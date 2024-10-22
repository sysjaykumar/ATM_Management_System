Imports System.Data.OleDb
Public Class REGISTRATION
    Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:\Users\Arun kumar\Documents\Visual Studio 2008\Projects\ATM Management System\ATMDate.accdb")
    Private Sub Reset()
        AccNumTxt.Text = ""
        NameTxt.Text = ""
        FNameTxt.Text = ""
        addTxt.Text = ""
        EduCB.SelectedIndex = -1
        OccTxt.Text = ""
        PinTxt.Text = ""
        PhoneTxt.Text = ""
    End Sub
    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        If AccNumTxt.Text = "" Or NameTxt.Text = "" Or FNameTxt.Text = "" Or PhoneTxt.Text = "" Or addTxt.Text = "" Or EduCB.SelectedIndex = -1 Or OccTxt.Text = "" Or PinTxt.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                Dim Bal = 0
                con.open()
                Dim query = " insert into AccountHolder values(int('" & AccNumTxt.Text & "'),'" & NameTxt.Text & "','" & FNameTxt.Text & "','" & DateTP.Value.Date & "','" & PhoneTxt.Text & "','" & addTxt.Text & "','" & EduCB.SelectedItem.ToString() & "','" & OccTxt.Text & "','" & PinTxt.Text & "',int('" & Bal & "'))"
                Dim cmd As OleDbCommand
                cmd = New OleDbCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Account Added")
                Reset()
                con.close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
     
    End Sub

    Private Sub backLbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backLbl.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub REGISTRATION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class