<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_FORMULARIO_WEB_BASICO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_FORMULARIO_WEB_BASICO))
        Me.BCK_FAVICON_FORM_BASICO_GERAR = New System.ComponentModel.BackgroundWorker
        Me.IML_1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'BCK_FAVICON_FORM_BASICO_GERAR
        '
        Me.BCK_FAVICON_FORM_BASICO_GERAR.WorkerSupportsCancellation = True
        '
        'IML_1
        '
        Me.IML_1.ImageStream = CType(resources.GetObject("IML_1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IML_1.TransparentColor = System.Drawing.Color.Transparent
        Me.IML_1.Images.SetKeyName(0, "1334691774_unknown.ico")
        '
        'FRM_FORMULARIO_WEB_BASICO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_FORMULARIO_WEB_BASICO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BCK_FAVICON_FORM_BASICO_GERAR As System.ComponentModel.BackgroundWorker
    Friend WithEvents IML_1 As System.Windows.Forms.ImageList
End Class
