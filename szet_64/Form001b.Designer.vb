<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form001b
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
        Me.lblOBJID = New System.Windows.Forms.Label()
        Me.lblOBJTIP = New System.Windows.Forms.Label()
        Me.cmbOBJID = New System.Windows.Forms.ComboBox()
        Me.cmbOBJTIP = New System.Windows.Forms.ComboBox()
        Me.SpQ296BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SZETAVDataSet = New szet_64.SZETAVDataSet()
        Me.lblLAKAS = New System.Windows.Forms.Label()
        Me.txtLAKAS = New System.Windows.Forms.TextBox()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCANCEL = New System.Windows.Forms.Button()
        Me.Sp_Q296TableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_Q296TableAdapter()
        CType(Me.SpQ296BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOBJID
        '
        Me.lblOBJID.Location = New System.Drawing.Point(25, 61)
        Me.lblOBJID.Name = "lblOBJID"
        Me.lblOBJID.Size = New System.Drawing.Size(99, 13)
        Me.lblOBJID.TabIndex = 29
        Me.lblOBJID.Text = "Berendezés megn."
        Me.lblOBJID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOBJTIP
        '
        Me.lblOBJTIP.Location = New System.Drawing.Point(25, 33)
        Me.lblOBJTIP.Name = "lblOBJTIP"
        Me.lblOBJTIP.Size = New System.Drawing.Size(99, 13)
        Me.lblOBJTIP.TabIndex = 30
        Me.lblOBJTIP.Text = "Berendezés típus"
        Me.lblOBJTIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbOBJID
        '
        Me.cmbOBJID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbOBJID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbOBJID.FormattingEnabled = True
        Me.cmbOBJID.Location = New System.Drawing.Point(130, 58)
        Me.cmbOBJID.Name = "cmbOBJID"
        Me.cmbOBJID.Size = New System.Drawing.Size(180, 21)
        Me.cmbOBJID.TabIndex = 1
        Me.cmbOBJID.Tag = "MEGNEV"
        '
        'cmbOBJTIP
        '
        Me.cmbOBJTIP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbOBJTIP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbOBJTIP.DataSource = Me.SpQ296BindingSource
        Me.cmbOBJTIP.DisplayMember = "KODENEV"
        Me.cmbOBJTIP.FormattingEnabled = True
        Me.cmbOBJTIP.Location = New System.Drawing.Point(130, 30)
        Me.cmbOBJTIP.Name = "cmbOBJTIP"
        Me.cmbOBJTIP.Size = New System.Drawing.Size(180, 21)
        Me.cmbOBJTIP.TabIndex = 0
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
        'lblLAKAS
        '
        Me.lblLAKAS.AutoSize = True
        Me.lblLAKAS.Location = New System.Drawing.Point(88, 88)
        Me.lblLAKAS.Name = "lblLAKAS"
        Me.lblLAKAS.Size = New System.Drawing.Size(36, 13)
        Me.lblLAKAS.TabIndex = 32
        Me.lblLAKAS.Text = "Lakás"
        Me.lblLAKAS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLAKAS
        '
        Me.txtLAKAS.Location = New System.Drawing.Point(130, 85)
        Me.txtLAKAS.Name = "txtLAKAS"
        Me.txtLAKAS.Size = New System.Drawing.Size(138, 20)
        Me.txtLAKAS.TabIndex = 2
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(235, 130)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 4
        Me.cmdOK.Text = "Rendben"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCANCEL
        '
        Me.cmdCANCEL.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCANCEL.Location = New System.Drawing.Point(12, 130)
        Me.cmdCANCEL.Name = "cmdCANCEL"
        Me.cmdCANCEL.Size = New System.Drawing.Size(75, 23)
        Me.cmdCANCEL.TabIndex = 3
        Me.cmdCANCEL.Text = "Mégsem"
        Me.cmdCANCEL.UseVisualStyleBackColor = True
        '
        'Sp_Q296TableAdapter
        '
        Me.Sp_Q296TableAdapter.ClearBeforeFill = True
        '
        'Form001b
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCANCEL
        Me.ClientSize = New System.Drawing.Size(334, 168)
        Me.Controls.Add(Me.cmdCANCEL)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.lblLAKAS)
        Me.Controls.Add(Me.txtLAKAS)
        Me.Controls.Add(Me.lblOBJID)
        Me.Controls.Add(Me.lblOBJTIP)
        Me.Controls.Add(Me.cmbOBJID)
        Me.Controls.Add(Me.cmbOBJTIP)
        Me.Name = "Form001b"
        Me.Text = "Form001b - Berendezés választás"
        CType(Me.SpQ296BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOBJID As System.Windows.Forms.Label
    Friend WithEvents lblOBJTIP As System.Windows.Forms.Label
    Friend WithEvents cmbOBJID As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOBJTIP As System.Windows.Forms.ComboBox
    Friend WithEvents lblLAKAS As System.Windows.Forms.Label
    Friend WithEvents txtLAKAS As System.Windows.Forms.TextBox
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdCANCEL As System.Windows.Forms.Button
    Friend WithEvents SZETAVDataSet As szet_64.SZETAVDataSet
    Friend WithEvents SpQ296BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_Q296TableAdapter As szet_64.SZETAVDataSetTableAdapters.sp_Q296TableAdapter
End Class
