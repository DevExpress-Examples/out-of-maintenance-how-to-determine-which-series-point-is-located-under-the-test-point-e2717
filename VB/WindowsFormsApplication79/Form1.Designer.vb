Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication79
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim xyDiagram2 As New DevExpress.XtraCharts.XYDiagram()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesLabel3 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (CObj(15.5R))})
			Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (CObj(8.7R))})
			Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (CObj(16.7R))})
			Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (CObj(14.3R))})
			Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint("E", New Object() { (CObj(12.1R))})
			Dim seriesPoint17 As New DevExpress.XtraCharts.SeriesPoint("F", New Object() { (CObj(13.7R))})
			Dim seriesPoint18 As New DevExpress.XtraCharts.SeriesPoint("G", New Object() { (CObj(14.2R))})
			Dim seriesPoint19 As New DevExpress.XtraCharts.SeriesPoint("H", New Object() { (CObj(10.8R))})
			Dim seriesPoint20 As New DevExpress.XtraCharts.SeriesPoint("I", New Object() { (CObj(15.2R))})
			Dim seriesPoint21 As New DevExpress.XtraCharts.SeriesPoint("J", New Object() { (CObj(12.3R))})
			Dim seriesPoint22 As New DevExpress.XtraCharts.SeriesPoint("K", New Object() { (CObj(10.1R))})
			Dim sideBySideBarSeriesView2 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
			Dim sideBySideBarSeriesLabel4 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			xyDiagram2.AxisX.WholeRange.AutoSideMargins = True
			xyDiagram2.AxisX.VisualRange.AutoSideMargins = True
			xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram2.AxisY.WholeRange.AutoSideMargins = True
			xyDiagram2.AxisY.VisualRange.AutoSideMargins = True
			xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
			Me.chartControl1.Diagram = xyDiagram2
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Legend.Visible = False
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.PaletteName = "In A Fog"
			sideBySideBarSeriesLabel3.LineVisible = True
			series2.Label = sideBySideBarSeriesLabel3
			series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series2.Name = "Series 1"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20, seriesPoint21, seriesPoint22})
			sideBySideBarSeriesView2.ColorEach = True
			series2.View = sideBySideBarSeriesView2
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series2}
			sideBySideBarSeriesLabel4.LineVisible = True
			Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel4
			Me.chartControl1.Size = New System.Drawing.Size(491, 307)
			Me.chartControl1.TabIndex = 0
'			Me.chartControl1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.chartControl1_MouseMove);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(491, 307)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(xyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
		Private toolTipController1 As DevExpress.Utils.ToolTipController
	End Class
End Namespace

