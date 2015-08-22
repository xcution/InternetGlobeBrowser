<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_FORMULARIO_GERADOR_DE_IMAGENS_DE_ABAS
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_FORMULARIO_GERADOR_DE_IMAGENS_DE_ABAS))
        Me.TMR_ATUALIZADOR = New System.Windows.Forms.Timer(Me.components)
        Me.PN_PRINCIPAL = New System.Windows.Forms.Panel
        Me.MOTOR_GECKOFX = New Gecko.GeckoWebBrowser
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CHK_1 = New System.Windows.Forms.CheckBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PN_PRINCIPAL.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TMR_ATUALIZADOR
        '
        Me.TMR_ATUALIZADOR.Interval = 3000
        '
        'PN_PRINCIPAL
        '
        Me.PN_PRINCIPAL.AutoScroll = True
        Me.PN_PRINCIPAL.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PN_PRINCIPAL.Controls.Add(Me.Panel1)
        Me.PN_PRINCIPAL.Controls.Add(Me.MOTOR_GECKOFX)
        Me.PN_PRINCIPAL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PN_PRINCIPAL.Location = New System.Drawing.Point(0, 0)
        Me.PN_PRINCIPAL.Name = "PN_PRINCIPAL"
        Me.PN_PRINCIPAL.Size = New System.Drawing.Size(792, 573)
        Me.PN_PRINCIPAL.TabIndex = 1
        '
        'MOTOR_GECKOFX
        '
        Me.MOTOR_GECKOFX.DisableWmImeSetContext = True
        Me.MOTOR_GECKOFX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MOTOR_GECKOFX.Location = New System.Drawing.Point(0, 0)
        Me.MOTOR_GECKOFX.Name = "MOTOR_GECKOFX"
        Me.MOTOR_GECKOFX.NoDefaultContextMenu = True
        Me.MOTOR_GECKOFX.Size = New System.Drawing.Size(792, 573)
        Me.MOTOR_GECKOFX.TabIndex = 0
        Me.MOTOR_GECKOFX.UseHttpActivityObserver = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.CHK_1)
        Me.Panel1.Location = New System.Drawing.Point(613, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(147, 43)
        Me.Panel1.TabIndex = 1
        '
        'CHK_1
        '
        Me.CHK_1.AutoSize = True
        Me.CHK_1.Checked = True
        Me.CHK_1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHK_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CHK_1.ForeColor = System.Drawing.Color.White
        Me.CHK_1.Location = New System.Drawing.Point(41, 14)
        Me.CHK_1.Name = "CHK_1"
        Me.CHK_1.Size = New System.Drawing.Size(99, 17)
        Me.CHK_1.TabIndex = 0
        Me.CHK_1.Text = "Atualizar página"
        Me.CHK_1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'FRM_FORMULARIO_GERADOR_DE_IMAGENS_DE_ABAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.PN_PRINCIPAL)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_FORMULARIO_GERADOR_DE_IMAGENS_DE_ABAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Abas abertas"
        Me.PN_PRINCIPAL.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TMR_ATUALIZADOR As System.Windows.Forms.Timer
    Friend WithEvents PN_PRINCIPAL As System.Windows.Forms.Panel
    Friend WithEvents MOTOR_GECKOFX As Gecko.GeckoWebBrowser
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CHK_1 As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
