Imports DevComponents.DotNetBar




Public Class FRM_NAVEGACAO


    'Variáveis de processamento local

    Dim v_item_menu_pop_up_clicado As Integer 'Armazena o item do bloqueador de pop-up clicado








    'Objetos básicos

    Public GECK_MOTOR_DE_AUTO_COMPLETAR_HIST As New Skybound.Gecko.GeckoWebBrowser 'Novo motor geckofx do recurso de autocompletar















    'Procedimentos basicos do navegador

    'Barra de encontrar texto ---------------------------------------------------------------------------------------

    Public Sub proc_barra_de_encontrar_exibir(ByVal v_resposta As Boolean) 'Exibe a barra de encontrar
        On Error Resume Next


        'Analizando resposta ---------------------------------------------------------------------------------------------------------

        If (v_resposta = True) Then


            PanelEx2.Visible = True 'Exibe a barra de encontrar


        Else


            PanelEx2.Visible = False 'Oculta a barra de encontrar


        End If

        '-----------------------------------------------------------------------------------------------------------------------------


        If (v_tipo_de_motor_layout_engine_em_uso_agora = False) Then


            PanelEx2.Visible = False 'Oculta a barra de encontrar


            Select Case v_qual_motor_esta_em_uso


                Case 1
                    OBJ_MOTOR_WEB_BROWSER_1.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 2
                    OBJ_MOTOR_WEB_BROWSER_2.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 3
                    OBJ_MOTOR_WEB_BROWSER_3.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 4
                    OBJ_MOTOR_WEB_BROWSER_4.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 5
                    OBJ_MOTOR_WEB_BROWSER_5.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 6
                    OBJ_MOTOR_WEB_BROWSER_6.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 7
                    OBJ_MOTOR_WEB_BROWSER_7.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 8
                    OBJ_MOTOR_WEB_BROWSER_8.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 9
                    OBJ_MOTOR_WEB_BROWSER_9.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 10
                    OBJ_MOTOR_WEB_BROWSER_10.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 11
                    OBJ_MOTOR_WEB_BROWSER_11.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 12
                    OBJ_MOTOR_WEB_BROWSER_12.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 13
                    OBJ_MOTOR_WEB_BROWSER_13.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 14
                    OBJ_MOTOR_WEB_BROWSER_14.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 15
                    OBJ_MOTOR_WEB_BROWSER_15.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 16
                    OBJ_MOTOR_WEB_BROWSER_16.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 17
                    OBJ_MOTOR_WEB_BROWSER_17.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 18
                    OBJ_MOTOR_WEB_BROWSER_18.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 19
                    OBJ_MOTOR_WEB_BROWSER_19.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 20
                    OBJ_MOTOR_WEB_BROWSER_20.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 21
                    OBJ_MOTOR_WEB_BROWSER_21.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 22
                    OBJ_MOTOR_WEB_BROWSER_22.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 23
                    OBJ_MOTOR_WEB_BROWSER_23.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 24
                    OBJ_MOTOR_WEB_BROWSER_24.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 25
                    OBJ_MOTOR_WEB_BROWSER_25.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 26
                    OBJ_MOTOR_WEB_BROWSER_26.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 27
                    OBJ_MOTOR_WEB_BROWSER_27.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 28
                    OBJ_MOTOR_WEB_BROWSER_28.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 29
                    OBJ_MOTOR_WEB_BROWSER_29.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 30
                    OBJ_MOTOR_WEB_BROWSER_30.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 31
                    OBJ_MOTOR_WEB_BROWSER_31.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 32
                    OBJ_MOTOR_WEB_BROWSER_32.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 33
                    OBJ_MOTOR_WEB_BROWSER_33.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 34
                    OBJ_MOTOR_WEB_BROWSER_34.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 35
                    OBJ_MOTOR_WEB_BROWSER_35.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 36
                    OBJ_MOTOR_WEB_BROWSER_36.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 37
                    OBJ_MOTOR_WEB_BROWSER_37.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 38
                    OBJ_MOTOR_WEB_BROWSER_38.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 39
                    OBJ_MOTOR_WEB_BROWSER_39.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 40
                    OBJ_MOTOR_WEB_BROWSER_40.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 41
                    OBJ_MOTOR_WEB_BROWSER_41.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 42
                    OBJ_MOTOR_WEB_BROWSER_42.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 43
                    OBJ_MOTOR_WEB_BROWSER_43.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 44
                    OBJ_MOTOR_WEB_BROWSER_44.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 45
                    OBJ_MOTOR_WEB_BROWSER_45.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 46
                    OBJ_MOTOR_WEB_BROWSER_46.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 47
                    OBJ_MOTOR_WEB_BROWSER_47.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 48
                    OBJ_MOTOR_WEB_BROWSER_48.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 49
                    OBJ_MOTOR_WEB_BROWSER_49.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 50
                    OBJ_MOTOR_WEB_BROWSER_50.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 51
                    OBJ_MOTOR_WEB_BROWSER_51.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 52
                    OBJ_MOTOR_WEB_BROWSER_52.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 53
                    OBJ_MOTOR_WEB_BROWSER_53.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 54
                    OBJ_MOTOR_WEB_BROWSER_54.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 55
                    OBJ_MOTOR_WEB_BROWSER_55.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 56
                    OBJ_MOTOR_WEB_BROWSER_56.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 57
                    OBJ_MOTOR_WEB_BROWSER_57.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 58
                    OBJ_MOTOR_WEB_BROWSER_58.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 59
                    OBJ_MOTOR_WEB_BROWSER_59.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 60
                    OBJ_MOTOR_WEB_BROWSER_60.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 61
                    OBJ_MOTOR_WEB_BROWSER_61.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 62
                    OBJ_MOTOR_WEB_BROWSER_62.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 63
                    OBJ_MOTOR_WEB_BROWSER_63.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 64
                    OBJ_MOTOR_WEB_BROWSER_64.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 65
                    OBJ_MOTOR_WEB_BROWSER_65.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 66
                    OBJ_MOTOR_WEB_BROWSER_66.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 67
                    OBJ_MOTOR_WEB_BROWSER_67.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 68
                    OBJ_MOTOR_WEB_BROWSER_68.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 69
                    OBJ_MOTOR_WEB_BROWSER_69.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 70
                    OBJ_MOTOR_WEB_BROWSER_70.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 71
                    OBJ_MOTOR_WEB_BROWSER_71.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 72
                    OBJ_MOTOR_WEB_BROWSER_72.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 73
                    OBJ_MOTOR_WEB_BROWSER_73.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 74
                    OBJ_MOTOR_WEB_BROWSER_74.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 75
                    OBJ_MOTOR_WEB_BROWSER_75.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 76
                    OBJ_MOTOR_WEB_BROWSER_76.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 77
                    OBJ_MOTOR_WEB_BROWSER_77.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 78
                    OBJ_MOTOR_WEB_BROWSER_78.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 79
                    OBJ_MOTOR_WEB_BROWSER_79.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 80
                    OBJ_MOTOR_WEB_BROWSER_80.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 81
                    OBJ_MOTOR_WEB_BROWSER_81.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 82
                    OBJ_MOTOR_WEB_BROWSER_82.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 83
                    OBJ_MOTOR_WEB_BROWSER_83.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 84
                    OBJ_MOTOR_WEB_BROWSER_84.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 85
                    OBJ_MOTOR_WEB_BROWSER_85.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 86
                    OBJ_MOTOR_WEB_BROWSER_86.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 87
                    OBJ_MOTOR_WEB_BROWSER_87.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 88
                    OBJ_MOTOR_WEB_BROWSER_88.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 89
                    OBJ_MOTOR_WEB_BROWSER_89.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 90
                    OBJ_MOTOR_WEB_BROWSER_90.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 91
                    OBJ_MOTOR_WEB_BROWSER_91.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 92
                    OBJ_MOTOR_WEB_BROWSER_92.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 93
                    OBJ_MOTOR_WEB_BROWSER_93.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 94
                    OBJ_MOTOR_WEB_BROWSER_94.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 95
                    OBJ_MOTOR_WEB_BROWSER_95.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 96
                    OBJ_MOTOR_WEB_BROWSER_96.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 97
                    OBJ_MOTOR_WEB_BROWSER_97.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 98
                    OBJ_MOTOR_WEB_BROWSER_98.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 99
                    OBJ_MOTOR_WEB_BROWSER_99.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 100
                    OBJ_MOTOR_WEB_BROWSER_100.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 101
                    OBJ_MOTOR_WEB_BROWSER_101.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 102
                    OBJ_MOTOR_WEB_BROWSER_102.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 103
                    OBJ_MOTOR_WEB_BROWSER_103.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 104
                    OBJ_MOTOR_WEB_BROWSER_104.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 105
                    OBJ_MOTOR_WEB_BROWSER_105.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 106
                    OBJ_MOTOR_WEB_BROWSER_106.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 107
                    OBJ_MOTOR_WEB_BROWSER_107.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 108
                    OBJ_MOTOR_WEB_BROWSER_108.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 109
                    OBJ_MOTOR_WEB_BROWSER_109.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 110
                    OBJ_MOTOR_WEB_BROWSER_110.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 111
                    OBJ_MOTOR_WEB_BROWSER_111.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 112
                    OBJ_MOTOR_WEB_BROWSER_112.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 113
                    OBJ_MOTOR_WEB_BROWSER_113.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 114
                    OBJ_MOTOR_WEB_BROWSER_114.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 115
                    OBJ_MOTOR_WEB_BROWSER_115.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 116
                    OBJ_MOTOR_WEB_BROWSER_116.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 117
                    OBJ_MOTOR_WEB_BROWSER_117.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 118
                    OBJ_MOTOR_WEB_BROWSER_118.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 119
                    OBJ_MOTOR_WEB_BROWSER_119.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 120
                    OBJ_MOTOR_WEB_BROWSER_120.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 121
                    OBJ_MOTOR_WEB_BROWSER_121.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 122
                    OBJ_MOTOR_WEB_BROWSER_122.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 123
                    OBJ_MOTOR_WEB_BROWSER_123.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 124
                    OBJ_MOTOR_WEB_BROWSER_124.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 125
                    OBJ_MOTOR_WEB_BROWSER_125.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 126
                    OBJ_MOTOR_WEB_BROWSER_126.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 127
                    OBJ_MOTOR_WEB_BROWSER_127.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")

                Case 128
                    OBJ_MOTOR_WEB_BROWSER_128.Focus() 'Selecionando o motor
                    SendKeys.Send("^f")






            End Select


        End If


    End Sub

    '----------------------------------------------------------------------------------------------------------------




    'Tela cheia -----------------------------------------------------------------------------------------------------

    Public Sub proc_tela_cheia_ativar_modo(ByVal v_resposta As Boolean) 'Ativa o modo de tela cheia
        On Error Resume Next


        'Analizando resposta ----------------------------------------------------------------------------------------------

        If (v_resposta = True) Then


            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None 'Sem borda
            ButtonItem81.Enabled = False 'Menu sim
            ButtonItem82.Enabled = True 'Menu nao
            Me.Hide() 'Ocultar
            Me.Show() 'Exibir


        Else


            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable 'Borda normal
            ButtonItem81.Enabled = True 'Menu sim
            ButtonItem82.Enabled = False 'Menu nao
            Me.Hide() 'Ocultar
            Me.Show() 'Exibir


        End If

        '------------------------------------------------------------------------------------------------------------------


    End Sub

    '----------------------------------------------------------------------------------------------------------------




    'Atualiza propriedades ao trocar de aba -------------------------------------------------------------------------

    Public Sub proc_atualizar_propriedades_gerais_evento_trocar_de_aba_completo() 'Ao trocar de aba alterar propriedades
        On Error Resume Next



        'Informa que pode atualizar a aba --------------------------------------------------------------------------

        V_PODE_CONTINUAR_EXECUTANDO_PROCEDIMENTOS_NORMAIS = True 'Informa que o processamento está normal 

        '-----------------------------------------------------------------------------------------------------------




        'Oculta a barra de enderecos -------------------------------------------------------------------------------

        Proc_exibir_ou_ocultar_barra_de_progresso(False) 'Oculta ou exibe a barra de carregamento

        '-----------------------------------------------------------------------------------------------------------



        'Não permite trabalhar com a aba de historico de navegação -----------------------------------------------------

        If (TabItem5.IsSelected = True) Then


            'Move o foco para a barra de endereços ---------------------------------------------------------------------

            ComboBoxEx1.Focus() 'Movendo o foco...

            '-----------------------------------------------------------------------------------------------------------




            'Saindo ----------------------------------------------------------------------------------------------------

            Exit Sub 'Saindo...

            '-----------------------------------------------------------------------------------------------------------


        End If

        '---------------------------------------------------------------------------------------------------------------



        'Retorna o tipo de motor em uso ------------------------------------------------------------------------------------------------------------------

        v_tipo_de_motor_layout_engine_em_uso_agora = func_retorne_tipo_de_motor(TabControl1.SelectedTab.Name) 'Retorna tipo de motor em uso

        '-------------------------------------------------------------------------------------------------------------------------------------------------



        'Atualiza os eventos em tempo de execução -------------------------------------------------------------------------------------

        proc_adicionador_de_eventos_em_tempo_de_execucao() 'Adiciona o evento em tempo de execução

        '------------------------------------------------------------------------------------------------------------------------------



        'Atualiza propriedades de carregamento concluido ---------------------------------------------------------------------------------------------------------

        Proc_atualizar_propriedades_site_carregar_completo(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        '---------------------------------------------------------------------------------------------------------------------------------------------------------



        'Atualize o historico de imagens recurso autocompletar ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        proc_gerar_e_atualiza_imagem_do_historico_de_sites_visitados_pelo_navegador(func_retorne_o_titulo_do_site_em_aberto, func_retorne_o_site_em_aberto, Date.Today) 'Gera a imagem do historico que sera usada no recurso de autocompletar

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



        'Oculta a aba de historico autocompletar -----------------------------------------------------------------------------------------------------------------

        proc_ocultar_aba_de_historico_autocompletar(False) 'Habilita ou desabilita a aba de historico

        '---------------------------------------------------------------------------------------------------------------------------------------------------------











    End Sub

    '----------------------------------------------------------------------------------------------------------------




    'Atualidades de cpu sair e executar açoes --------------------------------------------------------------------------

    Private Sub proc_atualidade_de_cpu_sair(ByVal v_fazer_algo As Boolean) 'Atualidade de cpu fazer algo ou não ao sair
        On Error Resume Next


        'Verificando se faz algo ou não --------------------------------------------------------------------------------

        If (v_fazer_algo = True) Then




            '# Saindo e informando que o problema deve ser corrigido

            proc_salvar_valor(3, V_ARQ_CONFIG_COMPUTADOR_LENTO_SOLUCAO) 'Salva a configuração

            proc_atualizar_valor_de_variaveis() 'Atualiza o valor das variáveis

            PanelEx3.Visible = False 'Saindo...




        Else




            '# Saindo e nao fazendo nada

            PanelEx3.Visible = False 'Saindo...




        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    '-------------------------------------------------------------------------------------------------------------------




    'Nivel de transparenia ---------------------------------------------------------------------------------------------

    Private Sub proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual
        On Error Resume Next

        Me.Opacity = V_VAL_CONFIG_TRANSPARENCIA 'Aplicando a transparencia

    End Sub

    '-------------------------------------------------------------------------------------------------------------------




    'Exibir texto correto na opçao de ler texto -------------------------------------------------------------------------------------------------------------------

    Private Sub proc_exibir_opcao_de_menu_correto_leitor_de_texto() 'Exibe a opção correta do item leitor de pagina
        On Error Resume Next

        Dim v_resposta_da_funcao As Boolean = func_retorne_motor_tts_sendo_usado_status() 'Retorna o valor do status de leitura do motor tts







        'Analizando resposta -------------------------------------------------------------------------------------------

        If (v_resposta_da_funcao = True) Then



            ButtonItem49.Text = "&Parar leitura de texto" 'Atualizando texto


        Else


            ButtonItem49.Text = "Ou&vir este texto" 'Atualizando texto


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    '--------------------------------------------------------------------------------------------------------------------------------------------------------------




    'Imprimir pagina ----------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub proc_imprimir_a_pagina_FRM_NAVEGACAO() 'Procedimento para imprimir a pagina
        On Error Resume Next


        'Mensagem ao usuario -------------------------------------------------------------------------------------------

        Dim OBJ_JANELA As New FRM_MENSAGENS_AO_USUARIO 'Janela de mensagem

        OBJ_JANELA.v_mensagem_FRM_MENSAGENS_AO_USUARIO = V_MS_12 'Mensagem

        OBJ_JANELA.v_tipo_de_mensagem_repassada = v_tipo_ms_1 'Tipo de mensagem

        OBJ_JANELA.TopMost = True 'Topmost ativado

        OBJ_JANELA.Show() 'Abrindo...

        OBJ_JANELA.Refresh() 'Atualizando...

        '---------------------------------------------------------------------------------------------------------------


        'Abrindo janela de impressao --------------------------------

        proc_imprimir_a_pagina() 'Imprimir página

        '------------------------------------------------------------


        'Fechando janela -----------------

        OBJ_JANELA.Close() 'Fechando...

        '---------------------------------


    End Sub

    Private Sub proc_exibir_ip_de_site_e_atual_formulario_de_navegacao() 'Exibe o ip do site e o ip do computador
        On Error Resume Next

        Dim V_HOST As New Uri(func_retorne_o_site_em_aberto) 'Obtendo host de site






        'Exibindo ip atual de computador e site -----------------------------------------------------------------------------------------------

        proc_exibir_end_ip_de_site_e_proprio_end_ip(V_HOST.Host, Control.MousePosition) 'Exibe endereço de site e o proprio end ip.

        '--------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    '--------------------------------------------------------------------------------------------------------------------------------------------------------------




    'Exibir a lista de favoritos simples ---------------------------------------------------------------------------------------------------------------------------

    Private Function func_listar_favoritos_no_menu_favoritos_sub_pastas(ByVal V_NOME_PASTA_ATUAL As String, ByVal V_INFORME_QUANT_FAVORITOS As Boolean, ByVal V_CONTADOR As Integer) 'Listar todos os favorítos do menu favoritos e suas subpastas
        On Error Resume Next

        Dim v_endereco_da_pasta_selecionada As String 'Informa o endereço da pasta selecionada

        Dim v_lista_de_sub_diretorios As System.Collections.ObjectModel.ReadOnlyCollection(Of String) 'Listagem de sub-diretorios

        Dim v_quantidade_de_favoritos As Integer 'Informa a quantidade de pastas

        Dim v_nome_da_pasta_a_adicionar As Array 'Informa o nome da pasta a ser adicionada

        Dim v_separador As String = "\" 'Separador do array

        Dim v_nome_na_lista As String 'Nome a ser colocado na listagem

        Dim v_extencao As String = ".txt" 'Extenção do arquivo de favoríto


        v_endereco_da_pasta_selecionada = V_PASTA_DE_FAVORITOS & "\" & V_NOME_PASTA_ATUAL 'Endereço da pasta




        'Inicializando -------------------------------------------------------------------------------------------------------------------------------------

        v_lista_de_sub_diretorios = My.Computer.FileSystem.GetFiles(v_endereco_da_pasta_selecionada, FileIO.SearchOption.SearchTopLevelOnly)

        v_quantidade_de_favoritos = v_lista_de_sub_diretorios.Count - 1 'Informa a quantidade de pastas

        '---------------------------------------------------------------------------------------------------------------------------------------------------




        'Verifica se informa somente a quantidade de favoritos ---------------------------------------------------------------------------------------------

        If (V_INFORME_QUANT_FAVORITOS = True) Then


            Return v_quantidade_de_favoritos 'Retorna a quantidade de favoritos

            Exit Function 'Saindo...


        End If

        '---------------------------------------------------------------------------------------------------------------------------------------------------




        'Adicionando --------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        v_nome_da_pasta_a_adicionar = Split(v_lista_de_sub_diretorios(v_contador), v_separador) 'Nome da pasta


        v_nome_na_lista = v_nome_da_pasta_a_adicionar(v_nome_da_pasta_a_adicionar.Length - 1) 'Nome a ser colocado na listagem


        v_nome_na_lista = v_nome_na_lista.Replace(v_extencao, Nothing) 'Limpando extenção


        Return v_nome_na_lista 'Informa o nome do arquivo de favorito


        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        '----------------------------------------------------------------------------------------------------------------------------------


    End Function

    Private Sub proc_clicar_sub_item_de_favorito(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento clicar no subitem do favorito
        On Error Resume Next

        Dim V_ITEM As ButtonItem = DirectCast(sender, ButtonItem) 'Novo item

        Dim V_VALOR_DO_ITEM As String = V_ITEM.Tooltip 'Obtendo o valor do item






        'Abrindo pagina de favorito agora -------------------------------------------------------------------------------------------------------------------------

        If (V_VALOR_DO_ITEM <> Nothing) Or (V_VALOR_DO_ITEM <> "") Then


            proc_navegar(V_VALOR_DO_ITEM, v_tipo_de_motor_layout_engine_em_uso_agora, v_qual_motor_esta_em_uso) 'NAVEGA NO SITE SOLICITADO PELO USUARIO


        End If

        '----------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_listar_pastas_raizes() 'Lista todas as pastas raizes
        On Error Resume Next

        Dim v_lista_de_sub_diretorios As System.Collections.ObjectModel.ReadOnlyCollection(Of String) 'Listagem de sub-diretorios

        Dim v_contador As Integer 'Contador de looping

        Dim v_quantidade_de_pastas As Integer 'Informa a quantidade de pastas

        Dim v_nome_da_pasta_a_adicionar As Array 'Informa o nome da pasta a ser adicionada

        Dim v_separador As String = "\" 'Separador do array






        'Inicializando -------------------------------------------------------------------------------------------------------------------------------------

        v_lista_de_sub_diretorios = My.Computer.FileSystem.GetDirectories(V_PASTA_DE_FAVORITOS, FileIO.SearchOption.SearchTopLevelOnly)

        v_contador = 0 'Contador de looping

        v_quantidade_de_pastas = v_lista_de_sub_diretorios.Count - 1 'Informa a quantidade de pastas

        ButtonItem103.SubItems.Clear() 'Limpando lista anterior

        '---------------------------------------------------------------------------------------------------------------------------------------------------




        'Varrendo -------------------------------------------------------------------------------------------------------------------------

        For v_contador = v_contador To v_quantidade_de_pastas




            'Adicionando ------------------------------------------------------------------------------------------------------------------

            v_nome_da_pasta_a_adicionar = Split(v_lista_de_sub_diretorios(v_contador), v_separador) 'Nome da pasta

            Dim OBJ_BOTAO_X1 As New DevComponents.DotNetBar.ButtonItem 'Novo botão de item

            OBJ_BOTAO_X1.Text = v_nome_da_pasta_a_adicionar(v_nome_da_pasta_a_adicionar.Length - 1) 'Obtendo o nome do botao

            OBJ_BOTAO_X1.Image = LST_3.Images.Item(6) 'Setando a imagem

            ButtonItem103.SubItems.Add(OBJ_BOTAO_X1) 'Adicionando pasta...

            '------------------------------------------------------------------------------------------------------------------------------




            'Adicionando favoritos das pastas agora ---------------------------------------------------------------------------------------

            Dim V_QUANT_DE_FAVORITOS_DENTRO_DE_PASTA As Integer = func_listar_favoritos_no_menu_favoritos_sub_pastas(v_nome_da_pasta_a_adicionar(v_nome_da_pasta_a_adicionar.Length - 1), True, 0) 'Listar todos os favorítos do menu favoritos e suas subpastas

            Dim V_CONTADOR_2 As Integer = 0 'Contador de looping




            'Adicionando os favoritos agora -----------------------------------------------------------------------------------------------

            For V_CONTADOR_2 = V_CONTADOR_2 To V_QUANT_DE_FAVORITOS_DENTRO_DE_PASTA


                Dim OBJ_BOTAO_X2 As New DevComponents.DotNetBar.ButtonItem 'Novo botão de item

                Dim V_VALOR_DO_ARQUIVO_DE_FAVORITO As String 'Valor do arquivo de favorito

                Dim V_END_DO_ARQUIVO As String = V_PASTA_DE_FAVORITOS & "\" & v_nome_da_pasta_a_adicionar(v_nome_da_pasta_a_adicionar.Length - 1) & "\" & func_listar_favoritos_no_menu_favoritos_sub_pastas(v_nome_da_pasta_a_adicionar(v_nome_da_pasta_a_adicionar.Length - 1), False, V_CONTADOR_2) & ".txt" 'Obtem o endereço do arquivo de favorito






                OBJ_BOTAO_X2.Text = func_listar_favoritos_no_menu_favoritos_sub_pastas(v_nome_da_pasta_a_adicionar(v_nome_da_pasta_a_adicionar.Length - 1), False, V_CONTADOR_2) 'Listar todos os favorítos do menu favoritos e suas subpastas

                V_VALOR_DO_ARQUIVO_DE_FAVORITO = func_ler_valor(V_END_DO_ARQUIVO) 'Retorna o valor do arquivo lido 

                OBJ_BOTAO_X2.Tooltip = V_VALOR_DO_ARQUIVO_DE_FAVORITO 'Tooltip do favorito

                AddHandler OBJ_BOTAO_X2.Click, AddressOf proc_clicar_sub_item_de_favorito  'Evento clicar no subitem do favorito

                OBJ_BOTAO_X2.Image = LST_3.Images.Item(5) 'Setando a imagem

                OBJ_BOTAO_X1.SubItems.Add(OBJ_BOTAO_X2) 'Adicionando pasta...


            Next

            '------------------------------------------------------------------------------------------------------------------------------




            '------------------------------------------------------------------------------------------------------------------------------




        Next

        '----------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub proc_listar_favoritos_no_menu_favoritos() 'Lista os favoritos no menu de favoritos
        On Error Resume Next

        proc_listar_pastas_raizes() 'Lista todas as pastas raizes







    End Sub

    '--------------------------------------------------------------------------------------------------------------------------------------------------------------
















    Private Sub ButtonItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem48.Click
        On Error Resume Next

        proc_chamar_painel_de_controle() 'Chamar o painel de controle

    End Sub

    Private Sub ButtonItem83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem83.Click
        On Error Resume Next

        proc_salvar_valor(v_esquema_de_aba_1, V_ARQ_CONFIG_ESQUEMA_DE_ABA) 'Salva a configuração

        proc_aplicar_tipo_de_aba_Modulo_de_aplicar_configuracoes() 'Aplica o tipo de aba

    End Sub

    Private Sub ButtonItem84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem84.Click
        On Error Resume Next

        proc_salvar_valor(v_esquema_de_aba_2, V_ARQ_CONFIG_ESQUEMA_DE_ABA) 'Salva a configuração

        proc_aplicar_tipo_de_aba_Modulo_de_aplicar_configuracoes() 'Aplica o tipo de aba

    End Sub

    Private Sub ButtonItem85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem85.Click
        On Error Resume Next

        proc_salvar_valor(v_esquema_de_aba_3, V_ARQ_CONFIG_ESQUEMA_DE_ABA) 'Salva a configuração

        proc_aplicar_tipo_de_aba_Modulo_de_aplicar_configuracoes() 'Aplica o tipo de aba

    End Sub

    Private Sub ButtonItem86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem86.Click
        On Error Resume Next

        proc_salvar_valor(v_esquema_de_aba_4, V_ARQ_CONFIG_ESQUEMA_DE_ABA) 'Salva a configuração

        proc_aplicar_tipo_de_aba_Modulo_de_aplicar_configuracoes() 'Aplica o tipo de aba

    End Sub

    Private Sub ButtonItem87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem87.Click
        On Error Resume Next

        proc_salvar_valor(v_esquema_de_aba_5, V_ARQ_CONFIG_ESQUEMA_DE_ABA) 'Salva a configuração

        proc_aplicar_tipo_de_aba_Modulo_de_aplicar_configuracoes() 'Aplica o tipo de aba

    End Sub

    Private Sub ButtonItem88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem88.Click
        On Error Resume Next

        proc_salvar_valor(v_esquema_de_aba_6, V_ARQ_CONFIG_ESQUEMA_DE_ABA) 'Salva a configuração

        proc_aplicar_tipo_de_aba_Modulo_de_aplicar_configuracoes() 'Aplica o tipo de aba

    End Sub

    Private Sub ButtonItem89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem89.Click
        On Error Resume Next

        proc_salvar_valor(v_esquema_de_aba_1, V_ARQ_CONFIG_ESQUEMA_DE_ABA) 'Salva a configuração

        proc_aplicar_tipo_de_aba_Modulo_de_aplicar_configuracoes() 'Aplica o tipo de aba

    End Sub

    Private Sub ButtonItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem65.Click
        On Error Resume Next

        proc_salvar_valor(v_barra_de_navegacao_exibir, V_ARQ_CONFIG_BARRA_DE_NAVEGACAO) 'Salva a configuração

        proc_barra_de_navegacao_Modulo_de_aplicar_configuracoes() 'Barra de navegação exibir ou não

    End Sub

    Private Sub ButtonItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem66.Click
        On Error Resume Next

        proc_salvar_valor(False, V_ARQ_CONFIG_BARRA_DE_NAVEGACAO) 'Salva a configuração

        proc_barra_de_navegacao_Modulo_de_aplicar_configuracoes() 'Barra de navegação exibir ou não

    End Sub

    Private Sub ButtonItem67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem67.Click
        On Error Resume Next

        proc_salvar_valor(v_barra_de_staus_exibir, V_ARQ_CONFIG_BARRA_DE_STATUS) 'Salva a configuração

        proc_barra_de_status_Modulo_de_aplicar_configuracoes() 'Exibe ou não a barra de status

    End Sub

    Private Sub ButtonItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem68.Click
        On Error Resume Next

        proc_salvar_valor(False, V_ARQ_CONFIG_BARRA_DE_STATUS) 'Salva a configuração

        proc_barra_de_status_Modulo_de_aplicar_configuracoes() 'Exibe ou não a barra de status

    End Sub

    Private Sub ButtonItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem41.Click
        On Error Resume Next

        proc_chamar_favoritos(True, False) 'Chama a janela de favoritos

    End Sub

    Private Sub ButtonItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem40.Click
        On Error Resume Next

        proc_chamar_favoritos(False, False) 'Chama a janela de favoritos

    End Sub

    Private Sub ButtonItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem38.Click
        On Error Resume Next

        proc_chamar_historico() 'Chama a janela de historico

    End Sub

    Private Sub ButtonItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem43.Click
        On Error Resume Next

        proc_chamar_novo_download() 'Chamar a janela de novo download

    End Sub

    Private Sub ButtonItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem46.Click
        On Error Resume Next

        proc_chamar_limpador_de_arquivos() 'Limpador de arquivos janela chamar

    End Sub

    Private Sub ButtonItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem25.Click
        On Error Resume Next

        proc_barra_de_encontrar_exibir(True) 'Exibe a barra de encontrar

    End Sub

    Private Sub ButtonX12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX12.Click
        On Error Resume Next

        proc_barra_de_encontrar_exibir(False) 'Exibe a barra de encontrar

    End Sub

    Private Sub ButtonItem81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem81.Click
        On Error Resume Next

        proc_tela_cheia_ativar_modo(True) 'Ativa o modo de tela cheia

    End Sub

    Private Sub ButtonItem82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem82.Click
        On Error Resume Next

        proc_tela_cheia_ativar_modo(False) 'Ativa o modo de tela cheia

    End Sub

    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        On Error Resume Next

        proc_adicionador_de_nova_aba_e_motor(True) 'Adiciona o motor geckofx ou não. True para sim e false para nao

    End Sub

    Private Sub TabControl1_TabRemoved(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.TabRemoved
        On Error Resume Next

        Dim v_nome_da_tab_removida As String 'Informa o nome da tab removida






        'Oculta a barra de enderecos -------------------------------------------------------------------------------

        Proc_exibir_ou_ocultar_barra_de_progresso(False) 'Oculta ou exibe a barra de carregamento

        '-----------------------------------------------------------------------------------------------------------




        'Informa a quantidade de abas abertas -----------------------------------------------------------------------

        v_quantidade_de_abas_abertas = TabControl1.Tabs.Count 'Quantidade de abas

        '------------------------------------------------------------------------------------------------------------




        'Inicializando variáveis ------------------------------------------------------------------------------------

        v_nome_da_tab_removida = TabControl1.SelectedTab.Name 'Obtendo o nome da tab selecionada

        '------------------------------------------------------------------------------------------------------------




        'Informando qual aba foi fechada -----------------------------------------------------------------------------------------------------------------

        proc_atualize_aba_disponivel(v_nome_da_tab_removida) 'Toda vez que uma tab for fechada atualizar para adicionar nova aba posteriormente.

        '-------------------------------------------------------------------------------------------------------------------------------------------------




        'Removendo ligação entre painel e motor ----------------------------------------------------------------------------------------------------------

        proc_remove_ligacao_entre_paineis_de_motores(v_nome_da_tab_removida) 'Remove a ligação entre paineis dos motores

        '-------------------------------------------------------------------------------------------------------------------------------------------------




        'Escolhe qual motor esta aberto para ser fechado ----------------------------------------------------------------------------

        proc_fechar_motor_geckofx_ou_trident(v_nome_da_tab_removida) 'Escolhe qual motor fechar

        '----------------------------------------------------------------------------------------------------------------------------




        'Remove a referencia da aba na barra de status --------------------------------------------------------------------------------------------------------

        proc_remove_referencia_aba_barra_de_status(v_nome_da_tab_removida) 'Toda vez que uma tab for fechada atualizar a referencia da aba na barra de status

        '------------------------------------------------------------------------------------------------------------------------------------------------------







    End Sub

    Private Sub TabControl1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.TabStripTabChangedEventArgs) Handles TabControl1.SelectedTabChanged
        On Error Resume Next

        proc_atualizar_propriedades_gerais_evento_trocar_de_aba_completo() 'Ao trocar de aba alterar propriedades

    End Sub

    Private Sub ButtonX13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX13.Click
        On Error Resume Next

        proc_adicionador_de_nova_aba_e_motor(False) 'Adiciona o motor geckofx ou não. True para sim e false para nao

    End Sub

    Private Sub ButtonX8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX8.Click
        On Error Resume Next

        proc_abrir_pagina_inicial() 'Abre a página inicial agora

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        On Error Resume Next

        proc_voltar_pagina_anterior() 'Volta uma pagina anterior

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        On Error Resume Next

        proc_avancar_pagina_anterior() 'Avança uma pagina posterior

    End Sub

    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        On Error Resume Next

        proc_atualiza_a_pagina() 'Atualiza a página em visualização

    End Sub

    Private Sub ButtonX7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX7.Click
        On Error Resume Next

        proc_para_carregamento_pagina_visualizacao() 'Para o carregamento da página em visualização

    End Sub

    Private Sub TabControl1_TabItemOpen(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.TabItemOpen
        On Error Resume Next



        'Oculta a barra de enderecos -------------------------------------------------------------------------------

        Proc_exibir_ou_ocultar_barra_de_progresso(False) 'Oculta ou exibe a barra de carregamento

        '-----------------------------------------------------------------------------------------------------------



        'Informa a quantidade de abas abertas -----------------------------------------------------------------------

        v_quantidade_de_abas_abertas = TabControl1.Tabs.Count 'Quantidade de abas

        '------------------------------------------------------------------------------------------------------------



        'Selecionando a aba adicionada ------------------------------------------------------------------------------

        TabControl1.SelectedTabIndex = v_quantidade_de_abas_abertas - 1 'Selecionando...

        '------------------------------------------------------------------------------------------------------------



        'Movendo o foco para a barra de endereços -------------------------------------------------------------------

        ComboBoxEx1.Text = "" 'Sem texto

        ComboBoxEx1.Focus() 'Movendo o foco

        '------------------------------------------------------------------------------------------------------------







    End Sub

    Private Sub ButtonItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem10.Click
        On Error Resume Next

        proc_adicionador_de_nova_aba_e_motor(True) 'Adiciona o motor geckofx ou não. True para sim e false para nao

    End Sub

    Private Sub ButtonItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem11.Click
        On Error Resume Next

        proc_fechar_aba_via_menu() 'Fechar aba via menu

    End Sub

    Private Sub ButtonItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem39.Click
        On Error Resume Next

        proc_abrir_pagina_inicial() 'Abre a página inicial agora

    End Sub

    Private Sub ButtonItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem33.Click
        On Error Resume Next

        proc_exibir_codigo_fonte_da_pagina() 'Exibe o codigo fonte da pagina

    End Sub

    Private Sub ButtonItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem31.Click
        On Error Resume Next

        proc_atualiza_a_pagina() 'Atualiza a página em visualização

    End Sub

    Private Sub ButtonItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem30.Click
        On Error Resume Next

        proc_para_carregamento_pagina_visualizacao() 'Para o carregamento da página em visualização

    End Sub

    Private Sub ButtonItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem36.Click
        On Error Resume Next

        proc_voltar_pagina_anterior() 'Volta uma pagina anterior

    End Sub

    Private Sub ButtonItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem37.Click
        On Error Resume Next

        proc_avancar_pagina_anterior() 'Avança uma pagina posterior

    End Sub

    Private Sub ButtonItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem13.Click
        On Error Resume Next

        proc_salvar_pagina() 'Salva a página em visualização

    End Sub

    Private Sub ButtonItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem12.Click
        On Error Resume Next

        proc_abrir_pagina_salva() 'Abre a página salva no HD

    End Sub

    Private Sub ButtonItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem14.Click
        On Error Resume Next

        proc_configurar_pagina() 'Configurar página

    End Sub

    Private Sub ButtonItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem15.Click
        On Error Resume Next

        'Mensagem ao usuario -------------------------------------------------------------------------------------------

        Dim OBJ_JANELA As New FRM_MENSAGENS_AO_USUARIO 'Janela de mensagem

        OBJ_JANELA.v_mensagem_FRM_MENSAGENS_AO_USUARIO = V_MS_12 'Mensagem

        OBJ_JANELA.v_tipo_de_mensagem_repassada = v_tipo_ms_1 'Tipo de mensagem

        OBJ_JANELA.TopMost = True 'Topmost ativado

        OBJ_JANELA.Show() 'Abrindo...

        OBJ_JANELA.Refresh() 'Atualizando...

        '---------------------------------------------------------------------------------------------------------------


        'Visualizando impressao ------------------------------------

        proc_visualizar_impressao() 'Visualizar impressão

        '-----------------------------------------------------------


        'Fechando janela -----------------

        OBJ_JANELA.Close() 'Fechando...

        '---------------------------------


    End Sub

    Private Sub m_PrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles m_PrintDocument.PrintPage
        On Error Resume Next


        'Modo paisagem ativado -----------------------------------------------------------------------------------------

        e.PageSettings.Landscape = True 'Modo ativado

        '---------------------------------------------------------------------------------------------------------------




        'Verificando contador de paginas -------------------------------------------------------------------------------

        If (V_CONTADOR_DE_PAGINAS_A_IMPRIMIR = V_QUANTIDADE_DE_ITENS_VISUALIZAR_IMPRESSAO) Then


            e.HasMorePages = False 'Nao usar mais paginas


            'Limpar itens usados ---------------------------------------------------------------------------------------

            V_QUANTIDADE_DE_ITENS_VISUALIZAR_IMPRESSAO = 0 'Zerando...

            V_CONTADOR_DE_PAGINAS_A_IMPRIMIR = 0 'Zerando...

            '-----------------------------------------------------------------------------------------------------------


            Exit Sub 'Saindo...


        End If

        '---------------------------------------------------------------------------------------------------------------




        'Obtendo imagem da lista ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        Dim OBJ_IMG_TEMP_IMPRIMIR_VISUALIZAR_IMPRESSAO As Image = Image.FromFile(V_PASTA_DE_CONFIGURACAO & "\" & v_nome_generico_de_imagem_de_impressao & V_CONTADOR_DE_PAGINAS_A_IMPRIMIR & v_extencao_2) 'Obtendo...

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



        'Montando coordenadas da imagem -----------------------------------------------------------------------------------------------------------------------------------------------------

        Dim x As Integer = e.MarginBounds.X + (e.MarginBounds.Width - OBJ_IMG_TEMP_IMPRIMIR_VISUALIZAR_IMPRESSAO.Width) \ 2 'Montando coordenadas

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        'Gerando grafico de impressao ----------------------------------------------------------------------------------

        e.Graphics.DrawImage(OBJ_IMG_TEMP_IMPRIMIR_VISUALIZAR_IMPRESSAO, x, 0) 'Gerando grafico

        '---------------------------------------------------------------------------------------------------------------


        'Proxima pagina ----------------------------

        e.HasMorePages = True 'Proxima pagina

        '-------------------------------------------


        'Atualizando contador ------------------------------------------------------------------------------------------

        V_CONTADOR_DE_PAGINAS_A_IMPRIMIR = V_CONTADOR_DE_PAGINAS_A_IMPRIMIR + 1 'Atualizando...

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub ButtonItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem16.Click
        On Error Resume Next

        proc_imprimir_a_pagina_FRM_NAVEGACAO() 'Procedimento para imprimir a pagina

    End Sub

    Private Sub ButtonItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem18.Click
        On Error Resume Next

        proc_desfazer_acao() 'Desfazer ação

    End Sub

    Private Sub ButtonItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem19.Click
        On Error Resume Next

        proc_refazer_acao() 'Refazer ação

    End Sub

    Private Sub ButtonItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem20.Click
        On Error Resume Next

        proc_recortar_acao() 'Recortar ação

    End Sub

    Private Sub ButtonItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem21.Click
        On Error Resume Next

        proc_copiar_acao() 'Copiar ação

    End Sub

    Private Sub ButtonItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem22.Click
        On Error Resume Next

        proc_colar_acao() 'Colar ação

    End Sub

    Private Sub ButtonItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem23.Click
        On Error Resume Next

        proc_deletar_acao() 'Deletar ação

    End Sub

    Private Sub ButtonItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem24.Click
        On Error Resume Next

        proc_selecionar_tudo_acao() 'Selecionar tudo ação

    End Sub

    Private Sub TextBoxX1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxX1.KeyDown
        On Error Resume Next


        If (e.KeyCode = Keys.Enter) Then


            e.SuppressKeyPress = True 'Não exibir o beep


            proc_encontrar_sentenca(TextBoxX1.Text) 'Encontra a frase especificada


        End If

    End Sub

    Private Sub ButtonX10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX10.Click
        On Error Resume Next

        proc_encontrar_sentenca(TextBoxX1.Text) 'Encontra a frase especificada

    End Sub

    Private Sub ButtonX11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX11.Click
        On Error Resume Next

        TextBoxX1.Clear() 'Limpando caixa de texto

    End Sub

    Private Sub ButtonItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem26.Click
        On Error Resume Next

        proc_barra_de_encontrar_exibir(True) 'Exibe a barra de encontrar

        proc_encontrar_sentenca(TextBoxX1.Text) 'Encontra a frase especificada

    End Sub

    Private Sub ButtonItem70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem70.Click
        On Error Resume Next

        proc_chamar_favoritos(False, False) 'Chama a janela de favoritos

    End Sub

    Private Sub ButtonItem69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem69.Click
        On Error Resume Next

        proc_chamar_favoritos(True, False) 'Chama a janela de favoritos

    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        On Error Resume Next

        proc_chamar_favoritos(False, False) 'Chama a janela de favoritos

    End Sub

    Private Sub ButtonItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem44.Click
        On Error Resume Next

        proc_exibir_lista_de_downloads() 'Exibir lista de downloads

    End Sub

    Private Sub ButtonItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem45.Click
        On Error Resume Next

        proc_exibir_propriedades_da_pagina() 'Exibe as propriedades da página

    End Sub

    Private Sub ComboBoxEx2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxEx2.KeyDown
        On Error Resume Next

        If (e.KeyCode = Keys.Enter) Then 'Ao pressionar enter

            e.SuppressKeyPress = True 'Desabilitar o beep

            proc_pesquisar(ComboBoxEx2.Text) 'Pesquisar conteúdo informado

        End If

    End Sub

    Private Sub ButtonItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem55.Click
        On Error Resume Next

        V_VAL_OPCAO_DE_PESQUISA_NA_WEB = 0 'Definindo pesquisa

    End Sub

    Private Sub ButtonItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem56.Click
        On Error Resume Next

        V_VAL_OPCAO_DE_PESQUISA_NA_WEB = 1 'Definindo pesquisa

        ButtonX9.Image = ButtonItem56.Image 'Igualando imagem

    End Sub

    Private Sub ButtonItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem57.Click
        On Error Resume Next

        V_VAL_OPCAO_DE_PESQUISA_NA_WEB = 2 'Definindo pesquisa

        ButtonX9.Image = ButtonItem57.Image 'Igualando imagem

    End Sub

    Private Sub ButtonItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem58.Click
        On Error Resume Next

        V_VAL_OPCAO_DE_PESQUISA_NA_WEB = 3 'Definindo pesquisa

        ButtonX9.Image = ButtonItem58.Image 'Igualando imagem

    End Sub

    Private Sub ButtonItem59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem59.Click
        On Error Resume Next

        V_VAL_OPCAO_DE_PESQUISA_NA_WEB = 4 'Definindo pesquisa

        ButtonX9.Image = ButtonItem59.Image 'Igualando imagem

    End Sub

    Private Sub ButtonItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem60.Click
        On Error Resume Next

        V_VAL_OPCAO_DE_PESQUISA_NA_WEB = 5 'Definindo pesquisa

        ButtonX9.Image = ButtonItem60.Image 'Igualando imagem

    End Sub

    Private Sub ButtonItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem61.Click
        On Error Resume Next

        V_VAL_OPCAO_DE_PESQUISA_NA_WEB = 6 'Definindo pesquisa

        ButtonX9.Image = ButtonItem61.Image 'Igualando imagem

    End Sub

    Private Sub ButtonItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem62.Click
        On Error Resume Next

        V_VAL_OPCAO_DE_PESQUISA_NA_WEB = 7 'Definindo pesquisa

        ButtonX9.Image = ButtonItem62.Image 'Igualando imagem

    End Sub

    Private Sub ButtonItem90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem90.Click
        On Error Resume Next

        V_VAL_OPCAO_DE_PESQUISA_NA_WEB = 8 'Definindo pesquisa

        ButtonX9.Image = ButtonItem90.Image 'Igualando imagem

    End Sub

    Private Sub ButtonX9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX9.Click
        On Error Resume Next

        proc_pesquisar(ComboBoxEx2.Text) 'Pesquisar conteúdo informado

    End Sub

    Private Sub ButtonItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem42.Click
        On Error Resume Next

        proc_pesquisar(ComboBoxEx2.Text) 'Pesquisar conteúdo informado

    End Sub

    Private Sub FRM_NAVEGACAO_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next


        'Verifica se há abas abertas ou nao ---------------------------------------------------------------------------------------------------

        proc_sair_informar_abas_abertas() 'Informa ao sair se há abas abertas

        '--------------------------------------------------------------------------------------------------------------------------------------




        'Salvando as configurações se for sair realmente --------------------------------------------------------------------------------------

        If (v_pode_encerrar_formulario_principal = False) Then


            proc_salvar_configuracoes_e_informacoes_ao_sair_Modulo_salvar_configuracoes_ao_sair() 'Salva todas as configuraçoes ao sair


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------




        'Sai ou nao do formulario de navegação --------------------------------------------------

        e.Cancel = v_pode_encerrar_formulario_principal 'Sai ou nao

        '----------------------------------------------------------------------------------------


    End Sub

    Private Sub ComboBoxEx1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxEx1.KeyDown
        On Error Resume Next


        'Ao pressionar enter navegar -------------------------------------------------------------------------------------------------------

        If (e.KeyCode = Keys.Enter) And (ComboBoxEx1.Text <> "") Then




            'Não permite o beep ----------------------------------------------------------------------------------------

            e.SuppressKeyPress = True 'Não permite exibir o beep

            '-----------------------------------------------------------------------------------------------------------




            'Abrindo site agora --------------------------------------------------------------------------------------------------------------------------

            proc_navegar(ComboBoxEx1.Text, v_tipo_de_motor_layout_engine_em_uso_agora, v_qual_motor_esta_em_uso) 'NAVEGA NO SITE SOLICITADO PELO USUARIO

            '---------------------------------------------------------------------------------------------------------------------------------------------




            'Oculta a aba de recurso autocompletar com imagens -------------------------------------------------------------------------------------------

            proc_ocultar_aba_de_historico_autocompletar(False) 'Habilita ou desabilita a aba de historico

            '---------------------------------------------------------------------------------------------------------------------------------------------




            'Oculta o menu de recurso autocompletar ------------------------------------------------------------------------------------------------------

            proc_ocultar_menu_autocompletar_barra_end_navegacao() 'Oculta o menu de autocompletar na barra de endereços

            '---------------------------------------------------------------------------------------------------------------------------------------------




            'Saindo do procedimento ------------------------------------------------------------------------------------

            Exit Sub 'Saindo do procedimento

            '-----------------------------------------------------------------------------------------------------------




        End If

        '-----------------------------------------------------------------------------------------------------------------------------------




        'Verifica se usa o recurso de autocompletar ----------------------------------------------------------------------

        If (V_VAL_CONFIG_USAR_RECURSO_AUTO_COMPLETAR_BARRA_DE_END = False) Then

            Exit Sub 'Saindo...

        End If

        '-----------------------------------------------------------------------------------------------------------------




        'Nao permite trabalhar com valores nulos -------------------------------------------------------------------------

        If (ComboBoxEx1.Text = "") And (e.KeyCode = Keys.Enter) Then




            'Limpando itens e liberando ultima aba aberta ----------------------------------------------------------------------------------------------------------

            proc_ocultar_menu_autocompletar_barra_end_navegacao() 'Oculta o menu de autocompletar na barra de endereços

            proc_ocultar_aba_de_historico_autocompletar(False) 'Habilita ou desabilita a aba de historico

            '-----------------------------------------------------------------------------------------------------------




            'Saindo ------------------

            Exit Sub 'Saindo...

            '-------------------------




        End If

        '---------------------------------------------------------------------------------------------------------------




        'Só executar os procedimentos de recurso autocompletar se a tecla nao for enter --------------------------------------------------------

        If (e.KeyCode <> Keys.Enter) Then



            'Recurso autocompletar -------------------------------------------------------------------------------------------------------------

            proc_executador_auto_completar(True, ComboBoxEx1.Text) 'Executador do autocompletar

            '-----------------------------------------------------------------------------------------------------------------------------------



            'Exibindo a aba de autocompletar com imagens ---------------------------------------------------------------------------------------

            TabControl1.SelectedTab = TabItem5 'Selecionando a aba de historico de imagens de site

            proc_ocultar_aba_de_historico_autocompletar(True) 'Habilita ou desabilita a aba de historico

            '-----------------------------------------------------------------------------------------------------------------------------------



        End If

        '-----------------------------------------------------------------------------------------------------------------------------------




    End Sub

    Private Sub ButtonX14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX14.Click
        On Error Resume Next


        'Verifica se o modo geek está ativado -----------------------------------------------------------------

        If (V_VAL_CONFIG_MODO_GEEK_ATIVADO = True) Then


            ComboBoxEx1.Text = "Modo Geek ativado, para exibir os itens desative o modo Geek." 'Texto

            Exit Sub 'Saindo...


        End If

        '-------------------------------------------------------------------------------------------------------




        'Exibir o menu autocompletar sem filtro --------------------------------------------------------------------------------------------

        proc_executador_auto_completar(False, Nothing) 'Executador do autocompletar

        '-----------------------------------------------------------------------------------------------------------------------------------




        'Exibindo a aba de autocompletar com imagens ---------------------------------------------------------------------------------------

        TabControl1.SelectedTab = TabItem5 'Selecionando a aba de historico de imagens de site

        proc_ocultar_aba_de_historico_autocompletar(True) 'Habilita ou desabilita a aba de historico

        '-----------------------------------------------------------------------------------------------------------------------------------




    End Sub

    Private Sub ComboBoxEx1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ComboBoxEx1.MouseClick
        On Error Resume Next

        proc_ocultar_menu_autocompletar_barra_end_navegacao() 'Oculta o menu de autocompletar na barra de endereços

    End Sub

    Private Sub ButtonX14_PopupShowing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX14.PopupShowing
        On Error Resume Next

        proc_executador_auto_completar(False, Nothing) 'Executador do autocompletar

    End Sub

    Private Sub mnu_autoCompletar_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles mnu_autoCompletar.ItemClicked
        On Error Resume Next

        Dim v_site_a_ser_aberto As String = e.ClickedItem.ToolTipText 'Obtendo o texto de tooltip






        'Abrindo site agora --------------------------------------------------------------------------------------------------------------------------

        proc_navegar(v_site_a_ser_aberto, v_tipo_de_motor_layout_engine_em_uso_agora, v_qual_motor_esta_em_uso) 'NAVEGA NO SITE SOLICITADO PELO USUARIO

        '---------------------------------------------------------------------------------------------------------------------------------------------


        'Ocultando o menu agora ----------------------------------------------------------------------------------------

        proc_ocultar_menu_autocompletar_barra_end_navegacao() 'Oculta o menu de autocompletar na barra de endereços

        '---------------------------------------------------------------------------------------------------------------


        'Ocultar aba de historico de imagens autocompletar -------------------------------------------------------------

        proc_ocultar_aba_de_historico_autocompletar(False) 'Habilita ou desabilita a aba de historico

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub FRM_NAVEGACAO_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        On Error Resume Next


        'Permitir o autoclose ------------------------------------------------------------------------------------------

        mnu_autoCompletar.AutoClose = True 'Permitindo...

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub FRM_NAVEGACAO_ResizeEnd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeEnd
        On Error Resume Next


        'Só executar o procurar se o menu ja estiver aberto ------------------------------------------

        If (mnu_autoCompletar.Visible = False) Then


            Exit Sub 'Saindo...


        End If

        '--------------------------------------------------------------------------------------------


        'Buscando -----------------------------------------------------------------------------------

        proc_executador_auto_completar(True, ComboBoxEx1.Text) 'Executador do autocompletar

        '--------------------------------------------------------------------------------------------


    End Sub

    Private Sub AbrirPáginaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirPáginaToolStripMenuItem.Click
        On Error Resume Next

        Dim v_url_a_abrir As String = Nothing 'Informa o endereço de url a ser aberto






        'Backup fazer --------------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram() 'Backup do conteúdo da ram

        '---------------------------------------------------------------------------------------------------------------




        'Copiando o endereço a ser aberto ------------------------------------------------------------------------------

        GECK_MOTOR_DE_AUTO_COMPLETAR_HIST.CopyLinkLocation() 'Copiando o link do item selecionado

        v_url_a_abrir = My.Computer.Clipboard.GetText 'Obtendo valor

        '---------------------------------------------------------------------------------------------------------------




        'Abrindo site agora -------------------------------------------------------------------------------------------------------------------------------------------

        If (v_url_a_abrir = Nothing) Or (v_url_a_abrir = "") Then

            Exit Sub 'Saindo

        End If

        proc_navegar(v_url_a_abrir, v_tipo_de_motor_layout_engine_em_uso_agora, v_qual_motor_esta_em_uso) 'NAVEGA NO SITE SOLICITADO PELO USUARIO

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Backup restaurar ----------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram_restaurar() 'Backup do conteúdo da ram restaurar

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub AbrirEmNovaAbaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirEmNovaAbaToolStripMenuItem.Click
        On Error Resume Next

        Dim v_url_a_abrir As String = Nothing 'Informa o endereço de url a ser aberto






        'Backup fazer --------------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram() 'Backup do conteúdo da ram

        '---------------------------------------------------------------------------------------------------------------




        'Copiando o endereço a ser aberto ------------------------------------------------------------------------------

        GECK_MOTOR_DE_AUTO_COMPLETAR_HIST.CopyLinkLocation() 'Copiando o link do item selecionado

        v_url_a_abrir = My.Computer.Clipboard.GetText 'Obtendo valor

        '---------------------------------------------------------------------------------------------------------------




        'Adicionando nova aba ------------------------------------------------------------------------------------------

        If (v_url_a_abrir = Nothing) Or (v_url_a_abrir = "") Then

            Exit Sub 'Saindo

        End If

        proc_adicionador_de_nova_aba_e_motor(True) 'Adiciona o motor geckofx ou não. True para sim e false para nao

        '---------------------------------------------------------------------------------------------------------------




        'Abrindo site agora -------------------------------------------------------------------------------------------------------------------------------------------

        proc_navegar(v_url_a_abrir, v_tipo_de_motor_layout_engine_em_uso_agora, v_qual_motor_esta_em_uso) 'NAVEGA NO SITE SOLICITADO PELO USUARIO

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Backup restaurar ----------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram_restaurar() 'Backup do conteúdo da ram restaurar

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub ColocarNosFavorítosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColocarNosFavorítosToolStripMenuItem.Click
        On Error Resume Next

        Dim OBJ_JANELA As New FRM_FAVORITOS 'Nova janela de favoritos

        Dim v_url_a_abrir As String = Nothing 'Informa o endereço de url a ser aberto

        Dim v_titulo As String = Nothing 'Informa o titulo do link






        'Backup fazer --------------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram() 'Backup do conteúdo da ram

        '---------------------------------------------------------------------------------------------------------------




        'Copiando o endereço a ser aberto ------------------------------------------------------------------------------

        GECK_MOTOR_DE_AUTO_COMPLETAR_HIST.CopyLinkLocation() 'Copiando o link do item selecionado

        v_url_a_abrir = My.Computer.Clipboard.GetText 'Obtendo valor

        '---------------------------------------------------------------------------------------------------------------




        'Não permite valor nulo ----------------------------------------------------------------------------------------

        If (v_url_a_abrir = Nothing) Or (v_url_a_abrir = "") Then

            Exit Sub 'Saindo

        End If

        '---------------------------------------------------------------------------------------------------------------




        'Obtendo o titulo do link --------------------------------------------------------------------------------------

        v_titulo = func_retorne_titulo_por_url_de_historico_atual(v_url_a_abrir) 'Retorna o titulo da url pelo valor da url

        '---------------------------------------------------------------------------------------------------------------




        'Definindo propriedades da janela ------------------------------------------------------------------------------

        OBJ_JANELA.Show() 'Abrindo janela

        OBJ_JANELA.txt_favorito_endereco.Text = v_url_a_abrir 'Url

        OBJ_JANELA.txt_titulo.Text = v_titulo 'Titulo

        OBJ_JANELA.TopMost = True 'Topmost ativado

        '---------------------------------------------------------------------------------------------------------------




        'Backup restaurar ----------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram_restaurar() 'Backup do conteúdo da ram restaurar

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub DefininaComoPáginaInicialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefininaComoPáginaInicialToolStripMenuItem.Click
        On Error Resume Next

        Dim v_url_a_abrir As String = Nothing 'Informa o endereço de url a ser aberto






        'Backup fazer --------------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram() 'Backup do conteúdo da ram

        '---------------------------------------------------------------------------------------------------------------




        'Copiando o endereço a ser aberto ------------------------------------------------------------------------------

        GECK_MOTOR_DE_AUTO_COMPLETAR_HIST.CopyLinkLocation() 'Copiando o link do item selecionado

        v_url_a_abrir = My.Computer.Clipboard.GetText 'Obtendo valor

        '---------------------------------------------------------------------------------------------------------------




        'Abrindo site agora -------------------------------------------------------------------------------------------------------------------------------------------

        If (v_url_a_abrir = Nothing) Or (v_url_a_abrir = "") Then

            Exit Sub 'Saindo

        End If

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Salvando nova pagina inicial ---------------------------------------------------------------------------------

        proc_salvar_valor(v_url_a_abrir, V_ARQ_CONFIG_PAGINA_INICIAL) 'Salva a configuração

        '--------------------------------------------------------------------------------------------------------------




        'Atualizando variaveis ----------------------------------------------------------------------------------------

        proc_atualizar_valor_de_variaveis() 'Atualiza o valor das variáveis

        '--------------------------------------------------------------------------------------------------------------




        'Backup restaurar ----------------------------------------------------------------------------------------------

        proc_backup_do_conteudo_da_ram_restaurar() 'Backup do conteúdo da ram restaurar

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        On Error Resume Next

        proc_alterar_as_propriedades_de_zoom_no_motor_em_visualizacao(0.25F) 'Altera o valor do zoom na página do motor selecionado

    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        On Error Resume Next

        proc_alterar_as_propriedades_de_zoom_no_motor_em_visualizacao(0.5F) 'Altera o valor do zoom na página do motor selecionado

    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        On Error Resume Next

        proc_alterar_as_propriedades_de_zoom_no_motor_em_visualizacao(0.75F) 'Altera o valor do zoom na página do motor selecionado

    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        On Error Resume Next

        proc_alterar_as_propriedades_de_zoom_no_motor_em_visualizacao(1.0F) 'Altera o valor do zoom na página do motor selecionado

    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        On Error Resume Next

        proc_alterar_as_propriedades_de_zoom_no_motor_em_visualizacao(1.25F) 'Altera o valor do zoom na página do motor selecionado

    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        On Error Resume Next

        proc_alterar_as_propriedades_de_zoom_no_motor_em_visualizacao(1.5F) 'Altera o valor do zoom na página do motor selecionado

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        On Error Resume Next

        proc_alterar_as_propriedades_de_zoom_no_motor_em_visualizacao(1.75F) 'Altera o valor do zoom na página do motor selecionado

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        On Error Resume Next

        proc_alterar_as_propriedades_de_zoom_no_motor_em_visualizacao(2.0F) 'Altera o valor do zoom na página do motor selecionado

    End Sub

    Private Sub ButtonItem73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem73.Click
        On Error Resume Next

        proc_alterar_as_propriedades_de_zoom_no_motor_em_visualizacao(0.25F) 'Altera o valor do zoom na página do motor selecionado

    End Sub

    Private Sub ButtonItem74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem74.Click
        On Error Resume Next

        proc_alterar_as_propriedades_de_zoom_no_motor_em_visualizacao(0.5F) 'Altera o valor do zoom na página do motor selecionado

    End Sub

    Private Sub ButtonItem75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem75.Click
        On Error Resume Next

        proc_alterar_as_propriedades_de_zoom_no_motor_em_visualizacao(0.75F) 'Altera o valor do zoom na página do motor selecionado

    End Sub

    Private Sub ButtonItem76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem76.Click
        On Error Resume Next

        proc_alterar_as_propriedades_de_zoom_no_motor_em_visualizacao(1.0F) 'Altera o valor do zoom na página do motor selecionado

    End Sub

    Private Sub ButtonItem77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem77.Click
        On Error Resume Next

        proc_alterar_as_propriedades_de_zoom_no_motor_em_visualizacao(1.25F) 'Altera o valor do zoom na página do motor selecionado

    End Sub

    Private Sub ButtonItem78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem78.Click
        On Error Resume Next

        proc_alterar_as_propriedades_de_zoom_no_motor_em_visualizacao(1.5F) 'Altera o valor do zoom na página do motor selecionado

    End Sub

    Private Sub ButtonItem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem79.Click
        On Error Resume Next

        proc_alterar_as_propriedades_de_zoom_no_motor_em_visualizacao(1.75F) 'Altera o valor do zoom na página do motor selecionado

    End Sub

    Private Sub ButtonItem80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem80.Click
        On Error Resume Next

        proc_alterar_as_propriedades_de_zoom_no_motor_em_visualizacao(2.0F) 'Altera o valor do zoom na página do motor selecionado

    End Sub

    Private Sub ProgressBarX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBarX1.Click
        On Error Resume Next

        Proc_exibir_ou_ocultar_barra_de_progresso(False) 'Oculta ou exibe a barra de carregamento

    End Sub

    Private Sub ProgressBarX1_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBarX1.VisibleChanged
        On Error Resume Next


        'Exibe barra de progresso secundaria ------------------------------------

        If (ProgressBarX1.Visible = False) Then


            ToolStripProgressBar1.Visible = True 'Exibe


        Else


            ToolStripProgressBar1.Visible = False 'Oculta


        End If

        '-----------------------------------------------------------------------


    End Sub

    Private Sub BCK_FAVICON_IMAGEM_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BCK_FAVICON_IMAGEM.DoWork
        On Error Resume Next

        Proc_obter_favicon_de_site() 'Obtem o favicon do site

    End Sub

    Private Sub BCK_FAVICON_IMAGEM_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BCK_FAVICON_IMAGEM.RunWorkerCompleted
        On Error Resume Next

        Proc_mostra_favicon_baixado() 'Mostra o favicon baixado

    End Sub

    Private Sub ToolStripSplitButton2_DropDownItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStripSplitButton2.DropDownItemClicked
        On Error Resume Next

        proc_permitir_pop_up_proxima_vez_abrir_pagina(e.ClickedItem.ToolTipText) 'Permite abrir a pop-up da proxima vez que a pagina for carregada

        e.ClickedItem.Visible = False 'Ocultando o menu

    End Sub

    Private Sub LimparMensagensDeJanelaBloqueadaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimparMensagensDeJanelaBloqueadaToolStripMenuItem.Click
        On Error Resume Next

        ToolStripSplitButton2.DropDownItems.Clear() 'Limpando os itens

        proc_som_de_evento_ouvir(v_som_limpar) 'Ouvir o som de evento

    End Sub

    Private Sub BCK_SITE_ONLINE_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BCK_SITE_ONLINE.DoWork
        On Error Resume Next

        proc_teste_de_pagina() 'Teste de página pra ver se responde a requisição WebRequest

    End Sub

    Private Sub BCK_SITE_ONLINE_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BCK_SITE_ONLINE.RunWorkerCompleted
        On Error Resume Next

        processar_resposta_teste_site_online() 'Resposta do teste de site online

    End Sub

    Private Sub LimparsitesPossívelmenteOfflineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimparsitesPossívelmenteOfflineToolStripMenuItem.Click
        On Error Resume Next

        ToolStripStatusLabel1.DropDownItems.Clear() 'Limpando

        proc_som_de_evento_ouvir(v_som_limpar) 'Ouvir o som de evento

    End Sub

    Private Sub drop_lista_de_abas_DropDownItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles drop_lista_de_abas.DropDownItemClicked
        On Error Resume Next

        proc_focar_aba_de_motor_via_referencia_de_aba(e.ClickedItem.Name) 'Foca a aba do motor via a aba de referencia

    End Sub

    Private Sub drop_lista_de_abas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drop_lista_de_abas.Click
        On Error Resume Next

        proc_atualizar_propriedades_gerais_evento_trocar_de_aba_completo() 'Ao trocar de aba alterar propriedades

    End Sub

    Private Sub TMR_SOLUCIONADOR_DE_PROBLEMAS_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMR_SOLUCIONADOR_DE_PROBLEMAS.Tick
        On Error Resume Next

        proc_solucionador_de_problemas_gerais_atualizar() 'Ativa o solucionador de problemas gerais e corrige conforme informado

    End Sub

    Private Sub ButtonItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem50.Click
        On Error Resume Next

        proc_chamar_aplicativo_ocultar_ip() 'Chamar o aplicativo ocultar IP

    End Sub

    Private Sub ButtonItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem51.Click
        On Error Resume Next

        proc_chamar_aplicativo_m7task() 'Chamar o aplicativo m7task

    End Sub

    Private Sub FRM_NAVEGACAO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual

    End Sub

    Private Sub BCK_HOST_URL_ONLINE_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BCK_HOST_URL_ONLINE.DoWork
        On Error Resume Next

        proc_teste_de_url_ou_host_disponivel_3() 'Informa se a url ou host está ou não disponivel

    End Sub

    Private Sub BCK_HOST_URL_ONLINE_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BCK_HOST_URL_ONLINE.RunWorkerCompleted
        On Error Resume Next

        proc_resposta_do_teste_de_url_host_disponivel_abrir_site() 'Informa a resposta do teste de host e url disponivel

    End Sub

    Private Sub ButtonItem92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem92.Click
        On Error Resume Next

        proc_atualidade_de_cpu_sair(False) 'Atualidade de cpu fazer algo ou não ao sair

    End Sub

    Private Sub ButtonItem93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem93.Click
        On Error Resume Next

        proc_atualidade_de_cpu_sair(True) 'Atualidade de cpu fazer algo ou não ao sair

    End Sub

    Private Sub ToolStripStatusLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel3.Click
        On Error Resume Next

        proc_informe_com_voz_sobre_protocolo_https_seguranca_pagina(func_retorne_o_site_em_aberto) 'Informa ao usuário se a página visitada é ou nao segura

    End Sub

    Private Sub ListView1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        On Error Resume Next

        proc_ocultar_menu_autocompletar_barra_end_navegacao() 'Oculta o menu de autocompletar na barra de endereços

    End Sub

    Private Sub ButtonItem7_PopupShowing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.PopupShowing
        On Error Resume Next

        proc_exibir_opcao_de_menu_correto_leitor_de_texto() 'Exibe a opção correta do item leitor de pagina

    End Sub

    Private Sub ButtonItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem49.Click
        On Error Resume Next

        proc_ler_texto_selecionado_pelo_item_da_barra_de_menus() 'Lê o texto selecionado pelo menu de aplicativos

    End Sub

    Private Sub ButtonItem2_PopupOpen(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.PopupOpenEventArgs) Handles ButtonItem2.PopupOpen
        On Error Resume Next

        proc_menu_editar_exibir_itens_corretos() 'Exibe os itens corretos do menu editar

    End Sub

    Private Sub ButtonItem4_PopupOpen(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.PopupOpenEventArgs) Handles ButtonItem4.PopupOpen
        On Error Resume Next

        proc_menu_historico_exibir_itens_corretos() 'Exibe os itens corretos do menu historico

    End Sub

    Private Sub ButtonItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem17.Click
        On Error Resume Next

        Me.Close() 'Saindo do formulário principal

    End Sub

    Private Sub ButtonItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem71.Click
        On Error Resume Next

        proc_chamar_historico() 'Chama a janela de historico

    End Sub

    Private Sub ButtonItem72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem72.Click
        On Error Resume Next

        proc_remover_todo_o_historico_de_navegacao() 'Remove todo o historico de navegação

    End Sub

    Private Sub ButtonItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem9.Click
        On Error Resume Next

        proc_chamar_aplicativo_photo_sete(False, Nothing) 'Chamar o aplicativo photo sete

    End Sub

    Private Sub ButtonItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem47.Click
        On Error Resume Next

        proc_chamar_aplicativo_baixabit() 'Chamar o aplicativo baixabit

    End Sub

    Private Sub ButtonItem94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem94.Click
        On Error Resume Next

        proc_chamar_aplicativo_pinger() 'Chamar o aplicativo pinger

    End Sub

    Private Sub ButtonItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem52.Click
        On Error Resume Next

        proc_chamar_aplicativo_robit() 'Chamar o aplicativo robit

    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        On Error Resume Next

        proc_exibir_ip_de_site_e_atual_formulario_de_navegacao() 'Exibe o ip do site e o ip do computador

    End Sub

    Private Sub ButtonItem95_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem95.Click
        On Error Resume Next

        proc_tirar_foto_do_site_em_visualizacao() 'Obtem a imagem do site em visualizacao

    End Sub

    Private Sub ButtonItem96_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem96.Click
        On Error Resume Next

        proc_chamar_favoritos(False, True) 'Chama a janela de favoritos

    End Sub

    Private Sub ButtonItem99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem99.Click
        On Error Resume Next

        proc_fazer_backup_de_todas_as_configuracoes() 'Faz o backup de todas as configuraçoes

    End Sub

    Private Sub ButtonItem98_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem98.Click
        On Error Resume Next

        proc_restaurar_backup_de_todas_as_configuracoes() 'Restaura todo o conteudo da pasta de configurações

    End Sub

    Private Sub ButtonItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem53.Click
        On Error Resume Next

        proc_menu_ajuda_processar_requerimento(V_PAGINA_DE_DOWNLOAD_DO_NAVEGADOR_AJUDA) 'Executar açao no menu ajuda pelo usuário

    End Sub

    Private Sub ButtonItem100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem100.Click
        On Error Resume Next

        proc_menu_ajuda_processar_requerimento(V_PAGINA_DE_DOWNLOAD_DO_NAVEGADOR_NOVIDADES) 'Executar açao no menu ajuda pelo usuário

    End Sub

    Private Sub ButtonItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem54.Click
        On Error Resume Next

        proc_chamar_aplicativo_exibidor_de_versao() 'Chamar o aplicativo exibidor de versao

    End Sub

    Private Sub ButtonItem101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem101.Click
        On Error Resume Next

        proc_menu_ajuda_processar_requerimento(V_PAGINA_DE_DOWNLOAD_DO_NAVEGADOR_ATUALIZACOES) 'Executar açao no menu ajuda pelo usuário

    End Sub

    Private Sub ButtonItem5_PopupShowing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem5.PopupShowing
        On Error Resume Next

        proc_listar_favoritos_no_menu_favoritos() 'Lista os favoritos no menu de favoritos

    End Sub

    Private Sub ButtonItem104_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem104.Click
        On Error Resume Next

        proc_chamar_aplicativo_associador_de_extencao() 'Associador de extenção

    End Sub

End Class
