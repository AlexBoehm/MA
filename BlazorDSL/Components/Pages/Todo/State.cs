using System.Collections.Immutable;

namespace BlazorDSL.Components.Pages.Todo;

public record State(
    ImmutableList<TodoItem> TodoItems,
    string InputText,
    string FilterText
);

public record TodoItem(
    int Id,
    string Text,
    bool Done
);
