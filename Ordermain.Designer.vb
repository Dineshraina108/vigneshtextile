<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ordermain
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
        Me.Btnconcern = New System.Windows.Forms.Button()
        Me.btnordetail = New System.Windows.Forms.Button()
        Me.lblordrev = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btnconcern
        '
        Me.Btnconcern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnconcern.Location = New System.Drawing.Point(148, 157)
        Me.Btnconcern.Name = "Btnconcern"
        Me.Btnconcern.Size = New System.Drawing.Size(154, 55)
        Me.Btnconcern.TabIndex = 0
        Me.Btnconcern.Text = "CONCERN"
        Me.Btnconcern.UseVisualStyleBackColor = True
        '
        'btnordetail
        '
        Me.btnordetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnordetail.Location = New System.Drawing.Point(148, 262)
        Me.btnordetail.Name = "btnordetail"
        Me.btnordetail.Size = New System.Drawing.Size(154, 56)
        Me.btnordetail.TabIndex = 1
        Me.btnordetail.Text = "ORDER DETAILS"
        Me.btnordetail.UseVisualStyleBackColor = True
        '
        'lblordrev
        '
        Me.lblordrev.AutoSize = True
        Me.lblordrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblordrev.Font = New System.Drawing.Font("Segoe Script", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblordrev.Location = New System.Drawing.Point(56, 47)
        Me.lblordrev.Name = "lblordrev"
        Me.lblordrev.Size = New System.Drawing.Size(360, 51)
        Me.lblordrev.TabIndex = 2
        Me.lblordrev.Text = "ORDER RECEIVING"
        '
        'Ordermain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(461, 374)
        Me.Controls.Add(Me.lblordrev)
        Me.Controls.Add(Me.btnordetail)
        Me.Controls.Add(Me.Btnconcern)
        Me.Name = "Ordermain"
        Me.Text = "Ordermain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnconcern As Button
    Friend WithEvents btnordetail As Button
    Friend WithEvents lblordrev As Label
End Class
