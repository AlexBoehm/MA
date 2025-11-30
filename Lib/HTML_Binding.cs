namespace BlazorDSL;

public static partial class Html
{
    public static class bind
    {
        public static class change
        {
            public static Attribute @checked(object receiver, bool value, Action<bool> onChange)            
                => new BindAttribute<bool>(receiver, "onchange", value, onChange);

            public static Attribute text(object receiver, string value, Action<string> onChange)
                => new BindAttribute<string>(receiver, "onchange", value, onChange);
        }

        public static class input
        {
            public static Attribute @string(object receiver, string value, Action<string> onChange)
                => new BindAttribute<string>(receiver, "oninput", value, onChange);
        }
    }
}
