Imports Gecko




Module MODULO_DE_SESSAO


    'VARIÁVEIS

    Public V_PODE_SAIR_DA_SESSAO_ATUAL As String = False 'INFORMA SE PODE OU NÃO SAIR DA SESSÃO ATUAL























    'PROCEDIMENTOS

    Public Sub PROC_SALVOU_SESSAO_CORRETAMENTE() 'INFORMA QUE SALVOU A SESSÃO CORRETAMENTE
        On Error Resume Next


        'SALVA A LISTA ----------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(True, V_ARQUIVO_END_16) 'SALVA O ARQUIVO

        '------------------------------------------------------------------------------------------------------------




        'REMOVE TODOS OS ARQUIVOS DE SESSÃO -------------------------------------------------------------------------

        PROC_REMOVER_TODOS_OS_ARQUIVOS(V_PASTA_DE_ARQUIVOS_DE_SESSAO) 'REMOVE TODOS OS ARQUIVOS DA PASTA INFORMADA

        '------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_NAO_SALVOU_SESSAO_CORRETAMENTE() 'INFORMA QUE NÃO SALVOU A SESSÃO CORRETAMENTE
        On Error Resume Next


        'SALVA A LISTA ----------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_16) 'SALVA O ARQUIVO

        '------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_SALVAR_SESSAO_ATUAL(ByVal V_URL_DA_SESSAO_DO_MOTOR As String, ByVal V_TOKEN_DE_MOTOR As String) 'SALVAR A SESSÃO ATUAL
        On Error Resume Next

        Dim V_SALVAR_ONDE As String = V_PASTA_DE_ARQUIVOS_DE_SESSAO & "\" & V_TOKEN_DE_MOTOR & V_EXTENCAO_DE_ARQUIVO_4 'SALVAR SESSÃO ONDE






        'SALVA A URL DO MOTOR EM UTILIZAÇÃO --------------------------------------------------------------------------------------------------------------

        My.Computer.FileSystem.WriteAllText(V_SALVAR_ONDE, V_URL_DA_SESSAO_DO_MOTOR, False) 'SALVANDO

        '-------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_ANALISA_RESTAURAR_SESSAO_ANTERIOR() 'RESTAURA A SESSÃO ANTERIOR
        On Error Resume Next

        Dim V_ULTIMA_SESSAO_ENCERRADA_CORRETAMENTE As String = FUNC_LER_ARQUIVO(V_ARQUIVO_END_16) 'A ÚLTIMA SESSÃO FOI ENCERRADA CORRETAMENTE

        Dim V_ENDERECO_URL_A_SER_ABERTO_VIA_COMANDO As String = V_JA_EXISTE_UMA_INSTANCIA_DO_NAVEGADOR_ABERTO 'ENDEREÇO DE URL A SER ABERTO VIA COMANDO






        'REMOVE ASPAS --------------------------------------------------------------------------------------------------

        V_ENDERECO_URL_A_SER_ABERTO_VIA_COMANDO = V_ENDERECO_URL_A_SER_ABERTO_VIA_COMANDO.Replace("""", "") 'REMOVENDO

        '---------------------------------------------------------------------------------------------------------------




        'VERIFICA SE HÁ UMA INSTANCIA DO NAVEGADOR EM ABERTO -----------------------------------------------------------

        If (V_JA_EXISTE_UMA_INSTANCIA_DO_NAVEGADOR_ABERTO.Length > 0) Then




            'ABRE A PAGINA HOME ----------------------------------------------------------------------------------------

            PROC_NOVA_ABA_ADICIONAR() 'ADICIONA NOVA ABA

            PROC_NAVEGAR(V_ENDERECO_URL_A_SER_ABERTO_VIA_COMANDO) 'ABRINDO O ENDEREÇO DE URL

            '-----------------------------------------------------------------------------------------------------------




            'SAINDO ----------------------------------------------------------------------------------------------------

            Exit Sub 'SAINDO DO PROCEDIMENTO

            '-----------------------------------------------------------------------------------------------------------




        End If

        '---------------------------------------------------------------------------------------------------------------




        'VERIFICA SE SALVOU A SESSÃO CORRETAMENTE ----------------------------------------------------------------------

        If (V_ULTIMA_SESSAO_ENCERRADA_CORRETAMENTE = True) Then




            'REMOVE TODOS OS ARQUIVOS DE SESSÃO ------------------------------------------------------------------------

            PROC_REMOVER_ARQUIVOS_DE_SESSAO_ANTIGOS() 'REMOVE OS ARQUIVOS DE SESSÃO ANTIGOS

            '-----------------------------------------------------------------------------------------------------------




            'ABRE A PAGINA HOME ----------------------------------------------------------------------------------------

            PROC_NOVA_ABA_ADICIONAR() 'ADICIONA NOVA ABA

            PROC_ABRIR_PAGINA_INICIAL() 'ABRE A PÁGINA INICIAL

            '-----------------------------------------------------------------------------------------------------------




            'SAINDO ----------------------------------------------------------------------------------------------------

            Exit Sub 'SAINDO...

            '-----------------------------------------------------------------------------------------------------------




        Else




            'EXIBE O PAINEL DE RESTAURAR SESSÃO ------------------------------------------------------------------------

            PROC_EXIBIR_O_PAINEL_DE_RESTAURAR_SESSAO(True) 'EXIBE OU OCULTA O PAINEL DE RESTAURAR SESSÃO

            '-----------------------------------------------------------------------------------------------------------




        End If

        '---------------------------------------------------------------------------------------------------------------



    End Sub

    Public Sub PROC_REINICIAR_SESSAO_ANTERIOR() 'REINICIA A SESSÃO ANTERIOR
        On Error Resume Next

        Dim ARRAY_DE_ARQUIVOS As New ArrayList 'NOVO ARRAY DE ARQUIVOS






        'OBTENDO TODOS OS ARQUIVOS DA PASTA --------------------------------------------------------------------------------------------------------------------------

        PROC_OBTER_TODOS_OS_ARQUIVOS(V_PASTA_DE_ARQUIVOS_DE_SESSAO, ARRAY_DE_ARQUIVOS, "*.txt*") 'OBTEM TODOS OS ARQUIVOS

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA SE HÁ ITENS PARA SEREM RESTAURADOS NA SESSÃO -------------------------------------------------------------------------------------------------------

        If (ARRAY_DE_ARQUIVOS.Count = 0) Then




            'ABRE A PAGINA HOME --------------------------------------------------------------------------------------------------------------------------------------

            PROC_NOVA_ABA_ADICIONAR() 'ADICIONA NOVA ABA

            PROC_ABRIR_PAGINA_INICIAL() 'ABRE A PÁGINA INICIAL

            Exit Sub 'SAINDO DO PROCEDIMENTO

            '---------------------------------------------------------------------------------------------------------------------------------------------------------




        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'NÃO EXIBIR MENSAGEM DE ABRIU ABAS DEMAIS --------------------------------------------------------------------------------------------------------------------

        PROC_SESSAO_DESABILITA_ABRIR_ABAS_DEMAIS() 'QUANDO FOR RESTAURAR UMA SESSÃO ANTERIOR, DESABILITAR TEMPORARIAMENTE O ABRIR ABAS DEMAIS

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'LENDO ARQUIVOS DE SESSAO ------------------------------------------------------------------------------------------------------------------------------------

        For Each V_ITEM_DE_PASTA In ARRAY_DE_ARQUIVOS


            Dim V_END_DE_ARQUIVO As String = V_ITEM_DE_PASTA 'ENDEREÇO DO ARQUIVO DE SESSÃO

            Dim V_URL_A_ABRIR As String 'URL A SER ABERTA NA SESSAO






            'LENDO CONTEUDO DE ARQUIVO DE SESSAO ---------------------------------------------------------------------------------------------------------------------

            V_URL_A_ABRIR = FUNC_LER_ARQUIVO(V_END_DE_ARQUIVO) 'LENDO CONTEUDO

            '---------------------------------------------------------------------------------------------------------------------------------------------------------




            'ABRINDO A URL AGORA -------------------------------------------------------------------------------------------------------------------------------------

            If (V_URL_A_ABRIR.Length <> 0) And (V_URL_A_ABRIR <> "about:blank") Then


                PROC_NOVA_ABA_ADICIONAR() 'ADICIONA UMA NOVA ABA

                PROC_NAVEGAR(V_URL_A_ABRIR) 'ABRINDO URL DE SESSÃO


            End If

            '---------------------------------------------------------------------------------------------------------------------------------------------------------




        Next

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'INICIAR A NOVA SESSAO ---------------------------------------------------------------------------------------------------------------------------------------

        PROC_INICIALIZAR_INICIAR_NOVA_SESSAO_AGORA() 'AO INICIALIZAR, INICIAR A NOVA SESSÃO

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'REMOVE OS ARQUIVOS DE SESSÃO ANTIGOS ------------------------------------------------------------------------------------------------------------------------

        PROC_REMOVER_ARQUIVOS_DE_SESSAO_ANTIGOS() 'REMOVE OS ARQUIVOS DE SESSÃO ANTIGOS

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




    End Sub

    Public Sub PROC_INICIALIZAR_INICIAR_NOVA_SESSAO_AGORA() 'AO INICIALIZAR, INICIAR A NOVA SESSÃO
        On Error Resume Next

        PROC_NAO_SALVOU_SESSAO_CORRETAMENTE() 'INFORMA QUE NÃO SALVOU A SESSÃO CORRETAMENTE

    End Sub

    Public Sub PROC_REMOVER_ARQUIVOS_DE_SESSAO_ANTIGOS() 'REMOVE OS ARQUIVOS DE SESSÃO ANTIGOS
        On Error Resume Next


        'REMOVE ARQUIVOS DE SESSÃO ANTIGOS E INICIA UMA NOVA SESSÃO ---------------------------------------------------------------------------

        PROC_REMOVER_TODOS_OS_ARQUIVOS(V_PASTA_DE_ARQUIVOS_DE_SESSAO) 'REMOVE TODOS OS ARQUIVOS DA PASTA INFORMADA

        PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_16) 'SALVA O ARQUIVO

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_SESSAO_DESABILITA_ABRIR_ABAS_DEMAIS() 'QUANDO FOR RESTAURAR UMA SESSÃO ANTERIOR, DESABILITAR TEMPORARIAMENTE O ABRIR ABAS DEMAIS
        On Error Resume Next

        PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_2) 'INFORMA QUE NÃO PODE INFORMAR AO USUÁRIO QUE ABRIU ABAS DEMAIS.

    End Sub

    Public Sub PROC_EXIBIR_O_PAINEL_DE_RESTAURAR_SESSAO(ByVal V_EXIBIR As Boolean) 'EXIBE OU OCULTA O PAINEL DE RESTAURAR SESSÃO
        On Error Resume Next

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PN_SESSAO.Visible = V_EXIBIR 'OCULTA OU EXIBE

    End Sub































End Module
