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
        Me.components = New System.ComponentModel.Container()
        Me.grdPreview = New System.Windows.Forms.DataGridView()
        Me.cmdExport = New System.Windows.Forms.Button()
        Me.cmdEXIT = New System.Windows.Forms.Button()
        Me.lblDOLGID = New System.Windows.Forms.Label()
        Me.cmbDOLGID = New System.Windows.Forms.ComboBox()
        Me.SpQ334BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SZETAVDataSet = New szet_64.SZETAVDataSet()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Sp_Q334TableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_Q334TableAdapter()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.grdPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpQ334BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdPreview
        '
        Me.grdPreview.AllowUserToAddRows = False
        Me.grdPreview.AllowUserToDeleteRows = False
        Me.grdPreview.AllowUserToOrderColumns = True
        Me.grdPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPreview.Location = New System.Drawing.Point(12, 90)
        Me.grdPreview.Name = "grdPreview"
        Me.grdPreview.ReadOnly = True
        Me.grdPreview.Size = New System.Drawing.Size(600, 281)
        Me.grdPreview.TabIndex = 1
        '
        'cmdExport
        '
        Me.cmdExport.Location = New System.Drawing.Point(275, 377)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(75, 23)
        Me.cmdExport.TabIndex = 2
        Me.cmdExport.Text = "Export CSV"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'cmdEXIT
        '
        Me.cmdEXIT.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdEXIT.Location = New System.Drawing.Point(12, 406)
        Me.cmdEXIT.Name = "cmdEXIT"
        Me.cmdEXIT.Size = New System.Drawing.Size(75, 25)
        Me.cmdEXIT.TabIndex = 3
        Me.cmdEXIT.Text = "Kilépés"
        Me.cmdEXIT.UseVisualStyleBackColor = True
        '
        'lblDOLGID
        '
        Me.lblDOLGID.Location = New System.Drawing.Point(12, 66)
        Me.lblDOLGID.Name = "lblDOLGID"
        Me.lblDOLGID.Size = New System.Drawing.Size(75, 13)
        Me.lblDOLGID.TabIndex = 14
        Me.lblDOLGID.Text = "Dolgozó"
        Me.lblDOLGID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbDOLGID
        '
        Me.cmbDOLGID.DataSource = Me.SpQ334BindingSource
        Me.cmbDOLGID.DisplayMember = "NEV"
        Me.cmbDOLGID.FormattingEnabled = True
        Me.cmbDOLGID.Location = New System.Drawing.Point(93, 63)
        Me.cmbDOLGID.Name = "cmbDOLGID"
        Me.cmbDOLGID.Size = New System.Drawing.Size(180, 21)
        Me.cmbDOLGID.TabIndex = 0
        Me.cmbDOLGID.Tag = "334"
        Me.cmbDOLGID.ValueMember = "ID"
        '
        'SpQ334BindingSource
        '
        Me.SpQ334BindingSource.DataMember = "sp_Q334"
        Me.SpQ334BindingSource.DataSource = Me.SZETAVDataSet
        '
        'SZETAVDataSet
        '
        Me.SZETAVDataSet.DataSetName = "SZETAVDataSet"
        Me.SZETAVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(205, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(214, 25)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "Óraszám leválogatás"
        '
        'Sp_Q334TableAdapter
        '
        Me.Sp_Q334TableAdapter.ClearBeforeFill = True
        '
        'Form091
        '
        Me.AcceptButton = Me.cmdExport
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdEXIT
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblDOLGID)
        Me.Controls.Add(Me.cmbDOLGID)
        Me.Controls.Add(Me.cmdEXIT)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.grdPreview)
        Me.Name = "Form091"
        Me.Text = "Form091 - NEXON export"
        CType(Me.grdPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpQ334BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdPreview As System.Windows.Forms.DataGridView
    Friend WithEvents cmdExport As System.Windows.Forms.Button
    Friend WithEvents cmdEXIT As System.Windows.Forms.Button
    Friend WithEvents lblDOLGID As System.Windows.Forms.Label
    Friend WithEvents cmbDOLGID As System.Windows.Forms.ComboBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents SZETAVDataSet As szet_64.SZETAVDataSet
    Friend WithEvents SpQ334BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_Q334TableAdapter As szet_64.SZETAVDataSetTableAdapters.sp_Q334TableAdapter
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
