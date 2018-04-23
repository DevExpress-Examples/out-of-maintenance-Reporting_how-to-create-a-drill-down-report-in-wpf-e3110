using System.Collections.Generic;
using System.Windows.Input;
using DevExpress.Xpf.Printing;
// ...

namespace PreviewClickSample {
    public class MainWindowViewModel {
        readonly DrillDownReport report = new DrillDownReport();

        public XtraReportPreviewModel PreviewModel { get; private set; }

        public MainWindowViewModel() {
            PreviewModel = new XtraReportPreviewModel(report);
            PreviewModel.PreviewMouseMove += model_PreviewMouseMove;
            PreviewModel.PreviewClick += model_PreviewClick;
            report.CreateDocument();
        }

        void model_PreviewClick(object sender, PreviewClickEventArgs e) {
            int index;
            if(string.IsNullOrEmpty(e.ElementTag) || !int.TryParse(e.ElementTag, out index)) {
                return;
            }
            var expandedValues = (List<int>)report.Parameters["expandedValuesParameter"].Value;
            if(expandedValues.Contains(index)) {
                expandedValues.Remove(index);
            } else {
                expandedValues.Add(index);
            }
            report.CreateDocument(false);
        }

        void model_PreviewMouseMove(object sender, PreviewClickEventArgs e) {
            if(!string.IsNullOrEmpty(e.ElementTag)) {
                e.Element.Cursor = Cursors.Hand;
            }
        }
    }
}
