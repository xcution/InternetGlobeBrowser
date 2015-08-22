Module MODULO_DE_PROCEDIMENTOS_EXTRAS


    'PROCEDIMENTOS

    Public Sub PROC_REINSTALAR_SISTEMA_DE_VOZ() 'REINSTALA O SISTEMA DE VOZ
        On Error Resume Next


        'VERIFICA SE O ARQUIVO ESTA DISPONIVEL -------------------------------------------------------------------------

        If (FUNC_RETORNE_SE_ARQUIVO_EXISTE(V_ARQUIVO_DE_INSTALACAO_DE_VOZ) = False) Then


            Exit Sub 'SAINDO


        End If

        '---------------------------------------------------------------------------------------------------------------




        'ABRINDO O PROCESSO --------------------------------------------------------------------------------------------

        Dim V_PROCESSO_ID As Integer

        V_PROCESSO_ID = Shell(V_ARQUIVO_DE_INSTALACAO_DE_VOZ, AppWinStyle.NormalFocus) 'RODANDO O PROCESSO

        AppActivate(V_PROCESSO_ID) 'ABRINDO

        '---------------------------------------------------------------------------------------------------------------


    End Sub















    'PROCEDIMENTOS DO MENU DE AJUDA

    Public Sub PROC_VERSAO_DE_APLICATIVO_NAVEGADOR() 'INFORMA A VERSÃO DO APLICATIVO NAVEGADOR
        On Error Resume Next

        Dim V_APLICATIVO_VERSAO_RODAR As String = V_PASTA_DE_INSTALACAO_ATUAL & "\Complementos\Versao\M7INFOVERSAO.exe" 'APLICATIVO A SER ABERTO

        Dim V_APLICATIVO_GLOBE As String = V_PASTA_DE_INSTALACAO_ATUAL & "\Internet Globe 2.0 Beta.exe" 'ARQUIVO .EXE DO NAVEGADOR






        'ABRE O APLICATIVO INFORMADOR DE VERSÃO, E VISUALIZA A VERSÃO DO NAVEGADOR -----------------------------------------------------------------------------

        Process.Start(V_APLICATIVO_VERSAO_RODAR, V_APLICATIVO_GLOBE) 'ABRINDO APLICATIVO DE VERSÃO

        '-------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub















    'ATUALIZADOR DE PLUGINS DO NAVEGADOR

    Public Sub PROC_ATUALIZAR_PLUGIN_FLASH_PLAYER() 'ATUALIZA O PLUGIN FLASH PLAYER
        On Error Resume Next

        PROC_NAVEGAR("http://get.adobe.com/br/flashplayer/") 'ABRINDO ENDEREÇO DE URL DE PLUGIN FLASH PLAYER

    End Sub

    Public Sub PROC_ATUALIZAR_PLUGIN_MICROSOFT_SILVERLIGHT() 'ATUALIZA O PLUGIN DO SILVERLIGHT
        On Error Resume Next

        PROC_NAVEGAR("http://www.microsoft.com/getsilverlight/Get-Started/Install/Default.aspx") 'ABRINDO ENDEREÇO DE PLUGIN MICROSOFT SILVERLIGHT

    End Sub
























































End Module
