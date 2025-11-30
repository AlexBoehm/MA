using static BlazorDSL.Html;

namespace BlazorDSL.Benchmarks.Components;

public class SimpleComponentDSL : WebComponent
{
    protected override Node Render() =>
        div([className("simple-component")],
            h1(text("Einfache Komponente")),
            p(text("Dies ist ein einfacher Absatz.")),
            div([className("content")],
                span(text("Text 1")),
                span(text("Text 2")),
                span(text("Text 3"))
            ),
            ul(
                li(text("Item 1")),
                li(text("Item 2")),
                li(text("Item 3"))
            )
        );
}
