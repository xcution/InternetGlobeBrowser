<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ERRO_AO_ABRIR_SITE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_ERRO_AO_ABRIR_SITE))
        Me.bck_teste_de_pagina = New System.ComponentModel.BackgroundWorker
        Me.bck_teste_de_servidor = New System.ComponentModel.BackgroundWorker
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PIC_5 = New System.Windows.Forms.PictureBox
        Me.PIC_6 = New System.Windows.Forms.PictureBox
        Me.PIC_3 = New System.Windows.Forms.PictureBox
        Me.PIC_4 = New System.Windows.Forms.PictureBox
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.PRG_PROGRESSO = New DevComponents.DotNetBar.Controls.ProgressBarX
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIC_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIC_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIC_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIC_4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bck_teste_de_pagina
        '
        '
        'bck_teste_de_servidor
        '
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonX1.FocusCuesEnabled = False
        Me.ButtonX1.Location = New System.Drawing.Point(281, 0)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor
        Me.ButtonX1.Size = New System.Drawing.Size(130, 32)
        Me.ButtonX1.TabIndex = 2
        Me.ButtonX1.Text = "Faça um novo teste"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonX2.Enabled = False
        Me.ButtonX2.FocusCuesEnabled = False
        Me.ButtonX2.Location = New System.Drawing.Point(151, 0)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor
        Me.ButtonX2.Size = New System.Drawing.Size(130, 32)
        Me.ButtonX2.TabIndex = 1
        Me.ButtonX2.Text = "&Abrir site"
        '
        'LabelX1
        '
        Me.LabelX1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(80, 146)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(450, 77)
        Me.LabelX1.TabIndex = 32
        Me.LabelX1.Text = "Aguardando..."
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX1.WordWrap = True
        '
        'LabelX2
        '
        Me.LabelX2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(80, 234)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(450, 77)
        Me.LabelX2.TabIndex = 32
        Me.LabelX2.Text = "Aguardando..."
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX2.WordWrap = True
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonX3.FocusCuesEnabled = False
        Me.ButtonX3.Location = New System.Drawing.Point(411, 0)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor
        Me.ButtonX3.Size = New System.Drawing.Size(130, 32)
        Me.ButtonX3.TabIndex = 0
        Me.ButtonX3.Text = "Abrir sem teste"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelX3.Location = New System.Drawing.Point(146, 39)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(323, 35)
        Me.LabelX3.TabIndex = 35
        Me.LabelX3.Text = "Erro ao tentar abrir site"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 234)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 146)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 36
        Me.PictureBox3.TabStop = False
        '
        'PIC_5
        '
        Me.PIC_5.Image = CType(resources.GetObject("PIC_5.Image"), System.Drawing.Image)
        Me.PIC_5.Location = New System.Drawing.Point(50, 146)
        Me.PIC_5.Name = "PIC_5"
        Me.PIC_5.Size = New System.Drawing.Size(24, 24)
        Me.PIC_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PIC_5.TabIndex = 36
        Me.PIC_5.TabStop = False
        Me.PIC_5.Visible = False
        '
        'PIC_6
        '
        Me.PIC_6.Image = CType(resources.GetObject("PIC_6.Image"), System.Drawing.Image)
        Me.PIC_6.Location = New System.Drawing.Point(50, 146)
        Me.PIC_6.Name = "PIC_6"
        Me.PIC_6.Size = New System.Drawing.Size(24, 24)
        Me.PIC_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PIC_6.TabIndex = 36
        Me.PIC_6.TabStop = False
        Me.PIC_6.Visible = False
        '
        'PIC_3
        '
        Me.PIC_3.Image = CType(resources.GetObject("PIC_3.Image"), System.Drawing.Image)
        Me.PIC_3.Location = New System.Drawing.Point(50, 234)
        Me.PIC_3.Name = "PIC_3"
        Me.PIC_3.Size = New System.Drawing.Size(24, 24)
        Me.PIC_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PIC_3.TabIndex = 38
        Me.PIC_3.TabStop = False
        Me.PIC_3.Visible = False
        '
        'PIC_4
        '
        Me.PIC_4.Image = CType(resources.GetObject("PIC_4.Image"), System.Drawing.Image)
        Me.PIC_4.Location = New System.Drawing.Point(50, 234)
        Me.PIC_4.Name = "PIC_4"
        Me.PIC_4.Size = New System.Drawing.Size(24, 24)
        Me.PIC_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PIC_4.TabIndex = 37
        Me.PIC_4.TabStop = False
        Me.PIC_4.Visible = False
        '
        'LabelX4
        '
        Me.LabelX4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(146, 80)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(384, 60)
        Me.LabelX4.TabIndex = 39
        Me.LabelX4.Text = "O Internet Globe lamenta, porque não conseguiu abrir a página do site informado. " & _
            "veja o porque logo abaixo."
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX4.WordWrap = True
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.PRG_PROGRESSO)
        Me.PanelEx1.Controls.Add(Me.ButtonX2)
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.Controls.Add(Me.ButtonX3)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx1.Location = New System.Drawing.Point(0, 331)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(541, 32)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 40
        '
        'PRG_PROGRESSO
        '
        Me.PRG_PROGRESSO.FocusCuesEnabled = False
        Me.PRG_PROGRESSO.Location = New System.Drawing.Point(5, 3)
        Me.PRG_PROGRESSO.MarqueeAnimationSpeed = 25
        Me.PRG_PROGRESSO.Name = "PRG_PROGRESSO"
        Me.PRG_PROGRESSO.Size = New System.Drawing.Size(142, 26)
        Me.PRG_PROGRESSO.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.PRG_PROGRESSO.TabIndex = 34
        Me.PRG_PROGRESSO.Visible = False
        '
        'FRM_ERRO_AO_ABRIR_SITE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(541, 363)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.PIC_3)
        Me.Controls.Add(Me.PIC_4)
        Me.Controls.Add(Me.PIC_6)
        Me.Controls.Add(Me.PIC_5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_ERRO_AO_ABRIR_SITE"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Não foi possível abrir a página"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIC_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIC_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIC_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIC_4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bck_teste_de_pagina As System.ComponentModel.BackgroundWorker
    Friend WithEvents bck_teste_de_servidor As System.ComponentModel.BackgroundWorker
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PIC_5 As System.Windows.Forms.PictureBox
    Friend WithEvents PIC_6 As System.Windows.Forms.PictureBox
    Friend WithEvents PIC_3 As System.Windows.Forms.PictureBox
    Friend WithEvents PIC_4 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PRG_PROGRESSO As DevComponents.DotNetBar.Controls.ProgressBarX
End Class
