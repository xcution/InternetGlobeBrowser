Imports System.Net
Imports System.IO


Public Class FRM_DOWNLOADER


    'Informações de início sobre download

    Public v_origem As String 'Origem de download

    Public v_destino As String 'Destino de download


    'Variáveis de informações

    Dim v_nome_do_download As String 'Nome do download

    Dim v_tamanho As Long 'Tamanho do arquivo

    Dim v_tamanho_completo As Long 'Tamanho completado do download

    Dim v_download_online As Boolean 'Informa se o download está ou não online

    Dim v_velocidade_de_download As Integer 'Velocidade do download

    Dim v_download_completo As Boolean 'Informa que o download está completo

    Dim v_extencao As String 'Informa a extenção do arquivo

    Dim v_medida_de_tamanho(3) As String 'Tipo de medida de tamanho de download

    Dim v_dados_recebidos_convertido As Long 'Informa a quantidade de dados recebidos já convertidos

    Dim v_dados_a_receber_convertidos As Long 'Dados a receber já converttidos









    'Procedimentos do download

    Private Sub proc_download() 'Inicia o processo de download do arquivo
        On Error Resume Next


        'Criar requisição e resposta -----------------------------------------------------------------------------------

        Dim V_RESPOSTA As HttpWebResponse 'Resposta

        Dim V_REQUISICAO As HttpWebRequest 'Requisição

        Dim V_ESCREVER_DADOS As New IO.FileStream(v_destino, IO.FileMode.OpenOrCreate) 'Arquivo de fluxo

        '---------------------------------------------------------------------------------------------------------------




        'Fazendo requisições -------------------------------------------------------------------------------------------

        V_REQUISICAO = WebRequest.Create(v_origem) 'Criando requisição

        V_REQUISICAO.Proxy = Nothing 'Não usar proxy

        V_REQUISICAO.AddRange(V_ESCREVER_DADOS.Length) 'Aqui informa para baixar o restante depois de onde parou

        V_RESPOSTA = V_REQUISICAO.GetResponse 'Resposta

        '---------------------------------------------------------------------------------------------------------------




        'Define onde parou pela última vez -----------------------------------------------------------------------------

        V_ESCREVER_DADOS.Seek(V_ESCREVER_DADOS.Length, SeekOrigin.Current) 'Começando de onde parou

        '---------------------------------------------------------------------------------------------------------------




        'Parte responsável pelo cálculo de velocidade ------------------------------------------------------------------

        Dim speedtimer As New Stopwatch

        Dim currentspeed As Double = -1

        Dim readings As Integer = 0

        '---------------------------------------------------------------------------------------------------------------




        'Escrever dados no disco enquanto não achar o final ----------------------------------------------------------------------------------

        Do

            'Caso o usuário cancelar -----------------------------------------------------------------------------------

            If bck_download.CancellationPending Then




                'Fechando arquivos abertos -----------------------------------------------------------------------------

                V_RESPOSTA.GetResponseStream.Close() 'Fechando resposta

                V_ESCREVER_DADOS.Close() 'Fechando fluxo de dados

                '-------------------------------------------------------------------------------------------------------




                'Saindo -----------------------

                Exit Do 'Sair ...

                '------------------------------




            End If

            '-----------------------------------------------------------------------------------------------------------




            speedtimer.Start() 'Ativar timer




            'Buffer ----------------------------------------------------------------------------------------------------

            Dim readBytes(4095) As Byte 'Buffer

            '-----------------------------------------------------------------------------------------------------------



            '*Se houver problemas com buffer é só mudar de readBytes.Length para 4096 ---------------------------------------------------------

            Dim bytesread As Integer = V_RESPOSTA.GetResponseStream.Read(readBytes, 0, readBytes.Length) 'Lendo e alocando dados em buffer

            '----------------------------------------------------------------------------------------------------------------------------------




            'Informando a quantidade de bytes baixados -----------------------------------------------------------------

            v_tamanho_completo = v_tamanho_completo + bytesread 'Atualizando...

            '-----------------------------------------------------------------------------------------------------------




            'Caso não tenha mais bytes para baixar então pode sair do looping ------------------------------------------

            If (bytesread = 0) Then


                v_download_completo = True 'Informa que o download está completo


                Exit Do 'Saindo


            Else


                v_download_completo = False 'Informa que o download ainda não está completo


            End If

            '-----------------------------------------------------------------------------------------------------------




            'Escrevendo dados do buffer no arquivo de fluxo ------------------------------------------------------------

            V_ESCREVER_DADOS.Write(readBytes, 0, bytesread)

            '-----------------------------------------------------------------------------------------------------------




            speedtimer.Stop() 'Parar timer




            'Calculando velocidade --------------------------------------------------------------------------------

            readings += 1

            If readings >= 5 Then 'For increase precision, the speed it's calculated only every five cicles


                currentspeed = 20480 / (speedtimer.ElapsedMilliseconds / 1000)

                v_velocidade_de_download = Convert.ToInt32(currentspeed / 1024 / 2)

                speedtimer.Reset()

                readings = 0


            End If

            '------------------------------------------------------------------------------------------------------


        Loop

        '-------------------------------------------------------------------------------------------------------------------------------------




        'Fechando arquivos abertos -------------------------------------------------------------------------------------

        V_RESPOSTA.GetResponseStream.Close() 'Fechando resposta

        V_ESCREVER_DADOS.Close() 'Fechando fluxo de dados

        '---------------------------------------------------------------------------------------------------------------




    End Sub

    Private Sub proc_obter_informacoes() 'Obter informações do arquivo
        On Error Resume Next

        'Variáveis de requisicao

        Dim REQUISICAO As System.Net.WebRequest

        Dim RESPOSTA As System.Net.WebResponse

        Dim TAMANHO As Long

        Dim NOME As String

        Dim array_de_extencao As Array

        Dim v_separador As String = "/"

        Dim v_posicao_da_extencao As Integer






        'Obtendo requisição --------------------------------------------------------------------------------------------

        REQUISICAO = System.Net.HttpWebRequest.Create(v_origem) 'Criando requisição

        REQUISICAO.Method = "HEAD" 'Methodo somente leitura

        '---------------------------------------------------------------------------------------------------------------




        'Obtendo resposta ----------------------------------------------------------------------------------------------

        RESPOSTA = REQUISICAO.GetResponse 'Obtendo resposta

        '---------------------------------------------------------------------------------------------------------------




        'Obtendo tamanho de arquivo ------------------------------------------------------------------------------------

        TAMANHO = (RESPOSTA.Headers.Get("Content-Length"))

        v_tamanho = TAMANHO

        '---------------------------------------------------------------------------------------------------------------




        'Nome do arquivo -----------------------------------------------------------------------------------------------

        NOME = v_origem.Substring(v_origem.LastIndexOf("/") + 1, (v_origem.Length - v_origem.LastIndexOf("/") - 1))

        v_nome_do_download = NOME

        '---------------------------------------------------------------------------------------------------------------




        'Extenção ------------------------------------------------------------------------------------------------------

        array_de_extencao = Split(v_origem, v_separador) 'Obtendo array

        v_extencao = (array_de_extencao(array_de_extencao.Length - 1)) 'Obtendo nome do download

        v_posicao_da_extencao = v_extencao.IndexOf(".") 'Obtendo onde começa a extenção

        v_extencao = v_extencao.Remove(0, v_posicao_da_extencao) 'Removendo até o ponto da extenção

        v_extencao = v_extencao.ToLower 'Convertendo para minúsculo

        '---------------------------------------------------------------------------------------------------------------




        'Informando destino do download --------------------------------------------------------------------------------

        v_destino = v_destino & v_nome_do_download 'Informando o destino do download

        '---------------------------------------------------------------------------------------------------------------




        'Fechando requisiçoes ------------------------------------------------------------------------------------------

        REQUISICAO.GetRequestStream.Close() 'Fechando requisição

        RESPOSTA.Close() 'Fechando resposta

        '---------------------------------------------------------------------------------------------------------------




        'Verificando se o download está ou não disponível --------------------------------------------------------------

        If (TAMANHO = 0) Then

            v_download_online = False 'Offline

        Else

            v_download_online = True 'Online

        End If

        '---------------------------------------------------------------------------------------------------------------




    End Sub





    'Procedimentos iniciais do download

    Private Sub proc_obter_informacoes_iniciar() 'Obtém informações iniciais
        On Error Resume Next

        bck_informacoes.RunWorkerAsync() 'trabalhando...

    End Sub





    'Procedimentos básicos

    Private Sub proc_iniciar_processo_de_download() 'Iniciando o processo de download
        On Error Resume Next

        bck_download.RunWorkerAsync() 'Trabalhando...

    End Sub

    Private Sub proc_obter_destino() 'Obtém o destino final do download
        On Error Resume Next

        Dim v_perguntar_onde_salvar As Boolean 'Informa se deve abrir a janela para escolher onde salvar o download.

        Dim v_pasta_de_download_atual As String 'Informa onde deve ser salvo o download.




        'Inicializando variáveis --------------------------------------------------------------------------------------------------------------------------------------------------------------

        v_perguntar_onde_salvar = V_VAL_CONFIG_PERGUNTAR_ONDE_SALVAR_DOWNLOADS 'Permite ou não escolher a pasta de download.

        v_pasta_de_download_atual = V_VAL_CONFIG_PASTA_DE_DOWNLOADS 'Pasta onde salvar o download

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Definindo propriedades ---------------------------------------------------------------------------------------

        SaveFileDialog1.FileName = v_nome_do_download 'Informando o nome do download

        SaveFileDialog1.Filter = "Extenção do arquivo(*" & v_extencao & ")|*" & v_extencao 'Extenção do arquivo

        '--------------------------------------------------------------------------------------------------------------


        'Verifica se esta ou nao online ---------------------------------------------

        If (v_download_online = False) Then

            Exit Sub 'Saindo do procedimento

        End If

        '----------------------------------------------------------------------------




        'Deixa ou não escolher manualmente a pasta onde será salvo o download -----------------------------------------

        If (v_perguntar_onde_salvar = False) Then


            'Destino do download --------------------------------------------------------------------------------

            v_destino = v_pasta_de_download_atual & "\" & v_nome_do_download 'Destino do download

            '----------------------------------------------------------------------------------------------------


            'Iniciando o download ------------------------------------------------

            proc_iniciar_processo_de_download() 'Iniciando o processo de download

            '---------------------------------------------------------------------


            'Saindo ----------------------------------

            Exit Sub

            '-----------------------------------------


        End If

        '--------------------------------------------------------------------------------------------------------------




        'Abrindo agora ------------------------------------------------------------------------------------------------

        If (Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then


            'Destino do download -------------------------------------------------

            v_destino = SaveFileDialog1.FileName 'Destino do download

            '---------------------------------------------------------------------


            'Iniciando o download ------------------------------------------------

            proc_iniciar_processo_de_download() 'Iniciando o processo de download

            '---------------------------------------------------------------------




        Else




            'Saindo ------------------------------

            Me.Close() 'Saindo

            '-------------------------------------


        End If

        '--------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_informando_informacoes_obtidas() 'Informa no formulario as informações obtidas
        On Error Resume Next

        'Informando agora ---------------------------------------------------------------------------------------------

        lbl_origem.Text = v_origem 'Origem

        lbl_destino.Text = v_destino 'Destino

        '--------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub proc_cancelar_download() 'Cancela o download
        On Error Resume Next


        'Cancelando download ------------------------------------------------------------------

        bck_download.CancelAsync() 'Cancelando

        '--------------------------------------------------------------------------------------


        'Mensagem ao usuário -----------------------------------------------------------------------------------------------------------------

        Me.Hide() 'Ocultando

        proc_chamar_mensagem_ao_usuario(V_MS_8, v_tipo_ms_3) 'Chama a janela de mensagem ao usuario

        'Remove o arquivo antigo -------------------------------------------------------------------

        My.Computer.FileSystem.DeleteFile(v_destino) 'Deletando...

        '-------------------------------------------------------------------------------------------


        Me.Close() 'Saindo

        '-------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub proc_se_fechar_excluir_download() 'Se o usuário fechar a janela excluir o download entao
        On Error Resume Next


        'Verifica se o download está ou não completo ------------------------------------------------------------------


        If (v_download_completo = False) Then


            'Cancelando, pausando, removendo -------------------------------------------------

            bck_download.CancelAsync() 'Cancelando

            System.Threading.Thread.Sleep(1000) 'Pausa

            My.Computer.FileSystem.DeleteFile(v_destino) 'Deletando...

            '---------------------------------------------------------------------------------


        End If


        '--------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_online_offline() 'Informa se o arquivo esta ou nao online
        On Error Resume Next


        'Analizando resposta ----------------------------------------------------------------------------------------------------------------------------------------


        If (v_download_online = False) Then


            'Informa que o download não está disponivel --------------------------------------------------------------------------------------

            Me.Hide() 'Ocultando

            proc_chamar_mensagem_ao_usuario(V_MS_9, v_tipo_ms_3) 'Chama a janela de mensagem ao usuario

            Me.Close() 'Saindo

            '---------------------------------------------------------------------------------------------------------------------------------


        Else


            'Habilita o timer atualizador de download --------------------------------------------

            atualizador_de_download.Enabled = True 'Habilitando...

            '-------------------------------------------------------------------------------------


        End If


        '------------------------------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub proc_download_completo() 'Informa que o download está completo
        On Error Resume Next


        'Parando o timer -------------------------------------------------------------

        If (v_download_completo = True) Then

            tmr_atualizar.Enabled = False 'Parando

        End If

        '-----------------------------------------------------------------------------


        'Informa que o download está concluido ------------------------------------------------------------------------

        If (chk_avisar.Checked = True) And (v_download_completo = True) Then


            Me.Hide() 'Ocultando

            proc_chamar_mensagem_ao_usuario(V_MS_10, v_tipo_ms_1) 'Chama a janela de mensagem ao usuario

            Me.Close() 'Saindo


        End If

        '--------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_informar_que_ha_menos_um_download() 'Informa que há menos um download na lista
        On Error Resume Next

        Modulo_salvar_configuracoes_ao_sair.v_quantidade_de_downloads_abertos = Modulo_salvar_configuracoes_ao_sair.v_quantidade_de_downloads_abertos - 1

    End Sub

    Private Sub proc_informar_que_ha_mais_um_download() 'Informa que há mais um download na lista
        On Error Resume Next

        Modulo_salvar_configuracoes_ao_sair.v_quantidade_de_downloads_abertos = Modulo_salvar_configuracoes_ao_sair.v_quantidade_de_downloads_abertos + 1

    End Sub

   

   

    Private Sub proc_copiar_para_a_ram() 'Copia o endereço do download para a ram
        On Error Resume Next

        'Copiando ------------------------------------------------------------------------------------------

        My.Computer.Clipboard.GetText(v_origem) 'Copiando endereço url para a ram

        '---------------------------------------------------------------------------------------------------


        'Informando ----------------------------------------------------------------------------------------------------------

        MsgBox("O endereço abaixo foi copiado:" & vbCrLf & vbCrLf & v_origem, MsgBoxStyle.Information, "Globe Informa") 'Mensagem

        '---------------------------------------------------------------------------------------------------------------------


    End Sub




    'Inicializador

    Private Sub proc_inicializador() 'Inicializador
        On Error Resume Next

        proc_informar_que_ha_mais_um_download() 'Informa que há mais um download na lista

        proc_obter_informacoes_iniciar() 'Obtém informações iniciais

    End Sub

    Private Sub proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual
        On Error Resume Next

        Me.Opacity = V_VAL_CONFIG_TRANSPARENCIA 'Aplicando a transparencia

    End Sub






    'Processa informações 

    Public Sub proc_converter_dados_recebidos() 'Converte os dados recebidos
        On Error Resume Next

        Dim v_dados As Long 'Informa os dados de cálculo

        Dim v_conversao(4) As Long 'Matriz de conversão

        Dim v_valor_de_conversao As Long 'Valor da conversão




        'Colhendo dados -----------------------------------------------------------------------------------

        v_dados = v_tamanho_completo 'Obtendo dados

        '--------------------------------------------------------------------------------------------------




        'Fazendo conversão --------------------------------------------------------------------------------

        v_conversao(1) = (v_dados / 1024) 'KB

        v_conversao(2) = (v_dados / 1024 / 1024) 'MB

        v_conversao(3) = (v_dados / 1024 / 1024 / 1024) 'GB

        v_conversao(4) = (v_dados / 1024 / 1024 / 1024 / 1024) 'TB

        '--------------------------------------------------------------------------------------------------




        'Informando estado de dados recebidos atualmente --------------------------------------------------

        'Kilobyte ----------------------------------------------------

        If (v_conversao(1) <= 1024) Then

            v_medida_de_tamanho(1) = " Kb"

            v_valor_de_conversao = v_conversao(1) 'KB

        End If

        '--------------------------------------------------------------


        'Megabyte -----------------------------------------------------

        If (v_conversao(2) >= 1) Then

            v_medida_de_tamanho(1) = " Mb"

            v_valor_de_conversao = v_conversao(2) 'MB

        End If

        '--------------------------------------------------------------


        'Gigabyte -----------------------------------------------------

        If (v_conversao(3) >= 1) Then

            v_medida_de_tamanho(1) = " Gb"

            v_valor_de_conversao = v_conversao(3) 'GB

        End If

        '--------------------------------------------------------------


        'Terabyte -----------------------------------------------------

        If (v_conversao(4) >= 1) Then

            v_medida_de_tamanho(1) = " Tb"

            v_valor_de_conversao = v_conversao(4) 'TB

        End If

        '--------------------------------------------------------------


        'Repassando valores obtidos ------------------------------------------------------------------------

        v_dados_recebidos_convertido = v_valor_de_conversao 'Conversão


        If (v_valor_de_conversao > 1) Then

            v_medida_de_tamanho(1) = v_medida_de_tamanho(1) & "s" 'Informa que está no plural

        End If

        '---------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_converter_dados_a_receber() 'Converte os dados a receber
        On Error Resume Next

        Dim v_dados As Long 'Informa os dados de cálculo

        Dim v_conversao(4) As Long 'Matriz de conversão

        Dim v_valor_de_conversao As Long 'Valor da conversão




        'Colhendo dados -----------------------------------------------------------------------------------

        v_dados = v_tamanho 'Obtendo dados

        '--------------------------------------------------------------------------------------------------




        'Fazendo conversão --------------------------------------------------------------------------------

        v_conversao(1) = (v_dados / 1024) 'KB

        v_conversao(2) = (v_dados / 1024 / 1024) 'MB

        v_conversao(3) = (v_dados / 1024 / 1024 / 1024) 'GB

        v_conversao(4) = (v_dados / 1024 / 1024 / 1024 / 1024) 'TB

        '--------------------------------------------------------------------------------------------------




        'Informando estado de dados recebidos atualmente --------------------------------------------------

        'Kilobyte ----------------------------------------------------

        If (v_conversao(1) <= 1024) Then

            v_medida_de_tamanho(2) = " Kb"

            v_valor_de_conversao = v_conversao(1) 'KB

        End If

        '--------------------------------------------------------------


        'Megabyte -----------------------------------------------------

        If (v_conversao(2) >= 1) Then

            v_medida_de_tamanho(2) = " Mb"

            v_valor_de_conversao = v_conversao(2) 'MB

        End If

        '--------------------------------------------------------------


        'Gigabyte -----------------------------------------------------

        If (v_conversao(3) >= 1) Then

            v_medida_de_tamanho(2) = " Gb"

            v_valor_de_conversao = v_conversao(3) 'GB

        End If

        '--------------------------------------------------------------


        'Terabyte -----------------------------------------------------

        If (v_conversao(4) >= 1) Then

            v_medida_de_tamanho(2) = " Tb"

            v_valor_de_conversao = v_conversao(4) 'TB

        End If

        '--------------------------------------------------------------


        'Repassando valores obtidos ------------------------------------------------------------------------

        v_dados_a_receber_convertidos = v_valor_de_conversao 'Conversão


        If (v_valor_de_conversao > 1) Then

            v_medida_de_tamanho(2) = v_medida_de_tamanho(2) & "s" 'Informa que está no plural

        End If

        '---------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_complemento_de_velocidade() 'Informa o complemento de velocidade
        On Error Resume Next


        'Analiza a velocidade de download ---------------------------------------------------------

        If (v_velocidade_de_download >= 1024) Then

            v_medida_de_tamanho(3) = " Mbps"


        Else

            v_medida_de_tamanho(3) = " Kbps"

        End If

        '------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_atualizar_porcentagem() 'Atualiza a procentagem
        On Error Resume Next

        Dim v_porcentagem As Integer 'Porcentagem de download




        'Calculando ---------------------------------------------------------------------------------------------------

        v_porcentagem = (v_tamanho_completo * 100) / v_tamanho 'Porcentagem

        '--------------------------------------------------------------------------------------------------------------


        'Atualizando agora --------------------------------------------------------------------------------------------

        ProgressBar1.Value = v_porcentagem 'Porcentagem

        lbl_porcentagem.Text = v_porcentagem & "%" 'Porcentagem

        '--------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_atualizar() 'Atualiza dados vistos no formulário
        On Error Resume Next


        'Atualizadores -----------------------------------------------------------------------------------------------

        proc_converter_dados_recebidos() 'Converte os dados recebidos

        proc_converter_dados_a_receber() 'Converte os dados a receber

        proc_complemento_de_velocidade() 'Informa o complemento de velocidade

        proc_atualizar_porcentagem() 'Atualiza a procentagem

        '-------------------------------------------------------------------------------------------------------------


        'Atualizando formulário agora --------------------------------------------------------------------------------

        lbl_baixado.Text = v_dados_recebidos_convertido & v_medida_de_tamanho(1) 'Baixado

        lbl_tamanho_arquivo.Text = v_dados_a_receber_convertidos & v_medida_de_tamanho(2) 'A baixar

        lbl_velocidade.Text = v_velocidade_de_download & v_medida_de_tamanho(3) 'Velocidade

        '-------------------------------------------------------------------------------------------------------------


    End Sub





















    Private Sub bck_download_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bck_download.DoWork
        On Error Resume Next

        proc_download() 'Inicia o processo de download do arquivo

    End Sub

    Private Sub bck_informacoes_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bck_informacoes.DoWork
        On Error Resume Next

        proc_obter_informacoes() 'Obter informações do arquivo

    End Sub

    Private Sub frm_Formulario_download_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual

        proc_inicializador() 'Inicializador

    End Sub

    Private Sub bck_informacoes_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bck_informacoes.RunWorkerCompleted
        On Error Resume Next

        proc_online_offline() 'Informa se o arquivo esta ou nao online

        proc_obter_destino() 'Obtém o destino final do download

        proc_informando_informacoes_obtidas() 'Informa no formulario as informações obtidas

    End Sub

    Private Sub tmr_atualizar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_atualizar.Tick
        On Error Resume Next

        proc_atualizar() 'Atualiza dados vistos no formulário

        proc_download_completo() 'Informa que o download está completo

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        On Error Resume Next

        proc_cancelar_download() 'Cancela o download

    End Sub

    Private Sub frm_Formulario_download_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next

        proc_informar_que_ha_menos_um_download() 'Informa que há menos um download na lista

        proc_se_fechar_excluir_download() 'Se o usuário fechar a janela excluir o download entao

    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        On Error Resume Next

        proc_copiar_para_a_ram() 'Copia o endereço do download para a ram

    End Sub

    Private Sub atualizador_de_download_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles atualizador_de_download.Tick
        On Error Resume Next

        proc_iniciar_processo_de_download() 'Iniciando o processo de download

    End Sub

End Class