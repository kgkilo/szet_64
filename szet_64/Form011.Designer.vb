<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form011
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
        Me.grd011 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NEVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SZEREGYSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BEOSZTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpLekerdDolgozoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SZETAVDataSet = New szet_64.SZETAVDataSet()
        Me.Sp_LekerdDolgozoTableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_LekerdDolgozoTableAdapter()
        Me.cmdUJ = New System.Windows.Forms.Button()
        Me.cmdMODOSIT = New System.Windows.Forms.Button()
        Me.cmdTOROL = New System.Windows.Forms.Button()
        Me.cmdEXIT = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmbOBJTIP = New System.Windows.Forms.ComboBox()
        Me.lblOBJTIP = New System.Windows.Forms.Label()
        CType(Me.grd011, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpLekerdDolgozoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd011
        '
        Me.grd011.AutoGenerateColumns = False
        Me.grd011.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd011.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NEVDataGridViewTextBoxColumn, Me.SZEREGYSDataGridViewTextBoxColumn, Me.BEOSZTDataGridViewTextBoxColumn})
        Me.grd011.DataSource = Me.SpLekerdDolgozoBindingSource
        Me.grd011.Location = New System.Drawing.Point(93, 86)
        Me.grd011.Name = "grd011"
        Me.grd011.ReadOnly = True
        Me.grd011.Size = New System.Drawing.Size(1026, 495)
        Me.grd011.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'NEVDataGridViewTextBoxColumn
        '
        Me.NEVDataGridViewTextBoxColumn.DataPropertyName = "NEV"
        Me.NEVDataGridViewTextBoxColumn.HeaderText = "Név"
        Me.NEVDataGridViewTextBoxColumn.Name = "NEVDataGridViewTextBoxColumn"
        Me.NEVDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SZEREGYSDataGridViewTextBoxColumn
        '
        Me.SZEREGYSDataGridViewTextBoxColumn.DataPropertyName = "SZEREGYS"
        Me.SZEREGYSDataGridViewTextBoxColumn.HeaderText = "Szervezeti egység"
        Me.SZEREGYSDataGridViewTextBoxColumn.Name = "SZEREGYSDataGridViewTextBoxColumn"
        Me.SZEREGYSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BEOSZTDataGridViewTextBoxColumn
        '
        Me.BEOSZTDataGridViewTextBoxColumn.DataPropertyName = "BEOSZT"
        Me.BEOSZTDataGridViewTextBoxColumn.HeaderText = "Beosztás"
        Me.BEOSZTDataGridViewTextBoxColumn.Name = "BEOSZTDataGridViewTextBoxColumn"
        Me.BEOSZTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SpLekerdDolgozoBindingSource
        '
        Me.SpLekerdDolgozoBindingSource.DataMember = "sp_LekerdDolgozo"
        Me.SpLekerdDolgozoBindingSource.DataSource = Me.SZETAVDataSet
        '
        'SZETAVDataSet
        '
        Me.SZETAVDataSet.DataSetName = "SZETAVDataSet"
        Me.SZETAVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_LekerdDolgozoTableAdapter
        '
        Me.Sp_LekerdDolgozoTableAdapter.ClearBeforeFill = True
        '
        'cmdUJ
        '
        Me.cmdUJ.Location = New System.Drawing.Point(12, 56)
        Me.cmdUJ.Name = "cmdUJ"
        Me.cmdUJ.Size = New System.Drawing.Size(75, 23)
        Me.cmdUJ.TabIndex = 1
        Me.cmdUJ.Text = "Új..."
        Me.cmdUJ.UseVisualStyleBackColor = True
        '
        'cmdMODOSIT
        '
        Me.cmdMODOSIT.Location = New System.Drawing.Point(12, 86)
        Me.cmdMODOSIT.Name = "cmdMODOSIT"
        Me.cmdMODOSIT.Size = New System.Drawing.Size(75, 23)
        Me.cmdMODOSIT.TabIndex = 2
        Me.cmdMODOSIT.Text = "Módosít..."
        Me.cmdMODOSIT.UseVisualStyleBackColor = True
        '
        'cmdTOROL
        '
        Me.cmdTOROL.Location = New System.Drawing.Point(12, 116)
        Me.cmdTOROL.Name = "cmdTOROL"
        Me.cmdTOROL.Size = New System.Drawing.Size(75, 23)
        Me.cmdTOROL.TabIndex = 3
        Me.cmdTOROL.Text = "Töröl"
        Me.cmdTOROL.UseVisualStyleBackColor = True
        '
        'cmdEXIT
        '
        Me.cmdEXIT.Location = New System.Drawing.Point(12, 556)
        Me.cmdEXIT.Name = "cmdEXIT"
        Me.cmdEXIT.Size = New System.Drawing.Size(75, 25)
        Me.cmdEXIT.TabIndex = 9
        Me.cmdEXIT.Text = "Kilépés"
        Me.cmdEXIT.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(482, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(212, 25)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "Berendezések listája"
        '
        'cmbOBJTIP
        '
        Me.cmbOBJTIP.FormattingEnabled = True
        Me.cmbOBJTIP.Location = New System.Drawing.Point(198, 58)
        Me.cmbOBJTIP.Name = "cmbOBJTIP"
        Me.cmbOBJTIP.Size = New System.Drawing.Size(180, 21)
        Me.cmbOBJTIP.TabIndex = 11
        Me.cmbOBJTIP.Tag = "296"
        '
        'lblOBJTIP
        '
        Me.lblOBJTIP.Location = New System.Drawing.Point(93, 61)
        Me.lblOBJTIP.Name = "lblOBJTIP"
        Me.lblOBJTIP.Size = New System.Drawing.Size(99, 13)
        Me.lblOBJTIP.TabIndex = 12
        Me.lblOBJTIP.Text = "Berendezés típus"
        Me.lblOBJTIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form011
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 586)
        Me.Controls.Add(Me.lblOBJTIP)
        Me.Controls.Add(Me.cmbOBJTIP)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.cmdEXIT)
        Me.Controls.Add(Me.cmdTOROL)
        Me.Controls.Add(Me.cmdMODOSIT)
        Me.Controls.Add(Me.cmdUJ)
        Me.Controls.Add(Me.grd011)
        Me.Name = "Form011"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Objektumok (Form011)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grd011, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpLekerdDolgozoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd011 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NEVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SZEREGYSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BEOSZTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpLekerdDolgozoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SZETAVDataSet As szet_64.SZETAVDataSet
    Friend WithEvents Sp_LekerdDolgozoTableAdapter As szet_64.SZETAVDataSetTableAdapters.sp_LekerdDolgozoTableAdapter
    Friend WithEvents cmdUJ As System.Windows.Forms.Button
    Friend WithEvents cmdMODOSIT As System.Windows.Forms.Button
    Friend WithEvents cmdTOROL As System.Windows.Forms.Button
    Friend WithEvents cmdEXIT As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cmbOBJTIP As System.Windows.Forms.ComboBox
    Friend WithEvents lblOBJTIP As System.Windows.Forms.Label
End Class
