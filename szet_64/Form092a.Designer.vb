<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form092a
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
        Me.txtERTEK = New System.Windows.Forms.TextBox()
        Me.txtNEV = New System.Windows.Forms.TextBox()
        Me.SZETAVDataSet = New szet_64.SZETAVDataSet()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblERTEK = New System.Windows.Forms.Label()
        Me.lblNEV = New System.Windows.Forms.Label()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCANCEL = New System.Windows.Forms.Button()
        Me.txtKODTIP = New System.Windows.Forms.TextBox()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtERTEK
        '
        Me.txtERTEK.Location = New System.Drawing.Point(234, 56)
        Me.txtERTEK.Name = "txtERTEK"
        Me.txtERTEK.Size = New System.Drawing.Size(137, 20)
        Me.txtERTEK.TabIndex = 0
        '
        'txtNEV
        '
        Me.txtNEV.Location = New System.Drawing.Point(234, 83)
        Me.txtNEV.Name = "txtNEV"
        Me.txtNEV.Size = New System.Drawing.Size(137, 20)
        Me.txtNEV.TabIndex = 1
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
        Me.lblTitle.Location = New System.Drawing.Point(188, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(166, 25)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Kódszótári elem"
        '
        'lblERTEK
        '
        Me.lblERTEK.AutoSize = True
        Me.lblERTEK.Location = New System.Drawing.Point(198, 59)
        Me.lblERTEK.Name = "lblERTEK"
        Me.lblERTEK.Size = New System.Drawing.Size(35, 13)
        Me.lblERTEK.TabIndex = 5
        Me.lblERTEK.Text = "Érték:"
        Me.lblERTEK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNEV
        '
        Me.lblNEV.AutoSize = True
        Me.lblNEV.Location = New System.Drawing.Point(139, 86)
        Me.lblNEV.Name = "lblNEV"
        Me.lblNEV.Size = New System.Drawing.Size(84, 13)
        Me.lblNEV.TabIndex = 6
        Me.lblNEV.Text = "Megjelenítendő:"
        Me.lblNEV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(423, 126)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 2
        Me.cmdOK.Text = "Rendben"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCANCEL
        '
        Me.cmdCANCEL.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCANCEL.Location = New System.Drawing.Point(12, 126)
        Me.cmdCANCEL.Name = "cmdCANCEL"
        Me.cmdCANCEL.Size = New System.Drawing.Size(75, 23)
        Me.cmdCANCEL.TabIndex = 3
        Me.cmdCANCEL.Text = "Mégsem"
        Me.cmdCANCEL.UseVisualStyleBackColor = True
        '
        'txtKODTIP
        '
        Me.txtKODTIP.Location = New System.Drawing.Point(234, 129)
        Me.txtKODTIP.Name = "txtKODTIP"
        Me.txtKODTIP.Size = New System.Drawing.Size(41, 20)
        Me.txtKODTIP.TabIndex = 11
        Me.txtKODTIP.TabStop = False
        Me.txtKODTIP.Visible = False
        '
        'Form092a
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCANCEL
        Me.ClientSize = New System.Drawing.Size(510, 161)
        Me.Controls.Add(Me.txtKODTIP)
        Me.Controls.Add(Me.cmdCANCEL)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.lblNEV)
        Me.Controls.Add(Me.lblERTEK)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtNEV)
        Me.Controls.Add(Me.txtERTEK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form092a"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "-1"
        Me.Text = "Form092a - Kódszótári elem"
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtERTEK As System.Windows.Forms.TextBox
    Friend WithEvents txtNEV As System.Windows.Forms.TextBox
    Friend WithEvents SZETAVDataSet As szet_64.SZETAVDataSet
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblERTEK As System.Windows.Forms.Label
    Friend WithEvents lblNEV As System.Windows.Forms.Label
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdCANCEL As System.Windows.Forms.Button
    Friend WithEvents txtKODTIP As System.Windows.Forms.TextBox
End Class
