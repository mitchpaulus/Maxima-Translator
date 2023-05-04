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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
[System.CLSCompliant(false)]
public partial class MaximaLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		EXP=1, MATRIX=2, IDENTIFIER=3, INTEGER=4, LPAREN=5, RPAREN=6, LBRACKET=7, 
		RBRACKET=8, COMMA=9, CARET=10, PLUS=11, MINUS=12, TIMES=13, DIVIDE=14, 
		WS=15;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"EXP", "MATRIX", "IDENTIFIER", "INTEGER", "LPAREN", "RPAREN", "LBRACKET", 
		"RBRACKET", "COMMA", "CARET", "PLUS", "MINUS", "TIMES", "DIVIDE", "WS"
	};


	public MaximaLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public MaximaLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

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

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static MaximaLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,15,81,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,
		2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,7,
		14,1,0,1,0,1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,1,2,5,2,45,8,2,10,2,
		12,2,48,9,2,1,3,4,3,51,8,3,11,3,12,3,52,1,4,1,4,1,5,1,5,1,6,1,6,1,7,1,
		7,1,8,1,8,1,9,1,9,1,10,1,10,1,11,1,11,1,12,1,12,1,13,1,13,1,14,4,14,76,
		8,14,11,14,12,14,77,1,14,1,14,0,0,15,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,
		8,17,9,19,10,21,11,23,12,25,13,27,14,29,15,1,0,4,3,0,65,90,95,95,97,122,
		4,0,48,57,65,90,95,95,97,122,1,0,48,57,3,0,9,10,13,13,32,32,83,0,1,1,0,
		0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,
		1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,
		0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,1,31,1,0,0,0,3,35,1,0,0,0,5,42,
		1,0,0,0,7,50,1,0,0,0,9,54,1,0,0,0,11,56,1,0,0,0,13,58,1,0,0,0,15,60,1,
		0,0,0,17,62,1,0,0,0,19,64,1,0,0,0,21,66,1,0,0,0,23,68,1,0,0,0,25,70,1,
		0,0,0,27,72,1,0,0,0,29,75,1,0,0,0,31,32,5,37,0,0,32,33,5,101,0,0,33,34,
		5,94,0,0,34,2,1,0,0,0,35,36,5,109,0,0,36,37,5,97,0,0,37,38,5,116,0,0,38,
		39,5,114,0,0,39,40,5,105,0,0,40,41,5,120,0,0,41,4,1,0,0,0,42,46,7,0,0,
		0,43,45,7,1,0,0,44,43,1,0,0,0,45,48,1,0,0,0,46,44,1,0,0,0,46,47,1,0,0,
		0,47,6,1,0,0,0,48,46,1,0,0,0,49,51,7,2,0,0,50,49,1,0,0,0,51,52,1,0,0,0,
		52,50,1,0,0,0,52,53,1,0,0,0,53,8,1,0,0,0,54,55,5,40,0,0,55,10,1,0,0,0,
		56,57,5,41,0,0,57,12,1,0,0,0,58,59,5,91,0,0,59,14,1,0,0,0,60,61,5,93,0,
		0,61,16,1,0,0,0,62,63,5,44,0,0,63,18,1,0,0,0,64,65,5,94,0,0,65,20,1,0,
		0,0,66,67,5,43,0,0,67,22,1,0,0,0,68,69,5,45,0,0,69,24,1,0,0,0,70,71,5,
		42,0,0,71,26,1,0,0,0,72,73,5,47,0,0,73,28,1,0,0,0,74,76,7,3,0,0,75,74,
		1,0,0,0,76,77,1,0,0,0,77,75,1,0,0,0,77,78,1,0,0,0,78,79,1,0,0,0,79,80,
		6,14,0,0,80,30,1,0,0,0,4,0,46,52,77,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}