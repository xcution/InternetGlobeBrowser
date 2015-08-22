Imports System.Management
Imports System
Imports System.Diagnostics
Imports System.Threading
Imports System.ComponentModel




Module MODULO_INTELIGENCIA_DE_PROCESSAMENTO


    'VARIÁVEIS

    Public V_NIVEL_ACEITAVEL_DE_PROCESSAMENTO As Integer = 85 'NÍVEL ACEITÁVEL DE PROCESSAMENTO

    Public V_NIVEL_ACEITAVEL_DE_TEMPERATURA As Integer = 60 'NIVEL ACEITAVEL DE TEMPERATURA DE PROCESSADOR

    Public V_NIVEL_ACEITAVEL_DE_MEMORIA_RAM_USO As Integer = 85 'NIVEL ACEITAVEL DE MEMORIA RAM EM USO










    'CONEXAO VARIÁVEIS

    Public V_ENDERECO_DE_TESTE_DE_CONEXAO_INTELIGENCIA As String = Nothing 'INFORMA O ENDEREÇO DE IP OU URL PARA O TESTE DE CONEXAO

    Public V_CONEXAO_COM_A_INTERNET_RESPOSTA_INTELIGENCIA As String = True 'INFORMA SE HÁ OU NÃO CONEXAO COM A INTERNET










    'OBJETOS DE CONEXAO

    Public OBJ_BACKGROUNDWORKER_TESTE_ONLINE_OU_OFFLINE_INTELIGENCIA As New BackgroundWorker 'NOVO BACKGROUNDWORKER










    'OBJETOS

    Dim OBJ_CPU As New PerformanceCounter 'Performace do processador

    Dim OBJ_CPU_PROCESSADOR As New System.Diagnostics.PerformanceCounter 'Performace do processador










    'PROCEDIMENTOS E FUNÇÔES

    Public Function FUNC_RETORNE_QUANTIDADE_DE_MEMORIA_RAM_USADA() 'RETORNA A QUANTIDADE DE MEMORIA RAM USADA
        On Error Resume Next

        Dim V_MEMORIA_LIVRE As Long = My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory 'MEMORIA RAM USADA DO COMPUTADOR






        'RETORNO -------------------------------------------------------------------------------------------------------

        Return V_MEMORIA_LIVRE 'RETORNO

        '---------------------------------------------------------------------------------------------------------------


    End Function

    Public Function FUNC_RETORNE_USO_DE_PROCESSADOR() 'RETORNA O USO DO PROCESSADOR
        On Error Resume Next

        Dim V_VALOR_DE_PORCENTAGEM As Integer 'VALOR DE USO DE CPU






        'DADOS BASICOS -------------------------------------------------------------------------------------------------

        OBJ_CPU.CategoryName = "Processor"

        OBJ_CPU.CounterName = "% Processor Time"

        OBJ_CPU.InstanceName = "_Total"

        '---------------------------------------------------------------------------------------------------------------




        'RETORNO -------------------------------------------------------------------------------------------------------

        V_VALOR_DE_PORCENTAGEM = OBJ_CPU.NextValue 'OBTEM VALOR

        V_VALOR_DE_PORCENTAGEM = Convert.ToInt32(V_VALOR_DE_PORCENTAGEM) 'CONVERTER

        Return V_VALOR_DE_PORCENTAGEM 'RETORNO

        '---------------------------------------------------------------------------------------------------------------


    End Function

    Public Function FUNC_RETORNE_TEMPERATURA_DE_PROCESSADOR() 'RETORNA A TEMPERATURA DO PROCESSADOR

        Dim V_RETORNO As Integer = 0 'Valor de retorno






        'RETORNA A TEMPERATURA DO PROCESSADOR --------------------------------------------------------------------------------------------------------


        Try


            'CRIA PROCURADOR

            Dim OBJ_PROCURADOR As New Management.ManagementObjectSearcher("root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature")




            'PROCURA ---------------------------------------------------------------------------------------------------

            For Each OBJ_PROCURAR As ManagementObject In OBJ_PROCURADOR.Get()


                Dim V_TEMPERATURA As Double = CDbl(OBJ_PROCURAR("CurrentTemperature")) 'TEMPERATURA

                V_TEMPERATURA = (V_TEMPERATURA - 2732) / 10.0 'CALCULANDO

                V_RETORNO = V_TEMPERATURA 'REPASSA O RETORNO


            Next

            '-----------------------------------------------------------------------------------------------------------




            'EM CASO DE ERRO ------------------------

        Catch ex As ManagementException

            V_RETORNO = 0 'ERRO

        End Try

        '--------------------------------------------




        'RETORNO ------------------------------------

        Return V_RETORNO 'Valor de retorno

        '--------------------------------------------


        '---------------------------------------------------------------------------------------------------------------------------------------------


    End Function

    Public Function FUNC_RETORNE_LISTA_DE_PROCESSOS_EM_EXECUCAO() 'RETORNA UMA LISTA DE PROCESSOS EM EXECUÇÃO
        On Error Resume Next

        Dim V_LISTA As String = Nothing 'LISTA DE PROCESSOS






        'ATUALIZA A LISTA DE PROCESSOS -----------------------------------------------------------------------------------

        For Each processo As Process In Process.GetProcesses()


            V_LISTA = V_LISTA & processo.ProcessName & vbCrLf 'Listando processos do sistema


        Next processo

        '-----------------------------------------------------------------------------------------------------------------




        'RETORNO ------------------------------------------------

        Return V_LISTA 'RETORNO

        '--------------------------------------------------------


    End Function

    Public Function FUNC_RETORNE_QUANTIDADE_DE_MEMORIA_RAM_TOTAL() 'RETORNA A QUANTIDADE DE MEMORIA RAM GERAL NO COMPUTADOR
        On Error Resume Next

        Dim V_MEMORIA_LIVRE As Long = My.Computer.Info.TotalPhysicalMemory 'MEMORIA TOTAL






        'RETORNO -------------------------------------------------------------------------------------------------------

        Return V_MEMORIA_LIVRE 'RETORNO

        '---------------------------------------------------------------------------------------------------------------


    End Function

    Public Function FUNC_RETORNE_QUANTIDADE_DE_MEMORIA_RAM_DISPONIVEL() 'RETORNA A QUANTIDADE DE MEMORIA RAM DISPONIVEL
        On Error Resume Next

        Dim V_RETORNO As Long = My.Computer.Info.AvailablePhysicalMemory 'QUANTIDADE DE MEMORIA DISPONIVEL






        'RETORNO -------------------------------------------------------------------------------------------------------

        Return V_RETORNO 'RETORNO

        '---------------------------------------------------------------------------------------------------------------


    End Function









    'PROCEDIMENTOS DE CONEXAO COM A INTERNET

    Private Sub PROC_TESTE_ONLINE_TRABALHAR_INTELIGENCIA(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) 'TESTE ONLINE TRABALHAR
        On Error Resume Next

        Dim V_PING(3) As Boolean 'VALORES DE RESPOSTAS






        'EXECUTA PING --------------------------------------------------------------------------------------------------

        V_PING(1) = My.Computer.Network.Ping(V_ENDERECO_DE_TESTE_DE_CONEXAO_INTELIGENCIA) 'PING

        V_PING(2) = My.Computer.Network.Ping(V_ENDERECO_DE_TESTE_DE_CONEXAO_INTELIGENCIA) 'PING

        V_PING(3) = My.Computer.Network.Ping(V_ENDERECO_DE_TESTE_DE_CONEXAO_INTELIGENCIA) 'PING

        '---------------------------------------------------------------------------------------------------------------




        'ANALISA RESPOSTA ----------------------------------------------------------------------------------------------

        If (V_PING(1) = False) And (V_PING(2) = False) And (V_PING(3) = False) Then


            V_CONEXAO_COM_A_INTERNET_RESPOSTA_INTELIGENCIA = False 'SEM CONEXAO


        Else


            V_CONEXAO_COM_A_INTERNET_RESPOSTA_INTELIGENCIA = True 'COM CONEXAO


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_RETORNE_SE_O_COMPUTADOR_TEM_CONEXAO_INTELIGENCIA() 'ANALISA SE O COMPUTADOR ESTÁ CONECTADO A INTERNET
        On Error Resume Next


        'PARA ULTIMO PROCESSO ------------------------------------------------------------------------------------------

        OBJ_BACKGROUNDWORKER_TESTE_ONLINE_OU_OFFLINE_INTELIGENCIA.CancelAsync() 'CANCELA

        '---------------------------------------------------------------------------------------------------------------




        'ADICIONA EVENTO ---------------------------------------------------------------------------------------------------------------------------------------------

        RemoveHandler OBJ_BACKGROUNDWORKER_TESTE_ONLINE_OU_OFFLINE_INTELIGENCIA.DoWork, AddressOf PROC_TESTE_ONLINE_TRABALHAR_INTELIGENCIA 'TESTE ONLINE TRABALHAR

        AddHandler OBJ_BACKGROUNDWORKER_TESTE_ONLINE_OU_OFFLINE_INTELIGENCIA.DoWork, AddressOf PROC_TESTE_ONLINE_TRABALHAR_INTELIGENCIA 'TESTE ONLINE TRABALHAR

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'RODANDO -------------------------------------------------------------------------------------------------------

        OBJ_BACKGROUNDWORKER_TESTE_ONLINE_OU_OFFLINE_INTELIGENCIA.RunWorkerAsync() 'RODANDO

        '---------------------------------------------------------------------------------------------------------------


    End Sub




















    'ANALISADOR DE NIVEL DE PROCESSAMENTO INTELIGENTE

    Public Sub PROC_VERIFICADOR_DE_INTELIGENCIA_DE_PROCESSAMENTO() 'VERIFICADOR DE INTELIGENCIA DE PROCESSAMENTO
        On Error Resume Next

        Dim V_USO_DE_CPU As Integer = FUNC_RETORNE_USO_DE_PROCESSADOR() 'RETORNA O USO DO PROCESSADOR

        Dim V_PORCENTAGEM_RAM_EM_USO As Integer = (FUNC_RETORNE_QUANTIDADE_DE_MEMORIA_RAM_USADA() * 100) \ FUNC_RETORNE_QUANTIDADE_DE_MEMORIA_RAM_TOTAL() 'RAM USADA

        Dim V_TEMP_CPU_ATUAL As Integer = FUNC_RETORNE_TEMPERATURA_DE_PROCESSADOR() 'RETORNA A TEMPERATURA DO PROCESSADOR

        '# OBSERVAÇÃO: False remove evento
        '# OBSERVAÇÃO: True adiciona evento






        'DESABILITA TODOS OS MENUS -------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ATemperaturaDoProcessadorEstáAltaToolStripMenuItem.Visible = False 'DESABILITA

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.AMemóriaDoComputadorEstáQuaseCheiaToolStripMenuItem.Visible = False 'DESABILITA

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.OProcessadorEstáTrabalhandoDemaisToolStripMenuItem.Visible = False 'DESABILITA

        '---------------------------------------------------------------------------------------------------------------




        'VERIFICA SE HÁ PROBLEMAS ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_USO_DE_CPU > V_NIVEL_ACEITAVEL_DE_PROCESSAMENTO) Then




            PROC_REMOVER_EVENTOS_PRINCIPAIS(False) 'REMOVE OS EVENTOS PRINCIPAIS DO NAVEGADOR

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.OProcessadorEstáTrabalhandoDemaisToolStripMenuItem.Visible = True 'HABILITA

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TSB_MENSAGENS.Visible = True 'HABILITA




        Else




            PROC_REMOVER_EVENTOS_PRINCIPAIS(True) 'REMOVE OS EVENTOS PRINCIPAIS DO NAVEGADOR

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.OProcessadorEstáTrabalhandoDemaisToolStripMenuItem.Visible = False 'DESABILITA

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TSB_MENSAGENS.Visible = False 'DESABILITA




        End If

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA SE HÁ PROBLEMAS ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_PORCENTAGEM_RAM_EM_USO > V_NIVEL_ACEITAVEL_DE_MEMORIA_RAM_USO) Then




            PROC_REMOVER_EVENTOS_PRINCIPAIS(False) 'REMOVE OS EVENTOS PRINCIPAIS DO NAVEGADOR

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.AMemóriaDoComputadorEstáQuaseCheiaToolStripMenuItem.Visible = True 'HABILITA

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TSB_MENSAGENS.Visible = True 'HABILITA




        Else




            PROC_REMOVER_EVENTOS_PRINCIPAIS(True) 'REMOVE OS EVENTOS PRINCIPAIS DO NAVEGADOR

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.AMemóriaDoComputadorEstáQuaseCheiaToolStripMenuItem.Visible = False 'DESABILITA

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TSB_MENSAGENS.Visible = False 'DESABILITA




        End If

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA SE HÁ PROBLEMAS ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_TEMP_CPU_ATUAL > V_NIVEL_ACEITAVEL_DE_TEMPERATURA) Then




            PROC_REMOVER_EVENTOS_PRINCIPAIS(False) 'REMOVE OS EVENTOS PRINCIPAIS DO NAVEGADOR

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ATemperaturaDoProcessadorEstáAltaToolStripMenuItem.Visible = True 'HABILITA

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TSB_MENSAGENS.Visible = True 'HABILITA




        Else




            PROC_REMOVER_EVENTOS_PRINCIPAIS(True) 'REMOVE OS EVENTOS PRINCIPAIS DO NAVEGADOR

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.ATemperaturaDoProcessadorEstáAltaToolStripMenuItem.Visible = False 'DESABILITA

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TSB_MENSAGENS.Visible = False 'DESABILITA




        End If

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_EXECUTADOR_DE_VERIFICADOR_DE_INTELIGENCIA(ByVal sender As System.Object, ByVal e As System.EventArgs) 'EXECUTA O TESTE DE INTELIGENCIA DE TEMPO EM TEMPO PRÉ INFORMADO
        On Error Resume Next

        PROC_VERIFICADOR_DE_INTELIGENCIA_DE_PROCESSAMENTO() 'VERIFICADOR DE INTELIGENCIA DE PROCESSAMENTO

    End Sub

    Public Sub PROC_TESTE_DE_INTELIGENCIA_ATIVAR(ByVal V_ATIVAR As Boolean) 'INICIA OS TESTES DE INTELIGENCIA
        On Error Resume Next


        'NAO PERMITE VALOR EM BRANCO -----------------------------------------------------------------------------------

        If (V_ATIVAR = Nothing) Or (V_ATIVAR = False) Then


            OBJ_TIMER_EXECUTADOR_DE_TESTE_DE_INTELIGENCIA.Enabled = False 'DESATIVA O TIMER

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TSB_MENSAGENS.Visible = False 'NÃO EXIBE MENSAGENS DE TESTE DE INTELIGENCIA

            Exit Sub 'SAINDO


        End If

        '---------------------------------------------------------------------------------------------------------------




        'DEFINE O INTERVALO --------------------------------------------------------------------------------------------

        OBJ_TIMER_EXECUTADOR_DE_TESTE_DE_INTELIGENCIA.Interval = 2000 'INTERVALO

        '---------------------------------------------------------------------------------------------------------------




        'REMOVE EVENTO ANTIGO E ADD NOVO EVENTO --------------------------------------------------------------------------------------------------------------------------------------------------------------------

        RemoveHandler OBJ_TIMER_EXECUTADOR_DE_TESTE_DE_INTELIGENCIA.Tick, AddressOf PROC_EXECUTADOR_DE_VERIFICADOR_DE_INTELIGENCIA 'EXECUTA O TESTE DE INTELIGENCIA DE TEMPO EM TEMPO PRÉ INFORMADO

        AddHandler OBJ_TIMER_EXECUTADOR_DE_TESTE_DE_INTELIGENCIA.Tick, AddressOf PROC_EXECUTADOR_DE_VERIFICADOR_DE_INTELIGENCIA 'EXECUTA O TESTE DE INTELIGENCIA DE TEMPO EM TEMPO PRÉ INFORMADO

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ATIVANDO OU DESATIVANDO ---------------------------------------------------------------------------------------

        OBJ_TIMER_EXECUTADOR_DE_TESTE_DE_INTELIGENCIA.Enabled = V_ATIVAR 'ATIVA OU DESATIVA

        '---------------------------------------------------------------------------------------------------------------


    End Sub




















    'PROCEDIMENTO DE ANALISE DE TRAVAMENTOS

    Public Sub PROC_VERIFICADOR_DE_TRAVAMENTO_DE_APLICATIVO() 'APLICATIVO ANTI-TRAVAMENTO
        On Error Resume Next

        Dim V_PARAMETRO As String = "Internet Globe 2.0 Beta" & vbCrLf & V_PASTA_DE_INSTALACAO_ATUAL & "\Internet Globe 2.0 Beta.exe" 'PARAMETRO






        'ABRINDO APLICATIVO ANTI-TRAVAMENTO -------------------------------------------------------------------------------------------------------------------------------------------------

        Process.Start(V_PASTA_DE_INSTALACAO_ATUAL & "\Complementos\Crash\M7SLMCRASH.exe", V_PARAMETRO) 'ABRINDO APLICATIVO ANTI-TRAVAMENTO

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub






















End Module
