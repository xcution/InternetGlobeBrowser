Imports Gecko
Imports System.Net
Imports System.IO




Public Class FRM_FORMULARIO_WEB_BASICO


    'OBJETOS LOCAIS

    Public OBJ_MOTOR_WEB_BASICO As New Gecko.GeckoWebBrowser 'NOVO MOTOR GECKOFX BASICO




















    'VARIÁVEIS LOCAIS

    Dim ICONE_FAVICON_BAIXADO_FORMATO_ICO As Icon 'ICONE BAIXADO NO FORMATO ICONE

    Dim V_URL_LOCAL As String 'INFORMA A URL DO SITE LOCALMENTE




















    'PROCEDIMENTOS

    Private Sub PROC_ADICIONA_MOTOR_WEB_BASICO(ByVal OBJ_MOTOR As GeckoWebBrowser) 'ADICIONA O MOTOR WEB BASICO
        On Error Resume Next


        'ADICIONANDO ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        Me.Controls.Add(OBJ_MOTOR) 'ADICIONA O MOTOR

        OBJ_MOTOR.Show() 'EXIBINDO O MOTOR

        OBJ_MOTOR.Dock = DockStyle.Fill 'TODA A PÁGINA

        OBJ_MOTOR.Name = V_NUMERO_DE_MOTOR_CRIADO_PARA_NOVA_ABA 'NOME DO MOTOR

        OBJ_MOTOR.NoDefaultContextMenu = True 'NAO EXIBE O MENU PADRÃO

        Me.Name = V_NUMERO_DE_MOTOR_CRIADO_PARA_NOVA_ABA 'NOME DE ABA

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'DEFINE O MOTOR DE AÇÃO DE USO ----------------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_DEFINE_MOTOR_DE_ACAO_EM_USO(OBJ_MOTOR) 'DEFINE O MOTOR DE AÇÃO EM USO

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ADICIONA OS EVENTOS --------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_ADD_EVENTOS_EM_GECKOFX(OBJ_MOTOR) 'ADICIONA EVENTOS NO MOTOR WEB GECKOFX

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA O NUMERO DE ABAS ABERTA -------------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_VERIFICA_NUMERO_DE_ABAS_ABERTAS_AO_ADICIONAR() 'VERIFICA O NUMERO DE ABAS ABERTAS AO ADICIONAR NOVA ABA

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'PREPARA A BARRA DE ENDEREÇOS -----------------------------------------------------------------------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CBO_ENDERECO_DO_SITE.Text = Nothing 'LIMPA A BARRA DE ENDEREÇOS

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CBO_ENDERECO_DO_SITE.Focus() 'FOCA A BARRA DE ENDEREÇOS

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ATUALIZA VARIÁVEL ESTATICA -------------------------------------------------------------------------------------------------------------------------------------------------------------------

        V_NUMERO_DE_MOTOR_CRIADO_PARA_NOVA_ABA = V_NUMERO_DE_MOTOR_CRIADO_PARA_NOVA_ABA + 1 'ATUALIZANDO...

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ADICIONA EVENTOS -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        AddHandler OBJ_MOTOR.DocumentCompleted, AddressOf PROC_CARREGAMENTO_COMPLETO_MOTOR_WEB_BASICO 'DOCUMENTO COMPLETO

        AddHandler OBJ_MOTOR.ProgressChanged, AddressOf PROC_CARREGAMENTO_PROGRESSO_MOTOR_WEB_BASICO 'EVENTO DE CARREGAMENTO EM PROGRESSO DO MOTOR GECKOFX

        AddHandler DirectCast(OBJ_MOTOR, Gecko.GeckoWebBrowser).WindowClosed, AddressOf PROC_EVENTO_FECHAR_MOTOR_GECKOFX 'EVENTO PARA QUANDO O MOTOR GECKOFX FOR FECHADO E NÃO A JANELA

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub




















    'PROCEDIMENTOS LOCAIS

    Private Sub PROC_SETA_FAVICON_PADRAO() 'SETA O FAVICON PADRÃO LOGO DE INICIO
        On Error Resume Next

        Dim OBJ_IMAGEM As Bitmap = IML_1.Images.Item(0) 'IMAGEM DE ICONE PADRAO






        'CONVERTER A IMAGEM PARA FAVICON -------------------------------------------------------------------------------

        ICONE_FAVICON_BAIXADO_FORMATO_ICO = Icon.FromHandle(OBJ_IMAGEM.GetHicon) 'CONVERTE A IMAGEM PARA FAVICON

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_PEGA_FAVICON_DE_SITE() 'PEGA O FAVICON DO SITE
        On Error Resume Next

        Dim OBJ_IMAGEM As Bitmap = FUNC_GERAR_FAVICON_DA_URL(V_URL_LOCAL) 'GERA O FAVICON DA URL INFORMADA






        'VERIFICA SE A IMAGEM POSSUI PIXEL -----------------------------------------------------------------------------

        If (OBJ_IMAGEM.PixelFormat = Nothing) Then


            OBJ_IMAGEM = IML_1.Images.Item(0) 'IMAGEM DE ICONE PADRAO


        End If

        '---------------------------------------------------------------------------------------------------------------




        'CONVERTER A IMAGEM PARA FAVICON -------------------------------------------------------------------------------

        ICONE_FAVICON_BAIXADO_FORMATO_ICO = Icon.FromHandle(OBJ_IMAGEM.GetHicon) 'CONVERTE A IMAGEM PARA FAVICON

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub PROC_GERA_IMAGEM_EM_BRANCO() 'GERA IMAGEM EM BRANCO
        On Error Resume Next


        'CRIA IMAGEM EM BRANCO -----------------------------------------------------------------------------------------

        Dim OBJ_IMAGEM_TEMP As Bitmap = IML_1.Images.Item(0) 'CRIA

        Me.Icon = Icon.FromHandle(OBJ_IMAGEM_TEMP.GetHicon) 'REPASSA

        ICONE_FAVICON_BAIXADO_FORMATO_ICO = Icon.FromHandle(OBJ_IMAGEM_TEMP.GetHicon) 'IMAGEM EM BRANCO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_SETAR_FAVICON_DE_SITE() 'SETA O FAVICON DE SITE AGORA
        On Error Resume Next


        'SETANDO ----------------------------------------------------------------------------------------------------

        Me.Icon = ICONE_FAVICON_BAIXADO_FORMATO_ICO 'SETANDO

        '------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_ATUALIZA_PILHA_DE_ABAS_FECHADAS() 'ATUALIZA A PILHA DE ABAS QUE FORAM FECHADAS
        On Error Resume Next


        'ATUALIZANDO --------------------------------------------------------------------------------------------------------------------------

        ARRAY_PILHA_DE_ABAS_QUE_FORAM_FECHADAS_PELO_USUARIO.Add(Me.OBJ_MOTOR_WEB_BASICO.Url.AbsoluteUri) 'ATUALIZANDO

        '--------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA O NUMERO DE ABAS ABERTAS ----------------------------------------------------------------------------------------------------

        If (FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.TabPages.Count = 1) Then

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.Close() 'FECHA O FORMULARIO DE NAVEGAÇÃO PRINCIPAL

        End If

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_LIMPAR_ARQUIVO_DE_SESSAO_LOCAL_AO_SAIR() 'AO SAIR LIMPAR O ARQUIVO DE SESSÃO ATUAL
        On Error Resume Next

        Dim V_ARQUIVO_A_REMOVER As String = V_PASTA_DE_ARQUIVOS_DE_SESSAO & "\" & OBJ_MOTOR_WEB_BASICO.Name & V_EXTENCAO_DE_ARQUIVO_4 'SALVAR SESSÃO ONDE






        'AO SAIR REMOVER O ARQUIVO DE SESSAO --------------------------------------------------------------------------------------------------

        PROC_REMOVER_ARQUIVO_UNICO_SEM_PERGUNTAS(V_ARQUIVO_A_REMOVER) 'REMOVE ARQUIVO SEM PERGUNTA

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_LIMPAR_MEMORIA_DESTE_FORMULARIO() 'LIMPA A MEMÓRIA DESTE FORMULARIO
        On Error Resume Next


        'LIMPANDO CODIGO DE DOCUMENTO HTML ----------------------------------------------------------------------------------------------------

        OBJ_MOTOR_WEB_BASICO.Document.Body.InnerHtml = Nothing 'LIMPANDO CÓDIGO FONTE

        '--------------------------------------------------------------------------------------------------------------------------------------




        'PARANDO BACKGROUNDWORKER FAVICON -----------------------------------------------------------------------------------------------------

        BCK_FAVICON_FORM_BASICO_GERAR.CancelAsync() 'CANCELANDO

        '--------------------------------------------------------------------------------------------------------------------------------------




        'LIMPA CONTROLES DESTE FORMULARIO -----------------------------------------------------------------------------------------------------

        Me.Dispose() 'LIMPANDO

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub





















    'EVENTOS LOCAIS

    Private Sub PROC_CARREGAMENTO_COMPLETO_MOTOR_WEB_BASICO(ByVal sender As System.Object, ByVal e As System.EventArgs) 'EVENTO DE CARREGAMENTO COMPLETO DO MOTOR GECKOFX
        On Error Resume Next


        'SETA O FAVICON PADRÃO -----------------------------------------------------------------------------------------

        PROC_SETA_FAVICON_PADRAO() 'SETA O FAVICON PADRÃO LOGO DE INICIO

        '---------------------------------------------------------------------------------------------------------------




        'OBTEM A URL LOCAL ---------------------------------------------------------------------------------------------

        V_URL_LOCAL = OBJ_MOTOR_WEB_BASICO.Url.AbsoluteUri 'URL LOCAL

        '---------------------------------------------------------------------------------------------------------------




        'INFORMA O TÍTULO DA JANELA ------------------------------------------------------------------------------------

        Me.Text = OBJ_MOTOR_WEB_BASICO.DocumentTitle 'INFORMANDO O TÍTULO DA JANELA

        '---------------------------------------------------------------------------------------------------------------




        'RODANDO PROCESSO ----------------------------------------------------------------------------------------------

        BCK_FAVICON_FORM_BASICO_GERAR.CancelAsync() 'CANCELA ULTIMO FAVICON

        BCK_FAVICON_FORM_BASICO_GERAR.RunWorkerAsync() 'RODANDO...

        '---------------------------------------------------------------------------------------------------------------




        'SETA O FAVICON SE JÁ TIVER BAIXADO ----------------------------------------------------------------------------

        PROC_SETAR_FAVICON_DE_SITE() 'SETA O FAVICON DE SITE AGORA

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_CARREGAMENTO_PROGRESSO_MOTOR_WEB_BASICO(ByVal sender As System.Object, ByVal e As Gecko.GeckoProgressEventArgs) 'EVENTO DE CARREGAMENTO EM PROGRESSO DO MOTOR GECKOFX
        On Error Resume Next


        'OBTEM A URL LOCAL ---------------------------------------------------------------------------------------------

        V_URL_LOCAL = OBJ_MOTOR_WEB_BASICO.Url.AbsoluteUri 'URL LOCAL

        '---------------------------------------------------------------------------------------------------------------




        'INFORMA O TÍTULO DA JANELA ------------------------------------------------------------------------------------

        Me.Text = OBJ_MOTOR_WEB_BASICO.DocumentTitle 'INFORMANDO O TÍTULO DA JANELA

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_EVENTO_FECHAR_MOTOR_GECKOFX(ByVal sender As System.Object, ByVal e As System.EventArgs) 'EVENTO PARA QUANDO O MOTOR GECKOFX FOR FECHADO E NÃO A JANELA
        On Error Resume Next


        'CANCELANDO, LIMPANDO E SAINDO -----------------------------------------------------------------------------------------------------

        BCK_FAVICON_FORM_BASICO_GERAR.CancelAsync() 'CANCELA BACKGROUNDWORKER

        Me.Close() 'FECHANDO ESTA JANELA

        '-----------------------------------------------------------------------------------------------------------------------------------


    End Sub
























    Private Sub FRM_FORMULARIO_WEB_BASICO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        'SOM DE SISTEMA ------------------------------------------------------------------------------------------------

        PROC_EXIBIR_SOM_DE_SISTEMA(4) 'EXIBE OS SONS INSTALADOS NO SISTEMA

        '---------------------------------------------------------------------------------------------------------------




        'ADICIONA MOTOR E GERA IMAGEM EM BRANCO ------------------------------------------------------------------------

        PROC_ADICIONA_MOTOR_WEB_BASICO(OBJ_MOTOR_WEB_BASICO) 'ADICIONA O MOTOR WEB BASICO

        PROC_GERA_IMAGEM_EM_BRANCO() 'GERA IMAGEM EM BRANCO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub BCK_FAVICON_FORM_BASICO_GERAR_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BCK_FAVICON_FORM_BASICO_GERAR.DoWork
        On Error Resume Next

        PROC_PEGA_FAVICON_DE_SITE() 'PEGA O FAVICON DO SITE

    End Sub

    Private Sub BCK_FAVICON_FORM_BASICO_GERAR_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BCK_FAVICON_FORM_BASICO_GERAR.RunWorkerCompleted
        On Error Resume Next

        PROC_SETAR_FAVICON_DE_SITE() 'SETA O FAVICON DE SITE AGORA

    End Sub

    Private Sub FRM_FORMULARIO_WEB_BASICO_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next


        'ATUALIZA PILHA DE ABAS FECHADAS E LIMPA ARQUIVOS DE SESSÃO AO SAIR -------------------------------------------------------------------

        PROC_ATUALIZA_PILHA_DE_ABAS_FECHADAS() 'ATUALIZA A PILHA DE ABAS QUE FORAM FECHADAS

        PROC_LIMPAR_ARQUIVO_DE_SESSAO_LOCAL_AO_SAIR() 'AO SAIR LIMPAR O ARQUIVO DE SESSÃO ATUAL

        '--------------------------------------------------------------------------------------------------------------------------------------




        'LIMPA A MEMÓRIA DESTE FORMULARIO -----------------------------------------------------------------------------------------------------

        PROC_LIMPAR_MEMORIA_DESTE_FORMULARIO() 'LIMPA A MEMÓRIA DESTE FORMULARIO

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

End Class