<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_FORMULARIO_DE_FAVORITOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_FORMULARIO_DE_FAVORITOS))
        Me.LST_PASTAS = New System.Windows.Forms.ListView
        Me.IML_IMAGENS = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.CMD_AVANCAR = New System.Windows.Forms.Button
        Me.CMD_VOLTAR = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.LST_SITES = New System.Windows.Forms.ListView
        Me.IML_IMAGENS_2 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PIC_FAVORITO = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LBL_DATA_ALTERACAO = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TXT_URL_FAV = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TXT_TITULO_FAV = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.TXT_END = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.TXT_TITULO = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Button10 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Button9 = New System.Windows.Forms.Button
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Button8 = New System.Windows.Forms.Button
        Me.TXT_LOCAL_COPIA_DE_FAVORITOS = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.IML_IMAGENS_3 = New System.Windows.Forms.ImageList(Me.components)
        Me.BCK_COPIA = New System.ComponentModel.BackgroundWorker
        Me.BCK_FAVICON = New System.ComponentModel.BackgroundWorker
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PIC_FAVORITO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LST_PASTAS
        '
        Me.LST_PASTAS.BackColor = System.Drawing.Color.White
        Me.LST_PASTAS.ForeColor = System.Drawing.Color.Black
        Me.LST_PASTAS.HideSelection = False
        Me.LST_PASTAS.LargeImageList = Me.IML_IMAGENS
        Me.LST_PASTAS.Location = New System.Drawing.Point(8, 37)
        Me.LST_PASTAS.Name = "LST_PASTAS"
        Me.LST_PASTAS.Size = New System.Drawing.Size(330, 391)
        Me.LST_PASTAS.SmallImageList = Me.IML_IMAGENS
        Me.LST_PASTAS.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LST_PASTAS.TabIndex = 0
        Me.LST_PASTAS.UseCompatibleStateImageBehavior = False
        '
        'IML_IMAGENS
        '
        Me.IML_IMAGENS.ImageStream = CType(resources.GetObject("IML_IMAGENS.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IML_IMAGENS.TransparentColor = System.Drawing.Color.Transparent
        Me.IML_IMAGENS.Images.SetKeyName(0, "1.png")
        Me.IML_IMAGENS.Images.SetKeyName(1, "2.png")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 518)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(819, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.CMD_AVANCAR)
        Me.Panel2.Controls.Add(Me.CMD_VOLTAR)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Location = New System.Drawing.Point(8, 434)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(330, 35)
        Me.Panel2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(288, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CMD_AVANCAR
        '
        Me.CMD_AVANCAR.AutoSize = True
        Me.CMD_AVANCAR.Dock = System.Windows.Forms.DockStyle.Left
        Me.CMD_AVANCAR.Enabled = False
        Me.CMD_AVANCAR.Image = CType(resources.GetObject("CMD_AVANCAR.Image"), System.Drawing.Image)
        Me.CMD_AVANCAR.Location = New System.Drawing.Point(258, 0)
        Me.CMD_AVANCAR.Name = "CMD_AVANCAR"
        Me.CMD_AVANCAR.Size = New System.Drawing.Size(30, 35)
        Me.CMD_AVANCAR.TabIndex = 1
        Me.CMD_AVANCAR.UseVisualStyleBackColor = True
        '
        'CMD_VOLTAR
        '
        Me.CMD_VOLTAR.AutoSize = True
        Me.CMD_VOLTAR.Dock = System.Windows.Forms.DockStyle.Left
        Me.CMD_VOLTAR.Enabled = False
        Me.CMD_VOLTAR.Image = CType(resources.GetObject("CMD_VOLTAR.Image"), System.Drawing.Image)
        Me.CMD_VOLTAR.Location = New System.Drawing.Point(228, 0)
        Me.CMD_VOLTAR.Name = "CMD_VOLTAR"
        Me.CMD_VOLTAR.Size = New System.Drawing.Size(30, 35)
        Me.CMD_VOLTAR.TabIndex = 0
        Me.CMD_VOLTAR.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(102, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 35)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Remover pasta"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Nova pasta"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.AutoSize = True
        Me.Button5.Location = New System.Drawing.Point(128, 87)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 23)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Remover favoríto"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.Location = New System.Drawing.Point(44, 87)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(78, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Abrir favoríto"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'LST_SITES
        '
        Me.LST_SITES.HideSelection = False
        Me.LST_SITES.HoverSelection = True
        Me.LST_SITES.LargeImageList = Me.IML_IMAGENS_2
        Me.LST_SITES.Location = New System.Drawing.Point(344, 37)
        Me.LST_SITES.Name = "LST_SITES"
        Me.LST_SITES.Size = New System.Drawing.Size(459, 310)
        Me.LST_SITES.SmallImageList = Me.IML_IMAGENS_2
        Me.LST_SITES.TabIndex = 0
        Me.LST_SITES.UseCompatibleStateImageBehavior = False
        '
        'IML_IMAGENS_2
        '
        Me.IML_IMAGENS_2.ImageStream = CType(resources.GetObject("IML_IMAGENS_2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IML_IMAGENS_2.TransparentColor = System.Drawing.Color.Transparent
        Me.IML_IMAGENS_2.Images.SetKeyName(0, "4.png")
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ImageList = Me.IML_IMAGENS_3
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(819, 518)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PIC_FAVORITO)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.LST_SITES)
        Me.TabPage1.Controls.Add(Me.LST_PASTAS)
        Me.TabPage1.Controls.Add(Me.ToolStrip1)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(811, 475)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Básico"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PIC_FAVORITO
        '
        Me.PIC_FAVORITO.Image = CType(resources.GetObject("PIC_FAVORITO.Image"), System.Drawing.Image)
        Me.PIC_FAVORITO.Location = New System.Drawing.Point(707, 6)
        Me.PIC_FAVORITO.Name = "PIC_FAVORITO"
        Me.PIC_FAVORITO.Size = New System.Drawing.Size(16, 16)
        Me.PIC_FAVORITO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PIC_FAVORITO.TabIndex = 7
        Me.PIC_FAVORITO.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LBL_DATA_ALTERACAO)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TXT_URL_FAV)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TXT_TITULO_FAV)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Location = New System.Drawing.Point(344, 353)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(459, 116)
        Me.Panel1.TabIndex = 6
        '
        'LBL_DATA_ALTERACAO
        '
        Me.LBL_DATA_ALTERACAO.AutoSize = True
        Me.LBL_DATA_ALTERACAO.Location = New System.Drawing.Point(127, 56)
        Me.LBL_DATA_ALTERACAO.Name = "LBL_DATA_ALTERACAO"
        Me.LBL_DATA_ALTERACAO.Size = New System.Drawing.Size(53, 13)
        Me.LBL_DATA_ALTERACAO.TabIndex = 10
        Me.LBL_DATA_ALTERACAO.Text = "00/00/00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "última alteração:"
        '
        'TXT_URL_FAV
        '
        Me.TXT_URL_FAV.Location = New System.Drawing.Point(44, 29)
        Me.TXT_URL_FAV.Name = "TXT_URL_FAV"
        Me.TXT_URL_FAV.Size = New System.Drawing.Size(412, 20)
        Me.TXT_URL_FAV.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Url:"
        '
        'TXT_TITULO_FAV
        '
        Me.TXT_TITULO_FAV.Enabled = False
        Me.TXT_TITULO_FAV.Location = New System.Drawing.Point(44, 3)
        Me.TXT_TITULO_FAV.Name = "TXT_TITULO_FAV"
        Me.TXT_TITULO_FAV.Size = New System.Drawing.Size(412, 20)
        Me.TXT_TITULO_FAV.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Título:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.TXT_END, Me.ToolStripLabel2, Me.TXT_TITULO, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(805, 31)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(101, 28)
        Me.ToolStripButton1.Text = "Novo favoríto"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(109, 28)
        Me.ToolStripButton2.Text = "Em visualização"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(24, 28)
        Me.ToolStripLabel1.Text = "Url:"
        '
        'TXT_END
        '
        Me.TXT_END.Name = "TXT_END"
        Me.TXT_END.Size = New System.Drawing.Size(175, 31)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(37, 28)
        Me.ToolStripLabel2.Text = "Título:"
        '
        'TXT_TITULO
        '
        Me.TXT_TITULO.Name = "TXT_TITULO"
        Me.TXT_TITULO.Size = New System.Drawing.Size(175, 31)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(65, 28)
        Me.ToolStripButton3.Text = "Salvar"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button10)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.Button9)
        Me.TabPage2.Controls.Add(Me.RadioButton2)
        Me.TabPage2.Controls.Add(Me.RadioButton1)
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.TXT_LOCAL_COPIA_DE_FAVORITOS)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.ImageIndex = 1
        Me.TabPage2.Location = New System.Drawing.Point(4, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(811, 475)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Importar e exportar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(608, 148)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 5
        Me.Button10.Text = "Cancelar"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.Location = New System.Drawing.Point(117, 205)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(566, 95)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(69, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Parado!"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Progresso:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(9, 19)
        Me.ProgressBar1.MarqueeAnimationSpeed = 50
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(551, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(527, 148)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 4
        Me.Button9.Text = "Iniciar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(314, 179)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(98, 17)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Exportar(salvar)"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(198, 179)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(110, 17)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.Text = "Importar(restaurar)"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(117, 176)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 1
        Me.Button8.Text = "Procurar..."
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TXT_LOCAL_COPIA_DE_FAVORITOS
        '
        Me.TXT_LOCAL_COPIA_DE_FAVORITOS.Location = New System.Drawing.Point(117, 150)
        Me.TXT_LOCAL_COPIA_DE_FAVORITOS.Name = "TXT_LOCAL_COPIA_DE_FAVORITOS"
        Me.TXT_LOCAL_COPIA_DE_FAVORITOS.Size = New System.Drawing.Size(404, 20)
        Me.TXT_LOCAL_COPIA_DE_FAVORITOS.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Pasta de exportação:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(142, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(541, 70)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Você pode importar ou exportar seus favorítos, para fazer isto, clique em procura" & _
            "r para escolher a pasta onde será salvo, ou restaurados os favorítos."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(142, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Importar e exportar favoritos"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(8, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'IML_IMAGENS_3
        '
        Me.IML_IMAGENS_3.ImageStream = CType(resources.GetObject("IML_IMAGENS_3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IML_IMAGENS_3.TransparentColor = System.Drawing.Color.Transparent
        Me.IML_IMAGENS_3.Images.SetKeyName(0, "1.png")
        Me.IML_IMAGENS_3.Images.SetKeyName(1, "2.png")
        '
        'BCK_COPIA
        '
        Me.BCK_COPIA.WorkerSupportsCancellation = True
        '
        'BCK_FAVICON
        '
        Me.BCK_FAVICON.WorkerSupportsCancellation = True
        '
        'FRM_FORMULARIO_DE_FAVORITOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 540)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_FORMULARIO_DE_FAVORITOS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Meus favorítos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PIC_FAVORITO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LST_PASTAS As System.Windows.Forms.ListView
    Friend WithEvents IML_IMAGENS As System.Windows.Forms.ImageList
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents LST_SITES As System.Windows.Forms.ListView
    Friend WithEvents IML_IMAGENS_2 As System.Windows.Forms.ImageList
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents IML_IMAGENS_3 As System.Windows.Forms.ImageList
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents TXT_LOCAL_COPIA_DE_FAVORITOS As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents BCK_COPIA As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents BCK_FAVICON As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TXT_END As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TXT_TITULO As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PIC_FAVORITO As System.Windows.Forms.PictureBox
    Friend WithEvents TXT_TITULO_FAV As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_URL_FAV As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBL_DATA_ALTERACAO As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CMD_AVANCAR As System.Windows.Forms.Button
    Friend WithEvents CMD_VOLTAR As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
