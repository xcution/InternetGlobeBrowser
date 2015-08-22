Imports System.IO

Module Modulo_de_inicializacao




    'Procedimentos a serem inicializados no carregamento do programa

    Public Sub proc_carregar_configuracoes_basicas() 'Carrega as configurações básicas
        On Error Resume Next


        'Tema -------------------------------------------------------------------------------------------------------

        proc_aplicar_tema_Modulo_de_aplicar_configuracoes() 'Aplica o tema no programa

        '------------------------------------------------------------------------------------------------------------




        'Aba --------------------------------------------------------------------------------------------------------

        proc_aplicar_tipo_de_aba_Modulo_de_aplicar_configuracoes() 'Aplica o tipo de aba

        '------------------------------------------------------------------------------------------------------------




        'Barra de navegação -----------------------------------------------------------------------------------------

        proc_barra_de_navegacao_Modulo_de_aplicar_configuracoes() 'Barra de navegação exibir ou não

        '------------------------------------------------------------------------------------------------------------




        'Barra de status --------------------------------------------------------------------------------------------

        proc_barra_de_status_Modulo_de_aplicar_configuracoes() 'Exibe ou não a barra de status

        '------------------------------------------------------------------------------------------------------------




        'Vozes do sistema -------------------------------------------------------------------------------------------

        proc_carregar_vozes_Modulo_de_aplicar_configuracoes() 'Carregar as vozes

        '------------------------------------------------------------------------------------------------------------




        'Preferencias dos motores -----------------------------------------------------------------------------------

        proc_inicializar_preferencias_de_motores() 'Inicializar as preferencias de motores layout engine

        '------------------------------------------------------------------------------------------------------------




        'Carregar historico -----------------------------------------------------------------------------------------

        proc_carregar_historico_de_sites_visitados() 'Carrega toda a lista de sites visitados

        '------------------------------------------------------------------------------------------------------------




        'Carregar historico de imagens de sites visitados -------------------------------------------------------------------------------------

        proc_carregar_historico_de_sites_visitados_imagens_de_autocompletar() 'Carrega as imagens do recurso de autocompletar

        '--------------------------------------------------------------------------------------------------------------------------------------




        'Abrir a página inicial -------------------------------------------------------------------------------------

        proc_abrir_pagina_inicial_ao_inicializar_navegador() 'Abre a página inicial ao inicializar o navegador

        '------------------------------------------------------------------------------------------------------------




        'Cria o recurso da aba do recurso de autocompletar -------------------------------------------------------------------------------------------------------

        proc_inicializar_motor_geckofx_em_aba_de_historico_de_rec_auto_completar() 'Inicializa e cria o motor geckofx da aba do recurso de autocompletar

        '---------------------------------------------------------------------------------------------------------------------------------------------------------




















    End Sub

    Public Sub proc_abrir_formulario_de_navegacao_Modulo_de_inicializacao() 'Abre o formulario de navegação
        On Error Resume Next


        'Abrindo formulario de navegação -------------------------------------------------------------------------------

        FRM_NAVEGACAO.Show() 'Abrindo o formulario de navegação

        '---------------------------------------------------------------------------------------------------------------




        'Ocultando a tela de boas vindas -------------------------------------------------------------------------------

        FRM_TELA_DE_BOAS_VINDAS.Close() 'Fechando a tela de boas vindas

        '---------------------------------------------------------------------------------------------------------------




        'Carregando configuraçoes basicas ------------------------------------------------------------------------------

        proc_carregar_configuracoes_basicas() 'Carrega as configurações básicas

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_carregar_e_inicializar_Modulo_de_inicializacao() 'Carrega e inicializa o programa
        On Error Resume Next


        'Setando diretorio de trabalho atual ----------------------------------------------------------------------------------------------------------------

        Directory.SetCurrentDirectory(V_PASTA_DA_INSTALACAO_DO_PROGRAMA) 'Setando diretorio atual

        '----------------------------------------------------------------------------------------------------------------------------------------------------




        'Verifica se carrega ou nao as configuraçõea padrao -------------------------------------------------------------------------------------------------

        proc_carregar_configuracoes_padrao_em_caso_de_falta() 'Em caso de nao houver configurações, então carregar configuração padrao.

        '----------------------------------------------------------------------------------------------------------------------------------------------------




        'Remove arquivos antigos de navegação -----------------------------------------------------------------------

        proc_limpar_cache_geckofx() 'Limpar cache do navegador ao inicializar geckofx

        proc_limpar_cache_de_historico_sites_visitados() 'Limpa o cache de historico de sites visitados

        '------------------------------------------------------------------------------------------------------------




        'Configurações necessárias ----------------------------------------------------------------------------------------

        proc_atualizar_valor_de_variaveis() 'Atualiza o valor das variáveis

        '------------------------------------------------------------------------------------------------------------------




        'Adicionar primeira aba ou restaura a ultima sessao ---------------------------------------------------------------

        proc_inicializar_e_restaurar_ultima_sessao() 'Inicializa e restaura a ultima sessao

        '------------------------------------------------------------------------------------------------------------------




        'Verifica se exibe ou não a tela de boas vindas -----------------------------------------------------------------------------------------------------------

        If (V_VAL_CONFIG_TELA_DE_BOAS_VINDAS = False) Then



            'Abrindo formulario de navegação e fechando tela de boas vindas -----------------------------------------------

            proc_abrir_formulario_de_navegacao_Modulo_de_inicializacao() 'Abre o formulario de navegação

            '--------------------------------------------------------------------------------------------------------------




            'Saindo ---------------------

            Exit Sub 'Saindo...

            '----------------------------



        Else



            'Som de inicialização, indicando que o formulario de boas vindas está aberto ainda ----------------------------

            proc_som_de_evento_ouvir(v_som_de_inicializacao) 'Ouvir o som de evento

            '--------------------------------------------------------------------------------------------------------------



        End If

        '----------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub
























End Module
