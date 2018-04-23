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
            Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim SideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim SeriesPoint12 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("A", New Object() {CType(15.5R, Object)})
            Dim SeriesPoint13 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("B", New Object() {CType(8.7R, Object)})
            Dim SeriesPoint14 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("C", New Object() {CType(16.7R, Object)})
            Dim SeriesPoint15 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("D", New Object() {CType(14.3R, Object)})
            Dim SeriesPoint16 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("E", New Object() {CType(12.1R, Object)})
            Dim SeriesPoint17 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("F", New Object() {CType(13.7R, Object)})
            Dim SeriesPoint18 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("G", New Object() {CType(14.2R, Object)})
            Dim SeriesPoint19 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("H", New Object() {CType(10.8R, Object)})
            Dim SeriesPoint20 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("I", New Object() {CType(15.2R, Object)})
            Dim SeriesPoint21 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("J", New Object() {CType(12.3R, Object)})
            Dim SeriesPoint22 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("K", New Object() {CType(10.1R, Object)})
            Dim SideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim SideBySideBarSeriesLabel4 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            XyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
            XyDiagram2.AxisX.Range.SideMarginsEnabled = True
            XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
            XyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
            XyDiagram2.AxisY.Range.SideMarginsEnabled = True
            XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = XyDiagram2
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.Visible = False
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PaletteName = "In A Fog"
            SideBySideBarSeriesLabel3.LineVisible = True
            Series2.Label = SideBySideBarSeriesLabel3
            Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Series2.Name = "Series 1"
            Series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint12, SeriesPoint13, SeriesPoint14, SeriesPoint15, SeriesPoint16, SeriesPoint17, SeriesPoint18, SeriesPoint19, SeriesPoint20, SeriesPoint21, SeriesPoint22})
            SideBySideBarSeriesView2.ColorEach = True
            Series2.View = SideBySideBarSeriesView2
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
            SideBySideBarSeriesLabel4.LineVisible = True
            Me.chartControl1.SeriesTemplate.Label = SideBySideBarSeriesLabel4
            Me.chartControl1.Size = New System.Drawing.Size(542, 328)
            Me.chartControl1.TabIndex = 0
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(542, 328)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
		Private toolTipController1 As DevExpress.Utils.ToolTipController
	End Class
End Namespace

