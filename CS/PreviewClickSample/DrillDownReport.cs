using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using DevExpress.XtraReports.UI;
// ...

namespace PreviewClickSample {
    public partial class DrillDownReport : DevExpress.XtraReports.UI.XtraReport {
        const string sShowDetail = "Show Detail";
        const string sHideDetail = "Hide Detail";

        public DrillDownReport() {
            InitializeComponent();
            expandedValuesParameter.Type = typeof(List<int>);
            expandedValuesParameter.Value = new List<int>();
            lbShowHide.BeforePrint += lbShowHide_BeforePrint;
            DetailReport.BeforePrint += DetailReport_BeforePrint;
        }

        List<int> ExpandedValues {
            get {
                return (List<int>)expandedValuesParameter.Value;
            }
        }

        bool ShouldShowDetail(int catID) {
            return ExpandedValues.Contains(catID);
        }

        private void lbShowHide_BeforePrint(object sender, PrintEventArgs e) {
            XRLabel label = (XRLabel)sender;
            if (ShouldShowDetail((int)label.Tag)) {
                label.Text = sHideDetail;
            }
            else {
                label.Text = sShowDetail;
            }
        }

        private void DetailReport_BeforePrint(object sender, PrintEventArgs e) {
            e.Cancel = !ShouldShowDetail((int)GetCurrentColumnValue("CategoryID"));
        }

        // The following code populates the XRChart with data.
        private void xrChart1_BeforePrint(object sender, PrintEventArgs e) {
            var chart = ((XRChart)sender);
            chart.DataSource = (from p in nwindDataSet1.Products
                                where p.CategoryID == (int)GetCurrentColumnValue("CategoryID")
                                select new {
                                    CategoryID = p.CategoryID,
                                    ProductName = p.ProductName,
                                    UnitsInStock = p.UnitsInStock,
                                    myRow = p.UnitPrice * p.UnitsInStock
                                }).ToArray();

            chart.Series[1].ArgumentDataMember = "ProductName";
            chart.Series[1].ValueDataMembers.AddRange(new string[] { "myRow" });

            chart.Series[0].ArgumentDataMember = "ProductName";
            chart.Series[0].ValueDataMembers.AddRange(new string[] { "UnitsInStock" });
        }
    }
}
