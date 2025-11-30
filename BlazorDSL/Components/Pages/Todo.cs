using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using static BlazorDSL.Html;

namespace BlazorDSL.Components.Pages;

[Route("/todo")]
public partial class Todo : WebComponent
{        
    protected override Node Render() =>
        Tags(
            h2("Todo-Liste DSL"),

            div([className("TodoList")],
                ul(
                    from item in _items
                    select li([className(item.Done ? "Done" : "")],
                        input([
                            type("checkbox"),
                            bind.change.@checked(this, item.Done, newValue => item.Done = newValue)                            
                        ]),
                        div(item.Text)
                    )
                ),

                div([className("DoneDisplay")],
                    text($"Erledigt: {_items.Count(x => x.Done)}/{_items.Count}")
                ),

                form(
                    [onSubmit(this, e => AddItem())],
                    input([
                        type("text"),
                        bind.input.@string(this, this.inputValue, newValue => this.inputValue = newValue)                        
                    ]),
                    button([type("submit")], "Hinzufügen")
                )
            )
        );

    private List<TodoItem> _items = [
        new TodoItem { Text = "Aufgabe 1", Done = true },
        new TodoItem { Text = "Aufgabe 2", Done = false },
        new TodoItem { Text = "Aufgabe 3", Done = false }
    ];

    private string inputValue = "";

    private void AddItem()
    {
        _items.Add(new TodoItem
        {
            Text = inputValue,
            Done = false
        });

        inputValue = "";
    }

    public class TodoItem
    {
        public string Text { get; set; } = "";
        public bool Done { get; set; }
    }
}