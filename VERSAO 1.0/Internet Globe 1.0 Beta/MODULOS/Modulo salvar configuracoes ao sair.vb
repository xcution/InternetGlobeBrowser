Module Modulo_salvar_configuracoes_ao_sair


    'Variáveis de processamento

    Public v_quantidade_de_downloads_abertos As Integer 'Informa a quantidade de downloads em execução




    'Procedimentos de salvar configurações

    Public Sub proc_salvar_o_historico_Modulo_salvar_configuracoes_ao_sair() 'Salvar historico ao sair
        On Error Resume Next


        'Verifica se deve salvar o historico de sites visitados --------------------------------------------------------------------------------

        If (V_VAL_CONFIG_ARMAZENAR_HISTORICO = True) Then




            proc_salvar_valor(v_lista_de_sites_visitados_titulo, V_ARQ_HISTORICO_LISTA_DE_SITES_VISITADOS_TITULO) 'Salva a configuração

            proc_salvar_valor(v_lista_de_sites_visitados_url, V_ARQ_HISTORICO_LISTA_DE_SITES_VISITADOS_URL) 'Salva a configuração

            proc_salvar_valor(v_data_da_visita, V_ARQ_HISTORICO_LISTA_DE_SITES_VISITADOS_DATA) 'Salva a configuração




        End If

        '---------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_salvar_o_historico_de_imagens_recurso_autocompletar_Modulo_salvar_configuracoes_ao_sair() 'Salva as imagens do recurso autocompletar ao sair do navegador
        On Error Resume Next

        Dim v_quantidade_de_imagens As Integer = FRM_NAVEGACAO.LST_IMAGENS_MIN_HISTORICO.Images.Count  'Obtendo numero de imagens

        Dim v_contador As Integer = 0 'Contador de looping






        'Verifica se deve salvar o historico de sites visitados --------------------------------------------------------------------------------

        If (V_VAL_CONFIG_ARMAZENAR_HISTORICO = False) Then


            Exit Sub 'Saindo...


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------




        'Salvando novas informações ---------------------------------------------------------------------------------------------------------------------------------------------

        For v_contador = v_contador To v_quantidade_de_imagens


            Dim v_endereco_da_imagem_de_hist_para_salvar_nova_img As String = V_PASTA_DE_CONFIGURACAO & "\" & v_contador - 1 & v_extencao_2 'Endereço de salvar a imagem






            'Verifica se a imagem já existe, e caso nao existir salvar -------------------------------------------------------------------------------------------

            If (func_retorne_se_arquivo_existe_no_computador(v_endereco_da_imagem_de_hist_para_salvar_nova_img) = False) Then




                'Obtendo a imagem temporária

                Dim OBJ_IMAGEM_TP As Image = FRM_NAVEGACAO.LST_IMAGENS_MIN_HISTORICO.Images.Item(v_contador - 1) 'Obtendo imagem...




                'Salvando a imagem temporaria

                OBJ_IMAGEM_TP.Save(v_endereco_da_imagem_de_hist_para_salvar_nova_img) 'Salvando a imagem

                '-------------------------------------------------------------------------------------------------------------------------------------------------------------------




            End If

            '-----------------------------------------------------------------------------------------------------------------------------------------------------




        Next

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Salvando arquivo com nomes de cada chave das imagens -------------------------------------------------------------------------------------------------------------------

        proc_salvar_valor(v_lista_de_sites_visitados_url, V_ARQ_HISTORICO_LISTA_DE_SITES_VISITADOS_NOMES_IMAGENS_SALVAS) 'Salvando url

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------




    End Sub

    Private Sub proc_salvar_historico_de_imagens_favicon() 'Salva os favicons
        On Error Resume Next

        Dim v_quantidade_de_favicons As Integer = FRM_NAVEGACAO.LST_LISTA_DE_FAVICONS.Images.Count  'Quantidade

        Dim v_contador As Integer = 0 'Contador de laço






        'Verifica se deve salvar o historico de sites visitados --------------------------------------------------------------------------------

        If (V_VAL_CONFIG_ARMAZENAR_HISTORICO = False) Then


            Exit Sub 'Saindo...


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------




        'Varrendo e salvando valores ---------------------------------------------------------------------------------------------------------------------------------

        For v_contador = v_contador To v_quantidade_de_favicons



            '#Obtém o endereço de salvar o favicon -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            Dim v_endereco_da_imagem_de_hist_para_salvar_nova_img_favicon As String = V_PASTA_DE_CONFIGURACAO & "\" & v_nome_generico_de_favicon & v_contador - 1 & v_extencao_2 'Endereço de salvar a imagem

            '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------






            'Verifica se a imagem já existe, e caso nao existir salvar -------------------------------------------------------------------------------------------

            If (func_retorne_se_arquivo_existe_no_computador(v_endereco_da_imagem_de_hist_para_salvar_nova_img_favicon) = False) Then




                'Obtendo a imagem temporária

                Dim OBJ_IMAGEM_TP As Image = FRM_NAVEGACAO.LST_LISTA_DE_FAVICONS.Images.Item(v_contador - 1) 'Obtendo imagem...




                'Salvando a imagem temporaria

                OBJ_IMAGEM_TP.Save(v_endereco_da_imagem_de_hist_para_salvar_nova_img_favicon) 'Salvando a imagem





            End If

            '-----------------------------------------------------------------------------------------------------------------------------------------------------




        Next

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Salvando chaves das imagens ---------------------------------------------------------------------------------------------------------------------------------

        proc_salvar_valor(v_lista_de_sites_visitados_url, V_ARQ_HISTORICO_DE_IMAGENS_FAVICONS_KEYS) 'Salva a configuração

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




    End Sub




















    'Salva as configuracoes e informações

    Public Sub proc_salvar_configuracoes_e_informacoes_ao_sair_Modulo_salvar_configuracoes_ao_sair() 'Salva todas as configuraçoes ao sair
        On Error Resume Next


        'Ocultar janela de navegação para dar a impressao de ja ter fechado ------------------------------------------------------------------------------------------

        proc_ocultar_ou_exibir_janela_de_navegacao(True) 'Oculta ou exibe a janela de navegação

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Salvando histórico de navegação ------------------------------------------------------------------------------------------------------------------------------


        If (func_ler_valor(V_ARQ_LIMPAR_DADOS_NAVEGACAO_HISTORICO) = False) Then


            proc_salvar_o_historico_Modulo_salvar_configuracoes_ao_sair() 'Salvar historico ao sair

            proc_salvar_o_historico_de_imagens_recurso_autocompletar_Modulo_salvar_configuracoes_ao_sair() 'Salva as imagens do recurso autocompletar ao sair do navegador

            proc_salvar_historico_de_imagens_favicon() 'Salva os favicons


        End If


        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




    End Sub



























End Module
