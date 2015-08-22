Imports System.Management




Module Modulo_solucionador_de_problemas


    'Variáveis e objetos

    Dim OBJ_CPU_PROCESSADOR As New System.Diagnostics.PerformanceCounter 'Performace do processador




    'Variáveis de respostas ao solucionador de problemas

    Public V_PROCESSADOR_USO_NORMAL As Boolean 'Informa se o processador está no uso normal

    Public V_PODE_CONTINUAR_EXECUTANDO_PROCEDIMENTOS_NORMAIS As Boolean 'Informa aos procedimentos de atualizar propriedades que podem continuar normais

    Public V_PROGRESSO_DE_PORCENTAGEM_USO_CPU As Integer 'Informa o progresso de uso de cpu

    Public V_COMPUTADOR_TEM_MUITA_MEMORIA_LIVRE As Boolean = True 'Informa se o computador tem muita memoria ram livre










    'Procedimentos de solução de problemas

    Private Sub proc_solucionar_problema_1() 'Solução para o problema de uso excessivo do processador
        On Error Resume Next


        'Seleciona o tipo de solução informada pelo usuário ------------------------------------------------------------

        Select Case V_VAL_CONFIG_COMPUTADOR_LENTO_SOLUCAO


            Case 1

                FRM_NAVEGACAO.PanelEx3.Visible = True 'Exibindo atualidades sobre cpu





            Case 3

                V_PROCESSADOR_USO_NORMAL = False 'Informa que o processamento está anormal
                V_PODE_CONTINUAR_EXECUTANDO_PROCEDIMENTOS_NORMAIS = False 'Informa que o processamento está anormal




        End Select

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_solucionar_problema_2() 'Solução para o problema de falta de memoria
        On Error Resume Next


        'Seleciona o tipo de solução informada pelo usuário ------------------------------------------------------------

        Select Case V_VAL_CONFIG_COMPUTADOR_LENTO_SOLUCAO


            Case 1

                FRM_NAVEGACAO.PanelEx3.Visible = True 'Exibindo atualidades sobre cpu
                V_COMPUTADOR_TEM_MUITA_MEMORIA_LIVRE = True 'Tem muita memoria ram livre





            Case 3

                V_PROCESSADOR_USO_NORMAL = False 'Informa que o processamento está anormal
                V_PODE_CONTINUAR_EXECUTANDO_PROCEDIMENTOS_NORMAIS = False 'Informa que o processamento está anormal
                V_COMPUTADOR_TEM_MUITA_MEMORIA_LIVRE = False 'Não tem muita memoria ram livre




        End Select

        '---------------------------------------------------------------------------------------------------------------


    End Sub













    'Procedimentos de medição de processamento

    Public Function func_retorne_uso_do_processador_atual() 'Retorna o uso do processador atualmente
        On Error Resume Next

        Dim v_valor_de_uso As Integer 'Valor de uso de cpu






        'Informações básicas sobre o processamento ---------------------------------------------------------------------------

        OBJ_CPU_PROCESSADOR.CategoryName = "Processor"

        OBJ_CPU_PROCESSADOR.CounterName = "% Processor Time"

        OBJ_CPU_PROCESSADOR.InstanceName = "_Total"

        '---------------------------------------------------------------------------------------------------------------------




        'Atualizando valores de processamento --------------------------------------------------------------------------------

        v_valor_de_uso = OBJ_CPU_PROCESSADOR.NextValue 'Obtendo o valor

        v_valor_de_uso = Convert.ToInt32(v_valor_de_uso) 'Convertendo para inteiro

        '---------------------------------------------------------------------------------------------------------------------




        'Dando o valor de retorno --------------------------------------------------------------------------------------------

        Return v_valor_de_uso 'Informando o progresso de uso de cpu

        '---------------------------------------------------------------------------------------------------------------------


    End Function

    Public Sub proc_analize_o_processamento_do_computador_cpu() 'Analiza se o processador está em uso normal de processamento
        On Error Resume Next

        Dim v_valor_de_processamento As Integer 'Valor de porcentagem em processamento

        Dim v_valor_de_processamento_anormal As Integer 'Informa o valor de processamento do computador anormal






        'Obtendo valores -----------------------------------------------------------------------------------------------

        v_valor_de_processamento = func_retorne_uso_do_processador_atual() 'Retorna o uso do processador atualmente

        v_valor_de_processamento_anormal = 80 'Obtendo valor

        V_PROGRESSO_DE_PORCENTAGEM_USO_CPU = v_valor_de_processamento 'Atualizando o progresso

        '---------------------------------------------------------------------------------------------------------------




        'Comparando valor agora ----------------------------------------------------------------------------------------

        If (v_valor_de_processamento < v_valor_de_processamento_anormal) Then



            '# Processamento normal

            V_PROCESSADOR_USO_NORMAL = True 'Informa que o processamento está normal

            V_PODE_CONTINUAR_EXECUTANDO_PROCEDIMENTOS_NORMAIS = True 'Informa que o processamento está normal 




        Else




            'Procedimentos para corrigir o problema ------------------------------------------------------------------------

            proc_solucionar_problema_1() 'Solução para o problema de uso excessivo do processador















            '---------------------------------------------------------------------------------------------------------------




        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_atualize_propriedades_de_atualidades_de_cpu() 'Atualiza as propriedades do atualidades de cpu
        On Error Resume Next

        FRM_NAVEGACAO.ProgressBarX2.Value = V_PROGRESSO_DE_PORCENTAGEM_USO_CPU 'Atualizando o progresso de uso de cpu

        FRM_NAVEGACAO.LabelX4.Text = V_PROGRESSO_DE_PORCENTAGEM_USO_CPU & "%" 'Atualizando o progresso de uso de cpu

    End Sub








    'Procedimentos de medição de temperatura de processador

    Public Function func_retorne_temperatura_de_processador() 'Retorna a temperatura do processador

        Dim v_retorno As String = 0 'Valor de retorno




        'Retornando a temperatura do processador -----------------------------------------------------------------------------------------------

        Try
            Dim searcher As New Management.ManagementObjectSearcher("root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature")

            For Each queryObj As ManagementObject In searcher.Get()
                Dim temp As Double = CDbl(queryObj("CurrentTemperature"))
                temp = (temp - 2732) / 10.0
                v_retorno = temp.ToString
            Next

        Catch ex As ManagementException
            v_retorno = 0
        End Try


        Return v_retorno 'Valor de retorno

        '---------------------------------------------------------------------------------------------------------------------------------------


    End Function

    Public Sub proc_atualize_informacao_sobre_temperatura_de_processador() 'Atualiza a informação sobre a temperatura do processador
        On Error Resume Next

        Dim v_temperatura_de_processador As Integer = func_retorne_temperatura_de_processador() 'Retorna a temperatura do processador






        'Atualizando agora ---------------------------------------------------------------------------------------------

        If (v_temperatura_de_processador > 0) Then


            FRM_NAVEGACAO.ProgressBarX3.Value = v_temperatura_de_processador 'Atualizando temperatura

            FRM_NAVEGACAO.LabelX5.Text = v_temperatura_de_processador & " Graus" 'Atualizando valor


        Else


            FRM_NAVEGACAO.ProgressBarX3.Value = 0 'Atualizando temperatura

            FRM_NAVEGACAO.LabelX5.Text = "Indisponível" 'Atualizando valor


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub










    'Procedimentos de calculo de memoria livre

    Public Sub proc_calcule_quantidade_de_memoria_disponivel() 'Calcula a quantidade de memoria ram disponivel
        On Error Resume Next

        Dim v_quant_ram_do_pc As Double = My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 'Quantidade de memoria disponivel

        Dim v_quant_ram_em_uso As Double = My.Computer.Info.AvailablePhysicalMemory / 1024 / 1024  'Quantidade de memoria em uso

        Dim v_quant_ram_restar As Double = v_quant_ram_do_pc - v_quant_ram_em_uso 'Calculando

        Dim v_porcentagem_livre As Integer 'Informa a porcentagem de ram livre






        'setando -------------------------------------------------------------------------------------------------------

        FRM_NAVEGACAO.ProgressBarX4.Maximum = Convert.ToUInt32(v_quant_ram_do_pc) 'Valor maximo

        FRM_NAVEGACAO.ProgressBarX4.Value = Convert.ToUInt32(v_quant_ram_em_uso) 'Valor atual

        v_porcentagem_livre = Convert.ToUInt32(v_quant_ram_em_uso * 100) \ v_quant_ram_do_pc 'Porcentagem de uso

        FRM_NAVEGACAO.LabelX8.Text = v_porcentagem_livre & "%" 'Porcentagem

        '---------------------------------------------------------------------------------------------------------------




        'Solucionador de problemas -------------------------------------------------------------------------------------



        If (v_porcentagem_livre > 85) Then



            proc_solucionar_problema_2() 'Solução para o problema de falta de memoria



        Else



            V_COMPUTADOR_TEM_MUITA_MEMORIA_LIVRE = True 'Tem muita memoria ram livre



        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub







    'Solucionador de problemas gerais

    Public Sub proc_solucionador_de_problemas_gerais_atualizar() 'Ativa o solucionador de problemas gerais e corrige conforme informado
        On Error Resume Next


        'Problema de processamento excessivo --------------------------------------------------------------------------------------------------

        proc_analize_o_processamento_do_computador_cpu() 'Analiza se o processador está em uso normal de processamento

        '--------------------------------------------------------------------------------------------------------------------------------------




        'Atualiza propriedades de atualidades de cpu ------------------------------------------------------------------------------------------

        proc_atualize_propriedades_de_atualidades_de_cpu() 'Atualiza as propriedades do atualidades de cpu

        proc_atualize_informacao_sobre_temperatura_de_processador() 'Atualiza a informação sobre a temperatura do processador

        '--------------------------------------------------------------------------------------------------------------------------------------




        'Atualiza propriedades memoria ram disponivel -----------------------------------------------------------------------------------------

        proc_calcule_quantidade_de_memoria_disponivel() 'Calcula a quantidade de memoria ram disponivel

        '--------------------------------------------------------------------------------------------------------------------------------------


































    End Sub















End Module
