using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace antgsm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _ = InitializeWebViewAsync();
        }

        private async Task InitializeWebViewAsync()
        {
            // store the cookies and configuration etc...
            string temp = System.IO.Path.GetTempPath() + "antgsm";

            CoreWebView2Environment webview2Environment = await CoreWebView2Environment.CreateAsync(null, temp);
            await WebView21.EnsureCoreWebView2Async(webview2Environment);

            WebView21.Source = new Uri("https://www.antgsm.com/forum/");
        }
    }
}
