namespace CustomCompiler.CodeAnalysis;

class SyntaxToken : SyntaxNode
{
    public override SyntaxKind Kind { get; }
    public int Position { get; set; }
    public string? Text { get; set; }
    public object? Value { get; set; }

    public SyntaxToken(SyntaxKind kind, int position, string? text, object? value)
    {
        Text = text;
        Position = position;
        Kind = kind;
        Value = value;
    }

    public override IEnumerable<SyntaxNode> GetChildren()
    {
        return Enumerable.Empty<SyntaxNode>();
    }
}
