﻿Public Class FRM_PROTOTICO




    'Variaveis basicas

    Dim V_NUM_EXEC_PROC As Byte = 1 'Informa quantas vezes o procedimento foi executado













    'Procedimentos e funçoes

    Private Sub proc_exibir_menus_de_contexto_corretamente() 'Exibe os menus de contexto corretamente
        On Error Resume Next


        'Menu de somente link ------------------------------------------------------------------------------------------

        If (GECKOFX_PROT.CanCopyLinkLocation = True) Then

            mnu_links.Show(MousePosition) 'Menu de somente links

        End If

        '---------------------------------------------------------------------------------------------------------------




        'Imagens com link ----------------------------------------------------------------------------------------------

        If (GECKOFX_PROT.CanCopyImageContents = True) And (GECKOFX_PROT.CanCopyLinkLocation = True) Then

            mnu_link_imagem.Show(MousePosition) 'Menu de imagens com link

        End If

        '---------------------------------------------------------------------------------------------------------------




        'Menu de corpo da página --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (Windows.Forms.Cursor.Current = Cursors.Arrow) Or (Windows.Forms.Cursor.Current = Cursors.IBeam) And (GECKOFX_PROT.CanCopyImageContents = False) And (GECKOFX_PROT.CanCopyImageLocation = False) And (GECKOFX_PROT.CanCopyLinkLocation = False) And (GECKOFX_PROT.CanCopySelection = False) And (GECKOFX_PROT.CanCutSelection = False) And (mnu_caixa_de_texto.Visible = False) Then


            mnu_body.Show(MousePosition) 'Menu de corpo do documento


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Imagens sem link ----------------------------------------------------------------------------------------------

        If (GECKOFX_PROT.CanCopyImageContents = True) And (GECKOFX_PROT.CanCopyLinkLocation = False) Then

            mnu_imagem.Show(MousePosition) 'Menu de imagens com link

        End If

        '---------------------------------------------------------------------------------------------------------------




        'Menu de copiar texto -------------------------------------------------------------------------------------------------------------------------

        If (GECKOFX_PROT.CanCopySelection = True) And (GECKOFX_PROT.CanCopyLinkLocation = False) And (mnu_caixa_de_texto.Visible = False) Then

            Dim v_site_em_selecao As String 'Informa o site em selecao




            'Copiando site em selecao -----------------------------------------------------------------------------------------------------------------

            GECKOFX_PROT.CopySelection() 'Obtendo endereço de site

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

    Private Sub proc_abrir_link_em_nova_aba() 'Abre o link em nova aba
        On Error Resume Next

        Dim v_url_a_abrir As String 'Url a ser aberta

        Dim v_index_de_aba As Integer = FRM_NAVEGACAO.TabControl1.SelectedTabIndex 'Obtendo o index






        'Backup fazer --------------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram() 'Backup do conteúdo da ram

        '---------------------------------------------------------------------------------------------------------------




        'Obtendo a url ------------------------------------------------------------------------------------------------------------------------------------------

        GECKOFX_PROT.CopyLinkLocation() 'Obtendo url

        v_url_a_abrir = My.Computer.Clipboard.GetText 'Obtendo url

        '--------------------------------------------------------------------------------------------------------------------------------------------------------




        'Não permite abrir conteudo invalido -------------------------

        If (v_url_a_abrir = "") Or (v_url_a_abrir = Nothing) Then

            Exit Sub 'Saindo...

        End If

        '-------------------------------------------------------------




        'Adicionando nova aba -----------------------------------------------------------------------------------------------------------------------------------

        proc_adicionador_de_nova_aba_e_motor(True) 'Adiciona o motor geckofx ou não. True para sim e false para nao

        proc_navegar(v_url_a_abrir, v_tipo_de_motor_layout_engine_em_uso_agora, v_qual_motor_esta_em_uso) 'NAVEGA NO SITE SOLICITADO PELO USUARIO

        '--------------------------------------------------------------------------------------------------------------------------------------------------------




        'Abre o link em segundo plano ou nao --------------------------------------------------------------------------------------------------------------------

        If (V_VAL_CONFIG_ABRIR_LINK_EM_SEGUNDO_PLANO = True) Then


            FRM_NAVEGACAO.TabControl1.SelectedTabIndex = v_index_de_aba 'Restaurando aba


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------------------------




        'Backup restaurar ----------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram_restaurar() 'Backup do conteúdo da ram restaurar

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_abrir_link_normal() 'Abre o link normal
        On Error Resume Next

        Dim v_url_a_abrir As String 'Url a ser aberta






        'Backup fazer --------------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram() 'Backup do conteúdo da ram

        '---------------------------------------------------------------------------------------------------------------




        'Obtendo a url ------------------------------------------------------------------------------------------------------------------------------------------

        GECKOFX_PROT.CopyLinkLocation() 'Obtendo url

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

        GECKOFX_PROT.CopyLinkLocation() 'Obtendo url

        v_url_do_link = My.Computer.Clipboard.GetText 'Obtendo url

        '--------------------------------------------------------------------------------------------------------------------------------------------------------




        'Obtendo o texto do link --------------------------------------------------------------------------------------------------------------------------------

        v_texto_do_link = GECKOFX_PROT.Document.ActiveElement.TextContent 'Obtendo o texto do link


        '# NÃO DEIXA TEXTO EM BRANCO

        If (v_texto_do_link = "") Or (v_texto_do_link = Nothing) Then


            v_texto_do_link = "Link do site: " & GECKOFX_PROT.Url.Host 'Link do site informando...


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

        GECKOFX_PROT.CopyLinkLocation() 'Copiando...

    End Sub

    Private Sub proc_copiar_selecao() 'Copia a seleção
        On Error Resume Next

        GECKOFX_PROT.CopySelection() 'Copiando...

    End Sub

    Private Sub proc_fazer_download_link() 'Faz o download pelo link
        On Error Resume Next

        Dim OBJ_JANELA As New FRM_NOVO_DOWNLOAD 'Janela de novo download

        Dim v_link_a_abrir As String = "" 'Informa o link a abrir






        'Backup fazer --------------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram() 'Backup do conteúdo da ram

        '---------------------------------------------------------------------------------------------------------------




        'Obtendo endereço de download ----------------------------------------------------------------------------------

        GECKOFX_PROT.CopyLinkLocation() 'Obtendo link

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
                GECKOFX_PROT.Undo() 'Desfaz

            Case 2
                GECKOFX_PROT.Redo() 'Refaz

            Case 3
                GECKOFX_PROT.CutSelection() 'Recortar

            Case 4
                GECKOFX_PROT.Paste() 'Colar

            Case 5
                GECKOFX_PROT.CutSelection() 'Limpar

            Case 6
                GECKOFX_PROT.SelectAll() 'Selecionar tudo

        End Select

    End Sub

    Private Sub proc_menu_de_body_acoes_de_menu(ByVal v_acao As Integer) 'Acoes sobre o menu de body
        On Error Resume Next

        Dim OBJ_JANELA As New FRM_FAVORITOS 'Nova janela de favorito






        Select Case v_acao

            Case 1
                GECKOFX_PROT.GoBack() 'Voltar

            Case 2
                GECKOFX_PROT.GoForward() 'Avançar

            Case 3
                GECKOFX_PROT.Reload() 'Recarregar

            Case 4
                GECKOFX_PROT.Stop() 'Parar

            Case 5
                proc_abrir_pagina_inicial() 'Abre a página inicial agora

            Case 6
                OBJ_JANELA.txt_favorito_endereco.Text = GECKOFX_PROT.Url.AbsoluteUri 'Url
                OBJ_JANELA.txt_nome_da_pasta.Text = GECKOFX_PROT.DocumentTitle 'Título
                OBJ_JANELA.Show() 'Exibindo janela
                OBJ_JANELA.TopMost = True 'Topmost ativado

            Case 7
                proc_salvar_pagina() 'Salva a página em visualização

            Case 8
                GECKOFX_PROT.SelectAll() 'Selecionar tudo
                
            Case 9
                GECKOFX_PROT.ViewSource() 'Codigo fonte

            Case 10
                GECKOFX_PROT.ShowPageProperties() 'Propriedades da página


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


                GECKOFX_PROT.CopyImageLocation() 'Endereço da imagem
                Dim v_endereco_imagem As String = My.Computer.Clipboard.GetText 'Endereço da imagem
                OBJ_JANELA.Show() 'Abrindo o formulario
                OBJ_JANELA.GeckoWebBrowser1.Navigate(v_endereco_imagem) 'Abrindo imagem
                OBJ_JANELA.v_endereco_da_imagem_em_visualizacao = v_endereco_imagem 'Repassando o endereço da imagem
                OBJ_JANELA.proc_obter_informacoes() 'Obtendo informações agora


                'Backup restaurar ----------------------------------------------------------------------------------------------

                proc_backup_do_conteudo_da_ram_restaurar() 'Backup do conteúdo da ram restaurar

                '---------------------------------------------------------------------------------------------------------------




            Case 2
                GECKOFX_PROT.CopyImageContents() 'Copiando a imagem


            Case 3
                GECKOFX_PROT.CopyImageLocation() 'Copia endereço da imagem


            Case 4

                'Backup fazer --------------------------------------------------------------------------------------------------

                proc_backup_do_conteudo_da_ram() 'Backup do conteúdo da ram

                '---------------------------------------------------------------------------------------------------------------


                'Copiando e definindo propriedades -----------------------------------------------------------------------------------------------------------------------------------------------------------------

                GECKOFX_PROT.CopyImageLocation() 'Endereço da imagem

                Dim v_nome_da_imagem As String = My.Computer.Clipboard.GetText 'Endereço da imagem

                Dim V_IMAGEM As Image 'Imagem da memoria ram

                v_nome_da_imagem = v_nome_da_imagem.Substring(v_nome_da_imagem.LastIndexOf("/") + 1, (v_nome_da_imagem.Length - v_nome_da_imagem.LastIndexOf("/") - 1)) 'Obtendo o nome da imagem

                OBJ_DIALOGO_SALVAR.FileName = v_nome_da_imagem 'Informando o nome da imagem

                GECKOFX_PROT.CopyImageContents() 'Copiando a imagem

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

        GECKOFX_PROT.CopySelection() 'Obtendo endereço de site

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

        GECKOFX_PROT.CopySelection() 'Obtendo endereço de site

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

        GECKOFX_PROT.CopySelection() 'Obtendo endereço de site

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

        proc_salvar_valor(GECKOFX_PROT.Url.AbsoluteUri, V_ARQ_CONFIG_PAGINA_INICIAL) 'Salva a configuração

        proc_atualizar_valor_de_variaveis() 'Atualiza o valor das variáveis

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_informe_ao_usuario_sobre_tentativa_de_abrir_pop_up(ByVal v_mensagem As String) 'Informa ao usuário sobre a tentativa de abrir uma pop-up
        On Error Resume Next

        Dim v_host_bloqueado As String = GECKOFX_PROT.Url.Host 'Informa o host bloqueado

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

        GECKOFX_PROT.CopySelection() 'Copiando seleção para a memoria

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

        If (GECKOFX_PROT.CanCutSelection = True) Then

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

        If (GECKOFX_PROT.CanCopySelection = True) Then


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

        If (GECKOFX_PROT.CanUndo = True) Then

            ToolStripMenuItem5.Enabled = True 'Habilitado

        Else

            ToolStripMenuItem5.Enabled = False 'Desabilitado

        End If

        '--------------------------------------------------------------------------




        'Refazer ------------------------------------------------------------------

        If (GECKOFX_PROT.CanRedo = True) Then

            RefazerToolStripMenuItem1.Enabled = True 'Habilitado

        Else

            RefazerToolStripMenuItem1.Enabled = False 'Desabilitado

        End If

        '--------------------------------------------------------------------------




        'Voltar -------------------------------------------------------------------

        If (GECKOFX_PROT.CanGoBack = True) Then

            ToolStripMenuItem37.Enabled = True 'Habilitado

        Else

            ToolStripMenuItem37.Enabled = False 'Desabilitado

        End If

        '--------------------------------------------------------------------------




        'Voltar -------------------------------------------------------------------

        If (GECKOFX_PROT.CanGoForward = True) Then

            ToolStripMenuItem38.Enabled = True 'Habilitado

        Else

            ToolStripMenuItem38.Enabled = False 'Desabilitado

        End If

        '--------------------------------------------------------------------------




        'Exibe menu correto leitor de texto ---------------------------------------------------------------------------------------------------

        proc_exibir_opcao_de_menu_correto_leitor_de_texto() 'Exibe a opção correta do item leitor de pagina, no menu body, e na barra de menus.

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub



































    Private Sub GECKOFX_PROT_ShowContextMenu(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoContextMenuEventArgs) Handles GECKOFX_PROT.ShowContextMenu
        On Error Resume Next


        'Exibe os menus e seus itens corretamente ----------------------------------------------------------------------

        proc_opcoes_de_itens_de_menus_exibir_itens_corretos() 'Exibe os itens dos menus corretamente

        '---------------------------------------------------------------------------------------------------------------


        'Exibindo menus agora ------------------------------------------------------------------------------------------

        proc_exibir_menus_de_contexto_corretamente() 'Exibe os menus de contexto corretamente

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub GECKOFX_PROT_DomMouseDown(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoDomMouseEventArgs) Handles GECKOFX_PROT.DomMouseDown
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

    Private Sub ToolStripMenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem18.Click
        On Error Resume Next

        proc_abrir_link_em_nova_aba() 'Abre o link em nova aba

    End Sub

    Private Sub ToolStripMenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem32.Click
        On Error Resume Next

        proc_abrir_link_em_nova_aba() 'Abre o link em nova aba

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

    Private Sub GECKOFX_PROT_CreateWindow(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoCreateWindowEventArgs) Handles GECKOFX_PROT.CreateWindow
        On Error Resume Next

        Dim OBJ_JANELA_POP_UP As New FRM_POP_UP 'Nova janela de pop-up

        Dim V_HOST_DE_SITE_ABRIR_POP_UP As String = GECKOFX_PROT.Url.Host 'Host do site que quer abrir a pop-up

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

    Private Sub TRIDENT_PROT_NewWindow(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TRIDENT_PROT.NewWindow
        On Error Resume Next

        e.Cancel = True 'Cancelar abrir pop-up

        proc_chamar_mensagem_ao_usuario(V_MS_17 & vbCrLf & "Site: " & TRIDENT_PROT.Url.Host & vbCrLf, v_tipo_ms_1) 'Chama a janela de mensagem ao usuario

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

        proc_informe_com_voz_sobre_protocolo_https_seguranca_pagina(GECKOFX_PROT.Url.AbsoluteUri) 'Informa ao usuário se a página visitada é ou nao segura

    End Sub

    Private Sub GECKOFX_PROT_DomKeyDown(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoDomKeyEventArgs) Handles GECKOFX_PROT.DomKeyDown
        On Error Resume Next

        Dim V_VALOR_DE_ZOOM_NO_MOTOR As Single = GECKOFX_PROT.Window.TextZoom 'Informa o valor de zoom no motor

        Static V_TELA_CHEIA_ULTIMO_VALOR As Integer 'Informa o valor anterior da tela cheia






        'Seleciona a tecla e executa ação associada ------------------------------------------------------------------------------------------------------------------

        Select Case e.KeyCode




            'Nova aba -------------------------------------------------------------------------------------------------------------------------

            Case e.CtrlKey And Keys.T

                proc_adicionador_de_nova_aba_e_motor(True) 'Adiciona o motor geckofx ou não. True para sim e false para nao

                '------------------------------------------------------------------------------------------------------------------------------




                'Aumentar o zoom --------------------------------------------------------------------------------------------------------------

            Case e.CtrlKey = True And Keys.Add 'Zoom aumentar

                GECKOFX_PROT.Window.TextZoom = V_VALOR_DE_ZOOM_NO_MOTOR + 0.25F 'Atualizando o valor de zoom
               
                '------------------------------------------------------------------------------------------------------------------------------




                'Restaura o valor de zoom -----------------------------------------------------------------------------------------------------

            Case e.CtrlKey = True And Keys.Z 'Restaurar valor de zoom

                GECKOFX_PROT.Window.TextZoom = 1.0F 'Zoom normal

                '------------------------------------------------------------------------------------------------------------------------------




                'Diminuir o zoom --------------------------------------------------------------------------------------------------------------

            Case e.CtrlKey = True And Keys.Subtract 'Zoom diminuir

                GECKOFX_PROT.Window.TextZoom = V_VALOR_DE_ZOOM_NO_MOTOR - 0.25F 'Atualizando o valor de zoom

                '------------------------------------------------------------------------------------------------------------------------------




                'Fecha aba ------------------------------------------------------------------------------------------------------------------------

            Case e.CtrlKey And Keys.W

                proc_fechar_aba_via_menu() 'Fechar aba via menu

                '------------------------------------------------------------------------------------------------------------------------------




                'Voltar ------------------------------------------------------------------------------------------------------------------------

            Case Keys.Back And (e.Target.TagName <> "INPUT") And (e.Target.TagName <> "TEXTAREA") 'Voltando uma página

                GECKOFX_PROT.GoBack() 'Voltando uma pagina

                '------------------------------------------------------------------------------------------------------------------------------




                'Pagina inicial ---------------------------------------------------------------------------------------------------------------

            Case Keys.Home

                GECKOFX_PROT.Navigate(V_VAL_CONFIG_PAGINA_INICIAL) 'Abre a página inicial agora

                '------------------------------------------------------------------------------------------------------------------------------




                'Tela cheia -------------------------------------------------------------------------------------------------------------------

            Case Keys.F11




                'Aplicando -----------------------------------------------------------------------------------

                If (V_TELA_CHEIA_ULTIMO_VALOR = 1) Then

                    FRM_NAVEGACAO.proc_tela_cheia_ativar_modo(True) 'Ativa o modo de tela cheia

                End If


                If (V_TELA_CHEIA_ULTIMO_VALOR = 2) Then

                    FRM_NAVEGACAO.proc_tela_cheia_ativar_modo(False) 'Desativa o modo de tela cheia

                    V_TELA_CHEIA_ULTIMO_VALOR = 1 'Valor inicial

                    Exit Sub 'Saindo...

                End If


                'Atualizando variável ------------------------------------------------------------------------

                V_TELA_CHEIA_ULTIMO_VALOR = V_TELA_CHEIA_ULTIMO_VALOR + 1 'Atualizando...

                '---------------------------------------------------------------------------------------------


                '---------------------------------------------------------------------------------------------

                '------------------------------------------------------------------------------------------------------------------------------




                'Atualizar a página -----------------------------------------------------------------------------------------------------------

            Case Keys.F5

                GECKOFX_PROT.Reload() 'Atualizando a página

                '------------------------------------------------------------------------------------------------------------------------------




                'Localizar sentença -----------------------------------------------------------------------------------------------------------

            Case Keys.F3

                FRM_NAVEGACAO.proc_barra_de_encontrar_exibir(True) 'Exibe a barra de encontrar

                '------------------------------------------------------------------------------------------------------------------------------




                'Cancelar carregamento --------------------------------------------------------------------------------------------------------

            Case Keys.Escape

                GECKOFX_PROT.Stop() 'Parando carregamento

                '------------------------------------------------------------------------------------------------------------------------------




                'Exibir historico --------------------------------------------------------------------------------------------------------

            Case e.CtrlKey = True And Keys.H

                proc_chamar_historico() 'Chama a janela de historico

                '------------------------------------------------------------------------------------------------------------------------------




                'Exibir historico imagens --------------------------------------------------------------------------------------------------------

            Case e.CtrlKey = True And Keys.Y

                proc_executador_auto_completar(False, Nothing) 'Executador do autocompletar

                FRM_NAVEGACAO.TabControl1.SelectedTab = FRM_NAVEGACAO.TabItem5 'Selecionando a aba de historico de imagens de site

                proc_ocultar_aba_de_historico_autocompletar(True) 'Habilita ou desabilita a aba de historico

                '------------------------------------------------------------------------------------------------------------------------------





                'Salvar pagina ----------------------------------------------------------------------------------------------------------------

            Case e.CtrlKey = True And Keys.S

                proc_salvar_pagina() 'Salva a página em visualização

                '------------------------------------------------------------------------------------------------------------------------------




                'Abrir pagina -----------------------------------------------------------------------------------------------------------------

            Case e.CtrlKey = True And Keys.O

                proc_abrir_pagina_salva() 'Abre a página salva no HD

                '------------------------------------------------------------------------------------------------------------------------------




                'Imprimir pagina --------------------------------------------------------------------------------------------------------------

            Case e.CtrlKey = True And Keys.P

                FRM_NAVEGACAO.proc_imprimir_a_pagina_FRM_NAVEGACAO() 'Procedimento para imprimir a pagina

                '------------------------------------------------------------------------------------------------------------------------------




                'Codigo fonte da pagina -------------------------------------------------------------------------------------------------------

            Case e.CtrlKey = True And Keys.U

                proc_exibir_codigo_fonte_da_pagina() 'Exibe o codigo fonte da pagina

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

                proc_chamar_favoritos(False, False) 'Chama a janela de favoritos

                '------------------------------------------------------------------------------------------------------------------------------




                'Exibe a lista de downloads ---------------------------------------------------------------------------------------------------

            Case e.CtrlKey = True And Keys.J

                proc_exibir_lista_de_downloads() 'Exibir lista de downloads

                '------------------------------------------------------------------------------------------------------------------------------




                'Move o foco para a barra de endereços ----------------------------------------------------------------------------------------

            Case Keys.F4

                FRM_NAVEGACAO.ComboBoxEx1.Focus() 'Movendo o foco

                '------------------------------------------------------------------------------------------------------------------------------



        End Select

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub TRIDENT_PROT_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles TRIDENT_PROT.PreviewKeyDown
        On Error Resume Next

        Static V_TELA_CHEIA_ULTIMO_VALOR As Integer 'Informa o valor anterior da tela cheia






        'Nao permite a execução dupla do mesmo procedimento ------------------------------------------------------------

        If (V_NUM_EXEC_PROC = 2) Then


            V_NUM_EXEC_PROC = 1 'Restaurando valor

            Exit Sub 'Saindo...


        End If

        '---------------------------------------------------------------------------------------------------------------




        'Incrementa novo valor -----------------------------------------------------------------------------------------

        V_NUM_EXEC_PROC = V_NUM_EXEC_PROC + 1 'Incrementando

        '---------------------------------------------------------------------------------------------------------------




        'Seleciona a tecla e executa ação associada ------------------------------------------------------------------------------------------------------------------

        Select Case e.KeyCode




            'Nova aba -------------------------------------------------------------------------------------------------------------------------

            Case e.Control And Keys.T

                proc_adicionador_de_nova_aba_e_motor(False) 'Adiciona o motor geckofx ou não. True para sim e false para nao

                '------------------------------------------------------------------------------------------------------------------------------




                'Fecha aba ------------------------------------------------------------------------------------------------------------------------

            Case e.Control And Keys.W

                proc_fechar_aba_via_menu() 'Fechar aba via menu

                '------------------------------------------------------------------------------------------------------------------------------




                'Pagina inicial ---------------------------------------------------------------------------------------------------------------

            Case Keys.Home

                TRIDENT_PROT.Navigate(V_VAL_CONFIG_PAGINA_INICIAL) 'Abre a página inicial agora

                '------------------------------------------------------------------------------------------------------------------------------




                'Tela cheia -------------------------------------------------------------------------------------------------------------------

            Case Keys.F11




                'Aplicando -----------------------------------------------------------------------------------

                If (V_TELA_CHEIA_ULTIMO_VALOR = 1) Then

                    FRM_NAVEGACAO.proc_tela_cheia_ativar_modo(True) 'Ativa o modo de tela cheia

                End If


                If (V_TELA_CHEIA_ULTIMO_VALOR = 2) Then

                    FRM_NAVEGACAO.proc_tela_cheia_ativar_modo(False) 'Desativa o modo de tela cheia

                    V_TELA_CHEIA_ULTIMO_VALOR = 1 'Valor inicial

                    Exit Sub 'Saindo...

                End If


                'Atualizando variável ------------------------------------------------------------------------

                V_TELA_CHEIA_ULTIMO_VALOR = V_TELA_CHEIA_ULTIMO_VALOR + 1 'Atualizando...

                '---------------------------------------------------------------------------------------------


                '---------------------------------------------------------------------------------------------

                '------------------------------------------------------------------------------------------------------------------------------




                'Atualizar a página -----------------------------------------------------------------------------------------------------------

            Case Keys.F5

                TRIDENT_PROT.Refresh() 'Atualizando a página

                '------------------------------------------------------------------------------------------------------------------------------




                'Localizar sentença -----------------------------------------------------------------------------------------------------------

            Case Keys.F3

                FRM_NAVEGACAO.proc_barra_de_encontrar_exibir(True) 'Exibe a barra de encontrar

                '------------------------------------------------------------------------------------------------------------------------------




                'Cancelar carregamento --------------------------------------------------------------------------------------------------------

            Case Keys.Escape

                TRIDENT_PROT.Stop() 'Parando carregamento

                '------------------------------------------------------------------------------------------------------------------------------




                'Exibir historico --------------------------------------------------------------------------------------------------------

            Case e.Control = True And Keys.H

                proc_chamar_historico() 'Chama a janela de historico

                '------------------------------------------------------------------------------------------------------------------------------




                'Exibir historico imagens --------------------------------------------------------------------------------------------------------

            Case e.Control = True And Keys.Y

                proc_executador_auto_completar(False, Nothing) 'Executador do autocompletar

                FRM_NAVEGACAO.TabControl1.SelectedTab = FRM_NAVEGACAO.TabItem5 'Selecionando a aba de historico de imagens de site

                proc_ocultar_aba_de_historico_autocompletar(True) 'Habilita ou desabilita a aba de historico

                '------------------------------------------------------------------------------------------------------------------------------





                'Salvar pagina ----------------------------------------------------------------------------------------------------------------

            Case e.Control = True And Keys.S

                proc_salvar_pagina() 'Salva a página em visualização

                '------------------------------------------------------------------------------------------------------------------------------




                'Abrir pagina -----------------------------------------------------------------------------------------------------------------

            Case e.Control = True And Keys.O

                proc_abrir_pagina_salva() 'Abre a página salva no HD

                '------------------------------------------------------------------------------------------------------------------------------




                'Imprimir pagina --------------------------------------------------------------------------------------------------------------

            Case e.Control = True And Keys.P

                FRM_NAVEGACAO.proc_imprimir_a_pagina_FRM_NAVEGACAO() 'Procedimento para imprimir a pagina

                '------------------------------------------------------------------------------------------------------------------------------




                'Codigo fonte da pagina -------------------------------------------------------------------------------------------------------

            Case e.Control = True And Keys.U

                proc_exibir_codigo_fonte_da_pagina() 'Exibe o codigo fonte da pagina

                '------------------------------------------------------------------------------------------------------------------------------




                'Exibir painel de controle ----------------------------------------------------------------------------------------------------

            Case e.Shift = True And Keys.P

                proc_chamar_painel_de_controle() 'Chamar o painel de controle

                '------------------------------------------------------------------------------------------------------------------------------




                'Exibe opções de ajuda e sobre a versao do software ---------------------------------------------------------------------------

            Case Keys.F1

                proc_chamar_aplicativo_exibidor_de_versao() 'Chamar o aplicativo exibidor de versao

                '------------------------------------------------------------------------------------------------------------------------------





                'Adiciona aos favoritos -------------------------------------------------------------------------------------------------------

            Case e.Control = True And Keys.D

                proc_chamar_favoritos(False, False) 'Chama a janela de favoritos

                '------------------------------------------------------------------------------------------------------------------------------




                'Exibe a lista de downloads ---------------------------------------------------------------------------------------------------

            Case e.Control = True And Keys.J

                proc_exibir_lista_de_downloads() 'Exibir lista de downloads

                '------------------------------------------------------------------------------------------------------------------------------




                'Move o foco para a barra de endereços ----------------------------------------------------------------------------------------

            Case Keys.F4

                FRM_NAVEGACAO.ComboBoxEx1.Focus() 'Movendo o foco

                '------------------------------------------------------------------------------------------------------------------------------



        End Select

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------



    End Sub

    Private Sub EditarImagemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarImagemToolStripMenuItem.Click
        On Error Resume Next

        proc_editar_imagem_com_editor_de_imagens() 'Edita a imagem com o editor de imagens

    End Sub

    Private Sub EditarImagemToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarImagemToolStripMenuItem1.Click
        On Error Resume Next

        proc_editar_imagem_com_editor_de_imagens() 'Edita a imagem com o editor de imagens

    End Sub

    Private Sub MeuIPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MeuIPToolStripMenuItem.Click
        On Error Resume Next

        proc_informe_o_ip_local() 'Informa o ip local do computador

    End Sub

    Private Sub IPDesteSiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IPDesteSiteToolStripMenuItem.Click
        On Error Resume Next

        proc_informe_o_ip_do_site_em_visualizacao(GECKOFX_PROT.Url.Host) 'Informa o endereço ip do site em visualização.

    End Sub

    Private Sub TirarFotoDesteSiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TirarFotoDesteSiteToolStripMenuItem.Click
        On Error Resume Next

        proc_tirar_foto_do_site_em_visualizacao() 'Obtem a imagem do site em visualizacao

    End Sub

End Class