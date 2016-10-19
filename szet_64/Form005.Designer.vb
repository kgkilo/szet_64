<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form005
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
        Me.grd005 = New System.Windows.Forms.DataGridView()
        Me.SpLekerdDolgozoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SZETAVDataSet = New szet_64.SZETAVDataSet()
        Me.Sp_LekerdDolgozoTableAdapter = New szet_64.SZETAVDataSetTableAdapters.sp_LekerdDolgozoTableAdapter()
        Me.cmdUJ = New System.Windows.Forms.Button()
        Me.cmdMODOSIT = New System.Windows.Forms.Button()
        Me.cmdTOROL = New System.Windows.Forms.Button()
        Me.cmdEXIT = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTALALAT = New System.Windows.Forms.Label()
        Me.txtTALALAT = New System.Windows.Forms.TextBox()
        CType(Me.grd005, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpLekerdDolgozoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd005
        '
        Me.grd005.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd005.Location = New System.Drawing.Point(93, 86)
        Me.grd005.Name = "grd005"
        Me.grd005.Size = New System.Drawing.Size(1026, 495)
        Me.grd005.TabIndex = 0
        '
        'SpLekerdDolgozoBindingSource
        '
        Me.SpLekerdDolgozoBindingSource.DataMember = "sp_LekerdDolgozo"
        Me.SpLekerdDolgozoBindingSource.DataSource = Me.SZETAVDataSet
        '
        'SZETAVDataSet
        '
        Me.SZETAVDataSet.DataSetName = "SZETAVDataSet"
        Me.SZETAVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_LekerdDolgozoTableAdapter
        '
        Me.Sp_LekerdDolgozoTableAdapter.ClearBeforeFill = True
        '
        'cmdUJ
        '
        Me.cmdUJ.Location = New System.Drawing.Point(12, 117)
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
        Me.lblTitle.Size = New System.Drawing.Size(164, 25)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "Dolgozók listája"
        '
        'lblTALALAT
        '
        Me.lblTALALAT.Location = New System.Drawing.Point(12, 39)
        Me.lblTALALAT.Name = "lblTALALAT"
        Me.lblTALALAT.Size = New System.Drawing.Size(75, 13)
        Me.lblTALALAT.TabIndex = 11
        Me.lblTALALAT.Text = "Találatok"
        Me.lblTALALAT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.txtTALALAT.TabIndex = 12
        Me.txtTALALAT.TabStop = False
        Me.txtTALALAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form005
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 586)
        Me.Controls.Add(Me.txtTALALAT)
        Me.Controls.Add(Me.lblTALALAT)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.cmdEXIT)
        Me.Controls.Add(Me.cmdTOROL)
        Me.Controls.Add(Me.cmdMODOSIT)
        Me.Controls.Add(Me.cmdUJ)
        Me.Controls.Add(Me.grd005)
        Me.Name = "Form005"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form005 - Dolgozók"
        CType(Me.grd005, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpLekerdDolgozoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SZETAVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd005 As System.Windows.Forms.DataGridView
    Friend WithEvents SpLekerdDolgozoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SZETAVDataSet As szet_64.SZETAVDataSet
    Friend WithEvents Sp_LekerdDolgozoTableAdapter As szet_64.SZETAVDataSetTableAdapters.sp_LekerdDolgozoTableAdapter
    Friend WithEvents cmdUJ As System.Windows.Forms.Button
    Friend WithEvents cmdMODOSIT As System.Windows.Forms.Button
    Friend WithEvents cmdTOROL As System.Windows.Forms.Button
    Friend WithEvents cmdEXIT As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblTALALAT As System.Windows.Forms.Label
    Friend WithEvents txtTALALAT As System.Windows.Forms.TextBox
End Class
