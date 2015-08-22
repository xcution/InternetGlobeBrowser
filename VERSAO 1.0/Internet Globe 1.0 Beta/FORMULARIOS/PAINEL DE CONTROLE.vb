Imports SpeechLib
Imports System.Drawing.ColorTranslator
Imports System.Math
Imports System.IO




Public Class FRM_PAINEL_DE_CONTROLE


    'Variáveis de processamento local

    Dim v_conectado As Boolean = False 'Conectado ou não

    Dim v_endereco_imagem As String 'Endereço da imagem

    Dim v_ultima_configuracao_do_modo_geek As Boolean 'Informa a ultima configuração do modo geek














    'Procedimentos


    'Salvar configurações do painel de controle


    Private Sub proc_acao_pop_up_salvar_config() 'Salva a ação da pop-up
        On Error Resume Next

        Dim v_valor_a_salvar As Byte = 0 'Informa o valor a ser salvo






        'Obtendo valor a ser salvo -----------------------------------------------------------------------------------

        If (rd6.Checked = True) Then

            v_valor_a_salvar = v_acao_pop_up_1 'Ação pop-up

        End If


        If (rd7.Checked = True) Then

            v_valor_a_salvar = v_acao_pop_up_2 'Ação pop-up

        End If


        If (rd8.Checked = True) Then

            v_valor_a_salvar = v_acao_pop_up_3 'Ação pop-up

        End If

        '------------------------------------------------------------------------------------------------------------


        'Salvando a configuração ------------------------------------------------------------------------------------

        proc_salvar_valor(v_valor_a_salvar, V_ARQ_CONFIG_POP_UP_ACAO) 'Salva a configuração

        '------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_aplica_pasta_padrao_downloads() 'Aplica a pasta padrão de downloads
        On Error Resume Next

        txt_2.Text = v_pasta_padrao_de_downloads 'Informando a pasta padrão de downloads

    End Sub

    Private Sub proc_acao_tema_definir() 'Define o tipo de tema aplicado
        On Error Resume Next

        Dim v_valor_a_salvar As Byte = 0 'Informa o valor a ser salvo






        'Obtendo valor a ser salvo ----------------------------------------------------------------------------------


        If (rd19.Checked = True) Then

            v_valor_a_salvar = v_acao_tema_1 'Ação tema

        End If


        If (rd20.Checked = True) Then

            v_valor_a_salvar = v_acao_tema_2 'Ação tema

        End If


        If (rd21.Checked = True) Then

            v_valor_a_salvar = v_acao_tema_3 'Ação tema

        End If

        '------------------------------------------------------------------------------------------------------------


        'Salvando a configuração ------------------------------------------------------------------------------------

        proc_salvar_valor(v_valor_a_salvar, V_ARQ_CONFIG_TIPO_DE_TEMA) 'Salva a configuração

        '------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_trans_parencia_salvar() 'Calculo de transparencia
        On Error Resume Next

        Dim v_valor_informado As Byte 'Valor informado da transparencia

        Dim v_valor_de_transparencia As Single 'Informa o valor da transparencia






        'Obtendo valor --------------------------------------------------------------------------------------------------------------

        v_valor_informado = trp_transparencia.Value 'Obtendo valor...

        v_valor_de_transparencia = (v_valor_informado / 100) 'Calculando valor




        '#Não permite transparencia muito baixa

        If (v_valor_de_transparencia < 0.4) Then


            trp_transparencia.Value = 40 'Nivel aceitavel

            MsgBox("Não é permitido um nível de transparência abaixo de 40%", MsgBoxStyle.Exclamation, "Alerta") 'Mensagem


            Exit Sub 'Saindo...


        End If

        '----------------------------------------------------------------------------------------------------------------------------




        'Salvando valor ---------------------------------------------------------------------------------------------

        proc_salvar_valor(v_valor_de_transparencia, V_ARQ_CONFIG_TRANSPARENCIA) 'Salva a configuração

        '------------------------------------------------------------------------------------------------------------




        'Atualiza o formulario de navegação -------------------------------------------------------------------------

        FRM_NAVEGACAO.Opacity = v_valor_de_transparencia 'Atualizando...

        '------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_informe_porcentagem_transparencia() 'Informa a porcentagem da transparencia
        On Error Resume Next

        prg_transparencia.Value = trp_transparencia.Value 'Informando...

        lbl_transp_porcent.Text = trp_transparencia.Value & "%" 'Informando...

    End Sub

    Private Sub proc_computador_lento_solucao_salvar() 'Salva o que fazer quando o computador estiver lento
        On Error Resume Next

        Dim v_valor_a_salvar As Byte = 0 'Informa o valor a ser salvo






        'Obtendo resposta -------------------------------------------------------------------------------------------

        If (rd3.Checked = True) Then

            v_valor_a_salvar = v_acao_computador_lento_1 'Ação computador lento

        End If


        If (rd4.Checked = True) Then

            v_valor_a_salvar = v_acao_computador_lento_2 'Ação computador lento

        End If


        If (rd5.Checked = True) Then

            v_valor_a_salvar = v_acao_computador_lento_3 'Ação computador lento

        End If

        '------------------------------------------------------------------------------------------------------------


        'Salvando resposta ------------------------------------------------------------------------------------------

        proc_salvar_valor(v_valor_a_salvar, V_ARQ_CONFIG_COMPUTADOR_LENTO_SOLUCAO) 'Salva a configuração

        '------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_salvar_configuracoes_FRM_PAINEL_DE_CONTROLE() 'Salva as configurações do painel de controle
        On Error Resume Next


        'Salvando as configurações ---------------------------------------------------------------------------------------------------------

        proc_salvar_valor(txt_1.Text, V_ARQ_CONFIG_PAGINA_INICIAL) 'Salva a configuração
        proc_salvar_valor(chk2.Checked, V_ARQ_CONFIG_ALERTAR_ABRIR_ABAS_DEMAIS) 'Salva a configuração
        proc_salvar_valor(chk3.Checked, V_ARQ_CONFIG_ALERTAR_ABAS_ABERTAS_AO_SAIR) 'Salva a configuração
        proc_salvar_valor(rd1.Checked, V_ARQ_CONFIG_PAGINA_INICIAL_EM_BRANCO_OU_HOME) 'Salva a configuração
        proc_acao_pop_up_salvar_config() 'Salva a ação da pop-up
        proc_salvar_valor(rd9.Checked, V_ARQ_CONFIG_ARMAZENAR_HISTORICO) 'Salva a configuração
        proc_salvar_valor(txt_2.Text, V_ARQ_CONFIG_PASTA_DE_DOWNLOADS) 'Salva a configuração
        proc_salvar_valor(chk1.Checked, V_ARQ_CONFIG_PERGUNTAR_ONDE_SALVAR_DOWNLOADS) 'Salva a configuração
        proc_salvar_valor(rd15.Checked, V_ARQ_CONFIG_TELA_DE_BOAS_VINDAS) 'Salva a configuração
        proc_salvar_valor(rd17.Checked, V_ARQ_CONFIG_USAR_RECURSO_DE_VOZ) 'Salva a configuração
        proc_salvar_valor(cbo_voz.SelectedIndex, V_ARQ_CONFIG_VOZ_SELECIONADA) 'Salva a configuração
        proc_salvar_valor(rd11.Checked, V_ARQ_CONFIG_PROTEGER_CONTRA_CODIGOS_MALICIOSOS) 'Salva a configuração
        proc_acao_tema_definir() 'Define o tipo de tema aplicado
        proc_trans_parencia_salvar() 'Calculo de transparencia
        proc_computador_lento_solucao_salvar() 'Salva o que fazer quando o computador estiver lento
        proc_salvar_valor(chk_processar_menos.Checked, V_ARQ_CONFIG_MODO_GEEK_ATIVADO) 'Salva a configuração
        proc_salvar_valor(txt_3.Text, V_ARQ_CONFIG_NOME_DE_USUARIO) 'Salva a configuração
        proc_salvar_valor(chk5.Checked, V_ARQ_CONFIG_ABRIR_LINK_EM_SEGUNDO_PLANO) 'Salva a configuração
        proc_salvar_valor(chk_6.Checked, V_ARQ_CONFIG_RECURSO_TESTE_DE_PAGINA_ONLINE) 'Salva a configuração
        proc_salvar_valor(chk_7.Checked, V_ARQ_CONFIG_RECURSO_DE_SONS_DE_SISTEMA) 'Salva a configuração
        proc_salvar_valor(chk_8.Checked, V_ARQ_CONFIG_USAR_RECURSO_AUTO_COMPLETAR_BARRA_DE_END) 'Salva a configuração









        '-----------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual
        On Error Resume Next

        Me.Opacity = V_VAL_CONFIG_TRANSPARENCIA 'Aplicando a transparencia

    End Sub











    'Carrega as configurações do painel de controle

    Private Sub proc_acao_pop_up_ler_config() 'Lê as configurações
        On Error Resume Next


        'Selecionando o tipo de ação pop-up -------------------------------------------------------------------------

        Select Case V_VAL_CONFIG_POP_UP_ACAO


            Case v_acao_pop_up_1 'Ação pop-up

                rd6.Checked = True 'Caixa de checagem


            Case v_acao_pop_up_2 'Ação pop-up

                rd7.Checked = True 'Caixa de checagem


            Case v_acao_pop_up_3 'Ação pop-up

                rd8.Checked = True 'Caixa de checagem
                cmd_add_excessao.Enabled = True 'Botao de lista de pop-ups


        End Select

        '------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_acao_tema_aplicar() 'Informa o tema do programa
        On Error Resume Next


        'Selecionando tipo de tema ----------------------------------------------------------------------------------------------------------

        Select Case V_VAL_CONFIG_TIPO_DE_TEMA


            Case v_acao_tema_1 'Ação tema

                rd19.Checked = True 'Caixa de checagem


            Case v_acao_tema_2 'Ação tema

                rd20.Checked = True 'Caixa de checagem


            Case v_acao_tema_3 'Ação tema

                rd21.Checked = True 'Caixa de checagem


        End Select

        '------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_trans_parencia_aplicar() 'Informa o nivel de transparencia
        On Error Resume Next

        Dim v_valor As Integer 'Informa o valor da transparencia






        'Calculando e aplicando o valor da transparencia ------------------------------------------------------------

        v_valor = (V_VAL_CONFIG_TRANSPARENCIA * 100) 'Aplicando a transparencia

        trp_transparencia.Value = v_valor 'Aplicando o valor da transparencia

        '------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_computador_lento_solucao_aplicar() 'Informa a solução do computador lento
        On Error Resume Next


        'Selecionando caixa de checagem -----------------------------------------------------------------------------

        Select Case V_VAL_CONFIG_COMPUTADOR_LENTO_SOLUCAO


            Case v_acao_computador_lento_1 'Ação computador lento

                rd3.Checked = True 'Caixa de checagem


            Case v_acao_computador_lento_2 'Ação computador lento

                rd4.Checked = True 'Caixa de checagem


            Case v_acao_computador_lento_3 'Ação computador lento

                rd5.Checked = True 'Caixa de checagem


        End Select

        '------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_esquema_de_historico_aplicar() 'Lê o esquema de salvar historico
        On Error Resume Next


        'Verificando configuração correta ---------------------------------------------------------------------------

        If (V_VAL_CONFIG_ARMAZENAR_HISTORICO = True) Then


            rd9.Checked = V_VAL_CONFIG_ARMAZENAR_HISTORICO 'Armazena


        Else


            rd10.Checked = True 'Não armazena


        End If

        '------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_tela_de_boas_vindas_aplicar() 'Informa se exibe ou não a tela de boas vindas
        On Error Resume Next


        'Seleciona a configuração correta ----------------------------------------------------------------------------

        If (V_VAL_CONFIG_TELA_DE_BOAS_VINDAS = True) Then


            rd15.Checked = V_VAL_CONFIG_TELA_DE_BOAS_VINDAS 'Exibe a tela de boas vindas


        Else


            rd16.Checked = True 'Não exibe a tela de boas vindas


        End If

        '-------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_esquema_proteger_contra_codigos_maliciosos() 'Informa se o esquema de codigos maliciosos esta ativado
        On Error Resume Next


        'Verificando configuração correta ----------------------------------------------------------------------------

        If (V_VAL_CONFIG_PROTEGER_CONTRA_CODIGOS_MALICIOSOS = True) Then


            rd11.Checked = V_VAL_CONFIG_PROTEGER_CONTRA_CODIGOS_MALICIOSOS 'Protege contra codigos


        Else


            rd12.Checked = True 'Não protege nada


        End If

        '------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_listar_vozes_do_sistema() 'Lista as vozes do sistema
        On Error Resume Next

        Dim v_array_de_vozes As Array = Split(V_VAL_VOZES_NO_SISTEMA, v_separador_de_string) 'Array de vozes do sistema

        Dim v_contador As Integer = 0 'Contador





        'Inicializando valores e carregando ----------------------------------------------------------------------------

        cbo_voz.Items.Clear() 'Limpando valores


        For v_contador = v_contador To v_array_de_vozes.Length - 2

            cbo_voz.Items.Add(v_array_de_vozes(v_contador)) 'Adicionando vozes

        Next

        '---------------------------------------------------------------------------------------------------------------




        'Selecionando a voz aplicada -----------------------------------------------------------------------------------

        cbo_voz.SelectedIndex = V_VAL_CONFIG_VOZ_SELECIONADA 'Selecionando

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_ler_config_caixa_de_opcoes() 'Lê as configuraçoes da caixinha de opçoes
        On Error Resume Next

        'Salvando configuracoes --------------------------------------------------------------------------------------------------------------------------------------

        chk_1.Checked = func_ler_valor(V_ARQ_CONFIG_AVISE_ERRO_ABRIR_SITE) 'Retorna o valor do arquivo lido

        chk_2.Checked = func_ler_valor(V_ARQ_CONFIG_INFORME_VOZ_ABRIR_SITE) 'Retorna o valor do arquivo lido

        chk_3.Checked = func_ler_valor(V_ARQ_CONFIG_USAR_VOZ_EM_CAIXAS_DE_DIALOGO) 'Retorna o valor do arquivo lido

        chk_4.Checked = func_ler_valor(V_ARQ_CONFIG_DESABILITA_EFEITOS_AVANCADOS_DE_NAVEGACAO) 'Desabilita efeitos avançados de navegação













        '-------------------------------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub proc_carregar_configuracoes_painel_de_controle() 'Carrega as configurações do painel de controle
        On Error Resume Next


        'Obtendo as configurações definidas pelo usuário -----------------------------------------------------------------------------------

        txt_1.Text = V_VAL_CONFIG_PAGINA_INICIAL 'Pagina inicial
        chk2.Checked = V_VAL_CONFIG_ALERTAR_ABRIR_ABAS_DEMAIS 'Alertar abrir abas demais
        chk3.Checked = V_VAL_CONFIG_ALERTAR_ABAS_ABERTAS_AO_SAIR 'Alertar ao sair e abas aberas
        rd1.Checked = V_VAL_CONFIG_PAGINA_INICIAL_EM_BRANCO_OU_HOME 'Pagina inicial modo de abrir
        proc_acao_pop_up_ler_config() 'Lê as configurações
        proc_esquema_de_historico_aplicar() 'Lê o esquema de salvar historico
        txt_2.Text = V_VAL_CONFIG_PASTA_DE_DOWNLOADS
        chk1.Checked = V_VAL_CONFIG_PERGUNTAR_ONDE_SALVAR_DOWNLOADS
        proc_tela_de_boas_vindas_aplicar() 'Informa se exibe ou não a tela de boas vindas
        rd17.Checked = V_VAL_CONFIG_USAR_RECURSO_DE_VOZ
        cbo_voz.SelectedIndex = V_VAL_CONFIG_VOZ_SELECIONADA
        proc_esquema_proteger_contra_codigos_maliciosos() 'Informa se o esquema de codigos maliciosos esta ativado
        proc_acao_tema_aplicar() 'Informa o tema do programa
        proc_trans_parencia_aplicar() 'Informa o nivel de transparencia
        proc_computador_lento_solucao_aplicar() 'Informa a solução do computador lento
        chk_processar_menos.Checked = V_VAL_CONFIG_MODO_GEEK_ATIVADO 'Modo geek
        txt_3.Text = V_VAL_CONFIG_NOME_DE_USUARIO 'Nome do usuario
        chk5.Checked = V_VAL_CONFIG_ABRIR_LINK_EM_SEGUNDO_PLANO 'Abrir link em segundo plano
        chk_6.Checked = V_VAL_CONFIG_RECURSO_TESTE_DE_PAGINA_ONLINE 'Abrir link em segundo plano
        chk_7.Checked = V_VAL_CONFIG_RECURSO_DE_SONS_DE_SISTEMA 'Sons de sistema
        proc_listar_vozes_do_sistema() 'Lista as vozes do sistema
        proc_carregar_imagem() 'Carregando a imagem
        proc_ler_config_caixa_de_opcoes() 'Lê as configuraçoes da caixinha de opçoes
        chk_8.Checked = V_VAL_CONFIG_USAR_RECURSO_AUTO_COMPLETAR_BARRA_DE_END 'Recurso de auto completar na barra de endereços








        '-----------------------------------------------------------------------------------------------------------------------------------


    End Sub










    'Procedimentos dos objetos

    Private Sub proc_adicionar_nova_excessao() 'Adiciona nova excessao a lista
        On Error Resume Next

        Dim OBJ_NOVA_JANELA As New FRM_POPUPS_PERMITIDAS 'Nova janela de adicionar excessao de pop-up





        OBJ_NOVA_JANELA.Show() 'Abrindo...

        OBJ_NOVA_JANELA.TopMost = True 'Topmost ativado


    End Sub










    'Procedimentos basicos

    Public Sub proc_memoria_ram() 'Informações sobre a memória ram do computador
        On Error Resume Next

        Dim v_mem As Double 'Memória

        Dim v_disponivel As Long 'Memória em uso

        Dim v_uso_ram As Long 'Quantidade de ram disponivel




        '------------------------- OBTENDO A QUANTIDADE DE MEMÓRIA RAM DA MÁQUINA -----------------------------------------

        v_mem = (My.Computer.Info.TotalPhysicalMemory / 1024) / 1024 'Obtendo a quantidade de memória e convertendo.


        If (v_mem < 1024) Then 'Caso seje menor que 1024 é megabyte, caso contrário Gigabyte.

            lbl_memoria.Text = v_mem & " Megabytes total" 'Total de memória física do computador

        Else

            v_mem = (v_mem / 1024) 'Convertendo para Gigabyte

            v_mem = Round(v_mem, 2) 'Arredondando casas decimais



            '--------------------- SE A QUANTIDADE DE RAM FOR MAIOR DO QUE 1 GB ENTÃO INFORMAR ABAIXO -------------

            If (v_mem > 1) Then 'Maior que um Gigabyte

                lbl_memoria.Text = v_mem & " Gigabytes no total" 'Total de memória física do computador

            Else

                lbl_memoria.Text = v_mem & " Gigabyte no total" 'Total de memória física do computador

            End If

            '------------------------------------------------------------------------------------------------------



        End If


        '----------- RESTAURA VALOR ORIGINAL ------------------------------

        v_mem = (My.Computer.Info.TotalPhysicalMemory / 1024) / 1024 'Obtendo a quantidade de memória e convertendo.

        '-------------------------------------------------------------------------------------------------------------------



        '------------------------ INFORMANDO A QUANTIDADE DISPONÍVEL -----------------------------------------------------------

        v_disponivel = (My.Computer.Info.AvailablePhysicalMemory / 1024) / 1024

        lbl_em_disponivel.Text = v_disponivel & " Megabytes disponíveis" 'Total de memória em uso

        '-------------------------------------------------------------------------------------------------------------------


        '------------------------ INFORMANDO A QUANTIDADE DE MEMÓRIA EM USO ------------------------------------------------

        v_uso_ram = (v_mem - v_disponivel) 'Calculando a quantidade de memória em uso

        lbl_mem_uso.Text = v_uso_ram & " Megabytes em uso" 'Total de memória em uso

        '-------------------------------------------------------------------------------------------------------------------



    End Sub

    Public Sub proc_particao_sistema() 'Informações sobre a partição de sistema
        On Error Resume Next

        Dim v_tamanho As Long 'Tamanho da partição de sistema

        Dim v_particao As String 'Partição de sistema

        Dim v_espaco_vazio As Long 'Espaço disponivel



        '-------------------------------------- OBTENDO O TAMANHO DA PARTIÇÃO SELECIONADA ------------------------------

        v_particao = drv_driver.Drive 'Informando o drive

        v_tamanho = My.Computer.FileSystem.GetDriveInfo(v_particao).TotalSize 'Obtendo o tamanho da partição

        v_tamanho = (v_tamanho / 1024) / (1024) / (1024) 'Fazendo a conversão

        lbl_part_sist_tamanho.Text = v_tamanho & " Gigabytes" 'Tamanho da partição de sistema

        '-----------------------------------------------------------------------------------------------------------------


        '----------------------------------- OBTENDO O ESPAÇO DISPONIVEL -------------------------------------------------

        v_espaco_vazio = My.Computer.FileSystem.GetDriveInfo(v_particao).TotalFreeSpace 'Espaço disponivel

        v_espaco_vazio = (v_espaco_vazio / 1024) / (1024) / (1024) 'Fazendo a conversão

        lbl_disponivel_espaco.Text = v_espaco_vazio & " Gigabytes livres" 'Gigabytes livres

        '-----------------------------------------------------------------------------------------------------------------


        '----------------------------- SISTEMA DE ARQUIVOS -------------------------------------------

        lbl_sistema_de_arquivos.Text = My.Computer.FileSystem.GetDriveInfo(v_particao).DriveFormat 'Sistema de arquivos

        '---------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_usuario_e_sistema_informar() 'Informar o nome do usuário e sistema operacional
        On Error Resume Next

        Dim v_usuario As String 'Nome de usuário

        Dim v_sistema As String 'Nome do sistema operacional



        '------------------------------ NOME DE USUÁRIO ---------------------------

        v_usuario = My.User.Name 'Nome de usuário

        lbl_usuario.Text = v_usuario 'Informando o nome do usuário

        '---------------------------------------------------------------------------



        '------------------------------- SISTEMA OPERACIONAL ------------------------

        v_sistema = My.Computer.Info.OSFullName 'Nome do sistema

        lbl_sistema.Text = v_sistema 'Informando o nome do sistema


        '-----------------------------------------------------------------------------


    End Sub

    Public Sub proc_ram_livre_problema() 'Se houve pouca ram informar que há um problema
        On Error Resume Next

        Dim v_mem As Long 'Memória

        Dim v_disponivel As Long 'Memória em uso

        Dim v_ram_porcentagem_livre As Long 'Porcentagem de memória ram livre

        Dim v_ram_porc_disponivel As Integer 'Quantidade de memória ram disponivel






        '------------------------- OBTENDO A QUANTIDADE DE MEMÓRIA RAM DA MÁQUINA -----------------------------------------

        v_mem = (My.Computer.Info.TotalPhysicalMemory / 1024) / 1024 'Obtendo a quantidade de memória e convertendo.

        '-------------------------------------------------------------------------------------------------------------------



        '------------------------ INFORMANDO A QUANTIDADE DISPONÍVEL -----------------------------------------------------------

        v_disponivel = (My.Computer.Info.AvailablePhysicalMemory / 1024) / 1024

        '-------------------------------------------------------------------------------------------------------------------


        '------------------------ BARRA DE PROGRESSO INFORMAR PORCENTAGEM LIVRE --------------------------------------------

        prg_ram_livre.Maximum = 100 'Valor máximo que pode atingir a barra de progresso.


        v_ram_porcentagem_livre = (v_disponivel * 100) / v_mem 'Calculo de porcentagem


        prg_ram_livre.Value = (100 - v_ram_porcentagem_livre) 'Informando a quantidade de memória ram livre na barra de progresso.

        lbl_ram_livre.Text = prg_ram_livre.Value & "%" 'Informando a porcentagem de memória ram livre na legenda.

        '-------------------------------------------------------------------------------------------------------------------


        '------------------- MENSAGEM A EXIBIR NA LEGENDA ------------------------------------------------------------------

        v_ram_porc_disponivel = prg_ram_livre.Value 'Obtendo o valor da porcentagem livre


        If (v_ram_porc_disponivel < 65) Then 'Comparando

            lbl_status.Text = V_MS_20 'Mensagem

            lbl_status.ForeColor = Color.White 'Boa


            '------- IMAGENS ------

            pic_1.Visible = False

            pic_2.Visible = False

            pic_3.Visible = True

            '---------------------


        End If


        If (v_ram_porc_disponivel >= 65) And (v_ram_porc_disponivel < 85) Then 'Comparando

            lbl_status.Text = V_MS_21 'Mensagem

            lbl_status.ForeColor = Color.Yellow 'Atenção


            '------- IMAGENS ------

            pic_1.Visible = False

            pic_2.Visible = True

            pic_3.Visible = False

            '---------------------


        End If


        If (v_ram_porc_disponivel >= 85) Then 'Comparando

            lbl_status.Text = V_MS_22 'Mensagem

            lbl_status.ForeColor = Color.Lime 'Crítico


            '------- IMAGENS ------

            pic_1.Visible = True

            pic_2.Visible = False

            pic_3.Visible = False

            '---------------------

        End If

        '--------------------------------------------------------------------------------------------------------------------




    End Sub

    Private Sub proc_conexao() 'Teste de conexão
        On Error Resume Next


        Dim resposta1, resposta2, resposta3 As Boolean 'Respostas do ping



        resposta1 = My.Computer.Network.Ping(host_teste_1) 'Ping 1

        resposta2 = My.Computer.Network.Ping(host_teste_2) 'Ping 2

        resposta3 = My.Computer.Network.Ping(host_teste_3) 'Ping 3



        If (resposta1 = True) Or (resposta2 = True) Or (resposta3 = True) Then 'Verifincando respostas de ping

            v_conectado = True 'Conectado

        Else

            v_conectado = False 'Não conectado

        End If


    End Sub

    Private Sub proc_conexao_resposta() 'Informando ao usuário se está ou não conectado a Internet.
        On Error Resume Next

        If (v_conectado = True) Then

            lbl_conexao.Text = "Seu computador está conectado a Internet"

            pic_conectado.Visible = True

            pic_desconectado.Visible = False

        Else

            lbl_conexao.Text = "Seu computador não está conectado a Internet"

            pic_conectado.Visible = False

            pic_desconectado.Visible = True

        End If


        '--------------------- OCULTAR A BARRA DE PROGRESSO -----------------

        prg_conexao.Visible = False 'Não exibir

        '--------------------------------------------------------------------

    End Sub

    Private Sub proc_mudar_imagem() 'Mudar imagem
        On Error Resume Next

        Dim dialogo As New OpenFileDialog 'Novo diálogo


        dialogo.ShowDialog() 'Exibindo o diálogo




        '-------------------- ABRINDO IMAGEM -----------------------------------------------------------------------------------------------------


        If (dialogo.FileName <> Nothing) Then

            pic_user.ImageLocation = dialogo.FileName 'Aplicando a imagem

            v_endereco_imagem = dialogo.FileName 'Aplicando a imagem

            proc_salvar_valor(v_endereco_imagem, V_ARQ_CONFIG_ENDERECO_IMAGEM_PAINEL_DE_CONTROLE) 'Salva a configuração

        End If


        '-----------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub proc_carregar_imagem() 'Carregando a imagem
        On Error Resume Next

        pic_user.ImageLocation = My.Computer.FileSystem.ReadAllText(V_ARQ_CONFIG_ENDERECO_IMAGEM_PAINEL_DE_CONTROLE) 'Endereço do arquivo de imagem

    End Sub

    Private Sub proc_ler_nome() 'Ler nome do usuário
        On Error Resume Next

        Dim V_TEXTO As String 'Texto a ser lido





        'Obtendo o texto ------------------------------------------------

        V_TEXTO = txt_3.Text 'Obtendo...


        If (V_TEXTO = Nothing) Or (V_TEXTO = "") Then

            Exit Sub

        End If

        '-----------------------------------------------------------------



        'Lendo o texto agora ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        proc_falar_texto_repassado_recurso_de_voz_direto_sem_nome_usuario(V_TEXTO) 'Procedimento para leitura de texto repassado pelo usuário, sem saida ou entrada na caixa de texto, sem usar o nome do usuário.

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_leitura_de_texte() 'Leitura de teste
        On Error Resume Next


        'Lendo configuração caso tenha sido alterada ------------------------------------------------------------------------------

        V_VAL_CONFIG_VOZ_SELECIONADA = func_ler_valor(V_ARQ_CONFIG_VOZ_SELECIONADA) 'Retorna o valor do arquivo lido

        '--------------------------------------------------------------------------------------------------------------------------




        'Lendo o texto agora -----------------------------------------------------------------------------------------------------------------------------------------

        OBJ_VOZ_DO_NAVEGADOR.Speak("", SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak) 'Calando voz

        OBJ_VOZ_DO_NAVEGADOR.Voice = OBJ_VOZ_DO_NAVEGADOR.GetVoices.Item(V_VAL_CONFIG_VOZ_SELECIONADA) 'Obtendo a voz selecionada

        OBJ_VOZ_DO_NAVEGADOR.Speak(v_nome_de_sistema_de_voz, SpeechVoiceSpeakFlags.SVSFlagsAsync) 'Lendo conteúdo informado pelo usuário

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_voz_aplicada_com_sucesso() 'Voz aplicada com sucesso
        On Error Resume Next


        'Salvando novas configurações -----------------------------------------------------------------------------------------------

        proc_salvar_valor(cbo_voz.SelectedIndex, V_ARQ_CONFIG_VOZ_SELECIONADA) 'Salva a configuração

        V_VAL_CONFIG_VOZ_SELECIONADA = func_ler_valor(V_ARQ_CONFIG_VOZ_SELECIONADA) 'Retorna o valor do arquivo lido

        '----------------------------------------------------------------------------------------------------------------------------




        'Lendo o texto agora -----------------------------------------------------------------------------------------------------------------------------------------

        OBJ_VOZ_DO_NAVEGADOR.Speak("", SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak) 'Calando voz

        OBJ_VOZ_DO_NAVEGADOR.Voice = OBJ_VOZ_DO_NAVEGADOR.GetVoices.Item(V_VAL_CONFIG_VOZ_SELECIONADA) 'Obtendo a voz selecionada




        If (rd17.Checked = True) Then


            OBJ_VOZ_DO_NAVEGADOR.Speak("Pronto a vóz já está funcionando.", SpeechVoiceSpeakFlags.SVSFlagsAsync) 'Lendo conteúdo informado pelo usuário


        Else


            OBJ_VOZ_DO_NAVEGADOR.Speak("Ops! ative o recurso de vóz clicando em ativar.", SpeechVoiceSpeakFlags.SVSFlagsAsync) 'Lendo conteúdo informado pelo usuário


        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_desabilitar_timer_ao_sair() 'Desabilita o timer ao sair do painel de controle
        On Error Resume Next

        tmr_atualizador.Enabled = False 'Desabilitando

    End Sub








    'Definir as configuracoes padrao do painel de controle

    Public Sub proc_definir_config_padrao_painel_de_controle() 'Define as configurações padrão do painel de controle
        On Error Resume Next


        'Atualizando propriedades de objetos e salvando configurações -------------------------------------------------------------------------

        rd1.Checked = True
        chk2.Checked = True
        chk_1.Checked = True
        chk_2.Checked = False
        chk_3.Checked = True
        chk_4.Checked = False
        rd6.Checked = True
        rd9.Checked = True
        chk1.Checked = True
        proc_aplica_pasta_padrao_downloads() 'Aplica a pasta padrão de downloads
        chk1.Checked = True
        rd15.Checked = True
        rd17.Checked = True
        rd12.Checked = True
        chk_6.Checked = False
        chk_7.Checked = True
        rd19.Checked = True
        proc_acao_tema_definir() 'Define o tipo de tema aplicado
        proc_aplicar_tema_Modulo_de_aplicar_configuracoes() 'Aplica o tema no programa
        trp_transparencia.Value = trp_transparencia.Maximum
        proc_trans_parencia_salvar() 'Calculo de transparencia
        rd4.Checked = True
        chk_processar_menos.Checked = False
        proc_salvar_valor(chk_processar_menos.Checked, V_ARQ_CONFIG_MODO_GEEK_ATIVADO) 'Salva a configuração
        V_VAL_CONFIG_MODO_GEEK_ATIVADO = func_ler_valor(V_ARQ_CONFIG_MODO_GEEK_ATIVADO) 'Retorna o valor do arquivo lido
        txt_3.Text = "Usuário de computador"
        proc_salvar_configuracoes_FRM_PAINEL_DE_CONTROLE() 'Salva as configurações do painel de controle
        chk5.Checked = True
        chk_8.Checked = True
        txt_1.Text = v_pagina_inicial_site_empresa 'Site da empresa



        '--------------------------------------------------------------------------------------------------------------------------------------




        'Mensagem ao usuário ----------------------------------------------------------------------------------------------------------------------------------------------------------------

        MsgBox("Prontinho, as configurações padrão foram definidas com sucesso!", MsgBoxStyle.Information, "Configurações padrão definidas com sucesso!") 'Mensagem ao usuário

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

























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














    Private Sub ButtonX10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX10.Click
        On Error Resume Next

        proc_salvar_configuracoes_FRM_PAINEL_DE_CONTROLE() 'Salva as configurações do painel de controle

    End Sub

    Private Sub ButtonX7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX7.Click
        On Error Resume Next

        proc_aplica_pasta_padrao_downloads() 'Aplica a pasta padrão de downloads

    End Sub

    Private Sub trp_transparencia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trp_transparencia.ValueChanged
        On Error Resume Next

        proc_informe_porcentagem_transparencia() 'Informa a porcentagem da transparencia

    End Sub

    Private Sub FRM_PAINEL_DE_CONTROLE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        proc_atualizar_valor_de_variaveis() 'Atualiza o valor das variáveis

        proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual

        proc_carregar_configuracoes_painel_de_controle() 'Carrega as configurações do painel de controle

        proc_ativa_modo_menos_processamento() 'Ativa o modo menos processamento


    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        On Error Resume Next

        proc_acao_tema_definir() 'Define o tipo de tema aplicado

        proc_aplicar_tema_Modulo_de_aplicar_configuracoes() 'Aplica o tema no programa

    End Sub

    Private Sub FRM_PAINEL_DE_CONTROLE_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next

        proc_desativa_modo_menos_processamento() 'Desativa o modo menos processamento

        proc_salvar_configuracoes_FRM_PAINEL_DE_CONTROLE() 'Salva as configurações do painel de controle

        proc_desabilitar_timer_ao_sair() 'Desabilita o timer ao sair do painel de controle

        proc_atualizar_valor_de_variaveis() 'Atualiza o valor das variáveis

    End Sub

    Private Sub cmd_add_excessao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_add_excessao.Click
        On Error Resume Next

        proc_adicionar_nova_excessao() 'Adiciona nova excessao a lista

    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        On Error Resume Next

        txt_1.Text = func_retorne_o_site_em_aberto() 'Retorna o endereço do site em aberto

    End Sub

    Private Sub tmr_atualizador_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_atualizador.Tick
        On Error Resume Next

        proc_memoria_ram() 'Informações sobre a memória ram do computador

        proc_particao_sistema() 'Informações sobre a partição de sistema

        proc_usuario_e_sistema_informar() 'Informar o nome do usuário e sistema operacional

        proc_ram_livre_problema() 'Se houve pouca ram informar que há um problema

    End Sub

    Private Sub bck_teste_de_conexao_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bck_teste_de_conexao.DoWork
        On Error Resume Next

        proc_conexao() 'Teste de conexão

    End Sub

    Private Sub bck_teste_de_conexao_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bck_teste_de_conexao.RunWorkerCompleted
        On Error Resume Next

        proc_conexao_resposta() 'Informando ao usuário se está ou não conectado a Internet.

    End Sub

    Private Sub ButtonX14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX14.Click
        On Error Resume Next

        prg_conexao.Visible = True 'Barra de progresso sendo exibida

        bck_teste_de_conexao.RunWorkerAsync() 'Rodando o processo de verificar conexão

    End Sub

    Private Sub ButtonX15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX15.Click
        On Error Resume Next

        proc_mudar_imagem() 'Mudar imagem

    End Sub

    Private Sub ButtonX13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX13.Click
        On Error Resume Next

        proc_ler_nome() 'Ler nome do usuário

    End Sub

    Private Sub ButtonX8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX8.Click
        On Error Resume Next

        proc_leitura_de_texte() 'Leitura de teste

    End Sub

    Private Sub ButtonX9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX9.Click
        On Error Resume Next

        proc_voz_aplicada_com_sucesso() 'Voz aplicada com sucesso

    End Sub

    Private Sub rd8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd8.CheckedChanged
        On Error Resume Next


        'Habilitando ou desabilitando o botão ---------------------------------------

        If (rd8.Checked = True) Then

            cmd_add_excessao.Enabled = True 'Habilita

        Else

            cmd_add_excessao.Enabled = False 'Desabilita

        End If

        '----------------------------------------------------------------------------


    End Sub

    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        On Error Resume Next

        proc_chamar_aplicativo_ocultar_ip() 'Chamar o aplicativo ocultar IP

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        On Error Resume Next

        proc_trans_parencia_salvar() 'Calculo de transparencia

        proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual

    End Sub

    Private Sub ButtonX12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX12.Click
        On Error Resume Next

        proc_definir_config_padrao_painel_de_controle() 'Define as configurações padrão do painel de controle

    End Sub

    Private Sub chk_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_1.CheckedChanged
        On Error Resume Next

        proc_salvar_valor(chk_1.Checked, V_ARQ_CONFIG_AVISE_ERRO_ABRIR_SITE) 'Salva a configuração

    End Sub

    Private Sub chk_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_2.CheckedChanged
        On Error Resume Next

        proc_salvar_valor(chk_2.Checked, V_ARQ_CONFIG_INFORME_VOZ_ABRIR_SITE) 'Salva a configuração

    End Sub

    Private Sub chk_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_3.CheckedChanged
        On Error Resume Next

        proc_salvar_valor(chk_3.Checked, V_ARQ_CONFIG_USAR_VOZ_EM_CAIXAS_DE_DIALOGO) 'Salva a configuração

    End Sub

    Private Sub chk_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_4.CheckedChanged
        On Error Resume Next

        proc_salvar_valor(chk_4.Checked, V_ARQ_CONFIG_DESABILITA_EFEITOS_AVANCADOS_DE_NAVEGACAO) 'Salva a configuração

    End Sub

    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        On Error Resume Next

        proc_chamar_limpador_de_arquivos() 'Limpador de arquivos janela chamar

    End Sub

    Private Sub chk_processar_menos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_processar_menos.CheckedChanged
        On Error Resume Next

        proc_salvar_valor(chk_processar_menos.Checked, V_ARQ_CONFIG_MODO_GEEK_ATIVADO) 'Salva a configuração

        V_VAL_CONFIG_MODO_GEEK_ATIVADO = func_ler_valor(V_ARQ_CONFIG_MODO_GEEK_ATIVADO) 'Retorna o valor do arquivo lido

    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        On Error Resume Next

        proc_chamar_aplicativo_instalador_do_recurso_de_leitura_de_voz_tts_speech() 'Chama o instalador do aplicativo que instala o recurso de voz TTS SPEECH

    End Sub

End Class