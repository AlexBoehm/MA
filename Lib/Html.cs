using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorDSL;

public static partial class Html {
    public static Node Tags(params Node[] nodes)
        => new ArrayNode(nodes.ToArray());

    public static Node Cond(bool condition, Func<Node> nodesTrue, Func<Node> nodeFalse)
        => new CondNode(condition, condition ? nodesTrue() : nodeFalse());

    public static Node empty() => EmptyNode.Instance;

    public static Attribute parameter(string name, object value)
        => new Attribute(name, value);

    public static Node text(string text)
        => new TextNode(text);

    public static Node DocTypeHtml() => new TagNode("!DOCTYPE html");

    #region templateParameter

    public static Attribute templateParameter(string key, params Node[] template)
        => new Attribute(
                key,
            (RenderFragment)(
                (RenderTreeBuilder builder) => {
                    Renderer.Render(builder, new ArrayNode(template));
                }
            )
        );

    public static Attribute templateParameter(string key, Func<Node> template)
        => new Attribute(
                key,                
            (RenderFragment)(
                (RenderTreeBuilder builder) => {
                    Renderer.Render(builder, template());
                }
            )
        );

    public static Attribute templateParameter<TContext>(string key, Func<TContext, Node> template)
        => new Attribute(
            key,                
            (RenderFragment<TContext>)(
                (TContext context) =>
                    (RenderTreeBuilder builder) => {
                        Renderer.Render(builder, template(context));
                    }
                )
            );

    #endregion    

    public static Node fragment(RenderFragment fragment)
        => new RenderFragmentNode(fragment);
    
}
