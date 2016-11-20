<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form021
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
        Me.cmdEXIT = New System.Windows.Forms.Button()
        Me.SpQ291BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SZETAVDataSet = New szet_64.SZETAVDataSet()
        Me.grdKARBAN = New System.Windows.Forms.DataGridView()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SpQ293BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpQ310ABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbMUVEL = New System.Windows.Forms.ComboBox()
        Me.SpQ298BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpQ337BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblMUVEL = New System.Windows.Forms.Label()
        Me.lblMUNIDO = New System.Windows.Forms.Label()
        Me.datDATUMTOL = New System.Windows.Forms.DateTimePicker()
        Me.lblMUNIDO2 = New System.Windows.Forms.Label()
        Me.datDATUMIG = New System.Windows.Forms.DateTimePicker()
        Me.SpQ335BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbOBJTIP = New System.Windows.Forms.ComboBox()
        Me.SpQ296BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblOBJTIP = New System.Windows.Forms.Label()
        Me.cmbOBJID = New System.Windows.Forms.ComboBox()
        Me.lblOBJID = New System.Windows.Forms.Label()
        Me.SpQ334BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdFRISSIT = New System.Windows.Forms.Button()
        Me.txtMUNOSZ = New System.Windows.Forms.TextBox()
        Me.lblMUNOSZ = New System.Windows.Forms.Label()
        Me.txtTALALAT = New System.Windows.Forms.TextBox()
        Me.lblTALALAT = New System.Windows.Forms.Label()
        Me.Sp_Q291TableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_Q291TableAdapter()
        Me.Sp_Q293TableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_Q293TableAdapter()
        Me.Sp_Q310ATableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_Q310ATableAdapter()
        Me.Sp_Q337TableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_Q337TableAdapter()
        Me.Sp_Q335TableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_Q335TableAdapter()
        Me.Sp_Q296TableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_Q296TableAdapter()
        Me.Sp_Q334TableAdapter1 = New szet_64.SZETAVDataSetTableAdapters.sp_Q334TableAdapter()
        Me.lblSZOLGJELL = New System.Windows.Forms.Label()
        Me.cmbSZOLGJELL = New System.Windows.Forms.ComboBox()
        Me.Sp_Q298TableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_Q298TableAdapter()
        Me.cmdTERVEK = New System.Windows.Forms.Button()
        CType(Me.SpQ291BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdKARBAN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpQ293BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpQ310ABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpQ298BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpQ337BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpQ335BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpQ296BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpQ334BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdEXIT
        '
        Me.cmdEXIT.Location = New System.Drawing.Point(12, 556)
        Me.cmdEXIT.Name = "cmdEXIT"
        Me.cmdEXIT.Size = New System.Drawing.Size(75, 25)
        Me.cmdEXIT.TabIndex = 2
        Me.cmdEXIT.Text = "Kilépés"
        Me.cmdEXIT.UseVisualStyleBackColor = True
        '
        'SpQ291BindingSource
        '
        Me.SpQ291BindingSource.DataMember = "sp_Q291"
        Me.SpQ291BindingSource.DataSource = Me.SZETAVDataSet
        '
        'SZETAVDataSet
        '
        Me.SZETAVDataSet.DataSetName = "SZETAVDataSet"
        Me.SZETAVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdKARBAN
        '
        Me.grdKARBAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdKARBAN.Location = New System.Drawing.Point(93, 170)
        Me.grdKARBAN.Name = "grdKARBAN"
        Me.grdKARBAN.Size = New System.Drawing.Size(1026, 411)
        Me.grdKARBAN.TabIndex = 9
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(472, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(228, 36)
        Me.lblTitle.TabIndex = 25
        Me.lblTitle.Text = "Karbantartások"
        '
        'SpQ293BindingSource
        '
        Me.SpQ293BindingSource.DataMember = "sp_Q293"
        Me.SpQ293BindingSource.DataSource = Me.SZETAVDataSet
        '
        'SpQ310ABindingSource
        '
        Me.SpQ310ABindingSource.DataMember = "sp_Q310A"
        Me.SpQ310ABindingSource.DataSource = Me.SZETAVDataSet
        '
        'cmbMUVEL
        '
        Me.cmbMUVEL.DataSource = Me.SpQ298BindingSource
        Me.cmbMUVEL.DisplayMember = "KODENEV"
        Me.cmbMUVEL.FormattingEnabled = True
        Me.cmbMUVEL.Location = New System.Drawing.Point(198, 114)
        Me.cmbMUVEL.Name = "cmbMUVEL"
        Me.cmbMUVEL.Size = New System.Drawing.Size(180, 22)
        Me.cmbMUVEL.TabIndex = 5
        Me.cmbMUVEL.Tag = "298"
        Me.cmbMUVEL.ValueMember = "KODERT"
        '
        'SpQ298BindingSource
        '
        Me.SpQ298BindingSource.DataMember = "sp_Q298"
        Me.SpQ298BindingSource.DataSource = Me.SZETAVDataSet
        '
        'SpQ337BindingSource
        '
        Me.SpQ337BindingSource.DataMember = "sp_Q337"
        Me.SpQ337BindingSource.DataSource = Me.SZETAVDataSet
        '
        'lblMUVEL
        '
        Me.lblMUVEL.Location = New System.Drawing.Point(93, 117)
        Me.lblMUVEL.Name = "lblMUVEL"
        Me.lblMUVEL.Size = New System.Drawing.Size(99, 14)
        Me.lblMUVEL.TabIndex = 26
        Me.lblMUVEL.Text = "Művelet típusa"
        Me.lblMUVEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMUNIDO
        '
        Me.lblMUNIDO.Location = New System.Drawing.Point(58, 89)
        Me.lblMUNIDO.Name = "lblMUNIDO"
        Me.lblMUNIDO.Size = New System.Drawing.Size(99, 14)
        Me.lblMUNIDO.TabIndex = 26
        Me.lblMUNIDO.Text = "Időszak"
        Me.lblMUNIDO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'datDATUMTOL
        '
        Me.datDATUMTOL.Checked = False
        Me.datDATUMTOL.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datDATUMTOL.Location = New System.Drawing.Point(164, 86)
        Me.datDATUMTOL.Name = "datDATUMTOL"
        Me.datDATUMTOL.ShowCheckBox = True
        Me.datDATUMTOL.Size = New System.Drawing.Size(100, 20)
        Me.datDATUMTOL.TabIndex = 3
        Me.datDATUMTOL.Value = New Date(2016, 9, 1, 0, 0, 0, 0)
        '
        'lblMUNIDO2
        '
        Me.lblMUNIDO2.AutoSize = True
        Me.lblMUNIDO2.Location = New System.Drawing.Point(266, 89)
        Me.lblMUNIDO2.Name = "lblMUNIDO2"
        Me.lblMUNIDO2.Size = New System.Drawing.Size(11, 14)
        Me.lblMUNIDO2.TabIndex = 28
        Me.lblMUNIDO2.Text = "-"
        Me.lblMUNIDO2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'datDATUMIG
        '
        Me.datDATUMIG.Checked = False
        Me.datDATUMIG.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datDATUMIG.Location = New System.Drawing.Point(278, 86)
        Me.datDATUMIG.Name = "datDATUMIG"
        Me.datDATUMIG.ShowCheckBox = True
        Me.datDATUMIG.Size = New System.Drawing.Size(100, 20)
        Me.datDATUMIG.TabIndex = 4
        Me.datDATUMIG.Value = New Date(2016, 10, 1, 0, 0, 0, 0)
        '
        'SpQ335BindingSource
        '
        Me.SpQ335BindingSource.DataMember = "sp_Q335"
        Me.SpQ335BindingSource.DataSource = Me.SZETAVDataSet
        '
        'cmbOBJTIP
        '
        Me.cmbOBJTIP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbOBJTIP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbOBJTIP.DataSource = Me.SpQ296BindingSource
        Me.cmbOBJTIP.DisplayMember = "KODENEV"
        Me.cmbOBJTIP.FormattingEnabled = True
        Me.cmbOBJTIP.Location = New System.Drawing.Point(505, 86)
        Me.cmbOBJTIP.Name = "cmbOBJTIP"
        Me.cmbOBJTIP.Size = New System.Drawing.Size(180, 22)
        Me.cmbOBJTIP.TabIndex = 6
        Me.cmbOBJTIP.Tag = "296"
        Me.cmbOBJTIP.ValueMember = "KODERT"
        '
        'SpQ296BindingSource
        '
        Me.SpQ296BindingSource.DataMember = "sp_Q296"
        Me.SpQ296BindingSource.DataSource = Me.SZETAVDataSet
        '
        'lblOBJTIP
        '
        Me.lblOBJTIP.Location = New System.Drawing.Point(400, 89)
        Me.lblOBJTIP.Name = "lblOBJTIP"
        Me.lblOBJTIP.Size = New System.Drawing.Size(99, 13)
        Me.lblOBJTIP.TabIndex = 26
        Me.lblOBJTIP.Text = "Berendezés típus"
        Me.lblOBJTIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbOBJID
        '
        Me.cmbOBJID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbOBJID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbOBJID.FormattingEnabled = True
        Me.cmbOBJID.Location = New System.Drawing.Point(505, 114)
        Me.cmbOBJID.Name = "cmbOBJID"
        Me.cmbOBJID.Size = New System.Drawing.Size(180, 22)
        Me.cmbOBJID.TabIndex = 7
        Me.cmbOBJID.Tag = "MEGNEV"
        '
        'lblOBJID
        '
        Me.lblOBJID.Location = New System.Drawing.Point(400, 117)
        Me.lblOBJID.Name = "lblOBJID"
        Me.lblOBJID.Size = New System.Drawing.Size(99, 13)
        Me.lblOBJID.TabIndex = 26
        Me.lblOBJID.Text = "Berendezés megn."
        Me.lblOBJID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SpQ334BindingSource
        '
        Me.SpQ334BindingSource.DataMember = "sp_Q334"
        Me.SpQ334BindingSource.DataSource = Me.SZETAVDataSet
        '
        'cmdFRISSIT
        '
        Me.cmdFRISSIT.Location = New System.Drawing.Point(12, 223)
        Me.cmdFRISSIT.Name = "cmdFRISSIT"
        Me.cmdFRISSIT.Size = New System.Drawing.Size(75, 25)
        Me.cmdFRISSIT.TabIndex = 0
        Me.cmdFRISSIT.Text = "Frissítés"
        Me.cmdFRISSIT.UseVisualStyleBackColor = True
        '
        'txtMUNOSZ
        '
        Me.txtMUNOSZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMUNOSZ.Enabled = False
        Me.txtMUNOSZ.Location = New System.Drawing.Point(12, 142)
        Me.txtMUNOSZ.Name = "txtMUNOSZ"
        Me.txtMUNOSZ.ReadOnly = True
        Me.txtMUNOSZ.Size = New System.Drawing.Size(75, 20)
        Me.txtMUNOSZ.TabIndex = 31
        Me.txtMUNOSZ.TabStop = False
        Me.txtMUNOSZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMUNOSZ
        '
        Me.lblMUNOSZ.Location = New System.Drawing.Point(12, 117)
        Me.lblMUNOSZ.Name = "lblMUNOSZ"
        Me.lblMUNOSZ.Size = New System.Drawing.Size(75, 13)
        Me.lblMUNOSZ.TabIndex = 26
        Me.lblMUNOSZ.Text = "Munkaóra"
        Me.lblMUNOSZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTALALAT
        '
        Me.txtTALALAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTALALAT.Enabled = False
        Me.txtTALALAT.Location = New System.Drawing.Point(12, 86)
        Me.txtTALALAT.Name = "txtTALALAT"
        Me.txtTALALAT.ReadOnly = True
        Me.txtTALALAT.Size = New System.Drawing.Size(75, 20)
        Me.txtTALALAT.TabIndex = 31
        Me.txtTALALAT.TabStop = False
        Me.txtTALALAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTALALAT
        '
        Me.lblTALALAT.Location = New System.Drawing.Point(12, 61)
        Me.lblTALALAT.Name = "lblTALALAT"
        Me.lblTALALAT.Size = New System.Drawing.Size(75, 13)
        Me.lblTALALAT.TabIndex = 26
        Me.lblTALALAT.Text = "Találatok"
        Me.lblTALALAT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Sp_Q291TableAdapter
        '
        Me.Sp_Q291TableAdapter.ClearBeforeFill = True
        '
        'Sp_Q293TableAdapter
        '
        Me.Sp_Q293TableAdapter.ClearBeforeFill = True
        '
        'Sp_Q310ATableAdapter
        '
        Me.Sp_Q310ATableAdapter.ClearBeforeFill = True
        '
        'Sp_Q337TableAdapter
        '
        Me.Sp_Q337TableAdapter.ClearBeforeFill = True
        '
        'Sp_Q335TableAdapter
        '
        Me.Sp_Q335TableAdapter.ClearBeforeFill = True
        '
        'Sp_Q296TableAdapter
        '
        Me.Sp_Q296TableAdapter.ClearBeforeFill = True
        '
        'Sp_Q334TableAdapter1
        '
        Me.Sp_Q334TableAdapter1.ClearBeforeFill = True
        '
        'lblSZOLGJELL
        '
        Me.lblSZOLGJELL.Location = New System.Drawing.Point(400, 145)
        Me.lblSZOLGJELL.Name = "lblSZOLGJELL"
        Me.lblSZOLGJELL.Size = New System.Drawing.Size(99, 13)
        Me.lblSZOLGJELL.TabIndex = 26
        Me.lblSZOLGJELL.Text = "Szolgáltatás jellege"
        Me.lblSZOLGJELL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbSZOLGJELL
        '
        Me.cmbSZOLGJELL.DataSource = Me.SpQ291BindingSource
        Me.cmbSZOLGJELL.DisplayMember = "KODENEV"
        Me.cmbSZOLGJELL.FormattingEnabled = True
        Me.cmbSZOLGJELL.Location = New System.Drawing.Point(505, 142)
        Me.cmbSZOLGJELL.Name = "cmbSZOLGJELL"
        Me.cmbSZOLGJELL.Size = New System.Drawing.Size(180, 22)
        Me.cmbSZOLGJELL.TabIndex = 8
        Me.cmbSZOLGJELL.Tag = "291"
        Me.cmbSZOLGJELL.ValueMember = "KODERT"
        '
        'Sp_Q298TableAdapter
        '
        Me.Sp_Q298TableAdapter.ClearBeforeFill = True
        '
        'cmdTERVEK
        '
        Me.cmdTERVEK.Location = New System.Drawing.Point(12, 284)
        Me.cmdTERVEK.Name = "cmdTERVEK"
        Me.cmdTERVEK.Size = New System.Drawing.Size(75, 25)
        Me.cmdTERVEK.TabIndex = 1
        Me.cmdTERVEK.Text = "Tervek"
        Me.cmdTERVEK.UseVisualStyleBackColor = True
        '
        'Form021
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 593)
        Me.Controls.Add(Me.cmdTERVEK)
        Me.Controls.Add(Me.txtTALALAT)
        Me.Controls.Add(Me.txtMUNOSZ)
        Me.Controls.Add(Me.lblMUNIDO2)
        Me.Controls.Add(Me.datDATUMIG)
        Me.Controls.Add(Me.datDATUMTOL)
        Me.Controls.Add(Me.lblMUNIDO)
        Me.Controls.Add(Me.lblMUVEL)
        Me.Controls.Add(Me.lblTALALAT)
        Me.Controls.Add(Me.lblMUNOSZ)
        Me.Controls.Add(Me.lblOBJID)
        Me.Controls.Add(Me.lblOBJTIP)
        Me.Controls.Add(Me.lblSZOLGJELL)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grdKARBAN)
        Me.Controls.Add(Me.cmbMUVEL)
        Me.Controls.Add(Me.cmbOBJID)
        Me.Controls.Add(Me.cmbOBJTIP)
        Me.Controls.Add(Me.cmbSZOLGJELL)
        Me.Controls.Add(Me.cmdFRISSIT)
        Me.Controls.Add(Me.cmdEXIT)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Name = "Form021"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form021"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SpQ291BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdKARBAN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpQ293BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpQ310ABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpQ298BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpQ337BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpQ335BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpQ296BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpQ334BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdEXIT As System.Windows.Forms.Button
    Friend WithEvents grdKARBAN As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cmbMUVEL As System.Windows.Forms.ComboBox
    Friend WithEvents lblMUVEL As System.Windows.Forms.Label
    Friend WithEvents lblMUNIDO As System.Windows.Forms.Label
    Friend WithEvents datDATUMTOL As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblMUNIDO2 As System.Windows.Forms.Label
    Friend WithEvents datDATUMIG As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbOBJTIP As System.Windows.Forms.ComboBox
    Friend WithEvents lblOBJTIP As System.Windows.Forms.Label
    Friend WithEvents cmbOBJID As System.Windows.Forms.ComboBox
    Friend WithEvents lblOBJID As System.Windows.Forms.Label
    Friend WithEvents cmdFRISSIT As System.Windows.Forms.Button
    Friend WithEvents txtMUNOSZ As System.Windows.Forms.TextBox
    Friend WithEvents lblMUNOSZ As System.Windows.Forms.Label
    Friend WithEvents txtTALALAT As System.Windows.Forms.TextBox
    Friend WithEvents lblTALALAT As System.Windows.Forms.Label
    Friend WithEvents SZETAVDataSet As szet_64.SZETAVDataSet
    Friend WithEvents SpQ291BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_Q291TableAdapter As szet_64.SZETAVDataSetTableAdapters.sp_Q291TableAdapter
    Friend WithEvents SpQ293BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_Q293TableAdapter As szet_64.SZETAVDataSetTableAdapters.sp_Q293TableAdapter
    Friend WithEvents SpQ310ABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_Q310ATableAdapter As szet_64.SZETAVDataSetTableAdapters.sp_Q310ATableAdapter
    Friend WithEvents SpQ337BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_Q337TableAdapter As szet_64.SZETAVDataSetTableAdapters.sp_Q337TableAdapter
    Friend WithEvents SpQ335BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_Q335TableAdapter As szet_64.SZETAVDataSetTableAdapters.sp_Q335TableAdapter
    Friend WithEvents SpQ296BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_Q296TableAdapter As szet_64.SZETAVDataSetTableAdapters.sp_Q296TableAdapter
    Friend WithEvents SpQ334BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_Q334TableAdapter1 As szet_64.SZETAVDataSetTableAdapters.sp_Q334TableAdapter
    Friend WithEvents lblSZOLGJELL As System.Windows.Forms.Label
    Friend WithEvents cmbSZOLGJELL As System.Windows.Forms.ComboBox
    Friend WithEvents SpQ298BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_Q298TableAdapter As szet_64.SZETAVDataSetTableAdapters.sp_Q298TableAdapter
    Friend WithEvents cmdTERVEK As System.Windows.Forms.Button
End Class
