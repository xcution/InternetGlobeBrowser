Public Class FRM_FORMULARIO_EXIBIDOR_DE_HISTORICO



    ' VARIÁVEIS

    Dim OBJ_IMAGEM_FAVICON As Image 'IMAGEM DE FAVICON

    Dim V_URL_ASSOCIADO_AO_MENU_DE_CONTEXTO As String 'ENDEREÇO URL DE FAVICON




















    'PROCEDIMENTOS BASICOS

    Private Sub PROC_ABRIR_HISTORICO_EM_NOVA_ABA() 'ABRE O HISTÓRICO EM NOVA ABA
        On Error Resume Next


        'ABRINDO ITEM DE HISTORICO CLICADO ------------------------------------------------------------------------------------

        PROC_NOVA_ABA_ADICIONAR() 'ADICIONA NOVA ABA

        PROC_NAVEGAR(V_URL_ASSOCIADO_AO_MENU_DE_CONTEXTO) 'NAVEGA NO ENDEREÇO DE SITE INFORMADO

        '----------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_ABRIR_HISTORICO_EM_ABA_ATUAL() 'ABRE O  HISTÓRICO NA ABA ATUAL
        On Error Resume Next


        'ABRINDO ITEM DE HISTORICO CLICADO ------------------------------------------------------------------------------------

        PROC_NAVEGAR(V_URL_ASSOCIADO_AO_MENU_DE_CONTEXTO) 'NAVEGA NO ENDEREÇO DE SITE INFORMADO

        '----------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_FAVORITO_PUXA_FAVICON() 'PUXAR FAVICON DE FAVORITO
        On Error Resume Next


        'LIMPA IMAGEM ANTIGA, PEGA NOVA IMAGEM E LIMPA URL ---------------------------------------------------------------------------------

        OBJ_IMAGEM_FAVICON = Nothing 'LIMPA IMAGEM ANTIGA

        OBJ_IMAGEM_FAVICON = FUNC_GERAR_FAVICON_DA_URL(V_URL_ASSOCIADO_AO_MENU_DE_CONTEXTO) 'GERA O FAVICON DA URL INFORMADA

        V_URL_ASSOCIADO_AO_MENU_DE_CONTEXTO = Nothing 'LIMPA URL

        '-----------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_SALVAR_FAVICON_AGORA_FAVORITO() 'SALVA O FAVICON AGORA
        On Error Resume Next

        Dim V_TITULO As String = MOTOR_GECKOFX.Document.ActiveElement.TextContent 'TITULO DE FAVORITO

        Dim V_PASTA_ONDE_SALVAR As String = V_PASTA_DE_MEUS_FAVORITOS_END 'PASTA ONDE SERA SALVO O FAVORITO






        'PROCESSANDO O TITULO ----------------------------------------------------------------------------------------------------------------------------------

        V_TITULO = V_TITULO.Replace(".", Nothing) 'REMOVE PONTO

        V_TITULO = V_TITULO.TrimStart 'REMOVE ESPAÇO EM BRANCO DE INICIO

        V_TITULO = V_TITULO.TrimEnd 'REMOVE ESPAÇO EM BRANCO DE FIM

        V_TITULO = FUNC_REMOVE_CARACTERES_ESPECIAIS(V_TITULO) 'REMOVE OS CARACTERES ESPECIAIS

        '-------------------------------------------------------------------------------------------------------------------------------------------------------




        'SALVANDO O FAVICON ------------------------------------------------------------------------------------------

        OBJ_IMAGEM_FAVICON.Save(V_PASTA_ONDE_SALVAR & "\" & V_TITULO & V_EXTENCAO_DE_ARQUIVO_3) 'SALVANDO...

        '-------------------------------------------------------------------------------------------------------------


    End Sub






























    Private Sub NovaAbaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovaAbaToolStripMenuItem.Click
        On Error Resume Next

        PROC_ABRIR_HISTORICO_EM_NOVA_ABA() 'ABRE O HISTÓRICO EM NOVA ABA

    End Sub

    Private Sub AbaAtualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbaAtualToolStripMenuItem.Click
        On Error Resume Next

        PROC_ABRIR_HISTORICO_EM_ABA_ATUAL() 'ABRE O  HISTÓRICO NA ABA ATUAL

    End Sub

    Private Sub AdicionaAosFavorítosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionaAosFavorítosToolStripMenuItem.Click
        On Error Resume Next


        MOTOR_GECKOFX.Hide() 'DESABILITA O MOTOR

        PROC_ADD_HISTORICO_AOS_FAVORITOS(V_URL_ASSOCIADO_AO_MENU_DE_CONTEXTO, MOTOR_GECKOFX.Document.ActiveElement.TextContent) 'ADICIONA O HISTÓRICO AOS FAVORITOS

        BCK_FAVICON.CancelAsync() 'CANCELA ULTIMO FAVICON

        BCK_FAVICON.RunWorkerAsync() 'DOWNLOAD DE NOVO FAVICON


    End Sub

    Private Sub MOTOR_GECKOFX_ShowContextMenu(ByVal sender As System.Object, ByVal e As Gecko.GeckoContextMenuEventArgs) Handles MOTOR_GECKOFX.ShowContextMenu
        On Error Resume Next


        'OBTENDO URL ASSOCIADA AO LINK ----------------------------------------------------------------------------------------

        V_URL_ASSOCIADO_AO_MENU_DE_CONTEXTO = e.AssociatedLink 'PUXAR FAVICON DE FAVORITO

        '----------------------------------------------------------------------------------------------------------------------




        'ABRINDO MENU ---------------------------------------------------------------------------------------------------------

        If (MOTOR_GECKOFX.CanCopyLinkLocation = True) Then


            MNU_OPCOES_DE_HISTORICO.Show(MousePosition) 'ABRINDO MENU DE OPÇÕES DE HISTÓRICO


        End If

        '----------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub MOTOR_GECKOFX_DomMouseDown(ByVal sender As System.Object, ByVal e As Gecko.GeckoDomMouseEventArgs) Handles MOTOR_GECKOFX.DomMouseDown
        On Error Resume Next


        'PERMITE AUTO-CLOSE --------------------------------------------------------------------------------------------

        OBJ_MENU_DE_CONTEXTO.AutoClose = True 'AUTO-CLOSE

        OBJ_MENU_DE_CONTEXTO.Close() 'FECHANDO MENU

        '---------------------------------------------------------------------------------------------------------------




        'SAIR AO PRESSIONAR UM BOTÃO QUE NAO SEJA O BOTAO 0 ----------------------------------------------------------------------------------------------------

        If (e.Button > 0) Then


            Exit Sub 'SAINDO...


        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA O TIPO DE ITEM CLICADO PELO USUÁRIO ----------------------------------------------------------------------------------------------------------

        If (e.Target.TagName = "IMG") Or (e.Target.TagName = "A") Then




            'ABRINDO ITEM DE HISTORICO CLICADO ------------------------------------------------------------------------------------

            PROC_NAVEGAR(MOTOR_GECKOFX.StatusText) 'NAVEGA NO ENDEREÇO DE SITE INFORMADO

            '----------------------------------------------------------------------------------------------------------------------




            'REMOVE ABA DE HISTORICO CASO ESTEJA ABERTA ---------------------------------------------------------------------------

            Me.Close() 'FECHANDO FORMULARIO

            '----------------------------------------------------------------------------------------------------------------------




        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub BCK_FAVICON_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BCK_FAVICON.DoWork
        On Error Resume Next

        PROC_FAVORITO_PUXA_FAVICON() 'PUXAR FAVICON DE FAVORITO

    End Sub

    Private Sub BCK_FAVICON_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BCK_FAVICON.RunWorkerCompleted
        On Error Resume Next

        PROC_SALVAR_FAVICON_AGORA_FAVORITO() 'SALVA O FAVICON AGORA

        MOTOR_GECKOFX.Show() 'HABILITA O MOTOR

    End Sub

    Private Sub FRM_FORMULARIO_EXIBIDOR_DE_HISTORICO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next


        'SOM DE SISTEMA ------------------------------------------------------------------------------------------------

        PROC_EXIBIR_SOM_DE_SISTEMA(3) 'EXIBE OS SONS INSTALADOS NO SISTEMA

        '---------------------------------------------------------------------------------------------------------------


    End Sub

End Class