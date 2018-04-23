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
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (CObj(15.5R))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (CObj(8.7R))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (CObj(16.7R))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (CObj(14.3R))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("E", New Object() { (CObj(12.1R))})
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("F", New Object() { (CObj(13.7R))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("G", New Object() { (CObj(14.2R))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("H", New Object() { (CObj(10.8R))})
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("I", New Object() { (CObj(15.2R))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("J", New Object() { (CObj(12.3R))})
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint("K", New Object() { (CObj(10.1R))})
			Dim sideBySideBarSeriesView1 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
			Dim sideBySideBarSeriesLabel2 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisX.Range.SideMarginsEnabled = True
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Legend.Visible = False
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.PaletteName = "In A Fog"
			sideBySideBarSeriesLabel1.LineVisible = True
			sideBySideBarSeriesLabel1.Visible = False
			series1.Label = sideBySideBarSeriesLabel1
			series1.Name = "Series 1"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11})
			sideBySideBarSeriesView1.ColorEach = True
			series1.View = sideBySideBarSeriesView1
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			sideBySideBarSeriesLabel2.LineVisible = True
			Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel2
			Me.chartControl1.Size = New System.Drawing.Size(459, 288)
			Me.chartControl1.TabIndex = 0
'			Me.chartControl1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.chartControl1_MouseMove);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(459, 288)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
		Private toolTipController1 As DevExpress.Utils.ToolTipController
	End Class
End Namespace

