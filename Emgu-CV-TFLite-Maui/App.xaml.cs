using Emgu.TF.Lite;

namespace EmguMauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            Emgu.TF.Lite.Platform.Maui.MauiInvoke.Init();
            Emgu.CV.Platform.Maui.MauiInvoke.Init();
            
            MainPage = new AppShell();
        }
    }
}
