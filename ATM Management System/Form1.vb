Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        MyProgress.Increment(1)
        Dim per As String
        per = Convert.ToString(MyProgress.Value)
        PercentLbl.Text = per + "%"
        If MyProgress.Value = 100 Then
            Me.Hide()
            Login.Show()
            Timer1.Enabled = False
        End If
    End Sub
End Class
