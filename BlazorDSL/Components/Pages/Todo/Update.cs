using Lib.MVU;
using System.Collections.Immutable;

namespace BlazorDSL.Components.Pages.Todo;

partial class TodoPage
{
    internal static (State state, Command<Message> command) Update(State state, Message message) =>
        message switch
        {
            AddItem msg => (
                state with
                {
                    InputText = ""
                },
                Commands.AddNewItem(msg.text)
            ),

            ItemAdded msg => (
                state with
                {
                    TodoItems = state.TodoItems.Add(msg.item)
                },
                Cmd<Message>.None
            ),

            RemoveItem msg => (
                state with
                {
                    TodoItems = state.TodoItems.Remove(msg.item)
                },
                Commands.RemoveItem(msg)
            ),

            RemoveDoneItems msg => (
                state,
                Commands.RemoveDoneItems(state)
            ),

            DoneItemsRemoved msg => (
                state with { 
                    TodoItems =
                        state.TodoItems.RemoveAll(
                            item => msg.ids.Contains(item.Id)
                        )
                },
                Cmd<Message>.None
            ),

            SetItemStatus msg => (
                state with
                {
                    TodoItems = 
                        state.TodoItems.Replace(
                            msg.item,
                            msg.item with { Done = msg.status }
                        )
                },
                Commands.SetItemStatus(msg)
            ),

            ChangeItemText msg => (
                state with
                {
                    TodoItems = state.TodoItems.Replace(
                        msg.item,
                        msg.item with { Text = msg.text }
                    )
                },
                Commands.ChangeItemText(msg)
            ),

            SetInputText msg => (
                state with { InputText = msg.text },
                Cmd<Message>.None
            ),

            ItemsFromDatabaseLoaded msg => (
                state with
                {
                    TodoItems = ImmutableList<TodoItem>.Empty.AddRange(msg.items)
                },
                Cmd<Message>.None
            ),

            SetFilter msg => (
                state with { FilterText = msg.filter },
                Cmd<Message>.None
            )
        };
}
