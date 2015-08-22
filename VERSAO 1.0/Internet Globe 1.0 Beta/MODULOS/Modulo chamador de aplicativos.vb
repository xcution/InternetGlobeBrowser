Imports System.IO




Module Modulo_chamador_de_aplicativos



    'Chamador de aplicativos

    Public Function func_retorne_aplicativo_existir(ByVal v_end_aplicativo As String) 'Retorna se o aplicativo existe ou não
        On Error Resume Next

        Dim v_arq_existe As Boolean 'Variável de existencia






        'Verifica se o arquivo existe e dá o retorno da funçao ---------------------------------------------------------

        v_arq_existe = My.Computer.FileSystem.FileExists(v_end_aplicativo) 'Verificando se o arquivo existe

        Return v_arq_existe 'Retorno

        '---------------------------------------------------------------------------------------------------------------


    End Function

    Public Sub proc_chamar_aplicativo_ocultar_ip() 'Chamar o aplicativo ocultar IP
        On Error Resume Next

        Dim v_aplicativo As String = V_PASTA_DA_INSTALACAO_DO_PROGRAMA & "\app\ocultarip\Microsete SLM Ocultar IP 1.0.exe" 'Endereço do aplicativo

        Dim v_app_existe As Boolean = func_retorne_aplicativo_existir(v_aplicativo) 'Retorna se o aplicativo existe ou não






        'Verifica se o aplicativo existe e executa o mesmo -------------------------------------------------------------

        If (v_app_existe = True) Then


            Process.Start(v_aplicativo, V_PASTA_DA_INSTALACAO_DO_PROGRAMA & "\app\ocultarip") 'Rodando o aplicativo


        Else


            proc_chamar_mensagem_ao_usuario(V_MS_23, v_tipo_ms_3) 'Chama a janela de mensagem ao usuario


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_chamar_aplicativo_m7task() 'Chamar o aplicativo m7task
        On Error Resume Next

        Dim v_aplicativo As String = V_PASTA_DA_INSTALACAO_DO_PROGRAMA & "\app\m7task\m7task.exe" 'Endereço do aplicativo

        Dim v_app_existe As Boolean = func_retorne_aplicativo_existir(v_aplicativo) 'Retorna se o aplicativo existe ou não






        'Verifica se o aplicativo existe e executa o mesmo -------------------------------------------------------------

        If (v_app_existe = True) Then


            Process.Start(v_aplicativo, V_PASTA_DA_INSTALACAO_DO_PROGRAMA & "\app\m7task") 'Rodando o aplicativo


        Else


            proc_chamar_mensagem_ao_usuario(V_MS_23, v_tipo_ms_3) 'Chama a janela de mensagem ao usuario


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_chamar_aplicativo_photo_sete(ByVal V_USAR_PARAMETRO As Boolean, ByVal V_END_IMAGEM As String) 'Chamar o aplicativo photo sete
        On Error Resume Next

        Dim v_aplicativo As String = V_PASTA_DA_INSTALACAO_DO_PROGRAMA & "\app\ps\M7 Photo Sete.exe" 'Endereço do aplicativo

        Dim v_app_existe As Boolean = func_retorne_aplicativo_existir(v_aplicativo) 'Retorna se o aplicativo existe ou não






        'Verifica se o aplicativo existe e executa o mesmo -------------------------------------------------------------

        If (v_app_existe = True) Then




            'Verifica se passa ou nao parametros para a imagem ---------------------------------------------------------

            If (V_USAR_PARAMETRO <> True) Then


                Process.Start(v_aplicativo, V_PASTA_DA_INSTALACAO_DO_PROGRAMA & "\app\ps") 'Rodando o aplicativo


            Else




                'Fechar e abrir ----------------------------------------------------------------------------------------

                For Each proc As Process In Process.GetProcessesByName("M7 Photo Sete")

                    proc.CloseMainWindow() 'Fechando...

                Next

                Process.Start(v_aplicativo, V_END_IMAGEM) 'Abrindo com parametro

                '-------------------------------------------------------------------------------------------------------




            End If

            '-----------------------------------------------------------------------------------------------------------




        Else




            'Informação ao usuário -----------------------------------------------------------------------

            proc_chamar_mensagem_ao_usuario(V_MS_23, v_tipo_ms_3) 'Chama a janela de mensagem ao usuario

            '---------------------------------------------------------------------------------------------




        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_chamar_aplicativo_baixabit() 'Chamar o aplicativo baixabit
        On Error Resume Next

        Dim v_aplicativo As String = V_PASTA_DA_INSTALACAO_DO_PROGRAMA & "\app\bbit\M7SLMBAIXABIT.exe" 'Endereço do aplicativo

        Dim v_app_existe As Boolean = func_retorne_aplicativo_existir(v_aplicativo) 'Retorna se o aplicativo existe ou não






        'Verifica se o aplicativo existe e executa o mesmo -------------------------------------------------------------

        If (v_app_existe = True) Then


            Process.Start(v_aplicativo, V_PASTA_DA_INSTALACAO_DO_PROGRAMA & "\app\bbit") 'Rodando o aplicativo


        Else


            proc_chamar_mensagem_ao_usuario(V_MS_23, v_tipo_ms_3) 'Chama a janela de mensagem ao usuario


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_chamar_aplicativo_pinger() 'Chamar o aplicativo pinger
        On Error Resume Next

        Dim v_aplicativo As String = V_PASTA_DA_INSTALACAO_DO_PROGRAMA & "\app\pinger\M7PINGER.exe" 'Endereço do aplicativo

        Dim v_app_existe As Boolean = func_retorne_aplicativo_existir(v_aplicativo) 'Retorna se o aplicativo existe ou não






        'Verifica se o aplicativo existe e executa o mesmo -------------------------------------------------------------

        If (v_app_existe = True) Then


            Process.Start(v_aplicativo, V_PASTA_DA_INSTALACAO_DO_PROGRAMA & "\app\pinger") 'Rodando o aplicativo


        Else


            proc_chamar_mensagem_ao_usuario(V_MS_23, v_tipo_ms_3) 'Chama a janela de mensagem ao usuario


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_chamar_aplicativo_robit() 'Chamar o aplicativo robit
        On Error Resume Next

        Dim v_aplicativo As String = V_PASTA_DA_INSTALACAO_DO_PROGRAMA & "\app\robit\M7ROBIT.exe" 'Endereço do aplicativo

        Dim v_app_existe As Boolean = func_retorne_aplicativo_existir(v_aplicativo) 'Retorna se o aplicativo existe ou não






        'Verifica se o aplicativo existe e executa o mesmo -------------------------------------------------------------

        If (v_app_existe = True) Then


            Process.Start(v_aplicativo, V_PASTA_DA_INSTALACAO_DO_PROGRAMA & "\app\robit") 'Rodando o aplicativo


        Else


            proc_chamar_mensagem_ao_usuario(V_MS_23, v_tipo_ms_3) 'Chama a janela de mensagem ao usuario


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_chamar_aplicativo_exibidor_de_versao() 'Chamar o aplicativo exibidor de versao
        On Error Resume Next

        Dim v_aplicativo As String = V_PASTA_DA_INSTALACAO_DO_PROGRAMA & "\M7INFOVERSAO.exe" 'Endereço do aplicativo

        Dim v_app_existe As Boolean = func_retorne_aplicativo_existir(v_aplicativo) 'Retorna se o aplicativo existe ou não






        'Verifica se o aplicativo existe e executa o mesmo -------------------------------------------------------------

        If (v_app_existe = True) Then


            Process.Start(v_aplicativo, "Internet Globe 1.0 Beta.exe") 'Chamando o aplicativo versão de software


        Else


            proc_chamar_mensagem_ao_usuario(V_MS_23, v_tipo_ms_3) 'Chama a janela de mensagem ao usuario


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_chamar_aplicativo_associador_de_extencao() 'Associador de extenção
        On Error Resume Next

        Dim v_aplicativo As String = V_PASTA_DA_INSTALACAO_DO_PROGRAMA & "\M7SLMAEXT.exe" 'Endereço do aplicativo

        Dim v_app_existe As Boolean = func_retorne_aplicativo_existir(v_aplicativo) 'Retorna se o aplicativo existe ou não

        Dim v_comando As String = Application.ExecutablePath & vbCrLf & Application.ExecutablePath.Replace(Path.GetExtension(Application.ExecutablePath), Nothing) & ".ico" 'Comando






        'Verifica se o aplicativo existe e executa o mesmo -------------------------------------------------------------

        If (v_app_existe = True) Then


            Process.Start(v_aplicativo, v_comando) 'Rodando o aplicativo


        Else


            proc_chamar_mensagem_ao_usuario(V_MS_23, v_tipo_ms_3) 'Chama a janela de mensagem ao usuario


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_chamar_aplicativo_instalador_do_recurso_de_leitura_de_voz_tts_speech() 'Chama o instalador do aplicativo que instala o recurso de voz TTS SPEECH
        On Error Resume Next

        Dim v_aplicativo As String = V_PASTA_DA_INSTALACAO_DO_PROGRAMA & "\ttsspechraquel.exe" 'Endereço do aplicativo

        Dim v_app_existe As Boolean = func_retorne_aplicativo_existir(v_aplicativo) 'Retorna se o aplicativo existe ou não







        'Verifica se o aplicativo existe e executa o mesmo -------------------------------------------------------------

        If (v_app_existe = True) Then


            Process.Start(v_aplicativo) 'Rodando o aplicativo


        Else


            proc_chamar_mensagem_ao_usuario(V_MS_42, v_tipo_ms_3) 'Chama a janela de mensagem ao usuario


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub


















End Module
