using Microsoft.AspNetCore.Components;
using System.Diagnostics;

namespace Lib.MVU
{
    public class MVUBlazorComponent<TState, TMessage> : ComponentBase
    {
        protected TState state;
        protected Dispatch<TMessage> dispatch;
        protected Action initialize;

        protected override void OnInitialized()
        {
            initialize();
            base.OnInitialized();
        }

        protected void RenderComponent()
        {
            InvokeAsync(() => {
                try {
                    StateHasChanged();
                } catch (Exception e) {
                    Debug.WriteLine(e.Message);
                    Debug.WriteLine(e.StackTrace);
                }
            });
        }
    }
}
