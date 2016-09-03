' Joshua Pickenpaugh
' September 3rd, 2016
' "Starbeans", Unit 3, CPT 432

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' Closes the application:
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        ' Creates local constant: 
        Const dblPRICE_PER_POUND As Double = 11.65

        ' Creates local variables: 
        Dim dblCaff As Double
        Dim dblDecaf As Double
        Dim dblTotalPounds As Double
        Dim dblTotalPrice As Double

        ' Assigns variables to text boxes, parses to double(s):
        Double.TryParse(txtCaff.Text, dblCaff)
        Double.TryParse(txtDecaf.Text, dblDecaf)

        ' Computes:
        dblTotalPounds = dblCaff + dblDecaf
        dblTotalPrice = dblTotalPounds * dblPRICE_PER_POUND

        ' Outputs to labels:
        lblTotalPounds.Text = dblTotalPounds
        lblTotalPrice.Text = dblTotalPrice

    End Sub
End Class
