using System.Collections.Immutable;

namespace BlazorDSL.Components.Pages.Todo;

public abstract record Message();
record AddItem(string text) : Message;
record ItemAdded(TodoItem item) : Message;
record RemoveItem(TodoItem item) : Message;
record SetItemStatus(TodoItem item, bool status) : Message;
record ChangeItemText(TodoItem item, string text) : Message;
record RemoveDoneItems() : Message;
record DoneItemsRemoved(ImmutableList<int> ids) : Message;
record SetInputText(string text) : Message;
record ItemsFromDatabaseLoaded(ImmutableList<TodoItem> items) : Message;
record SetFilter(string filter) : Message;
