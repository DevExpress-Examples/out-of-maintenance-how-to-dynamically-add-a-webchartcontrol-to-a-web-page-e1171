Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web
' ...

Namespace WebChartDynamic
	Partial Public Class _Default
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			' Request the chart's image from the client side to the server. 
			WebChartControl.ProcessImageRequest(Me)
		End Sub

		Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create a WebChartControl instance.
			Dim WebChartControl1 As New WebChartControl()

			' Create a line series and add points to it.
			Dim series1 As New Series("My Series", ViewType.Line)
			series1.Points.Add(New SeriesPoint("A", New Double() { 2 }))
			series1.Points.Add(New SeriesPoint("B", New Double() { 7 }))
			series1.Points.Add(New SeriesPoint("C", New Double() { 5 }))
			series1.Points.Add(New SeriesPoint("D", New Double() { 9 }))

			' Add the series to the chart.
			WebChartControl1.Series.Add(series1)

			' Add the chart to the form.
			Me.form1.Controls.Add(WebChartControl1)
		End Sub

	End Class
End Namespace
