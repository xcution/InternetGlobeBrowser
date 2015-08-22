Imports System.IO




Public Class FRM_FORMULARIO_DE_FAVORITOS


    'VARIÁVEIS

    Dim V_DIRETORIO_ATUAL As String = V_PASTA_DE_MEUS_FAVORITOS_END 'INFORMA O DIRETORIO ATUAL ONDE ESTÁ

    Dim V_EXPORTAR_IMPORTAR_ACAO_ATUAL As Boolean 'IMPORTA OU EXPORTA

    Dim V_IMPORTAR_EXPORTAR_PASTA_INFORMADA As String 'PASTA QUE EXPORTA OU IMPORTA

    Dim OBJ_IMAGEM_DE_FAVICON_DE_FAVORITO As Image 'NOVA IMAGEM DE FAVICON DE FAVORITO

    Dim V_END_DE_SITE_EM_VISUALIZACAO_FRM_FORMULARIO_DE_FAVORITOS As String 'ENDEREÇO DO SITE EM VISUALIZAÇÃO

    Dim ARRAY_DIRETORIOS_A_AVANCAR_EM_FAVORITOS As New ArrayList 'DIRETORIOS A AVANÇAR EM FAVORITOS

    Dim V_CONTADOR As Integer 'CONTADOR DE ACESSO

    Dim V_CONTADOR_2 As Integer 'CONTADOR 2 DE ACESSO




















    'PROCEDIMENTOS

    Private Sub PROC_LISTAR_TODOS_OS_FAVORITOS_DA_PASTA_ATUAL_ABERTA(ByVal V_END_DE_PASTA As String) 'AO ABRIR A PASTA LISTAR OS FAVORITOS
        On Error Resume Next

        Dim ARRAY_ARQUIVOS As Array = Directory.GetFiles(V_END_DE_PASTA, "*.txt*") 'OBTENDO TODOS OS ENDEREÇOS DOS ARQUIVOS

        Dim V_CONTADOR As Integer = 0 'CONTADOR DE LOOPING






        'INFORMA A PASTA ATUAL -----------------------------------------------------------------------------------------

        V_DIRETORIO_ATUAL = V_END_DE_PASTA 'INFORMANDO A PASTA ATUAL

        '---------------------------------------------------------------------------------------------------------------




        'LIMPA ITENS ANTIGOS -------------------------------------------------------------------------------------------

        LST_SITES.Clear() 'LIMPA ITENS ANTIGOS

        '---------------------------------------------------------------------------------------------------------------




        'ADICIONA NOVOS ITENS ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        For V_CONTADOR = V_CONTADOR To ARRAY_ARQUIVOS.Length - 1


            Dim V_NOME_DO_ARQUIVO As String = Path.GetFileName(ARRAY_ARQUIVOS(V_CONTADOR)).Replace(Path.GetExtension(ARRAY_ARQUIVOS(V_CONTADOR)), Nothing) 'NOME DO ARQUIVO

            Dim OBJ_LISTA As New ListViewItem 'NOVO ITEM DO LISTVIEW

            Dim OBJ_IMAGEM As Image = FUNC_RETORNE_FAVICON_SALVO_EM_PASTA_VIA_HOST(V_END_DE_PASTA, V_NOME_DO_ARQUIVO) 'RETORNA O FAVICON JÁ SALVO NO HD VIA HOST DO SITE






            'VERIFICA SE A IMAGEM POSSUI OU NAO FORMATO, SE NAO POSSUIR ENTAO APLICAR IMAGEM PADRAO -------------------------------------------

            If (OBJ_IMAGEM.PixelFormat = Nothing) Then


                OBJ_IMAGEM = IML_IMAGENS_2.Images.Item(0) 'APLICANDO A IMAGEM PADRAO

                OBJ_IMAGEM.Save(V_END_DE_PASTA & "\" & V_NOME_DO_ARQUIVO & V_EXTENCAO_DE_ARQUIVO_3) 'SALVA A IMAGEM SE NAO HOUVER UMA


            End If

            '----------------------------------------------------------------------------------------------------------------------------------




            'ATUALIZA IMAGENS DA LISTA ---------------------------------------------------------------------------------

            IML_IMAGENS_2.Images.Add(V_NOME_DO_ARQUIVO, OBJ_IMAGEM) 'CARREGANDO IMAGEM PARA A MEMORIA

            '-----------------------------------------------------------------------------------------------------------




            'DEFININDO PROPRIEDADES ------------------------------------------------------------------------------------

            OBJ_LISTA.Text = V_NOME_DO_ARQUIVO 'NOME DO ARQUIVO

            OBJ_LISTA.ToolTipText = ARRAY_ARQUIVOS(V_CONTADOR) 'LOCAL

            OBJ_LISTA.ImageKey = V_NOME_DO_ARQUIVO 'TIPO DE IMAGEM

            '-----------------------------------------------------------------------------------------------------------




            'ADICIONANDO PASTAS ----------------------------------------------------------------------------------------

            LST_SITES.Items.Add(OBJ_LISTA) 'ADICIONANDO

            '-----------------------------------------------------------------------------------------------------------


        Next

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




    End Sub

    Private Sub PROC_LISTAR_PASTAS_DOS_FAVORITOS(ByVal V_PASTA_A_ABRIR As String) 'LISTA AS PASTAS DOS FAVORITOS
        On Error Resume Next

        Dim ARRAY_TODAS_AS_PASTAS As Array = Directory.GetDirectories(V_PASTA_A_ABRIR) 'OBTENDO TODOS OS DIRETORIOS

        Dim V_CONTADOR As Integer = 0 'CONTADOR DE LOOPING






        'VERIFICA SE PODE OU NAO VOLTAR, EM CASO DE ESTIVER NO DIRETORIO PADRÃO DOS FAVORITOS --------------------------

        If (V_PASTA_A_ABRIR = V_PASTA_DE_MEUS_FAVORITOS_END) Then


            CMD_VOLTAR.Enabled = False 'DESABILITA


        Else


            CMD_VOLTAR.Enabled = True 'HABILITA


        End If

        '---------------------------------------------------------------------------------------------------------------




        'INFORMA A PASTA ATUAL ----------------------------------------------------------------------------------------------------------------

        V_DIRETORIO_ATUAL = V_PASTA_A_ABRIR 'INFORMANDO A PASTA ATUAL

        '--------------------------------------------------------------------------------------------------------------------------------------




        'LIMPA PASTAS ANTIGAS -----------------------------------------------------------------------------------------------------------------

        LST_PASTAS.Clear() 'LIMPANDO...

        '--------------------------------------------------------------------------------------------------------------------------------------




        'ADICIONANDO TODAS AS PASTAS ----------------------------------------------------------------------------------------------------------

        For V_CONTADOR = V_CONTADOR To ARRAY_TODAS_AS_PASTAS.Length - 1


            Dim V_NOME_DE_DIRETORIO As String = Path.GetFileName(ARRAY_TODAS_AS_PASTAS(V_CONTADOR)) 'NOME DAS PASTAS

            Dim OBJ_LISTA As New ListViewItem 'NOVO ITEM DO LISTVIEW




            'DEFININDO PROPRIEDADES -----------------------------------------------------------------------------------------------------------

            OBJ_LISTA.Text = V_NOME_DE_DIRETORIO 'NOME DA PASTA

            OBJ_LISTA.ImageIndex = 0 'TIPO DE PASTA

            OBJ_LISTA.ToolTipText = ARRAY_TODAS_AS_PASTAS(V_CONTADOR) 'LOCAL

            '----------------------------------------------------------------------------------------------------------------------------------




            'ADICIONANDO PASTAS ---------------------------------------------------------------------------------------------------------------

            LST_PASTAS.Items.Add(OBJ_LISTA) 'ADICIONANDO

            '----------------------------------------------------------------------------------------------------------------------------------


        Next

        '--------------------------------------------------------------------------------------------------------------------------------------




        'LISTAR AGORA OS FAVORITOS ------------------------------------------------------------------------------------------------------------

        PROC_LISTAR_TODOS_OS_FAVORITOS_DA_PASTA_ATUAL_ABERTA(V_PASTA_A_ABRIR) 'AO ABRIR A PASTA LISTAR OS FAVORITOS

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_MUDAR_COR_DE_PASTA() 'MUDA A COR DA PASTA AO SELECIONAR O ITEM
        On Error Resume Next

        Dim V_CONTADOR As Integer = 0 'CONTADOR






        'RESTAURA VALOR DE PASTAS --------------------------------------------------------------------------------------

        For V_CONTADOR = V_CONTADOR To LST_PASTAS.Items.Count

            LST_PASTAS.Items.Item(V_CONTADOR).ImageIndex = 0 'RESTAURANDO

        Next

        '---------------------------------------------------------------------------------------------------------------




        'INFORMA A PASTA ABERTA ----------------------------------------------------------------------------------------

        LST_PASTAS.FocusedItem.ImageIndex = 1 'INFORMANDO

        LST_PASTAS.Refresh() 'ATUALIZANDO

        '---------------------------------------------------------------------------------------------------------------




    End Sub





    








    'PROCEDIMENTOS BASICOS

    Private Sub PROC_SETAR_FAV_ICON() 'SETA O FAVICON AO INICIAR
        On Error Resume Next

        V_END_DE_SITE_EM_VISUALIZACAO_FRM_FORMULARIO_DE_FAVORITOS = FUNC_RETORNE_END_SITE_EM_VISUALIZACAO() 'RETORNA O ENDEREÇO DO SITE EM VISUALIZAÇÃO

        BCK_FAVICON.RunWorkerAsync() 'RODANDO O PROCESSO DE FAVICON

    End Sub

    Public Sub PROC_ADD_SITE_EM_VISUALIZACAO() 'ADICIONA O SITE EM VISUALIZAÇÃO
        On Error Resume Next


        'SETA OBJETOS --------------------------------------------------------------------------------------------------

        TXT_END.Text = FUNC_RETORNE_END_SITE_EM_VISUALIZACAO() 'RETORNA O ENDEREÇO DO SITE EM VISUALIZAÇÃO

        TXT_TITULO.Text = FUNC_RETORNE_TITULO_SITE_EM_VISUALIZACAO() 'RETORNA O TITULO DO SITE EM VISUALIZAÇÃO

        '---------------------------------------------------------------------------------------------------------------




        'SETA O FAVICON ------------------------------------------------------------------------------------------------

        PROC_SETAR_FAV_ICON() 'SETA O FAVICON AO INICIAR

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_SALVAR_NOVO_SITE() 'SALVA O NOVO SITE
        On Error Resume Next

        Dim V_ENDERECO As String = TXT_END.Text 'ENDERÇO DO SITE

        Dim V_TITULO As String = FUNC_REMOVE_CARACTERES_ESPECIAIS(TXT_TITULO.Text) 'REMOVE OS CARACTERES ESPECIAIS

        Dim V_END_DE_PASTA As String = V_DIRETORIO_ATUAL 'ENDEREÇO DE PASTA






        'NÃO SALVAR VALORES NULOS --------------------------------------------------------------------------------------

        If (V_ENDERECO.Length = 0) Or (V_TITULO.Length = 0) Then

            TXT_END.Focus() 'MOVENDO O FOCO PARA O ENDEREÇO DE FAVORITO: URL

            Exit Sub 'SAINDO

        End If

        '---------------------------------------------------------------------------------------------------------------




        'SALVANDO FAVORITO ---------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(V_ENDERECO, V_END_DE_PASTA & "\" & V_TITULO & V_EXTENCAO_DE_ARQUIVO_4) 'SALVA O ARQUIVO

        '---------------------------------------------------------------------------------------------------------------




        'VERIFICA SE A IMAGEM POSSUI PIEXL -----------------------------------------------------------------------------

        If (PIC_FAVORITO.Image.PixelFormat = Nothing) Then

            PIC_FAVORITO.Image = IML_IMAGENS_2.Images.Item(0) 'NOVA IMAGEM

        End If

        '---------------------------------------------------------------------------------------------------------------




        'SALVANDO VALOR E IMAGEM ---------------------------------------------------------------------------------------

        PIC_FAVORITO.Image.Save(V_END_DE_PASTA & "\" & V_TITULO & V_EXTENCAO_DE_ARQUIVO_3) 'SALVANDO IMAGEM

        '---------------------------------------------------------------------------------------------------------------




        'LIMPA OS CAMPOS -----------------------------------------------------------------------------------------------

        PROC_LIMPAR_CAMPOS() 'LIMPAR CAMPOS

        '---------------------------------------------------------------------------------------------------------------




        'LISTAR FAVORITOS AGORA ----------------------------------------------------------------------------------------

        PROC_LISTAR_PASTAS_DOS_FAVORITOS(V_DIRETORIO_ATUAL) 'LISTA AS PASTAS DOS FAVORITOS

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_LIMPAR_CAMPOS() 'LIMPAR CAMPOS
        On Error Resume Next

        TXT_END.Clear() 'LIMPANDO

        TXT_TITULO.Clear() 'LIMPANDO

    End Sub

    Private Sub PROC_ABRIR_O_FAVORITO() 'ABRE O FAVORITO
        On Error Resume Next

        Dim V_URL As String = FUNC_LER_ARQUIVO(V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR) 'LÊ CONFIG DE ARQUIVO






        'INFORMA ENDEREÇO DE FAVORITO, E SE ELE É UM ARQUIVO -----------------------------------------------------------

        V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR = LST_SITES.FocusedItem.ToolTipText 'INFORMA O ENDEREÇO NO HD DO FAVORITO

        V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR_PASTA_OU_ARQUIVO = True 'INFORMA QUE É ARQUIVO

        '---------------------------------------------------------------------------------------------------------------




        'ABRINDO FAVORITO ----------------------------------------------------------------------------------------------

        PROC_NAVEGAR(V_URL) 'NAVEGA NO ENDEREÇO DE SITE INFORMADO

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub PROC_NOVA_PASTA() 'NOVA PASTA
        On Error Resume Next

        Dim V_NOME_DE_NOVA_PASTA As String = InputBox("Informe o nome da nova pasta", "Nova pasta") 'CAIXA DE ENTRADA

        Dim V_PASTA_A_CRIAR As String = Nothing 'PASTA A CRIAR






        'PROCESSANDO VALOR OBTIDO ------------------------------------------------

        If (V_NOME_DE_NOVA_PASTA = "") Or (V_NOME_DE_NOVA_PASTA = Nothing) Then

            Exit Sub 'SAINDO...

        End If

        '--------------------------------------------------------------------------




        'REMOVE VALORES INVALIDOS -----------------------------------------------------------------------------------------------------

        V_NOME_DE_NOVA_PASTA = FUNC_REMOVE_CARACTERES_ESPECIAIS(V_NOME_DE_NOVA_PASTA) 'REMOVE OS CARACTERES ESPECIAIS

        '------------------------------------------------------------------------------------------------------------------------------




        'DETERMINA O ENDERECO DA PASTA ---------------------------------------------------------------------------------

        V_PASTA_A_CRIAR = V_DIRETORIO_ATUAL & "\" & V_NOME_DE_NOVA_PASTA 'OBTEM NOME

        '---------------------------------------------------------------------------------------------------------------




            'VERIFICA SE PASTA EXISTE ------------------------------------------------------------------------------------------------------------------------------------

        If (FUNC_RETORNA_SE_PASTA_EXISTE_OU_NAO(V_PASTA_A_CRIAR) = False) Then




            'CRIANDO PASTA ---------------------------------------------------------------------------------------------

            My.Computer.FileSystem.CreateDirectory(V_PASTA_A_CRIAR) 'CRIANDO A PASTA

            '-----------------------------------------------------------------------------------------------------------




        Else


            MsgBox("A pasta " & V_NOME_DE_NOVA_PASTA & " já existe, escolha outro nome.", MsgBoxStyle.Exclamation, "Já existe!") 'MENSAGEM


        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'LISTAR FAVORITOS AGORA ----------------------------------------------------------------------------------------

        PROC_LISTAR_PASTAS_DOS_FAVORITOS(V_DIRETORIO_ATUAL) 'LISTA AS PASTAS DOS FAVORITOS

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_REMOVER_PASTA_SELECIONADA() 'REMOVE A PASTA SELECIONADCA
        On Error Resume Next

        Dim V_PASTA_A_EXCLUIR As String = V_DIRETORIO_ATUAL 'PASTA A EXCLUIR

        Dim V_DIRETORIO_ANTERIOR As String = Directory.GetParent(V_DIRETORIO_ATUAL).ToString 'OBTÉM O DIRETÓRIO ANTERIOR






        'PERGUNTA SE O USUARIO DESEJA REMOVER A PASTA ----------------------------------------------------------------------------------------------------------------

        My.Computer.FileSystem.DeleteDirectory(V_PASTA_A_EXCLUIR, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.DeletePermanently) 'PERGUNTA

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'LISTAR FAVORITOS AGORA ----------------------------------------------------------------------------------------

        PROC_FAVORITOS_INICIO() 'VOLTA PRO INICIO EM FAVORITOS

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_INFORME_DADOS_BASICOS_DE_FAV_SELECIONADO(ByVal V_ORIGEM As String) 'AO SELECIONAR UM FAVORITO INFORMAR SEUS DADOS BASICOS
        On Error Resume Next

        Dim V_CONTEUDO As String = FUNC_LER_ARQUIVO(V_ORIGEM) 'LENDO O CONTEUDO DE ARQUIVO

        Dim V_NOME_DE_FAV_SELECIONADO_OBTER As String = Path.GetFileName(V_ORIGEM).Replace(Path.GetExtension(V_ORIGEM), Nothing)

        Dim V_CRIACAO_DE_FAV As New FileInfo(V_ORIGEM) 'DATA DE CRIAÇÃO DO FAVORITO






        'INFORMA DADOS BASICOS DE FAVORITO SELECIONADO -----------------------------------------------------------------

        TXT_URL_FAV.Text = V_CONTEUDO 'URL DO FAVORITO

        TXT_TITULO_FAV.Text = V_NOME_DE_FAV_SELECIONADO_OBTER 'TITULO DO FAVORITO

        LBL_DATA_ALTERACAO.Text = V_CRIACAO_DE_FAV.LastWriteTime 'ULTIMA ALTERAÇÃO DO FAVORITO

        '---------------------------------------------------------------------------------------------------------------




        'INFORMA ENDEREÇO DE FAVORITO, E SE ELE É UM ARQUIVO -----------------------------------------------------------

        V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR = LST_SITES.FocusedItem.ToolTipText 'INFORMA O ENDEREÇO NO HD DO FAVORITO

        V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR_PASTA_OU_ARQUIVO = True 'INFORMA QUE É ARQUIVO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_ALTERAR_DADOS_DO_FAVORITO_SELECIONADO() 'ALTERA OS DADOS DO FAVORITO SELECIONADO
        On Error Resume Next

        Dim V_ORIGEM As String = LST_SITES.FocusedItem.ToolTipText 'ORIGEM DE ARQUIVO DE FAVORITO SELECIONADO

        Dim V_NOVA_URL_DE_FAVORITO As String = TXT_URL_FAV.Text 'NOVA URL DE FAVORITO






        'SALVANDO URL DE FAVORITO --------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(V_NOVA_URL_DE_FAVORITO, V_ORIGEM) 'SALVANDO NOVA URL DE FAVORITO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_VOLTAR_UMA_PASTA_DE_FAVORITO() 'VOLTA UMA PASTA NO FAVORITO
        On Error Resume Next

        Dim V_DIRETORIO_ANTERIOR As String = Directory.GetParent(V_DIRETORIO_ATUAL).ToString 'OBTÉM O DIRETÓRIO ANTERIOR






        'ATUALIZA LISTA DE PASTAS A AVANÇAR POSTERIORMENTE -------------------------------------------------------------

        ARRAY_DIRETORIOS_A_AVANCAR_EM_FAVORITOS.Add(V_DIRETORIO_ATUAL) 'ATUALIZANDO

        '---------------------------------------------------------------------------------------------------------------




        'LISTA TODAS AS PASTAS E FAVORITOS -----------------------------------------------------------------------------

        PROC_LISTAR_PASTAS_DOS_FAVORITOS(V_DIRETORIO_ANTERIOR) 'LISTA AS PASTAS DOS FAVORITOS

        '---------------------------------------------------------------------------------------------------------------




        'HABILITA O BOTÃO AVANÇAR --------------------------------------------------------------------------------------

        CMD_AVANCAR.Enabled = True 'HABILITANDO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_AVANCAR_UMA_PASTA_DE_FAVORITO() 'AVANÇA UMA PASTA DE FAVORITO
        On Error Resume Next

        Dim V_VALOR_DE_ARRAY As String 'LENDO VALOR DE ARRAY






        'ATUALIZANDO O CONTADOR ----------------------------------------------------------------------------------------

        V_CONTADOR = V_CONTADOR + 1 'ATUALIZANDO

        '---------------------------------------------------------------------------------------------------------------




        'LENDO VALOR DE ARRAY ------------------------------------------------------------------------------------------

        If (V_CONTADOR - ARRAY_DIRETORIOS_A_AVANCAR_EM_FAVORITOS.Count = 1) Then




            V_CONTADOR = 0 'ZERA O CONTADOR

            V_CONTADOR_2 = 0 'ZERA O CONTADOR

            ARRAY_DIRETORIOS_A_AVANCAR_EM_FAVORITOS.Clear() 'LIMPANDO ARRAY

            CMD_AVANCAR.Enabled = False 'DESABILITA O BOTÃO A VANÇAR

            Exit Sub 'SAINDO DE PROCEDIMENTO




        Else




            V_CONTADOR_2 = ARRAY_DIRETORIOS_A_AVANCAR_EM_FAVORITOS.Count - V_CONTADOR 'ATUALIZA O CONTADOR 2

            V_VALOR_DE_ARRAY = ARRAY_DIRETORIOS_A_AVANCAR_EM_FAVORITOS(V_CONTADOR_2) 'OBTÉM O CONTEUDO DE ARRAY

            CMD_AVANCAR.Enabled = True 'HABILITA O BOTÃO AVANÇAR




        End If

        '---------------------------------------------------------------------------------------------------------------




        'DESABILITA O BOTÃO AVANÇAR ------------------------------------------------------------------------------------

        If (V_CONTADOR = ARRAY_DIRETORIOS_A_AVANCAR_EM_FAVORITOS.Count) Then


            CMD_AVANCAR.Enabled = False 'DESABILITA O BOTÃO A VANÇAR


        End If

        '---------------------------------------------------------------------------------------------------------------




        'LISTA TODAS AS PASTAS E FAVORITOS -----------------------------------------------------------------------------

        PROC_LISTAR_PASTAS_DOS_FAVORITOS(V_VALOR_DE_ARRAY) 'LISTA AS PASTAS DOS FAVORITOS

        '---------------------------------------------------------------------------------------------------------------



    End Sub

    Private Sub PROC_FAVORITOS_INICIO() 'VOLTA PRO INICIO EM FAVORITOS
        On Error Resume Next


        'LISTA TODAS AS PASTAS E FAVORITOS -----------------------------------------------------------------------------

        PROC_LISTAR_PASTAS_DOS_FAVORITOS(V_PASTA_DE_MEUS_FAVORITOS_END) 'LISTA AS PASTAS DOS FAVORITOS

        '---------------------------------------------------------------------------------------------------------------




        'DESABILITA O BOTÃO AVANÇAR E LIMPA ARRAY ----------------------------------------------------------------------

        ARRAY_DIRETORIOS_A_AVANCAR_EM_FAVORITOS.Clear() 'LIMPA ARRAY DE PASTAS A AVANÇAR

        V_CONTADOR = 0 'ZERA O CONTADOR

        V_CONTADOR_2 = 0 'ZERA O CONTADOR

        CMD_AVANCAR.Enabled = False 'DESABILITA O BOTÃO A VANÇAR

        '---------------------------------------------------------------------------------------------------------------


    End Sub














    'PROCEDIMENTOS DE IMPORTAR E EXPORTAR

    Private Sub PROC_IMPORTAR_EXPORTAR() 'PARA IMPORTAR TRUE, PARA EXPORTAR FALSE
        On Error Resume Next


        'COPIANDO PASTAS ----------------------------------------------------------------------------------------------------------------------------

        If (V_EXPORTAR_IMPORTAR_ACAO_ATUAL = True) Then


            PROC_COPIAR_PASTAS(V_PASTA_DE_MEUS_FAVORITOS_END, V_IMPORTAR_EXPORTAR_PASTA_INFORMADA) 'COPIA A PASTA DE ORIGEM PARA A PASTA DE DESTINO


        Else


            PROC_COPIAR_PASTAS(V_IMPORTAR_EXPORTAR_PASTA_INFORMADA, V_PASTA_DE_MEUS_FAVORITOS_END) 'COPIA A PASTA DE ORIGEM PARA A PASTA DE DESTINO


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_INICIAR_EXPORTAR_IMPORTAR() 'INICIA O EXPORTAR OU O IMPORTAR
        On Error Resume Next

        Dim V_PASTA_INFORMADA_A_ANALISAR As String = TXT_LOCAL_COPIA_DE_FAVORITOS.Text 'PASTA INFORMADA PELO USUÁRIO A SER ANALISADA






        'VERIFICA E INFORMA SE A PASTA EXISTE OU NAO ----------------------------------------------------------------------------------------------------------------------------------------

        If (FUNC_RETORNA_SE_PASTA_EXISTE_OU_NAO(V_PASTA_INFORMADA_A_ANALISAR) = False) Then


            MsgBox("A pasta '" & V_PASTA_INFORMADA_A_ANALISAR & "' não existe!", MsgBoxStyle.Exclamation, "Pasta não existe") 'INFORMA AO USUÁRIO QUE A PASTA NÃO EXISTE

            TXT_LOCAL_COPIA_DE_FAVORITOS.Focus() 'MOVE O FOCO PARA ENDEREÇO DE PASTA

            Exit Sub 'SAINDO DO PROCEDIMENTO


        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ALTERA PROPRIEDADES DE PROGRESSO ------------------------------------------------------------------------------

        ProgressBar1.Style = ProgressBarStyle.Marquee 'TIPO DE PROGRESSO

        Label7.Text = "Copia iniciada aguarde..." 'INFORMA QUE A COPIA FOI INICIADA

        '---------------------------------------------------------------------------------------------------------------




        'DEFINE LOCAL DA PASTA -----------------------------------------------------------------------------------------

        V_IMPORTAR_EXPORTAR_PASTA_INFORMADA = TXT_LOCAL_COPIA_DE_FAVORITOS.Text 'PASTA DE IMPORTAÇÃO OU EXPORTAÇÃO

        '---------------------------------------------------------------------------------------------------------------




        'INICIANDO PROCESSO DE COPIA -----------------------------------------------------------------------------------

        BCK_COPIA.RunWorkerAsync() 'RODANDO PROCESSO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_EXPORTAR_IMPORTAR_CONCLUIDO() 'EXPORTAR E IMPORTAR CONCLUIDO
        On Error Resume Next


        'INFORMANDO QUE O PROGRESSO FOI CONCLUIDO ----------------------------------------------------------------------

        ProgressBar1.Style = ProgressBarStyle.Blocks 'TIPO DE PROGRESSO

        Label7.Text = "Cópia feita com sucesso!" 'Informa que a copia foi feita

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_CANCELA_EXPORTAR_E_IMPORTAR() 'CANCELA O IMPORTAR E O EXPORTAR
        On Error Resume Next


        'INFORMANDO QUE O PROGRESSO FOI CONCLUIDO ----------------------------------------------------------------------

        ProgressBar1.Style = ProgressBarStyle.Blocks 'TIPO DE PROGRESSO

        Label7.Text = "A cópia foi parada!" 'Informa que a copia foi feita

        '---------------------------------------------------------------------------------------------------------------




        'PARANDO PROCESSO ----------------------------------------------------------------------------------------------

        BCK_COPIA.CancelAsync() 'CANCELANDO...

        '---------------------------------------------------------------------------------------------------------------




    End Sub

    Private Sub PROC_ALTERAR_PASTA_EXPORTAR_E_IMPORTAR() 'ALTERA A PASTA DE EXPORTAR E IMPORTAR
        On Error Resume Next


        'NOVO DIÁLOGO --------------------------------------------------------------------------------------------------

        OBJ_DIALOGO_ABRIR_PASTA = New FolderBrowserDialog 'NOVA CAIXA DE DIÁLOGO DE OBTER SOMENTE ENDEREÇO DE PASTA

        '---------------------------------------------------------------------------------------------------------------





        'SETA A NOVA PASTA DE COPIA ------------------------------------------------------------------------------------

        If (OBJ_DIALOGO_ABRIR_PASTA.ShowDialog = Windows.Forms.DialogResult.OK) Then


            TXT_LOCAL_COPIA_DE_FAVORITOS.Text = OBJ_DIALOGO_ABRIR_PASTA.SelectedPath 'PASTA SELECIONADCA


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_NOVO_FAVORITO_LIMPAR_DADOS_ANTIGOS() 'LIMPA OS DADOS ANTIGOS PARA NOVO FAVORITO
        On Error Resume Next


        'LIMPA CONTROLES E MOVE O FOCO PARA O ENDEREÇO E FAVORITO ------------------------------------------------------

        TXT_END.Clear() 'LIMPA URL

        TXT_TITULO.Clear() 'LIMPA TITULO

        PIC_FAVORITO.Image = IML_IMAGENS_2.Images.Item(0) 'RESTAURA IMAGEM

        TXT_END.Focus() 'MOVENDO O FOCO

        '---------------------------------------------------------------------------------------------------------------


    End Sub



























    Private Sub FRM_FORMULARIO_DE_FAVORITOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next


        'APLICA O FADIN ------------------------------------------------------------------------------------------------

        PROC_APLICAR_FADIN_EM_FORMULARIO(Me) 'APLICA O FADIN EM FORMULARIO

        '---------------------------------------------------------------------------------------------------------------




        'SOM DE SISTEMA ------------------------------------------------------------------------------------------------

        PROC_EXIBIR_SOM_DE_SISTEMA(0) 'EXIBE OS SONS INSTALADOS NO SISTEMA

        '---------------------------------------------------------------------------------------------------------------




        'LISTAR PASTAS E FAVORITOS -------------------------------------------------------------------------------------

        PROC_FAVORITOS_INICIO() 'VOLTA PRO INICIO EM FAVORITOS

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub LST_PASTAS_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LST_PASTAS.DoubleClick
        On Error Resume Next

        PROC_MUDAR_COR_DE_PASTA() 'MUDA A COR DA PASTA AO SELECIONAR O ITEM

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        On Error Resume Next

        PROC_ABRIR_O_FAVORITO() 'ABRE O FAVORITO

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next

        PROC_NOVA_PASTA() 'NOVA PASTA

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error Resume Next

        PROC_REMOVER_PASTA_SELECIONADA() 'REMOVE A PASTA SELECIONADCA

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        On Error Resume Next

        PROC_REMOVE_PASTA_DE_FAV_OU_O_FAVORITO() 'REMOVE O FAVORITO OU A PASTA

        PROC_LISTAR_PASTAS_DOS_FAVORITOS(V_DIRETORIO_ATUAL) 'LISTA AS PASTAS DOS FAVORITOS

    End Sub

    Private Sub BCK_COPIA_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BCK_COPIA.DoWork
        On Error Resume Next

        PROC_IMPORTAR_EXPORTAR() 'PARA IMPORTAR TRUE, PARA EXPORTAR FALSE

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        On Error Resume Next

        V_EXPORTAR_IMPORTAR_ACAO_ATUAL = False 'IMPORTA

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        On Error Resume Next

        V_EXPORTAR_IMPORTAR_ACAO_ATUAL = True 'EXPORTA

    End Sub

    Private Sub BCK_COPIA_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BCK_COPIA.RunWorkerCompleted
        On Error Resume Next

        PROC_EXPORTAR_IMPORTAR_CONCLUIDO() 'EXPORTAR E IMPORTAR CONCLUIDO

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        On Error Resume Next

        PROC_INICIAR_EXPORTAR_IMPORTAR() 'INICIA O EXPORTAR OU O IMPORTAR

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        On Error Resume Next

        PROC_CANCELA_EXPORTAR_E_IMPORTAR() 'CANCELA O IMPORTAR E O EXPORTAR

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        On Error Resume Next

        PROC_ALTERAR_PASTA_EXPORTAR_E_IMPORTAR() 'ALTERA A PASTA DE EXPORTAR E IMPORTAR

    End Sub

    Private Sub BCK_FAVICON_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BCK_FAVICON.DoWork
        On Error Resume Next


        'OBTENDO A IMAGEM DE FAVICON -------------------------------------------------------------------------------------------------------------------------------------

        OBJ_IMAGEM_DE_FAVICON_DE_FAVORITO = FUNC_GERAR_FAVICON_DA_URL(V_END_DE_SITE_EM_VISUALIZACAO_FRM_FORMULARIO_DE_FAVORITOS) 'GERA O FAVICON DA URL INFORMADA

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub BCK_FAVICON_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BCK_FAVICON.RunWorkerCompleted
        On Error Resume Next


        'SETANDO IMAGEM ---------------------------------------------------------------

        PIC_FAVORITO.Image = OBJ_IMAGEM_DE_FAVICON_DE_FAVORITO 'OBTENDO A IMAGEM

        '------------------------------------------------------------------------------

    End Sub

    Private Sub FRM_FORMULARIO_DE_FAVORITOS_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next


        'LIMPA OS CAMPOS -----------------------------------------------------------------------------------------------

        PROC_LIMPAR_CAMPOS() 'LIMPAR CAMPOS

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub LST_SITES_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LST_SITES.MouseDoubleClick
        On Error Resume Next

        PROC_ABRIR_O_FAVORITO() 'ABRE O FAVORITO

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        On Error Resume Next

        PROC_NOVO_FAVORITO_LIMPAR_DADOS_ANTIGOS() 'LIMPA OS DADOS ANTIGOS PARA NOVO FAVORITO

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        On Error Resume Next

        PROC_ADD_SITE_EM_VISUALIZACAO() 'ADICIONA O SITE EM VISUALIZAÇÃO

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        On Error Resume Next

        PROC_SALVAR_NOVO_SITE() 'SALVA O NOVO SITE

    End Sub

    Private Sub LST_SITES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LST_SITES.SelectedIndexChanged
        On Error Resume Next

        PROC_INFORME_DADOS_BASICOS_DE_FAV_SELECIONADO(LST_SITES.FocusedItem.ToolTipText) 'AO SELECIONAR UM FAVORITO INFORMAR SEUS DADOS BASICOS

    End Sub

    Private Sub TXT_URL_FAV_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_URL_FAV.TextChanged
        On Error Resume Next

        PROC_ALTERAR_DADOS_DO_FAVORITO_SELECIONADO() 'ALTERA OS DADOS DO FAVORITO SELECIONADO

    End Sub

    Private Sub TXT_LOCAL_COPIA_DE_FAVORITOS_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TXT_LOCAL_COPIA_DE_FAVORITOS.MouseDoubleClick
        On Error Resume Next


        'SELECIONA TUDO -----------------------------------------------------------------------

        TXT_LOCAL_COPIA_DE_FAVORITOS.SelectAll() 'SELECIONA TUDO

        '--------------------------------------------------------------------------------------

    End Sub

    Private Sub TXT_LOCAL_COPIA_DE_FAVORITOS_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_LOCAL_COPIA_DE_FAVORITOS.KeyDown
        On Error Resume Next


        'AO PRESSIONAR ENTER, ENTÃO COPIAR OU SALVAR OS FAVORITOS ------------------------------------------------------

        If (e.KeyCode = Keys.Enter) Then


            e.SuppressKeyPress = True 'SEM BEEP

            PROC_INICIAR_EXPORTAR_IMPORTAR() 'INICIA O EXPORTAR OU O IMPORTAR


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub LST_PASTAS_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LST_PASTAS.MouseDoubleClick
        On Error Resume Next


        'LISTAR PASTAS E FAVORITOS -------------------------------------------------------------------------------------

        PROC_LISTAR_PASTAS_DOS_FAVORITOS(LST_PASTAS.FocusedItem.ToolTipText) 'LISTA AS PASTAS DOS FAVORITOS

        '---------------------------------------------------------------------------------------------------------------




        'DESABILITA O BOTÃO AVANÇAR E LIMPA ARRAY ----------------------------------------------------------------------

        ARRAY_DIRETORIOS_A_AVANCAR_EM_FAVORITOS.Clear() 'LIMPA ARRAY DE PASTAS A AVANÇAR

        V_CONTADOR = 0 'ZERA O CONTADOR

        V_CONTADOR_2 = 0 'ZERA O CONTADOR

        CMD_AVANCAR.Enabled = False 'DESABILITA O BOTÃO A VANÇAR

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub LST_PASTAS_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LST_PASTAS.MouseClick
        On Error Resume Next


        'INFORMA A PASTA ATUAL -----------------------------------------------------------------------------------------

        V_DIRETORIO_ATUAL = LST_PASTAS.FocusedItem.ToolTipText 'INFORMANDO A PASTA ATUAL

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_VOLTAR.Click
        On Error Resume Next

        PROC_VOLTAR_UMA_PASTA_DE_FAVORITO() 'VOLTA UMA PASTA NO FAVORITO

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_AVANCAR.Click
        On Error Resume Next

        PROC_AVANCAR_UMA_PASTA_DE_FAVORITO() 'AVANÇA UMA PASTA DE FAVORITO

    End Sub

    Private Sub TXT_END_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_END.KeyDown
        On Error Resume Next


        'AO PRESSIONAR ENTER SALVAR NOVO FAVORITO ----------------------------------------------------------------------

        If (e.KeyCode = Keys.Enter) Then


            e.SuppressKeyPress = True 'SEM BEEP

            PROC_SALVAR_NOVO_SITE() 'SALVA O NOVO SITE


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub TXT_TITULO_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_TITULO.KeyDown
        On Error Resume Next


        'AO PRESSIONAR ENTER SALVAR NOVO FAVORITO ----------------------------------------------------------------------

        If (e.KeyCode = Keys.Enter) Then


            e.SuppressKeyPress = True 'SEM BEEP

            PROC_SALVAR_NOVO_SITE() 'SALVA O NOVO SITE


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next

        PROC_FAVORITOS_INICIO() 'VOLTA PRO INICIO EM FAVORITOS

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        On Error Resume Next

        PROC_FAVORITOS_INICIO() 'VOLTA PRO INICIO EM FAVORITOS

    End Sub

End Class