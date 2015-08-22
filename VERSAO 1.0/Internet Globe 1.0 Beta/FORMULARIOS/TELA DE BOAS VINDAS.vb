Public Class FRM_TELA_DE_BOAS_VINDAS



    'Procedimentos básicos

    Private Sub proc_ativar_timer_inicializador() 'Ativando timer inicializador
        On Error Resume Next


        'Só ativar o timer se a tela de boas vindas for exibida ------------------------------------------------------

        If (V_VAL_CONFIG_TELA_DE_BOAS_VINDAS = True) Then


            TRM_INICIALIZADOR.Enabled = True 'Ativando timer inicializador


        End If

        '-------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_finalizar_timer() 'Finalizador do timer
        On Error Resume Next

        Static v_timer_atual As Integer 'Informa o valor do timer atual






        'Atualizando valor atual ------------------------------------------------------------------------------------------

        v_timer_atual = v_timer_atual + 1000 'Incrementando

        '------------------------------------------------------------------------------------------------------------------




        'Comparando valor do timer atual --------------------------------------------------------------------------------------------------------------------------

        If (v_timer_atual = v_valor_maximo_do_timer_tela_de_boas_vindas) Then


            'Abrindo formulario de navegação e fechando tela de boas vindas -----------------------------------------------

            proc_abrir_formulario_de_navegacao_Modulo_de_inicializacao() 'Abre o formulario de navegação

            '---------------------------------------------------------------------------------------------------------------


        End If

        '----------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

















    Private Sub TELA_DE_BOAS_VINDAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next


        'Inicializando ----------------------------------------------------------------------------------------------------------------------

        proc_carregar_e_inicializar_Modulo_de_inicializacao() 'Carrega e inicializa o programa

        proc_ativar_timer_inicializador() 'Ativando timer inicializador

        '------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub TRM_INICIALIZADOR_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRM_INICIALIZADOR.Tick
        On Error Resume Next

        proc_finalizar_timer() 'Finalizador do timer

    End Sub

End Class