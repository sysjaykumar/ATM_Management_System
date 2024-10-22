Public Class MainForm
    Public Acc As String
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AccountNum.Text = Acc
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Me.Hide()
        Acc = AccountNum.Text
        Login.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim obj = New Deposit()
        obj.Acc = AccountNum.Text
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Application.Exit()
    End Sub

    
    Private Sub Balance_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Balance.Click
        Dim obj = New Balance()
        obj.Acc = AccountNum.Text
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim obj = New Withdraw()
        obj.Acc = AccountNum.Text
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim obj = New ChangePin()
        obj.Acc = AccountNum.Text
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim obj = New fastCash()
        obj.Acc = AccountNum.Text
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim obj = New MiniStatement()
        obj.Acc = AccountNum.Text
        obj.Show()
        Me.Hide()
    End Sub
End Class