<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form011a
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
        Me.SpQ271BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SZETAVDataSet = New szet_64.SZETAVDataSet()
        Me.SpQ304BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_Q271TableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_Q271TableAdapter()
        Me.Sp_Q304TableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_Q304TableAdapter()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCANCEL = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblMEGJ = New System.Windows.Forms.Label()
        Me.lblHSZ = New System.Windows.Forms.Label()
        Me.lblUTCA = New System.Windows.Forms.Label()
        Me.lblVAROS = New System.Windows.Forms.Label()
        Me.lblKATEG = New System.Windows.Forms.Label()
        Me.lblTELEPHSZ = New System.Windows.Forms.Label()
        Me.lblHITIDO = New System.Windows.Forms.Label()
        Me.lblUZEMIDO = New System.Windows.Forms.Label()
        Me.lblGYARTO = New System.Windows.Forms.Label()
        Me.lblGYSZAM = New System.Windows.Forms.Label()
        Me.lblTIPUS = New System.Windows.Forms.Label()
        Me.lblFSZAM = New System.Windows.Forms.Label()
        Me.lblNEVLTELJ = New System.Windows.Forms.Label()
        Me.lblALAIR = New System.Windows.Forms.Label()
        Me.lblFKOD = New System.Windows.Forms.Label()
        Me.lblUZALL = New System.Windows.Forms.Label()
        Me.lblVESZO = New System.Windows.Forms.Label()
        Me.lblELHELYEZ = New System.Windows.Forms.Label()
        Me.lblGYARTM = New System.Windows.Forms.Label()
        Me.lblMEGNEV = New System.Windows.Forms.Label()
        Me.cmbVAROS = New System.Windows.Forms.ComboBox()
        Me.cmbKATEG = New System.Windows.Forms.ComboBox()
        Me.cmbNEVLTELJME = New System.Windows.Forms.ComboBox()
        Me.cmbFSZAM = New System.Windows.Forms.ComboBox()
        Me.cmbALAIR = New System.Windows.Forms.ComboBox()
        Me.cmbFKOD = New System.Windows.Forms.ComboBox()
        Me.cmbUZALL = New System.Windows.Forms.ComboBox()
        Me.cmbVESZO = New System.Windows.Forms.ComboBox()
        Me.cmbGYARTO = New System.Windows.Forms.ComboBox()
        Me.txtMEGJ = New System.Windows.Forms.TextBox()
        Me.txtNEVLTELJ = New System.Windows.Forms.TextBox()
        Me.txtHSZ = New System.Windows.Forms.TextBox()
        Me.txtUTCA = New System.Windows.Forms.TextBox()
        Me.txtTELEPHSZ = New System.Windows.Forms.TextBox()
        Me.txtHITIDO = New System.Windows.Forms.TextBox()
        Me.txtUZEMIDO = New System.Windows.Forms.TextBox()
        Me.txtGYSZAM = New System.Windows.Forms.TextBox()
        Me.txtTIPUS = New System.Windows.Forms.TextBox()
        Me.txtELHELYEZ = New System.Windows.Forms.TextBox()
        Me.txtGYARTM = New System.Windows.Forms.TextBox()
        Me.txtMEGNEV = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.txtOBJTIP = New System.Windows.Forms.TextBox()
        CType(Me.SpQ271BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpQ304BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.lblTitle.Location = New System.Drawing.Point(64, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(192, 25)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Berendezés adatai"
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(662, 372)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 9
        Me.cmdOK.Text = "Rendben"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCANCEL
        '
        Me.cmdCANCEL.Location = New System.Drawing.Point(13, 372)
        Me.cmdCANCEL.Name = "cmdCANCEL"
        Me.cmdCANCEL.Size = New System.Drawing.Size(75, 23)
        Me.cmdCANCEL.TabIndex = 10
        Me.cmdCANCEL.Text = "Mégsem"
        Me.cmdCANCEL.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(729, 318)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblMEGJ)
        Me.TabPage1.Controls.Add(Me.lblHSZ)
        Me.TabPage1.Controls.Add(Me.lblUTCA)
        Me.TabPage1.Controls.Add(Me.lblVAROS)
        Me.TabPage1.Controls.Add(Me.lblKATEG)
        Me.TabPage1.Controls.Add(Me.lblTELEPHSZ)
        Me.TabPage1.Controls.Add(Me.lblHITIDO)
        Me.TabPage1.Controls.Add(Me.lblUZEMIDO)
        Me.TabPage1.Controls.Add(Me.lblGYARTO)
        Me.TabPage1.Controls.Add(Me.lblGYSZAM)
        Me.TabPage1.Controls.Add(Me.lblTIPUS)
        Me.TabPage1.Controls.Add(Me.lblFSZAM)
        Me.TabPage1.Controls.Add(Me.lblNEVLTELJ)
        Me.TabPage1.Controls.Add(Me.lblALAIR)
        Me.TabPage1.Controls.Add(Me.lblFKOD)
        Me.TabPage1.Controls.Add(Me.lblUZALL)
        Me.TabPage1.Controls.Add(Me.lblVESZO)
        Me.TabPage1.Controls.Add(Me.lblELHELYEZ)
        Me.TabPage1.Controls.Add(Me.lblGYARTM)
        Me.TabPage1.Controls.Add(Me.lblMEGNEV)
        Me.TabPage1.Controls.Add(Me.cmbVAROS)
        Me.TabPage1.Controls.Add(Me.cmbKATEG)
        Me.TabPage1.Controls.Add(Me.cmbNEVLTELJME)
        Me.TabPage1.Controls.Add(Me.cmbFSZAM)
        Me.TabPage1.Controls.Add(Me.cmbALAIR)
        Me.TabPage1.Controls.Add(Me.cmbFKOD)
        Me.TabPage1.Controls.Add(Me.cmbUZALL)
        Me.TabPage1.Controls.Add(Me.cmbVESZO)
        Me.TabPage1.Controls.Add(Me.cmbGYARTO)
        Me.TabPage1.Controls.Add(Me.txtMEGJ)
        Me.TabPage1.Controls.Add(Me.txtNEVLTELJ)
        Me.TabPage1.Controls.Add(Me.txtHSZ)
        Me.TabPage1.Controls.Add(Me.txtUTCA)
        Me.TabPage1.Controls.Add(Me.txtTELEPHSZ)
        Me.TabPage1.Controls.Add(Me.txtHITIDO)
        Me.TabPage1.Controls.Add(Me.txtUZEMIDO)
        Me.TabPage1.Controls.Add(Me.txtGYSZAM)
        Me.TabPage1.Controls.Add(Me.txtTIPUS)
        Me.TabPage1.Controls.Add(Me.txtELHELYEZ)
        Me.TabPage1.Controls.Add(Me.txtGYARTM)
        Me.TabPage1.Controls.Add(Me.txtMEGNEV)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(721, 292)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Általános"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblMEGJ
        '
        Me.lblMEGJ.Location = New System.Drawing.Point(12, 258)
        Me.lblMEGJ.Name = "lblMEGJ"
        Me.lblMEGJ.Size = New System.Drawing.Size(105, 13)
        Me.lblMEGJ.TabIndex = 2
        Me.lblMEGJ.Text = "Megjegyzés"
        Me.lblMEGJ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHSZ
        '
        Me.lblHSZ.Location = New System.Drawing.Point(437, 221)
        Me.lblHSZ.Name = "lblHSZ"
        Me.lblHSZ.Size = New System.Drawing.Size(46, 13)
        Me.lblHSZ.TabIndex = 2
        Me.lblHSZ.Text = "Hsz."
        Me.lblHSZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUTCA
        '
        Me.lblUTCA.Location = New System.Drawing.Point(267, 221)
        Me.lblUTCA.Name = "lblUTCA"
        Me.lblUTCA.Size = New System.Drawing.Size(30, 13)
        Me.lblUTCA.TabIndex = 2
        Me.lblUTCA.Text = "Utca"
        Me.lblUTCA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVAROS
        '
        Me.lblVAROS.Location = New System.Drawing.Point(12, 221)
        Me.lblVAROS.Name = "lblVAROS"
        Me.lblVAROS.Size = New System.Drawing.Size(105, 13)
        Me.lblVAROS.TabIndex = 2
        Me.lblVAROS.Text = "Város"
        Me.lblVAROS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblKATEG
        '
        Me.lblKATEG.Location = New System.Drawing.Point(12, 194)
        Me.lblKATEG.Name = "lblKATEG"
        Me.lblKATEG.Size = New System.Drawing.Size(105, 13)
        Me.lblKATEG.TabIndex = 2
        Me.lblKATEG.Text = "Kategória"
        Me.lblKATEG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTELEPHSZ
        '
        Me.lblTELEPHSZ.Location = New System.Drawing.Point(12, 168)
        Me.lblTELEPHSZ.Name = "lblTELEPHSZ"
        Me.lblTELEPHSZ.Size = New System.Drawing.Size(105, 13)
        Me.lblTELEPHSZ.TabIndex = 2
        Me.lblTELEPHSZ.Text = "Telepítési helyszám"
        Me.lblTELEPHSZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHITIDO
        '
        Me.lblHITIDO.Location = New System.Drawing.Point(12, 142)
        Me.lblHITIDO.Name = "lblHITIDO"
        Me.lblHITIDO.Size = New System.Drawing.Size(105, 13)
        Me.lblHITIDO.TabIndex = 2
        Me.lblHITIDO.Text = "Hitelesítés kelte"
        Me.lblHITIDO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUZEMIDO
        '
        Me.lblUZEMIDO.Location = New System.Drawing.Point(12, 116)
        Me.lblUZEMIDO.Name = "lblUZEMIDO"
        Me.lblUZEMIDO.Size = New System.Drawing.Size(105, 13)
        Me.lblUZEMIDO.TabIndex = 2
        Me.lblUZEMIDO.Text = "Üzembehelyezés"
        Me.lblUZEMIDO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGYARTO
        '
        Me.lblGYARTO.Location = New System.Drawing.Point(12, 89)
        Me.lblGYARTO.Name = "lblGYARTO"
        Me.lblGYARTO.Size = New System.Drawing.Size(105, 13)
        Me.lblGYARTO.TabIndex = 2
        Me.lblGYARTO.Text = "Gyártó cég"
        Me.lblGYARTO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGYSZAM
        '
        Me.lblGYSZAM.Location = New System.Drawing.Point(12, 62)
        Me.lblGYSZAM.Name = "lblGYSZAM"
        Me.lblGYSZAM.Size = New System.Drawing.Size(105, 13)
        Me.lblGYSZAM.TabIndex = 2
        Me.lblGYSZAM.Text = "Gyári szám"
        Me.lblGYSZAM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTIPUS
        '
        Me.lblTIPUS.Location = New System.Drawing.Point(12, 36)
        Me.lblTIPUS.Name = "lblTIPUS"
        Me.lblTIPUS.Size = New System.Drawing.Size(105, 13)
        Me.lblTIPUS.TabIndex = 2
        Me.lblTIPUS.Text = "Gyári típus"
        Me.lblTIPUS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFSZAM
        '
        Me.lblFSZAM.Location = New System.Drawing.Point(306, 194)
        Me.lblFSZAM.Name = "lblFSZAM"
        Me.lblFSZAM.Size = New System.Drawing.Size(125, 13)
        Me.lblFSZAM.TabIndex = 2
        Me.lblFSZAM.Text = "Főkönyvi szám"
        Me.lblFSZAM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNEVLTELJ
        '
        Me.lblNEVLTELJ.Location = New System.Drawing.Point(306, 168)
        Me.lblNEVLTELJ.Name = "lblNEVLTELJ"
        Me.lblNEVLTELJ.Size = New System.Drawing.Size(125, 13)
        Me.lblNEVLTELJ.TabIndex = 2
        Me.lblNEVLTELJ.Text = "Névleges teljesítmény"
        Me.lblNEVLTELJ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblALAIR
        '
        Me.lblALAIR.Location = New System.Drawing.Point(306, 142)
        Me.lblALAIR.Name = "lblALAIR"
        Me.lblALAIR.Size = New System.Drawing.Size(125, 13)
        Me.lblALAIR.TabIndex = 2
        Me.lblALAIR.Text = "Aláírásra jogosult"
        Me.lblALAIR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFKOD
        '
        Me.lblFKOD.Location = New System.Drawing.Point(306, 116)
        Me.lblFKOD.Name = "lblFKOD"
        Me.lblFKOD.Size = New System.Drawing.Size(125, 13)
        Me.lblFKOD.TabIndex = 2
        Me.lblFKOD.Text = "Kulcs található"
        Me.lblFKOD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUZALL
        '
        Me.lblUZALL.Location = New System.Drawing.Point(306, 89)
        Me.lblUZALL.Name = "lblUZALL"
        Me.lblUZALL.Size = New System.Drawing.Size(125, 13)
        Me.lblUZALL.TabIndex = 2
        Me.lblUZALL.Text = "Üzemállapot"
        Me.lblUZALL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVESZO
        '
        Me.lblVESZO.Location = New System.Drawing.Point(306, 62)
        Me.lblVESZO.Name = "lblVESZO"
        Me.lblVESZO.Size = New System.Drawing.Size(125, 13)
        Me.lblVESZO.TabIndex = 2
        Me.lblVESZO.Text = "Veszélyességi osztály"
        Me.lblVESZO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblELHELYEZ
        '
        Me.lblELHELYEZ.Location = New System.Drawing.Point(306, 36)
        Me.lblELHELYEZ.Name = "lblELHELYEZ"
        Me.lblELHELYEZ.Size = New System.Drawing.Size(125, 13)
        Me.lblELHELYEZ.TabIndex = 2
        Me.lblELHELYEZ.Text = "Berendezés elhelyezése"
        Me.lblELHELYEZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGYARTM
        '
        Me.lblGYARTM.Location = New System.Drawing.Point(306, 10)
        Me.lblGYARTM.Name = "lblGYARTM"
        Me.lblGYARTM.Size = New System.Drawing.Size(125, 13)
        Me.lblGYARTM.TabIndex = 2
        Me.lblGYARTM.Text = "Gyártmány"
        Me.lblGYARTM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMEGNEV
        '
        Me.lblMEGNEV.Location = New System.Drawing.Point(12, 10)
        Me.lblMEGNEV.Name = "lblMEGNEV"
        Me.lblMEGNEV.Size = New System.Drawing.Size(105, 13)
        Me.lblMEGNEV.TabIndex = 2
        Me.lblMEGNEV.Text = "Berendezés név"
        Me.lblMEGNEV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbVAROS
        '
        Me.cmbVAROS.FormattingEnabled = True
        Me.cmbVAROS.Location = New System.Drawing.Point(123, 218)
        Me.cmbVAROS.Name = "cmbVAROS"
        Me.cmbVAROS.Size = New System.Drawing.Size(138, 21)
        Me.cmbVAROS.TabIndex = 1
        Me.cmbVAROS.Tag = "289"
        '
        'cmbKATEG
        '
        Me.cmbKATEG.FormattingEnabled = True
        Me.cmbKATEG.Location = New System.Drawing.Point(123, 191)
        Me.cmbKATEG.Name = "cmbKATEG"
        Me.cmbKATEG.Size = New System.Drawing.Size(138, 21)
        Me.cmbKATEG.TabIndex = 1
        Me.cmbKATEG.Tag = "317"
        '
        'cmbNEVLTELJME
        '
        Me.cmbNEVLTELJME.FormattingEnabled = True
        Me.cmbNEVLTELJME.Location = New System.Drawing.Point(527, 165)
        Me.cmbNEVLTELJME.Name = "cmbNEVLTELJME"
        Me.cmbNEVLTELJME.Size = New System.Drawing.Size(48, 21)
        Me.cmbNEVLTELJME.TabIndex = 1
        Me.cmbNEVLTELJME.Tag = "279"
        '
        'cmbFSZAM
        '
        Me.cmbFSZAM.FormattingEnabled = True
        Me.cmbFSZAM.Location = New System.Drawing.Point(437, 191)
        Me.cmbFSZAM.Name = "cmbFSZAM"
        Me.cmbFSZAM.Size = New System.Drawing.Size(138, 21)
        Me.cmbFSZAM.TabIndex = 1
        Me.cmbFSZAM.Tag = "310"
        '
        'cmbALAIR
        '
        Me.cmbALAIR.FormattingEnabled = True
        Me.cmbALAIR.Location = New System.Drawing.Point(437, 139)
        Me.cmbALAIR.Name = "cmbALAIR"
        Me.cmbALAIR.Size = New System.Drawing.Size(138, 21)
        Me.cmbALAIR.TabIndex = 1
        Me.cmbALAIR.Tag = "315"
        '
        'cmbFKOD
        '
        Me.cmbFKOD.FormattingEnabled = True
        Me.cmbFKOD.Location = New System.Drawing.Point(437, 113)
        Me.cmbFKOD.Name = "cmbFKOD"
        Me.cmbFKOD.Size = New System.Drawing.Size(138, 21)
        Me.cmbFKOD.TabIndex = 1
        Me.cmbFKOD.Tag = "314"
        '
        'cmbUZALL
        '
        Me.cmbUZALL.FormattingEnabled = True
        Me.cmbUZALL.Location = New System.Drawing.Point(437, 86)
        Me.cmbUZALL.Name = "cmbUZALL"
        Me.cmbUZALL.Size = New System.Drawing.Size(138, 21)
        Me.cmbUZALL.TabIndex = 1
        Me.cmbUZALL.Tag = "297"
        '
        'cmbVESZO
        '
        Me.cmbVESZO.FormattingEnabled = True
        Me.cmbVESZO.Location = New System.Drawing.Point(437, 59)
        Me.cmbVESZO.Name = "cmbVESZO"
        Me.cmbVESZO.Size = New System.Drawing.Size(138, 21)
        Me.cmbVESZO.TabIndex = 1
        Me.cmbVESZO.Tag = "313"
        '
        'cmbGYARTO
        '
        Me.cmbGYARTO.FormattingEnabled = True
        Me.cmbGYARTO.Location = New System.Drawing.Point(123, 86)
        Me.cmbGYARTO.Name = "cmbGYARTO"
        Me.cmbGYARTO.Size = New System.Drawing.Size(138, 21)
        Me.cmbGYARTO.TabIndex = 1
        Me.cmbGYARTO.Tag = "312"
        '
        'txtMEGJ
        '
        Me.txtMEGJ.Location = New System.Drawing.Point(123, 245)
        Me.txtMEGJ.Multiline = True
        Me.txtMEGJ.Name = "txtMEGJ"
        Me.txtMEGJ.Size = New System.Drawing.Size(452, 40)
        Me.txtMEGJ.TabIndex = 0
        '
        'txtNEVLTELJ
        '
        Me.txtNEVLTELJ.Location = New System.Drawing.Point(437, 165)
        Me.txtNEVLTELJ.Name = "txtNEVLTELJ"
        Me.txtNEVLTELJ.Size = New System.Drawing.Size(84, 20)
        Me.txtNEVLTELJ.TabIndex = 0
        '
        'txtHSZ
        '
        Me.txtHSZ.Location = New System.Drawing.Point(489, 218)
        Me.txtHSZ.Name = "txtHSZ"
        Me.txtHSZ.Size = New System.Drawing.Size(86, 20)
        Me.txtHSZ.TabIndex = 0
        '
        'txtUTCA
        '
        Me.txtUTCA.Location = New System.Drawing.Point(297, 218)
        Me.txtUTCA.Name = "txtUTCA"
        Me.txtUTCA.Size = New System.Drawing.Size(134, 20)
        Me.txtUTCA.TabIndex = 0
        '
        'txtTELEPHSZ
        '
        Me.txtTELEPHSZ.Location = New System.Drawing.Point(123, 165)
        Me.txtTELEPHSZ.Name = "txtTELEPHSZ"
        Me.txtTELEPHSZ.Size = New System.Drawing.Size(138, 20)
        Me.txtTELEPHSZ.TabIndex = 0
        '
        'txtHITIDO
        '
        Me.txtHITIDO.Location = New System.Drawing.Point(123, 139)
        Me.txtHITIDO.Name = "txtHITIDO"
        Me.txtHITIDO.Size = New System.Drawing.Size(138, 20)
        Me.txtHITIDO.TabIndex = 0
        '
        'txtUZEMIDO
        '
        Me.txtUZEMIDO.Location = New System.Drawing.Point(123, 113)
        Me.txtUZEMIDO.Name = "txtUZEMIDO"
        Me.txtUZEMIDO.Size = New System.Drawing.Size(138, 20)
        Me.txtUZEMIDO.TabIndex = 0
        '
        'txtGYSZAM
        '
        Me.txtGYSZAM.Location = New System.Drawing.Point(123, 59)
        Me.txtGYSZAM.Name = "txtGYSZAM"
        Me.txtGYSZAM.Size = New System.Drawing.Size(138, 20)
        Me.txtGYSZAM.TabIndex = 0
        '
        'txtTIPUS
        '
        Me.txtTIPUS.Location = New System.Drawing.Point(123, 33)
        Me.txtTIPUS.Name = "txtTIPUS"
        Me.txtTIPUS.Size = New System.Drawing.Size(138, 20)
        Me.txtTIPUS.TabIndex = 0
        '
        'txtELHELYEZ
        '
        Me.txtELHELYEZ.Location = New System.Drawing.Point(437, 33)
        Me.txtELHELYEZ.Name = "txtELHELYEZ"
        Me.txtELHELYEZ.Size = New System.Drawing.Size(138, 20)
        Me.txtELHELYEZ.TabIndex = 0
        '
        'txtGYARTM
        '
        Me.txtGYARTM.Location = New System.Drawing.Point(437, 7)
        Me.txtGYARTM.Name = "txtGYARTM"
        Me.txtGYARTM.Size = New System.Drawing.Size(138, 20)
        Me.txtGYARTM.TabIndex = 0
        '
        'txtMEGNEV
        '
        Me.txtMEGNEV.Location = New System.Drawing.Point(123, 7)
        Me.txtMEGNEV.Name = "txtMEGNEV"
        Me.txtMEGNEV.Size = New System.Drawing.Size(138, 20)
        Me.txtMEGNEV.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(721, 292)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Gépészeti"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(721, 292)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Villamos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(721, 292)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Üzemeltetési"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'txtOBJTIP
        '
        Me.txtOBJTIP.Location = New System.Drawing.Point(337, 375)
        Me.txtOBJTIP.Name = "txtOBJTIP"
        Me.txtOBJTIP.Size = New System.Drawing.Size(100, 20)
        Me.txtOBJTIP.TabIndex = 12
        Me.txtOBJTIP.Visible = False
        '
        'Form011a
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 407)
        Me.Controls.Add(Me.txtOBJTIP)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmdCANCEL)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form011a"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "-1"
        Me.Text = "Berendezés adatai - Form011a"
        CType(Me.SpQ271BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpQ304BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SZETAVDataSet As szet_64.SZETAVDataSet
    Friend WithEvents SpQ271BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_Q271TableAdapter As szet_64.SZETAVDataSetTableAdapters.sp_Q271TableAdapter
    Friend WithEvents SpQ304BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_Q304TableAdapter As szet_64.SZETAVDataSetTableAdapters.sp_Q304TableAdapter
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdCANCEL As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents cmbVAROS As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKATEG As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGYARTO As System.Windows.Forms.ComboBox
    Friend WithEvents txtMEGJ As System.Windows.Forms.TextBox
    Friend WithEvents txtTELEPHSZ As System.Windows.Forms.TextBox
    Friend WithEvents txtHITIDO As System.Windows.Forms.TextBox
    Friend WithEvents txtUZEMIDO As System.Windows.Forms.TextBox
    Friend WithEvents txtGYSZAM As System.Windows.Forms.TextBox
    Friend WithEvents txtTIPUS As System.Windows.Forms.TextBox
    Friend WithEvents txtMEGNEV As System.Windows.Forms.TextBox
    Friend WithEvents lblGYSZAM As System.Windows.Forms.Label
    Friend WithEvents lblTIPUS As System.Windows.Forms.Label
    Friend WithEvents lblMEGNEV As System.Windows.Forms.Label
    Friend WithEvents lblGYARTO As System.Windows.Forms.Label
    Friend WithEvents lblMEGJ As System.Windows.Forms.Label
    Friend WithEvents lblVAROS As System.Windows.Forms.Label
    Friend WithEvents lblKATEG As System.Windows.Forms.Label
    Friend WithEvents lblTELEPHSZ As System.Windows.Forms.Label
    Friend WithEvents lblHITIDO As System.Windows.Forms.Label
    Friend WithEvents lblUZEMIDO As System.Windows.Forms.Label
    Friend WithEvents lblHSZ As System.Windows.Forms.Label
    Friend WithEvents lblUTCA As System.Windows.Forms.Label
    Friend WithEvents lblFSZAM As System.Windows.Forms.Label
    Friend WithEvents lblNEVLTELJ As System.Windows.Forms.Label
    Friend WithEvents lblALAIR As System.Windows.Forms.Label
    Friend WithEvents lblFKOD As System.Windows.Forms.Label
    Friend WithEvents lblUZALL As System.Windows.Forms.Label
    Friend WithEvents lblVESZO As System.Windows.Forms.Label
    Friend WithEvents lblELHELYEZ As System.Windows.Forms.Label
    Friend WithEvents lblGYARTM As System.Windows.Forms.Label
    Friend WithEvents cmbNEVLTELJME As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFSZAM As System.Windows.Forms.ComboBox
    Friend WithEvents cmbALAIR As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFKOD As System.Windows.Forms.ComboBox
    Friend WithEvents cmbUZALL As System.Windows.Forms.ComboBox
    Friend WithEvents cmbVESZO As System.Windows.Forms.ComboBox
    Friend WithEvents txtNEVLTELJ As System.Windows.Forms.TextBox
    Friend WithEvents txtHSZ As System.Windows.Forms.TextBox
    Friend WithEvents txtUTCA As System.Windows.Forms.TextBox
    Friend WithEvents txtELHELYEZ As System.Windows.Forms.TextBox
    Friend WithEvents txtGYARTM As System.Windows.Forms.TextBox
    Friend WithEvents txtOBJTIP As System.Windows.Forms.TextBox
End Class
