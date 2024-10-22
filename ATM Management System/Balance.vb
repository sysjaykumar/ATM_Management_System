Imports System.Data.OleDb
Public Class Balance
    Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:\Users\Arun kumar\Documents\Visual Studio 2008\Projects\ATM Management System\ATMDate.accdb")
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Dim main = New MainForm()
        main.Acc = Int(AccNum.Text)
        Me.Hide()
        main.Show()
    End Sub
    Public Acc As String
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Application.Exit()
    End Sub

    Private Sub getBalance()
        con.open()
        Dim cmd As OleDbCommand
        Dim query = "select Balance from AccountHolder where AccNum=int('" & Account & "')"
        cmd = New OleDbCommand(query, con)
        Dim adp = New OleDbDataAdapter(cmd)
        Dim dt As DataTable
        dt = New DataTable
        adp.Fill(dt)
        Amount.Text = Convert.ToInt32(dt.Rows(0)(0).ToString())
        con.close()
    End Sub
    Dim Account As Integer
    Private Sub Balance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Account = Convert.ToInt32(Acc)
        AccNum.Text = Acc
        getBalance()
    End Sub
End Class