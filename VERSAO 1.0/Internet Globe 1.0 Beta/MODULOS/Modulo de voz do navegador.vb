Imports SpeechLib




Module Modulo_de_voz_do_navegador


    'Objetos

    Public OBJ_VOZ_DO_NAVEGADOR As New SpeechLib.SpVoice 'Nova voz do sistema do navegador

    Public V_USANDO_CAIXA_DE_ENTRADA_E_SAIDA_DE_TEXTO As Boolean 'Informa se esta usando a caixa de saida e entrada de texto.















    'Procedimentos

    Public Sub proc_calar_voz_do_motor_tts() 'Cala a voz do motor tts
        On Error Resume Next


        'Verifica se esta usando a caixa de entrada e saida de texto, se tiver sair ------------------------------------

        If (V_USANDO_CAIXA_DE_ENTRADA_E_SAIDA_DE_TEXTO = True) Then

            Exit Sub 'Saindo...

        End If

        '---------------------------------------------------------------------------------------------------------------




        'Parando a voz -------------------------------------------------------------------------------------------------

        OBJ_VOZ_DO_NAVEGADOR.Speak("", SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak) 'Calando voz

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_falar_texto_repassado_recurso_de_voz(ByVal v_texto_repassado As String) 'Procedimento para leitura de texto repassado pelo usuário
        On Error Resume Next

        Dim v_resposta_da_funcao As Boolean = func_retorne_motor_tts_sendo_usado_status() 'Retorna o valor do status de leitura do motor tts






        'Informa se esta ou nao usando a caixa de entrada e saida de texto ---------------------------------------------

        V_USANDO_CAIXA_DE_ENTRADA_E_SAIDA_DE_TEXTO = True 'Esta usando

        '---------------------------------------------------------------------------------------------------------------




        'Verifica se o recurso de voz esta ativado ou não -------------------------------------------------------------------------------------

        If (V_VAL_CONFIG_USAR_RECURSO_DE_VOZ <> True) Then



            '# Pergunte ao usuario se deseja ativar o recurso de voz

            If (MsgBox(V_MS_19, MsgBoxStyle.YesNo, "Pergunta ao usuário") = MsgBoxResult.Yes) Then


                proc_salvar_valor(True, V_ARQ_CONFIG_USAR_RECURSO_DE_VOZ) 'Salva a configuração


            Else


                Exit Sub 'Saindo sem fazer nada


            End If




        End If

        '--------------------------------------------------------------------------------------------------------------------------------------




        'Analizando resposta -------------------------------------------------------------------------------------------


        'Caso esteja lendo, entao parar leitura -----------------------------------------------------------------------------------------------

        If (v_resposta_da_funcao = True) Then




            'Parando a voz -------------------------------------------------------------------------------------------------

            OBJ_VOZ_DO_NAVEGADOR.Speak("", SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak) 'Calando voz

            '---------------------------------------------------------------------------------------------------------------




            'Saindo ------------------------------------

            Exit Sub 'Saindo do procedimento...

            '-------------------------------------------




        End If

        '--------------------------------------------------------------------------------------------------------------------------------------




        'Chamando o formulário que mostra a atualização de texto ------------------------------------------------------------------------------

        proc_chamar_entrada_e_saida_de_texto(v_texto_repassado) 'Entrada e saida de texto

        '--------------------------------------------------------------------------------------------------------------------------------------




        'Selecionando a voz e lendo o texto para o usuário ------------------------------------------------------------------------------------

        OBJ_VOZ_DO_NAVEGADOR.Speak("", SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak) 'Calando voz

        OBJ_VOZ_DO_NAVEGADOR.Voice = OBJ_VOZ_DO_NAVEGADOR.GetVoices.Item(V_VAL_CONFIG_VOZ_SELECIONADA) 'Obtendo a voz selecionada

        OBJ_VOZ_DO_NAVEGADOR.Speak(v_texto_repassado, SpeechVoiceSpeakFlags.SVSFlagsAsync) 'Lendo conteúdo informado pelo usuário

        '--------------------------------------------------------------------------------------------------------------------------------------




    End Sub

    Public Sub proc_falar_texto_repassado_recurso_de_voz_direto(ByVal v_texto_repassado As String) 'Procedimento para leitura de texto repassado pelo usuário, sem saida ou entrada na caixa de texto.
        On Error Resume Next

        Dim v_resposta_da_funcao As Boolean = func_retorne_motor_tts_sendo_usado_status() 'Retorna o valor do status de leitura do motor tts






        'Verifica se esta usando a caixa de entrada e saida de texto, se tiver sair ------------------------------------

        If (V_USANDO_CAIXA_DE_ENTRADA_E_SAIDA_DE_TEXTO = True) And (v_resposta_da_funcao = True) Then

            Exit Sub 'Saindo...

        End If

        '---------------------------------------------------------------------------------------------------------------




        'Informa se esta ou nao usando a caixa de entrada e saida de texto ---------------------------------------------

        V_USANDO_CAIXA_DE_ENTRADA_E_SAIDA_DE_TEXTO = False 'Nao esta usando

        '---------------------------------------------------------------------------------------------------------------




        'Selecionando a voz e lendo o texto para o usuário ------------------------------------------------------------------------------------

        v_texto_repassado = V_VAL_CONFIG_NOME_DE_USUARIO & ", " & v_texto_repassado 'Nome do usuario e texto original

        OBJ_VOZ_DO_NAVEGADOR.Speak("", SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak) 'Calando voz

        OBJ_VOZ_DO_NAVEGADOR.Voice = OBJ_VOZ_DO_NAVEGADOR.GetVoices.Item(V_VAL_CONFIG_VOZ_SELECIONADA) 'Obtendo a voz selecionada

        OBJ_VOZ_DO_NAVEGADOR.Speak(v_texto_repassado, SpeechVoiceSpeakFlags.SVSFlagsAsync) 'Lendo conteúdo informado pelo usuário

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_falar_texto_repassado_recurso_de_voz_direto_sem_nome_usuario(ByVal v_texto_repassado As String) 'Procedimento para leitura de texto repassado pelo usuário, sem saida ou entrada na caixa de texto, sem usar o nome do usuário.
        On Error Resume Next

        Dim v_resposta_da_funcao As Boolean = func_retorne_motor_tts_sendo_usado_status() 'Retorna o valor do status de leitura do motor tts






        'Verifica se esta usando a caixa de entrada e saida de texto, se tiver sair ------------------------------------

        If (V_USANDO_CAIXA_DE_ENTRADA_E_SAIDA_DE_TEXTO = True) And (v_resposta_da_funcao = True) Then

            Exit Sub 'Saindo...

        End If

        '---------------------------------------------------------------------------------------------------------------




        'Informa se esta ou nao usando a caixa de entrada e saida de texto ---------------------------------------------

        V_USANDO_CAIXA_DE_ENTRADA_E_SAIDA_DE_TEXTO = False 'Nao esta usando

        '---------------------------------------------------------------------------------------------------------------




        'Selecionando a voz e lendo o texto para o usuário ------------------------------------------------------------------------------------

        v_texto_repassado = v_texto_repassado 'Nome do usuario e texto original

        OBJ_VOZ_DO_NAVEGADOR.Speak("", SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak) 'Calando voz

        OBJ_VOZ_DO_NAVEGADOR.Voice = OBJ_VOZ_DO_NAVEGADOR.GetVoices.Item(V_VAL_CONFIG_VOZ_SELECIONADA) 'Obtendo a voz selecionada

        OBJ_VOZ_DO_NAVEGADOR.Speak(v_texto_repassado, SpeechVoiceSpeakFlags.SVSFlagsAsync) 'Lendo conteúdo informado pelo usuário

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub





































End Module
