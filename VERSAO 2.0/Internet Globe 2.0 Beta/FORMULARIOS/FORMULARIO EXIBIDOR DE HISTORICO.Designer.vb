<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_FORMULARIO_EXIBIDOR_DE_HISTORICO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_FORMULARIO_EXIBIDOR_DE_HISTORICO))
        Me.MOTOR_GECKOFX = New Gecko.GeckoWebBrowser
        Me.MNU_OPCOES_DE_HISTORICO = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NovaAbaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AbaAtualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.AdicionaAosFavorítosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BCK_FAVICON = New System.ComponentModel.BackgroundWorker
        Me.MNU_OPCOES_DE_HISTORICO.SuspendLayout()
        Me.SuspendLayout()
        '
        'MOTOR_GECKOFX
        '
        Me.MOTOR_GECKOFX.DisableWmImeSetContext = False
        Me.MOTOR_GECKOFX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MOTOR_GECKOFX.Location = New System.Drawing.Point(0, 0)
        Me.MOTOR_GECKOFX.Name = "MOTOR_GECKOFX"
        Me.MOTOR_GECKOFX.NoDefaultContextMenu = True
        Me.MOTOR_GECKOFX.Size = New System.Drawing.Size(792, 573)
        Me.MOTOR_GECKOFX.TabIndex = 0
        Me.MOTOR_GECKOFX.UseHttpActivityObserver = False
        '
        'MNU_OPCOES_DE_HISTORICO
        '
        Me.MNU_OPCOES_DE_HISTORICO.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaAbaToolStripMenuItem, Me.AbaAtualToolStripMenuItem, Me.ToolStripMenuItem1, Me.AdicionaAosFavorítosToolStripMenuItem})
        Me.MNU_OPCOES_DE_HISTORICO.Name = "MNU_OPCOES_DE_HISTORICO"
        Me.MNU_OPCOES_DE_HISTORICO.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MNU_OPCOES_DE_HISTORICO.Size = New System.Drawing.Size(192, 76)
        '
        'NovaAbaToolStripMenuItem
        '
        Me.NovaAbaToolStripMenuItem.Name = "NovaAbaToolStripMenuItem"
        Me.NovaAbaToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.NovaAbaToolStripMenuItem.Text = "Nova aba"
        '
        'AbaAtualToolStripMenuItem
        '
        Me.AbaAtualToolStripMenuItem.Name = "AbaAtualToolStripMenuItem"
        Me.AbaAtualToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AbaAtualToolStripMenuItem.Text = "Aba atual"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(188, 6)
        '
        'AdicionaAosFavorítosToolStripMenuItem
        '
        Me.AdicionaAosFavorítosToolStripMenuItem.Name = "AdicionaAosFavorítosToolStripMenuItem"
        Me.AdicionaAosFavorítosToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AdicionaAosFavorítosToolStripMenuItem.Text = "Adiciona aos favorítos"
        '
        'BCK_FAVICON
        '
        Me.BCK_FAVICON.WorkerReportsProgress = True
        Me.BCK_FAVICON.WorkerSupportsCancellation = True
        '
        'FRM_FORMULARIO_EXIBIDOR_DE_HISTORICO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.MOTOR_GECKOFX)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_FORMULARIO_EXIBIDOR_DE_HISTORICO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Histórico"
        Me.MNU_OPCOES_DE_HISTORICO.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MOTOR_GECKOFX As Gecko.GeckoWebBrowser
    Friend WithEvents MNU_OPCOES_DE_HISTORICO As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NovaAbaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbaAtualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AdicionaAosFavorítosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BCK_FAVICON As System.ComponentModel.BackgroundWorker
End Class
