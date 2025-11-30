namespace BlazorDSL;
public static partial class Html {
    public static Node div(Attribute[] attributes, params Node[] inner)
        => new TagNode("div", attributes, inner);

    public static Node div(params Node[] inner) => new TagNode("div", inner);
    public static Node div(IEnumerable<Node> inner) => new TagNode("div", inner.ToArray());
    public static Node h1(string text) => new TagNode("h1", Html.text(text));
    public static Node text(string text) => new TextNode(text);
    public static Node p(string text) => new TagNode("p", Html.text(text));
    public static Node button(string text) => new TagNode("button", Html.text(text));
    public static Node button(Attribute[] attributes, string text)
        => new TagNode("button", attributes, Html.text(text));
    public static Node DocTypeHtml() => new TagNode("!DOCTYPE html");
    public static Node html(Attribute[] attributes, params Node[] inner) => new TagNode("html", inner);
    public static Node head(params Node[] inner) => new TagNode("div", inner);
    public static Node meta(Attribute[] attributes, params Node[] inner)
        => new TagNode("meta", attributes, inner);
    public static Node @base(Attribute[] attributes, params Node[] inner)
        => new TagNode("base", attributes, inner);
    public static Node link(Attribute[] attributes, params Node[] inner)
        => new TagNode("link", attributes, inner);
    public static Node body(Attribute[] attributes, params Node[] inner)
        => new TagNode("body", attributes, inner);
    public static Node script(Attribute[] attributes, params Node[] inner)
        => new TagNode("script", attributes, inner);
    public static Node a(Attribute[] attributes, string text)
        => new TagNode("a", attributes, Html.text(text));

    public static Node main(Attribute[] attributes, params Node[] inner)
        => new TagNode("main", attributes, inner);

    public static Node article(Attribute[] attributes, params Node[] inner)
        => new TagNode("article", attributes, inner);
}