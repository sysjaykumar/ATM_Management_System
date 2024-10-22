Imports System.Data.OleDb
Public Class ChangePin
    Public Acc As String
    Public MyAcc As Integer
    Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:\Users\Arun kumar\Documents\Visual Studio 2008\Projects\ATM Management System\ATMDate.accdb")
    Private Sub ChangePin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyAcc = Convert.ToInt32(Acc)
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Dim main = New MainForm()
        main.Acc = Int(Acc)
        Me.Hide()
        main.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Pin1Tb.Text = "" Or Pin2Tb.Text = "" Then
            MsgBox("Missing Information")
        ElseIf pin1tb.text = Pin2Tb.Text Then

            Try
                Dim Bal = 0
                con.open()
                Dim query = " update AccountHolder set PIN='" & Pin1Tb.Text & "' where AccNum=int('" & MyAcc & "')"
                Dim cmd As OleDbCommand
                cmd = New OleDbCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("PIN Change SuccessFull")
                con.close()
                Dim log = New Login
                log.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("PIN Does't Match")
        End If
    End Sub
End Class