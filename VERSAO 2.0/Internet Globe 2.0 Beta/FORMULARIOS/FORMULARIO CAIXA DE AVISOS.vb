Public Class FRM_FORMULARIO_CAIXA_DE_AVISOS


    'VARIÁVEIS

    Public V_MENSAGEM As String 'MENSAGEM A SER INFORMADA

    Public V_TIPO_DE_MS As Byte 'INFORMA O TIPO DE MENSAGEM

    Dim V_ENDERECO_DE_ARQUIVO_LOCAL As String 'ENDEREÇO DE ARQUIVO DE CONFIGURAÇÃO LOCAL



















    'PROCEDIMENTOS

    Private Sub PROC_INFORMAR_MENSAGEM() 'INFORMAR A MENSAGEM
        On Error Resume Next


        'SETA A MENSAGEM E A IMAGEM ------------------------------------------------------------------------------------

        LBL_MENSAGEM.Text = V_MENSAGEM 'MENSAGEM

        PIC_IMAGEM.Image = IML_IMAGENS.Images.Item(V_TIPO_DE_MS) 'TIPO DE MENSAGEM

        '---------------------------------------------------------------------------------------------------------------




        'INFORMA A MENSAGEM COM VOZ ------------------------------------------------------------------------------------

        PROC_USAR_SINTETIZADOR_DE_FALA_HUMANA(Nothing) 'USA O SINTETIZADOR DE FALA HUMANA EM MENSAGENS ETC...

        PROC_USAR_SINTETIZADOR_DE_FALA_HUMANA(V_MENSAGEM) 'USA O SINTETIZADOR DE FALA HUMANA EM MENSAGENS ETC...

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_SAIR_FORM_ATUAL() 'SAI DO FORMULARIO ATUAL
        On Error Resume Next

        Me.Close() 'FECHANDO...

    End Sub

    Private Sub PROC_ANALISA_TIPO_DE_AVISO_AO_USUARIO() 'ANALISA O TIPO DE AVISO INFORMADO AO USUÁRIO
        On Error Resume Next


        'OCULTA OU DESABILITA A OPÇÃO ---------------------------------------------------------------------------------------------------------

        CHK_1.Visible = False 'OPÇÃO INVISÍVEL

        '--------------------------------------------------------------------------------------------------------------------------------------




        'ANALISANDO ---------------------------------------------------------------------------------------------------------------------------

        Select Case V_TIPO_DE_MS


            Case 0

                CHK_1.Visible = True 'OPÇÃO VISÍVEL

                V_ENDERECO_DE_ARQUIVO_LOCAL = V_ARQUIVO_END_2 'SETANDO ENDEREÇO DE ARQUIVO DE CONFIGURAÇÃO LOCAL

                CHK_1.Checked = FUNC_LER_ARQUIVO(V_ENDERECO_DE_ARQUIVO_LOCAL) 'LENDO CONFIGURAÇÃO DE ARQUIVO











































        End Select

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub























    Private Sub FRM_FORMULARIO_CAIXA_DE_AVISOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next


        'ANALISA O TIPO DE AVISO AO USUÁRIO ----------------------------------------------------------------------------

        PROC_ANALISA_TIPO_DE_AVISO_AO_USUARIO() 'ANALISA O TIPO DE AVISO INFORMADO AO USUÁRIO

        '---------------------------------------------------------------------------------------------------------------




        'APLICA O FADIN ------------------------------------------------------------------------------------------------

        PROC_APLICAR_FADIN_EM_FORMULARIO(Me) 'APLICA O FADIN EM FORMULARIO

        '---------------------------------------------------------------------------------------------------------------




        'SOM DE SISTEMA ------------------------------------------------------------------------------------------------

        PROC_EXIBIR_SOM_DE_SISTEMA(1) 'EXIBE OS SONS INSTALADOS NO SISTEMA

        '---------------------------------------------------------------------------------------------------------------



        'INFORMANDO A MENSAGEM -----------------------------------------------------------------------------------------

        PROC_INFORMAR_MENSAGEM() 'INFORMAR A MENSAGEM

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next

        PROC_SAIR_FORM_ATUAL() 'SAI DO FORMULARIO ATUAL

    End Sub

    Private Sub FRM_FORMULARIO_CAIXA_DE_AVISOS_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next

        PROC_PARAR_SINTETIZADOR_DE_VOZ_HUMANA() 'PARA O SINTETIZADOR DE VOZ HUMANA

    End Sub

    Private Sub CHK_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_1.CheckedChanged
        On Error Resume Next


        'SALVANDO NOVA CONFIGURAÇÃO ------------------------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(CHK_1.Checked, V_ENDERECO_DE_ARQUIVO_LOCAL) 'SALVANDO CONFIGURAÇÃO DE ARQUIVO

        '---------------------------------------------------------------------------------------------------------------------------------------

    End Sub

End Class