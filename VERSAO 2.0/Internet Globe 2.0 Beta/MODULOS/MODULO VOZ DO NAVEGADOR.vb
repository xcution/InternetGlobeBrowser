Imports SpeechLib




Module MODULO_VOZ_DO_NAVEGADOR


    'OBJETOS

    Public OBJ_VOZ_LEITOR As New SpeechLib.SpVoice 'NOVA VÓZ DE LEITOR


















    'PROCEDIMENTOS DA VOZ

    Public Function FUNC_RETORNE_SE_A_VOZ_ESTA_SENDO_USADA() 'RETORNA SE A VOZ DO NAVEGADOR ESTÁ SENDO USADA OU NÃO
        On Error Resume Next


        'VERIFICANDO E RETORNANDO --------------------------------------------------------------------------------------

        If (OBJ_VOZ_LEITOR.Status.RunningState = SpeechRunState.SRSEIsSpeaking) Then


            Return True 'ESTÁ SENDO USADA


        Else


            Return False 'NÃO ESTÁ SENDO USADA


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Function

    Public Sub PROC_USAR_SINTETIZADOR_DE_FALA_HUMANA(ByVal V_CONTEUDO As String) 'USA O SINTETIZADOR DE FALA HUMANA EM MENSAGENS ETC...
        On Error Resume Next

        Dim V_VOZ As String = FUNC_LER_ARQUIVO(V_ARQUIVO_END_18) 'LENDO A VOZ SELECIONADA

        Dim V_PODE_USAR_O_RECURSO As String = FUNC_LER_ARQUIVO(V_ARQUIVO_END_19) 'INFORMA SE PODE USAR O RECURSO OU NÃO






        'VERIFICA SE PODE OU NÃO USAR O RECURSO ----------------------------------------------------------------------------------------------------------------------

        If (V_PODE_USAR_O_RECURSO = True) Then


            'LENDO O CONTEÚDO ----------------------------------------------------------------------------------------------------------------------------------------

            PROC_LER_CONTEUDO_INFORMADO_COM_A_VOZ_INSTALADA_NO_COMPUTADOR(V_CONTEUDO, False) 'LÊ O CONTEÚDO COM A VOZ INSTALADA NO COMPUTADOR

            '---------------------------------------------------------------------------------------------------------------------------------------------------------


        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_LER_CONTEUDO_INFORMADO_COM_A_VOZ_INSTALADA_NO_COMPUTADOR(ByVal V_TEXTO As String, ByVal V_PODE_PARAR_LEITURA_ATUAL As Boolean) 'LÊ O CONTEÚDO COM A VOZ INSTALADA NO COMPUTADOR
        On Error Resume Next

        Dim V_USANDO As String = FUNC_RETORNE_SE_A_VOZ_ESTA_SENDO_USADA() 'RETORNA SE A VOZ DO NAVEGADOR ESTÁ SENDO USADA OU NÃO

        Dim V_VOZ As String = FUNC_LER_ARQUIVO(V_ARQUIVO_END_18) 'LENDO A VOZ SELECIONADA

        Dim V_VOZ_NUMERO As Integer 'NÚMERO DA VOZ PADRÃO






        'VERIFICA SE ESTA SENDO USADO O SISTEMA DE VOZ, E SE PODE PARAR CASO SOLICITADO --------------------------------

        If (V_USANDO = True) And (V_PODE_PARAR_LEITURA_ATUAL = False) Then

            Exit Sub 'SAINDO

        End If

        '---------------------------------------------------------------------------------------------------------------




        'VERIFICA A VOZ ------------------------------------------------------------------------------------------------

        If (V_VOZ = Nothing) Or (V_VOZ = "") Then

            V_VOZ_NUMERO = 0 'VOZ PADRÃO

        Else

            V_VOZ_NUMERO = V_VOZ 'NUMERO DA VOZ INSTALADA

        End If

        '---------------------------------------------------------------------------------------------------------------




        'LENDO O CONTEUDO AGORA ----------------------------------------------------------------------------------------

        OBJ_VOZ_LEITOR.Resume() 'CONTINUA DE ONDE PAROU

        OBJ_VOZ_LEITOR.Speak("", SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak) 'PARANDO VOZ ANTERIOR

        OBJ_VOZ_LEITOR.Voice = OBJ_VOZ_LEITOR.GetVoices.Item(V_VOZ_NUMERO) 'VOZ SELECIONADA

        OBJ_VOZ_LEITOR.Speak(V_TEXTO, SpeechVoiceSpeakFlags.SVSFlagsAsync) 'LENDO O CONTEÚDO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_PARAR_SINTETIZADOR_DE_VOZ_HUMANA() 'PARA O SINTETIZADOR DE VOZ HUMANA
        On Error Resume Next


        'PARA VOZ ------------------------------------------------------------------------------------------------------

        If (FRM_FORMULARIO_DE_VOZ.Visible = False) Then


            OBJ_VOZ_LEITOR.Resume() 'CONTINUA DE ONDE PAROU

            OBJ_VOZ_LEITOR.Speak("", SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak) 'PARANDO VOZ ANTERIOR


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub
















    'PROCEDIMENTOS DE VOZ SECUNDARIOS

    Public Sub PROC_INFORMAR_SOBRE_CARREGAMENTO_CONCLUIDO_DA_PAGINA() 'INFORMA SOBRE O CARREGAMENTO CONCLUIDO DA PÁGINA
        On Error Resume Next

        Dim V_PODE_INFORMAR As String = FUNC_LER_ARQUIVO(V_ARQUIVO_END_23) 'CONFIGURAÇÃO DE ARQUIVO

        Dim V_URL_DO_SITE As String = OBJ_MOTOR_DE_ACAO_EM_USO.Url.Host 'OBTENDO O HOST

        Static V_ULTIMA_URL_DO_SITE As String 'ULTIMA URL DO SITE






        'SAINDO EM CASO DE NAO HOUVER URL VÁLIDA ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (OBJ_MOTOR_DE_ACAO_EM_USO.Url.Scheme = Nothing) Or (V_PODE_INFORMAR = False) Or (OBJ_MOTOR_DE_ACAO_EM_USO.Url = Nothing) Or (OBJ_MOTOR_DE_ACAO_EM_USO.Url.AbsoluteUri = "about:blank") Or (V_ULTIMA_URL_DO_SITE = OBJ_MOTOR_DE_ACAO_EM_USO.Url.Host) Then

            Exit Sub 'SAINDO

        End If

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'REMOVE PONTOS PARA MELHOR LEITURA ---------------------------------------------------------------------------------------------------------------------------------------------------------

        V_URL_DO_SITE = V_URL_DO_SITE.Replace(".", ", ponto, ") 'REMOVENDO PONTOS PARA MELHOR LEITURA

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'LENDO SOBRE O CARREGAMENTO CONCLUIDO ------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_LER_CONTEUDO_INFORMADO_COM_A_VOZ_INSTALADA_NO_COMPUTADOR(V_MS4 & V_URL_DO_SITE & V_MS5, False) 'LÊ O CONTEÚDO COM A VOZ INSTALADA NO COMPUTADOR

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ATUALIZA A ULTIMA URL DO SITE ---------------------------------------------------------------------------------

        V_ULTIMA_URL_DO_SITE = OBJ_MOTOR_DE_ACAO_EM_USO.Url.Host 'ATUALIZANDO

        '---------------------------------------------------------------------------------------------------------------


    End Sub



















End Module
