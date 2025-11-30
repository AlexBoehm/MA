using Lib.MVU;
using System.Collections.Immutable;

namespace BlazorDSL.Components.Pages.Todo;

partial class TodoPage
{
    public static (State, Command<Message>) Init() =>
        (InitState(), Commands.LoadItemsFromDatabase());

    static State InitState() =>
        new State(
            TodoItems: ImmutableList<TodoItem>.Empty,
            InputText: "",
            FilterText: ""
        );
}
