Imports System.Data.OleDb
Public Class fastCash
    Public Acc As String
    Public MyAcc As Integer
    Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:\Users\Arun kumar\Documents\Visual Studio 2008\Projects\ATM Management System\ATMDate.accdb")
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BalanceLb.Click

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Dim main = New MainForm()
        main.Acc = Int(Acc)
        main.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Application.Exit()
    End Sub
    Dim OldBalance = 0
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
        BalanceLb.Text = Oldbalance
        con.close()
    End Sub

    Private Sub fastCash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getBalance()
        MyAcc = Convert.ToInt32(Acc)
    End Sub
    Dim Amount As Integer
    Private Sub updateBalance(ByVal Amt As Integer)
        Dim Account = Convert.ToInt32(Acc)
        Dim NewBal = OldBalance - Amt
        Try
            Dim Bal = 0
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OldBalance < 100 Then
            MsgBox("No Enough Money")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Amount = 100
            Try
                Dim Bal = 0
                con.open()
                Dim query = " insert into TransactionTbl values(int('" & MyAcc & "'),'" & TrType & "','" & Amount & "','" & System.DateTime.Today.Date & "')"
                Dim cmd As OleDbCommand
                cmd = New OleDbCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Succesfull")
                con.close()
                updateBalance(Amount)
                Dim main = New MainForm()
                main.Acc = Int(Acc)
                main.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If OldBalance < 500 Then
            MsgBox("No Enough Money")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Amount = 500
            Try
                ' Dim Bal = 0
                con.open()
                Dim query = " insert into TransactionTbl values(int('" & MyAcc & "'),'" & TrType & "','" & Amount & "','" & System.DateTime.Today.Date & "')"
                Dim cmd As OleDbCommand
                cmd = New OleDbCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Succesfull")
                con.close()
                updateBalance(Amount)
                Dim main = New MainForm()
                main.Acc = Int(Acc)
                main.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If OldBalance < 1000 Then
            MsgBox("No Enough Money")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Amount = 1000
            Try
                Dim Bal = 0
                con.open()
                Dim query = " insert into TransactionTbl values(int('" & MyAcc & "'),'" & TrType & "','" & Amount & "','" & System.DateTime.Today.Date & "')"
                Dim cmd As OleDbCommand
                cmd = New OleDbCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Succesfull")
                con.close()
                updateBalance(Amount)
                Dim main = New MainForm()
                main.Acc = Int(Acc)
                main.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If OldBalance < 2000 Then
            MsgBox("No Enough Money")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Amount = 2000
            Try
                Dim Bal = 0
                con.open()
                Dim query = " insert into TransactionTbl values(int('" & MyAcc & "'),'" & TrType & "','" & Amount & "','" & System.DateTime.Today.Date & "')"
                Dim cmd As OleDbCommand
                cmd = New OleDbCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Succesfull")
                con.close()
                updateBalance(Amount)
                Dim main = New MainForm()
                main.Acc = Int(Acc)
                main.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If OldBalance < 5000 Then
            MsgBox("No Enough Money")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Amount = 5000
            Try
                Dim Bal = 0
                con.open()
                Dim query = " insert into TransactionTbl values(int('" & MyAcc & "'),'" & TrType & "','" & Amount & "','" & System.DateTime.Today.Date & "')"
                Dim cmd As OleDbCommand
                cmd = New OleDbCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Succesfull")
                con.close()
                updateBalance(Amount)
                Dim main = New MainForm()
                main.Acc = Int(Acc)
                main.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If OldBalance < 10000 Then
            MsgBox("No Enough Money")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Amount = 10000
            Try
                Dim Bal = 0
                con.open()
                Dim query = " insert into TransactionTbl values(int('" & MyAcc & "'),'" & TrType & "','" & Amount & "','" & System.DateTime.Today.Date & "')"
                Dim cmd As OleDbCommand
                cmd = New OleDbCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Succesfull")
                con.close()
                updateBalance(Amount)
                Dim main = New MainForm()
                main.Acc = Int(Acc)
                main.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class