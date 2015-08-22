Public Class FRM_FORMULARIO_SALVAR_ABAS_ABERTAS


    'VARIÁVEIS

    Dim V_EXECUTOU_ACAO As String = False 'INFORMA SE EXECUTOU UMA AÇÃO





















    'PROCEDIMENTOS

    Private Sub PROC_NAO_PODE_SAIR_SETAR() 'SETA QUE NÃO PODE SAIR
        On Error Resume Next


        'INFORMA QUE NÃO PODE SAIR E SAI DO FORMULARIO ATUAL ---------------------------------------------------------

        V_PODE_SAIR_DA_SESSAO_ATUAL = True 'INFORMA QUE NÃO PODE SAIR

        Me.Close() 'SAINDO...

        '-------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_SALVAR_ABAS_NAO_PERGUNTAR_NOVAMENTE(ByVal V_RESPOSTA As Boolean) 'NÃO PERGUNTAR NOVAMENTE SALVAR VALOR
        On Error Resume Next


        'EXIBE OU NÃO A CAIXA DE DIÁLOGO SALVAR ABAS ----------------------------------------------------------------

        If (V_RESPOSTA = True) Then


            V_RESPOSTA = False 'NÃO EXIBIR


        Else


            V_RESPOSTA = True 'EXIBIR


        End If

        '------------------------------------------------------------------------------------------------------------




        'SALVANDO O VALOR -------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(V_RESPOSTA, V_ARQUIVO_END_3) 'SALVANDO O VALOR

        '------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_SIM() 'SALVA SESSAO
        On Error Resume Next


        'INFORMA QUE EXECUTOU AÇÃO ---------------------------------

        V_EXECUTOU_ACAO = True 'EXECUTOU

        '-----------------------------------------------------------




        'INFORMA QUE DEVE ABRIR A SESSÃO AO INICIAR O NAVEGADOR -----------------------------------------------------

        PROC_NAO_SALVOU_SESSAO_CORRETAMENTE() 'INFORMA QUE NÃO SALVOU A SESSÃO CORRETAMENTE

        '------------------------------------------------------------------------------------------------------------




        'INFORMA QUE DEVE SALVAR SEMPRE AO SAIR SIM OU NÃO ----------------------------------------------------------

        PROC_SALVAR_ARQUIVO(True, V_ARQUIVO_END_17) 'INFORMA QUE DEVE SALVAR SEMPRE AO SAIR

        '------------------------------------------------------------------------------------------------------------




        'INFORMA QUE PODE SAIR ----------------------------------------------------------------------------------

        V_PODE_SAIR_DA_SESSAO_ATUAL = False 'INFORMA QUE ODE SAIR

        '--------------------------------------------------------------------------------------------------------




        'SALVA AS CONFIGURAÇÕES AO SAIR E ANALISA JANELAS ABERTAS ------------------------------------------------------

        PROC_SALVAR_TODAS_AS_CONFIGURACOES_AO_SAIR() 'SALVA TODAS AS CONFIGURAÇÕES AO SAIR DO NAVEGADOR

        Me.Close() 'SAINDO...

        '---------------------------------------------------------------------------------------------------------------



    End Sub

    Private Sub PROC_NAO() 'NAO SALVA SESSÃO
        On Error Resume Next


        'INFORMA QUE EXECUTOU AÇÃO -------------------------------------------------------------------------------------

        V_EXECUTOU_ACAO = True 'EXECUTOU

        '---------------------------------------------------------------------------------------------------------------




        'SALVA A SESSÃO CORRETAMENTE E SAI DO FORMULARIO ATUAL ---------------------------------------------------------

        PROC_SALVOU_SESSAO_CORRETAMENTE() 'INFORMA QUE SALVOU A SESSÃO CORRETAMENTE

        '---------------------------------------------------------------------------------------------------------------




        'INFORMA QUE DEVE SALVAR SEMPRE AO SAIR SIM OU NÃO -------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_17) 'INFORMA QUE DEVE SALVAR SEMPRE AO SAIR

        '---------------------------------------------------------------------------------------------------------------




        'INFORMA QUE PODE SAIR -----------------------------------------------------------------------------------------

        V_PODE_SAIR_DA_SESSAO_ATUAL = False 'INFORMA QUE NÃO PODE SAIR AGORA

        '---------------------------------------------------------------------------------------------------------------




        'SALVA AS CONFIGURAÇÕES AO SAIR E ANALISA JANELAS ABERTAS ------------------------------------------------------

        PROC_SALVAR_TODAS_AS_CONFIGURACOES_AO_SAIR() 'SALVA TODAS AS CONFIGURAÇÕES AO SAIR DO NAVEGADOR

        Me.Close() 'SAINDO...

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_NAO_SAIR() 'NÃO SAIR
        On Error Resume Next


        'INFORMA QUE EXECUTOU AÇÃO ---------------------------------

        V_EXECUTOU_ACAO = True 'EXECUTOU

        '-----------------------------------------------------------




        'NAO PODE SAIR SETAR ---------------------------------------

        PROC_NAO_PODE_SAIR_SETAR() 'SETA QUE NÃO PODE SAIR

        '-----------------------------------------------------------


    End Sub

    Private Sub PROC_ANALISA_EXECUTOU_ACAO_AO_SAIR() 'ANALISA SE EXECUTOU UMA AÇÃO AO SAIR
        On Error Resume Next


        'VERIFICA RESPOSTA ------------------------------------------------------------------------------------------

        If (V_EXECUTOU_ACAO = False) Then


            PROC_SALVAR_ABAS_NAO_PERGUNTAR_NOVAMENTE(False) 'NÃO PERGUNTAR NOVAMENTE SALVAR VALOR

            PROC_NAO_SAIR() 'NÃO SAIR


        End If

        '------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_EXIBIR_MENSAGEM() 'EXIBIR MENSGEM
        On Error Resume Next

        Dim V_MENSAGEM As String = LBL_MENSAGEM.Text 'MENSAGEM A SER LIDA






        'INFORMA A MENSAGEM COM VOZ ------------------------------------------------------------------------------------

        PROC_USAR_SINTETIZADOR_DE_FALA_HUMANA(Nothing) 'USA O SINTETIZADOR DE FALA HUMANA EM MENSAGENS ETC...

        PROC_USAR_SINTETIZADOR_DE_FALA_HUMANA(V_MENSAGEM) 'USA O SINTETIZADOR DE FALA HUMANA EM MENSAGENS ETC...

        '---------------------------------------------------------------------------------------------------------------


    End Sub



























    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error Resume Next

        PROC_NAO() 'NAO SALVA SESSÃO

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next

        PROC_SIM() 'SALVA SESSAO

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next

        PROC_NAO_SAIR() 'NÃO SAIR

    End Sub

    Private Sub CHK_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_1.CheckedChanged
        On Error Resume Next

        PROC_SALVAR_ABAS_NAO_PERGUNTAR_NOVAMENTE(CHK_1.Checked) 'NÃO PERGUNTAR NOVAMENTE SALVAR VALOR

    End Sub

    Private Sub FRM_FORMULARIO_SALVAR_ABAS_ABERTAS_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next

        PROC_PARAR_SINTETIZADOR_DE_VOZ_HUMANA() 'PARA O SINTETIZADOR DE VOZ HUMANA

        PROC_ANALISA_EXECUTOU_ACAO_AO_SAIR() 'ANALISA SE EXECUTOU UMA AÇÃO AO SAIR

    End Sub

    Private Sub FRM_FORMULARIO_SALVAR_ABAS_ABERTAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next


        'APLICA O FADIN ------------------------------------------------------------------------------------------------

        PROC_APLICAR_FADIN_EM_FORMULARIO(Me) 'APLICA O FADIN EM FORMULARIO

        '---------------------------------------------------------------------------------------------------------------




        'SOM DE SISTEMA ------------------------------------------------------------------------------------------------

        PROC_EXIBIR_SOM_DE_SISTEMA(3) 'EXIBE OS SONS INSTALADOS NO SISTEMA

        '---------------------------------------------------------------------------------------------------------------




        PROC_EXIBIR_MENSAGEM() 'EXIBIR MENSGEM

    End Sub

End Class