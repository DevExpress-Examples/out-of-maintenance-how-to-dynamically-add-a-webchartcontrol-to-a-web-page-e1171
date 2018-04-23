using System;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;
// ...

namespace WebChartDynamic {
    public partial class _Default : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            // Request the chart's image from the client side to the server. 
            WebChartControl.ProcessImageRequest(this);
        }

        protected void ASPxButton1_Click(object sender, EventArgs e) {
            // Create a WebChartControl instance.
            WebChartControl WebChartControl1 = new WebChartControl();

            // Create a line series and add points to it.
            Series series1 = new Series("My Series", ViewType.Line);
            series1.Points.Add(new SeriesPoint("A", new double[] { 2 }));
            series1.Points.Add(new SeriesPoint("B", new double[] { 7 }));
            series1.Points.Add(new SeriesPoint("C", new double[] { 5 }));
            series1.Points.Add(new SeriesPoint("D", new double[] { 9 }));

            // Add the series to the chart.
            WebChartControl1.Series.Add(series1);

            // Add the chart to the form.
            this.form1.Controls.Add(WebChartControl1);
        }

    }
}
