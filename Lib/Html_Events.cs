using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorDSL;

public static partial class Html {
    public static Attribute onClick(object sender, Action callback)
        => new Attribute(
            "onclick",
            EventCallback.Factory.Create<MouseEventArgs>(sender, callback)
        );
}