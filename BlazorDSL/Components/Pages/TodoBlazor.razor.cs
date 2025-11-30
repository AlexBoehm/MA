using BlazorDSL.Components.Pages.Todo;
using Lib.MVU;

namespace BlazorDSL.Components.Pages;

public partial class TodoBlazor : MVUBlazorComponent<Todo.State, Message>
{
    public TodoBlazor()
    {
        (base.state, base.initialize, base.dispatch) = MVUViewBuilder.BuildViewMethodBlazor(
            init: TodoPage.Init,
            update: TodoPage.Update,
            setState: state => this.state = state,
            renderComponent: base.RenderComponent
        );
    }
}
