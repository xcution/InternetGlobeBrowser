Module MODULO_FADIN


    'OBJETOS

    Dim OBJ_TIMER_FADIN As New Timer 'NOVO TIMER FADIN

    Public V_PAUSAR_FADIN As String = False 'INFORMA SE PAUSA O FADIN, EM CASO DE APLICAR UM NOVO TEMA ETC...















    'EVENTOS

    Private Sub PROC_FADIN_EVENTO_DE_TIMER(ByVal sender As System.Object, ByVal e As System.EventArgs) 'EVENTO FADIN DE TIMER
        On Error Resume Next


        'ATUALIZA OPACIDADE --------------------------------------------------------------------------------------------

        OBJ_FORMULARIO_DE_TRABALHO.Opacity = OBJ_FORMULARIO_DE_TRABALHO.Opacity + 0.1 'ATUALIZA OPACIDADE

        '---------------------------------------------------------------------------------------------------------------




        'PARA TIMER ----------------------------------------------------------------------------------------------------

        If (OBJ_FORMULARIO_DE_TRABALHO.Opacity >= V_NIVEL_DE_TRANSPARENCIA_ATUAL) Then


            OBJ_TIMER_FADIN.Enabled = False 'DESABILITA O TIMER


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_FORMULARIO_NOVO_REDIMENCIONAR_EVENTO(ByVal sender As System.Object, ByVal e As System.EventArgs) 'EVENTO DE REDIMENCIONAR
        On Error Resume Next

        Dim OBJ_FORM_TEMP As Form = DirectCast(sender, Form) 'FORMULARIO DE TRABALHO TEMPORARIO






        'APLICA O FADIN ------------------------------------------------------------------------------------------------

        PROC_APLICAR_FADIN_EM_FORMULARIO(OBJ_FORM_TEMP) 'APLICA O FADIN EM FORMULARIO

        '---------------------------------------------------------------------------------------------------------------


    End Sub














    'PROCEDIMENTOS

    Public Sub PROC_APLICAR_FADIN_EM_FORMULARIO(ByVal OBJ_FORMULARIO As Form) 'APLICA O FADIN EM FORMULARIO
        On Error Resume Next

        Dim V_NIVEL As Single = FUNC_LER_ARQUIVO(V_ARQUIVO_END_21) 'NIVEL DE TRANSPARENCIA ATUAL






        'OBTÉM O FORMULÁRIO DE TRABALHO ---------------------------------------------------------------------------------------------------

        OBJ_FORMULARIO_DE_TRABALHO = DirectCast(OBJ_FORMULARIO, Form) 'OBTENDO O FORMULARIO DE TRABALHO

        '----------------------------------------------------------------------------------------------------------------------------------




        'ADICIONA EVENTOS -----------------------------------------------------------------------------------------------------------------

        RemoveHandler OBJ_TIMER_FADIN.Tick, AddressOf PROC_FADIN_EVENTO_DE_TIMER 'EVENTO FADIN DE TIMER

        RemoveHandler OBJ_FORMULARIO_DE_TRABALHO.Resize, AddressOf PROC_FORMULARIO_NOVO_REDIMENCIONAR_EVENTO 'REDIMENCIONAR




        AddHandler OBJ_TIMER_FADIN.Tick, AddressOf PROC_FADIN_EVENTO_DE_TIMER 'EVENTO FADIN DE TIMER

        AddHandler OBJ_FORMULARIO_DE_TRABALHO.Resize, AddressOf PROC_FORMULARIO_NOVO_REDIMENCIONAR_EVENTO 'REDIMENCIONAR

        '----------------------------------------------------------------------------------------------------------------------------------




        'NÃO PERMITE NIVEL NAO VÁLIDO -----------------------------------------------------------------------------------------------------

        If (V_NIVEL <= 0) Or (V_NIVEL >= 1) Or (V_NIVEL = Nothing) Then




            'SALVANDO VALOR ---------------------------------------------------------------------------------------------------------------

            PROC_SALVAR_ARQUIVO(1, V_ARQUIVO_END_21) 'SALVANDO TRANSPARENCIA

            '------------------------------------------------------------------------------------------------------------------------------




            'OBTÉM O NIVEL NOVAMENTE ------------------------------------------------------------------------------------------------------

            V_NIVEL = 1 'NÍVEL PADRÃO

            '------------------------------------------------------------------------------------------------------------------------------




        End If

        '----------------------------------------------------------------------------------------------------------------------------------




        'INFORMA O NÍVEL DE TRANSPARENCIA -------------------------------------------------------------------------------------------------

        V_NIVEL_DE_TRANSPARENCIA_ATUAL = V_NIVEL 'INFORMA O NÍVEL DE TRANSPARENCIA

        '----------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA SE PODE USAR O FADIN ----------------------------------------------------------------------------------------------------

        If (V_PAUSAR_FADIN = True) Or (FUNC_LER_ARQUIVO(V_ARQUIVO_END_34) = False) Then


            OBJ_FORMULARIO.Opacity = V_NIVEL 'APLICANDO NÍVEL DE TRANSPARENCIA

            Exit Sub 'SAINDO


        End If

        '----------------------------------------------------------------------------------------------------------------------------------




        'APLICA O FADIN NORMAL ------------------------------------------------------------------------------------------------------------

        OBJ_FORMULARIO_DE_TRABALHO.Opacity = 0 'ZERA OPACIDADE

        OBJ_TIMER_FADIN.Interval = 25 'INTERVALO

        '----------------------------------------------------------------------------------------------------------------------------------




        'ATIVA O FADIN --------------------------------------------------------------------------------------------------------------------

        OBJ_TIMER_FADIN.Enabled = True 'ATIVANDO TIMER

        '----------------------------------------------------------------------------------------------------------------------------------


    End Sub
























End Module
