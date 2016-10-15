<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form002
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
        Me.cmbMUVLEIRROV = New System.Windows.Forms.ComboBox()
        Me.SpQ336BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SZETAVDataSet = New szet_64.SZETAVDataSet()
        Me.lblMUVLEIRROV = New System.Windows.Forms.Label()
        Me.txtMUVLEIR = New System.Windows.Forms.TextBox()
        Me.lblMUVLEIR = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grdTELJ = New System.Windows.Forms.DataGridView()
        Me.txtMUNORA = New System.Windows.Forms.TextBox()
        Me.dtMUNDAT = New System.Windows.Forms.DateTimePicker()
        Me.lblMUNORA = New System.Windows.Forms.Label()
        Me.lblMUNDAT = New System.Windows.Forms.Label()
        Me.lblDOLG_ID = New System.Windows.Forms.Label()
        Me.cmbDOLG_ID = New System.Windows.Forms.ComboBox()
        Me.SpQ334BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdTOROL = New System.Windows.Forms.Button()
        Me.cmdUJ = New System.Windows.Forms.Button()
        Me.Sp_Q336TableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_Q336TableAdapter()
        Me.Sp_Q334TableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_Q334TableAdapter()
        Me.lblMUNORA2 = New System.Windows.Forms.Label()
        Me.spcMUNORA = New System.Windows.Forms.TextBox()
        Me.cmdCANCEL = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        CType(Me.SpQ336BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdTELJ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpQ334BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbMUVLEIRROV
        '
        Me.cmbMUVLEIRROV.DataSource = Me.SpQ336BindingSource
        Me.cmbMUVLEIRROV.DisplayMember = "KODENEV"
        Me.cmbMUVLEIRROV.FormattingEnabled = True
        Me.cmbMUVLEIRROV.Location = New System.Drawing.Point(104, 12)
        Me.cmbMUVLEIRROV.Name = "cmbMUVLEIRROV"
        Me.cmbMUVLEIRROV.Size = New System.Drawing.Size(138, 21)
        Me.cmbMUVLEIRROV.TabIndex = 0
        Me.cmbMUVLEIRROV.Tag = "336"
        Me.cmbMUVLEIRROV.ValueMember = "KODERT"
        '
        'SpQ336BindingSource
        '
        Me.SpQ336BindingSource.DataMember = "sp_Q336"
        Me.SpQ336BindingSource.DataSource = Me.SZETAVDataSet
        '
        'SZETAVDataSet
        '
        Me.SZETAVDataSet.DataSetName = "SZETAVDataSet"
        Me.SZETAVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblMUVLEIRROV
        '
        Me.lblMUVLEIRROV.AutoSize = True
        Me.lblMUVLEIRROV.Location = New System.Drawing.Point(12, 15)
        Me.lblMUVLEIRROV.Name = "lblMUVLEIRROV"
        Me.lblMUVLEIRROV.Size = New System.Drawing.Size(86, 13)
        Me.lblMUVLEIRROV.TabIndex = 24
        Me.lblMUVLEIRROV.Text = "Elvégzett munka"
        Me.lblMUVLEIRROV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMUVLEIR
        '
        Me.txtMUVLEIR.Location = New System.Drawing.Point(104, 39)
        Me.txtMUVLEIR.Multiline = True
        Me.txtMUVLEIR.Name = "txtMUVLEIR"
        Me.txtMUVLEIR.Size = New System.Drawing.Size(508, 93)
        Me.txtMUVLEIR.TabIndex = 1
        '
        'lblMUVLEIR
        '
        Me.lblMUVLEIR.AutoSize = True
        Me.lblMUVLEIR.Location = New System.Drawing.Point(23, 42)
        Me.lblMUVLEIR.Name = "lblMUVLEIR"
        Me.lblMUVLEIR.Size = New System.Drawing.Size(75, 13)
        Me.lblMUVLEIR.TabIndex = 24
        Me.lblMUVLEIR.Text = "Munka leírása"
        Me.lblMUVLEIR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdTELJ)
        Me.GroupBox1.Controls.Add(Me.txtMUNORA)
        Me.GroupBox1.Controls.Add(Me.dtMUNDAT)
        Me.GroupBox1.Controls.Add(Me.lblMUNORA)
        Me.GroupBox1.Controls.Add(Me.lblMUNDAT)
        Me.GroupBox1.Controls.Add(Me.lblDOLG_ID)
        Me.GroupBox1.Controls.Add(Me.cmbDOLG_ID)
        Me.GroupBox1.Controls.Add(Me.cmdTOROL)
        Me.GroupBox1.Controls.Add(Me.cmdUJ)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(599, 162)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Teljesítmény adatok"
        '
        'grdTELJ
        '
        Me.grdTELJ.AllowUserToAddRows = False
        Me.grdTELJ.AllowUserToDeleteRows = False
        Me.grdTELJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTELJ.Location = New System.Drawing.Point(91, 46)
        Me.grdTELJ.Name = "grdTELJ"
        Me.grdTELJ.ReadOnly = True
        Me.grdTELJ.Size = New System.Drawing.Size(502, 110)
        Me.grdTELJ.TabIndex = 6
        '
        'txtMUNORA
        '
        Me.txtMUNORA.Location = New System.Drawing.Point(547, 19)
        Me.txtMUNORA.Name = "txtMUNORA"
        Me.txtMUNORA.Size = New System.Drawing.Size(46, 20)
        Me.txtMUNORA.TabIndex = 4
        '
        'dtMUNDAT
        '
        Me.dtMUNDAT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtMUNDAT.Location = New System.Drawing.Point(394, 19)
        Me.dtMUNDAT.Name = "dtMUNDAT"
        Me.dtMUNDAT.Size = New System.Drawing.Size(104, 20)
        Me.dtMUNDAT.TabIndex = 3
        '
        'lblMUNORA
        '
        Me.lblMUNORA.AutoSize = True
        Me.lblMUNORA.Location = New System.Drawing.Point(517, 22)
        Me.lblMUNORA.Name = "lblMUNORA"
        Me.lblMUNORA.Size = New System.Drawing.Size(24, 13)
        Me.lblMUNORA.TabIndex = 4
        Me.lblMUNORA.Text = "Óra"
        '
        'lblMUNDAT
        '
        Me.lblMUNDAT.AutoSize = True
        Me.lblMUNDAT.Location = New System.Drawing.Point(276, 22)
        Me.lblMUNDAT.Name = "lblMUNDAT"
        Me.lblMUNDAT.Size = New System.Drawing.Size(112, 13)
        Me.lblMUNDAT.TabIndex = 3
        Me.lblMUNDAT.Text = "Munkavégzés dátuma"
        '
        'lblDOLG_ID
        '
        Me.lblDOLG_ID.AutoSize = True
        Me.lblDOLG_ID.Location = New System.Drawing.Point(88, 22)
        Me.lblDOLG_ID.Name = "lblDOLG_ID"
        Me.lblDOLG_ID.Size = New System.Drawing.Size(46, 13)
        Me.lblDOLG_ID.TabIndex = 2
        Me.lblDOLG_ID.Text = "Dolgozó"
        '
        'cmbDOLG_ID
        '
        Me.cmbDOLG_ID.DataSource = Me.SpQ334BindingSource
        Me.cmbDOLG_ID.DisplayMember = "NEV"
        Me.cmbDOLG_ID.FormattingEnabled = True
        Me.cmbDOLG_ID.Location = New System.Drawing.Point(140, 19)
        Me.cmbDOLG_ID.Name = "cmbDOLG_ID"
        Me.cmbDOLG_ID.Size = New System.Drawing.Size(121, 21)
        Me.cmbDOLG_ID.TabIndex = 2
        Me.cmbDOLG_ID.Tag = "334"
        Me.cmbDOLG_ID.ValueMember = "ID"
        '
        'SpQ334BindingSource
        '
        Me.SpQ334BindingSource.DataMember = "sp_Q334"
        Me.SpQ334BindingSource.DataSource = Me.SZETAVDataSet
        '
        'cmdTOROL
        '
        Me.cmdTOROL.Location = New System.Drawing.Point(6, 133)
        Me.cmdTOROL.Name = "cmdTOROL"
        Me.cmdTOROL.Size = New System.Drawing.Size(75, 23)
        Me.cmdTOROL.TabIndex = 7
        Me.cmdTOROL.Text = "Törlés"
        Me.cmdTOROL.UseVisualStyleBackColor = True
        '
        'cmdUJ
        '
        Me.cmdUJ.Location = New System.Drawing.Point(6, 19)
        Me.cmdUJ.Name = "cmdUJ"
        Me.cmdUJ.Size = New System.Drawing.Size(75, 23)
        Me.cmdUJ.TabIndex = 5
        Me.cmdUJ.Text = "Rögzítés"
        Me.cmdUJ.UseVisualStyleBackColor = True
        '
        'Sp_Q336TableAdapter
        '
        Me.Sp_Q336TableAdapter.ClearBeforeFill = True
        '
        'Sp_Q334TableAdapter
        '
        Me.Sp_Q334TableAdapter.ClearBeforeFill = True
        '
        'lblMUNORA2
        '
        Me.lblMUNORA2.AutoSize = True
        Me.lblMUNORA2.Location = New System.Drawing.Point(458, 15)
        Me.lblMUNORA2.Name = "lblMUNORA2"
        Me.lblMUNORA2.Size = New System.Drawing.Size(102, 13)
        Me.lblMUNORA2.TabIndex = 24
        Me.lblMUNORA2.Text = "Munkaóra összesen"
        Me.lblMUNORA2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'spcMUNORA
        '
        Me.spcMUNORA.Enabled = False
        Me.spcMUNORA.Location = New System.Drawing.Point(566, 12)
        Me.spcMUNORA.Name = "spcMUNORA"
        Me.spcMUNORA.ReadOnly = True
        Me.spcMUNORA.Size = New System.Drawing.Size(46, 20)
        Me.spcMUNORA.TabIndex = 4
        Me.spcMUNORA.TabStop = False
        '
        'cmdCANCEL
        '
        Me.cmdCANCEL.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCANCEL.Location = New System.Drawing.Point(12, 306)
        Me.cmdCANCEL.Name = "cmdCANCEL"
        Me.cmdCANCEL.Size = New System.Drawing.Size(75, 23)
        Me.cmdCANCEL.TabIndex = 8
        Me.cmdCANCEL.Text = "Mégsem"
        Me.cmdCANCEL.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(537, 306)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 9
        Me.cmdOK.Text = "Rendben"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'Form002
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 338)
        Me.Controls.Add(Me.cmdCANCEL)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.spcMUNORA)
        Me.Controls.Add(Me.txtMUVLEIR)
        Me.Controls.Add(Me.cmbMUVLEIRROV)
        Me.Controls.Add(Me.lblMUVLEIR)
        Me.Controls.Add(Me.lblMUNORA2)
        Me.Controls.Add(Me.lblMUVLEIRROV)
        Me.Name = "Form002"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form002 - Visszaírás"
        CType(Me.SpQ336BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdTELJ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpQ334BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbMUVLEIRROV As System.Windows.Forms.ComboBox
    Friend WithEvents lblMUVLEIRROV As System.Windows.Forms.Label
    Friend WithEvents txtMUVLEIR As System.Windows.Forms.TextBox
    Friend WithEvents lblMUVLEIR As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grdTELJ As System.Windows.Forms.DataGridView
    Friend WithEvents txtMUNORA As System.Windows.Forms.TextBox
    Friend WithEvents dtMUNDAT As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblMUNORA As System.Windows.Forms.Label
    Friend WithEvents lblMUNDAT As System.Windows.Forms.Label
    Friend WithEvents lblDOLG_ID As System.Windows.Forms.Label
    Friend WithEvents cmbDOLG_ID As System.Windows.Forms.ComboBox
    Friend WithEvents cmdTOROL As System.Windows.Forms.Button
    Friend WithEvents cmdUJ As System.Windows.Forms.Button
    Friend WithEvents SZETAVDataSet As szet_64.SZETAVDataSet
    Friend WithEvents SpQ336BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_Q336TableAdapter As szet_64.SZETAVDataSetTableAdapters.sp_Q336TableAdapter
    Friend WithEvents SpQ334BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_Q334TableAdapter As szet_64.SZETAVDataSetTableAdapters.sp_Q334TableAdapter
    Friend WithEvents lblMUNORA2 As System.Windows.Forms.Label
    Friend WithEvents spcMUNORA As System.Windows.Forms.TextBox
    Friend WithEvents cmdCANCEL As System.Windows.Forms.Button
    Friend WithEvents cmdOK As System.Windows.Forms.Button
End Class
