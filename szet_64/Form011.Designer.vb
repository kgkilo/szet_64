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
        Me.MEGNEV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEPHSZ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GYSZAM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SZETAVDataSet = New szet_64.SZETAVDataSet()
        Me.cmdUJ = New System.Windows.Forms.Button()
        Me.cmdMODOSIT = New System.Windows.Forms.Button()
        Me.cmdTOROL = New System.Windows.Forms.Button()
        Me.cmdEXIT = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmbOBJTIP = New System.Windows.Forms.ComboBox()
        Me.SpQ296BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblOBJTIP = New System.Windows.Forms.Label()
        Me.Sp_Q296TableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_Q296TableAdapter()
        Me.txtTALALAT = New System.Windows.Forms.TextBox()
        Me.lblTALALAT = New System.Windows.Forms.Label()
        CType(Me.grd011, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpQ296BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd011
        '
        Me.grd011.AllowUserToAddRows = False
        Me.grd011.AutoGenerateColumns = False
        Me.grd011.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd011.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd011.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.MEGNEV, Me.TIPUS, Me.TELEPHSZ, Me.GYSZAM, Me.C6, Me.C7, Me.C8, Me.C9, Me.C10, Me.C11, Me.C12, Me.C13, Me.C14, Me.C15})
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
        'MEGNEV
        '
        Me.MEGNEV.DataPropertyName = "MEGNEV"
        Me.MEGNEV.HeaderText = "Megnevezés"
        Me.MEGNEV.Name = "MEGNEV"
        Me.MEGNEV.ReadOnly = True
        '
        'TIPUS
        '
        Me.TIPUS.DataPropertyName = "TIPUS"
        Me.TIPUS.HeaderText = "Típus"
        Me.TIPUS.Name = "TIPUS"
        Me.TIPUS.ReadOnly = True
        '
        'TELEPHSZ
        '
        Me.TELEPHSZ.DataPropertyName = "TELEPHSZ"
        Me.TELEPHSZ.HeaderText = "Telepítési helyszám"
        Me.TELEPHSZ.Name = "TELEPHSZ"
        Me.TELEPHSZ.ReadOnly = True
        '
        'GYSZAM
        '
        Me.GYSZAM.DataPropertyName = "GYSZAM"
        Me.GYSZAM.HeaderText = "Gyári szám"
        Me.GYSZAM.Name = "GYSZAM"
        Me.GYSZAM.ReadOnly = True
        '
        'C6
        '
        Me.C6.HeaderText = "C6"
        Me.C6.Name = "C6"
        Me.C6.ReadOnly = True
        '
        'C7
        '
        Me.C7.HeaderText = "C7"
        Me.C7.Name = "C7"
        Me.C7.ReadOnly = True
        '
        'C8
        '
        Me.C8.HeaderText = "C8"
        Me.C8.Name = "C8"
        Me.C8.ReadOnly = True
        '
        'C9
        '
        Me.C9.HeaderText = "C9"
        Me.C9.Name = "C9"
        Me.C9.ReadOnly = True
        '
        'C10
        '
        Me.C10.HeaderText = "C10"
        Me.C10.Name = "C10"
        Me.C10.ReadOnly = True
        '
        'C11
        '
        Me.C11.HeaderText = "C11"
        Me.C11.Name = "C11"
        Me.C11.ReadOnly = True
        '
        'C12
        '
        Me.C12.HeaderText = "C12"
        Me.C12.Name = "C12"
        Me.C12.ReadOnly = True
        '
        'C13
        '
        Me.C13.HeaderText = "C13"
        Me.C13.Name = "C13"
        Me.C13.ReadOnly = True
        '
        'C14
        '
        Me.C14.HeaderText = "C14"
        Me.C14.Name = "C14"
        Me.C14.ReadOnly = True
        '
        'C15
        '
        Me.C15.HeaderText = "C15"
        Me.C15.Name = "C15"
        Me.C15.ReadOnly = True
        '
        'SZETAVDataSet
        '
        Me.SZETAVDataSet.DataSetName = "SZETAVDataSet"
        Me.SZETAVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdUJ
        '
        Me.cmdUJ.Location = New System.Drawing.Point(12, 116)
        Me.cmdUJ.Name = "cmdUJ"
        Me.cmdUJ.Size = New System.Drawing.Size(75, 23)
        Me.cmdUJ.TabIndex = 1
        Me.cmdUJ.Text = "Új..."
        Me.cmdUJ.UseVisualStyleBackColor = True
        '
        'cmdMODOSIT
        '
        Me.cmdMODOSIT.Location = New System.Drawing.Point(12, 146)
        Me.cmdMODOSIT.Name = "cmdMODOSIT"
        Me.cmdMODOSIT.Size = New System.Drawing.Size(75, 23)
        Me.cmdMODOSIT.TabIndex = 2
        Me.cmdMODOSIT.Text = "Módosít..."
        Me.cmdMODOSIT.UseVisualStyleBackColor = True
        '
        'cmdTOROL
        '
        Me.cmdTOROL.Location = New System.Drawing.Point(12, 176)
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
        Me.cmbOBJTIP.DataSource = Me.SpQ296BindingSource
        Me.cmbOBJTIP.DisplayMember = "KODENEV"
        Me.cmbOBJTIP.FormattingEnabled = True
        Me.cmbOBJTIP.Location = New System.Drawing.Point(198, 58)
        Me.cmbOBJTIP.Name = "cmbOBJTIP"
        Me.cmbOBJTIP.Size = New System.Drawing.Size(180, 21)
        Me.cmbOBJTIP.TabIndex = 11
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
        Me.lblOBJTIP.Location = New System.Drawing.Point(93, 61)
        Me.lblOBJTIP.Name = "lblOBJTIP"
        Me.lblOBJTIP.Size = New System.Drawing.Size(99, 13)
        Me.lblOBJTIP.TabIndex = 12
        Me.lblOBJTIP.Text = "Berendezés típus"
        Me.lblOBJTIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Sp_Q296TableAdapter
        '
        Me.Sp_Q296TableAdapter.ClearBeforeFill = True
        '
        'txtTALALAT
        '
        Me.txtTALALAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTALALAT.Enabled = False
        Me.txtTALALAT.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtTALALAT.Location = New System.Drawing.Point(12, 58)
        Me.txtTALALAT.Name = "txtTALALAT"
        Me.txtTALALAT.ReadOnly = True
        Me.txtTALALAT.Size = New System.Drawing.Size(75, 20)
        Me.txtTALALAT.TabIndex = 13
        Me.txtTALALAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTALALAT
        '
        Me.lblTALALAT.Location = New System.Drawing.Point(12, 39)
        Me.lblTALALAT.Name = "lblTALALAT"
        Me.lblTALALAT.Size = New System.Drawing.Size(75, 13)
        Me.lblTALALAT.TabIndex = 14
        Me.lblTALALAT.Text = "Találatok"
        Me.lblTALALAT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form011
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 586)
        Me.Controls.Add(Me.lblTALALAT)
        Me.Controls.Add(Me.txtTALALAT)
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
        Me.Text = "Form011 - Berendezések"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grd011, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpQ296BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd011 As System.Windows.Forms.DataGridView
    Friend WithEvents SZETAVDataSet As szet_64.SZETAVDataSet
    Friend WithEvents cmdUJ As System.Windows.Forms.Button
    Friend WithEvents cmdMODOSIT As System.Windows.Forms.Button
    Friend WithEvents cmdTOROL As System.Windows.Forms.Button
    Friend WithEvents cmdEXIT As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cmbOBJTIP As System.Windows.Forms.ComboBox
    Friend WithEvents lblOBJTIP As System.Windows.Forms.Label
    Friend WithEvents SpQ296BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_Q296TableAdapter As szet_64.SZETAVDataSetTableAdapters.sp_Q296TableAdapter
    Friend WithEvents txtTALALAT As System.Windows.Forms.TextBox
    Friend WithEvents lblTALALAT As System.Windows.Forms.Label
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MEGNEV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TELEPHSZ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GYSZAM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C15 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
