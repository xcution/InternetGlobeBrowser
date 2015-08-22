Imports System.IO
Imports System.Net
Imports System.ComponentModel




Module MODULO_ANALISADOR_DE_LINKS


    'VARIÁVEIS

    Public V_LINK_A_ANALISAR As String = Nothing 'LINK A SER ANALISADO

    Dim V_LINK_ONLINE As Boolean 'INFORMA SE O LINK ESTÁ OU NÃO ONLINE










    'OBJETOS

    Dim OBJ_BACKGROUNDWORKER_ANALISADOR_DE_LINS As New BackgroundWorker 'NOVO ANALISADOR DE LINKS















    'PROCEDIMENTOS

    Private Sub PROC_ANALISADOR_DE_LINKS() 'ANALISADOR DE LINKS
        On Error Resume Next


        'OBTENDO DADOS -----------------------------------------------------------------------------------------------------------------------------------------------

        Dim REQUISICAO As WebRequest = WebRequest.Create(V_LINK_A_ANALISAR) 'REQUISICAO

        Dim RESPOSTA As WebResponse = REQUISICAO.GetResponse() 'REAPOSTA

        Dim BUFFER_TOTAL As Integer = 0 'BUFFER TOTAL

        Dim BUFFER(128) As [Byte] 'BUFFER

        Dim DADOS As Stream = RESPOSTA.GetResponseStream() 'STREAM

        BUFFER_TOTAL = DADOS.Read(BUFFER, 0, 128) 'OBTEM TOTAL DE BUFFER

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'FECHA CONEXAO COM RESPOSTA ------------------------------------------------------------------------------------

        RESPOSTA.Close() 'FECHANDO

        '---------------------------------------------------------------------------------------------------------------




        'INFORMA SE ESTA OU NÃO ONLINE -------------------------------------------------------------------------------------------------------------------------------

        If (BUFFER_TOTAL > 0) Then


            V_LINK_ONLINE = True 'LINK ONLINE


        Else


            V_LINK_ONLINE = False 'LINK OFFLINE


        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_RESPOSTA_DE_TESTE_DE_LINK() 'RESPOSTA DE TESTE DE LINK
        On Error Resume Next


        'INFORMA SE O LINKE ESTA OU NÃO ONLINE ------------------------------------------------------------------------------------------------------------------------

        If (V_LINK_ONLINE = True) Then


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripStatusLabel1.Text = "Link online" 'INFORMA QUE O LINK ESTÁ ONLINE
            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripStatusLabel1.Image = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.IML_IMAGENS_2.Images.Item(1) 'ONLINE
            PROC_EXIBIR_SOM_DE_SISTEMA(5) 'EXIBE OS SONS INSTALADOS NO SISTEMA


        Else


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripStatusLabel1.Text = "Link off-line" 'INFORMA QUE O LINK ESTÁ OFFLINE
            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripStatusLabel1.Image = FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.IML_IMAGENS_2.Images.Item(0) 'OFFLINE
            PROC_EXIBIR_SOM_DE_SISTEMA(6) 'EXIBE OS SONS INSTALADOS NO SISTEMA


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_INICIAR_TESTE_DE_LINK(ByVal V_ENDERECO_DE_URL As String) 'INICIA O TESTE DE LINK PARA VERIFICAR SE ESTÁ OU NÃO ONLINE
        On Error Resume Next


        'VERIFICA SE RECURSO ESTA ATIVADO ------------------------------------------------------------------------------

        If (FUNC_LER_ARQUIVO(V_ARQUIVO_END_27) = False) Then


            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripStatusLabel1.Visible = False 'NAO EXIBE O TESTE DE LINK

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripSeparator1.Visible = False 'OCULTA

            Exit Sub 'SAINDO...


        End If

        '---------------------------------------------------------------------------------------------------------------




        'INFORMA PARA ESPERAR ------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripStatusLabel1.Visible = True 'EXIBE O TESTE DE LINK

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripStatusLabel1.Text = "Espera..." 'INFORMA PARA ESPERAR

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ToolStripSeparator1.Visible = True 'EXIBE

        '---------------------------------------------------------------------------------------------------------------




        'INFORMA QUE DEVE SUPORTAR CANCELAMENTO E CANCELA ULTIMO LINK A SER ANALISADO ---------------------------------------------------------

        OBJ_BACKGROUNDWORKER_ANALISADOR_DE_LINS.WorkerSupportsCancellation = True 'INFORMA QUE SUPORTA CANCELAR

        OBJ_BACKGROUNDWORKER_ANALISADOR_DE_LINS.CancelAsync() 'CANCELANDO

        '--------------------------------------------------------------------------------------------------------------------------------------




        'REPASSA O ENDEREÇO DE ANALISE ---------------------------------------------------------------------------------

        V_LINK_A_ANALISAR = V_ENDERECO_DE_URL 'REPASSANDO

        '---------------------------------------------------------------------------------------------------------------




        'ATUALIZA EVENTOS DO OBJETO -----------------------------------------------------------------------------------------------------------

        RemoveHandler OBJ_BACKGROUNDWORKER_ANALISADOR_DE_LINS.DoWork, AddressOf PROC_TESTE_DE_LINK_TRABALHANDO 'EXECUTA O TESTE DE LINK

        RemoveHandler OBJ_BACKGROUNDWORKER_ANALISADOR_DE_LINS.RunWorkerCompleted, AddressOf PROC_TESTE_DE_LINK_COMPLETO 'TESTE DE LINK COMPLETO




        AddHandler OBJ_BACKGROUNDWORKER_ANALISADOR_DE_LINS.DoWork, AddressOf PROC_TESTE_DE_LINK_TRABALHANDO 'EXECUTA O TESTE DE LINK

        AddHandler OBJ_BACKGROUNDWORKER_ANALISADOR_DE_LINS.RunWorkerCompleted, AddressOf PROC_TESTE_DE_LINK_COMPLETO 'TESTE DE LINK COMPLETO

        '--------------------------------------------------------------------------------------------------------------------------------------




        'RODANDO PROCESSO ----------------------------------------------------------------------------------------------

        OBJ_BACKGROUNDWORKER_ANALISADOR_DE_LINS.RunWorkerAsync() 'RODANDO O PROCESSO

        '---------------------------------------------------------------------------------------------------------------


    End Sub















    'EVENTOS

    Private Sub PROC_TESTE_DE_LINK_TRABALHANDO(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) 'EXECUTA O TESTE DE LINK
        On Error Resume Next

        PROC_ANALISADOR_DE_LINKS() 'ANALISADOR DE LINKS

    End Sub

    Private Sub PROC_TESTE_DE_LINK_COMPLETO(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) 'TESTE DE LINK COMPLETO
        On Error Resume Next

        PROC_RESPOSTA_DE_TESTE_DE_LINK() 'RESPOSTA DE TESTE DE LINK

    End Sub



























End Module
