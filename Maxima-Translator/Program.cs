// See https://aka.ms/new-console-template for more information

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

public class Program
{
    public static void Main(string[] argv)
    {
        int i = 0;
        while (i < argv.Length)
        {
            if (argv[i] is "-h" or "--help")
            {
                Console.Write("Maxima-Translator\n");
                Console.Write("USAGE:\n");
                Console.Write("Maxima-Translator\n");
                Console.Write("\n");
                Console.Write("Currently reads a Maxima expression from stdin, and returns xlim formatted version.\n");
                return;
            }

            i++;
        }
        
        // Read from stdin
        var input = Console.In.ReadToEnd();

        // Parse
        AntlrInputStream inputStream = new AntlrInputStream(input);
        MaximaLexer lexer = new MaximaLexer(inputStream);
        CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
        MaximaParser parser = new MaximaParser(commonTokenStream);
        IParseTree tree = parser.expression();

        // Visit
        var visitor = new XlimVisitor();
        var result = visitor.Visit(tree);

        // Write to stdout
        Console.Write(result);
    }
}



public class XlimVisitor : MaximaBaseVisitor<string>
{
    public override string VisitBinaryExp(MaximaParser.BinaryExpContext context) => $"{Visit(context.expression(0))} {context.op.Text} {Visit(context.expression(1))}";

    public override string VisitExpExp(MaximaParser.ExpExpContext context)
    {
        return context.MINUS() is not null 
            ? $"exp: -({Visit(context.expression())});" 
            : $"exp: {Visit(context.expression())};";
    } 

    public override string VisitUnaryExp(MaximaParser.UnaryExpContext context) => $"-{Visit(context.expression())}";

    // public override string VisitMatrix_row(MaximaParser.Matrix_rowContext context) => string.Join(", ", context.expression().Select(Visit)) + "\n";
    public override string VisitList(MaximaParser.ListContext context) => string.Join(", ", context.expression().Select(Visit)) + "\n";

    public override string VisitMatrix(MaximaParser.MatrixContext context) => "[[\n" + string.Join(string.Empty, context.matrix_rows().list().Select(Visit)) + "]]\n";

    public override string VisitTerminal(ITerminalNode node) => node.GetText();
    public override string VisitPowerExp(MaximaParser.PowerExpContext context) => $"{Visit(context.expression(0))}{context.CARET().GetText()}{Visit(context.expression(1))}";

    public override string VisitParenExp(MaximaParser.ParenExpContext context) => $"({Visit(context.expression())})";

    protected override string AggregateResult(string aggregate, string nextResult)
    {
        if (string.IsNullOrEmpty(aggregate) && string.IsNullOrEmpty(nextResult)) return string.Empty;
        if (string.IsNullOrEmpty(aggregate)) return nextResult;
        return aggregate.EndsWith('\n') ? $"{aggregate}{nextResult}" : $"{aggregate} {nextResult}";
    }

}
