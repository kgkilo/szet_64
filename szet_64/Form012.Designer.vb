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
        Me.grdMEGNEV = New System.Windows.Forms.DataGridView()
        Me.lblOBJTIP = New System.Windows.Forms.Label()
        Me.cmbOBJTIP = New System.Windows.Forms.ComboBox()
        Me.SpQ296BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SZETAVDataSet = New szet_64.SZETAVDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbOBJTIP2 = New System.Windows.Forms.ComboBox()
        Me.lblOBJTIP2 = New System.Windows.Forms.Label()
        Me.Sp_Q296TableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_Q296TableAdapter()
        Me.lblTALALAT = New System.Windows.Forms.Label()
        Me.txtTALALAT = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdMEGNEV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpQ296BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.lblTALALAT)
        Me.GroupBox1.Controls.Add(Me.txtTALALAT)
        Me.GroupBox1.Controls.Add(Me.grdMEGNEV)
        Me.GroupBox1.Controls.Add(Me.lblOBJTIP)
        Me.GroupBox1.Controls.Add(Me.cmbOBJTIP)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(822, 177)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Berendezés választás"
        '
        'grdMEGNEV
        '
        Me.grdMEGNEV.AllowUserToAddRows = False
        Me.grdMEGNEV.AllowUserToDeleteRows = False
        Me.grdMEGNEV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMEGNEV.Location = New System.Drawing.Point(9, 47)
        Me.grdMEGNEV.Name = "grdMEGNEV"
        Me.grdMEGNEV.ReadOnly = True
        Me.grdMEGNEV.Size = New System.Drawing.Size(807, 124)
        Me.grdMEGNEV.TabIndex = 15
        '
        'lblOBJTIP
        '
        Me.lblOBJTIP.Location = New System.Drawing.Point(6, 22)
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
        Me.cmbOBJTIP.Location = New System.Drawing.Point(111, 19)
        Me.cmbOBJTIP.Name = "cmbOBJTIP"
        Me.cmbOBJTIP.Size = New System.Drawing.Size(180, 21)
        Me.cmbOBJTIP.TabIndex = 13
        Me.cmbOBJTIP.Tag = "296"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbOBJTIP2)
        Me.GroupBox2.Controls.Add(Me.lblOBJTIP2)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 230)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(822, 246)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kapcsolatok"
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
        'Sp_Q296TableAdapter
        '
        Me.Sp_Q296TableAdapter.ClearBeforeFill = True
        '
        'lblTALALAT
        '
        Me.lblTALALAT.Location = New System.Drawing.Point(660, 22)
        Me.lblTALALAT.Name = "lblTALALAT"
        Me.lblTALALAT.Size = New System.Drawing.Size(75, 13)
        Me.lblTALALAT.TabIndex = 17
        Me.lblTALALAT.Text = "Találatok"
        Me.lblTALALAT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTALALAT
        '
        Me.txtTALALAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTALALAT.Enabled = False
        Me.txtTALALAT.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtTALALAT.Location = New System.Drawing.Point(741, 19)
        Me.txtTALALAT.Name = "txtTALALAT"
        Me.txtTALALAT.ReadOnly = True
        Me.txtTALALAT.Size = New System.Drawing.Size(75, 20)
        Me.txtTALALAT.TabIndex = 16
        Me.txtTALALAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdMEGNEV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpQ296BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
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
    Friend WithEvents cmbOBJTIP2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblOBJTIP2 As System.Windows.Forms.Label
    Friend WithEvents grdMEGNEV As System.Windows.Forms.DataGridView
    Friend WithEvents lblTALALAT As System.Windows.Forms.Label
    Friend WithEvents txtTALALAT As System.Windows.Forms.TextBox
End Class
