<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_DOWNLOADER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_DOWNLOADER))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx
        Me.lbl_porcentagem = New DevComponents.DotNetBar.LabelX
        Me.ProgressBar1 = New DevComponents.DotNetBar.Controls.ProgressBarX
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.chk_avisar = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.ReflectionImage2 = New DevComponents.DotNetBar.Controls.ReflectionImage
        Me.lbl_velocidade = New DevComponents.DotNetBar.LabelX
        Me.lbl_baixado = New DevComponents.DotNetBar.LabelX
        Me.lbl_tamanho_arquivo = New DevComponents.DotNetBar.LabelX
        Me.lbl_destino = New DevComponents.DotNetBar.LabelX
        Me.lbl_origem = New DevComponents.DotNetBar.LabelX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.ReflectionImage1 = New DevComponents.DotNetBar.Controls.ReflectionImage
        Me.bck_informacoes = New System.ComponentModel.BackgroundWorker
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.tmr_atualizar = New System.Windows.Forms.Timer(Me.components)
        Me.bck_download = New System.ComponentModel.BackgroundWorker
        Me.atualizador_de_download = New System.Windows.Forms.Timer(Me.components)
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Controls.Add(Me.chk_avisar)
        Me.PanelEx1.Controls.Add(Me.ReflectionImage2)
        Me.PanelEx1.Controls.Add(Me.lbl_velocidade)
        Me.PanelEx1.Controls.Add(Me.lbl_baixado)
        Me.PanelEx1.Controls.Add(Me.lbl_tamanho_arquivo)
        Me.PanelEx1.Controls.Add(Me.lbl_destino)
        Me.PanelEx1.Controls.Add(Me.lbl_origem)
        Me.PanelEx1.Controls.Add(Me.LabelX6)
        Me.PanelEx1.Controls.Add(Me.LabelX5)
        Me.PanelEx1.Controls.Add(Me.LabelX4)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.ReflectionImage1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(523, 222)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 31
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx2.Controls.Add(Me.lbl_porcentagem)
        Me.PanelEx2.Controls.Add(Me.ProgressBar1)
        Me.PanelEx2.Controls.Add(Me.ButtonX1)
        Me.PanelEx2.Controls.Add(Me.ButtonX3)
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx2.Location = New System.Drawing.Point(0, 197)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(523, 25)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 33
        '
        'lbl_porcentagem
        '
        Me.lbl_porcentagem.AutoSize = True
        Me.lbl_porcentagem.ForeColor = System.Drawing.Color.Black
        Me.lbl_porcentagem.Location = New System.Drawing.Point(230, 5)
        Me.lbl_porcentagem.Name = "lbl_porcentagem"
        Me.lbl_porcentagem.Size = New System.Drawing.Size(18, 15)
        Me.lbl_porcentagem.TabIndex = 34
        Me.lbl_porcentagem.Text = "0%"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.FocusCuesEnabled = False
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(220, 22)
        Me.ProgressBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.ProgressBar1.TabIndex = 33
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonX1.FocusCuesEnabled = False
        Me.ButtonX1.Location = New System.Drawing.Point(277, 0)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor
        Me.ButtonX1.Size = New System.Drawing.Size(75, 25)
        Me.ButtonX1.TabIndex = 32
        Me.ButtonX1.Text = "&Cancelar"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonX3.FocusCuesEnabled = False
        Me.ButtonX3.Location = New System.Drawing.Point(352, 0)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor
        Me.ButtonX3.Size = New System.Drawing.Size(171, 25)
        Me.ButtonX3.TabIndex = 32
        Me.ButtonX3.Text = "&Copiar o endereço do download"
        '
        'chk_avisar
        '
        Me.chk_avisar.AutoSize = True
        Me.chk_avisar.FocusCuesEnabled = False
        Me.chk_avisar.Location = New System.Drawing.Point(98, 169)
        Me.chk_avisar.Name = "chk_avisar"
        Me.chk_avisar.Size = New System.Drawing.Size(158, 15)
        Me.chk_avisar.TabIndex = 31
        Me.chk_avisar.Text = "Avisar ao concluir download"
        Me.chk_avisar.TextColor = System.Drawing.Color.White
        '
        'ReflectionImage2
        '
        '
        '
        '
        Me.ReflectionImage2.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ReflectionImage2.Image = CType(resources.GetObject("ReflectionImage2.Image"), System.Drawing.Image)
        Me.ReflectionImage2.Location = New System.Drawing.Point(35, 128)
        Me.ReflectionImage2.Name = "ReflectionImage2"
        Me.ReflectionImage2.Size = New System.Drawing.Size(57, 56)
        Me.ReflectionImage2.TabIndex = 31
        '
        'lbl_velocidade
        '
        Me.lbl_velocidade.AutoSize = True
        Me.lbl_velocidade.ForeColor = System.Drawing.Color.Cyan
        Me.lbl_velocidade.Location = New System.Drawing.Point(164, 149)
        Me.lbl_velocidade.Name = "lbl_velocidade"
        Me.lbl_velocidade.Size = New System.Drawing.Size(75, 15)
        Me.lbl_velocidade.TabIndex = 3
        Me.lbl_velocidade.Text = "Não informado"
        '
        'lbl_baixado
        '
        Me.lbl_baixado.AutoSize = True
        Me.lbl_baixado.ForeColor = System.Drawing.Color.Cyan
        Me.lbl_baixado.Location = New System.Drawing.Point(149, 111)
        Me.lbl_baixado.Name = "lbl_baixado"
        Me.lbl_baixado.Size = New System.Drawing.Size(75, 15)
        Me.lbl_baixado.TabIndex = 3
        Me.lbl_baixado.Text = "Não informado"
        '
        'lbl_tamanho_arquivo
        '
        Me.lbl_tamanho_arquivo.ForeColor = System.Drawing.Color.Cyan
        Me.lbl_tamanho_arquivo.Location = New System.Drawing.Point(210, 87)
        Me.lbl_tamanho_arquivo.Name = "lbl_tamanho_arquivo"
        Me.lbl_tamanho_arquivo.Size = New System.Drawing.Size(301, 23)
        Me.lbl_tamanho_arquivo.TabIndex = 3
        Me.lbl_tamanho_arquivo.Text = "Não informado"
        '
        'lbl_destino
        '
        Me.lbl_destino.ForeColor = System.Drawing.Color.Cyan
        Me.lbl_destino.Location = New System.Drawing.Point(201, 66)
        Me.lbl_destino.Name = "lbl_destino"
        Me.lbl_destino.Size = New System.Drawing.Size(310, 23)
        Me.lbl_destino.TabIndex = 3
        Me.lbl_destino.Text = "Não informado"
        '
        'lbl_origem
        '
        Me.lbl_origem.ForeColor = System.Drawing.Color.Cyan
        Me.lbl_origem.Location = New System.Drawing.Point(200, 45)
        Me.lbl_origem.Name = "lbl_origem"
        Me.lbl_origem.Size = New System.Drawing.Size(311, 23)
        Me.lbl_origem.TabIndex = 3
        Me.lbl_origem.Text = "Não informado"
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        Me.LabelX6.ForeColor = System.Drawing.Color.Lime
        Me.LabelX6.Location = New System.Drawing.Point(98, 149)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(60, 15)
        Me.LabelX6.TabIndex = 2
        Me.LabelX6.Text = "Velocidade:"
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.ForeColor = System.Drawing.Color.Lime
        Me.LabelX5.Location = New System.Drawing.Point(98, 110)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(45, 15)
        Me.LabelX5.TabIndex = 2
        Me.LabelX5.Text = "Baixado:"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.ForeColor = System.Drawing.Color.Lime
        Me.LabelX4.Location = New System.Drawing.Point(98, 89)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(106, 15)
        Me.LabelX4.TabIndex = 2
        Me.LabelX4.Text = "Tamanho do arquivo:"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.ForeColor = System.Drawing.Color.Lime
        Me.LabelX3.Location = New System.Drawing.Point(98, 68)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(97, 15)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Destino do arquivo:"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.ForeColor = System.Drawing.Color.Lime
        Me.LabelX2.Location = New System.Drawing.Point(98, 47)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(96, 15)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "Origem do arquivo:"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.White
        Me.LabelX1.Location = New System.Drawing.Point(98, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(245, 24)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Baixando arquivo da Internet"
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
        Me.ReflectionImage1.Size = New System.Drawing.Size(89, 119)
        Me.ReflectionImage1.TabIndex = 0
        '
        'bck_informacoes
        '
        Me.bck_informacoes.WorkerReportsProgress = True
        Me.bck_informacoes.WorkerSupportsCancellation = True
        '
        'tmr_atualizar
        '
        Me.tmr_atualizar.Enabled = True
        Me.tmr_atualizar.Interval = 1000
        '
        'bck_download
        '
        Me.bck_download.WorkerReportsProgress = True
        Me.bck_download.WorkerSupportsCancellation = True
        '
        'atualizador_de_download
        '
        Me.atualizador_de_download.Interval = 30000
        '
        'FRM_DOWNLOADER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 222)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FRM_DOWNLOADER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baixando arquivo da Internet - Internet Globe"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents chk_avisar As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ReflectionImage2 As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents lbl_velocidade As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_baixado As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_tamanho_arquivo As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_destino As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl_origem As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ReflectionImage1 As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents bck_informacoes As System.ComponentModel.BackgroundWorker
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents tmr_atualizar As System.Windows.Forms.Timer
    Friend WithEvents bck_download As System.ComponentModel.BackgroundWorker
    Friend WithEvents atualizador_de_download As System.Windows.Forms.Timer
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ProgressBar1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents lbl_porcentagem As DevComponents.DotNetBar.LabelX
End Class
