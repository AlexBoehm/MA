using Microsoft.AspNetCore.Components;
using static BlazorDSL.Html;

namespace BlazorDSL.Benchmarks.Components;

public class TodoComponentDSL : WebComponent
{
    [Parameter]
    public List<TodoItem> Items { get; set; } = [];

    private string _inputValue = "";

    protected override Node Render() =>
        div([className("todo-app")],
            h2(text("Todo-Liste")),
            div([className("todo-list")],
                ul(
                    from item in Items
                    select li([className(item.Done ? "done" : "")],
                        input([
                            type("checkbox"),
                            bind.change.@checked(item.Done, x => item.Done = x)
                        ]),
                        span(text(item.Text))
                    )
                ),
                div([className("stats")],
                    text($"Erledigt: {Items.Count(x => x.Done)}/{Items.Count}")
                ),
                form([onSubmit(AddItem)],
                    input([
                        type("text"),
                        bind.input.@string(_inputValue, x => _inputValue = x)
                    ]),
                    button([type("submit")], text("Hinzufügen"))
                )
            )
        );

    private void AddItem()
    {
        Items.Add(new TodoItem { Text = _inputValue, Done = false });
        _inputValue = "";
    }
}
