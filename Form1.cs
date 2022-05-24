using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace TestWinFormsHybridBlazorPublish;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        
        var services = new ServiceCollection();
        services.AddWindowsFormsBlazorWebView();
        blazorWebView.HostPage = "wwwroot\\index.html";
        blazorWebView.Services = services.BuildServiceProvider();
        blazorWebView.RootComponents.Add<Counter>("#app");
    }
}