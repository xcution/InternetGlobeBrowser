Module Modulo_gerenciador_de_janelas


    'Gerenciadores de janela


    Public Sub proc_ocultar_ou_exibir_janela_de_navegacao(ByVal v_resposta As Boolean) 'Oculta ou exibe a janela de navegação
        On Error Resume Next


        'Exibe ou oculta a janela de navegação --------------------------------------------------------------------------

        If (v_resposta = True) Then


            FRM_NAVEGACAO.Hide() 'Ocultando...


        Else


            FRM_NAVEGACAO.Show() 'Exibindo...


        End If

        '-----------------------------------------------------------------------------------------------------------------


    End Sub
















































End Module
