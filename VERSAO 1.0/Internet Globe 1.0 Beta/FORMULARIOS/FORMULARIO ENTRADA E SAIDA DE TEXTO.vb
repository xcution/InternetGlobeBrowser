Imports SpeechLib



Public Class FRM_FORMULARIO_ENTRADA_E_SAIDA_DE_TEXTO


    'Variáveis de processamento local

    Public V_TEXTO_REPASSADO_PELO_USUARIO_REALIZAR_LEITURA As String 'Texto repassado ao usuário para a leitura













    'Procedimentos locais

    Private Sub proc_mostrar_atualizacao_de_progresso_de_leitura() 'Mostra o progresso de leitura atual
        On Error Resume Next

        Dim v_texto_sendo_lido As String 'Armazena o progresso de leitura atual

        Dim v_posicao_da_leitura As Long 'Informa a posição da leitura





        'Inicializando valores --------------------------------------------------------------------------------------------------------------------------------------------------------------

        v_posicao_da_leitura = OBJ_VOZ_DO_NAVEGADOR.Status.InputWordPosition 'Obtendo a posição da leitura do texto

        v_texto_sendo_lido = V_TEXTO_REPASSADO_PELO_USUARIO_REALIZAR_LEITURA.Substring(0, v_posicao_da_leitura) 'Informando a posiçao atual da leitura

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Atualizando agora ---------------------------------------------------------------------------------------------

        ProgressBarItem1.Maximum = V_TEXTO_REPASSADO_PELO_USUARIO_REALIZAR_LEITURA.Length 'Valor máximo

        ProgressBarItem1.Value = v_posicao_da_leitura 'Valor atual




        'So atualizar texto se nao houver foco na caixa de texto Richtextbox ------------------------

        If (RichTextBox1.Focused = False) Then

            RichTextBox1.Text = v_texto_sendo_lido  'Atualizando texto

        End If

        '--------------------------------------------------------------------------------------------


        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_iniciar_timer_1() 'Inicia o timer 1
        On Error Resume Next

        TMR_ATUALIZADOR_1.Enabled = True 'Habilitando

    End Sub

    Private Sub proc_pause_leitura_do_texto() 'Pausa a leitura do texto
        On Error Resume Next

        OBJ_VOZ_DO_NAVEGADOR.Pause() 'Pausando...

        TMR_ATUALIZADOR_1.Enabled = False 'Pausa

    End Sub

    Private Sub proc_continuar_lendo_texto() 'Continua lendo o texto pausado
        On Error Resume Next

        OBJ_VOZ_DO_NAVEGADOR.Resume() 'Continua lendo

        TMR_ATUALIZADOR_1.Enabled = True 'Continua

    End Sub

    Private Sub proc_salvar_arquivo_de_leitura() 'Salva o arquivo de leitura
        On Error Resume Next

        Dim DLG_DIALOGO As New SaveFileDialog 'Diálogo de salvar

        Static V_NUM_ARQUIVO As Integer 'Numero do arquivo

        Dim V_NOME_DO_ARQUIVO As String = "Internet Globe som numero " & V_NUM_ARQUIVO 'Informa o nome do arquivo






        'Definindo propriedades -----------------------------------------------------------------------------------------

        DLG_DIALOGO.Filter = "Extenção do arquivo(*" & v_extencao_3 & ")|*" & v_extencao_3 'Extenção do arquivo

        DLG_DIALOGO.FileName = V_NOME_DO_ARQUIVO 'Informando o nome do arquivo

        '----------------------------------------------------------------------------------------------------------------


        'Salvando o arquivo agora ---------------------------------------------------------------------------------------

        If (DLG_DIALOGO.ShowDialog = Windows.Forms.DialogResult.OK) Then

            Me.Hide() 'Ocultando...

            Dim oVoice As New SpeechLib.SpVoice
            Dim cpFileStream As New SpeechLib.SpFileStream
            cpFileStream.Open(DLG_DIALOGO.FileName, SpeechLib.SpeechStreamFileMode.SSFMCreateForWrite, False)
            oVoice.AudioOutputStream = cpFileStream
            oVoice.Voice = oVoice.GetVoices.Item(V_VAL_CONFIG_VOZ_SELECIONADA)
            oVoice.Volume = 100
            oVoice.Speak(V_TEXTO_REPASSADO_PELO_USUARIO_REALIZAR_LEITURA, SpeechLib.SpeechVoiceSpeakFlags.SVSFDefault)
            oVoice = Nothing
            cpFileStream.Close()
            cpFileStream = Nothing
            V_NUM_ARQUIVO = V_NUM_ARQUIVO + 1 'Incrementando
            proc_chamar_mensagem_ao_usuario(V_MS_18, v_tipo_ms_1) 'Chama a janela de mensagem ao usuario

            Me.Show() 'Exibindo...

        End If

        '----------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_sair_da_janela(ByVal v_continua_lendo As Boolean) 'Sai da janela atual
        On Error Resume Next


        'Verifica se deve continuar lendo ou nao ----------------------------------------------------------------------------------------------

        If (v_continua_lendo = True) Then


            Me.Close() 'Saindo...


        Else


            V_USANDO_CAIXA_DE_ENTRADA_E_SAIDA_DE_TEXTO = False 'Informa que nao esta mais usando a caixa de texto

            OBJ_VOZ_DO_NAVEGADOR.Speak("", SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak) 'Calando voz

            Me.Close() 'Saindo...


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual
        On Error Resume Next

        Me.Opacity = V_VAL_CONFIG_TRANSPARENCIA 'Aplicando a transparencia

    End Sub



















    Private Sub TMR_ATUALIZADOR_1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMR_ATUALIZADOR_1.Tick
        On Error Resume Next

        proc_mostrar_atualizacao_de_progresso_de_leitura() 'Mostra o progresso de leitura atual

    End Sub

    Private Sub FRM_FORMULARIO_ENTRADA_E_SAIDA_DE_TEXTO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual

        proc_iniciar_timer_1() 'Inicia o timer 1

    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        On Error Resume Next

        proc_pause_leitura_do_texto() 'Pausa a leitura do texto

    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        On Error Resume Next

        proc_continuar_lendo_texto() 'Continua lendo o texto pausado

    End Sub

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.Click
        On Error Resume Next

        proc_salvar_arquivo_de_leitura() 'Salva o arquivo de leitura

    End Sub

    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem5.Click
        On Error Resume Next

        proc_sair_da_janela(False) 'Sai da janela atual

    End Sub

    Private Sub ButtonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem6.Click
        On Error Resume Next

        proc_sair_da_janela(True) 'Sai da janela atual

    End Sub

    Private Sub ButtonItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem8.Click
        On Error Resume Next

        TMR_ATUALIZADOR_1.Enabled = False 'Desabilita o timer

    End Sub

End Class