Public Class FRM_RESTAURAR_SESSAO_ANTERIOR



    'Variáveis basicas

    Dim v_ultima_configuracao_do_modo_geek As Boolean 'Informa a ultima configuração do modo geek










    'Procedimentos basicos

    Private Sub proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual
        On Error Resume Next

        Me.Opacity = V_VAL_CONFIG_TRANSPARENCIA 'Aplicando a transparencia

    End Sub

    Private Sub proc_encerrar() 'Encerra o programa por completo
        On Error Resume Next

        End 'Saindo...

    End Sub

    Private Sub proc_informe_com_voz_texto_da_janela() 'Informa com voz o texto da janela em exibição.
        On Error Resume Next

        Dim V_TEXTO_DA_JANELA As String 'Armazena o texto da janela






        'Inicializando variável ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        V_TEXTO_DA_JANELA = lbl_mensagem.Text 'Texto a ser lido

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Lendo o texto ----------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_VAL_CONFIG_USAR_VOZ_EM_CAIXAS_DE_DIALOGO = True) Then


            proc_falar_texto_repassado_recurso_de_voz_direto(V_TEXTO_DA_JANELA) 'Procedimento para leitura de texto repassado pelo usuário, sem saida ou entrada na caixa de texto.


        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_aplicar_tema_janela_restaurar_sessao() 'Aplicar tema somente na janela de restaurar sessao
        On Error Resume Next


        'Obtendo a configuração do tema -----------------------------------------------------------------------------

        V_VAL_CONFIG_TIPO_DE_TEMA = func_ler_valor(V_ARQ_CONFIG_TIPO_DE_TEMA) 'Retorna o valor do arquivo lido

        '------------------------------------------------------------------------------------------------------------






        'Selecionando o tipo de tema --------------------------------------------------------------------------------------------------------------------------------

        Select Case V_VAL_CONFIG_TIPO_DE_TEMA


            Case v_acao_tema_1 'Tema 1

                Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black 'Preto


            Case v_acao_tema_2 'Tema 2

                Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue 'Azul


            Case v_acao_tema_3 'Tema 3

                Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver 'Prateado


        End Select

        '------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub







    'Fazendo o navegador trabalhar menos temporariamente

    Private Sub proc_ativa_modo_menos_processamento() 'Ativa o modo menos processamento
        On Error Resume Next


        'Ocultando formulario principal --------------------------------------------

        FRM_NAVEGACAO.Hide() 'Ocultando...

        '---------------------------------------------------------------------------




        'Lendo configuração ---------------------------------------------------------------------------------------------

        v_ultima_configuracao_do_modo_geek = V_VAL_CONFIG_MODO_GEEK_ATIVADO 'Atualizando valor original da configuração

        '----------------------------------------------------------------------------------------------------------------




        'Definindo configuração temporaria ------------------------------------------------------------------------------

        V_VAL_CONFIG_MODO_GEEK_ATIVADO = True 'Ativando o modo geek temporario

        '----------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_desativa_modo_menos_processamento() 'Desativa o modo menos processamento
        On Error Resume Next


        'Exibindo formulario principal ---------------------------------------

        FRM_NAVEGACAO.Show() 'Exibindo...

        '---------------------------------------------------------------------




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










    'Dados de sessao

    Private Sub proc_iniciar_nova_ou_restaurar_sessao(ByVal v_resposta As Boolean) 'Inicia nova sessao ou inicia nova
        On Error Resume Next

        v_resposta_reabre_ou_inicia_nova_sessao = v_resposta 'Resposta


        Me.Close() 'Saindo do formulario atual

    End Sub




















    Private Sub FRM_RESTAURAR_SESSAO_ANTERIOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        proc_ativa_modo_menos_processamento() 'Ativa o modo menos processamento

        proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual

        proc_aplicar_tema_janela_restaurar_sessao() 'Aplicar tema somente na janela de restaurar sessao

        proc_informe_com_voz_texto_da_janela() 'Informa com voz o texto da janela em exibição.

    End Sub

    Private Sub FRM_RESTAURAR_SESSAO_ANTERIOR_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next

        proc_desativa_modo_menos_processamento() 'Desativa o modo menos processamento

        proc_calar_voz_do_motor_tts() 'Cala a voz do motor tts

    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        On Error Resume Next

        proc_iniciar_nova_ou_restaurar_sessao(False) 'Inicia nova sessao ou inicia nova

    End Sub

    Private Sub ButtonX2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        On Error Resume Next

        proc_iniciar_nova_ou_restaurar_sessao(True) 'Inicia nova sessao ou inicia nova

    End Sub

    Private Sub ButtonX3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        On Error Resume Next

        proc_encerrar() 'Encerra o programa por completo

    End Sub

End Class
