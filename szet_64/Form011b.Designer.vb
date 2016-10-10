<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form011b
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
        Me.txtOBJTIP = New System.Windows.Forms.TextBox()
        Me.cmdCANCEL = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblEPULTIP = New System.Windows.Forms.Label()
        Me.lblVAROS = New System.Windows.Forms.Label()
        Me.cmbEPULTIP = New System.Windows.Forms.ComboBox()
        Me.cmbVAROS = New System.Windows.Forms.ComboBox()
        Me.lblEPULSZ = New System.Windows.Forms.Label()
        Me.lblHELYR = New System.Windows.Forms.Label()
        Me.lblEPULNEV = New System.Windows.Forms.Label()
        Me.lblHSZ = New System.Windows.Forms.Label()
        Me.lblUTCA = New System.Windows.Forms.Label()
        Me.lblIRSZAM = New System.Windows.Forms.Label()
        Me.txtEPULSZ = New System.Windows.Forms.TextBox()
        Me.txtHELYR = New System.Windows.Forms.TextBox()
        Me.txtEPULNEV = New System.Windows.Forms.TextBox()
        Me.txtHSZ = New System.Windows.Forms.TextBox()
        Me.txtUTCA = New System.Windows.Forms.TextBox()
        Me.txtIRSZAM = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtOBJTIP
        '
        Me.txtOBJTIP.Location = New System.Drawing.Point(140, 402)
        Me.txtOBJTIP.Name = "txtOBJTIP"
        Me.txtOBJTIP.Size = New System.Drawing.Size(100, 20)
        Me.txtOBJTIP.TabIndex = 25
        Me.txtOBJTIP.TabStop = False
        Me.txtOBJTIP.Visible = False
        '
        'cmdCANCEL
        '
        Me.cmdCANCEL.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCANCEL.Location = New System.Drawing.Point(13, 402)
        Me.cmdCANCEL.Name = "cmdCANCEL"
        Me.cmdCANCEL.Size = New System.Drawing.Size(75, 23)
        Me.cmdCANCEL.TabIndex = 26
        Me.cmdCANCEL.Text = "Mégsem"
        Me.cmdCANCEL.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(663, 402)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 27
        Me.cmdOK.Text = "Rendben"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEPULTIP)
        Me.GroupBox1.Controls.Add(Me.lblVAROS)
        Me.GroupBox1.Controls.Add(Me.cmbEPULTIP)
        Me.GroupBox1.Controls.Add(Me.cmbVAROS)
        Me.GroupBox1.Controls.Add(Me.lblEPULSZ)
        Me.GroupBox1.Controls.Add(Me.lblHELYR)
        Me.GroupBox1.Controls.Add(Me.lblEPULNEV)
        Me.GroupBox1.Controls.Add(Me.lblHSZ)
        Me.GroupBox1.Controls.Add(Me.lblUTCA)
        Me.GroupBox1.Controls.Add(Me.lblIRSZAM)
        Me.GroupBox1.Controls.Add(Me.txtEPULSZ)
        Me.GroupBox1.Controls.Add(Me.txtHELYR)
        Me.GroupBox1.Controls.Add(Me.txtEPULNEV)
        Me.GroupBox1.Controls.Add(Me.txtHSZ)
        Me.GroupBox1.Controls.Add(Me.txtUTCA)
        Me.GroupBox1.Controls.Add(Me.txtIRSZAM)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 76)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Épület adatai"
        '
        'lblEPULTIP
        '
        Me.lblEPULTIP.Location = New System.Drawing.Point(360, 47)
        Me.lblEPULTIP.Name = "lblEPULTIP"
        Me.lblEPULTIP.Size = New System.Drawing.Size(80, 13)
        Me.lblEPULTIP.TabIndex = 21
        Me.lblEPULTIP.Text = "Épület típusa"
        Me.lblEPULTIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVAROS
        '
        Me.lblVAROS.Location = New System.Drawing.Point(179, 22)
        Me.lblVAROS.Name = "lblVAROS"
        Me.lblVAROS.Size = New System.Drawing.Size(60, 13)
        Me.lblVAROS.TabIndex = 21
        Me.lblVAROS.Text = "Város"
        Me.lblVAROS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbEPULTIP
        '
        Me.cmbEPULTIP.DisplayMember = "KODENEV"
        Me.cmbEPULTIP.FormattingEnabled = True
        Me.cmbEPULTIP.Location = New System.Drawing.Point(446, 44)
        Me.cmbEPULTIP.Name = "cmbEPULTIP"
        Me.cmbEPULTIP.Size = New System.Drawing.Size(138, 21)
        Me.cmbEPULTIP.TabIndex = 6
        Me.cmbEPULTIP.Tag = "274"
        Me.cmbEPULTIP.ValueMember = "KODERT"
        '
        'cmbVAROS
        '
        Me.cmbVAROS.DisplayMember = "KODENEV"
        Me.cmbVAROS.FormattingEnabled = True
        Me.cmbVAROS.Location = New System.Drawing.Point(245, 19)
        Me.cmbVAROS.Name = "cmbVAROS"
        Me.cmbVAROS.Size = New System.Drawing.Size(138, 21)
        Me.cmbVAROS.TabIndex = 1
        Me.cmbVAROS.Tag = "289"
        Me.cmbVAROS.ValueMember = "KODERT"
        '
        'lblEPULSZ
        '
        Me.lblEPULSZ.Location = New System.Drawing.Point(167, 48)
        Me.lblEPULSZ.Name = "lblEPULSZ"
        Me.lblEPULSZ.Size = New System.Drawing.Size(72, 13)
        Me.lblEPULSZ.TabIndex = 19
        Me.lblEPULSZ.Text = "Épületszám"
        Me.lblEPULSZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHELYR
        '
        Me.lblHELYR.Location = New System.Drawing.Point(10, 48)
        Me.lblHELYR.Name = "lblHELYR"
        Me.lblHELYR.Size = New System.Drawing.Size(76, 13)
        Me.lblHELYR.TabIndex = 19
        Me.lblHELYR.Text = "Helyrajzi szám"
        Me.lblHELYR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEPULNEV
        '
        Me.lblEPULNEV.Location = New System.Drawing.Point(590, 48)
        Me.lblEPULNEV.Name = "lblEPULNEV"
        Me.lblEPULNEV.Size = New System.Drawing.Size(54, 13)
        Me.lblEPULNEV.TabIndex = 19
        Me.lblEPULNEV.Text = "Ép. neve"
        Me.lblEPULNEV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHSZ
        '
        Me.lblHSZ.Location = New System.Drawing.Point(590, 22)
        Me.lblHSZ.Name = "lblHSZ"
        Me.lblHSZ.Size = New System.Drawing.Size(54, 13)
        Me.lblHSZ.TabIndex = 19
        Me.lblHSZ.Text = "Házszám"
        Me.lblHSZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUTCA
        '
        Me.lblUTCA.Location = New System.Drawing.Point(397, 22)
        Me.lblUTCA.Name = "lblUTCA"
        Me.lblUTCA.Size = New System.Drawing.Size(43, 13)
        Me.lblUTCA.TabIndex = 19
        Me.lblUTCA.Text = "Utca"
        Me.lblUTCA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIRSZAM
        '
        Me.lblIRSZAM.Location = New System.Drawing.Point(10, 22)
        Me.lblIRSZAM.Name = "lblIRSZAM"
        Me.lblIRSZAM.Size = New System.Drawing.Size(76, 13)
        Me.lblIRSZAM.TabIndex = 19
        Me.lblIRSZAM.Text = "Irányítószám"
        Me.lblIRSZAM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEPULSZ
        '
        Me.txtEPULSZ.Location = New System.Drawing.Point(245, 45)
        Me.txtEPULSZ.Name = "txtEPULSZ"
        Me.txtEPULSZ.Size = New System.Drawing.Size(69, 20)
        Me.txtEPULSZ.TabIndex = 5
        '
        'txtHELYR
        '
        Me.txtHELYR.Location = New System.Drawing.Point(92, 45)
        Me.txtHELYR.Name = "txtHELYR"
        Me.txtHELYR.Size = New System.Drawing.Size(69, 20)
        Me.txtHELYR.TabIndex = 4
        '
        'txtEPULNEV
        '
        Me.txtEPULNEV.Location = New System.Drawing.Point(650, 45)
        Me.txtEPULNEV.Name = "txtEPULNEV"
        Me.txtEPULNEV.Size = New System.Drawing.Size(69, 20)
        Me.txtEPULNEV.TabIndex = 7
        '
        'txtHSZ
        '
        Me.txtHSZ.Location = New System.Drawing.Point(650, 19)
        Me.txtHSZ.Name = "txtHSZ"
        Me.txtHSZ.Size = New System.Drawing.Size(69, 20)
        Me.txtHSZ.TabIndex = 3
        '
        'txtUTCA
        '
        Me.txtUTCA.Location = New System.Drawing.Point(446, 19)
        Me.txtUTCA.Name = "txtUTCA"
        Me.txtUTCA.Size = New System.Drawing.Size(138, 20)
        Me.txtUTCA.TabIndex = 2
        '
        'txtIRSZAM
        '
        Me.txtIRSZAM.Location = New System.Drawing.Point(92, 19)
        Me.txtIRSZAM.Name = "txtIRSZAM"
        Me.txtIRSZAM.Size = New System.Drawing.Size(69, 20)
        Me.txtIRSZAM.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(13, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(728, 276)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Épület műszaki adatai"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(307, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(138, 25)
        Me.lblTitle.TabIndex = 30
        Me.lblTitle.Text = "Épület adatai"
        '
        'Form011b
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCANCEL
        Me.ClientSize = New System.Drawing.Size(753, 437)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtOBJTIP)
        Me.Controls.Add(Me.cmdCANCEL)
        Me.Controls.Add(Me.cmdOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form011b"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "-1"
        Me.Text = "Form011b - Épület adatai"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOBJTIP As System.Windows.Forms.TextBox
    Friend WithEvents cmdCANCEL As System.Windows.Forms.Button
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblHELYR As System.Windows.Forms.Label
    Friend WithEvents lblIRSZAM As System.Windows.Forms.Label
    Friend WithEvents txtHELYR As System.Windows.Forms.TextBox
    Friend WithEvents txtIRSZAM As System.Windows.Forms.TextBox
    Friend WithEvents lblEPULTIP As System.Windows.Forms.Label
    Friend WithEvents lblVAROS As System.Windows.Forms.Label
    Friend WithEvents cmbEPULTIP As System.Windows.Forms.ComboBox
    Friend WithEvents cmbVAROS As System.Windows.Forms.ComboBox
    Friend WithEvents lblEPULSZ As System.Windows.Forms.Label
    Friend WithEvents lblEPULNEV As System.Windows.Forms.Label
    Friend WithEvents lblHSZ As System.Windows.Forms.Label
    Friend WithEvents lblUTCA As System.Windows.Forms.Label
    Friend WithEvents txtEPULSZ As System.Windows.Forms.TextBox
    Friend WithEvents txtEPULNEV As System.Windows.Forms.TextBox
    Friend WithEvents txtHSZ As System.Windows.Forms.TextBox
    Friend WithEvents txtUTCA As System.Windows.Forms.TextBox
End Class
