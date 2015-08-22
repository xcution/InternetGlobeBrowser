Public Class FRM_POP_UP



    'Variáveis basicas

    Dim V_HOST_EM_VISUALIZACAO_POP_UP As String 'Host em visualização do motor pop-up

    Dim OBJ_IMG_FAVICON_POP_UP As Image 'Imagem do favicon

    Public v_token_pop_up As Integer 'Token da pop up










    'Procedimentos basicos

    Private Sub proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual
        On Error Resume Next

        Me.Opacity = V_VAL_CONFIG_TRANSPARENCIA 'Aplicando a transparencia

    End Sub

    Private Sub proc_informa_atualiza_quantidade_de_pop_up_add() 'Incrementa a quantidade de pop-ups abertas
        On Error Resume Next

        v_quantidade_de_pop_ups_abertas = v_quantidade_de_pop_ups_abertas + 1 'Incrementa

        v_token_pop_up = v_quantidade_de_pop_ups_abertas 'Atualiza o token

    End Sub

    Private Sub proc_informa_atualiza_quantidade_de_pop_up_remove() 'Decrementa a quantidade de pop-ups abertas
        On Error Resume Next

        v_quantidade_de_pop_ups_abertas = v_quantidade_de_pop_ups_abertas - 1 'Decrementa

    End Sub

    Private Sub proc_ocultar_barra_de_progresso_pop_up() 'Oculta a barra de progresso da pop-up
        On Error Resume Next

        ToolStripProgressBar1.Visible = False 'Oculta

    End Sub

    Private Sub proc_exibir_barra_de_progresso_pop_up() 'Exibe a barra de progresso da pop-up
        On Error Resume Next

        ToolStripProgressBar1.Visible = True 'Exibe

    End Sub







    'Procedimentos de navegação

    Private Sub proc_acao_navegacao_pop_up(ByVal v_acao As Byte) 'Ação de navegação da janela pop-up
        On Error Resume Next


        'Executa ação de navegação -----------------------------------------------------------------------------------------------------

        Select Case v_acao


            Case 1
                GECKOFX_POP_UP.GoBack() 'Voltar


            Case 2
                GECKOFX_POP_UP.GoForward() 'Avançar


            Case 3
                GECKOFX_POP_UP.Reload() 'Recarregar


            Case 4
                GECKOFX_POP_UP.Stop() 'Para o carregamento


            Case 5
                Dim V_ENDERECO_ABRIR As String = func_ler_valor(V_ARQ_CONFIG_PAGINA_INICIAL) 'Retorna o valor do arquivo lido
                GECKOFX_POP_UP.Navigate(V_ENDERECO_ABRIR) 'Abrindo o endereço informado na home
                proc_exibir_barra_de_progresso_pop_up() 'Exibe a barra de progresso da pop-up


        End Select

        '-------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_carregando_pagina_pop_up(ByVal v_maximo As Integer, ByVal v_atual As Integer, ByVal v_host As String) 'Atualiza as propriedades quando estiver carregando a pagina
        On Error Resume Next

        'Atualiza a barra de progresso ---------------------------------------------------------------------------------

        ToolStripProgressBar1.Maximum = v_maximo 'Valor maximo

        ToolStripProgressBar1.Value = v_atual 'Valor atual

        '---------------------------------------------------------------------------------------------------------------




        'Atualiza o texto da barra de status ---------------------------------------------------------------------------

        ToolStripStatusLabel1.Text = v_host 'Informando o host atual

        '---------------------------------------------------------------------------------------------------------------




        'Botoes de navegação -------------------------------------------------------------------------------------------

        ButtonX1.Enabled = GECKOFX_POP_UP.CanGoBack 'Voltar

        ButtonX2.Enabled = GECKOFX_POP_UP.CanGoForward 'Avançar

        '---------------------------------------------------------------------------------------------------------------




        'Atualizar barra de titulos ------------------------------------------------------------------------------------

        Me.Text = GECKOFX_POP_UP.DocumentTitle & v_versao_do_navegador 'Titulo e logotipo

        '---------------------------------------------------------------------------------------------------------------




        'Atualizando url da sessao pop up ------------------------------------------------------------------------------

        proc_atualize_variaveis_de_sessao_pop_up(GECKOFX_POP_UP.Url.AbsoluteUri, v_token_pop_up) 'Atualiza as variáveis de sessao pop-up

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_informe_endereco_de_site_seguro_barra_de_status() 'Informa se o endereço do site em visualização é seguro, ou nao
        On Error Resume Next

        Dim V_SITE_EM_VISUALIZACAO As String = GECKOFX_POP_UP.Url.AbsoluteUri 'Url absoluta do site

        V_SITE_EM_VISUALIZACAO = V_SITE_EM_VISUALIZACAO.ToLower 'Converter para minusculo






        'Analizando ----------------------------------------------------------------------------------------------------

        If (V_SITE_EM_VISUALIZACAO.StartsWith("https://") = True) Then



            ToolStripStatusLabel2.Image = FRM_NAVEGACAO.LST_3.Images.Item(3) 'Seguro



        Else



            ToolStripStatusLabel2.Image = FRM_NAVEGACAO.LST_3.Images.Item(4) 'Inseguro



        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_carregamento_concluido_pop_up() 'Carregamento concluido da pop-up
        On Error Resume Next


        'Atualiza o texto da barra de status ---------------------------------------------------------------------------

        ToolStripStatusLabel1.Text = GECKOFX_POP_UP.Url.Host 'Informando o host atual

        '---------------------------------------------------------------------------------------------------------------




        'Informa se o site é ou nao seguro ---------------------------------------------------------------------------------------

        proc_informe_endereco_de_site_seguro_barra_de_status() 'Informa se o endereço do site em visualização é seguro, ou nao

        '-------------------------------------------------------------------------------------------------------------------------




        'Botoes de navegação -------------------------------------------------------------------------------------------

        ButtonX1.Enabled = GECKOFX_POP_UP.CanGoBack 'Voltar

        ButtonX2.Enabled = GECKOFX_POP_UP.CanGoForward 'Avançar

        '---------------------------------------------------------------------------------------------------------------




        'Atualizar barra de titulos ------------------------------------------------------------------------------------

        Me.Text = GECKOFX_POP_UP.DocumentTitle & v_versao_do_navegador 'Titulo e logotipo

        '---------------------------------------------------------------------------------------------------------------




        'Atualiza o texto da barra de endereços ------------------------------------------------------------------------

        If (ComboBoxEx1.Focused = False) Then


            ComboBoxEx1.Text = GECKOFX_POP_UP.Url.AbsoluteUri 'Url absoluta


        End If

        '---------------------------------------------------------------------------------------------------------------




        'Atualiza variável do host do site -----------------------------------------------------------------------------

        V_HOST_EM_VISUALIZACAO_POP_UP = GECKOFX_POP_UP.Url.AbsoluteUri 'Host do site

        '---------------------------------------------------------------------------------------------------------------




        'Atualiza o favicon --------------------------------------------------------------------------------------------

        BCK_ATUALIZADOR.CancelAsync() 'Cancela ultimo

        BCK_ATUALIZADOR.RunWorkerAsync() 'Atualizando...

        '---------------------------------------------------------------------------------------------------------------




        'Atualizando a lista de sessao pop up --------------------------------------------------------------------------

        proc_salvar_sessao_de_navegacao_atual_pop_up() 'Salva a sessão de navegação atual das pop ups

        '---------------------------------------------------------------------------------------------------------------




        'Atualiza barra de progresso -----------------------------------------------------------------------------------

        proc_ocultar_barra_de_progresso_pop_up() 'Oculta a barra de progresso da pop-up

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_adicionar_pop_up_aos_favoritos() 'Adicionar o pop up aos favoritos
        On Error Resume Next

        Dim OBJ_JANELA As New FRM_FAVORITOS 'Janela de favoritos

        Dim v_titulo As String = GECKOFX_POP_UP.DocumentTitle 'Titulo

        Dim v_url As String = GECKOFX_POP_UP.Url.AbsoluteUri 'Url absoluta






        'Adicionando novo favorito -------------------------------------------------------------------------------------

        OBJ_JANELA.TopMost = True 'Topmost ativado

        OBJ_JANELA.Show() 'Abrindo formulario

        OBJ_JANELA.txt_titulo.Text = v_titulo 'Titulo

        OBJ_JANELA.txt_favorito_endereco.Text = v_url 'Url do site

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_navegar_pop_up() 'Navega no site informado
        On Error Resume Next

        Dim v_endereco_abrir As String = ComboBoxEx1.Text 'Endereço






        'Não permite abrir conteudo em branco --------------------------------------------------------------------------

        If (v_endereco_abrir = Nothing) Or (v_endereco_abrir = "") Then

            Exit Sub 'Saindo...

        End If

        '---------------------------------------------------------------------------------------------------------------




        'Abrindo a pagina agora ----------------------------------------------------------------------------------------

        GECKOFX_POP_UP.Navigate(v_endereco_abrir) 'Navegando...

        proc_exibir_barra_de_progresso_pop_up() 'Exibe a barra de progresso da pop-up

        '---------------------------------------------------------------------------------------------------------------


    End Sub










    'Procedimentos de pop - up

    Private Sub proc_ao_sair_verificar_numero_de_pop_ups_abertas() 'Ao sair verificar o numero de pop ups abertas
        On Error Resume Next


        'Informa se há ou nao janelas pop up abertas -------------------------------------------------------------------

        If (v_quantidade_de_pop_ups_abertas <= 0) Then


            proc_informar_encerrou_sessao_corretamente_pop_up(True) 'Informa que encerrou a sessão corretamente


        Else


            proc_informar_encerrou_sessao_corretamente_pop_up(False) 'Informa que encerrou a sessão corretamente


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub




    'Procedimentos e funçoes

    Private Sub proc_exibir_menus_de_contexto_corretamente() 'Exibe os menus de contexto corretamente
        On Error Resume Next


        'Menu de somente link ------------------------------------------------------------------------------------------

        If (GECKOFX_POP_UP.CanCopyLinkLocation = True) Then

            mnu_links.Show(MousePosition) 'Menu de somente links

        End If

        '---------------------------------------------------------------------------------------------------------------




        'Imagens com link ----------------------------------------------------------------------------------------------

        If (GECKOFX_POP_UP.CanCopyImageContents = True) And (GECKOFX_POP_UP.CanCopyLinkLocation = True) Then

            mnu_link_imagem.Show(MousePosition) 'Menu de imagens com link

        End If

        '---------------------------------------------------------------------------------------------------------------




        'Menu de corpo da página --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (Windows.Forms.Cursor.Current = Cursors.Arrow) Or (Windows.Forms.Cursor.Current = Cursors.IBeam) And (GECKOFX_POP_UP.CanCopyImageContents = False) And (GECKOFX_POP_UP.CanCopyImageLocation = False) And (GECKOFX_POP_UP.CanCopyLinkLocation = False) And (GECKOFX_POP_UP.CanCopySelection = False) And (GECKOFX_POP_UP.CanCutSelection = False) And (mnu_caixa_de_texto.Visible = False) Then


            mnu_body.Show(MousePosition) 'Menu de corpo do documento


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Imagens sem link ----------------------------------------------------------------------------------------------

        If (GECKOFX_POP_UP.CanCopyImageContents = True) And (GECKOFX_POP_UP.CanCopyLinkLocation = False) Then

            mnu_imagem.Show(MousePosition) 'Menu de imagens com link

        End If

        '---------------------------------------------------------------------------------------------------------------




        'Menu de copiar texto -------------------------------------------------------------------------------------------------------------------------

        If (GECKOFX_POP_UP.CanCopySelection = True) And (GECKOFX_POP_UP.CanCopyLinkLocation = False) And (mnu_caixa_de_texto.Visible = False) Then

            Dim v_site_em_selecao As String 'Informa o site em selecao




            'Copiando site em selecao -----------------------------------------------------------------------------------------------------------------

            GECKOFX_POP_UP.CopySelection() 'Obtendo endereço de site

            v_site_em_selecao = My.Computer.Clipboard.GetText 'Obtendo endereço de site

            v_site_em_selecao = v_site_em_selecao.ToLower 'Minusculo

            '---------------------------------------------------------------------------------------------------------------




            'Abrindo o menu ------------------------------------------------------------------------------------------------

            mnu_texto_selecionado.Show(MousePosition) 'Menu de texto selecionado

            '---------------------------------------------------------------------------------------------------------------




            If (v_site_em_selecao.StartsWith("http:") = True) Or (v_site_em_selecao.StartsWith("www.") = True) Then


                AbrirEsteSiteToolStripMenuItem.Enabled = True 'Habilitado

                AdicionarAosFavorítosToolStripMenuItem.Enabled = True 'Habilitado

                DefinaComoPáginaInícialToolStripMenuItem.Enabled = True 'Habilitado


            Else


                AbrirEsteSiteToolStripMenuItem.Enabled = False 'Desabilitado

                AdicionarAosFavorítosToolStripMenuItem.Enabled = False 'Desabilitado

                DefinaComoPáginaInícialToolStripMenuItem.Enabled = False 'Desabilitado


            End If


        End If

        '---------------------------------------------------------------------------------------------------------------








    End Sub
















    'Procedimentos dos menus de contexto

    Private Sub proc_abrir_link_normal() 'Abre o link normal
        On Error Resume Next

        Dim v_url_a_abrir As String 'Url a ser aberta






        'Backup fazer --------------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram() 'Backup do conteúdo da ram

        '---------------------------------------------------------------------------------------------------------------




        'Obtendo a url ------------------------------------------------------------------------------------------------------------------------------------------

        GECKOFX_POP_UP.CopyLinkLocation() 'Obtendo url

        v_url_a_abrir = My.Computer.Clipboard.GetText 'Obtendo url

        '--------------------------------------------------------------------------------------------------------------------------------------------------------




        'Não permite abrir conteudo invalido -------------------------

        If (v_url_a_abrir = "") Or (v_url_a_abrir = Nothing) Then

            Exit Sub 'Saindo...

        End If

        '-------------------------------------------------------------




        'Navegando ----------------------------------------------------------------------------------------------------------------------------------------------

        proc_navegar(v_url_a_abrir, v_tipo_de_motor_layout_engine_em_uso_agora, v_qual_motor_esta_em_uso) 'NAVEGA NO SITE SOLICITADO PELO USUARIO

        '--------------------------------------------------------------------------------------------------------------------------------------------------------




        'Backup restaurar ----------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram_restaurar() 'Backup do conteúdo da ram restaurar

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_adiciona_link_aos_favoritos() 'Adiciona o link aos favoritos
        On Error Resume Next

        Dim v_url_do_link As String = "" 'Url a ser aberta

        Dim v_texto_do_link As String = "" 'Informa o texto do link

        Dim OBJ_JANELA As New FRM_FAVORITOS 'Nova janela de favorito






        'Backup fazer --------------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram() 'Backup do conteúdo da ram

        '---------------------------------------------------------------------------------------------------------------




        'Obtendo a url ------------------------------------------------------------------------------------------------------------------------------------------

        GECKOFX_POP_UP.CopyLinkLocation() 'Obtendo url

        v_url_do_link = My.Computer.Clipboard.GetText 'Obtendo url

        '--------------------------------------------------------------------------------------------------------------------------------------------------------




        'Obtendo o texto do link --------------------------------------------------------------------------------------------------------------------------------

        v_texto_do_link = GECKOFX_POP_UP.Document.ActiveElement.TextContent 'Obtendo o texto do link


        '# NÃO DEIXA TEXTO EM BRANCO

        If (v_texto_do_link = "") Or (v_texto_do_link = Nothing) Then


            v_texto_do_link = "Link do site: " & GECKOFX_POP_UP.Url.Host 'Link do site informando...


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------------------------




        'Não permite abrir conteudo invalido ---------------------------------------------------------------------------------------

        If (v_url_do_link = "") Or (v_url_do_link = Nothing) Then

            Exit Sub 'Saindo...

        End If

        '---------------------------------------------------------------------------------------------------------------------------




        'Abrindo janela de favorito -----------------------------------------------------------------------------------------------------------------------------

        OBJ_JANELA.Show() 'Abrindo janela

        OBJ_JANELA.TopMost = True 'Topmost ativado

        OBJ_JANELA.txt_favorito_endereco.Text = v_url_do_link 'Url

        OBJ_JANELA.txt_titulo.Text = v_texto_do_link 'Título

        '--------------------------------------------------------------------------------------------------------------------------------------------------------




        'Backup restaurar ----------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram_restaurar() 'Backup do conteúdo da ram restaurar

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_copiar_link() 'Copiar o link
        On Error Resume Next

        GECKOFX_POP_UP.CopyLinkLocation() 'Copiando...

    End Sub

    Private Sub proc_copiar_selecao() 'Copia a seleção
        On Error Resume Next

        GECKOFX_POP_UP.CopySelection() 'Copiando...

    End Sub

    Private Sub proc_fazer_download_link() 'Faz o download pelo link
        On Error Resume Next

        Dim OBJ_JANELA As New FRM_NOVO_DOWNLOAD 'Janela de novo download

        Dim v_link_a_abrir As String = "" 'Informa o link a abrir






        'Backup fazer --------------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram() 'Backup do conteúdo da ram

        '---------------------------------------------------------------------------------------------------------------




        'Obtendo endereço de download ----------------------------------------------------------------------------------

        GECKOFX_POP_UP.CopyLinkLocation() 'Obtendo link

        v_link_a_abrir = My.Computer.Clipboard.GetText 'Obtendo link

        '---------------------------------------------------------------------------------------------------------------




        'Não permite valor nulo ----------------------------------------------------------------------------------------

        If (v_link_a_abrir = Nothing) Or (v_link_a_abrir = "") Then

            Exit Sub 'Saindo...

        End If

        '---------------------------------------------------------------------------------------------------------------




        'Abrindo janela de download ------------------------------------------------------------------------------------

        OBJ_JANELA.Show() 'Abrindo...

        OBJ_JANELA.TopMost = True 'Topmost igual verdadeiro

        OBJ_JANELA.txt_url_download.Text = v_link_a_abrir 'Repassando link de download...

        '---------------------------------------------------------------------------------------------------------------




        'Backup restaurar ----------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram_restaurar() 'Backup do conteúdo da ram restaurar

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_caixa_de_texto_acoes_menu(ByVal v_acao As Integer) 'Executa a ação sobre a caixa de texto
        On Error Resume Next

        Select Case v_acao

            Case 1
                GECKOFX_POP_UP.Undo() 'Desfaz

            Case 2
                GECKOFX_POP_UP.Redo() 'Refaz

            Case 3
                GECKOFX_POP_UP.CutSelection() 'Recortar

            Case 4
                GECKOFX_POP_UP.Paste() 'Colar

            Case 5
                GECKOFX_POP_UP.CutSelection() 'Limpar

            Case 6
                GECKOFX_POP_UP.SelectAll() 'Selecionar tudo

        End Select

    End Sub

    Private Sub proc_menu_de_body_acoes_de_menu(ByVal v_acao As Integer) 'Acoes sobre o menu de body
        On Error Resume Next

        Dim OBJ_JANELA As New FRM_FAVORITOS 'Nova janela de favorito






        Select Case v_acao

            Case 1
                GECKOFX_POP_UP.GoBack() 'Voltar

            Case 2
                GECKOFX_POP_UP.GoForward() 'Avançar

            Case 3
                GECKOFX_POP_UP.Reload() 'Recarregar

            Case 4
                GECKOFX_POP_UP.Stop() 'Parar

            Case 5
                proc_abrir_pagina_inicial() 'Abre a página inicial agora

            Case 6
                OBJ_JANELA.txt_favorito_endereco.Text = GECKOFX_POP_UP.Url.AbsoluteUri 'Url
                OBJ_JANELA.txt_nome_da_pasta.Text = GECKOFX_POP_UP.DocumentTitle 'Título
                OBJ_JANELA.Show() 'Exibindo janela
                OBJ_JANELA.TopMost = True 'Topmost ativado

            Case 7
                proc_salvar_pagina() 'Salva a página em visualização

            Case 8
                GECKOFX_POP_UP.SelectAll() 'Selecionar tudo

            Case 9
                GECKOFX_POP_UP.ViewSource() 'Codigo fonte

            Case 10
                GECKOFX_POP_UP.ShowPageProperties() 'Propriedades da página


        End Select


    End Sub

    Private Sub proc_menu_de_imagem_acoes(ByVal v_acao As Integer) 'Ações sobre o menu de imagens
        On Error Resume Next

        Dim OBJ_JANELA As New FRM_EXIBIR_IMAGEM 'Nova janela exibir imagem

        Dim OBJ_DIALOGO_SALVAR As New SaveFileDialog 'Novo diálogo de salvar imagem

        Dim V_EXTENCAO_IMG_SALVAR As String = Nothing 'Informa a extenção da imagem






        'Verificando opção de menu -------------------------------------------------------------------------------------

        Select Case v_acao

            Case 1


                'Backup fazer --------------------------------------------------------------------------------------------------

                proc_backup_do_conteudo_da_ram() 'Backup do conteúdo da ram

                '---------------------------------------------------------------------------------------------------------------


                GECKOFX_POP_UP.CopyImageLocation() 'Endereço da imagem
                Dim v_endereco_imagem As String = My.Computer.Clipboard.GetText 'Endereço da imagem
                OBJ_JANELA.Show() 'Abrindo o formulario
                OBJ_JANELA.GeckoWebBrowser1.Navigate(v_endereco_imagem) 'Abrindo imagem
                OBJ_JANELA.v_endereco_da_imagem_em_visualizacao = v_endereco_imagem 'Repassando o endereço da imagem
                OBJ_JANELA.proc_obter_informacoes() 'Obtendo informações agora


                'Backup restaurar ----------------------------------------------------------------------------------------------

                proc_backup_do_conteudo_da_ram_restaurar() 'Backup do conteúdo da ram restaurar

                '---------------------------------------------------------------------------------------------------------------




            Case 2
                GECKOFX_POP_UP.CopyImageContents() 'Copiando a imagem


            Case 3
                GECKOFX_POP_UP.CopyImageLocation() 'Copia endereço da imagem


            Case 4

                'Backup fazer --------------------------------------------------------------------------------------------------

                proc_backup_do_conteudo_da_ram() 'Backup do conteúdo da ram

                '---------------------------------------------------------------------------------------------------------------


                'Copiando e definindo propriedades -----------------------------------------------------------------------------------------------------------------------------------------------------------------

                GECKOFX_POP_UP.CopyImageLocation() 'Endereço da imagem

                Dim v_nome_da_imagem As String = My.Computer.Clipboard.GetText 'Endereço da imagem

                Dim V_IMAGEM As Image 'Imagem da memoria ram

                v_nome_da_imagem = v_nome_da_imagem.Substring(v_nome_da_imagem.LastIndexOf("/") + 1, (v_nome_da_imagem.Length - v_nome_da_imagem.LastIndexOf("/") - 1)) 'Obtendo o nome da imagem

                OBJ_DIALOGO_SALVAR.FileName = v_nome_da_imagem 'Informando o nome da imagem

                GECKOFX_POP_UP.CopyImageContents() 'Copiando a imagem

                V_IMAGEM = My.Computer.Clipboard.GetImage 'Obtendo a imagem da memoria ram

                V_EXTENCAO_IMG_SALVAR = v_nome_da_imagem.Substring(v_nome_da_imagem.IndexOf(".")) 'Extenção da imagem


                'Definindo propriedades do objeto caixa de diálogo salvar -----------------------------------------------------------------------------------------------

                OBJ_DIALOGO_SALVAR.Filter = "Extenção do arquivo(*" & V_EXTENCAO_IMG_SALVAR & ")|*" & V_EXTENCAO_IMG_SALVAR 'Extenção do arquivo

                '--------------------------------------------------------------------------------------------------------------------------------------------------------


                'Salvando a imagem agora ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                If (OBJ_DIALOGO_SALVAR.ShowDialog = Windows.Forms.DialogResult.OK) Then

                    V_IMAGEM.Save(OBJ_DIALOGO_SALVAR.FileName)

                End If

                '-------------------------------------------------------------------------------------------------------


                'Backup restaurar ----------------------------------------------------------------------------------------------

                proc_backup_do_conteudo_da_ram_restaurar() 'Backup do conteúdo da ram restaurar

                '---------------------------------------------------------------------------------------------------------------







































        End Select

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_abrir_site_em_selecao(ByVal v_nova_aba As Boolean) 'Abre o site selecionado em nova aba
        On Error Resume Next

        Dim v_site_em_selecao As String 'Informa o site em selecao






        'Backup fazer --------------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram() 'Backup do conteúdo da ram

        '---------------------------------------------------------------------------------------------------------------




        'Copiando site em selecao --------------------------------------------------------------------------------------

        GECKOFX_POP_UP.CopySelection() 'Obtendo endereço de site

        v_site_em_selecao = My.Computer.Clipboard.GetText 'Obtendo endereço de site

        '---------------------------------------------------------------------------------------------------------------


        'Abrindo site agora -------------------------------------------------------------------------------------------------------------------------------

        If (v_nova_aba = False) Then


            proc_navegar(v_site_em_selecao, v_tipo_de_motor_layout_engine_em_uso_agora, v_qual_motor_esta_em_uso) 'NAVEGA NO SITE SOLICITADO PELO USUARIO


        Else


            proc_adicionador_de_nova_aba_e_motor(True) 'Adiciona o motor geckofx ou não. True para sim e false para nao

            proc_navegar(v_site_em_selecao, v_tipo_de_motor_layout_engine_em_uso_agora, v_qual_motor_esta_em_uso) 'NAVEGA NO SITE SOLICITADO PELO USUARIO


        End If


        '--------------------------------------------------------------------------------------------------------------------------------------------------




        'Backup restaurar ----------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram_restaurar() 'Backup do conteúdo da ram restaurar

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_adicionar_site_selecionado_aos_favoritos() 'Adiciona o site selecionado aos favoritos
        On Error Resume Next

        Dim v_site_em_selecao As String 'Informa o site em selecao

        Dim OBJ_JANELA As New FRM_FAVORITOS 'Nova janela de favoritos






        'Backup fazer --------------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram() 'Backup do conteúdo da ram

        '---------------------------------------------------------------------------------------------------------------




        'Copiando site em selecao --------------------------------------------------------------------------------------

        GECKOFX_POP_UP.CopySelection() 'Obtendo endereço de site

        v_site_em_selecao = My.Computer.Clipboard.GetText 'Obtendo endereço de site

        '---------------------------------------------------------------------------------------------------------------


        'Adicionando site agora ----------------------------------------------------------------------------------------

        OBJ_JANELA.Show() 'Abrindo

        OBJ_JANELA.TopMost = True 'Topmost ativado

        OBJ_JANELA.txt_favorito_endereco.Text = v_site_em_selecao 'Endereco

        OBJ_JANELA.txt_titulo.Text = v_site_em_selecao 'Titulo igual endereco

        '---------------------------------------------------------------------------------------------------------------




        'Backup restaurar ----------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram_restaurar() 'Backup do conteúdo da ram restaurar

        '---------------------------------------------------------------------------------------------------------------



    End Sub

    Private Sub proc_adicionar_site_selecionado_a_pagina_inicial() 'Adiciona o site selecionado a pagina inicial
        On Error Resume Next

        Dim v_site_em_selecao As String 'Informa o site em selecao






        'Backup fazer --------------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram() 'Backup do conteúdo da ram

        '---------------------------------------------------------------------------------------------------------------




        'Copiando site em selecao --------------------------------------------------------------------------------------

        GECKOFX_POP_UP.CopySelection() 'Obtendo endereço de site

        v_site_em_selecao = My.Computer.Clipboard.GetText 'Obtendo endereço de site

        '---------------------------------------------------------------------------------------------------------------


        'Adicionando site agora ----------------------------------------------------------------------------------------

        proc_salvar_valor(v_site_em_selecao, V_ARQ_CONFIG_PAGINA_INICIAL) 'Salva a configuração

        proc_atualizar_valor_de_variaveis() 'Atualiza o valor das variáveis

        '---------------------------------------------------------------------------------------------------------------




        'Backup restaurar ----------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram_restaurar() 'Backup do conteúdo da ram restaurar

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_adicionar_site_em_visualizacao_a_pagina_inicial() 'Adiciona o site em visualizacao a pagina inicial
        On Error Resume Next


        'Adicionando site agora ----------------------------------------------------------------------------------------

        proc_salvar_valor(GECKOFX_POP_UP.Url.AbsoluteUri, V_ARQ_CONFIG_PAGINA_INICIAL) 'Salva a configuração

        proc_atualizar_valor_de_variaveis() 'Atualiza o valor das variáveis

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_informe_ao_usuario_sobre_tentativa_de_abrir_pop_up(ByVal v_mensagem As String) 'Informa ao usuário sobre a tentativa de abrir uma pop-up
        On Error Resume Next

        Dim v_host_bloqueado As String = GECKOFX_POP_UP.Url.Host 'Informa o host bloqueado

        Dim obj_item As New ToolStripMenuItem 'Novo item de menu






        'Inicializa valores --------------------------------------------------------------------------------------------

        obj_item.ToolTipText = v_host_bloqueado 'Tooltip do site

        obj_item.Text = v_mensagem 'Valor do texto do menu

        '---------------------------------------------------------------------------------------------------------------


        'Adicionando o objeto ------------------------------------------------------------------------------------------

        FRM_NAVEGACAO.ToolStripSplitButton2.DropDownItems.Add(obj_item) 'Adicionando o item

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_ler_texto_selecionado() 'Lê o texto informado e selecionado pelo usuário
        On Error Resume Next

        Dim v_texto_selecionado As String 'Armazena o texto selecionado pelo usuário






        'Informando que esta usando a caixa de entrada e saida de texto ------------------------------------------------

        V_USANDO_CAIXA_DE_ENTRADA_E_SAIDA_DE_TEXTO = True 'Informa que esta usando a caixa de entrada e saida de texto

        '---------------------------------------------------------------------------------------------------------------




        'Backup fazer --------------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram() 'Backup do conteúdo da ram

        '---------------------------------------------------------------------------------------------------------------




        'Copiando o texto para a variável ------------------------------------------------------------------------------

        GECKOFX_POP_UP.CopySelection() 'Copiando seleção para a memoria

        v_texto_selecionado = My.Computer.Clipboard.GetText 'Obtendo texto




        If (v_texto_selecionado = "") Or (v_texto_selecionado = Nothing) Then


            MsgBox("Selecione o texto e mande ler novamente!", MsgBoxStyle.Information, "Informação ao usuário") 'Informação

            Exit Sub

        End If

        '---------------------------------------------------------------------------------------------------------------




        'Lendo texto informado pelo usuário ----------------------------------------------------------------------------

        proc_falar_texto_repassado_recurso_de_voz(v_texto_selecionado) 'Lendo o texto informado pelo usuário

        '---------------------------------------------------------------------------------------------------------------




        'Backup restaurar ----------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram_restaurar() 'Backup do conteúdo da ram restaurar

        '---------------------------------------------------------------------------------------------------------------


    End Sub










    'Exibir opcoes de menus corretamente

    Private Sub proc_exibir_opcao_de_menu_correto_leitor_de_texto() 'Exibe a opção correta do item leitor de pagina, no menu body, e na barra de menus.
        On Error Resume Next

        Dim v_resposta_da_funcao As Boolean = func_retorne_motor_tts_sendo_usado_status() 'Retorna o valor do status de leitura do motor tts







        'Analizando resposta -------------------------------------------------------------------------------------------

        If (v_resposta_da_funcao = True) Then


            LeiaEsteTextoPraMimToolStripMenuItem.Text = "&Parar leitura de texto" 'Informa que esta pausando a leitura

            FRM_NAVEGACAO.ButtonItem49.Text = LeiaEsteTextoPraMimToolStripMenuItem.Text 'Igualando textos

            ToolStripMenuItem13.Text = LeiaEsteTextoPraMimToolStripMenuItem.Text 'Igualando textos


        Else


            LeiaEsteTextoPraMimToolStripMenuItem.Text = "Ou&vir este texto" 'Informa o texto original

            FRM_NAVEGACAO.ButtonItem49.Text = LeiaEsteTextoPraMimToolStripMenuItem.Text 'Igualando textos

            ToolStripMenuItem13.Text = LeiaEsteTextoPraMimToolStripMenuItem.Text 'Igualando textos


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_opcoes_de_itens_de_menus_exibir_itens_corretos() 'Exibe os itens dos menus corretamente
        On Error Resume Next


        'Recortar -----------------------------------------------------------------

        If (GECKOFX_POP_UP.CanCutSelection = True) Then

            ToolStripMenuItem6.Enabled = True 'Habilitado

        Else

            ToolStripMenuItem6.Enabled = False 'Desabilitado

        End If

        '--------------------------------------------------------------------------




        'Texto da memoria ---------------------------------------------------------

        If (My.Computer.Clipboard.GetText <> Nothing) Then

            ToolStripMenuItem9.Enabled = True 'Habilitado

        Else

            ToolStripMenuItem9.Enabled = False 'Desabilitado

        End If

        '--------------------------------------------------------------------------




        'Copiar selecao -----------------------------------------------------------

        If (GECKOFX_POP_UP.CanCopySelection = True) Then


            ToolStripMenuItem12.Enabled = True 'Habilitado

            ToolStripMenuItem7.Enabled = True 'Habilitado

            ToolStripMenuItem14.Enabled = True 'Habilitado

            CopiarTextoToolStripMenuItem.Enabled = True 'Habilitado

            ToolStripMenuItem10.Enabled = True 'Habilitado


        Else


            ToolStripMenuItem12.Enabled = False 'Desabilitado

            ToolStripMenuItem7.Enabled = False 'Desabilitado

            ToolStripMenuItem14.Enabled = False 'Desabilitado

            CopiarTextoToolStripMenuItem.Enabled = False 'Desabilitado

            ToolStripMenuItem10.Enabled = False 'Desabilitado


        End If

        '--------------------------------------------------------------------------




        'Desfazer -----------------------------------------------------------------

        If (GECKOFX_POP_UP.CanUndo = True) Then

            ToolStripMenuItem5.Enabled = True 'Habilitado

        Else

            ToolStripMenuItem5.Enabled = False 'Desabilitado

        End If

        '--------------------------------------------------------------------------




        'Refazer ------------------------------------------------------------------

        If (GECKOFX_POP_UP.CanRedo = True) Then

            RefazerToolStripMenuItem1.Enabled = True 'Habilitado

        Else

            RefazerToolStripMenuItem1.Enabled = False 'Desabilitado

        End If

        '--------------------------------------------------------------------------




        'Voltar -------------------------------------------------------------------

        If (GECKOFX_POP_UP.CanGoBack = True) Then

            ToolStripMenuItem37.Enabled = True 'Habilitado

        Else

            ToolStripMenuItem37.Enabled = False 'Desabilitado

        End If

        '--------------------------------------------------------------------------




        'Voltar -------------------------------------------------------------------

        If (GECKOFX_POP_UP.CanGoForward = True) Then

            ToolStripMenuItem38.Enabled = True 'Habilitado

        Else

            ToolStripMenuItem38.Enabled = False 'Desabilitado

        End If

        '--------------------------------------------------------------------------




        'Exibe menu correto leitor de texto ---------------------------------------------------------------------------------------------------

        proc_exibir_opcao_de_menu_correto_leitor_de_texto() 'Exibe a opção correta do item leitor de pagina, no menu body, e na barra de menus.

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub








    'Referente ao menu do botao direito para editar a imagem com o editor de imagens

    Dim V_INDEX_DA_IMAGEM_SALVA As Integer 'Informa o index da imagem salva






    Public Sub proc_editar_imagem_com_editor_de_imagens_pop_up() 'Edita a imagem com o editor de imagens em pop-up
        On Error Resume Next

        Dim OBJ_IMAGEM_RECUPERADA As Image 'Imagem recuperada da ram

        Dim V_END_ARQUIVO_DA_IMAGEM As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\" & "imagem_ps" & V_INDEX_DA_IMAGEM_SALVA & ".jpg" 'Obtendo o endereço da imagem






        'Backup fazer --------------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram() 'Backup do conteúdo da ram

        '---------------------------------------------------------------------------------------------------------------




        'Atualizando index ---------------------------------------------------------------------------------------------

        V_INDEX_DA_IMAGEM_SALVA = V_INDEX_DA_IMAGEM_SALVA + 1 'Atualizando...

        '---------------------------------------------------------------------------------------------------------------



        'Obtendo dados da imagem ---------------------------------------------------------------------------------------


        GECKOFX_POP_UP.CopyImageContents() 'Copiando a imagem

        OBJ_IMAGEM_RECUPERADA = My.Computer.Clipboard.GetImage 'Obtendo a imagem

        OBJ_IMAGEM_RECUPERADA.Save(V_END_ARQUIVO_DA_IMAGEM) 'Salvando a imagem


        '---------------------------------------------------------------------------------------------------------------




        'Abrindo programa ----------------------------------------------------------------------------------------------

        proc_chamar_aplicativo_photo_sete(True, V_END_ARQUIVO_DA_IMAGEM) 'Chamar o aplicativo photo sete

        '---------------------------------------------------------------------------------------------------------------



        'Backup restaurar ----------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram_restaurar() 'Backup do conteúdo da ram restaurar

        '---------------------------------------------------------------------------------------------------------------


    End Sub




















    Private Sub FRM_POP_UP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        proc_informa_atualiza_quantidade_de_pop_up_add() 'Incrementa a quantidade de pop-ups abertas

        proc_informar_encerrou_sessao_corretamente_pop_up(False) 'Informa que encerrou a sessão corretamente

        proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        On Error Resume Next

        proc_acao_navegacao_pop_up(1) 'Ação de navegação da janela pop-up

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        On Error Resume Next

        proc_acao_navegacao_pop_up(2) 'Ação de navegação da janela pop-up

    End Sub

    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        On Error Resume Next

        proc_acao_navegacao_pop_up(3) 'Ação de navegação da janela pop-up

    End Sub

    Private Sub ButtonX7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX7.Click
        On Error Resume Next

        proc_acao_navegacao_pop_up(4) 'Ação de navegação da janela pop-up

    End Sub

    Private Sub ButtonX8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX8.Click
        On Error Resume Next

        proc_acao_navegacao_pop_up(5) 'Ação de navegação da janela pop-up

    End Sub

    Private Sub GeckoWebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GECKOFX_POP_UP.DocumentCompleted
        On Error Resume Next

        proc_carregamento_concluido_pop_up() 'Carregamento concluido da pop-up

    End Sub

    Private Sub GeckoWebBrowser1_ProgressChanged(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) Handles GECKOFX_POP_UP.ProgressChanged
        On Error Resume Next

        proc_carregando_pagina_pop_up(e.MaximumProgress, e.CurrentProgress, GECKOFX_POP_UP.StatusText) 'Atualiza as propriedades quando estiver carregando a pagina

    End Sub

    Private Sub GeckoWebBrowser1_DomMouseMove(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoDomMouseEventArgs) Handles GECKOFX_POP_UP.DomMouseMove
        On Error Resume Next

        'Atualiza o texto da barra de status ---------------------------------------------------------------------------

        ToolStripStatusLabel1.Text = GECKOFX_POP_UP.StatusText 'Informando texto do motor

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub BCK_ATUALIZADOR_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BCK_ATUALIZADOR.DoWork
        On Error Resume Next

        OBJ_IMG_FAVICON_POP_UP = func_gerar_favicon_de_web_sites(V_HOST_EM_VISUALIZACAO_POP_UP) 'Gera o favicon da página visitada

    End Sub

    Private Sub BCK_ATUALIZADOR_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BCK_ATUALIZADOR.RunWorkerCompleted
        On Error Resume Next

        ButtonX3.Image = OBJ_IMG_FAVICON_POP_UP 'Atualizando imagem

    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        On Error Resume Next

        proc_adicionar_pop_up_aos_favoritos() 'Adicionar o pop up aos favoritos

    End Sub

    Private Sub FRM_POP_UP_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next

        proc_informa_atualiza_quantidade_de_pop_up_remove() 'Decrementa a quantidade de pop-ups abertas

        proc_ao_sair_verificar_numero_de_pop_ups_abertas() 'Ao sair verificar o numero de pop ups abertas

    End Sub

    Private Sub ComboBoxEx1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxEx1.KeyDown
        On Error Resume Next

        If (e.KeyCode = Keys.Enter) Then


            e.SuppressKeyPress = True 'Desabilita o beep

            proc_navegar_pop_up() 'Navega no site informado


        End If

    End Sub

    Private Sub ToolStripStatusLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel2.Click
        On Error Resume Next

        proc_informe_com_voz_sobre_protocolo_https_seguranca_pagina(GECKOFX_POP_UP.Url.AbsoluteUri) 'Informa ao usuário se a página visitada é ou nao segura

    End Sub

    Private Sub GECKOFX_PROT_ShowContextMenu(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoContextMenuEventArgs) Handles GECKOFX_POP_UP.ShowContextMenu
        On Error Resume Next


        'Exibe os menus e seus itens corretamente ----------------------------------------------------------------------

        proc_opcoes_de_itens_de_menus_exibir_itens_corretos() 'Exibe os itens dos menus corretamente

        '---------------------------------------------------------------------------------------------------------------


        'Exibindo menus agora ------------------------------------------------------------------------------------------

        proc_exibir_menus_de_contexto_corretamente() 'Exibe os menus de contexto corretamente

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub GECKOFX_PROT_DomMouseDown(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoDomMouseEventArgs) Handles GECKOFX_POP_UP.DomMouseDown
        On Error Resume Next


        'Exibe os menus e seus itens corretamente ----------------------------------------------------------------------

        proc_opcoes_de_itens_de_menus_exibir_itens_corretos() 'Exibe os itens dos menus corretamente

        '---------------------------------------------------------------------------------------------------------------


        'Exibir o menu de caixa de texto ------------------------------------------------------------------------------------------------------

        If (e.Button <> 0) And (Windows.Forms.Cursor.Current = Cursors.IBeam) Then




            If (e.Target.TagName = "INPUT") Or (e.Target.TagName = "TEXTAREA") Then

                mnu_caixa_de_texto.Show(MousePosition) 'Abrir o menu de contexto

            End If




        End If

        '--------------------------------------------------------------------------------------------------------------------------------------



    End Sub

    Private Sub ToolStripMenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem29.Click
        On Error Resume Next

        proc_abrir_link_normal() 'Abre o link normal

    End Sub

    Private Sub ToolStripMenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem31.Click
        On Error Resume Next

        proc_abrir_link_normal() 'Abre o link normal

    End Sub

    Private Sub ToolStripMenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem27.Click
        On Error Resume Next

        proc_adiciona_link_aos_favoritos() 'Adiciona o link aos favoritos

    End Sub

    Private Sub ToolStripMenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem33.Click
        On Error Resume Next

        proc_adiciona_link_aos_favoritos() 'Adiciona o link aos favoritos

    End Sub

    Private Sub ToolStripMenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem28.Click
        On Error Resume Next

        proc_copiar_link() 'Copiar o link

    End Sub

    Private Sub ToolStripMenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem34.Click
        On Error Resume Next

        proc_copiar_link() 'Copiar o link

    End Sub

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
        On Error Resume Next

        proc_copiar_selecao() 'Copia a seleção

    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        On Error Resume Next

        proc_copiar_selecao() 'Copia a seleção

    End Sub

    Private Sub CopiarTextoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarTextoToolStripMenuItem.Click
        On Error Resume Next

        proc_copiar_selecao() 'Copia a seleção

    End Sub

    Private Sub ToolStripMenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem14.Click
        On Error Resume Next

        proc_copiar_selecao() 'Copia a seleção

    End Sub

    Private Sub FazerDownloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FazerDownloadToolStripMenuItem.Click
        On Error Resume Next

        proc_fazer_download_link() 'Faz o download pelo link

    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        On Error Resume Next

        proc_fazer_download_link() 'Faz o download pelo link

    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        On Error Resume Next

        proc_caixa_de_texto_acoes_menu(1) 'Executa a ação sobre a caixa de texto

    End Sub

    Private Sub RefazerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefazerToolStripMenuItem1.Click
        On Error Resume Next

        proc_caixa_de_texto_acoes_menu(2) 'Executa a ação sobre a caixa de texto

    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        On Error Resume Next

        proc_caixa_de_texto_acoes_menu(3) 'Executa a ação sobre a caixa de texto

    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        On Error Resume Next

        proc_caixa_de_texto_acoes_menu(4) 'Executa a ação sobre a caixa de texto

    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        On Error Resume Next

        proc_caixa_de_texto_acoes_menu(5) 'Executa a ação sobre a caixa de texto

    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        On Error Resume Next

        proc_caixa_de_texto_acoes_menu(6) 'Executa a ação sobre a caixa de texto

    End Sub

    Private Sub ToolStripMenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem37.Click
        On Error Resume Next

        proc_menu_de_body_acoes_de_menu(1) 'Acoes sobre o menu de body

    End Sub

    Private Sub ToolStripMenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem38.Click
        On Error Resume Next

        proc_menu_de_body_acoes_de_menu(2) 'Acoes sobre o menu de body

    End Sub

    Private Sub ToolStripMenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem39.Click
        On Error Resume Next

        proc_menu_de_body_acoes_de_menu(3) 'Acoes sobre o menu de body

    End Sub

    Private Sub ToolStripMenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem40.Click
        On Error Resume Next

        proc_menu_de_body_acoes_de_menu(4) 'Acoes sobre o menu de body

    End Sub

    Private Sub HomePáginaInícialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomePáginaInícialToolStripMenuItem.Click
        On Error Resume Next

        proc_menu_de_body_acoes_de_menu(5) 'Acoes sobre o menu de body

    End Sub

    Private Sub ToolStripMenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem41.Click
        On Error Resume Next

        proc_menu_de_body_acoes_de_menu(6) 'Acoes sobre o menu de body

    End Sub

    Private Sub ToolStripMenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem42.Click
        On Error Resume Next

        proc_menu_de_body_acoes_de_menu(7) 'Acoes sobre o menu de body

    End Sub

    Private Sub ToolStripMenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem44.Click
        On Error Resume Next

        proc_menu_de_body_acoes_de_menu(8) 'Acoes sobre o menu de body

    End Sub

    Private Sub ToolStripMenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem45.Click
        On Error Resume Next

        proc_menu_de_body_acoes_de_menu(9) 'Acoes sobre o menu de body

    End Sub

    Private Sub ToolStripMenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem46.Click
        On Error Resume Next

        proc_menu_de_body_acoes_de_menu(10) 'Acoes sobre o menu de body

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        On Error Resume Next

        proc_menu_de_imagem_acoes(1) 'Ações sobre o menu de imagens

    End Sub

    Private Sub CopiarImagemToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarImagemToolStripMenuItem1.Click
        On Error Resume Next

        proc_menu_de_imagem_acoes(2) 'Ações sobre o menu de imagens

    End Sub

    Private Sub ToolStripMenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem47.Click
        On Error Resume Next

        proc_menu_de_imagem_acoes(3) 'Ações sobre o menu de imagens

    End Sub

    Private Sub ToolStripMenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem48.Click
        On Error Resume Next

        proc_menu_de_imagem_acoes(4) 'Ações sobre o menu de imagens

    End Sub

    Private Sub ExibirImagemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExibirImagemToolStripMenuItem.Click
        On Error Resume Next

        proc_menu_de_imagem_acoes(1) 'Ações sobre o menu de imagens

    End Sub

    Private Sub CopiarImagemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarImagemToolStripMenuItem.Click
        On Error Resume Next

        proc_menu_de_imagem_acoes(2) 'Ações sobre o menu de imagens

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        On Error Resume Next

        proc_menu_de_imagem_acoes(3) 'Ações sobre o menu de imagens

    End Sub

    Private Sub SalvarimagemComoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarimagemComoToolStripMenuItem.Click
        On Error Resume Next

        proc_menu_de_imagem_acoes(4) 'Ações sobre o menu de imagens

    End Sub

    Private Sub SelecionarTudoCtrlAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelecionarTudoCtrlAToolStripMenuItem.Click
        On Error Resume Next

        proc_menu_de_body_acoes_de_menu(8) 'Acoes sobre o menu de body

    End Sub

    Private Sub NovaAbaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovaAbaToolStripMenuItem.Click
        On Error Resume Next

        proc_abrir_site_em_selecao(True) 'Abre o site selecionado em nova aba

    End Sub

    Private Sub AbaAtualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbaAtualToolStripMenuItem.Click
        On Error Resume Next

        proc_abrir_site_em_selecao(False) 'Abre o site selecionado em nova aba

    End Sub

    Private Sub AdicionarAosFavorítosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarAosFavorítosToolStripMenuItem.Click
        On Error Resume Next

        proc_adicionar_site_selecionado_aos_favoritos() 'Adiciona o site selecionado aos favoritos

    End Sub

    Private Sub DefinaComoPáginaInícialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefinaComoPáginaInícialToolStripMenuItem.Click
        On Error Resume Next

        proc_adicionar_site_selecionado_a_pagina_inicial() 'Adiciona o site selecionado a pagina inicial

    End Sub

    Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem16.Click
        On Error Resume Next

        proc_adicionar_site_em_visualizacao_a_pagina_inicial() 'Adiciona o site em visualizacao a pagina inicial

    End Sub

    Private Sub GECKOFX_PROT_CreateWindow(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoCreateWindowEventArgs) Handles GECKOFX_POP_UP.CreateWindow
        On Error Resume Next

        Dim OBJ_JANELA_POP_UP As New FRM_POP_UP 'Nova janela de pop-up

        Dim V_HOST_DE_SITE_ABRIR_POP_UP As String = GECKOFX_POP_UP.Url.Host 'Host do site que quer abrir a pop-up

        Dim V_FAZ_PARTE As Boolean 'Informa que o host faz parte da lista

        Dim V_PODE_ABRIR As Integer 'Informa que pode abrir a pop-up

        Static V_NUM_MENSAGEM As Integer 'Numero da mensagem






        'Atualiza o numero da mensagem -----------------------------------------------------------

        V_NUM_MENSAGEM = V_NUM_MENSAGEM + 1 'Atualizando o numero da mensagem

        '-----------------------------------------------------------------------------------------




        'Evento som ------------------------------------------------------------------------------

        proc_som_de_evento_ouvir(v_som_de_pop_up) 'Ouvir o som de evento

        '-----------------------------------------------------------------------------------------




        'Carregando a lista ---------------------------------------------------------------------------------------------------------------------------------------

        V_VAL_CONFIG_POP_UP_ACAO = func_ler_valor(V_ARQ_CONFIG_POP_UP_ACAO) 'Retorna o valor do arquivo lido

        V_VAL_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS = func_ler_valor(V_ARQ_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS) 'Retorna o valor do arquivo lido

        '----------------------------------------------------------------------------------------------------------------------------------------------------------




        'Atualizando variáveis locais -----------------------------------------------------------------------------------------------

        V_PODE_ABRIR = V_VAL_CONFIG_POP_UP_ACAO 'Informa se o bloqueador de pop-up esta ativado

        '----------------------------------------------------------------------------------------------------------------------------




        'Não permite valor inválido ------------------------------------------------------------------------------------

        If (V_PODE_ABRIR <> 1) And (V_PODE_ABRIR <> 2) And (V_PODE_ABRIR <> 3) Then


            OBJ_JANELA_POP_UP.Opacity = 0 'Formulario invisivel

            OBJ_JANELA_POP_UP.ShowInTaskbar = False 'Não exibe na barra de tarefas

            OBJ_JANELA_POP_UP.Show() 'Abrindo a pop-up

            e.WebBrowser = OBJ_JANELA_POP_UP.GECKOFX_POP_UP 'Lendo valores de pop-up

            OBJ_JANELA_POP_UP.Close() 'Fecha o formulario

            Exit Sub


        End If

        '---------------------------------------------------------------------------------------------------------------




        'Verifica se o modo bloqueador de pop-up esta ativado ou não ---------------------------

        If (V_PODE_ABRIR = 1) Then


            OBJ_JANELA_POP_UP.Show() 'Abrindo a pop-up

            e.WebBrowser = OBJ_JANELA_POP_UP.GECKOFX_POP_UP 'Lendo valores de pop-up

            OBJ_JANELA_POP_UP.GECKOFX_POP_UP.Refresh() 'Reconstroi o controle

            Exit Sub 'Saindo...


        End If

        '---------------------------------------------------------------------------------------




        'Não abre a pop-up ----------------------------------------------------------------------------------------------------------------------------------------------

        If (V_PODE_ABRIR = 2) Then


            OBJ_JANELA_POP_UP.Opacity = 0 'Formulario invisivel

            OBJ_JANELA_POP_UP.ShowInTaskbar = False 'Não exibe na barra de tarefas

            OBJ_JANELA_POP_UP.Show() 'Abrindo a pop-up

            e.WebBrowser = OBJ_JANELA_POP_UP.GECKOFX_POP_UP 'Lendo valores de pop-up

            OBJ_JANELA_POP_UP.Close() 'Fecha o formulario

            proc_informe_ao_usuario_sobre_tentativa_de_abrir_pop_up("Mensagem: " & V_NUM_MENSAGEM & vbCrLf & V_MS_15) 'Mensagem

            Exit Sub 'Saindo...


        End If

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Verifica se o host esta na lista de permitidos ---------------------------------------------------------------------------------------

        If (V_PODE_ABRIR = 3) And (V_VAL_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS.Contains(V_HOST_DE_SITE_ABRIR_POP_UP) = True) Then


            OBJ_JANELA_POP_UP.Show() 'Abrindo a pop-up

            e.WebBrowser = OBJ_JANELA_POP_UP.GECKOFX_POP_UP 'Lendo valores de pop-up


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------




        'Verifica se o host esta na lista de permitidos -----------------------------------------------------------------------------------------------------------------

        If (V_PODE_ABRIR = 3) And (V_VAL_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS.Contains(V_HOST_DE_SITE_ABRIR_POP_UP) = False) Then


            OBJ_JANELA_POP_UP.Opacity = 0 'Formulario invisivel

            OBJ_JANELA_POP_UP.ShowInTaskbar = False 'Não exibe na barra de tarefas

            OBJ_JANELA_POP_UP.Show() 'Abrindo a pop-up

            e.WebBrowser = OBJ_JANELA_POP_UP.GECKOFX_POP_UP 'Lendo valores de pop-up

            OBJ_JANELA_POP_UP.Close() 'Fecha o formulario

            proc_informe_ao_usuario_sobre_tentativa_de_abrir_pop_up("Mensagem: " & V_NUM_MENSAGEM & vbCrLf & V_MS_16) 'Mensagem

            Exit Sub 'Saindo...


        End If

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------



    End Sub

    Private Sub LeiaEsteTextoPraMimToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeiaEsteTextoPraMimToolStripMenuItem.Click
        On Error Resume Next

        proc_ler_texto_selecionado() 'Lê o texto informado e selecionado pelo usuário

    End Sub

    Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem13.Click
        On Error Resume Next

        proc_ler_texto_selecionado() 'Lê o texto informado e selecionado pelo usuário

    End Sub

    Private Sub SegurançaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SegurançaToolStripMenuItem.Click
        On Error Resume Next

        proc_informe_com_voz_sobre_protocolo_https_seguranca_pagina(GECKOFX_POP_UP.Url.AbsoluteUri) 'Informa ao usuário se a página visitada é ou nao segura

    End Sub

    Private Sub GECKOFX_POP_UP_Navigating(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoNavigatingEventArgs) Handles GECKOFX_POP_UP.Navigating
        On Error Resume Next

        proc_exibir_barra_de_progresso_pop_up() 'Exibe a barra de progresso da pop-up

    End Sub

    Private Sub GECKOFX_POP_UP_DomKeyDown(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoDomKeyEventArgs) Handles GECKOFX_POP_UP.DomKeyDown
        On Error Resume Next

        Dim V_VALOR_DE_ZOOM_NO_MOTOR As Single = GECKOFX_POP_UP.Window.TextZoom 'Informa o valor de zoom no motor

        Static V_TELA_CHEIA_ULTIMO_VALOR As Integer 'Informa o valor anterior da tela cheia






        'Seleciona a tecla e executa ação associada ------------------------------------------------------------------------------------------------------------------

        Select Case e.KeyCode




            'Aumentar o zoom --------------------------------------------------------------------------------------------------------------

            Case e.CtrlKey = True And Keys.Add 'Zoom aumentar

                GECKOFX_POP_UP.Window.TextZoom = V_VALOR_DE_ZOOM_NO_MOTOR + 0.25F 'Atualizando o valor de zoom

                '------------------------------------------------------------------------------------------------------------------------------




                'Restaura o valor de zoom -----------------------------------------------------------------------------------------------------

            Case e.CtrlKey = True And Keys.Z 'Restaurar valor de zoom

                GECKOFX_POP_UP.Window.TextZoom = 1.0F 'Zoom normal

                '------------------------------------------------------------------------------------------------------------------------------




                'Diminuir o zoom --------------------------------------------------------------------------------------------------------------

            Case e.CtrlKey = True And Keys.Subtract 'Zoom diminuir

                GECKOFX_POP_UP.Window.TextZoom = V_VALOR_DE_ZOOM_NO_MOTOR - 0.25F 'Atualizando o valor de zoom

                '------------------------------------------------------------------------------------------------------------------------------




                'Voltar ------------------------------------------------------------------------------------------------------------------------

            Case Keys.Back And (e.Target.TagName <> "INPUT") And (e.Target.TagName <> "TEXTAREA") 'Voltando uma página

                GECKOFX_POP_UP.GoBack() 'Voltando uma pagina

                '------------------------------------------------------------------------------------------------------------------------------




                'Pagina inicial ---------------------------------------------------------------------------------------------------------------

            Case Keys.Home

                GECKOFX_POP_UP.Navigate(V_VAL_CONFIG_PAGINA_INICIAL) 'Abre a página inicial agora

                '------------------------------------------------------------------------------------------------------------------------------




                'Atualizar a página -----------------------------------------------------------------------------------------------------------

            Case Keys.F5

                GECKOFX_POP_UP.Reload() 'Atualizando a página

                '------------------------------------------------------------------------------------------------------------------------------




                'Cancelar carregamento --------------------------------------------------------------------------------------------------------

            Case Keys.Escape

                GECKOFX_POP_UP.Stop() 'Parando carregamento

                '------------------------------------------------------------------------------------------------------------------------------




                'Exibir historico --------------------------------------------------------------------------------------------------------

            Case e.CtrlKey = True And Keys.H

                proc_chamar_historico() 'Chama a janela de historico

                '------------------------------------------------------------------------------------------------------------------------------




                'Codigo fonte da pagina -------------------------------------------------------------------------------------------------------

            Case e.CtrlKey = True And Keys.U

                GECKOFX_POP_UP.ViewSource() 'Exibindo o codigo fonte da página

                '------------------------------------------------------------------------------------------------------------------------------




                'Exibir painel de controle ----------------------------------------------------------------------------------------------------

            Case e.ShiftKey = True And Keys.P

                proc_chamar_painel_de_controle() 'Chamar o painel de controle

                '------------------------------------------------------------------------------------------------------------------------------




                'Exibe opções de ajuda e sobre a versao do software ---------------------------------------------------------------------------

            Case Keys.F1

                proc_chamar_aplicativo_exibidor_de_versao() 'Chamar o aplicativo exibidor de versao

                '------------------------------------------------------------------------------------------------------------------------------





                'Adiciona aos favoritos -------------------------------------------------------------------------------------------------------

            Case e.CtrlKey = True And Keys.D

                proc_adicionar_pop_up_aos_favoritos() 'Adicionar o pop up aos favoritos

                '------------------------------------------------------------------------------------------------------------------------------




                'Exibe a lista de downloads ---------------------------------------------------------------------------------------------------

            Case e.CtrlKey = True And Keys.J

                proc_exibir_lista_de_downloads() 'Exibir lista de downloads

                '------------------------------------------------------------------------------------------------------------------------------




                'Move o foco para a barra de endereços ----------------------------------------------------------------------------------------

            Case Keys.F4

                ComboBoxEx1.Focus() 'Movendo o foco

                '------------------------------------------------------------------------------------------------------------------------------



        End Select

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub EditarImagemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarImagemToolStripMenuItem.Click
        On Error Resume Next

        proc_editar_imagem_com_editor_de_imagens_pop_up() 'Edita a imagem com o editor de imagens em pop-up

    End Sub

    Private Sub EditarImagemToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarImagemToolStripMenuItem1.Click
        On Error Resume Next

        proc_editar_imagem_com_editor_de_imagens_pop_up() 'Edita a imagem com o editor de imagens em pop-up

    End Sub

    Private Sub MeuIPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeuIPToolStripMenuItem.Click
        On Error Resume Next

        proc_informe_o_ip_local() 'Informa o ip local do computador

    End Sub

    Private Sub IPDesteSiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IPDesteSiteToolStripMenuItem.Click
        On Error Resume Next

        proc_informe_o_ip_do_site_em_visualizacao(GECKOFX_POP_UP.Url.Host) 'Informa o endereço ip do site em visualização.

    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        On Error Resume Next

        proc_exibir_end_ip_de_site_e_proprio_end_ip(GECKOFX_POP_UP.Url.Host, Control.MousePosition) 'Exibe endereço de site e o proprio end ip.

    End Sub

    Private Sub TirarFotoDesteSiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TirarFotoDesteSiteToolStripMenuItem.Click
        On Error Resume Next

        proc_tirar_foto_do_site_em_visualizacao() 'Obtem a imagem do site em visualizacao

    End Sub

End Class