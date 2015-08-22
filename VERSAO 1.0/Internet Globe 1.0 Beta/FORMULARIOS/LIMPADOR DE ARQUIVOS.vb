Public Class FRM_LIMPADOR_DE_ARQUIVOS


    'Variáveis basicas

    Dim v_ultima_configuracao_do_modo_geek As Boolean 'Informa a ultima configuração do modo geek











    'Procedimentos

    Private Sub proc_salvar_escolhas() 'Salva as escolhas do usuario
        On Error Resume Next


        'Informa para limpar os arquivos na proxima inicializacao ------------------------------------------------------

        proc_salvar_valor(chk_arquivos.Checked, V_ARQ_LIMPAR_DADOS_NAVEGACAO) 'Salva a configuração

        '---------------------------------------------------------------------------------------------------------------




        'Informa para limpar os arquivos na proxima inicializacao ------------------------------------------------------

        proc_salvar_valor(chk_visitados.Checked, V_ARQ_LIMPAR_DADOS_NAVEGACAO_HISTORICO) 'Salva a configuração

        '---------------------------------------------------------------------------------------------------------------




        'Nao informa que ira limpar os arquivos na proxima inicialização -----------------------------------------------

        If (chk_arquivos.Checked = False) And (chk_visitados.Checked = False) Then

            Exit Sub

        End If

        '---------------------------------------------------------------------------------------------------------------




        'Mensagem ao usuario -------------------------------------------------------------------------------------------

        proc_chamar_mensagem_ao_usuario(V_MS_11, v_tipo_ms_1) 'Chama a janela de mensagem ao usuario

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_ler_configuracoes() 'Le as configuracoes ja definidas anteriormente
        On Error Resume Next

        chk_arquivos.Checked = func_ler_valor(V_ARQ_LIMPAR_DADOS_NAVEGACAO) 'Retorna o valor do arquivo lido

        chk_visitados.Checked = func_ler_valor(V_ARQ_LIMPAR_DADOS_NAVEGACAO_HISTORICO) 'Retorna o valor do arquivo lido

    End Sub

    Private Sub proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual
        On Error Resume Next

        Me.Opacity = V_VAL_CONFIG_TRANSPARENCIA 'Aplicando a transparencia

    End Sub

    Private Sub proc_informe_com_voz_texto_da_janela() 'Informa com voz o texto da janela em exibição.
        On Error Resume Next

        Dim V_TEXTO_DA_JANELA As String 'Armazena o texto da janela






        'Inicializando variável ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        V_TEXTO_DA_JANELA = "Limpar os items informados abaixo, deixará o navegador muito mais rápido." 'Atualizando...

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
















    

    Private Sub FRM_LIMPADOR_DE_ARQUIVOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        proc_ativa_modo_menos_processamento() 'Ativa o modo menos processamento

        proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual

        proc_ler_configuracoes() 'Le as configuracoes ja definidas anteriormente

        proc_informe_com_voz_texto_da_janela() 'Informa com voz o texto da janela em exibição.

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        On Error Resume Next

        Me.Close() 'Saindo...

    End Sub

    Private Sub FRM_LIMPADOR_DE_ARQUIVOS_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next

        proc_desativa_modo_menos_processamento() 'Desativa o modo menos processamento

        proc_salvar_escolhas() 'Salva as escolhas do usuario

        proc_calar_voz_do_motor_tts() 'Cala a voz do motor tts

    End Sub

End Class