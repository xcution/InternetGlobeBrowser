Imports Gecko




Module MODULO_GERENCIADOR_DE_ABAS


    'VARIAVEIS DE CRIAÇÃO DE ABAS

    Public V_NUMERO_DE_MOTOR_CRIADO_PARA_NOVA_ABA As Integer 'INFORMA O NUMERO DO MOTOR CRIADO PARA A NOVA ABA

























    'PROCEDIMENTOS REFERENTES AS ABAS

    Public Sub PROC_ADD_EVENTOS_EM_GECKOFX(ByVal OBJ_MOTOR_WEB_GECKOFX As Object) 'ADICIONA EVENTOS NO MOTOR WEB GECKOFX
        On Error Resume Next


        'ADICIONA OS EVENTOS NO MOTOR GECKOFX ----------------------------------------------------------------------------------------------------------------------------------------------------------------------

        AddHandler DirectCast(OBJ_MOTOR_WEB_GECKOFX, Gecko.GeckoWebBrowser).ShowContextMenu, AddressOf PROC_BOTAO_DIREITO_DO_MOUSE_GECKOFX_EXIBIR_MENU 'EVENTO DO BOTAO DIREITO DO MOUSE
        AddHandler DirectCast(OBJ_MOTOR_WEB_GECKOFX, Gecko.GeckoWebBrowser).DocumentCompleted, AddressOf PROC_DOCUMENTO_COMPLETO_GECKOFX 'DOCUMENTO COMPLETO GECKOFX
        AddHandler DirectCast(OBJ_MOTOR_WEB_GECKOFX, Gecko.GeckoWebBrowser).DomMouseDown, AddressOf PROC_BOTAO_CENTRAL_DO_MOUSE_GECKOFX_MOUSE_DOWN 'BOTÃO DIREITO TO MOUSE
        AddHandler DirectCast(OBJ_MOTOR_WEB_GECKOFX, Gecko.GeckoWebBrowser).ProgressChanged, AddressOf PROC_CARREGANDO_A_PAGINA_EXIBIR_PROGRESSO 'EXIBE O PROGRESSO DE CARREGAMENTO DA PÁGINA
        AddHandler DirectCast(OBJ_MOTOR_WEB_GECKOFX, Gecko.GeckoWebBrowser).DomClick, AddressOf PROC_CLICAR_NO_MOTOR_GECKOFX 'AO CLICAR NO MOTOR GECKOFX
        AddHandler DirectCast(OBJ_MOTOR_WEB_GECKOFX, Gecko.GeckoWebBrowser).CreateWindow, AddressOf PROC_EVENTO_DE_NOVA_POP_UP_OU_NOVA_JANELA 'NOVA JANELA OU NOVA POP-UP
        AddHandler DirectCast(OBJ_MOTOR_WEB_GECKOFX, Gecko.GeckoWebBrowser).DomMouseMove, AddressOf PROC_EVENTO_MOVER_O_MOUSE_SOBRE_A_PAGINA 'EVENTO MOVER O MOUSE SOBRE A PÁGINA
        AddHandler DirectCast(OBJ_MOTOR_WEB_GECKOFX, Gecko.GeckoWebBrowser).CreateWindow2, AddressOf PROC_EVENTO_DE_NOVA_POP_UP_BLOQUEADOR_DE_JANELA 'ESTE EVENTO BLOQUEIA OU NÃO A POPUP
        AddHandler DirectCast(OBJ_MOTOR_WEB_GECKOFX, Gecko.GeckoWebBrowser).DomKeyUp, AddressOf PROC_PRESSIONAR_TECLAS_SOBRE_O_MOTOR_EM_USO 'EVENTO PRESSIONAR TECLAS SOBRE O MOTOR EM USO
        AddHandler DirectCast(OBJ_MOTOR_WEB_GECKOFX, Gecko.GeckoWebBrowser).Navigating, AddressOf PROC_EVENTO_NAVIGATING 'EVENTO NAVIGATING DO MOTOR GECKOFX








        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'NÃO PERMITE MENUS PADRÃO --------------------------------------------------------------------------------------

        DirectCast(OBJ_MOTOR_WEB_GECKOFX, Gecko.GeckoWebBrowser).NoDefaultContextMenu = True 'DESABILITA

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_NOVA_ABA_ADICIONAR() 'ADICIONA NOVA ABA
        On Error Resume Next

        Dim OBJ_FORMULARIO As New FRM_FORMULARIO_WEB_BASICO 'NOVO FORMULÁRIO DO WINDOWS QUE CONTÉM O MOTOR GECKOFX






        'ADICIONANDO O MOTOR ------------------------------------------------------------------------------------------------------------------

        OBJ_FORMULARIO.BackColor = Color.White 'FUNDO BRANCO

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.TabPages.Add(OBJ_FORMULARIO) 'NOVA ABA DO NAVEGADOR

        PROC_NAVEGAR(V_PASTA_DE_ARQUIVO_DE_INICIO_DE_PAGINA_DE_INICIO) 'NAVEGA NO ENDEREÇO DE SITE INFORMADO

        '--------------------------------------------------------------------------------------------------------------------------------------




        'FOCA A BARRA DE ENDEREÇOS AGORA ------------------------------------------------------------------------------------------------------

        PROC_FOCAR_A_BARRA_DE_ENDERECOS(0) 'FOCA NA BARRA DE ENDEREÇOS

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_REMOVE_ABA() 'REMOVE A ABA
        On Error Resume Next


        'REMOVE A ABA EM SELEÇÃO ---------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.TabPages.Remove(FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TAB_ABAS.TabPages.SelectedTab) 'REMOVENDO A ABA

        '---------------------------------------------------------------------------------------------------------------


    End Sub





























End Module
