Imports Gecko
Imports System.IO
Imports SpeechLib




Public Class FRM_FORMULARIO_PAINEL_DE_CONTROLE


    'VARIÁVEIS LOCAIS

    Dim V_IP_DE_TESTE_PNC As String 'IP DE TESTE DE PAINEL DE CONTROLE

    Dim V_RESPOSTA_TESTE_PNC As Boolean 'INFORMA O TESTE DE IP FEITO PELO PAINEL DE CONTROLE

















    'PROCEDIMENTOS DO PAINEL DE CONTROLE

    Private Sub PROC_EM_BRANCO() 'ABRIR EM BRANCO
        On Error Resume Next


        'ABRIR EM BRANCO -------------------------------------------------------------

        TXT_HOME.Text = "about:blank" 'PÁGINA EM BRANCO

        '-----------------------------------------------------------------------------


    End Sub

    Private Sub PROC_SITE_ADD_HOME_EM_VISUALIZACAO() 'ADICIONA O SITE EM VISUALIZAÇÃO COMO PÁGINA HOME
        On Error Resume Next

        Dim V_SITE As String 'SITE EM VISUALIZAÇÃO






        'OBTENDO URL ---------------------------------------------------------------------------------------------------

        V_SITE = CType(OBJ_MOTOR_DE_ACAO_EM_USO, Gecko.GeckoWebBrowser).Url.AbsoluteUri

        '---------------------------------------------------------------------------------------------------------------




        'SETANDO ---------------------------------

        TXT_HOME.Text = V_SITE

        '-----------------------------------------

    End Sub

    Private Sub PROC_APLICA_PASTA_PADRAO_DE_DOWNLOAD() 'APLICA A PASTA PADRÃO DE DOWNLOAD
        On Error Resume Next

        TXT_LOCAL_DOWNLOAD.Text = V_PASTA_DE_MEUS_DOWNLOADS_BAIXADOS_PADRAO_END 'APLICANDO

    End Sub

    Private Sub PROC_ESCOLHER_NOVA_PASTA_DE_DOWNLOAD() 'ESCOLHE A NOVA PASTA DE DOWNLOAD
        On Error Resume Next


        'NOVO DIÁLOGO --------------------------------------------------------------------------------------------------

        OBJ_DIALOGO_ABRIR_PASTA = New FolderBrowserDialog 'NOVO DIÁLOGO DE ESCOLHER PASTA

        '---------------------------------------------------------------------------------------------------------------




        'ABRINDO -------------------------------------------------------------------------------------------------------

        If (OBJ_DIALOGO_ABRIR_PASTA.ShowDialog = System.Windows.Forms.DialogResult.OK) Then


            TXT_LOCAL_DOWNLOAD.Text = OBJ_DIALOGO_ABRIR_PASTA.SelectedPath 'REPASSA A PASTA SELECIONADA


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_SALVA_VOZ_SELECIONADA() 'SALVA A VOZ SELECIONADA
        On Error Resume Next

        PROC_SALVAR_ARQUIVO(CBO_VOZES.SelectedIndex, V_ARQUIVO_END_18) 'SALVANDO A VOZ

    End Sub

    Private Sub PROC_HABILITAR_RECURSO_DE_VOZ() 'HABILITA OU NÃO O RECURSO DE VOZ
        On Error Resume Next


        'SALVANDO INDEX DE VOZ -----------------------------------------------------------------------------------------

        If (CHK_RECURSO_DE_FALA.Checked = False) Then


            CBO_VOZES.SelectedIndex = -1 'SELECIONA NENHUMA VOZ

            PROC_SALVAR_ARQUIVO(Nothing, V_ARQUIVO_END_18) 'SALVANDO A VOZ


        Else


            CBO_VOZES.SelectedIndex = 0 'SELECIONA A PRIMEIRA VOZ AGORA

            PROC_SALVAR_ARQUIVO(CBO_VOZES.SelectedIndex, V_ARQUIVO_END_18) 'SALVANDO A VOZ


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_RECURSO_DE_VOZ_CAIXA_DE_MS_HABILITAR() 'ATIVA OU NÃO O RECURSO DE VOZ EM CAIXAS DE DIÁLOGO
        On Error Resume Next

        PROC_SALVAR_ARQUIVO(CHK_MSG_EXIBE_OUVIR.Checked, V_ARQUIVO_END_19) 'SALVANDO RECURSO DE VOZ EM CAIXAS DE DIÁLOGO

    End Sub

    Private Sub PROC_RECURSO_DE_TEMA_HABILITAR() 'RECURSO DE TEMAS DO NAVEGADOR
        On Error Resume Next


        'SALVANDO O TEMA -----------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(CBO_TEMAS.SelectedItem, V_ARQUIVO_END_20) 'SALVA O TEMA SELECIONADO

        '---------------------------------------------------------------------------------------------------------------




        'AGORA CARREGA O TEMA ------------------------------------------------------------------------------------------

        PROC_CARREGAR_TEMA_SELECIONADO() 'CARREGA O TEMA SELECIONADO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_ATIVAR_TIMER_ATUALIZADOR(ByVal V_RESPOSTA As Boolean) 'ATIVA OU DESATIVA O TIMER ATUALIZADOR
        On Error Resume Next

        TMR_ATUALIZADOR.Enabled = V_RESPOSTA 'ATIVANDO OU DESATIVANDO

    End Sub


















    'INFORME QUEM SOU

    Private Sub PROC_QUEM_SOU_PAINEL_DE_CONTROLE() 'QUEM SOU NO PAINEL DE CONTROLE
        On Error Resume Next


        'LENDO O CONTEÚDO ----------------------------------------------------------------------------------------------

        PROC_USAR_SINTETIZADOR_DE_FALA_HUMANA(Nothing) 'USA O SINTETIZADOR DE FALA HUMANA EM MENSAGENS ETC...

        PROC_USAR_SINTETIZADOR_DE_FALA_HUMANA(V_QUEM_SOU_NAVEGADOR) 'USA O SINTETIZADOR DE FALA HUMANA EM MENSAGENS ETC...

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_QUEM_SOU_PAINEL_DE_CONTROLE_PARAR() 'AO SAIR PARA DE LER QUEM SOU
        On Error Resume Next

        PROC_USAR_SINTETIZADOR_DE_FALA_HUMANA(Nothing) 'USA O SINTETIZADOR DE FALA HUMANA EM MENSAGENS ETC...

    End Sub














    'PROCEDIMENTOS DE CARREGAR CONFIGURACOES

    Private Sub PROC_CARREGAR_BASICO() 'CARREGA AS CONFIGURAÇÕES BÁSICAS
        On Error Resume Next


        'BÁSICAS -------------------------------------------------------------------------------------------------------

        TXT_HOME.Text = FUNC_LER_ARQUIVO(V_ARQUIVO_END_1) 'LÊ CONFIG DE ARQUIVO
        TXT_LOCAL_DOWNLOAD.Text = FUNC_LER_ARQUIVO(V_ARQUIVO_END_6) 'LÊ CONFIG DE ARQUIVO
        CHK1.Checked = FUNC_LER_ARQUIVO(V_ARQUIVO_END_2) 'LÊ CONFIG DE ARQUIVO
        CHK2.Checked = FUNC_LER_ARQUIVO(V_ARQUIVO_END_3) 'LÊ CONFIG DE ARQUIVO
        CHK3.Checked = FUNC_LER_ARQUIVO(V_ARQUIVO_END_4) 'LÊ CONFIG DE ARQUIVO
        CHK4.Checked = FUNC_LER_ARQUIVO(V_ARQUIVO_END_5) 'LÊ CONFIG DE ARQUIVO

        '---------------------------------------------------------------------------------------------------------------




        'POP-UP --------------------------------------------------------------------------------------------------------

        If (FUNC_LER_ARQUIVO(V_ARQUIVO_END_7) = True) Then

            RD1.Checked = True
            RD2.Checked = False
            RD3.Checked = False

        End If

        '---------------------------------------------------------------------------------------------------------------




        'POP-UP --------------------------------------------------------------------------------------------------------

        If (FUNC_LER_ARQUIVO(V_ARQUIVO_END_8) = True) Then

            RD1.Checked = False
            RD2.Checked = True
            RD3.Checked = False

        End If

        '---------------------------------------------------------------------------------------------------------------




        'POP-UP --------------------------------------------------------------------------------------------------------

        If (FUNC_LER_ARQUIVO(V_ARQUIVO_END_9) = True) Then

            RD1.Checked = False
            RD2.Checked = False
            RD3.Checked = True

        End If

        '---------------------------------------------------------------------------------------------------------------




        'CARREGA OPÇÕES ------------------------------------------------------------------------------------------------

        CHK_OPT_2.Checked = FUNC_LER_ARQUIVO(V_ARQUIVO_END_23) 'Lendo valor de configuração
        CHK_OPT_3.Checked = FUNC_LER_ARQUIVO(V_ARQUIVO_END_24) 'Lendo valor de configuração
        CHK_OPT_4.Checked = FUNC_LER_ARQUIVO(V_ARQUIVO_END_25) 'Lendo valor de configuração
        CHK_OPT_5.Checked = FUNC_LER_ARQUIVO(V_ARQUIVO_END_26) 'Lendo valor de configuração
        CHK_OPT_6.Checked = FUNC_LER_ARQUIVO(V_ARQUIVO_END_27) 'Lendo valor de configuração
        CHK_OPT_7.Checked = FUNC_LER_ARQUIVO(V_ARQUIVO_END_28) 'Lendo valor de configuração
        CHK_OPT_8.Checked = FUNC_LER_ARQUIVO(V_ARQUIVO_END_29) 'Lendo valor de configuração
        CHK_OPT_9.Checked = FUNC_LER_ARQUIVO(V_ARQUIVO_END_30) 'Lendo valor de configuração
        CHK_OPT_10.Checked = FUNC_LER_ARQUIVO(V_ARQUIVO_END_34) 'Lendo valor de configuração
        CHK_OPT_11.Checked = FUNC_LER_ARQUIVO(V_ARQUIVO_END_35) 'Lendo valor de configuração
        CHK_OPT_12.Checked = FUNC_LER_ARQUIVO(V_ARQUIVO_END_37) 'Lendo valor de configuração











        '---------------------------------------------------------------------------------------------------------------




















    End Sub

    Private Sub PROC_CARREGA_VOZES_PAINEL_DE_CONTROLE() 'CARREGA AS VOZES DO PAINEL DE CONTROLE
        On Error Resume Next

        Dim V_VOZES_INSTALADAS As String = FUNC_RETORNE_TODAS_AS_VOZES_INSTALADAS() 'RETORNA TODAS AS VOZES INSTALADAS NO SISTEMA

        Dim ARRAY_VOZES As Array = Split(V_VOZES_INSTALADAS, V_SEPARADOR_DE_STRINGS) 'SEPARANDO DADOS

        Dim V_CONTADOR As Integer = 0 'CONTADOR

        Dim V_NOME_DA_VOZ As String = FUNC_LER_ARQUIVO(V_ARQUIVO_END_18) 'OBTEM O NOME DA VOZ






        'LIMPA AS VOZES ------------------------------------------------------------------------------------------------

        CBO_VOZES.Items.Clear() 'LIMPA ITENS

        '---------------------------------------------------------------------------------------------------------------




        'ADICIONA AS VOZES ---------------------------------------------------------------------------------------------

        For V_CONTADOR = V_CONTADOR To ARRAY_VOZES.Length




            'VERIFICA CONDIÇÃO -----------------------------------------------------------------------------------------

            If (ARRAY_VOZES(V_CONTADOR) <> Nothing) And (ARRAY_VOZES(V_CONTADOR) <> "") Then


                CBO_VOZES.Items.Add(ARRAY_VOZES(V_CONTADOR)) 'LISTA VOZ


            End If

            '-----------------------------------------------------------------------------------------------------------




        Next

        '---------------------------------------------------------------------------------------------------------------




        'SETA VOZ SELECIONADA ANTES ------------------------------------------------------------------------------------

        CBO_VOZES.SelectedIndex = FUNC_LER_ARQUIVO(V_ARQUIVO_END_18) 'LENDO A VOZ SELECIONADA ANTES

        '---------------------------------------------------------------------------------------------------------------




        'VERIFICA SE O RECURSO DE VOZ FOI ATIVADO ----------------------------------------------------------------------

        If (V_NOME_DA_VOZ = Nothing) Or (V_NOME_DA_VOZ = "") Or (V_NOME_DA_VOZ.Length < 1) Then


            CHK_RECURSO_DE_FALA.Checked = False 'NÃO


        Else


            CHK_RECURSO_DE_FALA.Checked = True 'SIM

            CBO_VOZES.SelectedIndex = 0 'SELECIONA A PRIMEIRA VOZ AGORA


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_USAR_RECURSO_DE_VOZ_EM_MSG_CARREGAR() 'VERIFICA SE USA O RECURSO DE VOZ EM CAIXAS DE DIÁLOGO
        On Error Resume Next

        CHK_MSG_EXIBE_OUVIR.Checked = FUNC_LER_ARQUIVO(V_ARQUIVO_END_19) 'LENDO CONFIGURAÇÃO

    End Sub

    









    'TEMAS

    Private Sub PROC_CARREGAR_TODOS_OS_TEMAS_INSTALADOS() 'CARREGA TODOS OS TEMAS INSTALADOS NO COMPUTADOR
        On Error Resume Next

        Dim ARRAY_QUANTIDADE_DE_TEMAS As Array = Directory.GetFiles(V_PASTA_DE_TEMAS, "*.vssf*") 'TEMAS INSTALADOS

        Dim V_CONTADOR As Integer = 0 'CONTADOR DE LOOPING

        Dim V_EXTENCAO_DE_TEMA As String = ".vssf" 'EXTENÇÃO DO TEMA






        'LIMPA ULTIMA LISTA --------------------------------------------------------------------------------------------

        CBO_TEMAS.Items.Clear() 'LIMPANDO

        '---------------------------------------------------------------------------------------------------------------




        'ADICIONA NOVOS ITENS ------------------------------------------------------------------------------------------

        For V_CONTADOR = V_CONTADOR To ARRAY_QUANTIDADE_DE_TEMAS.Length - 1


            Dim V_NOME_DE_TEMA As String = Path.GetFileName(ARRAY_QUANTIDADE_DE_TEMAS(V_CONTADOR)) 'NOME DO TEMA






            V_NOME_DE_TEMA = V_NOME_DE_TEMA.Replace(V_EXTENCAO_DE_TEMA, Nothing) 'REMOVE EXTENÇÃO

            CBO_TEMAS.Items.Add(V_NOME_DE_TEMA) 'APLICA O NOME DO TEMA


        Next

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_TEMA_PADRAO_APLICAR() 'APLICA O TEMA PADRÃO
        On Error Resume Next


        'PAUSA O FADIN -------------------------------------------------------------------------------------------------

        V_PAUSAR_FADIN = True 'PAUSANDO

        '---------------------------------------------------------------------------------------------------------------




        'SALVANDO O TEMA -----------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(Nothing, V_ARQUIVO_END_20) 'SALVA O TEMA SELECIONADO

        '---------------------------------------------------------------------------------------------------------------




        'REMOVE TEMA ---------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.VST_TEMA.TargetControls = SkinSoft.VisualStyler.TargetControls.None 'REMOVENDO...

        '---------------------------------------------------------------------------------------------------------------




        'AGORA CARREGA O TEMA ------------------------------------------------------------------------------------------

        PROC_CARREGAR_TEMA_SELECIONADO() 'CARREGA O TEMA SELECIONADO

        '---------------------------------------------------------------------------------------------------------------




        'REABILITA O FADIN ---------------------------------------------------------------------------------------------

        V_PAUSAR_FADIN = False 'REABILITANDO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_CARREGAR_TEMA_SELECIONADO() 'CARREGA O TEMA SELECIONADO
        On Error Resume Next


        'CARREGA O TEMA SELECIONADO E APLICA O TEMA --------------------------------------------------------------------

        PROC_APLICADOR_DE_TEMAS_NO_NAVEGADOR() 'APLICADOR DE TEMAS NO NAVEGADOR

        '---------------------------------------------------------------------------------------------------------------


    End Sub











    'TRANSPARENCIA

    Private Sub PROC_PORCENTAGEM_DE_TRANSPARENCIA() 'PORCENTAGEM DE TRANSPARENCIA
        On Error Resume Next

        Dim V_VALOR_ATUAL As Single = OBJ_FORMULARIO_DE_TRABALHO.Opacity 'VALOR ATUAL DE OPACITY






        'INFORMA O NIVEL DE TRANSPARENCIA ------------------------------------------------------------------------------

        PRG_TRANSPARENCIA.Maximum = 100 'VALOR MÁXIMO

        PRG_TRANSPARENCIA.Value = (V_VALOR_ATUAL * 100) \ 1 'VALOR ATUAL

        LBL_TRANSPARENCIA.Text = (V_VALOR_ATUAL * 100) \ 1 & "%" 'VALOR ATUAL

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_PORCENTAGEM_DE_TRANSPARENCIA_2() 'PORCENTAGEM DE TRANSPARENCIA 2
        On Error Resume Next

        Dim V_VALOR_ATUAL As Single = FUNC_LER_ARQUIVO(V_ARQUIVO_END_21) 'VALOR ATUAL DE OPACITY






        'INFORMA O NIVEL DE TRANSPARENCIA ------------------------------------------------------------------------------

        PRG_TRANSPARENCIA.Maximum = 100 'VALOR MÁXIMO

        PRG_TRANSPARENCIA.Value = (V_VALOR_ATUAL * 100) \ 1 'VALOR ATUAL

        LBL_TRANSPARENCIA.Text = (V_VALOR_ATUAL * 100) \ 1 & "%" 'VALOR ATUAL

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_SALVAR_TRANSPARENCIA(ByVal V_ACAO As Byte) 'SALVA A TRANSPARENCIA
        On Error Resume Next

        Dim V_VALOR_ATUAL As Single = OBJ_FORMULARIO_DE_TRABALHO.Opacity 'VALOR ATUAL DE OPACITY






        'ATUALIZANDO ---------------------------------------------------------------------------------------------------

        Select Case V_ACAO


            Case 1 'AÇÃO 1 ---------------------------------------------------------------------------------------------

                If (V_VALOR_ATUAL > 1) Then

                    Exit Sub 'SAINDO

                End If

                '-------------------------------------------------------------------------------------------------------




            Case 2 'AÇÃO 2 ---------------------------------------------------------------------------------------------

                If (V_VALOR_ATUAL <= 0.8) Then

                    Exit Sub 'SAINDO

                End If

                '-------------------------------------------------------------------------------------------------------


        End Select

        '---------------------------------------------------------------------------------------------------------------




        'VERIFICA A AÇÃO -----------------------------------------------------------------------------------------------

        Select Case V_ACAO


            Case 1

                V_VALOR_ATUAL = V_VALOR_ATUAL + 0.1 'ATUALIZA


            Case 2

                V_VALOR_ATUAL = V_VALOR_ATUAL - 0.1 'ATUALIZA


            Case 3

                V_VALOR_ATUAL = 1 'RESTAURA VALOR


        End Select

        '---------------------------------------------------------------------------------------------------------------




        'ATUALIZA OPACITY ----------------------------------------------------------------------------------------------

        OBJ_FORMULARIO_DE_TRABALHO.Opacity = V_VALOR_ATUAL 'ATUALIZANDO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.Opacity = V_VALOR_ATUAL 'ATUALIZANDO

        '---------------------------------------------------------------------------------------------------------------




        'SALVANDO VALOR ------------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(OBJ_FORMULARIO_DE_TRABALHO.Opacity, V_ARQUIVO_END_21) 'SALVANDO TRANSPARENCIA

        '---------------------------------------------------------------------------------------------------------------




        'PORCENTAGEM ---------------------------------------------------------------------------------------------------

        PROC_PORCENTAGEM_DE_TRANSPARENCIA() 'PORCENTAGEM DE TRANSPARENCIA

        '---------------------------------------------------------------------------------------------------------------


    End Sub














    'CARREGADOR DE CONFIGURAÇÕES

    Private Sub PROC_CARREGAR_CONFIGURACOES() 'CARREGA AS CONFIGURAÇÕES
        On Error Resume Next

        PROC_CARREGAR_BASICO() 'CARREGA AS CONFIGURAÇÕES BÁSICAS

        PROC_CARREGA_VOZES_PAINEL_DE_CONTROLE() 'CARREGA AS VOZES DO PAINEL DE CONTROLE

        PROC_USAR_RECURSO_DE_VOZ_EM_MSG_CARREGAR() 'VERIFICA SE USA O RECURSO DE VOZ EM CAIXAS DE DIÁLOGO

        PROC_CARREGAR_TODOS_OS_TEMAS_INSTALADOS() 'CARREGA TODOS OS TEMAS INSTALADOS NO COMPUTADOR

        PROC_CARREGAR_TEMA_SELECIONADO() 'CARREGA O TEMA SELECIONADO

        PROC_PORCENTAGEM_DE_TRANSPARENCIA_2() 'PORCENTAGEM DE TRANSPARENCIA 2




























    End Sub

    Private Sub PROC_INFORME_CONFIGURACOES_DO_COMPUTADOR() 'INFORMA TODAS AS CONFIGURAÇÕES DO COMPUTADOR
        On Error Resume Next

        Dim V_RAM_TOTAL As Double = (FUNC_RETORNE_QUANTIDADE_DE_MEMORIA_RAM_TOTAL() / 1024 / 1024) 'RETORNA A QUANTIDADE DE MEMORIA RAM GERAL NO COMPUTADOR

        Dim V_RAM_USADA As Double = (FUNC_RETORNE_QUANTIDADE_DE_MEMORIA_RAM_USADA() / 1024 / 1024) 'RETORNA A QUANTIDADE DE MEMORIA RAM USADA

        Dim V_RAM_DISPONIVEL As Double = (FUNC_RETORNE_QUANTIDADE_DE_MEMORIA_RAM_DISPONIVEL() / 1024 / 1024) 'MEMORIA DISPONIVEL

        Dim V_USO_DE_CPU As Integer = FUNC_RETORNE_USO_DE_PROCESSADOR() 'RETORNA O USO DO PROCESSADOR

        Dim V_PORCENTAGEM_RAM_EM_USO As Integer = (FUNC_RETORNE_QUANTIDADE_DE_MEMORIA_RAM_USADA() * 100) \ FUNC_RETORNE_QUANTIDADE_DE_MEMORIA_RAM_TOTAL() 'RAM USADA

        Dim V_TEMP_CPU_ATUAL As Integer = FUNC_RETORNE_TEMPERATURA_DE_PROCESSADOR() 'RETORNA A TEMPERATURA DO PROCESSADOR

        Dim V_MS_COMPLEMENTO(3) As String 'MENSAGENS A EXIBIR INFORMANDO COMO ESTA O COMPUTADOR

        Dim V_TEM_ERRO(3) As Boolean 'INFORMA SE HA ERROS






        'CALCULANDO MEMORIA DISPONIVEL ---------------------------------------------------------------------------------

        If (V_RAM_TOTAL > 1024) Then


            V_RAM_TOTAL = V_RAM_TOTAL / 1024 'GB


        End If

        '---------------------------------------------------------------------------------------------------------------




        'MEMORIA USADA -------------------------------------------------------------------------------------------------

        If (V_RAM_USADA > 1024) Then


            V_RAM_USADA = V_RAM_USADA / 1024 'GB


        End If

        '---------------------------------------------------------------------------------------------------------------




        'MEMORIA RAM DISPONIVEL ----------------------------------------------------------------------------------------

        If (V_RAM_DISPONIVEL > 1024) Then


            V_RAM_DISPONIVEL = V_RAM_DISPONIVEL / 1024 'GB


        End If

        '---------------------------------------------------------------------------------------------------------------




        'REPASSA OS VALORES --------------------------------------------------------------------------------------------

        Label10.Text = Math.Round(V_RAM_TOTAL, 1) & " GB" 'GB

        Label11.Text = Math.Round(V_RAM_DISPONIVEL, 1) & " GB" 'INFORMANDO

        Label12.Text = Math.Round(V_RAM_USADA, 1) & " MB" 'USADA

        '---------------------------------------------------------------------------------------------------------------




        'VERIFICA SE HÁ PROBLEMAS ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_USO_DE_CPU > V_NIVEL_ACEITAVEL_DE_PROCESSAMENTO) Then

            V_MS_COMPLEMENTO(1) = "O processador está trabalhando demais." 'INFORMAÇÃO

            V_TEM_ERRO(1) = True 'HÁ ERRO

        Else

            V_MS_COMPLEMENTO(1) = "O processador está trabalhando normal." 'INFORMAÇÃO

            V_TEM_ERRO(1) = False 'NÃO HÁ ERRO

        End If

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA SE HÁ PROBLEMAS ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_PORCENTAGEM_RAM_EM_USO > V_NIVEL_ACEITAVEL_DE_MEMORIA_RAM_USO) Then

            V_MS_COMPLEMENTO(2) = "A memória do computador está quase cheia." 'INFORMAÇÃO

            V_TEM_ERRO(2) = True 'HÁ ERRO

        Else

            V_MS_COMPLEMENTO(2) = "A memória do computador está ótima." 'INFORMAÇÃO

            V_TEM_ERRO(2) = False 'NÃO HA ERRO

        End If

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA SE HÁ PROBLEMAS ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_TEMP_CPU_ATUAL > V_NIVEL_ACEITAVEL_DE_TEMPERATURA) Then

            V_MS_COMPLEMENTO(3) = "Alerta o processador está quente demais." 'INFORMAÇÃO

            V_TEM_ERRO(3) = True 'HÁ ERRO

        Else

            V_MS_COMPLEMENTO(3) = "O processador está com a temperatura aceitável." 'INFORMAÇÃO

            V_TEM_ERRO(3) = False 'NÃO HÁ ERRO

        End If

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'COMO ESTA O COMPUTADOR ----------------------------------------------------------------------------------------

        Label20.Text = V_MS_COMPLEMENTO(1) & vbCrLf & V_MS_COMPLEMENTO(2) & vbCrLf & V_MS_COMPLEMENTO(3) 'INFORMANDO

        '---------------------------------------------------------------------------------------------------------------




        'CONEXAO -------------------------------------------------------------------------------------------------------

        ProgressBar1.Visible = True 'VISIVEL

        V_IP_DE_TESTE_PNC = TXT_IP.Text 'INFORMANDO O IP

        BCK_TESTE_CONEXAO.CancelAsync() 'CANCELANDO

        BCK_TESTE_CONEXAO.RunWorkerAsync() 'RODANDO PROCESSO

        '---------------------------------------------------------------------------------------------------------------




        'VERIFICA SE HÁ ERROS OU NAO -----------------------------------------------------------------------------------

        If (V_TEM_ERRO(1) = True) Or (V_TEM_ERRO(2) = True) Or (V_TEM_ERRO(3) = True) Then


            PIC_COMPUTADOR.Image = IML_IMAGENS.Images.Item(0) 'IMAGEM

        Else


            PIC_COMPUTADOR.Image = IML_IMAGENS.Images.Item(0) 'IMAGEM


        End If

        '---------------------------------------------------------------------------------------------------------------




        'INFORMAÇÕES SOBRE O DISCO RIGIDO ------------------------------------------------------------------------------

        PROC_INFORMACOES_SOBRE_O_DISCO_RIGIDO() 'INFORMAÇÕES SOBRE O DISCO RIGIDO

        '---------------------------------------------------------------------------------------------------------------


















    End Sub

    Private Sub PROC_TESTE_CONFIG_COMPUTADOR_ONLINE() 'VERIFICA SE O COMPUTADOR ESTÁ ONLINE
        On Error Resume Next

        Dim V_RESPOSTA(3) As Boolean 'RESPOSTAS DE TESTES DE IP






        'EXECUTA TESTES ------------------------------------------------------------------------------------------------

        V_RESPOSTA(1) = My.Computer.Network.Ping(V_IP_DE_TESTE_PNC) 'PINGANDO

        V_RESPOSTA(2) = My.Computer.Network.Ping(V_IP_DE_TESTE_PNC) 'PINGANDO

        V_RESPOSTA(3) = My.Computer.Network.Ping(V_IP_DE_TESTE_PNC) 'PINGANDO

        '---------------------------------------------------------------------------------------------------------------




        'REPASSA A RESPOSTA --------------------------------------------------------------------------------------------

        If (V_RESPOSTA(1) = True) Or (V_RESPOSTA(2) = True) Or (V_RESPOSTA(2) = True) Then

            V_RESPOSTA_TESTE_PNC = True 'ESTA CONECTADO

        Else

            V_RESPOSTA_TESTE_PNC = False 'ESTA DESCONECTADO


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_TESTE_CONFIG_COMPUTADOR_ONLINE_RESPOSTA() 'INFORMA AGORA SE O COMPUTADOR ESTA OU NAO CONECTADO A INTERNET
        On Error Resume Next


        'ANALISA RESPOSTA ----------------------------------------------------------------------------------------------

        If (V_RESPOSTA_TESTE_PNC = True) Then


            Label21.Text = "Conectado!" 'INFORMA QUE ESTA CONECTADO

            PIC_CONEXAO.Image = IML_IMAGENS.Images.Item(0) 'IMAGEM


        Else


            Label21.Text = "Desconectado!" 'INFORMA QUE ESTA DESCONECTADO

            PIC_CONEXAO.Image = IML_IMAGENS.Images.Item(1) 'IMAGEM


        End If

        '---------------------------------------------------------------------------------------------------------------




        'BARRA DE PROGRESSO --------------------------------------------------------------------------------------------

        ProgressBar1.Visible = False 'OCULTA

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_INFORMACOES_SOBRE_O_DISCO_RIGIDO() 'INFORMAÇÕES SOBRE O DISCO RIGIDO
        On Error Resume Next

        Dim V_DISCO As String = DriveListBox1.Drive 'DISCO RIGIDO

        Dim V_ESPACO_EM_DISCO_TOTAL As Long = My.Computer.FileSystem.GetDriveInfo(V_DISCO).TotalSize 'ESPAÇO TOTAL EM DISCO

        Dim V_ESPACO_EM_DISCO_DISPONIVEL As Double = My.Computer.FileSystem.GetDriveInfo(V_DISCO).TotalFreeSpace 'ESPAÇO TOTAL EM DISCO

        Dim V_SISTEMA As String = My.Computer.FileSystem.GetDriveInfo(V_DISCO).DriveFormat 'SISTEMA DE ARQUIVOS






        'INFORMANDO ---------------------------------------------------------------------------------------------------------------------------

        Label17.Text = V_ESPACO_EM_DISCO_TOTAL \ 1024 \ 1024 \ 1024 & " GB" 'TAMANHO DO DISCO

        Label18.Text = Math.Round(V_ESPACO_EM_DISCO_DISPONIVEL / 1024 / 1024 / 1024, 2) & " GB" 'TAMANHO DO DISCO DISPONIVEL

        Label19.Text = V_SISTEMA 'SISTEMA DE ARQUIVOS

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_OPCOES_PADRAO() 'OPÇÕES PADRAO
        On Error Resume Next


        'CONFIGURAÇÕES PADRAO ------------------------------------------------------------------------------------------

        CHK_OPT_3.Checked = False 'PADRÃO
        CHK_OPT_4.Checked = True 'PADRÃO
        CHK_OPT_5.Checked = True 'PADRÃO
        CHK_OPT_6.Checked = True 'PADRÃO
        CHK_OPT_7.Checked = True 'PADRÃO
        CHK_OPT_8.Checked = True 'PADRÃO
        CHK_OPT_9.Checked = True 'PADRÃO
        CHK_OPT_11.Checked = False 'PADRÃO
        CHK_OPT_12.Checked = False 'PADRÃO

        '---------------------------------------------------------------------------------------------------------------


    End Sub














    'RELACIONADO AOS DADOS DO USUARIO

    Private Sub PROC_CARREGAR_IMAGEM() 'CARREGA A IMAGEM DE USUARIO
        On Error Resume Next

        PIC_USUARIO.ImageLocation = FUNC_LER_ARQUIVO(V_ARQUIVO_END_31) 'LENDO IMAGEM DE USUÁRIO

    End Sub

    Private Sub PROC_TROCAR_FOTO(ByVal V_REMOVER As Boolean) 'TROCAR A FOTO DE USUÁRIO
        On Error Resume Next


        'NOVO DIÁLOGO E DEFINE FILTRO ----------------------------------------------------------------------------------

        OBJ_DIALOGO_ABRIR_ARQUIVO = New OpenFileDialog 'NOVO DIÁLOGO DE ABRIR

        OBJ_DIALOGO_ABRIR_ARQUIVO.Filter = "Imagens|*.jpg;*.bmp;*.jpeg;*.gif;*.png|Todas as imagens|*.*" 'FILTRO

        '---------------------------------------------------------------------------------------------------------------




        'SALVANDO IMAGEM EM BRANCO -------------------------------------------------------------------------------------

        If (V_REMOVER = True) Then


            PROC_SALVAR_ARQUIVO(Nothing, V_ARQUIVO_END_31) 'SALVANDO

            PROC_CARREGAR_IMAGEM() 'CARREGA A IMAGEM DE USUARIO

            Exit Sub 'SAINDO


        End If

        '---------------------------------------------------------------------------------------------------------------




        'ABRINDO DIÁLOGO E CARREGANDO IMAGEM ---------------------------------------------------------------------------

        If (OBJ_DIALOGO_ABRIR_ARQUIVO.ShowDialog = System.Windows.Forms.DialogResult.OK) Then


            PROC_SALVAR_ARQUIVO(OBJ_DIALOGO_ABRIR_ARQUIVO.FileName, V_ARQUIVO_END_31) 'SALVANDO

            PROC_CARREGAR_IMAGEM() 'CARREGA A IMAGEM DE USUARIO


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_CARREGAR_NOME() 'CARREGA NOME DE USUÁRIO
        On Error Resume Next

        TXT_NOME.Text = FUNC_LER_ARQUIVO(V_ARQUIVO_END_32) 'LENDO O NOME DE USUÁRIO

    End Sub

    Private Sub PROC_CARREGAR_GENERO() 'CARREGAR O GENERO
        On Error Resume Next


        'GENERO --------------------------------------------------------------------------------------------------------

        If (FUNC_LER_ARQUIVO(V_ARQUIVO_END_33) = True) Then

            RadioButton1.Checked = True 'MASCULINO

        Else

            RadioButton2.Checked = True 'FEMININO

        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub















    Private Sub TXT_HOME_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_HOME.TextChanged
        On Error Resume Next

        'SALVANDO ------------------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(TXT_HOME.Text, V_ARQUIVO_END_1) 'SALVA O ARQUIVO

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub CHK1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK1.CheckedChanged
        On Error Resume Next

        'SALVANDO ------------------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(CHK1.Checked, V_ARQUIVO_END_2) 'SALVA O ARQUIVO

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub CHK2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK2.CheckedChanged
        On Error Resume Next

        'SALVANDO ------------------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(CHK2.Checked, V_ARQUIVO_END_3) 'SALVA O ARQUIVO

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub CHK3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK3.CheckedChanged
        On Error Resume Next

        'SALVANDO ------------------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(CHK3.Checked, V_ARQUIVO_END_4) 'SALVA O ARQUIVO

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub CHK4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK4.CheckedChanged
        On Error Resume Next

        'SALVANDO ------------------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(CHK4.Checked, V_ARQUIVO_END_5) 'SALVA O ARQUIVO

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub TXT_LOCAL_DOWNLOAD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_LOCAL_DOWNLOAD.TextChanged
        On Error Resume Next

        'SALVANDO ------------------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(TXT_LOCAL_DOWNLOAD.Text, V_ARQUIVO_END_6) 'SALVA O ARQUIVO

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub RD1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RD1.CheckedChanged
        On Error Resume Next

        'SALVANDO ------------------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(RD1.Checked, V_ARQUIVO_END_7) 'SALVA O ARQUIVO

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub RD2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RD2.CheckedChanged
        On Error Resume Next

        'SALVANDO ------------------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(RD2.Checked, V_ARQUIVO_END_8) 'SALVA O ARQUIVO

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub RD3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RD3.CheckedChanged
        On Error Resume Next

        'SALVANDO ------------------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(RD3.Checked, V_ARQUIVO_END_9) 'SALVA O ARQUIVO

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub FRM_FORMULARIO_PAINEL_DE_CONTROLE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next


        'APLICA O FADIN ------------------------------------------------------------------------------------------------

        PROC_APLICAR_FADIN_EM_FORMULARIO(Me) 'APLICA O FADIN EM FORMULARIO

        '---------------------------------------------------------------------------------------------------------------




        'SOM DE SISTEMA ------------------------------------------------------------------------------------------------

        PROC_EXIBIR_SOM_DE_SISTEMA(0) 'EXIBE OS SONS INSTALADOS NO SISTEMA

        '---------------------------------------------------------------------------------------------------------------




        'CARREGA CONFIGURAÇOES -----------------------------------------------------------------------------------------

        PROC_CARREGAR_CONFIGURACOES() 'CARREGA AS CONFIGURAÇÕES

        '---------------------------------------------------------------------------------------------------------------




        'ATIVA O TIMER -------------------------------------------------------------------------------------------------

        PROC_ATIVAR_TIMER_ATUALIZADOR(True) 'ATIVA OU DESATIVA O TIMER ATUALIZADOR

        '---------------------------------------------------------------------------------------------------------------




        'CARREGA A IMAGEM DE USUÁRIO -----------------------------------------------------------------------------------

        PROC_CARREGAR_IMAGEM() 'CARREGA A IMAGEM DE USUARIO

        '---------------------------------------------------------------------------------------------------------------




        'NOME DE USUARIO -----------------------------------------------------------------------------------------------

        PROC_CARREGAR_NOME() 'CARREGA NOME DE USUÁRIO

        '---------------------------------------------------------------------------------------------------------------




        'GENERO --------------------------------------------------------------------------------------------------------

        PROC_CARREGAR_GENERO() 'CARREGAR O GENERO

        '---------------------------------------------------------------------------------------------------------------
















    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next


        'ABRIR EM BRANCO -------------------------------------------------------------

        PROC_EM_BRANCO() 'ABRIR EM BRANCO

        '-----------------------------------------------------------------------------


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next

        PROC_SITE_ADD_HOME_EM_VISUALIZACAO() 'ADICIONA O SITE EM VISUALIZAÇÃO COMO PÁGINA HOME

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        On Error Resume Next

        PROC_APLICA_PASTA_PADRAO_DE_DOWNLOAD() 'APLICA A PASTA PADRÃO DE DOWNLOAD

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        On Error Resume Next

        PROC_ESCOLHER_NOVA_PASTA_DE_DOWNLOAD() 'ESCOLHE A NOVA PASTA DE DOWNLOAD

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        On Error Resume Next

        PROC_CHAMAR_JANELA_GERENCIADORA_DE_POPUP() 'CHAMA A JANELA GERENCIADORA DE POP-UPS

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error Resume Next


        'OCULTA O PAINEL DE CONTROLE, LIMPA OS ARQUIVOS E DEPOIS EXIBE NOVAMENTE ------------------------------------

        Me.Hide() 'OCULTA O PAINEL DE CONTROLE

        PROC_LIMPAR_ARQUIVOS_DE_HISTORICO() 'LIMPA OS ARQUIVOS DE HISTÓRICO

        Me.Show() 'EXIBE NOVAMENTE O PAINEL DE CONTROLE

        '------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub CBO_VOZES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBO_VOZES.SelectedIndexChanged
        On Error Resume Next

        PROC_SALVA_VOZ_SELECIONADA() 'SALVA A VOZ SELECIONADA

    End Sub

    Private Sub CHK_RECURSO_DE_FALA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_RECURSO_DE_FALA.CheckedChanged
        On Error Resume Next


        'SALVANDO INDEX DE VOZ -----------------------------------------------------------------------------------------

        PROC_HABILITAR_RECURSO_DE_VOZ() 'HABILITA OU NÃO O RECURSO DE VOZ

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub CHK_MSG_EXIBE_OUVIR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_MSG_EXIBE_OUVIR.CheckedChanged
        On Error Resume Next

        PROC_RECURSO_DE_VOZ_CAIXA_DE_MS_HABILITAR() 'ATIVA OU NÃO O RECURSO DE VOZ EM CAIXAS DE DIÁLOGO

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBO_TEMAS.SelectedIndexChanged
        On Error Resume Next

        'PAUSA O FADIN -------------------------------------------------------------------------------------------------

        V_PAUSAR_FADIN = True 'PAUSANDO

        '---------------------------------------------------------------------------------------------------------------




        'RESTAURA TEMA -------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.VST_TEMA.TargetControls = SkinSoft.VisualStyler.TargetControls.FormsAndControls 'RESTAURA

        '---------------------------------------------------------------------------------------------------------------




        'TEMA DO NAVEGADOR ---------------------------------------------------------------------------------------------

        PROC_RECURSO_DE_TEMA_HABILITAR() 'RECURSO DE TEMAS DO NAVEGADOR

        '---------------------------------------------------------------------------------------------------------------




        'REABILITA O FADIN ---------------------------------------------------------------------------------------------

        V_PAUSAR_FADIN = False 'REABILITANDO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        On Error Resume Next

        PROC_SALVAR_TRANSPARENCIA(1) 'SALVA A TRANSPARENCIA

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        On Error Resume Next

        PROC_SALVAR_TRANSPARENCIA(2) 'SALVA A TRANSPARENCIA

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        On Error Resume Next

        PROC_SALVAR_TRANSPARENCIA(3) 'SALVA A TRANSPARENCIA

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        On Error Resume Next


        PROC_QUEM_SOU_PAINEL_DE_CONTROLE() 'QUEM SOU NO PAINEL DE CONTROLE


    End Sub

    Private Sub FRM_FORMULARIO_PAINEL_DE_CONTROLE_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next

        PROC_CARREGA_INTELIGENCIA_INICIALIZAR() 'CARREGA O TESTE DE INTELIGENCIA AO INICIALIZAR

        PROC_QUEM_SOU_PAINEL_DE_CONTROLE_PARAR() 'AO SAIR PARA DE LER QUEM SOU




        'DESATIVA O TIMER ----------------------------------------------------------------------------------------------

        PROC_ATIVAR_TIMER_ATUALIZADOR(False) 'ATIVA OU DESATIVA O TIMER ATUALIZADOR

        '---------------------------------------------------------------------------------------------------------------




    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        On Error Resume Next

        PROC_REINSTALAR_SISTEMA_DE_VOZ() 'REINSTALA O SISTEMA DE VOZ

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        On Error Resume Next

        PROC_TEMA_PADRAO_APLICAR() 'APLICA O TEMA PADRÃO

    End Sub

    Private Sub CHK_OPT_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_OPT_2.CheckedChanged
        On Error Resume Next

        PROC_SALVAR_ARQUIVO(CHK_OPT_2.Checked, V_ARQUIVO_END_23) 'SALVANDO VALOR

    End Sub

    Private Sub CHK_OPT_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_OPT_3.CheckedChanged
        On Error Resume Next

        PROC_SALVAR_ARQUIVO(CHK_OPT_3.Checked, V_ARQUIVO_END_24) 'SALVANDO VALOR

    End Sub

    Private Sub CHK_OPT_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_OPT_4.CheckedChanged
        On Error Resume Next

        PROC_SALVAR_ARQUIVO(CHK_OPT_4.Checked, V_ARQUIVO_END_25) 'SALVANDO VALOR

    End Sub

    Private Sub CHK_OPT_5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_OPT_5.CheckedChanged
        On Error Resume Next


        'SALVA E CARREGA NOVA CONFIGURAÇÃO -----------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(CHK_OPT_5.Checked, V_ARQUIVO_END_26) 'SALVANDO VALOR

        '---------------------------------------------------------------------------------------------------------------




        'AGORA CARREGA A NOVA CONFIGURAÇÃO -----------------------------------------------------------------------------

        PROC_CARREGA_INTELIGENCIA_INICIALIZAR() 'CARREGA O TESTE DE INTELIGENCIA AO INICIALIZAR

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub CHK_OPT_6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_OPT_6.CheckedChanged
        On Error Resume Next


        'SALVA E CARREGA NOVA CONFIGURAÇÃO -----------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(CHK_OPT_6.Checked, V_ARQUIVO_END_27) 'SALVANDO VALOR

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub CHK_OPT_7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_OPT_7.CheckedChanged
        On Error Resume Next

        PROC_SALVAR_ARQUIVO(CHK_OPT_7.Checked, V_ARQUIVO_END_28) 'SALVANDO VALOR

    End Sub

    Private Sub CHK_OPT_8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_OPT_8.CheckedChanged
        On Error Resume Next

        PROC_SALVAR_ARQUIVO(CHK_OPT_8.Checked, V_ARQUIVO_END_29) 'SALVANDO VALOR

    End Sub

    Private Sub CHK_OPT_9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_OPT_9.CheckedChanged
        On Error Resume Next

        PROC_SALVAR_ARQUIVO(CHK_OPT_9.Checked, V_ARQUIVO_END_30) 'SALVANDO VALOR

    End Sub

    Private Sub TMR_ATUALIZADOR_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMR_ATUALIZADOR.Tick
        On Error Resume Next

        PROC_INFORME_CONFIGURACOES_DO_COMPUTADOR() 'INFORMA TODAS AS CONFIGURAÇÕES DO COMPUTADOR

    End Sub

    Private Sub BCK_TESTE_CONEXAO_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BCK_TESTE_CONEXAO.DoWork
        On Error Resume Next

        PROC_TESTE_CONFIG_COMPUTADOR_ONLINE() 'VERIFICA SE O COMPUTADOR ESTÁ ONLINE

    End Sub

    Private Sub BCK_TESTE_CONEXAO_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BCK_TESTE_CONEXAO.RunWorkerCompleted
        On Error Resume Next

        PROC_TESTE_CONFIG_COMPUTADOR_ONLINE_RESPOSTA() 'INFORMA AGORA SE O COMPUTADOR ESTA OU NAO CONECTADO A INTERNET

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        On Error Resume Next

        V_IP_DE_TESTE_PNC = TXT_IP.Text 'INFORMANDO O IP

        BCK_TESTE_CONEXAO.CancelAsync() 'CANCELANDO

        BCK_TESTE_CONEXAO.RunWorkerAsync() 'RODANDO PROCESSO


    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        On Error Resume Next

        PROC_TROCAR_FOTO(False) 'TROCAR A FOTO DE USUÁRIO

    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        On Error Resume Next

        PROC_TROCAR_FOTO(True) 'TROCAR A FOTO DE USUÁRIO

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NOME.TextChanged
        On Error Resume Next

        PROC_SALVAR_ARQUIVO(TXT_NOME.Text, V_ARQUIVO_END_32) 'SALVANDO CONFIGURAÇÃO

    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        On Error Resume Next

        TXT_NOME.Text = Nothing 'LIMPA O NOME

        PROC_SALVAR_ARQUIVO(TXT_NOME.Text, V_ARQUIVO_END_32) 'SALVANDO CONFIGURAÇÃO

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        On Error Resume Next

        PROC_SALVAR_ARQUIVO(True, V_ARQUIVO_END_33) 'SALVANDO CONFIGURAÇÃO

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        On Error Resume Next

        PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_33) 'SALVANDO CONFIGURAÇÃO

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        On Error Resume Next

        PROC_OPCOES_PADRAO() 'OPÇÕES PADRAO

    End Sub

    Private Sub CHK_OPT_10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_OPT_10.CheckedChanged
        On Error Resume Next

        PROC_SALVAR_ARQUIVO(CHK_OPT_10.Checked, V_ARQUIVO_END_34) 'SALVANDO CONFIGURAÇÃO

    End Sub

    Private Sub CHK_OPT_11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_OPT_11.CheckedChanged
        On Error Resume Next

        PROC_SALVAR_ARQUIVO(CHK_OPT_11.Checked, V_ARQUIVO_END_35) 'SALVANDO A CONFIGURAÇÃO

    End Sub

    Private Sub CHK_OPT_12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_OPT_12.CheckedChanged
        On Error Resume Next

        PROC_SALVAR_ARQUIVO(CHK_OPT_12.Checked, V_ARQUIVO_END_37) 'SALVANDO A CONFIGURAÇÃO

    End Sub

End Class