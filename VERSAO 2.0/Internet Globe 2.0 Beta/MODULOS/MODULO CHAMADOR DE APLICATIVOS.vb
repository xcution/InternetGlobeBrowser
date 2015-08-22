Imports System.IO

Module MODULO_CHAMADOR_DE_APLICATIVOS


    'VARIÁVEIS

    Public V_PASTA_DE_APLICATIVOS_DO_NAVEGADOR As String = Application.StartupPath() & "\app" 'PASTA DE INSTALAÇÃO DE APLICATIVOS DO NAVEGADOR

    Public V_INDICE_DE_APLICATIVOS_DO_NAVEGADOR_TITULO As String = V_PASTA_DE_APLICATIVOS_DO_NAVEGADOR & "\titulo.txt" 'AQUI FICA O TITULO DE CADA APLICATIVO INSTALADO

    Public V_INDICE_DE_APLICATIVOS_DO_NAVEGADOR_LOCALIZACAO As String = V_PASTA_DE_APLICATIVOS_DO_NAVEGADOR & "\local.txt" 'AQUI FICA A ORIGEM DE CADA APLICATIVO INSTALADO










    'CONSTANTES

    Public V_APLICATIVO_PADRAO_PARA_EDITOR_DE_IMAGENS As String = V_PASTA_DE_APLICATIVOS_DO_NAVEGADOR & "\ps\M7 Photo Sete.exe" 'APLICATIVO PADRAO PARA EDIÇÃO DE IMAGENS




















    'PROCEDIMENTOS RELACIONADOS AOS APLICATIVOS INSTALADOS

    Public Sub PROC_ABRIR_APLICATIVO_INSTALADO_DO_NAVEGADOR(ByVal V_ORIGEM As String) 'ABRE O APLICATIVO INSTALADO PARA O USUÁRIO
        On Error Resume Next


        'VERIFICA SE O APLICATIVO A SER ABERTO É O ASSOCIADOR DE EXTENÇÃO -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_ORIGEM.Contains("M7SLMAEXT.exe") = True) Then


            PROC_ABRIR_APLICATIVO_INSTALADO_DO_NAVEGADOR_PARAMETRO_EXTRA(V_ORIGEM, Application.ExecutablePath & vbCrLf & V_PASTA_DE_INSTALACAO_ATUAL & "\icone.ico") 'ABRE O APLICATIVO INSTALADO PARA O USUÁRIO COM PARAMETRO EXTRA

            Exit Sub 'SAINDO DO PROCEDIMENTO


        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'ABRINDO APLICATIVO COM PARAMETRO ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        Process.Start(V_ORIGEM, Path.GetDirectoryName(V_ORIGEM)) 'ABRE O APLICATIVO JUNTO COM O PARAMETRO

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_LISTE_OS_APLICATIVOS_NO_MENU_DE_APLICATIVOS(ByVal OBJ_PARAMETRO As Object) 'LISTA OS APLICATIVOS NO MENU DE PLUGINS
        On Error Resume Next

        Dim ARRAY_NOME_APP As Array = Split(FUNC_LER_ARQUIVO(V_INDICE_DE_APLICATIVOS_DO_NAVEGADOR_TITULO), vbCrLf) 'CRIANDO ARRAY COM NOMES DE APLICATIVOS INSTALADOS

        Dim ARRAY_LOCAL_APP As Array = Split(FUNC_LER_ARQUIVO(V_INDICE_DE_APLICATIVOS_DO_NAVEGADOR_LOCALIZACAO), vbCrLf) 'CRIANDO ARRAY COM NOMES DE APLICATIVOS INSTALADOS






        'CRIANDO REFERENCIA AO OBJETO ----------------------------------------------------------------------------------

        Dim OBJ_DE_ITEM_CRIADO_AGORA As ToolStripMenuItem = CType(OBJ_PARAMETRO, ToolStripMenuItem) 'REFERENCIANDO

        '---------------------------------------------------------------------------------------------------------------




        'LIMPA O  OBJETO -----------------------------------------------------------------------------------------------

        OBJ_DE_ITEM_CRIADO_AGORA.DropDownItems.Clear() 'LIMPANDO

        '---------------------------------------------------------------------------------------------------------------




        'ADICIONA APLICATIVO A LISTA -----------------------------------------------------------------------------------

        For A = 0 To ARRAY_NOME_APP.Length - 1

            Dim OBJ_ITEM As New ToolStripMenuItem 'NOVO MENU DE ITEM





            'ADICIONA APLICATIVO E EVENTO ---------------------------------------------------------------------------------------------------------------------------------

            If (ARRAY_NOME_APP(A) <> Nothing) And (ARRAY_NOME_APP(A) <> "") And (ARRAY_NOME_APP(A) <> "True") Then


                Dim V_LOCAL_DE_APP As String = V_PASTA_DE_APLICATIVOS_DO_NAVEGADOR & "\" & ARRAY_LOCAL_APP(A) 'LOCAL DE APLICATIVO

                Dim OBJ_IMAGE As Image = FUNC_RETORNE_A_IMAGEM_DE_ARQUIVO(V_LOCAL_DE_APP) 'RETORNA A IMAGEM DE ARQUIVO EM DISCO






                OBJ_IMAGE = OBJ_IMAGE.GetThumbnailImage(16, 16, Nothing, Nothing) 'OBTENDO MINIATURA DE IMAGEM

                OBJ_DE_ITEM_CRIADO_AGORA.DropDownItems.Add(OBJ_ITEM) 'APLICATIVO

                OBJ_ITEM.Text = ARRAY_NOME_APP(A) 'TITULO

                OBJ_ITEM.Tag = V_LOCAL_DE_APP 'LOCAL

                OBJ_ITEM.Image = OBJ_IMAGE 'IMAGEM

                AddHandler OBJ_ITEM.Click, AddressOf PROC_SELECIONOU_APLICATIVO_EVENTO 'EVENTO




            End If

            '--------------------------------------------------------------------------------------------------------------------------------------------------------------


        Next

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_ABRIR_PASTA_DE_APLICATIVO_INSTALADO(ByVal V_ORIGEM As String) 'ABRE A PASTA DE APLICATIVO INSTALADO
        On Error Resume Next


        'ABRINDO PASTA ------------------------------------------------------------------------------------------------------------------------

        Process.Start(Path.GetDirectoryName(V_ORIGEM)) 'ABRINDO A PASTA

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_REMOVER_APLICATIVO_INSTALADO(ByVal V_ORIGEM As String, ByVal V_TITULO As String) 'REMOVE O APLICATIVO INSTALADO
        On Error Resume Next

        Dim V_LISTA_DE_TITULOS As String = FUNC_LER_ARQUIVO(V_INDICE_DE_APLICATIVOS_DO_NAVEGADOR_TITULO) 'TITULOS

        Dim V_LISTA_DE_LOCAIS As String = FUNC_LER_ARQUIVO(V_INDICE_DE_APLICATIVOS_DO_NAVEGADOR_LOCALIZACAO) 'LOCAIS






        'REMOVENDO ----------------------------------------------------------------------------------------------------------------------------

        If (MsgBox(V_MS8, MsgBoxStyle.YesNo, V_MS8) = MsgBoxResult.Yes) Then


            'REMOVENDO CONTEUDOS --------------------------------------------------------------------------------------------------------------

            PROC_REMOVE_PASTA_COMPLETA_COM_SUB_PASTAS(Path.GetDirectoryName(V_ORIGEM), False) 'REMOVE TODA A PASTA INCLUINDO ARQUIVOS

            V_LISTA_DE_TITULOS = V_LISTA_DE_TITULOS.Replace(V_TITULO, Nothing) 'REMOVENDO TITULO

            V_LISTA_DE_LOCAIS = V_LISTA_DE_LOCAIS.Replace(V_ORIGEM, Nothing) 'REMOVENDO ORIGEM

            '----------------------------------------------------------------------------------------------------------------------------------




            'ATUALIZANDO CONTEUDOS ------------------------------------------------------------------------------------------------------------

            PROC_SALVAR_ARQUIVO(V_LISTA_DE_TITULOS, V_INDICE_DE_APLICATIVOS_DO_NAVEGADOR_TITULO) 'ATUALIZANDO CONTEUDO

            PROC_SALVAR_ARQUIVO(V_LISTA_DE_LOCAIS, V_INDICE_DE_APLICATIVOS_DO_NAVEGADOR_LOCALIZACAO) 'ATUALIZANDO CONTEUDO

            '----------------------------------------------------------------------------------------------------------------------------------


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_ABRIR_APLICATIVO_INSTALADO_DO_NAVEGADOR_PARAMETRO_EXTRA(ByVal V_ORIGEM As String, ByVal V_PARAMETRO As String) 'ABRE O APLICATIVO INSTALADO PARA O USUÁRIO COM PARAMETRO EXTRA
        On Error Resume Next


        'ABRINDO APLICATIVO COM PARAMETRO -----------------------------------------------------------------------------------------------------

        Process.Start(V_ORIGEM, V_PARAMETRO) 'ABRE O APLICATIVO JUNTO COM O PARAMETRO

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

















    'EVENTOS

    Public Sub PROC_SELECIONOU_APLICATIVO_EVENTO(ByVal sender As System.Object, ByVal e As System.EventArgs) 'EVENTO DE SELECIONOU APLICATIVO
        On Error Resume Next


        'CRIANDO REFERENCIA AO OBJETO ----------------------------------------------------------------------------------

        Dim OBJ_DE_ITEM_CRIADO_AGORA As ToolStripMenuItem = CType(sender, ToolStripMenuItem) 'REFERENCIANDO

        '---------------------------------------------------------------------------------------------------------------




        'ABRINDO APLICATIVO AGORA ---------------------------------------------------------------------------------------------------------------------------

        PROC_ABRIR_APLICATIVO_INSTALADO_DO_NAVEGADOR(OBJ_DE_ITEM_CRIADO_AGORA.Tag) 'ABRE O APLICATIVO INSTALADO PARA O USUÁRIO

        '----------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub








































End Module
