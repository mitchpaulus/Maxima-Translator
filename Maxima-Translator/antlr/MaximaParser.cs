//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.11.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Maxima.g4 by ANTLR 4.11.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
[System.CLSCompliant(false)]
public partial class MaximaParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		EXP=1, MATRIX=2, IDENTIFIER=3, INTEGER=4, LPAREN=5, RPAREN=6, LBRACKET=7, 
		RBRACKET=8, COMMA=9, CARET=10, PLUS=11, MINUS=12, TIMES=13, DIVIDE=14, 
		WS=15;
	public const int
		RULE_matrix = 0, RULE_matrix_rows = 1, RULE_list = 2, RULE_expression = 3;
	public static readonly string[] ruleNames = {
		"matrix", "matrix_rows", "list", "expression"
	};

	private static readonly string[] _LiteralNames = {
		null, "'%e^'", "'matrix'", null, null, "'('", "')'", "'['", "']'", "','", 
		"'^'", "'+'", "'-'", "'*'", "'/'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "EXP", "MATRIX", "IDENTIFIER", "INTEGER", "LPAREN", "RPAREN", "LBRACKET", 
		"RBRACKET", "COMMA", "CARET", "PLUS", "MINUS", "TIMES", "DIVIDE", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Maxima.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static MaximaParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public MaximaParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public MaximaParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class MatrixContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MATRIX() { return GetToken(MaximaParser.MATRIX, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(MaximaParser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Matrix_rowsContext matrix_rows() {
			return GetRuleContext<Matrix_rowsContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(MaximaParser.RPAREN, 0); }
		public MatrixContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_matrix; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.EnterMatrix(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.ExitMatrix(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMaximaVisitor<TResult> typedVisitor = visitor as IMaximaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMatrix(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MatrixContext matrix() {
		MatrixContext _localctx = new MatrixContext(Context, State);
		EnterRule(_localctx, 0, RULE_matrix);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 8;
			Match(MATRIX);
			State = 9;
			Match(LPAREN);
			State = 10;
			matrix_rows();
			State = 11;
			Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Matrix_rowsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ListContext[] list() {
			return GetRuleContexts<ListContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ListContext list(int i) {
			return GetRuleContext<ListContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(MaximaParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(MaximaParser.COMMA, i);
		}
		public Matrix_rowsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_matrix_rows; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.EnterMatrix_rows(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.ExitMatrix_rows(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMaximaVisitor<TResult> typedVisitor = visitor as IMaximaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMatrix_rows(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Matrix_rowsContext matrix_rows() {
		Matrix_rowsContext _localctx = new Matrix_rowsContext(Context, State);
		EnterRule(_localctx, 2, RULE_matrix_rows);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 13;
			list();
			State = 18;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 14;
				Match(COMMA);
				State = 15;
				list();
				}
				}
				State = 20;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ListContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LBRACKET() { return GetToken(MaximaParser.LBRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RBRACKET() { return GetToken(MaximaParser.RBRACKET, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(MaximaParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(MaximaParser.COMMA, i);
		}
		public ListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_list; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.EnterList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.ExitList(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMaximaVisitor<TResult> typedVisitor = visitor as IMaximaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitList(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ListContext list() {
		ListContext _localctx = new ListContext(Context, State);
		EnterRule(_localctx, 4, RULE_list);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 21;
			Match(LBRACKET);
			State = 22;
			expression(0);
			State = 27;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 23;
				Match(COMMA);
				State = 24;
				expression(0);
				}
				}
				State = 29;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 30;
			Match(RBRACKET);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
	 
		public ExpressionContext() { }
		public virtual void CopyFrom(ExpressionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class IdentifierExpContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER() { return GetToken(MaximaParser.IDENTIFIER, 0); }
		public IdentifierExpContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.EnterIdentifierExp(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.ExitIdentifierExp(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMaximaVisitor<TResult> typedVisitor = visitor as IMaximaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIdentifierExp(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IntegerExpContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INTEGER() { return GetToken(MaximaParser.INTEGER, 0); }
		public IntegerExpContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.EnterIntegerExp(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.ExitIntegerExp(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMaximaVisitor<TResult> typedVisitor = visitor as IMaximaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIntegerExp(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ParenExpContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(MaximaParser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(MaximaParser.RPAREN, 0); }
		public ParenExpContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.EnterParenExp(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.ExitParenExp(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMaximaVisitor<TResult> typedVisitor = visitor as IMaximaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParenExp(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class UnaryExpContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MINUS() { return GetToken(MaximaParser.MINUS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public UnaryExpContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.EnterUnaryExp(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.ExitUnaryExp(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMaximaVisitor<TResult> typedVisitor = visitor as IMaximaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUnaryExp(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ExpExpContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EXP() { return GetToken(MaximaParser.EXP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(MaximaParser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(MaximaParser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MINUS() { return GetToken(MaximaParser.MINUS, 0); }
		public ExpExpContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.EnterExpExp(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.ExitExpExp(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMaximaVisitor<TResult> typedVisitor = visitor as IMaximaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExpExp(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class MatrixExpContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public MatrixContext matrix() {
			return GetRuleContext<MatrixContext>(0);
		}
		public MatrixExpContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.EnterMatrixExp(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.ExitMatrixExp(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMaximaVisitor<TResult> typedVisitor = visitor as IMaximaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMatrixExp(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class PowerExpContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CARET() { return GetToken(MaximaParser.CARET, 0); }
		public PowerExpContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.EnterPowerExp(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.ExitPowerExp(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMaximaVisitor<TResult> typedVisitor = visitor as IMaximaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPowerExp(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class BinaryExpContext : ExpressionContext {
		public IToken op;
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MINUS() { return GetToken(MaximaParser.MINUS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PLUS() { return GetToken(MaximaParser.PLUS, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TIMES() { return GetToken(MaximaParser.TIMES, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIVIDE() { return GetToken(MaximaParser.DIVIDE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CARET() { return GetToken(MaximaParser.CARET, 0); }
		public BinaryExpContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.EnterBinaryExp(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.ExitBinaryExp(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMaximaVisitor<TResult> typedVisitor = visitor as IMaximaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBinaryExp(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ListExpContext : ExpressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ListContext list() {
			return GetRuleContext<ListContext>(0);
		}
		public ListExpContext(ExpressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.EnterListExp(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMaximaListener typedListener = listener as IMaximaListener;
			if (typedListener != null) typedListener.ExitListExp(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMaximaVisitor<TResult> typedVisitor = visitor as IMaximaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitListExp(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		return expression(0);
	}

	private ExpressionContext expression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExpressionContext _localctx = new ExpressionContext(Context, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 6;
		EnterRecursionRule(_localctx, 6, RULE_expression, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 51;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case EXP:
				{
				_localctx = new ExpExpContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 33;
				Match(EXP);
				State = 35;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==MINUS) {
					{
					State = 34;
					Match(MINUS);
					}
				}

				State = 37;
				Match(LPAREN);
				State = 38;
				expression(0);
				State = 39;
				Match(RPAREN);
				}
				break;
			case MINUS:
				{
				_localctx = new UnaryExpContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 41;
				Match(MINUS);
				State = 42;
				expression(6);
				}
				break;
			case LPAREN:
				{
				_localctx = new ParenExpContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 43;
				Match(LPAREN);
				State = 44;
				expression(0);
				State = 45;
				Match(RPAREN);
				}
				break;
			case INTEGER:
				{
				_localctx = new IntegerExpContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 47;
				Match(INTEGER);
				}
				break;
			case IDENTIFIER:
				{
				_localctx = new IdentifierExpContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 48;
				Match(IDENTIFIER);
				}
				break;
			case MATRIX:
				{
				_localctx = new MatrixExpContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 49;
				matrix();
				}
				break;
			case LBRACKET:
				{
				_localctx = new ListExpContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 50;
				list();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 61;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,5,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 59;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,4,Context) ) {
					case 1:
						{
						_localctx = new PowerExpContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 53;
						if (!(Precpred(Context, 9))) throw new FailedPredicateException(this, "Precpred(Context, 9)");
						State = 54;
						Match(CARET);
						State = 55;
						expression(10);
						}
						break;
					case 2:
						{
						_localctx = new BinaryExpContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 56;
						if (!(Precpred(Context, 8))) throw new FailedPredicateException(this, "Precpred(Context, 8)");
						State = 57;
						((BinaryExpContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(((_la) & ~0x3f) == 0 && ((1L << _la) & 31744L) != 0) ) {
							((BinaryExpContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 58;
						expression(9);
						}
						break;
					}
					} 
				}
				State = 63;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,5,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 3: return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 9);
		case 1: return Precpred(Context, 8);
		}
		return true;
	}

	private static int[] _serializedATN = {
		4,1,15,65,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,1,0,1,0,1,0,1,0,1,0,1,1,1,1,
		1,1,5,1,17,8,1,10,1,12,1,20,9,1,1,2,1,2,1,2,1,2,5,2,26,8,2,10,2,12,2,29,
		9,2,1,2,1,2,1,3,1,3,1,3,3,3,36,8,3,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,3,
		1,3,1,3,1,3,1,3,1,3,3,3,52,8,3,1,3,1,3,1,3,1,3,1,3,1,3,5,3,60,8,3,10,3,
		12,3,63,9,3,1,3,0,1,6,4,0,2,4,6,0,1,1,0,10,14,71,0,8,1,0,0,0,2,13,1,0,
		0,0,4,21,1,0,0,0,6,51,1,0,0,0,8,9,5,2,0,0,9,10,5,5,0,0,10,11,3,2,1,0,11,
		12,5,6,0,0,12,1,1,0,0,0,13,18,3,4,2,0,14,15,5,9,0,0,15,17,3,4,2,0,16,14,
		1,0,0,0,17,20,1,0,0,0,18,16,1,0,0,0,18,19,1,0,0,0,19,3,1,0,0,0,20,18,1,
		0,0,0,21,22,5,7,0,0,22,27,3,6,3,0,23,24,5,9,0,0,24,26,3,6,3,0,25,23,1,
		0,0,0,26,29,1,0,0,0,27,25,1,0,0,0,27,28,1,0,0,0,28,30,1,0,0,0,29,27,1,
		0,0,0,30,31,5,8,0,0,31,5,1,0,0,0,32,33,6,3,-1,0,33,35,5,1,0,0,34,36,5,
		12,0,0,35,34,1,0,0,0,35,36,1,0,0,0,36,37,1,0,0,0,37,38,5,5,0,0,38,39,3,
		6,3,0,39,40,5,6,0,0,40,52,1,0,0,0,41,42,5,12,0,0,42,52,3,6,3,6,43,44,5,
		5,0,0,44,45,3,6,3,0,45,46,5,6,0,0,46,52,1,0,0,0,47,52,5,4,0,0,48,52,5,
		3,0,0,49,52,3,0,0,0,50,52,3,4,2,0,51,32,1,0,0,0,51,41,1,0,0,0,51,43,1,
		0,0,0,51,47,1,0,0,0,51,48,1,0,0,0,51,49,1,0,0,0,51,50,1,0,0,0,52,61,1,
		0,0,0,53,54,10,9,0,0,54,55,5,10,0,0,55,60,3,6,3,10,56,57,10,8,0,0,57,58,
		7,0,0,0,58,60,3,6,3,9,59,53,1,0,0,0,59,56,1,0,0,0,60,63,1,0,0,0,61,59,
		1,0,0,0,61,62,1,0,0,0,62,7,1,0,0,0,63,61,1,0,0,0,6,18,27,35,51,59,61
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
