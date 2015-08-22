Imports Skybound.Gecko

Public Class FRM_NOVO_DOWNLOAD



    'Variáveis de processamento

    Dim v_modo As Byte = 1 'Modo do download









    'Variáveis basicas

    Dim v_ultima_configuracao_do_modo_geek As Boolean 'Informa a ultima configuração do modo geek




















    'Procedimentos

    Private Sub proc_fechar() 'Procedimento para fechar
        On Error Resume Next

        Me.Close() 'Fechando

    End Sub

    Public Function func_iniciar_novo_download_1(ByVal v_url_de_download) 'Inicia um novo download
        On Error Resume Next

        Dim nv_download As New FRM_DOWNLOADER 'Nova instancia de download




        'Não permite continuar em caso de campo em branco -----------------------------------

        If (v_url_de_download = Nothing) Then

            Return Nothing 'Retorno

            Exit Function 'Saida

        End If

        '------------------------------------------------------------------------------------


        'Definindo propriedades -------------------------------------------------------------

        nv_download.v_origem = v_url_de_download 'Origem de download

        '------------------------------------------------------------------------------------


        'Abrindo ----------------------------------------------------------------------------

        nv_download.Show() 'Abrindo

        '------------------------------------------------------------------------------------

    End Function

    Public Function func_iniciar_novo_download_2(ByVal v_url_de_download) 'Inicia um novo download
        On Error Resume Next


        'Não permite continuar em caso de campo em branco -----------------------------------

        If (v_url_de_download = Nothing) Then

            Return Nothing 'Retorno

            Exit Function 'Saida

        End If

        '------------------------------------------------------------------------------------


        'Definindo propriedades -------------------------------------------------------------

        Process.Start("Explorer", v_url_de_download) 'Abrindo download

        '------------------------------------------------------------------------------------


    End Function

    Public Function func_iniciar_novo_download_3(ByVal v_url_de_download) 'Inicia um novo download
        On Error Resume Next

        Dim OBJ_MOTOR_DOWNLOAD_GECKOFX As New Skybound.Gecko.ChromeDialog


        'Não permite continuar em caso de campo em branco -----------------------------------

        If (v_url_de_download = Nothing) Then

            Return Nothing 'Retorno

            Exit Function 'Saida

        End If

        '------------------------------------------------------------------------------------


        'Definindo propriedades -------------------------------------------------------------

        OBJ_MOTOR_DOWNLOAD_GECKOFX.Show() 'Abrir

        OBJ_MOTOR_DOWNLOAD_GECKOFX.WebBrowser.Navigate(v_url_de_download) 'Abrindo download

        '------------------------------------------------------------------------------------


    End Function

    Public Sub proc_novo_download() 'Fazer novo download
        On Error Resume Next

        Dim v_end_de_download As String 'Informa o endereço do novo download

        Dim v_protocolo As String 'Informa o protocolo do download




        'Inicializando variáveis ------------------------------------------------

        v_end_de_download = txt_url_download.Text 'Url absoluta

        v_protocolo = v_end_de_download(0) 'F de FTP

        v_protocolo = v_protocolo.ToLower 'Minusculo caso necessario

        '------------------------------------------------------------------------


        'Verifica o inicio do protocolo --------------------------------------------------------------------------------

        If (v_protocolo = "f") Then


            MsgBox("O download solicitado deve ser baixado no modo agrupado!", MsgBoxStyle.Information, "Globe - Informa") 'Mensagem

            v_modo = 3 'Modo de download


            rd3.Checked = True 'Informando o modo

            rd1.Enabled = False 'Não disponivel

            rd2.Enabled = False 'Não disponivel


        End If

        '---------------------------------------------------------------------------------------------------------------


        'Iniciar novo download -----------------------------------------------------------------------------------------

        Select Case v_modo


            Case 1
                func_iniciar_novo_download_1(v_end_de_download) 'Inicia um novo download


            Case 2
                func_iniciar_novo_download_2(v_end_de_download) 'Inicia um novo download


            Case 3
                func_iniciar_novo_download_3(v_end_de_download) 'Inicia um novo download


        End Select



        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual
        On Error Resume Next

        Me.Opacity = V_VAL_CONFIG_TRANSPARENCIA 'Aplicando a transparencia

    End Sub

    Private Sub proc_informe_com_voz_texto_da_janela() 'Informa com voz o texto da janela em exibição.
        On Error Resume Next

        Dim V_TEXTO_DA_JANELA As String 'Armazena o texto da janela






        'Inicializando variável ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        V_TEXTO_DA_JANELA = V_MS_34 'Texto da janela

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Lendo o texto ----------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_VAL_CONFIG_USAR_VOZ_EM_CAIXAS_DE_DIALOGO = True) Then


            proc_falar_texto_repassado_recurso_de_voz_direto(V_TEXTO_DA_JANELA) 'Procedimento para leitura de texto repassado pelo usuário, sem saida ou entrada na caixa de texto.


        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub











    'Fazendo o navegador trabalhar menos temporariamente

    Private Sub proc_ativa_modo_menos_processamento() 'Ativa o modo menos processamento
        On Error Resume Next


        'Lendo configuração ---------------------------------------------------------------------------------------------

        v_ultima_configuracao_do_modo_geek = V_VAL_CONFIG_MODO_GEEK_ATIVADO 'Atualizando valor original da configuração

        '----------------------------------------------------------------------------------------------------------------




        'Definindo configuração temporaria ------------------------------------------------------------------------------

        V_VAL_CONFIG_MODO_GEEK_ATIVADO = True 'Ativando o modo geek temporario

        '----------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_desativa_modo_menos_processamento() 'Desativa o modo menos processamento
        On Error Resume Next

        'Restaurando valor original ------------------------------------------------------------------------------------

        V_VAL_CONFIG_MODO_GEEK_ATIVADO = v_ultima_configuracao_do_modo_geek 'Restaurando valor original

        '---------------------------------------------------------------------------------------------------------------




        'Removendo valor de variável -----------------------------------------------------------------------------------

        v_ultima_configuracao_do_modo_geek = Nothing 'Valor nulo

        '---------------------------------------------------------------------------------------------------------------




        'Atualizando propriedades nao atualizadas ----------------------------------------------------------------------------------------------------------------

        Proc_atualizar_propriedades_site_carregar_completo(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        '---------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub


























    Private Sub frm_novo_download_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        proc_ativa_modo_menos_processamento() 'Ativa o modo menos processamento

        proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual

        proc_informe_com_voz_texto_da_janela() 'Informa com voz o texto da janela em exibição.

    End Sub

    Private Sub frm_novo_download_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next

        proc_desativa_modo_menos_processamento() 'Desativa o modo menos processamento

        proc_calar_voz_do_motor_tts() 'Cala a voz do motor tts

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        On Error Resume Next

        proc_novo_download() 'Fazer novo download

        proc_fechar() 'Procedimento para fechar

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        On Error Resume Next

        proc_fechar() 'Procedimento para fechar

    End Sub

    Private Sub txt_url_download_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_url_download.KeyDown
        On Error Resume Next


        If (e.KeyCode = Keys.Enter) Then 'Ao pressionar enter


            e.SuppressKeyPress = True 'Desabilitar o beep

            proc_novo_download() 'Fazer novo download

            proc_fechar() 'Procedimento para fechar


        End If


    End Sub

    Private Sub rd1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd1.CheckedChanged
        On Error Resume Next

        v_modo = 1 'Modo 1

    End Sub

    Private Sub rd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd2.CheckedChanged
        On Error Resume Next

        v_modo = 2 'Modo 2

    End Sub

    Private Sub rd3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd3.CheckedChanged
        On Error Resume Next

        v_modo = 3 'Modo 3

    End Sub
End Class