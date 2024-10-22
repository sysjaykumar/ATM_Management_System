﻿Imports System.Data.OleDb
Public Class Deposit
    Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:\Users\Arun kumar\Documents\Visual Studio 2008\Projects\ATM Management System\ATMDate.accdb")
    Private Sub BackLbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackLbl.Click
        Dim main = New MainForm()
        main.Acc = Int(MyAcc)
        main.Show()
        Me.Hide()
    End Sub

    Public Acc As String
    Dim Oldbalance = 0
    Private Sub getDeposit()
        con.open()
        Dim cmd As OleDbCommand
        Dim query = "select Balance from AccountHolder where AccNum=int('" & Acc & "')"
        cmd = New OleDbCommand(query, con)
        Dim adp = New OleDbDataAdapter(cmd)
        Dim dt As DataTable
        dt = New DataTable
        adp.Fill(dt)
        Oldbalance = Convert.ToInt32(dt.Rows(0)(0).ToString())
        con.close()
    End Sub
    Private Sub updateBalance()
        Dim Account = Convert.ToInt32(Acc)
        Dim NewBal = Oldbalance + Convert.ToInt32(DAmount.Text)
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
    Private Sub DepositBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepositBtn.Click
        If DAmount.Text = "" Or Convert.ToInt32(DAmount.Text) < 1 Then
            MsgBox("Missing Information")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Deposit"
            Try
                Dim Bal = 0
                con.open()
                Dim query = " insert into TransactionTbl values(int('" & MyAcc & "'),'" & TrType & "','" & DAmount.Text & "','" & System.DateTime.Today.Date & "')"
                Dim cmd As OleDbCommand
                cmd = New OleDbCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Deposit Succesfull")
                con.close()
                updateBalance()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Public MyAcc As Integer
    Private Sub Deposit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyAcc = Convert.ToInt32(Acc)
        getDeposit()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Application.Exit()
    End Sub
End Class