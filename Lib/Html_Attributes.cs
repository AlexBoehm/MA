namespace BlazorDSL;

public static partial class Html {
     public static Attribute id(string value)
        => new Attribute("id", value);

    public static Attribute className(string value)
        => new Attribute("class", value);

    public static Attribute lang(string value)
        => new Attribute("lang", value);

    public static Attribute charset(string value)
        => new Attribute("charset", value);

    public static Attribute name(string value)
        => new Attribute("name", value);

    public static Attribute content(string value)
        => new Attribute("content", value);

    public static Attribute href(string value)
        => new Attribute("href", value);

    public static Attribute link(string value)
        => new Attribute("link", value);

    public static Attribute rel(string value)
        => new Attribute("rel", value);

    public static Attribute type(string value)
        => new Attribute("type", value);

    public static Attribute src(string value)
        => new Attribute("src", value);

    public static Attribute target(string value)
        => new Attribute("target", value);
}

