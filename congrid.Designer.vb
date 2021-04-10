<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class congrid
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
        Dim GridViewBrowseColumn1 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn2 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn3 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn4 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn5 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn6 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RGV = New Telerik.WinControls.UI.RadGridView()
        CType(Me.RGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGV.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RGV
        '
        Me.RGV.BackColor = System.Drawing.SystemColors.Control
        Me.RGV.Cursor = System.Windows.Forms.Cursors.Default
        Me.RGV.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RGV.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RGV.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RGV.Location = New System.Drawing.Point(12, 12)
        '
        '
        '
        GridViewBrowseColumn1.EnableExpressionEditor = False
        GridViewBrowseColumn1.FieldName = "CONCERNID"
        GridViewBrowseColumn1.HeaderText = "CONCERNID"
        GridViewBrowseColumn1.Name = "CONCERNID"
        GridViewBrowseColumn1.Width = 75
        GridViewBrowseColumn2.EnableExpressionEditor = False
        GridViewBrowseColumn2.FieldName = "CONCERNNAME"
        GridViewBrowseColumn2.HeaderText = "CONCERNNAME"
        GridViewBrowseColumn2.Name = "CONCERNNAME"
        GridViewBrowseColumn2.Width = 143
        GridViewBrowseColumn3.EnableExpressionEditor = False
        GridViewBrowseColumn3.FieldName = "ADDRESS"
        GridViewBrowseColumn3.HeaderText = "ADDRESS"
        GridViewBrowseColumn3.Name = "ADDRESS"
        GridViewBrowseColumn3.Width = 76
        GridViewBrowseColumn4.EnableExpressionEditor = False
        GridViewBrowseColumn4.FieldName = "PHONENUMBER"
        GridViewBrowseColumn4.HeaderText = "PHONENUMBER"
        GridViewBrowseColumn4.Name = "PHONENUMBER"
        GridViewBrowseColumn4.Width = 97
        GridViewBrowseColumn5.EnableExpressionEditor = False
        GridViewBrowseColumn5.FieldName = "EMAIL"
        GridViewBrowseColumn5.HeaderText = "EMAIL"
        GridViewBrowseColumn5.Name = "EMAIL"
        GridViewBrowseColumn5.Width = 148
        GridViewBrowseColumn6.EnableExpressionEditor = False
        GridViewBrowseColumn6.FieldName = "ORDERID"
        GridViewBrowseColumn6.HeaderText = "ORDERID"
        GridViewBrowseColumn6.Name = "ORDERID"
        Me.RGV.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewBrowseColumn1, GridViewBrowseColumn2, GridViewBrowseColumn3, GridViewBrowseColumn4, GridViewBrowseColumn5, GridViewBrowseColumn6})
        Me.RGV.MasterTemplate.EnableAlternatingRowColor = True
        Me.RGV.MasterTemplate.EnableFiltering = True
        Me.RGV.MasterTemplate.EnableGrouping = False
        Me.RGV.MasterTemplate.EnableSorting = False
        Me.RGV.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.RGV.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RGV.Name = "RGV"
        Me.RGV.ReadOnly = True
        Me.RGV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RGV.Size = New System.Drawing.Size(607, 233)
        Me.RGV.TabIndex = 0
        '
        'congrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 257)
        Me.Controls.Add(Me.RGV)
        Me.Name = "congrid"
        Me.Text = "congrid"
        CType(Me.RGV.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RGV As Telerik.WinControls.UI.RadGridView
End Class
