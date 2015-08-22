Public Class FRM_HISTORICO


    'Variáveis basicas

    Dim v_ultima_configuracao_do_modo_geek As Boolean 'Informa a ultima configuração do modo geek


















    'Procedimentos

    Private Sub proc_carregar_dados_de_historico_agora_FRM_HISTORICO() 'Carrega os dados de historico agora
        On Error Resume Next


        'Array de datas diferentes -----------------------------------------------------------------------------------------------------------------------------------

        Dim array_datas_diferentes As Array = Split(v_datas_diferentes, v_separador_de_string_2) 'Obtendo datas separadas agora

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


        'Variáveis de trabalho ---------------------------------------------------------------------------------------------------------------------------------------

        Dim v_quantidade_de_datas_diferentes As Integer = array_datas_diferentes.Length 'Informa a quantidade de datas diferentes

        Dim v_quantidade_de_sites_hist_visitados As Integer = array_lista_de_sites_visitados_titulo.Length 'Informa a quantidade geral de sites visitados

        Dim v_contador_1 As Integer = 0 'Contador 1

        Dim v_contador_2 As Integer = 0 'Contador 2

        Dim v_valor_data_anterior As String = "" 'Informa a data anterior

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------






        'Adiciona nodes primeiro -------------------------------------------------------------------------------------------------------------------------------------

        For i = 0 To v_quantidade_de_datas_diferentes




            'Não permite adicionar valor em branco ou nulo -----------------------------------------------------------------------------------------------------------

            If (array_datas_diferentes(i) <> "") Or (array_datas_diferentes(i) <> Nothing) Then




                'Adicionando data ou a palavra hoje ------------------------------------------------------------------------------------------------------------------

                If (array_datas_diferentes(i) <> Date.Today) Then


                    TreeView1.Nodes.Add(array_datas_diferentes(i)) 'Adicionando nodes de datas


                Else


                    TreeView1.Nodes.Add("Hoje") 'Adicionando nodes de datas


                End If


                '-----------------------------------------------------------------------------------------------------------------------------------------------------



            End If

        Next

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Varrendo e separando historico por data ---------------------------------------------------------------------------------------------------------------------

        For v_contador_1 = v_contador_1 To v_quantidade_de_datas_diferentes




            'Comparando data diferente com todas as outras datas da matriz todas as datas ----------------------------------------------------------------------------

            For v_contador_2 = v_contador_2 To v_quantidade_de_sites_hist_visitados - 1



                If (array_datas_diferentes(v_contador_1) = array_data_da_visita(v_contador_2)) Then


                    'Objeto node criado ---------------------------------------------------------------

                    Dim OBJ_NODE As New System.Windows.Forms.TreeNode 'Objeto node

                    '----------------------------------------------------------------------------------



                    'Não adiciona valores em branco ou paginas em branco -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


                    If (array_lista_de_sites_visitados_url(v_contador_2) <> "") And (array_lista_de_sites_visitados_url(v_contador_2) <> "about:blank") And (array_lista_de_sites_visitados_url(v_contador_2) <> Nothing) Then



                        'Definindo propriedades ----------------------------------------------------------------------------

                        OBJ_NODE.Text = array_lista_de_sites_visitados_titulo(v_contador_2) 'Texto

                        OBJ_NODE.ToolTipText = array_lista_de_sites_visitados_url(v_contador_2) 'Valor

                        OBJ_NODE.ImageIndex = 1 'Imagem de inicio

                        OBJ_NODE.SelectedImageIndex = 1 'Imagem de seleção

                        TreeView1.Nodes.Item(v_contador_1).Nodes.Add(OBJ_NODE) 'Adicionando o título do site

                        '---------------------------------------------------------------------------------------------------



                    End If


                    '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


                End If



            Next

            '---------------------------------------------------------------------------------------------------------------------------------------------------------




            'Avançar o contador de looping secundario ----------------------------------------------------------------------------------------------------------------

            v_contador_2 = v_contador_1 'Avançando...

            '---------------------------------------------------------------------------------------------------------------------------------------------------------





        Next

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------










    End Sub

    Private Sub proc_inicializar() 'Inicializar
        On Error Resume Next

        proc_separar_arrays_de_informacoes_sobre_historico() 'Separa arrays de informações de historico

        proc_separar_datas_diferentes() 'Separa as datas diferentes

        proc_carregar_dados_de_historico_agora_FRM_HISTORICO() 'Carrega os dados de historico agora

    End Sub

    Private Sub proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual
        On Error Resume Next

        Me.Opacity = V_VAL_CONFIG_TRANSPARENCIA 'Aplicando a transparencia

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








    'Abrir historico selecionado

    Private Sub proc_abrir_em_pagina_atual() 'Abre a url do historico na página  atual
        On Error Resume Next

        Dim v_url As String = Nothing 'Url a ser aberta



        'Só abrir itens que são urls -------------------------------------------

        If (TreeView1.SelectedNode.Level = 0) Then

            Exit Sub

        End If

        '-----------------------------------------------------------------------



        'Obtem endereço de favorito e navega ------------------------------------------------------------------------------------------------

        v_url = TreeView1.SelectedNode.ToolTipText 'Url a ser aberta

        proc_navegar(v_url, v_tipo_de_motor_layout_engine_em_uso_agora, v_qual_motor_esta_em_uso) 'NAVEGA NO SITE SOLICITADO PELO USUARIO

        '------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub proc_abrir_em_nova_aba() 'Abre a url do historico em uma nova aba
        On Error Resume Next

        Dim v_url As String = Nothing 'Url a ser aberta



        'Só abrir itens que são urls -------------------------------------------

        If (TreeView1.SelectedNode.Level = 0) Then

            Exit Sub

        End If

        '-----------------------------------------------------------------------



        'Obtem endereço de favorito e navega ------------------------------------------------------------------------------------------------

        v_url = TreeView1.SelectedNode.ToolTipText 'Url a ser aberta

        proc_adicionador_de_nova_aba_e_motor(True) 'Adiciona o motor geckofx ou não. True para sim e false para nao

        FRM_NAVEGACAO.TabControl1.SelectedTabIndex = FRM_NAVEGACAO.TabControl1.Tabs.Count - 1

        proc_navegar(v_url, v_tipo_de_motor_layout_engine_em_uso_agora, v_qual_motor_esta_em_uso) 'NAVEGA NO SITE SOLICITADO PELO USUARIO

        '------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_abrir_historico_selecionado(ByVal v_em_nova_aba As Boolean) 'Abre o histórico selecionado
        On Error Resume Next



        'Só abrir itens que são urls -------------------------------------------

        If (TreeView1.SelectedNode.Level = 0) Then

            Exit Sub

        End If

        '-----------------------------------------------------------------------



        'Abrindo historico ---------------------------------------------------------------------------------------------

        If (v_em_nova_aba = True) Then


            proc_abrir_em_nova_aba() 'Abre a url do historico em uma nova aba


        Else


            proc_abrir_em_pagina_atual() 'Abre a url do historico na página  atual


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub





    'Informar dados do historico

    Private Sub proc_informe_dados_do_historico() 'Informa os dados do historico
        On Error Resume Next


        LabelX3.Text = TreeView1.SelectedNode.ToolTipText 'Informando a url do historico

        LabelX4.Text = func_retorne_data_pela_url(TreeView1.SelectedNode.ToolTipText) 'Retorna a data da url informada


    End Sub













    Private Sub FRM_HISTORICO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        proc_ativa_modo_menos_processamento() 'Ativa o modo menos processamento

        proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual

        proc_inicializar() 'Inicializar

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        On Error Resume Next

        proc_abrir_historico_selecionado(True) 'Abre o histórico selecionado

    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        On Error Resume Next

        proc_abrir_historico_selecionado(False) 'Abre o histórico selecionado

    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        On Error Resume Next




        'Só abrir itens que são urls -------------------------------------------

        If (TreeView1.SelectedNode.Level = 0) Then


            ButtonX2.Enabled = False
            ButtonX3.Enabled = False
            AbrirEmNovaAbaToolStripMenuItem.Enabled = False
            AbrirNaAbaAtualToolStripMenuItem.Enabled = False


        Else


            ButtonX2.Enabled = True
            ButtonX3.Enabled = True
            AbrirEmNovaAbaToolStripMenuItem.Enabled = True
            AbrirNaAbaAtualToolStripMenuItem.Enabled = True


        End If

        '-----------------------------------------------------------------------


        'Informando os dados do historico ------------------------------------------------------------------------------

        proc_informe_dados_do_historico() 'Informa os dados do historico

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub AbrirEmNovaAbaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirEmNovaAbaToolStripMenuItem.Click
        On Error Resume Next

        proc_abrir_historico_selecionado(True) 'Abre o histórico selecionado

    End Sub

    Private Sub AbrirNaAbaAtualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirNaAbaAtualToolStripMenuItem.Click
        On Error Resume Next

        proc_abrir_historico_selecionado(False) 'Abre o histórico selecionado

    End Sub

    Private Sub FRM_HISTORICO_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next

        proc_desativa_modo_menos_processamento() 'Desativa o modo menos processamento

    End Sub

End Class