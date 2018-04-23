using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Printing;
using DevExpress.XtraReports.UI;
// ...

namespace PreviewClickSample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        readonly DrillDownReport report = new DrillDownReport();

        XtraReport Report {
            get {
                return report;
            }
        }

        public MainWindow() {
            InitializeComponent();
            ThemeManager.ApplicationThemeName = "Azure";
            Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e) {
            XtraReportPreviewModel model = new XtraReportPreviewModel(report);
            model.PreviewMouseMove += model_PreviewMouseMove;
            model.PreviewClick += model_PreviewClick;
            preview.Model = model;
            report.CreateDocument(false);
        }

        void model_PreviewClick(object sender, PreviewClickEventArgs e) {
            if (e.ElementTag != string.Empty) {
                List<int> expandedValues =
                    (List<int>)report.Parameters["expandedValuesParameter"].Value;
                int index;
                if (!int.TryParse(e.ElementTag, out index))
                    return;

                if (expandedValues.Contains(index)) {
                    expandedValues.Remove(index);
                }
                else {
                    expandedValues.Add(index);
                }
                Report.CreateDocument(false);
            }
        }

        void model_PreviewMouseMove(object sender, PreviewClickEventArgs e) {
            if (e.ElementTag != null && !e.ElementTag.Equals(string.Empty)) {
                e.Control.Cursor = Cursors.Hand;
            }
        }
    }
}
