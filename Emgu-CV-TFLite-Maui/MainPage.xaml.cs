using Emgu.TF.Lite;

namespace EmguMauiApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            CounterBtn.Text = String.Format("Emgu TF Lite version: {0}\n\n\nEmgu CV Build Info: {1}", Emgu.TF.Lite.TfLiteInvoke.Version, Emgu.CV.CvInvoke.BuildInformation);
            
            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
