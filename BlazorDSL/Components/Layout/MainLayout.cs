using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using static BlazorDSL.Html;

namespace BlazorDSL.Components.Layout;

public partial class MainLayout : LayoutComponentBase
{
    protected override void BuildRenderTree(RenderTreeBuilder builder) {
        var content = Render();
        Renderer.Render(builder, content);
    }

    Node Render() =>
        Tags(
            div([className("page")],
                div([className("sidebar")],
                    Component<NavMenu>()
                ),
                main([],
                    div([className("top-row px-4")],
                        a(
                            [
                                href("https://learn.microsoft.com/aspnet/core/"),
                                target("_blank")
                            ],
                            "About"
                        )
                    ),
                    article([className("content px-4")],
                        fragment(Body)
                    )
                )
            ),
            div([id("blazor-error-ui")],
                text("An unhandled error has occurred."),
                a([className("reload"), href("")], "Reload"),
                a([className("dismiss")], "🗙")
            )
        );
}
