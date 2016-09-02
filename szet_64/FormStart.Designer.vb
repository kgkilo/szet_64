<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStart
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
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdMunkalap = New System.Windows.Forms.Button()
        Me.cmdJegyz = New System.Windows.Forms.Button()
        Me.cmdRAKTAR = New System.Windows.Forms.Button()
        Me.lblFormel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(433, 367)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(150, 46)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "Kilépés"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdMunkalap
        '
        Me.cmdMunkalap.Location = New System.Drawing.Point(81, 84)
        Me.cmdMunkalap.Name = "cmdMunkalap"
        Me.cmdMunkalap.Size = New System.Drawing.Size(150, 46)
        Me.cmdMunkalap.TabIndex = 0
        Me.cmdMunkalap.Text = "Munkalapok"
        Me.cmdMunkalap.UseVisualStyleBackColor = True
        '
        'cmdJegyz
        '
        Me.cmdJegyz.Location = New System.Drawing.Point(81, 162)
        Me.cmdJegyz.Name = "cmdJegyz"
        Me.cmdJegyz.Size = New System.Drawing.Size(150, 46)
        Me.cmdJegyz.TabIndex = 1
        Me.cmdJegyz.Text = "Jegyzőkönyvek"
        Me.cmdJegyz.UseVisualStyleBackColor = True
        '
        'cmdRAKTAR
        '
        Me.cmdRAKTAR.Location = New System.Drawing.Point(81, 240)
        Me.cmdRAKTAR.Name = "cmdRAKTAR"
        Me.cmdRAKTAR.Size = New System.Drawing.Size(150, 46)
        Me.cmdRAKTAR.TabIndex = 2
        Me.cmdRAKTAR.Text = "Raktár"
        Me.cmdRAKTAR.UseVisualStyleBackColor = True
        Me.cmdRAKTAR.Visible = False
        '
        'lblFormel
        '
        Me.lblFormel.AutoSize = True
        Me.lblFormel.Location = New System.Drawing.Point(81, 416)
        Me.lblFormel.Name = "lblFormel"
        Me.lblFormel.Size = New System.Drawing.Size(127, 13)
        Me.lblFormel.TabIndex = 4
        Me.lblFormel.Text = "(C) 2000-2016 Formel Kft."
        '
        'FormStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.lblFormel)
        Me.Controls.Add(Me.cmdRAKTAR)
        Me.Controls.Add(Me.cmdJegyz)
        Me.Controls.Add(Me.cmdMunkalap)
        Me.Controls.Add(Me.cmdExit)
        Me.Name = "FormStart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Szegedi Hőszolgáltató Kft."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdMunkalap As System.Windows.Forms.Button
    Friend WithEvents cmdJegyz As System.Windows.Forms.Button
    Friend WithEvents cmdRAKTAR As System.Windows.Forms.Button
    Friend WithEvents lblFormel As System.Windows.Forms.Label

End Class
