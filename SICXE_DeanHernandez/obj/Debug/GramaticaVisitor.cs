//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Lepo-lap\Desktop\SICXE\SICXE_DeanHernandez\SICXE_DeanHernandez\Gramatica.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace SICXE_DeanHernandez {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="GramaticaParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IGramaticaVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.programa"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrograma([NotNull] GramaticaParser.ProgramaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.inicio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInicio([NotNull] GramaticaParser.InicioContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.fin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFin([NotNull] GramaticaParser.FinContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.proposiciones"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProposiciones([NotNull] GramaticaParser.ProposicionesContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.proposicion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProposicion([NotNull] GramaticaParser.ProposicionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.saltoLinea"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSaltoLinea([NotNull] GramaticaParser.SaltoLineaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirectiva([NotNull] GramaticaParser.DirectivaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.tipodirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTipodirectiva([NotNull] GramaticaParser.TipodirectivaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.byte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitByte([NotNull] GramaticaParser.ByteContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.word"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWord([NotNull] GramaticaParser.WordContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.resb"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitResb([NotNull] GramaticaParser.ResbContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.resw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitResw([NotNull] GramaticaParser.ReswContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.base"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBase([NotNull] GramaticaParser.BaseContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.instruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInstruccion([NotNull] GramaticaParser.InstruccionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.formato"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFormato([NotNull] GramaticaParser.FormatoContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.f1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitF1([NotNull] GramaticaParser.F1Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.f2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitF2([NotNull] GramaticaParser.F2Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.f3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitF3([NotNull] GramaticaParser.F3Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.f4"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitF4([NotNull] GramaticaParser.F4Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.simple3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimple3([NotNull] GramaticaParser.Simple3Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.indirecto3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIndirecto3([NotNull] GramaticaParser.Indirecto3Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.inmediato3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInmediato3([NotNull] GramaticaParser.Inmediato3Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.simple4"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimple4([NotNull] GramaticaParser.Simple4Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.indirecto4"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIndirecto4([NotNull] GramaticaParser.Indirecto4Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.inmediato4"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInmediato4([NotNull] GramaticaParser.Inmediato4Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.num"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNum([NotNull] GramaticaParser.NumContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.etiqueta"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEtiqueta([NotNull] GramaticaParser.EtiquetaContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.const"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConst([NotNull] GramaticaParser.ConstContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramaticaParser.reg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReg([NotNull] GramaticaParser.RegContext context);
}
} // namespace SICXE_DeanHernandez
