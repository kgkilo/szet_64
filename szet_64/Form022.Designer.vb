<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form022
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optCSOPORTOS2 = New System.Windows.Forms.RadioButton()
        Me.optCSOPORTOS1 = New System.Windows.Forms.RadioButton()
        Me.lblOBJTIP = New System.Windows.Forms.Label()
        Me.lblMUVEL = New System.Windows.Forms.Label()
        Me.cmbOBJTIP = New System.Windows.Forms.ComboBox()
        Me.SpQ296BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SZETAVDataSet = New szet_64.SZETAVDataSet()
        Me.cmbMUVEL = New System.Windows.Forms.ComboBox()
        Me.SpQ298BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblIDO = New System.Windows.Forms.Label()
        Me.txtIDO = New System.Windows.Forms.TextBox()
        Me.cmdODA = New System.Windows.Forms.Button()
        Me.cmdVISSZA = New System.Windows.Forms.Button()
        Me.lblTERVEK = New System.Windows.Forms.Label()
        Me.lblOBJ = New System.Windows.Forms.Label()
        Me.grdKAPCSOLT = New System.Windows.Forms.DataGridView()
        Me.grdNEMKAPCSOLT = New System.Windows.Forms.DataGridView()
        Me.cmbIDOE = New System.Windows.Forms.ComboBox()
        Me.lblIDOE = New System.Windows.Forms.Label()
        Me.Sp_Q296TableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_Q296TableAdapter()
        Me.cmdCLOSE = New System.Windows.Forms.Button()
        Me.Sp_Q298TableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_Q298TableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SpQ296BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpQ298BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdKAPCSOLT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdNEMKAPCSOLT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(321, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(205, 25)
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "Karbantartási tervek"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.lblOBJTIP)
        Me.GroupBox1.Controls.Add(Me.lblMUVEL)
        Me.GroupBox1.Controls.Add(Me.cmbOBJTIP)
        Me.GroupBox1.Controls.Add(Me.cmbMUVEL)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(822, 79)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Beállítások"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optCSOPORTOS2)
        Me.GroupBox3.Controls.Add(Me.optCSOPORTOS1)
        Me.GroupBox3.Location = New System.Drawing.Point(313, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 54)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'optCSOPORTOS2
        '
        Me.optCSOPORTOS2.AutoSize = True
        Me.optCSOPORTOS2.Location = New System.Drawing.Point(6, 34)
        Me.optCSOPORTOS2.Name = "optCSOPORTOS2"
        Me.optCSOPORTOS2.Size = New System.Drawing.Size(57, 17)
        Me.optCSOPORTOS2.TabIndex = 4
        Me.optCSOPORTOS2.Text = "Egyedi"
        Me.optCSOPORTOS2.UseVisualStyleBackColor = True
        '
        'optCSOPORTOS1
        '
        Me.optCSOPORTOS1.AutoSize = True
        Me.optCSOPORTOS1.Checked = True
        Me.optCSOPORTOS1.Location = New System.Drawing.Point(6, 10)
        Me.optCSOPORTOS1.Name = "optCSOPORTOS1"
        Me.optCSOPORTOS1.Size = New System.Drawing.Size(72, 17)
        Me.optCSOPORTOS1.TabIndex = 3
        Me.optCSOPORTOS1.TabStop = True
        Me.optCSOPORTOS1.Text = "Csoportos"
        Me.optCSOPORTOS1.UseVisualStyleBackColor = True
        '
        'lblOBJTIP
        '
        Me.lblOBJTIP.Location = New System.Drawing.Point(6, 49)
        Me.lblOBJTIP.Name = "lblOBJTIP"
        Me.lblOBJTIP.Size = New System.Drawing.Size(99, 13)
        Me.lblOBJTIP.TabIndex = 14
        Me.lblOBJTIP.Text = "Berendezés"
        Me.lblOBJTIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMUVEL
        '
        Me.lblMUVEL.Location = New System.Drawing.Point(6, 22)
        Me.lblMUVEL.Name = "lblMUVEL"
        Me.lblMUVEL.Size = New System.Drawing.Size(99, 13)
        Me.lblMUVEL.TabIndex = 14
        Me.lblMUVEL.Text = "Művelet"
        Me.lblMUVEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbOBJTIP
        '
        Me.cmbOBJTIP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbOBJTIP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbOBJTIP.DataSource = Me.SpQ296BindingSource
        Me.cmbOBJTIP.DisplayMember = "KODENEV"
        Me.cmbOBJTIP.FormattingEnabled = True
        Me.cmbOBJTIP.Location = New System.Drawing.Point(111, 46)
        Me.cmbOBJTIP.Name = "cmbOBJTIP"
        Me.cmbOBJTIP.Size = New System.Drawing.Size(180, 21)
        Me.cmbOBJTIP.TabIndex = 2
        Me.cmbOBJTIP.Tag = "298"
        Me.cmbOBJTIP.ValueMember = "KODERT"
        '
        'SpQ296BindingSource
        '
        Me.SpQ296BindingSource.DataMember = "sp_Q296"
        Me.SpQ296BindingSource.DataSource = Me.SZETAVDataSet
        '
        'SZETAVDataSet
        '
        Me.SZETAVDataSet.DataSetName = "SZETAVDataSet"
        Me.SZETAVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbMUVEL
        '
        Me.cmbMUVEL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbMUVEL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMUVEL.DataSource = Me.SpQ298BindingSource
        Me.cmbMUVEL.DisplayMember = "KODENEV"
        Me.cmbMUVEL.FormattingEnabled = True
        Me.cmbMUVEL.Location = New System.Drawing.Point(111, 19)
        Me.cmbMUVEL.Name = "cmbMUVEL"
        Me.cmbMUVEL.Size = New System.Drawing.Size(180, 21)
        Me.cmbMUVEL.TabIndex = 1
        Me.cmbMUVEL.Tag = "298"
        Me.cmbMUVEL.ValueMember = "KODERT"
        '
        'SpQ298BindingSource
        '
        Me.SpQ298BindingSource.DataMember = "sp_Q298"
        Me.SpQ298BindingSource.DataSource = Me.SZETAVDataSet
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblIDO)
        Me.GroupBox2.Controls.Add(Me.txtIDO)
        Me.GroupBox2.Controls.Add(Me.cmdODA)
        Me.GroupBox2.Controls.Add(Me.cmdVISSZA)
        Me.GroupBox2.Controls.Add(Me.lblTERVEK)
        Me.GroupBox2.Controls.Add(Me.lblOBJ)
        Me.GroupBox2.Controls.Add(Me.grdKAPCSOLT)
        Me.GroupBox2.Controls.Add(Me.grdNEMKAPCSOLT)
        Me.GroupBox2.Controls.Add(Me.cmbIDOE)
        Me.GroupBox2.Controls.Add(Me.lblIDOE)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(822, 315)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tervek"
        '
        'lblIDO
        '
        Me.lblIDO.AutoSize = True
        Me.lblIDO.Location = New System.Drawing.Point(54, 22)
        Me.lblIDO.Name = "lblIDO"
        Me.lblIDO.Size = New System.Drawing.Size(51, 13)
        Me.lblIDO.TabIndex = 27
        Me.lblIDO.Text = "Időtartam"
        '
        'txtIDO
        '
        Me.txtIDO.Location = New System.Drawing.Point(111, 19)
        Me.txtIDO.Name = "txtIDO"
        Me.txtIDO.Size = New System.Drawing.Size(50, 20)
        Me.txtIDO.TabIndex = 26
        '
        'cmdODA
        '
        Me.cmdODA.Location = New System.Drawing.Point(375, 141)
        Me.cmdODA.Name = "cmdODA"
        Me.cmdODA.Size = New System.Drawing.Size(75, 23)
        Me.cmdODA.TabIndex = 25
        Me.cmdODA.Text = "=====>"
        Me.cmdODA.UseVisualStyleBackColor = True
        '
        'cmdVISSZA
        '
        Me.cmdVISSZA.Location = New System.Drawing.Point(375, 213)
        Me.cmdVISSZA.Name = "cmdVISSZA"
        Me.cmdVISSZA.Size = New System.Drawing.Size(75, 23)
        Me.cmdVISSZA.TabIndex = 25
        Me.cmdVISSZA.Text = "<====="
        Me.cmdVISSZA.UseVisualStyleBackColor = True
        '
        'lblTERVEK
        '
        Me.lblTERVEK.Location = New System.Drawing.Point(456, 53)
        Me.lblTERVEK.Name = "lblTERVEK"
        Me.lblTERVEK.Size = New System.Drawing.Size(360, 13)
        Me.lblTERVEK.TabIndex = 16
        Me.lblTERVEK.Text = "K A R B A N T A R T Á S I   T E R V E K"
        Me.lblTERVEK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOBJ
        '
        Me.lblOBJ.Location = New System.Drawing.Point(9, 53)
        Me.lblOBJ.Name = "lblOBJ"
        Me.lblOBJ.Size = New System.Drawing.Size(360, 13)
        Me.lblOBJ.TabIndex = 16
        Me.lblOBJ.Text = "B E R E N D E Z É S   F É L E S É G E K"
        Me.lblOBJ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grdKAPCSOLT
        '
        Me.grdKAPCSOLT.AllowUserToAddRows = False
        Me.grdKAPCSOLT.AllowUserToDeleteRows = False
        Me.grdKAPCSOLT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdKAPCSOLT.Location = New System.Drawing.Point(456, 69)
        Me.grdKAPCSOLT.Name = "grdKAPCSOLT"
        Me.grdKAPCSOLT.ReadOnly = True
        Me.grdKAPCSOLT.Size = New System.Drawing.Size(360, 240)
        Me.grdKAPCSOLT.TabIndex = 15
        '
        'grdNEMKAPCSOLT
        '
        Me.grdNEMKAPCSOLT.AllowUserToAddRows = False
        Me.grdNEMKAPCSOLT.AllowUserToDeleteRows = False
        Me.grdNEMKAPCSOLT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdNEMKAPCSOLT.Location = New System.Drawing.Point(9, 69)
        Me.grdNEMKAPCSOLT.Name = "grdNEMKAPCSOLT"
        Me.grdNEMKAPCSOLT.ReadOnly = True
        Me.grdNEMKAPCSOLT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdNEMKAPCSOLT.Size = New System.Drawing.Size(360, 240)
        Me.grdNEMKAPCSOLT.TabIndex = 15
        '
        'cmbIDOE
        '
        Me.cmbIDOE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbIDOE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbIDOE.DisplayMember = "KODERT"
        Me.cmbIDOE.FormattingEnabled = True
        Me.cmbIDOE.Location = New System.Drawing.Point(247, 18)
        Me.cmbIDOE.Name = "cmbIDOE"
        Me.cmbIDOE.Size = New System.Drawing.Size(122, 21)
        Me.cmbIDOE.TabIndex = 13
        Me.cmbIDOE.Tag = "299"
        Me.cmbIDOE.ValueMember = "KODERT"
        '
        'lblIDOE
        '
        Me.lblIDOE.Location = New System.Drawing.Point(176, 22)
        Me.lblIDOE.Name = "lblIDOE"
        Me.lblIDOE.Size = New System.Drawing.Size(65, 13)
        Me.lblIDOE.TabIndex = 14
        Me.lblIDOE.Text = "Időegység"
        Me.lblIDOE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Sp_Q296TableAdapter
        '
        Me.Sp_Q296TableAdapter.ClearBeforeFill = True
        '
        'cmdCLOSE
        '
        Me.cmdCLOSE.Location = New System.Drawing.Point(760, 453)
        Me.cmdCLOSE.Name = "cmdCLOSE"
        Me.cmdCLOSE.Size = New System.Drawing.Size(75, 23)
        Me.cmdCLOSE.TabIndex = 0
        Me.cmdCLOSE.Text = "Kilépés"
        Me.cmdCLOSE.UseVisualStyleBackColor = True
        '
        'Sp_Q298TableAdapter
        '
        Me.Sp_Q298TableAdapter.ClearBeforeFill = True
        '
        'Form022
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 486)
        Me.Controls.Add(Me.cmdCLOSE)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form022"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form022 - Karbantartási tervek"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.SpQ296BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpQ298BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grdKAPCSOLT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdNEMKAPCSOLT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMUVEL As System.Windows.Forms.Label
    Friend WithEvents cmbMUVEL As System.Windows.Forms.ComboBox
    Friend WithEvents SZETAVDataSet As szet_64.SZETAVDataSet
    Friend WithEvents SpQ296BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_Q296TableAdapter As szet_64.SZETAVDataSetTableAdapters.sp_Q296TableAdapter
    Friend WithEvents cmbIDOE As System.Windows.Forms.ComboBox
    Friend WithEvents lblIDOE As System.Windows.Forms.Label
    Friend WithEvents lblOBJ As System.Windows.Forms.Label
    Friend WithEvents grdNEMKAPCSOLT As System.Windows.Forms.DataGridView
    Friend WithEvents cmdCLOSE As System.Windows.Forms.Button
    Friend WithEvents cmdODA As System.Windows.Forms.Button
    Friend WithEvents cmdVISSZA As System.Windows.Forms.Button
    Friend WithEvents lblTERVEK As System.Windows.Forms.Label
    Friend WithEvents grdKAPCSOLT As System.Windows.Forms.DataGridView
    Friend WithEvents SpQ298BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_Q298TableAdapter As szet_64.SZETAVDataSetTableAdapters.sp_Q298TableAdapter
    Friend WithEvents lblOBJTIP As System.Windows.Forms.Label
    Friend WithEvents cmbOBJTIP As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents optCSOPORTOS2 As System.Windows.Forms.RadioButton
    Friend WithEvents optCSOPORTOS1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblIDO As System.Windows.Forms.Label
    Friend WithEvents txtIDO As System.Windows.Forms.TextBox
End Class
