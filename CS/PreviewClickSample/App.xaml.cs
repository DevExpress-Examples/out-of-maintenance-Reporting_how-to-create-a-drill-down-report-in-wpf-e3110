using System;
using System.Windows;
using DevExpress.Xpf.Core;

namespace PreviewClickSample {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        protected override void OnActivated(EventArgs e) {
            ThemeManager.ApplicationThemeName = "Azure";
        }
    }
}
