Imports Gecko
Imports System.ComponentModel




Module MODULO_DE_PROPRIEDADES_DE_MOTORES_GECKOFX


    'VARIÁVEIS DE PROPRIEDADES

    Public V_URL_DO_FAVICON_PROPRIEDADES_DE_MOTORES_GECKOFX As String 'URL DO FAVICVON

    Public IMG_FAVICON_FORMULARIO_PRINCIPAL As Image 'FAVICON DE FORMULARIO PRINCIPAL











































    'PROPRIEDADES DE CARREGAMEMTO DO MOTOR GECKOFX

    Public Sub PROC_PUXAR_FAVICON_DE_FORMULARIO_PRINCIPAL() 'PUXA O FAVICON DO FORMULARIO PRINCIPAL
        On Error Resume Next


        'INFORMA A URL DO FAVICON --------------------------------------------------------------------------------------

        V_URL_DO_FAVICON_PROPRIEDADES_DE_MOTORES_GECKOFX = OBJ_MOTOR_DE_ACAO_EM_USO.Url.AbsoluteUri 'URL DE FAVICON

        '---------------------------------------------------------------------------------------------------------------




        'LIMPA FAVICON ANTIGO ------------------------------------------------------------------------------------------

        IMG_FAVICON_FORMULARIO_PRINCIPAL = Nothing 'LIMPANDO...

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.LBL_CARREGANDO.Image = Nothing 'LIMPANDO...

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PIC_FAVICON.Image = Nothing 'LIMPANDO...

        '---------------------------------------------------------------------------------------------------------------




        'CANCELA FAVICON -----------------------------------------------------------------------------------------------

        BCK_EXECUTADOR_DE_DOWNLOAD_2.CancelAsync() 'CANCELA ULTIMO FAVICON

        BCK_EXECUTADOR_DE_DOWNLOAD_2 = New BackgroundWorker 'NOVO BACKGROUNDWORKER

        '---------------------------------------------------------------------------------------------------------------




        'ADICIONA EVENTOS -------------------------------------------------------------------------------------------------------------------------------------------------------------

        AddHandler BCK_EXECUTADOR_DE_DOWNLOAD_2.DoWork, AddressOf PROC_GERAR_FAVICON_FORMULARIO_PRINCIPAL 'GERA O FAVICON PARA O FORMULARIO PRINCIPAL

        AddHandler BCK_EXECUTADOR_DE_DOWNLOAD_2.RunWorkerCompleted, AddressOf PROC_FAVICON_FORMULARIO_PRINCIPAL_GERADO 'FAVICON DO FORMULARIO PRINCIPAL FOI GERADO

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'RODANDO EVENTO ------------------------------------------------------------------------------------------------

        BCK_EXECUTADOR_DE_DOWNLOAD_2.RunWorkerAsync() 'RODANDO...

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_PROPRIEDADES_DE_PROGRESSO_EM_ANDAMENTO(ByVal V_MAXIMO As Long, ByVal V_ATUAL As Long) 'PROPRIEDADES GERAIS DE SOMENTE PROGRESSO DE CARREGAMENTO DE PÁGINA
        On Error Resume Next


        'PROGRESSO DE PÁGINA --------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PRG_PROGRESSO.Maximum = V_MAXIMO 'VALOR MAXIMO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PRG_PROGRESSO.Value = V_ATUAL 'VALOR ATUAL

        '----------------------------------------------------------------------------------------------------------------




        'EXIBE OU NAO A BARRA DE PROGRESSO ------------------------------------------------------------------------------

        If (V_MAXIMO = V_ATUAL) Then


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PRG_PROGRESSO.Visible = False 'OCULTA

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripSeparator2.Visible = False 'OCULTA


        Else


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PRG_PROGRESSO.Visible = True 'EXIBE

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripSeparator2.Visible = True 'EXIBE


        End If

        '----------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_PROPRIEDADE_GERAIS(ByVal V_TITULO As String, ByVal V_URL As String, ByVal V_TOKEN As Integer) 'ATUALIZA AS PROPRIEDADES GERAIS
        On Error Resume Next

        Dim V_ABA_QUE_ESTA As Integer = OBJ_MOTOR_DE_ACAO_EM_USO.Name 'ABA ATUAL

        Dim V_HOST As New Uri(V_URL) 'OBTEM DADOS DE PROTOCOLO, URL ETC....






        'ATUALIZA COM CONDIÇÃO DE TOKEN -----------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_ABA_QUE_ESTA = V_TOKEN) Then




            'TITULO -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.Text = V_TITULO & V_LOGOTIPO 'ATUALIZA O TITULO

            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'URL ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            If (FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CBO_ENDERECO_DO_SITE.ContainsFocus = False) Then


                FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.CBO_ENDERECO_DO_SITE.Text = V_URL 'BARRA DE URL


            End If

            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'INFORMA O HOST EM QUE ESTÁ -----------------------------------------------------------------------------------------------------------------------------------------------------------

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.LBL_CARREGANDO.Text = V_HOST.Host 'INFORMANDO O HOST

            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'ATUALIZA A ABA AGORA -----------------------------------------------------------------------------------------------------------------------------------------------------------------

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.SelectedForm.TEXT = V_TITULO 'ATUALIZA O TITULO DA ABA

            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'BARRA DE STATUS --------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TOL_ABAS_ABERTAS.Text = "Abas abertas " & FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.TabPages.Count 'QUANTIDADE DE ABAS ABERTAS

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



    End Sub






























































End Module
