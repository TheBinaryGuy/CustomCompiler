namespace CustomCompiler.CodeAnalysis;

sealed class NumberExpressionSyntax : ExpressionSyntax
{
    public override SyntaxKind Kind => SyntaxKind.NumberExpression;

    public SyntaxToken NumberToken { get; }

    public NumberExpressionSyntax(SyntaxToken numberToken)
    {
        NumberToken = numberToken;
    }

    public override IEnumerable<SyntaxNode> GetChildren()
    {
        yield return NumberToken;
    }
}
