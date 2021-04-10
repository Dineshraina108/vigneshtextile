Imports Oracle.DataAccess.Client
Public Class concern

    Private Sub concern_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbcon()
        Dim query As String
        Dim dt As New DataTable
        query = "select concernid,concernname,address,phonenumber,emailid,orderid from CONCERN_ENRTY order by concernid"
        dt = selquery(query)
        cboconid.DataSource = dt
        cboconid.DisplayMember = "concernid"
        cboconid.ValueMember = "concernid"
        cboconid.DroppedDown = True
        dbclose()
    End Sub
    Dim Msg As String
    Private Sub btncnADD_Click(sender As Object, e As EventArgs) Handles btncnADD.Click
        'Dim query As String
        'dbcon()

        ProcessonValidation()

        'query = "INSERT INTO CONCERN_ENRTY(CONCERNID,CONCERNNAME,ADDRESS,PHONENUMBER,EMAILID,ORDERID)VALUES
        ' (" & txtconid.Text & ",'" & txtconname.Text & "','" & txtaddress.Text & "','" & txtphno.Text &
        '   "','" & txtmailid.Text & "'," & txtordid.Text & ")"
        'insquery(query)


    End Sub

    Private Sub ProcessonValidation()
        Try

            If txtconid.Text = "" Or txtconid.Text = String.Empty Then
                Msg = "Concern ID" + Environment.NewLine
            End If
            If txtconname.Text = "" Or txtconname.Text = String.Empty Then
                Msg = Msg + "Concern Name" + Environment.NewLine
            End If
            If txtaddress.Text = "" Or txtaddress.Text = String.Empty Then
                Msg = Msg + "Address" + Environment.NewLine
            End If
            If txtphno.Text = "" Or txtphno.Text = String.Empty Then
                Msg = Msg + "Phone No" + Environment.NewLine
            End If
            If txtmailid.Text = "" Or txtmailid.Text = String.Empty Then
                Msg = Msg + "Mail ID" + Environment.NewLine
            End If
            If txtordid.Text = "" Or txtordid.Text = String.Empty Then
                Msg = Msg + "Order ID"
            End If
            If Msg <> String.Empty Then
                Msg = "Please Fill Below Details :" + Environment.NewLine + Msg
                MessageBox.Show(Msg)
            End If
            If Msg = "" Then
                Dim query As String
                query = "INSERT INTO CONCERN_ENRTY(CONCERNID,CONCERNNAME,ADDRESS,PHONENUMBER,EMAILID,ORDERID)VALUES
                         (" & txtconid.Text & ",'" & txtconname.Text & "','" & txtaddress.Text & "','" & txtphno.Text &
                      "','" & txtmailid.Text & "'," & txtordid.Text & ")"
                dbcon()
                insquery(query)
                dbclose()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtconid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtconid.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtconname.Focus()
        End If
    End Sub

    Private Sub txtconname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtconname.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtaddress.Focus()
        End If
    End Sub

    Private Sub txtaddress_KeyDown(sender As Object, e As KeyEventArgs) Handles txtaddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtphno.Focus()
        End If
    End Sub

    Private Sub txtphno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtphno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtmailid.Focus()
        End If
    End Sub

    Private Sub txtmailid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmailid.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtordid.Focus()
        End If
    End Sub

    Private Sub txtordid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtordid.KeyDown
        If e.KeyCode = Keys.Enter Then
            btncnADD.Focus()
        End If
    End Sub

    Private Sub btnconview_Click(sender As Object, e As EventArgs) Handles btnconview.Click
        congrid.Show()

        Dim query As String
        Dim dt As DataTable
        query = "select concernid,concernname,address,phonenumber,emailid,orderid from CONCERN_ENRTY"
        dt = selquery(query)
        congrid.RGV.DataSource = dt

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim query As String
        dbcon()
        query = ("Update CONCERN_ENRTY set concernname='" & txtconname.Text & "',address='" & txtaddress.Text & "',phonenumber='" & txtphno.Text & "',Emailid='" & txtmailid.Text & "',orderid='" & txtordid.Text & "' where concernid='" & cboconid.SelectedValue & "'")
        updquery(query)
        dbclose()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub cboconid_KeyDown(sender As Object, e As KeyEventArgs) Handles cboconid.KeyDown

        Dim query As String
        Dim dt1 As New DataTable
        If e.KeyCode = Keys.Enter Then
            dbcon()
            query = ("select concernname,address,phonenumber,emailid,orderid from CONCERN_ENRTY where concernid='" & cboconid.SelectedValue & "'")
            Using cmd As New OracleCommand(query, con)
                Using ada As New OracleDataAdapter(cmd)
                    ada.Fill(dt1)
                End Using
            End Using
            txtconname.Text = dt1.Rows(0)("concernname")
            txtaddress.Text = dt1.Rows(0)("address")
            txtphno.Text = dt1.Rows(0)("phonenumber")
            txtmailid.Text = dt1.Rows(0)("emailid")
            txtordid.Text = dt1.Rows(0)("orderid")
            dbclose()
        End If
    End Sub
End Class