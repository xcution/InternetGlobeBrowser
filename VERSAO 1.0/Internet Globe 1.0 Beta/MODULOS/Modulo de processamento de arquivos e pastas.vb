Module Modulo_de_processamento_de_arquivos_e_pastas



    'Cria pastas, salva e le valores de arquivos de configuracao

    Public Sub proc_criar_pasta_de_configuracao() 'Cria a pasta de configuração caso não exista
        On Error Resume Next

        Dim v_pasta_existir As Boolean 'Informa se a pasta existe ou não




        'Obtendo resposta -------------------------------------------------------------------------------------------

        v_pasta_existir = My.Computer.FileSystem.DirectoryExists(V_PASTA_DE_CONFIGURACAO) 'Obtendo resposta

        '------------------------------------------------------------------------------------------------------------


        'Processando resposta ---------------------------------------------------------------------------------------

        If (v_pasta_existir = False) Then


            My.Computer.FileSystem.CreateDirectory(V_PASTA_DE_CONFIGURACAO) 'Criando pasta de configuração


        End If

        '------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_salvar_valor(ByVal v_valor As String, ByVal v_destino_de_arquivo As String) 'Salva a configuração
        On Error Resume Next


        'Criando pasta caso não exista -------------------------------------------------------------------------------

        proc_criar_pasta_de_configuracao() 'Cria a pasta de configuração caso não exista

        '-------------------------------------------------------------------------------------------------------------




        'Salvando nova configuração ----------------------------------------------------------------------------------

        My.Computer.FileSystem.WriteAllText(v_destino_de_arquivo, v_valor, False) 'Salvando configuração...

        '-------------------------------------------------------------------------------------------------------------


    End Sub

    Public Function func_ler_valor(ByVal v_destino_de_arquivo As String) 'Retorna o valor do arquivo lido
        On Error Resume Next

        Dim v_valor As String = Nothing 'Informa o valor do arquivo lido






        'Lendo valor do arquivo no HD --------------------------------------------------------------------------------

        v_valor = My.Computer.FileSystem.ReadAllText(v_destino_de_arquivo) 'Lendo valor do arquivo

        '-------------------------------------------------------------------------------------------------------------


        'Não retornar valor nulo porque nao pode ser comparado a nada ------------------------------------------------

        If (v_valor = Nothing) Then


            v_valor = "" 'Não permite retornar valor nulo


        End If

        '-------------------------------------------------------------------------------------------------------------


        'Retorno de valor -----------------------------------------------

        Return v_valor 'Retornando...

        '----------------------------------------------------------------


    End Function

    Public Sub proc_remover_arquivo(ByVal v_end_de_arquivo As String) 'Remove um arquivo
        On Error Resume Next


        'Não permite valores nulos --------------------------------------------------------------------------------------------

        If (v_end_de_arquivo <> Nothing) And (v_end_de_arquivo <> "") Then


            My.Computer.FileSystem.DeleteFile(v_end_de_arquivo) 'Removendo arquivo


        End If

        '----------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Function func_retorne_se_arquivo_existe_no_computador(ByVal v_end_de_arquivo As String) 'Retorna se o arquivo existe ou não no computador
        On Error Resume Next

        Dim v_resposta_de_analise As Boolean = My.Computer.FileSystem.FileExists(v_end_de_arquivo) 'Analizando






        'Retorno ----------------------------------------------------------------------------------------------

        Return v_resposta_de_analise 'Retorno

        '------------------------------------------------------------------------------------------------------


    End Function








































End Module
