Imports Gecko
Imports System.IO
Imports SpeechLib
Imports SkinSoft
Imports System.Reflection




Module MODULO_DE_ACOES_BASICAS




    'VARIÁVEIS DE IMPRESSAO

    Public V_QUANTIDADE_DE_ITENS_VISUALIZAR_IMPRESSAO As Integer = 0 'Informa a quantidade de itens do visualizar impressao

    Public V_CONTADOR_DE_PAGINAS_A_IMPRIMIR As Integer = 0 'Informa o contador de paginas a serem impressas










    'VARIÁVEIS DE HISTORICO

    Public V_CONTADOR_DE_ITENS_DE_HISTORICO As Integer = 1 'CONTADOR DE ITENS DE HISTORICO

    Public V_LISTA_DE_HISTORICO_URL_JA_EXISTE As String = "" 'LISTA DE HISTORICO DE URLS QUE JÁ EXISTEM

    Public V_TAMANHO_DE_IMAGENS_DE_HISTORICO As Integer = 256 'TAMANHO DE IMAGENS DE HISTÓRICO

    Public V_FILTRO_DE_EXIBICAO_DE_HISTORICO_DE_SITES_VISITADOS As String = Nothing 'FILTRO DE HISTORICO DE SITES VISITADOS

    Public V_CONFIG_TEMP_RECURSO_DE_AUTOCOMPLETAR As String = True 'RECURSO DE AUTOCOMPLETAR

    Public V_CONFIG_TEMP_RECURSO_DE_AUTOCOMPLETAR_IMAGENS As String = True 'RECURSO DE AUTOCOMPLETAR IMAGENS EXIBIR

    Public V_VALORES_DE_AUTO_COMPLETAR_OBTIDOS_COM_FILTRO As String 'VALORES OBTIDOS COM O RECURSO DE AUTO-COMPLETAR COM FILTRO DEFINIDO PELO USUÁRIO

    Public V_QUANTIDADE_DE_ITENS_DE_HISTORICO_EXCESSO As Integer = 100 'QUANTIDADE DE ITENS DE HISTÓRICO QUE JÁ ESTÁ EM EXCESSO









    'VARIÁVEIS DO RECURSO DE AUTOCOMPLETAR

    Public V_DADOS_DO_RECURSO_DE_AUTOCOMPLETAR As String = Nothing 'DADOS DO RECURSO DE AUTOCOMPLETAR










    'PILHA DE ABAS QUE FORAM FECHADAS

    Public ARRAY_PILHA_DE_ABAS_QUE_FORAM_FECHADAS_PELO_USUARIO As New ArrayList 'PILHA DE ABAS QUE FORAM FECHADAS PELO USUÁRIO















    'VARIÁVEIS DE USO GERAL

    Dim V_ENDERECO_DA_IMAGEM_BACKUP_PARA_O_EDITOR_DE_IMAGENS_ABRIR As String 'ENDEREÇO DA IMAGEM SALVA, PARA SER ABERTA COM O EDITOR DE IMAGENS





























    'PROCEDIMENTOS DE AÇÕES BASICAS

    Public Sub PROC_ABRIR_PAGINA_SALVA_NO_HD() 'ABRE A PÁGINA SALVA NO HD
        On Error Resume Next


        'CRIANDO NOVO DIÁLOGO DE ABRIR ARQUIVO -------------------------------------------------------------------------

        OBJ_DIALOGO_ABRIR_ARQUIVO = New OpenFileDialog 'NOVO DIÁLOGO DE ABRIR ARQUIVO

        '---------------------------------------------------------------------------------------------------------------




        'DEFINE PROPRIEDADE -----------------------------------------------------------------------------------------------------------------------------------

        OBJ_DIALOGO_ABRIR_ARQUIVO.Filter = "Extenção do arquivo(*" & V_EXTENCAO_DE_ARQUIVO_2 & ")|*" & V_EXTENCAO_DE_ARQUIVO_2 'Extenção do arquivo

        '------------------------------------------------------------------------------------------------------------------------------------------------------




        'ABRINDO O ARQUIVO ---------------------------------------------------------------------------------------------

        If (OBJ_DIALOGO_ABRIR_ARQUIVO.ShowDialog = DialogResult.OK) Then


            Dim V_END_ARQUIVO_HTML_ABRIR As String = OBJ_DIALOGO_ABRIR_ARQUIVO.FileName 'ENDEREÇO DO ARQUIVO A SER ABERTO




            'ABRINDO ARQUIVO AGORA ---------------------------------------

            PROC_NAVEGAR(V_END_ARQUIVO_HTML_ABRIR) 'ABRINDO ARQUIVO

            '-------------------------------------------------------------


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_SALVAR_PAGINA_NO_HD() 'SALVA A PÁGINA NO HD
        On Error Resume Next


        'CRIA NOVO DIÁLOGO ---------------------------------------------------------------------------------------------

        OBJ_DIALOGO_ABRIR_PASTA = New FolderBrowserDialog 'NOVO DIÁLOGO

        '---------------------------------------------------------------------------------------------------------------




        'ABRINDO DIÁLOGO E SALVANDO ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (OBJ_DIALOGO_ABRIR_PASTA.ShowDialog = DialogResult.OK) Then


            Dim V_TITULO_DA_PAGINA As String = CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).DocumentTitle 'TÍTULO


            CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).SaveDocument(OBJ_DIALOGO_ABRIR_PASTA.SelectedPath & "\" & V_TITULO_DA_PAGINA & V_EXTENCAO_DE_ARQUIVO_2) 'SALVANDO...


        End If

        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_TIRAR_FOTO_DO_SITE() 'TIRA FOTO DO SITE
        On Error Resume Next

        Dim OBJ_IMAGEM As Image = FUNC_RETORNE_IMAGEM_DE_MOTOR_GECKOFX_COMPLETO() 'RETORNA A IMAGEM DO MOTOR GECKOFX

        Static V_NUM_DE_IMAGEM As Integer 'NÚMERO DA IMAGEM






        'NOVA CAIXA DE DIÁLOGO -----------------------------------------------------------------------

        OBJ_DIALOGO_SALVAR_ARQUIVO = New SaveFileDialog 'NOVA CAIXA DE DIÁLOGO DE SALVAR ARQUIVO

        '---------------------------------------------------------------------------------------------




        'DEFINE O FILTRO DA IMAGEM -----------------------------------------------------------------------------------------------------------------------------------

        OBJ_DIALOGO_SALVAR_ARQUIVO.FileName = "Imagem_" & V_NUM_DE_IMAGEM 'NOME DA IMAGEM

        OBJ_DIALOGO_SALVAR_ARQUIVO.Filter = "Extenção do arquivo(*" & V_EXTENCAO_DE_ARQUIVO_3 & ")|*" & V_EXTENCAO_DE_ARQUIVO_3 'Extenção do arquivo

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'SALVANDO A IMAGEM ----------------------------------------------------------------------

        If (OBJ_DIALOGO_SALVAR_ARQUIVO.ShowDialog = DialogResult.OK) Then


            OBJ_IMAGEM.Save(OBJ_DIALOGO_SALVAR_ARQUIVO.FileName) 'SALVANDO A IMAGEM

            V_NUM_DE_IMAGEM = V_NUM_DE_IMAGEM + 1 'ATUALIZA NUMERO DE IMAGEM


        End If

        '----------------------------------------------------------------------------------------

    End Sub

    Public Sub PROC_ZOOM_NO_TEXTO(ByVal V_VALOR As Integer) 'APLICA O ZOOM NO TEXTO
        On Error Resume Next

        Dim V_VALOR_DE_ZOOM As Single = (V_VALOR / 100) 'VALOR DE ZOOM






        'VALOR DE ZOOM -----------------------------------------------------------------------------------------------------------------------------------------------

        CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).Window.TextZoom = V_VALOR_DE_ZOOM 'APLICANDO O ZOOM

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Public Sub PROC_ALTERAR_A_COR_DA_ABA() 'ALTERAR A COR DA ABA
        On Error Resume Next

        Dim OBJ_COR As New ColorDialog 'DIÁLOGO DE COR






        'AO FECHAR A JANELA APLICAR A COR E SALVAR ---------------------------------------------------------------------

        If (OBJ_COR.ShowDialog = DialogResult.OK) Then




            'APLICANDO -------------------------------------------------------------------------------------------------

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.BackHighColor = OBJ_COR.Color 'COR
            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.BackLowColor = OBJ_COR.Color 'COR
            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.TabBackLowColor = OBJ_COR.Color 'COR
            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.TabBackHighColor = OBJ_COR.Color 'COR
            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.TabBackLowColorDisabled = OBJ_COR.Color 'COR
            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.Refresh() 'ATUALIZANDO

            '-----------------------------------------------------------------------------------------------------------




            'SALVANDO NOVA COR -----------------------------------------------------------------------------------------

            PROC_SALVAR_ARQUIVO(OBJ_COR.Color.ToArgb, V_ARQUIVO_END_12) 'SALVA O ARQUIVO

            '-----------------------------------------------------------------------------------------------------------




        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_ALTERAR_A_COR_DO_TEXTO_DA_ABA() 'ALTERAR A COR DO TEXTO DA ABA
        On Error Resume Next

        Dim OBJ_COR As New ColorDialog 'DIÁLOGO DE COR






        'AO FECHAR A JANELA APLICAR A COR E SALVAR ---------------------------------------------------------------------

        If (OBJ_COR.ShowDialog = DialogResult.OK) Then




            'APLICANDO -------------------------------------------------------------------------------------------------

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.ForeColor = OBJ_COR.Color 'APLICA A COR

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.Refresh() 'ATUALIZANDO

            '-----------------------------------------------------------------------------------------------------------




            'SALVANDO NOVA COR -----------------------------------------------------------------------------------------

            PROC_SALVAR_ARQUIVO(OBJ_COR.Color.ToArgb, V_ARQUIVO_END_13) 'SALVA O ARQUIVO

            '-----------------------------------------------------------------------------------------------------------




        End If

        '---------------------------------------------------------------------------------------------------------------



    End Sub

    Public Sub PROC_RESTAURAR_A_COR_NATUAL_DA_ABA() 'RESTAURA A COR NATURAL DA ABA
        On Error Resume Next


        'RESTAURA A COR ------------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(True, V_ARQUIVO_END_12) 'RESTAURA A COR

        PROC_SALVAR_ARQUIVO(True, V_ARQUIVO_END_13) 'RESTAURA A COR

        '---------------------------------------------------------------------------------------------------------------




        'CARREGA A COR E ESTILO DE ABA ---------------------------------------------------------------------------------

        PROC_CARREGA_COR_E_ESTILO_DE_ABA(True) 'CARREGA A COR E O ESTILO DA ABA

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_PROCURAR_POR_TEXTO_NA_PAGINA(ByVal V_LOCALIZAR As String, ByVal V_TERMINOU As Boolean) 'PROCURA E SELECIONA O TEXTO NA PÁGINA
        On Error Resume Next

        Dim V_CONTEUDO_DA_PAGINA As String 'CONTEUDO DA PÁGINA CONTEUDO INNERHTML

        Dim V_CODIGO_DE_SELECAO As String = "<span style='background-color: rgb(0,255,127);'>" & V_LOCALIZAR & "</span>" 'CÓDIGO DE SELEÇÃO

        Static V_CONTEUDO_DO_MOTOR_BACKUP As String 'ARMAZENA O CONTEUDO DO MOTOR INALTERADO.

        Static V_ULTIMA_URL_UTILIZADA As String 'ARMAZENA A ULTIMA URL UTILIZADA NA PROCURA






        'INFORMA QUE TERMINOU DE LOCALIZAR E PODE RESTAURAR O CODIGO AO ESTADO NORMAL ----------------------------------------------------------------------------------

        If (V_TERMINOU = True) And (V_CONTEUDO_DO_MOTOR_BACKUP <> Nothing) And (V_ULTIMA_URL_UTILIZADA = OBJ_MOTOR_DE_ACAO_EM_USO.Url.AbsoluteUri) Then


            OBJ_MOTOR_DE_ACAO_EM_USO.Document.Body.InnerHtml = V_CONTEUDO_DO_MOTOR_BACKUP 'IGUALANDO CODIGO

            OBJ_MOTOR_DE_ACAO_EM_USO.Stop() 'PARANDO CARREGAMENTO

            Exit Sub 'SAINDO


        End If

        '---------------------------------------------------------------------------------------------------------------------------------------------------------------




        'NAO PERMITE VALOR NULO ----------------------------------------------------------------------------------------

        If (V_LOCALIZAR.Length = 0) Then


            Exit Sub 'SAINDO


        End If

        '---------------------------------------------------------------------------------------------------------------




        'LIMPA ULTIMO VALOR ANTERADO, E INFORMA NOVO VALOR DE CONTEUDO DE PAGINA ----------------------------------------------------------------------------------------

        If (V_ULTIMA_URL_UTILIZADA <> OBJ_MOTOR_DE_ACAO_EM_USO.Url.AbsoluteUri) Then




            V_CONTEUDO_DO_MOTOR_BACKUP = OBJ_MOTOR_DE_ACAO_EM_USO.Document.Body.InnerHtml 'CONTEUDO DE BACKUP DE CODIGO DE PÁGINA

            V_ULTIMA_URL_UTILIZADA = OBJ_MOTOR_DE_ACAO_EM_USO.Url.AbsoluteUri 'ULTIMA URL UTILIZADA

            V_CONTEUDO_DA_PAGINA = OBJ_MOTOR_DE_ACAO_EM_USO.Document.Body.InnerHtml 'CONTEUDO DE PÁGINA




        Else




            V_CONTEUDO_DA_PAGINA = V_CONTEUDO_DO_MOTOR_BACKUP 'CONTEUDO DE PÁGINA




        End If

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------




        'SUBSTITUI PELO NOVO CODIGO DE SELEÇÃO -------------------------------------------------------------------------

        V_CONTEUDO_DA_PAGINA = V_CONTEUDO_DA_PAGINA.Replace(V_LOCALIZAR, V_CODIGO_DE_SELECAO) 'SUBSTITUINDO

        '---------------------------------------------------------------------------------------------------------------




        'IGUALANDO CODIGO ----------------------------------------------------------------------------------------------

        OBJ_MOTOR_DE_ACAO_EM_USO.Document.Body.InnerHtml = V_CONTEUDO_DA_PAGINA 'IGUALANDO CODIGO

        '---------------------------------------------------------------------------------------------------------------




        'PARANDO CARREGAMENTO ------------------------------------------------------------------------------------------

        OBJ_MOTOR_DE_ACAO_EM_USO.Stop() 'PARANDO CARREGAMENTO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_EXIBIR_TELA_CHEIA(ByVal OBJ_FORMULARIO As Form) 'EXIBE EM TELA CHEIA
        On Error Resume Next

        Dim OBJ_FORMULARIO_TELA_CHEIA As Form = DirectCast(OBJ_FORMULARIO, Form)






        'TELA CHEIA OU NAO ---------------------------------------------------------------------------------------------

        If (OBJ_FORMULARIO_TELA_CHEIA.ControlBox = True) Then




            OBJ_FORMULARIO_TELA_CHEIA.ControlBox = False 'INFORMA QUE NAO DEVE EXIBIR BARRA DE TITULOS

            OBJ_FORMULARIO_TELA_CHEIA.FormBorderStyle = FormBorderStyle.None 'SEM BORDA

            OBJ_FORMULARIO_TELA_CHEIA.WindowState = FormWindowState.Maximized 'INICIA MAXIMIZADO

            OBJ_FORMULARIO_TELA_CHEIA.Hide() 'OCULTA

            OBJ_FORMULARIO_TELA_CHEIA.Show() 'EXIBE NOVAMENTE




        Else




            OBJ_FORMULARIO_TELA_CHEIA.ControlBox = True 'INFORMA QUE DEVE EXIBIR BARRA DE TITULOS

            OBJ_FORMULARIO_TELA_CHEIA.FormBorderStyle = FormBorderStyle.Sizable 'BORDA NORMAL

            OBJ_FORMULARIO_TELA_CHEIA.WindowState = FormWindowState.Maximized 'INICIA MAXIMIZADO

            OBJ_FORMULARIO_TELA_CHEIA.Hide() 'OCULTA

            OBJ_FORMULARIO_TELA_CHEIA.Show() 'EXIBE NOVAMENTE




        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_INFORMAR_CHAVE_DE_SEGURANCA_DO_SITE_EM_VISUALIZACAO(ByVal V_URL As String) 'INFORMA A CHAVE DE SEGURANÇA DO SITE EM VISUALIZAÇÃO
        On Error Resume Next

        Dim V_PROTOCOLO As String = FUNC_RETORNA_O_PROTOCOLO_DE_URL(V_URL) 'PROTOCOLO DE SITE






        'VERIFICA SE O SITE É OU NAO SEGURO --------------------------------------------------------------------------------------------------------------------------

        If (V_PROTOCOLO = "https") Then


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripStatusLabel2.Image = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.IML_IMAGENS_1.Images.Item(2) 'NAO SEGURO
            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripStatusLabel2.Text = V_PROTOCOLO & " este site é protegido" 'INFORMANDO PROTOCOLO


        Else


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripStatusLabel2.Image = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.IML_IMAGENS_1.Images.Item(3) 'SEGURO
            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripStatusLabel2.Text = V_PROTOCOLO 'INFORMANDO PROTOCOLO


        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_DEFINIR_IMAGEM_COMO_PLANO_DE_FUNDO() 'DEFINE A IMAGEM COMO PLANO DE FUNDO
        On Error Resume Next

        Dim SPI_SETDESKWALLPAPER As Integer = 20 'VARIÁVEL

        Dim SPIF_UPDATEINIFILE As Integer = 1 'VARIÁVEL

        Dim V_DEST_IMAGEM As String = V_PASTA_DE_IMAGEM_DEFINIDA_COMO_PLANO_DE_FUNDO & "\BMPDESKTOP.bmp" 'IMAGEM A SER SALVA






        'CRIA PASTA EM CASO DE NAO EXISTIR ----------------------------------------------------------------------------------------------------

        My.Computer.FileSystem.CreateDirectory(V_PASTA_DE_IMAGEM_DEFINIDA_COMO_PLANO_DE_FUNDO) 'CRIA PASTA DE HISTORICO

        '--------------------------------------------------------------------------------------------------------------------------------------




        'FAZ BACKUP DO CONTEUDO DA RAM ---------------------------------------------------------------------------------

        PROC_BACKUP_DE_CONTEUDO_DA_RAM() 'BACKUP DO CO NTEUDO DA MEMORIA RAM

        '---------------------------------------------------------------------------------------------------------------




        'OBTENDO IMAGEM DE MOTOR ---------------------------------------------------------------------------------------

        OBJ_MOTOR_DE_ACAO_EM_USO.CopyImageContents() 'COPIANDO A IMAGEM

        '---------------------------------------------------------------------------------------------------------------




        'SALVANDO IMAGEM AGORA -----------------------------------------------------------------------------------------

        My.Computer.Clipboard.GetImage.Save(V_DEST_IMAGEM, System.Drawing.Imaging.ImageFormat.Bmp) 'SALVANDO A IMAGEM

        '---------------------------------------------------------------------------------------------------------------




        'RESTAURA O CONTEUDO DA RAM ------------------------------------------------------------------------------------

        PROC_BACKUP_DE_CONTEUDO_DA_RAM_RESTAURAR() 'RESTAURA O CONTEUDO DA MEMÓRIA RAM

        '---------------------------------------------------------------------------------------------------------------




        'DEFININDO IMAGEM AGORA -------------------------------------------------------------------------------------------------------------------------------------------------------------

        SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, V_DEST_IMAGEM, SPIF_UPDATEINIFILE) 'SETANDO IMAGEM

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_LIMPAR_SENHAS_ARMAZENADAS_NO_NAVEGADOR(ByVal V_RESP As Boolean) 'LIMPA AS SENHAS ARMAZENADAS NO COMPUTADOR
        On Error Resume Next


        'SALVA CONFIGURAÇÃO E EXIBE MENSAGEM ---------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(V_RESP, V_ARQUIVO_END_36) 'SALVANDO CONFIGURAÇÃO


        If (V_RESP = True) Then


            PROC_CHAMAR_JANELA_DE_AVISOS(V_MS6, 2) 'FORMULARIO DE AVISOS


        Else


            PROC_CHAMAR_JANELA_DE_AVISOS(V_MS7, 2) 'FORMULARIO DE AVISOS


        End If


        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_ABRIR_PASTA_DE_DOWNLOADS() 'ABRIR A PASTA DE DOWNLOADS
        On Error Resume Next

        Dim V_ORIGEM As String = FUNC_LER_ARQUIVO(V_ARQUIVO_END_6) 'OBTENDO PASTA DE DOWNLOADS ORIGEM






        'NAO PERMITE VALOR NULO ----------------------------------------------------------------------------------------

        If (V_ORIGEM = Nothing) Or (V_ORIGEM = "") Then

            Exit Sub 'SAINDO

        End If

        '---------------------------------------------------------------------------------------------------------------




        'ABRINDO PASTA -------------------------------------------------------------------------------------------------

        Process.Start(V_ORIGEM) 'ABRINDO A PASTA

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_PESQUISA_FEITA_PELO_USUARIO(ByVal V_PALAVRA As String, ByVal V_SITE_DE_BUSCA As Integer) 'PESQUISA FEITA PELO USUÁRIO
        On Error Resume Next

        Dim V_ABRIR_PESQUISA As String = Nothing 'PESQUISA A SER ABERTA






        'FORMANDO ENDEREÇO DE PESQUISA A SER ABERTO ----------------------------------------------------------------------------------------------------------------------------------

        Select Case V_SITE_DE_BUSCA


            Case 0
                V_ABRIR_PESQUISA = "http://www.baixabit.com.br" 'END. DE PESQUISA

            Case 1
                V_ABRIR_PESQUISA = "http://www.google.com.br/#hl=pt-BR&output=search&sclient=psy-ab&q=" & V_PALAVRA 'END. DE PESQUISA

            Case 2
                V_ABRIR_PESQUISA = "http://br.search.yahoo.com/search?p=" & V_PALAVRA 'END. DE PESQUISA

            Case 3
                V_ABRIR_PESQUISA = "http://www.youtube.com/results?search_query=" & V_PALAVRA 'END. DE PESQUISA

            Case 4
                V_ABRIR_PESQUISA = "http://www.facebook.com/home.php?ref=wizard#!/search/results.php?q=" & V_PALAVRA 'END. DE PESQUISA

            Case 5
                V_ABRIR_PESQUISA = "http://www.orkut.com.br/Main#UniversalSearch?origin=box&searchFor=A&q=" & V_PALAVRA 'END. DE PESQUISA

            Case 6
                V_ABRIR_PESQUISA = "http://pt.wikipedia.org/w/index.php?title=Especial%3APesquisar&profile=default&search=" & V_PALAVRA 'END. DE PESQUISA


        End Select

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ABRINDO ENDEREÇO DE PESQUISA ----------------------------------------------------------------------------------

        PROC_NAVEGAR(V_ABRIR_PESQUISA) 'ABRINDO ENDEREÇO DE SITE

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_FOCAR_A_BARRA_DE_ENDERECOS(ByVal V_RECUPERA_OU_SALVA As Byte) 'FOCA NA BARRA DE ENDEREÇOS
        On Error Resume Next

        '#NOTA: 0 LIMPA A BARRA DE ENDEREÇOS
        '#NOTA: 1 PEGA O CONTEUDO DA BARRA DE ENDEREÇOS
        '#NOTA: 2 RESTAURA O CONTEUDO DA BARRA DE ENDEREÇOS

        Dim V_POSICAO_1 As Integer = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CBO_ENDERECO_DO_SITE.SelectionStart 'ONDE ESTA O CURSOR ATUALMENTE NA BARRA

        Static V_TEXTO_A_RESTAURAR As String = "" 'TEXTO A SER RESTAURADO






        'RESTAURA O TEXTO DE ONDE PAROU -----------------------------------------------------------------------------------------------------------------------------------------------------

        Select Case V_RECUPERA_OU_SALVA




            Case 0
                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CBO_ENDERECO_DO_SITE.Text = Nothing 'LIMPA A CAIXA DE TEXTO
                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CBO_ENDERECO_DO_SITE.Focus() 'MOVE O FOCO PARA A CAIXA DE TEXTO




            Case 1
                V_TEXTO_A_RESTAURAR = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CBO_ENDERECO_DO_SITE.Text.Substring(0, V_POSICAO_1) 'PEGANDO O TEXTO DA BARRA DE ENDEREÇOS




            Case 2
                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CBO_ENDERECO_DO_SITE.Focus() 'MOVE O FOCO PARA A CAIXA DE TEXTO
                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CBO_ENDERECO_DO_SITE.Text = V_TEXTO_A_RESTAURAR 'RESTAURA O TEXTO
                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CBO_ENDERECO_DO_SITE.SelectionStart = V_TEXTO_A_RESTAURAR.Length 'RESTAURA DE ONDE PAROU




        End Select

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_PERMITE_PESQUISA_COM_TEXTO_SELECIONADO_EM_MOTOR_EM_USO() 'PERMITE A PESQUISA PELO TEXTO SELECIONADO NO MOTOR EM USO
        On Error Resume Next

        Dim V_CARACTERES_A_EXIBIR As Integer = 15 'QUANTIDADE DE CARACTERES A SEREM EXIBIDOS






        'VERIFICA A QUANTIDADE DE CARACTERES A SEREM EXIBIDOS -----------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (FUNC_RETORNE_SELECAO_DE_TEXTO_EM_MOTOR_EM_USO.Length > V_CARACTERES_A_EXIBIR) Then

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PesquiseTextoToolStripMenuItem.Text = "&Pesquise """ & FUNC_RETORNE_SELECAO_DE_TEXTO_EM_MOTOR_EM_USO().Substring(0, V_CARACTERES_A_EXIBIR) & "...""" 'INFORMA O QUE DEVE SER PERSUISADO

        Else

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PesquiseTextoToolStripMenuItem.Text = "&Pesquise """ & FUNC_RETORNE_SELECAO_DE_TEXTO_EM_MOTOR_EM_USO() & "...""" 'INFORMA O QUE DEVE SER PERSUISADO

        End If

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'OPÇÃO DE PROCURAR POR TEXTO SELECIONADO ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PesquiseTextoToolStripMenuItem.Tag = FUNC_RETORNE_SELECAO_DE_TEXTO_EM_MOTOR_EM_USO() 'RETORNA O TEXTO SELECIONADO EM MOTOR EM USO

        RemoveHandler FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PesquiseTextoToolStripMenuItem.Click, AddressOf PROC_EVENTO_PESQUISAR_POR_SELECAO

        AddHandler FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PesquiseTextoToolStripMenuItem.Click, AddressOf PROC_EVENTO_PESQUISAR_POR_SELECAO

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_OUVIR_O_TEXTO_SELECIONADO_PELO_USUARIO_EM_MOTOR_EM_USO() 'OUVE O TEXTO SELECIONADO PELO USUÁRIO
        On Error Resume Next


        'OPÇÃO DE PROCURAR POR TEXTO SELECIONADO ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.OuvirTextoToolStripMenuItem.Tag = FUNC_RETORNE_SELECAO_DE_TEXTO_EM_MOTOR_EM_USO() 'RETORNA O TEXTO SELECIONADO EM MOTOR EM USO

        RemoveHandler FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.OuvirTextoToolStripMenuItem.Click, AddressOf PROC_EVENTO_LEITURA_DE_TEXTO_SELECIONADO_MOTOR_EM_USO 'EVENTO LEITURA DE TEXTO SELECIONADO PELO USUÁRIO

        AddHandler FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.OuvirTextoToolStripMenuItem.Click, AddressOf PROC_EVENTO_LEITURA_DE_TEXTO_SELECIONADO_MOTOR_EM_USO 'EVENTO LEITURA DE TEXTO SELECIONADO PELO USUÁRIO

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_SALVAR_A_IMAGEM_BACKUP_PARA_EDITOR_DE_IMAGENS() 'SALVA A IMAGEM PARA SER ABERTA COM O EDITOR DE IMAGENS DO NAVEGADOR
        On Error Resume Next

        Dim OBJ_IMAGEM As Image 'NOVO OBJETO DE IMAGEM

        Dim V_ENDERECO_DE_ARQUIVO_A_SALVAR As String = V_PASTA_DE_IMAGEM_DE_BACKUP_PARA_EDITOR_DE_IMAGENS & "\" & Date.Now.Day & Date.Now.Month & Date.Now.Year & Date.Now.Hour & Date.Now.Minute & Date.Now.Second & Date.Now.Millisecond & V_EXTENCAO_DE_ARQUIVO_5 'ENDEREÇO DA IMAGEM A SER SALVA






        'FAZ BACKUP DO CONTEUDO DA RAM --------------------------------------------------------------------------------------------------------------------------------

        PROC_BACKUP_DE_CONTEUDO_DA_RAM() 'BACKUP DO CO NTEUDO DA MEMORIA RAM

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------




        'CRIA PASTA DESTINO SE NAO EXISTIR -----------------------------------------------------------------------------

        My.Computer.FileSystem.CreateDirectory(V_PASTA_DE_IMAGEM_DE_BACKUP_PARA_EDITOR_DE_IMAGENS) 'CRIANDO PASTA

        '---------------------------------------------------------------------------------------------------------------




        'OBTENDO IMAGEM DE MOTOR --------------------------------------------------------------------------------------------------------------------------------------

        OBJ_MOTOR_DE_ACAO_EM_USO.CopyImageContents() 'COPIANDO A IMAGEM

        OBJ_IMAGEM = My.Computer.Clipboard.GetImage 'OBTENDO A IMAGEM

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------




        'SALVANDO A IMAGEM --------------------------------------------------------------------------------------------------------------------------------------------

        V_ENDERECO_DA_IMAGEM_BACKUP_PARA_O_EDITOR_DE_IMAGENS_ABRIR = V_ENDERECO_DE_ARQUIVO_A_SALVAR 'SETANDO ENDERÇO DE IMAGEM

        OBJ_IMAGEM.Save(V_ENDERECO_DA_IMAGEM_BACKUP_PARA_O_EDITOR_DE_IMAGENS_ABRIR, System.Drawing.Imaging.ImageFormat.Bmp) 'SALVANDO A IMAGEM

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------




        'RESTAURA O CONTEUDO DA RAM -----------------------------------------------------------------------------------------------------------------------------------

        PROC_BACKUP_DE_CONTEUDO_DA_RAM_RESTAURAR() 'RESTAURA O CONTEUDO DA MEMÓRIA RAM

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_EDITAR_IMAGEM_COM_APLICATIVO_EDITOR_DE_IMAGENS() 'EDITAR A IMAGEM COM O APLICATIVO EDITOR DE IMAGENS
        On Error Resume Next


        'COPIA A IMAGEM --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_SALVAR_A_IMAGEM_BACKUP_PARA_EDITOR_DE_IMAGENS() 'SALVA A IMAGEM PARA SER ABERTA COM O EDITOR DE IMAGENS DO NAVEGADOR

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA SE O APLICATIVO ESTA DISPONIVEL ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (FUNC_RETORNA_SE_O_ARQUIVO_EXISTE_OU_NAO(V_APLICATIVO_PADRAO_PARA_EDITOR_DE_IMAGENS) = False) Then


            MsgBox(V_MS9, MsgBoxStyle.Exclamation, V_MS9) 'MENSAGEM AO USUÁRIO

            Exit Sub 'SAINDO


        End If

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ABRINDO O APLICATIVO --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_ABRIR_APLICATIVO_INSTALADO_DO_NAVEGADOR_PARAMETRO_EXTRA(V_APLICATIVO_PADRAO_PARA_EDITOR_DE_IMAGENS, V_ENDERECO_DA_IMAGEM_BACKUP_PARA_O_EDITOR_DE_IMAGENS_ABRIR) 'ABRE O APLICATIVO INSTALADO PARA O USUÁRIO COM PARAMETRO EXTRA

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_OBTENHA_DADOS_BASICOS_SOBRE_TODAS_AS_ABAS_ABERTAS_TITULO(ByVal OBJ_REFERENCIA As Object) 'OBTÉM TODOS OS DADOS BÁSICOS DE TODAS AS ABAS ABERTAS TITULO
        On Error Resume Next

        Dim ARRAY_ABAS_ABERTAS As Array = FUNC_RETORNE_ARRAY_DE_TODAS_AS_ABAS_ABERTAS_TITULO() 'RETORNA O ARRAY DE TODAS AS ABAS ABERTAS TITULO

        Dim OBJ_MENU_STRIP As New ToolStripSplitButton 'NOVO BOTÃO DE MENUS STRIPBUTTON






        'REFERENCIA O OBJETO E LIPA ITENS ANTIGOS -------------------------------------------------------------------------------------------------------------------------------------------

        OBJ_MENU_STRIP = DirectCast(OBJ_REFERENCIA, ToolStripSplitButton) 'REFERENCIA O OBJETO

        OBJ_MENU_STRIP.DropDownItems.Clear() 'LIMPA TODOS OS ITENS ANTIGOS

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ATUALIZA OS ITENS AGORA ------------------------------------------------------------------------------------------------------------------------------------------------------------

        For I = 0 To ARRAY_ABAS_ABERTAS.Length

            Dim V_VALOR_OBTIDO_DE_ARRAY_ABAS_ABERTAS As String = ARRAY_ABAS_ABERTAS(I) 'VALOR OBTIDO DE ARRAY ABAS ABERTAS

            Dim ARRAY_DE_DADOS_OBTIDOS As Array = Split(V_VALOR_OBTIDO_DE_ARRAY_ABAS_ABERTAS, V_SEPARADOR_DE_STRINGS_3) 'TITULO E INDEX DE FORMULÁRIO

            Dim V_TITULO As String = ARRAY_DE_DADOS_OBTIDOS(0) 'TÍTULO DA ABA

            Dim V_INDEX_DE_ABA As Integer = ARRAY_DE_DADOS_OBTIDOS(1) 'INDEX DA ABA

            Dim V_INDEX_DE_FORMULARIO As Integer = ARRAY_DE_DADOS_OBTIDOS(2) 'INDEX DE FORMULÁRIO

            Dim OBJ_MENU_SUBITEM As New ToolStripMenuItem 'NOVO ITEM DE MENU






            'VERIFICA SE O VALOR DE ARRAY NÃO É NULO ----------------------------------------------------------------------------------------------------------------------------------------

            If (V_VALOR_OBTIDO_DE_ARRAY_ABAS_ABERTAS.Length > 0) Then


                'TÍTULO, TAG E ADICIONA O SUBITEM CRIADO ------------------------------------------------------------------------------------------------------------------------------------

                OBJ_MENU_SUBITEM.Text = V_TITULO 'TÍTULO DE MENU

                OBJ_MENU_SUBITEM.Tag = V_INDEX_DE_ABA 'INDEX DA ABA

                OBJ_MENU_STRIP.DropDownItems.Add(OBJ_MENU_SUBITEM) 'ADICIONA O NOVO ITEM CRIADO

                OBJ_MENU_SUBITEM.Image = FUNC_RETORNE_ICONE_DE_ABA_INFORMADA(V_INDEX_DE_FORMULARIO) 'RETORNA O ICONE DA JANELA DA ABA INFORMADA PELO INDEX

                '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------




                'ADICIONA EVENTO AGORA ------------------------------------------------------------------------------------------------------------------------------------------------------

                AddHandler OBJ_MENU_SUBITEM.Click, AddressOf PROC_EVENTO_CLICAR_EM_SUBITEM_TODAS_AS_ABAS_ABERTAS 'EVENTO QUE ABRE A ABA PELO INDEX

                '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            End If




        Next

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_SALVAR_CONFIGURACAO_RESTAURAR_CONFIG_DO_NAVEGADOR(ByVal V_RESPOSTA As Boolean) 'CONFIGURAÇÃO PARA RESTAURAR TODAS AS CONFIGURAÇÕES DO NAVEGADOR
        On Error Resume Next


        'SALVA A CONFIGURAÇÃO -----------------------------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(V_RESPOSTA, V_ARQUIVO_END_38) 'SALVANDO CONFIGURAÇÃO

        '--------------------------------------------------------------------------------------------------------------------------------------




        'INFORMA AO USUÁRIO QUE FARA ISTO DA PROXIMA VEZ QUE INICIALIZAR ----------------------------------------------------------------------

        If (V_RESPOSTA = True) Then

            PROC_CHAMAR_JANELA_DE_AVISOS(V_MS10, 2) 'FORMULARIO DE AVISOS

        End If

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_OPCOES_DE_MENU_DE_FORMULARIO_PRINCIPAL_BARRA_DE_MENUS() 'AQUI FICAM AS OPÇÕES DE MENU DO FORMULARIO PRINCIPAL
        On Error Resume Next

        Dim V_CONFIG_1 As Boolean = FUNC_LER_ARQUIVO(V_ARQUIVO_END_38) 'LENDO A CONFIGURAÇÃO






        'MENU RESTAURAR CONFIGURAÇÕES SIM OU NAO ----------------------------------------------------------------------------------------------

        If (V_CONFIG_1 = False) Then

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.SimToolStripMenuItem.Enabled = True 'HABILITA
            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.NãoToolStripMenuItem.Enabled = False 'DESABILITA

        Else

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.SimToolStripMenuItem.Enabled = False 'DESABILITA
            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.NãoToolStripMenuItem.Enabled = True 'HABILITA

        End If

        '--------------------------------------------------------------------------------------------------------------------------------------



































































    End Sub

    Public Sub PROC_INFORME_IP_DE_SITE_EM_VISUALIZACAO_E_IP_LOCAL() 'INFORMA O IP DO SITE EM VISUALIZAÇÃO E O IP DO COMPUTADOR
        On Error Resume Next

        Dim V_IP_LOCAL As String = FUNC_RETORNA_O_IP_LOCAL(My.Computer.Name) 'RETORNA O IP LOCAL

        Dim V_IP_DE_SITE As String = FUNC_RETORNA_O_IP_LOCAL(OBJ_MOTOR_DE_ACAO_EM_USO.Url.Host) 'RETORNA O IP DE SITE






        'RETORNA IP LOCAL E IP DE SITE EM FOCO ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        MsgBox("Ip deste computador: " & V_IP_LOCAL & vbCrLf & "Ip do site: " & OBJ_MOTOR_DE_ACAO_EM_USO.Url.Host & " -> " & V_IP_DE_SITE & " <-", MsgBoxStyle.Information, "Ip local e ip de site") 'IP LOCAL E IP DE SITE

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_CLICAR_EM_IMAGEM_DE_ABAS_ABERTAS(ByVal V_NUMERO_DE_JANELA_ABA_SELECIONADA As String) 'CLICAR EM IMAGEM DE ABAS ABERTAS
        On Error Resume Next

        Dim V_CONTADOR As Integer = 0 'CONTADOR DE LOOPING






        'PROCURA POR NOME DE FORMULARIO EM TODOS OS FORMULARIOS --------------------------------------------------------------------------------------------------------------------------------------------------------------

        For V_CONTADOR = V_CONTADOR To My.Application.OpenForms.Count




            'VERIFICA SE O NOME DE ITEM É IGUAL A JANELA SELECIONADA PELA IMAGEM... ------------------------------------------------------------------------------------------------------------------------------------------

            If (My.Application.OpenForms.Item(V_CONTADOR).Name = V_NUMERO_DE_JANELA_ABA_SELECIONADA) Then




                'INFORMA INDEX DE FORMULARIO ENCONTRADO, EM SEGUIDA ABRE O INDEX SELECIONADO ---------------------------------------------------------------------------------------------------------------------------------

                Dim V_INDEX_DO_FORMULARIO_ENCONTRADO As Integer = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.TabPages.IndexOf(My.Application.OpenForms.Item(V_CONTADOR)) 'INDEX DE ABA SELECIONADA

                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.TabPages.Item(V_INDEX_DO_FORMULARIO_ENCONTRADO).Select() 'SELECIONA ABA ENCONTRADA

                '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




                'SAINDO DE FOR -----------------------------------------------

                Exit For 'SAINDO DE FOR

                '-------------------------------------------------------------




            End If

            '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        Next


        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




    End Sub

    Public Sub PROC_NOVO_DOWNLOAD_MODO_SIMPLES_OU_AGRUPADO(ByVal V_MODO As Boolean) 'NOVO DOWNLOAD DEFINIDO PELO MODO SIMPLES OU AGRUPADO
        On Error Resume Next

        Dim V_ENDERECO_DE_DOWNLOAD As String = Nothing 'ENDEREÇO DE DOWNLOAD






        'VERIFICA O MODO DE DOWNLOAD ---------------------------------------------------------------------------------------------------------------------------------

        If (V_MODO = False) Then


            V_ENDERECO_DE_DOWNLOAD = InputBox("Informe o endereço de download", "Novo download") 'ENDEREÇO DE DOWNLOAD


        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'INICIA O NOVO DOWNLOAD DEPENDENDO DO MODO -------------------------------------------------------------------------------------------------------------------

        If (V_MODO = True) Then




            'ABRE O APLICATIVO ---------------------------------------------------------------------------------------------------------------------------------------

            Process.Start(V_PASTA_DE_APLICATIVOS_DO_NAVEGADOR & "\downbasicwin\M7SLMDOWNLOADERWINDOWS.exe") 'ABRINDO DOWNLOAD COM O COMANDO JÁ INFORMADO

            '---------------------------------------------------------------------------------------------------------------------------------------------------------




        Else




            'ABRINDO O GERENCIADOR DE DOWNLOADS NO MODO AGRUPADO -----------------------------------------------------------------------------------------------------

            If (V_ENDERECO_DE_DOWNLOAD.Length > 0) Then


                PROC_RODAR_GERENCIADORES_DE_DOWNLOAD(V_ENDERECO_DE_DOWNLOAD) 'RODA OS GERENCIADORES DE DOWNLOAD


            End If

            '---------------------------------------------------------------------------------------------------------------------------------------------------------




        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_MUDAR_IMAGEM_DE_FUNDO_DE_PAGINA_DE_INICIO(ByVal V_COMANDO As String) 'MUDA A IMAGEM DE FUNDO DE PÁGINA DE INICIO
        On Error Resume Next

        Dim V_ARQUIVO_A_SUBSTITUIR As String = Path.GetDirectoryName(V_PASTA_DE_ARQUIVO_DE_INICIO_DE_PAGINA_DE_INICIO) & "\images\Wallpaper.jpg"






        'VERIFICA SE O COMANDO É VALIDO -------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_COMANDO_DE_SISTEMA_1 = V_COMANDO) And (V_COMANDO.Length > 0) Then




            'NOVO DIÁLOGO E DEFINE FILTRO -----------------------------------------------------------------------------------------------------------------------------------------------------------------

            OBJ_DIALOGO_ABRIR_ARQUIVO = New OpenFileDialog 'NOVO DIÁLOGO DE ABRIR

            OBJ_DIALOGO_ABRIR_ARQUIVO.Filter = "Imagens jpg (*.jpg)|*.jpg" 'FILTRO

            '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'DEFINE PASTA INICIAL DE IMAGENS --------------------------------------------------------------------------------------------------------------------------------------------------------------

            OBJ_DIALOGO_ABRIR_ARQUIVO.InitialDirectory = V_PASTA_DE_IMAGENS_DE_PAGINA_DE_INICIO 'DEFINE PASTA INICIAL DE IMAGENS

            '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'ABRINDO DIÁLOGO E SALVANDO NOVA IMAGEM DE FUNDO ----------------------------------------------------------------------------------------------------------------------------------------------

            If (OBJ_DIALOGO_ABRIR_ARQUIVO.ShowDialog = DialogResult.OK) Then




                PROC_REMOVER_ARQUIVO_UNICO_SEM_PERGUNTAS(V_ARQUIVO_A_SUBSTITUIR) 'REMOVE ARQUIVO SEM PERGUNTA

                My.Computer.FileSystem.CopyFile(OBJ_DIALOGO_ABRIR_ARQUIVO.FileName, V_ARQUIVO_A_SUBSTITUIR) 'COPIANDO

                PROC_ACOES_BASICAS_AVANCAR_VOLTAR_ATUALIZAR_ETC(4) 'VOLTAR, AVANÇAR, ETC.




            End If

            '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        End If

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub













    'RELACIONADO AO HISTÓRICO DE SITES VISITADOS

    Public Sub PROC_SALVAR_HISTORICO_DE_SITE_VISITADO_AGORA(ByRef OBJ_MOTOR As Gecko.GeckoWebBrowser) 'SALVA O HISTORICO DO SITE VISITADO AGORA
        On Error Resume Next

        Dim IMG_IMAGEM_DE_SITE As Image 'IMAGEM DA PÁGINA A SER SALVA

        Dim V_HOST_DE_SITE_VISITADO_PASTA As String = V_PASTA_DE_HISTORICO_DE_SITES_VISITADOS & "\" & OBJ_MOTOR.Url.Host 'HOST DE SITE VISITADO

        Dim V_ARQUIVO_DE_HISTORICO_IMAGEM As String = V_HOST_DE_SITE_VISITADO_PASTA & "\" & OBJ_MOTOR.Url.Host & V_CONTADOR_DE_ITENS_DE_HISTORICO & V_EXTENCAO_DE_ARQUIVO_3 'ENDEREÇO JÁ COM O NOME DA IMAGEM

        Dim V_ARQUIVO_DE_HISTORICO_URL_DE_CADA_IMAGEM As String = V_HOST_DE_SITE_VISITADO_PASTA & "\" & OBJ_MOTOR.Url.Host & V_CONTADOR_DE_ITENS_DE_HISTORICO & V_EXTENCAO_DE_ARQUIVO_4 'ENDEREÇO URL DE CADA IMAGEM

        Dim V_ARQUIVO_DE_INDICE_DE_HISTORICO As String = V_PASTA_DE_HISTORICO_DE_SITES_VISITADOS & "\indice" & V_EXTENCAO_DE_ARQUIVO_4 'INFORMA O ARQUIVO DE INDICE GERAL

        Dim V_CONTEUDO_DE_INDICE As String = V_SEPARADOR_DE_STRINGS_2 & OBJ_MOTOR.Url.AbsoluteUri & V_SEPARADOR_DE_STRINGS_2 & OBJ_MOTOR.DocumentTitle & V_SEPARADOR_DE_STRINGS_2 & OBJ_MOTOR.Url.Host & "\" & OBJ_MOTOR.Url.Host & V_CONTADOR_DE_ITENS_DE_HISTORICO & V_EXTENCAO_DE_ARQUIVO_3 'CONTEUDO DE INDICE






        'INFORMA PELO MENOS O AUTOCOMPLETAR -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        V_DADOS_DO_RECURSO_DE_AUTOCOMPLETAR = V_SEPARADOR_DE_STRINGS_2 & OBJ_MOTOR.Url.AbsoluteUri & V_DADOS_DO_RECURSO_DE_AUTOCOMPLETAR 'ATUALIZANDO...

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'NÃO PERMITE ADICIONAR DUPLICATAS ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_LISTA_DE_HISTORICO_URL_JA_EXISTE.Contains(OBJ_MOTOR.Url.AbsoluteUri) = True) Or (OBJ_MOTOR.Url.AbsoluteUri = "about:blank") Or (OBJ_MOTOR.Url.Host = Nothing) Then


            Exit Sub 'SAINDO DO PROCEDIMENTO


        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ATUALIZA LISTA DE URLS JÁ EXISTENTES -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        V_LISTA_DE_HISTORICO_URL_JA_EXISTE = V_LISTA_DE_HISTORICO_URL_JA_EXISTE & V_CONTEUDO_DE_INDICE 'ATUALIZANDO

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'CRIA PASTA DE SITE VISITADO --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        My.Computer.FileSystem.CreateDirectory(V_HOST_DE_SITE_VISITADO_PASTA) 'CRIANDO PASTA

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'SALVANDO IMAGEM E VALOR ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        IMG_IMAGEM_DE_SITE = FUNC_RETORNE_IMAGEM_DE_MOTOR_GECKOFX_APENAS_VISUALIZACAO(OBJ_MOTOR) 'RETORNA SOMENTE A PARTE EM VISUALIZAÇÃO DO MOTOR

        IMG_IMAGEM_DE_SITE = IMG_IMAGEM_DE_SITE.GetThumbnailImage(V_TAMANHO_DE_IMAGENS_DE_HISTORICO, V_TAMANHO_DE_IMAGENS_DE_HISTORICO, Nothing, Nothing) 'OBTENDO MINIATURA

        IMG_IMAGEM_DE_SITE.Save(V_ARQUIVO_DE_HISTORICO_IMAGEM) 'SALVANDO IMAGEM

        My.Computer.FileSystem.WriteAllText(V_ARQUIVO_DE_INDICE_DE_HISTORICO, V_CONTEUDO_DE_INDICE, True) 'SALVANDO INDICE

        My.Computer.FileSystem.WriteAllText(V_ARQUIVO_DE_HISTORICO_URL_DE_CADA_IMAGEM, OBJ_MOTOR.Url.AbsoluteUri & vbCrLf & OBJ_MOTOR.DocumentTitle, False) 'SALVANDO A URL DE CADA IMAGEM

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ATUALIZANDO O CONTADOR -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        V_CONTADOR_DE_ITENS_DE_HISTORICO = V_CONTADOR_DE_ITENS_DE_HISTORICO + 1 'ATUALIZA O CONTADOR

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




    End Sub

    Public Sub PROC_PROCESSAR_CONTEUDO_DE_HISTORICO_SALVO_NO_COMPUTADOR() 'PROCESSA O CONTEÚDO DE HISTÓRICO SALVO NO COMPUTADOR
        On Error Resume Next

        Dim V_CONTADOR_DE_TABELA As Integer = 1 'CONTADOR DA TABELA

        Dim V_ARQUIVO_DE_INDICE_DE_HISTORICO_HTML As String = V_PASTA_DE_HISTORICO_DE_SITES_VISITADOS & "\indice" & V_EXTENCAO_DE_ARQUIVO_2 'INFORMA O ARQUIVO DE INDICE GERAL

        Dim ARRAY_ITENS As Array = Split(V_LISTA_DE_HISTORICO_URL_JA_EXISTE, V_SEPARADOR_DE_STRINGS_2) 'SEPARANDO ITENS DE ARRAY

        Dim V_CONTADOR As Integer = 1 'CONTADOR DE LOOPING

        Dim V_CODIGO_HTML_GERADO_HISTORICO As String = Nothing 'CODIGO HTML DE HISTORICO GERADO

        Dim V_CODIGO_DE_TABELA As String = Nothing 'CODIGO DE GERAÇÃO DE TABELA

        Dim V_CODIGO_HTML_DE_INICIO As String = "<HTML><HEAD><TITLE>Histórico</TITLE></HEAD><style type='text/css'>body{background-color: #1E1E1E;color: #000000;}</style><style type='text/css'>a{color: #C0C0C0;text-decoration: none;}a:visited{color: #C0C0C0;}a:active{color: #C0C0C0;}a:hover{color: #C0C0C0;text-decoration: none;}</style><BODY><CENTER><BR></BR><span style='color:#F0F0F0;font-family:Arial;font-size:32px;'>Sites que você acessou</span></div><BR></BR><TABLE BORDER='0' CELLPADDING=35>" 'CODIGO DE INICIO DE HTML

        Dim V_CODIGO_HTML_DE_FIM As String = "</TABLE></CENTER><center> <span style='color:#C0C0C0;font-family:Arial;font-size:24px;'><BR></BR><strong>Que tal pesquisar no Google</strong></span></div> <form name='formulario1' action='http://www.google.com.br/search' method='get'><span style='color:#D2D2D2;font-family:Arial;font-size:14px;'><img src='chrome://global/content/3.png' align='center'></img><input type='text' name='q' style=' width: 300px'></input> <input type='submit' value='Pesquisar'></input></span></form><span style='color:#D2D2D2;font-family:Arial;font-size:11px;'>Para novas atualizações <a href='http://www.baixabit.com.br' style='text-decoration:none'>http://www.baixabit.com.br</a><br></br>Software desenvolvido por Microsete SLM<span style='color:#D2D2D2;font-family:Arial;font-size:9.7px;'>®</span></span></center><BR></BR></BODY></HTML>" 'CODIGO HTML DE FIM

        Dim V_QUANTIDADE_DE_RESULTADOS_EXIBIDOS As Integer = 1 'QUANTIDADE DE RESULTADOS EXIBIDOS

        Dim V_CODIGO_HTML_EXTRA_1 As String 'CODIGO HTML EXTRA






        'LIMPANDO ULTIMO ARQUIVO DE INDICE DE HTML -------------------------------------------------------------------------------------------------------------

        My.Computer.FileSystem.WriteAllText(V_ARQUIVO_DE_INDICE_DE_HISTORICO_HTML, Nothing, False) 'LIMPANDO...

        '-------------------------------------------------------------------------------------------------------------------------------------------------------




        'LIMPA VALORES ANTIGOS DO AUTOCOMPLETAR ----------------------------------------------------------------------------------------------------------------

        V_DADOS_DO_RECURSO_DE_AUTOCOMPLETAR = Nothing 'LIMPANDO...

        '-------------------------------------------------------------------------------------------------------------------------------------------------------




        'ATUALIZANDO VALORES -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        For V_CONTADOR = V_CONTADOR To ARRAY_ITENS.Length - 1



            Dim V_URL As String = ARRAY_ITENS(V_CONTADOR) 'OBTENDO A URL DE HISTORICO

            Dim V_TITULO As String = ARRAY_ITENS(V_CONTADOR + 1) 'OBTENDO O TITULO DE HISTORICO

            Dim V_TITULO_2 As String = ARRAY_ITENS(V_CONTADOR + 1) 'OBTENDO O TITULO DE HISTORICO TITULO DA IMAGEM AO PASSAR O MOUSE

            Dim V_IMAGEM_END As String = ARRAY_ITENS(V_CONTADOR + 2) 'OBTENDO O ENDEREÇO DA IMAGEM DE HISTÓRICO






            'ATUALIZANDO O CONTADOR ----------------------------------------------------------------------------------------------

            V_CONTADOR = V_CONTADOR + 2 'ATUALIZANDO...

            '---------------------------------------------------------------------------------------------------------------------




            'CONVERTE O TITULO PARA MINUSCULO ------------------------------------------------------------------------------------

            V_TITULO = V_TITULO.ToLower 'CONVERTENDO...

            V_TITULO_2 = V_TITULO.ToLower 'CONVERTENDO...

            '---------------------------------------------------------------------------------------------------------------------




            'LIMITAR QUANTIDADE DE ITENS EM TITULO -------------------------------------------------------------------------------

            V_TITULO = V_TITULO.Substring(0, 28) & "..." 'LIMITANDO...

            '---------------------------------------------------------------------------------------------------------------------




            'CONVERTE O FILTRO PARA MINUSCULO ------------------------------------------------------------------------------------------------------------------

            V_FILTRO_DE_EXIBICAO_DE_HISTORICO_DE_SITES_VISITADOS = V_FILTRO_DE_EXIBICAO_DE_HISTORICO_DE_SITES_VISITADOS.ToLower 'CONVERTENDO...

            '---------------------------------------------------------------------------------------------------------------------------------------------------




            'ANALISA O FILTRO -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            If (V_URL.Contains(V_FILTRO_DE_EXIBICAO_DE_HISTORICO_DE_SITES_VISITADOS)) Or (V_TITULO.Contains(V_FILTRO_DE_EXIBICAO_DE_HISTORICO_DE_SITES_VISITADOS)) Or (V_IMAGEM_END.Contains(V_FILTRO_DE_EXIBICAO_DE_HISTORICO_DE_SITES_VISITADOS)) Then




                'GERANDO CODIGO DE TABELA -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                Select Case V_CONTADOR_DE_TABELA


                    Case 1
                        V_CODIGO_DE_TABELA = V_CODIGO_DE_TABELA & "<TR><TD>" & "<A HREF='" & V_URL & "'>" & "<IMG SRC='" & V_IMAGEM_END & "' WIDTH='" & V_TAMANHO_DE_IMAGENS_DE_HISTORICO & "' HEIGHT='" & V_TAMANHO_DE_IMAGENS_DE_HISTORICO & "' ALIGN='BOTTOM' BORDER='0' TITLE='" & V_TITULO_2 & "'> <BR CLEAR='ALL'>" & V_TITULO & " <BR></A>" & "</TD>" 'CODIGO


                    Case 2
                        V_CODIGO_DE_TABELA = V_CODIGO_DE_TABELA & "<TD>" & "<A HREF='" & V_URL & "'>" & "<IMG SRC='" & V_IMAGEM_END & "' WIDTH='" & V_TAMANHO_DE_IMAGENS_DE_HISTORICO & "' HEIGHT='" & V_TAMANHO_DE_IMAGENS_DE_HISTORICO & "' ALIGN='BOTTOM' BORDER='0' TITLE='" & V_TITULO_2 & "'> <BR CLEAR='ALL'>" & V_TITULO & " <BR> </A>" & "</TD>" 'CODIGO


                    Case 3
                        V_CODIGO_DE_TABELA = V_CODIGO_DE_TABELA & "<TD>" & "<A HREF='" & V_URL & "'>" & "<IMG SRC='" & V_IMAGEM_END & "' WIDTH='" & V_TAMANHO_DE_IMAGENS_DE_HISTORICO & "' HEIGHT='" & V_TAMANHO_DE_IMAGENS_DE_HISTORICO & "' ALIGN='BOTTOM' BORDER='0' TITLE='" & V_TITULO_2 & "'> <BR CLEAR='ALL'>" & V_TITULO & " <BR> </A>" & "</TD></TR>" 'CODIGO
                        V_CONTADOR_DE_TABELA = 0 'RESETANDO VALOR


                End Select

                '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




                'REPASSA DADOS DO RECURSO DE AUTOCOMPLETAR -----------------------------------------------------------------------------------------------------

                V_DADOS_DO_RECURSO_DE_AUTOCOMPLETAR = V_DADOS_DO_RECURSO_DE_AUTOCOMPLETAR & V_SEPARADOR_DE_STRINGS_2 & V_URL 'REPASSANDO

                '-----------------------------------------------------------------------------------------------------------------------------------------------




                'INFORMA QUE ENCONTROU MAIS UM RESULTADO ------------------------------------------------------------

                V_QUANTIDADE_DE_RESULTADOS_EXIBIDOS = V_QUANTIDADE_DE_RESULTADOS_EXIBIDOS + 1 'ATUALIZANDO...

                '----------------------------------------------------------------------------------------------------




            Else




                'ZERA O CONTADOR DE TABELA ---------------------------------------------------------------------------------------------------------------------

                V_CONTADOR_DE_TABELA = 0 'RESETANDO VALOR

                '-----------------------------------------------------------------------------------------------------------------------------------------------




            End If


            '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'ATUALIZANDO CONTADOR DE TABLEA --------------------------------------------------------------------------------------------------------------------

            V_CONTADOR_DE_TABELA = V_CONTADOR_DE_TABELA + 1 'ATUALIZANDO CONTADOR DE TABELA

            '---------------------------------------------------------------------------------------------------------------------------------------------------




        Next

        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'GERA CODIGO HTML EXTRA ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        V_CODIGO_HTML_EXTRA_1 = "<span style='color:#C0C0C0;font-family:Arial;font-size:13px;'><strong>Em seu histórico contém " & ARRAY_ITENS.Length \ 3 & " itens<BR>Exibindo " & V_QUANTIDADE_DE_RESULTADOS_EXIBIDOS - 1 & " itens encontrados</strong></span></div>" 'CODIGO EXTRA

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ATUALIZANDO CODIGO A SER GRAVADO ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        V_CODIGO_HTML_GERADO_HISTORICO = V_CODIGO_HTML_DE_INICIO & V_CODIGO_DE_TABELA & V_CODIGO_HTML_EXTRA_1 & V_CODIGO_HTML_DE_FIM 'ATUALIZANDO...

        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ESCREVENDO CODIGO HTML GERADO -------------------------------------------------------------------------------------------------------------------------

        My.Computer.FileSystem.WriteAllText(V_ARQUIVO_DE_INDICE_DE_HISTORICO_HTML, V_CODIGO_HTML_GERADO_HISTORICO, False) 'ESCREVENDO CODIGO HTML

        '-------------------------------------------------------------------------------------------------------------------------------------------------------




    End Sub

    Public Sub PROC_PROCESSAR_HISTORICO_DE_NAVEGACAO_DE_USUARIO() 'PROCESSA O HISTORICO DE NAVEGAÇAO FEITA PELO USUÁRIO
        On Error Resume Next


        'PARANDO ULTIMO PROCESSO -------------------------------------------------------------------------------------------------------------------------------

        OBJ_BCK_PROCESSADOR_DE_HISTORICO.CancelAsync() 'CANCELANDO...

        '-------------------------------------------------------------------------------------------------------------------------------------------------------




        'REMOVE EVENTOS ANTIGOS ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        RemoveHandler OBJ_BCK_PROCESSADOR_DE_HISTORICO.DoWork, AddressOf PROC_EVENTO_DE_PROCESSAMENTO_DE_HISTORICO 'EVENTO DE PROCESSAMENTO DE HISTORICO

        RemoveHandler OBJ_BCK_PROCESSADOR_DE_HISTORICO.RunWorkerCompleted, AddressOf PROC_EVENTO_DE_PROCESSAMENTO_DE_HISTORICO_COMPLETADO 'EVENTO DE PROCESSAMENTO DE HISTORICO COMPLETADO

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ADICIONADO EVENTOS -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        AddHandler OBJ_BCK_PROCESSADOR_DE_HISTORICO.DoWork, AddressOf PROC_EVENTO_DE_PROCESSAMENTO_DE_HISTORICO 'EVENTO DE PROCESSAMENTO DE HISTORICO

        AddHandler OBJ_BCK_PROCESSADOR_DE_HISTORICO.RunWorkerCompleted, AddressOf PROC_EVENTO_DE_PROCESSAMENTO_DE_HISTORICO_COMPLETADO 'EVENTO DE PROCESSAMENTO DE HISTORICO COMPLETADO

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'PROCESSANDO -------------------------------------------------------------------------------------------------------------------------------------------

        OBJ_BCK_PROCESSADOR_DE_HISTORICO.RunWorkerAsync() 'RODANDO E PROCESSANDO...

        '-------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_PROCESSAMENTO_DE_HISTORICO_COMPLETADO_EXIBIR_RESULTADO() 'EXIBE O RESULTADO DO PROCESSAMENTO DE HISTORICO
        On Error Resume Next

        Dim V_ARQUIVO_DE_INDICE_DE_HISTORICO_HTML As String = V_PASTA_DE_HISTORICO_DE_SITES_VISITADOS & "\indice" & V_EXTENCAO_DE_ARQUIVO_2 'INFORMA O ARQUIVO DE INDICE GERAL






        'ABRINDO CONTEUDO GERADO -------------------------------------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_EXIBIDOR_DE_HISTORICO.MOTOR_GECKOFX.Navigate(V_ARQUIVO_DE_INDICE_DE_HISTORICO_HTML) 'ABRINDO RESULTADO

        '-------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_EXIBIR_O_FORMULARIO_DE_HISTORICOS_PROCESSADOS() 'EXIBE O FORMULÁRIO DE HISTÓRICOS PROCESSADOS
        On Error Resume Next



        'VERIFICA SE O FORMULÁRIO JÁ ESTÁ ABERTO OU NÃO ---------------------------------------------------------------------------------------------------------------------------------------

        If (FRM_FORMULARIO_EXIBIDOR_DE_HISTORICO.Visible = False) And (V_CONFIG_TEMP_RECURSO_DE_AUTOCOMPLETAR_IMAGENS = True) Then




            'MOVENDO O FOCO PARA A BARRA DE ENDEREÇOS --------------------------------------------------------------------------------------------------------------

            PROC_FOCAR_A_BARRA_DE_ENDERECOS(1) 'FOCA NA BARRA DE ENDEREÇOS

            '-------------------------------------------------------------------------------------------------------------------------------------------------------




            'REMOVENDO EVENTO DE MUDANÇA DE ABAS -------------------------------------------------------------------------------------------------------------------

            RemoveHandler FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.SelectedTabChanged, AddressOf TAB_ABAS_SELECIONAR_OUTRA_ABA

            '-------------------------------------------------------------------------------------------------------------------------------------------------------




            'FECHANDO FORMULARIO ANTIGO, ADICIONANDO NOVO, E MOVENDO FOCO PARA BARRA DE ENDEREÇOS ------------------------------------------------------------------

            FRM_FORMULARIO_EXIBIDOR_DE_HISTORICO.Close() 'FECHANDO FORMULARIO

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.TabPages.Add(FRM_FORMULARIO_EXIBIDOR_DE_HISTORICO) 'NOVA ABA DO NAVEGADOR

            '-------------------------------------------------------------------------------------------------------------------------------------------------------




            'MOVENDO O FOCO PARA A BARRA DE ENDEREÇOS --------------------------------------------------------------------------------------------------------------

            PROC_FOCAR_A_BARRA_DE_ENDERECOS(2) 'FOCA NA BARRA DE ENDEREÇOS

            '-------------------------------------------------------------------------------------------------------------------------------------------------------




            'ADICIONA EVENTO DE MUDANÇA DE ABAS --------------------------------------------------------------------------------------------------------------------

            AddHandler FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.SelectedTabChanged, AddressOf TAB_ABAS_SELECIONAR_OUTRA_ABA 'EVENTO DE MUDANÇA DE ABAS

            '-------------------------------------------------------------------------------------------------------------------------------------------------------




        End If

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_FECHAR_O_FORMULARIO_DE_HISTORICOS_PROCESSADOS() 'FECHA O FORMULÁRIO DE  HISTÓRICOS PROCESSADOS
        On Error Resume Next


        'FECHANDO O FORMULÁRIO ---------------------------------------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_EXIBIDOR_DE_HISTORICO.Close() 'FECHANDO O FORMULÁRIO

        PROC_FECHAR_O_HISTORICO_EXIBIDO_NO_FORM_PRINCIPAL() 'FECHA O HISTÓRICO EXIBIDO NO FORMULARIO PRINCIPAL

        '-------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_LIMPA_VARIAVEIS_DE_HISTORICO() 'LIMPA AS VARIÁVEIS DE HISTÓRICO
        On Error Resume Next


        'LIMPA VARIÁVEL DE HISTORICO --------------------------------------------------------------------------------

        V_LISTA_DE_HISTORICO_URL_JA_EXISTE = "" 'LIMPA A VARIÁVEL DE  HISTORICO

        V_DADOS_DO_RECURSO_DE_AUTOCOMPLETAR = "" 'LIMPA A VARIÁVEL DE  HISTORICO

        '------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_FECHAR_O_HISTORICO_EXIBIDO_NO_FORM_PRINCIPAL() 'FECHA O HISTÓRICO EXIBIDO NO FORMULARIO PRINCIPAL
        On Error Resume Next


        'FECHA O FORMULÁRIO DE HISTORICO SE ESTIVER ABERTO ---------------------------------------------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_EXIBIDOR_DE_HISTORICO.Close() 'FECHANDO O FORMULÁRIO...

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PN_PRINCIPAL.Dock = DockStyle.Fill 'PAINEL DE FORMULARIO PRINCIPAL OCUPAR TODO O FORMULARIO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PN_HISTORICO.Visible = False 'OCULTA O PAINEL DE AÇÕES SOBRE O HISTORICO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PN_HISTORICO.Dock = DockStyle.Left 'PREENCHIMENTO LADO ESQUERDO DO FORMULARIO

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_ADD_HISTORICO_AOS_FAVORITOS(ByVal V_URL_DE_HISTORICO As String, ByVal V_TITULO_DE_HISTORICO As String) 'ADICIONA O HISTÓRICO AOS FAVORITOS
        On Error Resume Next

        Dim V_PASTA_ONDE_SALVAR As String = V_PASTA_DE_MEUS_FAVORITOS_END 'PASTA ONDE SERA SALVO O FAVORITO

        Dim V_TITULO As String = V_TITULO_DE_HISTORICO 'TITULO DE FAVORITO






        'PROCESSANDO O TITULO ----------------------------------------------------------------------------------------------------------------------------------

        V_TITULO = V_TITULO.Replace(".", Nothing) 'REMOVE PONTO

        V_TITULO = V_TITULO.TrimStart 'REMOVE ESPAÇO EM BRANCO DE INICIO

        V_TITULO = V_TITULO.TrimEnd 'REMOVE ESPAÇO EM BRANCO DE FIM

        V_TITULO = FUNC_REMOVE_CARACTERES_ESPECIAIS(V_TITULO) 'REMOVE OS CARACTERES ESPECIAIS

        '-------------------------------------------------------------------------------------------------------------------------------------------------------




        'SALVANDO O FAVORITO AGORA -----------------------------------------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(V_URL_DE_HISTORICO, V_PASTA_ONDE_SALVAR & "\" & V_TITULO & V_EXTENCAO_DE_ARQUIVO_4) 'SALVA O ARQUIVO

        '-------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_PROCESSAR_DADOS_MENU_AUTO_COMPLETAR_COM_FILTRO_DEFIN_USUARIO(ByVal V_FILTRO As String) 'PROCESSA OS DADOS DO MENU DE AUTO-COMPLETAR COM FILTRO DEFINIDO PELO USUÁRIO
        On Error Resume Next

        Dim ARRAY_DE_DADOS_DE_AUTOCOMPLETAR As Array = Split(V_DADOS_DO_RECURSO_DE_AUTOCOMPLETAR, V_SEPARADOR_DE_STRINGS_2) 'SEPARANDO EM ARRAY

        Dim V_VALORES_LIDOS As String = Nothing 'VALORES LIDO EM ARRAY

        Dim V_MAX As Integer = 12 'QUANTIDADE MÁXIMA DE ITENS A EXIBIR

        Dim V_CONTADOR As Integer = 1 'CONTADOR DE LEITURA DE DADOS






        'VARRENDO ARRAY DE VALORES ------------------------------------------------------------------------------------------------------------

        For Each I In ARRAY_DE_DADOS_DE_AUTOCOMPLETAR


            Dim V_VALOR As String = I 'VALOR OBTIDO DA LEITURA






            'ATUALIZA OS VALORES ---------------------------------------------------------------------------------------

            If (V_VALOR.Contains(V_FILTRO)) Then


                V_VALORES_LIDOS = V_VALORES_LIDOS & vbCrLf & V_VALOR 'ATUALIZANDO DADOS DE VALORES

                V_VALORES_DE_AUTO_COMPLETAR_OBTIDOS_COM_FILTRO = V_VALORES_LIDOS 'IGUALANDO OS VALORES


            End If

            '-----------------------------------------------------------------------------------------------------------




            'SAINDO DO PROCEDIMENTO ------------------------------------------------------------------------------------

            If (V_CONTADOR > V_MAX) Then


                V_VALORES_DE_AUTO_COMPLETAR_OBTIDOS_COM_FILTRO = V_VALORES_LIDOS 'IGUALANDO OS VALORES

                Exit Sub 'SAINDO DO PROCEDIMENTO


            End If

            '-----------------------------------------------------------------------------------------------------------




            'ATUALIZA O CONTADOR ---------------------------------------------------------------------------------------

            V_CONTADOR = V_CONTADOR + 1 'ATUALIZANDO

            '-----------------------------------------------------------------------------------------------------------




        Next

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_EXIBIR_MENU_AUTO_COMPLETAR_COM_FILTRO_DEFIN_USUARIO() 'EXIBE O MENU DE AUTO-COMPLETAR COM FILTRO DEFINIDO PELO USUÁRIO
        On Error Resume Next

        Dim ARRAY_VALORES_DE_RECURSO_AUTOCOMPLETAR As Array = Split(V_VALORES_DE_AUTO_COMPLETAR_OBTIDOS_COM_FILTRO, vbCrLf) 'SEPARANDO VALORES DE RECURSO DE AUTO-COMPLETAR

        Dim V_TEXTO_DA_BARRA_DE_ENDERECOS As String = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CBO_ENDERECO_DO_SITE.Text 'TEXTO DA BARRA DE ENDEREÇOS

        Dim V_PONTO As New Point(FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.Location) 'PONTO DE LOCALIZAÇÃO DO MENU






        'LIMPA ITENS ANTIGOS ---------------------------------------------------------------------------------------------------------------------------

        OBJ_MENU_DE_CONTEXTO.Items.Clear() 'LIMPANDO ITENS ANTIGOS

        '-----------------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA SE USA O RECURSO AUTO-COMPLETAR ------------------------------------------------------------------------------------------------------

        If (V_CONFIG_TEMP_RECURSO_DE_AUTOCOMPLETAR = False) Or (ARRAY_VALORES_DE_RECURSO_AUTOCOMPLETAR.Length = 0) Then


            OBJ_MENU_DE_CONTEXTO.Close() 'FECHANDO O MENU

            Exit Sub 'SAINDO


        End If

        '-----------------------------------------------------------------------------------------------------------------------------------------------




        'DESABILITA O AUTO-CLOSE -----------------------------------------------------------------------------------------------------------------------

        OBJ_MENU_DE_CONTEXTO.AutoClose = False 'DESABILITA O AUTO-CLOSE

        '-----------------------------------------------------------------------------------------------------------------------------------------------




        'DEFINE TAMANHO, ETC... ----------------------------------------------------------------------------------------------------------------

        OBJ_MENU_DE_CONTEXTO.Width = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CBO_ENDERECO_DO_SITE.Size.Width 'LARGURA DO MENU

        OBJ_MENU_DE_CONTEXTO.Height = 375 'ALTURA DO MENU

        OBJ_MENU_DE_CONTEXTO.AutoSize = False 'AUTOSIZE

        OBJ_MENU_DE_CONTEXTO.RenderMode = ToolStripRenderMode.System 'TIPO DE RENDERMODE

        '---------------------------------------------------------------------------------------------------------------------------------------




        'LENDO VALORES DE ARRAY ------------------------------------------------------------------------------------------------------------------------

        For Each I In ARRAY_VALORES_DE_RECURSO_AUTOCOMPLETAR


            Dim V_VALOR As String = I 'VALOR DE ITEM OBTIDO

            Dim V_URL As New Uri(V_VALOR) 'URL DE SITE






            'ADICIONA ITEM DE MENU E DADOS -------------------------------------------------------------------------------------------------------------

            If (V_VALOR.Length > 0) Then


                Dim OBJ_ITEM As New ToolStripMenuItem 'NOVO ITEM DE MENU






                'ADICIONA O ITEM -----------------------------------------------------------------------------------------------------------------------

                OBJ_MENU_DE_CONTEXTO.Items.Add(OBJ_ITEM) 'ADICIONA NOVO ITEM

                OBJ_ITEM.Tag = V_VALOR 'TAG DE OBJETO

                '---------------------------------------------------------------------------------------------------------------------------------------




                'DEFINE TAMANHO, ETC... ----------------------------------------------------------------------------------------------------------------

                OBJ_MENU_DE_CONTEXTO.Width = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CBO_ENDERECO_DO_SITE.Size.Width 'LARGURA DO MENU

                OBJ_MENU_DE_CONTEXTO.Height = 375 'ALTURA DO MENU

                OBJ_MENU_DE_CONTEXTO.AutoSize = False 'AUTOSIZE

                OBJ_MENU_DE_CONTEXTO.RenderMode = ToolStripRenderMode.System 'TIPO DE RENDERMODE

                '---------------------------------------------------------------------------------------------------------------------------------------




                'ADICIONA VALOR DE TEXTO DE ITEM -------------------------------------------------------------------------------------------------------

                If (V_VALOR.Length > 90) Then

                    V_VALOR = V_VALOR.Substring(0, 90) & "..." 'VALOR DE TEXTO DE MENU

                End If

                '---------------------------------------------------------------------------------------------------------------------------------------




                'TEXTO DO MENU -------------------------------------------------------------------------------------------------------------------------

                OBJ_ITEM.Text = V_URL.Host & vbCrLf & V_VALOR 'TEXTO DE ITEM

                '---------------------------------------------------------------------------------------------------------------------------------------




                'ADICIONA EVENTO -----------------------------------------------------------------------------------------------------------------------

                AddHandler OBJ_ITEM.Click, AddressOf PROC_HISTORICO_PROCESSADO_CLICAR_EM_ITEM 'EVENTO CLICAR EM DADO DE HISTORICO PROCESSADO

                '---------------------------------------------------------------------------------------------------------------------------------------




            End If

            '-------------------------------------------------------------------------------------------------------------------------------------------




        Next

        '-----------------------------------------------------------------------------------------------------------------------------------------------




        'DEFINE TAMANHO, ETC... ----------------------------------------------------------------------------------------------------------------

        OBJ_MENU_DE_CONTEXTO.Width = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CBO_ENDERECO_DO_SITE.Size.Width 'LARGURA DO MENU

        OBJ_MENU_DE_CONTEXTO.Height = 375 'ALTURA DO MENU

        OBJ_MENU_DE_CONTEXTO.AutoSize = False 'AUTOSIZE

        OBJ_MENU_DE_CONTEXTO.RenderMode = ToolStripRenderMode.System 'TIPO DE RENDERMODE

        '---------------------------------------------------------------------------------------------------------------------------------------




        'ABRINDO MENU ----------------------------------------------------------------------------------------------------------------------------------

        OBJ_MENU_DE_CONTEXTO.Show(V_PONTO.X + 90, V_PONTO.Y + 85) 'ABRINDO...

        '-----------------------------------------------------------------------------------------------------------------------------------------------




        'PERMITE O AUTO-CLOSE --------------------------------------------------------------------------------------------------------------------------

        OBJ_MENU_DE_CONTEXTO.AutoClose = True 'PERMITE O AUTO-CLOSE

        '-----------------------------------------------------------------------------------------------------------------------------------------------


    End Sub










    'RELACIONADO A EXIBIR O HISTÓRICO NO FORMULARIO PRINCIPAL

    Public Sub PROC_EXIBIR_HISTORICO_ORGANIZADO_EM_FRM_PRINCIPAL_PAINEL() 'EXIBE NO PAINEL DE HISTORICO DE FORMULARIO PRINCIPAL, O HISTÓRICO ORGANIZADO
        On Error Resume Next

        Dim ARRAY_DE_PASTAS_LISTA As New ArrayList 'ARRAY COM ENDEREÇOS DE PASTAS

        Dim ARRAY_DE_ARQUIVOS As New ArrayList 'NOVO ARRAY DE ARQUIVOS

        Dim V_LISTA_DE_NODES_ADICIONADOS As String = "" 'LISTA DE NODES ADICIONADOS

        Dim OBJ_IML_IMAGENS As New ImageList 'NOVA LISTA DE IMAGEM

        Static V_JA_AVISOU As Boolean = False 'INFORMA QUE JÁ AVISOU AO USUÁRIO






        'LIMPA VALORES ANTIGOS -----------------------------------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TRV_HISTORICO.Nodes.Clear() 'LIMPANDO

        '---------------------------------------------------------------------------------------------------------------------------------------------------




        '1° ETAPA LISTA AS PASTAS

        'LISTANDO AS PASTAS --------------------------------------------------------------------------------------------------------------------------------

        PROC_OBTER_TODAS_AS_PASTAS(V_PASTA_DE_HISTORICO_DE_SITES_VISITADOS, ARRAY_DE_PASTAS_LISTA) 'OBTEM TODAS AS PASTAS

        '---------------------------------------------------------------------------------------------------------------------------------------------------




        '2° ETAPA LISTA TODOS OS ARQUIVOS AGORA

        'LISTA ARQUIVOS AGORA -----------------------------------------------------------------------------------------------------------------------------

        For Each V_ITEM_DE_PASTA In ARRAY_DE_PASTAS_LISTA


            PROC_OBTER_TODOS_OS_ARQUIVOS(V_ITEM_DE_PASTA, ARRAY_DE_ARQUIVOS, "*.txt*") 'OBTEM TODOS OS ARQUIVOS


        Next

        '---------------------------------------------------------------------------------------------------------------------------------------------------




        'INFORMA AO USUÁRIO QUE DEVE ESPERAR, PORQUE TEM MUITOS ARQUIVOS -----------------------------------------------------------------------------------

        If (ARRAY_DE_ARQUIVOS.Count >= V_QUANTIDADE_DE_ITENS_DE_HISTORICO_EXCESSO) And (V_JA_AVISOU = False) Then

            PROC_CHAMAR_JANELA_DE_AVISOS(V_MS11, 2) 'FORMULARIO DE AVISOS

            V_JA_AVISOU = True 'INFORMA QUE JÁ AVISOU

        End If

        '---------------------------------------------------------------------------------------------------------------------------------------------------




        '3° ETAPA PROCESSA OS ARQUIVOS AGORA

        'ADICIONA OS ARQUIVOS AGORA ----------------------------------------------------------------------------------------------------------------------------------

        For Each V_ITEM_DE_PASTA In ARRAY_DE_ARQUIVOS


            Dim V_INFORMACAO_DE_DIRETORIO As New DirectoryInfo(V_ITEM_DE_PASTA) 'INFORMAÇÕES SOBRE O DIRETORIO

            Dim V_DATA_DE_CRIACAO As String = V_INFORMACAO_DE_DIRETORIO.CreationTime.Date 'DATA DA CRIAÇÃO DO ARQUIVO

            Dim OBJ_NODE_PRINCIPAL As New TreeNode 'OBJETO DE NODE

            Dim OBJ_NODE_FILHO As TreeNode 'NODE FILHO






            'ADICIONA NODES A LISTA ----------------------------------------------------------------------------------------------------------------------------------

            If (V_LISTA_DE_NODES_ADICIONADOS.Contains(V_DATA_DE_CRIACAO) = False) Then


                Dim V_DATA_DE_NODE_PAI As String = V_DATA_DE_CRIACAO 'DATA DO NODE PAI




                'INFORMA A DATA DE HOJE OU NAO -----------------------------------------------------------------------------------------------------------------------

                If (V_DATA_DE_CRIACAO = Date.Today) Then


                    V_DATA_DE_NODE_PAI = "Hoje" 'AO INVEZ DE INFORMAR A DATA, INFORMA O TEXTO HOJE


                End If

                '-----------------------------------------------------------------------------------------------------------------------------------------------------




                'VERIFICA SE O NODE PAI ESTA NA LISTA ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                OBJ_IML_IMAGENS.Images.Add("calendario.png", FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.IML_IMAGENS_2.Images.Item(FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.IML_IMAGENS_2.Images.IndexOfKey("calendario.png"))) 'ADICIONA IMAGEM E CHAVE

                V_LISTA_DE_NODES_ADICIONADOS = V_LISTA_DE_NODES_ADICIONADOS & vbCrLf & V_DATA_DE_CRIACAO 'ATUALIZA STRING DE COMPARAÇÃO DE NODES EXISTENTES

                OBJ_NODE_PRINCIPAL.Text = V_DATA_DE_NODE_PAI 'DEFINE DATA DE CRIAÇÃO DE NODE PAI

                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TRV_HISTORICO.Nodes.Add(OBJ_NODE_PRINCIPAL) 'ATUALIZANDO ARRAY

                OBJ_NODE_PRINCIPAL.ImageKey = "calendario.png"

                '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




                'ADICIONANDO NODES FILHOS ----------------------------------------------------------------------------------------------------------------------------

                For I = 0 To ARRAY_DE_ARQUIVOS.Count - 1


                    Dim V_INFORMACAO_DE_ARQUIVO As New DirectoryInfo(ARRAY_DE_ARQUIVOS(I)) 'INFORMAÇÕES SOBRE O DIRETORIO




                    'VERIFICA DATA DE NODE FILHO ---------------------------------------------------------------------------------------------------------------------

                    If (V_DATA_DE_CRIACAO = V_INFORMACAO_DE_ARQUIVO.CreationTime.Date) Then


                        Dim V_ENDERECO_DE_IMAGEM As String = Path.GetFullPath(ARRAY_DE_ARQUIVOS(I)) 'ENDEREÇO DE IMAGEM

                        Dim OBJ_IMAGEM As Image 'NOVA IMAGEM

                        Dim V_CONTEUDO_DE_NODE As String = FUNC_LER_ARQUIVO(ARRAY_DE_ARQUIVOS(I)) 'LENDO URL DE NODE

                        Dim ARRAY_CONTEUDO_DE_NODE As Array = Split(V_CONTEUDO_DE_NODE, vbCrLf) 'SEPARANDO URL E TITULO DE NODE

                        Dim V_TEXTO_DE_NODE_FILHO As String = ARRAY_CONTEUDO_DE_NODE(1) 'TEXTO OU TITULO DE NODE

                        Dim V_URL_DE_NODE_FILHO As String = ARRAY_CONTEUDO_DE_NODE(0) 'URL DE NODE






                        'DEFINE O IMAGELIST --------------------------------------------------------------------------------------------------------------------------------

                        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TRV_HISTORICO.ImageList = OBJ_IML_IMAGENS 'DEFININDO

                        '---------------------------------------------------------------------------------------------------------------------------------------------------




                        'NODE FILHO

                        V_ENDERECO_DE_IMAGEM = V_ENDERECO_DE_IMAGEM.Replace(V_EXTENCAO_DE_ARQUIVO_4, V_EXTENCAO_DE_ARQUIVO_3) 'TROCA EXTENÇÃO

                        OBJ_NODE_FILHO = New TreeNode 'NOVO NODE FILHO

                        OBJ_NODE_FILHO.Text = V_TEXTO_DE_NODE_FILHO 'TITULO DE NODE

                        OBJ_NODE_FILHO.Tag = V_URL_DE_NODE_FILHO 'URL DO NODE

                        OBJ_NODE_PRINCIPAL.Nodes.Add(OBJ_NODE_FILHO) 'ADICIONANDO NODE






                        'IMAGEM

                        OBJ_IMAGEM = FUNC_ARQUIVO_RETORNE_IMAGEM_EM_DISCO((V_ENDERECO_DE_IMAGEM)) 'CARREGA A IMAGEM NA MEMORIA

                        OBJ_IML_IMAGENS.Images.Add(V_ENDERECO_DE_IMAGEM, OBJ_IMAGEM) 'ADICIONA IMAGEM E CHAVE

                        OBJ_NODE_FILHO.ImageKey = V_ENDERECO_DE_IMAGEM 'SETA A IMAGEM

                        OBJ_NODE_FILHO.SelectedImageKey = V_ENDERECO_DE_IMAGEM 'SETA A IMAGEM




                    End If

                    '-------------------------------------------------------------------------------------------------------------------------------------------------


                Next


                '-----------------------------------------------------------------------------------------------------------------------------------------------------


            End If


            '---------------------------------------------------------------------------------------------------------------------------------------------------------




        Next

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




    End Sub

    Public Sub PROC_SELECIONAR_HISTORICO_NODE_EXIBIR_DADOS(ByVal V_IMAGEM_DE_NODE_KEY As String) 'AO SELECIONAR UM HISTÓRICO, FILHO DENTRO DA LISTA EXIBIR SUA IMAGEM ORIGINAL E INFORMAÇÕES.
        On Error Resume Next

        Dim OBJ_IMAGEM As Image 'OBJETO IMAGEM






        'CARREGA E SETA A IMAGEM -------------------------------------------------------------------------------------------------------------------------------------

        OBJ_IMAGEM = FUNC_ARQUIVO_RETORNE_IMAGEM_EM_DISCO(V_IMAGEM_DE_NODE_KEY) 'RETORNA A IMAGEM EXISTENTE EM DISCO

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA SE A IMAGEM POSSUI OU NAO FORMATO ------------------------------------------------------------------------------------------------------------------

        If (OBJ_IMAGEM.PixelFormat = Nothing) Then


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PIC_HISTORICO.Image = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PIC_HISTORICO.ErrorImage 'SETANDO A IMAGEM


        Else


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PIC_HISTORICO.Image = OBJ_IMAGEM 'SETANDO A IMAGEM


        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub










    'RELACIONADO AO AUTO-COMPLETAR

    Public Sub PROC_VERIFICA_SE_USA_O_RECURSO_AUTO_COMPLETAR_NORMAL_E_IMAGENS() 'VERIFICA SE USA O RECURO DE AUTO-COMPLETAR NORMAL E IMAGENS
        On Error Resume Next


        'LENDO CONFIGURAÇÕES ------------------------------------------------------------------------------------------------------------------

        V_CONFIG_TEMP_RECURSO_DE_AUTOCOMPLETAR = FUNC_LER_ARQUIVO(V_ARQUIVO_END_29) 'LÊ CONFIG DE ARQUIVO

        V_CONFIG_TEMP_RECURSO_DE_AUTOCOMPLETAR_IMAGENS = FUNC_LER_ARQUIVO(V_ARQUIVO_END_30) 'LÊ CONFIG DE ARQUIVO

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub










    'FAVORITOS

    Public Sub PROC_FAVORITOS_LISTAR_TODOS_SALVOS(ByVal OBJ_SUBITEM_ATUAL As Object, ByVal V_ENDERECO_DE_FAVORITOS_A_CARREGAR As String) 'LISTA TODOS OS ARQUIVOS DE FAVORITOS
        On Error Resume Next

        Dim OBJ_SUBITEM_PRINCIPAL As ToolStripMenuItem = CType(OBJ_SUBITEM_ATUAL, ToolStripMenuItem) 'CRIANDO OBJETO DE HERANÇA PARA NOVA ATUALIZAÇÃO DE VALORES DE FAVORITOS








        'ADICIONA SUBITEM DE SITE AGORA ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        Dim V_ARRAY_DE_ARQUIVOS As Array = FUNC_ARRAY_RETORNE_TODOS_OR_ARQUIVOS(V_ENDERECO_DE_FAVORITOS_A_CARREGAR) 'RETORNA TODOS OS ARQUIVOS DA PASTA

        Dim V_CONTADOR_2 As Integer = 0 'CONTADOR 2






        For V_CONTADOR_2 = V_CONTADOR_2 To V_ARRAY_DE_ARQUIVOS.Length - 1


            'CRIA SUBITEM E GERA O SEU TEXTO -----------------------------------------------------------------------

            Dim OBJ_SUB_ITEM As New ToolStripMenuItem 'NOVO MENU DE ITEM

            Dim V_NOME_DO_ARQUIVO As String = Path.GetFileName(V_ARRAY_DE_ARQUIVOS(V_CONTADOR_2)) 'NOME DO ARQUIVO




            V_NOME_DO_ARQUIVO = V_NOME_DO_ARQUIVO.Replace(V_NOME_DO_ARQUIVO.Substring(V_NOME_DO_ARQUIVO.Length - 4), Nothing)

            '-------------------------------------------------------------------------------------------------------






            'OBTENDO A IMAGEM AGORA ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            Dim OBJ_IMAGEM As Image = FUNC_RETORNE_FAVICON_SALVO_EM_PASTA_VIA_HOST(V_ENDERECO_DE_FAVORITOS_A_CARREGAR, V_NOME_DO_ARQUIVO) 'RETORNA O FAVICON JÁ SALVO NO HD VIA HOST DO SITE

            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'SETANDO PROPRIEDADES -----------------------------------------------------------------------------------------------------------------

            OBJ_SUB_ITEM.Text = V_NOME_DO_ARQUIVO 'DEFINE O TÍTULO DO FAVORITO

            OBJ_SUB_ITEM.Image = OBJ_IMAGEM 'SETANDO A IMAGEM

            OBJ_SUBITEM_PRINCIPAL.DropDownItems.Add(OBJ_SUB_ITEM) 'ADICIONANDO O SUBITEM

            OBJ_SUB_ITEM.ToolTipText = V_ENDERECO_DE_FAVORITOS_A_CARREGAR & "\" & V_NOME_DO_ARQUIVO & V_EXTENCAO_DE_ARQUIVO_4 'NOME DO ARQUIVO

            OBJ_SUB_ITEM.Name = V_NOME_GENERICO_DE_FAVORITOS & V_CONTADOR_2 'NOME DE FAVORITO

            '--------------------------------------------------------------------------------------------------------------------------------------




            'ADICIONA EVENTO AGORA ----------------------------------------------------------------------------------------------------------------

            AddHandler OBJ_SUB_ITEM.Click, AddressOf PROC_FAVORITOS_CLICOU_EM_FAVORITO

            AddHandler OBJ_SUB_ITEM.MouseUp, AddressOf PROC_FAVORITOS_MOUSE_UP_SOBRE_ITEM 'AO SOLTAR O MOUSE SOBRE O FAVORITO


            '--------------------------------------------------------------------------------------------------------------------------------------




        Next


        '---------------------------------------------------------------------------------------------------------------------------------------------------------------







    End Sub

    Public Sub PROC_FAVORITOS_LISTAR_TODOS(ByVal V_ENDERECO_DE_FAVORITOS_A_CARREGAR As String, ByRef OBJ_PARAMETRO As Object, ByVal V_LIMPAR_LISTA As Boolean) 'LISTA TODOS OS FAVORITOS
        On Error Resume Next

        Dim V_ARRAY_DE_PASTAS As Array = FUNC_ARRAY_RETORNE_TODAS_AS_PASTAS_E_SUB_PASTAS(V_ENDERECO_DE_FAVORITOS_A_CARREGAR) 'RETORNA TODAS AS PASTAS E SUBPASTAS EM FORMA DE ARRAY

        Dim V_CONTADOR_1 As Integer = 0 'CONTADOR 1






        'CRIANDO REFERENCIA AO OBJETO ----------------------------------------------------------------------------------

        Dim OBJ_DE_ITEM_CRIADO_AGORA As ToolStripMenuItem = CType(OBJ_PARAMETRO, ToolStripMenuItem) 'REFERENCIANDO

        '---------------------------------------------------------------------------------------------------------------




        'LIMPA ITENS ANTIGOS -------------------------------------------------------------------------------------------

        If (V_LIMPAR_LISTA = True) Then


            OBJ_DE_ITEM_CRIADO_AGORA.DropDownItems.Clear() 'LIMPANDO...


        End If

        '---------------------------------------------------------------------------------------------------------------











        For V_CONTADOR_1 = V_CONTADOR_1 To V_ARRAY_DE_PASTAS.Length - 1




            'CRIA SUBITEM E DEFINE TEXTO DE ITEM -----------------------------------------------------------------------

            Dim OBJ_ITEM As New ToolStripMenuItem 'NOVO MENU DE ITEM

            Dim V_NOME_DE_DIRETORIO As String = Path.GetFileName(V_ARRAY_DE_PASTAS(V_CONTADOR_1)) 'NOME DAS PASTAS

            '-----------------------------------------------------------------------------------------------------------






            'SETA TEXTO DE ITEM, SETA IMAGEM E ADICIONA COMO SUBITEM ---------------------------------------------------

            OBJ_ITEM.Text = V_NOME_DE_DIRETORIO 'NOME DE PASTA

            OBJ_ITEM.Image = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.IML_IMAGENS_1.Images.Item(0) 'SETA A IMAGEM

            OBJ_ITEM.Name = V_NOME_GENERICO_DE_PASTA_DE_FAVORITOS & V_CONTADOR_1 'DEFININDO NOME DE SUBITEM

            OBJ_DE_ITEM_CRIADO_AGORA.DropDownItems.Add(OBJ_ITEM) 'ADICIONA O ITEM

            '-----------------------------------------------------------------------------------------------------------




            'ADICIONA EVENTO DE NOVO SUBITEM -------------------------------------------------------------------------------------------------------------------------

            AddHandler OBJ_ITEM.DropDownOpening, AddressOf PROC_FAVORITOS_BARRA_DE_MENUS_ATUALIZAR_LISTA 'ATUALIZA OS FAVORITOS NA BARRA DE MENUS

            AddHandler OBJ_ITEM.MouseUp, AddressOf PROC_FAVORITOS_MOUSE_UP_SOBRE_ITEM 'AO SOLTAR O MOUSE SOBRE O FAVORITO


            '---------------------------------------------------------------------------------------------------------------------------------------------------------




            'DEFINE TOLTIP DO MENU --------------------------------------------------------------------------------------

            OBJ_ITEM.ToolTipText = V_ENDERECO_DE_FAVORITOS_A_CARREGAR & "\" & V_NOME_DE_DIRETORIO 'DEFININDO...

            '------------------------------------------------------------------------------------------------------------




        Next


        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




    End Sub










    'IMPRIMIR

    Public Sub PROC_DIVIDIR_A_IMAGEM_EM_PARTES(ByVal OBJ_IMAGEM_BITMAP_ORIGINAL As Bitmap, ByVal V_TAMANHO_DA_PAGINA As Integer) 'Procedimento de divisão de imagem
        On Error Resume Next

        Dim V_ALTURA As Integer = OBJ_IMAGEM_BITMAP_ORIGINAL.Height 'Altura da imagem

        Dim V_LARGURA As Integer = OBJ_IMAGEM_BITMAP_ORIGINAL.Width 'Largura da imagem

        Dim V_ALTURA_DA_FOLHA As Integer = V_TAMANHO_DA_PAGINA 'Altura da folha já definida

        Dim V_QUANTIDADE_DE_DIVISOES_POSSIVEIS As Integer = (V_ALTURA / V_TAMANHO_DA_PAGINA_WEB_PADRAO) 'Obtendo a quantidade de divisoes da imagem

        Dim V_TAMANHO_DE_CADA_PARTE As Integer = V_TAMANHO_DA_PAGINA  'Obtendo o tamanho de cada parte

        Dim V_CONTADOR As Integer = 0 'Contador de recorte

        V_QUANTIDADE_DE_ITENS_VISUALIZAR_IMPRESSAO = V_QUANTIDADE_DE_DIVISOES_POSSIVEIS 'Informa a quantidade de paginas de impressao






        'Modo landscape ativado ----------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PRT_IMPRIMIR.DefaultPageSettings.Landscape = True 'Landscape ativado

        '---------------------------------------------------------------------------------------------------------------




        'Inicializando loop para separação de imagem ------------------------------------------------------------------------------------------

        For V_CONTADOR = V_CONTADOR To V_QUANTIDADE_DE_DIVISOES_POSSIVEIS


            Dim V_RETANGULO As New RectangleF(0, V_TAMANHO_DE_CADA_PARTE * V_CONTADOR, V_LARGURA, V_TAMANHO_DE_CADA_PARTE) 'Novo retangulo

            Dim OBJ_IMG_IMAGE_TEMP As New Bitmap(V_LARGURA, V_TAMANHO_DE_CADA_PARTE) 'Nova imagem bitmap

            Dim G As Graphics = Graphics.FromImage(OBJ_IMG_IMAGE_TEMP) 'Novo grafico






            'Definindo imagem do grafico

            G.DrawImage(OBJ_IMAGEM_BITMAP_ORIGINAL, 0, 0, V_RETANGULO, GraphicsUnit.Pixel) 'Definindo imagem do grafico




            'Salvando a imagem temporaria

            My.Computer.FileSystem.DeleteFile(V_PASTA_DE_CONFIGURACOES_END_IMPRIMIR & "\" & V_NOME_GENERICO_DE_IMAGENS_DE_IMPRESSAO & V_CONTADOR & V_EXTENCAO_DE_ARQUIVO_3) 'Removendo temporario

            OBJ_IMG_IMAGE_TEMP.Save(V_PASTA_DE_CONFIGURACOES_END_IMPRIMIR & "\" & V_NOME_GENERICO_DE_IMAGENS_DE_IMPRESSAO & V_CONTADOR & V_EXTENCAO_DE_ARQUIVO_3) 'Salvando...



        Next

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_VISUALIZAR_IMPRESSAO_OU_IMPRIMIR(ByVal V_IMPRIMIR As Boolean) 'VISUALIZAR IMPRESSÃO OU IMPRIME
        On Error Resume Next

        Dim OBJ_IMAGEM As Bitmap = FUNC_RETORNE_IMAGEM_DE_MOTOR_GECKOFX_COMPLETO() 'RETORNA A IMAGEM DO MOTOR GECKOFX

        Dim V_ALTURA, V_LARGURA As Integer 'Largura e altura

        Dim V_TAMANHO_DA_PAGINA As Single 'Informa o tamanho da pagina






        'REMOVE TODOS OS ARQUIVOS ANTES EXISTENTES ------------------------------------------------------------------------

        PROC_REMOVER_TODOS_OS_ARQUIVOS(V_PASTA_DE_CONFIGURACOES_END_IMPRIMIR) 'REMOVE TODOS OS ARQUIVOS DA PASTA INFORMADA

        '------------------------------------------------------------------------------------------------------------------




        'OBTENDO ALTURA E LARGURA DE PÁGINA --------------------------------------------------------------------------------------------------------------------------

        V_ALTURA = CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).Document.Body.ClientHeight 'ALTURA

        V_LARGURA = CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).Document.Body.ClientWidth 'LARGURA

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Não permite imagem menor que o valor informado abaixo ser divida em duas partes ----------

        If (V_ALTURA <> V_TAMANHO_DA_PAGINA_WEB_PADRAO) Then


            V_TAMANHO_DA_PAGINA = V_TAMANHO_DA_PAGINA_WEB_PADRAO 'Recalculando valor...


        End If

        '-----------------------------------------------------------------------------------------




        'CRIA PASTA DE CONFIGURAÇÃO DE IMPRESSAO TEMPORARIA -----------------------------------------------------------------------------------

        My.Computer.FileSystem.CreateDirectory(V_PASTA_DE_CONFIGURACOES_END_IMPRIMIR) 'CRIANDO PASTA DE VISUALIZAÇÃO DE IMPRESSAO

        '--------------------------------------------------------------------------------------------------------------------------------------




        'DIVIDINDO A IMAGEM --------------------------------------------------------------------------------

        PROC_DIVIDIR_A_IMAGEM_EM_PARTES(OBJ_IMAGEM, V_TAMANHO_DA_PAGINA) 'Procedimento de divisão de imagem

        '-------------------------------------------------------------------------------------------




        'Visualizando impressao ou imprime -----------------------------------------------------------

        If (V_IMPRIMIR = False) Then


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PRT_VISUALIZAR.ShowDialog() 'Visualizando...


        Else


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PRT_IMPRIMIR.Print() 'Imprimindo...


        End If


        '---------------------------------------------------------------------------------------------




    End Sub










    'BACKUP DO CONTEUDO DA RAM

    Dim V_RAM_AUDIO_DADOS As Stream 'Vai conter os dados da ram

    Dim V_RAM_IMAGEM_DADOS As System.Drawing.Image 'Imagem backup

    Dim V_RAM_TEXTO_DADOS As String 'Texto de backup da ram










    Public Sub PROC_BACKUP_DE_CONTEUDO_DA_RAM() 'BACKUP DO CO NTEUDO DA MEMORIA RAM
        On Error Resume Next


        'OBTENDO DADOS -------------------------------------------------------------------------------------------------

        V_RAM_AUDIO_DADOS = My.Computer.Clipboard.GetAudioStream 'AUDIO

        V_RAM_IMAGEM_DADOS = My.Computer.Clipboard.GetImage 'IMAGEM

        V_RAM_TEXTO_DADOS = My.Computer.Clipboard.GetText 'TEXTO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_BACKUP_DE_CONTEUDO_DA_RAM_RESTAURAR() 'RESTAURA O CONTEUDO DA MEMÓRIA RAM
        On Error Resume Next


        'RESTAURA OS DADOS ---------------------------------------------------------------------------------------------

        My.Computer.Clipboard.SetAudio(V_RAM_AUDIO_DADOS) 'AUDIO

        My.Computer.Clipboard.SetImage(V_RAM_IMAGEM_DADOS) 'IMAGEM

        My.Computer.Clipboard.SetText(V_RAM_TEXTO_DADOS) 'TEXTO

        '---------------------------------------------------------------------------------------------------------------


    End Sub














    'RELACIONADO AOS MENUS DE OPÇOES DO BOTAO DIREITO

    Private Sub PROC_SALVAR_A_IMAGEM() 'SALVA A IMAGEM
        On Error Resume Next

        Dim OBJ_IMAGEM As Image 'NOVO OBJETO DE IMAGEM

        Static V_CONTADOR As Integer 'CONTADOR DE IMAGENS

        Dim V_EXTENCAO_DA_IMAGEM As String 'EXTENÇÃO DA IMAGEM






        'FAZ BACKUP DO CONTEUDO DA RAM ---------------------------------------------------------------------------------

        PROC_BACKUP_DE_CONTEUDO_DA_RAM() 'BACKUP DO CO NTEUDO DA MEMORIA RAM

        '---------------------------------------------------------------------------------------------------------------




        'OBTENDO A EXTENÇÃO DA IMAGEM ----------------------------------------------------------------------------------

        OBJ_MOTOR_DE_ACAO_EM_USO.CopyImageLocation() 'COPIANDO O ENDEREÇO DA IMAGEM

        V_EXTENCAO_DA_IMAGEM = Path.GetExtension(My.Computer.Clipboard.GetText) 'EXTENÇÃO

        '---------------------------------------------------------------------------------------------------------------




        'OBTENDO IMAGEM DE MOTOR ---------------------------------------------------------------------------------------

        OBJ_MOTOR_DE_ACAO_EM_USO.CopyImageContents() 'COPIANDO A IMAGEM

        OBJ_IMAGEM = My.Computer.Clipboard.GetImage 'OBTENDO A IMAGEM

        '---------------------------------------------------------------------------------------------------------------




        'PROPRIEDADES DE CAIXA DE DIÁLOGO DE SALVAR ARQUIVO -----------------------------------------------------------------------------------

        OBJ_DIALOGO_SALVAR_ARQUIVO = New SaveFileDialog 'NOVO DIÁLOGO DE SALVAR ARQUIVO

        OBJ_DIALOGO_SALVAR_ARQUIVO.Filter = "Imagens|*.jpg;*.bmp;*.jpeg;*.gif;*.png|Todas as imagens|*.*" 'FILTRO DE ARQUIVO

        OBJ_DIALOGO_SALVAR_ARQUIVO.FileName = "Nova imagem " & V_CONTADOR & V_EXTENCAO_DA_IMAGEM 'NOVO SOM

        '--------------------------------------------------------------------------------------------------------------------------------------




        'SALVANDO A IMAGEM ---------------------------------------------------------------------------------------------

        If (OBJ_DIALOGO_SALVAR_ARQUIVO.ShowDialog = DialogResult.OK) Then


            OBJ_IMAGEM.Save(OBJ_DIALOGO_SALVAR_ARQUIVO.FileName, System.Drawing.Imaging.ImageFormat.Bmp) 'SALVANDO A IMAGEM

            V_CONTADOR = V_CONTADOR + 1 'ATUALIZA O CONTADOR


        End If

        '---------------------------------------------------------------------------------------------------------------




        'RESTAURA O CONTEUDO DA RAM ------------------------------------------------------------------------------------

        PROC_BACKUP_DE_CONTEUDO_DA_RAM_RESTAURAR() 'RESTAURA O CONTEUDO DA MEMÓRIA RAM

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_MENU_ACAO_EXECUTAR(ByVal V_ACAO As Byte) 'AÇÃO DO MENU DO BOTAO DIREITO
        On Error Resume Next


        'AÇÃO SOBRE O MOTOR ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        Select Case V_ACAO


            Case 1

                If (FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.Visible = True) Then


                    'PEGA O INDEX DA ABA ATUAL, ADICIONA NOVA ABA, ABRE O LINK INFORMADO, E VERIFICA SE DEVE RETORNAR A ABA ANTERIOR A ADICIONADA -------------------------------------------

                    Dim V_INDEX_DA_ABA_ATUAL As Integer = FUNC_RETORNE_INDEX_DE_FORMULARIO(FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.SelectedForm) 'INDEX DE FORMULARIO ATUAL

                    PROC_NOVA_ABA_ADICIONAR() 'ADICIONA NOVA ABA

                    PROC_NAVEGAR(V_URL_ASSOCIADA_AO_MENU_DE_LINKS_MODULO_DE_EVENTOS) 'NAVEGA NO ENDEREÇO DE SITE INFORMADO





                    'VERIFICA AGORA SE DEVE RETORNAR A ABA ANTERIOR -------------------------------------------------------------------------------------------------------------------------

                    If (FUNC_LER_ARQUIVO(V_ARQUIVO_END_4) = True) Then

                        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.TabPages.Item(V_INDEX_DA_ABA_ATUAL).Select() 'SELECIONA A ÚLTIMA ABA ABERTA AGORA

                    End If

                    '------------------------------------------------------------------------------------------------------------------------------------------------------------------------




                    '------------------------------------------------------------------------------------------------------------------------------------------------------------------------




                End If


            Case 2

                If (FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.Visible = True) Then

                    PROC_NAVEGAR(V_URL_ASSOCIADA_AO_MENU_DE_LINKS_MODULO_DE_EVENTOS) 'NAVEGA NO ENDEREÇO DE SITE INFORMADO

                End If


            Case 3
                CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).CopyLinkLocation() 'OBTENDO ENDEREÇO DE LINK


            Case 4
                CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).CopyImageContents() 'COPIANDO A IMAGEM


            Case 5
                CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).CopyImageLocation() 'COPIANDO LOCAL DA IMAGEM


            Case 6
                CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).SelectAll() 'SELECIONAR TUDO


            Case 7
                CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).ViewSource() 'EXIBE O CODIGO FONTE


            Case 8
                CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).ShowPageProperties() 'EXIBE AS PROPRIEDADES


            Case 9
                PROC_TIRAR_FOTO_DO_SITE() 'TIRA FOTO DO SITE


            Case 10
                CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).Undo() 'DESFAZER


            Case 11
                CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).Redo() 'REFAZER


            Case 12
                CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).CutSelection() 'RECORTAR


            Case 13
                CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).CopySelection() 'COPIAR


            Case 14
                CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).Paste() 'COLAR


            Case 15
                CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).CutSelection() 'RECORTAR


            Case 16
                CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).SelectAll() 'SELECIONA TUDO


            Case 17
                PROC_SALVAR_A_IMAGEM() 'SALVA A IMAGEM


            Case 18
                PROC_DEFINIR_IMAGEM_COMO_PLANO_DE_FUNDO() 'DEFINE A IMAGEM COMO PLANO DE FUNDO























        End Select

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub















    'PROCEDIMENTOS BASICOS DO FORMULARIO DE NAVEGAÇÃO

    Public Sub PROC_VERIFICA_NUMERO_DE_ABAS_ABERTAS_AO_ADICIONAR() 'VERIFICA O NUMERO DE ABAS ABERTAS AO ADICIONAR NOVA ABA
        On Error Resume Next


        'VERIFICA SE É MAIOR QUE O NUMERO DE ABAS QUE CAUSAM TRAVAMENTO -------------------------------------------------------------------------------------------------

        If (FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.TabPages.Count > V_NUMERO_DE_ABAS_CAUSA_TRAVAMENTO) And (FUNC_LER_ARQUIVO(V_ARQUIVO_END_2) = True) Then


            PROC_CHAMAR_JANELA_DE_AVISOS(V_MS2, 0) 'FORMULARIO DE AVISOS


        End If

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub




















    'PROCEDIMENTOS DE TEMAS

    Public Sub PROC_APLICADOR_DE_TEMAS_NO_NAVEGADOR() 'APLICADOR DE TEMAS NO NAVEGADOR
        On Error Resume Next

        Dim V_TEMA_SELECIONADO As String = FUNC_LER_ARQUIVO(V_ARQUIVO_END_20) 'LENDO O TEMA INFORMADO

        Dim V_ENDERECO_DE_TEMA As String = V_PASTA_DE_TEMAS & "\" & V_TEMA_SELECIONADO & ".vssf" 'TEMA PADRÃO






        'SO APLICA SE O TEMA EXISTIR -----------------------------------------------------------------------------------

        If (FUNC_RETORNA_SE_O_ARQUIVO_EXISTE_OU_NAO(V_ENDERECO_DE_TEMA) = False) Then

            Exit Sub 'SAINDO

        End If

        '---------------------------------------------------------------------------------------------------------------




        'APLICANDO O TEMA ----------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.VST_TEMA.LoadVisualStyle(V_ENDERECO_DE_TEMA) 'APLICANDO TEMA

        '---------------------------------------------------------------------------------------------------------------


    End Sub















    'NAVEGAÇÃO ANÔNIMA

    Public Sub PROC_NAVEGACAO_ANONIMA_UTILIZAR() 'NAVEGAÇÃO ANONIMA UTILIZAR
        On Error Resume Next

        Dim V_DIRETORIO_DE_PROFILE_REMOVER_ARQUIVOS As String = Xpcom.ProfileDirectory 'DIRETORIO DE PROFILE






        'VERIFICA SE HÁ UMA INSTANCIA DO NAVEGADOR EM ABERTO ----------------------------------------------------------------------------------

        If (V_JA_EXISTE_UMA_INSTANCIA_DO_NAVEGADOR_ABERTO.Length > 0) Then


            Exit Sub 'SAINDO DO PROCEDIMENTO


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------




        'EM CASO DE NAO HOUVER CONFIGURAÇÃO ---------------------------------------------------------------------------------------------------

        If (FUNC_LER_ARQUIVO(V_ARQUIVO_END_35) = Nothing) Then

            PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_35) 'SALVANDO NOVA CONFIGURAÇÃO

        End If

        '--------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA SE REMOVE OS ARQUIVOS DE HISTORICO DE NAVEGAÇÃO, QUANDO O MODO DE ANONIMO ESTIVER ATIVADO -----------------------------------

        If (FUNC_LER_ARQUIVO(V_ARQUIVO_END_35) = True) Then


            PROC_REMOVER_PASTA_POR_COMPLETO(V_PASTA_DE_HISTORICO_DE_SITES_VISITADOS) 'REMOVE PASTA DE HISTORICO

            PROC_REMOVER_PASTA_POR_COMPLETO(V_DIRETORIO_DE_PROFILE_REMOVER_ARQUIVOS) 'REMOVE ARQUIVOS DE PROFILE DO GECKOFX


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub




















    'LIMPAR HISTORICO NO MODO SILENCIOSO

    Public Sub PROC_LIMPAR_HISTORICO_EM_MODO_SILENCIOSO() 'LIMPA O HISTÓRICO NO MODO SILENCIOSO
        On Error Resume Next


        'VERIFICA SE HÁ UMA INSTANCIA DO NAVEGADOR EM ABERTO ----------------------------------------------------------------------------------

        If (V_JA_EXISTE_UMA_INSTANCIA_DO_NAVEGADOR_ABERTO.Length > 0) Then

            Exit Sub 'SAINDO DO PROCEDIMENTO

        End If

        '--------------------------------------------------------------------------------------------------------------------------------------




        '#NOTA: FALSE QUER DIZER QUE NAO DEVE ARMAZENAR O HISTORICO
        'EM CASO DE NAO HOUVER CONFIGURAÇÃO ---------------------------------------------------------------------------------------------------

        If (FUNC_LER_ARQUIVO(V_ARQUIVO_END_5) = Nothing) Then

            PROC_SALVAR_ARQUIVO(True, V_ARQUIVO_END_5) 'SALVANDO NOVA CONFIGURAÇÃO

        End If

        '--------------------------------------------------------------------------------------------------------------------------------------




        'REMOVE O HISTORICO NO MODO SILENCIOSO -------------------------------------------------------------------------

        If (FUNC_LER_ARQUIVO(V_ARQUIVO_END_5) = False) Then


            Kill(V_PASTA_DE_HISTORICO_DE_SITES_VISITADOS & "\*.*") 'REMOVENDO TODOS OS ARQUIVOS


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub




















    'REABRIDOR DE ABAS QUE FORAM ABERTAS

    Public Sub PROC_REABRIR_ULTIMA_ABA_MNU() 'REABRE A ÚLTIMA ABA QUE FOI ABERTA E FECHADA
        On Error Resume Next

        Dim V_URL_SELECIONADA_DE_INDICE As String = ARRAY_PILHA_DE_ABAS_QUE_FORAM_FECHADAS_PELO_USUARIO.Item(ARRAY_PILHA_DE_ABAS_QUE_FORAM_FECHADAS_PELO_USUARIO.Count - 1) 'URL A SER ABERTA






        'NÃO PERMITE ABRIR VALOR NULO OU EM BRANCO ------------------------------------------------------------------------------------------------------------------------------------------

        If (V_URL_SELECIONADA_DE_INDICE = Nothing) Or (V_URL_SELECIONADA_DE_INDICE = "") Or (ARRAY_PILHA_DE_ABAS_QUE_FORAM_FECHADAS_PELO_USUARIO.Count = 0) Then

            Exit Sub 'SAINDO

        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'REMOVE ITEM QUE VAI SER ABERTO -----------------------------------------------------------------------------------------------------------------------------------------------------

        ARRAY_PILHA_DE_ABAS_QUE_FORAM_FECHADAS_PELO_USUARIO.Remove(ARRAY_PILHA_DE_ABAS_QUE_FORAM_FECHADAS_PELO_USUARIO.Item(ARRAY_PILHA_DE_ABAS_QUE_FORAM_FECHADAS_PELO_USUARIO.Count - 1)) 'REMOVENDO...

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ADICIONA NOVA ABA E ABRE O ENDEREÇO DE URL -----------------------------------------------------------------------------------------------------------------------------------------

        PROC_NOVA_ABA_ADICIONAR() 'ADICIONA NOVA ABA

        PROC_NAVEGAR(V_URL_SELECIONADA_DE_INDICE) 'ABRINDO URL

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub





































End Module
