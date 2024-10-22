Imports System.Data.OleDb
Public Class Login
    Public AccountNum As String
    Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:\Users\Arun kumar\Documents\Visual Studio 2008\Projects\ATM Management System\ATMDate.accdb")
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Me.Hide()
        REGISTRATION.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If AccNumTxt.Text = "" Or PinCodeTxt.Text = "" Then
            MsgBox("Enter the Account Number & PIN Number ")
        Else
            con.open()
            Dim query = "select * from AccountHolder where AccNum=int('" & AccNumTxt.Text & "') and PIN='" & PinCodeTxt.Text & "'"
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(query, con)
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Wrong Account Number and PIN ")
            Else
                Dim obj = New MainForm
                obj.Acc = Int(AccNumTxt.Text)
                obj.Show()
                Me.Hide()
            End If
            con.close()
        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Application.Exit()
    End Sub
End Class