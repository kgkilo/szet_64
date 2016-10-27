<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form005a
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
        Me.txtNEV = New System.Windows.Forms.TextBox()
        Me.txtLOGIN = New System.Windows.Forms.TextBox()
        Me.cmbSZEREGYS = New System.Windows.Forms.ComboBox()
        Me.SpQ271BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SZETAVDataSet = New szet_64.SZETAVDataSet()
        Me.cmbBEOSZT = New System.Windows.Forms.ComboBox()
        Me.SpQ304BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_Q271TableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_Q271TableAdapter()
        Me.Sp_Q304TableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_Q304TableAdapter()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblNEV = New System.Windows.Forms.Label()
        Me.lblLOGIN = New System.Windows.Forms.Label()
        Me.lblSZEREGYS = New System.Windows.Forms.Label()
        Me.lblBEOSZT = New System.Windows.Forms.Label()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCANCEL = New System.Windows.Forms.Button()
        CType(Me.SpQ271BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpQ304BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNEV
        '
        Me.txtNEV.Location = New System.Drawing.Point(105, 56)
        Me.txtNEV.Name = "txtNEV"
        Me.txtNEV.Size = New System.Drawing.Size(137, 20)
        Me.txtNEV.TabIndex = 0
        '
        'txtLOGIN
        '
        Me.txtLOGIN.Location = New System.Drawing.Point(105, 83)
        Me.txtLOGIN.Name = "txtLOGIN"
        Me.txtLOGIN.Size = New System.Drawing.Size(137, 20)
        Me.txtLOGIN.TabIndex = 1
        '
        'cmbSZEREGYS
        '
        Me.cmbSZEREGYS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbSZEREGYS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSZEREGYS.DataSource = Me.SpQ271BindingSource
        Me.cmbSZEREGYS.DisplayMember = "KODENEV"
        Me.cmbSZEREGYS.FormattingEnabled = True
        Me.cmbSZEREGYS.Location = New System.Drawing.Point(361, 56)
        Me.cmbSZEREGYS.Name = "cmbSZEREGYS"
        Me.cmbSZEREGYS.Size = New System.Drawing.Size(137, 21)
        Me.cmbSZEREGYS.TabIndex = 2
        Me.cmbSZEREGYS.ValueMember = "KODERT"
        '
        'SpQ271BindingSource
        '
        Me.SpQ271BindingSource.DataMember = "sp_Q271"
        Me.SpQ271BindingSource.DataSource = Me.SZETAVDataSet
        '
        'SZETAVDataSet
        '
        Me.SZETAVDataSet.DataSetName = "SZETAVDataSet"
        Me.SZETAVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbBEOSZT
        '
        Me.cmbBEOSZT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbBEOSZT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBEOSZT.DataSource = Me.SpQ304BindingSource
        Me.cmbBEOSZT.DisplayMember = "KODENEV"
        Me.cmbBEOSZT.FormattingEnabled = True
        Me.cmbBEOSZT.Location = New System.Drawing.Point(361, 83)
        Me.cmbBEOSZT.Name = "cmbBEOSZT"
        Me.cmbBEOSZT.Size = New System.Drawing.Size(137, 21)
        Me.cmbBEOSZT.TabIndex = 3
        Me.cmbBEOSZT.ValueMember = "KODERT"
        '
        'SpQ304BindingSource
        '
        Me.SpQ304BindingSource.DataMember = "sp_Q304"
        Me.SpQ304BindingSource.DataSource = Me.SZETAVDataSet
        '
        'Sp_Q271TableAdapter
        '
        Me.Sp_Q271TableAdapter.ClearBeforeFill = True
        '
        'Sp_Q304TableAdapter
        '
        Me.Sp_Q304TableAdapter.ClearBeforeFill = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(188, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(156, 25)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Dolgozó adatai"
        '
        'lblNEV
        '
        Me.lblNEV.AutoSize = True
        Me.lblNEV.Location = New System.Drawing.Point(69, 59)
        Me.lblNEV.Name = "lblNEV"
        Me.lblNEV.Size = New System.Drawing.Size(30, 13)
        Me.lblNEV.TabIndex = 5
        Me.lblNEV.Text = "Név:"
        Me.lblNEV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLOGIN
        '
        Me.lblLOGIN.AutoSize = True
        Me.lblLOGIN.Location = New System.Drawing.Point(10, 86)
        Me.lblLOGIN.Name = "lblLOGIN"
        Me.lblLOGIN.Size = New System.Drawing.Size(89, 13)
        Me.lblLOGIN.TabIndex = 6
        Me.lblLOGIN.Text = "Felhasználói név:"
        Me.lblLOGIN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSZEREGYS
        '
        Me.lblSZEREGYS.AutoSize = True
        Me.lblSZEREGYS.Location = New System.Drawing.Point(259, 59)
        Me.lblSZEREGYS.Name = "lblSZEREGYS"
        Me.lblSZEREGYS.Size = New System.Drawing.Size(96, 13)
        Me.lblSZEREGYS.TabIndex = 7
        Me.lblSZEREGYS.Text = "Szervezeti egység:"
        Me.lblSZEREGYS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBEOSZT
        '
        Me.lblBEOSZT.AutoSize = True
        Me.lblBEOSZT.Location = New System.Drawing.Point(302, 86)
        Me.lblBEOSZT.Name = "lblBEOSZT"
        Me.lblBEOSZT.Size = New System.Drawing.Size(53, 13)
        Me.lblBEOSZT.TabIndex = 8
        Me.lblBEOSZT.Text = "Beosztás:"
        Me.lblBEOSZT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(423, 126)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 9
        Me.cmdOK.Text = "Rendben"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCANCEL
        '
        Me.cmdCANCEL.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCANCEL.Location = New System.Drawing.Point(12, 126)
        Me.cmdCANCEL.Name = "cmdCANCEL"
        Me.cmdCANCEL.Size = New System.Drawing.Size(75, 23)
        Me.cmdCANCEL.TabIndex = 10
        Me.cmdCANCEL.Text = "Mégsem"
        Me.cmdCANCEL.UseVisualStyleBackColor = True
        '
        'Form005a
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCANCEL
        Me.ClientSize = New System.Drawing.Size(510, 161)
        Me.Controls.Add(Me.cmdCANCEL)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.lblBEOSZT)
        Me.Controls.Add(Me.lblSZEREGYS)
        Me.Controls.Add(Me.lblLOGIN)
        Me.Controls.Add(Me.lblNEV)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.cmbBEOSZT)
        Me.Controls.Add(Me.cmbSZEREGYS)
        Me.Controls.Add(Me.txtLOGIN)
        Me.Controls.Add(Me.txtNEV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form005a"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "-1"
        Me.Text = "Form005a - Dolgozó adatai"
        CType(Me.SpQ271BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpQ304BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNEV As System.Windows.Forms.TextBox
    Friend WithEvents txtLOGIN As System.Windows.Forms.TextBox
    Friend WithEvents cmbSZEREGYS As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBEOSZT As System.Windows.Forms.ComboBox
    Friend WithEvents SZETAVDataSet As szet_64.SZETAVDataSet
    Friend WithEvents SpQ271BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_Q271TableAdapter As szet_64.SZETAVDataSetTableAdapters.sp_Q271TableAdapter
    Friend WithEvents SpQ304BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_Q304TableAdapter As szet_64.SZETAVDataSetTableAdapters.sp_Q304TableAdapter
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblNEV As System.Windows.Forms.Label
    Friend WithEvents lblLOGIN As System.Windows.Forms.Label
    Friend WithEvents lblSZEREGYS As System.Windows.Forms.Label
    Friend WithEvents lblBEOSZT As System.Windows.Forms.Label
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdCANCEL As System.Windows.Forms.Button
End Class
