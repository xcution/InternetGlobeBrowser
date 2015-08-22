Imports Gecko




Public Class FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL


    'PROCEDIMENTOS LOCAIS

    Public Sub PROC_MENU_HISTORICO_EXIBIR_TODOS_FORM_PRINCIPAL(ByVal V_EXIBIR_AS_DATAS_DE_HISTORICO As Boolean) 'EXIBE TODOS OS HISTORICOS
        On Error Resume Next


        'FECHANDO FORMULARIOS DE TRABALHO SECUNDÁRIO ---------------------------------------------------------------------------------------------------------------------------------------------

        PROC_FECHAR_FORMULARIOS_DE_TRABALHO_SECUNDARIO() 'FECHA TODOS OS FORMULARIOS DE TRABALHO SECUNDÁRIO

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'LIMPA O TEXTO ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        CBO_ENDERECO_DO_SITE.Text = Nothing 'LIMPANDO

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'CRIANDO FILTRO DE EXIBIÇÃO DE HISTÓRICO -------------------------------------------------------------------------------------------------------------------------------------------------

        V_FILTRO_DE_EXIBICAO_DE_HISTORICO_DE_SITES_VISITADOS = Nothing 'FILTRO DE EXTENÇÃO DE EXIBIÇÃO DE HISTÓRICO DE SITES

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'PROCESSANDO HISTORICO DE NAVEGAÇÃO ------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_PROCESSAR_HISTORICO_DE_NAVEGACAO_DE_USUARIO() 'PROCESSA O HISTORICO DE NAVEGAÇAO FEITA PELO USUÁRIO

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'EXIBINDO O FORMULARIO -------------------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_EXIBIR_O_FORMULARIO_DE_HISTORICOS_PROCESSADOS() 'EXIBE O FORMULÁRIO DE HISTÓRICOS PROCESSADOS

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA SE EXIBE O HISTÓRICO POR DATAS TAMBÉM ------------------------------------------------------------------------------------------------------------------------------------------

        If (V_EXIBIR_AS_DATAS_DE_HISTORICO = False) Then

            Exit Sub 'SAINDO

        End If

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'EXIBE O PAINEL DE ACOES SOBRE O HISTORICO -----------------------------------------------------------------------------------------------------------------------------------------------

        PN_HISTORICO.Visible = True 'EXIBINDO

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'PAINEL PRINCIPAL OCUPAR REGIAO DIREITA DO FORMULARIO ------------------------------------------------------------------------------------------------------------------------------------

        PN_PRINCIPAL.Dock = DockStyle.Right 'OCUPAR REGIAO DIREITA

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'EXIBIR PAINEL DE HISTORICO EM PREENCHIMENTO COMPLETO ------------------------------------------------------------------------------------------------------------------------------------

        PN_HISTORICO.Dock = DockStyle.Fill 'OCUPA TODA A ÁREA

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'EXIBE AGORA O HISTÓRICO ORGANIZADO ------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_EXIBIR_HISTORICO_ORGANIZADO_EM_FRM_PRINCIPAL_PAINEL() 'EXIBE NO PAINEL DE HISTORICO DE FORMULARIO PRINCIPAL, O HISTÓRICO ORGANIZADO

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




    End Sub

    Private Sub PROC_INCREMENTA_ITEM_A_POP_UP_FORM_PRINCIPAL() 'INCREMENTA O ITEM A POP-UP
        On Error Resume Next

        Dim V_LISTA_DE_HOSTS_POP_UP As String = FUNC_LER_ARQUIVO(V_ARQUIVO_END_15) 'LENDO A LISTA DE POP-UPS






        'VERIFICA SE O VALOR DA LISTA ESTÁ EM BRANCO -------------------------------------------------------------------

        If (V_LISTA_DE_HOSTS_POP_UP.Length = Nothing) Then

            V_LISTA_DE_HOSTS_POP_UP = "" 'VALOR NÃO NULO

        End If

        '---------------------------------------------------------------------------------------------------------------




        'ATUALIZANDO A LISTA ---------------------------------------------------------------------------------------------------

        If (V_LISTA_DE_HOSTS_POP_UP.Contains(CBO_POP_UPS.Text) = False) Then

            V_LISTA_DE_HOSTS_POP_UP = V_LISTA_DE_HOSTS_POP_UP & CBO_POP_UPS.Text & V_SEPARADOR_DE_STRINGS 'ATUALIZANDO

        End If

        '-----------------------------------------------------------------------------------------------------------------------




        'SALVANDO --------------------------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(V_LISTA_DE_HOSTS_POP_UP, V_ARQUIVO_END_15) 'SALVANDO

        CBO_POP_UPS.Items.Remove(CBO_POP_UPS.Text) 'REMOVENDO ITEM DA LISTA

        CBO_POP_UPS.Text = Nothing 'LIMPA TEXTO

        '-----------------------------------------------------------------------------------------------------------------------




        'OCULTA O PAINEL, E SALVA A CONFIGURAÇÃO ABAIXO QUE PERMITE ABRIR OS SITES DA LISTA ----------------------------

        PN_POP_UPS.Visible = False 'OCULTANDO

        PROC_SALVAR_ARQUIVO(True, V_ARQUIVO_END_9) 'SALVANDO A CONFIGURAÇÃO

        PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_8) 'SALVANDO A CONFIGURAÇÃO

        PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_7) 'SALVANDO A CONFIGURAÇÃO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    































    Private Sub NovaAbaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovaAbaToolStripMenuItem.Click
        On Error Resume Next

        PROC_NOVA_ABA_ADICIONAR() 'ADICIONA NOVA ABA

    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        On Error Resume Next

        PROC_NOVA_ABA_ADICIONAR() 'ADICIONA NOVA ABA

    End Sub

    Private Sub RemoverAbaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoverAbaToolStripMenuItem.Click
        On Error Resume Next

        PROC_REMOVE_ABA() 'REMOVE A ABA

    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBO_ENDERECO_DO_SITE.KeyDown
        On Error Resume Next


        'CRIANDO FILTRO DE EXIBIÇÃO DE HISTÓRICO -----------------------------------------------------------------------------------------------------------------------------------------

        V_FILTRO_DE_EXIBICAO_DE_HISTORICO_DE_SITES_VISITADOS = CBO_ENDERECO_DO_SITE.Text 'FILTRO DE EXTENÇÃO DE EXIBIÇÃO DE HISTÓRICO DE SITES

        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'VERIFICA SE ENTER FOI PRESSIONADO E NAVEGA --------------------------------------------------------------------------------------------------------------------------------------

        If (e.KeyCode = Keys.Enter) Then




            'SEM BEEP E ABRINDO ENDEREÇO -------------------------------------------------------------------------------------------------------------------------------------------------

            e.SuppressKeyPress = True 'SEM BEEP

            PROC_NAVEGAR(CBO_ENDERECO_DO_SITE.Text) 'NAVEGA NO ENDEREÇO DE SITE INFORMADO

            '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'LIMPANDO O FILTRO -----------------------------------------------------------------------------------------------------------------------------------------------------------

            V_FILTRO_DE_EXIBICAO_DE_HISTORICO_DE_SITES_VISITADOS = Nothing 'LIMPANDO

            '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        Else




            'PROCESSANDO HISTORICO DE NAVEGAÇÃO ------------------------------------------------------------------------------------------------------------------------------------------

            PROC_PROCESSAR_HISTORICO_DE_NAVEGACAO_DE_USUARIO() 'PROCESSA O HISTORICO DE NAVEGAÇAO FEITA PELO USUÁRIO

            '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'EXIBINDO O FORMULARIO -------------------------------------------------------------------------------------------------------------------------------------------------------

            PROC_EXIBIR_O_FORMULARIO_DE_HISTORICOS_PROCESSADOS() 'EXIBE O FORMULÁRIO DE HISTÓRICOS PROCESSADOS

            '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        End If

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        On Error Resume Next

        PROC_ACOES_BASICAS_AVANCAR_VOLTAR_ATUALIZAR_ETC(3) 'VOLTAR, AVANÇAR, ETC.

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        On Error Resume Next

        PROC_ACOES_BASICAS_AVANCAR_VOLTAR_ATUALIZAR_ETC(4) 'VOLTAR, AVANÇAR, ETC.

    End Sub

    Private Sub VoltarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoltarToolStripMenuItem.Click
        On Error Resume Next

        PROC_ACOES_BASICAS_AVANCAR_VOLTAR_ATUALIZAR_ETC(1) 'VOLTAR, AVANÇAR, ETC.

    End Sub

    Private Sub AvançarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvançarToolStripMenuItem.Click
        On Error Resume Next

        PROC_ACOES_BASICAS_AVANCAR_VOLTAR_ATUALIZAR_ETC(2) 'VOLTAR, AVANÇAR, ETC.

    End Sub

    Private Sub VoltarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoltarToolStripMenuItem1.Click
        On Error Resume Next

        PROC_ACOES_BASICAS_AVANCAR_VOLTAR_ATUALIZAR_ETC(1) 'VOLTAR, AVANÇAR, ETC.

    End Sub

    Private Sub AvançarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvançarToolStripMenuItem1.Click
        On Error Resume Next

        PROC_ACOES_BASICAS_AVANCAR_VOLTAR_ATUALIZAR_ETC(2) 'VOLTAR, AVANÇAR, ETC.

    End Sub

    Private Sub MNU_BARRA_DE_MENUS_MenuActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNU_BARRA_DE_MENUS.MenuActivate
        On Error Resume Next

        PROC_EXIBIR_OPCOES_DE_MENU_CORRETAMENTE() 'EXIBE AS OPÇÕES DE MENU CORRETAMENTE

        PROC_OPCOES_DE_MENU_DE_FORMULARIO_PRINCIPAL_BARRA_DE_MENUS() 'AQUI FICAM AS OPÇÕES DE MENU DO FORMULARIO PRINCIPAL

    End Sub

    Private Sub FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next


        'CARREGANDO AS CONFIGURAÇÕES -----------------------------------------------------------------------------------

        PROC_CARREGAR_E_INICIALIZAR_AS_CONFIGURACOES() 'CARREGA E INICIALIZA AS CONFIGURAÇÕES

        '---------------------------------------------------------------------------------------------------------------




        'APLICA O FADIN ------------------------------------------------------------------------------------------------

        V_PAUSAR_FADIN = True 'USA O FADIN

        PROC_APLICAR_FADIN_EM_FORMULARIO(Me) 'APLICA O FADIN EM FORMULARIO

        '---------------------------------------------------------------------------------------------------------------




        'SOM DE SISTEMA ------------------------------------------------------------------------------------------------

        PROC_EXIBIR_SOM_DE_SISTEMA(0) 'EXIBE OS SONS INSTALADOS NO SISTEMA

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PararToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PararToolStripMenuItem1.Click
        On Error Resume Next

        PROC_ACOES_BASICAS_AVANCAR_VOLTAR_ATUALIZAR_ETC(3) 'VOLTAR, AVANÇAR, ETC.

    End Sub

    Private Sub PararToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PararToolStripMenuItem.Click
        On Error Resume Next

        PROC_ACOES_BASICAS_AVANCAR_VOLTAR_ATUALIZAR_ETC(3) 'VOLTAR, AVANÇAR, ETC.

    End Sub

    Private Sub RecarregarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecarregarToolStripMenuItem1.Click
        On Error Resume Next

        PROC_ACOES_BASICAS_AVANCAR_VOLTAR_ATUALIZAR_ETC(4) 'VOLTAR, AVANÇAR, ETC.

    End Sub

    Private Sub RecarregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecarregarToolStripMenuItem.Click
        On Error Resume Next

        PROC_ACOES_BASICAS_AVANCAR_VOLTAR_ATUALIZAR_ETC(4) 'VOLTAR, AVANÇAR, ETC.

    End Sub

    Private Sub AbrirPáginaNoHDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirPáginaNoHDToolStripMenuItem.Click
        On Error Resume Next

        PROC_ABRIR_PAGINA_SALVA_NO_HD() 'ABRE A PÁGINA SALVA NO HD

    End Sub

    Private Sub SalvarPáginaNoHDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarPáginaNoHDToolStripMenuItem.Click
        On Error Resume Next

        PROC_SALVAR_PAGINA_NO_HD() 'SALVA A PÁGINA NO HD

    End Sub

    Private Sub VisualizarImpressãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisualizarImpressãoToolStripMenuItem.Click
        On Error Resume Next

        PROC_VISUALIZAR_IMPRESSAO_OU_IMPRIMIR(False) 'VISUALIZAR IMPRESSÃO OU IMPRIME

    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        On Error Resume Next

        PROC_VISUALIZAR_IMPRESSAO_OU_IMPRIMIR(True) 'VISUALIZAR IMPRESSÃO OU IMPRIME

    End Sub

    Private Sub PRT_IMPRIMIR_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PRT_IMPRIMIR.PrintPage
        On Error Resume Next


        'Modo paisagem ativado -----------------------------------------------------------------------------------------

        e.PageSettings.Landscape = True 'Modo ativado

        '---------------------------------------------------------------------------------------------------------------




        'Verificando contador de paginas -------------------------------------------------------------------------------

        If (V_CONTADOR_DE_PAGINAS_A_IMPRIMIR = V_QUANTIDADE_DE_ITENS_VISUALIZAR_IMPRESSAO) Then


            e.HasMorePages = False 'Nao usar mais paginas


            'Limpar itens usados ---------------------------------------------------------------------------------------

            V_QUANTIDADE_DE_ITENS_VISUALIZAR_IMPRESSAO = 0 'Zerando...

            V_CONTADOR_DE_PAGINAS_A_IMPRIMIR = 0 'Zerando...

            '-----------------------------------------------------------------------------------------------------------


            Exit Sub 'Saindo...


        End If

        '---------------------------------------------------------------------------------------------------------------




        'Obtendo imagem da lista --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        Dim OBJ_IMG_TEMP_IMPRIMIR_VISUALIZAR_IMPRESSAO As Image = Image.FromFile(V_PASTA_DE_CONFIGURACOES_END_IMPRIMIR & "\" & V_NOME_GENERICO_DE_IMAGENS_DE_IMPRESSAO & V_CONTADOR_DE_PAGINAS_A_IMPRIMIR & V_EXTENCAO_DE_ARQUIVO_3) 'Obtendo...

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Montando coordenadas da imagem -----------------------------------------------------------------------------------------------------------------------------------------------------

        Dim x As Integer = e.MarginBounds.X + (e.MarginBounds.Width - OBJ_IMG_TEMP_IMPRIMIR_VISUALIZAR_IMPRESSAO.Width) \ 2 'Montando coordenadas

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Gerando grafico de impressao ----------------------------------------------------------------------------------

        e.Graphics.DrawImage(OBJ_IMG_TEMP_IMPRIMIR_VISUALIZAR_IMPRESSAO, x, 0) 'Gerando grafico

        '---------------------------------------------------------------------------------------------------------------




        'Proxima pagina ----------------------------

        e.HasMorePages = True 'Proxima pagina

        '-------------------------------------------




        'Atualizando contador ------------------------------------------------------------------------------------------

        V_CONTADOR_DE_PAGINAS_A_IMPRIMIR = V_CONTADOR_DE_PAGINAS_A_IMPRIMIR + 1 'Atualizando...

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub NovaAbaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovaAbaToolStripMenuItem1.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(1) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub AbaAtualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbaAtualToolStripMenuItem.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(2) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub CopiarImagemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarImagemToolStripMenuItem.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(3) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub CopiarImagemToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarImagemToolStripMenuItem1.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(4) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub CopiarEndereçodeImagemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarEndereçodeImagemToolStripMenuItem.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(5) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub CopiarImagemToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarImagemToolStripMenuItem2.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(4) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub CopiarEndereçoDeImagemToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarEndereçoDeImagemToolStripMenuItem1.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(5) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub SalvarComoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarComoToolStripMenuItem.Click
        On Error Resume Next

        PROC_SALVAR_PAGINA_NO_HD() 'SALVA A PÁGINA NO HD

    End Sub

    Private Sub SelecionarTudoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelecionarTudoToolStripMenuItem.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(6) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub CódigofonteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CódigofonteToolStripMenuItem.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(7) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub PropriedadesDaPáginaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropriedadesDaPáginaToolStripMenuItem.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(8) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub TirarFotoDoSiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TirarFotoDoSiteToolStripMenuItem.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(9) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub DesfazerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesfazerToolStripMenuItem1.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(10) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub DesfazerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesfazerToolStripMenuItem.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(10) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub RefazerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefazerToolStripMenuItem1.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(11) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub RefazerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefazerToolStripMenuItem.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(11) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub RecortarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecortarToolStripMenuItem.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(12) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub RecortarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecortarToolStripMenuItem1.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(12) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub CopiarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItem1.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(13) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub CopiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItem.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(13) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub ColarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColarToolStripMenuItem.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(14) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub ColarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColarToolStripMenuItem1.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(14) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub ExcluirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripMenuItem1.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(15) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub ExcluirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripMenuItem.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(15) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub SelecionarTudoToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelecionarTudoToolStripMenuItem2.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(16) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub SelecionarTudoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelecionarTudoToolStripMenuItem1.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(16) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub PainelDeControleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PainelDeControleToolStripMenuItem.Click
        On Error Resume Next

        PROC_CHAMAR_PAINEL_DE_CONTROLE() 'CHAMA O PAINEL DE CONTROLE

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        On Error Resume Next

        PROC_ABRIR_PAGINA_INICIAL() 'ABRE A PÁGINA INICIAL

    End Sub

    Private Sub PáginaInícialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PáginaInícialToolStripMenuItem.Click
        On Error Resume Next

        PROC_ABRIR_PAGINA_INICIAL() 'ABRE A PÁGINA INICIAL

    End Sub

    Private Sub PáginainícialToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PáginainícialToolStripMenuItem1.Click
        On Error Resume Next

        PROC_ABRIR_PAGINA_INICIAL() 'ABRE A PÁGINA INICIAL

    End Sub

    Private Sub CódigofonteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CódigofonteToolStripMenuItem1.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(7) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub ExibirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExibirToolStripMenuItem1.Click
        On Error Resume Next


        'SALVANDO ------------------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(True, V_ARQUIVO_END_10) 'SALVA O ARQUIVO

        PROC_CARREGAR_PREFERENCIAS_DO_NAVEGADOR() 'CARREGAR AS PREFERENCIAS DO NAVEGADOR

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub NãoExibirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NãoExibirToolStripMenuItem.Click
        On Error Resume Next


        'SALVANDO ------------------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_10) 'SALVA O ARQUIVO

        PROC_CARREGAR_PREFERENCIAS_DO_NAVEGADOR() 'CARREGAR AS PREFERENCIAS DO NAVEGADOR

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub ExibirToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExibirToolStripMenuItem2.Click
        On Error Resume Next


        'SALVANDO ------------------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(True, V_ARQUIVO_END_11) 'SALVA O ARQUIVO

        PROC_CARREGAR_PREFERENCIAS_DO_NAVEGADOR() 'CARREGAR AS PREFERENCIAS DO NAVEGADOR

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub NãoExibirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NãoExibirToolStripMenuItem1.Click
        On Error Resume Next


        'SALVANDO ------------------------------------------------------------------------------------------------------

        PROC_SALVAR_ARQUIVO(False, V_ARQUIVO_END_11) 'SALVA O ARQUIVO

        PROC_CARREGAR_PREFERENCIAS_DO_NAVEGADOR() 'CARREGAR AS PREFERENCIAS DO NAVEGADOR

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub FavorítoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FavorítoToolStripMenuItem.Click
        On Error Resume Next

        PROC_CHAMAR_MEUS_FAVORITOS(2) 'CHAMA A JANELA DE MEUS FAVORÍTOS

    End Sub

    Private Sub TOL_TODOS_OS_FAVORITOS_DropDownOpening(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOL_TODOS_OS_FAVORITOS.DropDownOpening
        On Error Resume Next


        'LISTA FAVORITOS E PASTAS --------------------------------------------------------------------------------------------------------------

        PROC_FAVORITOS_LISTAR_TODOS_SALVOS(sender, V_PASTA_DE_MEUS_FAVORITOS_END) 'LISTA TODOS OS ARQUIVOS DE FAVORITOS

        PROC_FAVORITOS_LISTAR_TODOS(V_PASTA_DE_MEUS_FAVORITOS_END, sender, False) 'LISTA TODOS OS FAVORITOS

        '---------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub TOL_TODOS_OS_FAVORITOS_DropDownClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOL_TODOS_OS_FAVORITOS.DropDownClosed
        On Error Resume Next


        'LIMPA TODOS OS SUBITENS AO SAIR DO MENU -----------------------------------------------------------------------

        TOL_TODOS_OS_FAVORITOS.DropDownItems.Clear() 'LIMPANDO...

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub ExcluirFavorítoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirFavorítoToolStripMenuItem.Click
        On Error Resume Next

        PROC_REMOVE_PASTA_DE_FAV_OU_O_FAVORITO() 'REMOVE O FAVORITO OU A PASTA

    End Sub

    Private Sub ExcluirPastaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirPastaToolStripMenuItem.Click
        On Error Resume Next

        PROC_REMOVE_PASTA_DE_FAV_OU_O_FAVORITO() 'REMOVE O FAVORITO OU A PASTA

    End Sub

    Private Sub RenomearFavorítoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenomearFavorítoToolStripMenuItem.Click
        On Error Resume Next

        PROC_RENOMEAR_PASTA_DE_FAV_OU_O_FAVORITO() 'RENOMEIA O FAVORITO OU A PASTA

    End Sub

    Private Sub RenomearPastaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenomearPastaToolStripMenuItem.Click
        On Error Resume Next

        PROC_RENOMEAR_PASTA_DE_FAV_OU_O_FAVORITO() 'RENOMEIA O FAVORITO OU A PASTA

    End Sub

    Private Sub AbrirEmNovaAbaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirEmNovaAbaToolStripMenuItem.Click
        On Error Resume Next

        PROC_ABRIR_FAVORITO_TOL_MENU_MODULO_MANIPULADOR_DE_ARQUIVOS() 'ABRE O FAVORITO INFORMADO NO TOL MENU

    End Sub

    Private Sub ExportarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarToolStripMenuItem.Click
        On Error Resume Next

        PROC_CHAMAR_MEUS_FAVORITOS(1) 'CHAMA A JANELA DE MEUS FAVORÍTOS

    End Sub

    Private Sub RemoverTudoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoverTudoToolStripMenuItem.Click
        On Error Resume Next

        PROC_REMOVE_PASTA_COMPLETA_COM_SUB_PASTAS(V_PASTA_DE_MEUS_FAVORITOS_END, True) 'REMOVE TODA A PASTA INCLUINDO ARQUIVOS

    End Sub

    Private Sub NormalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalToolStripMenuItem.Click
        On Error Resume Next

        PROC_ZOOM_NO_TEXTO(100) 'APLICA O ZOOM NO TEXTO

    End Sub

    Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem16.Click
        On Error Resume Next

        PROC_ZOOM_NO_TEXTO(25) 'APLICA O ZOOM NO TEXTO

    End Sub

    Private Sub ToolStripMenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem17.Click
        On Error Resume Next

        PROC_ZOOM_NO_TEXTO(50) 'APLICA O ZOOM NO TEXTO

    End Sub

    Private Sub ToolStripMenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem21.Click
        On Error Resume Next

        PROC_ZOOM_NO_TEXTO(75) 'APLICA O ZOOM NO TEXTO

    End Sub

    Private Sub ToolStripMenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem18.Click
        On Error Resume Next

        PROC_ZOOM_NO_TEXTO(100) 'APLICA O ZOOM NO TEXTO

    End Sub

    Private Sub ToolStripMenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem19.Click
        On Error Resume Next

        PROC_ZOOM_NO_TEXTO(125) 'APLICA O ZOOM NO TEXTO

    End Sub

    Private Sub ToolStripMenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem20.Click
        On Error Resume Next

        PROC_ZOOM_NO_TEXTO(150) 'APLICA O ZOOM NO TEXTO

    End Sub

    Private Sub ToolStripMenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem22.Click
        On Error Resume Next

        PROC_ZOOM_NO_TEXTO(175) 'APLICA O ZOOM NO TEXTO

    End Sub

    Private Sub ToolStripMenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem23.Click
        On Error Resume Next

        PROC_ZOOM_NO_TEXTO(200) 'APLICA O ZOOM NO TEXTO

    End Sub

    Private Sub CorDaAbaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorDaAbaToolStripMenuItem1.Click
        On Error Resume Next

        PROC_ALTERAR_A_COR_DA_ABA() 'ALTERAR A COR DA ABA

    End Sub

    Private Sub CorDaLetraDaAbaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorDaLetraDaAbaToolStripMenuItem.Click
        On Error Resume Next

        PROC_ALTERAR_A_COR_DO_TEXTO_DA_ABA() 'ALTERAR A COR DO TEXTO DA ABA

    End Sub

    Private Sub RestaurarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestaurarToolStripMenuItem.Click
        On Error Resume Next

        PROC_RESTAURAR_A_COR_NATUAL_DA_ABA() 'RESTAURA A COR NATURAL DA ABA

    End Sub

    Private Sub ExibirDownloadsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExibirDownloadsToolStripMenuItem.Click
        On Error Resume Next

        PROC_RODAR_GERENCIADORES_DE_DOWNLOAD(Nothing) 'RODA OS GERENCIADORES DE DOWNLOAD

    End Sub

    Private Sub BaixarArquivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaixarArquivoToolStripMenuItem.Click
        On Error Resume Next

        PROC_RODAR_GERENCIADORES_DE_DOWNLOAD(V_URL_ASSOCIADA_AO_MENU_DE_LINKS_MODULO_DE_EVENTOS) 'RODA OS GERENCIADORES DE DOWNLOAD

    End Sub

    Private Sub FRM_NAVEGACAO_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next


        'RESTAURA VALOR DE CANCELA OU NÃO ------------------------------------------------------------------------------

        V_PODE_SAIR_DA_SESSAO_ATUAL = False 'INFORMA QUE PODE SAIR

        '---------------------------------------------------------------------------------------------------------------




        'SALVA A SESSAO ------------------------------------------------------------------------------------------------

        PROC_CHAMAR_SALVAR_JANELAS_ABERTAS() 'CHAMAR O SALVAR JANELAS ABERTAS

        '---------------------------------------------------------------------------------------------------------------




        'FECHANDO FORMULARIOS DE TRABALHO SECUNDÁRIO ---------------------------------------------------------------------------------------------------------------------------------------------

        If (V_PODE_SAIR_DA_SESSAO_ATUAL = False) Then




            'REMOVE EVENTOS NECESSÁRIOS E SAI DO APLICATIVO --------------------------------------------------------------------------------------------------------------------------------------

            RemoveHandler TAB_ABAS.SelectedTabChanged, AddressOf TAB_ABAS_SELECIONAR_OUTRA_ABA 'AO SELECIONAR OUTRA ABA EXECUTAR ESTE EVENTO

            Me.Dispose() 'LIMPANDO FORMULÁRIO

            Application.Exit() 'SAINDO DO APLICATIVO

            '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'SAI, PORÉM SE HOUVER PROBLEMAS REMOVER ESTA LINHA DE CÓDIGO -------------------------------------------------------------------------------------------------------------------------

            End 'AGORA PODE SAIR RÁPIDO: *SE ARQUIVOS ESTIVEREM CORROMPENDO REMOVA ESTA LINHA*

            '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        End If

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'CANCELA OU NÃO A SAIDA ----------------------------------------------------------------------------------------

        e.Cancel = V_PODE_SAIR_DA_SESSAO_ATUAL 'CANCELA OU NÃO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub FRM_NAVEGACAO_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        On Error Resume Next


        'DEFINE O MOTOR DE AÇÃO DE USO -------------------------------------------------------------------------------------------------------------

        PROC_DEFINE_MOTOR_DE_ACAO_EM_USO(TAB_ABAS.SelectedForm.Controls.Item(0)) 'DEFINE O MOTOR DE AÇÃO EM USO

        '-------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        On Error Resume Next

        PROC_CHAMAR_JANELA_GERADORA_DE_IMAGENS_DE_ABAS() 'JANELA GERADORA DE IMAGENS DE ABAS

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        On Error Resume Next

        PROC_MENU_HISTORICO_EXIBIR_TODOS_FORM_PRINCIPAL(False) 'EXIBE TODOS OS HISTORICOS

    End Sub

    Private Sub LeitorDeTextoscomVózToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeitorDeTextoscomVózToolStripMenuItem.Click
        On Error Resume Next

        PROC_CHAMAR_LEITOR_DE_TEXTOS_COM_VOZ(Nothing) 'CHAMA O LEITOR DE TEXTOS COM VOZ

    End Sub

    Private Sub TRV_BOTOES_ItemClicked(ByVal sender As System.Object, ByVal e As WinUI.Controls.TravelButtonItemClickedEventArgs) Handles TRV_BOTOES.ItemClicked
        On Error Resume Next

        'VOLTAR --------------------------------------------------------------------------------------------------------

        If (e.ClickedItem = WinUI.Controls.TravelButtonItem.BackButton) Then


            PROC_ACOES_BASICAS_AVANCAR_VOLTAR_ATUALIZAR_ETC(1) 'VOLTAR, AVANÇAR, ETC.


        End If

        '---------------------------------------------------------------------------------------------------------------




        'AVANÇAR -------------------------------------------------------------------------------------------------------

        If (e.ClickedItem = WinUI.Controls.TravelButtonItem.ForwardButton) Then


            PROC_ACOES_BASICAS_AVANCAR_VOLTAR_ATUALIZAR_ETC(2) 'VOLTAR, AVANÇAR, ETC.


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub InteligênciaDeProcessamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InteligênciaDeProcessamentoToolStripMenuItem.Click
        On Error Resume Next

        PROC_CHAMAR_JANELA_DE_INTELIGENCIA_DE_PROCESSAMENTO() 'CHAMA A JANELA DE INTELIGENCIA DE PROCESSAMENTO

    End Sub

    Private Sub CBO_ENDERECO_DO_SITE_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CBO_ENDERECO_DO_SITE.MouseClick
        On Error Resume Next


        'VERIFICA SE USA O RECURSO DE AUTO-COMPLETAR -----------------------------------------------------------------------------------------------------------------

        PROC_VERIFICA_SE_USA_O_RECURSO_AUTO_COMPLETAR_NORMAL_E_IMAGENS() 'VERIFICA SE USA O RECURO DE AUTO-COMPLETAR NORMAL E IMAGENS

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'PERMITE AUTO-CLOSE ------------------------------------------------------------------------------------------------------------------------------------------

        OBJ_MENU_DE_CONTEXTO.AutoClose = True 'AUTO-CLOSE

        OBJ_MENU_DE_CONTEXTO.Close() 'FECHANDO MENU

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'SELECIONA TODO O TEXTO DA BARRA DE ENDEREÇOS ----------------------------------------------------------------------------------------------------------------

        If (CBO_ENDERECO_DO_SITE.SelectionStart = 0) Then

            CBO_ENDERECO_DO_SITE.SelectAll() 'SELECIONA TUDO COM DOIS CLIQUES

        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub ExcluirOHistóricoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirOHistóricoToolStripMenuItem.Click
        On Error Resume Next


        'LIMPA E FECHA CONTROLES ABERTOS ---------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_LIMPAR_ARQUIVOS_DE_HISTORICO() 'LIMPA OS ARQUIVOS DE HISTÓRICO

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub ExibirOHistóricoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExibirOHistóricoToolStripMenuItem.Click
        On Error Resume Next

        PROC_MENU_HISTORICO_EXIBIR_TODOS_FORM_PRINCIPAL(True) 'EXIBE TODOS OS HISTORICOS

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next


        'LIMPA E FECHA CONTROLES ABERTOS ---------------------------------------------------------------------------------------------------------------------------------------------------------

        PROC_LIMPAR_ARQUIVOS_DE_HISTORICO() 'LIMPA OS ARQUIVOS DE HISTÓRICO

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next

        PROC_FECHAR_O_HISTORICO_EXIBIDO_NO_FORM_PRINCIPAL() 'FECHA O HISTÓRICO EXIBIDO NO FORMULARIO PRINCIPAL

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        On Error Resume Next

        PN_POP_UPS.Visible = False 'OCULTA O PAINEL DE POP-UP

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error Resume Next

        PROC_INCREMENTA_ITEM_A_POP_UP_FORM_PRINCIPAL() 'INCREMENTA O ITEM A POP-UP

    End Sub

    Private Sub FRM_NAVEGACAO_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        On Error Resume Next

        V_PAUSAR_FADIN = False 'PERMITE USAR O FADIN

    End Sub

    Private Sub SalvarImagemToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarImagemToolStripMenuItem1.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(17) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub SalvarImagemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarImagemToolStripMenuItem.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(17) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub ModoAvançadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next



    End Sub

    Private Sub ModosimplesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next



    End Sub

    Private Sub TXT_LOCALIZAR_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_LOCALIZAR.KeyDown
        On Error Resume Next


        'BUSCA PELA SENTENÇA AO PRESSIONAR ENTER -----------------------------------------------------------------------

        If (e.KeyCode = Keys.Enter) Then


            e.SuppressKeyPress = True 'SEM BEEP

            PROC_PROCURAR_POR_TEXTO_NA_PAGINA(TXT_LOCALIZAR.Text, False) 'PROCURA E SELECIONA O TEXTO NA PÁGINA


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        On Error Resume Next

        PROC_PROCURAR_POR_TEXTO_NA_PAGINA(TXT_LOCALIZAR.Text, False) 'PROCURA E SELECIONA O TEXTO NA PÁGINA

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        On Error Resume Next

        TXT_LOCALIZAR.Clear() 'LIMPA TEXTO

        TXT_LOCALIZAR.Focus() 'MOVENDO O FOCO PARA O CAMPO

        PROC_PROCURAR_POR_TEXTO_NA_PAGINA(TXT_LOCALIZAR.Text, False) 'PROCURA E SELECIONA O TEXTO NA PÁGINA

    End Sub

    Private Sub PN_LOCALIZAR_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PN_LOCALIZAR.VisibleChanged
        On Error Resume Next


        'AO EXIBIR MOVER O FOCO PARA A CAIXA DE BUSCA ------------------------------------------------------------------

        If (PN_LOCALIZAR.Visible = True) Then


            TXT_LOCALIZAR.Focus() 'Movendo o foco


        Else


            PROC_PROCURAR_POR_TEXTO_NA_PAGINA(Nothing, True) 'PROCURA E SELECIONA O TEXTO NA PÁGINA


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        On Error Resume Next

        PN_LOCALIZAR.Visible = False 'OCULTA O RECURSO DE LOCALIZAR NA PÁGINA

    End Sub

    Private Sub LocalizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarToolStripMenuItem.Click
        On Error Resume Next

        PN_LOCALIZAR.Visible = True 'EXIBE O PAINEL DE LOCALIZAR

    End Sub

    Private Sub LocalizarpróximoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarpróximoToolStripMenuItem.Click
        On Error Resume Next


        'EXIBE O PAINEL DE LOCALIZAR -----------------------------------------------------------------------------------

        PN_LOCALIZAR.Visible = True 'EXIBE O PAINEL DE LOCALIZAR

        '---------------------------------------------------------------------------------------------------------------




        'LOCALIZA EM CASO DE HOUVER CONTEUDO NA CAIXA DE TEXTO DE LOCALIZAR --------------------------------------------

        If (TXT_LOCALIZAR.TextLength <> 0) Then


            PROC_PROCURAR_POR_TEXTO_NA_PAGINA(TXT_LOCALIZAR.Text, False) 'PROCURA E SELECIONA O TEXTO NA PÁGINA


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub TelaInteiraF11ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TelaInteiraF11ToolStripMenuItem.Click
        On Error Resume Next

        PROC_EXIBIR_TELA_CHEIA(Me) 'EXIBE EM TELA CHEIA

    End Sub

    Private Sub DefinaComoPlanoDeFundoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefinaComoPlanoDeFundoToolStripMenuItem.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(18) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub LimparToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimparToolStripMenuItem.Click
        On Error Resume Next

        PROC_LIMPAR_SENHAS_ARMAZENADAS_NO_NAVEGADOR(True) 'LIMPA AS SENHAS ARMAZENADAS NO COMPUTADOR

    End Sub

    Private Sub CancelarLimparToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarLimparToolStripMenuItem.Click
        On Error Resume Next

        PROC_LIMPAR_SENHAS_ARMAZENADAS_NO_NAVEGADOR(False) 'LIMPA AS SENHAS ARMAZENADAS NO COMPUTADOR

    End Sub

    Private Sub SenhasToolStripMenuItem_DropDownOpened(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SenhasToolStripMenuItem.DropDownOpened
        On Error Resume Next


        'EXIBE MENUS CORRETAMENTE --------------------------------------------------------------------------------------

        If (FUNC_LER_ARQUIVO(V_ARQUIVO_END_36) = True) Then


            CancelarLimparToolStripMenuItem.Enabled = True 'CANCELA

            LimparToolStripMenuItem.Enabled = False 'LIMPA


        Else


            LimparToolStripMenuItem.Enabled = True 'LIMPA

            CancelarLimparToolStripMenuItem.Enabled = False 'CANCELA


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub NovaAbaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovaAbaToolStripMenuItem2.Click
        On Error Resume Next

        PROC_NOVA_ABA_ADICIONAR() 'ADICIONA NOVA ABA

    End Sub

    Private Sub FecharAbaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharAbaToolStripMenuItem.Click
        On Error Resume Next

        PROC_REMOVE_ABA() 'REMOVE A ABA

    End Sub

    Private Sub RecarregarAbaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecarregarAbaToolStripMenuItem.Click
        On Error Resume Next

        PROC_ACOES_BASICAS_AVANCAR_VOLTAR_ATUALIZAR_ETC(4) 'VOLTAR, AVANÇAR, ETC.

    End Sub

    Private Sub AdicionaAosFavorítosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionaAosFavorítosToolStripMenuItem.Click
        On Error Resume Next

        PROC_CHAMAR_MEUS_FAVORITOS(2) 'CHAMA A JANELA DE MEUS FAVORÍTOS

    End Sub

    Private Sub GerenciarFavorítosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GerenciarFavorítosToolStripMenuItem.Click
        On Error Resume Next

        PROC_CHAMAR_MEUS_FAVORITOS(0) 'CHAMA A JANELA DE MEUS FAVORÍTOS

    End Sub

    Private Sub ReabrirAbaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReabrirAbaToolStripMenuItem.Click
        On Error Resume Next

        PROC_REABRIR_ULTIMA_ABA_MNU() 'REABRE A ÚLTIMA ABA QUE FOI ABERTA E FECHADA

    End Sub

    Private Sub MNU_ABA_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MNU_ABA.Opening
        On Error Resume Next


        'VERIFICA SE HÁ ITENS A SEREM ABERTOS --------------------------------------------------------------------------

        If (ARRAY_PILHA_DE_ABAS_QUE_FORAM_FECHADAS_PELO_USUARIO.Count = 0) Then


            ReabrirAbaToolStripMenuItem.Visible = False 'NAO


        Else


            ReabrirAbaToolStripMenuItem.Visible = True 'SIM


        End If

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub PastaDeDownloadsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PastaDeDownloadsToolStripMenuItem.Click
        On Error Resume Next

        PROC_ABRIR_PASTA_DE_DOWNLOADS() 'ABRIR A PASTA DE DOWNLOADS

    End Sub

    Private Sub PastaDeDownloadsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PastaDeDownloadsToolStripMenuItem1.Click
        On Error Resume Next

        PROC_ABRIR_PASTA_DE_DOWNLOADS() 'ABRIR A PASTA DE DOWNLOADS

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        On Error Resume Next

        PROC_NAVEGAR(CBO_ENDERECO_DO_SITE.Text) 'NAVEGA NO ENDEREÇO DE SITE INFORMADO

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        On Error Resume Next

        PN_PESQUISA.Visible = False 'OCULTA O PAINEL DE PESQUISA

    End Sub

    Private Sub TXT_PESQUISA_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_PESQUISA.KeyDown
        On Error Resume Next


        'AO PRESSIONAR ENTER PESQUISAR --------------------------------------------------------------------------------------------------------

        If (e.KeyCode = Keys.Enter) Then


            e.SuppressKeyPress = True

            PROC_PESQUISA_FEITA_PELO_USUARIO(TXT_PESQUISA.Text, CBO_SITE_DE_PESQUISA.SelectedIndex) 'PESQUISA FEITA PELO USUÁRIO


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        On Error Resume Next

        PROC_PESQUISA_FEITA_PELO_USUARIO(TXT_PESQUISA.Text, CBO_SITE_DE_PESQUISA.SelectedIndex) 'PESQUISA FEITA PELO USUÁRIO

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        On Error Resume Next

        PN_PESQUISA.Visible = True 'PAINEL DE PESQUISA

        CBO_SITE_DE_PESQUISA.SelectedIndex = 1 'SELECIONA SITE DE PESQUISA INICIAL

        TXT_PESQUISA.Focus() 'MOVE O FOCO PARA A CAIXA DE PESQUISA

    End Sub

    Private Sub FecharToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharToolStripMenuItem.Click
        On Error Resume Next

        Me.Close() 'FECHANDO O NAVEGADOR

    End Sub

    Private Sub NovajanelaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovajanelaToolStripMenuItem.Click
        On Error Resume Next

        PROC_CHAMAR_NOVA_INSTANCIA_DO_NAVEGADOR() 'CHAMA UMA NOVA INSTANCIA DO NAVEGADOR

    End Sub

    Private Sub TRV_HISTORICO_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TRV_HISTORICO.MouseDoubleClick
        On Error Resume Next


        'VERIFICA O NIVEL DE NODE E ABRE A URL -------------------------------------------------------------------------

        If (TRV_HISTORICO.SelectedNode.Level = 1) Then

            PROC_NAVEGAR(TRV_HISTORICO.SelectedNode.Tag) 'ABRINDO URL

        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub TRV_HISTORICO_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TRV_HISTORICO.KeyDown
        On Error Resume Next


        'VERIFICA O NIVEL DE NODE E ABRE A URL -------------------------------------------------------------------------

        If (TRV_HISTORICO.SelectedNode.Level = 1) And (e.KeyCode = Keys.Enter) Then


            e.SuppressKeyPress = True 'SEM BEEP

            PROC_NAVEGAR(TRV_HISTORICO.SelectedNode.Tag) 'ABRINDO URL


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub TRV_HISTORICO_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TRV_HISTORICO.AfterSelect
        On Error Resume Next


        'VERIFICA O NIVEL DE NODE E ABRE A URL ---------------------------------------------------------------------------------------------------------------------------------------------------------

        If (TRV_HISTORICO.SelectedNode.Level = 1) Then

            PROC_SELECIONAR_HISTORICO_NODE_EXIBIR_DADOS(TRV_HISTORICO.SelectedNode.ImageKey) 'AO SELECIONAR UM HISTÓRICO, FILHO DENTRO DA LISTA EXIBIR SUA IMAGEM ORIGINAL E INFORMAÇÕES.

        End If

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        On Error Resume Next


        PN_HISTORICO.Hide() 'OCULTA O PAINEL DE HISTÓRICO

        PN_PRINCIPAL.Dock = DockStyle.Fill 'PAINEL PRINCIPAL OCUPAR TODA A ÁREA


    End Sub

    Private Sub CopiarSeleçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarSeleçãoToolStripMenuItem.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(13) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub AbrirEmNovaAbaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirEmNovaAbaToolStripMenuItem1.Click
        On Error Resume Next


        'VERIFICA O NIVEL DE NODE E ABRE A URL -------------------------------------------------------------------------

        If (TRV_HISTORICO.SelectedNode.Level = 1) Then

            PROC_NOVA_ABA_ADICIONAR() 'ADICIONA UMA NOVA ABA

            PROC_NAVEGAR(TRV_HISTORICO.SelectedNode.Text) 'ABRINDO URL

        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub AbrirNaAbaAtualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirNaAbaAtualToolStripMenuItem.Click
        On Error Resume Next


        'VERIFICA O NIVEL DE NODE E ABRE A URL -------------------------------------------------------------------------

        If (TRV_HISTORICO.SelectedNode.Level = 1) Then

            PROC_NAVEGAR(TRV_HISTORICO.SelectedNode.Text) 'ABRINDO URL

        End If

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub AdicionaAosFavorítosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionaAosFavorítosToolStripMenuItem1.Click
        On Error Resume Next


        'VERIFICA NÍVEL DE NODE E SALVA COMO NOVO FAVORITO -----------------------------------------------------------------------------------------------------------

        If (TRV_HISTORICO.SelectedNode.Level = 1) Then

            PROC_ADD_HISTORICO_AOS_FAVORITOS(TRV_HISTORICO.SelectedNode.Tag, TRV_HISTORICO.SelectedNode.Text) 'ADICIONA O HISTÓRICO AOS FAVORITOS

        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub ExibirTodosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExibirTodosToolStripMenuItem.Click
        On Error Resume Next

        PROC_CHAMAR_A_JANELA_DE_PLUGINS_INSTALADOS(0) 'CHAMA A JANELA DE PLUGINS INSTALADOS

    End Sub

    Private Sub ExibirTodosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExibirTodosToolStripMenuItem1.Click
        On Error Resume Next

        PROC_CHAMAR_A_JANELA_DE_PLUGINS_INSTALADOS(1) 'CHAMA A JANELA DE PLUGINS INSTALADOS

    End Sub

    Private Sub AplicativosToolStripMenuItem1_DropDownOpening(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AplicativosToolStripMenuItem1.DropDownOpening
        On Error Resume Next

        PROC_LISTE_OS_APLICATIVOS_NO_MENU_DE_APLICATIVOS(RápidoToolStripMenuItem) 'LISTA OS APLICATIVOS NO MENU DE PLUGINS

    End Sub

    Private Sub EditarImagemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarImagemToolStripMenuItem.Click
        On Error Resume Next

        PROC_EDITAR_IMAGEM_COM_APLICATIVO_EDITOR_DE_IMAGENS() 'EDITAR A IMAGEM COM O APLICATIVO EDITOR DE IMAGENS

    End Sub

    Private Sub DefinaComoPlanoDeFundoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefinaComoPlanoDeFundoToolStripMenuItem1.Click
        On Error Resume Next

        PROC_MENU_ACAO_EXECUTAR(18) 'AÇÃO DO MENU DO BOTAO DIREITO

    End Sub

    Private Sub TOL_ABAS_ABERTAS_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOL_ABAS_ABERTAS.ButtonClick
        On Error Resume Next

        PROC_OBTENHA_DADOS_BASICOS_SOBRE_TODAS_AS_ABAS_ABERTAS_TITULO(sender) 'OBTÉM TODOS OS DADOS BÁSICOS DE TODAS AS ABAS ABERTAS TITULO

    End Sub

    Private Sub TOL_ABAS_ABERTAS_DropDownOpening(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOL_ABAS_ABERTAS.DropDownOpening
        On Error Resume Next

        PROC_OBTENHA_DADOS_BASICOS_SOBRE_TODAS_AS_ABAS_ABERTAS_TITULO(sender) 'OBTÉM TODOS OS DADOS BÁSICOS DE TODAS AS ABAS ABERTAS TITULO

    End Sub

    Private Sub SobreOInternetGlobeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreOInternetGlobeToolStripMenuItem.Click
        On Error Resume Next

        PROC_VERSAO_DE_APLICATIVO_NAVEGADOR() 'INFORMA A VERSÃO DO APLICATIVO NAVEGADOR

    End Sub

    Private Sub AjudaOnlineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjudaOnlineToolStripMenuItem.Click
        On Error Resume Next

        PROC_ACAO_EXECUTAR_DO_MENU_DE_AJUDA(0) 'AÇÃO A SER EXECUTADA DO MENU AJUDA

    End Sub

    Private Sub NovidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovidadesToolStripMenuItem.Click
        On Error Resume Next

        PROC_ACAO_EXECUTAR_DO_MENU_DE_AJUDA(1) 'AÇÃO A SER EXECUTADA DO MENU AJUDA

    End Sub

    Private Sub VerificarAtualizaçõesNoSiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerificarAtualizaçõesNoSiteToolStripMenuItem.Click
        On Error Resume Next

        PROC_ACAO_EXECUTAR_DO_MENU_DE_AJUDA(2) 'AÇÃO A SER EXECUTADA DO MENU AJUDA

    End Sub

    Private Sub SimToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimToolStripMenuItem.Click
        On Error Resume Next

        PROC_SALVAR_CONFIGURACAO_RESTAURAR_CONFIG_DO_NAVEGADOR(True) 'CONFIGURAÇÃO PARA RESTAURAR TODAS AS CONFIGURAÇÕES DO NAVEGADOR

    End Sub

    Private Sub NãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NãoToolStripMenuItem.Click
        On Error Resume Next

        PROC_SALVAR_CONFIGURACAO_RESTAURAR_CONFIG_DO_NAVEGADOR(False) 'CONFIGURAÇÃO PARA RESTAURAR TODAS AS CONFIGURAÇÕES DO NAVEGADOR

    End Sub

    Private Sub TRV_HISTORICO_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TRV_HISTORICO.MouseClick
        On Error Resume Next

        'PERMITE AUTO-CLOSE --------------------------------------------------------------------------------------------

        OBJ_MENU_DE_CONTEXTO.AutoClose = True 'AUTO-CLOSE

        OBJ_MENU_DE_CONTEXTO.Close() 'FECHANDO MENU

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub PIC_HISTORICO_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PIC_HISTORICO.MouseClick
        On Error Resume Next

        'PERMITE AUTO-CLOSE --------------------------------------------------------------------------------------------

        OBJ_MENU_DE_CONTEXTO.AutoClose = True 'AUTO-CLOSE

        OBJ_MENU_DE_CONTEXTO.Close() 'FECHANDO MENU

        '---------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub ExibirDownloadsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExibirDownloadsToolStripMenuItem1.Click
        On Error Resume Next

        PROC_RODAR_GERENCIADORES_DE_DOWNLOAD(Nothing) 'RODA OS GERENCIADORES DE DOWNLOAD

    End Sub

    Private Sub PIC_FAVICON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PIC_FAVICON.Click
        On Error Resume Next

        PROC_INFORME_IP_DE_SITE_EM_VISUALIZACAO_E_IP_LOCAL() 'INFORMA O IP DO SITE EM VISUALIZAÇÃO E O IP DO COMPUTADOR

    End Sub

    Private Sub AdobeFlashPlayerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdobeFlashPlayerToolStripMenuItem.Click
        On Error Resume Next

        PROC_ATUALIZAR_PLUGIN_FLASH_PLAYER() 'ATUALIZA O PLUGIN FLASH PLAYER

    End Sub

    Private Sub MicrosoftSilverlightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MicrosoftSilverlightToolStripMenuItem.Click
        On Error Resume Next

        PROC_ATUALIZAR_PLUGIN_MICROSOFT_SILVERLIGHT() 'ATUALIZA O PLUGIN DO SILVERLIGHT

    End Sub

    Private Sub CBO_ENDERECO_DO_SITE_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBO_ENDERECO_DO_SITE.Enter
        On Error Resume Next


        'VERIFICA SE USA O RECURSO DE AUTO-COMPLETAR -----------------------------------------------------------------------------------------------------------------

        PROC_VERIFICA_SE_USA_O_RECURSO_AUTO_COMPLETAR_NORMAL_E_IMAGENS() 'VERIFICA SE USA O RECURO DE AUTO-COMPLETAR NORMAL E IMAGENS

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        On Error Resume Next


        'REINICIA A SESSÃO ANTERIOR, E OCULTA O PAINEL DE RESTAURAR A SESSAO -------------------------------------------

        PROC_REINICIAR_SESSAO_ANTERIOR() 'REINICIA A SESSÃO ANTERIOR

        PROC_EXIBIR_O_PAINEL_DE_RESTAURAR_SESSAO(False) 'EXIBE OU OCULTA O PAINEL DE RESTAURAR SESSÃO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        On Error Resume Next


        'REMOVE TODOS OS ARQUIVOS DE SESSÃO ----------------------------------------------------------------------------

        PROC_REMOVER_TODOS_OS_ARQUIVOS(V_PASTA_DE_ARQUIVOS_DE_SESSAO) 'REMOVE TODOS OS ARQUIVOS DA PASTA INFORMADA

        '---------------------------------------------------------------------------------------------------------------




        'ABRE A PAGINA HOME --------------------------------------------------------------------------------------------

        PROC_NOVA_ABA_ADICIONAR() 'ADICIONA NOVA ABA

        PROC_ABRIR_PAGINA_INICIAL() 'ABRE A PÁGINA INICIAL

        '---------------------------------------------------------------------------------------------------------------




        'INFORMA QUE INICOU NOVA SESSÃO, REMOVE OS ARQUIVOS ANTIGOS, E ATIVA O ALERTAR VARIAS ABAS ABERTAS -------------

        PROC_SALVOU_SESSAO_CORRETAMENTE() 'INFORMA QUE SALVOU A SESSÃO CORRETAMENTE

        PROC_SALVAR_ARQUIVO(True, V_ARQUIVO_END_3) 'SALVANDO CONFIGURAÇÃO DE ARQUIVO

        '---------------------------------------------------------------------------------------------------------------




        'OCULTA O PAINEL DE RESTAURAR A SESSÃO -------------------------------------------------------------------------

        PROC_EXIBIR_O_PAINEL_DE_RESTAURAR_SESSAO(False) 'EXIBE OU OCULTA O PAINEL DE RESTAURAR SESSÃO

        '---------------------------------------------------------------------------------------------------------------




    End Sub

    Private Sub ModosimplesToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModosimplesToolStripMenuItem.Click
        On Error Resume Next

        PROC_NOVO_DOWNLOAD_MODO_SIMPLES_OU_AGRUPADO(True) 'NOVO DOWNLOAD DEFINIDO PELO MODO SIMPLES OU AGRUPADO

    End Sub

    Private Sub ModoagrupadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModoagrupadoToolStripMenuItem.Click
        On Error Resume Next

        PROC_NOVO_DOWNLOAD_MODO_SIMPLES_OU_AGRUPADO(False) 'NOVO DOWNLOAD DEFINIDO PELO MODO SIMPLES OU AGRUPADO

    End Sub

End Class

