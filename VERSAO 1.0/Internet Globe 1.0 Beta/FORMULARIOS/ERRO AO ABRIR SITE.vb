Public Class FRM_ERRO_AO_ABRIR_SITE



    'Variáveis basicas

    Dim v_ultima_configuracao_do_modo_geek As Boolean 'Informa a ultima configuração do modo geek

    Public v_site_de_teste As String = Nothing 'Site do teste de conexao

    Public v_aba_abrir_numero As Integer = Nothing 'Informa o numero da aba a ser aberta















    'Procedimentos basicos

    Private Sub proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual
        On Error Resume Next

        Me.Opacity = V_VAL_CONFIG_TRANSPARENCIA 'Aplicando a transparencia

    End Sub

    Private Sub proc_obter_end_site_teste() 'Obtendo o site de teste
        On Error Resume Next

        v_site_de_teste = v_endereco_do_endereco_url_ou_host_a_ser_aberto 'Obtendo...

    End Sub

    Private Sub proc_abrir_o_site_FRM_ERRO_AO_ABRIR_SITE() 'Abre o site agora
        On Error Resume Next


        'Maximizar formulario principal --------------------------------------------------------------------------------

        FRM_NAVEGACAO.WindowState = FormWindowState.Maximized

        '---------------------------------------------------------------------------------------------------------------




        'Se o numero da aba for nulo entao adicionar uma nova aba ------------------------------------------------------

        If (v_aba_abrir_numero = Nothing) Then


            proc_adicionador_de_nova_aba_e_motor(True) 'Adiciona o motor geckofx ou não. True para sim e false para nao

            v_aba_abrir_numero = v_ultima_aba_adicionada_numero 'Atualizando...


        End If

        '---------------------------------------------------------------------------------------------------------------




        'Verificando o tipo do motor e abrindo site -----------------------------------------------------------------

        If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then


            proc_abrir_site_motor_geckofx(v_site_de_teste, v_aba_abrir_numero) 'Abre a página solicitada no Geckofx


        Else


            proc_abrir_site_motor_trident(v_site_de_teste, v_aba_abrir_numero) 'Abre a página solicitada no trident


        End If

        '-------------------------------------------------------------------------------------------------------------




        'Saindo ------------------------------------------------------------------------------------------------------

        Me.Close() 'Saindo...

        '-------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_informe_com_voz_texto_da_janela(ByVal v_teste_ok As Boolean) 'Informa com voz o texto da janela em exibição.
        On Error Resume Next

        Dim V_TEXTO_DA_JANELA As String 'Armazena o texto da janela






        'Não permite ler mensagem se o formulario nao estiver visivel --------------------------------------------------

        If (Me.Visible = False) Then

            Exit Sub 'Saindo...

        End If

        '---------------------------------------------------------------------------------------------------------------




        'Inicializando variável ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (v_teste_ok = False) Then


            V_TEXTO_DA_JANELA = "Erro ao tentar abrir site. O Internet Glóbe lamenta, porque não conseguiu abrir a página do site informado. veja o porque logo abaixo. " 'Atualizando...

            V_TEXTO_DA_JANELA = V_TEXTO_DA_JANELA & LabelX1.Text & ", e " & LabelX2.Text 'Atualizando...


        Else


            V_TEXTO_DA_JANELA = "Sucesso! " 'Atualizando...

            V_TEXTO_DA_JANELA = V_TEXTO_DA_JANELA & LabelX1.Text & ", e " & LabelX2.Text 'Atualizando...


        End If
        
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Lendo o texto ----------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_VAL_CONFIG_USAR_VOZ_EM_CAIXAS_DE_DIALOGO = True) Then

            proc_falar_texto_repassado_recurso_de_voz_direto(V_TEXTO_DA_JANELA) 'Procedimento para leitura de texto repassado pelo usuário, sem saida ou entrada na caixa de texto.

        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_sair_parar_testes_de_conexao() 'Ao sair parar os testes de conexão
        On Error Resume Next

        bck_teste_de_pagina.CancelAsync() 'Cancela teste de pagina

        bck_teste_de_servidor.CancelAsync() 'Cancela o teste de servidor

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







    'Procedimentos do teste de conexao geral

    Public Sub proc_resposta_do_teste_webrequest_FRM_ERRO_AO_ABRIR_SITE() 'Informa a resposta do teste de host e url disponivel
        On Error Resume Next

        Dim v_url As New Uri(v_site_de_teste) 'Obtendo nova url






        'Obtendo host --------------------------------------------------------------------------------------------------

        v_site_de_teste = v_url.Host 'Obtendo o host agora

        '---------------------------------------------------------------------------------------------------------------


        'Verificando se a resposta do teste é offline -----------------------------------------------------------------------------------------------------------------

        If (v_host_url_esta_online_1 = False) And (v_host_url_esta_online_2 = False) And (v_host_url_esta_online_3 = False) Then


            PIC_5.Visible = True 'Sem acesso

            PIC_6.Visible = False 'Com acesso

            LabelX1.Text = "A página do site: " & v_site_de_teste & ", não foi aberta porque não está disponível, verifique novamente o endereço do site informado." 'Mensagem

            ButtonX2.Enabled = False 'Nao disponivel


        Else


            PIC_5.Visible = False 'Sem acesso

            PIC_6.Visible = True 'Com acesso

            LabelX1.Text = "A página do site: " & v_site_de_teste & ", está disponível, clique em abrir site para abrir." 'Mensagem

            ButtonX2.Enabled = True 'Disponivel


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_resposta_do_teste_de_servidor_FRM_ERRO_AO_ABRIR_SITE() 'Resposta do teste de servidor com ping
        On Error Resume Next

        Dim v_url As New Uri(v_site_de_teste) 'Obtendo nova url






        'Obtendo host --------------------------------------------------------------------------------------------------

        v_site_de_teste = v_url.Host 'Obtendo o host agora

        '---------------------------------------------------------------------------------------------------------------




        'Resposta do teste de conexao -----------------------------------------------------------------------------------------------------------------

        If (v_tem_internet = True) Then


            PIC_3.Visible = True 'Com acesso

            PIC_4.Visible = False 'Sem

            LabelX2.Text = "Seu computador está com a Internet funcionando normalmente." 'Atualizando...


        Else




            PIC_3.Visible = False 'Com acesso

            PIC_4.Visible = True 'Sem

            LabelX2.Text = "Seu computador está com problema na Internet, por isto não é possível abrir o site: " & v_site_de_teste & "." 'Atualizando...


        End If

        '----------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_informe_ao_usuario_oque_aconteceu() 'Informe ao usuário o que aconteceu
        On Error Resume Next


        'Analizando resposta ------------------------------------------------------------------------------------------------------------------

        If (v_host_url_esta_online_1 = False) And (v_host_url_esta_online_2 = False) And (v_host_url_esta_online_3 = False) Then


            proc_informe_com_voz_texto_da_janela(False) 'Informa com voz o texto da janela em exibição.


        Else


            proc_informe_com_voz_texto_da_janela(True) 'Informa com voz o texto da janela em exibição.


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_iniciar_testes_de_conexao() 'Inicia os testes de conexao
        On Error Resume Next


        'Cancela ultimo teste ------------------------------------------------------------------------------------------

        bck_teste_de_pagina.CancelAsync() 'Cancelando

        '---------------------------------------------------------------------------------------------------------------




        'iniciando ultimo teste ----------------------------------------------------------------------------------------

        bck_teste_de_pagina.RunWorkerAsync() 'Iniciando...

        '---------------------------------------------------------------------------------------------------------------




        'Altera modo da barra de progresso -----------------------------------------------------------------------------

        PRG_PROGRESSO.Visible = True 'Visualizando

        PRG_PROGRESSO.ProgressType = DevComponents.DotNetBar.eProgressItemType.Marquee 'Marquee

        '---------------------------------------------------------------------------------------------------------------


    End Sub













    Private Sub FRM_ERRO_AO_ABRIR_SITE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        proc_obter_end_site_teste() 'Obtendo o site de teste

        proc_ativa_modo_menos_processamento() 'Ativa o modo menos processamento

        proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual

        proc_iniciar_testes_de_conexao() 'Inicia os testes de conexao

    End Sub

    Private Sub FRM_ERRO_AO_ABRIR_SITE_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next

        proc_desativa_modo_menos_processamento() 'Desativa o modo menos processamento

        proc_calar_voz_do_motor_tts() 'Cala a voz do motor tts

        proc_sair_parar_testes_de_conexao() 'Ao sair parar os testes de conexão

    End Sub

    Private Sub bck_teste_de_pagina_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bck_teste_de_pagina.DoWork
        On Error Resume Next

        proc_teste_de_url_ou_host_disponivel_3() 'Informa se a url ou host está ou não disponivel

    End Sub

    Private Sub bck_teste_de_pagina_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bck_teste_de_pagina.RunWorkerCompleted
        On Error Resume Next

        bck_teste_de_servidor.CancelAsync() 'Cancelando

        bck_teste_de_servidor.RunWorkerAsync() 'Iniciando...

    End Sub

    Private Sub bck_teste_de_servidor_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bck_teste_de_servidor.DoWork
        On Error Resume Next

        proc_teste_de_ter_internet_ao_abrir_site() 'Teste de internet ao abrir site

    End Sub

    Private Sub bck_teste_de_servidor_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bck_teste_de_servidor.RunWorkerCompleted
        On Error Resume Next


        'Resposta dos testes de conexao --------------------------------------------------------------------------------

        proc_resposta_do_teste_webrequest_FRM_ERRO_AO_ABRIR_SITE() 'Informa a resposta do teste de host e url disponivel

        proc_resposta_do_teste_de_servidor_FRM_ERRO_AO_ABRIR_SITE() 'Resposta do teste de servidor com ping

        proc_informe_ao_usuario_oque_aconteceu() 'Informe ao usuário o que aconteceu

        '---------------------------------------------------------------------------------------------------------------



        'Altera modo da barra de progresso -----------------------------------------------------------------------------

        PRG_PROGRESSO.Visible = False 'Nao visualizando

        PRG_PROGRESSO.ProgressType = DevComponents.DotNetBar.eProgressItemType.Standard 'Normal

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        On Error Resume Next

        proc_iniciar_testes_de_conexao() 'Inicia os testes de conexao

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        On Error Resume Next

        proc_abrir_o_site_FRM_ERRO_AO_ABRIR_SITE() 'Abre o site agora

    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        On Error Resume Next

        proc_abrir_o_site_FRM_ERRO_AO_ABRIR_SITE() 'Abre o site agora

    End Sub

End Class