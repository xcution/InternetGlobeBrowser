Module Modulo_de_chamar_janelas



    'Procedimentos para criação de novas janelas

    Public Sub proc_chamar_painel_de_controle() 'Chamar o painel de controle
        On Error Resume Next

        Dim OBJ_JANELA As New FRM_PAINEL_DE_CONTROLE 'Nova janela de painel de controle






        'Abrindo janela ----------------------------------------------------------------

        OBJ_JANELA.Show() 'Chamando o painel de controle

        '-------------------------------------------------------------------------------




        'Atualizando variáveis ---------------------------------------------------------

        proc_atualizar_valor_de_variaveis() 'Atualiza o valor das variáveis

        '-------------------------------------------------------------------------------


    End Sub

    Public Sub proc_chamar_favoritos(ByVal v_listar As Boolean, ByVal v_gerenciar As Boolean) 'Chama a janela de favoritos
        On Error Resume Next

        Dim OBJ_JANELA As New FRM_FAVORITOS 'Nova janela de favoritos






        'Definindo propriedades --------------------------------------------------------------------------------------

        OBJ_JANELA.v_listar_favoritos = v_listar 'Informa se vai listar ou não

        OBJ_JANELA.v_gerenciar_favoritos = v_gerenciar 'Informa se vai ou nao gerenciar favoritos

        OBJ_JANELA.Show() 'Abrindo a janela

        '-------------------------------------------------------------------------------------------------------------



        'Atualizando variáveis ---------------------------------------------------------

        proc_atualizar_valor_de_variaveis() 'Atualiza o valor das variáveis

        '-------------------------------------------------------------------------------


    End Sub

    Public Sub proc_chamar_historico() 'Chama a janela de historico
        On Error Resume Next

        Dim OBJ_JANELA As New FRM_HISTORICO 'Nova janela de historico






        'Definindo propriedades --------------------------------------------------------------------------------------

        OBJ_JANELA.Show() 'Abrindo a janela

        '-------------------------------------------------------------------------------------------------------------




        'Atualizando variáveis ---------------------------------------------------------

        proc_atualizar_valor_de_variaveis() 'Atualiza o valor das variáveis

        '-------------------------------------------------------------------------------


    End Sub

    Public Sub proc_chamar_novo_download() 'Chamar a janela de novo download
        On Error Resume Next

        Dim OBJ_JANELA As New FRM_NOVO_DOWNLOAD 'Janela de novo download






        'Definindo propriedades --------------------------------------------------------------------------------------

        OBJ_JANELA.Show() 'Abrindo a janela

        '-------------------------------------------------------------------------------------------------------------




        'Atualizando variáveis ---------------------------------------------------------

        proc_atualizar_valor_de_variaveis() 'Atualiza o valor das variáveis

        '-------------------------------------------------------------------------------


    End Sub

    Public Sub proc_chamar_limpador_de_arquivos() 'Limpador de arquivos janela chamar
        On Error Resume Next

        Dim OBJ_JANELA As New FRM_LIMPADOR_DE_ARQUIVOS






        'Definindo propriedades --------------------------------------------------------------------------------------

        OBJ_JANELA.Show() 'Abrindo a janela

        '-------------------------------------------------------------------------------------------------------------




        'Atualizando variáveis ---------------------------------------------------------

        proc_atualizar_valor_de_variaveis() 'Atualiza o valor das variáveis

        '-------------------------------------------------------------------------------


    End Sub

    Public Sub proc_chamar_mensagem_ao_usuario(ByVal MS As String, ByVal v_tipo_de_mensagem_ms As Byte) 'Chama a janela de mensagem ao usuario
        On Error Resume Next

        Dim OBJ_JANELA As New FRM_MENSAGENS_AO_USUARIO






        'Definindo propriedades --------------------------------------------------------------------------------------

        OBJ_JANELA.v_mensagem_FRM_MENSAGENS_AO_USUARIO = MS 'Informando a mensagem ao usuario

        OBJ_JANELA.v_tipo_de_mensagem_repassada = v_tipo_de_mensagem_ms 'Repassando o tipo de mensagem

        OBJ_JANELA.Show() 'Abrindo a janela

        '-------------------------------------------------------------------------------------------------------------




        'Atualizando variáveis ---------------------------------------------------------

        proc_atualizar_valor_de_variaveis() 'Atualiza o valor das variáveis

        '-------------------------------------------------------------------------------


    End Sub

    Public Sub proc_chamar_entrada_e_saida_de_texto(ByVal v_texto_repassado As String) 'Entrada e saida de texto
        On Error Resume Next

        Dim OBJ_JANELA As New FRM_FORMULARIO_ENTRADA_E_SAIDA_DE_TEXTO 'Nova janela de entrada e saida de texto






        'Definindo propriedades --------------------------------------------------------------------------------------

        OBJ_JANELA.Show() 'Abrindo a janela

        OBJ_JANELA.V_TEXTO_REPASSADO_PELO_USUARIO_REALIZAR_LEITURA = v_texto_repassado 'Obtendo o texto repassado

        '-------------------------------------------------------------------------------------------------------------




        'Atualizando variáveis ---------------------------------------------------------

        proc_atualizar_valor_de_variaveis() 'Atualiza o valor das variáveis

        '-------------------------------------------------------------------------------


    End Sub

    Public Sub proc_chamar_janela_de_erro_ao_abrir_site() 'Chama a janela de erro ao abrir site
        On Error Resume Next

        Dim OBJ_JANELA As New FRM_ERRO_AO_ABRIR_SITE 'Novo formulário de erro ao abrir site






        'Não permite a janela de erro ao abrir site, quando o protetor de codigos maliciosos estiver habilitado ------------------------------

        If (V_VAL_CONFIG_PROTEGER_CONTRA_CODIGOS_MALICIOSOS = True) Then


            Exit Sub 'Saindo...


        End If

        '-------------------------------------------------------------------------------------------------------------------------------------




        'Definindo propriedades --------------------------------------------------------------------------------------

        OBJ_JANELA.Show() 'Abrindo a janela

        OBJ_JANELA.v_aba_abrir_numero = v_qual_motor_esta_em_uso 'Numero da aba

        '-------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_chamar_janela_de_restaurar_sessao() 'Chama a janela de restauração de sessao
        On Error Resume Next

        Dim OBJ_JANELA As New FRM_RESTAURAR_SESSAO_ANTERIOR 'Nova janela






        'Abrindo a janela ----------------------------------------------------------------------------------------------

        OBJ_JANELA.ShowDialog() 'Abrindo a janela

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_chamar_painel_de_controle_app_config_padrao() 'Chamar o painel de controle e aplica as configurações padrão
        On Error Resume Next

        Dim OBJ_JANELA As New FRM_PAINEL_DE_CONTROLE 'Nova janela de painel de controle






        'Abrindo janela ----------------------------------------------------------------

        OBJ_JANELA.Show() 'Chamando o painel de controle

        '-------------------------------------------------------------------------------




        'Atualizando variáveis --------------------------------------------------------------------------------------------------------

        OBJ_JANELA.proc_definir_config_padrao_painel_de_controle() 'Define as configurações padrão do painel de controle

        OBJ_JANELA.txt_1.Text = v_pagina_inicial_site_empresa 'Site da empresa

        OBJ_JANELA.proc_salvar_configuracoes_FRM_PAINEL_DE_CONTROLE() 'Salva as configurações do painel de controle

        proc_atualizar_valor_de_variaveis() 'Atualiza o valor das variáveis

        '------------------------------------------------------------------------------------------------------------------------------


    End Sub



























End Module
