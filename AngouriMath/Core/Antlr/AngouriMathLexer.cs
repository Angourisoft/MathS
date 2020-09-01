//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ./AngouriMath.g by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AngouriMath.Core.Antlr {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
internal partial class AngouriMathLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, NEWLINE=33, NUMBER=34, VARIABLE=35, COMMENT=36, WS=37;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "T__29", "T__30", "T__31", "NEWLINE", 
		"EXPONENT", "NUMBER", "VARIABLE", "COMMENT", "WS"
	};


	    // As the declaration order of static fields is the initialization order
	    // We will get null if we access the private static field _LiteralNames from static fields defined here
	    // So these are instance fields
	    public readonly CommonToken Multiply = new(Array.IndexOf(_LiteralNames, "'*'"), "*");
	    public readonly CommonToken Power = new(Array.IndexOf(_LiteralNames, "'^'"), "^");


	public AngouriMathLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public AngouriMathLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'!'", "'^'", "'-'", "'+'", "'*'", "'/'", "','", "'('", "')'", "'sin('", 
		"'cos('", "'log('", "'sqrt('", "'cbrt('", "'sqr('", "'ln('", "'tan('", 
		"'cotan('", "'sec('", "'cosec('", "'arcsin('", "'arccos('", "'arctan('", 
		"'arccotan('", "'arcsec('", "'arccosec('", "'gamma('", "'derivative('", 
		"'integral('", "'limit('", "'limitleft('", "'limitright('"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, "NEWLINE", "NUMBER", 
		"VARIABLE", "COMMENT", "WS"
	};
	internal static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "AngouriMath.g"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static AngouriMathLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\'', '\x16D', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', 
		'\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', 
		'\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', 
		'\x3', '\x16', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', 
		'\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x18', 
		'\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', 
		'\x3', '\x18', '\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', 
		'\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', 
		'\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', 
		'\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', 
		'\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', 
		'\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', 
		'\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', 
		'\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', 
		'\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', 
		'\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1E', 
		'\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', 
		'\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1F', 
		'\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', 
		'\x3', '\x1F', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', 
		' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', 
		' ', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', 
		'!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', 
		'!', '\x3', '\"', '\x5', '\"', '\x10E', '\n', '\"', '\x3', '\"', '\x3', 
		'\"', '\x3', '#', '\x3', '#', '\x5', '#', '\x114', '\n', '#', '\x3', '#', 
		'\x6', '#', '\x117', '\n', '#', '\r', '#', '\xE', '#', '\x118', '\x3', 
		'$', '\x6', '$', '\x11C', '\n', '$', '\r', '$', '\xE', '$', '\x11D', '\x3', 
		'$', '\x3', '$', '\a', '$', '\x122', '\n', '$', '\f', '$', '\xE', '$', 
		'\x125', '\v', '$', '\x3', '$', '\x5', '$', '\x128', '\n', '$', '\x3', 
		'$', '\x5', '$', '\x12B', '\n', '$', '\x3', '$', '\x5', '$', '\x12E', 
		'\n', '$', '\x3', '$', '\x6', '$', '\x131', '\n', '$', '\r', '$', '\xE', 
		'$', '\x132', '\x3', '$', '\x5', '$', '\x136', '\n', '$', '\x3', '$', 
		'\x5', '$', '\x139', '\n', '$', '\x3', '$', '\x5', '$', '\x13C', '\n', 
		'$', '\x3', '%', '\x6', '%', '\x13F', '\n', '%', '\r', '%', '\xE', '%', 
		'\x140', '\x3', '%', '\x3', '%', '\x6', '%', '\x145', '\n', '%', '\r', 
		'%', '\xE', '%', '\x146', '\x5', '%', '\x149', '\n', '%', '\x3', '&', 
		'\x3', '&', '\x3', '&', '\x3', '&', '\a', '&', '\x14F', '\n', '&', '\f', 
		'&', '\xE', '&', '\x152', '\v', '&', '\x3', '&', '\x5', '&', '\x155', 
		'\n', '&', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', '&', 
		'\a', '&', '\x15C', '\n', '&', '\f', '&', '\xE', '&', '\x15F', '\v', '&', 
		'\x3', '&', '\x3', '&', '\x5', '&', '\x163', '\n', '&', '\x3', '&', '\x3', 
		'&', '\x3', '\'', '\x6', '\'', '\x168', '\n', '\'', '\r', '\'', '\xE', 
		'\'', '\x169', '\x3', '\'', '\x3', '\'', '\x3', '\x15D', '\x2', '(', '\x3', 
		'\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', 
		'\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', 
		'\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', 
		'\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', 
		'/', '\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', '\x37', '\x1D', 
		'\x39', '\x1E', ';', '\x1F', '=', ' ', '?', '!', '\x41', '\"', '\x43', 
		'#', '\x45', '\x2', 'G', '$', 'I', '%', 'K', '&', 'M', '\'', '\x3', '\x2', 
		'\b', '\x4', '\x2', 'G', 'G', 'g', 'g', '\x4', '\x2', '-', '-', '/', '/', 
		'\x4', '\x2', '\x43', '\\', '\x63', '|', '\x5', '\x2', '\x32', ';', '\x43', 
		'\\', '\x63', '|', '\x4', '\x2', '\f', '\f', '\xF', '\xF', '\x4', '\x2', 
		'\v', '\v', '\"', '\"', '\x2', '\x180', '\x2', '\x3', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', 
		'\x3', '\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'+', '\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x39', '\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '=', '\x3', '\x2', '\x2', '\x2', '\x2', '?', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x41', '\x3', '\x2', '\x2', '\x2', '\x2', '\x43', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'G', '\x3', '\x2', '\x2', '\x2', '\x2', 'I', 
		'\x3', '\x2', '\x2', '\x2', '\x2', 'K', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'M', '\x3', '\x2', '\x2', '\x2', '\x3', 'O', '\x3', '\x2', '\x2', '\x2', 
		'\x5', 'Q', '\x3', '\x2', '\x2', '\x2', '\a', 'S', '\x3', '\x2', '\x2', 
		'\x2', '\t', 'U', '\x3', '\x2', '\x2', '\x2', '\v', 'W', '\x3', '\x2', 
		'\x2', '\x2', '\r', 'Y', '\x3', '\x2', '\x2', '\x2', '\xF', '[', '\x3', 
		'\x2', '\x2', '\x2', '\x11', ']', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'_', '\x3', '\x2', '\x2', '\x2', '\x15', '\x61', '\x3', '\x2', '\x2', 
		'\x2', '\x17', '\x66', '\x3', '\x2', '\x2', '\x2', '\x19', 'k', '\x3', 
		'\x2', '\x2', '\x2', '\x1B', 'p', '\x3', '\x2', '\x2', '\x2', '\x1D', 
		'v', '\x3', '\x2', '\x2', '\x2', '\x1F', '|', '\x3', '\x2', '\x2', '\x2', 
		'!', '\x81', '\x3', '\x2', '\x2', '\x2', '#', '\x85', '\x3', '\x2', '\x2', 
		'\x2', '%', '\x8A', '\x3', '\x2', '\x2', '\x2', '\'', '\x91', '\x3', '\x2', 
		'\x2', '\x2', ')', '\x96', '\x3', '\x2', '\x2', '\x2', '+', '\x9D', '\x3', 
		'\x2', '\x2', '\x2', '-', '\xA5', '\x3', '\x2', '\x2', '\x2', '/', '\xAD', 
		'\x3', '\x2', '\x2', '\x2', '\x31', '\xB5', '\x3', '\x2', '\x2', '\x2', 
		'\x33', '\xBF', '\x3', '\x2', '\x2', '\x2', '\x35', '\xC7', '\x3', '\x2', 
		'\x2', '\x2', '\x37', '\xD1', '\x3', '\x2', '\x2', '\x2', '\x39', '\xD8', 
		'\x3', '\x2', '\x2', '\x2', ';', '\xE4', '\x3', '\x2', '\x2', '\x2', '=', 
		'\xEE', '\x3', '\x2', '\x2', '\x2', '?', '\xF5', '\x3', '\x2', '\x2', 
		'\x2', '\x41', '\x100', '\x3', '\x2', '\x2', '\x2', '\x43', '\x10D', '\x3', 
		'\x2', '\x2', '\x2', '\x45', '\x111', '\x3', '\x2', '\x2', '\x2', 'G', 
		'\x13B', '\x3', '\x2', '\x2', '\x2', 'I', '\x13E', '\x3', '\x2', '\x2', 
		'\x2', 'K', '\x162', '\x3', '\x2', '\x2', '\x2', 'M', '\x167', '\x3', 
		'\x2', '\x2', '\x2', 'O', 'P', '\a', '#', '\x2', '\x2', 'P', '\x4', '\x3', 
		'\x2', '\x2', '\x2', 'Q', 'R', '\a', '`', '\x2', '\x2', 'R', '\x6', '\x3', 
		'\x2', '\x2', '\x2', 'S', 'T', '\a', '/', '\x2', '\x2', 'T', '\b', '\x3', 
		'\x2', '\x2', '\x2', 'U', 'V', '\a', '-', '\x2', '\x2', 'V', '\n', '\x3', 
		'\x2', '\x2', '\x2', 'W', 'X', '\a', ',', '\x2', '\x2', 'X', '\f', '\x3', 
		'\x2', '\x2', '\x2', 'Y', 'Z', '\a', '\x31', '\x2', '\x2', 'Z', '\xE', 
		'\x3', '\x2', '\x2', '\x2', '[', '\\', '\a', '.', '\x2', '\x2', '\\', 
		'\x10', '\x3', '\x2', '\x2', '\x2', ']', '^', '\a', '*', '\x2', '\x2', 
		'^', '\x12', '\x3', '\x2', '\x2', '\x2', '_', '`', '\a', '+', '\x2', '\x2', 
		'`', '\x14', '\x3', '\x2', '\x2', '\x2', '\x61', '\x62', '\a', 'u', '\x2', 
		'\x2', '\x62', '\x63', '\a', 'k', '\x2', '\x2', '\x63', '\x64', '\a', 
		'p', '\x2', '\x2', '\x64', '\x65', '\a', '*', '\x2', '\x2', '\x65', '\x16', 
		'\x3', '\x2', '\x2', '\x2', '\x66', 'g', '\a', '\x65', '\x2', '\x2', 'g', 
		'h', '\a', 'q', '\x2', '\x2', 'h', 'i', '\a', 'u', '\x2', '\x2', 'i', 
		'j', '\a', '*', '\x2', '\x2', 'j', '\x18', '\x3', '\x2', '\x2', '\x2', 
		'k', 'l', '\a', 'n', '\x2', '\x2', 'l', 'm', '\a', 'q', '\x2', '\x2', 
		'm', 'n', '\a', 'i', '\x2', '\x2', 'n', 'o', '\a', '*', '\x2', '\x2', 
		'o', '\x1A', '\x3', '\x2', '\x2', '\x2', 'p', 'q', '\a', 'u', '\x2', '\x2', 
		'q', 'r', '\a', 's', '\x2', '\x2', 'r', 's', '\a', 't', '\x2', '\x2', 
		's', 't', '\a', 'v', '\x2', '\x2', 't', 'u', '\a', '*', '\x2', '\x2', 
		'u', '\x1C', '\x3', '\x2', '\x2', '\x2', 'v', 'w', '\a', '\x65', '\x2', 
		'\x2', 'w', 'x', '\a', '\x64', '\x2', '\x2', 'x', 'y', '\a', 't', '\x2', 
		'\x2', 'y', 'z', '\a', 'v', '\x2', '\x2', 'z', '{', '\a', '*', '\x2', 
		'\x2', '{', '\x1E', '\x3', '\x2', '\x2', '\x2', '|', '}', '\a', 'u', '\x2', 
		'\x2', '}', '~', '\a', 's', '\x2', '\x2', '~', '\x7F', '\a', 't', '\x2', 
		'\x2', '\x7F', '\x80', '\a', '*', '\x2', '\x2', '\x80', ' ', '\x3', '\x2', 
		'\x2', '\x2', '\x81', '\x82', '\a', 'n', '\x2', '\x2', '\x82', '\x83', 
		'\a', 'p', '\x2', '\x2', '\x83', '\x84', '\a', '*', '\x2', '\x2', '\x84', 
		'\"', '\x3', '\x2', '\x2', '\x2', '\x85', '\x86', '\a', 'v', '\x2', '\x2', 
		'\x86', '\x87', '\a', '\x63', '\x2', '\x2', '\x87', '\x88', '\a', 'p', 
		'\x2', '\x2', '\x88', '\x89', '\a', '*', '\x2', '\x2', '\x89', '$', '\x3', 
		'\x2', '\x2', '\x2', '\x8A', '\x8B', '\a', '\x65', '\x2', '\x2', '\x8B', 
		'\x8C', '\a', 'q', '\x2', '\x2', '\x8C', '\x8D', '\a', 'v', '\x2', '\x2', 
		'\x8D', '\x8E', '\a', '\x63', '\x2', '\x2', '\x8E', '\x8F', '\a', 'p', 
		'\x2', '\x2', '\x8F', '\x90', '\a', '*', '\x2', '\x2', '\x90', '&', '\x3', 
		'\x2', '\x2', '\x2', '\x91', '\x92', '\a', 'u', '\x2', '\x2', '\x92', 
		'\x93', '\a', 'g', '\x2', '\x2', '\x93', '\x94', '\a', '\x65', '\x2', 
		'\x2', '\x94', '\x95', '\a', '*', '\x2', '\x2', '\x95', '(', '\x3', '\x2', 
		'\x2', '\x2', '\x96', '\x97', '\a', '\x65', '\x2', '\x2', '\x97', '\x98', 
		'\a', 'q', '\x2', '\x2', '\x98', '\x99', '\a', 'u', '\x2', '\x2', '\x99', 
		'\x9A', '\a', 'g', '\x2', '\x2', '\x9A', '\x9B', '\a', '\x65', '\x2', 
		'\x2', '\x9B', '\x9C', '\a', '*', '\x2', '\x2', '\x9C', '*', '\x3', '\x2', 
		'\x2', '\x2', '\x9D', '\x9E', '\a', '\x63', '\x2', '\x2', '\x9E', '\x9F', 
		'\a', 't', '\x2', '\x2', '\x9F', '\xA0', '\a', '\x65', '\x2', '\x2', '\xA0', 
		'\xA1', '\a', 'u', '\x2', '\x2', '\xA1', '\xA2', '\a', 'k', '\x2', '\x2', 
		'\xA2', '\xA3', '\a', 'p', '\x2', '\x2', '\xA3', '\xA4', '\a', '*', '\x2', 
		'\x2', '\xA4', ',', '\x3', '\x2', '\x2', '\x2', '\xA5', '\xA6', '\a', 
		'\x63', '\x2', '\x2', '\xA6', '\xA7', '\a', 't', '\x2', '\x2', '\xA7', 
		'\xA8', '\a', '\x65', '\x2', '\x2', '\xA8', '\xA9', '\a', '\x65', '\x2', 
		'\x2', '\xA9', '\xAA', '\a', 'q', '\x2', '\x2', '\xAA', '\xAB', '\a', 
		'u', '\x2', '\x2', '\xAB', '\xAC', '\a', '*', '\x2', '\x2', '\xAC', '.', 
		'\x3', '\x2', '\x2', '\x2', '\xAD', '\xAE', '\a', '\x63', '\x2', '\x2', 
		'\xAE', '\xAF', '\a', 't', '\x2', '\x2', '\xAF', '\xB0', '\a', '\x65', 
		'\x2', '\x2', '\xB0', '\xB1', '\a', 'v', '\x2', '\x2', '\xB1', '\xB2', 
		'\a', '\x63', '\x2', '\x2', '\xB2', '\xB3', '\a', 'p', '\x2', '\x2', '\xB3', 
		'\xB4', '\a', '*', '\x2', '\x2', '\xB4', '\x30', '\x3', '\x2', '\x2', 
		'\x2', '\xB5', '\xB6', '\a', '\x63', '\x2', '\x2', '\xB6', '\xB7', '\a', 
		't', '\x2', '\x2', '\xB7', '\xB8', '\a', '\x65', '\x2', '\x2', '\xB8', 
		'\xB9', '\a', '\x65', '\x2', '\x2', '\xB9', '\xBA', '\a', 'q', '\x2', 
		'\x2', '\xBA', '\xBB', '\a', 'v', '\x2', '\x2', '\xBB', '\xBC', '\a', 
		'\x63', '\x2', '\x2', '\xBC', '\xBD', '\a', 'p', '\x2', '\x2', '\xBD', 
		'\xBE', '\a', '*', '\x2', '\x2', '\xBE', '\x32', '\x3', '\x2', '\x2', 
		'\x2', '\xBF', '\xC0', '\a', '\x63', '\x2', '\x2', '\xC0', '\xC1', '\a', 
		't', '\x2', '\x2', '\xC1', '\xC2', '\a', '\x65', '\x2', '\x2', '\xC2', 
		'\xC3', '\a', 'u', '\x2', '\x2', '\xC3', '\xC4', '\a', 'g', '\x2', '\x2', 
		'\xC4', '\xC5', '\a', '\x65', '\x2', '\x2', '\xC5', '\xC6', '\a', '*', 
		'\x2', '\x2', '\xC6', '\x34', '\x3', '\x2', '\x2', '\x2', '\xC7', '\xC8', 
		'\a', '\x63', '\x2', '\x2', '\xC8', '\xC9', '\a', 't', '\x2', '\x2', '\xC9', 
		'\xCA', '\a', '\x65', '\x2', '\x2', '\xCA', '\xCB', '\a', '\x65', '\x2', 
		'\x2', '\xCB', '\xCC', '\a', 'q', '\x2', '\x2', '\xCC', '\xCD', '\a', 
		'u', '\x2', '\x2', '\xCD', '\xCE', '\a', 'g', '\x2', '\x2', '\xCE', '\xCF', 
		'\a', '\x65', '\x2', '\x2', '\xCF', '\xD0', '\a', '*', '\x2', '\x2', '\xD0', 
		'\x36', '\x3', '\x2', '\x2', '\x2', '\xD1', '\xD2', '\a', 'i', '\x2', 
		'\x2', '\xD2', '\xD3', '\a', '\x63', '\x2', '\x2', '\xD3', '\xD4', '\a', 
		'o', '\x2', '\x2', '\xD4', '\xD5', '\a', 'o', '\x2', '\x2', '\xD5', '\xD6', 
		'\a', '\x63', '\x2', '\x2', '\xD6', '\xD7', '\a', '*', '\x2', '\x2', '\xD7', 
		'\x38', '\x3', '\x2', '\x2', '\x2', '\xD8', '\xD9', '\a', '\x66', '\x2', 
		'\x2', '\xD9', '\xDA', '\a', 'g', '\x2', '\x2', '\xDA', '\xDB', '\a', 
		't', '\x2', '\x2', '\xDB', '\xDC', '\a', 'k', '\x2', '\x2', '\xDC', '\xDD', 
		'\a', 'x', '\x2', '\x2', '\xDD', '\xDE', '\a', '\x63', '\x2', '\x2', '\xDE', 
		'\xDF', '\a', 'v', '\x2', '\x2', '\xDF', '\xE0', '\a', 'k', '\x2', '\x2', 
		'\xE0', '\xE1', '\a', 'x', '\x2', '\x2', '\xE1', '\xE2', '\a', 'g', '\x2', 
		'\x2', '\xE2', '\xE3', '\a', '*', '\x2', '\x2', '\xE3', ':', '\x3', '\x2', 
		'\x2', '\x2', '\xE4', '\xE5', '\a', 'k', '\x2', '\x2', '\xE5', '\xE6', 
		'\a', 'p', '\x2', '\x2', '\xE6', '\xE7', '\a', 'v', '\x2', '\x2', '\xE7', 
		'\xE8', '\a', 'g', '\x2', '\x2', '\xE8', '\xE9', '\a', 'i', '\x2', '\x2', 
		'\xE9', '\xEA', '\a', 't', '\x2', '\x2', '\xEA', '\xEB', '\a', '\x63', 
		'\x2', '\x2', '\xEB', '\xEC', '\a', 'n', '\x2', '\x2', '\xEC', '\xED', 
		'\a', '*', '\x2', '\x2', '\xED', '<', '\x3', '\x2', '\x2', '\x2', '\xEE', 
		'\xEF', '\a', 'n', '\x2', '\x2', '\xEF', '\xF0', '\a', 'k', '\x2', '\x2', 
		'\xF0', '\xF1', '\a', 'o', '\x2', '\x2', '\xF1', '\xF2', '\a', 'k', '\x2', 
		'\x2', '\xF2', '\xF3', '\a', 'v', '\x2', '\x2', '\xF3', '\xF4', '\a', 
		'*', '\x2', '\x2', '\xF4', '>', '\x3', '\x2', '\x2', '\x2', '\xF5', '\xF6', 
		'\a', 'n', '\x2', '\x2', '\xF6', '\xF7', '\a', 'k', '\x2', '\x2', '\xF7', 
		'\xF8', '\a', 'o', '\x2', '\x2', '\xF8', '\xF9', '\a', 'k', '\x2', '\x2', 
		'\xF9', '\xFA', '\a', 'v', '\x2', '\x2', '\xFA', '\xFB', '\a', 'n', '\x2', 
		'\x2', '\xFB', '\xFC', '\a', 'g', '\x2', '\x2', '\xFC', '\xFD', '\a', 
		'h', '\x2', '\x2', '\xFD', '\xFE', '\a', 'v', '\x2', '\x2', '\xFE', '\xFF', 
		'\a', '*', '\x2', '\x2', '\xFF', '@', '\x3', '\x2', '\x2', '\x2', '\x100', 
		'\x101', '\a', 'n', '\x2', '\x2', '\x101', '\x102', '\a', 'k', '\x2', 
		'\x2', '\x102', '\x103', '\a', 'o', '\x2', '\x2', '\x103', '\x104', '\a', 
		'k', '\x2', '\x2', '\x104', '\x105', '\a', 'v', '\x2', '\x2', '\x105', 
		'\x106', '\a', 't', '\x2', '\x2', '\x106', '\x107', '\a', 'k', '\x2', 
		'\x2', '\x107', '\x108', '\a', 'i', '\x2', '\x2', '\x108', '\x109', '\a', 
		'j', '\x2', '\x2', '\x109', '\x10A', '\a', 'v', '\x2', '\x2', '\x10A', 
		'\x10B', '\a', '*', '\x2', '\x2', '\x10B', '\x42', '\x3', '\x2', '\x2', 
		'\x2', '\x10C', '\x10E', '\a', '\xF', '\x2', '\x2', '\x10D', '\x10C', 
		'\x3', '\x2', '\x2', '\x2', '\x10D', '\x10E', '\x3', '\x2', '\x2', '\x2', 
		'\x10E', '\x10F', '\x3', '\x2', '\x2', '\x2', '\x10F', '\x110', '\a', 
		'\f', '\x2', '\x2', '\x110', '\x44', '\x3', '\x2', '\x2', '\x2', '\x111', 
		'\x113', '\t', '\x2', '\x2', '\x2', '\x112', '\x114', '\t', '\x3', '\x2', 
		'\x2', '\x113', '\x112', '\x3', '\x2', '\x2', '\x2', '\x113', '\x114', 
		'\x3', '\x2', '\x2', '\x2', '\x114', '\x116', '\x3', '\x2', '\x2', '\x2', 
		'\x115', '\x117', '\x4', '\x32', ';', '\x2', '\x116', '\x115', '\x3', 
		'\x2', '\x2', '\x2', '\x117', '\x118', '\x3', '\x2', '\x2', '\x2', '\x118', 
		'\x116', '\x3', '\x2', '\x2', '\x2', '\x118', '\x119', '\x3', '\x2', '\x2', 
		'\x2', '\x119', '\x46', '\x3', '\x2', '\x2', '\x2', '\x11A', '\x11C', 
		'\x4', '\x32', ';', '\x2', '\x11B', '\x11A', '\x3', '\x2', '\x2', '\x2', 
		'\x11C', '\x11D', '\x3', '\x2', '\x2', '\x2', '\x11D', '\x11B', '\x3', 
		'\x2', '\x2', '\x2', '\x11D', '\x11E', '\x3', '\x2', '\x2', '\x2', '\x11E', 
		'\x11F', '\x3', '\x2', '\x2', '\x2', '\x11F', '\x123', '\a', '\x30', '\x2', 
		'\x2', '\x120', '\x122', '\x4', '\x32', ';', '\x2', '\x121', '\x120', 
		'\x3', '\x2', '\x2', '\x2', '\x122', '\x125', '\x3', '\x2', '\x2', '\x2', 
		'\x123', '\x121', '\x3', '\x2', '\x2', '\x2', '\x123', '\x124', '\x3', 
		'\x2', '\x2', '\x2', '\x124', '\x127', '\x3', '\x2', '\x2', '\x2', '\x125', 
		'\x123', '\x3', '\x2', '\x2', '\x2', '\x126', '\x128', '\x5', '\x45', 
		'#', '\x2', '\x127', '\x126', '\x3', '\x2', '\x2', '\x2', '\x127', '\x128', 
		'\x3', '\x2', '\x2', '\x2', '\x128', '\x12A', '\x3', '\x2', '\x2', '\x2', 
		'\x129', '\x12B', '\a', 'k', '\x2', '\x2', '\x12A', '\x129', '\x3', '\x2', 
		'\x2', '\x2', '\x12A', '\x12B', '\x3', '\x2', '\x2', '\x2', '\x12B', '\x13C', 
		'\x3', '\x2', '\x2', '\x2', '\x12C', '\x12E', '\a', '\x30', '\x2', '\x2', 
		'\x12D', '\x12C', '\x3', '\x2', '\x2', '\x2', '\x12D', '\x12E', '\x3', 
		'\x2', '\x2', '\x2', '\x12E', '\x130', '\x3', '\x2', '\x2', '\x2', '\x12F', 
		'\x131', '\x4', '\x32', ';', '\x2', '\x130', '\x12F', '\x3', '\x2', '\x2', 
		'\x2', '\x131', '\x132', '\x3', '\x2', '\x2', '\x2', '\x132', '\x130', 
		'\x3', '\x2', '\x2', '\x2', '\x132', '\x133', '\x3', '\x2', '\x2', '\x2', 
		'\x133', '\x135', '\x3', '\x2', '\x2', '\x2', '\x134', '\x136', '\x5', 
		'\x45', '#', '\x2', '\x135', '\x134', '\x3', '\x2', '\x2', '\x2', '\x135', 
		'\x136', '\x3', '\x2', '\x2', '\x2', '\x136', '\x138', '\x3', '\x2', '\x2', 
		'\x2', '\x137', '\x139', '\a', 'k', '\x2', '\x2', '\x138', '\x137', '\x3', 
		'\x2', '\x2', '\x2', '\x138', '\x139', '\x3', '\x2', '\x2', '\x2', '\x139', 
		'\x13C', '\x3', '\x2', '\x2', '\x2', '\x13A', '\x13C', '\a', 'k', '\x2', 
		'\x2', '\x13B', '\x11B', '\x3', '\x2', '\x2', '\x2', '\x13B', '\x12D', 
		'\x3', '\x2', '\x2', '\x2', '\x13B', '\x13A', '\x3', '\x2', '\x2', '\x2', 
		'\x13C', 'H', '\x3', '\x2', '\x2', '\x2', '\x13D', '\x13F', '\t', '\x4', 
		'\x2', '\x2', '\x13E', '\x13D', '\x3', '\x2', '\x2', '\x2', '\x13F', '\x140', 
		'\x3', '\x2', '\x2', '\x2', '\x140', '\x13E', '\x3', '\x2', '\x2', '\x2', 
		'\x140', '\x141', '\x3', '\x2', '\x2', '\x2', '\x141', '\x148', '\x3', 
		'\x2', '\x2', '\x2', '\x142', '\x144', '\a', '\x61', '\x2', '\x2', '\x143', 
		'\x145', '\t', '\x5', '\x2', '\x2', '\x144', '\x143', '\x3', '\x2', '\x2', 
		'\x2', '\x145', '\x146', '\x3', '\x2', '\x2', '\x2', '\x146', '\x144', 
		'\x3', '\x2', '\x2', '\x2', '\x146', '\x147', '\x3', '\x2', '\x2', '\x2', 
		'\x147', '\x149', '\x3', '\x2', '\x2', '\x2', '\x148', '\x142', '\x3', 
		'\x2', '\x2', '\x2', '\x148', '\x149', '\x3', '\x2', '\x2', '\x2', '\x149', 
		'J', '\x3', '\x2', '\x2', '\x2', '\x14A', '\x14B', '\a', '\x31', '\x2', 
		'\x2', '\x14B', '\x14C', '\a', '\x31', '\x2', '\x2', '\x14C', '\x150', 
		'\x3', '\x2', '\x2', '\x2', '\x14D', '\x14F', '\n', '\x6', '\x2', '\x2', 
		'\x14E', '\x14D', '\x3', '\x2', '\x2', '\x2', '\x14F', '\x152', '\x3', 
		'\x2', '\x2', '\x2', '\x150', '\x14E', '\x3', '\x2', '\x2', '\x2', '\x150', 
		'\x151', '\x3', '\x2', '\x2', '\x2', '\x151', '\x154', '\x3', '\x2', '\x2', 
		'\x2', '\x152', '\x150', '\x3', '\x2', '\x2', '\x2', '\x153', '\x155', 
		'\a', '\xF', '\x2', '\x2', '\x154', '\x153', '\x3', '\x2', '\x2', '\x2', 
		'\x154', '\x155', '\x3', '\x2', '\x2', '\x2', '\x155', '\x156', '\x3', 
		'\x2', '\x2', '\x2', '\x156', '\x163', '\a', '\f', '\x2', '\x2', '\x157', 
		'\x158', '\a', '\x31', '\x2', '\x2', '\x158', '\x159', '\a', ',', '\x2', 
		'\x2', '\x159', '\x15D', '\x3', '\x2', '\x2', '\x2', '\x15A', '\x15C', 
		'\v', '\x2', '\x2', '\x2', '\x15B', '\x15A', '\x3', '\x2', '\x2', '\x2', 
		'\x15C', '\x15F', '\x3', '\x2', '\x2', '\x2', '\x15D', '\x15E', '\x3', 
		'\x2', '\x2', '\x2', '\x15D', '\x15B', '\x3', '\x2', '\x2', '\x2', '\x15E', 
		'\x160', '\x3', '\x2', '\x2', '\x2', '\x15F', '\x15D', '\x3', '\x2', '\x2', 
		'\x2', '\x160', '\x161', '\a', ',', '\x2', '\x2', '\x161', '\x163', '\a', 
		'\x31', '\x2', '\x2', '\x162', '\x14A', '\x3', '\x2', '\x2', '\x2', '\x162', 
		'\x157', '\x3', '\x2', '\x2', '\x2', '\x163', '\x164', '\x3', '\x2', '\x2', 
		'\x2', '\x164', '\x165', '\b', '&', '\x2', '\x2', '\x165', 'L', '\x3', 
		'\x2', '\x2', '\x2', '\x166', '\x168', '\t', '\a', '\x2', '\x2', '\x167', 
		'\x166', '\x3', '\x2', '\x2', '\x2', '\x168', '\x169', '\x3', '\x2', '\x2', 
		'\x2', '\x169', '\x167', '\x3', '\x2', '\x2', '\x2', '\x169', '\x16A', 
		'\x3', '\x2', '\x2', '\x2', '\x16A', '\x16B', '\x3', '\x2', '\x2', '\x2', 
		'\x16B', '\x16C', '\b', '\'', '\x2', '\x2', '\x16C', 'N', '\x3', '\x2', 
		'\x2', '\x2', '\x17', '\x2', '\x10D', '\x113', '\x118', '\x11D', '\x123', 
		'\x127', '\x12A', '\x12D', '\x132', '\x135', '\x138', '\x13B', '\x140', 
		'\x146', '\x148', '\x150', '\x154', '\x15D', '\x162', '\x169', '\x3', 
		'\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace AngouriMath.Core.Antlr
