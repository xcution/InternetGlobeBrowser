Module MODULO_DE_NOVAS_ATUALIZACOES_E_AJUDA

    'VARIÁVEIS

    Dim V_PAGINA_DE_DOWNLOAD_DO_NAVEGADOR As String = "http://www.baixabit.com.br/IG" 'PÁGINA DE DOWNLOAD DO INTERNET GLOBE

    Dim V_PAGINA_DE_DOWNLOAD_DO_NAVEGADOR_AJUDA As String = V_PAGINA_DE_DOWNLOAD_DO_NAVEGADOR & "/Ajuda/" 'PÁGINA DE DOWNLOAD DO INTERNET GLOBE AJUDA

    Dim V_PAGINA_DE_DOWNLOAD_DO_NAVEGADOR_NOVIDADES As String = V_PAGINA_DE_DOWNLOAD_DO_NAVEGADOR & "/Novidades/" 'PÁGINA DE DOWNLOAD DO INTERNET GLOBE NOVIDADES

    Dim V_PAGINA_DE_DOWNLOAD_DO_NAVEGADOR_ATUALIZACOES As String = V_PAGINA_DE_DOWNLOAD_DO_NAVEGADOR & "/Atualizacoes/" 'PÁGINA DE DOWNLOAD DO INTERNET GLOBE ATUALIZAÇÕES




















    'PROCEDIMENTOS

    Public Sub PROC_ACAO_EXECUTAR_DO_MENU_DE_AJUDA(ByVal V_ACAO As Integer) 'AÇÃO A SER EXECUTADA DO MENU AJUDA
        On Error Resume Next

        Dim V_CONFIG_ATUAL As Boolean = FUNC_LER_ARQUIVO(V_ARQUIVO_END_2) 'CONFIGURAÇÃO QUE INFORMA SE ABRIU ABAS DEMAIS






        'NÃO PODE INFORMAR QUE ABRIU ABAS DEMAIS -------------------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_2) 'INFORMA QUE NÃO PODE INFORMAR QUE ABRIU ABAS DEMAIS

        '-----------------------------------------------------------------------------------------------------------------------------------------------




        'ADICIONA NOVA ABA -----------------------------------------------------------------------------------------------------------------------------

        PROC_NOVA_ABA_ADICIONAR() 'ADICIONA NOVA ABA

        '-----------------------------------------------------------------------------------------------------------------------------------------------




        'CONFIGURAÇÃO VOLTAR VALOR, PODE INFORMAR QUE ABRIU ABAS DEMAIS --------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(V_CONFIG_ATUAL, V_ARQUIVO_END_2) 'INFORMA QUE PODE OU NÃO INFORMAR QUE ABRIU ABAS DEMAIS

        '-----------------------------------------------------------------------------------------------------------------------------------------------




        'ABRE A PÁGINA INFORMADA AGORA -----------------------------------------------------------------------------------------------------------------

        Select Case V_ACAO


            Case 0
                OBJ_MOTOR_DE_ACAO_EM_USO.Navigate(V_PAGINA_DE_DOWNLOAD_DO_NAVEGADOR_AJUDA) 'ABRINDO PAGINA SOLICITADA


            Case 1
                OBJ_MOTOR_DE_ACAO_EM_USO.Navigate(V_PAGINA_DE_DOWNLOAD_DO_NAVEGADOR_NOVIDADES) 'ABRINDO PAGINA SOLICITADA


            Case 2
                OBJ_MOTOR_DE_ACAO_EM_USO.Navigate(V_PAGINA_DE_DOWNLOAD_DO_NAVEGADOR_ATUALIZACOES) 'ABRINDO PAGINA SOLICITADA


        End Select

        '-----------------------------------------------------------------------------------------------------------------------------------------------


    End Sub































End Module
