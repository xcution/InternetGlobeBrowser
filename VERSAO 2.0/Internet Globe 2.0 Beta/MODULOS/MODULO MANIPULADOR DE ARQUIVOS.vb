Imports System.IO




Module MODULO_MANIPULADOR_DE_ARQUIVOS


    'ENDEREÇOS DE ARQUIVOS

    Public V_EXTENCAO_DE_ARQUIVO_1 As String = ".dll" 'EXTENÇÃO DE FORMATO DE ARQUIVO
    Public V_EXTENCAO_DE_ARQUIVO_2 As String = ".html" 'EXTENÇÃO DE FORMATO DE ARQUIVO
    Public V_EXTENCAO_DE_ARQUIVO_3 As String = ".jpg" 'EXTENÇÃO DE FORMATO DE ARQUIVO
    Public V_EXTENCAO_DE_ARQUIVO_4 As String = ".txt" 'EXTENÇÃO DE FORMATO DE ARQUIVO
    Public V_EXTENCAO_DE_ARQUIVO_5 As String = ".bmp" 'EXTENÇÃO DE FORMATO DE ARQUIVO







    'PASTAS -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Public V_PASTA_DE_CONFIGURACOES_END As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\M7SLMCONFIGIG1.2" 'PASTA DE CONFIGURAÇÕES
    Public V_PASTA_DE_CONFIGURACOES_END_IMPRIMIR As String = V_PASTA_DE_CONFIGURACOES_END & "\cachedeimpressao" 'PASTA DE CONFIGURAÇÕES
    Public V_PASTA_DE_MEUS_FAVORITOS_END As String = V_PASTA_DE_CONFIGURACOES_END & "\" & V_NOME_DE_PASTA_MEUS_FAVORITOS 'PASTA DE MEUS FAVORITOS
    Public V_PASTA_DE_MEUS_DOWNLOADS_BAIXADOS_PADRAO_END As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Downloads do IG" 'PASTA PADRÃO DE DOWNLOADS
    Public V_PASTA_DE_HISTORICO_DE_SITES_VISITADOS As String = V_PASTA_DE_CONFIGURACOES_END & "\Meuhistorico" 'PASTA DE HISTORICO DE SITES VISITADOS
    Public V_PASTA_DE_INSTALACAO_ATUAL As String = Application.StartupPath() 'PASTA DE INSTALAÇÃO ATUAL
    Public V_PASTA_DE_TEMAS As String = V_PASTA_DE_INSTALACAO_ATUAL & "\Complementos\Temas" 'PASTA DE TEMAS
    Public V_ARQUIVO_DE_INSTALACAO_DE_VOZ As String = V_PASTA_DE_INSTALACAO_ATUAL & "\Complementos\Voz\Instalar.exe" 'INSTALAR ARQUIVO DE VOZ
    Public V_PASTA_DE_IMAGEM_DEFINIDA_COMO_PLANO_DE_FUNDO As String = V_PASTA_DE_CONFIGURACOES_END & "\Imagemdesktop" 'IMAGEM DE DESKTOP DEFINIDA PELO USUÁRIO
    Public V_PASTA_DE_ARQUIVOS_DE_SESSAO As String = V_PASTA_DE_CONFIGURACOES_END & "\Sessaodeusuario" 'PASTA DE SESSÃO DE USUÁRIO
    Public V_PASTA_DE_IMAGEM_DE_BACKUP_PARA_EDITOR_DE_IMAGENS As String = V_PASTA_DE_CONFIGURACOES_END & "\Imagensbkpeditor" 'PASTA ONDE SÃO SALVOS AS IMAGENS DE BACKUP PARA O EDITOR DE IMAGENS
    Public V_PASTA_DE_IMAGENS_DE_ABAS_ABERTAS_ATUALMENTE As String = V_PASTA_DE_CONFIGURACOES_END & "\Imagensdeabasabertas" 'PASTA DE IMAGENS DE ABAS ABERTAS
    Public V_PASTA_DE_ARQUIVO_DE_INICIO_DE_PAGINA_DE_INICIO As String = V_PASTA_DE_INSTALACAO_ATUAL & "\inicio\index.html" 'AQUI FICA O ARQUIVO DE INICIO DE PÁGINA DE INICIO
    Public V_PASTA_DE_IMAGENS_DE_PAGINA_DE_INICIO As String = V_PASTA_DE_INSTALACAO_ATUAL & "\Complementos\Imagens" 'ENDEREÇO DE IMAGENS DE PÁGINA DE INÍCIO














    'ARQUIVOS DE BASICO DO PAINEL DE CONTROLE --------------------------------------------------------------------------

    Public V_ARQUIVO_END_1 As String = V_PASTA_DE_CONFIGURACOES_END & "\1" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_2 As String = V_PASTA_DE_CONFIGURACOES_END & "\2" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_3 As String = V_PASTA_DE_CONFIGURACOES_END & "\3" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_4 As String = V_PASTA_DE_CONFIGURACOES_END & "\4" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_5 As String = V_PASTA_DE_CONFIGURACOES_END & "\5" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_6 As String = V_PASTA_DE_CONFIGURACOES_END & "\6" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_7 As String = V_PASTA_DE_CONFIGURACOES_END & "\7" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_8 As String = V_PASTA_DE_CONFIGURACOES_END & "\8" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_9 As String = V_PASTA_DE_CONFIGURACOES_END & "\9" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_10 As String = V_PASTA_DE_CONFIGURACOES_END & "\10" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_11 As String = V_PASTA_DE_CONFIGURACOES_END & "\11" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_12 As String = V_PASTA_DE_CONFIGURACOES_END & "\12" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_13 As String = V_PASTA_DE_CONFIGURACOES_END & "\13" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_14 As String = V_PASTA_DE_CONFIGURACOES_END & "\14" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_15 As String = V_PASTA_DE_CONFIGURACOES_END & "\15" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_16 As String = V_PASTA_DE_CONFIGURACOES_END & "\16" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_17 As String = V_PASTA_DE_CONFIGURACOES_END & "\17" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_18 As String = V_PASTA_DE_CONFIGURACOES_END & "\18" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_19 As String = V_PASTA_DE_CONFIGURACOES_END & "\19" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_20 As String = V_PASTA_DE_CONFIGURACOES_END & "\20" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_21 As String = V_PASTA_DE_CONFIGURACOES_END & "\21" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    'Public V_ARQUIVO_END_22 As String = V_PASTA_DE_CONFIGURACOES_END & "\22" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - DISPONIVEL PARA USO

    Public V_ARQUIVO_END_23 As String = V_PASTA_DE_CONFIGURACOES_END & "\23" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_24 As String = V_PASTA_DE_CONFIGURACOES_END & "\24" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_25 As String = V_PASTA_DE_CONFIGURACOES_END & "\25" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_26 As String = V_PASTA_DE_CONFIGURACOES_END & "\26" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_27 As String = V_PASTA_DE_CONFIGURACOES_END & "\27" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_28 As String = V_PASTA_DE_CONFIGURACOES_END & "\28" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_29 As String = V_PASTA_DE_CONFIGURACOES_END & "\29" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_30 As String = V_PASTA_DE_CONFIGURACOES_END & "\30" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_31 As String = V_PASTA_DE_CONFIGURACOES_END & "\31" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_32 As String = V_PASTA_DE_CONFIGURACOES_END & "\32" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_33 As String = V_PASTA_DE_CONFIGURACOES_END & "\33" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_34 As String = V_PASTA_DE_CONFIGURACOES_END & "\34" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_35 As String = V_PASTA_DE_CONFIGURACOES_END & "\35" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_36 As String = V_PASTA_DE_CONFIGURACOES_END & "\36" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_37 As String = V_PASTA_DE_CONFIGURACOES_END & "\37" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO

    Public V_ARQUIVO_END_38 As String = V_PASTA_DE_CONFIGURACOES_END & "\38" & V_EXTENCAO_DE_ARQUIVO_1 'ARQUIVO - USANDO



















    'GERENCIADOR DE FAVORITOS

    Public V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR As String 'ENDEREÇO DE PASTA OU FAVORITO A SER MANIPULADO

    Public V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR_PASTA_OU_ARQUIVO As Boolean 'INFORMA SE É PASTA OU ARQUIVO








    'PROCESSADOR DE FAVORITOS

    Public Sub PROC_REMOVE_PASTA_DE_FAV_OU_O_FAVORITO() 'REMOVE O FAVORITO OU A PASTA
        On Error Resume Next


        'REMOVE A PASTA OU ARQUIVO -----------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR_PASTA_OU_ARQUIVO = False) Then


            My.Computer.FileSystem.DeleteDirectory(V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin) 'REMOVE PASTA


        Else


            V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR = V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR.Replace(V_EXTENCAO_DE_ARQUIVO_4, Nothing) 'DEFINE NOME
            My.Computer.FileSystem.DeleteFile(V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR & V_EXTENCAO_DE_ARQUIVO_3) 'REMOVE ARQUIVO
            My.Computer.FileSystem.DeleteFile(V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR & V_EXTENCAO_DE_ARQUIVO_4) 'REMOVE ARQUIVO
            FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TOL_TODOS_OS_FAVORITOS.DropDownItems.Clear() 'LIMPANDO...



        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_RENOMEAR_PASTA_DE_FAV_OU_O_FAVORITO() 'RENOMEIA O FAVORITO OU A PASTA
        On Error Resume Next



        'LIMPANDO ITENS -------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.TOL_TODOS_OS_FAVORITOS.DropDownItems.Clear() 'LIMPANDO...

        '---------------------------------------------------------------------------------------------------------------




        'REMOVE A PASTA OU ARQUIVO -----------------------------------------------------------------------------------------------------------------------------------------------------------


        If (V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR_PASTA_OU_ARQUIVO = False) Then


            Dim V_NOME_DE_FAVORITO As String = InputBox("Novo nome", "Renomear pasta") 'CAIXA DE ENTRADA COM NOVO NOME






            'RENOMEIA A PASTA ----------------------------------------------------------------------------------------------------------------------------------------

            If (V_NOME_DE_FAVORITO <> Nothing) And (V_NOME_DE_FAVORITO <> "") Then


                My.Computer.FileSystem.RenameDirectory(V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR, FUNC_REMOVE_CARACTERES_ESPECIAIS(V_NOME_DE_FAVORITO)) 'RENOMEIA PASTA


            End If

            '---------------------------------------------------------------------------------------------------------------------------------------------------------




        Else




            Dim V_NOME_DE_FAVORITO As String = InputBox("Novo nome", "Renomear favoríto") 'CAIXA DE ENTRADA COM NOVO NOME






            'RENOMEIA A PASTA ----------------------------------------------------------------------------------------------------------------------------------------

            If (V_NOME_DE_FAVORITO <> Nothing) And (V_NOME_DE_FAVORITO <> "") Then




                V_NOME_DE_FAVORITO = FUNC_REMOVE_CARACTERES_ESPECIAIS(V_NOME_DE_FAVORITO) 'REMOVE CARACTERES INVALIDOS

                V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR = V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR.Replace(V_EXTENCAO_DE_ARQUIVO_4, Nothing) 'DEFINE NOME




                'RENOMEANDO AGORA -----------------------------------------------------------------------------------------------------------------------------------------------------------

                My.Computer.FileSystem.RenameFile(V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR & V_EXTENCAO_DE_ARQUIVO_3, V_NOME_DE_FAVORITO & V_EXTENCAO_DE_ARQUIVO_3) 'RENOMEIA FAVORITO

                My.Computer.FileSystem.RenameFile(V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR & V_EXTENCAO_DE_ARQUIVO_4, V_NOME_DE_FAVORITO & V_EXTENCAO_DE_ARQUIVO_4) 'RENOMEIA FAVORITO

                '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------




            End If

            '---------------------------------------------------------------------------------------------------------------------------------------------------------




        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




    End Sub

    Public Sub PROC_ABRIR_FAVORITO_TOL_MENU_MODULO_MANIPULADOR_DE_ARQUIVOS() 'ABRE O FAVORITO INFORMADO NO TOL MENU
        On Error Resume Next

        Dim V_SITE_A_ABRIR As String = FUNC_LER_ARQUIVO(V_END_DE_FAV_ARQ_OU_PASTA_A_TRABALHAR) 'LÊ CONFIG DE ARQUIVO






        'ADICIONA NOVA ABA E NAVEGA ------------------------------------------------------------------------------------

        PROC_NOVA_ABA_ADICIONAR() 'ADICIONA NOVA ABA

        PROC_NAVEGAR(V_SITE_A_ABRIR) 'NAVEGA NO ENDEREÇO DE SITE INFORMADO

        '---------------------------------------------------------------------------------------------------------------


    End Sub




















    'PROCEDIMENTOS DE SALVAR E LER

    Public Sub PROC_CRIAR_PASTAS() 'CRIAR PASTAS DE SISTEMA DO NAVEGADOR
        On Error Resume Next


        'CRIANDO AS PASTAS -------------------------------------------------------------------------------------------------------------------------------------------

        My.Computer.FileSystem.CreateDirectory(V_PASTA_DE_CONFIGURACOES_END) 'PASTA DE CONFIGURAÇÃO

        My.Computer.FileSystem.CreateDirectory(V_PASTA_DE_CONFIGURACOES_END_IMPRIMIR) 'PASTA DE CONFIGURAÇÃO

        My.Computer.FileSystem.CreateDirectory(V_PASTA_DE_MEUS_FAVORITOS_END) 'PASTA DE CONFIGURAÇÃO

        My.Computer.FileSystem.CreateDirectory(V_PASTA_DE_MEUS_DOWNLOADS_BAIXADOS_PADRAO_END) 'PASTA PADRÃO DE DOWNLOADS DO IG

        My.Computer.FileSystem.CreateDirectory(V_PASTA_DE_HISTORICO_DE_SITES_VISITADOS) 'CRIA PASTA DE HISTORICO

        My.Computer.FileSystem.CreateDirectory(V_PASTA_DE_IMAGEM_DEFINIDA_COMO_PLANO_DE_FUNDO) 'CRIA PASTA DE HISTORICO

        My.Computer.FileSystem.CreateDirectory(V_PASTA_DE_ARQUIVOS_DE_SESSAO) 'PASTA DE SESSÃO DE USUÁRIO

        My.Computer.FileSystem.CreateDirectory(V_PASTA_DE_IMAGEM_DE_BACKUP_PARA_EDITOR_DE_IMAGENS) 'PASTA DE BACKUP DE IMAGENS DE EDIÇÃO

        My.Computer.FileSystem.CreateDirectory(V_PASTA_DE_IMAGENS_DE_ABAS_ABERTAS_ATUALMENTE) 'PASTA DE MINIATURAS DE IMAGENS DE ABAS ABERTAS

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_SALVAR_ARQUIVO(ByVal V_VALOR As String, ByVal V_DESTINO As String) 'SALVA O ARQUIVO
        On Error Resume Next


        'CRIA PASTA DESTINO SE NAO EXISTIR -----------------------------------------------------------------------------

        My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(V_DESTINO)) 'CRIANDO PASTA

        '---------------------------------------------------------------------------------------------------------------




        'SALVANDO ------------------------------------------------------------------------------------------------------

        My.Computer.FileSystem.WriteAllText(V_DESTINO, V_VALOR, False) 'SALVA NOVO VALOR

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Function FUNC_LER_ARQUIVO(ByVal V_DESTINO As String) As String 'LÊ CONFIG DE ARQUIVO
        On Error Resume Next

        Dim V_VALOR_DE_RETORNO As String 'VALOR DE RETORNO






        'CRIA PASTA DESTINO SE NAO EXISTIR ----------------------------------------------------------------------------------------------------

        My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(V_DESTINO)) 'CRIANDO PASTA

        '--------------------------------------------------------------------------------------------------------------------------------------




        'SALVANDO -----------------------------------------------------------------------------------------------------------------------------

        V_VALOR_DE_RETORNO = My.Computer.FileSystem.ReadAllText(V_DESTINO, System.Text.Encoding.UTF7) 'LENDO

        '--------------------------------------------------------------------------------------------------------------------------------------




        'EM CASO DE VALOR NULO RETORNE VERDADEIRO ---------------------------------------------------------------------------------------------

        If (V_VALOR_DE_RETORNO.Length = 0) Then


            V_VALOR_DE_RETORNO = True 'RETORNO


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------




        'RETORNO ------------------------------------------------------------------------------------------------------------------------------

        Return V_VALOR_DE_RETORNO 'RETORNO EM CASO DE NAO FOR, STRING OU NUMERO

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Function

    Public Function FUNC_RETORNA_SE_O_ARQUIVO_EXISTE_OU_NAO(ByVal V_ORIGEM As String) 'RETORNA SE UM ARQUIVO EXISTE OU NAO
        On Error Resume Next

        Dim V_EXISTE As Boolean = My.Computer.FileSystem.FileExists(V_ORIGEM) 'RETORNO DE FUNÇÃO






        'CRIA PASTA DESTINO SE NAO EXISTIR -----------------------------------------------------------------------------

        My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(V_ORIGEM)) 'CRIANDO PASTA

        '---------------------------------------------------------------------------------------------------------------




        'RETORNO -------------------------------------------------------------------------------------------------------

        Return V_EXISTE 'RETORNO

        '---------------------------------------------------------------------------------------------------------------


    End Function

    Public Sub PROC_REMOVER_TODOS_OS_ARQUIVOS(ByVal V_END_DE_PASTA As String) 'REMOVE TODOS OS ARQUIVOS DA PASTA INFORMADA
        On Error Resume Next


        'REMOVER TUDO --------------------------------------------------------------------------------------------------

        Kill(V_END_DE_PASTA & "\*") 'REMOVENDO TUDO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Function FUNC_ARRAY_RETORNE_TODAS_AS_PASTAS_E_SUB_PASTAS(ByVal V_PASTA_DE_ORIGEM As String) 'RETORNA TODAS AS PASTAS E SUBPASTAS EM FORMA DE ARRAY
        On Error Resume Next

        Dim ARRAY_TODAS_AS_PASTAS As Array = Directory.GetDirectories(V_PASTA_DE_ORIGEM) 'OBTENDO TODOS OS DIRETORIOS






        'CRIA PASTA DESTINO SE NAO EXISTIR -----------------------------------------------------------------------------

        My.Computer.FileSystem.CreateDirectory(V_PASTA_DE_ORIGEM) 'CRIANDO A PASTA

        '---------------------------------------------------------------------------------------------------------------




        'RETORNO -------------------------------------------------------------------------------------------------------

        Return ARRAY_TODAS_AS_PASTAS 'RETORNO

        '---------------------------------------------------------------------------------------------------------------


    End Function

    Public Function FUNC_ARRAY_RETORNE_TODOS_OR_ARQUIVOS(ByVal V_PASTA_DE_ORIGEM As String) 'RETORNA TODOS OS ARQUIVOS DA PASTA
        On Error Resume Next

        Dim ARRAY_TODOS_OS_ARQUIVOS As Array = Directory.GetFiles(V_PASTA_DE_ORIGEM, "*.txt*") 'OBTENDO TODOS OS DIRETORIOS






        'CRIA PASTA DESTINO SE NAO EXISTIR -----------------------------------------------------------------------------

        My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(V_PASTA_DE_ORIGEM)) 'CRIANDO PASTA

        '---------------------------------------------------------------------------------------------------------------




        'RETORNO -------------------------------------------------------------------------------------------------------

        Return ARRAY_TODOS_OS_ARQUIVOS 'RETORNO

        '---------------------------------------------------------------------------------------------------------------


    End Function

    Public Sub PROC_REMOVE_PASTA_COMPLETA_COM_SUB_PASTAS(ByVal V_ORIGEM As String, ByVal V_PERGUNTA As Boolean) 'REMOVE TODA A PASTA INCLUINDO ARQUIVOS
        On Error Resume Next


        'REMOVE A PASTA ---------------------------------------------------------------------------------------------------------------------------------------------

        If (V_PERGUNTA = False) Then


            My.Computer.FileSystem.DeleteDirectory(V_ORIGEM, FileIO.UICancelOption.DoNothing, FileIO.RecycleOption.DeletePermanently) 'REMOVENDO...


        Else


            My.Computer.FileSystem.DeleteDirectory(V_ORIGEM, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.DeletePermanently) 'REMOVENDO...


        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_REMOVE_SOMENTE_O_ARQUIVO(ByVal V_ORIGEM As String, ByVal V_PERGUNTA As Boolean) 'REMOVE SOMENTE O ARQUIVO
        On Error Resume Next


        'REMOVE O ARQUIVO ---------------------------------------------------------------------------------------------------------------------------------------------

        If (V_PERGUNTA = False) Then


            My.Computer.FileSystem.DeleteFile(V_ORIGEM, FileIO.UICancelOption.DoNothing, FileIO.RecycleOption.DeletePermanently) 'REMOVENDO...


        Else


            My.Computer.FileSystem.DeleteFile(V_ORIGEM, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.DeletePermanently) 'REMOVENDO...


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Public Sub PROC_LIMPAR_ARQUIVOS_DE_HISTORICO() 'LIMPA OS ARQUIVOS DE HISTÓRICO
        On Error Resume Next


        'DELETANDO A PASTA DE HISTORICO --------------------------------------------------------------------------------------------------------------------------------------------------

        My.Computer.FileSystem.DeleteDirectory(V_PASTA_DE_HISTORICO_DE_SITES_VISITADOS, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.DeletePermanently) 'DELETANDO

        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'LIMPA CONTROLES QUE USAM O HISTORICO -----------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PIC_HISTORICO.Image = Nothing 'LIMPA A IMAGEM DE HISTORICO

        '------------------------------------------------------------------------------------------------------------




        'FECHA O FORMULÁRIO DE HISTORICO SE ESTIVER ABERTO ---------------------------------------------------------------------------------------------------------------------------------------

        FRM_FORMULARIO_DE_NAVEGACAO_PRINCIPAL.PN_HISTORICO.Visible = False 'OCULTA O PAINEL DE AÇÕES SOBRE O HISTORICO

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'FECHANDO FORMULARIOS DE TRABALHO SECUNDÁRIO ---------------------------------------------------------------------------------------------------------------------------------------------

        PROC_FECHAR_FORMULARIOS_DE_TRABALHO_SECUNDARIO() 'FECHA TODOS OS FORMULARIOS DE TRABALHO SECUNDÁRIO

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'LIMPA AS VARIÁVEIS DE HISTORICO ----------------------------------------------------------------------------

        PROC_LIMPA_VARIAVEIS_DE_HISTORICO() 'LIMPA AS VARIÁVEIS DE HISTÓRICO

        '------------------------------------------------------------------------------------------------------------




    End Sub

    Public Sub PROC_REMOVER_PASTA_POR_COMPLETO(ByVal V_ORIGEM As String) 'REMOVE A PASTA E SUB-PASTAS E TODOS OS ARQUIVOS.
        On Error Resume Next


        'REMOVENDO -----------------------------------------------------------------------------------------------------

        System.IO.Directory.Delete(V_ORIGEM, True) 'REMOVE PASTA DE HISTORICO

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub PROC_COPIAR_PASTAS(ByVal V_ORIGEM As String, ByVal V_DESTINO As String) 'COPIA A PASTA DE ORIGEM PARA A PASTA DE DESTINO
        On Error Resume Next


        'NÃO PERMITE VALORES EM BRANCO OU NULOS ------------------------------------------------------------------------

        If (V_ORIGEM = "") Or (V_ORIGEM = Nothing) Or (V_DESTINO = "") Or (V_DESTINO = Nothing) Then

            Exit Sub 'SAINDO...

        End If

        '---------------------------------------------------------------------------------------------------------------




        'CRIA PASTA DESTINO SE NAO EXISTIR -----------------------------------------------------------------------------

        My.Computer.FileSystem.CreateDirectory(V_ORIGEM) 'CRIANDO A PASTA

        My.Computer.FileSystem.CreateDirectory(V_DESTINO) 'CRIANDO A PASTA

        '---------------------------------------------------------------------------------------------------------------




        'COPIANDO ARQUIVOS AGORA ---------------------------------------------------------------------------------------

        My.Computer.FileSystem.CopyDirectory(V_ORIGEM, V_DESTINO) 'COPIANDO...

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Function FUNC_RETORNA_SE_PASTA_EXISTE_OU_NAO(ByVal V_ORIGEM As String) 'RETORNA SE A PASTA EXISTE OU NAO
        On Error Resume Next

        Dim V_EXISTE As Boolean = My.Computer.FileSystem.DirectoryExists(V_ORIGEM) 'RETORNO






        'CRIANDO PASTA -------------------------------------------------------------------------------------------------

        If (V_EXISTE = False) Then

            My.Computer.FileSystem.CreateDirectory(V_ORIGEM) 'CRIANDO A PASTA

        End If

        '---------------------------------------------------------------------------------------------------------------




        'RETORNO -------------------------------------------------------------------------------------------------------

        Return V_EXISTE 'RETORNO

        '---------------------------------------------------------------------------------------------------------------


    End Function

    Public Sub PROC_OBTER_TODAS_AS_PASTAS(ByVal V_PASTA_INICIAL As String, ByRef ARRAY_DE_PASTAS As ArrayList) 'OBTEM TODAS AS PASTAS
        On Error Resume Next

        Dim V_PASTAS() As String = Directory.GetDirectories(V_PASTA_INICIAL) 'VARIÁVEL ONDE FICAM OS ENDEREÇOS DE PASTAS






        'SE NÃO HOUVER VALOR DE PASTA INICIAL ENTÃO SAIR ---------------------------------------------------------------

        If (V_PASTA_INICIAL.Length = 0) Then

            Exit Sub 'SAINDO

        End If

        '---------------------------------------------------------------------------------------------------------------




        'CRIA A PASTA EM CASO DE NÃO EXISTIR ---------------------------------------------------------------------------

        My.Computer.FileSystem.CreateDirectory(V_PASTA_INICIAL) 'CRIANDO A PASTA EM CASO DE NÃO EXISTIR

        '---------------------------------------------------------------------------------------------------------------




        'ATUALIZA O ARRAY ----------------------------------------------------------------------------------------------

        ARRAY_DE_PASTAS.AddRange(V_PASTAS) 'ATUALIZA ARRAY

        '---------------------------------------------------------------------------------------------------------------




        'PROCURA POR TODAS AS PASTAS -----------------------------------------------------------------------------------

        For Each Dir As String In V_PASTAS

            PROC_OBTER_TODAS_AS_PASTAS(Dir, ARRAY_DE_PASTAS) 'OBTEM TODAS AS PASTAS

        Next

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Function FUNC_ARQUIVO_RETORNE_IMAGEM_EM_DISCO(ByVal V_ORIGEM As String) As Image  'RETORNA A IMAGEM EXISTENTE EM DISCO
        On Error Resume Next

        Dim V_EXISTE As Boolean = FUNC_RETORNA_SE_O_ARQUIVO_EXISTE_OU_NAO(V_ORIGEM) 'DETERMINA SE O ARQUIVO EXISTE OU NAO

        Dim OBJ_IMAGEM_STREAM As New System.IO.FileStream(V_ORIGEM, System.IO.FileMode.Open, System.IO.FileAccess.Read) 'STREAM DE IMAGEM EM DISCO

        Dim OBJ_IMAGEM As Image = Image.FromStream(OBJ_IMAGEM_STREAM) 'CONVERTE O STREAM PARA IMAGE







        'FECHA ARQUIVO DE IMAGEM ABERTO --------------------------------------------------------------------------------

        OBJ_IMAGEM_STREAM.Close() 'FECHA ARQUIVO DE IMAGEM ABERTO

        '---------------------------------------------------------------------------------------------------------------




        'CRIA PASTA DESTINO SE NAO EXISTIR -----------------------------------------------------------------------------

        My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(V_ORIGEM)) 'CRIANDO PASTA

        '---------------------------------------------------------------------------------------------------------------




        'SE O ARQUIVO NÃO EXISTIR ENTÃO RETORNE NOTHING ----------------------------------------------------------------

        If (V_EXISTE = False) Then


            Return Nothing 'RETORNA VALOR NULO

            Exit Function 'SAI DA FUNÇÃO


        End If

        '---------------------------------------------------------------------------------------------------------------




        'RETORNO DE IMAGEM ---------------------------------------------------------------------------------------------

        Return OBJ_IMAGEM 'RETORNO

        '---------------------------------------------------------------------------------------------------------------


    End Function

    Public Sub PROC_REMOVER_ARQUIVO_UNICO_SEM_PERGUNTAS(ByVal V_END As String) 'REMOVE ARQUIVO SEM PERGUNTA
        On Error Resume Next

        My.Computer.FileSystem.DeleteFile(V_END) 'REMOVENDO ARQUIVO SEM PERGUNTA

    End Sub

    Public Sub PROC_OBTER_TODOS_OS_ARQUIVOS(ByVal V_PASTA_INICIAL As String, ByRef ARRAY_DE_ARQUIVOS As ArrayList, ByVal V_FILTRO As String) 'OBTEM TODOS OS ARQUIVOS
        On Error Resume Next

        Dim V_ARQUIVOS() As String = Directory.GetFiles(V_PASTA_INICIAL, V_FILTRO) 'VARIÁVEL ONDE FICAM OS ENDEREÇOS DE ARQUIVOS






        'SE NÃO HOUVER VALOR DE PASTA INICIAL ENTÃO SAIR ---------------------------------------------------------------

        If (V_PASTA_INICIAL.Length = 0) Then

            Exit Sub 'SAINDO

        End If

        '---------------------------------------------------------------------------------------------------------------




        'CRIA PASTA DESTINO SE NAO EXISTIR -----------------------------------------------------------------------------

        My.Computer.FileSystem.CreateDirectory(V_PASTA_INICIAL) 'CRIANDO PASTA

        '---------------------------------------------------------------------------------------------------------------




        'ATUALIZA O ARRAY ----------------------------------------------------------------------------------------------

        ARRAY_DE_ARQUIVOS.AddRange(V_ARQUIVOS) 'ATUALIZA ARRAY

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Function FUNC_RETORNE_A_IMAGEM_DE_ARQUIVO(ByVal V_ORIGEM As String) As Image 'RETORNA A IMAGEM DE ARQUIVO EM DISCO
        On Error Resume Next

        Dim V_EXISTE As Boolean = FUNC_RETORNA_SE_O_ARQUIVO_EXISTE_OU_NAO(V_ORIGEM) 'RETORNO DE FUNÇÃO

        Dim OBJ_IMAGEM_ICONE As Icon = Icon.ExtractAssociatedIcon(V_ORIGEM) 'EXTRAINDO ICONE

        Dim OBJ_BITMAP_CONVERTIDO As Bitmap 'CRIA NOVA BITMAP

        Dim OBJ_IMAGE As Image 'OBJETO DE RETORNO






        'CRIA PASTA DESTINO SE NAO EXISTIR -----------------------------------------------------------------------------

        My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(V_ORIGEM)) 'CRIANDO PASTA

        '---------------------------------------------------------------------------------------------------------------




        'CONVERTENDO A IMAGEM ------------------------------------------------------------------------------------------

        OBJ_BITMAP_CONVERTIDO = OBJ_IMAGEM_ICONE.ToBitmap 'CONVERTE IMAGEM PARA BITMAP

        OBJ_IMAGE = OBJ_BITMAP_CONVERTIDO 'CRIANDO O OBJETO DE RETORNO

        '---------------------------------------------------------------------------------------------------------------




        'EM CASO DE NÃO EXISTIR O ARQUIVO RETORNE VALOR NULO -----------------------------------------------------------

        If (V_EXISTE = False) Then

            Return Nothing 'VALOR NULO

            Exit Function 'SAI DA FUNÇÃO

        End If

        '---------------------------------------------------------------------------------------------------------------




        'RETORNO DE IMAGEM ---------------------------------------------------------------------------------------------

        Return OBJ_IMAGE 'RETORNO

        '---------------------------------------------------------------------------------------------------------------


    End Function





























End Module
