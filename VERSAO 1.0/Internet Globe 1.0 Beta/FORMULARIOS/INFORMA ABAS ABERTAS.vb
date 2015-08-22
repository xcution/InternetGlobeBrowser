Public Class FRM_INFORMA_ABAS_ABERTAS



    'Variáveis basicas

    Public V_ABERTAS As Integer 'Quantidade de abas abertas

    Dim v_ultima_configuracao_do_modo_geek As Boolean 'Informa a ultima configuração do modo geek

    Dim v_executou_opcao As Boolean = False 'Informa se o usuario executou uma opção













    'Procedimentos basicos

    Private Sub proc_informar_valores() 'Informa os valores recebidos
        On Error Resume Next

        lbl_abas_quantidade.Text = V_ABERTAS 'Informa a quantidade de abas abertas

    End Sub

    Private Sub proc_sair_da_janela() 'Sai da janela
        On Error Resume Next

        Me.Close() 'Saindo...

    End Sub

    Private Sub proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual
        On Error Resume Next

        Me.Opacity = V_VAL_CONFIG_TRANSPARENCIA 'Aplicando a transparencia

    End Sub

    Private Sub proc_informe_com_voz_texto_da_janela() 'Informa com voz o texto da janela em exibição.
        On Error Resume Next

        Dim V_TEXTO_DA_JANELA As String 'Armazena o texto da janela






        'Inicializando variável ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        V_TEXTO_DA_JANELA = "Sair do navegador? Existem váriás abas abertas, deseja fechar assim mesmo? Número de abas abertas: " & V_ABERTAS & ". " 'Atualizando...

        V_TEXTO_DA_JANELA = V_TEXTO_DA_JANELA & "Você deseja cancelar fechar? sair e não salvar as abas abertas? ou sair e salvar as abas abertas?" 'Atualizando...

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








    'Dados de sessao

    Private Sub proc_resposta_salvar_ou_nao_a_sessao(ByVal v_resposta As Boolean) 'Salva ou não a sessão
        On Error Resume Next


        v_executou_opcao = True 'Informa que o usuario executou uma opçao




        'Informa se salva ou nao a sessao aberta -----------------------------------------------------------------------

        proc_informar_encerrou_sessao_corretamente(v_resposta) 'Informa que encerrou a sessão corretamente

        '---------------------------------------------------------------------------------------------------------------




        'Informa que pode encerrar -------------------------------------------------------------------------------------

        v_pode_encerrar_formulario_principal = False 'Informa que pode encerrar

        '---------------------------------------------------------------------------------------------------------------




        'Saindo --------------------------------

        Me.Close() 'Saindo...

        '---------------------------------------


    End Sub

    Private Sub proc_cancelar_saida() 'Cancela a saida
        On Error Resume Next

        v_executou_opcao = True 'Informa que o usuario executou uma opçao




        v_pode_encerrar_formulario_principal = True 'Informa que nao pode encerrar

        Me.Close() 'Saindo...

    End Sub

    Private Sub proc_sair_verifica_ususario_executou_opcao() 'Verifica se o usuario executou uma opção
        On Error Resume Next

        If (v_executou_opcao = False) Then


            v_pode_encerrar_formulario_principal = True 'Informa que nao pode encerrar


        End If

    End Sub










    'Salvar e ler configuração do perguntar sempre

    Private Sub proc_salvar_config_perguntar_sempre_sair_abas_abertas() 'Salvar a configuração do sair, e sempre perguntar fechar várias abas.
        On Error Resume Next

        proc_salvar_valor(CheckBoxX1.Checked, V_ARQ_CONFIG_ALERTAR_ABAS_ABERTAS_AO_SAIR) 'Salva a configuração

        V_VAL_CONFIG_ALERTAR_ABAS_ABERTAS_AO_SAIR = func_ler_valor(V_ARQ_CONFIG_ALERTAR_ABAS_ABERTAS_AO_SAIR) 'Retorna o valor do arquivo lido

    End Sub

    Private Sub proc_ler_config_perguntar_sempre_sair_abas_abertas() 'Lê a configuração do sair, e sempre perguntar fechar várias abas.
        On Error Resume Next

        V_VAL_CONFIG_ALERTAR_ABAS_ABERTAS_AO_SAIR = func_ler_valor(V_ARQ_CONFIG_ALERTAR_ABAS_ABERTAS_AO_SAIR) 'Retorna o valor do arquivo lido

        CheckBoxX1.Checked = V_VAL_CONFIG_ALERTAR_ABAS_ABERTAS_AO_SAIR 'Setando configuração

    End Sub






























    Private Sub FRM_INFORMA_ABAS_ABERTAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        proc_ativa_modo_menos_processamento() 'Ativa o modo menos processamento

        proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual

        proc_informar_valores() 'Informa os valores recebidos

        proc_informe_com_voz_texto_da_janela() 'Informa com voz o texto da janela em exibição.

        proc_ler_config_perguntar_sempre_sair_abas_abertas() 'Lê a configuração do sair, e sempre perguntar fechar várias abas.

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next

        proc_sair_da_janela() 'Sai da janela

    End Sub

    Private Sub FRM_INFORMA_ABAS_ABERTAS_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next

        proc_sair_verifica_ususario_executou_opcao() 'Verifica se o usuario executou uma opção

        proc_desativa_modo_menos_processamento() 'Desativa o modo menos processamento

        proc_calar_voz_do_motor_tts() 'Cala a voz do motor tts

        proc_salvar_config_perguntar_sempre_sair_abas_abertas() 'Salvar a configuração do sair, e sempre perguntar fechar várias abas.

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        On Error Resume Next

        proc_resposta_salvar_ou_nao_a_sessao(True) 'Salva ou não a sessão

    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        On Error Resume Next

        proc_resposta_salvar_ou_nao_a_sessao(False) 'Salva ou não a sessão

    End Sub

    Private Sub ButtonX1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        On Error Resume Next

        proc_cancelar_saida() 'Cancela a saida

    End Sub

End Class