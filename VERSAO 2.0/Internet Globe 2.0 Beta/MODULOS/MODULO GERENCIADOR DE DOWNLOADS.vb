Imports System.Net
Imports System.ComponentModel
Imports System.IO




Module MODULO_GERENCIADOR_DE_DOWNLOADS


    'VARIAVEIS DE DOWNLOAD

    Public V_ENDERECO_TEMPORARIO_DE_CADA_DOWNLOAD As String 'ENDEREÇO TEMPORARIO DE CADA DOWNLOAD
























    'PROCEDIMENTOS PARA INICIO DE DOWNLOAD

    Public Function FUNC_RETORNE_TIPO_DE_ARQUIVO_DE_DOWNLOAD(ByVal V_URL As String) 'RETORNA O TIPO DE ARQUIVO DE DOWNLOAD
        On Error Resume Next


        'REQUISICAO PRA OBTER TAMANHO DE DOWNLOAD SEM ADDRANGE ---------------------------------------------------------------------------------------------------------------------------------

        Dim V_URL_ORIGEM As New Uri(V_URL) 'NOVA URL DE ORIGEM

        Dim V_REQUISICAO As WebRequest 'REQUISIÇÃO

        Dim V_RESPOSTA As WebResponse 'RESPOSTA

        Dim V_RETORNO As String = "" 'RETORNO DE ARQUIVO

        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA SE A URL FOI INFORMADA -------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_URL.Length = 0) Then




            Return V_RETORNO 'RETORNO

            Exit Function 'SAIDA




        End If

        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'SAINDO DA FUNÇÃO ----------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_URL_ORIGEM.Scheme = "ftp") Then


            Dim ARRAY_LISTA_NAO_BAIXAR As New ArrayList 'LISTA DE FORMATOS DE ARQUIVOS

            Dim V_EXTENCAO_ATUAL As String = Path.GetExtension(V_URL).ToLower 'EXTENÇÃO DE ARQUIVO ATUAL






            'ATUALIZANDO --------------------------------------------------------------------------------------------

            ARRAY_LISTA_NAO_BAIXAR.Add(".htm") 'ATUALIZANDO...
            ARRAY_LISTA_NAO_BAIXAR.Add(".html") 'ATUALIZANDO...
            ARRAY_LISTA_NAO_BAIXAR.Add(".txt") 'ATUALIZANDO...
            ARRAY_LISTA_NAO_BAIXAR.Add(".rtf") 'ATUALIZANDO...
            ARRAY_LISTA_NAO_BAIXAR.Add(".rtx") 'ATUALIZANDO...

            '--------------------------------------------------------------------------------------------------------




            'VERIFICANDO SE ESTÁ NA LISTA ---------------------------------------------------------------------------

            If (ARRAY_LISTA_NAO_BAIXAR.IndexOf(V_EXTENCAO_ATUAL) = -1) And (V_EXTENCAO_ATUAL.Length > 0) Then



                V_RETORNO = "application/" 'CODIGO PARA BAIXAR


            Else


                V_RETORNO = "" 'CODIGO PARA NÃO BAIXAR



            End If

            '--------------------------------------------------------------------------------------------------------





            Return V_RETORNO 'RETORNO

            Exit Function 'SAINDO DA FUNÇÃO


        End If

        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'EXECUTA A REQUISIÇÃO-------------------------------------------------------------------------------------------------------------------------------------------------------------------

        V_REQUISICAO = WebRequest.Create(V_URL_ORIGEM.AbsoluteUri) 'CRIANDO A REQUISIÇÃO

        V_REQUISICAO.Method = "HEAD" 'APENAS LEITURA

        V_REQUISICAO.Proxy = Nothing 'NAO USA PROXY

        V_RESPOSTA = V_REQUISICAO.GetResponse 'RESPOSTA

        V_RETORNO = V_RESPOSTA.ContentType 'RETORNO DE ARQUIVO

        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------






        'FECHA RESPOSTA E DADOS ABERTOS PARA NAO DAR ERRO --------------------------------------------------------------------------------------------------------------------------------------

        V_RESPOSTA.Close() 'FECHA RESPOSTA

        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'RETORNO DE ARQUIVO --------------------------------------------------------------------------------------------------------------------------------------------------------------------

        Return V_RETORNO 'RETORNO

        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Function

    Public Sub PROC_INICIAR_NOVO_TESTE_DE_DOWNLOAD(ByVal V_URL As String) 'INICIA O NOVO TESTE DE DOWNLOAD
        On Error Resume Next


        'INICIA O NOVO BACKGROUNDWORKER DE DOWNLOAD -----------------------------------------------------------------------------------------------------------

        BCK_EXECUTADOR_DE_DOWNLOAD = New BackgroundWorker 'NOVO BACKGROUNDWORKER

        AddHandler BCK_EXECUTADOR_DE_DOWNLOAD.DoWork, AddressOf PROC_BAIXAR_DOWNLOAD_AGORA 'PUXA O DOWNLOAD PROPRIAMENTE DITO

        AddHandler BCK_EXECUTADOR_DE_DOWNLOAD.RunWorkerCompleted, AddressOf PROC_BAIXAR_DOWNLOAD_COMPLETO 'INFORMA QUE O DOWNLOAD ESTÁ COMPLETO

        '------------------------------------------------------------------------------------------------------------------------------------------------------




        'DADOS DE CADA DOWNLOAD --------------------------------------------------------------------------------------------------------------------------------

        V_ENDERECO_TEMPORARIO_DE_CADA_DOWNLOAD = V_URL 'REPASSA A URL DE TESTE INICIAL

        BCK_EXECUTADOR_DE_DOWNLOAD.RunWorkerAsync() 'RODANDO O PROCESSO

        '------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_RODAR_GERENCIADORES_DE_DOWNLOAD(ByVal V_URL As String) 'RODA OS GERENCIADORES DE DOWNLOAD
        On Error Resume Next

        Dim V_PASTA_DOWNLOAD As String = FUNC_LER_ARQUIVO(V_ARQUIVO_END_6) 'PASTA DE DOWNLOAD

        Dim V_COMANDO As String 'COMANDO PARA NOVO DOWNLOAD






        'PASTA DE DOWNLOAD --------------------------------------------------------------------------------------------------------------------

        If (V_PASTA_DOWNLOAD.Length = 0) Then


            V_PASTA_DOWNLOAD = My.Computer.FileSystem.SpecialDirectories.Desktop 'DESKTOP


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------




        'GERA O COMANDO A SER REPASSADO -------------------------------------------------------------------------------------------------------

        V_COMANDO = V_URL & vbCrLf & V_PASTA_DOWNLOAD 'COMANDO PARA NOVO DOWNLOAD

        '--------------------------------------------------------------------------------------------------------------------------------------




        'JANELA DE NOVO DOWNLOAD --------------------------------------------------------------------------------------------------------------

        If (V_URL.Length = 0) Then


            Process.Start(V_PASTA_DE_INSTALACAO_ATUAL & "\Complementos\Downloader\M7SLMGDOWNCLIENTE.exe", Nothing) 'NOVO DOWNLOAD


        Else


            Process.Start(V_PASTA_DE_INSTALACAO_ATUAL & "\Complementos\Downloader\M7SLMGDOWNCLIENTE.exe", V_COMANDO) 'NOVO DOWNLOAD


        End If
        
        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub











































End Module
