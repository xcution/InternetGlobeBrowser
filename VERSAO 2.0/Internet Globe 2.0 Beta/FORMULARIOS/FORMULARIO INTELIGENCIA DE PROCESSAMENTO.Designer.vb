<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_FORMULARIO_INTELIGENCIA_DE_PROCESSAMENTO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_FORMULARIO_INTELIGENCIA_DE_PROCESSAMENTO))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PIC1 = New System.Windows.Forms.PictureBox
        Me.LBL_1 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PIC2 = New System.Windows.Forms.PictureBox
        Me.LBL_2 = New System.Windows.Forms.Label
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.PIC3 = New System.Windows.Forms.PictureBox
        Me.LBL_3 = New System.Windows.Forms.Label
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TMR_ATUALIZADOR = New System.Windows.Forms.Timer(Me.components)
        Me.IML_1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.PIC4 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXT_IP = New System.Windows.Forms.TextBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.PIC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PIC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PIC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PIC4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PIC1)
        Me.GroupBox1.Controls.Add(Me.LBL_1)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 75)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Memória em uso"
        '
        'PIC1
        '
        Me.PIC1.Location = New System.Drawing.Point(232, 19)
        Me.PIC1.Name = "PIC1"
        Me.PIC1.Size = New System.Drawing.Size(48, 48)
        Me.PIC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PIC1.TabIndex = 3
        Me.PIC1.TabStop = False
        '
        'LBL_1
        '
        Me.LBL_1.AutoSize = True
        Me.LBL_1.Location = New System.Drawing.Point(166, 54)
        Me.LBL_1.Name = "LBL_1"
        Me.LBL_1.Size = New System.Drawing.Size(41, 13)
        Me.LBL_1.TabIndex = 2
        Me.LBL_1.Text = "Parado"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(60, 44)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PIC2)
        Me.GroupBox2.Controls.Add(Me.LBL_2)
        Me.GroupBox2.Controls.Add(Me.ProgressBar2)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(286, 75)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Processador uso geral"
        '
        'PIC2
        '
        Me.PIC2.Location = New System.Drawing.Point(232, 19)
        Me.PIC2.Name = "PIC2"
        Me.PIC2.Size = New System.Drawing.Size(48, 48)
        Me.PIC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PIC2.TabIndex = 3
        Me.PIC2.TabStop = False
        '
        'LBL_2
        '
        Me.LBL_2.AutoSize = True
        Me.LBL_2.Location = New System.Drawing.Point(166, 54)
        Me.LBL_2.Name = "LBL_2"
        Me.LBL_2.Size = New System.Drawing.Size(41, 13)
        Me.LBL_2.TabIndex = 2
        Me.LBL_2.Text = "Parado"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(60, 44)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar2.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PIC3)
        Me.GroupBox3.Controls.Add(Me.LBL_3)
        Me.GroupBox3.Controls.Add(Me.ProgressBar3)
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 174)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(286, 75)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Temperatura de processador"
        '
        'PIC3
        '
        Me.PIC3.Location = New System.Drawing.Point(232, 19)
        Me.PIC3.Name = "PIC3"
        Me.PIC3.Size = New System.Drawing.Size(48, 48)
        Me.PIC3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PIC3.TabIndex = 3
        Me.PIC3.TabStop = False
        '
        'LBL_3
        '
        Me.LBL_3.AutoSize = True
        Me.LBL_3.Location = New System.Drawing.Point(166, 54)
        Me.LBL_3.Name = "LBL_3"
        Me.LBL_3.Size = New System.Drawing.Size(41, 13)
        Me.LBL_3.TabIndex = 2
        Me.LBL_3.Text = "Parado"
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Location = New System.Drawing.Point(60, 44)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar3.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 341)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Sair"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TMR_ATUALIZADOR
        '
        Me.TMR_ATUALIZADOR.Interval = 1000
        '
        'IML_1
        '
        Me.IML_1.ImageStream = CType(resources.GetObject("IML_1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IML_1.TransparentColor = System.Drawing.Color.Transparent
        Me.IML_1.Images.SetKeyName(0, "check.png")
        Me.IML_1.Images.SetKeyName(1, "1337706966_onebit_36.png")
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PIC4)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.TXT_IP)
        Me.GroupBox4.Controls.Add(Me.PictureBox4)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 255)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(286, 75)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Internet"
        '
        'PIC4
        '
        Me.PIC4.Location = New System.Drawing.Point(232, 19)
        Me.PIC4.Name = "PIC4"
        Me.PIC4.Size = New System.Drawing.Size(48, 48)
        Me.PIC4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PIC4.TabIndex = 4
        Me.PIC4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ip de teste:"
        '
        'TXT_IP
        '
        Me.TXT_IP.Location = New System.Drawing.Point(121, 34)
        Me.TXT_IP.Name = "TXT_IP"
        Me.TXT_IP.Size = New System.Drawing.Size(105, 20)
        Me.TXT_IP.TabIndex = 1
        Me.TXT_IP.Text = "208.67.222.222"
        Me.TXT_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'FRM_FORMULARIO_INTELIGENCIA_DE_PROCESSAMENTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 376)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_FORMULARIO_INTELIGENCIA_DE_PROCESSAMENTO"
        Me.Text = "Inteligência de processamento"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PIC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PIC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PIC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PIC4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents LBL_1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents LBL_2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents LBL_3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar3 As System.Windows.Forms.ProgressBar
    Friend WithEvents TMR_ATUALIZADOR As System.Windows.Forms.Timer
    Friend WithEvents PIC1 As System.Windows.Forms.PictureBox
    Friend WithEvents PIC2 As System.Windows.Forms.PictureBox
    Friend WithEvents PIC3 As System.Windows.Forms.PictureBox
    Friend WithEvents IML_1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PIC4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_IP As System.Windows.Forms.TextBox
End Class
