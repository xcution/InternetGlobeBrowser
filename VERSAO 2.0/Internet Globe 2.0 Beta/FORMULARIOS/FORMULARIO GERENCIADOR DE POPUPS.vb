Public Class FRM_FORMULARIO_GERENCIADOR_DE_POPUPS


    'VARIÁVEIS

    Dim V_LISTA_COMPLETA_DE_SITES_POP_UPS As String 'LISTA DE SITES QUE PODEM ABRIR POPUPS















    Private Sub PROC_LISTAR_TODOS_OS_POP_UPS_PERMITIDAS() 'LISTA TODOS OS SITES QUE PODEM ABRIR POPUPS
        On Error Resume Next

        Dim V_CONTADOR As Integer = 0 'CONTADOR DE LOOPING






        'LISTANDO TODOS OS SITES ---------------------------------------------------------------------------------------

        V_LISTA_COMPLETA_DE_SITES_POP_UPS = FUNC_LER_ARQUIVO(V_ARQUIVO_END_15) 'LÊ CONFIG DE ARQUIVO

        '---------------------------------------------------------------------------------------------------------------




        'SEPARANDO VALORES ---------------------------------------------------------------------------------------------

        Dim ARRAY_SEPARAR_LISTA As Array = Split(V_LISTA_COMPLETA_DE_SITES_POP_UPS, V_SEPARADOR_DE_STRINGS) 'SEPARANDO

        '---------------------------------------------------------------------------------------------------------------




        'ATUALIZANDO ---------------------------------------------------------------------------------------------------




        'LIMPANDO ---------------------------------------------------------------

        LST_POPUP.Items.Clear() 'LIMPANDO TODOS OS ITENS

        '------------------------------------------------------------------------




        'ATUALIZANDO ---------------------------------------------------------------------------------------------------

        For V_CONTADOR = V_CONTADOR To ARRAY_SEPARAR_LISTA.Length




            Dim V_VALOR As String = ARRAY_SEPARAR_LISTA(V_CONTADOR) 'VALOR




            'SO ADICIONA VALOR VÁLIDO

            If (V_VALOR <> Nothing) And (V_VALOR <> "") Then


                LST_POPUP.Items.Add(V_VALOR) 'ADICIONANDO...


            End If




        Next

        '---------------------------------------------------------------------------------------------------------------




        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_VERIFICA_PROTOCOLO() 'VERIFICA O PROTOCOLO DE ENDEREÇO
        On Error Resume Next

        Dim V_URL As New Uri(TXT_ENDERECO.Text) 'NOVA URL






        'VERIFICA A EXISTENCIA DE PROTOCOLO ----------------------------------------------------------------------------

        If (V_URL.Scheme = Nothing) Then


            TXT_ENDERECO.Text = "http://" & TXT_ENDERECO.Text 'ADICIONA O PROTOCOLO


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_ADICIONA_POPUP_EM_LISTA() 'ADICIONA A POPUP NA LISTA
        On Error Resume Next


        'VERIFICA O PROTOCOLO DE ENDEREÇO ------------------------------------------------------------------------------

        PROC_VERIFICA_PROTOCOLO() 'VERIFICA O PROTOCOLO DE ENDEREÇO

        '---------------------------------------------------------------------------------------------------------------


        Dim V_URL As New Uri(TXT_ENDERECO.Text) 'NOVA URL

        Dim V_ENDERECO As String = V_URL.Host 'OBTEM ENDEREÇO DE SITE QUE PODE ABRIR POPUP






        'VERIFICA SE JÁ É DA LISTA -----------------------------------------------------------------------------------------------------------------------------


        If (V_LISTA_COMPLETA_DE_SITES_POP_UPS.Contains(V_ENDERECO) = False) Then


            V_LISTA_COMPLETA_DE_SITES_POP_UPS = V_LISTA_COMPLETA_DE_SITES_POP_UPS & V_ENDERECO & V_SEPARADOR_DE_STRINGS 'ATUALIZANDO...


        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------




        'SALVANDO NOVO VALOR -------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(V_LISTA_COMPLETA_DE_SITES_POP_UPS, V_ARQUIVO_END_15) 'SALVA O ARQUIVO

        '---------------------------------------------------------------------------------------------------------------




        'ATUALIZA AGORA ------------------------------------------------------------------------------------------------

        PROC_LISTAR_TODOS_OS_POP_UPS_PERMITIDAS() 'LISTA TODOS OS SITES QUE PODEM ABRIR POPUPS

        '---------------------------------------------------------------------------------------------------------------




        'LIMPA CAIXA DE TEXTO --------------------------

        TXT_ENDERECO.Clear() 'LIMPANDO...

        '-----------------------------------------------


    End Sub

    Private Sub PROC_EXCLUIR_POPUP_EM_LISTA() 'EXCLUIR A POPUP DA LISTA
        On Error Resume Next

        Dim V_END_DE_POPUP As String = LST_POPUP.SelectedItem 'OBTEM A POPUP SELECIONADA






        'EXCLUINDO TUDO ------------------------------------------------------------------------------------------------

        If (CHK_EXCLUIR_TUDO.Checked = True) Then


            V_LISTA_COMPLETA_DE_SITES_POP_UPS = Nothing 'LIMPANDO TUDO...


        End If

        '---------------------------------------------------------------------------------------------------------------




        'REMOVENDO DA LISTA --------------------------------------------------------------------------------------------------------------------

        V_LISTA_COMPLETA_DE_SITES_POP_UPS = V_LISTA_COMPLETA_DE_SITES_POP_UPS.Replace(V_END_DE_POPUP, Nothing) 'EXCLUINDO DA LISTA

        '---------------------------------------------------------------------------------------------------------------------------------------




        'SALVANDO NOVO VALOR -------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(V_LISTA_COMPLETA_DE_SITES_POP_UPS, V_ARQUIVO_END_15) 'SALVA O ARQUIVO

        '---------------------------------------------------------------------------------------------------------------




        'ATUALIZA AGORA ------------------------------------------------------------------------------------------------

        PROC_LISTAR_TODOS_OS_POP_UPS_PERMITIDAS() 'LISTA TODOS OS SITES QUE PODEM ABRIR POPUPS

        '---------------------------------------------------------------------------------------------------------------




    End Sub

    Private Sub PROC_SAIR_JANELA_ATUAL() 'SAI DA JANELA ATUAL
        On Error Resume Next

        Me.Close() 'SAINDO...

    End Sub

    Private Sub PROC_ADICIONA_POPUP_SITE_EM_VISUALIZACAO() 'ADICIONA O SITE POPUP EM VISUALIZACAO
        On Error Resume Next


        'SETA O ENDEREÇO COMO O SITE EM VISUALIZAÇÃO -------------------------------------------------------------------

        TXT_ENDERECO.Text = FUNC_RETORNE_END_SITE_EM_VISUALIZACAO() 'RETORNA O ENDEREÇO DO SITE EM VISUALIZAÇÃO

        '---------------------------------------------------------------------------------------------------------------


    End Sub
























    Private Sub FRM_FORMULARIO_GERENCIADOR_DE_POPUPS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next


        'APLICA O FADIN ------------------------------------------------------------------------------------------------

        PROC_APLICAR_FADIN_EM_FORMULARIO(Me) 'APLICA O FADIN EM FORMULARIO

        '---------------------------------------------------------------------------------------------------------------




        'SOM DE SISTEMA ------------------------------------------------------------------------------------------------

        PROC_EXIBIR_SOM_DE_SISTEMA(0) 'EXIBE OS SONS INSTALADOS NO SISTEMA

        '---------------------------------------------------------------------------------------------------------------




        PROC_LISTAR_TODOS_OS_POP_UPS_PERMITIDAS() 'LISTA TODOS OS SITES QUE PODEM ABRIR POPUPS

    End Sub

    Private Sub TXT_ENDERECO_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_ENDERECO.KeyDown
        On Error Resume Next


        'ATUALIZA ------------------------------------------------------------------------------------------------------

        If (e.KeyCode = Keys.Enter) Then


            e.SuppressKeyPress = True 'SEM BEEP

            PROC_ADICIONA_POPUP_EM_LISTA() 'ADICIONA A POPUP NA LISTA


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next

        PROC_ADICIONA_POPUP_EM_LISTA() 'ADICIONA A POPUP NA LISTA

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next

        PROC_EXCLUIR_POPUP_EM_LISTA() 'EXCLUIR A POPUP DA LISTA

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error Resume Next

        PROC_SAIR_JANELA_ATUAL() 'SAI DA JANELA ATUAL

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        On Error Resume Next

        PROC_ADICIONA_POPUP_SITE_EM_VISUALIZACAO() 'ADICIONA O SITE POPUP EM VISUALIZACAO

    End Sub

End Class