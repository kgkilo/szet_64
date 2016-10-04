<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form091
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
        Me.grdPreview = New System.Windows.Forms.DataGridView()
        Me.cmdExport = New System.Windows.Forms.Button()
        Me.cmdEXIT = New System.Windows.Forms.Button()
        CType(Me.grdPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdPreview
        '
        Me.grdPreview.AllowUserToAddRows = False
        Me.grdPreview.AllowUserToDeleteRows = False
        Me.grdPreview.AllowUserToOrderColumns = True
        Me.grdPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPreview.Location = New System.Drawing.Point(12, 67)
        Me.grdPreview.Name = "grdPreview"
        Me.grdPreview.ReadOnly = True
        Me.grdPreview.Size = New System.Drawing.Size(600, 164)
        Me.grdPreview.TabIndex = 0
        '
        'cmdExport
        '
        Me.cmdExport.Location = New System.Drawing.Point(275, 377)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(75, 23)
        Me.cmdExport.TabIndex = 1
        Me.cmdExport.Text = "Export CSV"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'cmdEXIT
        '
        Me.cmdEXIT.Location = New System.Drawing.Point(12, 406)
        Me.cmdEXIT.Name = "cmdEXIT"
        Me.cmdEXIT.Size = New System.Drawing.Size(75, 25)
        Me.cmdEXIT.TabIndex = 10
        Me.cmdEXIT.Text = "Kilépés"
        Me.cmdEXIT.UseVisualStyleBackColor = True
        '
        'Form091
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.cmdEXIT)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.grdPreview)
        Me.Name = "Form091"
        Me.Text = "Form091 - NEXON export"
        CType(Me.grdPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdPreview As System.Windows.Forms.DataGridView
    Friend WithEvents cmdExport As System.Windows.Forms.Button
    Friend WithEvents cmdEXIT As System.Windows.Forms.Button
End Class
