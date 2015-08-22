Public Class FRM_POPUPS_PERMITIDAS


    'Variaveis basicas

    Dim V_ARRAY_DE_HOSTS As Array 'Array de hosts

    Dim v_ultima_configuracao_do_modo_geek As Boolean 'Informa a ultima configuração do modo geek












    'Procedimentos basicos

    Private Sub proc_carregar_informacoes() 'Carrega informaçoes sobre hosts bloqueados
        On Error Resume Next

        V_VAL_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS = func_ler_valor(V_ARQ_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS) 'Retorna o valor do arquivo lido

        V_ARRAY_DE_HOSTS = Split(V_VAL_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS, v_separador_de_string) 'Separando hosts

    End Sub

    Private Sub proc_listar_hosts() 'Lista os hosts ao usuario
        On Error Resume Next

        Dim v_contador_1 As Integer 'Contador inicial

        Dim v_contador_2 As Integer 'Contador final






        'Limpando valores antigos --------------------------------------------------------------------------------------

        lst_listagem.Items.Clear() 'Limpando...




        'Inicializa o contador 1

        v_contador_1 = 1 'Contador 1




        'Inicializa o contador 2

        v_contador_2 = V_ARRAY_DE_HOSTS.Length 'Contador 2

        '---------------------------------------------------------------------------------------------------------------




        'Varrendo e atualizando ----------------------------------------------------------------------------------------

        For v_contador_1 = v_contador_1 To v_contador_2



            If (V_ARRAY_DE_HOSTS(v_contador_1) <> "") Or (V_ARRAY_DE_HOSTS(v_contador_1) <> Nothing) Then

                lst_listagem.Items.Add(V_ARRAY_DE_HOSTS(v_contador_1)) 'Atualizando...

            End If



        Next

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_adicionar_a_lista() 'Adiciona o site informado a lista
        On Error Resume Next

        Dim v_url_informada_no_campo As String 'Informa a url repassada pelo usuario

        Dim v_host_da_url As Uri 'Host obtido da url repassada pelo usuario






        'Obtendo valores iniciais --------------------------------------------------------------------------------------

        v_url_informada_no_campo = txt_site_permitido.Text.ToLower 'Obtendo url

        v_host_da_url = New Uri(v_url_informada_no_campo) 'Obtendo o host




        '# NÃO PERMITE ADICIONAR VALOR NULO EM HOST

        If (v_host_da_url = Nothing) Then

            v_url_informada_no_campo = "http://" & v_url_informada_no_campo 'Informando protocolo http

            v_host_da_url = New Uri(v_url_informada_no_campo) 'Obtendo o host

        End If


        '---------------------------------------------------------------------------------------------------------------




        'Verificando se o site ja faz ou nao parte da listagem ----------------------------------------------------------------------

        If (v_url_informada_no_campo = "") Or (v_url_informada_no_campo = Nothing) Then


            Me.Hide() 'Oculta

            proc_chamar_mensagem_ao_usuario(V_MS_14, v_tipo_ms_1) 'Chama a janela de mensagem ao usuario

            Me.Show() 'Exibe

            Exit Sub 'Saindo...


        End If

        '----------------------------------------------------------------------------------------------------------------------------




        'Verificando se o site ja faz ou nao parte da listagem ----------------------------------------------------------------------

        If (V_VAL_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS.Contains(v_host_da_url.Host) = True) Then


            Me.Hide() 'Oculta

            proc_chamar_mensagem_ao_usuario(V_MS_13, v_tipo_ms_1) 'Chama a janela de mensagem ao usuario

            Me.Show() 'Exibe

            Exit Sub 'Saindo do procedimento


        End If

        '----------------------------------------------------------------------------------------------------------------------------




        'Atualizando ---------------------------------------------------------------------------------------------------------------------------------------------

        If (v_url_informada_no_campo <> "") Or (v_url_informada_no_campo <> Nothing) Then


            V_VAL_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS = V_VAL_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS & v_separador_de_string & v_host_da_url.Host 'Atualizando variavel

            proc_salvar_valor(V_VAL_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS, V_ARQ_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS) 'Salva a configuração

            txt_site_permitido.Clear() 'Limpando caixa de texto


        End If

        '---------------------------------------------------------------------------------------------------------------------------------------------------------




        'Atualiza valores atuais ---------------------------------------------------------------------------------------------

        proc_carregar_informacoes() 'Carrega informaçoes sobre hosts bloqueados

        proc_listar_hosts() 'Lista os hosts ao usuario

        '---------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_sair_janela() 'Sai da janela
        On Error Resume Next

        Me.Close() 'Saindo...

    End Sub

    Private Sub proc_remover_item() 'Remove o item selecionado
        On Error Resume Next

        Dim v_host_selecionado As String = lst_listagem.SelectedItem 'Item selecionado






        If (v_host_selecionado <> "") Or (v_host_selecionado <> Nothing) Then


            V_VAL_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS = V_VAL_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS.Replace(v_separador_de_string & v_host_selecionado, Nothing) 'Atualizando variavel

            proc_salvar_valor(V_VAL_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS, V_ARQ_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS) 'Salva a configuração

            proc_carregar_informacoes() 'Carrega informaçoes sobre hosts bloqueados

            proc_listar_hosts() 'Lista os hosts ao usuario


        End If


    End Sub

    Private Sub proc_remover_tudo() 'Remove tudo
        On Error Resume Next


        If (MsgBox("Você deseja mesmo remover todos os sites permitidos?", MsgBoxStyle.YesNo, "Pergunta ao usuário") = MsgBoxResult.Yes) Then


            V_VAL_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS = "" 'Atualizando variavel

            proc_salvar_valor(V_VAL_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS, V_ARQ_CONFIG_LISTA_DE_POP_UPS_PERMITIDAS) 'Salva a configuração

            proc_carregar_informacoes() 'Carrega informaçoes sobre hosts bloqueados

            proc_listar_hosts() 'Lista os hosts ao usuario

            MsgBox("Sites excluidos com sucesso!       ", MsgBoxStyle.Information, "Informação") 'Informação


        End If


    End Sub

    Private Sub proc_exibir_itens_menu_correto() 'Exibir os itens do menu corretamente
        On Error Resume Next

        Dim v_host_selecionado As String = lst_listagem.SelectedItem 'Item selecionado






        'Habilita ou desabilita itens do menu -------------------------------------------------------------------------

        If (lst_listagem.Items.Count = 0) Then


            RemoverToolStripMenuItem.Enabled = False 'Desabilitado

            RemoverTudoToolStripMenuItem.Enabled = False 'Desabilitado


        Else


            RemoverToolStripMenuItem.Enabled = True 'Habilitado

            RemoverTudoToolStripMenuItem.Enabled = True 'Habilitado


        End If

        '--------------------------------------------------------------------------------------------------------------




        'Habilita ou desabilita o menu de remover item -----------------------------------------------------------------

        If (v_host_selecionado = "") Or (v_host_selecionado = Nothing) Then


            RemoverToolStripMenuItem.Enabled = False 'Desabilitado


        Else


            RemoverToolStripMenuItem.Enabled = True 'Habilitado


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_adicionar_host_em_visualizacao() 'Adiciona host em visualização
        On Error Resume Next

        txt_site_permitido.Text = func_retorne_o_site_em_aberto() 'Retorna o endereço do site em aberto

        proc_adicionar_a_lista() 'Adiciona o site informado a lista

    End Sub

    Private Sub proc_procurar_por_host() 'Procurar por host informado
        On Error Resume Next

        Dim v_host_a_ser_procurado As String 'Host a ser procurado






        'Obtendo valor de host -----------------------------------------------------------------------------------------

        v_host_a_ser_procurado = txt_busca.Text 'Obtendo valor...

        v_host_a_ser_procurado = v_host_a_ser_procurado.ToLower 'Minusculo

        '---------------------------------------------------------------------------------------------------------------




        'Nao permite valor nulo ----------------------------------------------------------------------------------------

        If (v_host_a_ser_procurado = "") Or (v_host_a_ser_procurado = Nothing) Then

            Exit Sub 'Saindo...

        End If

        '---------------------------------------------------------------------------------------------------------------




        'Selecionando o item ---------------------------------------------------------------

        lst_listagem.SelectedItem = v_host_a_ser_procurado 'Selecionando...

        '-----------------------------------------------------------------------------------


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

















    Private Sub FRM_POPUPS_PERMITIDAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        proc_ativa_modo_menos_processamento() 'Ativa o modo menos processamento

        proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual

        proc_carregar_informacoes() 'Carrega informaçoes sobre hosts bloqueados

        proc_listar_hosts() 'Lista os hosts ao usuario

    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        On Error Resume Next

        proc_adicionar_a_lista() 'Adiciona o site informado a lista

    End Sub

    Private Sub FRM_POPUPS_PERMITIDAS_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next

        proc_desativa_modo_menos_processamento() 'Desativa o modo menos processamento

        proc_atualizar_valor_de_variaveis() 'Atualiza o valor das variáveis

    End Sub

    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        On Error Resume Next

        proc_sair_janela() 'Sai da janela

    End Sub

    Private Sub RemoverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoverToolStripMenuItem.Click
        On Error Resume Next

        proc_remover_item() 'Remove o item selecionado

    End Sub

    Private Sub RemoverTudoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoverTudoToolStripMenuItem.Click
        On Error Resume Next

        proc_remover_tudo() 'Remove tudo

    End Sub

    Private Sub mnu_contexto_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnu_contexto.Opening
        On Error Resume Next

        proc_exibir_itens_menu_correto() 'Exibir os itens do menu corretamente

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        On Error Resume Next

        proc_adicionar_host_em_visualizacao() 'Adiciona host em visualização

    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        On Error Resume Next

        proc_remover_item() 'Remove o item selecionado

    End Sub

    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        On Error Resume Next

        proc_remover_tudo() 'Remove tudo

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        On Error Resume Next

        proc_procurar_por_host() 'Procurar por host informado

    End Sub

    Private Sub txt_site_permitido_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_site_permitido.KeyDown
        On Error Resume Next


        If (e.KeyCode = Keys.Enter) Then


            e.SuppressKeyPress = True 'Não permite bip

            proc_adicionar_a_lista() 'Adiciona o site informado a lista


        End If


    End Sub

    Private Sub txt_busca_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_busca.KeyDown
        On Error Resume Next


        If (e.KeyCode = Keys.Enter) Then

            e.SuppressKeyPress = True 'Não permite o bip

            proc_procurar_por_host() 'Procurar por host informado

        End If


    End Sub

End Class