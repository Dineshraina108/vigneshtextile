Imports Oracle.DataAccess.Client
Public Class Form1

    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        Dim usdt As New DataTable
        Dim query As String
        dbcon()
        query = "SELECT * FROM usreg WHERE USERNAME='" & txtuname.Text & "' AND UPASSWORD='" & txtpw.Text & "'"
        usdt = selquery(query)
        Try
                If usdt.Rows.Count > 0 Then
                'MsgBox("ok")
                Master.Show()
                Me.Hide()
            Else
                    MsgBox("iNVALID USERNAME OR PASSWORD")
                End If

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        dbclose()

    End Sub

    Private Sub llblsignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblsignup.LinkClicked
        Register.Show()

    End Sub

    Private Sub txtuname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtuname.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dt As New DataTable
            Dim query As String
            dbcon()
            Try
                If e.KeyCode = Keys.Enter Then
                    If txtuname.Text <> "" Then
                        query = "SELECT userprivillage FROM usreg WHERE USERNAME='" & txtuname.Text & "'"
                        dt = selquery(query)
                        If dt.Rows(0)("userprivillage").ToString = "Y" Then
                            llblsignup.Visible = True
                            txtpw.Focus()
                        Else
                            MsgBox("user privillage deneied")
                            llblsignup.Visible = False
                            txtpw.Focus()
                        End If
                    Else
                        MsgBox("User Name is Empty..")
                        txtuname.Focus()
                    End If
                End If
                'dt = selquery(Query)

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
            dbclose()
        End If


    End Sub

    Private Sub txtpw_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpw.KeyDown
        dbcon()

        If e.KeyCode = Keys.Enter Then
            Try
                If txtpw.Text <> "" Then
                Else
                    MsgBox("Password is Empty..")
                    txtpw.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
            btnlog.Focus()
        End If
        dbclose()

    End Sub

    Private Sub btncnl_Click(sender As Object, e As EventArgs) Handles btncnl.Click
        Me.Close()

    End Sub

    Private Sub pnllog_Paint(sender As Object, e As PaintEventArgs) Handles pnllog.Paint

    End Sub


End Class
