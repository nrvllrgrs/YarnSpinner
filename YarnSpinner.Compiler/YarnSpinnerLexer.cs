//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/desplesda/Work/YarnSpinner/YarnSpinner.Compiler/YarnSpinnerLexer.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Yarn.Compiler {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public partial class YarnSpinnerLexer : IndentAwareLexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		INDENT=1, DEDENT=2, BLANK_LINE_FOLLOWING_OPTION=3, WS=4, COMMENT=5, NEWLINE=6, 
		ID=7, BODY_START=8, HEADER_DELIMITER=9, HASHTAG=10, REST_OF_LINE=11, BODY_WS=12, 
		BODY_END=13, SHORTCUT_ARROW=14, LINE_GROUP_ARROW=15, COMMAND_START=16, 
		EXPRESSION_START=17, ESCAPED_ANY=18, TEXT_ESCAPE=19, TEXT_COMMENT=20, 
		TEXT=21, UNESCAPABLE_CHARACTER=22, TEXT_COMMANDHASHTAG_WS=23, TEXT_COMMANDHASHTAG_COMMENT=24, 
		TEXT_COMMANDHASHTAG_ERROR=25, HASHTAG_WS=26, HASHTAG_TEXT=27, EXPR_WS=28, 
		KEYWORD_TRUE=29, KEYWORD_FALSE=30, KEYWORD_NULL=31, OPERATOR_ASSIGNMENT=32, 
		OPERATOR_LOGICAL_LESS_THAN_EQUALS=33, OPERATOR_LOGICAL_GREATER_THAN_EQUALS=34, 
		OPERATOR_LOGICAL_EQUALS=35, OPERATOR_LOGICAL_LESS=36, OPERATOR_LOGICAL_GREATER=37, 
		OPERATOR_LOGICAL_NOT_EQUALS=38, OPERATOR_LOGICAL_AND=39, OPERATOR_LOGICAL_OR=40, 
		OPERATOR_LOGICAL_XOR=41, OPERATOR_LOGICAL_NOT=42, OPERATOR_MATHS_ADDITION_EQUALS=43, 
		OPERATOR_MATHS_SUBTRACTION_EQUALS=44, OPERATOR_MATHS_MULTIPLICATION_EQUALS=45, 
		OPERATOR_MATHS_MODULUS_EQUALS=46, OPERATOR_MATHS_DIVISION_EQUALS=47, OPERATOR_MATHS_ADDITION=48, 
		OPERATOR_MATHS_SUBTRACTION=49, OPERATOR_MATHS_MULTIPLICATION=50, OPERATOR_MATHS_DIVISION=51, 
		OPERATOR_MATHS_MODULUS=52, LPAREN=53, RPAREN=54, COMMA=55, EXPRESSION_AS=56, 
		STRING=57, FUNC_ID=58, EXPRESSION_END=59, VAR_ID=60, DOT=61, NUMBER=62, 
		COMMAND_NEWLINE=63, COMMAND_WS=64, COMMAND_IF=65, COMMAND_ELSEIF=66, COMMAND_ELSE=67, 
		COMMAND_SET=68, COMMAND_ENDIF=69, COMMAND_CALL=70, COMMAND_DECLARE=71, 
		COMMAND_JUMP=72, COMMAND_DETOUR=73, COMMAND_RETURN=74, COMMAND_ENUM=75, 
		COMMAND_CASE=76, COMMAND_ENDENUM=77, COMMAND_LOCAL=78, COMMAND_END=79, 
		COMMAND_TEXT_NEWLINE=80, COMMAND_TEXT_END=81, COMMAND_EXPRESSION_START=82, 
		COMMAND_TEXT=83, COMMAND_ID_NEWLINE=84, TYPE_STRING=85, TYPE_NUMBER=86, 
		TYPE_BOOL=87;
	public const int
		WHITESPACE=2, COMMENTS=3;
	public const int
		HeaderMode=1, BodyMode=2, TextMode=3, TextEscapedMode=4, TextCommandOrHashtagMode=5, 
		HashtagMode=6, ExpressionMode=7, CommandMode=8, CommandTextMode=9, CommandIDMode=10, 
		CommandIDOrExpressionMode=11;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN", "WHITESPACE", "COMMENTS"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE", "HeaderMode", "BodyMode", "TextMode", "TextEscapedMode", 
		"TextCommandOrHashtagMode", "HashtagMode", "ExpressionMode", "CommandMode", 
		"CommandTextMode", "CommandIDMode", "CommandIDOrExpressionMode"
	};

	public static readonly string[] ruleNames = {
		"WS", "COMMENT", "NEWLINE", "ID", "IDENTIFIER_HEAD", "IDENTIFIER_CHARACTER", 
		"IDENTIFIER_CHARACTERS", "BODY_START", "HEADER_DELIMITER", "HASHTAG", 
		"REST_OF_LINE", "HEADER_NEWLINE", "BODY_WS", "BODY_NEWLINE", "BODY_COMMENT", 
		"BODY_END", "SHORTCUT_ARROW", "LINE_GROUP_ARROW", "COMMAND_START", "BODY_HASHTAG", 
		"EXPRESSION_START", "ESCAPED_BRACKET_START", "ESCAPED_ANY", "ANY", "TEXT_NEWLINE", 
		"TEXT_ESCAPED_MARKUP_BRACKET", "TEXT_ESCAPE", "TEXT_HASHTAG", "TEXT_EXPRESSION_START", 
		"TEXT_COMMAND_START", "TEXT_COMMENT", "TEXT", "TEXT_FRAG", "TEXT_ESCAPED_CHARACTER", 
		"UNESCAPABLE_CHARACTER", "TEXT_COMMANDHASHTAG_WS", "TEXT_COMMANDHASHTAG_COMMENT", 
		"TEXT_COMMANDHASHTAG_COMMAND_START", "TEXT_COMMANDHASHTAG_HASHTAG", "TEXT_COMMANDHASHTAG_NEWLINE", 
		"TEXT_COMMANDHASHTAG_ERROR", "HASHTAG_WS", "HASHTAG_TAG", "HASHTAG_TEXT", 
		"EXPR_WS", "KEYWORD_TRUE", "KEYWORD_FALSE", "KEYWORD_NULL", "OPERATOR_ASSIGNMENT", 
		"OPERATOR_LOGICAL_LESS_THAN_EQUALS", "OPERATOR_LOGICAL_GREATER_THAN_EQUALS", 
		"OPERATOR_LOGICAL_EQUALS", "OPERATOR_LOGICAL_LESS", "OPERATOR_LOGICAL_GREATER", 
		"OPERATOR_LOGICAL_NOT_EQUALS", "OPERATOR_LOGICAL_AND", "OPERATOR_LOGICAL_OR", 
		"OPERATOR_LOGICAL_XOR", "OPERATOR_LOGICAL_NOT", "OPERATOR_MATHS_ADDITION_EQUALS", 
		"OPERATOR_MATHS_SUBTRACTION_EQUALS", "OPERATOR_MATHS_MULTIPLICATION_EQUALS", 
		"OPERATOR_MATHS_MODULUS_EQUALS", "OPERATOR_MATHS_DIVISION_EQUALS", "OPERATOR_MATHS_ADDITION", 
		"OPERATOR_MATHS_SUBTRACTION", "OPERATOR_MATHS_MULTIPLICATION", "OPERATOR_MATHS_DIVISION", 
		"OPERATOR_MATHS_MODULUS", "LPAREN", "RPAREN", "COMMA", "EXPRESSION_AS", 
		"TYPE_STRING", "TYPE_NUMBER", "TYPE_BOOL", "STRING", "FUNC_ID", "EXPRESSION_END", 
		"EXPRESSION_COMMAND_END", "VAR_ID", "DOT", "NUMBER", "INT", "DIGIT", "COMMAND_NEWLINE", 
		"COMMAND_WS", "COMMAND_IF", "COMMAND_ELSEIF", "COMMAND_ELSE", "COMMAND_SET", 
		"COMMAND_ENDIF", "COMMAND_CALL", "COMMAND_DECLARE", "COMMAND_JUMP", "COMMAND_DETOUR", 
		"COMMAND_RETURN", "COMMAND_ENUM", "COMMAND_CASE", "COMMAND_ENDENUM", "COMMAND_LOCAL", 
		"COMMAND_END", "COMMAND_EXPRESSION_AT_START", "COMMAND_ARBITRARY", "COMMAND_TEXT_NEWLINE", 
		"COMMAND_TEXT_END", "COMMAND_EXPRESSION_START", "COMMAND_TEXT", "COMMAND_ID_NEWLINE", 
		"COMMAND_ID", "COMMAND_ID_END", "COMMAND_ID_OR_EXPRESSION_ID", "COMMAND_ID_OR_EXPRESSION_START", 
		"COMMAND_ID_OR_EXPRESSION_END"
	};


	public YarnSpinnerLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public YarnSpinnerLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, null, null, "'---'", null, "'#'", 
		null, null, "'==='", "'->'", "'=>'", "'<<'", null, null, "'\\'", null, 
		null, null, null, null, null, null, null, null, "'true'", "'false'", "'null'", 
		null, null, null, null, null, null, null, null, null, null, null, "'+='", 
		"'-='", "'*='", "'%='", "'/='", "'+'", "'-'", "'*'", "'/'", "'%'", "'('", 
		"')'", "','", "'as'", null, null, "'}'", null, "'.'", null, null, null, 
		null, null, null, null, "'endif'", null, null, null, null, null, null, 
		null, null, null, null, null, null, "'{'", null, null, "'string'", "'number'", 
		"'bool'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "INDENT", "DEDENT", "BLANK_LINE_FOLLOWING_OPTION", "WS", "COMMENT", 
		"NEWLINE", "ID", "BODY_START", "HEADER_DELIMITER", "HASHTAG", "REST_OF_LINE", 
		"BODY_WS", "BODY_END", "SHORTCUT_ARROW", "LINE_GROUP_ARROW", "COMMAND_START", 
		"EXPRESSION_START", "ESCAPED_ANY", "TEXT_ESCAPE", "TEXT_COMMENT", "TEXT", 
		"UNESCAPABLE_CHARACTER", "TEXT_COMMANDHASHTAG_WS", "TEXT_COMMANDHASHTAG_COMMENT", 
		"TEXT_COMMANDHASHTAG_ERROR", "HASHTAG_WS", "HASHTAG_TEXT", "EXPR_WS", 
		"KEYWORD_TRUE", "KEYWORD_FALSE", "KEYWORD_NULL", "OPERATOR_ASSIGNMENT", 
		"OPERATOR_LOGICAL_LESS_THAN_EQUALS", "OPERATOR_LOGICAL_GREATER_THAN_EQUALS", 
		"OPERATOR_LOGICAL_EQUALS", "OPERATOR_LOGICAL_LESS", "OPERATOR_LOGICAL_GREATER", 
		"OPERATOR_LOGICAL_NOT_EQUALS", "OPERATOR_LOGICAL_AND", "OPERATOR_LOGICAL_OR", 
		"OPERATOR_LOGICAL_XOR", "OPERATOR_LOGICAL_NOT", "OPERATOR_MATHS_ADDITION_EQUALS", 
		"OPERATOR_MATHS_SUBTRACTION_EQUALS", "OPERATOR_MATHS_MULTIPLICATION_EQUALS", 
		"OPERATOR_MATHS_MODULUS_EQUALS", "OPERATOR_MATHS_DIVISION_EQUALS", "OPERATOR_MATHS_ADDITION", 
		"OPERATOR_MATHS_SUBTRACTION", "OPERATOR_MATHS_MULTIPLICATION", "OPERATOR_MATHS_DIVISION", 
		"OPERATOR_MATHS_MODULUS", "LPAREN", "RPAREN", "COMMA", "EXPRESSION_AS", 
		"STRING", "FUNC_ID", "EXPRESSION_END", "VAR_ID", "DOT", "NUMBER", "COMMAND_NEWLINE", 
		"COMMAND_WS", "COMMAND_IF", "COMMAND_ELSEIF", "COMMAND_ELSE", "COMMAND_SET", 
		"COMMAND_ENDIF", "COMMAND_CALL", "COMMAND_DECLARE", "COMMAND_JUMP", "COMMAND_DETOUR", 
		"COMMAND_RETURN", "COMMAND_ENUM", "COMMAND_CASE", "COMMAND_ENDENUM", "COMMAND_LOCAL", 
		"COMMAND_END", "COMMAND_TEXT_NEWLINE", "COMMAND_TEXT_END", "COMMAND_EXPRESSION_START", 
		"COMMAND_TEXT", "COMMAND_ID_NEWLINE", "TYPE_STRING", "TYPE_NUMBER", "TYPE_BOOL"
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

	public override string GrammarFileName { get { return "YarnSpinnerLexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static YarnSpinnerLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,87,864,6,-1,6,-1,6,-1,6,-1,6,-1,6,-1,6,-1,6,-1,6,-1,6,-1,6,-1,6,-1,
		2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,7,7,7,2,8,7,
		8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,7,14,2,15,7,15,
		2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,7,21,2,22,7,22,
		2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,7,28,2,29,7,29,
		2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,7,35,2,36,7,36,
		2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,7,42,2,43,7,43,
		2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,7,49,2,50,7,50,
		2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,2,55,7,55,2,56,7,56,2,57,7,57,
		2,58,7,58,2,59,7,59,2,60,7,60,2,61,7,61,2,62,7,62,2,63,7,63,2,64,7,64,
		2,65,7,65,2,66,7,66,2,67,7,67,2,68,7,68,2,69,7,69,2,70,7,70,2,71,7,71,
		2,72,7,72,2,73,7,73,2,74,7,74,2,75,7,75,2,76,7,76,2,77,7,77,2,78,7,78,
		2,79,7,79,2,80,7,80,2,81,7,81,2,82,7,82,2,83,7,83,2,84,7,84,2,85,7,85,
		2,86,7,86,2,87,7,87,2,88,7,88,2,89,7,89,2,90,7,90,2,91,7,91,2,92,7,92,
		2,93,7,93,2,94,7,94,2,95,7,95,2,96,7,96,2,97,7,97,2,98,7,98,2,99,7,99,
		2,100,7,100,2,101,7,101,2,102,7,102,2,103,7,103,2,104,7,104,2,105,7,105,
		2,106,7,106,2,107,7,107,2,108,7,108,2,109,7,109,2,110,7,110,2,111,7,111,
		2,112,7,112,2,113,7,113,1,0,4,0,242,8,0,11,0,12,0,243,1,0,1,0,1,1,1,1,
		1,1,1,1,5,1,252,8,1,10,1,12,1,255,9,1,1,1,1,1,1,2,3,2,260,8,2,1,2,1,2,
		3,2,264,8,2,1,2,5,2,267,8,2,10,2,12,2,270,9,2,1,2,1,2,1,3,1,3,3,3,276,
		8,3,1,4,3,4,279,8,4,1,5,1,5,3,5,283,8,5,1,6,4,6,286,8,6,11,6,12,6,287,
		1,7,1,7,1,7,1,7,1,7,1,7,1,8,1,8,5,8,298,8,8,10,8,12,8,301,9,8,1,8,1,8,
		1,9,1,9,1,9,1,9,1,10,4,10,310,8,10,11,10,12,10,311,1,11,1,11,1,11,1,11,
		1,11,1,11,1,12,1,12,1,12,1,12,1,13,1,13,1,13,1,13,1,13,1,14,1,14,1,14,
		1,14,1,14,1,15,1,15,1,15,1,15,1,15,1,15,1,16,1,16,1,16,1,17,1,17,1,17,
		1,18,1,18,1,18,1,18,1,18,1,19,1,19,1,19,1,19,1,19,1,19,1,20,1,20,1,20,
		1,20,1,20,1,21,1,21,1,21,1,21,1,21,1,21,1,22,1,22,1,22,1,22,1,22,1,22,
		1,23,1,23,1,23,1,23,1,23,1,24,1,24,1,24,1,24,1,24,1,25,1,25,1,25,1,25,
		3,25,388,8,25,1,25,1,25,1,26,1,26,1,26,1,26,1,26,1,27,1,27,1,27,1,27,1,
		27,1,27,1,28,1,28,1,28,1,28,1,28,1,29,1,29,1,29,1,29,1,29,1,29,1,29,1,
		30,1,30,1,30,1,30,1,31,4,31,420,8,31,11,31,12,31,421,1,31,3,31,425,8,31,
		1,32,1,32,1,33,1,33,1,33,1,33,1,33,1,34,1,34,1,34,1,34,1,35,1,35,1,35,
		1,35,1,36,1,36,1,36,1,36,1,37,1,37,1,37,1,37,1,37,1,37,1,38,1,38,1,38,
		1,38,1,38,1,39,1,39,1,39,1,39,1,39,1,40,1,40,1,41,1,41,1,41,1,41,1,42,
		1,42,1,42,1,42,1,43,4,43,473,8,43,11,43,12,43,474,1,43,1,43,1,44,1,44,
		1,44,1,44,1,45,1,45,1,45,1,45,1,45,1,46,1,46,1,46,1,46,1,46,1,46,1,47,
		1,47,1,47,1,47,1,47,1,48,1,48,1,48,3,48,502,8,48,1,49,1,49,1,49,1,49,1,
		49,3,49,509,8,49,1,50,1,50,1,50,1,50,1,50,3,50,516,8,50,1,51,1,51,1,51,
		1,51,1,51,1,51,3,51,524,8,51,1,52,1,52,1,52,3,52,529,8,52,1,53,1,53,1,
		53,3,53,534,8,53,1,54,1,54,1,54,1,54,1,54,3,54,541,8,54,1,55,1,55,1,55,
		1,55,1,55,3,55,548,8,55,1,56,1,56,1,56,1,56,3,56,554,8,56,1,57,1,57,1,
		57,1,57,3,57,560,8,57,1,58,1,58,1,58,1,58,3,58,566,8,58,1,59,1,59,1,59,
		1,60,1,60,1,60,1,61,1,61,1,61,1,62,1,62,1,62,1,63,1,63,1,63,1,64,1,64,
		1,65,1,65,1,66,1,66,1,67,1,67,1,68,1,68,1,69,1,69,1,70,1,70,1,71,1,71,
		1,72,1,72,1,72,1,73,1,73,1,73,1,73,1,73,1,73,1,73,1,73,1,73,1,74,1,74,
		1,74,1,74,1,74,1,74,1,74,1,74,1,74,1,75,1,75,1,75,1,75,1,75,1,75,1,75,
		1,76,1,76,1,76,1,76,5,76,631,8,76,10,76,12,76,634,9,76,1,76,1,76,1,77,
		1,77,1,78,1,78,1,78,1,78,1,79,1,79,1,79,1,79,1,79,1,79,1,79,1,80,1,80,
		1,80,1,81,1,81,1,82,1,82,1,82,1,82,1,82,3,82,661,8,82,1,83,4,83,664,8,
		83,11,83,12,83,665,1,84,1,84,1,85,1,85,1,86,1,86,1,86,1,86,1,87,1,87,1,
		87,1,87,1,87,1,87,1,87,1,88,1,88,1,88,1,88,1,88,1,88,1,88,1,88,1,88,1,
		88,1,88,1,89,1,89,1,89,1,89,1,89,1,89,3,89,700,8,89,1,90,1,90,1,90,1,90,
		1,90,1,90,1,90,1,90,1,91,1,91,1,91,1,91,1,91,1,91,1,92,1,92,1,92,1,92,
		1,92,1,92,1,92,1,92,1,92,1,93,1,93,1,93,1,93,1,93,1,93,1,93,1,93,1,93,
		1,93,1,93,1,93,1,94,1,94,1,94,1,94,1,94,1,94,1,94,1,94,1,94,1,95,1,95,
		1,95,1,95,1,95,1,95,1,95,1,95,1,95,1,95,1,95,1,96,1,96,1,96,1,96,1,96,
		1,96,1,96,1,96,3,96,765,8,96,1,97,1,97,1,97,1,97,1,97,1,97,1,97,1,97,1,
		97,1,98,1,98,1,98,1,98,1,98,1,98,1,98,1,98,1,98,1,99,1,99,1,99,1,99,1,
		99,1,99,1,99,1,99,1,99,3,99,794,8,99,1,100,1,100,1,100,1,100,1,100,1,100,
		1,100,1,100,1,101,1,101,1,101,1,101,1,101,1,102,1,102,1,102,1,102,1,102,
		1,102,1,103,1,103,1,103,1,103,1,103,1,104,1,104,1,105,1,105,1,105,1,105,
		1,105,1,106,1,106,1,106,1,106,1,107,4,107,832,8,107,11,107,12,107,833,
		1,108,1,108,1,109,1,109,1,109,1,109,1,109,1,110,1,110,1,110,1,110,1,110,
		1,110,1,111,1,111,1,111,1,111,1,111,1,112,1,112,1,112,1,112,1,112,1,113,
		1,113,1,113,1,113,1,113,1,113,0,0,114,12,4,14,5,16,6,18,7,20,0,22,0,24,
		0,26,8,28,9,30,10,32,11,34,0,36,12,38,0,40,0,42,13,44,14,46,15,48,16,50,
		0,52,17,54,0,56,18,58,0,60,0,62,0,64,19,66,0,68,0,70,0,72,20,74,21,76,
		0,78,0,80,22,82,23,84,24,86,0,88,0,90,0,92,25,94,26,96,0,98,27,100,28,
		102,29,104,30,106,31,108,32,110,33,112,34,114,35,116,36,118,37,120,38,
		122,39,124,40,126,41,128,42,130,43,132,44,134,45,136,46,138,47,140,48,
		142,49,144,50,146,51,148,52,150,53,152,54,154,55,156,56,158,85,160,86,
		162,87,164,57,166,58,168,59,170,0,172,60,174,61,176,62,178,0,180,0,182,
		63,184,64,186,65,188,66,190,67,192,68,194,69,196,70,198,71,200,72,202,
		73,204,74,206,75,208,76,210,77,212,78,214,79,216,0,218,0,220,80,222,81,
		224,82,226,83,228,84,230,0,232,0,234,0,236,0,238,0,12,0,1,2,3,4,5,6,7,
		8,9,10,11,14,2,0,9,9,32,32,2,0,10,10,13,13,49,0,65,90,95,95,97,122,168,
		168,170,170,173,173,175,175,178,181,183,186,188,190,192,214,216,246,248,
		767,880,5759,5761,6157,6159,7615,7680,8191,8203,8205,8234,8238,8255,8256,
		8276,8276,8288,8399,8448,8591,9312,9471,10102,10131,11264,11775,11904,
		12287,12292,12295,12321,12335,12337,55295,63744,64829,64832,64975,65008,
		65055,65072,65092,65095,65533,65536,131069,131072,196605,196608,262141,
		262144,327677,327680,393213,393216,458749,458752,524285,524288,589821,
		589824,655357,655360,720893,720896,786429,786432,851965,851968,917501,
		917504,983037,5,0,48,57,768,879,7616,7679,8400,8447,65056,65071,1,0,32,
		32,2,0,47,47,60,60,7,0,10,10,13,13,35,35,47,47,60,60,92,92,123,123,7,0,
		35,35,47,47,60,60,62,62,92,92,123,123,125,125,5,0,9,10,13,13,32,32,35,
		36,60,60,4,0,10,10,13,13,34,34,92,92,2,0,34,34,92,92,1,0,48,57,10,0,9,
		13,32,32,133,133,160,160,5760,5760,8192,8202,8232,8233,8239,8239,8287,
		8287,12288,12288,4,0,10,10,13,13,62,62,123,123,880,0,12,1,0,0,0,0,14,1,
		0,0,0,0,16,1,0,0,0,0,18,1,0,0,0,0,26,1,0,0,0,0,28,1,0,0,0,0,30,1,0,0,0,
		1,32,1,0,0,0,1,34,1,0,0,0,2,36,1,0,0,0,2,38,1,0,0,0,2,40,1,0,0,0,2,42,
		1,0,0,0,2,44,1,0,0,0,2,46,1,0,0,0,2,48,1,0,0,0,2,50,1,0,0,0,2,52,1,0,0,
		0,2,54,1,0,0,0,2,56,1,0,0,0,2,58,1,0,0,0,3,60,1,0,0,0,3,62,1,0,0,0,3,64,
		1,0,0,0,3,66,1,0,0,0,3,68,1,0,0,0,3,70,1,0,0,0,3,72,1,0,0,0,3,74,1,0,0,
		0,4,78,1,0,0,0,4,80,1,0,0,0,5,82,1,0,0,0,5,84,1,0,0,0,5,86,1,0,0,0,5,88,
		1,0,0,0,5,90,1,0,0,0,5,92,1,0,0,0,6,94,1,0,0,0,6,96,1,0,0,0,6,98,1,0,0,
		0,7,100,1,0,0,0,7,102,1,0,0,0,7,104,1,0,0,0,7,106,1,0,0,0,7,108,1,0,0,
		0,7,110,1,0,0,0,7,112,1,0,0,0,7,114,1,0,0,0,7,116,1,0,0,0,7,118,1,0,0,
		0,7,120,1,0,0,0,7,122,1,0,0,0,7,124,1,0,0,0,7,126,1,0,0,0,7,128,1,0,0,
		0,7,130,1,0,0,0,7,132,1,0,0,0,7,134,1,0,0,0,7,136,1,0,0,0,7,138,1,0,0,
		0,7,140,1,0,0,0,7,142,1,0,0,0,7,144,1,0,0,0,7,146,1,0,0,0,7,148,1,0,0,
		0,7,150,1,0,0,0,7,152,1,0,0,0,7,154,1,0,0,0,7,156,1,0,0,0,7,158,1,0,0,
		0,7,160,1,0,0,0,7,162,1,0,0,0,7,164,1,0,0,0,7,166,1,0,0,0,7,168,1,0,0,
		0,7,170,1,0,0,0,7,172,1,0,0,0,7,174,1,0,0,0,7,176,1,0,0,0,8,182,1,0,0,
		0,8,184,1,0,0,0,8,186,1,0,0,0,8,188,1,0,0,0,8,190,1,0,0,0,8,192,1,0,0,
		0,8,194,1,0,0,0,8,196,1,0,0,0,8,198,1,0,0,0,8,200,1,0,0,0,8,202,1,0,0,
		0,8,204,1,0,0,0,8,206,1,0,0,0,8,208,1,0,0,0,8,210,1,0,0,0,8,212,1,0,0,
		0,8,214,1,0,0,0,8,216,1,0,0,0,8,218,1,0,0,0,9,220,1,0,0,0,9,222,1,0,0,
		0,9,224,1,0,0,0,9,226,1,0,0,0,10,228,1,0,0,0,10,230,1,0,0,0,10,232,1,0,
		0,0,11,234,1,0,0,0,11,236,1,0,0,0,11,238,1,0,0,0,12,241,1,0,0,0,14,247,
		1,0,0,0,16,263,1,0,0,0,18,273,1,0,0,0,20,278,1,0,0,0,22,282,1,0,0,0,24,
		285,1,0,0,0,26,289,1,0,0,0,28,295,1,0,0,0,30,304,1,0,0,0,32,309,1,0,0,
		0,34,313,1,0,0,0,36,319,1,0,0,0,38,323,1,0,0,0,40,328,1,0,0,0,42,333,1,
		0,0,0,44,339,1,0,0,0,46,342,1,0,0,0,48,345,1,0,0,0,50,350,1,0,0,0,52,356,
		1,0,0,0,54,361,1,0,0,0,56,367,1,0,0,0,58,373,1,0,0,0,60,378,1,0,0,0,62,
		387,1,0,0,0,64,391,1,0,0,0,66,396,1,0,0,0,68,402,1,0,0,0,70,407,1,0,0,
		0,72,414,1,0,0,0,74,424,1,0,0,0,76,426,1,0,0,0,78,428,1,0,0,0,80,433,1,
		0,0,0,82,437,1,0,0,0,84,441,1,0,0,0,86,445,1,0,0,0,88,451,1,0,0,0,90,456,
		1,0,0,0,92,461,1,0,0,0,94,463,1,0,0,0,96,467,1,0,0,0,98,472,1,0,0,0,100,
		478,1,0,0,0,102,482,1,0,0,0,104,487,1,0,0,0,106,493,1,0,0,0,108,501,1,
		0,0,0,110,508,1,0,0,0,112,515,1,0,0,0,114,523,1,0,0,0,116,528,1,0,0,0,
		118,533,1,0,0,0,120,540,1,0,0,0,122,547,1,0,0,0,124,553,1,0,0,0,126,559,
		1,0,0,0,128,565,1,0,0,0,130,567,1,0,0,0,132,570,1,0,0,0,134,573,1,0,0,
		0,136,576,1,0,0,0,138,579,1,0,0,0,140,582,1,0,0,0,142,584,1,0,0,0,144,
		586,1,0,0,0,146,588,1,0,0,0,148,590,1,0,0,0,150,592,1,0,0,0,152,594,1,
		0,0,0,154,596,1,0,0,0,156,598,1,0,0,0,158,601,1,0,0,0,160,610,1,0,0,0,
		162,619,1,0,0,0,164,626,1,0,0,0,166,637,1,0,0,0,168,639,1,0,0,0,170,643,
		1,0,0,0,172,650,1,0,0,0,174,653,1,0,0,0,176,660,1,0,0,0,178,663,1,0,0,
		0,180,667,1,0,0,0,182,669,1,0,0,0,184,671,1,0,0,0,186,675,1,0,0,0,188,
		682,1,0,0,0,190,693,1,0,0,0,192,701,1,0,0,0,194,709,1,0,0,0,196,715,1,
		0,0,0,198,724,1,0,0,0,200,736,1,0,0,0,202,745,1,0,0,0,204,756,1,0,0,0,
		206,766,1,0,0,0,208,775,1,0,0,0,210,784,1,0,0,0,212,795,1,0,0,0,214,803,
		1,0,0,0,216,808,1,0,0,0,218,814,1,0,0,0,220,819,1,0,0,0,222,821,1,0,0,
		0,224,826,1,0,0,0,226,831,1,0,0,0,228,835,1,0,0,0,230,837,1,0,0,0,232,
		842,1,0,0,0,234,848,1,0,0,0,236,853,1,0,0,0,238,858,1,0,0,0,240,242,7,
		0,0,0,241,240,1,0,0,0,242,243,1,0,0,0,243,241,1,0,0,0,243,244,1,0,0,0,
		244,245,1,0,0,0,245,246,6,0,0,0,246,13,1,0,0,0,247,248,5,47,0,0,248,249,
		5,47,0,0,249,253,1,0,0,0,250,252,8,1,0,0,251,250,1,0,0,0,252,255,1,0,0,
		0,253,251,1,0,0,0,253,254,1,0,0,0,254,256,1,0,0,0,255,253,1,0,0,0,256,
		257,6,1,1,0,257,15,1,0,0,0,258,260,5,13,0,0,259,258,1,0,0,0,259,260,1,
		0,0,0,260,261,1,0,0,0,261,264,5,10,0,0,262,264,5,13,0,0,263,259,1,0,0,
		0,263,262,1,0,0,0,264,268,1,0,0,0,265,267,7,0,0,0,266,265,1,0,0,0,267,
		270,1,0,0,0,268,266,1,0,0,0,268,269,1,0,0,0,269,271,1,0,0,0,270,268,1,
		0,0,0,271,272,6,2,2,0,272,17,1,0,0,0,273,275,3,20,4,0,274,276,3,24,6,0,
		275,274,1,0,0,0,275,276,1,0,0,0,276,19,1,0,0,0,277,279,7,2,0,0,278,277,
		1,0,0,0,279,21,1,0,0,0,280,283,7,3,0,0,281,283,3,20,4,0,282,280,1,0,0,
		0,282,281,1,0,0,0,283,23,1,0,0,0,284,286,3,22,5,0,285,284,1,0,0,0,286,
		287,1,0,0,0,287,285,1,0,0,0,287,288,1,0,0,0,288,25,1,0,0,0,289,290,5,45,
		0,0,290,291,5,45,0,0,291,292,5,45,0,0,292,293,1,0,0,0,293,294,6,7,3,0,
		294,27,1,0,0,0,295,299,5,58,0,0,296,298,7,4,0,0,297,296,1,0,0,0,298,301,
		1,0,0,0,299,297,1,0,0,0,299,300,1,0,0,0,300,302,1,0,0,0,301,299,1,0,0,
		0,302,303,6,8,4,0,303,29,1,0,0,0,304,305,5,35,0,0,305,306,1,0,0,0,306,
		307,6,9,5,0,307,31,1,0,0,0,308,310,8,1,0,0,309,308,1,0,0,0,310,311,1,0,
		0,0,311,309,1,0,0,0,311,312,1,0,0,0,312,33,1,0,0,0,313,314,3,16,2,0,314,
		315,1,0,0,0,315,316,6,11,6,0,316,317,6,11,2,0,317,318,6,11,7,0,318,35,
		1,0,0,0,319,320,3,12,0,0,320,321,1,0,0,0,321,322,6,12,0,0,322,37,1,0,0,
		0,323,324,3,16,2,0,324,325,1,0,0,0,325,326,6,13,6,0,326,327,6,13,2,0,327,
		39,1,0,0,0,328,329,3,14,1,0,329,330,1,0,0,0,330,331,6,14,8,0,331,332,6,
		14,1,0,332,41,1,0,0,0,333,334,5,61,0,0,334,335,5,61,0,0,335,336,5,61,0,
		0,336,337,1,0,0,0,337,338,6,15,7,0,338,43,1,0,0,0,339,340,5,45,0,0,340,
		341,5,62,0,0,341,45,1,0,0,0,342,343,5,61,0,0,343,344,5,62,0,0,344,47,1,
		0,0,0,345,346,5,60,0,0,346,347,5,60,0,0,347,348,1,0,0,0,348,349,6,18,9,
		0,349,49,1,0,0,0,350,351,5,35,0,0,351,352,1,0,0,0,352,353,6,19,10,0,353,
		354,6,19,11,0,354,355,6,19,5,0,355,51,1,0,0,0,356,357,5,123,0,0,357,358,
		1,0,0,0,358,359,6,20,12,0,359,360,6,20,13,0,360,53,1,0,0,0,361,362,5,92,
		0,0,362,363,5,91,0,0,363,364,1,0,0,0,364,365,6,21,14,0,365,366,6,21,12,
		0,366,55,1,0,0,0,367,368,5,92,0,0,368,369,1,0,0,0,369,370,6,22,0,0,370,
		371,6,22,12,0,371,372,6,22,15,0,372,57,1,0,0,0,373,374,9,0,0,0,374,375,
		1,0,0,0,375,376,6,23,14,0,376,377,6,23,12,0,377,59,1,0,0,0,378,379,3,16,
		2,0,379,380,1,0,0,0,380,381,6,24,6,0,381,382,6,24,7,0,382,61,1,0,0,0,383,
		384,5,92,0,0,384,388,5,91,0,0,385,386,5,92,0,0,386,388,5,93,0,0,387,383,
		1,0,0,0,387,385,1,0,0,0,388,389,1,0,0,0,389,390,6,25,14,0,390,63,1,0,0,
		0,391,392,5,92,0,0,392,393,1,0,0,0,393,394,6,26,16,0,394,395,6,26,15,0,
		395,65,1,0,0,0,396,397,3,30,9,0,397,398,1,0,0,0,398,399,6,27,10,0,399,
		400,6,27,17,0,400,401,6,27,5,0,401,67,1,0,0,0,402,403,5,123,0,0,403,404,
		1,0,0,0,404,405,6,28,18,0,405,406,6,28,13,0,406,69,1,0,0,0,407,408,5,60,
		0,0,408,409,5,60,0,0,409,410,1,0,0,0,410,411,6,29,19,0,411,412,6,29,17,
		0,412,413,6,29,9,0,413,71,1,0,0,0,414,415,3,14,1,0,415,416,1,0,0,0,416,
		417,6,30,1,0,417,73,1,0,0,0,418,420,3,76,32,0,419,418,1,0,0,0,420,421,
		1,0,0,0,421,419,1,0,0,0,421,422,1,0,0,0,422,425,1,0,0,0,423,425,7,5,0,
		0,424,419,1,0,0,0,424,423,1,0,0,0,425,75,1,0,0,0,426,427,8,6,0,0,427,77,
		1,0,0,0,428,429,7,7,0,0,429,430,1,0,0,0,430,431,6,33,14,0,431,432,6,33,
		7,0,432,79,1,0,0,0,433,434,9,0,0,0,434,435,1,0,0,0,435,436,6,34,7,0,436,
		81,1,0,0,0,437,438,3,12,0,0,438,439,1,0,0,0,439,440,6,35,0,0,440,83,1,
		0,0,0,441,442,3,14,1,0,442,443,1,0,0,0,443,444,6,36,1,0,444,85,1,0,0,0,
		445,446,5,60,0,0,446,447,5,60,0,0,447,448,1,0,0,0,448,449,6,37,19,0,449,
		450,6,37,9,0,450,87,1,0,0,0,451,452,5,35,0,0,452,453,1,0,0,0,453,454,6,
		38,10,0,454,455,6,38,5,0,455,89,1,0,0,0,456,457,3,16,2,0,457,458,1,0,0,
		0,458,459,6,39,6,0,459,460,6,39,7,0,460,91,1,0,0,0,461,462,9,0,0,0,462,
		93,1,0,0,0,463,464,3,12,0,0,464,465,1,0,0,0,465,466,6,41,0,0,466,95,1,
		0,0,0,467,468,3,30,9,0,468,469,1,0,0,0,469,470,6,42,10,0,470,97,1,0,0,
		0,471,473,8,8,0,0,472,471,1,0,0,0,473,474,1,0,0,0,474,472,1,0,0,0,474,
		475,1,0,0,0,475,476,1,0,0,0,476,477,6,43,7,0,477,99,1,0,0,0,478,479,3,
		12,0,0,479,480,1,0,0,0,480,481,6,44,0,0,481,101,1,0,0,0,482,483,5,116,
		0,0,483,484,5,114,0,0,484,485,5,117,0,0,485,486,5,101,0,0,486,103,1,0,
		0,0,487,488,5,102,0,0,488,489,5,97,0,0,489,490,5,108,0,0,490,491,5,115,
		0,0,491,492,5,101,0,0,492,105,1,0,0,0,493,494,5,110,0,0,494,495,5,117,
		0,0,495,496,5,108,0,0,496,497,5,108,0,0,497,107,1,0,0,0,498,502,5,61,0,
		0,499,500,5,116,0,0,500,502,5,111,0,0,501,498,1,0,0,0,501,499,1,0,0,0,
		502,109,1,0,0,0,503,504,5,60,0,0,504,509,5,61,0,0,505,506,5,108,0,0,506,
		507,5,116,0,0,507,509,5,101,0,0,508,503,1,0,0,0,508,505,1,0,0,0,509,111,
		1,0,0,0,510,511,5,62,0,0,511,516,5,61,0,0,512,513,5,103,0,0,513,514,5,
		116,0,0,514,516,5,101,0,0,515,510,1,0,0,0,515,512,1,0,0,0,516,113,1,0,
		0,0,517,518,5,61,0,0,518,524,5,61,0,0,519,520,5,105,0,0,520,524,5,115,
		0,0,521,522,5,101,0,0,522,524,5,113,0,0,523,517,1,0,0,0,523,519,1,0,0,
		0,523,521,1,0,0,0,524,115,1,0,0,0,525,529,5,60,0,0,526,527,5,108,0,0,527,
		529,5,116,0,0,528,525,1,0,0,0,528,526,1,0,0,0,529,117,1,0,0,0,530,534,
		5,62,0,0,531,532,5,103,0,0,532,534,5,116,0,0,533,530,1,0,0,0,533,531,1,
		0,0,0,534,119,1,0,0,0,535,536,5,33,0,0,536,541,5,61,0,0,537,538,5,110,
		0,0,538,539,5,101,0,0,539,541,5,113,0,0,540,535,1,0,0,0,540,537,1,0,0,
		0,541,121,1,0,0,0,542,543,5,97,0,0,543,544,5,110,0,0,544,548,5,100,0,0,
		545,546,5,38,0,0,546,548,5,38,0,0,547,542,1,0,0,0,547,545,1,0,0,0,548,
		123,1,0,0,0,549,550,5,111,0,0,550,554,5,114,0,0,551,552,5,124,0,0,552,
		554,5,124,0,0,553,549,1,0,0,0,553,551,1,0,0,0,554,125,1,0,0,0,555,556,
		5,120,0,0,556,557,5,111,0,0,557,560,5,114,0,0,558,560,5,94,0,0,559,555,
		1,0,0,0,559,558,1,0,0,0,560,127,1,0,0,0,561,562,5,110,0,0,562,563,5,111,
		0,0,563,566,5,116,0,0,564,566,5,33,0,0,565,561,1,0,0,0,565,564,1,0,0,0,
		566,129,1,0,0,0,567,568,5,43,0,0,568,569,5,61,0,0,569,131,1,0,0,0,570,
		571,5,45,0,0,571,572,5,61,0,0,572,133,1,0,0,0,573,574,5,42,0,0,574,575,
		5,61,0,0,575,135,1,0,0,0,576,577,5,37,0,0,577,578,5,61,0,0,578,137,1,0,
		0,0,579,580,5,47,0,0,580,581,5,61,0,0,581,139,1,0,0,0,582,583,5,43,0,0,
		583,141,1,0,0,0,584,585,5,45,0,0,585,143,1,0,0,0,586,587,5,42,0,0,587,
		145,1,0,0,0,588,589,5,47,0,0,589,147,1,0,0,0,590,591,5,37,0,0,591,149,
		1,0,0,0,592,593,5,40,0,0,593,151,1,0,0,0,594,595,5,41,0,0,595,153,1,0,
		0,0,596,597,5,44,0,0,597,155,1,0,0,0,598,599,5,97,0,0,599,600,5,115,0,
		0,600,157,1,0,0,0,601,602,5,115,0,0,602,603,5,116,0,0,603,604,5,114,0,
		0,604,605,5,105,0,0,605,606,5,110,0,0,606,607,5,103,0,0,607,608,1,0,0,
		0,608,609,6,73,20,0,609,159,1,0,0,0,610,611,5,110,0,0,611,612,5,117,0,
		0,612,613,5,109,0,0,613,614,5,98,0,0,614,615,5,101,0,0,615,616,5,114,0,
		0,616,617,1,0,0,0,617,618,6,74,20,0,618,161,1,0,0,0,619,620,5,98,0,0,620,
		621,5,111,0,0,621,622,5,111,0,0,622,623,5,108,0,0,623,624,1,0,0,0,624,
		625,6,75,20,0,625,163,1,0,0,0,626,632,5,34,0,0,627,631,8,9,0,0,628,629,
		5,92,0,0,629,631,7,10,0,0,630,627,1,0,0,0,630,628,1,0,0,0,631,634,1,0,
		0,0,632,630,1,0,0,0,632,633,1,0,0,0,633,635,1,0,0,0,634,632,1,0,0,0,635,
		636,5,34,0,0,636,165,1,0,0,0,637,638,3,18,3,0,638,167,1,0,0,0,639,640,
		5,125,0,0,640,641,1,0,0,0,641,642,6,78,7,0,642,169,1,0,0,0,643,644,5,62,
		0,0,644,645,5,62,0,0,645,646,1,0,0,0,646,647,6,79,21,0,647,648,6,79,7,
		0,648,649,6,79,7,0,649,171,1,0,0,0,650,651,5,36,0,0,651,652,3,18,3,0,652,
		173,1,0,0,0,653,654,5,46,0,0,654,175,1,0,0,0,655,661,3,178,83,0,656,657,
		3,178,83,0,657,658,5,46,0,0,658,659,3,178,83,0,659,661,1,0,0,0,660,655,
		1,0,0,0,660,656,1,0,0,0,661,177,1,0,0,0,662,664,3,180,84,0,663,662,1,0,
		0,0,664,665,1,0,0,0,665,663,1,0,0,0,665,666,1,0,0,0,666,179,1,0,0,0,667,
		668,7,11,0,0,668,181,1,0,0,0,669,670,3,16,2,0,670,183,1,0,0,0,671,672,
		3,12,0,0,672,673,1,0,0,0,673,674,6,86,0,0,674,185,1,0,0,0,675,676,5,105,
		0,0,676,677,5,102,0,0,677,678,1,0,0,0,678,679,7,12,0,0,679,680,1,0,0,0,
		680,681,6,87,13,0,681,187,1,0,0,0,682,683,5,101,0,0,683,684,5,108,0,0,
		684,685,5,115,0,0,685,686,5,101,0,0,686,687,5,105,0,0,687,688,5,102,0,
		0,688,689,1,0,0,0,689,690,7,12,0,0,690,691,1,0,0,0,691,692,6,88,13,0,692,
		189,1,0,0,0,693,694,5,101,0,0,694,695,5,108,0,0,695,696,5,115,0,0,696,
		697,5,101,0,0,697,699,1,0,0,0,698,700,7,12,0,0,699,698,1,0,0,0,699,700,
		1,0,0,0,700,191,1,0,0,0,701,702,5,115,0,0,702,703,5,101,0,0,703,704,5,
		116,0,0,704,705,1,0,0,0,705,706,7,12,0,0,706,707,1,0,0,0,707,708,6,90,
		13,0,708,193,1,0,0,0,709,710,5,101,0,0,710,711,5,110,0,0,711,712,5,100,
		0,0,712,713,5,105,0,0,713,714,5,102,0,0,714,195,1,0,0,0,715,716,5,99,0,
		0,716,717,5,97,0,0,717,718,5,108,0,0,718,719,5,108,0,0,719,720,1,0,0,0,
		720,721,7,12,0,0,721,722,1,0,0,0,722,723,6,92,13,0,723,197,1,0,0,0,724,
		725,5,100,0,0,725,726,5,101,0,0,726,727,5,99,0,0,727,728,5,108,0,0,728,
		729,5,97,0,0,729,730,5,114,0,0,730,731,5,101,0,0,731,732,1,0,0,0,732,733,
		7,12,0,0,733,734,1,0,0,0,734,735,6,93,13,0,735,199,1,0,0,0,736,737,5,106,
		0,0,737,738,5,117,0,0,738,739,5,109,0,0,739,740,5,112,0,0,740,741,1,0,
		0,0,741,742,7,12,0,0,742,743,1,0,0,0,743,744,6,94,22,0,744,201,1,0,0,0,
		745,746,5,100,0,0,746,747,5,101,0,0,747,748,5,116,0,0,748,749,5,111,0,
		0,749,750,5,117,0,0,750,751,5,114,0,0,751,752,1,0,0,0,752,753,7,12,0,0,
		753,754,1,0,0,0,754,755,6,95,22,0,755,203,1,0,0,0,756,757,5,114,0,0,757,
		758,5,101,0,0,758,759,5,116,0,0,759,760,5,117,0,0,760,761,5,114,0,0,761,
		762,5,110,0,0,762,764,1,0,0,0,763,765,7,12,0,0,764,763,1,0,0,0,764,765,
		1,0,0,0,765,205,1,0,0,0,766,767,5,101,0,0,767,768,5,110,0,0,768,769,5,
		117,0,0,769,770,5,109,0,0,770,771,1,0,0,0,771,772,7,12,0,0,772,773,1,0,
		0,0,773,774,6,97,23,0,774,207,1,0,0,0,775,776,5,99,0,0,776,777,5,97,0,
		0,777,778,5,115,0,0,778,779,5,101,0,0,779,780,1,0,0,0,780,781,7,12,0,0,
		781,782,1,0,0,0,782,783,6,98,13,0,783,209,1,0,0,0,784,785,5,101,0,0,785,
		786,5,110,0,0,786,787,5,100,0,0,787,788,5,101,0,0,788,789,5,110,0,0,789,
		790,5,117,0,0,790,791,5,109,0,0,791,793,1,0,0,0,792,794,7,12,0,0,793,792,
		1,0,0,0,793,794,1,0,0,0,794,211,1,0,0,0,795,796,5,108,0,0,796,797,5,111,
		0,0,797,798,5,99,0,0,798,799,5,97,0,0,799,800,5,108,0,0,800,801,1,0,0,
		0,801,802,7,12,0,0,802,213,1,0,0,0,803,804,5,62,0,0,804,805,5,62,0,0,805,
		806,1,0,0,0,806,807,6,101,7,0,807,215,1,0,0,0,808,809,5,123,0,0,809,810,
		1,0,0,0,810,811,6,102,24,0,811,812,6,102,25,0,812,813,6,102,13,0,813,217,
		1,0,0,0,814,815,9,0,0,0,815,816,1,0,0,0,816,817,6,103,26,0,817,818,6,103,
		25,0,818,219,1,0,0,0,819,820,3,16,2,0,820,221,1,0,0,0,821,822,5,62,0,0,
		822,823,5,62,0,0,823,824,1,0,0,0,824,825,6,105,7,0,825,223,1,0,0,0,826,
		827,5,123,0,0,827,828,1,0,0,0,828,829,6,106,13,0,829,225,1,0,0,0,830,832,
		8,13,0,0,831,830,1,0,0,0,832,833,1,0,0,0,833,831,1,0,0,0,833,834,1,0,0,
		0,834,227,1,0,0,0,835,836,3,16,2,0,836,229,1,0,0,0,837,838,3,18,3,0,838,
		839,1,0,0,0,839,840,6,109,27,0,840,841,6,109,7,0,841,231,1,0,0,0,842,843,
		5,62,0,0,843,844,5,62,0,0,844,845,1,0,0,0,845,846,6,110,21,0,846,847,6,
		110,7,0,847,233,1,0,0,0,848,849,3,18,3,0,849,850,1,0,0,0,850,851,6,111,
		27,0,851,852,6,111,7,0,852,235,1,0,0,0,853,854,3,52,20,0,854,855,1,0,0,
		0,855,856,6,112,18,0,856,857,6,112,28,0,857,237,1,0,0,0,858,859,5,62,0,
		0,859,860,5,62,0,0,860,861,1,0,0,0,861,862,6,113,21,0,862,863,6,113,7,
		0,863,239,1,0,0,0,46,0,1,2,3,4,5,6,7,8,9,10,11,243,253,259,263,268,275,
		278,282,287,299,311,387,421,424,474,501,508,515,523,528,533,540,547,553,
		559,565,630,632,660,665,699,764,793,833,29,0,1,0,0,3,0,0,2,0,5,2,0,5,1,
		0,5,6,0,7,6,0,4,0,0,7,5,0,5,8,0,7,10,0,5,5,0,5,3,0,5,7,0,7,21,0,5,4,0,
		6,0,0,2,5,0,7,17,0,7,16,0,7,58,0,7,79,0,5,11,0,5,10,0,7,82,0,2,9,0,7,83,
		0,7,7,0,2,7,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Yarn.Compiler
