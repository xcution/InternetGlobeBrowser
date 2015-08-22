Public Class FRM_FORMULARIO_DE_PLUGINS_INSTALADOS


    'VARIÁVEIS

    Public V_ABA_FRM_FORMULARIO_DE_PLUGINS_INSTALADOS As Byte 'ABA A SELECIONAR DESTA JANELA











    'PROCEDIMENTOS BASICOS

    Private Sub PROC_SELECIONAR_ABA_LOCAL() 'SELECIONA A ABA LOCAL
        On Error Resume Next

        TAB_OPCOES.SelectedIndex = V_ABA_FRM_FORMULARIO_DE_PLUGINS_INSTALADOS 'SELECIONANDO O INDEX

    End Sub

    Private Sub PROC_LISTAR_PLUGINS_E_APLICATIVOS_GERAIS() 'LISTA OS APLICATIVOS, E OS PLUGINS GERAIS
        On Error Resume Next

        PROC_SELECIONAR_ABA_LOCAL() 'SELECIONA A ABA LOCAL

        PROC_LISTAR_TODOS_OS_PLUGINS() 'LISTA TODOS OS PLUGINS

        PROC_LISTAR_TODOS_OS_APLICATIVOS() 'LISTA TODOS OS APLICATIVOS

    End Sub























    'PLUGINS

    Private Sub PROC_ABRIR_PLUGIN(ByVal V_TAG As Integer) 'ABRE O PLUGIN VIA TAG
        On Error Resume Next


        'ABRINDO APLICATIVO --------------------------------------------------------------------------------------------

        Select Case V_TAG

            Case 0
                PROC_CHAMAR_LEITOR_DE_TEXTOS_COM_VOZ(Nothing) 'CHAMA O LEITOR DE TEXTOS COM VOZ

            Case 1
                PROC_CHAMAR_JANELA_DE_INTELIGENCIA_DE_PROCESSAMENTO() 'CHAMA A JANELA DE INTELIGENCIA DE PROCESSAMENTO

        End Select

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_LISTE_PLUGIN_0() 'LISTA O PLUGIN
        On Error Resume Next

        Dim OBJ_ITEM As New ListViewItem 'NOVO NODE

        Dim V_NOME As String = "Leitor de textos(vóz)" 'NOME DE APLICATIVO

        Dim V_TAG_DE_APP As Integer = 0 'INDEX DA IMAGEM DE PLUGIN






        'PLUGIN DE LER PÁGINA ------------------------------------------------------------------------------------------

        OBJ_ITEM.Text = V_NOME 'TEXTO

        LST_PLUGINS.Items.Add(OBJ_ITEM) 'ADICIONA

        OBJ_ITEM.ImageIndex = V_TAG_DE_APP 'INDEX DA IMAGEM DE PLUGIN

        OBJ_ITEM.Tag = V_TAG_DE_APP 'TAG DE APLICATIVO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_LISTE_PLUGIN_1() 'LISTA O PLUGIN
        On Error Resume Next

        Dim OBJ_ITEM As New ListViewItem 'NOVO NODE

        Dim V_NOME As String = "Inteligência de processamento" 'NOME DE APLICATIVO

        Dim V_TAG_DE_APP As Integer = 1 'INDEX DA IMAGEM DE PLUGIN






        'PLUGIN DE LER PÁGINA ------------------------------------------------------------------------------------------

        OBJ_ITEM.Text = V_NOME 'TEXTO

        LST_PLUGINS.Items.Add(OBJ_ITEM) 'ADICIONA

        OBJ_ITEM.ImageIndex = V_TAG_DE_APP 'INDEX DA IMAGEM DE PLUGIN

        OBJ_ITEM.Tag = V_TAG_DE_APP 'TAG DE APLICATIVO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_LISTE_PLUGIN_2() 'PLUGINS DE NÚCLEO
        On Error Resume Next

        MT_PLUGINS_DE_NUCLEO.Navigate("about:plugins") 'ABRINDO LISTA DE PLUGINS DE NÚCLEO

    End Sub

    Private Sub PROC_LISTAR_TODOS_OS_PLUGINS() 'LISTA TODOS OS PLUGINS
        On Error Resume Next


        'LIMPA A LISTA DE PLUGINS E LISTA OS NOVO PLUGINS--------------------------------------------------------------------------------------

        LST_PLUGINS.Clear() 'LIMPA LISTA DE PLUGINS

        PROC_LISTE_PLUGIN_0() 'LISTA O PLUGIN

        PROC_LISTE_PLUGIN_1() 'LISTA O PLUGIN

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub




















    'APLICATIVOS

    Private Sub PROC_LISTAR_TODOS_OS_APLICATIVOS() 'LISTA TODOS OS APLICATIVOS
        On Error Resume Next

        Dim ARRAY_NOME_APP As Array = Split(FUNC_LER_ARQUIVO(V_INDICE_DE_APLICATIVOS_DO_NAVEGADOR_TITULO), vbCrLf) 'CRIANDO ARRAY COM NOMES DE APLICATIVOS INSTALADOS

        Dim ARRAY_LOCAL_APP As Array = Split(FUNC_LER_ARQUIVO(V_INDICE_DE_APLICATIVOS_DO_NAVEGADOR_LOCALIZACAO), vbCrLf) 'CRIANDO ARRAY COM NOMES DE APLICATIVOS INSTALADOS






        'CRIANDO REFERENCIA AO OBJETO ----------------------------------------------------------------------------------

        Dim OBJ_DE_ITEM_CRIADO_AGORA As ListView = CType(LST_APLICATIVOS, ListView) 'REFERENCIANDO

        '---------------------------------------------------------------------------------------------------------------




        'LIMPA ULTIMA LISTA DE APLICATIVOS -----------------------------------------------------------------------------

        LST_APLICATIVOS.Clear() 'LIMPA LISTA DE APLICATIVOS

        IML_3.Images.Clear() 'LIMPA AS IMAGENS

        '---------------------------------------------------------------------------------------------------------------




        'ADICIONA APLICATIVO A LISTA -----------------------------------------------------------------------------------

        For A = 0 To ARRAY_NOME_APP.Length - 1

            Dim OBJ_ITEM As New ListViewItem 'NOVO MENU DE ITEM





            'ADICIONA APLICATIVO E EVENTO --------------------------------------------------------------------------------------------------------------------

            If (ARRAY_NOME_APP(A) <> Nothing) And (ARRAY_NOME_APP(A) <> "") And (ARRAY_NOME_APP(A) <> "True") Then


                Dim V_LOCAL_DE_APP As String = V_PASTA_DE_APLICATIVOS_DO_NAVEGADOR & "\" & ARRAY_LOCAL_APP(A) 'LOCAL DE APLICATIVO

                Dim OBJ_IMAGE As Image = FUNC_RETORNE_A_IMAGEM_DE_ARQUIVO(V_LOCAL_DE_APP) 'RETORNA A IMAGEM DE ARQUIVO EM DISCO






                LST_APLICATIVOS.Items.Add(OBJ_ITEM) 'ADD APLICATIVO

                OBJ_ITEM.Text = ARRAY_NOME_APP(A) 'TITULO

                OBJ_ITEM.Tag = V_LOCAL_DE_APP 'LOCAL

                IML_3.Images.Add(ARRAY_NOME_APP(A), OBJ_IMAGE) 'ADICIONA A IMAGEM

                OBJ_ITEM.ImageKey = ARRAY_NOME_APP(A) 'CODIGO DA IMAGEM



            End If

            '-------------------------------------------------------------------------------------------------------------------------------------------------


        Next

        '---------------------------------------------------------------------------------------------------------------


    End Sub



































    Private Sub FRM_FORMULARIO_DE_PLUGINS_INSTALADOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        PROC_LISTAR_PLUGINS_E_APLICATIVOS_GERAIS() 'LISTA OS APLICATIVOS, E OS PLUGINS GERAIS

    End Sub

    Private Sub LST_PLUGINS_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LST_PLUGINS.DoubleClick
        On Error Resume Next

        PROC_ABRIR_PLUGIN(LST_PLUGINS.FocusedItem.Tag) 'ABRE O PLUGIN VIA TAG

    End Sub

    Private Sub LST_PLUGINS_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LST_PLUGINS.KeyDown
        On Error Resume Next


        'AO PRESSIONAR ENTER ENTAO ABRIR O PLUGIN ----------------------------------------------------------------------

        If (e.KeyCode = Keys.Enter) Then


            e.SuppressKeyPress = True 'SEM BEEP

            PROC_ABRIR_PLUGIN(LST_PLUGINS.FocusedItem.Tag) 'ABRE O PLUGIN VIA TAG


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub LST_APLICATIVOS_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LST_APLICATIVOS.DoubleClick
        On Error Resume Next

        PROC_ABRIR_APLICATIVO_INSTALADO_DO_NAVEGADOR(LST_APLICATIVOS.FocusedItem.Tag) 'ABRE O APLICATIVO INSTALADO PARA O USUÁRIO

    End Sub

    Private Sub LST_APLICATIVOS_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LST_APLICATIVOS.KeyDown
        On Error Resume Next


        'AO PRESSIONAR ENTER ABRIR APLICATIVO INSTALADO ---------------------------------------------------------------------------------------

        If (e.KeyCode = Keys.Enter) Then


            e.SuppressKeyPress = True 'SEM BEEP

            PROC_ABRIR_APLICATIVO_INSTALADO_DO_NAVEGADOR(LST_APLICATIVOS.FocusedItem.Tag) 'ABRE O APLICATIVO INSTALADO PARA O USUÁRIO


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        On Error Resume Next

        PROC_ABRIR_PLUGIN(LST_PLUGINS.FocusedItem.Tag) 'ABRE O PLUGIN VIA TAG

    End Sub

    Private Sub MNU_PLUGINS_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MNU_PLUGINS.Opening
        On Error Resume Next


        'VERIFICA SE PODE ABRIR O PLUGIN SELECIONADO -------------------------------------------------------------------

        If (LST_PLUGINS.SelectedItems.Count = 0) Then


            AbrirToolStripMenuItem.Enabled = False 'NAO DISPONIVEL


        Else


            AbrirToolStripMenuItem.Enabled = True 'DISPONIVEL


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub MNU_APLICATIVOS_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MNU_APLICATIVOS.Opening
        On Error Resume Next


        'VERIFICA SE PODE ABRIR O APLICATIVO SELECIONADO ---------------------------------------------------------------

        If (LST_APLICATIVOS.SelectedItems.Count = 0) Then


            MNU_APLICATIVOS.Enabled = False 'NAO DISPONIVEL


        Else


            MNU_APLICATIVOS.Enabled = True 'DISPONIVEL


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub AbrirAplicativoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirAplicativoToolStripMenuItem.Click
        On Error Resume Next

        PROC_ABRIR_APLICATIVO_INSTALADO_DO_NAVEGADOR(LST_APLICATIVOS.FocusedItem.Tag) 'ABRE O APLICATIVO INSTALADO PARA O USUÁRIO

    End Sub

    Private Sub PastaDeAplicativoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PastaDeAplicativoToolStripMenuItem.Click
        On Error Resume Next

        PROC_ABRIR_PASTA_DE_APLICATIVO_INSTALADO(LST_APLICATIVOS.FocusedItem.Tag) 'ABRE A PASTA DE APLICATIVO INSTALADO

    End Sub

    Private Sub RemoverAplicativoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoverAplicativoToolStripMenuItem.Click
        On Error Resume Next

        PROC_REMOVER_APLICATIVO_INSTALADO(LST_APLICATIVOS.FocusedItem.Tag, LST_APLICATIVOS.FocusedItem.Text) 'REMOVE O APLICATIVO INSTALADO

        PROC_LISTAR_TODOS_OS_APLICATIVOS() 'LISTA TODOS OS APLICATIVOS

    End Sub

    Private Sub TAB_OPCOES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TAB_OPCOES.SelectedIndexChanged
        On Error Resume Next

        PROC_LISTE_PLUGIN_2() 'PLUGINS DE NÚCLEO

    End Sub

End Class