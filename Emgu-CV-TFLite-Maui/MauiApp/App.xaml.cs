using Emgu.TF.Lite;

namespace EmguMauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

#if __ANDROID__ || __IOS__ || __MACCATALYST__ || WINDOWS
            Emgu.TF.Lite.Platform.Maui.MauiInvoke.Init();
            Emgu.CV.Platform.Maui.MauiInvoke.Init();
#endif            
        }
		
		protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}
