#Region "#usings"
Imports System
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
' ...
#End Region ' #usings

Namespace WindowsFormsApplication79
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#code"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            chartControl1.CrosshairEnabled = DefaultBoolean.False
            chartControl1.RuntimeHitTesting = True
        End Sub


        Private Sub chartControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chartControl1.MouseMove
            ' Obtain hit information under the test point.
            Dim hi As ChartHitInfo = chartControl1.CalcHitInfo(e.X, e.Y)

            ' Obtain the series point under the test point.
            Dim point As SeriesPoint = hi.SeriesPoint

            ' Check whether the series point was clicked or not.
            If point IsNot Nothing Then
                ' Obtain the series point argument.
                Dim argument As String = "Argument: " & point.Argument.ToString()

                ' Obtain series point values.
                Dim values As String = "Value(s): " & point.Values(0).ToString()
                If point.Values.Length > 1 Then
                    For i As Integer = 1 To point.Values.Length - 1
                        values = values & ", " & point.Values(i).ToString()
                    Next i
                End If

                ' Show the tooltip.
                toolTipController1.ShowHint(argument & ControlChars.Lf & values, "SeriesPoint Data")
            Else
                ' Hide the tooltip.
                toolTipController1.HideHint()
            End If
        End Sub
        #End Region ' #code

    End Class
End Namespace
