<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_LIMPADOR_DE_ARQUIVOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_LIMPADOR_DE_ARQUIVOS))
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.chk_arquivos = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_visitados = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.ReflectionImage1 = New DevComponents.DotNetBar.Controls.ReflectionImage
        Me.lbl_mensagem = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.PanelEx2.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.Controls.Add(Me.LabelX2)
        Me.PanelEx2.Controls.Add(Me.chk_arquivos)
        Me.PanelEx2.Controls.Add(Me.chk_visitados)
        Me.PanelEx2.Controls.Add(Me.ReflectionImage1)
        Me.PanelEx2.Controls.Add(Me.lbl_mensagem)
        Me.PanelEx2.Controls.Add(Me.LabelX1)
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(496, 260)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 5
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Yellow
        Me.LabelX2.Location = New System.Drawing.Point(143, 134)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(156, 21)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Limpar o que abaixo?"
        '
        'chk_arquivos
        '
        Me.chk_arquivos.AutoSize = True
        Me.chk_arquivos.BackColor = System.Drawing.Color.Transparent
        Me.chk_arquivos.FocusCuesEnabled = False
        Me.chk_arquivos.Location = New System.Drawing.Point(143, 187)
        Me.chk_arquivos.Name = "chk_arquivos"
        Me.chk_arquivos.Size = New System.Drawing.Size(183, 15)
        Me.chk_arquivos.TabIndex = 1
        Me.chk_arquivos.Text = "Remover arquivos de navegação"
        Me.chk_arquivos.TextColor = System.Drawing.Color.White
        '
        'chk_visitados
        '
        Me.chk_visitados.AutoSize = True
        Me.chk_visitados.BackColor = System.Drawing.Color.Transparent
        Me.chk_visitados.FocusCuesEnabled = False
        Me.chk_visitados.Location = New System.Drawing.Point(143, 166)
        Me.chk_visitados.Name = "chk_visitados"
        Me.chk_visitados.Size = New System.Drawing.Size(127, 15)
        Me.chk_visitados.TabIndex = 0
        Me.chk_visitados.Text = "Limpar sites visitados"
        Me.chk_visitados.TextColor = System.Drawing.Color.White
        '
        'ReflectionImage1
        '
        '
        '
        '
        Me.ReflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ReflectionImage1.Image = CType(resources.GetObject("ReflectionImage1.Image"), System.Drawing.Image)
        Me.ReflectionImage1.Location = New System.Drawing.Point(3, 3)
        Me.ReflectionImage1.Name = "ReflectionImage1"
        Me.ReflectionImage1.Size = New System.Drawing.Size(134, 218)
        Me.ReflectionImage1.TabIndex = 1
        '
        'lbl_mensagem
        '
        Me.lbl_mensagem.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mensagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mensagem.ForeColor = System.Drawing.Color.White
        Me.lbl_mensagem.Location = New System.Drawing.Point(143, 77)
        Me.lbl_mensagem.Name = "lbl_mensagem"
        Me.lbl_mensagem.Size = New System.Drawing.Size(350, 41)
        Me.lbl_mensagem.TabIndex = 2
        Me.lbl_mensagem.Text = "Limpar os items informados abaixo, deixará o navegador muito mais rápido."
        Me.lbl_mensagem.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lbl_mensagem.WordWrap = True
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.White
        Me.LabelX1.Location = New System.Drawing.Point(143, 42)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(265, 29)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Limpeza do Navegador"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.ButtonX2)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx1.Location = New System.Drawing.Point(0, 228)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(496, 32)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 6
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonX2.FocusCuesEnabled = False
        Me.ButtonX2.Location = New System.Drawing.Point(421, 0)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor
        Me.ButtonX2.Size = New System.Drawing.Size(75, 32)
        Me.ButtonX2.TabIndex = 2
        Me.ButtonX2.Text = "&Ok"
        '
        'FRM_LIMPADOR_DE_ARQUIVOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 260)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.PanelEx2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_LIMPADOR_DE_ARQUIVOS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Limpador de arquivos"
        Me.TopMost = True
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ReflectionImage1 As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents lbl_mensagem As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chk_arquivos As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_visitados As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
End Class
