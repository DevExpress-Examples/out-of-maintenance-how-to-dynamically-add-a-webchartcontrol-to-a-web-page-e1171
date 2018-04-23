Imports System
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web
' ...

Namespace WebChartRuntime
    Partial Public Class _Default
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Create a chart.
            Dim WebChartControl1 As New WebChartControl()

            ' Add the chart to the form.
            ' Note that a chart isn't initialized until it's added to the form's collection of controls.
            Me.form1.Controls.Add(WebChartControl1)

            ' Create the first side-by-side bar series and add points to it.
            Dim series1 As New Series("Side-by-Side Bar Series 1", ViewType.Bar)
            series1.Points.Add(New SeriesPoint("I", New Double() { 10 }))
            series1.Points.Add(New SeriesPoint("II", New Double() { 12 }))
            series1.Points.Add(New SeriesPoint("III", New Double() { 14 }))
            series1.Points.Add(New SeriesPoint("IV", New Double() { 17 }))

            ' Create the second side-by-side bar series and add points to it.
            Dim series2 As New Series("Side-by-Side Bar Series 2", ViewType.Bar)
            series2.Points.Add(New SeriesPoint("I", New Double() { 15 }))
            series2.Points.Add(New SeriesPoint("II", New Double() { 18 }))
            series2.Points.Add(New SeriesPoint("III", New Double() { 25 }))
            series2.Points.Add(New SeriesPoint("IV", New Double() { 33 }))

            ' Add the series to the chart.
            WebChartControl1.Series.Add(series1)
            WebChartControl1.Series.Add(series2)

            ' Hide the legend (if necessary).
            WebChartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False

            ' Rotate the diagram (if necessary).
            CType(WebChartControl1.Diagram, XYDiagram).Rotated = True
        End Sub

    End Class
End Namespace
