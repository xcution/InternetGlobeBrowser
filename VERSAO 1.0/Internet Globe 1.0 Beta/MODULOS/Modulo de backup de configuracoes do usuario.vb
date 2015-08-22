Module Modulo_de_backup_de_configuracoes_do_usuario


    'Variáveis de endereços de pastas de configuração

    Dim v_pasta_de_configuracao_backup_favoritos As String = V_PASTA_DE_FAVORITOS 'Pasta de favoritos para futuro backup

    Dim v_pasta_de_todas_as_configuracoes_backup As String = V_PASTA_DE_CONFIGURACAO 'Pasta de configuração geral para futuro backup















    'Procedimentos para backup de configurações

    '# Favoritos

    Public Sub proc_fazer_backup_de_todos_os_favoritos() 'Faz backup de todos os favoritos
        On Error Resume Next

        Dim OBJ_DIALOGO_ESCOLHER_PASTA As New FolderBrowserDialog 'Diálogo para escolher a pasta de backup

        Dim V_PASTA_JA_EXISTE As Boolean 'Informa se a pasta de destino ja existe

        Dim V_PASTA_JA_EXISTE_2 As Boolean 'Informa se a pasta de destino ja existe

        Dim V_DESTINO_BCKUP As String 'Informa o destino do backup






        'Fazendo o backup da pasta --------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (OBJ_DIALOGO_ESCOLHER_PASTA.ShowDialog = DialogResult.OK) Then




            V_DESTINO_BCKUP = OBJ_DIALOGO_ESCOLHER_PASTA.SelectedPath & "\" & v_nome_generico_de_pasta_de_favoritos 'Obtendo destino

            V_PASTA_JA_EXISTE = My.Computer.FileSystem.DirectoryExists(V_DESTINO_BCKUP) 'Verificando existencia...

            V_PASTA_JA_EXISTE_2 = My.Computer.FileSystem.DirectoryExists(v_pasta_de_configuracao_backup_favoritos) 'Verificando existencia...

            My.Computer.FileSystem.CopyDirectory(v_pasta_de_configuracao_backup_favoritos, V_DESTINO_BCKUP) 'Fazendo o backup




            'Informa que a copia foi feita com sucesso, se houver pasta de origem e destino ----------------------------

            If (V_PASTA_JA_EXISTE = True) And (V_PASTA_JA_EXISTE_2 = True) Then

                proc_chamar_mensagem_ao_usuario(V_MS_36, v_tipo_ms_1) 'Chama a janela de mensagem ao usuario

            End If

            '-----------------------------------------------------------------------------------------------------------




            'Informa que a pasta de origem nao existe ------------------------------------------------------------------

            If (V_PASTA_JA_EXISTE_2 = False) Then

                proc_chamar_mensagem_ao_usuario(V_MS_38, v_tipo_ms_3) 'Chama a janela de mensagem ao usuario

            End If

            '-----------------------------------------------------------------------------------------------------------


        End If

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



    End Sub

    Public Sub proc_restaurar_backup_de_todos_os_favoritos() 'Restaura o backup de todos os favoritos
        On Error Resume Next

        Dim OBJ_DIALOGO_ESCOLHER_PASTA As New FolderBrowserDialog 'Diálogo para escolher a pasta de backup

        Dim V_DESTINO_BCKUP As String 'Informa o destino do backup



        


        'Fazendo o backup da pasta --------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (OBJ_DIALOGO_ESCOLHER_PASTA.ShowDialog = DialogResult.OK) Then




            V_DESTINO_BCKUP = OBJ_DIALOGO_ESCOLHER_PASTA.SelectedPath 'Informando a pasta que sera copiada



            'Verificando se a pasta selecionada é a pasta de favoritos ----------------------------------------------------------------------------------------------------------

            If (V_DESTINO_BCKUP.Contains(v_nome_generico_de_pasta_de_favoritos) = True) Then


                My.Computer.FileSystem.CopyDirectory(V_DESTINO_BCKUP, v_pasta_de_configuracao_backup_favoritos) 'Fazendo o backup


            Else


                proc_chamar_mensagem_ao_usuario(V_MS_37 & v_nome_generico_de_pasta_de_favoritos & ".", v_tipo_ms_3) 'Chama a janela de mensagem ao usuario


            End If

            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------



        End If

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub


    '#Configurações

    Public Sub proc_fazer_backup_de_todas_as_configuracoes() 'Faz o backup de todas as configuraçoes
        On Error Resume Next

        Dim OBJ_DIALOGO_ESCOLHER_PASTA As New FolderBrowserDialog 'Diálogo para escolher a pasta de backup

        Dim V_PASTA_JA_EXISTE As Boolean 'Informa se a pasta de destino ja existe

        Dim V_PASTA_JA_EXISTE_2 As Boolean 'Informa se a pasta de destino ja existe

        Dim V_DESTINO_BCKUP As String 'Informa o destino do backup






        'Fazendo o backup da pasta --------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (OBJ_DIALOGO_ESCOLHER_PASTA.ShowDialog = DialogResult.OK) Then




            V_DESTINO_BCKUP = OBJ_DIALOGO_ESCOLHER_PASTA.SelectedPath & "\" & v_nome_generico_de_pasta_de_configuracoes_gerais 'Obtendo destino

            V_PASTA_JA_EXISTE = My.Computer.FileSystem.DirectoryExists(V_DESTINO_BCKUP) 'Verificando existencia...

            V_PASTA_JA_EXISTE_2 = My.Computer.FileSystem.DirectoryExists(v_pasta_de_todas_as_configuracoes_backup) 'Verificando existencia...

            My.Computer.FileSystem.CopyDirectory(v_pasta_de_todas_as_configuracoes_backup, V_DESTINO_BCKUP) 'Fazendo o backup




            'Informa que a copia foi feita com sucesso, se houver pasta de origem e destino ----------------------------

            If (V_PASTA_JA_EXISTE = True) And (V_PASTA_JA_EXISTE_2 = True) Then

                proc_chamar_mensagem_ao_usuario(V_MS_39, v_tipo_ms_1) 'Chama a janela de mensagem ao usuario

            End If

            '-----------------------------------------------------------------------------------------------------------




            'Informa que a pasta de origem nao existe ------------------------------------------------------------------

            If (V_PASTA_JA_EXISTE_2 = False) Then

                proc_chamar_mensagem_ao_usuario(V_MS_40, v_tipo_ms_3) 'Chama a janela de mensagem ao usuario

            End If

            '-----------------------------------------------------------------------------------------------------------


        End If

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



    End Sub

    Public Sub proc_restaurar_backup_de_todas_as_configuracoes() 'Restaura a configuração do navegador
        On Error Resume Next

        Dim OBJ_DIALOGO_ESCOLHER_PASTA As New FolderBrowserDialog 'Diálogo para escolher a pasta de backup

        Dim V_DESTINO_BCKUP As String 'Informa o destino do backup






        'Fazendo o backup da pasta --------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (OBJ_DIALOGO_ESCOLHER_PASTA.ShowDialog = DialogResult.OK) Then




            V_DESTINO_BCKUP = OBJ_DIALOGO_ESCOLHER_PASTA.SelectedPath 'Informando a pasta que sera copiada



            'Verificando se a pasta selecionada é a pasta de favoritos ----------------------------------------------------------------------------------------------------------

            If (V_DESTINO_BCKUP.Contains(v_nome_generico_de_pasta_de_configuracoes_gerais) = True) Then


                My.Computer.FileSystem.CopyDirectory(V_DESTINO_BCKUP, v_pasta_de_todas_as_configuracoes_backup) 'Fazendo o backup


            Else


                proc_chamar_mensagem_ao_usuario(V_MS_37 & v_nome_generico_de_pasta_de_configuracoes_gerais & ".", v_tipo_ms_3) 'Chama a janela de mensagem ao usuario


            End If

            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------



        End If

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub







































End Module
