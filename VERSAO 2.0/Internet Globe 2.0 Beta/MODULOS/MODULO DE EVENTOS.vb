Imports Gecko




Module MODULO_DE_EVENTOS


    'VARIÁVEIS

    Public V_URL_ASSOCIADA_AO_MENU_DE_LINKS_MODULO_DE_EVENTOS As String = "" 'LINK QUE É ASSOCIADO AO MENU DIREITO DO MOUSE SOBRE O LINK

    Public V_LISTA_DE_SITES_QUE_TIVERAM_POP_UPS_BLOQUEADAS As String = "" 'INFORMA A LISTA DE SITES QUE TIVERAM SUAS POP-UPS BLOQUEADAS
































    'PROCEDIMENTOS DE EVENTOS

    Private Sub PROC_MENU_CORRETAMENTE_LINK() 'EXIBE O MENU DE LINK CORRETAMENTE
        On Error Resume Next

        Dim V_NOME_DE_DOWNLOAD As String = FUNC_RETORNE_NOME_DE_DOWNLOAD(V_URL_ASSOCIADA_AO_MENU_DE_LINKS_MODULO_DE_EVENTOS) 'OBTEM O NOME DO DOWNLOAD PELA URL

        Dim V_PONTO_DE_EXTENCAO As Integer = V_NOME_DE_DOWNLOAD.Substring(V_NOME_DE_DOWNLOAD.LastIndexOf("."), V_NOME_DE_DOWNLOAD.Length - V_NOME_DE_DOWNLOAD.LastIndexOf(".") - 3).Length 'EM CADO DE DER UM VALOR MAIOR QUE 1 ENTÃO O ULTIMO . NAO É EXTENÇÃO DE ARQUIVO






        'OPÇOES DE NOVA ABA E ABA ATUAL --------------------------------------------------------------------------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.NovaAbaToolStripMenuItem1.Visible = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.Visible 'EXIBINDO NOVA ABA

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.AbaAtualToolStripMenuItem.Visible = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.Visible 'EXIBINDO ABA ATUAL

        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'DEFINE O TITULO DO DOWNLOAD ------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.BaixarArquivoToolStripMenuItem.Text = V_NOME_DE_DOWNLOAD 'REPASSA O NOME DO DOWNLOAD

        '----------------------------------------------------------------------------------------------------------------------------




        'VERIFICA O NOME DO DOWNLOAD --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_NOME_DE_DOWNLOAD.Contains(".html") = True) And (V_NOME_DE_DOWNLOAD.Contains(".htm") = True) And (V_NOME_DE_DOWNLOAD.Contains(".") = True) And (V_NOME_DE_DOWNLOAD.Contains(".php") = True) And (V_NOME_DE_DOWNLOAD.Contains(".aspx") = True) Then


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripMenuItem24.Visible = False 'DESABILITA
            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.BaixarArquivoToolStripMenuItem.Visible = False 'DESABILITA
            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.BaixarArquivoToolStripMenuItem.Text = Nothing 'SEM CONTEÚDO

        Else


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripMenuItem24.Visible = True 'HABILITA
            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.BaixarArquivoToolStripMenuItem.Visible = True 'HABILITA


        End If


        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA SE O .(PONTO) ESTA TRES CASAS ANTES DO FIM DA STRING, INDICANDO EXTENÇÃO DE ARQUIVO ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_PONTO_DE_EXTENCAO <> 1) Then


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripMenuItem24.Visible = False 'DESABILITA
            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.BaixarArquivoToolStripMenuItem.Visible = False 'DESABILITA
            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.BaixarArquivoToolStripMenuItem.Text = Nothing 'SEM CONTEÚDO


        Else


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripMenuItem24.Visible = True 'HABILITA
            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.BaixarArquivoToolStripMenuItem.Visible = True 'HABILITA


        End If


        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_EXIBIR_OPCOES_DE_MENU_CORRETAMENTE() 'EXIBE AS OPÇÕES DE MENU CORRETAMENTE
        On Error Resume Next

        Dim OBJ_MOTOR As Gecko.GeckoWebBrowser 'MOTOR WEB






        'OBTEM DADOS DO MOTOR -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        'cria um objeto somente para captura de informações, não serve como referencia direta ao objeto original

        OBJ_MOTOR = CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser) 'OBTENDO DADOS DO MOTOR

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'VOLTAR, AVANÇAR, VOLTAR ETC ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.VoltarToolStripMenuItem1.Enabled = OBJ_MOTOR.CanGoBack 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.AvançarToolStripMenuItem1.Enabled = OBJ_MOTOR.CanGoForward 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.VoltarToolStripMenuItem.Enabled = OBJ_MOTOR.CanGoBack 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.AvançarToolStripMenuItem.Enabled = OBJ_MOTOR.CanGoForward 'ESTADO




        '#NOTA: DEIXAR OS DOIS BOTOES ABAIXO COMO ESTÃO POR CAUSA DA POPUP...

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TRV_BOTOES.BackEnabled = DirectCast(FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.SelectedForm.Controls.Item(0), Gecko.GeckoWebBrowser).CanGoBack 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TRV_BOTOES.ForwardEnabled = DirectCast(FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.SelectedForm.Controls.Item(0), Gecko.GeckoWebBrowser).CanGoForward() 'ESTADO

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'RELACIONADO A IMAGEM -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CopiarImagemToolStripMenuItem1.Enabled = OBJ_MOTOR.CanCopyImageContents 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CopiarEndereçodeImagemToolStripMenuItem.Enabled = OBJ_MOTOR.CanCopyImageLocation 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CopiarImagemToolStripMenuItem2.Enabled = OBJ_MOTOR.CanCopyImageContents 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CopiarEndereçoDeImagemToolStripMenuItem1.Enabled = OBJ_MOTOR.CanCopyImageLocation 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.SalvarImagemToolStripMenuItem.Enabled = OBJ_MOTOR.CanCopyImageLocation 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.SalvarImagemToolStripMenuItem1.Enabled = OBJ_MOTOR.CanCopyImageLocation 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.EditarImagemToolStripMenuItem.Visible = FUNC_RETORNA_SE_O_ARQUIVO_EXISTE_OU_NAO(V_APLICATIVO_PADRAO_PARA_EDITOR_DE_IMAGENS) 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.DefinaComoPlanoDeFundoToolStripMenuItem1.Enabled = OBJ_MOTOR.CanCopyImageLocation 'ESTADO

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'RELACIONADO A TEXTO PURO ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.DesfazerToolStripMenuItem.Enabled = OBJ_MOTOR.CanUndo 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.DesfazerToolStripMenuItem1.Enabled = OBJ_MOTOR.CanUndo 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.RefazerToolStripMenuItem.Enabled = OBJ_MOTOR.CanRedo 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.RefazerToolStripMenuItem1.Enabled = OBJ_MOTOR.CanRedo 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.RecortarToolStripMenuItem1.Enabled = OBJ_MOTOR.CanCutSelection 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.RecortarToolStripMenuItem.Enabled = OBJ_MOTOR.CanCutSelection 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CopiarToolStripMenuItem.Enabled = OBJ_MOTOR.CanCopySelection 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CopiarToolStripMenuItem1.Enabled = OBJ_MOTOR.CanCopySelection 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ColarToolStripMenuItem1.Enabled = OBJ_MOTOR.CanPaste 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ColarToolStripMenuItem.Enabled = OBJ_MOTOR.CanPaste 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ExcluirToolStripMenuItem1.Enabled = OBJ_MOTOR.CanCutSelection 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ExcluirToolStripMenuItem.Enabled = OBJ_MOTOR.CanCutSelection 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CopiarSeleçãoToolStripMenuItem.Enabled = OBJ_MOTOR.CanCopySelection 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PesquiseTextoToolStripMenuItem.Visible = OBJ_MOTOR.CanCopySelection 'ESTADO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.OuvirTextoToolStripMenuItem.Visible = OBJ_MOTOR.CanCopySelection 'ESTADO









        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



























    End Sub

    Public Sub PROC_EVENTO_PESQUISAR_POR_SELECAO(ByVal sender As System.Object, ByVal e As System.EventArgs) 'EVENTO PESQUISAR POR SELEÇÃO
        On Error Resume Next

        Dim OBJ_ITEM As New ToolStripMenuItem 'NOVO OBJETO DE TOOLSTRIPMENUITEM

        Dim V_PESQUISE As String 'CONTEUDO DE PESQUISA






        'IGUALANDO OBJETOS ---------------------------------------------------------------------------------------------

        OBJ_ITEM = DirectCast(sender, ToolStripMenuItem) 'IGUALANDO OBJETOS

        '---------------------------------------------------------------------------------------------------------------




        'OBTEM O CONTEUDO DE PESQUISA ----------------------------------------------------------------------------------

        V_PESQUISE = OBJ_ITEM.Tag 'OBTENDO O CONTEUDO

        '---------------------------------------------------------------------------------------------------------------




        'PESQUISA ------------------------------------------------------------------------------------------------------

        PROC_NOVA_ABA_ADICIONAR() 'ADICIONA A NOVA ABA

        PROC_PESQUISA_FEITA_PELO_USUARIO(OBJ_ITEM.Tag, 1) 'PESQUISA FEITA PELO USUÁRIO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_EVENTO_LEITURA_DE_TEXTO_SELECIONADO_MOTOR_EM_USO(ByVal sender As System.Object, ByVal e As System.EventArgs) 'EVENTO LEITURA DE TEXTO SELECIONADO PELO USUÁRIO
        On Error Resume Next

        Dim OBJ_ITEM As New ToolStripMenuItem 'NOVO OBJETO DE TOOLSTRIPMENUITEM

        Dim V_LEIA As String 'CONTEUDO DE LEITURA






        'IGUALANDO OBJETOS ---------------------------------------------------------------------------------------------

        OBJ_ITEM = DirectCast(sender, ToolStripMenuItem) 'IGUALANDO OBJETOS

        '---------------------------------------------------------------------------------------------------------------




        'OBTEM O CONTEUDO DE LEITURA -----------------------------------------------------------------------------------

        V_LEIA = OBJ_ITEM.Tag 'OBTENDO O CONTEUDO

        '---------------------------------------------------------------------------------------------------------------




        'VERIFICA SE O CONTEÚDO E OU NAO VALIDO ------------------------------------------------------------------------

        If (V_LEIA.Length = 0) Then


            PROC_BACKUP_DE_CONTEUDO_DA_RAM() 'FAZ O BACKUP DO CONTEUDO DA RAM

            OBJ_MOTOR_DE_ACAO_EM_USO.CopySelection() 'COPIANDO A SELEÇÃO

            V_LEIA = My.Computer.Clipboard.GetText 'OBTENDO O TEXTO DA MEMORIA

            PROC_BACKUP_DE_CONTEUDO_DA_RAM_RESTAURAR() 'RESTAURA O BACKUP DO CONTEUDO DA RAM


        End If

        '---------------------------------------------------------------------------------------------------------------




        'LEITURA -------------------------------------------------------------------------------------------------------

        PROC_CHAMAR_LEITOR_DE_TEXTOS_COM_VOZ(V_LEIA) 'CHAMA O LEITOR DE TEXTOS COM VOZ

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_DOCUMENTO_COMPLETO_GECKOFX_BASICO(ByVal sender As System.Object, ByVal e As System.EventArgs) 'DOCUMENTO COMPLETO GECKOFX EVENTO BASICO APENAS PARA ALGUMAS ALTERAÇÕES
        On Error Resume Next

        Dim OBJ_MOTOR As Gecko.GeckoWebBrowser 'MOTOR WEB QUE OBTÉM E RECEBE COMANDOS, VALORES ETC.






        'REFERENCIANDO MOTOR COM OBJETO DO EVENTO ----------------------------------------------------------------------

        OBJ_MOTOR = CType(sender, Gecko.GeckoWebBrowser) 'OBTENDO DADOS DO MOTOR

        '---------------------------------------------------------------------------------------------------------------




        'SALVA DADOS DE HISTORICO E ATUALIZA IMAGEM DE HISTÓRICO -------------------------------------------------------

        'NÚMERO DE IF: 1

        PROC_SALVAR_HISTORICO_DE_SITE_VISITADO_AGORA(OBJ_MOTOR) 'SALVA O HISTORICO DO SITE VISITADO AGORA

        '---------------------------------------------------------------------------------------------------------------




        'SALVAR SESSÃO AGORA -----------------------------------------------------------------------------------------------------------------------------------------

        PROC_SALVAR_SESSAO_ATUAL(OBJ_MOTOR.Url.AbsoluteUri, OBJ_MOTOR.Name) 'SALVAR A SESSÃO ATUAL

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_DOCUMENTO_COMPLETO_GECKOFX(ByVal sender As System.Object, ByVal e As System.EventArgs) 'DOCUMENTO COMPLETO GECKOFX
        On Error Resume Next

        Dim OBJ_MOTOR As Gecko.GeckoWebBrowser 'MOTOR WEB QUE OBTÉM E RECEBE COMANDOS, VALORES ETC.

        Dim V_TOKEN_DO_MOTOR As String 'INFORMA O TOKEN DE CRIAÇÃO DO MOTOR

        Dim V_ABA_QUE_ESTA As String 'ABA ATUAL EM QUE ESTÁ






        'REFERENCIANDO MOTOR COM OBJETO DO EVENTO ----------------------------------------------------------------------

        OBJ_MOTOR = CType(sender, Gecko.GeckoWebBrowser) 'OBTENDO DADOS DO MOTOR

        '---------------------------------------------------------------------------------------------------------------




        'OBTENDO TOKEN DE MOTOR E ABA EM QUE ESTÁ ----------------------------------------------------------------------

        V_TOKEN_DO_MOTOR = OBJ_MOTOR.Name 'OBTENDO TOKEN DO MOTOR

        V_ABA_QUE_ESTA = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.SelectedForm.Name 'ABA ATUAL

        '---------------------------------------------------------------------------------------------------------------




        'SALVA DADOS DE HISTORICO E ATUALIZA IMAGEM DE HISTÓRICO -------------------------------------------------------

        'NÚMERO DE IF: 1

        PROC_SALVAR_HISTORICO_DE_SITE_VISITADO_AGORA(OBJ_MOTOR) 'SALVA O HISTORICO DO SITE VISITADO AGORA

        '---------------------------------------------------------------------------------------------------------------




        'SALVAR SESSÃO AGORA -----------------------------------------------------------------------------------------------------------------------------------------

        PROC_SALVAR_SESSAO_ATUAL(OBJ_MOTOR.Url.AbsoluteUri, OBJ_MOTOR.Name) 'SALVAR A SESSÃO ATUAL

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'SO ATUALIZA AS PROPRIEDADES DO FORMULARIO PRINCIPAL, SE O  TOKEK DE MOTOR FOR IGUAL A ABA EM QUE ESTÁ --------------------------------------------------------------------------------------------------

        'NÚMERO DE IF: 1

        If (V_TOKEN_DO_MOTOR <> V_ABA_QUE_ESTA) Then




            'REMOVE EVENTO COMPLETO, E ADICIONA O BÁSICO -----------------------------------------------------------------------------------------------------------------------------------------

            RemoveHandler OBJ_MOTOR.DocumentCompleted, AddressOf PROC_DOCUMENTO_COMPLETO_GECKOFX 'DOCUMENTO COMPLETO GECKOFX

            AddHandler OBJ_MOTOR.DocumentCompleted, AddressOf PROC_DOCUMENTO_COMPLETO_GECKOFX_BASICO 'DOCUMENTO COMPLETO GECKOFX EVENTO BASICO APENAS PARA ALGUMAS ALTERAÇÕES

            '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'SAINDO -------------------------------------

            Exit Sub 'SAINDO

            '--------------------------------------------




        End If

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ATUALIZA FAVICON ----------------------------------------------------------------------------------------------

        PROC_PUXAR_FAVICON_DE_FORMULARIO_PRINCIPAL() 'PUXA O FAVICON DO FORMULARIO PRINCIPAL

        '---------------------------------------------------------------------------------------------------------------




        'OPÇOES DE MENUS -----------------------------------------------------------------------------------------------

        PROC_EXIBIR_OPCOES_DE_MENU_CORRETAMENTE() 'EXIBE AS OPÇÕES DE MENU CORRETAMENTE

        '---------------------------------------------------------------------------------------------------------------




        'INFORMA SOBRE O CARREGAMENTO CONCLUIDO DA PÁGINA --------------------------------------------------------------

        'NÚMERO DE IF: 1

        PROC_INFORMAR_SOBRE_CARREGAMENTO_CONCLUIDO_DA_PAGINA() 'INFORMA SOBRE O CARREGAMENTO CONCLUIDO DA PÁGINA

        '---------------------------------------------------------------------------------------------------------------




        'URL -----------------------------------------------------------------------------------------------------------

        'NÚMERO DE IF: 1

        If (FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CBO_ENDERECO_DO_SITE.ContainsFocus = False) Then

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CBO_ENDERECO_DO_SITE.Text = OBJ_MOTOR.Url.AbsoluteUri 'BARRA DE URL

        End If

        '---------------------------------------------------------------------------------------------------------------




        'INFORMA O HOST EM QUE ESTÁ ------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.LBL_CARREGANDO.Text = OBJ_MOTOR.Url.Host 'INFORMANDO O HOST

        '---------------------------------------------------------------------------------------------------------------




        'INFORMA CHAVE DE SEGURANÇA ------------------------------------------------------------------------------------------------------------------------------------

        'NÚMERO DE IF: 1

        PROC_INFORMAR_CHAVE_DE_SEGURANCA_DO_SITE_EM_VISUALIZACAO(OBJ_MOTOR.Url.AbsoluteUri) 'INFORMA A CHAVE DE SEGURANÇA DO SITE EM VISUALIZAÇÃO

        '---------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ATUALIZA O TEXTO DA JANELA ------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.Text = OBJ_MOTOR.DocumentTitle & V_LOGOTIPO 'ATUALIZA O TITULO DA ABA

        '---------------------------------------------------------------------------------------------------------------------




        '#INFORMAÇÕES: NÚMERO DE IFs EXECUTADOS: 05
        '#ALGUNS PROCEDIMENTOS SO PODEM SER EXECUTADOS SE A ABA EM VISUALIZAÇAO, FOR IGUAL AO TOKEN


    End Sub

    Public Sub PROC_BOTAO_DIREITO_DO_MOUSE_GECKOFX_EXIBIR_MENU(ByVal sender As System.Object, ByVal e As Gecko.GeckoContextMenuEventArgs) 'EVENTO DO BOTAO DIREITO DO MOUSE
        On Error Resume Next

        Dim OBJ_MOTOR As Gecko.GeckoWebBrowser 'MOTOR WEB

        Dim V_TAG_DE_OBJETO_EM_FOCO As String = e.TargetNode.LocalName 'NOME DA TAG DO OBJETO EM FOCO






        'INFORMA A URL ASSOCIADA AO LINK QUE RECEBE O FOCO ---------------------------------------------------------------------------------------------------

        V_URL_ASSOCIADA_AO_MENU_DE_LINKS_MODULO_DE_EVENTOS = e.AssociatedLink 'INFORMANDO URL

        '-----------------------------------------------------------------------------------------------------------------------------------------------------




        'CONVERTER TAG PARA MAIUSCULO ------------------------------------------------------------------------------------------------------------------------

        V_TAG_DE_OBJETO_EM_FOCO = V_TAG_DE_OBJETO_EM_FOCO.ToUpper 'CONVERTENDO

        '-----------------------------------------------------------------------------------------------------------------------------------------------------




        'DEFINE O MOTOR DE AÇÃO DE USO -----------------------------------------------------------------------------------------------------------------------

        PROC_DEFINE_MOTOR_DE_ACAO_EM_USO(sender) 'DEFINE O MOTOR DE AÇÃO EM USO

        '-----------------------------------------------------------------------------------------------------------------------------------------------------




        'OBTEM DADOS DO MOTOR --------------------------------------------------------------------------------------------------------------------------------

        OBJ_MOTOR = CType(sender, Gecko.GeckoWebBrowser) 'OBTENDO DADOS DO MOTOR

        '-----------------------------------------------------------------------------------------------------------------------------------------------------




        'EXIBE OS MENUS CORRETAMENTE -------------------------------------------------------------------------------------------------------------------------

        PROC_EXIBIR_OPCOES_DE_MENU_CORRETAMENTE() 'EXIBE AS OPÇÕES DE MENU CORRETAMENTE

        PROC_PERMITE_PESQUISA_COM_TEXTO_SELECIONADO_EM_MOTOR_EM_USO() 'PERMITE A PESQUISA PELO TEXTO SELECIONADO NO MOTOR EM USO

        PROC_OUVIR_O_TEXTO_SELECIONADO_PELO_USUARIO_EM_MOTOR_EM_USO() 'OUVE O TEXTO SELECIONADO PELO USUÁRIO

        '-----------------------------------------------------------------------------------------------------------------------------------------------------




        'MENU DE CORPO DA PÁGINA ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_TAG_DE_OBJETO_EM_FOCO <> "INPUT") And (V_TAG_DE_OBJETO_EM_FOCO <> "TEXTAREA") And (V_TAG_DE_OBJETO_EM_FOCO <> "BUTTON") And (V_TAG_DE_OBJETO_EM_FOCO <> "A") And (V_TAG_DE_OBJETO_EM_FOCO <> "IMG") And (OBJ_MOTOR.CanCopySelection = False) And (OBJ_MOTOR.CanCopyImageContents = False) And (OBJ_MOTOR.CanCopyImageLocation = False) And (OBJ_MOTOR.CanCopyLinkLocation = False) Then


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.MNU_CORPO.Show(FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.MousePosition) 'ABRINDO O MENU

            Exit Sub 'SAINDO DO PROCEDIMENTO


        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ABRINDO MENU DE LINK -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_TAG_DE_OBJETO_EM_FOCO = "A") Or (OBJ_MOTOR.CanCopyLinkLocation = True) Then


            PROC_MENU_CORRETAMENTE_LINK() 'EXIBE O MENU DE LINK CORRETAMENTE

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.MNU_LINK.Show(FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.MousePosition) 'ABRINDO MENU DE LINK

            Exit Sub 'SAINDO DO PROCEDIMENTO


        End If

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'EXIBE O MENU CAIXA DE TEXTO ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_TAG_DE_OBJETO_EM_FOCO = "INPUT") Or (V_TAG_DE_OBJETO_EM_FOCO = "TEXTAREA") Or (OBJ_MOTOR.CanCopySelection = True) Then


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.MNU_CAIXA_DE_TEXTO.Show(FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.MousePosition) 'ABRINDO MENU DE CAIXA DE TEXTO

            Exit Sub 'SAINDO DO PROCEDIMENTO


        End If

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ABRINDO MENU DE IMAGEM -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_TAG_DE_OBJETO_EM_FOCO = "IMG") Or (OBJ_MOTOR.CanCopyImageContents = True) Or (OBJ_MOTOR.CanCopyImageLocation = True) Then


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.MNU_IMAGEM.Show(FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.MousePosition) 'ABRINDO MENU DE LINK

            Exit Sub 'SAINDO DO PROCEDIMENTO


        End If

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_BOTAO_CENTRAL_DO_MOUSE_GECKOFX_MOUSE_DOWN(ByVal sender As System.Object, ByVal e As Gecko.GeckoDomMouseEventArgs) 'BOTÃO DIREITO TO MOUSE
        On Error Resume Next

        Dim OBJ_MOTOR As Gecko.GeckoWebBrowser 'MOTOR WEB






        'OBTEM DADOS DO MOTOR ------------------------------------------------------------------------------------------

        OBJ_MOTOR = CType(sender, Gecko.GeckoWebBrowser) 'OBTENDO DADOS DO MOTOR

        '---------------------------------------------------------------------------------------------------------------




        'INFORMA URL A SER ABERTA --------------------------------------------------------------------------------------

        Dim V_URL_A_ABRIR As New Uri(OBJ_MOTOR.StatusText) 'NOVA URL, URL A SER ABERTA EM NOVA ABA

        '---------------------------------------------------------------------------------------------------------------




        'DEFINE O MOTOR DE AÇÃO DE USO ---------------------------------------------------------------------------------

        PROC_DEFINE_MOTOR_DE_ACAO_EM_USO(sender) 'DEFINE O MOTOR DE AÇÃO EM USO

        '---------------------------------------------------------------------------------------------------------------




        'OPÇOES DE MENUS -----------------------------------------------------------------------------------------------

        PROC_EXIBIR_OPCOES_DE_MENU_CORRETAMENTE() 'EXIBE AS OPÇÕES DE MENU CORRETAMENTE

        '---------------------------------------------------------------------------------------------------------------




        '#NOTA: NÃO JUNTAR AS COMPARAÇÕES ABAIXO EM UMA, SO PORQUE NOTHING COSTUMA DAR ERRO ENTRE DUAS COMPARAÇÕES

        'PRIMEIRO VERIFICA SE O BOTÃO PRESSIONADO FOI O DO MEIO --------------------------------------------------------

        If (e.Button <> 1) Then

            Exit Sub 'SAINDO

        End If

        '---------------------------------------------------------------------------------------------------------------




        'DEPOIS VERIFICA SE A URL A SER ABERTA É VALIDA ----------------------------------------------------------------

        If (V_URL_A_ABRIR.AbsoluteUri = Nothing) Then

            Exit Sub 'SAINDO

        End If

        '---------------------------------------------------------------------------------------------------------------




        'TAMBÉM NAO PERMITE ABRIR URL EM BRANCO ------------------------------------------------------------------------

        If (V_URL_A_ABRIR.AbsoluteUri = "about:blank") Then

            Exit Sub 'SAINDO

        End If

        '---------------------------------------------------------------------------------------------------------------




        'INFORMA LINK A SER ABERTO, E EM SEGUIDA ABRE O LINK -----------------------------------------------------------

        V_URL_ASSOCIADA_AO_MENU_DE_LINKS_MODULO_DE_EVENTOS = V_URL_A_ABRIR.AbsoluteUri 'OBTENDO A URL ABSOLUTA

        PROC_MENU_ACAO_EXECUTAR(1) 'AÇÃO DO MENU DO BOTAO DIREITO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_FAVORITOS_BARRA_DE_MENUS_ATUALIZAR_LISTA(ByVal sender As System.Object, ByVal e As System.EventArgs) 'ATUALIZA OS FAVORITOS NA BARRA DE MENUS
            On Error Resume Next

            Dim OBJ_SUBITEM As ToolStripMenuItem = CType(sender, ToolStripMenuItem) 'CRIANDO OBJETO DE HERANÇA PARA NOVA ATUALIZAÇÃO DE VALORES DE FAVORITOS






            'PRIMEIRO LISTA AS PASTAS E DEPOIS LISTA OS FAVORITOS ---------------------------------------------------------------------------------

            PROC_FAVORITOS_LISTAR_TODOS(OBJ_SUBITEM.ToolTipText, OBJ_SUBITEM, True) 'LISTA TODOS OS FAVORITOS

            PROC_FAVORITOS_LISTAR_TODOS_SALVOS(OBJ_SUBITEM, OBJ_SUBITEM.ToolTipText) 'LISTA TODOS OS ARQUIVOS DE FAVORITOS

            '--------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Public Sub PROC_FAVORITOS_CLICOU_EM_FAVORITO(ByVal sender As System.Object, ByVal e As System.EventArgs) 'ABRE O FAVORITO CLICADO
            On Error Resume Next

            Dim OBJ_SUBITEM As ToolStripMenuItem = CType(sender, ToolStripMenuItem) 'CRIANDO OBJETO DE HERANÇA PARA NOVA ATUALIZAÇÃO DE VALORES DE FAVORITOS

            Dim V_ENDERECO_DO_SITE As String = FUNC_LER_ARQUIVO(OBJ_SUBITEM.ToolTipText) 'OBTENDO O ENDERÇO DO SITE






            'NAVEGA NO ENDEREÇO DO SITE ------------------------------------------------------------------------------------

            PROC_NAVEGAR(V_ENDERECO_DO_SITE) 'NAVEGA NO ENDEREÇO DE SITE INFORMADO

            '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_FAVORITOS_MOUSE_UP_SOBRE_ITEM(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) 'AO SOLTAR O MOUSE SOBRE O FAVORITO
            On Error Resume Next

            Dim OBJ_MENU As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem) 'OBJETO DIRETO DO MENU

            Dim V_ENDERECO_CLICADO As String = OBJ_MENU.Name 'NOME DO MENU CLICADO






            'INFORMA O NOME DO ITEM CLICADO ------------------------------------------------------

            V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR = OBJ_MENU.ToolTipText 'NOME DO MENU CLICADO

            '-------------------------------------------------------------------------------------




            'EXIBE OS MENUS CORRETAMENTE ------------------------------------------------------------------------------------------------------------

            If (V_ENDERECO_CLICADO.StartsWith(V_NOME_GENERICO_DE_FAVORITOS) = True) Then


                'MENUS CORRETOS --------------------------------------------------------------------------------------------

                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.RenomearPastaToolStripMenuItem.Enabled = False 'DESABILITADO
                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ExcluirPastaToolStripMenuItem.Enabled = False 'DESABILITADO
                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.RenomearFavorítoToolStripMenuItem.Enabled = True 'HABILITADO
                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ExcluirFavorítoToolStripMenuItem.Enabled = True 'HABILITADO
                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.AbrirEmNovaAbaToolStripMenuItem.Enabled = True 'HABILITADO

                '-----------------------------------------------------------------------------------------------------------




                'INFORMA SE É PASTA OU ARQUIVO -----------------------------------------------

                V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR_PASTA_OU_ARQUIVO = True 'PASTA

                '-----------------------------------------------------------------------------


            End If




            If (V_ENDERECO_CLICADO.StartsWith(V_NOME_GENERICO_DE_PASTA_DE_FAVORITOS) = True) Then


                'MENUS CORRETOS --------------------------------------------------------------------------------------------

                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.RenomearPastaToolStripMenuItem.Enabled = True 'HABILITADO
                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ExcluirPastaToolStripMenuItem.Enabled = True 'HABILITADO
                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.RenomearFavorítoToolStripMenuItem.Enabled = False 'DESABILITADO
                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ExcluirFavorítoToolStripMenuItem.Enabled = False 'DESABILITADO
                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.AbrirEmNovaAbaToolStripMenuItem.Enabled = False 'DESABILITADO

                '-----------------------------------------------------------------------------------------------------------




                'INFORMA SE É PASTA OU ARQUIVO -----------------------------------------------

                V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR_PASTA_OU_ARQUIVO = False 'ARQUIVO

                '-----------------------------------------------------------------------------


            End If

            '----------------------------------------------------------------------------------------------------------------------------------------




            'ABRINDO O MENU ------------------------------------------------------------------------------------------------

            If (e.Button = MouseButtons.Right) Then


                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.MNU_DE_TOL_FAVORITOS.Show(FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.MousePosition) 'ABRINDO...


            End If

            '---------------------------------------------------------------------------------------------------------------




















    End Sub

    Public Sub PROC_CLICAR_NO_MOTOR_GECKOFX(ByVal sender As System.Object, ByVal e As Gecko.GeckoDomEventArgs) 'AO CLICAR NO MOTOR GECKOFX
            On Error Resume Next


        'DEFINE O MOTOR DE AÇÃO DE USO -------------------------------------------------------------------------------------------------------------------------------

        PROC_DEFINE_MOTOR_DE_ACAO_EM_USO(sender) 'DEFINE O MOTOR DE AÇÃO EM USO

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ATUALIZA O CONTROLE ABAIXO ----------------------------------------------------------------------------------------------------------------------------------

        OBJ_MOTOR_DE_ACAO_EM_USO.Refresh() 'ATUALIZANDO

        OBJ_MOTOR_DE_ACAO_EM_USO.Update() 'ATUALIZANDO

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'OPÇOES DE MENUS ---------------------------------------------------------------------------------------------------------------------------------------------

        PROC_EXIBIR_OPCOES_DE_MENU_CORRETAMENTE() 'EXIBE AS OPÇÕES DE MENU CORRETAMENTE

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'PERMITE AUTO-CLOSE ------------------------------------------------------------------------------------------------------------------------------------------

        OBJ_MENU_DE_CONTEXTO.AutoClose = True 'AUTO-CLOSE

        OBJ_MENU_DE_CONTEXTO.Close() 'FECHANDO MENU

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA SE O LINK CLICADO É PARA MUDAR A IMAGEM DE FUNDO DE PAGINA DE INICIO -------------------------------------------------------------------------------

        PROC_MUDAR_IMAGEM_DE_FUNDO_DE_PAGINA_DE_INICIO(OBJ_MOTOR_DE_ACAO_EM_USO.StatusText) 'MUDA A IMAGEM DE FUNDO DE PÁGINA DE INICIO

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_EVENTO_MOVER_O_MOUSE_SOBRE_A_PAGINA(ByVal sender As System.Object, ByVal e As Gecko.GeckoDomMouseEventArgs) 'EVENTO MOVER O MOUSE SOBRE A PÁGINA
            On Error Resume Next

            Dim V_URL As New Uri(OBJ_MOTOR_DE_ACAO_EM_USO.StatusText) 'NOVA URL

            Static V_ULTIMA_URL_TESTADA As String 'INFORMA A ULTIMA URL TESTADA






            'VERIFICA SE A URL É VALIDA ------------------------------------------------------------------------------------

            If (V_URL.Scheme = Nothing) Then


                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.LBL_CARREGANDO.Text = OBJ_MOTOR_DE_ACAO_EM_USO.Url.Host 'INFORMA O LINK

                Exit Sub 'SAINDO...


            End If

            '---------------------------------------------------------------------------------------------------------------




            'INFORMA O LINK ------------------------------------------------------------------------------------------------

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.LBL_CARREGANDO.Text = V_URL.AbsoluteUri 'INFORMA O LINK NA BARRA DE STATUS

            '---------------------------------------------------------------------------------------------------------------




            'VERIFICA SE O LINK JA FOI TESTADO -----------------------------------------------------------------------------

            If (V_ULTIMA_URL_TESTADA = V_URL.AbsoluteUri) Then


                Exit Sub 'SAINDO...


            End If

            '---------------------------------------------------------------------------------------------------------------




            'ANALISA URL ---------------------------------------------------------------------------------------------------

            PROC_INICIAR_TESTE_DE_LINK(V_URL.AbsoluteUri) 'INICIA O TESTE DE LINK PARA VERIFICAR SE ESTÁ OU NÃO ONLINE

            '---------------------------------------------------------------------------------------------------------------




            'ATUALIZA URL TESTADA ------------------------------------------------------------------------------------------

            V_ULTIMA_URL_TESTADA = V_URL.AbsoluteUri 'ATUALIZANDO

            '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_EVENTO_DE_NOVA_POP_UP_OU_NOVA_JANELA(ByVal sender As System.Object, ByVal e As Gecko.GeckoCreateWindowEventArgs) 'NOVA JANELA OU NOVA POP-UP
            On Error Resume Next

            Dim OBJ_MOTOR As New Gecko.GeckoWebBrowser 'NOVO MOTOR SKYBOUND

            Dim V_PODE_ABRIR_POPUP As Boolean 'INFORMA SE PODE ABRIR A POPUP

            Dim V_NUMERO_DESTE_MOTOR As Integer 'INFORMA O NUMERO DESTE MOTOR

            Dim V_NUMERO_DE_MOTOR_EM_FOCO_AGORA As Integer = CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).Name 'NUMERO DO MOTOR EM VISUALIZAÇÃO






            'IGUALA MOTOR PARA OBTER DADOS ---------------------------------------------------------------------------------

            OBJ_MOTOR = DirectCast(sender, Gecko.GeckoWebBrowser) 'OBTEM DADOS DE MOTOR

            '---------------------------------------------------------------------------------------------------------------




            'OBTENDO O NUMERO DESTE MOTOR ----------------------------------------------------------------------------------

            V_NUMERO_DESTE_MOTOR = OBJ_MOTOR.Name 'NÚMERO DO MOTOR

            '---------------------------------------------------------------------------------------------------------------




            'INFORMA SE PODE OU NAO ABRIR A POPUP -------------------------------------------------------------------------------------------------

            V_PODE_ABRIR_POPUP = FUNC_RETORNE_SITE_PODE_ABRIR_POPUP(OBJ_MOTOR.Url.AbsoluteUri) 'RETORNA SE O SITE PODE OU NÃO ABRIR UMA POPUP

            '--------------------------------------------------------------------------------------------------------------------------------------




            'VERIFICA SE ABRE OU NAO A POPUP ------------------------------------------------------------------------------------------------------

            If (V_PODE_ABRIR_POPUP = True) Or (V_NUMERO_DE_MOTOR_EM_FOCO_AGORA = V_NUMERO_DESTE_MOTOR) Then




                'SOM DE POP-UP -------------------------------------------------------------------------------------------------

                PROC_EXIBIR_SOM_DE_SISTEMA(7) 'EXIBE OS SONS INSTALADOS NO SISTEMA

                '---------------------------------------------------------------------------------------------------------------




                'ADICIONA NOVA ABA, E IGUALA OS MOTORES --------------------------------------------------------------------

                PROC_NOVA_ABA_ADICIONAR() 'NOVA ABA

                e.WebBrowser = OBJ_MOTOR_DE_ACAO_EM_USO 'IGUALANDO OS MOTORES

                '-----------------------------------------------------------------------------------------------------------




            End If

            '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_EVENTO_DE_NOVA_POP_UP_BLOQUEADOR_DE_JANELA(ByVal sender As System.Object, ByVal e As Gecko.GeckoCreateWindow2EventArgs) 'ESTE EVENTO BLOQUEIA OU NÃO A POPUP
            On Error Resume Next

            Dim V_PODE_ABRIR_POPUP As Boolean 'INFORMA SE PODE ABRIR A POPUP

            Dim OBJ_MOTOR As New Gecko.GeckoWebBrowser 'NOVO MOTOR SKYBOUND






            'IGUALA MOTOR PARA OBTER DADOS -----------------------------------------------------------------------------------------------------------------------------------------------

            OBJ_MOTOR = DirectCast(sender, Gecko.GeckoWebBrowser) 'OBTEM DADOS DE MOTOR

            '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'INFORMA SE PODE OU NAO ABRIR A POPUP ----------------------------------------------------------------------------------------------------------------------------------------

            V_PODE_ABRIR_POPUP = FUNC_RETORNE_SITE_PODE_ABRIR_POPUP(OBJ_MOTOR.Url.AbsoluteUri) 'RETORNA SE O SITE PODE OU NÃO ABRIR UMA POPUP

            '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'CANCELA A ABERTURA DA POPUP -------------------------------------------------------------------------------------------------------------------------------------------------

            If (V_PODE_ABRIR_POPUP = False) Then




                'EXIBINDO PAINEL DE POP-UP -----------------------------------------------------------------------------------------------------------------------------------------------

                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PN_POP_UPS.Visible = True 'EXIBINDO O PAINEL DE POP-UP

                '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------




                'AGORA ATUALIZA A LISTA --------------------------------------------------------------------------------------------------------------------------------------------------

                If (V_LISTA_DE_SITES_QUE_TIVERAM_POP_UPS_BLOQUEADAS.Contains(OBJ_MOTOR.Url.AbsoluteUri) = False) Then


                    V_LISTA_DE_SITES_QUE_TIVERAM_POP_UPS_BLOQUEADAS = V_LISTA_DE_SITES_QUE_TIVERAM_POP_UPS_BLOQUEADAS & OBJ_MOTOR.Url.AbsoluteUri & vbCrLf 'ATUALIZA A LISTA

                    FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CBO_POP_UPS.Items.Add(OBJ_MOTOR.Url.Host) 'AQUI ESTAO OS HOSTS BLOQUEADOS

                    FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CBO_POP_UPS.Text = OBJ_MOTOR.Url.Host 'INFORMA O HOST


                End If

                '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------




                'CANCELA A ABERTURA DA POPUP ---------------------------------------------------------------------------------------------------------------------------------------------

                e.Cancel = True 'CANCELANDO

                '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            End If

            '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_PRESSIONAR_TECLAS_SOBRE_O_MOTOR_EM_USO(ByVal sender As System.Object, ByVal e As Gecko.GeckoDomKeyEventArgs) 'EVENTO PRESSIONAR TECLAS SOBRE O MOTOR EM USO
        On Error Resume Next

        Static V_ZOOM As Integer = 125 'VALOR DE ZOOM






        'VERIFICA TECLA SELECIONADA ---------------------------------------------------------------------------------------------------------------------------------------------------------

        Select Case e.KeyCode

            Case 107 'ZOM + -----------------------------------------------------------------------------------------------------------------------------------------------

                If (e.CtrlKey = True) Then

                    V_ZOOM = V_ZOOM + 25 'ATUALIZA O ZOOM
                    PROC_ZOOM_NO_TEXTO(V_ZOOM) 'APLICA O ZOOM NO TEXTO

                End If

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case 109 'ZOM - -----------------------------------------------------------------------------------------------------------------------------------------------

                If (e.CtrlKey = True) Then

                    V_ZOOM = V_ZOOM - 25 'ATUALIZA O ZOOM
                    PROC_ZOOM_NO_TEXTO(V_ZOOM) 'APLICA O ZOOM NO TEXTO

                End If

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.T 'NOVA ABA -----------------------------------------------------------------------------------------------------------------------------------------

                If (e.CtrlKey = True) Then

                    PROC_NOVA_ABA_ADICIONAR() 'ADICIONA NOVA ABA

                End If

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.F 'LOCALIZAR ----------------------------------------------------------------------------------------------------------------------------------------

                If (e.CtrlKey = True) Then

                    FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PN_LOCALIZAR.Visible = True 'EXIBE O PAINEL DE LOCALIZAR

                End If

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.F3 'LOCALIZAR ---------------------------------------------------------------------------------------------------------------------------------------

                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PN_LOCALIZAR.Visible = True 'EXIBE O PAINEL DE LOCALIZAR

                PROC_PROCURAR_POR_TEXTO_NA_PAGINA(FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TXT_LOCALIZAR.Text, False) 'PROCURA E SELECIONA O TEXTO NA PÁGINA

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.L 'FOCALIZA EM BARRA DE ENDEREÇOS -------------------------------------------------------------------------------------------------------------------

                If (e.CtrlKey = True) Then

                    FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CBO_ENDERECO_DO_SITE.Focus() 'FOCALIZA EM BARRA DE ENDEREÇOS

                End If

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.K 'FOCALIZA EM BARRA DE BUSCAS ----------------------------------------------------------------------------------------------------------------------

                If (e.CtrlKey = True) Then


                    FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PN_PESQUISA.Visible = True 'PAINEL DE PESQUISA

                    FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CBO_SITE_DE_PESQUISA.SelectedIndex = 1 'SELECIONA SITE DE PESQUISA INICIAL

                    FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TXT_PESQUISA.Focus() 'MOVE O FOCO PARA A CAIXA DE PESQUISA


                End If

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.F5 'ATUALIZA A PÁGINA -------------------------------------------------------------------------------------------------------------------------------

                PROC_ACOES_BASICAS_AVANCAR_VOLTAR_ATUALIZAR_ETC(4) 'VOLTAR, AVANÇAR, ETC.

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.F4 'FECHA A ABA ATUAL -------------------------------------------------------------------------------------------------------------------------------

                PROC_REMOVE_ABA() 'REMOVE A ABA

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.F6 'REABRE A ABA ------------------------------------------------------------------------------------------------------------------------------------

                PROC_REABRIR_ULTIMA_ABA_MNU() 'REABRE A ÚLTIMA ABA QUE FOI ABERTA E FECHADA

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.F11 'EXIBE EM TELA CHEIA ----------------------------------------------------------------------------------------------------------------------------

                PROC_EXIBIR_TELA_CHEIA(FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL) 'EXIBE EM TELA CHEIA

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.H 'HISTORICO ----------------------------------------------------------------------------------------------------------------------------------------

                If (e.CtrlKey = True) Then

                    FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PROC_MENU_HISTORICO_EXIBIR_TODOS_FORM_PRINCIPAL(True) 'EXIBE TODOS OS HISTORICOS

                End If

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.J 'DOWNLOADS ----------------------------------------------------------------------------------------------------------------------------------------

                If (e.CtrlKey = True) Then

                    'PROC_CHAMAR_JANELA_DE_BAIXADOR_DE_ARQUIVOS(Nothing) 'JANELA BAIXADORA DE ARQUIVOS

                End If

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.Home 'PÁGINA INICIAL --------------------------------------------------------------------------------------------------------------------------------

                PROC_ABRIR_PAGINA_INICIAL() 'ABRE A PÁGINA INICIAL

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.Escape 'CANCELA CARREGAMENTO DE PÁGINA --------------------------------------------------------------------------------------------------------------

                PROC_ACOES_BASICAS_AVANCAR_VOLTAR_ATUALIZAR_ETC(3) 'VOLTAR, AVANÇAR, ETC.

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.F12 'PAINEL DE CONTROLE -----------------------------------------------------------------------------------------------------------------------------

                PROC_CHAMAR_PAINEL_DE_CONTROLE() 'CHAMA O PAINEL DE CONTROLE

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.Back 'VOLTAR ----------------------------------------------------------------------------------------------------------------------------------------

                If (e.Target.TagName <> "INPUT") And (e.Target.TagName <> "TEXTAREA") Then

                    PROC_ACOES_BASICAS_AVANCAR_VOLTAR_ATUALIZAR_ETC(1) 'VOLTAR, AVANÇAR, ETC.

                End If

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.S 'SALVAR A PÁGINA ----------------------------------------------------------------------------------------------------------------------------------

                If (e.CtrlKey = True) Then

                    PROC_SALVAR_PAGINA_NO_HD() 'SALVA A PÁGINA NO HD

                End If

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.P 'IMPRIMIR PÁGINA ----------------------------------------------------------------------------------------------------------------------------------

                If (e.CtrlKey = True) Then

                    PROC_VISUALIZAR_IMPRESSAO_OU_IMPRIMIR(True) 'VISUALIZAR IMPRESSÃO OU IMPRIME

                End If

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.W 'FECHAR ABA ---------------------------------------------------------------------------------------------------------------------------------------

                If (e.CtrlKey = True) Then

                    PROC_REMOVE_ABA() 'REMOVE A ABA

                End If

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.O 'ABRIR ARQUIVO -------------------------------------------------------------------------------------------------------------------------------------

                If (e.CtrlKey = True) Then

                    PROC_ABRIR_PAGINA_SALVA_NO_HD() 'ABRE A PÁGINA SALVA NO HD

                End If

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.U 'CODIGO FONTE -------------------------------------------------------------------------------------------------------------------------------------

                If (e.CtrlKey = True) Then

                    PROC_MENU_ACAO_EXECUTAR(7) 'AÇÃO DO MENU DO BOTAO DIREITO

                End If

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case 96 'ZOOM NORMAL ------------------------------------------------------------------------------------------------------------------------------------------

                If (e.CtrlKey = True) Then

                    PROC_ZOOM_NO_TEXTO(100) 'APLICA O ZOOM NO TEXTO

                End If

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.D 'FAVORITOS ADICIONAR ------------------------------------------------------------------------------------------------------------------------------

                If (e.CtrlKey = True) Then

                    PROC_CHAMAR_MEUS_FAVORITOS(2) 'CHAMA A JANELA DE MEUS FAVORÍTOS

                End If

                '----------------------------------------------------------------------------------------------------------------------------------------------------------




            Case Keys.N 'NOVA JANELA --------------------------------------------------------------------------------------------------------------------------------------

                If (e.CtrlKey = True) Then

                    PROC_CHAMAR_NOVA_INSTANCIA_DO_NAVEGADOR() 'CHAMA UMA NOVA INSTANCIA DO NAVEGADOR

                End If

                '----------------------------------------------------------------------------------------------------------------------------------------------------------


        End Select

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA O NIVEL DE ZOOM ATUAL --------------------------------------------------------------------------------

        If (V_ZOOM <= 0) Or (V_ZOOM >= 200) Then

            V_ZOOM = 100 'ATUALIZA O ZOOM

        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_EVENTO_NAVIGATING(ByVal sender As System.Object, ByVal e As Gecko.GeckoNavigatingEventArgs) 'EVENTO NAVIGATING DO MOTOR GECKOFX
        On Error Resume Next

        Dim OBJ_MOTOR As New Gecko.GeckoWebBrowser 'NOVO MOTOR GECKOFX

        Dim V_TOKEN_DO_MOTOR As String 'INFORMA O TOKEN DE CRIAÇÃO DO MOTOR

        Dim V_ABA_QUE_ESTA As String 'ABA ATUAL EM QUE ESTÁ






        'IGUALA MOTORES ------------------------------------------------------------------------------------------------

        OBJ_MOTOR = DirectCast(sender, Gecko.GeckoWebBrowser) 'MOTOR GECKOFX

        '---------------------------------------------------------------------------------------------------------------




        'OBTENDO TOKEN DE MOTOR E ABA EM QUE ESTÁ ----------------------------------------------------------------------

        V_TOKEN_DO_MOTOR = OBJ_MOTOR.Name 'OBTENDO TOKEN DO MOTOR

        V_ABA_QUE_ESTA = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.SelectedForm.Name 'ABA ATUAL

        '---------------------------------------------------------------------------------------------------------------




        'INICIA O NOVO PROCESSO DE DOWNLOAD ----------------------------------------------------------------------------

        PROC_INICIAR_NOVO_TESTE_DE_DOWNLOAD(e.Uri.AbsoluteUri) 'INICIA O NOVO TESTE DE DOWNLOAD

        '---------------------------------------------------------------------------------------------------------------




        'INFORMA QUE ESTÁ ABRINDO A PAGINA -----------------------------------------------------------------------------

        If (V_TOKEN_DO_MOTOR = V_ABA_QUE_ESTA) Then

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.LBL_CARREGANDO.Text = "Abrindo " & e.Uri.AbsoluteUri 'URL ABRINDO...

        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_HISTORICO_PROCESSADO_CLICAR_EM_ITEM(ByVal sender As System.Object, ByVal e As System.EventArgs) 'EVENTO CLICAR EM DADO DE HISTORICO PROCESSADO
        On Error Resume Next

        Dim V_URL As String = DirectCast(sender, ToolStripMenuItem).Tag 'URL DE ITEM CLICADO






        'ABRINDO ENDEREÇO DE URL ---------------------------------------------------------------------------------------

        PROC_NAVEGAR(sender.TAG) 'NAVEGA NO ENDEREÇO DE SITE INFORMADO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_EVENTO_CLICAR_EM_SUBITEM_TODAS_AS_ABAS_ABERTAS(ByVal sender As System.Object, ByVal e As System.EventArgs) 'EVENTO QUE ABRE A ABA PELO INDEX
        On Error Resume Next

        Dim OBJ_SUBITEM As New ToolStripMenuItem 'NOVO SUBITEM DE TOOLSTRIPMENUITEM






        'SETA E OBTÉM AS PROPRIEDADES -----------------------------------------------------------------------------------------------------------------------------

        OBJ_SUBITEM = DirectCast(sender, ToolStripMenuItem) 'SETANDO E OBTENDO PROPRIEDADES

        '----------------------------------------------------------------------------------------------------------------------------------------------------------




        'ABRINDO ABA AGORA ----------------------------------------------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.TabPages.Item(OBJ_SUBITEM.Tag).Select() 'SELECIONA A ÚLTIMA ABA ABERTA AGORA

        '----------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub


















    'EVENTO TROCAR DE ABA

    Public Sub TAB_ABAS_SELECIONAR_OUTRA_ABA(ByVal sender As System.Object, ByVal e As System.EventArgs) 'AO SELECIONAR OUTRA ABA EXECUTAR ESTE EVENTO
        On Error Resume Next

        Dim OBJ_MOTOR As Gecko.GeckoWebBrowser 'MOTOR WEB

        Dim V_TOKEN_DO_MOTOR As String 'INFORMA O TOKEN DE CRIAÇÃO DO MOTOR






        'FECHANDO FORMULARIOS DE TRABALHO SECUNDÁRIO ---------------------------------------------------------------------------------------------------------------------------------------------

        PROC_FECHAR_FORMULARIOS_DE_TRABALHO_SECUNDARIO() 'FECHA TODOS OS FORMULARIOS DE TRABALHO SECUNDÁRIO

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'OBTEM DADOS DO MOTOR --------------------------------------------------------------------------------------------------------------------------------------------------------------------

        'cria um objeto somente para captura de informações, não serve como referencia direta ao objeto original

        OBJ_MOTOR = DirectCast(FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.SelectedForm.Controls.Item(0), Gecko.GeckoWebBrowser) 'OBTENDO DADOS DO MOTOR

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'DEFINE O MOTOR DE AÇÃO DE USO -------------------------------------------------------------------------------------------------------------

        PROC_DEFINE_MOTOR_DE_ACAO_EM_USO(OBJ_MOTOR) 'DEFINE O MOTOR DE AÇÃO EM USO

        '-------------------------------------------------------------------------------------------------------------------------------------------




        'SETANDO TOKEN -------------------------------------------------------------------------------------------------

        V_TOKEN_DO_MOTOR = OBJ_MOTOR.Name 'OBTENDO TOKEN DO MOTOR

        '---------------------------------------------------------------------------------------------------------------




        'OPÇOES DE MENUS -----------------------------------------------------------------------------------------------

        PROC_EXIBIR_OPCOES_DE_MENU_CORRETAMENTE() 'EXIBE AS OPÇÕES DE MENU CORRETAMENTE

        '---------------------------------------------------------------------------------------------------------------




        'ATUALIZA PROPRIEDADES ---------------------------------------------------------------------------------------------------------------------

        PROC_PROPRIEDADE_GERAIS(OBJ_MOTOR.DocumentTitle, OBJ_MOTOR.Url.AbsoluteUri, V_TOKEN_DO_MOTOR)  'ATUALIZA AS PROPRIEDADES GERAIS

        '-------------------------------------------------------------------------------------------------------------------------------------------




        'ATUALIZA FAVICON ----------------------------------------------------------------------------------------------

        PROC_PUXAR_FAVICON_DE_FORMULARIO_PRINCIPAL() 'PUXA O FAVICON DO FORMULARIO PRINCIPAL

        '---------------------------------------------------------------------------------------------------------------




        'REMOVE EVENTO ANTIGO DO MOTOR ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        RemoveHandler OBJ_MOTOR.ProgressChanged, AddressOf PROC_CARREGANDO_A_PAGINA_EXIBIR_PROGRESSO 'EXIBE O PROGRESSO DE CARREGAMENTO DA PÁGINA

        RemoveHandler OBJ_MOTOR.DocumentCompleted, AddressOf PROC_DOCUMENTO_COMPLETO_GECKOFX 'DOCUMENTO COMPLETO GECKOFX

        RemoveHandler OBJ_MOTOR.DocumentCompleted, AddressOf PROC_DOCUMENTO_COMPLETO_GECKOFX_BASICO 'DOCUMENTO COMPLETO GECKOFX EVENTO BASICO APENAS PARA ALGUMAS ALTERAÇÕES

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ADICIONA O EVENTO DO MOTOR ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        AddHandler OBJ_MOTOR.ProgressChanged, AddressOf PROC_CARREGANDO_A_PAGINA_EXIBIR_PROGRESSO 'EXIBE O PROGRESSO DE CARREGAMENTO DA PÁGINA

        AddHandler OBJ_MOTOR.DocumentCompleted, AddressOf PROC_DOCUMENTO_COMPLETO_GECKOFX 'DOCUMENTO COMPLETO GECKOFX

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'OCULTA A BARRA DE PROGRESSO DO FORMULARIO ATUAL ------------------------------------------------------------------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PRG_PROGRESSO.Visible = False 'OCULTA

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




























    End Sub





















    'PROGRESSO DE CARREGAMENTO

    Public Sub PROC_CARREGANDO_A_PAGINA_EXIBIR_PROGRESSO(ByVal sender As System.Object, ByVal e As Gecko.GeckoProgressEventArgs) 'EXIBE O PROGRESSO DE CARREGAMENTO DA PÁGINA
        On Error Resume Next

        Dim OBJ_MOTOR As Gecko.GeckoWebBrowser 'MOTOR WEB

        Dim V_TOKEN_DO_MOTOR As String 'INFORMA O TOKEN DE CRIAÇÃO DO MOTOR

        Dim V_ABA_QUE_ESTA As String = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.SelectedForm.Name 'ABA ATUAL






        'OBTEM DADOS DO MOTOR --------------------------------------------------------------------------------------------------------------------------------------------------------------------

        'cria um objeto somente para captura de informações, não serve como referencia direta ao objeto original

        OBJ_MOTOR = CType(sender, Gecko.GeckoWebBrowser) 'OBTENDO DADOS DO MOTOR

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'SETANDO TOKEN -------------------------------------------------------------------------------------------------

        V_TOKEN_DO_MOTOR = OBJ_MOTOR.Name 'OBTENDO TOKEN DO MOTOR

        '---------------------------------------------------------------------------------------------------------------




        'SÓ PERMITE ALTERAR PROPRIEDADES NA ABA CORRETA, CASO CONTRÁRIO REMOVER ESTE EVENTO ------------------------------------------------------------------------------------------------------------------------

        If (V_TOKEN_DO_MOTOR = V_ABA_QUE_ESTA) Then




            'ATUALIZA PROPRIEDADES --------------------------------------------------------------------------------------------------------------------------------------------------------------

            PROC_PROPRIEDADES_DE_PROGRESSO_EM_ANDAMENTO(e.MaximumProgress, e.CurrentProgress) 'PROPRIEDADES GERAIS DE SOMENTE PROGRESSO DE CARREGAMENTO DE PÁGINA

            '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'ATUALIZA O TEXTO DA JANELA ------------------------------------------------------------------------------------------

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.Text = OBJ_MOTOR.DocumentTitle & V_LOGOTIPO 'ATUALIZA O TITULO DA ABA

            '---------------------------------------------------------------------------------------------------------------------




            'INFORMA EM QUAL SITE ESTA CONECTADO ---------------------------------------------------------------------------------

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.LBL_CARREGANDO.Text = OBJ_MOTOR.Url.Host 'INFORMANDO EM QUAL SITE ESTA CONECTADO

            '---------------------------------------------------------------------------------------------------------------------




        Else




            'REMOVE O EVENTO DO MOTOR QUE NÃO É O MOTOR EM VISUALIZAÇÃO NA ABA ATUAL -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            RemoveHandler CType(sender, Gecko.GeckoWebBrowser).ProgressChanged, AddressOf PROC_CARREGANDO_A_PAGINA_EXIBIR_PROGRESSO 'EXIBE O PROGRESSO DE CARREGAMENTO DA PÁGINA

            '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        End If

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub






















    'EVENTOS DO BAIXADOR DE ARQUIVOS

    Public Sub PROC_BAIXAR_DOWNLOAD_AGORA(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) 'PUXA O DOWNLOAD PROPRIAMENTE DITO
        On Error Resume Next

        Dim V_TIPO_DE_ARQUIVO As String = FUNC_RETORNE_TIPO_DE_ARQUIVO_DE_DOWNLOAD(V_ENDERECO_TEMPORARIO_DE_CADA_DOWNLOAD) 'RETORNA O TIPO DE ARQUIVO DE DOWNLOAD'RETORNA ENDEREÇO DE DOWNLOAD

        Static V_ULTIMA_URL As String = "" 'ÚLTIMA URL DE DOWNLOAD ABERTA






        'VERIFICA SE O VALOR OBTIDO É VALIDO -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_TIPO_DE_ARQUIVO.Length = 0) Then


            Exit Sub 'SAINDO


        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA SE É DOWNLOAD OU TEXTO NORMAL ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_ULTIMA_URL <> V_ENDERECO_TEMPORARIO_DE_CADA_DOWNLOAD) And (V_TIPO_DE_ARQUIVO.IndexOf("/octet-stream") = -1) And (V_TIPO_DE_ARQUIVO.IndexOf("text/") = -1) And (V_TIPO_DE_ARQUIVO.IndexOf("image/") = -1) And (V_TIPO_DE_ARQUIVO.IndexOf("/x-javascript") = -1) And (V_ENDERECO_TEMPORARIO_DE_CADA_DOWNLOAD.IndexOf("file://") = -1) Then


            PROC_RODAR_GERENCIADORES_DE_DOWNLOAD(V_ENDERECO_TEMPORARIO_DE_CADA_DOWNLOAD) 'RODA OS GERENCIADORES DE DOWNLOAD


        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ATUALIZANDO ULTIMA URL DE DOWNLOAD --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        V_ULTIMA_URL = V_ENDERECO_TEMPORARIO_DE_CADA_DOWNLOAD 'ATUALIZANDO

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_BAIXAR_DOWNLOAD_COMPLETO(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) 'INFORMA QUE O DOWNLOAD ESTÁ COMPLETO
        On Error Resume Next





    End Sub




















    'EVENTOS DE PROCESSAMENTO DE HISTORICO

    Public Sub PROC_EVENTO_DE_PROCESSAMENTO_DE_HISTORICO(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) 'EVENTO DE PROCESSAMENTO DE HISTORICO
        On Error Resume Next


        'EXIBINDO DADOS DE HISTORICO -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_PROCESSAR_CONTEUDO_DE_HISTORICO_SALVO_NO_COMPUTADOR() 'PROCESSA O CONTEÚDO DE HISTÓRICO SALVO NO COMPUTADOR

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'PROCESSAR DADOS DE RECURSO AUTO_COMPLETAR -----------------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_PROCESSAR_DADOS_MENU_AUTO_COMPLETAR_COM_FILTRO_DEFIN_USUARIO(V_FILTRO_DE_EXIBICAO_DE_HISTORICO_DE_SITES_VISITADOS) 'PROCESSA OS DADOS DO MENU DE AUTO-COMPLETAR COM FILTRO DEFINIDO PELO USUÁRIO

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_EVENTO_DE_PROCESSAMENTO_DE_HISTORICO_COMPLETADO(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) 'EVENTO DE PROCESSAMENTO DE HISTORICO COMPLETADO
        On Error Resume Next


        'EXIBE RESULTADOS DE PROCESSAMENTO DE HISTORICO ------------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_PROCESSAMENTO_DE_HISTORICO_COMPLETADO_EXIBIR_RESULTADO() 'EXIBE O RESULTADO DO PROCESSAMENTO DE HISTORICO

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'EXIBE OS DADOS PROCESSADOS DO MENU AUTO-COMPLETAR ---------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_EXIBIR_MENU_AUTO_COMPLETAR_COM_FILTRO_DEFIN_USUARIO() 'EXIBE O MENU DE AUTO-COMPLETAR COM FILTRO DEFINIDO PELO USUÁRIO

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub



















    'EVENTOS GERADOR DE FAVICON PARA FORMULARIO PRINCIPAL

    Public Sub PROC_GERAR_FAVICON_FORMULARIO_PRINCIPAL(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) 'GERA O FAVICON PARA O FORMULARIO PRINCIPAL
        On Error Resume Next


        'OBTEM FAVICON DE FORMULARIO PRINCIPAL -----------------------------------------------------------------------------------------------------------------------

        IMG_FAVICON_FORMULARIO_PRINCIPAL = Nothing 'LIMPA IMAGEM ANTIGA

        IMG_FAVICON_FORMULARIO_PRINCIPAL = FUNC_GERAR_FAVICON_DA_URL(V_URL_DO_FAVICON_PROPRIEDADES_DE_MOTORES_GECKOFX) 'GERA O FAVICON DA URL INFORMADA

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_FAVICON_FORMULARIO_PRINCIPAL_GERADO(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) 'FAVICON DO FORMULARIO PRINCIPAL FOI GERADO
        On Error Resume Next


        'SETANDO FAVICON -----------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.LBL_CARREGANDO.Image = IMG_FAVICON_FORMULARIO_PRINCIPAL 'SETA O FAVICON DA BARRA DE STATUS

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PIC_FAVICON.Image = IMG_FAVICON_FORMULARIO_PRINCIPAL 'SETA O FAVICON DA BARRA DE STATUS

        '---------------------------------------------------------------------------------------------------------------


    End Sub



































    'REMOVEDOR DE EVENTOS

    Public Sub PROC_REMOVER_EVENTOS_PRINCIPAIS(ByVal V_ACAO As Boolean) 'REMOVE OS EVENTOS PRINCIPAIS DO NAVEGADOR
            On Error Resume Next

            Dim OBJ_MOTOR As Gecko.GeckoWebBrowser 'MOTOR WEB

            Dim V_TOKEN_DO_MOTOR As String 'INFORMA O TOKEN DE CRIAÇÃO DO MOTOR

            Dim V_ABA_QUE_ESTA As String = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.SelectedForm.Name 'ABA ATUAL






            'OBTEM DADOS DO MOTOR --------------------------------------------------------------------------------------------------------------------------------------------------------------------

            'cria um objeto somente para captura de informações, não serve como referencia direta ao objeto original

            OBJ_MOTOR = CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser) 'OBTENDO DADOS DO MOTOR

            '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'SETANDO TOKEN -------------------------------------------------------------------------------------------------

            V_TOKEN_DO_MOTOR = OBJ_MOTOR.Name 'OBTENDO TOKEN DO MOTOR

            '---------------------------------------------------------------------------------------------------------------




            'VERIFICA SE O TOKEN DE MOTOR É IGUAL A ABA EM FOCO ------------------------------------------------------------

            If (V_TOKEN_DO_MOTOR <> V_ABA_QUE_ESTA) Then

                Exit Sub 'SAINDO DO PROCEDIMENTO

            End If

            '---------------------------------------------------------------------------------------------------------------




            'EXECUTA A AÇÃO ---------------------------------------------------------------------------------------------------------------------------------------------------------------------

            If (V_ACAO = False) Then




                'REMOVE EVENTOS PRINCIPAIS ------------------------------------------------------------------------------------------------------------------------------------------------------

                RemoveHandler OBJ_MOTOR_DE_ACAO_EM_USO.DocumentCompleted, AddressOf PROC_DOCUMENTO_COMPLETO_GECKOFX 'DOCUMENTO COMPLETO GECKOFX

                RemoveHandler OBJ_MOTOR_DE_ACAO_EM_USO.ProgressChanged, AddressOf PROC_CARREGANDO_A_PAGINA_EXIBIR_PROGRESSO 'EXIBE O PROGRESSO DE CARREGAMENTO DA PÁGINA

                '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




                'PAUSA O FADIN ---------------------------------------------------------------------------------------------

                V_PAUSAR_FADIN = True 'PAUSANDO

                '-----------------------------------------------------------------------------------------------------------




            Else




                'REMOVE EVENTOS PRINCIPAIS ------------------------------------------------------------------------------------------------------------------------------------------------------

                RemoveHandler OBJ_MOTOR_DE_ACAO_EM_USO.DocumentCompleted, AddressOf PROC_DOCUMENTO_COMPLETO_GECKOFX 'DOCUMENTO COMPLETO GECKOFX

                RemoveHandler OBJ_MOTOR_DE_ACAO_EM_USO.ProgressChanged, AddressOf PROC_CARREGANDO_A_PAGINA_EXIBIR_PROGRESSO 'EXIBE O PROGRESSO DE CARREGAMENTO DA PÁGINA

                '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




                'ADICIONA EVENTOS PRINCIPAIS ----------------------------------------------------------------------------------------------------------------------------------------------------

                AddHandler OBJ_MOTOR_DE_ACAO_EM_USO.DocumentCompleted, AddressOf PROC_DOCUMENTO_COMPLETO_GECKOFX 'DOCUMENTO COMPLETO GECKOFX

                AddHandler OBJ_MOTOR_DE_ACAO_EM_USO.ProgressChanged, AddressOf PROC_CARREGANDO_A_PAGINA_EXIBIR_PROGRESSO 'EXIBE O PROGRESSO DE CARREGAMENTO DA PÁGINA

                '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




                'INICIA O FADIN --------------------------------------------------------------------------------------------

                V_PAUSAR_FADIN = False 'INICIANDO

                '-----------------------------------------------------------------------------------------------------------




            End If

            '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub































End Module
