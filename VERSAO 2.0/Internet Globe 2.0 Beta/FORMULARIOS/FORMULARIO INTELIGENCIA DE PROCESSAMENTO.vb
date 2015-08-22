Public Class FRM_FORMULARIO_INTELIGENCIA_DE_PROCESSAMENTO


    'PROCEDIMENTOS

    Private Sub PROC_ATIVAR_TIMER() 'ATIVA O TIMER
        On Error Resume Next

        TMR_ATUALIZADOR.Enabled = True 'HABILITA

    End Sub

    Private Sub PROC_PARAR_TIMER() 'PARANDO TIMER
        On Error Resume Next

        TMR_ATUALIZADOR.Enabled = False 'DESABILITA

    End Sub

    Private Sub PROC_RAM_JA_USADA() 'INFORMA A QUANTIDADE DE MEMORIA RAM USADA
        On Error Resume Next

        Dim V_PORCENTAGEM_RAM_EM_USO As Integer = (FUNC_RETORNE_QUANTIDADE_DE_MEMORIA_RAM_USADA() * 100) \ FUNC_RETORNE_QUANTIDADE_DE_MEMORIA_RAM_TOTAL() 'RAM USADA






        'MEMORIA USADA ---------------------------------------------------------------------------------------------------------------------------------------------------------------------

        ProgressBar1.Maximum = FUNC_RETORNE_QUANTIDADE_DE_MEMORIA_RAM_TOTAL() 'RETORNA A QUANTIDADE DE MEMORIA RAM GERAL NO COMPUTADOR

        ProgressBar1.Value = FUNC_RETORNE_QUANTIDADE_DE_MEMORIA_RAM_USADA() 'RETORNA A QUANTIDADE DE MEMORIA RAM USADA

        LBL_1.Text = V_PORCENTAGEM_RAM_EM_USO & "%" 'PORCENTAGEM USADA

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA SE É ACEITAVEL ---------------------------------------------------------------------------------------

        If (V_NIVEL_ACEITAVEL_DE_MEMORIA_RAM_USO > V_PORCENTAGEM_RAM_EM_USO) Then


            PIC1.Image = IML_1.Images.Item(0) 'ALERTA


        Else


            PIC1.Image = IML_1.Images.Item(1) 'NORMAL


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_USO_DE_PROCESSADOR() 'USO DE PROCESSADOR
        On Error Resume Next

        Dim V_USO_DE_CPU As Integer = FUNC_RETORNE_USO_DE_PROCESSADOR() 'USO DE CPU






        'INFORMA O USO DE CPU ------------------------------------------------------------------------------------------

        ProgressBar2.Value = V_USO_DE_CPU 'PROGRESSO

        LBL_2.Text = V_USO_DE_CPU & "%" 'PORCENTAGEM

        '---------------------------------------------------------------------------------------------------------------




        'VERIFICA SE É ACEITAVEL ---------------------------------------------------------------------------------------

        If (V_USO_DE_CPU < V_NIVEL_ACEITAVEL_DE_PROCESSAMENTO) Then


            PIC2.Image = IML_1.Images.Item(0) 'ALERTA


        Else


            PIC2.Image = IML_1.Images.Item(1) 'NORMAL


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_TEMPERATURA() 'TEMPERATURA DE PROCESSADOR
        On Error Resume Next

        Dim V_TEMPERATURA As Integer = FUNC_RETORNE_TEMPERATURA_DE_PROCESSADOR() 'RETORNA A TEMPERATURA DO PROCESSADOR






        'REPASSA VALORES -----------------------------------------------------------------------------------------------

        ProgressBar3.Maximum = V_NIVEL_ACEITAVEL_DE_TEMPERATURA 'VALOR MÁXIMO

        ProgressBar3.Value = V_TEMPERATURA 'VALOR ATUAL

        LBL_3.Text = V_TEMPERATURA & "°" 'TEMPERATURA

        '---------------------------------------------------------------------------------------------------------------




        'VERIFICA SE É ACEITAVEL ---------------------------------------------------------------------------------------

        If (V_TEMPERATURA <= V_NIVEL_ACEITAVEL_DE_TEMPERATURA) Then


            PIC3.Image = IML_1.Images.Item(0) 'ALERTA


        Else


            PIC3.Image = IML_1.Images.Item(1) 'NORMAL


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_CONEXAO_TESTE_INTELIGENCIA() 'TESTE DE CONEXAO MODO INTELIGENTE
        On Error Resume Next


        'INICIA TESTES -------------------------------------------------------------------------------------------------

        V_ENDERECO_DE_TESTE_DE_CONEXAO_INTELIGENCIA = TXT_IP.Text 'ENDEREÇO DE TESTE DE CONEXAO

        PROC_RETORNE_SE_O_COMPUTADOR_TEM_CONEXAO_INTELIGENCIA() 'ANALISA SE O COMPUTADOR ESTÁ CONECTADO A INTERNET

        '---------------------------------------------------------------------------------------------------------------




        'REPASSA A RESPOSTA DE TESTE DE CONEXAO ------------------------------------------------------------------------

        If (V_CONEXAO_COM_A_INTERNET_RESPOSTA_INTELIGENCIA = True) Then


            PIC4.Image = IML_1.Images.Item(0) 'ALERTA


        Else


            PIC4.Image = IML_1.Images.Item(1) 'NORMAL


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_ATUALIZADOR_DE_INFORMACOES() 'ATUALIZADOR DE INFORMAÇÕES
        On Error Resume Next

        PROC_RAM_JA_USADA() 'INFORMA A QUANTIDADE DE MEMORIA RAM USADA

        PROC_USO_DE_PROCESSADOR() 'USO DE PROCESSADOR

        PROC_TEMPERATURA() 'TEMPERATURA DE PROCESSADOR

        PROC_CONEXAO_TESTE_INTELIGENCIA() 'TESTE DE CONEXAO MODO INTELIGENTE




    End Sub

    


















    Private Sub FRM_FORMULARIO_INTELIGENCIA_DE_PROCESSAMENTO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next


        'APLICA O FADIN ------------------------------------------------------------------------------------------------

        PROC_APLICAR_FADIN_EM_FORMULARIO(Me) 'APLICA O FADIN EM FORMULARIO

        '---------------------------------------------------------------------------------------------------------------




        'SOM DE SISTEMA ------------------------------------------------------------------------------------------------

        PROC_EXIBIR_SOM_DE_SISTEMA(0) 'EXIBE OS SONS INSTALADOS NO SISTEMA

        '---------------------------------------------------------------------------------------------------------------




        PROC_ATIVAR_TIMER() 'ATIVA O TIMER

    End Sub

    Private Sub FRM_FORMULARIO_INTELIGENCIA_DE_PROCESSAMENTO_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next

        PROC_PARAR_TIMER() 'PARANDO TIMER

    End Sub

    Private Sub TMR_ATUALIZADOR_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMR_ATUALIZADOR.Tick
        On Error Resume Next

        PROC_ATUALIZADOR_DE_INFORMACOES() 'ATUALIZADOR DE INFORMAÇÕES

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next

        Me.Close() 'SAINDO...

    End Sub

End Class