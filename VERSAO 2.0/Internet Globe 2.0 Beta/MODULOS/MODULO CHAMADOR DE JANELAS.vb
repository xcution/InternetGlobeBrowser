Imports System.IO

Module MODULO_CHAMADOR_DE_JANELAS


    'PROCEDIMENTOS

    Public Sub PROC_CHAMAR_PAINEL_DE_CONTROLE() 'CHAMA O PAINEL DE CONTROLE
        On Error Resume Next


        'CHAMANDO O PAINEL DE CONTROLE --------------------------------------------------------------------------------

        FRM_FORMULARIO_PAINEL_DE_CONTROLE.ShowDialog() 'ABRINDO AGORA

        '--------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_CHAMAR_MEUS_FAVORITOS(ByVal V_ABA_A_ABRIR As Byte) 'CHAMA A JANELA DE MEUS FAVORÍTOS
        On Error Resume Next


        'ABRINDO A JANELA DE MAIS FAVORITOS ----------------------------------------------------------------------------

        Select Case V_ABA_A_ABRIR


            Case 1
                FRM_FORMULARIO_DE_FAVORITOS.TabControl1.SelectedIndex = 1 'ABA SELECIONADCA


            Case 2
                FRM_FORMULARIO_DE_FAVORITOS.TabControl1.SelectedIndex = 0 'ABA SELECIONADCA
                FRM_FORMULARIO_DE_FAVORITOS.PROC_ADD_SITE_EM_VISUALIZACAO() 'ADICIONA O SITE EM VISUALIZAÇÃO


        End Select

        '---------------------------------------------------------------------------------------------------------------




        'ABRINDO FORMULARIO --------------------------------------------------

        FRM_FORMULARIO_DE_FAVORITOS.ShowDialog() 'ABRINDO A JANELA

        '---------------------------------------------------------------------


    End Sub

    Public Sub PROC_CHAMAR_JANELA_DE_AVISOS(ByVal V_MENSAGEM As String, ByVal V_TIPO_MS As Byte) 'FORMULARIO DE AVISOS
        On Error Resume Next

        Dim OBJ_JANELA As New FRM_FORMULARIO_CAIXA_DE_AVISOS 'NOVO FORMULARIO DE AVISOS






        'ABRINDO ----------------------------------------------------------------------------

        OBJ_JANELA.V_MENSAGEM = V_MENSAGEM 'MENSAGEM

        OBJ_JANELA.V_TIPO_DE_MS = V_TIPO_MS 'TIPO DE MENSAGEM

        OBJ_JANELA.ShowDialog() 'ABRINDO FORMULARIO

        '------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_CHAMAR_JANELA_GERENCIADORA_DE_POPUP() 'CHAMA A JANELA GERENCIADORA DE POP-UPS
        On Error Resume Next

        Dim OBJ_NOVA_JANELA As New FRM_FORMULARIO_GERENCIADOR_DE_POPUPS 'NOVA JANELA

        Dim V_PAINEL_DE_CONTROLE_VISIVEL As String = FRM_FORMULARIO_PAINEL_DE_CONTROLE.Visible 'INFORMA SE O PAINEL DE CONTROLE ESTAVA OU NAO VISIVEL






        'OCULTA O PAINEL DE CONTROLE -----------------------------------------------------------------------------------

        If (FRM_FORMULARIO_PAINEL_DE_CONTROLE.Visible = True) Then


            FRM_FORMULARIO_PAINEL_DE_CONTROLE.Hide() 'OCULTA O PAINEL DE CONTROLE


        End If

        '---------------------------------------------------------------------------------------------------------------




        'ABRINDO JANELA ------------------------------------------------------------------------------------------------

        OBJ_NOVA_JANELA.ShowDialog() 'ABRINDO A JANELA

        '---------------------------------------------------------------------------------------------------------------




        'EXIBE OU NAO O PAINEL DE CONTROLE -----------------------------------------------------------------------------

        FRM_FORMULARIO_PAINEL_DE_CONTROLE.Visible = V_PAINEL_DE_CONTROLE_VISIVEL 'EXIBE OU NAO O PAINEL DE CONTROLE

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_CHAMAR_JANELA_GERADORA_DE_IMAGENS_DE_ABAS() 'JANELA GERADORA DE IMAGENS DE ABAS
        On Error Resume Next


        'FECHANDO FORMULARIOS DE TRABALHO SECUNDÁRIO ---------------------------------------------------------------------------------------------------------------------------------------------

        PROC_FECHAR_FORMULARIOS_DE_TRABALHO_SECUNDARIO() 'FECHA TODOS OS FORMULARIOS DE TRABALHO SECUNDÁRIO

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA SE O FORMULÁRIO JÁ ESTÁ ABERTO OU NÃO ---------------------------------------------------------------------------------------------------------------------------------------

        If (FRM_FORMULARIO_GERADOR_DE_IMAGENS_DE_ABAS.Visible = False) Then




            'REMOVENDO EVENTO DE MUDANÇA DE ABAS -------------------------------------------------------------------------------------------------------------------

            RemoveHandler FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.SelectedTabChanged, AddressOf TAB_ABAS_SELECIONAR_OUTRA_ABA

            '-------------------------------------------------------------------------------------------------------------------------------------------------------




            'FECHANDO FORMULARIO ANTIGO, ADICIONANDO NOVO, E MOVENDO FOCO PARA BARRA DE ENDEREÇOS ------------------------------------------------------------------

            FRM_FORMULARIO_GERADOR_DE_IMAGENS_DE_ABAS.Close() 'FECHANDO FORMULARIO

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.TabPages.Add(FRM_FORMULARIO_GERADOR_DE_IMAGENS_DE_ABAS) 'NOVA ABA DO NAVEGADOR

            '-------------------------------------------------------------------------------------------------------------------------------------------------------




            'FECHA O FORMULÁRIO DE HISTORICO SE ESTIVER ABERTO ---------------------------------------------------------------------------------------------------------------------------------------

            FRM_FORMULARIO_EXIBIDOR_DE_HISTORICO.Close() 'FECHANDO O FORMULÁRIO...

            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PN_HISTORICO.Visible = False 'OCULTA O PAINEL DE AÇÕES SOBRE O HISTORICO

            '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'ADICIONA EVENTO DE MUDANÇA DE ABAS --------------------------------------------------------------------------------------------------------------------

            AddHandler FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.SelectedTabChanged, AddressOf TAB_ABAS_SELECIONAR_OUTRA_ABA 'EVENTO DE MUDANÇA DE ABAS

            '-------------------------------------------------------------------------------------------------------------------------------------------------------




        End If

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



    End Sub

    Public Sub PROC_CHAMAR_SALVAR_JANELAS_ABERTAS() 'CHAMAR O SALVAR JANELAS ABERTAS
        On Error Resume Next

        Dim V_NAO_ABRIR_FORMULARIO_MAS_SALVAR As String = FUNC_LER_ARQUIVO(V_ARQUIVO_END_17) 'LENDO CONFIGURAÇÃO

        Dim V_PODE_ABRIR_FORMULARIO As String = FUNC_LER_ARQUIVO(V_ARQUIVO_END_3) 'LENDO CONFIGURAÇÃO

        Dim OBJ_FORMULARIO As New FRM_FORMULARIO_SALVAR_ABAS_ABERTAS 'NOVO FORMULÁRIO






        'VERIFICA SE SALVA AS ABAS MESMO SEM EXIBIR O FORMULARIO DE PERGUNTA ---------------------------------------------------------------

        If (V_NAO_ABRIR_FORMULARIO_MAS_SALVAR = True) And (V_PODE_ABRIR_FORMULARIO = False) Then




            'SALVA AS CONFIGURAÇÕES AO SAIR E ANALISA JANELAS ABERTAS ----------------------------------------------------------------------

            PROC_SALVAR_TODAS_AS_CONFIGURACOES_AO_SAIR() 'SALVA TODAS AS CONFIGURAÇÕES AO SAIR DO NAVEGADOR

            '-------------------------------------------------------------------------------------------------------------------------------




            'INFORMA QUE PODE SAIR ---------------------------------------------------------------------------------------------------------

            V_PODE_SAIR_DA_SESSAO_ATUAL = False 'INFORMA QUE PODE SAIR

            '-------------------------------------------------------------------------------------------------------------------------------




            'SAINDO ------------------------------------------------------------------------------------------------------------------------

            Exit Sub 'SAINDO...

            '-------------------------------------------------------------------------------------------------------------------------------




        End If

        '-----------------------------------------------------------------------------------------------------------------------------------




        'ABRINDO FORMULARIO ----------------------------------------------------------------------------------------------------------------

        If (V_PODE_ABRIR_FORMULARIO = True) And (FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.TabPages.Count) > 1 Then




            OBJ_FORMULARIO.ShowDialog() 'ABRINDO FORMULÁRIO...




        Else




            'SALVAR SESSÃO CORRETAMENTE ----------------------------------------------------------------------------------------------------

            PROC_SALVOU_SESSAO_CORRETAMENTE() 'INFORMA QUE SALVOU A SESSÃO CORRETAMENTE

            '-------------------------------------------------------------------------------------------------------------------------------




            'SALVA AS CONFIGURAÇÕES AO SAIR E ANALISA JANELAS ABERTAS ----------------------------------------------------------------------

            PROC_SALVAR_TODAS_AS_CONFIGURACOES_AO_SAIR() 'SALVA TODAS AS CONFIGURAÇÕES AO SAIR DO NAVEGADOR

            '-------------------------------------------------------------------------------------------------------------------------------




        End If

        '-----------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_CHAMAR_LEITOR_DE_TEXTOS_COM_VOZ(ByVal V_TEXTO As String) 'CHAMA O LEITOR DE TEXTOS COM VOZ
        On Error Resume Next

        Static V_ULTIMO_TEXTO_LIDO As String 'INFORMA O ULTIMO TEXTO LIDO PELO SISTEMA






        'VERIFICA SE É UMA NOVA LEITURA DE TEXTO -----------------------------------------------------------------------

        If (V_ULTIMO_TEXTO_LIDO <> V_TEXTO) And (V_TEXTO <> Nothing) Then

            FRM_FORMULARIO_DE_VOZ.Close() 'FECHA ULTIMA ABERTURA

        End If

        '---------------------------------------------------------------------------------------------------------------




        'ABRINDO FORMULARIO --------------------------------------------------------------------------------------------

        If (FUNC_RETORNE_SE_A_VOZ_ESTA_SENDO_USADA() = False) Then


            FRM_FORMULARIO_DE_VOZ.Close() 'FECHA ULTIMA ABERTURA

            FRM_FORMULARIO_DE_VOZ.V_TEXTO_A_SER_TRABALHADO = V_TEXTO 'TEXTO A SER TRABALHADO

            FRM_FORMULARIO_DE_VOZ.RCH_TEXTO.Text = V_TEXTO 'TEXTO A SER TRABALHADO

            FRM_FORMULARIO_DE_VOZ.Show() 'ABRINDO

            FRM_FORMULARIO_DE_VOZ.TopMost = True 'HABILITA O TOPMOST


        Else


            FRM_FORMULARIO_DE_VOZ.Show() 'ABRINDO


        End If


        '---------------------------------------------------------------------------------------------------------------




        'ATUALIZA ULTIMO TEXTO LIDO ------------------------------------------------------------------------------------

        If (V_TEXTO <> Nothing) Then


            V_ULTIMO_TEXTO_LIDO = V_TEXTO 'ATUALIZANDO


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_CHAMAR_JANELA_DE_INTELIGENCIA_DE_PROCESSAMENTO() 'CHAMA A JANELA DE INTELIGENCIA DE PROCESSAMENTO
        On Error Resume Next


        'CHAMA FORMULARIO DE INTELIGENCIA DE PROCESSAMENTO -------------------------------------------------------------

        FRM_FORMULARIO_INTELIGENCIA_DE_PROCESSAMENTO.Show() 'INTELIGENCIA DE PROCESSAMENTO

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Public Sub PROC_CHAMAR_JANELA_DE_NAVEGACAO() 'CHAMA A JANELA DE NAVEGAÇÃO
        On Error Resume Next


        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.Show() 'ABRINDO A JANELA DE NAVEGAÇÃO


    End Sub

    Public Sub PROC_CHAMAR_NOVA_INSTANCIA_DO_NAVEGADOR() 'CHAMA UMA NOVA INSTANCIA DO NAVEGADOR
        On Error Resume Next

        Dim V_DESTINO As String = V_PASTA_DE_INSTALACAO_ATUAL & "\Internet Globe 2.0 Beta.exe" 'DESTINO DE NOVA INSTANCIA DO NAVEGADOR






        'CHAMA NOVA INSTANCIA DO NAVEGADOR ----------------------------------------------------------------------------------------------------

        Process.Start(V_DESTINO, Path.GetDirectoryName(V_DESTINO)) 'CHAMA NOVA INSTANCIA DO NAVEGADOR

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_CHAMAR_A_JANELA_DE_PLUGINS_INSTALADOS(ByVal V_ABA_DE_APP As Byte) 'CHAMA A JANELA DE PLUGINS INSTALADOS
        On Error Resume Next


        'REMOVENDO EVENTO DE MUDANÇA DE ABAS -------------------------------------------------------------------------------------------------------------------

        RemoveHandler FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.SelectedTabChanged, AddressOf TAB_ABAS_SELECIONAR_OUTRA_ABA

        '-------------------------------------------------------------------------------------------------------------------------------------------------------




        'FECHA OS FORMULARIOS ABERTOS DE TRABALHO SECUNDÁRIOS ABERTOS ------------------------------------------------------------------------------------------

        PROC_FECHAR_FORMULARIOS_DE_TRABALHO_SECUNDARIO() 'FECHA TODOS OS FORMULARIOS DE TRABALHO SECUNDÁRIO

        '-------------------------------------------------------------------------------------------------------------------------------------------------------




        'FECHA O FORMULARIO DE PLUGINS INSTALADOS E REABRE -----------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_PLUGINS_INSTALADOS.V_ABA_FRM_FORMULARIO_DE_PLUGINS_INSTALADOS = V_ABA_DE_APP 'INFORMA A ABA A SER ABERTA

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.TabPages.Add(FRM_FORMULARIO_DE_PLUGINS_INSTALADOS) 'ADICIONA EM NOVA ABA

        '-------------------------------------------------------------------------------------------------------------------------------------------------------




        'ADICIONA EVENTO DE MUDANÇA DE ABAS --------------------------------------------------------------------------------------------------------------------

        AddHandler FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.SelectedTabChanged, AddressOf TAB_ABAS_SELECIONAR_OUTRA_ABA 'EVENTO DE MUDANÇA DE ABAS

        '-------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub














    'FECHAR JANELAS ABERTAS POR ESTE MODULO

    Public Sub PROC_FECHAR_FORMULARIOS_DE_TRABALHO_SECUNDARIO() 'FECHA TODOS OS FORMULARIOS DE TRABALHO SECUNDÁRIO
        On Error Resume Next


        'FECHA O FORMULÁRIO DE HISTORICO SE ESTIVER ABERTO ---------------------------------------------------------------------------------------------------------------------------------------

        PROC_FECHAR_O_HISTORICO_EXIBIDO_NO_FORM_PRINCIPAL() 'FECHA O HISTÓRICO EXIBIDO NO FORMULARIO PRINCIPAL

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'FECHA O FORMULARIO DE IMAGENS DE ABAS ABERTAS -------------------------------------------------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_GERADOR_DE_IMAGENS_DE_ABAS.Close() 'FECHANDO O FORMULARIO...

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'FECHA O FORMULARIO DE TESTE DE INTELIGENCIA ---------------------------------------------------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_INTELIGENCIA_DE_PROCESSAMENTO.Close() 'FECHANDO O FORMULARIO...

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'FECHA O FORMULARIO DE PLUGINS E APLICATIVOS INSTALADOS ----------------------------------------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_PLUGINS_INSTALADOS.Close() 'FECHANDO O FORMULARIO...

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'PERMITE AUTO-CLOSE --------------------------------------------------------------------------------------------

        OBJ_MENU_DE_CONTEXTO.AutoClose = True 'AUTO-CLOSE

        OBJ_MENU_DE_CONTEXTO.Close() 'FECHANDO MENU

        '---------------------------------------------------------------------------------------------------------------




        'FECHA FORMULARIO DE HISTORICOS PROCESSADOS --------------------------------------------------------------------

        PROC_FECHAR_O_FORMULARIO_DE_HISTORICOS_PROCESSADOS() 'FECHA O FORMULÁRIO DE  HISTÓRICOS PROCESSADOS

        '---------------------------------------------------------------------------------------------------------------

























    End Sub
















































End Module
