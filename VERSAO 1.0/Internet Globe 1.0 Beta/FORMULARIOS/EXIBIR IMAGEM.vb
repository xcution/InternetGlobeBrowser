Imports System.Net
Imports System.IO




Public Class FRM_EXIBIR_IMAGEM


    'Variáveis basicas

    Public v_endereco_da_imagem_em_visualizacao As String = Nothing 'Informa o endereço da imagem em visualização

    Dim v_tamanho As Long 'Tamanho do arquivo

    Dim v_nome_do_download As String 'Nome da imagem

    Dim v_extencao As String 'Extenção da imagem











    'Procedimentos basicos

    Private Sub proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual
        On Error Resume Next

        Me.Opacity = V_VAL_CONFIG_TRANSPARENCIA 'Aplicando a transparencia

    End Sub

    Private Sub proc_copiar_endereco_da_imagem() 'Copia o endereço da imagem
        On Error Resume Next

        My.Computer.Clipboard.SetText(v_endereco_da_imagem_em_visualizacao) 'Setando o endereço da imagem para a ram

    End Sub

    Private Sub proc_sair() 'Sair do formulario atual
        On Error Resume Next

        Me.Close() 'Saindo...

    End Sub

    Private Sub proc_salvar_a_imagem() 'Salvar imagem no computador
        On Error Resume Next

        Dim nv_download As New FRM_DOWNLOADER 'Nova instancia de download






        'Não permite continuar em caso de campo em branco -----------------------------------

        If (v_endereco_da_imagem_em_visualizacao = Nothing) Then

            Exit Sub 'Saida

        End If

        '------------------------------------------------------------------------------------




        'Desativa o topmost -----------------------------------------------------------------

        Me.TopMost = False 'Desativando

        '------------------------------------------------------------------------------------




        'Definindo propriedades -------------------------------------------------------------

        nv_download.v_origem = v_endereco_da_imagem_em_visualizacao 'Origem de download

        '------------------------------------------------------------------------------------




        'Abrindo ----------------------------------------------------------------------------

        nv_download.Show() 'Abrindo

        '------------------------------------------------------------------------------------



    End Sub

    Private Sub proc_obter_informacoes_gerais() 'Obter informações do arquivo
        On Error Resume Next


        Dim REQUISICAO As System.Net.WebRequest

        Dim RESPOSTA As System.Net.WebResponse

        Dim TAMANHO As Long

        Dim NOME As String

        Dim array_de_extencao As Array

        Dim v_separador As String = "/"

        Dim v_posicao_da_extencao As Integer






        'Obtendo requisição -----------------------------------------------------------------------------------


        REQUISICAO = System.Net.HttpWebRequest.Create(v_endereco_da_imagem_em_visualizacao) 'Criando requisição

        REQUISICAO.Method = "HEAD" 'Methodo somente leitura

        '------------------------------------------------------------------------------------------------------



        'Obtendo resposta -------------------------------------------------------------------------------------

        RESPOSTA = REQUISICAO.GetResponse 'Obtendo resposta

        '------------------------------------------------------------------------------------------------------



        'Obtendo tamanho de arquivo ------------------------------------------------------------------------------------------------------------------------------------------


        TAMANHO = (RESPOSTA.Headers.Get("Content-Length"))

        v_tamanho = TAMANHO / 1024


        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------



        'Nome do arquivo --------------------------------------------------------------------------------------------------------------------------

        NOME = v_endereco_da_imagem_em_visualizacao.Substring(v_endereco_da_imagem_em_visualizacao.LastIndexOf("/") + 1, (v_endereco_da_imagem_em_visualizacao.Length - v_endereco_da_imagem_em_visualizacao.LastIndexOf("/") - 1))

        v_nome_do_download = NOME

        '------------------------------------------------------------------------------------------------------------------------------------------



        'Extenção -----------------------------------------------------------------------------------------------------------------------------------------

        array_de_extencao = Split(v_endereco_da_imagem_em_visualizacao, v_separador) 'Obtendo array

        v_extencao = (array_de_extencao(array_de_extencao.Length - 1)) 'Obtendo nome do download

        v_posicao_da_extencao = v_extencao.IndexOf(".") 'Obtendo onde começa a extenção

        v_extencao = v_extencao.Remove(0, v_posicao_da_extencao) 'Removendo até o ponto da extenção

        v_extencao = v_extencao.ToLower 'Convertendo para minúsculo

        '--------------------------------------------------------------------------------------------------------------------------------------------------




        'Fechando requisiçoes -------------------------------------------

        REQUISICAO.GetRequestStream.Close()

        RESPOSTA.Close()

        '----------------------------------------------------------------


    End Sub

    Private Sub proc_repassar_informacoes() 'Repassa as informacoes obtidas
        On Error Resume Next

        LabelX3.Text = v_extencao 'Extenção 

        LabelX4.Text = v_tamanho & " Kilobytes" 'Tamanho

        LabelX6.Text = v_nome_do_download 'Informa o nome da imagem

    End Sub

    Public Sub proc_obter_informacoes() 'Obtendo informações agora
        On Error Resume Next

        BackgroundWorker1.RunWorkerAsync() 'Rodando...

    End Sub

























    Private Sub FRM_EXIBIR_IMAGEM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        On Error Resume Next

        proc_copiar_endereco_da_imagem() 'Copia o endereço da imagem

    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        On Error Resume Next

        proc_sair() 'Sair do formulario atual

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        On Error Resume Next

        proc_salvar_a_imagem() 'Salvar imagem no computador

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        On Error Resume Next

        proc_obter_informacoes_gerais() 'Obter informações do arquivo

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        On Error Resume Next

        proc_repassar_informacoes() 'Repassa as informacoes obtidas

    End Sub

End Class