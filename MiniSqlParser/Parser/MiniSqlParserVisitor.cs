//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from MiniSqlParser.g4 by ANTLR 4.9.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="MiniSqlParserParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.3")]
[System.CLSCompliant(false)]
public interface IMiniSqlParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.stmts_root"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStmts_root([NotNull] MiniSqlParserParser.Stmts_rootContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.stmt_root"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStmt_root([NotNull] MiniSqlParserParser.Stmt_rootContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.query_root"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQuery_root([NotNull] MiniSqlParserParser.Query_rootContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.predicate_root"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPredicate_root([NotNull] MiniSqlParserParser.Predicate_rootContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.expr_root"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr_root([NotNull] MiniSqlParserParser.Expr_rootContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.placeholder_root"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPlaceholder_root([NotNull] MiniSqlParserParser.Placeholder_rootContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.stmts"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStmts([NotNull] MiniSqlParserParser.StmtsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.scols"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScols([NotNull] MiniSqlParserParser.ScolsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.error"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitError([NotNull] MiniSqlParserParser.ErrorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStmt([NotNull] MiniSqlParserParser.StmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.stmt_sub"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStmt_sub([NotNull] MiniSqlParserParser.Stmt_subContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelect_stmt([NotNull] MiniSqlParserParser.Select_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.update_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUpdate_stmt([NotNull] MiniSqlParserParser.Update_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.insert_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInsert_stmt([NotNull] MiniSqlParserParser.Insert_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.replace_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReplace_stmt([NotNull] MiniSqlParserParser.Replace_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.delete_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDelete_stmt([NotNull] MiniSqlParserParser.Delete_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.merge_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMerge_stmt([NotNull] MiniSqlParserParser.Merge_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.merge_update_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMerge_update_clause([NotNull] MiniSqlParserParser.Merge_update_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.merge_insert_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMerge_insert_clause([NotNull] MiniSqlParserParser.Merge_insert_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.call_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCall_stmt([NotNull] MiniSqlParserParser.Call_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.truncate_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTruncate_stmt([NotNull] MiniSqlParserParser.Truncate_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.if_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIf_stmt([NotNull] MiniSqlParserParser.If_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.sqlite_pragma_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSqlite_pragma_stmt([NotNull] MiniSqlParserParser.Sqlite_pragma_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.null_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNull_stmt([NotNull] MiniSqlParserParser.Null_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.with_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWith_clause([NotNull] MiniSqlParserParser.With_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.with_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWith_definition([NotNull] MiniSqlParserParser.With_definitionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQuery([NotNull] MiniSqlParserParser.QueryContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ValueQueryClause</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.query_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValueQueryClause([NotNull] MiniSqlParserParser.ValueQueryClauseContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>CompoundQueryClause</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.query_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompoundQueryClause([NotNull] MiniSqlParserParser.CompoundQueryClauseContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BracketedQueryClause</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.query_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBracketedQueryClause([NotNull] MiniSqlParserParser.BracketedQueryClauseContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>SingleQueryClause</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.query_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSingleQueryClause([NotNull] MiniSqlParserParser.SingleQueryClauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.aliased_query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAliased_query([NotNull] MiniSqlParserParser.Aliased_queryContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.result_columns"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitResult_columns([NotNull] MiniSqlParserParser.Result_columnsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.result_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitResult_column([NotNull] MiniSqlParserParser.Result_columnContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.assignments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignments([NotNull] MiniSqlParserParser.AssignmentsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.column_names"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumn_names([NotNull] MiniSqlParserParser.Column_namesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.unqualified_column_names"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnqualified_column_names([NotNull] MiniSqlParserParser.Unqualified_column_namesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.values_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValues_clauses([NotNull] MiniSqlParserParser.Values_clausesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.value_columns"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValue_columns([NotNull] MiniSqlParserParser.Value_columnsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.value_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValue_column([NotNull] MiniSqlParserParser.Value_columnContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.exprs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprs([NotNull] MiniSqlParserParser.ExprsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExprArgument</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprArgument([NotNull] MiniSqlParserParser.ExprArgumentContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>PredicateArgument</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPredicateArgument([NotNull] MiniSqlParserParser.PredicateArgumentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArguments([NotNull] MiniSqlParserParser.ArgumentsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>JoinSource</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.join_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoinSource([NotNull] MiniSqlParserParser.JoinSourceContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>TableSource</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.join_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTableSource([NotNull] MiniSqlParserParser.TableSourceContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>SubQuerySource</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.join_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSubQuerySource([NotNull] MiniSqlParserParser.SubQuerySourceContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BracketedSource</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.join_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBracketedSource([NotNull] MiniSqlParserParser.BracketedSourceContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>CommaJoinSource</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.join_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCommaJoinSource([NotNull] MiniSqlParserParser.CommaJoinSourceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.join_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoin_constraint([NotNull] MiniSqlParserParser.Join_constraintContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.join_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoin_operator([NotNull] MiniSqlParserParser.Join_operatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.groupBy_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGroupBy_clause([NotNull] MiniSqlParserParser.GroupBy_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.orderBy_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrderBy_clause([NotNull] MiniSqlParserParser.OrderBy_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.ordering_term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrdering_term([NotNull] MiniSqlParserParser.Ordering_termContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.partitionBy_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPartitionBy_clause([NotNull] MiniSqlParserParser.PartitionBy_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.partitioning_term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPartitioning_term([NotNull] MiniSqlParserParser.Partitioning_termContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.declare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclare([NotNull] MiniSqlParserParser.DeclareContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParams([NotNull] MiniSqlParserParser.ParamsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.param"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParam([NotNull] MiniSqlParserParser.ParamContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.out_param"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOut_param([NotNull] MiniSqlParserParser.Out_paramContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.limit_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLimit_clause([NotNull] MiniSqlParserParser.Limit_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.for_update_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFor_update_clause([NotNull] MiniSqlParserParser.For_update_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.for_update_of_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFor_update_of_clause([NotNull] MiniSqlParserParser.For_update_of_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IsPredicate</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsPredicate([NotNull] MiniSqlParserParser.IsPredicateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BetweenPredicate</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBetweenPredicate([NotNull] MiniSqlParserParser.BetweenPredicateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExistsPredicate</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExistsPredicate([NotNull] MiniSqlParserParser.ExistsPredicateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>SubQueryPredicate</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSubQueryPredicate([NotNull] MiniSqlParserParser.SubQueryPredicateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AndPredicate</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAndPredicate([NotNull] MiniSqlParserParser.AndPredicateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LikePredicate</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLikePredicate([NotNull] MiniSqlParserParser.LikePredicateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>InPredicate</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInPredicate([NotNull] MiniSqlParserParser.InPredicateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NotPredicate</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNotPredicate([NotNull] MiniSqlParserParser.NotPredicateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>OrPredicate</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrPredicate([NotNull] MiniSqlParserParser.OrPredicateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BracketedPredicate</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBracketedPredicate([NotNull] MiniSqlParserParser.BracketedPredicateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BinaryOpPredicate</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBinaryOpPredicate([NotNull] MiniSqlParserParser.BinaryOpPredicateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>PhPredicate</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPhPredicate([NotNull] MiniSqlParserParser.PhPredicateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IsNullPredicate</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsNullPredicate([NotNull] MiniSqlParserParser.IsNullPredicateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>CollatePredicate</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCollatePredicate([NotNull] MiniSqlParserParser.CollatePredicateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExtractFuncExpr</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExtractFuncExpr([NotNull] MiniSqlParserParser.ExtractFuncExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Case1Expr</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCase1Expr([NotNull] MiniSqlParserParser.Case1ExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ColumnExpr</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumnExpr([NotNull] MiniSqlParserParser.ColumnExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>SubQueryExpr</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSubQueryExpr([NotNull] MiniSqlParserParser.SubQueryExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>WindowFuncExpr</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWindowFuncExpr([NotNull] MiniSqlParserParser.WindowFuncExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BracketedExpr</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBracketedExpr([NotNull] MiniSqlParserParser.BracketedExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>GenericFuncExpr</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGenericFuncExpr([NotNull] MiniSqlParserParser.GenericFuncExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>PostgreSqlCastExpr</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPostgreSqlCastExpr([NotNull] MiniSqlParserParser.PostgreSqlCastExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>SignedNumberExpr</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSignedNumberExpr([NotNull] MiniSqlParserParser.SignedNumberExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>PhExpr</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPhExpr([NotNull] MiniSqlParserParser.PhExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AggregateFuncExpr</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAggregateFuncExpr([NotNull] MiniSqlParserParser.AggregateFuncExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Case2Expr</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCase2Expr([NotNull] MiniSqlParserParser.Case2ExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BitwiseNotExpr</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBitwiseNotExpr([NotNull] MiniSqlParserParser.BitwiseNotExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>SubstrFuncExpr</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSubstrFuncExpr([NotNull] MiniSqlParserParser.SubstrFuncExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>CastExpr</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCastExpr([NotNull] MiniSqlParserParser.CastExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LiteralExpr</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralExpr([NotNull] MiniSqlParserParser.LiteralExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BinaryOpExpr</c>
	/// labeled alternative in <see cref="MiniSqlParserParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBinaryOpExpr([NotNull] MiniSqlParserParser.BinaryOpExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.substring_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSubstring_function([NotNull] MiniSqlParserParser.Substring_functionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.extract_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExtract_function([NotNull] MiniSqlParserParser.Extract_functionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.aggregate_function1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAggregate_function1([NotNull] MiniSqlParserParser.Aggregate_function1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.aggregate_function2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAggregate_function2([NotNull] MiniSqlParserParser.Aggregate_function2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.window_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWindow_function([NotNull] MiniSqlParserParser.Window_functionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.generic_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGeneric_function([NotNull] MiniSqlParserParser.Generic_functionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.qualified_schema_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQualified_schema_name([NotNull] MiniSqlParserParser.Qualified_schema_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction_name([NotNull] MiniSqlParserParser.Function_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIndex_name([NotNull] MiniSqlParserParser.Index_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTable_name([NotNull] MiniSqlParserParser.Table_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumn_name([NotNull] MiniSqlParserParser.Column_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.unqualified_column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnqualified_column_name([NotNull] MiniSqlParserParser.Unqualified_column_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.aliased_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAliased_table_name([NotNull] MiniSqlParserParser.Aliased_table_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.hinted_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHinted_table_name([NotNull] MiniSqlParserParser.Hinted_table_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.hinted_aliased_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHinted_aliased_table_name([NotNull] MiniSqlParserParser.Hinted_aliased_table_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.table_hint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTable_hint([NotNull] MiniSqlParserParser.Table_hintContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType_name([NotNull] MiniSqlParserParser.Type_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.collation_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCollation_name([NotNull] MiniSqlParserParser.Collation_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.constraint_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstraint_name([NotNull] MiniSqlParserParser.Constraint_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.table_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTable_alias([NotNull] MiniSqlParserParser.Table_aliasContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.column_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumn_alias([NotNull] MiniSqlParserParser.Column_aliasContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifier([NotNull] MiniSqlParserParser.IdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.identifiable_keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifiable_keyword([NotNull] MiniSqlParserParser.Identifiable_keywordContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.literal_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteral_value([NotNull] MiniSqlParserParser.Literal_valueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniSqlParserParser.datetimeField"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDatetimeField([NotNull] MiniSqlParserParser.DatetimeFieldContext context);
}
