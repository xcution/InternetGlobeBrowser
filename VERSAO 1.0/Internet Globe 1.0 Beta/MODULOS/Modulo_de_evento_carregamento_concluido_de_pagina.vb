Module Modulo_de_evento_carregamento_concluido_de_pagina


    'Evento do motor geckofx ---------------------------------------------------------------------------------------------------------------------------------------------------------------


    Public Sub proc_carregamento_completado_motor_geckofx_1(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 1

        tab1.Text = " " & OBJ_MOTOR_GECKOFX_1.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_1.Text = " " & OBJ_MOTOR_GECKOFX_1.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_1.DocumentTitle, OBJ_MOTOR_GECKOFX_1.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(1) = OBJ_MOTOR_GECKOFX_1.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_1.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_2(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 2

        tab2.Text = " " & OBJ_MOTOR_GECKOFX_2.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_2.Text = " " & OBJ_MOTOR_GECKOFX_2.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_2.DocumentTitle, OBJ_MOTOR_GECKOFX_2.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(2) = OBJ_MOTOR_GECKOFX_2.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_2.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_3(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 3

        tab3.Text = " " & OBJ_MOTOR_GECKOFX_3.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_3.Text = " " & OBJ_MOTOR_GECKOFX_3.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_3.DocumentTitle, OBJ_MOTOR_GECKOFX_3.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(3) = OBJ_MOTOR_GECKOFX_3.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_3.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_4(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 4

        tab4.Text = " " & OBJ_MOTOR_GECKOFX_4.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_4.Text = " " & OBJ_MOTOR_GECKOFX_4.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_4.DocumentTitle, OBJ_MOTOR_GECKOFX_4.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(4) = OBJ_MOTOR_GECKOFX_4.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_4.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_5(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 5

        tab5.Text = " " & OBJ_MOTOR_GECKOFX_5.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_5.Text = " " & OBJ_MOTOR_GECKOFX_5.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_5.DocumentTitle, OBJ_MOTOR_GECKOFX_5.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(5) = OBJ_MOTOR_GECKOFX_5.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_5.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_6(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 6

        tab6.Text = " " & OBJ_MOTOR_GECKOFX_6.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_6.Text = " " & OBJ_MOTOR_GECKOFX_6.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_6.DocumentTitle, OBJ_MOTOR_GECKOFX_6.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(6) = OBJ_MOTOR_GECKOFX_6.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_6.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_7(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 7

        tab7.Text = " " & OBJ_MOTOR_GECKOFX_7.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_7.Text = " " & OBJ_MOTOR_GECKOFX_7.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_7.DocumentTitle, OBJ_MOTOR_GECKOFX_7.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(7) = OBJ_MOTOR_GECKOFX_7.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_7.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_8(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 8

        tab8.Text = " " & OBJ_MOTOR_GECKOFX_8.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_8.Text = " " & OBJ_MOTOR_GECKOFX_8.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_8.DocumentTitle, OBJ_MOTOR_GECKOFX_8.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(8) = OBJ_MOTOR_GECKOFX_8.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_8.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_9(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 9

        tab9.Text = " " & OBJ_MOTOR_GECKOFX_9.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_9.Text = " " & OBJ_MOTOR_GECKOFX_9.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_9.DocumentTitle, OBJ_MOTOR_GECKOFX_9.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(9) = OBJ_MOTOR_GECKOFX_9.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_9.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_10(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 10

        tab10.Text = " " & OBJ_MOTOR_GECKOFX_10.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_10.Text = " " & OBJ_MOTOR_GECKOFX_10.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_10.DocumentTitle, OBJ_MOTOR_GECKOFX_10.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(10) = OBJ_MOTOR_GECKOFX_10.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_10.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_11(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 11

        tab11.Text = " " & OBJ_MOTOR_GECKOFX_11.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_11.Text = " " & OBJ_MOTOR_GECKOFX_11.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_11.DocumentTitle, OBJ_MOTOR_GECKOFX_11.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(11) = OBJ_MOTOR_GECKOFX_11.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_11.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_12(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 12

        tab12.Text = " " & OBJ_MOTOR_GECKOFX_12.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_12.Text = " " & OBJ_MOTOR_GECKOFX_12.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_12.DocumentTitle, OBJ_MOTOR_GECKOFX_12.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(12) = OBJ_MOTOR_GECKOFX_12.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_12.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_13(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 13

        tab13.Text = " " & OBJ_MOTOR_GECKOFX_13.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_13.Text = " " & OBJ_MOTOR_GECKOFX_13.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_13.DocumentTitle, OBJ_MOTOR_GECKOFX_13.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(13) = OBJ_MOTOR_GECKOFX_13.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_13.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_14(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 14

        tab14.Text = " " & OBJ_MOTOR_GECKOFX_14.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_14.Text = " " & OBJ_MOTOR_GECKOFX_14.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_14.DocumentTitle, OBJ_MOTOR_GECKOFX_14.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(14) = OBJ_MOTOR_GECKOFX_14.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_14.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_15(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 15

        tab15.Text = " " & OBJ_MOTOR_GECKOFX_15.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_15.Text = " " & OBJ_MOTOR_GECKOFX_15.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_15.DocumentTitle, OBJ_MOTOR_GECKOFX_15.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(15) = OBJ_MOTOR_GECKOFX_15.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_15.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_16(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 16

        tab16.Text = " " & OBJ_MOTOR_GECKOFX_16.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_16.Text = " " & OBJ_MOTOR_GECKOFX_16.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_16.DocumentTitle, OBJ_MOTOR_GECKOFX_16.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(16) = OBJ_MOTOR_GECKOFX_16.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_16.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_17(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 17

        tab17.Text = " " & OBJ_MOTOR_GECKOFX_17.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_17.Text = " " & OBJ_MOTOR_GECKOFX_17.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_17.DocumentTitle, OBJ_MOTOR_GECKOFX_17.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(17) = OBJ_MOTOR_GECKOFX_17.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_17.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_18(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 18

        tab18.Text = " " & OBJ_MOTOR_GECKOFX_18.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_18.Text = " " & OBJ_MOTOR_GECKOFX_18.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_18.DocumentTitle, OBJ_MOTOR_GECKOFX_18.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(18) = OBJ_MOTOR_GECKOFX_18.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_18.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_19(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 19

        tab19.Text = " " & OBJ_MOTOR_GECKOFX_19.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_19.Text = " " & OBJ_MOTOR_GECKOFX_19.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_19.DocumentTitle, OBJ_MOTOR_GECKOFX_19.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(19) = OBJ_MOTOR_GECKOFX_19.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_19.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_20(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 20

        tab20.Text = " " & OBJ_MOTOR_GECKOFX_20.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_20.Text = " " & OBJ_MOTOR_GECKOFX_20.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_20.DocumentTitle, OBJ_MOTOR_GECKOFX_20.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(20) = OBJ_MOTOR_GECKOFX_20.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_20.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_21(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 21

        tab21.Text = " " & OBJ_MOTOR_GECKOFX_21.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_21.Text = " " & OBJ_MOTOR_GECKOFX_21.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_21.DocumentTitle, OBJ_MOTOR_GECKOFX_21.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(21) = OBJ_MOTOR_GECKOFX_21.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_21.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_22(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 22

        tab22.Text = " " & OBJ_MOTOR_GECKOFX_22.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_22.Text = " " & OBJ_MOTOR_GECKOFX_22.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_22.DocumentTitle, OBJ_MOTOR_GECKOFX_22.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(22) = OBJ_MOTOR_GECKOFX_22.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_22.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_23(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 23

        tab23.Text = " " & OBJ_MOTOR_GECKOFX_23.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_23.Text = " " & OBJ_MOTOR_GECKOFX_23.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_23.DocumentTitle, OBJ_MOTOR_GECKOFX_23.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(23) = OBJ_MOTOR_GECKOFX_23.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_23.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_24(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 24

        tab24.Text = " " & OBJ_MOTOR_GECKOFX_24.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_24.Text = " " & OBJ_MOTOR_GECKOFX_24.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_24.DocumentTitle, OBJ_MOTOR_GECKOFX_24.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(24) = OBJ_MOTOR_GECKOFX_24.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_24.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_25(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 25

        tab25.Text = " " & OBJ_MOTOR_GECKOFX_25.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_25.Text = " " & OBJ_MOTOR_GECKOFX_25.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_25.DocumentTitle, OBJ_MOTOR_GECKOFX_25.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(25) = OBJ_MOTOR_GECKOFX_25.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_25.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_26(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 26

        tab26.Text = " " & OBJ_MOTOR_GECKOFX_26.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_26.Text = " " & OBJ_MOTOR_GECKOFX_26.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_26.DocumentTitle, OBJ_MOTOR_GECKOFX_26.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(26) = OBJ_MOTOR_GECKOFX_26.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_26.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_27(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 27

        tab27.Text = " " & OBJ_MOTOR_GECKOFX_27.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_27.Text = " " & OBJ_MOTOR_GECKOFX_27.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_27.DocumentTitle, OBJ_MOTOR_GECKOFX_27.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(27) = OBJ_MOTOR_GECKOFX_27.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_27.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_28(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 28

        tab28.Text = " " & OBJ_MOTOR_GECKOFX_28.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_28.Text = " " & OBJ_MOTOR_GECKOFX_28.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_28.DocumentTitle, OBJ_MOTOR_GECKOFX_28.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(28) = OBJ_MOTOR_GECKOFX_28.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_28.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_29(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 29

        tab29.Text = " " & OBJ_MOTOR_GECKOFX_29.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_29.Text = " " & OBJ_MOTOR_GECKOFX_29.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_29.DocumentTitle, OBJ_MOTOR_GECKOFX_29.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(29) = OBJ_MOTOR_GECKOFX_29.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_29.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_30(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 30

        tab30.Text = " " & OBJ_MOTOR_GECKOFX_30.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_30.Text = " " & OBJ_MOTOR_GECKOFX_30.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_30.DocumentTitle, OBJ_MOTOR_GECKOFX_30.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(30) = OBJ_MOTOR_GECKOFX_30.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_30.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_31(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 31

        tab31.Text = " " & OBJ_MOTOR_GECKOFX_31.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_31.Text = " " & OBJ_MOTOR_GECKOFX_31.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_31.DocumentTitle, OBJ_MOTOR_GECKOFX_31.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(31) = OBJ_MOTOR_GECKOFX_31.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_31.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_32(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 32

        tab32.Text = " " & OBJ_MOTOR_GECKOFX_32.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_32.Text = " " & OBJ_MOTOR_GECKOFX_32.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_32.DocumentTitle, OBJ_MOTOR_GECKOFX_32.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(32) = OBJ_MOTOR_GECKOFX_32.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_32.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_33(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 33

        tab33.Text = " " & OBJ_MOTOR_GECKOFX_33.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_33.Text = " " & OBJ_MOTOR_GECKOFX_33.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_33.DocumentTitle, OBJ_MOTOR_GECKOFX_33.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(33) = OBJ_MOTOR_GECKOFX_33.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_33.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_34(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 34

        tab34.Text = " " & OBJ_MOTOR_GECKOFX_34.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_34.Text = " " & OBJ_MOTOR_GECKOFX_34.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_34.DocumentTitle, OBJ_MOTOR_GECKOFX_34.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(34) = OBJ_MOTOR_GECKOFX_34.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_34.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_35(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 35

        tab35.Text = " " & OBJ_MOTOR_GECKOFX_35.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_35.Text = " " & OBJ_MOTOR_GECKOFX_35.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_35.DocumentTitle, OBJ_MOTOR_GECKOFX_35.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(35) = OBJ_MOTOR_GECKOFX_35.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_35.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_36(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 36

        tab36.Text = " " & OBJ_MOTOR_GECKOFX_36.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_36.Text = " " & OBJ_MOTOR_GECKOFX_36.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_36.DocumentTitle, OBJ_MOTOR_GECKOFX_36.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(36) = OBJ_MOTOR_GECKOFX_36.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_36.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_37(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 37

        tab37.Text = " " & OBJ_MOTOR_GECKOFX_37.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_37.Text = " " & OBJ_MOTOR_GECKOFX_37.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_37.DocumentTitle, OBJ_MOTOR_GECKOFX_37.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(37) = OBJ_MOTOR_GECKOFX_37.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_37.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_38(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 38

        tab38.Text = " " & OBJ_MOTOR_GECKOFX_38.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_38.Text = " " & OBJ_MOTOR_GECKOFX_38.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_38.DocumentTitle, OBJ_MOTOR_GECKOFX_38.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(38) = OBJ_MOTOR_GECKOFX_38.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_38.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_39(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 39

        tab39.Text = " " & OBJ_MOTOR_GECKOFX_39.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_39.Text = " " & OBJ_MOTOR_GECKOFX_39.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_39.DocumentTitle, OBJ_MOTOR_GECKOFX_39.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(39) = OBJ_MOTOR_GECKOFX_39.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_39.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_40(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 40

        tab40.Text = " " & OBJ_MOTOR_GECKOFX_40.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_40.Text = " " & OBJ_MOTOR_GECKOFX_40.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_40.DocumentTitle, OBJ_MOTOR_GECKOFX_40.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(40) = OBJ_MOTOR_GECKOFX_40.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_40.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_41(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 41

        tab41.Text = " " & OBJ_MOTOR_GECKOFX_41.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_41.Text = " " & OBJ_MOTOR_GECKOFX_41.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_41.DocumentTitle, OBJ_MOTOR_GECKOFX_41.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(41) = OBJ_MOTOR_GECKOFX_41.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_41.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_42(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 42

        tab42.Text = " " & OBJ_MOTOR_GECKOFX_42.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_42.Text = " " & OBJ_MOTOR_GECKOFX_42.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_42.DocumentTitle, OBJ_MOTOR_GECKOFX_42.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(42) = OBJ_MOTOR_GECKOFX_42.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_42.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_43(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 43

        tab43.Text = " " & OBJ_MOTOR_GECKOFX_43.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_43.Text = " " & OBJ_MOTOR_GECKOFX_43.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_43.DocumentTitle, OBJ_MOTOR_GECKOFX_43.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(43) = OBJ_MOTOR_GECKOFX_43.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_43.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_44(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 44

        tab44.Text = " " & OBJ_MOTOR_GECKOFX_44.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_44.Text = " " & OBJ_MOTOR_GECKOFX_44.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_44.DocumentTitle, OBJ_MOTOR_GECKOFX_44.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(44) = OBJ_MOTOR_GECKOFX_44.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_44.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_45(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 45

        tab45.Text = " " & OBJ_MOTOR_GECKOFX_45.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_45.Text = " " & OBJ_MOTOR_GECKOFX_45.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_45.DocumentTitle, OBJ_MOTOR_GECKOFX_45.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(45) = OBJ_MOTOR_GECKOFX_45.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_45.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_46(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 46

        tab46.Text = " " & OBJ_MOTOR_GECKOFX_46.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_46.Text = " " & OBJ_MOTOR_GECKOFX_46.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_46.DocumentTitle, OBJ_MOTOR_GECKOFX_46.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(46) = OBJ_MOTOR_GECKOFX_46.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_46.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_47(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 47

        tab47.Text = " " & OBJ_MOTOR_GECKOFX_47.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_47.Text = " " & OBJ_MOTOR_GECKOFX_47.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_47.DocumentTitle, OBJ_MOTOR_GECKOFX_47.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(47) = OBJ_MOTOR_GECKOFX_47.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_47.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_48(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 48

        tab48.Text = " " & OBJ_MOTOR_GECKOFX_48.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_48.Text = " " & OBJ_MOTOR_GECKOFX_48.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_48.DocumentTitle, OBJ_MOTOR_GECKOFX_48.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(48) = OBJ_MOTOR_GECKOFX_48.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_48.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_49(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 49

        tab49.Text = " " & OBJ_MOTOR_GECKOFX_49.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_49.Text = " " & OBJ_MOTOR_GECKOFX_49.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_49.DocumentTitle, OBJ_MOTOR_GECKOFX_49.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(49) = OBJ_MOTOR_GECKOFX_49.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_49.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_50(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 50

        tab50.Text = " " & OBJ_MOTOR_GECKOFX_50.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_50.Text = " " & OBJ_MOTOR_GECKOFX_50.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_50.DocumentTitle, OBJ_MOTOR_GECKOFX_50.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(50) = OBJ_MOTOR_GECKOFX_50.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_50.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_51(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 51

        tab51.Text = " " & OBJ_MOTOR_GECKOFX_51.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_51.Text = " " & OBJ_MOTOR_GECKOFX_51.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_51.DocumentTitle, OBJ_MOTOR_GECKOFX_51.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(51) = OBJ_MOTOR_GECKOFX_51.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_51.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_52(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 52

        tab52.Text = " " & OBJ_MOTOR_GECKOFX_52.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_52.Text = " " & OBJ_MOTOR_GECKOFX_52.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_52.DocumentTitle, OBJ_MOTOR_GECKOFX_52.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(52) = OBJ_MOTOR_GECKOFX_52.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_52.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_53(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 53

        tab53.Text = " " & OBJ_MOTOR_GECKOFX_53.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_53.Text = " " & OBJ_MOTOR_GECKOFX_53.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_53.DocumentTitle, OBJ_MOTOR_GECKOFX_53.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(53) = OBJ_MOTOR_GECKOFX_53.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_53.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_54(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 54

        tab54.Text = " " & OBJ_MOTOR_GECKOFX_54.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_54.Text = " " & OBJ_MOTOR_GECKOFX_54.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_54.DocumentTitle, OBJ_MOTOR_GECKOFX_54.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(54) = OBJ_MOTOR_GECKOFX_54.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_54.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_55(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 55

        tab55.Text = " " & OBJ_MOTOR_GECKOFX_55.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_55.Text = " " & OBJ_MOTOR_GECKOFX_55.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_55.DocumentTitle, OBJ_MOTOR_GECKOFX_55.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(55) = OBJ_MOTOR_GECKOFX_55.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_55.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_56(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 56

        tab56.Text = " " & OBJ_MOTOR_GECKOFX_56.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_56.Text = " " & OBJ_MOTOR_GECKOFX_56.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_56.DocumentTitle, OBJ_MOTOR_GECKOFX_56.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(56) = OBJ_MOTOR_GECKOFX_56.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_56.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_57(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 57

        tab57.Text = " " & OBJ_MOTOR_GECKOFX_57.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_57.Text = " " & OBJ_MOTOR_GECKOFX_57.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_57.DocumentTitle, OBJ_MOTOR_GECKOFX_57.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(57) = OBJ_MOTOR_GECKOFX_57.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_57.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_58(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 58

        tab58.Text = " " & OBJ_MOTOR_GECKOFX_58.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_58.Text = " " & OBJ_MOTOR_GECKOFX_58.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_58.DocumentTitle, OBJ_MOTOR_GECKOFX_58.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(58) = OBJ_MOTOR_GECKOFX_58.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_58.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_59(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 59

        tab59.Text = " " & OBJ_MOTOR_GECKOFX_59.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_59.Text = " " & OBJ_MOTOR_GECKOFX_59.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_59.DocumentTitle, OBJ_MOTOR_GECKOFX_59.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(59) = OBJ_MOTOR_GECKOFX_59.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_59.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_60(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 60

        tab60.Text = " " & OBJ_MOTOR_GECKOFX_60.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_60.Text = " " & OBJ_MOTOR_GECKOFX_60.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_60.DocumentTitle, OBJ_MOTOR_GECKOFX_60.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(60) = OBJ_MOTOR_GECKOFX_60.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_60.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_61(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 61

        tab61.Text = " " & OBJ_MOTOR_GECKOFX_61.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_61.Text = " " & OBJ_MOTOR_GECKOFX_61.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_61.DocumentTitle, OBJ_MOTOR_GECKOFX_61.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(61) = OBJ_MOTOR_GECKOFX_61.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_61.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_62(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 62

        tab62.Text = " " & OBJ_MOTOR_GECKOFX_62.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_62.Text = " " & OBJ_MOTOR_GECKOFX_62.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_62.DocumentTitle, OBJ_MOTOR_GECKOFX_62.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(62) = OBJ_MOTOR_GECKOFX_62.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_62.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_63(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 63

        tab63.Text = " " & OBJ_MOTOR_GECKOFX_63.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_63.Text = " " & OBJ_MOTOR_GECKOFX_63.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_63.DocumentTitle, OBJ_MOTOR_GECKOFX_63.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(63) = OBJ_MOTOR_GECKOFX_63.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_63.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_64(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 64

        tab64.Text = " " & OBJ_MOTOR_GECKOFX_64.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_64.Text = " " & OBJ_MOTOR_GECKOFX_64.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_64.DocumentTitle, OBJ_MOTOR_GECKOFX_64.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(64) = OBJ_MOTOR_GECKOFX_64.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_64.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_65(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 65

        tab65.Text = " " & OBJ_MOTOR_GECKOFX_65.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_65.Text = " " & OBJ_MOTOR_GECKOFX_65.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_65.DocumentTitle, OBJ_MOTOR_GECKOFX_65.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(65) = OBJ_MOTOR_GECKOFX_65.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_65.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_66(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 66

        tab66.Text = " " & OBJ_MOTOR_GECKOFX_66.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_66.Text = " " & OBJ_MOTOR_GECKOFX_66.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_66.DocumentTitle, OBJ_MOTOR_GECKOFX_66.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(66) = OBJ_MOTOR_GECKOFX_66.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_66.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_67(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 67

        tab67.Text = " " & OBJ_MOTOR_GECKOFX_67.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_67.Text = " " & OBJ_MOTOR_GECKOFX_67.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_67.DocumentTitle, OBJ_MOTOR_GECKOFX_67.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(67) = OBJ_MOTOR_GECKOFX_67.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_67.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_68(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 68

        tab68.Text = " " & OBJ_MOTOR_GECKOFX_68.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_68.Text = " " & OBJ_MOTOR_GECKOFX_68.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_68.DocumentTitle, OBJ_MOTOR_GECKOFX_68.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(68) = OBJ_MOTOR_GECKOFX_68.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_68.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_69(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 69

        tab69.Text = " " & OBJ_MOTOR_GECKOFX_69.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_69.Text = " " & OBJ_MOTOR_GECKOFX_69.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_69.DocumentTitle, OBJ_MOTOR_GECKOFX_69.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(69) = OBJ_MOTOR_GECKOFX_69.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_69.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_70(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 70

        tab70.Text = " " & OBJ_MOTOR_GECKOFX_70.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_70.Text = " " & OBJ_MOTOR_GECKOFX_70.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_70.DocumentTitle, OBJ_MOTOR_GECKOFX_70.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(70) = OBJ_MOTOR_GECKOFX_70.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_70.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_71(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 71

        tab71.Text = " " & OBJ_MOTOR_GECKOFX_71.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_71.Text = " " & OBJ_MOTOR_GECKOFX_71.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_71.DocumentTitle, OBJ_MOTOR_GECKOFX_71.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(71) = OBJ_MOTOR_GECKOFX_71.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_71.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_72(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 72

        tab72.Text = " " & OBJ_MOTOR_GECKOFX_72.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_72.Text = " " & OBJ_MOTOR_GECKOFX_72.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_72.DocumentTitle, OBJ_MOTOR_GECKOFX_72.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(72) = OBJ_MOTOR_GECKOFX_72.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_72.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_73(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 73

        tab73.Text = " " & OBJ_MOTOR_GECKOFX_73.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_73.Text = " " & OBJ_MOTOR_GECKOFX_73.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_73.DocumentTitle, OBJ_MOTOR_GECKOFX_73.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(73) = OBJ_MOTOR_GECKOFX_73.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_73.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_74(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 74

        tab74.Text = " " & OBJ_MOTOR_GECKOFX_74.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_74.Text = " " & OBJ_MOTOR_GECKOFX_74.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_74.DocumentTitle, OBJ_MOTOR_GECKOFX_74.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(74) = OBJ_MOTOR_GECKOFX_74.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_74.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_75(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 75

        tab75.Text = " " & OBJ_MOTOR_GECKOFX_75.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_75.Text = " " & OBJ_MOTOR_GECKOFX_75.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_75.DocumentTitle, OBJ_MOTOR_GECKOFX_75.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(75) = OBJ_MOTOR_GECKOFX_75.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_75.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_76(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 76

        tab76.Text = " " & OBJ_MOTOR_GECKOFX_76.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_76.Text = " " & OBJ_MOTOR_GECKOFX_76.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_76.DocumentTitle, OBJ_MOTOR_GECKOFX_76.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(76) = OBJ_MOTOR_GECKOFX_76.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_76.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_77(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 77

        tab77.Text = " " & OBJ_MOTOR_GECKOFX_77.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_77.Text = " " & OBJ_MOTOR_GECKOFX_77.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_77.DocumentTitle, OBJ_MOTOR_GECKOFX_77.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(77) = OBJ_MOTOR_GECKOFX_77.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_77.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_78(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 78

        tab78.Text = " " & OBJ_MOTOR_GECKOFX_78.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_78.Text = " " & OBJ_MOTOR_GECKOFX_78.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_78.DocumentTitle, OBJ_MOTOR_GECKOFX_78.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(78) = OBJ_MOTOR_GECKOFX_78.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_78.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_79(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 79

        tab79.Text = " " & OBJ_MOTOR_GECKOFX_79.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_79.Text = " " & OBJ_MOTOR_GECKOFX_79.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_79.DocumentTitle, OBJ_MOTOR_GECKOFX_79.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(79) = OBJ_MOTOR_GECKOFX_79.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_79.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_80(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 80

        tab80.Text = " " & OBJ_MOTOR_GECKOFX_80.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_80.Text = " " & OBJ_MOTOR_GECKOFX_80.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_80.DocumentTitle, OBJ_MOTOR_GECKOFX_80.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(80) = OBJ_MOTOR_GECKOFX_80.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_80.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_81(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 81

        tab81.Text = " " & OBJ_MOTOR_GECKOFX_81.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_81.Text = " " & OBJ_MOTOR_GECKOFX_81.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_81.DocumentTitle, OBJ_MOTOR_GECKOFX_81.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(81) = OBJ_MOTOR_GECKOFX_81.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_81.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_82(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 82

        tab82.Text = " " & OBJ_MOTOR_GECKOFX_82.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_82.Text = " " & OBJ_MOTOR_GECKOFX_82.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_82.DocumentTitle, OBJ_MOTOR_GECKOFX_82.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(82) = OBJ_MOTOR_GECKOFX_82.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_82.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_83(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 83

        tab83.Text = " " & OBJ_MOTOR_GECKOFX_83.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_83.Text = " " & OBJ_MOTOR_GECKOFX_83.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_83.DocumentTitle, OBJ_MOTOR_GECKOFX_83.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(83) = OBJ_MOTOR_GECKOFX_83.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_83.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_84(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 84

        tab84.Text = " " & OBJ_MOTOR_GECKOFX_84.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_84.Text = " " & OBJ_MOTOR_GECKOFX_84.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_84.DocumentTitle, OBJ_MOTOR_GECKOFX_84.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(84) = OBJ_MOTOR_GECKOFX_84.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_84.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_85(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 85

        tab85.Text = " " & OBJ_MOTOR_GECKOFX_85.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_85.Text = " " & OBJ_MOTOR_GECKOFX_85.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_85.DocumentTitle, OBJ_MOTOR_GECKOFX_85.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(85) = OBJ_MOTOR_GECKOFX_85.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_85.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_86(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 86

        tab86.Text = " " & OBJ_MOTOR_GECKOFX_86.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_86.Text = " " & OBJ_MOTOR_GECKOFX_86.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_86.DocumentTitle, OBJ_MOTOR_GECKOFX_86.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(86) = OBJ_MOTOR_GECKOFX_86.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_86.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_87(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 87

        tab87.Text = " " & OBJ_MOTOR_GECKOFX_87.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_87.Text = " " & OBJ_MOTOR_GECKOFX_87.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_87.DocumentTitle, OBJ_MOTOR_GECKOFX_87.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(87) = OBJ_MOTOR_GECKOFX_87.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_87.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_88(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 88

        tab88.Text = " " & OBJ_MOTOR_GECKOFX_88.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_88.Text = " " & OBJ_MOTOR_GECKOFX_88.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_88.DocumentTitle, OBJ_MOTOR_GECKOFX_88.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(88) = OBJ_MOTOR_GECKOFX_88.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_88.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_89(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 89

        tab89.Text = " " & OBJ_MOTOR_GECKOFX_89.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_89.Text = " " & OBJ_MOTOR_GECKOFX_89.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_89.DocumentTitle, OBJ_MOTOR_GECKOFX_89.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(89) = OBJ_MOTOR_GECKOFX_89.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_89.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_90(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 90

        tab90.Text = " " & OBJ_MOTOR_GECKOFX_90.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_90.Text = " " & OBJ_MOTOR_GECKOFX_90.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_90.DocumentTitle, OBJ_MOTOR_GECKOFX_90.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(90) = OBJ_MOTOR_GECKOFX_90.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_90.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_91(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 91

        tab91.Text = " " & OBJ_MOTOR_GECKOFX_91.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_91.Text = " " & OBJ_MOTOR_GECKOFX_91.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_91.DocumentTitle, OBJ_MOTOR_GECKOFX_91.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(91) = OBJ_MOTOR_GECKOFX_91.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_91.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_92(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 92

        tab92.Text = " " & OBJ_MOTOR_GECKOFX_92.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_92.Text = " " & OBJ_MOTOR_GECKOFX_92.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_92.DocumentTitle, OBJ_MOTOR_GECKOFX_92.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(92) = OBJ_MOTOR_GECKOFX_92.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_92.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_93(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 93

        tab93.Text = " " & OBJ_MOTOR_GECKOFX_93.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_93.Text = " " & OBJ_MOTOR_GECKOFX_93.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_93.DocumentTitle, OBJ_MOTOR_GECKOFX_93.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(93) = OBJ_MOTOR_GECKOFX_93.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_93.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_94(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 94

        tab94.Text = " " & OBJ_MOTOR_GECKOFX_94.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_94.Text = " " & OBJ_MOTOR_GECKOFX_94.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_94.DocumentTitle, OBJ_MOTOR_GECKOFX_94.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(94) = OBJ_MOTOR_GECKOFX_94.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_94.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_95(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 95

        tab95.Text = " " & OBJ_MOTOR_GECKOFX_95.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_95.Text = " " & OBJ_MOTOR_GECKOFX_95.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_95.DocumentTitle, OBJ_MOTOR_GECKOFX_95.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(95) = OBJ_MOTOR_GECKOFX_95.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_95.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_96(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 96

        tab96.Text = " " & OBJ_MOTOR_GECKOFX_96.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_96.Text = " " & OBJ_MOTOR_GECKOFX_96.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_96.DocumentTitle, OBJ_MOTOR_GECKOFX_96.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(96) = OBJ_MOTOR_GECKOFX_96.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_96.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_97(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 97

        tab97.Text = " " & OBJ_MOTOR_GECKOFX_97.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_97.Text = " " & OBJ_MOTOR_GECKOFX_97.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_97.DocumentTitle, OBJ_MOTOR_GECKOFX_97.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(97) = OBJ_MOTOR_GECKOFX_97.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_97.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_98(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 98

        tab98.Text = " " & OBJ_MOTOR_GECKOFX_98.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_98.Text = " " & OBJ_MOTOR_GECKOFX_98.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_98.DocumentTitle, OBJ_MOTOR_GECKOFX_98.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(98) = OBJ_MOTOR_GECKOFX_98.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_98.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_99(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 99

        tab99.Text = " " & OBJ_MOTOR_GECKOFX_99.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_99.Text = " " & OBJ_MOTOR_GECKOFX_99.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_99.DocumentTitle, OBJ_MOTOR_GECKOFX_99.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(99) = OBJ_MOTOR_GECKOFX_99.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_99.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_100(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 100

        tab100.Text = " " & OBJ_MOTOR_GECKOFX_100.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_100.Text = " " & OBJ_MOTOR_GECKOFX_100.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_100.DocumentTitle, OBJ_MOTOR_GECKOFX_100.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(100) = OBJ_MOTOR_GECKOFX_100.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_100.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_101(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 101

        tab101.Text = " " & OBJ_MOTOR_GECKOFX_101.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_101.Text = " " & OBJ_MOTOR_GECKOFX_101.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_101.DocumentTitle, OBJ_MOTOR_GECKOFX_101.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(101) = OBJ_MOTOR_GECKOFX_101.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_101.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_102(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 102

        tab102.Text = " " & OBJ_MOTOR_GECKOFX_102.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_102.Text = " " & OBJ_MOTOR_GECKOFX_102.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_102.DocumentTitle, OBJ_MOTOR_GECKOFX_102.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(102) = OBJ_MOTOR_GECKOFX_102.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_102.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_103(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 103

        tab103.Text = " " & OBJ_MOTOR_GECKOFX_103.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_103.Text = " " & OBJ_MOTOR_GECKOFX_103.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_103.DocumentTitle, OBJ_MOTOR_GECKOFX_103.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(103) = OBJ_MOTOR_GECKOFX_103.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_103.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_104(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 104

        tab104.Text = " " & OBJ_MOTOR_GECKOFX_104.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_104.Text = " " & OBJ_MOTOR_GECKOFX_104.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_104.DocumentTitle, OBJ_MOTOR_GECKOFX_104.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(104) = OBJ_MOTOR_GECKOFX_104.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_104.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_105(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 105

        tab105.Text = " " & OBJ_MOTOR_GECKOFX_105.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_105.Text = " " & OBJ_MOTOR_GECKOFX_105.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_105.DocumentTitle, OBJ_MOTOR_GECKOFX_105.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(105) = OBJ_MOTOR_GECKOFX_105.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_105.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_106(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 106

        tab106.Text = " " & OBJ_MOTOR_GECKOFX_106.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_106.Text = " " & OBJ_MOTOR_GECKOFX_106.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_106.DocumentTitle, OBJ_MOTOR_GECKOFX_106.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(106) = OBJ_MOTOR_GECKOFX_106.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_106.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_107(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 107

        tab107.Text = " " & OBJ_MOTOR_GECKOFX_107.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_107.Text = " " & OBJ_MOTOR_GECKOFX_107.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_107.DocumentTitle, OBJ_MOTOR_GECKOFX_107.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(107) = OBJ_MOTOR_GECKOFX_107.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_107.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_108(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 108

        tab108.Text = " " & OBJ_MOTOR_GECKOFX_108.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_108.Text = " " & OBJ_MOTOR_GECKOFX_108.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_108.DocumentTitle, OBJ_MOTOR_GECKOFX_108.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(108) = OBJ_MOTOR_GECKOFX_108.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_108.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_109(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 109

        tab109.Text = " " & OBJ_MOTOR_GECKOFX_109.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_109.Text = " " & OBJ_MOTOR_GECKOFX_109.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_109.DocumentTitle, OBJ_MOTOR_GECKOFX_109.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(109) = OBJ_MOTOR_GECKOFX_109.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_109.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_110(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 110

        tab110.Text = " " & OBJ_MOTOR_GECKOFX_110.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_110.Text = " " & OBJ_MOTOR_GECKOFX_110.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_110.DocumentTitle, OBJ_MOTOR_GECKOFX_110.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(110) = OBJ_MOTOR_GECKOFX_110.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_110.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_111(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 111

        tab111.Text = " " & OBJ_MOTOR_GECKOFX_111.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_111.Text = " " & OBJ_MOTOR_GECKOFX_111.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_111.DocumentTitle, OBJ_MOTOR_GECKOFX_111.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(111) = OBJ_MOTOR_GECKOFX_111.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_111.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_112(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 112

        tab112.Text = " " & OBJ_MOTOR_GECKOFX_112.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_112.Text = " " & OBJ_MOTOR_GECKOFX_112.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_112.DocumentTitle, OBJ_MOTOR_GECKOFX_112.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(112) = OBJ_MOTOR_GECKOFX_112.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_112.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_113(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 113

        tab113.Text = " " & OBJ_MOTOR_GECKOFX_113.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_113.Text = " " & OBJ_MOTOR_GECKOFX_113.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_113.DocumentTitle, OBJ_MOTOR_GECKOFX_113.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(113) = OBJ_MOTOR_GECKOFX_113.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_113.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_114(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 114

        tab114.Text = " " & OBJ_MOTOR_GECKOFX_114.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_114.Text = " " & OBJ_MOTOR_GECKOFX_114.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_114.DocumentTitle, OBJ_MOTOR_GECKOFX_114.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(114) = OBJ_MOTOR_GECKOFX_114.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_114.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_115(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 115

        tab115.Text = " " & OBJ_MOTOR_GECKOFX_115.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_115.Text = " " & OBJ_MOTOR_GECKOFX_115.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_115.DocumentTitle, OBJ_MOTOR_GECKOFX_115.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(115) = OBJ_MOTOR_GECKOFX_115.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_115.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_116(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 116

        tab116.Text = " " & OBJ_MOTOR_GECKOFX_116.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_116.Text = " " & OBJ_MOTOR_GECKOFX_116.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_116.DocumentTitle, OBJ_MOTOR_GECKOFX_116.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(116) = OBJ_MOTOR_GECKOFX_116.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_116.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_117(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 117

        tab117.Text = " " & OBJ_MOTOR_GECKOFX_117.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_117.Text = " " & OBJ_MOTOR_GECKOFX_117.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_117.DocumentTitle, OBJ_MOTOR_GECKOFX_117.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(117) = OBJ_MOTOR_GECKOFX_117.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_117.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_118(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 118

        tab118.Text = " " & OBJ_MOTOR_GECKOFX_118.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_118.Text = " " & OBJ_MOTOR_GECKOFX_118.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_118.DocumentTitle, OBJ_MOTOR_GECKOFX_118.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(118) = OBJ_MOTOR_GECKOFX_118.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_118.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_119(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 119

        tab119.Text = " " & OBJ_MOTOR_GECKOFX_119.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_119.Text = " " & OBJ_MOTOR_GECKOFX_119.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_119.DocumentTitle, OBJ_MOTOR_GECKOFX_119.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(119) = OBJ_MOTOR_GECKOFX_119.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_119.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_120(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 120

        tab120.Text = " " & OBJ_MOTOR_GECKOFX_120.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_120.Text = " " & OBJ_MOTOR_GECKOFX_120.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_120.DocumentTitle, OBJ_MOTOR_GECKOFX_120.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(120) = OBJ_MOTOR_GECKOFX_120.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_120.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_121(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 121

        tab121.Text = " " & OBJ_MOTOR_GECKOFX_121.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_121.Text = " " & OBJ_MOTOR_GECKOFX_121.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_121.DocumentTitle, OBJ_MOTOR_GECKOFX_121.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(121) = OBJ_MOTOR_GECKOFX_121.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_121.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_122(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 122

        tab122.Text = " " & OBJ_MOTOR_GECKOFX_122.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_122.Text = " " & OBJ_MOTOR_GECKOFX_122.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_122.DocumentTitle, OBJ_MOTOR_GECKOFX_122.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(122) = OBJ_MOTOR_GECKOFX_122.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_122.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_123(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 123

        tab123.Text = " " & OBJ_MOTOR_GECKOFX_123.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_123.Text = " " & OBJ_MOTOR_GECKOFX_123.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_123.DocumentTitle, OBJ_MOTOR_GECKOFX_123.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(123) = OBJ_MOTOR_GECKOFX_123.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_123.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_124(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 124

        tab124.Text = " " & OBJ_MOTOR_GECKOFX_124.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_124.Text = " " & OBJ_MOTOR_GECKOFX_124.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_124.DocumentTitle, OBJ_MOTOR_GECKOFX_124.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(124) = OBJ_MOTOR_GECKOFX_124.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_124.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_125(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 125

        tab125.Text = " " & OBJ_MOTOR_GECKOFX_125.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_125.Text = " " & OBJ_MOTOR_GECKOFX_125.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_125.DocumentTitle, OBJ_MOTOR_GECKOFX_125.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(125) = OBJ_MOTOR_GECKOFX_125.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_125.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_126(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 126

        tab126.Text = " " & OBJ_MOTOR_GECKOFX_126.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_126.Text = " " & OBJ_MOTOR_GECKOFX_126.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_126.DocumentTitle, OBJ_MOTOR_GECKOFX_126.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(126) = OBJ_MOTOR_GECKOFX_126.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_126.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_127(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 127

        tab127.Text = " " & OBJ_MOTOR_GECKOFX_127.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_127.Text = " " & OBJ_MOTOR_GECKOFX_127.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_127.DocumentTitle, OBJ_MOTOR_GECKOFX_127.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(127) = OBJ_MOTOR_GECKOFX_127.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_127.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_geckofx_128(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 128

        tab128.Text = " " & OBJ_MOTOR_GECKOFX_128.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_128.Text = " " & OBJ_MOTOR_GECKOFX_128.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_geckofx(OBJ_MOTOR_GECKOFX_128.DocumentTitle, OBJ_MOTOR_GECKOFX_128.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(128) = OBJ_MOTOR_GECKOFX_128.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_128.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_geckofx_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub




    '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------












    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::












    'Evento motor trident ------------------------------------------------------------------------------------------------------------------------------------------------------------------



    Public Sub proc_carregamento_completado_motor_trident_1(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 1

        tab1.Text = " " & OBJ_MOTOR_WEB_BROWSER_1.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_1.Text = " " & OBJ_MOTOR_WEB_BROWSER_1.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_1.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_1.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(1) = OBJ_MOTOR_WEB_BROWSER_1.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_1.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_2(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 2

        tab2.Text = " " & OBJ_MOTOR_WEB_BROWSER_2.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_2.Text = " " & OBJ_MOTOR_WEB_BROWSER_2.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_2.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_2.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(2) = OBJ_MOTOR_WEB_BROWSER_2.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_2.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_3(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 3

        tab3.Text = " " & OBJ_MOTOR_WEB_BROWSER_3.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_3.Text = " " & OBJ_MOTOR_WEB_BROWSER_3.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_3.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_3.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(3) = OBJ_MOTOR_WEB_BROWSER_3.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_3.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_4(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 4

        tab4.Text = " " & OBJ_MOTOR_WEB_BROWSER_4.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_4.Text = " " & OBJ_MOTOR_WEB_BROWSER_4.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_4.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_4.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(4) = OBJ_MOTOR_WEB_BROWSER_4.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_4.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_5(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 5

        tab5.Text = " " & OBJ_MOTOR_WEB_BROWSER_5.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_5.Text = " " & OBJ_MOTOR_WEB_BROWSER_5.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_5.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_5.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(5) = OBJ_MOTOR_WEB_BROWSER_5.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_5.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_6(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 6

        tab6.Text = " " & OBJ_MOTOR_WEB_BROWSER_6.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_6.Text = " " & OBJ_MOTOR_WEB_BROWSER_6.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_6.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_6.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(6) = OBJ_MOTOR_WEB_BROWSER_6.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_6.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_7(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 7

        tab7.Text = " " & OBJ_MOTOR_WEB_BROWSER_7.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_7.Text = " " & OBJ_MOTOR_WEB_BROWSER_7.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_7.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_7.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(7) = OBJ_MOTOR_WEB_BROWSER_7.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_7.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_8(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 8

        tab8.Text = " " & OBJ_MOTOR_WEB_BROWSER_8.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_8.Text = " " & OBJ_MOTOR_WEB_BROWSER_8.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_8.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_8.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(8) = OBJ_MOTOR_WEB_BROWSER_8.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_8.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_9(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 9

        tab9.Text = " " & OBJ_MOTOR_WEB_BROWSER_9.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_9.Text = " " & OBJ_MOTOR_WEB_BROWSER_9.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_9.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_9.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(9) = OBJ_MOTOR_WEB_BROWSER_9.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_9.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_10(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 10

        tab10.Text = " " & OBJ_MOTOR_WEB_BROWSER_10.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_10.Text = " " & OBJ_MOTOR_WEB_BROWSER_10.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_10.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_10.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(10) = OBJ_MOTOR_WEB_BROWSER_10.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_10.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_11(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 11

        tab11.Text = " " & OBJ_MOTOR_WEB_BROWSER_11.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_11.Text = " " & OBJ_MOTOR_WEB_BROWSER_11.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_11.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_11.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(11) = OBJ_MOTOR_WEB_BROWSER_11.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_11.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_12(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 12

        tab12.Text = " " & OBJ_MOTOR_WEB_BROWSER_12.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_12.Text = " " & OBJ_MOTOR_WEB_BROWSER_12.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_12.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_12.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(12) = OBJ_MOTOR_WEB_BROWSER_12.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_12.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_13(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 13

        tab13.Text = " " & OBJ_MOTOR_WEB_BROWSER_13.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_13.Text = " " & OBJ_MOTOR_WEB_BROWSER_13.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_13.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_13.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(13) = OBJ_MOTOR_WEB_BROWSER_13.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_13.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_14(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 14

        tab14.Text = " " & OBJ_MOTOR_WEB_BROWSER_14.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_14.Text = " " & OBJ_MOTOR_WEB_BROWSER_14.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_14.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_14.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(14) = OBJ_MOTOR_WEB_BROWSER_14.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_14.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_15(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 15

        tab15.Text = " " & OBJ_MOTOR_WEB_BROWSER_15.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_15.Text = " " & OBJ_MOTOR_WEB_BROWSER_15.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_15.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_15.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(15) = OBJ_MOTOR_WEB_BROWSER_15.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_15.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_16(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 16

        tab16.Text = " " & OBJ_MOTOR_WEB_BROWSER_16.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_16.Text = " " & OBJ_MOTOR_WEB_BROWSER_16.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_16.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_16.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(16) = OBJ_MOTOR_WEB_BROWSER_16.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_16.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_17(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 17

        tab17.Text = " " & OBJ_MOTOR_WEB_BROWSER_17.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_17.Text = " " & OBJ_MOTOR_WEB_BROWSER_17.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_17.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_17.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(17) = OBJ_MOTOR_WEB_BROWSER_17.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_17.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_18(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 18

        tab18.Text = " " & OBJ_MOTOR_WEB_BROWSER_18.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_18.Text = " " & OBJ_MOTOR_WEB_BROWSER_18.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_18.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_18.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(18) = OBJ_MOTOR_WEB_BROWSER_18.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_18.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_19(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 19

        tab19.Text = " " & OBJ_MOTOR_WEB_BROWSER_19.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_19.Text = " " & OBJ_MOTOR_WEB_BROWSER_19.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_19.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_19.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(19) = OBJ_MOTOR_WEB_BROWSER_19.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_19.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_20(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 20

        tab20.Text = " " & OBJ_MOTOR_WEB_BROWSER_20.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_20.Text = " " & OBJ_MOTOR_WEB_BROWSER_20.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_20.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_20.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(20) = OBJ_MOTOR_WEB_BROWSER_20.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_20.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_21(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 21

        tab21.Text = " " & OBJ_MOTOR_WEB_BROWSER_21.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_21.Text = " " & OBJ_MOTOR_WEB_BROWSER_21.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_21.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_21.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(21) = OBJ_MOTOR_WEB_BROWSER_21.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_21.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_22(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 22

        tab22.Text = " " & OBJ_MOTOR_WEB_BROWSER_22.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_22.Text = " " & OBJ_MOTOR_WEB_BROWSER_22.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_22.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_22.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(22) = OBJ_MOTOR_WEB_BROWSER_22.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_22.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_23(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 23

        tab23.Text = " " & OBJ_MOTOR_WEB_BROWSER_23.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_23.Text = " " & OBJ_MOTOR_WEB_BROWSER_23.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_23.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_23.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(23) = OBJ_MOTOR_WEB_BROWSER_23.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_23.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_24(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 24

        tab24.Text = " " & OBJ_MOTOR_WEB_BROWSER_24.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_24.Text = " " & OBJ_MOTOR_WEB_BROWSER_24.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_24.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_24.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(24) = OBJ_MOTOR_WEB_BROWSER_24.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_24.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_25(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 25

        tab25.Text = " " & OBJ_MOTOR_WEB_BROWSER_25.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_25.Text = " " & OBJ_MOTOR_WEB_BROWSER_25.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_25.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_25.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(25) = OBJ_MOTOR_WEB_BROWSER_25.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_25.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_26(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 26

        tab26.Text = " " & OBJ_MOTOR_WEB_BROWSER_26.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_26.Text = " " & OBJ_MOTOR_WEB_BROWSER_26.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_26.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_26.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(26) = OBJ_MOTOR_WEB_BROWSER_26.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_26.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_27(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 27

        tab27.Text = " " & OBJ_MOTOR_WEB_BROWSER_27.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_27.Text = " " & OBJ_MOTOR_WEB_BROWSER_27.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_27.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_27.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(27) = OBJ_MOTOR_WEB_BROWSER_27.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_27.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_28(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 28

        tab28.Text = " " & OBJ_MOTOR_WEB_BROWSER_28.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_28.Text = " " & OBJ_MOTOR_WEB_BROWSER_28.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_28.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_28.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(28) = OBJ_MOTOR_WEB_BROWSER_28.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_28.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_29(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 29

        tab29.Text = " " & OBJ_MOTOR_WEB_BROWSER_29.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_29.Text = " " & OBJ_MOTOR_WEB_BROWSER_29.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_29.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_29.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(29) = OBJ_MOTOR_WEB_BROWSER_29.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_29.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_30(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 30

        tab30.Text = " " & OBJ_MOTOR_WEB_BROWSER_30.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_30.Text = " " & OBJ_MOTOR_WEB_BROWSER_30.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_30.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_30.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(30) = OBJ_MOTOR_WEB_BROWSER_30.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_30.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_31(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 31

        tab31.Text = " " & OBJ_MOTOR_WEB_BROWSER_31.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_31.Text = " " & OBJ_MOTOR_WEB_BROWSER_31.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_31.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_31.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(31) = OBJ_MOTOR_WEB_BROWSER_31.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_31.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_32(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 32

        tab32.Text = " " & OBJ_MOTOR_WEB_BROWSER_32.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_32.Text = " " & OBJ_MOTOR_WEB_BROWSER_32.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_32.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_32.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(32) = OBJ_MOTOR_WEB_BROWSER_32.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_32.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_33(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 33

        tab33.Text = " " & OBJ_MOTOR_WEB_BROWSER_33.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_33.Text = " " & OBJ_MOTOR_WEB_BROWSER_33.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_33.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_33.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(33) = OBJ_MOTOR_WEB_BROWSER_33.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_33.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_34(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 34

        tab34.Text = " " & OBJ_MOTOR_WEB_BROWSER_34.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_34.Text = " " & OBJ_MOTOR_WEB_BROWSER_34.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_34.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_34.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(34) = OBJ_MOTOR_WEB_BROWSER_34.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_34.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_35(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 35

        tab35.Text = " " & OBJ_MOTOR_WEB_BROWSER_35.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_35.Text = " " & OBJ_MOTOR_WEB_BROWSER_35.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_35.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_35.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(35) = OBJ_MOTOR_WEB_BROWSER_35.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_35.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_36(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 36

        tab36.Text = " " & OBJ_MOTOR_WEB_BROWSER_36.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_36.Text = " " & OBJ_MOTOR_WEB_BROWSER_36.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_36.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_36.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(36) = OBJ_MOTOR_WEB_BROWSER_36.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_36.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_37(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 37

        tab37.Text = " " & OBJ_MOTOR_WEB_BROWSER_37.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_37.Text = " " & OBJ_MOTOR_WEB_BROWSER_37.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_37.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_37.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(37) = OBJ_MOTOR_WEB_BROWSER_37.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_37.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_38(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 38

        tab38.Text = " " & OBJ_MOTOR_WEB_BROWSER_38.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_38.Text = " " & OBJ_MOTOR_WEB_BROWSER_38.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_38.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_38.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(38) = OBJ_MOTOR_WEB_BROWSER_38.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_38.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_39(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 39

        tab39.Text = " " & OBJ_MOTOR_WEB_BROWSER_39.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_39.Text = " " & OBJ_MOTOR_WEB_BROWSER_39.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_39.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_39.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(39) = OBJ_MOTOR_WEB_BROWSER_39.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_39.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_40(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 40

        tab40.Text = " " & OBJ_MOTOR_WEB_BROWSER_40.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_40.Text = " " & OBJ_MOTOR_WEB_BROWSER_40.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_40.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_40.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(40) = OBJ_MOTOR_WEB_BROWSER_40.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_40.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_41(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 41

        tab41.Text = " " & OBJ_MOTOR_WEB_BROWSER_41.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_41.Text = " " & OBJ_MOTOR_WEB_BROWSER_41.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_41.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_41.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(41) = OBJ_MOTOR_WEB_BROWSER_41.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_41.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_42(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 42

        tab42.Text = " " & OBJ_MOTOR_WEB_BROWSER_42.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_42.Text = " " & OBJ_MOTOR_WEB_BROWSER_42.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_42.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_42.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(42) = OBJ_MOTOR_WEB_BROWSER_42.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_42.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_43(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 43

        tab43.Text = " " & OBJ_MOTOR_WEB_BROWSER_43.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_43.Text = " " & OBJ_MOTOR_WEB_BROWSER_43.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_43.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_43.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(43) = OBJ_MOTOR_WEB_BROWSER_43.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_43.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_44(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 44

        tab44.Text = " " & OBJ_MOTOR_WEB_BROWSER_44.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_44.Text = " " & OBJ_MOTOR_WEB_BROWSER_44.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_44.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_44.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(44) = OBJ_MOTOR_WEB_BROWSER_44.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_44.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_45(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 45

        tab45.Text = " " & OBJ_MOTOR_WEB_BROWSER_45.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_45.Text = " " & OBJ_MOTOR_WEB_BROWSER_45.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_45.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_45.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(45) = OBJ_MOTOR_WEB_BROWSER_45.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_45.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_46(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 46

        tab46.Text = " " & OBJ_MOTOR_WEB_BROWSER_46.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_46.Text = " " & OBJ_MOTOR_WEB_BROWSER_46.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_46.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_46.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(46) = OBJ_MOTOR_WEB_BROWSER_46.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_46.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_47(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 47

        tab47.Text = " " & OBJ_MOTOR_WEB_BROWSER_47.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_47.Text = " " & OBJ_MOTOR_WEB_BROWSER_47.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_47.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_47.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(47) = OBJ_MOTOR_WEB_BROWSER_47.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_47.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_48(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 48

        tab48.Text = " " & OBJ_MOTOR_WEB_BROWSER_48.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_48.Text = " " & OBJ_MOTOR_WEB_BROWSER_48.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_48.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_48.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(48) = OBJ_MOTOR_WEB_BROWSER_48.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_48.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_49(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 49

        tab49.Text = " " & OBJ_MOTOR_WEB_BROWSER_49.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_49.Text = " " & OBJ_MOTOR_WEB_BROWSER_49.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_49.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_49.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(49) = OBJ_MOTOR_WEB_BROWSER_49.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_49.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_50(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 50

        tab50.Text = " " & OBJ_MOTOR_WEB_BROWSER_50.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_50.Text = " " & OBJ_MOTOR_WEB_BROWSER_50.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_50.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_50.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(50) = OBJ_MOTOR_WEB_BROWSER_50.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_50.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_51(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 51

        tab51.Text = " " & OBJ_MOTOR_WEB_BROWSER_51.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_51.Text = " " & OBJ_MOTOR_WEB_BROWSER_51.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_51.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_51.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(51) = OBJ_MOTOR_WEB_BROWSER_51.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_51.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_52(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 52

        tab52.Text = " " & OBJ_MOTOR_WEB_BROWSER_52.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_52.Text = " " & OBJ_MOTOR_WEB_BROWSER_52.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_52.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_52.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(52) = OBJ_MOTOR_WEB_BROWSER_52.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_52.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_53(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 53

        tab53.Text = " " & OBJ_MOTOR_WEB_BROWSER_53.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_53.Text = " " & OBJ_MOTOR_WEB_BROWSER_53.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_53.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_53.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(53) = OBJ_MOTOR_WEB_BROWSER_53.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_53.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_54(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 54

        tab54.Text = " " & OBJ_MOTOR_WEB_BROWSER_54.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_54.Text = " " & OBJ_MOTOR_WEB_BROWSER_54.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_54.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_54.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(54) = OBJ_MOTOR_WEB_BROWSER_54.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_54.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_55(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 55

        tab55.Text = " " & OBJ_MOTOR_WEB_BROWSER_55.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_55.Text = " " & OBJ_MOTOR_WEB_BROWSER_55.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_55.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_55.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(55) = OBJ_MOTOR_WEB_BROWSER_55.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_55.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_56(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 56

        tab56.Text = " " & OBJ_MOTOR_WEB_BROWSER_56.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_56.Text = " " & OBJ_MOTOR_WEB_BROWSER_56.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_56.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_56.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(56) = OBJ_MOTOR_WEB_BROWSER_56.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_56.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_57(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 57

        tab57.Text = " " & OBJ_MOTOR_WEB_BROWSER_57.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_57.Text = " " & OBJ_MOTOR_WEB_BROWSER_57.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_57.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_57.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(57) = OBJ_MOTOR_WEB_BROWSER_57.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_57.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_58(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 58

        tab58.Text = " " & OBJ_MOTOR_WEB_BROWSER_58.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_58.Text = " " & OBJ_MOTOR_WEB_BROWSER_58.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_58.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_58.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(58) = OBJ_MOTOR_WEB_BROWSER_58.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_58.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_59(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 59

        tab59.Text = " " & OBJ_MOTOR_WEB_BROWSER_59.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_59.Text = " " & OBJ_MOTOR_WEB_BROWSER_59.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_59.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_59.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(59) = OBJ_MOTOR_WEB_BROWSER_59.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_59.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_60(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 60

        tab60.Text = " " & OBJ_MOTOR_WEB_BROWSER_60.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_60.Text = " " & OBJ_MOTOR_WEB_BROWSER_60.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_60.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_60.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(60) = OBJ_MOTOR_WEB_BROWSER_60.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_60.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_61(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 61

        tab61.Text = " " & OBJ_MOTOR_WEB_BROWSER_61.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_61.Text = " " & OBJ_MOTOR_WEB_BROWSER_61.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_61.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_61.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(61) = OBJ_MOTOR_WEB_BROWSER_61.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_61.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_62(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 62

        tab62.Text = " " & OBJ_MOTOR_WEB_BROWSER_62.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_62.Text = " " & OBJ_MOTOR_WEB_BROWSER_62.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_62.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_62.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(62) = OBJ_MOTOR_WEB_BROWSER_62.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_62.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_63(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 63

        tab63.Text = " " & OBJ_MOTOR_WEB_BROWSER_63.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_63.Text = " " & OBJ_MOTOR_WEB_BROWSER_63.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_63.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_63.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(63) = OBJ_MOTOR_WEB_BROWSER_63.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_63.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_64(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 64

        tab64.Text = " " & OBJ_MOTOR_WEB_BROWSER_64.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_64.Text = " " & OBJ_MOTOR_WEB_BROWSER_64.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_64.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_64.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(64) = OBJ_MOTOR_WEB_BROWSER_64.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_64.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_65(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 65

        tab65.Text = " " & OBJ_MOTOR_WEB_BROWSER_65.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_65.Text = " " & OBJ_MOTOR_WEB_BROWSER_65.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_65.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_65.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(65) = OBJ_MOTOR_WEB_BROWSER_65.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_65.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_66(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 66

        tab66.Text = " " & OBJ_MOTOR_WEB_BROWSER_66.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_66.Text = " " & OBJ_MOTOR_WEB_BROWSER_66.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_66.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_66.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(66) = OBJ_MOTOR_WEB_BROWSER_66.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_66.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_67(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 67

        tab67.Text = " " & OBJ_MOTOR_WEB_BROWSER_67.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_67.Text = " " & OBJ_MOTOR_WEB_BROWSER_67.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_67.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_67.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(67) = OBJ_MOTOR_WEB_BROWSER_67.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_67.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_68(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 68

        tab68.Text = " " & OBJ_MOTOR_WEB_BROWSER_68.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_68.Text = " " & OBJ_MOTOR_WEB_BROWSER_68.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_68.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_68.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(68) = OBJ_MOTOR_WEB_BROWSER_68.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_68.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_69(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 69

        tab69.Text = " " & OBJ_MOTOR_WEB_BROWSER_69.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_69.Text = " " & OBJ_MOTOR_WEB_BROWSER_69.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_69.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_69.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(69) = OBJ_MOTOR_WEB_BROWSER_69.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_69.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_70(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 70

        tab70.Text = " " & OBJ_MOTOR_WEB_BROWSER_70.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_70.Text = " " & OBJ_MOTOR_WEB_BROWSER_70.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_70.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_70.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(70) = OBJ_MOTOR_WEB_BROWSER_70.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_70.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_71(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 71

        tab71.Text = " " & OBJ_MOTOR_WEB_BROWSER_71.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_71.Text = " " & OBJ_MOTOR_WEB_BROWSER_71.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_71.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_71.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(71) = OBJ_MOTOR_WEB_BROWSER_71.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_71.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_72(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 72

        tab72.Text = " " & OBJ_MOTOR_WEB_BROWSER_72.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_72.Text = " " & OBJ_MOTOR_WEB_BROWSER_72.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_72.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_72.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(72) = OBJ_MOTOR_WEB_BROWSER_72.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_72.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_73(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 73

        tab73.Text = " " & OBJ_MOTOR_WEB_BROWSER_73.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_73.Text = " " & OBJ_MOTOR_WEB_BROWSER_73.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_73.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_73.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(73) = OBJ_MOTOR_WEB_BROWSER_73.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_73.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_74(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 74

        tab74.Text = " " & OBJ_MOTOR_WEB_BROWSER_74.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_74.Text = " " & OBJ_MOTOR_WEB_BROWSER_74.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_74.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_74.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(74) = OBJ_MOTOR_WEB_BROWSER_74.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_74.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_75(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 75

        tab75.Text = " " & OBJ_MOTOR_WEB_BROWSER_75.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_75.Text = " " & OBJ_MOTOR_WEB_BROWSER_75.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_75.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_75.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(75) = OBJ_MOTOR_WEB_BROWSER_75.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_75.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_76(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 76

        tab76.Text = " " & OBJ_MOTOR_WEB_BROWSER_76.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_76.Text = " " & OBJ_MOTOR_WEB_BROWSER_76.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_76.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_76.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(76) = OBJ_MOTOR_WEB_BROWSER_76.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_76.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_77(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 77

        tab77.Text = " " & OBJ_MOTOR_WEB_BROWSER_77.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_77.Text = " " & OBJ_MOTOR_WEB_BROWSER_77.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_77.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_77.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(77) = OBJ_MOTOR_WEB_BROWSER_77.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_77.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_78(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 78

        tab78.Text = " " & OBJ_MOTOR_WEB_BROWSER_78.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_78.Text = " " & OBJ_MOTOR_WEB_BROWSER_78.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_78.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_78.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(78) = OBJ_MOTOR_WEB_BROWSER_78.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_78.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_79(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 79

        tab79.Text = " " & OBJ_MOTOR_WEB_BROWSER_79.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_79.Text = " " & OBJ_MOTOR_WEB_BROWSER_79.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_79.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_79.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(79) = OBJ_MOTOR_WEB_BROWSER_79.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_79.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_80(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 80

        tab80.Text = " " & OBJ_MOTOR_WEB_BROWSER_80.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_80.Text = " " & OBJ_MOTOR_WEB_BROWSER_80.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_80.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_80.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(80) = OBJ_MOTOR_WEB_BROWSER_80.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_80.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_81(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 81

        tab81.Text = " " & OBJ_MOTOR_WEB_BROWSER_81.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_81.Text = " " & OBJ_MOTOR_WEB_BROWSER_81.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_81.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_81.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(81) = OBJ_MOTOR_WEB_BROWSER_81.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_81.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_82(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 82

        tab82.Text = " " & OBJ_MOTOR_WEB_BROWSER_82.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_82.Text = " " & OBJ_MOTOR_WEB_BROWSER_82.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_82.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_82.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(82) = OBJ_MOTOR_WEB_BROWSER_82.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_82.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_83(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 83

        tab83.Text = " " & OBJ_MOTOR_WEB_BROWSER_83.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_83.Text = " " & OBJ_MOTOR_WEB_BROWSER_83.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_83.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_83.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(83) = OBJ_MOTOR_WEB_BROWSER_83.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_83.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_84(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 84

        tab84.Text = " " & OBJ_MOTOR_WEB_BROWSER_84.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_84.Text = " " & OBJ_MOTOR_WEB_BROWSER_84.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_84.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_84.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(84) = OBJ_MOTOR_WEB_BROWSER_84.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_84.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_85(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 85

        tab85.Text = " " & OBJ_MOTOR_WEB_BROWSER_85.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_85.Text = " " & OBJ_MOTOR_WEB_BROWSER_85.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_85.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_85.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(85) = OBJ_MOTOR_WEB_BROWSER_85.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_85.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_86(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 86

        tab86.Text = " " & OBJ_MOTOR_WEB_BROWSER_86.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_86.Text = " " & OBJ_MOTOR_WEB_BROWSER_86.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_86.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_86.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(86) = OBJ_MOTOR_WEB_BROWSER_86.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_86.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_87(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 87

        tab87.Text = " " & OBJ_MOTOR_WEB_BROWSER_87.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_87.Text = " " & OBJ_MOTOR_WEB_BROWSER_87.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_87.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_87.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(87) = OBJ_MOTOR_WEB_BROWSER_87.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_87.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_88(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 88

        tab88.Text = " " & OBJ_MOTOR_WEB_BROWSER_88.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_88.Text = " " & OBJ_MOTOR_WEB_BROWSER_88.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_88.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_88.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(88) = OBJ_MOTOR_WEB_BROWSER_88.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_88.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_89(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 89

        tab89.Text = " " & OBJ_MOTOR_WEB_BROWSER_89.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_89.Text = " " & OBJ_MOTOR_WEB_BROWSER_89.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_89.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_89.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(89) = OBJ_MOTOR_WEB_BROWSER_89.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_89.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_90(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 90

        tab90.Text = " " & OBJ_MOTOR_WEB_BROWSER_90.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_90.Text = " " & OBJ_MOTOR_WEB_BROWSER_90.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_90.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_90.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(90) = OBJ_MOTOR_WEB_BROWSER_90.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_90.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_91(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 91

        tab91.Text = " " & OBJ_MOTOR_WEB_BROWSER_91.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_91.Text = " " & OBJ_MOTOR_WEB_BROWSER_91.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_91.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_91.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(91) = OBJ_MOTOR_WEB_BROWSER_91.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_91.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_92(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 92

        tab92.Text = " " & OBJ_MOTOR_WEB_BROWSER_92.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_92.Text = " " & OBJ_MOTOR_WEB_BROWSER_92.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_92.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_92.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(92) = OBJ_MOTOR_WEB_BROWSER_92.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_92.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_93(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 93

        tab93.Text = " " & OBJ_MOTOR_WEB_BROWSER_93.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_93.Text = " " & OBJ_MOTOR_WEB_BROWSER_93.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_93.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_93.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(93) = OBJ_MOTOR_WEB_BROWSER_93.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_93.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_94(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 94

        tab94.Text = " " & OBJ_MOTOR_WEB_BROWSER_94.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_94.Text = " " & OBJ_MOTOR_WEB_BROWSER_94.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_94.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_94.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(94) = OBJ_MOTOR_WEB_BROWSER_94.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_94.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_95(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 95

        tab95.Text = " " & OBJ_MOTOR_WEB_BROWSER_95.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_95.Text = " " & OBJ_MOTOR_WEB_BROWSER_95.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_95.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_95.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(95) = OBJ_MOTOR_WEB_BROWSER_95.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_95.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_96(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 96

        tab96.Text = " " & OBJ_MOTOR_WEB_BROWSER_96.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_96.Text = " " & OBJ_MOTOR_WEB_BROWSER_96.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_96.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_96.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(96) = OBJ_MOTOR_WEB_BROWSER_96.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_96.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_97(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 97

        tab97.Text = " " & OBJ_MOTOR_WEB_BROWSER_97.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_97.Text = " " & OBJ_MOTOR_WEB_BROWSER_97.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_97.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_97.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(97) = OBJ_MOTOR_WEB_BROWSER_97.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_97.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_98(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 98

        tab98.Text = " " & OBJ_MOTOR_WEB_BROWSER_98.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_98.Text = " " & OBJ_MOTOR_WEB_BROWSER_98.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_98.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_98.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(98) = OBJ_MOTOR_WEB_BROWSER_98.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_98.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_99(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 99

        tab99.Text = " " & OBJ_MOTOR_WEB_BROWSER_99.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_99.Text = " " & OBJ_MOTOR_WEB_BROWSER_99.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_99.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_99.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(99) = OBJ_MOTOR_WEB_BROWSER_99.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_99.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_100(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 100

        tab100.Text = " " & OBJ_MOTOR_WEB_BROWSER_100.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_100.Text = " " & OBJ_MOTOR_WEB_BROWSER_100.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_100.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_100.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(100) = OBJ_MOTOR_WEB_BROWSER_100.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_100.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_101(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 101

        tab101.Text = " " & OBJ_MOTOR_WEB_BROWSER_101.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_101.Text = " " & OBJ_MOTOR_WEB_BROWSER_101.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_101.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_101.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(101) = OBJ_MOTOR_WEB_BROWSER_101.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_101.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_102(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 102

        tab102.Text = " " & OBJ_MOTOR_WEB_BROWSER_102.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_102.Text = " " & OBJ_MOTOR_WEB_BROWSER_102.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_102.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_102.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(102) = OBJ_MOTOR_WEB_BROWSER_102.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_102.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_103(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 103

        tab103.Text = " " & OBJ_MOTOR_WEB_BROWSER_103.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_103.Text = " " & OBJ_MOTOR_WEB_BROWSER_103.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_103.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_103.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(103) = OBJ_MOTOR_WEB_BROWSER_103.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_103.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_104(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 104

        tab104.Text = " " & OBJ_MOTOR_WEB_BROWSER_104.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_104.Text = " " & OBJ_MOTOR_WEB_BROWSER_104.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_104.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_104.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(104) = OBJ_MOTOR_WEB_BROWSER_104.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_104.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_105(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 105

        tab105.Text = " " & OBJ_MOTOR_WEB_BROWSER_105.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_105.Text = " " & OBJ_MOTOR_WEB_BROWSER_105.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_105.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_105.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(105) = OBJ_MOTOR_WEB_BROWSER_105.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_105.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_106(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 106

        tab106.Text = " " & OBJ_MOTOR_WEB_BROWSER_106.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_106.Text = " " & OBJ_MOTOR_WEB_BROWSER_106.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_106.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_106.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(106) = OBJ_MOTOR_WEB_BROWSER_106.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_106.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_107(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 107

        tab107.Text = " " & OBJ_MOTOR_WEB_BROWSER_107.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_107.Text = " " & OBJ_MOTOR_WEB_BROWSER_107.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_107.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_107.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(107) = OBJ_MOTOR_WEB_BROWSER_107.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_107.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_108(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 108

        tab108.Text = " " & OBJ_MOTOR_WEB_BROWSER_108.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_108.Text = " " & OBJ_MOTOR_WEB_BROWSER_108.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_108.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_108.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(108) = OBJ_MOTOR_WEB_BROWSER_108.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_108.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_109(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 109

        tab109.Text = " " & OBJ_MOTOR_WEB_BROWSER_109.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_109.Text = " " & OBJ_MOTOR_WEB_BROWSER_109.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_109.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_109.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(109) = OBJ_MOTOR_WEB_BROWSER_109.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_109.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_110(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 110

        tab110.Text = " " & OBJ_MOTOR_WEB_BROWSER_110.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_110.Text = " " & OBJ_MOTOR_WEB_BROWSER_110.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_110.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_110.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(110) = OBJ_MOTOR_WEB_BROWSER_110.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_110.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_111(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 111

        tab111.Text = " " & OBJ_MOTOR_WEB_BROWSER_111.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_111.Text = " " & OBJ_MOTOR_WEB_BROWSER_111.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_111.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_111.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(111) = OBJ_MOTOR_WEB_BROWSER_111.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_111.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_112(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 112

        tab112.Text = " " & OBJ_MOTOR_WEB_BROWSER_112.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_112.Text = " " & OBJ_MOTOR_WEB_BROWSER_112.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_112.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_112.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(112) = OBJ_MOTOR_WEB_BROWSER_112.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_112.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_113(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 113

        tab113.Text = " " & OBJ_MOTOR_WEB_BROWSER_113.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_113.Text = " " & OBJ_MOTOR_WEB_BROWSER_113.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_113.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_113.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(113) = OBJ_MOTOR_WEB_BROWSER_113.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_113.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_114(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 114

        tab114.Text = " " & OBJ_MOTOR_WEB_BROWSER_114.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_114.Text = " " & OBJ_MOTOR_WEB_BROWSER_114.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_114.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_114.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(114) = OBJ_MOTOR_WEB_BROWSER_114.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_114.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_115(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 115

        tab115.Text = " " & OBJ_MOTOR_WEB_BROWSER_115.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_115.Text = " " & OBJ_MOTOR_WEB_BROWSER_115.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_115.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_115.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(115) = OBJ_MOTOR_WEB_BROWSER_115.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_115.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_116(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 116

        tab116.Text = " " & OBJ_MOTOR_WEB_BROWSER_116.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_116.Text = " " & OBJ_MOTOR_WEB_BROWSER_116.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_116.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_116.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(116) = OBJ_MOTOR_WEB_BROWSER_116.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_116.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_117(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 117

        tab117.Text = " " & OBJ_MOTOR_WEB_BROWSER_117.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_117.Text = " " & OBJ_MOTOR_WEB_BROWSER_117.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_117.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_117.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(117) = OBJ_MOTOR_WEB_BROWSER_117.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_117.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_118(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 118

        tab118.Text = " " & OBJ_MOTOR_WEB_BROWSER_118.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_118.Text = " " & OBJ_MOTOR_WEB_BROWSER_118.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_118.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_118.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(118) = OBJ_MOTOR_WEB_BROWSER_118.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_118.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_119(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 119

        tab119.Text = " " & OBJ_MOTOR_WEB_BROWSER_119.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_119.Text = " " & OBJ_MOTOR_WEB_BROWSER_119.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_119.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_119.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(119) = OBJ_MOTOR_WEB_BROWSER_119.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_119.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_120(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 120

        tab120.Text = " " & OBJ_MOTOR_WEB_BROWSER_120.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_120.Text = " " & OBJ_MOTOR_WEB_BROWSER_120.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_120.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_120.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(120) = OBJ_MOTOR_WEB_BROWSER_120.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_120.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_121(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 121

        tab121.Text = " " & OBJ_MOTOR_WEB_BROWSER_121.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_121.Text = " " & OBJ_MOTOR_WEB_BROWSER_121.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_121.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_121.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(121) = OBJ_MOTOR_WEB_BROWSER_121.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_121.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_122(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 122

        tab122.Text = " " & OBJ_MOTOR_WEB_BROWSER_122.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_122.Text = " " & OBJ_MOTOR_WEB_BROWSER_122.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_122.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_122.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(122) = OBJ_MOTOR_WEB_BROWSER_122.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_122.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_123(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 123

        tab123.Text = " " & OBJ_MOTOR_WEB_BROWSER_123.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_123.Text = " " & OBJ_MOTOR_WEB_BROWSER_123.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_123.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_123.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(123) = OBJ_MOTOR_WEB_BROWSER_123.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_123.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_124(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 124

        tab124.Text = " " & OBJ_MOTOR_WEB_BROWSER_124.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_124.Text = " " & OBJ_MOTOR_WEB_BROWSER_124.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_124.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_124.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(124) = OBJ_MOTOR_WEB_BROWSER_124.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_124.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_125(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 125

        tab125.Text = " " & OBJ_MOTOR_WEB_BROWSER_125.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_125.Text = " " & OBJ_MOTOR_WEB_BROWSER_125.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_125.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_125.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(125) = OBJ_MOTOR_WEB_BROWSER_125.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_125.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_126(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 126

        tab126.Text = " " & OBJ_MOTOR_WEB_BROWSER_126.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_126.Text = " " & OBJ_MOTOR_WEB_BROWSER_126.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_126.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_126.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(126) = OBJ_MOTOR_WEB_BROWSER_126.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_126.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_127(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 127

        tab127.Text = " " & OBJ_MOTOR_WEB_BROWSER_127.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_127.Text = " " & OBJ_MOTOR_WEB_BROWSER_127.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_127.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_127.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(127) = OBJ_MOTOR_WEB_BROWSER_127.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_127.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub

    Public Sub proc_carregamento_completado_motor_trident_128(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Evento de carregamento completado geckofx
        On Error Resume Next
        Dim v_token As Integer = 128

        tab128.Text = " " & OBJ_MOTOR_WEB_BROWSER_128.DocumentTitle 'Titulo da pagina
        Tool_aba_referencia_128.Text = " " & OBJ_MOTOR_WEB_BROWSER_128.DocumentTitle 'Titulo da pagina
        proc_gerar_imagem_historico_e_atualizar_algumas_propriedades_por_aba_trident(OBJ_MOTOR_WEB_BROWSER_128.DocumentTitle, OBJ_MOTOR_WEB_BROWSER_128.Url.AbsoluteUri, Date.Today, v_token) 'Gera a imagem do historico que sera usada no recurso de autocompletar
        V_VALOR_URL_TEMPORARIO_Modulo_backgroundworker_trabalhar(128) = OBJ_MOTOR_WEB_BROWSER_128.Url.AbsoluteUri 'Url da pagina do favicon
        OBJ_BACKGROUNDWORKER_128.RunWorkerAsync() 'Rodando o processo

        If (v_token = v_qual_motor_esta_em_uso) Then

            proc_atualizar_propriedades_carregamento_completo_trident_Modulo_propriedades_tempo_de_execucao(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        End If

    End Sub


    '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------





End Module
