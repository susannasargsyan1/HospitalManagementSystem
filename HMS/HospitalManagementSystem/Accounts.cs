using System;
using System.Windows.Forms;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;

namespace Hospital_Management_System
{
    public partial class Accounts : Form
    {
        public Accounts()
        {
            InitializeComponent();

            // Initialize and configure the Blazor WebView
            var webView = new BlazorWebView();
            webView.Dock = DockStyle.Fill;
            webView.Location = new System.Drawing.Point(0, 0);
            webView.MinimumSize = new System.Drawing.Size(20, 20);
            webView.Name = "blazorWebView";
            webView.Size = new System.Drawing.Size(800, 600);
            webView.TabIndex = 0;
            webView.Text = "blazorWebView";
            webView.Url = "wwwroot/index.html"; // Replace with the path to your Blazor app's index.html
            webView.CreateHostBuilder = builder => builder.RootComponents.Add<App>("#app"); // Replace "App" with the root component of your Blazor app

            this.Controls.Add(webView);
        }
    }
}

