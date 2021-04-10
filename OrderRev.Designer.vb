<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderRev
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
        Me.pnlorev = New System.Windows.Forms.Panel()
        Me.lblormain = New System.Windows.Forms.Label()
        Me.lblordid = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtordid = New System.Windows.Forms.TextBox()
        Me.cbotype = New System.Windows.Forms.ComboBox()
        Me.lblconcernid = New System.Windows.Forms.Label()
        Me.txtgoods = New System.Windows.Forms.TextBox()
        Me.txtconcernid = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.pnlorev.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlorev
        '
        Me.pnlorev.Controls.Add(Me.DateTimePicker1)
        Me.pnlorev.Controls.Add(Me.txtconcernid)
        Me.pnlorev.Controls.Add(Me.txtgoods)
        Me.pnlorev.Controls.Add(Me.lblconcernid)
        Me.pnlorev.Controls.Add(Me.cbotype)
        Me.pnlorev.Controls.Add(Me.txtordid)
        Me.pnlorev.Controls.Add(Me.Label4)
        Me.pnlorev.Controls.Add(Me.Label3)
        Me.pnlorev.Controls.Add(Me.Label2)
        Me.pnlorev.Controls.Add(Me.lblordid)
        Me.pnlorev.Location = New System.Drawing.Point(23, 55)
        Me.pnlorev.Name = "pnlorev"
        Me.pnlorev.Size = New System.Drawing.Size(357, 297)
        Me.pnlorev.TabIndex = 0
        '
        'lblormain
        '
        Me.lblormain.AutoSize = True
        Me.lblormain.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblormain.Location = New System.Drawing.Point(88, 5)
        Me.lblormain.Name = "lblormain"
        Me.lblormain.Size = New System.Drawing.Size(240, 47)
        Me.lblormain.TabIndex = 1
        Me.lblormain.Text = "Order Receiving"
        '
        'lblordid
        '
        Me.lblordid.AutoSize = True
        Me.lblordid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblordid.Location = New System.Drawing.Point(34, 56)
        Me.lblordid.Name = "lblordid"
        Me.lblordid.Size = New System.Drawing.Size(64, 18)
        Me.lblordid.TabIndex = 0
        Me.lblordid.Text = "Order ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No.Of.Goods"
        '
        'txtordid
        '
        Me.txtordid.Location = New System.Drawing.Point(190, 56)
        Me.txtordid.Name = "txtordid"
        Me.txtordid.Size = New System.Drawing.Size(115, 20)
        Me.txtordid.TabIndex = 4
        '
        'cbotype
        '
        Me.cbotype.FormattingEnabled = True
        Me.cbotype.Location = New System.Drawing.Point(190, 107)
        Me.cbotype.Name = "cbotype"
        Me.cbotype.Size = New System.Drawing.Size(115, 21)
        Me.cbotype.TabIndex = 5
        '
        'lblconcernid
        '
        Me.lblconcernid.AutoSize = True
        Me.lblconcernid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconcernid.Location = New System.Drawing.Point(34, 234)
        Me.lblconcernid.Name = "lblconcernid"
        Me.lblconcernid.Size = New System.Drawing.Size(83, 18)
        Me.lblconcernid.TabIndex = 6
        Me.lblconcernid.Text = "Concern ID"
        '
        'txtgoods
        '
        Me.txtgoods.Location = New System.Drawing.Point(190, 189)
        Me.txtgoods.Name = "txtgoods"
        Me.txtgoods.Size = New System.Drawing.Size(115, 20)
        Me.txtgoods.TabIndex = 8
        '
        'txtconcernid
        '
        Me.txtconcernid.Location = New System.Drawing.Point(190, 234)
        Me.txtconcernid.Name = "txtconcernid"
        Me.txtconcernid.Size = New System.Drawing.Size(115, 20)
        Me.txtconcernid.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(457, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 47)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(457, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 47)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "VIEW ORDER"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(457, 203)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 47)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "UPDATE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(457, 276)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(140, 47)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "CLOSE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(190, 146)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(115, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'OrderRev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 375)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblormain)
        Me.Controls.Add(Me.pnlorev)
        Me.Name = "OrderRev"
        Me.Text = "OrderRev"
        Me.pnlorev.ResumeLayout(False)
        Me.pnlorev.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlorev As Panel
    Friend WithEvents lblormain As Label
    Friend WithEvents txtconcernid As TextBox
    Friend WithEvents txtgoods As TextBox
    Friend WithEvents lblconcernid As Label
    Friend WithEvents cbotype As ComboBox
    Friend WithEvents txtordid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblordid As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
