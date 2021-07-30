using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace BlazorDualMode2.Hybrid
{
    public partial class App : Application
    {
        protected override Window CreateWindow(IActivationState activationState)
        {
            Microsoft.Maui.Controls.Compatibility.Forms.Init(activationState);

            BlazorWebView blazorWebView = new() { HostPage = "wwwroot/index.html" };
            blazorWebView.RootComponents.Add(new() { ComponentType = typeof(Main), Selector = "app" });

            return new Window(new ContentPage
            {
                Content = blazorWebView
            });
        }
    }
}
