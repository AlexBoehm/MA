using Microsoft.AspNetCore.Components;

namespace BlazorDSL;
public static partial class Html {
     public static Node Component<TComponent>()
        => new ComponentNode(typeof(TComponent));

    public static Node Component<TComponent>(IComponentRenderMode renderMode)
        => new ComponentNode(typeof(TComponent), Array.Empty<Attribute>(), renderMode);

    public static Node Component<TComponent>(IComponentRenderMode renderMode, Attribute[] parameters)
        => new ComponentNode(typeof(TComponent), parameters, renderMode);

    public static Node Component<TComponent>(Attribute[] parameters, params Node[] childContent)
        => new ComponentNode(
            typeof(TComponent),
            childContent.Length == 0
                ? parameters
                : parameters.Concat([templateParameter("ChildContent", childContent)]).ToArray()
            );

    public static Node Component<TComponent>(IComponentRenderMode renderMode, Attribute[] parameters, params Node[] childContent)
        => new ComponentNode(
            typeof(TComponent),
            childContent.Length == 0
                ? parameters
                : parameters.Concat([templateParameter("ChildContent", childContent)]).ToArray(),
            renderMode
        )
    ;
}