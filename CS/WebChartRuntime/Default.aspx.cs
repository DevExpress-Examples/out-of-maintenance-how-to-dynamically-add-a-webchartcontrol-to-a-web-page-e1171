using System;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;
// ...

namespace WebChartRuntime {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void ASPxButton1_Click(object sender, EventArgs e) {
            // Create a chart.
            WebChartControl WebChartControl1 = new WebChartControl();

            // Add the chart to the form.
            // Note that a chart isn't initialized until it's added to the form's collection of controls.
            this.form1.Controls.Add(WebChartControl1);

            // Create the first side-by-side bar series and add points to it.
            Series series1 = new Series("Side-by-Side Bar Series 1", ViewType.Bar);
            series1.Points.Add(new SeriesPoint("I", new double[] { 10 }));
            series1.Points.Add(new SeriesPoint("II", new double[] { 12 }));
            series1.Points.Add(new SeriesPoint("III", new double[] { 14 }));
            series1.Points.Add(new SeriesPoint("IV", new double[] { 17 }));

            // Create the second side-by-side bar series and add points to it.
            Series series2 = new Series("Side-by-Side Bar Series 2", ViewType.Bar);
            series2.Points.Add(new SeriesPoint("I", new double[] { 15 }));
            series2.Points.Add(new SeriesPoint("II", new double[] { 18 }));
            series2.Points.Add(new SeriesPoint("III", new double[] { 25 }));
            series2.Points.Add(new SeriesPoint("IV", new double[] { 33 }));

            // Add the series to the chart.
            WebChartControl1.Series.Add(series1);
            WebChartControl1.Series.Add(series2);

            // Hide the legend (if necessary).
            WebChartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Rotate the diagram (if necessary).
            ((XYDiagram)WebChartControl1.Diagram).Rotated = true;
        }

    }
}
