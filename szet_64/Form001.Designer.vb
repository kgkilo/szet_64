<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form001
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
        Me.cmdEXIT = New System.Windows.Forms.Button()
        Me.cmbSZOLGJELL = New System.Windows.Forms.ComboBox()
        Me.grdMUNKALAP = New System.Windows.Forms.DataGridView()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSZOLGJELL = New System.Windows.Forms.Label()
        Me.cmbTIPUSH = New System.Windows.Forms.ComboBox()
        Me.lblTIPUSH = New System.Windows.Forms.Label()
        Me.cmbFSZAM = New System.Windows.Forms.ComboBox()
        Me.lblFSZAM = New System.Windows.Forms.Label()
        Me.cmbMLAPTIP = New System.Windows.Forms.ComboBox()
        Me.lblMLAPTIP = New System.Windows.Forms.Label()
        Me.lblMUNIDO = New System.Windows.Forms.Label()
        Me.datDATUMTOL = New System.Windows.Forms.DateTimePicker()
        Me.lblMUNIDO2 = New System.Windows.Forms.Label()
        Me.datDATUMIG = New System.Windows.Forms.DateTimePicker()
        Me.lblMUNKALAPID = New System.Windows.Forms.Label()
        Me.txtMUNKALAPID = New System.Windows.Forms.TextBox()
        Me.lblMUNELV = New System.Windows.Forms.Label()
        Me.datMUNELV = New System.Windows.Forms.DateTimePicker()
        Me.cmbALLAPOT = New System.Windows.Forms.ComboBox()
        Me.lblALLAPOT = New System.Windows.Forms.Label()
        Me.cmbOBJTIP = New System.Windows.Forms.ComboBox()
        Me.lblOBJTIP = New System.Windows.Forms.Label()
        Me.cmbOBJID = New System.Windows.Forms.ComboBox()
        Me.lblOBJID = New System.Windows.Forms.Label()
        Me.cmbDOLGID = New System.Windows.Forms.ComboBox()
        Me.lblDOLGID = New System.Windows.Forms.Label()
        Me.lblMUNDAT = New System.Windows.Forms.Label()
        Me.datMUNDATTOL = New System.Windows.Forms.DateTimePicker()
        Me.datMUNDATIG = New System.Windows.Forms.DateTimePicker()
        Me.lblMUNDAT2 = New System.Windows.Forms.Label()
        Me.cmbTELEPHSZ = New System.Windows.Forms.ComboBox()
        Me.lblTELEPHSZ = New System.Windows.Forms.Label()
        Me.cmdFRISSIT = New System.Windows.Forms.Button()
        Me.cmdUJ = New System.Windows.Forms.Button()
        Me.cmdMODOSIT = New System.Windows.Forms.Button()
        Me.cmdVISSZAIR = New System.Windows.Forms.Button()
        Me.boxPRINT = New System.Windows.Forms.GroupBox()
        Me.cmbNYOMTTIP = New System.Windows.Forms.ComboBox()
        Me.cmdLIST = New System.Windows.Forms.Button()
        Me.cmdCSOPLIST = New System.Windows.Forms.Button()
        Me.cmdMASOL = New System.Windows.Forms.Button()
        Me.txtMUNOSZ = New System.Windows.Forms.TextBox()
        Me.lblMUNOSZ = New System.Windows.Forms.Label()
        Me.txtTALALAT = New System.Windows.Forms.TextBox()
        Me.lblTALALAT = New System.Windows.Forms.Label()
        CType(Me.grdMUNKALAP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxPRINT.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdEXIT
        '
        Me.cmdEXIT.Location = New System.Drawing.Point(12, 556)
        Me.cmdEXIT.Name = "cmdEXIT"
        Me.cmdEXIT.Size = New System.Drawing.Size(75, 25)
        Me.cmdEXIT.TabIndex = 8
        Me.cmdEXIT.Text = "Kilépés"
        Me.cmdEXIT.UseVisualStyleBackColor = True
        '
        'cmbSZOLGJELL
        '
        Me.cmbSZOLGJELL.FormattingEnabled = True
        Me.cmbSZOLGJELL.Location = New System.Drawing.Point(198, 58)
        Me.cmbSZOLGJELL.Name = "cmbSZOLGJELL"
        Me.cmbSZOLGJELL.Size = New System.Drawing.Size(223, 22)
        Me.cmbSZOLGJELL.TabIndex = 9
        '
        'grdMUNKALAP
        '
        Me.grdMUNKALAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMUNKALAP.Location = New System.Drawing.Point(93, 170)
        Me.grdMUNKALAP.Name = "grdMUNKALAP"
        Me.grdMUNKALAP.Size = New System.Drawing.Size(1026, 411)
        Me.grdMUNKALAP.TabIndex = 24
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(472, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(185, 36)
        Me.lblTitle.TabIndex = 25
        Me.lblTitle.Text = "Munkalapok"
        '
        'lblSZOLGJELL
        '
        Me.lblSZOLGJELL.Location = New System.Drawing.Point(93, 61)
        Me.lblSZOLGJELL.Name = "lblSZOLGJELL"
        Me.lblSZOLGJELL.Size = New System.Drawing.Size(99, 13)
        Me.lblSZOLGJELL.TabIndex = 26
        Me.lblSZOLGJELL.Text = "Szolgáltatás jellege"
        Me.lblSZOLGJELL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTIPUSH
        '
        Me.cmbTIPUSH.FormattingEnabled = True
        Me.cmbTIPUSH.Location = New System.Drawing.Point(198, 86)
        Me.cmbTIPUSH.Name = "cmbTIPUSH"
        Me.cmbTIPUSH.Size = New System.Drawing.Size(223, 22)
        Me.cmbTIPUSH.TabIndex = 10
        '
        'lblTIPUSH
        '
        Me.lblTIPUSH.Location = New System.Drawing.Point(93, 89)
        Me.lblTIPUSH.Name = "lblTIPUSH"
        Me.lblTIPUSH.Size = New System.Drawing.Size(99, 14)
        Me.lblTIPUSH.TabIndex = 26
        Me.lblTIPUSH.Text = "Típushiba"
        Me.lblTIPUSH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbFSZAM
        '
        Me.cmbFSZAM.FormattingEnabled = True
        Me.cmbFSZAM.Location = New System.Drawing.Point(198, 114)
        Me.cmbFSZAM.Name = "cmbFSZAM"
        Me.cmbFSZAM.Size = New System.Drawing.Size(223, 22)
        Me.cmbFSZAM.TabIndex = 11
        '
        'lblFSZAM
        '
        Me.lblFSZAM.Location = New System.Drawing.Point(93, 117)
        Me.lblFSZAM.Name = "lblFSZAM"
        Me.lblFSZAM.Size = New System.Drawing.Size(99, 14)
        Me.lblFSZAM.TabIndex = 26
        Me.lblFSZAM.Text = "Főkönyvi szám"
        Me.lblFSZAM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMLAPTIP
        '
        Me.cmbMLAPTIP.FormattingEnabled = True
        Me.cmbMLAPTIP.Location = New System.Drawing.Point(198, 142)
        Me.cmbMLAPTIP.Name = "cmbMLAPTIP"
        Me.cmbMLAPTIP.Size = New System.Drawing.Size(223, 22)
        Me.cmbMLAPTIP.TabIndex = 12
        '
        'lblMLAPTIP
        '
        Me.lblMLAPTIP.Location = New System.Drawing.Point(93, 145)
        Me.lblMLAPTIP.Name = "lblMLAPTIP"
        Me.lblMLAPTIP.Size = New System.Drawing.Size(99, 14)
        Me.lblMLAPTIP.TabIndex = 26
        Me.lblMLAPTIP.Text = "Munkalap típusa"
        Me.lblMLAPTIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMUNIDO
        '
        Me.lblMUNIDO.Location = New System.Drawing.Point(791, 61)
        Me.lblMUNIDO.Name = "lblMUNIDO"
        Me.lblMUNIDO.Size = New System.Drawing.Size(99, 14)
        Me.lblMUNIDO.TabIndex = 26
        Me.lblMUNIDO.Text = "Kiállítás dátuma"
        Me.lblMUNIDO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'datDATUMTOL
        '
        Me.datDATUMTOL.Checked = False
        Me.datDATUMTOL.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datDATUMTOL.Location = New System.Drawing.Point(896, 58)
        Me.datDATUMTOL.Name = "datDATUMTOL"
        Me.datDATUMTOL.ShowCheckBox = True
        Me.datDATUMTOL.Size = New System.Drawing.Size(100, 20)
        Me.datDATUMTOL.TabIndex = 17
        Me.datDATUMTOL.Value = New Date(2016, 9, 1, 0, 0, 0, 0)
        '
        'lblMUNIDO2
        '
        Me.lblMUNIDO2.AutoSize = True
        Me.lblMUNIDO2.Location = New System.Drawing.Point(1002, 61)
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
        Me.datDATUMIG.Location = New System.Drawing.Point(1019, 58)
        Me.datDATUMIG.Name = "datDATUMIG"
        Me.datDATUMIG.ShowCheckBox = True
        Me.datDATUMIG.Size = New System.Drawing.Size(100, 20)
        Me.datDATUMIG.TabIndex = 18
        Me.datDATUMIG.Value = New Date(2016, 10, 1, 0, 0, 0, 0)
        '
        'lblMUNKALAPID
        '
        Me.lblMUNKALAPID.Location = New System.Drawing.Point(791, 89)
        Me.lblMUNKALAPID.Name = "lblMUNKALAPID"
        Me.lblMUNKALAPID.Size = New System.Drawing.Size(99, 14)
        Me.lblMUNKALAPID.TabIndex = 26
        Me.lblMUNKALAPID.Text = "Munkalap száma"
        Me.lblMUNKALAPID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMUNKALAPID
        '
        Me.txtMUNKALAPID.Location = New System.Drawing.Point(896, 86)
        Me.txtMUNKALAPID.Name = "txtMUNKALAPID"
        Me.txtMUNKALAPID.Size = New System.Drawing.Size(67, 20)
        Me.txtMUNKALAPID.TabIndex = 19
        '
        'lblMUNELV
        '
        Me.lblMUNELV.Location = New System.Drawing.Point(969, 89)
        Me.lblMUNELV.Name = "lblMUNELV"
        Me.lblMUNELV.Size = New System.Drawing.Size(51, 14)
        Me.lblMUNELV.TabIndex = 26
        Me.lblMUNELV.Text = "Végezh."
        Me.lblMUNELV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'datMUNELV
        '
        Me.datMUNELV.Checked = False
        Me.datMUNELV.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datMUNELV.Location = New System.Drawing.Point(1019, 86)
        Me.datMUNELV.Name = "datMUNELV"
        Me.datMUNELV.ShowCheckBox = True
        Me.datMUNELV.Size = New System.Drawing.Size(100, 20)
        Me.datMUNELV.TabIndex = 20
        Me.datMUNELV.Value = New Date(2016, 1, 1, 0, 0, 0, 0)
        '
        'cmbALLAPOT
        '
        Me.cmbALLAPOT.FormattingEnabled = True
        Me.cmbALLAPOT.Location = New System.Drawing.Point(547, 58)
        Me.cmbALLAPOT.Name = "cmbALLAPOT"
        Me.cmbALLAPOT.Size = New System.Drawing.Size(223, 22)
        Me.cmbALLAPOT.TabIndex = 13
        '
        'lblALLAPOT
        '
        Me.lblALLAPOT.Location = New System.Drawing.Point(442, 61)
        Me.lblALLAPOT.Name = "lblALLAPOT"
        Me.lblALLAPOT.Size = New System.Drawing.Size(99, 13)
        Me.lblALLAPOT.TabIndex = 26
        Me.lblALLAPOT.Text = "Állapot jelző"
        Me.lblALLAPOT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbOBJTIP
        '
        Me.cmbOBJTIP.FormattingEnabled = True
        Me.cmbOBJTIP.Location = New System.Drawing.Point(547, 86)
        Me.cmbOBJTIP.Name = "cmbOBJTIP"
        Me.cmbOBJTIP.Size = New System.Drawing.Size(223, 22)
        Me.cmbOBJTIP.TabIndex = 14
        '
        'lblOBJTIP
        '
        Me.lblOBJTIP.Location = New System.Drawing.Point(442, 89)
        Me.lblOBJTIP.Name = "lblOBJTIP"
        Me.lblOBJTIP.Size = New System.Drawing.Size(99, 13)
        Me.lblOBJTIP.TabIndex = 26
        Me.lblOBJTIP.Text = "Berendezés típus"
        Me.lblOBJTIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbOBJID
        '
        Me.cmbOBJID.FormattingEnabled = True
        Me.cmbOBJID.Location = New System.Drawing.Point(547, 114)
        Me.cmbOBJID.Name = "cmbOBJID"
        Me.cmbOBJID.Size = New System.Drawing.Size(223, 22)
        Me.cmbOBJID.TabIndex = 15
        '
        'lblOBJID
        '
        Me.lblOBJID.Location = New System.Drawing.Point(442, 117)
        Me.lblOBJID.Name = "lblOBJID"
        Me.lblOBJID.Size = New System.Drawing.Size(99, 13)
        Me.lblOBJID.TabIndex = 26
        Me.lblOBJID.Text = "Berendezés megn."
        Me.lblOBJID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbDOLGID
        '
        Me.cmbDOLGID.FormattingEnabled = True
        Me.cmbDOLGID.Location = New System.Drawing.Point(547, 142)
        Me.cmbDOLGID.Name = "cmbDOLGID"
        Me.cmbDOLGID.Size = New System.Drawing.Size(223, 22)
        Me.cmbDOLGID.TabIndex = 16
        '
        'lblDOLGID
        '
        Me.lblDOLGID.Location = New System.Drawing.Point(442, 145)
        Me.lblDOLGID.Name = "lblDOLGID"
        Me.lblDOLGID.Size = New System.Drawing.Size(99, 13)
        Me.lblDOLGID.TabIndex = 26
        Me.lblDOLGID.Text = "Dolgozó"
        Me.lblDOLGID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMUNDAT
        '
        Me.lblMUNDAT.Location = New System.Drawing.Point(791, 117)
        Me.lblMUNDAT.Name = "lblMUNDAT"
        Me.lblMUNDAT.Size = New System.Drawing.Size(99, 14)
        Me.lblMUNDAT.TabIndex = 26
        Me.lblMUNDAT.Text = "Visszaírás dátuma"
        Me.lblMUNDAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'datMUNDATTOL
        '
        Me.datMUNDATTOL.Checked = False
        Me.datMUNDATTOL.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datMUNDATTOL.Location = New System.Drawing.Point(896, 114)
        Me.datMUNDATTOL.Name = "datMUNDATTOL"
        Me.datMUNDATTOL.ShowCheckBox = True
        Me.datMUNDATTOL.Size = New System.Drawing.Size(100, 20)
        Me.datMUNDATTOL.TabIndex = 21
        Me.datMUNDATTOL.Value = New Date(2016, 9, 1, 0, 0, 0, 0)
        '
        'datMUNDATIG
        '
        Me.datMUNDATIG.Checked = False
        Me.datMUNDATIG.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datMUNDATIG.Location = New System.Drawing.Point(1019, 114)
        Me.datMUNDATIG.Name = "datMUNDATIG"
        Me.datMUNDATIG.ShowCheckBox = True
        Me.datMUNDATIG.Size = New System.Drawing.Size(100, 20)
        Me.datMUNDATIG.TabIndex = 22
        Me.datMUNDATIG.Value = New Date(2016, 10, 1, 0, 0, 0, 0)
        '
        'lblMUNDAT2
        '
        Me.lblMUNDAT2.AutoSize = True
        Me.lblMUNDAT2.Location = New System.Drawing.Point(1002, 117)
        Me.lblMUNDAT2.Name = "lblMUNDAT2"
        Me.lblMUNDAT2.Size = New System.Drawing.Size(11, 14)
        Me.lblMUNDAT2.TabIndex = 28
        Me.lblMUNDAT2.Text = "-"
        Me.lblMUNDAT2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbTELEPHSZ
        '
        Me.cmbTELEPHSZ.FormattingEnabled = True
        Me.cmbTELEPHSZ.Location = New System.Drawing.Point(896, 142)
        Me.cmbTELEPHSZ.Name = "cmbTELEPHSZ"
        Me.cmbTELEPHSZ.Size = New System.Drawing.Size(223, 22)
        Me.cmbTELEPHSZ.TabIndex = 23
        '
        'lblTELEPHSZ
        '
        Me.lblTELEPHSZ.Location = New System.Drawing.Point(791, 145)
        Me.lblTELEPHSZ.Name = "lblTELEPHSZ"
        Me.lblTELEPHSZ.Size = New System.Drawing.Size(99, 13)
        Me.lblTELEPHSZ.TabIndex = 26
        Me.lblTELEPHSZ.Text = "Telepítési hszám"
        Me.lblTELEPHSZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'cmdUJ
        '
        Me.cmdUJ.Location = New System.Drawing.Point(12, 254)
        Me.cmdUJ.Name = "cmdUJ"
        Me.cmdUJ.Size = New System.Drawing.Size(75, 25)
        Me.cmdUJ.TabIndex = 1
        Me.cmdUJ.Text = "Új munkalap"
        Me.cmdUJ.UseVisualStyleBackColor = True
        '
        'cmdMODOSIT
        '
        Me.cmdMODOSIT.Location = New System.Drawing.Point(12, 285)
        Me.cmdMODOSIT.Name = "cmdMODOSIT"
        Me.cmdMODOSIT.Size = New System.Drawing.Size(75, 25)
        Me.cmdMODOSIT.TabIndex = 2
        Me.cmdMODOSIT.Text = "Módosítás"
        Me.cmdMODOSIT.UseVisualStyleBackColor = True
        '
        'cmdVISSZAIR
        '
        Me.cmdVISSZAIR.Location = New System.Drawing.Point(12, 316)
        Me.cmdVISSZAIR.Name = "cmdVISSZAIR"
        Me.cmdVISSZAIR.Size = New System.Drawing.Size(75, 25)
        Me.cmdVISSZAIR.TabIndex = 3
        Me.cmdVISSZAIR.Text = "Visszaírás"
        Me.cmdVISSZAIR.UseVisualStyleBackColor = True
        '
        'boxPRINT
        '
        Me.boxPRINT.Controls.Add(Me.cmbNYOMTTIP)
        Me.boxPRINT.Controls.Add(Me.cmdLIST)
        Me.boxPRINT.Location = New System.Drawing.Point(12, 347)
        Me.boxPRINT.Name = "boxPRINT"
        Me.boxPRINT.Size = New System.Drawing.Size(75, 81)
        Me.boxPRINT.TabIndex = 30
        Me.boxPRINT.TabStop = False
        Me.boxPRINT.Text = "Nyomtatás"
        '
        'cmbNYOMTTIP
        '
        Me.cmbNYOMTTIP.FormattingEnabled = True
        Me.cmbNYOMTTIP.Location = New System.Drawing.Point(7, 20)
        Me.cmbNYOMTTIP.Name = "cmbNYOMTTIP"
        Me.cmbNYOMTTIP.Size = New System.Drawing.Size(62, 22)
        Me.cmbNYOMTTIP.TabIndex = 4
        '
        'cmdLIST
        '
        Me.cmdLIST.Location = New System.Drawing.Point(7, 48)
        Me.cmdLIST.Name = "cmdLIST"
        Me.cmdLIST.Size = New System.Drawing.Size(62, 25)
        Me.cmdLIST.TabIndex = 5
        Me.cmdLIST.Text = "OK"
        Me.cmdLIST.UseVisualStyleBackColor = True
        '
        'cmdCSOPLIST
        '
        Me.cmdCSOPLIST.Location = New System.Drawing.Point(12, 434)
        Me.cmdCSOPLIST.Name = "cmdCSOPLIST"
        Me.cmdCSOPLIST.Size = New System.Drawing.Size(75, 25)
        Me.cmdCSOPLIST.TabIndex = 6
        Me.cmdCSOPLIST.Text = "Csop. nyomt"
        Me.cmdCSOPLIST.UseVisualStyleBackColor = True
        '
        'cmdMASOL
        '
        Me.cmdMASOL.Location = New System.Drawing.Point(12, 465)
        Me.cmdMASOL.Name = "cmdMASOL"
        Me.cmdMASOL.Size = New System.Drawing.Size(75, 25)
        Me.cmdMASOL.TabIndex = 7
        Me.cmdMASOL.Text = "Másolat"
        Me.cmdMASOL.UseVisualStyleBackColor = True
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
        'Form001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 593)
        Me.Controls.Add(Me.txtTALALAT)
        Me.Controls.Add(Me.txtMUNOSZ)
        Me.Controls.Add(Me.boxPRINT)
        Me.Controls.Add(Me.txtMUNKALAPID)
        Me.Controls.Add(Me.lblMUNDAT2)
        Me.Controls.Add(Me.lblMUNIDO2)
        Me.Controls.Add(Me.datMUNELV)
        Me.Controls.Add(Me.datMUNDATIG)
        Me.Controls.Add(Me.datMUNDATTOL)
        Me.Controls.Add(Me.datDATUMIG)
        Me.Controls.Add(Me.lblMUNDAT)
        Me.Controls.Add(Me.datDATUMTOL)
        Me.Controls.Add(Me.lblMUNIDO)
        Me.Controls.Add(Me.lblMUNELV)
        Me.Controls.Add(Me.lblMUNKALAPID)
        Me.Controls.Add(Me.lblMLAPTIP)
        Me.Controls.Add(Me.lblFSZAM)
        Me.Controls.Add(Me.lblTIPUSH)
        Me.Controls.Add(Me.lblTELEPHSZ)
        Me.Controls.Add(Me.lblTALALAT)
        Me.Controls.Add(Me.lblMUNOSZ)
        Me.Controls.Add(Me.lblDOLGID)
        Me.Controls.Add(Me.lblOBJID)
        Me.Controls.Add(Me.lblOBJTIP)
        Me.Controls.Add(Me.lblALLAPOT)
        Me.Controls.Add(Me.lblSZOLGJELL)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grdMUNKALAP)
        Me.Controls.Add(Me.cmbMLAPTIP)
        Me.Controls.Add(Me.cmbFSZAM)
        Me.Controls.Add(Me.cmbTIPUSH)
        Me.Controls.Add(Me.cmbTELEPHSZ)
        Me.Controls.Add(Me.cmbDOLGID)
        Me.Controls.Add(Me.cmbOBJID)
        Me.Controls.Add(Me.cmbOBJTIP)
        Me.Controls.Add(Me.cmbALLAPOT)
        Me.Controls.Add(Me.cmbSZOLGJELL)
        Me.Controls.Add(Me.cmdVISSZAIR)
        Me.Controls.Add(Me.cmdMODOSIT)
        Me.Controls.Add(Me.cmdUJ)
        Me.Controls.Add(Me.cmdFRISSIT)
        Me.Controls.Add(Me.cmdMASOL)
        Me.Controls.Add(Me.cmdCSOPLIST)
        Me.Controls.Add(Me.cmdEXIT)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Name = "Form001"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form001"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdMUNKALAP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxPRINT.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdEXIT As System.Windows.Forms.Button
    Friend WithEvents cmbSZOLGJELL As System.Windows.Forms.ComboBox
    Friend WithEvents grdMUNKALAP As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSZOLGJELL As System.Windows.Forms.Label
    Friend WithEvents cmbTIPUSH As System.Windows.Forms.ComboBox
    Friend WithEvents lblTIPUSH As System.Windows.Forms.Label
    Friend WithEvents cmbFSZAM As System.Windows.Forms.ComboBox
    Friend WithEvents lblFSZAM As System.Windows.Forms.Label
    Friend WithEvents cmbMLAPTIP As System.Windows.Forms.ComboBox
    Friend WithEvents lblMLAPTIP As System.Windows.Forms.Label
    Friend WithEvents lblMUNIDO As System.Windows.Forms.Label
    Friend WithEvents datDATUMTOL As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblMUNIDO2 As System.Windows.Forms.Label
    Friend WithEvents datDATUMIG As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblMUNKALAPID As System.Windows.Forms.Label
    Friend WithEvents txtMUNKALAPID As System.Windows.Forms.TextBox
    Friend WithEvents lblMUNELV As System.Windows.Forms.Label
    Friend WithEvents datMUNELV As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbALLAPOT As System.Windows.Forms.ComboBox
    Friend WithEvents lblALLAPOT As System.Windows.Forms.Label
    Friend WithEvents cmbOBJTIP As System.Windows.Forms.ComboBox
    Friend WithEvents lblOBJTIP As System.Windows.Forms.Label
    Friend WithEvents cmbOBJID As System.Windows.Forms.ComboBox
    Friend WithEvents lblOBJID As System.Windows.Forms.Label
    Friend WithEvents cmbDOLGID As System.Windows.Forms.ComboBox
    Friend WithEvents lblDOLGID As System.Windows.Forms.Label
    Friend WithEvents lblMUNDAT As System.Windows.Forms.Label
    Friend WithEvents datMUNDATTOL As System.Windows.Forms.DateTimePicker
    Friend WithEvents datMUNDATIG As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblMUNDAT2 As System.Windows.Forms.Label
    Friend WithEvents cmbTELEPHSZ As System.Windows.Forms.ComboBox
    Friend WithEvents lblTELEPHSZ As System.Windows.Forms.Label
    Friend WithEvents cmdFRISSIT As System.Windows.Forms.Button
    Friend WithEvents cmdUJ As System.Windows.Forms.Button
    Friend WithEvents cmdMODOSIT As System.Windows.Forms.Button
    Friend WithEvents cmdVISSZAIR As System.Windows.Forms.Button
    Friend WithEvents boxPRINT As System.Windows.Forms.GroupBox
    Friend WithEvents cmbNYOMTTIP As System.Windows.Forms.ComboBox
    Friend WithEvents cmdLIST As System.Windows.Forms.Button
    Friend WithEvents cmdCSOPLIST As System.Windows.Forms.Button
    Friend WithEvents cmdMASOL As System.Windows.Forms.Button
    Friend WithEvents txtMUNOSZ As System.Windows.Forms.TextBox
    Friend WithEvents lblMUNOSZ As System.Windows.Forms.Label
    Friend WithEvents txtTALALAT As System.Windows.Forms.TextBox
    Friend WithEvents lblTALALAT As System.Windows.Forms.Label
End Class
