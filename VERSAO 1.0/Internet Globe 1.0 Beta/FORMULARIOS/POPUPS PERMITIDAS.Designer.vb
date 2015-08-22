<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_POPUPS_PERMITIDAS
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_POPUPS_PERMITIDAS))
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.txt_site_permitido = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX5 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX
        Me.lst_listagem = New System.Windows.Forms.ListBox
        Me.mnu_contexto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoverTudoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txt_busca = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx
        Me.ButtonX6 = New DevComponents.DotNetBar.ButtonX
        Me.mnu_contexto.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.AutoSize = True
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.FocusCuesEnabled = False
        Me.ButtonX3.Image = CType(resources.GetObject("ButtonX3.Image"), System.Drawing.Image)
        Me.ButtonX3.Location = New System.Drawing.Point(16, 432)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 0, 10, 0)
        Me.ButtonX3.Size = New System.Drawing.Size(192, 38)
        Me.ButtonX3.TabIndex = 1
        Me.ButtonX3.Text = "A&dicionar site informado acima"
        Me.ButtonX3.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.Location = New System.Drawing.Point(73, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(235, 15)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Informe o nome do site a ser encontrado abaixo"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.FocusCuesEnabled = False
        Me.ButtonX2.Image = CType(resources.GetObject("ButtonX2.Image"), System.Drawing.Image)
        Me.ButtonX2.Location = New System.Drawing.Point(207, 432)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 10, 0, 10)
        Me.ButtonX2.Size = New System.Drawing.Size(195, 38)
        Me.ButtonX2.TabIndex = 1
        Me.ButtonX2.Text = "&Adicionar site em visualização"
        Me.ButtonX2.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'txt_site_permitido
        '
        '
        '
        '
        Me.txt_site_permitido.Border.Class = "TextBoxBorder"
        Me.txt_site_permitido.Location = New System.Drawing.Point(118, 406)
        Me.txt_site_permitido.Name = "txt_site_permitido"
        Me.txt_site_permitido.Size = New System.Drawing.Size(284, 20)
        Me.txt_site_permitido.TabIndex = 0
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.Location = New System.Drawing.Point(12, 407)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(100, 15)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Novo site permitido:"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.FocusCuesEnabled = False
        Me.ButtonX1.Location = New System.Drawing.Point(73, 59)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.ButtonX1.Size = New System.Drawing.Size(117, 23)
        Me.ButtonX1.TabIndex = 2
        Me.ButtonX1.Text = "&Buscar"
        '
        'ButtonX5
        '
        Me.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX5.FocusCuesEnabled = False
        Me.ButtonX5.Location = New System.Drawing.Point(144, 358)
        Me.ButtonX5.Name = "ButtonX5"
        Me.ButtonX5.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 10, 0, 10)
        Me.ButtonX5.Size = New System.Drawing.Size(133, 23)
        Me.ButtonX5.TabIndex = 4
        Me.ButtonX5.Text = "R&emover tudo"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.FocusCuesEnabled = False
        Me.ButtonX4.Location = New System.Drawing.Point(12, 358)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 0, 10, 0)
        Me.ButtonX4.Size = New System.Drawing.Size(133, 23)
        Me.ButtonX4.TabIndex = 4
        Me.ButtonX4.Text = "&Remover site selecionado"
        '
        'lst_listagem
        '
        Me.lst_listagem.ContextMenuStrip = Me.mnu_contexto
        Me.lst_listagem.Cursor = System.Windows.Forms.Cursors.Cross
        Me.lst_listagem.ForeColor = System.Drawing.Color.Blue
        Me.lst_listagem.FormattingEnabled = True
        Me.lst_listagem.Location = New System.Drawing.Point(12, 88)
        Me.lst_listagem.Name = "lst_listagem"
        Me.lst_listagem.Size = New System.Drawing.Size(390, 264)
        Me.lst_listagem.TabIndex = 3
        '
        'mnu_contexto
        '
        Me.mnu_contexto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoverToolStripMenuItem, Me.RemoverTudoToolStripMenuItem})
        Me.mnu_contexto.Name = "mnu_contexto"
        Me.mnu_contexto.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mnu_contexto.Size = New System.Drawing.Size(211, 48)
        '
        'RemoverToolStripMenuItem
        '
        Me.RemoverToolStripMenuItem.Name = "RemoverToolStripMenuItem"
        Me.RemoverToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.RemoverToolStripMenuItem.Text = "&Remover item selecionado"
        '
        'RemoverTudoToolStripMenuItem
        '
        Me.RemoverTudoToolStripMenuItem.Name = "RemoverTudoToolStripMenuItem"
        Me.RemoverTudoToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.RemoverTudoToolStripMenuItem.Text = "R&emover tudo"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.PictureBox1)
        Me.PanelEx1.Controls.Add(Me.txt_busca)
        Me.PanelEx1.Controls.Add(Me.ButtonX3)
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.Controls.Add(Me.ButtonX2)
        Me.PanelEx1.Controls.Add(Me.ButtonX5)
        Me.PanelEx1.Controls.Add(Me.txt_site_permitido)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.ButtonX4)
        Me.PanelEx1.Controls.Add(Me.lst_listagem)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(414, 529)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'txt_busca
        '
        '
        '
        '
        Me.txt_busca.Border.Class = "TextBoxBorder"
        Me.txt_busca.Location = New System.Drawing.Point(73, 33)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(296, 20)
        Me.txt_busca.TabIndex = 10
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx2.Controls.Add(Me.ButtonX6)
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx2.Location = New System.Drawing.Point(0, 489)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(414, 40)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 9
        '
        'ButtonX6
        '
        Me.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX6.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonX6.FocusCuesEnabled = False
        Me.ButtonX6.Location = New System.Drawing.Point(315, 0)
        Me.ButtonX6.Name = "ButtonX6"
        Me.ButtonX6.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor
        Me.ButtonX6.Size = New System.Drawing.Size(99, 40)
        Me.ButtonX6.TabIndex = 0
        Me.ButtonX6.Text = "&Ok"
        '
        'FRM_POPUPS_PERMITIDAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 529)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_POPUPS_PERMITIDAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pop-ups permitidas"
        Me.TopMost = True
        Me.mnu_contexto.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_site_permitido As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX5 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lst_listagem As System.Windows.Forms.ListBox
    Friend WithEvents mnu_contexto As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoverTudoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX6 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_busca As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
