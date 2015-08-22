<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_FORMULARIO_DE_PLUGINS_INSTALADOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_FORMULARIO_DE_PLUGINS_INSTALADOS))
        Me.IML_1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TAB_OPCOES = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LST_PLUGINS = New System.Windows.Forms.ListView
        Me.MNU_PLUGINS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IML_2 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LST_APLICATIVOS = New System.Windows.Forms.ListView
        Me.MNU_APLICATIVOS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AbrirAplicativoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PastaDeAplicativoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.RemoverAplicativoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IML_3 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.MT_PLUGINS_DE_NUCLEO = New Gecko.GeckoWebBrowser
        Me.TAB_OPCOES.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MNU_PLUGINS.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MNU_APLICATIVOS.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'IML_1
        '
        Me.IML_1.ImageStream = CType(resources.GetObject("IML_1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IML_1.TransparentColor = System.Drawing.Color.Transparent
        Me.IML_1.Images.SetKeyName(0, "1340383214_plugin_32.png")
        Me.IML_1.Images.SetKeyName(1, "1340383734_applications-development.png")
        Me.IML_1.Images.SetKeyName(2, "programs_defaults.png")
        '
        'TAB_OPCOES
        '
        Me.TAB_OPCOES.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TAB_OPCOES.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TAB_OPCOES.Controls.Add(Me.TabPage1)
        Me.TAB_OPCOES.Controls.Add(Me.TabPage2)
        Me.TAB_OPCOES.Controls.Add(Me.TabPage3)
        Me.TAB_OPCOES.ImageList = Me.IML_1
        Me.TAB_OPCOES.ItemSize = New System.Drawing.Size(150, 42)
        Me.TAB_OPCOES.Location = New System.Drawing.Point(12, 12)
        Me.TAB_OPCOES.Name = "TAB_OPCOES"
        Me.TAB_OPCOES.SelectedIndex = 0
        Me.TAB_OPCOES.Size = New System.Drawing.Size(768, 549)
        Me.TAB_OPCOES.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TAB_OPCOES.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 46)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(760, 499)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Plugins"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LST_PLUGINS)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 493)
        Me.Panel1.TabIndex = 1
        '
        'LST_PLUGINS
        '
        Me.LST_PLUGINS.ContextMenuStrip = Me.MNU_PLUGINS
        Me.LST_PLUGINS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LST_PLUGINS.LargeImageList = Me.IML_2
        Me.LST_PLUGINS.Location = New System.Drawing.Point(0, 0)
        Me.LST_PLUGINS.MultiSelect = False
        Me.LST_PLUGINS.Name = "LST_PLUGINS"
        Me.LST_PLUGINS.Size = New System.Drawing.Size(754, 493)
        Me.LST_PLUGINS.TabIndex = 0
        Me.LST_PLUGINS.UseCompatibleStateImageBehavior = False
        '
        'MNU_PLUGINS
        '
        Me.MNU_PLUGINS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem})
        Me.MNU_PLUGINS.Name = "MNU_PLUGINS"
        Me.MNU_PLUGINS.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MNU_PLUGINS.Size = New System.Drawing.Size(109, 26)
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.AbrirToolStripMenuItem.Text = "&Abrir"
        '
        'IML_2
        '
        Me.IML_2.ImageStream = CType(resources.GetObject("IML_2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IML_2.TransparentColor = System.Drawing.Color.Transparent
        Me.IML_2.Images.SetKeyName(0, "1340384742_bubble_32.png")
        Me.IML_2.Images.SetKeyName(1, "1340385140_processor.png")
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.ImageIndex = 1
        Me.TabPage2.Location = New System.Drawing.Point(4, 46)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(760, 499)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Aplicativos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LST_APLICATIVOS)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(754, 493)
        Me.Panel2.TabIndex = 0
        '
        'LST_APLICATIVOS
        '
        Me.LST_APLICATIVOS.ContextMenuStrip = Me.MNU_APLICATIVOS
        Me.LST_APLICATIVOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LST_APLICATIVOS.LargeImageList = Me.IML_3
        Me.LST_APLICATIVOS.Location = New System.Drawing.Point(0, 0)
        Me.LST_APLICATIVOS.MultiSelect = False
        Me.LST_APLICATIVOS.Name = "LST_APLICATIVOS"
        Me.LST_APLICATIVOS.Size = New System.Drawing.Size(754, 493)
        Me.LST_APLICATIVOS.TabIndex = 0
        Me.LST_APLICATIVOS.UseCompatibleStateImageBehavior = False
        '
        'MNU_APLICATIVOS
        '
        Me.MNU_APLICATIVOS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirAplicativoToolStripMenuItem, Me.PastaDeAplicativoToolStripMenuItem, Me.ToolStripMenuItem1, Me.RemoverAplicativoToolStripMenuItem})
        Me.MNU_APLICATIVOS.Name = "MNU_APLICATIVOS"
        Me.MNU_APLICATIVOS.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MNU_APLICATIVOS.Size = New System.Drawing.Size(177, 76)
        '
        'AbrirAplicativoToolStripMenuItem
        '
        Me.AbrirAplicativoToolStripMenuItem.Name = "AbrirAplicativoToolStripMenuItem"
        Me.AbrirAplicativoToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AbrirAplicativoToolStripMenuItem.Text = "&Abrir aplicativo"
        '
        'PastaDeAplicativoToolStripMenuItem
        '
        Me.PastaDeAplicativoToolStripMenuItem.Name = "PastaDeAplicativoToolStripMenuItem"
        Me.PastaDeAplicativoToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.PastaDeAplicativoToolStripMenuItem.Text = "&Pasta de aplicativo"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(173, 6)
        '
        'RemoverAplicativoToolStripMenuItem
        '
        Me.RemoverAplicativoToolStripMenuItem.Name = "RemoverAplicativoToolStripMenuItem"
        Me.RemoverAplicativoToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.RemoverAplicativoToolStripMenuItem.Text = "&Remover aplicativo"
        '
        'IML_3
        '
        Me.IML_3.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.IML_3.ImageSize = New System.Drawing.Size(32, 32)
        Me.IML_3.TransparentColor = System.Drawing.Color.Transparent
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.ImageIndex = 2
        Me.TabPage3.Location = New System.Drawing.Point(4, 46)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(760, 499)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Plugins de núcleo"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.MT_PLUGINS_DE_NUCLEO)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(754, 493)
        Me.Panel3.TabIndex = 0
        '
        'MT_PLUGINS_DE_NUCLEO
        '
        Me.MT_PLUGINS_DE_NUCLEO.DisableWmImeSetContext = False
        Me.MT_PLUGINS_DE_NUCLEO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MT_PLUGINS_DE_NUCLEO.Location = New System.Drawing.Point(0, 0)
        Me.MT_PLUGINS_DE_NUCLEO.Name = "MT_PLUGINS_DE_NUCLEO"
        Me.MT_PLUGINS_DE_NUCLEO.NoDefaultContextMenu = True
        Me.MT_PLUGINS_DE_NUCLEO.Size = New System.Drawing.Size(754, 493)
        Me.MT_PLUGINS_DE_NUCLEO.TabIndex = 0
        Me.MT_PLUGINS_DE_NUCLEO.UseHttpActivityObserver = False
        '
        'FRM_FORMULARIO_DE_PLUGINS_INSTALADOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.TAB_OPCOES)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_FORMULARIO_DE_PLUGINS_INSTALADOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plugins"
        Me.TAB_OPCOES.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.MNU_PLUGINS.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.MNU_APLICATIVOS.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IML_1 As System.Windows.Forms.ImageList
    Friend WithEvents TAB_OPCOES As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LST_PLUGINS As System.Windows.Forms.ListView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LST_APLICATIVOS As System.Windows.Forms.ListView
    Friend WithEvents IML_2 As System.Windows.Forms.ImageList
    Friend WithEvents IML_3 As System.Windows.Forms.ImageList
    Friend WithEvents MNU_PLUGINS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNU_APLICATIVOS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AbrirAplicativoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PastaDeAplicativoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RemoverAplicativoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents MT_PLUGINS_DE_NUCLEO As Gecko.GeckoWebBrowser
End Class
