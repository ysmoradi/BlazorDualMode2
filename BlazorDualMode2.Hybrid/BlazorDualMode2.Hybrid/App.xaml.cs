using Microsoft.Maui;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;

namespace BlazorDualMode2.Hybrid
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();
        }

        protected override IWindow CreateWindow(IActivationState activationState)
        {
            Microsoft.Maui.Controls.Compatibility.Forms.Init(activationState);

            On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>()
                .SetImageDirectory("Assets");

            return new Microsoft.Maui.Controls.Window(new MainPage());
        }
    }
}
