var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

String msg = String.Format(
    "Emgu TF Lite v{0}{1}{1}Emgu CV BuildInformation{1}{2}",
    Emgu.TF.Lite.TfLiteInvoke.Version,
    Environment.NewLine,
    Emgu.CV.CvInvoke.BuildInformation);
app.MapGet("/", () => msg);

app.Run();
