Module MODULO_DE_SONS


    'VARIÁVEIS

    Dim V_PASTA_DE_SONS As String = Application.StartupPath() & "\Complementos\Medias\" 'PASTAS DE SONS












    'PROCEDIMENTOS

    Public Sub PROC_EXIBIR_SOM_DE_SISTEMA(ByVal V_TIPO_DE_SOM As Integer) 'EXIBE OS SONS INSTALADOS NO SISTEMA
        On Error Resume Next


        'VERIFICA SE O RECURSO ESTA ATIVADO ---------------------------------------------------------------------------------------------------

        If (FUNC_LER_ARQUIVO(V_ARQUIVO_END_28) = False) Then

            Exit Sub 'SAINDO

        End If

        '--------------------------------------------------------------------------------------------------------------------------------------




        'USANDO O RECURSO ---------------------------------------------------------------------------------------------------------------------

        My.Computer.Audio.Play(V_PASTA_DE_SONS & V_TIPO_DE_SOM & ".wav", AudioPlayMode.Background) 'OUVINDO

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub













End Module
