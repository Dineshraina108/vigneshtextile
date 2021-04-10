Imports System.Text.RegularExpressions
Public Class Register
    Dim uid, uname, pass, repass, emailid, mobileno, usrivillage As String
    Dim emailformat As Regex = New Regex("^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,6}$")

    Private Sub txtuname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtuname.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtupass.Focus()
        End If
    End Sub

    Private Sub txtupass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtupass.KeyDown
        If e.KeyCode = Keys.Enter Then
            txturepass.Focus()
        End If
    End Sub

    Private Sub txturepass_KeyDown(sender As Object, e As KeyEventArgs) Handles txturepass.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtemail.Focus()
        End If

    End Sub

    Private Sub txtemail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtemail.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtmobno.Focus()
        End If
    End Sub
    Public Sub clear()
        txtid.Text = ""
        txtuname.Text = ""
        txtupass.Text = ""
        txturepass.Text = ""
        txtemail.Text = ""
        txtmobno.Text = ""
    End Sub

    Private Sub llblallogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblallogin.LinkClicked
        Form1.Show()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
    End Sub

    Private Sub txtid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtid.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtuname.Focus()
        End If
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RDN.Checked = True
    End Sub

    Private Sub RDN_CheckedChanged(sender As Object, e As EventArgs) Handles RDN.CheckedChanged
        If RDN.Checked = True Then
            RDS.Checked = False
            usrivillage = "N"
        End If
    End Sub

    Private Sub RDS_CheckedChanged(sender As Object, e As EventArgs) Handles RDS.CheckedChanged
        If RDS.Checked = True Then
            RDN.Checked = False
            usrivillage = "Y"
        End If
    End Sub


    Private Sub btnreg_Click(sender As Object, e As EventArgs) Handles btnreg.Click
        dbcon()
        uid = txtid.Text
        uname = txtuname.Text
        pass = txtupass.Text
        repass = txturepass.Text
        emailid = txtemail.Text
        mobileno = txtmobno.Text

        Dim dt As New DataTable
        Dim qry As String
        If pass = repass Then
            qry = "SELECT count(*) from usreg where userid=" & uid & "AND USERNAME='" & uname & "'"
            dt = selquery(qry)
            'If dt.Rows(0)("count(*)").ToString = "1" Then
            '    qry = "UPDATE USREG SET UPASS='" & pass & "', REPASS='" & repass & "' WHERE USERID=" & uid & "AND USERNAME='" & uname & "'"
            '    updquery(qry)
            'Else
            If emailformat.IsMatch(emailid) Then
                    If Len(txtmobno.Text) > 10 Or Len(txtmobno.Text) < 10 Then
                        MsgBox("INVALID MOBILE NUMBER")

                    Else

                    qry = "INSERT INTO USREG VALUES (" & uid & ",'" & uname & "','" & pass & "','" & repass & "','" & emailid & "','" & txtmobno.Text & "','" & usrivillage & "')"
                    insquery(qry)
                    Form1.Show()
                End If
                Else
                    MsgBox("INVALID EMAIL ID")
                'clear()
                ' End If
            End If
        Else
            MsgBox("PASSWORD AND REPASSWORD NOT MATCH")
            '  clear()
        End If
        dbclose()
    End Sub
End Class
