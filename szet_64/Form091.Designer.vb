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
        Me.lblDATUMIG = New System.Windows.Forms.Label()
        Me.datDATUMIG = New System.Windows.Forms.DateTimePicker()
        Me.datDATUMTOL = New System.Windows.Forms.DateTimePicker()
        Me.lblDATUMTOL = New System.Windows.Forms.Label()
        Me.cmdFRISSIT = New System.Windows.Forms.Button()
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
        Me.cmdExport.TabIndex = 4
        Me.cmdExport.Text = "Export CSV"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'cmdEXIT
        '
        Me.cmdEXIT.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdEXIT.Location = New System.Drawing.Point(537, 404)
        Me.cmdEXIT.Name = "cmdEXIT"
        Me.cmdEXIT.Size = New System.Drawing.Size(75, 25)
        Me.cmdEXIT.TabIndex = 5
        Me.cmdEXIT.Text = "Kilépés"
        Me.cmdEXIT.UseVisualStyleBackColor = True
        '
        'lblDOLGID
        '
        Me.lblDOLGID.Location = New System.Drawing.Point(12, 66)
        Me.lblDOLGID.Name = "lblDOLGID"
        Me.lblDOLGID.Size = New System.Drawing.Size(47, 13)
        Me.lblDOLGID.TabIndex = 14
        Me.lblDOLGID.Text = "Dolgozó"
        Me.lblDOLGID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbDOLGID
        '
        Me.cmbDOLGID.DataSource = Me.SpQ334BindingSource
        Me.cmbDOLGID.DisplayMember = "NEV"
        Me.cmbDOLGID.FormattingEnabled = True
        Me.cmbDOLGID.Location = New System.Drawing.Point(63, 63)
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
        'lblDATUMIG
        '
        Me.lblDATUMIG.AutoSize = True
        Me.lblDATUMIG.Location = New System.Drawing.Point(500, 67)
        Me.lblDATUMIG.Name = "lblDATUMIG"
        Me.lblDATUMIG.Size = New System.Drawing.Size(10, 13)
        Me.lblDATUMIG.TabIndex = 32
        Me.lblDATUMIG.Text = "-"
        Me.lblDATUMIG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'datDATUMIG
        '
        Me.datDATUMIG.Checked = False
        Me.datDATUMIG.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datDATUMIG.Location = New System.Drawing.Point(512, 64)
        Me.datDATUMIG.Name = "datDATUMIG"
        Me.datDATUMIG.ShowCheckBox = True
        Me.datDATUMIG.Size = New System.Drawing.Size(100, 20)
        Me.datDATUMIG.TabIndex = 2
        Me.datDATUMIG.Value = New Date(2016, 10, 1, 0, 0, 0, 0)
        '
        'datDATUMTOL
        '
        Me.datDATUMTOL.Checked = False
        Me.datDATUMTOL.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datDATUMTOL.Location = New System.Drawing.Point(398, 64)
        Me.datDATUMTOL.Name = "datDATUMTOL"
        Me.datDATUMTOL.ShowCheckBox = True
        Me.datDATUMTOL.Size = New System.Drawing.Size(100, 20)
        Me.datDATUMTOL.TabIndex = 1
        Me.datDATUMTOL.Value = New Date(2016, 10, 1, 0, 0, 0, 0)
        '
        'lblDATUMTOL
        '
        Me.lblDATUMTOL.Location = New System.Drawing.Point(292, 67)
        Me.lblDATUMTOL.Name = "lblDATUMTOL"
        Me.lblDATUMTOL.Size = New System.Drawing.Size(99, 14)
        Me.lblDATUMTOL.TabIndex = 31
        Me.lblDATUMTOL.Text = "Intervallum"
        Me.lblDATUMTOL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdFRISSIT
        '
        Me.cmdFRISSIT.Location = New System.Drawing.Point(12, 406)
        Me.cmdFRISSIT.Name = "cmdFRISSIT"
        Me.cmdFRISSIT.Size = New System.Drawing.Size(75, 23)
        Me.cmdFRISSIT.TabIndex = 3
        Me.cmdFRISSIT.Text = "Frissít"
        Me.cmdFRISSIT.UseVisualStyleBackColor = True
        '
        'Form091
        '
        Me.AcceptButton = Me.cmdExport
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdEXIT
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.lblDATUMIG)
        Me.Controls.Add(Me.datDATUMIG)
        Me.Controls.Add(Me.datDATUMTOL)
        Me.Controls.Add(Me.lblDATUMTOL)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblDOLGID)
        Me.Controls.Add(Me.cmbDOLGID)
        Me.Controls.Add(Me.cmdEXIT)
        Me.Controls.Add(Me.cmdFRISSIT)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.grdPreview)
        Me.Name = "Form091"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents lblDATUMIG As System.Windows.Forms.Label
    Friend WithEvents datDATUMIG As System.Windows.Forms.DateTimePicker
    Friend WithEvents datDATUMTOL As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDATUMTOL As System.Windows.Forms.Label
    Friend WithEvents cmdFRISSIT As System.Windows.Forms.Button
End Class
