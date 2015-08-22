Module Modulo_de_evento_progresso_de_pagina


    'Evento do motor geckofx ---------------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub proc_carregamento_motor_geckofx_1(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 1

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_1.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_1 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab1.Text = " " & OBJ_MOTOR_GECKOFX_1.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_1.Text = tab1.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_2(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 2

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_2.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_2 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab2.Text = " " & OBJ_MOTOR_GECKOFX_2.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_2.Text = tab2.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_3(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 3

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_3.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_3 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab3.Text = " " & OBJ_MOTOR_GECKOFX_3.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_3.Text = tab3.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_4(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 4

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_4.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_4 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab4.Text = " " & OBJ_MOTOR_GECKOFX_4.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_4.Text = tab4.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_5(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 5

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_5.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_5 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab5.Text = " " & OBJ_MOTOR_GECKOFX_5.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_5.Text = tab5.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_6(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 6

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_6.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_6 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab6.Text = " " & OBJ_MOTOR_GECKOFX_6.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_6.Text = tab6.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_7(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 7

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_7.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_7 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab7.Text = " " & OBJ_MOTOR_GECKOFX_7.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_7.Text = tab7.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_8(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 8

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_8.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_8 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab8.Text = " " & OBJ_MOTOR_GECKOFX_8.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_8.Text = tab8.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_9(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 9

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_9.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_9 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab9.Text = " " & OBJ_MOTOR_GECKOFX_9.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_9.Text = tab9.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_10(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 10

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_10.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_10 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab10.Text = " " & OBJ_MOTOR_GECKOFX_10.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_10.Text = tab10.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_11(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 11

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_11.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_11 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab11.Text = " " & OBJ_MOTOR_GECKOFX_11.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_11.Text = tab11.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_12(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 12

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_12.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_12 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab12.Text = " " & OBJ_MOTOR_GECKOFX_12.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_12.Text = tab12.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_13(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 13

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_13.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_13 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab13.Text = " " & OBJ_MOTOR_GECKOFX_13.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_13.Text = tab13.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_14(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 14

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_14.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_14 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab14.Text = " " & OBJ_MOTOR_GECKOFX_14.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_14.Text = tab14.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_15(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 15

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_15.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_15 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab15.Text = " " & OBJ_MOTOR_GECKOFX_15.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_15.Text = tab15.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_16(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 16

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_16.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_16 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab16.Text = " " & OBJ_MOTOR_GECKOFX_16.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_16.Text = tab16.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_17(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 17

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_17.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_17 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab17.Text = " " & OBJ_MOTOR_GECKOFX_17.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_17.Text = tab17.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_18(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 18

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_18.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_18 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab18.Text = " " & OBJ_MOTOR_GECKOFX_18.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_18.Text = tab18.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_19(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 19

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_19.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_19 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab19.Text = " " & OBJ_MOTOR_GECKOFX_19.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_19.Text = tab19.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_20(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 20

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_20.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_20 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab20.Text = " " & OBJ_MOTOR_GECKOFX_20.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_20.Text = tab20.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_21(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 21

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_21.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_21 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab21.Text = " " & OBJ_MOTOR_GECKOFX_21.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_21.Text = tab21.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_22(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 22

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_22.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_22 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab22.Text = " " & OBJ_MOTOR_GECKOFX_22.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_22.Text = tab22.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_23(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 23

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_23.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_23 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab23.Text = " " & OBJ_MOTOR_GECKOFX_23.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_23.Text = tab23.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_24(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 24

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_24.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_24 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab24.Text = " " & OBJ_MOTOR_GECKOFX_24.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_24.Text = tab24.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_25(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 25

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_25.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_25 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab25.Text = " " & OBJ_MOTOR_GECKOFX_25.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_25.Text = tab25.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_26(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 26

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_26.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_26 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab26.Text = " " & OBJ_MOTOR_GECKOFX_26.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_26.Text = tab26.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_27(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 27

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_27.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_27 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab27.Text = " " & OBJ_MOTOR_GECKOFX_27.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_27.Text = tab27.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_28(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 28

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_28.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_28 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab28.Text = " " & OBJ_MOTOR_GECKOFX_28.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_28.Text = tab28.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_29(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 29

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_29.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_29 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab29.Text = " " & OBJ_MOTOR_GECKOFX_29.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_29.Text = tab29.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_30(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 30

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_30.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_30 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab30.Text = " " & OBJ_MOTOR_GECKOFX_30.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_30.Text = tab30.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_31(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 31

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_31.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_31 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab31.Text = " " & OBJ_MOTOR_GECKOFX_31.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_31.Text = tab31.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_32(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 32

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_32.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_32 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab32.Text = " " & OBJ_MOTOR_GECKOFX_32.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_32.Text = tab32.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_33(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 33

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_33.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_33 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab33.Text = " " & OBJ_MOTOR_GECKOFX_33.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_33.Text = tab33.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_34(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 34

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_34.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_34 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab34.Text = " " & OBJ_MOTOR_GECKOFX_34.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_34.Text = tab34.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_35(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 35

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_35.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_35 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab35.Text = " " & OBJ_MOTOR_GECKOFX_35.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_35.Text = tab35.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_36(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 36

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_36.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_36 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab36.Text = " " & OBJ_MOTOR_GECKOFX_36.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_36.Text = tab36.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_37(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 37

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_37.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_37 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab37.Text = " " & OBJ_MOTOR_GECKOFX_37.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_37.Text = tab37.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_38(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 38

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_38.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_38 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab38.Text = " " & OBJ_MOTOR_GECKOFX_38.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_38.Text = tab38.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_39(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 39

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_39.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_39 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab39.Text = " " & OBJ_MOTOR_GECKOFX_39.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_39.Text = tab39.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_40(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 40

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_40.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_40 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab40.Text = " " & OBJ_MOTOR_GECKOFX_40.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_40.Text = tab40.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_41(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 41

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_41.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_41 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab41.Text = " " & OBJ_MOTOR_GECKOFX_41.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_41.Text = tab41.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_42(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 42

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_42.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_42 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab42.Text = " " & OBJ_MOTOR_GECKOFX_42.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_42.Text = tab42.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_43(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 43

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_43.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_43 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab43.Text = " " & OBJ_MOTOR_GECKOFX_43.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_43.Text = tab43.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_44(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 44

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_44.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_44 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab44.Text = " " & OBJ_MOTOR_GECKOFX_44.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_44.Text = tab44.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_45(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 45

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_45.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_45 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab45.Text = " " & OBJ_MOTOR_GECKOFX_45.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_45.Text = tab45.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_46(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 46

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_46.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_46 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab46.Text = " " & OBJ_MOTOR_GECKOFX_46.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_46.Text = tab46.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_47(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 47

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_47.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_47 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab47.Text = " " & OBJ_MOTOR_GECKOFX_47.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_47.Text = tab47.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_48(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 48

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_48.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_48 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab48.Text = " " & OBJ_MOTOR_GECKOFX_48.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_48.Text = tab48.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_49(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 49

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_49.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_49 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab49.Text = " " & OBJ_MOTOR_GECKOFX_49.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_49.Text = tab49.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_50(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 50

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_50.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_50 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab50.Text = " " & OBJ_MOTOR_GECKOFX_50.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_50.Text = tab50.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_51(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 51

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_51.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_51 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab51.Text = " " & OBJ_MOTOR_GECKOFX_51.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_51.Text = tab51.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_52(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 52

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_52.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_52 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab52.Text = " " & OBJ_MOTOR_GECKOFX_52.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_52.Text = tab52.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_53(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 53

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_53.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_53 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab53.Text = " " & OBJ_MOTOR_GECKOFX_53.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_53.Text = tab53.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_54(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 54

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_54.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_54 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab54.Text = " " & OBJ_MOTOR_GECKOFX_54.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_54.Text = tab54.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_55(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 55

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_55.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_55 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab55.Text = " " & OBJ_MOTOR_GECKOFX_55.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_55.Text = tab55.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_56(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 56

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_56.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_56 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab56.Text = " " & OBJ_MOTOR_GECKOFX_56.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_56.Text = tab56.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_57(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 57

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_57.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_57 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab57.Text = " " & OBJ_MOTOR_GECKOFX_57.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_57.Text = tab57.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_58(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 58

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_58.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_58 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab58.Text = " " & OBJ_MOTOR_GECKOFX_58.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_58.Text = tab58.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_59(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 59

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_59.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_59 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab59.Text = " " & OBJ_MOTOR_GECKOFX_59.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_59.Text = tab59.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_60(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 60

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_60.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_60 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab60.Text = " " & OBJ_MOTOR_GECKOFX_60.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_60.Text = tab60.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_61(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 61

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_61.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_61 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab61.Text = " " & OBJ_MOTOR_GECKOFX_61.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_61.Text = tab61.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_62(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 62

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_62.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_62 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab62.Text = " " & OBJ_MOTOR_GECKOFX_62.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_62.Text = tab62.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_63(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 63

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_63.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_63 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab63.Text = " " & OBJ_MOTOR_GECKOFX_63.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_63.Text = tab63.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_64(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 64

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_64.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_64 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab64.Text = " " & OBJ_MOTOR_GECKOFX_64.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_64.Text = tab64.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_65(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 65

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_65.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_65 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab65.Text = " " & OBJ_MOTOR_GECKOFX_65.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_65.Text = tab65.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_66(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 66

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_66.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_66 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab66.Text = " " & OBJ_MOTOR_GECKOFX_66.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_66.Text = tab66.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_67(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 67

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_67.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_67 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab67.Text = " " & OBJ_MOTOR_GECKOFX_67.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_67.Text = tab67.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_68(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 68

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_68.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_68 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab68.Text = " " & OBJ_MOTOR_GECKOFX_68.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_68.Text = tab68.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_69(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 69

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_69.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_69 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab69.Text = " " & OBJ_MOTOR_GECKOFX_69.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_69.Text = tab69.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_70(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 70

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_70.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_70 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab70.Text = " " & OBJ_MOTOR_GECKOFX_70.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_70.Text = tab70.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_71(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 71

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_71.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_71 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab71.Text = " " & OBJ_MOTOR_GECKOFX_71.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_71.Text = tab71.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_72(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 72

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_72.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_72 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab72.Text = " " & OBJ_MOTOR_GECKOFX_72.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_72.Text = tab72.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_73(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 73

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_73.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_73 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab73.Text = " " & OBJ_MOTOR_GECKOFX_73.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_73.Text = tab73.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_74(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 74

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_74.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_74 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab74.Text = " " & OBJ_MOTOR_GECKOFX_74.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_74.Text = tab74.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_75(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 75

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_75.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_75 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab75.Text = " " & OBJ_MOTOR_GECKOFX_75.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_75.Text = tab75.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_76(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 76

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_76.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_76 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab76.Text = " " & OBJ_MOTOR_GECKOFX_76.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_76.Text = tab76.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_77(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 77

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_77.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_77 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab77.Text = " " & OBJ_MOTOR_GECKOFX_77.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_77.Text = tab77.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_78(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 78

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_78.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_78 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab78.Text = " " & OBJ_MOTOR_GECKOFX_78.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_78.Text = tab78.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_79(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 79

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_79.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_79 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab79.Text = " " & OBJ_MOTOR_GECKOFX_79.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_79.Text = tab79.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_80(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 80

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_80.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_80 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab80.Text = " " & OBJ_MOTOR_GECKOFX_80.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_80.Text = tab80.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_81(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 81

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_81.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_81 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab81.Text = " " & OBJ_MOTOR_GECKOFX_81.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_81.Text = tab81.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_82(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 82

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_82.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_82 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab82.Text = " " & OBJ_MOTOR_GECKOFX_82.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_82.Text = tab82.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_83(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 83

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_83.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_83 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab83.Text = " " & OBJ_MOTOR_GECKOFX_83.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_83.Text = tab83.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_84(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 84

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_84.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_84 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab84.Text = " " & OBJ_MOTOR_GECKOFX_84.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_84.Text = tab84.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_85(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 85

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_85.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_85 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab85.Text = " " & OBJ_MOTOR_GECKOFX_85.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_85.Text = tab85.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_86(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 86

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_86.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_86 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab86.Text = " " & OBJ_MOTOR_GECKOFX_86.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_86.Text = tab86.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_87(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 87

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_87.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_87 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab87.Text = " " & OBJ_MOTOR_GECKOFX_87.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_87.Text = tab87.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_88(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 88

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_88.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_88 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab88.Text = " " & OBJ_MOTOR_GECKOFX_88.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_88.Text = tab88.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_89(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 89

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_89.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_89 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab89.Text = " " & OBJ_MOTOR_GECKOFX_89.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_89.Text = tab89.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_90(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 90

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_90.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_90 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab90.Text = " " & OBJ_MOTOR_GECKOFX_90.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_90.Text = tab90.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_91(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 91

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_91.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_91 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab91.Text = " " & OBJ_MOTOR_GECKOFX_91.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_91.Text = tab91.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_92(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 92

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_92.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_92 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab92.Text = " " & OBJ_MOTOR_GECKOFX_92.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_92.Text = tab92.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_93(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 93

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_93.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_93 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab93.Text = " " & OBJ_MOTOR_GECKOFX_93.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_93.Text = tab93.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_94(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 94

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_94.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_94 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab94.Text = " " & OBJ_MOTOR_GECKOFX_94.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_94.Text = tab94.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_95(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 95

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_95.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_95 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab95.Text = " " & OBJ_MOTOR_GECKOFX_95.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_95.Text = tab95.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_96(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 96

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_96.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_96 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab96.Text = " " & OBJ_MOTOR_GECKOFX_96.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_96.Text = tab96.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_97(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 97

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_97.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_97 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab97.Text = " " & OBJ_MOTOR_GECKOFX_97.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_97.Text = tab97.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_98(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 98

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_98.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_98 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab98.Text = " " & OBJ_MOTOR_GECKOFX_98.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_98.Text = tab98.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_99(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 99

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_99.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_99 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab99.Text = " " & OBJ_MOTOR_GECKOFX_99.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_99.Text = tab99.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_100(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 100

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_100.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_100 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab100.Text = " " & OBJ_MOTOR_GECKOFX_100.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_100.Text = tab100.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_101(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 101

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_101.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_101 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab101.Text = " " & OBJ_MOTOR_GECKOFX_101.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_101.Text = tab101.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_102(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 102

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_102.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_102 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab102.Text = " " & OBJ_MOTOR_GECKOFX_102.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_102.Text = tab102.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_103(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 103

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_103.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_103 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab103.Text = " " & OBJ_MOTOR_GECKOFX_103.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_103.Text = tab103.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_104(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 104

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_104.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_104 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab104.Text = " " & OBJ_MOTOR_GECKOFX_104.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_104.Text = tab104.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_105(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 105

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_105.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_105 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab105.Text = " " & OBJ_MOTOR_GECKOFX_105.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_105.Text = tab105.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_106(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 106

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_106.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_106 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab106.Text = " " & OBJ_MOTOR_GECKOFX_106.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_106.Text = tab106.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_107(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 107

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_107.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_107 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab107.Text = " " & OBJ_MOTOR_GECKOFX_107.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_107.Text = tab107.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_108(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 108

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_108.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_108 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab108.Text = " " & OBJ_MOTOR_GECKOFX_108.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_108.Text = tab108.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_109(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 109

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_109.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_109 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab109.Text = " " & OBJ_MOTOR_GECKOFX_109.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_109.Text = tab109.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_110(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 110

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_110.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_110 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab110.Text = " " & OBJ_MOTOR_GECKOFX_110.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_110.Text = tab110.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_111(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 111

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_111.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_111 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab111.Text = " " & OBJ_MOTOR_GECKOFX_111.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_111.Text = tab111.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_112(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 112

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_112.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_112 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab112.Text = " " & OBJ_MOTOR_GECKOFX_112.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_112.Text = tab112.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_113(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 113

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_113.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_113 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab113.Text = " " & OBJ_MOTOR_GECKOFX_113.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_113.Text = tab113.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_114(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 114

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_114.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_114 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab114.Text = " " & OBJ_MOTOR_GECKOFX_114.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_114.Text = tab114.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_115(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 115

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_115.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_115 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab115.Text = " " & OBJ_MOTOR_GECKOFX_115.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_115.Text = tab115.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_116(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 116

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_116.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_116 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab116.Text = " " & OBJ_MOTOR_GECKOFX_116.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_116.Text = tab116.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_117(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 117

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_117.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_117 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab117.Text = " " & OBJ_MOTOR_GECKOFX_117.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_117.Text = tab117.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_118(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 118

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_118.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_118 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab118.Text = " " & OBJ_MOTOR_GECKOFX_118.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_118.Text = tab118.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_119(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 119

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_119.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_119 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab119.Text = " " & OBJ_MOTOR_GECKOFX_119.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_119.Text = tab119.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_120(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 120

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_120.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_120 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab120.Text = " " & OBJ_MOTOR_GECKOFX_120.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_120.Text = tab120.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_121(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 121

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_121.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_121 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab121.Text = " " & OBJ_MOTOR_GECKOFX_121.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_121.Text = tab121.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_122(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 122

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_122.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_122 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab122.Text = " " & OBJ_MOTOR_GECKOFX_122.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_122.Text = tab122.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_123(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 123

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_123.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_123 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab123.Text = " " & OBJ_MOTOR_GECKOFX_123.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_123.Text = tab123.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_124(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 124

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_124.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_124 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab124.Text = " " & OBJ_MOTOR_GECKOFX_124.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_124.Text = tab124.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_125(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 125

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_125.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_125 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab125.Text = " " & OBJ_MOTOR_GECKOFX_125.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_125.Text = tab125.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_126(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 126

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_126.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_126 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab126.Text = " " & OBJ_MOTOR_GECKOFX_126.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_126.Text = tab126.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_127(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 127

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_127.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_127 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab127.Text = " " & OBJ_MOTOR_GECKOFX_127.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_127.Text = tab127.Text 'Texto da tab

    End Sub

    Public Sub proc_carregamento_motor_geckofx_128(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoProgressEventArgs) 'Evento de carregamento do motor geckofx
        On Error Resume Next
        Dim v_token As Integer = 128

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_GECKOFX_128.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_128 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab128.Text = " " & OBJ_MOTOR_GECKOFX_128.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_128.Text = tab128.Text 'Texto da tab

    End Sub



    '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------















    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
















    'Evento motor trident ------------------------------------------------------------------------------------------------------------------------------------------------------------------


    Public Sub proc_carregamento_motor_trident_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 1

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_1.ProgressChanged, AddressOf proc_carregamento_motor_trident_1 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab1.Text = " " & OBJ_MOTOR_WEB_BROWSER_1.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_1.Text = tab1.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 2

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_2.ProgressChanged, AddressOf proc_carregamento_motor_trident_2 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab2.Text = " " & OBJ_MOTOR_WEB_BROWSER_2.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_2.Text = tab2.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_3(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 3

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_3.ProgressChanged, AddressOf proc_carregamento_motor_trident_3 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab3.Text = " " & OBJ_MOTOR_WEB_BROWSER_3.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_3.Text = tab3.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_4(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 4

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_4.ProgressChanged, AddressOf proc_carregamento_motor_trident_4 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab4.Text = " " & OBJ_MOTOR_WEB_BROWSER_4.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_4.Text = tab4.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_5(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 5

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_5.ProgressChanged, AddressOf proc_carregamento_motor_trident_5 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab5.Text = " " & OBJ_MOTOR_WEB_BROWSER_5.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_5.Text = tab5.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_6(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 6

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_6.ProgressChanged, AddressOf proc_carregamento_motor_trident_6 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab6.Text = " " & OBJ_MOTOR_WEB_BROWSER_6.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_6.Text = tab6.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_7(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 7

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_7.ProgressChanged, AddressOf proc_carregamento_motor_trident_7 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab7.Text = " " & OBJ_MOTOR_WEB_BROWSER_7.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_7.Text = tab7.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_8(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 8

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_8.ProgressChanged, AddressOf proc_carregamento_motor_trident_8 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab8.Text = " " & OBJ_MOTOR_WEB_BROWSER_8.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_8.Text = tab8.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_9(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 9

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_9.ProgressChanged, AddressOf proc_carregamento_motor_trident_9 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab9.Text = " " & OBJ_MOTOR_WEB_BROWSER_9.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_9.Text = tab9.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_10(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 10

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_10.ProgressChanged, AddressOf proc_carregamento_motor_trident_10 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab10.Text = " " & OBJ_MOTOR_WEB_BROWSER_10.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_10.Text = tab10.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_11(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 11

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_11.ProgressChanged, AddressOf proc_carregamento_motor_trident_11 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab11.Text = " " & OBJ_MOTOR_WEB_BROWSER_11.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_11.Text = tab11.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_12(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 12

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_12.ProgressChanged, AddressOf proc_carregamento_motor_trident_12 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab12.Text = " " & OBJ_MOTOR_WEB_BROWSER_12.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_12.Text = tab12.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_13(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 13

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_13.ProgressChanged, AddressOf proc_carregamento_motor_trident_13 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab13.Text = " " & OBJ_MOTOR_WEB_BROWSER_13.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_13.Text = tab13.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_14(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 14

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_14.ProgressChanged, AddressOf proc_carregamento_motor_trident_14 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab14.Text = " " & OBJ_MOTOR_WEB_BROWSER_14.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_14.Text = tab14.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_15(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 15

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_15.ProgressChanged, AddressOf proc_carregamento_motor_trident_15 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab15.Text = " " & OBJ_MOTOR_WEB_BROWSER_15.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_15.Text = tab15.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_16(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 16

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_16.ProgressChanged, AddressOf proc_carregamento_motor_trident_16 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab16.Text = " " & OBJ_MOTOR_WEB_BROWSER_16.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_16.Text = tab16.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_17(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 17

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_17.ProgressChanged, AddressOf proc_carregamento_motor_trident_17 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab17.Text = " " & OBJ_MOTOR_WEB_BROWSER_17.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_17.Text = tab17.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_18(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 18

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_18.ProgressChanged, AddressOf proc_carregamento_motor_trident_18 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab18.Text = " " & OBJ_MOTOR_WEB_BROWSER_18.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_18.Text = tab18.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_19(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 19

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_19.ProgressChanged, AddressOf proc_carregamento_motor_trident_19 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab19.Text = " " & OBJ_MOTOR_WEB_BROWSER_19.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_19.Text = tab19.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_20(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 20

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_20.ProgressChanged, AddressOf proc_carregamento_motor_trident_20 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab20.Text = " " & OBJ_MOTOR_WEB_BROWSER_20.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_20.Text = tab20.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_21(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 21

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_21.ProgressChanged, AddressOf proc_carregamento_motor_trident_21 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab21.Text = " " & OBJ_MOTOR_WEB_BROWSER_21.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_21.Text = tab21.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_22(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 22

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_22.ProgressChanged, AddressOf proc_carregamento_motor_trident_22 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab22.Text = " " & OBJ_MOTOR_WEB_BROWSER_22.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_22.Text = tab22.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_23(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 23

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_23.ProgressChanged, AddressOf proc_carregamento_motor_trident_23 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab23.Text = " " & OBJ_MOTOR_WEB_BROWSER_23.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_23.Text = tab23.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_24(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 24

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_24.ProgressChanged, AddressOf proc_carregamento_motor_trident_24 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab24.Text = " " & OBJ_MOTOR_WEB_BROWSER_24.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_24.Text = tab24.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_25(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 25

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_25.ProgressChanged, AddressOf proc_carregamento_motor_trident_25 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab25.Text = " " & OBJ_MOTOR_WEB_BROWSER_25.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_25.Text = tab25.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_26(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 26

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_26.ProgressChanged, AddressOf proc_carregamento_motor_trident_26 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab26.Text = " " & OBJ_MOTOR_WEB_BROWSER_26.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_26.Text = tab26.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_27(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 27

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_27.ProgressChanged, AddressOf proc_carregamento_motor_trident_27 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab27.Text = " " & OBJ_MOTOR_WEB_BROWSER_27.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_27.Text = tab27.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_28(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 28

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_28.ProgressChanged, AddressOf proc_carregamento_motor_trident_28 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab28.Text = " " & OBJ_MOTOR_WEB_BROWSER_28.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_28.Text = tab28.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_29(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 29

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_29.ProgressChanged, AddressOf proc_carregamento_motor_trident_29 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab29.Text = " " & OBJ_MOTOR_WEB_BROWSER_29.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_29.Text = tab29.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_30(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 30

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_30.ProgressChanged, AddressOf proc_carregamento_motor_trident_30 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab30.Text = " " & OBJ_MOTOR_WEB_BROWSER_30.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_30.Text = tab30.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_31(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 31

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_31.ProgressChanged, AddressOf proc_carregamento_motor_trident_31 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab31.Text = " " & OBJ_MOTOR_WEB_BROWSER_31.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_31.Text = tab31.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_32(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 32

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_32.ProgressChanged, AddressOf proc_carregamento_motor_trident_32 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab32.Text = " " & OBJ_MOTOR_WEB_BROWSER_32.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_32.Text = tab32.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_33(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 33

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_33.ProgressChanged, AddressOf proc_carregamento_motor_trident_33 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab33.Text = " " & OBJ_MOTOR_WEB_BROWSER_33.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_33.Text = tab33.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_34(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 34

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_34.ProgressChanged, AddressOf proc_carregamento_motor_trident_34 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab34.Text = " " & OBJ_MOTOR_WEB_BROWSER_34.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_34.Text = tab34.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_35(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 35

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_35.ProgressChanged, AddressOf proc_carregamento_motor_trident_35 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab35.Text = " " & OBJ_MOTOR_WEB_BROWSER_35.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_35.Text = tab35.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_36(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 36

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_36.ProgressChanged, AddressOf proc_carregamento_motor_trident_36 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab36.Text = " " & OBJ_MOTOR_WEB_BROWSER_36.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_36.Text = tab36.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_37(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 37

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_37.ProgressChanged, AddressOf proc_carregamento_motor_trident_37 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab37.Text = " " & OBJ_MOTOR_WEB_BROWSER_37.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_37.Text = tab37.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_38(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 38

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_38.ProgressChanged, AddressOf proc_carregamento_motor_trident_38 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab38.Text = " " & OBJ_MOTOR_WEB_BROWSER_38.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_38.Text = tab38.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_39(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 39

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_39.ProgressChanged, AddressOf proc_carregamento_motor_trident_39 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab39.Text = " " & OBJ_MOTOR_WEB_BROWSER_39.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_39.Text = tab39.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_40(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 40

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_40.ProgressChanged, AddressOf proc_carregamento_motor_trident_40 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab40.Text = " " & OBJ_MOTOR_WEB_BROWSER_40.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_40.Text = tab40.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_41(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 41

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_41.ProgressChanged, AddressOf proc_carregamento_motor_trident_41 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab41.Text = " " & OBJ_MOTOR_WEB_BROWSER_41.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_41.Text = tab41.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_42(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 42

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_42.ProgressChanged, AddressOf proc_carregamento_motor_trident_42 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab42.Text = " " & OBJ_MOTOR_WEB_BROWSER_42.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_42.Text = tab42.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_43(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 43

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_43.ProgressChanged, AddressOf proc_carregamento_motor_trident_43 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab43.Text = " " & OBJ_MOTOR_WEB_BROWSER_43.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_43.Text = tab43.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_44(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 44

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_44.ProgressChanged, AddressOf proc_carregamento_motor_trident_44 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab44.Text = " " & OBJ_MOTOR_WEB_BROWSER_44.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_44.Text = tab44.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_45(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 45

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_45.ProgressChanged, AddressOf proc_carregamento_motor_trident_45 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab45.Text = " " & OBJ_MOTOR_WEB_BROWSER_45.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_45.Text = tab45.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_46(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 46

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_46.ProgressChanged, AddressOf proc_carregamento_motor_trident_46 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab46.Text = " " & OBJ_MOTOR_WEB_BROWSER_46.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_46.Text = tab46.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_47(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 47

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_47.ProgressChanged, AddressOf proc_carregamento_motor_trident_47 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab47.Text = " " & OBJ_MOTOR_WEB_BROWSER_47.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_47.Text = tab47.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_48(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 48

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_48.ProgressChanged, AddressOf proc_carregamento_motor_trident_48 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab48.Text = " " & OBJ_MOTOR_WEB_BROWSER_48.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_48.Text = tab48.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_49(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 49

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_49.ProgressChanged, AddressOf proc_carregamento_motor_trident_49 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab49.Text = " " & OBJ_MOTOR_WEB_BROWSER_49.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_49.Text = tab49.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_50(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 50

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_50.ProgressChanged, AddressOf proc_carregamento_motor_trident_50 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab50.Text = " " & OBJ_MOTOR_WEB_BROWSER_50.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_50.Text = tab50.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_51(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 51

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_51.ProgressChanged, AddressOf proc_carregamento_motor_trident_51 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab51.Text = " " & OBJ_MOTOR_WEB_BROWSER_51.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_51.Text = tab51.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_52(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 52

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_52.ProgressChanged, AddressOf proc_carregamento_motor_trident_52 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab52.Text = " " & OBJ_MOTOR_WEB_BROWSER_52.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_52.Text = tab52.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_53(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 53

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_53.ProgressChanged, AddressOf proc_carregamento_motor_trident_53 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab53.Text = " " & OBJ_MOTOR_WEB_BROWSER_53.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_53.Text = tab53.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_54(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 54

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_54.ProgressChanged, AddressOf proc_carregamento_motor_trident_54 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab54.Text = " " & OBJ_MOTOR_WEB_BROWSER_54.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_54.Text = tab54.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_55(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 55

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_55.ProgressChanged, AddressOf proc_carregamento_motor_trident_55 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab55.Text = " " & OBJ_MOTOR_WEB_BROWSER_55.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_55.Text = tab55.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_56(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 56

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_56.ProgressChanged, AddressOf proc_carregamento_motor_trident_56 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab56.Text = " " & OBJ_MOTOR_WEB_BROWSER_56.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_56.Text = tab56.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_57(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 57

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_57.ProgressChanged, AddressOf proc_carregamento_motor_trident_57 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab57.Text = " " & OBJ_MOTOR_WEB_BROWSER_57.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_57.Text = tab57.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_58(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 58

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_58.ProgressChanged, AddressOf proc_carregamento_motor_trident_58 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab58.Text = " " & OBJ_MOTOR_WEB_BROWSER_58.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_58.Text = tab58.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_59(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 59

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_59.ProgressChanged, AddressOf proc_carregamento_motor_trident_59 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab59.Text = " " & OBJ_MOTOR_WEB_BROWSER_59.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_59.Text = tab59.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_60(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 60

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_60.ProgressChanged, AddressOf proc_carregamento_motor_trident_60 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab60.Text = " " & OBJ_MOTOR_WEB_BROWSER_60.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_60.Text = tab60.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_61(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 61

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_61.ProgressChanged, AddressOf proc_carregamento_motor_trident_61 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab61.Text = " " & OBJ_MOTOR_WEB_BROWSER_61.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_61.Text = tab61.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_62(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 62

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_62.ProgressChanged, AddressOf proc_carregamento_motor_trident_62 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab62.Text = " " & OBJ_MOTOR_WEB_BROWSER_62.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_62.Text = tab62.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_63(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 63

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_63.ProgressChanged, AddressOf proc_carregamento_motor_trident_63 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab63.Text = " " & OBJ_MOTOR_WEB_BROWSER_63.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_63.Text = tab63.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_64(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 64

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_64.ProgressChanged, AddressOf proc_carregamento_motor_trident_64 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab64.Text = " " & OBJ_MOTOR_WEB_BROWSER_64.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_64.Text = tab64.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_65(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 65

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_65.ProgressChanged, AddressOf proc_carregamento_motor_trident_65 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab65.Text = " " & OBJ_MOTOR_WEB_BROWSER_65.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_65.Text = tab65.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_66(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 66

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_66.ProgressChanged, AddressOf proc_carregamento_motor_trident_66 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab66.Text = " " & OBJ_MOTOR_WEB_BROWSER_66.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_66.Text = tab66.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_67(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 67

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_67.ProgressChanged, AddressOf proc_carregamento_motor_trident_67 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab67.Text = " " & OBJ_MOTOR_WEB_BROWSER_67.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_67.Text = tab67.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_68(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 68

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_68.ProgressChanged, AddressOf proc_carregamento_motor_trident_68 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab68.Text = " " & OBJ_MOTOR_WEB_BROWSER_68.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_68.Text = tab68.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_69(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 69

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_69.ProgressChanged, AddressOf proc_carregamento_motor_trident_69 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab69.Text = " " & OBJ_MOTOR_WEB_BROWSER_69.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_69.Text = tab69.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_70(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 70

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_70.ProgressChanged, AddressOf proc_carregamento_motor_trident_70 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab70.Text = " " & OBJ_MOTOR_WEB_BROWSER_70.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_70.Text = tab70.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_71(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 71

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_71.ProgressChanged, AddressOf proc_carregamento_motor_trident_71 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab71.Text = " " & OBJ_MOTOR_WEB_BROWSER_71.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_71.Text = tab71.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_72(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 72

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_72.ProgressChanged, AddressOf proc_carregamento_motor_trident_72 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab72.Text = " " & OBJ_MOTOR_WEB_BROWSER_72.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_72.Text = tab72.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_73(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 73

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_73.ProgressChanged, AddressOf proc_carregamento_motor_trident_73 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab73.Text = " " & OBJ_MOTOR_WEB_BROWSER_73.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_73.Text = tab73.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_74(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 74

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_74.ProgressChanged, AddressOf proc_carregamento_motor_trident_74 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab74.Text = " " & OBJ_MOTOR_WEB_BROWSER_74.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_74.Text = tab74.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_75(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 75

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_75.ProgressChanged, AddressOf proc_carregamento_motor_trident_75 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab75.Text = " " & OBJ_MOTOR_WEB_BROWSER_75.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_75.Text = tab75.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_76(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 76

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_76.ProgressChanged, AddressOf proc_carregamento_motor_trident_76 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab76.Text = " " & OBJ_MOTOR_WEB_BROWSER_76.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_76.Text = tab76.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_77(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 77

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_77.ProgressChanged, AddressOf proc_carregamento_motor_trident_77 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab77.Text = " " & OBJ_MOTOR_WEB_BROWSER_77.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_77.Text = tab77.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_78(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 78

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_78.ProgressChanged, AddressOf proc_carregamento_motor_trident_78 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab78.Text = " " & OBJ_MOTOR_WEB_BROWSER_78.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_78.Text = tab78.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_79(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 79

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_79.ProgressChanged, AddressOf proc_carregamento_motor_trident_79 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab79.Text = " " & OBJ_MOTOR_WEB_BROWSER_79.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_79.Text = tab79.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_80(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 80

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_80.ProgressChanged, AddressOf proc_carregamento_motor_trident_80 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab80.Text = " " & OBJ_MOTOR_WEB_BROWSER_80.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_80.Text = tab80.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_81(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 81

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_81.ProgressChanged, AddressOf proc_carregamento_motor_trident_81 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab81.Text = " " & OBJ_MOTOR_WEB_BROWSER_81.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_81.Text = tab81.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_82(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 82

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_82.ProgressChanged, AddressOf proc_carregamento_motor_trident_82 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab82.Text = " " & OBJ_MOTOR_WEB_BROWSER_82.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_82.Text = tab82.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_83(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 83

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_83.ProgressChanged, AddressOf proc_carregamento_motor_trident_83 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab83.Text = " " & OBJ_MOTOR_WEB_BROWSER_83.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_83.Text = tab83.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_84(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 84

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_84.ProgressChanged, AddressOf proc_carregamento_motor_trident_84 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab84.Text = " " & OBJ_MOTOR_WEB_BROWSER_84.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_84.Text = tab84.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_85(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 85

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_85.ProgressChanged, AddressOf proc_carregamento_motor_trident_85 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab85.Text = " " & OBJ_MOTOR_WEB_BROWSER_85.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_85.Text = tab85.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_86(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 86

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_86.ProgressChanged, AddressOf proc_carregamento_motor_trident_86 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab86.Text = " " & OBJ_MOTOR_WEB_BROWSER_86.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_86.Text = tab86.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_87(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 87

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_87.ProgressChanged, AddressOf proc_carregamento_motor_trident_87 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab87.Text = " " & OBJ_MOTOR_WEB_BROWSER_87.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_87.Text = tab87.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_88(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 88

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_88.ProgressChanged, AddressOf proc_carregamento_motor_trident_88 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab88.Text = " " & OBJ_MOTOR_WEB_BROWSER_88.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_88.Text = tab88.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_89(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 89

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_89.ProgressChanged, AddressOf proc_carregamento_motor_trident_89 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab89.Text = " " & OBJ_MOTOR_WEB_BROWSER_89.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_89.Text = tab89.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_90(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 90

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_90.ProgressChanged, AddressOf proc_carregamento_motor_trident_90 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab90.Text = " " & OBJ_MOTOR_WEB_BROWSER_90.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_90.Text = tab90.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_91(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 91

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_91.ProgressChanged, AddressOf proc_carregamento_motor_trident_91 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab91.Text = " " & OBJ_MOTOR_WEB_BROWSER_91.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_91.Text = tab91.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_92(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 92

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_92.ProgressChanged, AddressOf proc_carregamento_motor_trident_92 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab92.Text = " " & OBJ_MOTOR_WEB_BROWSER_92.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_92.Text = tab92.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_93(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 93

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_93.ProgressChanged, AddressOf proc_carregamento_motor_trident_93 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab93.Text = " " & OBJ_MOTOR_WEB_BROWSER_93.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_93.Text = tab93.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_94(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 94

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_94.ProgressChanged, AddressOf proc_carregamento_motor_trident_94 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab94.Text = " " & OBJ_MOTOR_WEB_BROWSER_94.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_94.Text = tab94.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_95(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 95

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_95.ProgressChanged, AddressOf proc_carregamento_motor_trident_95 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab95.Text = " " & OBJ_MOTOR_WEB_BROWSER_95.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_95.Text = tab95.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_96(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 96

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_96.ProgressChanged, AddressOf proc_carregamento_motor_trident_96 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab96.Text = " " & OBJ_MOTOR_WEB_BROWSER_96.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_96.Text = tab96.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_97(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 97

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_97.ProgressChanged, AddressOf proc_carregamento_motor_trident_97 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab97.Text = " " & OBJ_MOTOR_WEB_BROWSER_97.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_97.Text = tab97.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_98(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 98

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_98.ProgressChanged, AddressOf proc_carregamento_motor_trident_98 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab98.Text = " " & OBJ_MOTOR_WEB_BROWSER_98.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_98.Text = tab98.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_99(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 99

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_99.ProgressChanged, AddressOf proc_carregamento_motor_trident_99 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab99.Text = " " & OBJ_MOTOR_WEB_BROWSER_99.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_99.Text = tab99.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_100(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 100

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_100.ProgressChanged, AddressOf proc_carregamento_motor_trident_100 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab100.Text = " " & OBJ_MOTOR_WEB_BROWSER_100.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_100.Text = tab100.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_101(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 101

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_101.ProgressChanged, AddressOf proc_carregamento_motor_trident_101 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab101.Text = " " & OBJ_MOTOR_WEB_BROWSER_101.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_101.Text = tab101.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_102(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 102

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_102.ProgressChanged, AddressOf proc_carregamento_motor_trident_102 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab102.Text = " " & OBJ_MOTOR_WEB_BROWSER_102.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_102.Text = tab102.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_103(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 103

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_103.ProgressChanged, AddressOf proc_carregamento_motor_trident_103 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab103.Text = " " & OBJ_MOTOR_WEB_BROWSER_103.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_103.Text = tab103.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_104(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 104

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_104.ProgressChanged, AddressOf proc_carregamento_motor_trident_104 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab104.Text = " " & OBJ_MOTOR_WEB_BROWSER_104.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_104.Text = tab104.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_105(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 105

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_105.ProgressChanged, AddressOf proc_carregamento_motor_trident_105 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab105.Text = " " & OBJ_MOTOR_WEB_BROWSER_105.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_105.Text = tab105.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_106(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 106

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_106.ProgressChanged, AddressOf proc_carregamento_motor_trident_106 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab106.Text = " " & OBJ_MOTOR_WEB_BROWSER_106.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_106.Text = tab106.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_107(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 107

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_107.ProgressChanged, AddressOf proc_carregamento_motor_trident_107 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab107.Text = " " & OBJ_MOTOR_WEB_BROWSER_107.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_107.Text = tab107.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_108(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 108

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_108.ProgressChanged, AddressOf proc_carregamento_motor_trident_108 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab108.Text = " " & OBJ_MOTOR_WEB_BROWSER_108.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_108.Text = tab108.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_109(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 109

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_109.ProgressChanged, AddressOf proc_carregamento_motor_trident_109 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab109.Text = " " & OBJ_MOTOR_WEB_BROWSER_109.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_109.Text = tab109.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_110(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 110

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_110.ProgressChanged, AddressOf proc_carregamento_motor_trident_110 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab110.Text = " " & OBJ_MOTOR_WEB_BROWSER_110.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_110.Text = tab110.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_111(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 111

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_111.ProgressChanged, AddressOf proc_carregamento_motor_trident_111 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab111.Text = " " & OBJ_MOTOR_WEB_BROWSER_111.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_111.Text = tab111.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_112(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 112

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_112.ProgressChanged, AddressOf proc_carregamento_motor_trident_112 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab112.Text = " " & OBJ_MOTOR_WEB_BROWSER_112.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_112.Text = tab112.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_113(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 113

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_113.ProgressChanged, AddressOf proc_carregamento_motor_trident_113 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab113.Text = " " & OBJ_MOTOR_WEB_BROWSER_113.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_113.Text = tab113.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_114(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 114

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_114.ProgressChanged, AddressOf proc_carregamento_motor_trident_114 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab114.Text = " " & OBJ_MOTOR_WEB_BROWSER_114.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_114.Text = tab114.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_115(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 115

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_115.ProgressChanged, AddressOf proc_carregamento_motor_trident_115 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab115.Text = " " & OBJ_MOTOR_WEB_BROWSER_115.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_115.Text = tab115.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_116(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 116

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_116.ProgressChanged, AddressOf proc_carregamento_motor_trident_116 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab116.Text = " " & OBJ_MOTOR_WEB_BROWSER_116.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_116.Text = tab116.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_117(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 117

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_117.ProgressChanged, AddressOf proc_carregamento_motor_trident_117 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab117.Text = " " & OBJ_MOTOR_WEB_BROWSER_117.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_117.Text = tab117.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_118(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 118

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_118.ProgressChanged, AddressOf proc_carregamento_motor_trident_118 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab118.Text = " " & OBJ_MOTOR_WEB_BROWSER_118.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_118.Text = tab118.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_119(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 119

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_119.ProgressChanged, AddressOf proc_carregamento_motor_trident_119 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab119.Text = " " & OBJ_MOTOR_WEB_BROWSER_119.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_119.Text = tab119.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_120(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 120

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_120.ProgressChanged, AddressOf proc_carregamento_motor_trident_120 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab120.Text = " " & OBJ_MOTOR_WEB_BROWSER_120.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_120.Text = tab120.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_121(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 121

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_121.ProgressChanged, AddressOf proc_carregamento_motor_trident_121 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab121.Text = " " & OBJ_MOTOR_WEB_BROWSER_121.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_121.Text = tab121.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_122(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 122

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_122.ProgressChanged, AddressOf proc_carregamento_motor_trident_122 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab122.Text = " " & OBJ_MOTOR_WEB_BROWSER_122.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_122.Text = tab122.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_123(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 123

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_123.ProgressChanged, AddressOf proc_carregamento_motor_trident_123 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab123.Text = " " & OBJ_MOTOR_WEB_BROWSER_123.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_123.Text = tab123.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_124(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 124

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_124.ProgressChanged, AddressOf proc_carregamento_motor_trident_124 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab124.Text = " " & OBJ_MOTOR_WEB_BROWSER_124.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_124.Text = tab124.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_125(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 125

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_125.ProgressChanged, AddressOf proc_carregamento_motor_trident_125 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab125.Text = " " & OBJ_MOTOR_WEB_BROWSER_125.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_125.Text = tab125.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_126(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 126

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_126.ProgressChanged, AddressOf proc_carregamento_motor_trident_126 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab126.Text = " " & OBJ_MOTOR_WEB_BROWSER_126.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_126.Text = tab126.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_127(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 127

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_127.ProgressChanged, AddressOf proc_carregamento_motor_trident_127 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab127.Text = " " & OBJ_MOTOR_WEB_BROWSER_127.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_127.Text = tab127.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub

    Public Sub proc_carregamento_motor_trident_128(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) 'Evento de carregamento do motor trident
        On Error Resume Next
        Dim v_token As Integer = 128

        If (v_token <> v_qual_motor_esta_em_uso) Then
            RemoveHandler OBJ_MOTOR_WEB_BROWSER_128.ProgressChanged, AddressOf proc_carregamento_motor_trident_128 'Removendo evento
            Exit Sub
        End If

        FRM_NAVEGACAO.ProgressBarX1.Maximum = e.MaximumProgress 'Valor máximo de progresso 
        FRM_NAVEGACAO.ProgressBarX1.Value = e.CurrentProgress 'Porcentagem de carregamento
        FRM_NAVEGACAO.ToolStripProgressBar1.Maximum = e.MaximumProgress 'Valor máximo de progresso
        FRM_NAVEGACAO.ToolStripProgressBar1.Value = e.CurrentProgress 'Porcentagem de carregamento
        tab128.Text = " " & OBJ_MOTOR_WEB_BROWSER_128.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_128.Text = tab128.Text 'Texto da tab

        Proc_atualize_propriedades_status_text_trident() 'Atualiza as propriedades do status text na barra de status

    End Sub




    '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




















End Module
