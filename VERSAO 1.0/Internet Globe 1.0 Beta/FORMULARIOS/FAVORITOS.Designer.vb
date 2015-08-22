<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_FAVORITOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_FAVORITOS))
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx
        Me.ButtonX6 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX5 = New DevComponents.DotNetBar.ButtonX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.cbo_pasta = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ReflectionImage4 = New DevComponents.DotNetBar.Controls.ReflectionImage
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.txt_titulo = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.ReflectionImage1 = New DevComponents.DotNetBar.Controls.ReflectionImage
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.txt_favorito_endereco = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.cmd_excluir = New DevComponents.DotNetBar.ButtonX
        Me.txt_nome_da_pasta = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmd_nova = New DevComponents.DotNetBar.ButtonX
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX
        Me.cmd_renomear = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.tree_pastas_de_favoritos = New System.Windows.Forms.TreeView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.mnu_favoritos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AbrirFavorítoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AbrirFavorítoEmNovaAbaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ReToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_pastas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.PanelEx4.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.TabControlPanel4.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.mnu_favoritos.SuspendLayout()
        Me.mnu_pastas.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.Transparent
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Controls.Add(Me.TabControlPanel4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(476, 376)
        Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Tabs.Add(Me.TabItem3)
        Me.TabControl1.Tabs.Add(Me.TabItem2)
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.PanelEx3)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(476, 354)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 5
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.Controls.Add(Me.PanelEx4)
        Me.PanelEx3.Controls.Add(Me.ButtonX5)
        Me.PanelEx3.Controls.Add(Me.LabelX2)
        Me.PanelEx3.Controls.Add(Me.ButtonX4)
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx3.Location = New System.Drawing.Point(1, 1)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(474, 352)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 0
        '
        'PanelEx4
        '
        Me.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx4.Controls.Add(Me.ButtonX6)
        Me.PanelEx4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx4.Location = New System.Drawing.Point(0, 317)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(474, 35)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        Me.PanelEx4.TabIndex = 3
        '
        'ButtonX6
        '
        Me.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX6.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonX6.FocusCuesEnabled = False
        Me.ButtonX6.Location = New System.Drawing.Point(399, 0)
        Me.ButtonX6.Name = "ButtonX6"
        Me.ButtonX6.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor
        Me.ButtonX6.Size = New System.Drawing.Size(75, 35)
        Me.ButtonX6.TabIndex = 2
        Me.ButtonX6.Text = "Ok"
        '
        'ButtonX5
        '
        Me.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX5.AntiAlias = True
        Me.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX5.FocusCuesEnabled = False
        Me.ButtonX5.Image = CType(resources.GetObject("ButtonX5.Image"), System.Drawing.Image)
        Me.ButtonX5.Location = New System.Drawing.Point(255, 130)
        Me.ButtonX5.Name = "ButtonX5"
        Me.ButtonX5.Size = New System.Drawing.Size(208, 155)
        Me.ButtonX5.TabIndex = 1
        Me.ButtonX5.Text = "Exportar"
        '
        'LabelX2
        '
        Me.LabelX2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.White
        Me.LabelX2.Location = New System.Drawing.Point(11, 3)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(452, 121)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Você pode importar ou exportar seus favorítos, assim você não perde, ou restaura " & _
            "os seus favorítos."
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX2.WordWrap = True
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.AntiAlias = True
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.FocusCuesEnabled = False
        Me.ButtonX4.Image = CType(resources.GetObject("ButtonX4.Image"), System.Drawing.Image)
        Me.ButtonX4.Location = New System.Drawing.Point(11, 130)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(208, 155)
        Me.ButtonX4.TabIndex = 0
        Me.ButtonX4.Text = "Importar"
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Importar e Exportar"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.PanelEx2)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(476, 354)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.Controls.Add(Me.ButtonX2)
        Me.PanelEx2.Controls.Add(Me.cbo_pasta)
        Me.PanelEx2.Controls.Add(Me.ReflectionImage4)
        Me.PanelEx2.Controls.Add(Me.LabelX10)
        Me.PanelEx2.Controls.Add(Me.txt_titulo)
        Me.PanelEx2.Controls.Add(Me.LabelX5)
        Me.PanelEx2.Controls.Add(Me.ReflectionImage1)
        Me.PanelEx2.Controls.Add(Me.ButtonX1)
        Me.PanelEx2.Controls.Add(Me.txt_favorito_endereco)
        Me.PanelEx2.Controls.Add(Me.LabelX4)
        Me.PanelEx2.Controls.Add(Me.LabelX9)
        Me.PanelEx2.Controls.Add(Me.LabelX1)
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(1, 1)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(474, 352)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 0
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.AntiAlias = True
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.FocusCuesEnabled = False
        Me.ButtonX2.Location = New System.Drawing.Point(173, 210)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor
        Me.ButtonX2.Size = New System.Drawing.Size(258, 22)
        Me.ButtonX2.TabIndex = 4
        Me.ButtonX2.Text = "A&dicionar site em visualização"
        '
        'cbo_pasta
        '
        Me.cbo_pasta.DisplayMember = "Text"
        Me.cbo_pasta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_pasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_pasta.FormattingEnabled = True
        Me.cbo_pasta.ItemHeight = 14
        Me.cbo_pasta.Location = New System.Drawing.Point(99, 174)
        Me.cbo_pasta.Name = "cbo_pasta"
        Me.cbo_pasta.Size = New System.Drawing.Size(332, 20)
        Me.cbo_pasta.Sorted = True
        Me.cbo_pasta.TabIndex = 2
        '
        'ReflectionImage4
        '
        '
        '
        '
        Me.ReflectionImage4.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ReflectionImage4.Image = CType(resources.GetObject("ReflectionImage4.Image"), System.Drawing.Image)
        Me.ReflectionImage4.Location = New System.Drawing.Point(437, 174)
        Me.ReflectionImage4.Name = "ReflectionImage4"
        Me.ReflectionImage4.Size = New System.Drawing.Size(22, 24)
        Me.ReflectionImage4.TabIndex = 7
        '
        'LabelX10
        '
        Me.LabelX10.AutoSize = True
        Me.LabelX10.ForeColor = System.Drawing.Color.White
        Me.LabelX10.Location = New System.Drawing.Point(11, 179)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(82, 15)
        Me.LabelX10.TabIndex = 6
        Me.LabelX10.Text = "Salvar na pasta:"
        '
        'txt_titulo
        '
        '
        '
        '
        Me.txt_titulo.Border.Class = "TextBoxBorder"
        Me.txt_titulo.Location = New System.Drawing.Point(99, 148)
        Me.txt_titulo.Name = "txt_titulo"
        Me.txt_titulo.Size = New System.Drawing.Size(360, 20)
        Me.txt_titulo.TabIndex = 1
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.ForeColor = System.Drawing.Color.White
        Me.LabelX5.Location = New System.Drawing.Point(105, 67)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(301, 15)
        Me.LabelX5.TabIndex = 5
        Me.LabelX5.Text = "Para adicionar um novo favoríto preencha os campos abaixo."
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX5.WordWrap = True
        '
        'ReflectionImage1
        '
        '
        '
        '
        Me.ReflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ReflectionImage1.Image = CType(resources.GetObject("ReflectionImage1.Image"), System.Drawing.Image)
        Me.ReflectionImage1.Location = New System.Drawing.Point(11, 13)
        Me.ReflectionImage1.Name = "ReflectionImage1"
        Me.ReflectionImage1.Size = New System.Drawing.Size(88, 104)
        Me.ReflectionImage1.TabIndex = 3
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.AntiAlias = True
        Me.ButtonX1.AutoSize = True
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.FocusCuesEnabled = False
        Me.ButtonX1.Image = CType(resources.GetObject("ButtonX1.Image"), System.Drawing.Image)
        Me.ButtonX1.Location = New System.Drawing.Point(99, 210)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor
        Me.ButtonX1.Size = New System.Drawing.Size(75, 22)
        Me.ButtonX1.TabIndex = 3
        Me.ButtonX1.Text = "&Adicionar"
        '
        'txt_favorito_endereco
        '
        '
        '
        '
        Me.txt_favorito_endereco.Border.Class = "TextBoxBorder"
        Me.txt_favorito_endereco.Location = New System.Drawing.Point(99, 122)
        Me.txt_favorito_endereco.Name = "txt_favorito_endereco"
        Me.txt_favorito_endereco.Size = New System.Drawing.Size(360, 20)
        Me.txt_favorito_endereco.TabIndex = 0
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.White
        Me.LabelX4.Location = New System.Drawing.Point(105, 22)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(199, 39)
        Me.LabelX4.TabIndex = 4
        Me.LabelX4.Text = "Novo favoríto"
        '
        'LabelX9
        '
        Me.LabelX9.AutoSize = True
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        Me.LabelX9.ForeColor = System.Drawing.Color.White
        Me.LabelX9.Location = New System.Drawing.Point(60, 153)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(33, 15)
        Me.LabelX9.TabIndex = 0
        Me.LabelX9.Text = "Título:"
        Me.LabelX9.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.ForeColor = System.Drawing.Color.White
        Me.LabelX1.Location = New System.Drawing.Point(11, 123)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(82, 15)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "End. do favoríto:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Novo favoríto"
        '
        'TabControlPanel4
        '
        Me.TabControlPanel4.Controls.Add(Me.PanelEx1)
        Me.TabControlPanel4.Controls.Add(Me.Panel1)
        Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel4.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel4.Size = New System.Drawing.Size(476, 354)
        Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel4.Style.GradientAngle = 90
        Me.TabControlPanel4.TabIndex = 4
        Me.TabControlPanel4.TabItem = Me.TabItem3
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.cmd_excluir)
        Me.PanelEx1.Controls.Add(Me.txt_nome_da_pasta)
        Me.PanelEx1.Controls.Add(Me.cmd_nova)
        Me.PanelEx1.Controls.Add(Me.LabelX14)
        Me.PanelEx1.Controls.Add(Me.cmd_renomear)
        Me.PanelEx1.Controls.Add(Me.ButtonX3)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(1, 285)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(474, 68)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 12
        '
        'cmd_excluir
        '
        Me.cmd_excluir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmd_excluir.AntiAlias = True
        Me.cmd_excluir.BackColor = System.Drawing.Color.Transparent
        Me.cmd_excluir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmd_excluir.FocusCuesEnabled = False
        Me.cmd_excluir.Image = CType(resources.GetObject("cmd_excluir.Image"), System.Drawing.Image)
        Me.cmd_excluir.Location = New System.Drawing.Point(31, 32)
        Me.cmd_excluir.Name = "cmd_excluir"
        Me.cmd_excluir.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 0, 10, 0)
        Me.cmd_excluir.Size = New System.Drawing.Size(102, 30)
        Me.cmd_excluir.TabIndex = 0
        Me.cmd_excluir.Text = "&Excluir pasta"
        '
        'txt_nome_da_pasta
        '
        '
        '
        '
        Me.txt_nome_da_pasta.Border.Class = "TextBoxBorder"
        Me.txt_nome_da_pasta.Location = New System.Drawing.Point(72, 5)
        Me.txt_nome_da_pasta.Name = "txt_nome_da_pasta"
        Me.txt_nome_da_pasta.Size = New System.Drawing.Size(373, 20)
        Me.txt_nome_da_pasta.TabIndex = 11
        Me.txt_nome_da_pasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmd_nova
        '
        Me.cmd_nova.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmd_nova.AntiAlias = True
        Me.cmd_nova.BackColor = System.Drawing.Color.Transparent
        Me.cmd_nova.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmd_nova.FocusCuesEnabled = False
        Me.cmd_nova.Image = CType(resources.GetObject("cmd_nova.Image"), System.Drawing.Image)
        Me.cmd_nova.Location = New System.Drawing.Point(132, 32)
        Me.cmd_nova.Name = "cmd_nova"
        Me.cmd_nova.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor
        Me.cmd_nova.Size = New System.Drawing.Size(102, 30)
        Me.cmd_nova.TabIndex = 9
        Me.cmd_nova.Text = "&Nova pasta"
        '
        'LabelX14
        '
        Me.LabelX14.AutoSize = True
        Me.LabelX14.BackColor = System.Drawing.Color.Transparent
        Me.LabelX14.ForeColor = System.Drawing.Color.Black
        Me.LabelX14.Location = New System.Drawing.Point(31, 6)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(35, 15)
        Me.LabelX14.TabIndex = 10
        Me.LabelX14.Text = "Nome:"
        '
        'cmd_renomear
        '
        Me.cmd_renomear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmd_renomear.AntiAlias = True
        Me.cmd_renomear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmd_renomear.FocusCuesEnabled = False
        Me.cmd_renomear.Image = CType(resources.GetObject("cmd_renomear.Image"), System.Drawing.Image)
        Me.cmd_renomear.Location = New System.Drawing.Point(233, 32)
        Me.cmd_renomear.Name = "cmd_renomear"
        Me.cmd_renomear.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor
        Me.cmd_renomear.Size = New System.Drawing.Size(111, 30)
        Me.cmd_renomear.TabIndex = 0
        Me.cmd_renomear.Text = "&Renomear item"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.AntiAlias = True
        Me.ButtonX3.BackColor = System.Drawing.Color.Transparent
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.FocusCuesEnabled = False
        Me.ButtonX3.Location = New System.Drawing.Point(343, 32)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 10, 0, 10)
        Me.ButtonX3.Size = New System.Drawing.Size(102, 30)
        Me.ButtonX3.TabIndex = 2
        Me.ButtonX3.Text = "&Sair"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.tree_pastas_de_favoritos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(474, 284)
        Me.Panel1.TabIndex = 11
        '
        'tree_pastas_de_favoritos
        '
        Me.tree_pastas_de_favoritos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tree_pastas_de_favoritos.HideSelection = False
        Me.tree_pastas_de_favoritos.ImageIndex = 1
        Me.tree_pastas_de_favoritos.ImageList = Me.ImageList1
        Me.tree_pastas_de_favoritos.Location = New System.Drawing.Point(0, 0)
        Me.tree_pastas_de_favoritos.Name = "tree_pastas_de_favoritos"
        Me.tree_pastas_de_favoritos.SelectedImageKey = "folderopen1.png"
        Me.tree_pastas_de_favoritos.Size = New System.Drawing.Size(474, 284)
        Me.tree_pastas_de_favoritos.TabIndex = 7
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder_horizontal_open.png")
        Me.ImageList1.Images.SetKeyName(1, "folder_horizontal.png")
        Me.ImageList1.Images.SetKeyName(2, "web-browser.png")
        '
        'TabItem3
        '
        Me.TabItem3.AttachedControl = Me.TabControlPanel4
        Me.TabItem3.Name = "TabItem3"
        Me.TabItem3.Text = "Gerenciar"
        '
        'mnu_favoritos
        '
        Me.mnu_favoritos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirFavorítoToolStripMenuItem, Me.AbrirFavorítoEmNovaAbaToolStripMenuItem, Me.RemoverToolStripMenuItem, Me.ToolStripSeparator1, Me.ReToolStripMenuItem})
        Me.mnu_favoritos.Name = "mnu_contexto"
        Me.mnu_favoritos.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mnu_favoritos.Size = New System.Drawing.Size(215, 98)
        '
        'AbrirFavorítoToolStripMenuItem
        '
        Me.AbrirFavorítoToolStripMenuItem.Image = CType(resources.GetObject("AbrirFavorítoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AbrirFavorítoToolStripMenuItem.Name = "AbrirFavorítoToolStripMenuItem"
        Me.AbrirFavorítoToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.AbrirFavorítoToolStripMenuItem.Text = "&Abrir favoríto selecionado"
        '
        'AbrirFavorítoEmNovaAbaToolStripMenuItem
        '
        Me.AbrirFavorítoEmNovaAbaToolStripMenuItem.Image = CType(resources.GetObject("AbrirFavorítoEmNovaAbaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AbrirFavorítoEmNovaAbaToolStripMenuItem.Name = "AbrirFavorítoEmNovaAbaToolStripMenuItem"
        Me.AbrirFavorítoEmNovaAbaToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.AbrirFavorítoEmNovaAbaToolStripMenuItem.Text = "A&brir favoríto em nova aba"
        '
        'RemoverToolStripMenuItem
        '
        Me.RemoverToolStripMenuItem.Image = CType(resources.GetObject("RemoverToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RemoverToolStripMenuItem.Name = "RemoverToolStripMenuItem"
        Me.RemoverToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.RemoverToolStripMenuItem.Text = "&Remover"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(211, 6)
        '
        'ReToolStripMenuItem
        '
        Me.ReToolStripMenuItem.Image = CType(resources.GetObject("ReToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReToolStripMenuItem.Name = "ReToolStripMenuItem"
        Me.ReToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ReToolStripMenuItem.Text = "&Renomear favoríto"
        '
        'mnu_pastas
        '
        Me.mnu_pastas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem4, Me.ToolStripMenuItem3})
        Me.mnu_pastas.Name = "mnu_pastas"
        Me.mnu_pastas.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mnu_pastas.Size = New System.Drawing.Size(165, 76)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem1.Text = "&Nova pasta"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem2.Text = "&Excluir pasta"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(161, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem3.Text = "&Renomear pasta"
        '
        'FRM_FAVORITOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 376)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_FAVORITOS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Favorítos"
        Me.TopMost = True
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx4.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.TabControlPanel4.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.mnu_favoritos.ResumeLayout(False)
        Me.mnu_pastas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbo_pasta As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ReflectionImage4 As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_titulo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ReflectionImage1 As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_favorito_endereco As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmd_nova As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmd_excluir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmd_renomear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_nome_da_pasta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tree_pastas_de_favoritos As System.Windows.Forms.TreeView
    Friend WithEvents TabItem3 As DevComponents.DotNetBar.TabItem
    Friend WithEvents mnu_favoritos As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AbrirFavorítoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirFavorítoEmNovaAbaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RemoverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents mnu_pastas As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ReToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX6 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX5 As DevComponents.DotNetBar.ButtonX
End Class
