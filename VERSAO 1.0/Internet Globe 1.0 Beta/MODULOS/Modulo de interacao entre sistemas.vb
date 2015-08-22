Imports System.IO




Module Modulo_de_interacao_entre_sistemas


    'VARIÁVEIS

    Public V_PAGINA_DE_DOWNLOAD_DO_NAVEGADOR As String = "http://www.baixabit.com.br/IG" 'PÁGINA DE DOWNLOAD DO INTERNET GLOBE

    Public V_PAGINA_DE_DOWNLOAD_DO_NAVEGADOR_AJUDA As String = V_PAGINA_DE_DOWNLOAD_DO_NAVEGADOR & "/Ajuda/" 'PÁGINA DE DOWNLOAD DO INTERNET GLOBE AJUDA

    Public V_PAGINA_DE_DOWNLOAD_DO_NAVEGADOR_NOVIDADES As String = V_PAGINA_DE_DOWNLOAD_DO_NAVEGADOR & "/Novidades/" 'PÁGINA DE DOWNLOAD DO INTERNET GLOBE NOVIDADES

    Public V_PAGINA_DE_DOWNLOAD_DO_NAVEGADOR_ATUALIZACOES As String = V_PAGINA_DE_DOWNLOAD_DO_NAVEGADOR & "/Atualizacoes/" 'PÁGINA DE DOWNLOAD DO INTERNET GLOBE ATUALIZAÇÕES




















    'Procedimentos

    Public Sub proc_menu_ajuda_processar_requerimento(ByVal v_abrir_end_solicitado As String) 'Executar açao no menu ajuda pelo usuário
        On Error Resume Next

        Dim v_backup_config_abas_de_mais As Boolean = V_VAL_CONFIG_ALERTAR_ABRIR_ABAS_DEMAIS 'Faz o backup






        'Informa que nao pode alertar ao abrir abas demais -------------------------------------------------------------

        V_VAL_CONFIG_ALERTAR_ABRIR_ABAS_DEMAIS = False 'Informa que não deve alertar sobre abrir abas demais

        '---------------------------------------------------------------------------------------------------------------




        'Adicionando nova aba -----------------------------------------------------------------------------------------------------------------------------------

        proc_adicionador_de_nova_aba_e_motor(True) 'Adiciona o motor geckofx ou não. True para sim e false para nao

        proc_navegar(v_abrir_end_solicitado, v_tipo_de_motor_layout_engine_em_uso_agora, v_qual_motor_esta_em_uso) 'NAVEGA NO SITE SOLICITADO PELO USUARIO

        '--------------------------------------------------------------------------------------------------------------------------------------------------------




        'Restaurando o backup de configuração --------------------------------------------------------------------------

        V_VAL_CONFIG_ALERTAR_ABRIR_ABAS_DEMAIS = v_backup_config_abas_de_mais 'Restaurando

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    




























End Module
