Imports Gecko




Module MODULO_DE_NAVEGACAO


    'PROCEDIMENTOS DE NAVEGAÇÃO

    Public Sub PROC_NAVEGAR(ByVal V_ENDERECO_DE_SITE As String) 'NAVEGA NO ENDEREÇO DE SITE INFORMADO
        On Error Resume Next


        'FECHA FORMULÁRIO DE HISTÓRICO ---------------------------------------------------------------------------------

        PROC_FECHAR_FORMULARIOS_DE_TRABALHO_SECUNDARIO() 'FECHA TODOS OS FORMULARIOS DE TRABALHO SECUNDÁRIO

        '---------------------------------------------------------------------------------------------------------------




        'VERIFICA SE O ENDEREÇO É VALIDO -------------------------------------------------------------------------------

        If (V_ENDERECO_DE_SITE = Nothing) Or (V_ENDERECO_DE_SITE = "") Then

            Exit Sub 'SAI DO PROCEDIMENTO E NAO DEIXA NAVEGAR

        End If

        '---------------------------------------------------------------------------------------------------------------




        'ABRINDO O ENDEREÇO INFORMADO -------------------------------------------------------------------------------------------------------------------------------------

        CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).Navigate(V_ENDERECO_DE_SITE) 'ABRINDO...

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_ACOES_BASICAS_AVANCAR_VOLTAR_ATUALIZAR_ETC(ByVal V_ACAO As Byte) 'VOLTAR, AVANÇAR, ETC.
        On Error Resume Next


        'ANALISANDO AÇÃO ---------------------------------------------------------------------------------------------------------------------------------------------

        Select Case V_ACAO


            Case 1
                CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).GoBack() 'EXECUTANDO

            Case 2
                CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).GoForward() 'EXECUTANDO

            Case 3
                CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).Stop() 'EXECUTANDO

            Case 4
                CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).Reload() 'EXECUTANDO


        End Select

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_ABRIR_PAGINA_INICIAL() 'ABRE A PÁGINA INICIAL
        On Error Resume Next

        Dim V_ENDERECO_HOME As String = FUNC_LER_ARQUIVO(V_ARQUIVO_END_1) 'LÊ CONFIG DE ARQUIVO






        'VERIFICA SE A PÁGINA INICIAL É EM BRANCO ----------------------------------------------------------------------

        If (V_ENDERECO_HOME = "about:blank") Then


            PROC_NAVEGAR(V_PASTA_DE_ARQUIVO_DE_INICIO_DE_PAGINA_DE_INICIO) 'NAVEGA NO ENDEREÇO DE SITE INFORMADO

            Exit Sub 'SAIDNO


        End If

        '---------------------------------------------------------------------------------------------------------------




        'NAO PERMITE VALOR NULO ----------------------------------------------------------------------------------------

        If (V_ENDERECO_HOME.Length > 0) Then


            PROC_NAVEGAR(V_ENDERECO_HOME) 'NAVEGA NO ENDEREÇO DE SITE INFORMADO


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub














































End Module
