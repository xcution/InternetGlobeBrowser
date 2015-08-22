<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_FORMULARIO_CAIXA_DE_AVISOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_FORMULARIO_CAIXA_DE_AVISOS))
        Me.PIC_IMAGEM = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.IML_IMAGENS = New System.Windows.Forms.ImageList(Me.components)
        Me.LBL_MENSAGEM = New System.Windows.Forms.Label
        Me.CHK_1 = New System.Windows.Forms.CheckBox
        CType(Me.PIC_IMAGEM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PIC_IMAGEM
        '
        Me.PIC_IMAGEM.Location = New System.Drawing.Point(12, 12)
        Me.PIC_IMAGEM.Name = "PIC_IMAGEM"
        Me.PIC_IMAGEM.Size = New System.Drawing.Size(32, 32)
        Me.PIC_IMAGEM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PIC_IMAGEM.TabIndex = 0
        Me.PIC_IMAGEM.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(282, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IML_IMAGENS
        '
        Me.IML_IMAGENS.ImageStream = CType(resources.GetObject("IML_IMAGENS.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IML_IMAGENS.TransparentColor = System.Drawing.Color.Transparent
        Me.IML_IMAGENS.Images.SetKeyName(0, "alerta.png")
        Me.IML_IMAGENS.Images.SetKeyName(1, "erro.png")
        Me.IML_IMAGENS.Images.SetKeyName(2, "informacao.png")
        Me.IML_IMAGENS.Images.SetKeyName(3, "pergunta.png")
        '
        'LBL_MENSAGEM
        '
        Me.LBL_MENSAGEM.Location = New System.Drawing.Point(50, 20)
        Me.LBL_MENSAGEM.Name = "LBL_MENSAGEM"
        Me.LBL_MENSAGEM.Size = New System.Drawing.Size(307, 85)
        Me.LBL_MENSAGEM.TabIndex = 0
        Me.LBL_MENSAGEM.Text = "Nada informado"
        '
        'CHK_1
        '
        Me.CHK_1.AutoSize = True
        Me.CHK_1.Location = New System.Drawing.Point(53, 119)
        Me.CHK_1.Name = "CHK_1"
        Me.CHK_1.Size = New System.Drawing.Size(106, 17)
        Me.CHK_1.TabIndex = 0
        Me.CHK_1.Text = "Avise-me sempre"
        Me.CHK_1.UseVisualStyleBackColor = True
        Me.CHK_1.Visible = False
        '
        'FRM_FORMULARIO_CAIXA_DE_AVISOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 150)
        Me.Controls.Add(Me.CHK_1)
        Me.Controls.Add(Me.LBL_MENSAGEM)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PIC_IMAGEM)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_FORMULARIO_CAIXA_DE_AVISOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aviso"
        CType(Me.PIC_IMAGEM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PIC_IMAGEM As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents IML_IMAGENS As System.Windows.Forms.ImageList
    Friend WithEvents LBL_MENSAGEM As System.Windows.Forms.Label
    Friend WithEvents CHK_1 As System.Windows.Forms.CheckBox
End Class
