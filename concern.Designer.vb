<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class concern
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncnADD = New System.Windows.Forms.Button()
        Me.btnconview = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lblconid = New System.Windows.Forms.Label()
        Me.lblconname = New System.Windows.Forms.Label()
        Me.lbladd = New System.Windows.Forms.Label()
        Me.lblphno = New System.Windows.Forms.Label()
        Me.lblmail = New System.Windows.Forms.Label()
        Me.lblorid = New System.Windows.Forms.Label()
        Me.txtconid = New System.Windows.Forms.TextBox()
        Me.txtmailid = New System.Windows.Forms.TextBox()
        Me.txtordid = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtconname = New System.Windows.Forms.TextBox()
        Me.pnlcon = New System.Windows.Forms.Panel()
        Me.txtphno = New System.Windows.Forms.TextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.cboconid = New System.Windows.Forms.ComboBox()
        Me.pnlcon.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Concern Entry"
        '
        'btncnADD
        '
        Me.btncnADD.Location = New System.Drawing.Point(466, 127)
        Me.btncnADD.Name = "btncnADD"
        Me.btncnADD.Size = New System.Drawing.Size(114, 48)
        Me.btncnADD.TabIndex = 3
        Me.btncnADD.Text = "ADD"
        Me.btncnADD.UseVisualStyleBackColor = True
        '
        'btnconview
        '
        Me.btnconview.Location = New System.Drawing.Point(466, 204)
        Me.btnconview.Name = "btnconview"
        Me.btnconview.Size = New System.Drawing.Size(114, 47)
        Me.btnconview.TabIndex = 4
        Me.btnconview.Text = "VIEW CONCERN"
        Me.btnconview.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(466, 282)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(114, 47)
        Me.btnupdate.TabIndex = 5
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(466, 360)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(114, 47)
        Me.btnclose.TabIndex = 6
        Me.btnclose.Text = "CLOSE"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lblconid
        '
        Me.lblconid.AutoSize = True
        Me.lblconid.Location = New System.Drawing.Point(68, 61)
        Me.lblconid.Name = "lblconid"
        Me.lblconid.Size = New System.Drawing.Size(74, 13)
        Me.lblconid.TabIndex = 0
        Me.lblconid.Text = "CONCERN ID"
        '
        'lblconname
        '
        Me.lblconname.AutoSize = True
        Me.lblconname.Location = New System.Drawing.Point(68, 120)
        Me.lblconname.Name = "lblconname"
        Me.lblconname.Size = New System.Drawing.Size(94, 13)
        Me.lblconname.TabIndex = 1
        Me.lblconname.Text = "CONCERN NAME"
        '
        'lbladd
        '
        Me.lbladd.AutoSize = True
        Me.lbladd.Location = New System.Drawing.Point(67, 172)
        Me.lbladd.Name = "lbladd"
        Me.lbladd.Size = New System.Drawing.Size(59, 13)
        Me.lbladd.TabIndex = 2
        Me.lbladd.Text = "ADDRESS"
        '
        'lblphno
        '
        Me.lblphno.AutoSize = True
        Me.lblphno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphno.Location = New System.Drawing.Point(67, 225)
        Me.lblphno.Name = "lblphno"
        Me.lblphno.Size = New System.Drawing.Size(107, 15)
        Me.lblphno.TabIndex = 3
        Me.lblphno.Text = "PHONE NUMBER"
        '
        'lblmail
        '
        Me.lblmail.AutoSize = True
        Me.lblmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmail.Location = New System.Drawing.Point(67, 276)
        Me.lblmail.Name = "lblmail"
        Me.lblmail.Size = New System.Drawing.Size(62, 15)
        Me.lblmail.TabIndex = 4
        Me.lblmail.Text = "E-MAIL ID"
        '
        'lblorid
        '
        Me.lblorid.AutoSize = True
        Me.lblorid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblorid.Location = New System.Drawing.Point(67, 332)
        Me.lblorid.Name = "lblorid"
        Me.lblorid.Size = New System.Drawing.Size(66, 15)
        Me.lblorid.TabIndex = 5
        Me.lblorid.Text = "ORDER ID"
        '
        'txtconid
        '
        Me.txtconid.Location = New System.Drawing.Point(257, 61)
        Me.txtconid.Name = "txtconid"
        Me.txtconid.Size = New System.Drawing.Size(100, 20)
        Me.txtconid.TabIndex = 6
        '
        'txtmailid
        '
        Me.txtmailid.Location = New System.Drawing.Point(257, 276)
        Me.txtmailid.Name = "txtmailid"
        Me.txtmailid.Size = New System.Drawing.Size(100, 20)
        Me.txtmailid.TabIndex = 8
        '
        'txtordid
        '
        Me.txtordid.Location = New System.Drawing.Point(257, 329)
        Me.txtordid.Name = "txtordid"
        Me.txtordid.Size = New System.Drawing.Size(100, 20)
        Me.txtordid.TabIndex = 9
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(257, 172)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(100, 20)
        Me.txtaddress.TabIndex = 10
        '
        'txtconname
        '
        Me.txtconname.Location = New System.Drawing.Point(257, 120)
        Me.txtconname.Name = "txtconname"
        Me.txtconname.Size = New System.Drawing.Size(100, 20)
        Me.txtconname.TabIndex = 11
        '
        'pnlcon
        '
        Me.pnlcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlcon.Controls.Add(Me.cboconid)
        Me.pnlcon.Controls.Add(Me.txtconname)
        Me.pnlcon.Controls.Add(Me.txtaddress)
        Me.pnlcon.Controls.Add(Me.txtordid)
        Me.pnlcon.Controls.Add(Me.txtmailid)
        Me.pnlcon.Controls.Add(Me.txtphno)
        Me.pnlcon.Controls.Add(Me.txtconid)
        Me.pnlcon.Controls.Add(Me.lblorid)
        Me.pnlcon.Controls.Add(Me.lblmail)
        Me.pnlcon.Controls.Add(Me.lblphno)
        Me.pnlcon.Controls.Add(Me.lbladd)
        Me.pnlcon.Controls.Add(Me.lblconname)
        Me.pnlcon.Controls.Add(Me.lblconid)
        Me.pnlcon.Location = New System.Drawing.Point(-5, 83)
        Me.pnlcon.Name = "pnlcon"
        Me.pnlcon.Size = New System.Drawing.Size(418, 408)
        Me.pnlcon.TabIndex = 2
        '
        'txtphno
        '
        Me.txtphno.Location = New System.Drawing.Point(257, 225)
        Me.txtphno.Name = "txtphno"
        Me.txtphno.Size = New System.Drawing.Size(100, 20)
        Me.txtphno.TabIndex = 7
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Location = New System.Drawing.Point(365, 28)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 33)
        Me.lblError.TabIndex = 7
        '
        'cboconid
        '
        Me.cboconid.FormattingEnabled = True
        Me.cboconid.Location = New System.Drawing.Point(257, 44)
        Me.cboconid.Name = "cboconid"
        Me.cboconid.Size = New System.Drawing.Size(100, 21)
        Me.cboconid.TabIndex = 12
        '
        'concern
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(612, 488)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnconview)
        Me.Controls.Add(Me.btncnADD)
        Me.Controls.Add(Me.pnlcon)
        Me.Controls.Add(Me.Label1)
        Me.Name = "concern"
        Me.Text = "concern"
        Me.pnlcon.ResumeLayout(False)
        Me.pnlcon.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btncnADD As Button
    Friend WithEvents btnconview As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents lblconid As Label
    Friend WithEvents lblconname As Label
    Friend WithEvents lbladd As Label
    Friend WithEvents lblphno As Label
    Friend WithEvents lblmail As Label
    Friend WithEvents lblorid As Label
    Friend WithEvents txtconid As TextBox
    Friend WithEvents txtmailid As TextBox
    Friend WithEvents txtordid As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtconname As TextBox
    Friend WithEvents pnlcon As Panel
    Friend WithEvents txtphno As TextBox
    Friend WithEvents lblError As Label
    Friend WithEvents cboconid As ComboBox
End Class
