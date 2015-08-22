Public Class FRM_ABAS_DEMAIS


    'Variáveis basicas

    Public V_ABERTAS As Integer 'Informa a quantidade de abas abertas

    Public V_RECOMENDAVEL As Integer 'Informa a quantidade de abas recomendavel

    Dim v_ultima_configuracao_do_modo_geek As Boolean 'Informa a ultima configuração do modo geek















    'Procedimentos basicos

    Private Sub proc_informar_valores() 'Informa os valores recebidos
        On Error Resume Next

        lbl_abas_quantidade.Text = V_ABERTAS 'Informa a quantidade de abas abertas

        lbl_recomendavel.Text = V_RECOMENDAVEL 'Informa a quantidade de abas recomendavel a abrir

    End Sub

    Private Sub proc_sair_da_janela() 'Sai da janela
        On Error Resume Next

        Me.Close() 'Saindo...

    End Sub

    Private Sub proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual
        On Error Resume Next

        Me.Opacity = V_VAL_CONFIG_TRANSPARENCIA 'Aplicando a transparencia

    End Sub

    Private Sub proc_informe_com_voz_texto_da_janela() 'Informa com voz o texto da janela em exibição.
        On Error Resume Next

        Dim V_TEXTO_DA_JANELA As String 'Armazena o texto da janela






        'Inicializando variável ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        V_TEXTO_DA_JANELA = "Tome cuidado!, abrir abas demais pode deixar o navegador lento. Número de abas abertas: " & V_ABERTAS & "." 'Atualizando...

        V_TEXTO_DA_JANELA = V_TEXTO_DA_JANELA & "Número de abas recomendável: " & V_RECOMENDAVEL & "." 'Atualizando...

        V_TEXTO_DA_JANELA = V_TEXTO_DA_JANELA & " Clique em ok para fechar esta janela." 'Atualizando...

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Lendo o texto ----------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_VAL_CONFIG_USAR_VOZ_EM_CAIXAS_DE_DIALOGO = True) Then

            proc_falar_texto_repassado_recurso_de_voz_direto(V_TEXTO_DA_JANELA) 'Procedimento para leitura de texto repassado pelo usuário, sem saida ou entrada na caixa de texto.

        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub












    'Fazendo o navegador trabalhar menos temporariamente

    Private Sub proc_ativa_modo_menos_processamento() 'Ativa o modo menos processamento
        On Error Resume Next


        'Lendo configuração ---------------------------------------------------------------------------------------------

        v_ultima_configuracao_do_modo_geek = V_VAL_CONFIG_MODO_GEEK_ATIVADO 'Atualizando valor original da configuração

        '----------------------------------------------------------------------------------------------------------------




        'Definindo configuração temporaria ------------------------------------------------------------------------------

        V_VAL_CONFIG_MODO_GEEK_ATIVADO = True 'Ativando o modo geek temporario

        '----------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_desativa_modo_menos_processamento() 'Desativa o modo menos processamento
        On Error Resume Next

        'Restaurando valor original ------------------------------------------------------------------------------------

        V_VAL_CONFIG_MODO_GEEK_ATIVADO = v_ultima_configuracao_do_modo_geek 'Restaurando valor original

        '---------------------------------------------------------------------------------------------------------------




        'Removendo valor de variável -----------------------------------------------------------------------------------

        v_ultima_configuracao_do_modo_geek = Nothing 'Valor nulo

        '---------------------------------------------------------------------------------------------------------------




        'Atualizando propriedades nao atualizadas ----------------------------------------------------------------------------------------------------------------

        Proc_atualizar_propriedades_site_carregar_completo(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        '---------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub




























    Private Sub FRM_ABAS_DEMAIS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        proc_ativa_modo_menos_processamento() 'Ativa o modo menos processamento

        proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual

        proc_informar_valores() 'Informa os valores recebidos

        proc_informe_com_voz_texto_da_janela() 'Informa com voz o texto da janela em exibição.

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        On Error Resume Next

        proc_sair_da_janela() 'Sai da janela

    End Sub

    Private Sub FRM_ABAS_DEMAIS_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next

        proc_desativa_modo_menos_processamento() 'Desativa o modo menos processamento

        proc_calar_voz_do_motor_tts() 'Cala a voz do motor tts

    End Sub

End Class