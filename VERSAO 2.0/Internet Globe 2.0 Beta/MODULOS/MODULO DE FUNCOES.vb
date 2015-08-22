Imports SpeechLib
Imports Gecko
Imports System.IO




Module MODULO_DE_FUNCOES


    'VARIÁVEIS

    Public V_TAMANHO_DA_PAGINA_WEB_PADRAO As Integer = 768 'TAMANHO NORMAL DE UMA PÁGINA WEB

















    'OBTER IMAGENS DO MOTOR

    Public Function FUNC_RETORNE_IMAGEM_DE_MOTOR_GECKOFX_COMPLETO() 'RETORNA A IMAGEM DO MOTOR GECKOFX
        On Error Resume Next

        Dim V_ALTURA As Integer = CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).Document.Body.ClientHeight 'ALTURA

        Dim V_LARGURA As Integer = CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).Document.Body.ClientWidth 'LARGURA

        Dim V_TAMANHO_DA_PAGINA As Size 'TAMANHO DA PAGINA REAL

        Dim OBJ_IMAGEM_BMP As Bitmap 'IMAGEM BITMAP

        Dim V_QUANTIDADE_DE_DIVISOES_POSSIVEIS As Integer = (V_ALTURA / V_TAMANHO_DA_PAGINA_WEB_PADRAO) 'Obtendo a quantidade de divisoes da imagem






        'Não permite imagem menor que o valor informado abaixo ser divida em duas partes -----------------------

        If (V_ALTURA <> V_TAMANHO_DA_PAGINA_WEB_PADRAO) And (V_QUANTIDADE_DE_DIVISOES_POSSIVEIS = 1) Then


            V_ALTURA = V_TAMANHO_DA_PAGINA_WEB_PADRAO 'Define como tamanho padrão


        End If

        '-------------------------------------------------------------------------------------------------------




        'DEFININDO O TAMANHO REAL DA PÁGINA ------------------------------------------------------

        V_TAMANHO_DA_PAGINA = New Size(V_LARGURA, V_ALTURA) 'TAMANHO REAL DA PÁGINA

        '-----------------------------------------------------------------------------------------




        'SETANDO MOTOR PARA NENHUM PREENCHIMENTO DE TAMANHO ----------------------------------------------------------------------------------------------------------

        CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).Dock = DockStyle.None 'PREENCHIMENTO NENHUM

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'NOVO TAMANHO DE PÁGINA --------------------------------------------------------------------------------------------------------------------------------------

        CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).Size = New Size(V_TAMANHO_DA_PAGINA) 'NOVO TAMANHO DE PÁGINA

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'CRIANDO NVOA IMAGEM --------------------------------------------------------

        OBJ_IMAGEM_BMP = New Bitmap(V_LARGURA, V_ALTURA) 'CRIANDO NOVA IMAGEM

        '----------------------------------------------------------------------------




        'GERANDO IMAGEM DO MOTOR ------------------------------------------------------------------------------------------------------------------------------------------------------------

        CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).DrawToBitmap(OBJ_IMAGEM_BMP, New Rectangle(0, 0, V_LARGURA, V_ALTURA)) 'GERANDO...

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'RESTAURA O TAMANHO ORIGINAL DO MOTOR ---------------------------------------------------------------------------------------------------------------

        CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).Dock = DockStyle.Fill 'TAMANHO ORIGINAL DO MOTOR

        '----------------------------------------------------------------------------------------------------------------------------------------------------




        'RETORNO ---------------------------

        Return OBJ_IMAGEM_BMP 'RETORNO...

        '-----------------------------------





    End Function

    Public Function FUNC_GERAR_FAVICON_DA_URL(ByVal V_URL As String) As Image  'GERA O FAVICON DA URL INFORMADA
        On Error Resume Next

        Dim URI As New Uri(V_URL) 'NOVA URL DE ENDEREÇO REPASSADO

        Dim V_FAVICON_URL As String = "http://" & URI.Host & "/favicon.ico" 'OBTEM O ENDEREÇO DE FAVICON






        'BAIXANDO A IMAGEM ---------------------------------------------------------------------------------------------

        Dim REQUEST As System.Net.WebRequest = System.Net.HttpWebRequest.Create(V_FAVICON_URL) 'REQUISICAO

        Dim RESPOSTA As System.Net.WebResponse = REQUEST.GetResponse 'RESPOSTA

        Dim STREAM As System.IO.Stream = RESPOSTA.GetResponseStream() 'DADOS

        Dim FAVICON_IMAGEM As Image = Image.FromStream(STREAM) 'IMAGEM

        '---------------------------------------------------------------------------------------------------------------




        'FECHA CONEXAO COM RESPOSTA ------------------------------------------------------------------------------------

        RESPOSTA.Close() 'FECHANDO

        STREAM.Close() 'FECHANDO FLUXO DE DADOS

        '---------------------------------------------------------------------------------------------------------------




        'GERA IMAGEM MINIATURA DO FAVICON ------------------------------------------------------------------------------

        FAVICON_IMAGEM = FAVICON_IMAGEM.GetThumbnailImage(16, 16, Nothing, Nothing) 'Miniatura

        '---------------------------------------------------------------------------------------------------------------




        'RETORNO -------------------------------------------------------------------------------------------------------

        Return FAVICON_IMAGEM 'Retorno de imagem

        '---------------------------------------------------------------------------------------------------------------


    End Function

    Public Function FUNC_RETORNE_END_SITE_EM_VISUALIZACAO() 'RETORNA O ENDEREÇO DO SITE EM VISUALIZAÇÃO
        On Error Resume Next

        Dim V_RETORNO As String = CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).Url.AbsoluteUri 'OBTENDO






        'RETORNO ------------------------------

        Return V_RETORNO

        '--------------------------------------


    End Function

    Public Function FUNC_RETORNE_TITULO_SITE_EM_VISUALIZACAO() 'RETORNA O TITULO DO SITE EM VISUALIZAÇÃO
        On Error Resume Next

        Dim V_RETORNO As String = CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).DocumentTitle 'OBTENDO






        'RETORNO ------------------------------

        Return V_RETORNO

        '--------------------------------------


    End Function

    Public Function FUNC_RETORNE_FAVICON_SALVO_EM_PASTA_VIA_HOST(ByVal V_PASTA_DE_FAVICON As String, ByVal V_HOST As String) 'RETORNA O FAVICON JÁ SALVO NO HD VIA HOST DO SITE
        On Error Resume Next

        Dim OBJ_IMAGEM As Bitmap 'IMAGEM






        'LENDO IMAGEM --------------------------------------------------------------------------------------------------

        OBJ_IMAGEM = New Bitmap(Image.FromFile(V_PASTA_DE_FAVICON & "\" & V_HOST & V_EXTENCAO_DE_ARQUIVO_3)) 'OBTENDO

        '---------------------------------------------------------------------------------------------------------------



        'RETORNO --------------------------

        Return OBJ_IMAGEM

        '----------------------------------


    End Function

    Public Function FUNC_REMOVE_CARACTERES_ESPECIAIS(ByVal V_VALOR As String) 'REMOVE OS CARACTERES ESPECIAIS
        On Error Resume Next


        'REMOVE VALORES INVÁLIDOS -------------------------------------

        V_VALOR = V_VALOR.Replace("\", Nothing) 'REMOVENDO
        V_VALOR = V_VALOR.Replace("/", Nothing) 'REMOVENDO
        V_VALOR = V_VALOR.Replace(":", Nothing) 'REMOVENDO
        V_VALOR = V_VALOR.Replace("*", Nothing) 'REMOVENDO
        V_VALOR = V_VALOR.Replace("?", Nothing) 'REMOVENDO
        V_VALOR = V_VALOR.Replace("""", Nothing) 'REMOVENDO
        V_VALOR = V_VALOR.Replace("<", Nothing) 'REMOVENDO
        V_VALOR = V_VALOR.Replace(">", Nothing) 'REMOVENDO
        V_VALOR = V_VALOR.Replace("|", Nothing) 'REMOVENDO

        '--------------------------------------------------------------




        'RETORNO ------------------------------------------------------

        Return V_VALOR 'RETORNO...

        '--------------------------------------------------------------

    End Function

    Public Function FUNC_RETORNE_NOME_DE_DOWNLOAD(ByVal V_URL_DE_DOWN As String) 'OBTEM O NOME DO DOWNLOAD PELA URL
        On Error Resume Next

        Dim V_NOME_DE_DOWNLOAD As String = V_URL_DE_DOWN.Substring(V_URL_DE_DOWN.LastIndexOf("/") + 1, (V_URL_DE_DOWN.Length - V_URL_DE_DOWN.LastIndexOf("/") - 1)) 'OBTENDO O NOME DO DOWNLOAD






        'VERIFICA SE O NOME DO DOWNLOAD CONTÉM PONTO INDICANDO EXTENÇÃO DE ARQUIVO -------------------------------------

        If (V_NOME_DE_DOWNLOAD.Contains(".") = False) Then


            V_NOME_DE_DOWNLOAD = Nothing 'NADA A BAIXAR


        Else


            V_NOME_DE_DOWNLOAD = "Baixar " & V_NOME_DE_DOWNLOAD 'INFORME O NOME DO DOWNLOAD A BAIXAR


        End If

        '---------------------------------------------------------------------------------------------------------------




        'RETORNO --------------------------------------------

        Return V_NOME_DE_DOWNLOAD 'RETORNO...

        '----------------------------------------------------


    End Function

    Public Function FUNC_RETORNE_ESPACO_EM_DISCO(ByVal V_DISCO As String) 'RETORNA O ESPAÇO EM DISCO
        On Error Resume Next


        Dim V_EAPACO_EM_DISCO As Long = My.Computer.FileSystem.GetDriveInfo(V_DISCO).TotalFreeSpace 'OBTENDO O TAMANHO EM DISCO






        'RETORNO --------------------------------------------

        Return V_EAPACO_EM_DISCO 'RETORNO...

        '----------------------------------------------------


    End Function

    Public Function FUNC_RETORNE_SITE_PODE_ABRIR_POPUP(ByVal V_END_DE_SITE As String) 'RETORNA SE O SITE PODE OU NÃO ABRIR UMA POPUP
        On Error Resume Next

        Dim V_LISTAGEM As String = FUNC_LER_ARQUIVO(V_ARQUIVO_END_15) 'LÊ CONFIG DE ARQUIVO

        Dim V_URL As New Uri(V_END_DE_SITE) 'INFORMA O ENDEREÇO DO SITE A SER COMPARADO






        'POP-UP --------------------------------------------------------------------------------------------------------

        If (FUNC_LER_ARQUIVO(V_ARQUIVO_END_7) = True) Then


            Return False 'NÃO PODE ABRIR POPUP

            Exit Function 'SAI DA FUNÇÃO


        End If

        '---------------------------------------------------------------------------------------------------------------




        'POP-UP --------------------------------------------------------------------------------------------------------

        If (FUNC_LER_ARQUIVO(V_ARQUIVO_END_8) = True) Then


            Return True 'INFORMA QUE PODE ABRIR SEMPRE

            Exit Function 'SAI DA FUNÇÃO


        End If

        '---------------------------------------------------------------------------------------------------------------




        'POP-UP --------------------------------------------------------------------------------------------------------

        If (FUNC_LER_ARQUIVO(V_ARQUIVO_END_9) = True) Then




            'VERIFICA SE O HOST INFORMADO ESTÁ OU NAO NA LISTA DE PERMITIDOS -------------------------------------------

            If (V_LISTAGEM.Contains(V_URL.Host) = True) Then




                Return True 'INFORMA QUE PODE ABRIR SEMPRE

                Exit Function 'SAI DA FUNÇÃO




            Else




                Return False 'NÃO PODE ABRIR POPUP

                Exit Function 'SAI DA FUNÇÃO




            End If

            '---------------------------------------------------------------------------------------------------------------




        End If

        '---------------------------------------------------------------------------------------------------------------


    End Function

    Public Function FUNC_RETORNE_IMAGEM_DE_MOTOR_GECKOFX_APENAS_VISUALIZACAO(ByVal OBJ_MOTOR_REPASSADO As Gecko.GeckoWebBrowser) 'RETORNA SOMENTE A PARTE EM VISUALIZAÇÃO DO MOTOR
        On Error Resume Next

        Dim V_ALTURA As Integer = CType(OBJ_MOTOR_REPASSADO, Gecko.GeckoWebBrowser).Height 'ALTURA

        Dim V_LARGURA As Integer = CType(OBJ_MOTOR_REPASSADO, Gecko.GeckoWebBrowser).Document.Body.ClientWidth 'LARGURA

        Dim OBJ_IMAGEM_BMP As Bitmap 'IMAGEM BITMAP






        'CRIANDO NVOA IMAGEM ----------------------------------------------------------------------------------------------------------------------------------------------------------------

        OBJ_IMAGEM_BMP = New Bitmap(V_LARGURA, V_ALTURA) 'CRIANDO NOVA IMAGEM

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'GERANDO IMAGEM DO MOTOR ------------------------------------------------------------------------------------------------------------------------------------------------------------

        CType(OBJ_MOTOR_REPASSADO, Gecko.GeckoWebBrowser).DrawToBitmap(OBJ_IMAGEM_BMP, New Rectangle(0, 0, V_LARGURA, V_ALTURA)) 'GERANDO...

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'RESTAURA O TAMANHO ORIGINAL DO MOTOR -----------------------------------------------------------------------------------------------------------------------------------------------

        CType(OBJ_MOTOR_REPASSADO, Gecko.GeckoWebBrowser).Dock = DockStyle.Fill 'TAMANHO ORIGINAL DO MOTOR

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'RETORNO ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        Return OBJ_IMAGEM_BMP 'RETORNO...

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Function

    Public Function FUNC_RETORNE_INDEX_DE_FORMULARIO(ByVal OBJ_FORMULARIO As Object) 'RETORNA O INDEX DO FORMULARIO REPASSADO
        On Error Resume Next


        'RETORNA O INDEX DO FORMULÁRIO ABERTO, OU SEJA A ABA EM FOCO -------------------------------------------------------------------------------------------------

        Return FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.TabPages.IndexOf(OBJ_FORMULARIO) + 1 'INDEX DE ABA SELECIONADA

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Function

    Public Function FUNC_RETORNE_TODAS_AS_VOZES_INSTALADAS() 'RETORNA TODAS AS VOZES INSTALADAS NO SISTEMA
        On Error Resume Next

        Dim OBJ_NOVA_VOZ As New SpeechLib.SpVoice 'NOVA INSTANCIA DE VOZ

        Dim TOKEN_DE_VOZES As ISpeechObjectToken 'VOZES

        Dim V_VAL_VOZES_NO_SISTEMA As String = Nothing 'VOZES DO SISTEMA






        'PROCURANDO VOZES ---------------------------------------------------------------------------------------------------------------------

        For Each vozes In OBJ_NOVA_VOZ.GetVoices 'Buscando vozes


            V_VAL_VOZES_NO_SISTEMA = V_VAL_VOZES_NO_SISTEMA & vozes.GetDescription & V_SEPARADOR_DE_STRINGS 'Adicionando vozes


        Next

        '--------------------------------------------------------------------------------------------------------------------------------------




        'RETORNO -----------------------------------------

        Return V_VAL_VOZES_NO_SISTEMA 'RETORNO

        '-------------------------------------------------


    End Function

    Public Function FUNC_RETORNE_SE_ARQUIVO_EXISTE(ByVal V_ARQUIVO As String) 'RETORNA SE O ARQUIVO EXISTE OU NÃO
        On Error Resume Next


        'VERIFICA SE O ARQUIVO EXISTE OU NÃO --------------------------------------------------------------------------------------------------------------

        If (FUNC_RETORNA_SE_O_ARQUIVO_EXISTE_OU_NAO(V_ARQUIVO) = False) Then


            Dim V_ARQUIVO_NOME As String = "Problema com o arquivo: " & My.Computer.FileSystem.GetFileInfo(V_ARQUIVO).Name 'NOME DE ARQUIVO

            V_ARQUIVO_NOME = V_ARQUIVO_NOME.Substring(0, V_ARQUIVO_NOME.Length - 4) & "." & vbCrLf & vbCrLf 'REMOVE EXTENÇÃO DE ARQUIVO

            PROC_CHAMAR_JANELA_DE_AVISOS(V_ARQUIVO_NOME & V_MS3, 1) 'FORMULARIO DE AVISOS

            Return False 'NÃO ARQUIVO EXISTE


        Else


            Return True 'VERDADEIRO ARQUIVO EXISTE


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------------------


    End Function

    Public Function FUNC_RETORNA_URL_COM_PROTOCOLO(ByVal V_URL_REPASSADA As String) 'RETORNA A URL COM O PROTOCOLO
        On Error Resume Next

        Dim V_URL As New Uri(V_URL_REPASSADA) 'NOVA URL






        'VERIFICA A EXISTENCIA DE PROTOCOLO ----------------------------------------------------------------------------

        If (V_URL.Scheme = Nothing) Then


            Return "http://" & V_URL_REPASSADA  'ADICIONA O PROTOCOLO


        Else


            Return V_URL_REPASSADA 'RETORNA URL NORMAL


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Function

    Public Function FUNC_RETORNA_O_PROTOCOLO_DE_URL(ByVal V_URL As String) 'RETORNA O TIPO DE PROTOCOLO DA URL
        On Error Resume Next

        Dim V_URL_PROTOCOLO As New Uri(V_URL) 'NOVA URL






        'RETORNA O PROTOCOLO -------------------------------------------------------------------------------------------

        Return V_URL_PROTOCOLO.Scheme 'RETORNO

        '---------------------------------------------------------------------------------------------------------------


    End Function

    Public Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer 'FUNÇÃO PARA SETAR IMAGEM COMO PLANO DE FUNDO DE AREA DE TRABALHO

    Public Function FUNC_RETORNE_SELECAO_DE_TEXTO_EM_MOTOR_EM_USO() As String  'RETORNA O TEXTO SELECIONADO EM MOTOR EM USO
        On Error Resume Next

        Dim V_RETORNO As String 'RETORNO






        'RETORNO DE TEXTO SELECIONADO ----------------------------------------------------------------------------------

        V_RETORNO = OBJ_MOTOR_DE_ACAO_EM_USO.Window.Selection.ToString 'RETORNO

        Return V_RETORNO 'RETORNO

        '---------------------------------------------------------------------------------------------------------------


    End Function

    Public Function FUNC_RETORNE_ARRAY_DE_TODAS_AS_ABAS_ABERTAS() As Array 'RETORNA O ARRAY DE TODAS AS ABAS ABERTAS
        On Error Resume Next

        Dim V_QUANTIDADE_DE_ABAS As Integer = My.Application.OpenForms.Count 'QUANTIDADE DE ABAS ABERTAS

        Dim V_CONTADOR As Integer = 0 'CONTADOR INICIAL

        Dim ARRAY_ABAS_ABERTAS As Array 'ARRAY COM TODAS AS ABAS ABERTAS

        Dim V_STRING_ABAS_ABERTAS As String = Nothing 'STRING COM TODAS AS ABAS ABERTAS






        'VARRENDO E ATUALIZANDO IMAGENS ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        For V_CONTADOR = V_CONTADOR To V_QUANTIDADE_DE_ABAS


            Dim OBJ_MOTOR As New Gecko.GeckoWebBrowser 'MOTOR WEB

            Dim OBJ_IMAGEM As Image 'IMAGEM DE MOTOR DE ABAS ABERTAS

            Dim V_NOME_DO_MOTOR As String 'INFORMA O NOME DO MOTOR






            'SETA O MOTOR, OBTÉM IMAGEM E ADICIONA A IMAGEM -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            OBJ_MOTOR = DirectCast(My.Application.OpenForms.Item(V_CONTADOR).Controls.Item(0), Gecko.GeckoWebBrowser) 'OBTENDO DADOS DO MOTOR

            V_NOME_DO_MOTOR = OBJ_MOTOR.Name 'OBTÉM O NOME DO MOTOR

            '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'VERIFICA SE O NOME DO MOTOR É NÚMERICO ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            If (IsNumeric(V_NOME_DO_MOTOR) = True) And (V_NOME_DO_MOTOR.Length > 0) Then


                V_STRING_ABAS_ABERTAS = V_STRING_ABAS_ABERTAS & V_NOME_DO_MOTOR & vbCrLf 'ATUALIZANDO VALORES


            End If

            '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        Next


        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------





        'SEPARA STRING EM ARRAY -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        ARRAY_ABAS_ABERTAS = Split(V_STRING_ABAS_ABERTAS, vbCrLf) 'SEPARANDO

        Return ARRAY_ABAS_ABERTAS 'RETORNO

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Function

    Public Function FUNC_RETORNE_ARRAY_DE_TODAS_AS_ABAS_ABERTAS_TITULO() As Array 'RETORNA O ARRAY DE TODAS AS ABAS ABERTAS TITULO
        On Error Resume Next

        Dim V_QUANTIDADE_DE_ABAS As Integer = My.Application.OpenForms.Count 'QUANTIDADE DE ABAS ABERTAS

        Dim V_CONTADOR As Integer = 0 'CONTADOR INICIAL

        Dim ARRAY_ABAS_ABERTAS As Array 'ARRAY COM TODAS AS ABAS ABERTAS

        Dim V_STRING_ABAS_ABERTAS As String = Nothing 'STRING COM TODAS AS ABAS ABERTAS






        'VARRENDO E ATUALIZANDO IMAGENS -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        For V_CONTADOR = V_CONTADOR To V_QUANTIDADE_DE_ABAS


            Dim OBJ_MOTOR As New Gecko.GeckoWebBrowser 'MOTOR WEB

            Dim OBJ_IMAGEM As Image 'IMAGEM DE MOTOR DE ABAS ABERTAS

            Dim V_NOME_DO_MOTOR As String 'INFORMA O NOME DO MOTOR






            'SETA O MOTOR, OBTÉM IMAGEM E ADICIONA A IMAGEM -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            OBJ_MOTOR = DirectCast(My.Application.OpenForms.Item(V_CONTADOR).Controls.Item(0), Gecko.GeckoWebBrowser) 'OBTENDO DADOS DO MOTOR

            V_NOME_DO_MOTOR = OBJ_MOTOR.Name 'OBTÉM O NOME DO MOTOR

            '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'VERIFICA SE O NOME DO MOTOR É NÚMERICO -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            If (IsNumeric(V_NOME_DO_MOTOR) = True) And (V_NOME_DO_MOTOR.Length > 0) Then

                V_STRING_ABAS_ABERTAS = V_STRING_ABAS_ABERTAS & OBJ_MOTOR.DocumentTitle & V_SEPARADOR_DE_STRINGS_3 & FUNC_RETORNE_INDEX_DE_FORMULARIO(OBJ_MOTOR.Parent) - 1 & V_SEPARADOR_DE_STRINGS_3 & V_CONTADOR & vbCrLf 'ATUALIZANDO STRING COM TITULO E URL DE MOTOR

            End If

            '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        Next


        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------





        'SEPARA STRING EM ARRAY ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        ARRAY_ABAS_ABERTAS = Split(V_STRING_ABAS_ABERTAS, vbCrLf) 'SEPARANDO

        Return ARRAY_ABAS_ABERTAS 'RETORNO

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Function

    Public Function FUNC_RETORNE_ICONE_DE_ABA_INFORMADA(ByVal V_INDEX As Integer) 'RETORNA O ICONE DA JANELA DA ABA INFORMADA PELO INDEX DO FORMULÁRIO
        On Error Resume Next

        Dim OBJ_FORMULARIO As New Form 'NOVO FORMULÁRIO

        Dim OBJ_ICONE As Icon 'OBJETO ICONE

        Dim OBJ_IMAGEM As Image 'OBJETO IMAGEM






        'IGUALA PROPRIEDADES -------------------------------------------------------------------------------------------

        OBJ_FORMULARIO = DirectCast(My.Application.OpenForms.Item(V_INDEX), Form) 'IGUALANDO

        '---------------------------------------------------------------------------------------------------------------




        'OBTENDO O ICONE -----------------------------------------------------------------------------------------------

        OBJ_ICONE = OBJ_FORMULARIO.Icon 'OBTENDO O OBJETO ICONE

        '---------------------------------------------------------------------------------------------------------------




        'CONVERTE ICONE PARA IMAGEM ------------------------------------------------------------------------------------

        OBJ_IMAGEM = OBJ_ICONE.ToBitmap 'CONVERTENDO

        '---------------------------------------------------------------------------------------------------------------




        'RETORNO -------------------------------------------------------------------------------------------------------

        Return OBJ_IMAGEM 'RETORNO DE IMAGEM

        '---------------------------------------------------------------------------------------------------------------


    End Function




















    'FUNÇÕES DE CONEXÃO COM A INTERNET ETC...

    Public Function FUNC_RETORNA_O_IP_LOCAL(ByVal V_URL As String) 'RETORNA O IP LOCAL DO COMPUTADOR
        On Error Resume Next

        Dim V_HOST As String = System.Net.Dns.GetHostName 'HOST

        Dim V_IP_HOST As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(V_URL) 'HOST E IP

        Dim V_IP As String = Nothing 'IP OBTIDO






        'VARRENDO E OBTENDO IP ----------------------------------------------------------------------------------------------------------------

        For Each myIP As System.Net.IPAddress In V_IP_HOST.AddressList




            'OBTENDO O IP ---------------------------------------------------------------------------------------------------------------------

            V_IP = myIP.ToString 'ENDEREÇO IP DO COMPUTADOR

            '----------------------------------------------------------------------------------------------------------------------------------




        Next

        '--------------------------------------------------------------------------------------------------------------------------------------




        'RETORNO DE IP ------------------------------------------------------------------------------------------------------------------------

        If (V_IP <> Nothing) Then


            Return V_IP 'RETORNO DE IP


        Else


            V_IP = "Não obtido!" 'INFORMA QUE O IP NÃO PÔDE SER OBTIDO


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Function

    


































End Module
