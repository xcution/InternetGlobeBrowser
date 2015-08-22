Public Class FRM_FORMULARIO_GERADOR_DE_IMAGENS_DE_ABAS


    'VARIÁVEIS LOCAIS

    Dim V_ARQUIVO_HTML_DE_INDICE_GERADO As String = V_PASTA_DE_IMAGENS_DE_ABAS_ABERTAS_ATUALMENTE & "\indice.html" 'ARQUIVO DE INDICE HTML




















    'PROCEDIMENTOS

    Private Sub PROC_ADICIONAR_TODAS_AS_IMAGENS_DE_TODAS_AS_ABAS_ABERTAS() 'ADICIONA AS IMAGENS DE TODAS AS ABAS ABERTAS
        On Error Resume Next

        Dim V_QUANTIDADE_DE_ABAS As Integer = My.Application.OpenForms.Count 'QUANTIDADE DE ABAS ABERTAS

        Dim V_CONTADOR As Integer = 0 'CONTADOR INICIAL

        Dim V_CODIGO_HTML_DE_INICIO As String = "<HTML><HEAD><TITLE>Histórico</TITLE></HEAD><style type='text/css'>body{background-color: #404040;color: #000000;}</style><style type='text/css'>a{color: #C0C0C0;text-decoration: none;}a:visited{color: #C0C0C0;}a:active{color: #C0C0C0;}a:hover{color: #C0C0C0;text-decoration: none;}</style><BODY><CENTER><BR></BR><span style='color:#F0F0F0;font-family:Arial;font-size:32px;'>Sites que estão abertos</span></div><BR></BR><TABLE BORDER='0' CELLPADDING=35>" 'CODIGO DE INICIO DE HTML

        Dim V_CODIGO_HTML_DE_MEIO As String = "" 'CODIGO HTML DE MEIO CORPO

        Dim V_CODIGO_HTML_DE_FIM As String = "</TABLE></CENTER></BODY></HTML>" 'CODIGO HTML DE FIM

        Dim V_CONTADOR_DE_TABELA As Integer 'CONTADOR DE TABELA






        'VARRENDO E ATUALIZANDO IMAGENS ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        For V_CONTADOR = V_CONTADOR To V_QUANTIDADE_DE_ABAS


            Dim OBJ_MOTOR As New Gecko.GeckoWebBrowser 'MOTOR WEB

            Dim OBJ_IMAGEM As Image 'IMAGEM DE MOTOR DE ABAS ABERTAS

            Dim V_NOME_DO_MOTOR As String 'INFORMA O NOME DO MOTOR






            'SETA O MOTOR, OBTÉM IMAGEM E ADICIONA A IMAGEM -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            OBJ_MOTOR = DirectCast(My.Application.OpenForms.Item(V_CONTADOR).Controls.Item(0), Gecko.GeckoWebBrowser) 'OBTENDO DADOS DO MOTOR

            V_NOME_DO_MOTOR = OBJ_MOTOR.Name 'OBTÉM O NOME DO MOTOR

            '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'VERIFICA SE O NOME DO MOTOR É NÚMERICO ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            If (IsNumeric(V_NOME_DO_MOTOR) = True) And (V_NOME_DO_MOTOR.Length > 0) Then




                OBJ_IMAGEM = FUNC_RETORNE_IMAGEM_DE_MOTOR_GECKOFX_APENAS_VISUALIZACAO(OBJ_MOTOR) 'RETORNA SOMENTE A PARTE EM VISUALIZAÇÃO DO MOTOR

                OBJ_IMAGEM = OBJ_IMAGEM.GetThumbnailImage(V_TAMANHO_DE_IMAGEM_DE_ABA_DE_ABAS_EM_ABERTO, V_TAMANHO_DE_IMAGEM_DE_ABA_DE_ABAS_EM_ABERTO, Nothing, Nothing) 'REDIMENCIONA IMAGEM

                PROC_REMOVER_ARQUIVO_UNICO_SEM_PERGUNTAS(V_PASTA_DE_IMAGENS_DE_ABAS_ABERTAS_ATUALMENTE & "\" & V_NOME_DO_MOTOR & V_EXTENCAO_DE_ARQUIVO_3)

                OBJ_IMAGEM.Save(V_PASTA_DE_IMAGENS_DE_ABAS_ABERTAS_ATUALMENTE & "\" & V_NOME_DO_MOTOR & V_EXTENCAO_DE_ARQUIVO_3, System.Drawing.Imaging.ImageFormat.Jpeg) 'SALVANDO IMAGEM AGORA

                V_CONTADOR_DE_TABELA = V_CONTADOR_DE_TABELA + 1 'ATUALIZANDO O CONTADOR






                'GERANDO CODIGO DE TABELA -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                Select Case V_CONTADOR_DE_TABELA


                    Case 1
                        V_CODIGO_HTML_DE_MEIO = V_CODIGO_HTML_DE_MEIO & "<TR><TD>" & "<A HREF='" & V_NOME_DO_MOTOR & "'>" & "<IMG SRC='" & V_NOME_DO_MOTOR & V_EXTENCAO_DE_ARQUIVO_3 & "' WIDTH='" & V_TAMANHO_DE_IMAGENS_DE_HISTORICO & "' HEIGHT='" & V_TAMANHO_DE_IMAGENS_DE_HISTORICO & "' ALIGN='BOTTOM' BORDER='0' TITLE='" & OBJ_MOTOR.DocumentTitle & "'> <BR CLEAR='ALL'>" & OBJ_MOTOR.DocumentTitle & " <BR></A>" & "</TD>" 'CODIGO


                    Case 2
                        V_CODIGO_HTML_DE_MEIO = V_CODIGO_HTML_DE_MEIO & "<TD>" & "<A HREF='" & V_NOME_DO_MOTOR & "'>" & "<IMG SRC='" & V_NOME_DO_MOTOR & V_EXTENCAO_DE_ARQUIVO_3 & "' WIDTH='" & V_TAMANHO_DE_IMAGENS_DE_HISTORICO & "' HEIGHT='" & V_TAMANHO_DE_IMAGENS_DE_HISTORICO & "' ALIGN='BOTTOM' BORDER='0' TITLE='" & OBJ_MOTOR.DocumentTitle & "'> <BR CLEAR='ALL'>" & OBJ_MOTOR.DocumentTitle & " <BR> </A>" & "</TD>" 'CODIGO


                    Case 3
                        V_CODIGO_HTML_DE_MEIO = V_CODIGO_HTML_DE_MEIO & "<TD>" & "<A HREF='" & V_NOME_DO_MOTOR & "'>" & "<IMG SRC='" & V_NOME_DO_MOTOR & V_EXTENCAO_DE_ARQUIVO_3 & "' WIDTH='" & V_TAMANHO_DE_IMAGENS_DE_HISTORICO & "' HEIGHT='" & V_TAMANHO_DE_IMAGENS_DE_HISTORICO & "' ALIGN='BOTTOM' BORDER='0' TITLE='" & OBJ_MOTOR.DocumentTitle & "'> <BR CLEAR='ALL'>" & OBJ_MOTOR.DocumentTitle & " <BR> </A>" & "</TD></TR>" 'CODIGO
                        V_CONTADOR_DE_TABELA = 0 'RESETANDO VALOR


                End Select

                '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            End If

            '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        Next


        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'SALVANDO CODIGO HTML -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(V_CODIGO_HTML_DE_INICIO & V_CODIGO_HTML_DE_MEIO & V_CODIGO_HTML_DE_FIM, V_ARQUIVO_HTML_DE_INDICE_GERADO) 'SALVANDO O CODIGO HTML

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

       

        'ABRINDO PÁGINA SALVA -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        MOTOR_GECKOFX.Navigate(V_ARQUIVO_HTML_DE_INDICE_GERADO) 'ABRINDO PÁGINA

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub














    'PROCEDIMENTOS DE INICIALIZAÇÃO

    Private Sub PROC_ATIVAR_TIMER() 'ATIVA O TIMER
        On Error Resume Next


        'ATIVA O TIMER -------------------------------------------------------------------------------------------------

        TMR_ATUALIZADOR.Enabled = True 'HABILITA O TIMER

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_DESATIVAR_TIMER() 'DESATIVAR O TIMER
        On Error Resume Next


        'DESATIVA O TIMER ----------------------------------------------------------------------------------------------

        TMR_ATUALIZADOR.Enabled = False 'DESATIVA O TIMER

        '---------------------------------------------------------------------------------------------------------------


    End Sub










    'PROCEDIMENTOS AO SAIR

    Private Sub PROC_SAIR_LIMPAR_DADOS_GERADOR_DE_IMAGENS() 'AO SAIR LIMPAR OS DADOS DO GERADOR DE IMAGENS
        On Error Resume Next


        'REMOVE TODOS OS ARQUIVOS DE IMAGENS GERADOS -----------------------------------------------------------------------------------------------------------------

        PROC_REMOVER_TODOS_OS_ARQUIVOS(V_PASTA_DE_IMAGENS_DE_ABAS_ABERTAS_ATUALMENTE) 'REMOVE TODOS OS ARQUIVOS DA PASTA INFORMADA

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub




















    Private Sub FRM_FORMULARIO_GERADOR_DE_IMAGENS_DE_ABAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next


        'ADICIONA IMAGENS DE TODAS AS ABAS ABERTAS ---------------------------------------------------------------------

        PROC_ADICIONAR_TODAS_AS_IMAGENS_DE_TODAS_AS_ABAS_ABERTAS() 'ADICIONA AS IMAGENS DE TODAS AS ABAS ABERTAS

        '---------------------------------------------------------------------------------------------------------------




        'SOM DE SISTEMA ------------------------------------------------------------------------------------------------

        PROC_EXIBIR_SOM_DE_SISTEMA(3) 'EXIBE OS SONS INSTALADOS NO SISTEMA

        '---------------------------------------------------------------------------------------------------------------




        'ATIVA O TIMER -------------------------------------------------------------------------------------------------

        PROC_ATIVAR_TIMER() 'ATIVA O TIMER

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub TMR_ATUALIZADOR_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMR_ATUALIZADOR.Tick
        On Error Resume Next

        PROC_ADICIONAR_TODAS_AS_IMAGENS_DE_TODAS_AS_ABAS_ABERTAS() 'ADICIONA AS IMAGENS DE TODAS AS ABAS ABERTAS

    End Sub

    Private Sub FRM_FORMULARIO_GERADOR_DE_IMAGENS_DE_ABAS_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next


        'DESATIVA O TIMER E LIMPA VALORES ------------------------------------------------------------------------------

        PROC_DESATIVAR_TIMER() 'DESATIVAR O TIMER

        PROC_SAIR_LIMPAR_DADOS_GERADOR_DE_IMAGENS() 'AO SAIR LIMPAR OS DADOS DO GERADOR DE IMAGENS

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub OBJ_MOTOR_LOCAL_DomMouseDown(ByVal sender As System.Object, ByVal e As Gecko.GeckoDomMouseEventArgs) Handles MOTOR_GECKOFX.DomMouseDown
        On Error Resume Next


        'PERMITE AUTO-CLOSE ------------------------------------------------------------------------------------------------------------------------------------

        OBJ_MENU_DE_CONTEXTO.AutoClose = True 'AUTO-CLOSE

        OBJ_MENU_DE_CONTEXTO.Close() 'FECHANDO MENU

        '-------------------------------------------------------------------------------------------------------------------------------------------------------




        'DESATIVA O TIMER TEMPORARIAMENTE ----------------------------------------------------------------------------------------------------------------------

        PROC_DESATIVAR_TIMER() 'DESATIVAR O TIMER

        '-------------------------------------------------------------------------------------------------------------------------------------------------------




        'SAIR AO PRESSIONAR UM BOTÃO QUE NAO SEJA O BOTAO 0 ----------------------------------------------------------------------------------------------------

        If (e.Button > 0) Then

            Exit Sub 'SAINDO...

        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA O TIPO DE ITEM CLICADO PELO USUÁRIO ----------------------------------------------------------------------------------------------------------

        If (e.Target.TagName = "IMG") Or (e.Target.TagName = "A") Then




            'ABRINDO ITEM DE HISTORICO CLICADO -----------------------------------------------------------------------------------------------------------------

            Dim V_NUMERO As String = MOTOR_GECKOFX.StatusText.Substring(MOTOR_GECKOFX.StatusText.LastIndexOf("/")).Replace("/", Nothing) 'OBTENDO O NUMERO




            PROC_CLICAR_EM_IMAGEM_DE_ABAS_ABERTAS(V_NUMERO) 'CLICAR EM IMAGEM DE ABAS ABERTAS

            '---------------------------------------------------------------------------------------------------------------------------------------------------

           

            'REMOVE ABA DE HISTORICO CASO ESTEJA ABERTA --------------------------------------------------------------------------------------------------------

            Me.Close() 'FECHANDO FORMULARIO

            '---------------------------------------------------------------------------------------------------------------------------------------------------




        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub MOTOR_GECKOFX_DomMouseUp(ByVal sender As System.Object, ByVal e As Gecko.GeckoDomMouseEventArgs) Handles MOTOR_GECKOFX.DomMouseUp
        On Error Resume Next


        'ATIVA OU NÃO O TIMER ------------------------------------------------------------------------------------------

        If (CHK_1.Checked = True) Then

            PROC_ATIVAR_TIMER() 'ATIVA O TIMER

        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub CHK_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_1.CheckedChanged
        On Error Resume Next

        TMR_ATUALIZADOR.Enabled = CHK_1.Checked 'HATIVA OU NÃO O TIMER

    End Sub

End Class