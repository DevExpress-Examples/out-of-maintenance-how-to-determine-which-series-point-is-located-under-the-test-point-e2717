#region #usings
using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...
#endregion #usings

namespace WindowsFormsApplication79 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

#region #code
private void chartControl1_MouseMove(object sender, MouseEventArgs e) {
    // Obtain hit information under the test point.
    ChartHitInfo hi = chartControl1.CalcHitInfo(e.X, e.Y);

    // Obtain the series point under the test point.
    SeriesPoint point = hi.SeriesPoint;

    // Check whether the series point was clicked or not.
    if (point != null) {
        // Obtain the series point argument.
        string argument = "Argument: " + point.Argument.ToString();

        // Obtain series point values.
        string values = "Value(s): " + point.Values[0].ToString();
        if (point.Values.Length > 1) {
            for (int i = 1; i < point.Values.Length; i++) {
                values = values + ", " + point.Values[i].ToString();
            }
        }

        // Show the tooltip.
        toolTipController1.ShowHint(argument + "\n" + values, "SeriesPoint Data");
    }
    else {
        // Hide the tooltip.
        toolTipController1.HideHint();
    }
}
#endregion #code
    }
}
