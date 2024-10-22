Imports System.Data.OleDb
Public Class MiniStatement

    Public Acc As String
    Public MyAcc As Integer
    Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:\Users\Arun kumar\Documents\Visual Studio 2008\Projects\ATM Management System\ATMDate.accdb")
    Private Sub Display()
        con.open()
        Dim query = " select * from TransactionTbl where AccNum=int('" & Acc & "')"
        Dim cmd As New OleDbCommand(query, con)
        Dim adp As OleDbDataAdapter
        adp = New OleDbDataAdapter(cmd)
        Dim builder As New OleDbCommandBuilder(adp)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.close()

    End Sub
    Private Sub MiniStatement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Display()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Application.Exit()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Dim main = New MainForm()
        main.Acc = Int(Acc)
        main.Show()
        Me.Hide()
    End Sub
End Class