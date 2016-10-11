<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form012
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblOBJTIP = New System.Windows.Forms.Label()
        Me.cmbOBJTIP = New System.Windows.Forms.ComboBox()
        Me.SZETAVDataSet = New szet_64.SZETAVDataSet()
        Me.SpQ296BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_Q296TableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_Q296TableAdapter()
        Me.cmbMEGNEV = New System.Windows.Forms.ComboBox()
        Me.lblMEGNEV = New System.Windows.Forms.Label()
        Me.cmbOBJTIP2 = New System.Windows.Forms.ComboBox()
        Me.lblOBJTIP2 = New System.Windows.Forms.Label()
        Me.lblFUTOMUNEV = New System.Windows.Forms.Label()
        Me.txtFUTOMUNEV = New System.Windows.Forms.TextBox()
        Me.txtTIPUS = New System.Windows.Forms.TextBox()
        Me.txtTELEPHSZ = New System.Windows.Forms.TextBox()
        Me.txtGYSZAM = New System.Windows.Forms.TextBox()
        Me.lblTIPUS = New System.Windows.Forms.Label()
        Me.lblTELEPHSZ = New System.Windows.Forms.Label()
        Me.lblGYSZAM = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpQ296BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(289, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(268, 25)
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "Kapcsolatok karbantartása"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTIPUS)
        Me.GroupBox1.Controls.Add(Me.lblGYSZAM)
        Me.GroupBox1.Controls.Add(Me.lblTELEPHSZ)
        Me.GroupBox1.Controls.Add(Me.lblFUTOMUNEV)
        Me.GroupBox1.Controls.Add(Me.txtGYSZAM)
        Me.GroupBox1.Controls.Add(Me.txtTELEPHSZ)
        Me.GroupBox1.Controls.Add(Me.txtTIPUS)
        Me.GroupBox1.Controls.Add(Me.txtFUTOMUNEV)
        Me.GroupBox1.Controls.Add(Me.lblMEGNEV)
        Me.GroupBox1.Controls.Add(Me.lblOBJTIP)
        Me.GroupBox1.Controls.Add(Me.cmbMEGNEV)
        Me.GroupBox1.Controls.Add(Me.cmbOBJTIP)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(822, 107)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Berendezés választás"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbOBJTIP2)
        Me.GroupBox2.Controls.Add(Me.lblOBJTIP2)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 174)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(822, 302)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kapcsolatok"
        '
        'lblOBJTIP
        '
        Me.lblOBJTIP.Location = New System.Drawing.Point(43, 35)
        Me.lblOBJTIP.Name = "lblOBJTIP"
        Me.lblOBJTIP.Size = New System.Drawing.Size(99, 13)
        Me.lblOBJTIP.TabIndex = 14
        Me.lblOBJTIP.Text = "Berendezés típus"
        Me.lblOBJTIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbOBJTIP
        '
        Me.cmbOBJTIP.DataSource = Me.SpQ296BindingSource
        Me.cmbOBJTIP.DisplayMember = "KODENEV"
        Me.cmbOBJTIP.FormattingEnabled = True
        Me.cmbOBJTIP.Location = New System.Drawing.Point(148, 32)
        Me.cmbOBJTIP.Name = "cmbOBJTIP"
        Me.cmbOBJTIP.Size = New System.Drawing.Size(180, 21)
        Me.cmbOBJTIP.TabIndex = 13
        Me.cmbOBJTIP.Tag = "296"
        Me.cmbOBJTIP.ValueMember = "KODERT"
        '
        'SZETAVDataSet
        '
        Me.SZETAVDataSet.DataSetName = "SZETAVDataSet"
        Me.SZETAVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpQ296BindingSource
        '
        Me.SpQ296BindingSource.DataMember = "sp_Q296"
        Me.SpQ296BindingSource.DataSource = Me.SZETAVDataSet
        '
        'Sp_Q296TableAdapter
        '
        Me.Sp_Q296TableAdapter.ClearBeforeFill = True
        '
        'cmbMEGNEV
        '
        Me.cmbMEGNEV.DisplayMember = "KODENEV"
        Me.cmbMEGNEV.FormattingEnabled = True
        Me.cmbMEGNEV.Location = New System.Drawing.Point(148, 59)
        Me.cmbMEGNEV.Name = "cmbMEGNEV"
        Me.cmbMEGNEV.Size = New System.Drawing.Size(180, 21)
        Me.cmbMEGNEV.TabIndex = 13
        Me.cmbMEGNEV.Tag = "296"
        Me.cmbMEGNEV.ValueMember = "KODERT"
        '
        'lblMEGNEV
        '
        Me.lblMEGNEV.Location = New System.Drawing.Point(43, 62)
        Me.lblMEGNEV.Name = "lblMEGNEV"
        Me.lblMEGNEV.Size = New System.Drawing.Size(99, 13)
        Me.lblMEGNEV.TabIndex = 14
        Me.lblMEGNEV.Text = "Berendezés"
        Me.lblMEGNEV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbOBJTIP2
        '
        Me.cmbOBJTIP2.DisplayMember = "KODENEV"
        Me.cmbOBJTIP2.FormattingEnabled = True
        Me.cmbOBJTIP2.Location = New System.Drawing.Point(148, 19)
        Me.cmbOBJTIP2.Name = "cmbOBJTIP2"
        Me.cmbOBJTIP2.Size = New System.Drawing.Size(180, 21)
        Me.cmbOBJTIP2.TabIndex = 13
        Me.cmbOBJTIP2.Tag = "296"
        Me.cmbOBJTIP2.ValueMember = "KODERT"
        '
        'lblOBJTIP2
        '
        Me.lblOBJTIP2.Location = New System.Drawing.Point(6, 22)
        Me.lblOBJTIP2.Name = "lblOBJTIP2"
        Me.lblOBJTIP2.Size = New System.Drawing.Size(136, 13)
        Me.lblOBJTIP2.TabIndex = 14
        Me.lblOBJTIP2.Text = "Kapcsolódó berendezés"
        Me.lblOBJTIP2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFUTOMUNEV
        '
        Me.lblFUTOMUNEV.Location = New System.Drawing.Point(534, 16)
        Me.lblFUTOMUNEV.Name = "lblFUTOMUNEV"
        Me.lblFUTOMUNEV.Size = New System.Drawing.Size(138, 13)
        Me.lblFUTOMUNEV.TabIndex = 16
        Me.lblFUTOMUNEV.Text = "Berendezés név"
        Me.lblFUTOMUNEV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFUTOMUNEV
        '
        Me.txtFUTOMUNEV.Enabled = False
        Me.txtFUTOMUNEV.Location = New System.Drawing.Point(534, 32)
        Me.txtFUTOMUNEV.Name = "txtFUTOMUNEV"
        Me.txtFUTOMUNEV.ReadOnly = True
        Me.txtFUTOMUNEV.Size = New System.Drawing.Size(138, 20)
        Me.txtFUTOMUNEV.TabIndex = 15
        '
        'txtTIPUS
        '
        Me.txtTIPUS.Enabled = False
        Me.txtTIPUS.Location = New System.Drawing.Point(678, 32)
        Me.txtTIPUS.Name = "txtTIPUS"
        Me.txtTIPUS.ReadOnly = True
        Me.txtTIPUS.Size = New System.Drawing.Size(138, 20)
        Me.txtTIPUS.TabIndex = 15
        '
        'txtTELEPHSZ
        '
        Me.txtTELEPHSZ.Enabled = False
        Me.txtTELEPHSZ.Location = New System.Drawing.Point(534, 79)
        Me.txtTELEPHSZ.Name = "txtTELEPHSZ"
        Me.txtTELEPHSZ.ReadOnly = True
        Me.txtTELEPHSZ.Size = New System.Drawing.Size(138, 20)
        Me.txtTELEPHSZ.TabIndex = 15
        '
        'txtGYSZAM
        '
        Me.txtGYSZAM.Enabled = False
        Me.txtGYSZAM.Location = New System.Drawing.Point(678, 79)
        Me.txtGYSZAM.Name = "txtGYSZAM"
        Me.txtGYSZAM.ReadOnly = True
        Me.txtGYSZAM.Size = New System.Drawing.Size(138, 20)
        Me.txtGYSZAM.TabIndex = 15
        '
        'lblTIPUS
        '
        Me.lblTIPUS.Location = New System.Drawing.Point(675, 16)
        Me.lblTIPUS.Name = "lblTIPUS"
        Me.lblTIPUS.Size = New System.Drawing.Size(138, 13)
        Me.lblTIPUS.TabIndex = 16
        Me.lblTIPUS.Text = "Gyári típus"
        Me.lblTIPUS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTELEPHSZ
        '
        Me.lblTELEPHSZ.Location = New System.Drawing.Point(534, 63)
        Me.lblTELEPHSZ.Name = "lblTELEPHSZ"
        Me.lblTELEPHSZ.Size = New System.Drawing.Size(138, 13)
        Me.lblTELEPHSZ.TabIndex = 16
        Me.lblTELEPHSZ.Text = "Telepítési helyszám"
        Me.lblTELEPHSZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGYSZAM
        '
        Me.lblGYSZAM.Location = New System.Drawing.Point(675, 63)
        Me.lblGYSZAM.Name = "lblGYSZAM"
        Me.lblGYSZAM.Size = New System.Drawing.Size(138, 13)
        Me.lblGYSZAM.TabIndex = 16
        Me.lblGYSZAM.Text = "Gyári szám"
        Me.lblGYSZAM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form012
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 586)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form012"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form012 - Kapcsolatok"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpQ296BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblOBJTIP As System.Windows.Forms.Label
    Friend WithEvents cmbOBJTIP As System.Windows.Forms.ComboBox
    Friend WithEvents SZETAVDataSet As szet_64.SZETAVDataSet
    Friend WithEvents SpQ296BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_Q296TableAdapter As szet_64.SZETAVDataSetTableAdapters.sp_Q296TableAdapter
    Friend WithEvents lblMEGNEV As System.Windows.Forms.Label
    Friend WithEvents cmbMEGNEV As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOBJTIP2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblOBJTIP2 As System.Windows.Forms.Label
    Friend WithEvents lblFUTOMUNEV As System.Windows.Forms.Label
    Friend WithEvents txtTELEPHSZ As System.Windows.Forms.TextBox
    Friend WithEvents txtTIPUS As System.Windows.Forms.TextBox
    Friend WithEvents txtFUTOMUNEV As System.Windows.Forms.TextBox
    Friend WithEvents lblTIPUS As System.Windows.Forms.Label
    Friend WithEvents lblGYSZAM As System.Windows.Forms.Label
    Friend WithEvents lblTELEPHSZ As System.Windows.Forms.Label
    Friend WithEvents txtGYSZAM As System.Windows.Forms.TextBox
End Class
