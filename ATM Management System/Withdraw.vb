Imports System.Data.OleDb
Public Class Withdraw
    Public Acc As String
    Public MyAcc As Integer
    Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:\Users\Arun kumar\Documents\Visual Studio 2008\Projects\ATM Management System\ATMDate.accdb")
    Private Sub Withdraw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getBalance()
        MyAcc = Convert.ToInt32(Acc)
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Dim main = New MainForm()
        main.Acc = Int(Acc)
        main.Show()
        Me.Hide()
    End Sub
    Dim Oldbalance = 0
    Private Sub getBalance()
        con.open()
        Dim cmd As OleDbCommand
        Dim query = "select Balance from AccountHolder where AccNum=int('" & Acc & "')"
        cmd = New OleDbCommand(query, con)
        Dim adp = New OleDbDataAdapter(cmd)
        Dim dt As DataTable
        dt = New DataTable
        adp.Fill(dt)
        Oldbalance = Convert.ToInt32(dt.Rows(0)(0).ToString())
        AmountBal.Text = Oldbalance
        con.close()
    End Sub
    Private Sub updateBalance()
        Dim Account = Convert.ToInt32(Acc)
        Dim NewBal = Oldbalance - Convert.ToInt32(WithAmount.Text)
        Try
            'Dim Bal = 0
            con.open()
            Dim query = " update AccountHolder set Balance=" & NewBal & " where AccNum=" & Acc & ""
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Balance Updated ")
            con.close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If WithAmount.Text = "" Then
            MsgBox("Missing Information")
        ElseIf Convert.ToInt32(WithAmount.Text) > Oldbalance Then
            MsgBox("No Enough Maoney")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Try
                Dim Bal = 0
                con.open()
                Dim query = " insert into TransactionTbl values(int('" & MyAcc & "'),'" & TrType & "','" & WithAmount.Text & "','" & System.DateTime.Today.Date & "')"
                Dim cmd As OleDbCommand
                cmd = New OleDbCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Succesfull")
                con.close()
                updateBalance()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Application.Exit()
    End Sub
End Class