<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_FORMULARIO_DE_VOZ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_FORMULARIO_DE_VOZ))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.RCH_TEXTO = New System.Windows.Forms.RichTextBox
        Me.MNU_MENU_CORPO = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RecortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ColarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TMR_ATUALIZADOR = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LBL_STATUS = New System.Windows.Forms.Label
        Me.PRG_PROGRESSO = New System.Windows.Forms.ProgressBar
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ToolStrip1.SuspendLayout()
        Me.MNU_MENU_CORPO.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton5, Me.ToolStripSeparator2, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripButton6, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 379)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(569, 39)
        Me.ToolStrip1.TabIndex = 1
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(72, 36)
        Me.ToolStripButton1.Text = "Iniciar"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Enabled = False
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(76, 36)
        Me.ToolStripButton5.Text = "Pausar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(119, 36)
        Me.ToolStripButton2.Text = "Salvar em áudio"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(97, 36)
        Me.ToolStripButton3.Text = "Novo texto"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(78, 36)
        Me.ToolStripButton6.Text = "Ocultar"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(61, 36)
        Me.ToolStripButton4.Text = "Sair"
        '
        'RCH_TEXTO
        '
        Me.RCH_TEXTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RCH_TEXTO.ContextMenuStrip = Me.MNU_MENU_CORPO
        Me.RCH_TEXTO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RCH_TEXTO.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RCH_TEXTO.Location = New System.Drawing.Point(0, 0)
        Me.RCH_TEXTO.Name = "RCH_TEXTO"
        Me.RCH_TEXTO.Size = New System.Drawing.Size(569, 349)
        Me.RCH_TEXTO.TabIndex = 2
        Me.RCH_TEXTO.Text = ""
        '
        'MNU_MENU_CORPO
        '
        Me.MNU_MENU_CORPO.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecortarToolStripMenuItem, Me.CopiarToolStripMenuItem, Me.ColarToolStripMenuItem, Me.ExcluirToolStripMenuItem})
        Me.MNU_MENU_CORPO.Name = "MNU_MENU_CORPO"
        Me.MNU_MENU_CORPO.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MNU_MENU_CORPO.Size = New System.Drawing.Size(128, 92)
        '
        'RecortarToolStripMenuItem
        '
        Me.RecortarToolStripMenuItem.Name = "RecortarToolStripMenuItem"
        Me.RecortarToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.RecortarToolStripMenuItem.Text = "&Recortar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.CopiarToolStripMenuItem.Text = "&Copiar"
        '
        'ColarToolStripMenuItem
        '
        Me.ColarToolStripMenuItem.Name = "ColarToolStripMenuItem"
        Me.ColarToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ColarToolStripMenuItem.Text = "Co&lar"
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ExcluirToolStripMenuItem.Text = "&Excluir"
        '
        'TMR_ATUALIZADOR
        '
        Me.TMR_ATUALIZADOR.Enabled = True
        Me.TMR_ATUALIZADOR.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LBL_STATUS)
        Me.Panel1.Controls.Add(Me.PRG_PROGRESSO)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 349)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(569, 30)
        Me.Panel1.TabIndex = 3
        '
        'LBL_STATUS
        '
        Me.LBL_STATUS.AutoSize = True
        Me.LBL_STATUS.Location = New System.Drawing.Point(158, 9)
        Me.LBL_STATUS.Name = "LBL_STATUS"
        Me.LBL_STATUS.Size = New System.Drawing.Size(41, 13)
        Me.LBL_STATUS.TabIndex = 1
        Me.LBL_STATUS.Text = "Parado"
        '
        'PRG_PROGRESSO
        '
        Me.PRG_PROGRESSO.Location = New System.Drawing.Point(3, 3)
        Me.PRG_PROGRESSO.Name = "PRG_PROGRESSO"
        Me.PRG_PROGRESSO.Size = New System.Drawing.Size(149, 23)
        Me.PRG_PROGRESSO.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RCH_TEXTO)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(569, 349)
        Me.Panel2.TabIndex = 4
        '
        'FRM_FORMULARIO_DE_VOZ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 418)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_FORMULARIO_DE_VOZ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recurso de vóz"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MNU_MENU_CORPO.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents RCH_TEXTO As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TMR_ATUALIZADOR As System.Windows.Forms.Timer
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PRG_PROGRESSO As System.Windows.Forms.ProgressBar
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LBL_STATUS As System.Windows.Forms.Label
    Friend WithEvents MNU_MENU_CORPO As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RecortarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcluirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
