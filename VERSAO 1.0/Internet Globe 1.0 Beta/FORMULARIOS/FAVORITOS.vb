Public Class FRM_FAVORITOS


    'Variáveis temporarias

    Public v_listar_favoritos As Boolean = False 'Lista ou não os favoritos

    Public v_gerenciar_favoritos As Boolean = False 'Gerencia ou nao os favoritos










    'Variáveis de processamento de favoritos

    Dim v_nome_da_pasta_selecionada As String 'Informa o nome da pasta selecionada

    Dim v_endereco_da_pasta_selecionada As String 'Informa o endereço da pasta selecionada

    Dim v_nome_da_nova_pasta As String = "Nova pasta" 'Informa o nome da nova pasta

    Dim v_salvar_na_pasta As String 'Salvar favorito na pasta

    Dim v_extencao As String = ".txt" 'Extenção do arquivo de favoríto

    Dim v_nome_do_favorito_selecionado As String 'Informa o nome do favorito selecionado

    Dim v_endereco_do_favorito_selecionado As String 'Informa o endereço do favorito selecionado

    Dim v_index_da_pasta As Integer 'Informa o index da pasta

    Dim v_index_do_favorito As Integer 'Informa o index do favorito

    Dim v_nivel_atual As Integer 'Informa o nivel atual








    'Variáveis basicas

    Dim v_ultima_configuracao_do_modo_geek As Boolean 'Informa a ultima configuração do modo geek













    'Gerenciamento de pastas

    Private Sub proc_pasta_inicial() 'Ir para a pasta inicial
        On Error Resume Next

        'Selecionando primeira pasta da lista -----------------------------------------------------------------------------

        tree_pastas_de_favoritos.SelectedNode = tree_pastas_de_favoritos.Nodes.Item(v_index_da_pasta) 'Pasta da lista

        tree_pastas_de_favoritos.SelectedNode.Expand() 'Expandindo

        '------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub proc_listar_pastas_raizes() 'Lista todas as pastas raizes
        On Error Resume Next

        Dim v_lista_de_sub_diretorios As System.Collections.ObjectModel.ReadOnlyCollection(Of String) 'Listagem de sub-diretorios

        Dim v_contador As Integer 'Contador de looping

        Dim v_quantidade_de_pastas As Integer 'Informa a quantidade de pastas

        Dim v_nome_da_pasta_a_adicionar As Array 'Informa o nome da pasta a ser adicionada

        Dim v_separador As String = "\" 'Separador do array






        'Inicializando -------------------------------------------------------------------------------------------------------------------------------------

        v_lista_de_sub_diretorios = My.Computer.FileSystem.GetDirectories(V_PASTA_DE_FAVORITOS, FileIO.SearchOption.SearchTopLevelOnly)

        v_contador = 0 'Contador de looping

        v_quantidade_de_pastas = v_lista_de_sub_diretorios.Count - 1 'Informa a quantidade de pastas

        tree_pastas_de_favoritos.Nodes.Clear() 'Limpando lista anterior

        txt_nome_da_pasta.Text = Nothing 'Limpando nome

        '---------------------------------------------------------------------------------------------------------------------------------------------------




        'Varrendo -------------------------------------------------------------------------------------------------------------------------

        For v_contador = v_contador To v_quantidade_de_pastas




            'Adicionando ------------------------------------------------------------------------------------------------------------------

            v_nome_da_pasta_a_adicionar = Split(v_lista_de_sub_diretorios(v_contador), v_separador) 'Nome da pasta

            tree_pastas_de_favoritos.Nodes.Add(v_nome_da_pasta_a_adicionar(v_nome_da_pasta_a_adicionar.Length - 1)) 'Adicionando pasta...

            '------------------------------------------------------------------------------------------------------------------------------




        Next

        '----------------------------------------------------------------------------------------------------------------------------------




        'Pasta inicial abrir ------------------------------------------------------------

        proc_pasta_inicial() 'Ir para a pasta inicial

        '--------------------------------------------------------------------------------


    End Sub

    Private Function func_renomear_pasta(ByVal v_novo_nome As String) 'Renomeia a pasta desejada
        On Error Resume Next

        Dim V_PASTA_DE_FAVORITOS_de_comparacao As String 'Pasta de comparação de existencia






        'Inicializar -----------------------------------------------------------------------------------------

        V_PASTA_DE_FAVORITOS_de_comparacao = V_PASTA_DE_FAVORITOS & "\" & v_novo_nome 'Informando a pasta de comparação de existencia

        '-----------------------------------------------------------------------------------------------------




        'Não pode ser nome em branco --------------------------------------------------------------------------------------------------------------------------------------------------------

        If (v_novo_nome = Nothing) Then


            'Mensagem com janela e voz ao usuário ---------------------------------------------------------------------------------------------------------------------------------


            If (V_VAL_CONFIG_USAR_RECURSO_DE_VOZ = True) Then



                'Ocultando janela atual ----------------

                Me.Hide() 'Ocultando

                '---------------------------------------




                'Mensagem com voz ao usuário -----------------------------------------------------------------------------------------------------------

                proc_chamar_mensagem_ao_usuario(V_MS_3, v_tipo_ms_1) 'Chama a janela de mensagem ao usuario

                '---------------------------------------------------------------------------------------------------------------------------------------




                'Exibindo janela novamente -----------------

                Me.Show() 'Exibindo

                txt_nome_da_pasta.Focus() 'Movendo o foco

                '-------------------------------------------




            Else




                'Informe ao usuário ----------------------------------------------------------------------------------------------

                MsgBox("Você não informou o novo nome da pasta.", MsgBoxStyle.Information, "Informação ao usuário") 'Informação

                txt_nome_da_pasta.Focus() 'Movendo o foco

                '-----------------------------------------------------------------------------------------------------------------




            End If


            '----------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'Retorno e saida ----------------------

            Return Nothing

            Exit Function

            '--------------------------------------


        End If

        '-------------------------------------------------------------------------




        'Verificando se a pasta já existe --------------------------------------------------------------------------------------------------------------------------

        If (My.Computer.FileSystem.DirectoryExists(V_PASTA_DE_FAVORITOS_de_comparacao) = True) Then


            'Mensagem com janela e voz ao usuário ---------------------------------------------------------------------------------------------------------------------------------


            If (V_VAL_CONFIG_USAR_RECURSO_DE_VOZ = True) Then




                'Ocultando janela atual ----------------

                Me.Hide() 'Ocultando

                '---------------------------------------




                'Mensagem com voz ao usuário -----------------------------------------------------------------------------------------------------

                proc_chamar_mensagem_ao_usuario(V_MS_5, v_tipo_ms_1) 'Chama a janela de mensagem ao usuario

                '---------------------------------------------------------------------------------------------------------------------------------




                'Exibindo janela novamente ------------------

                Me.Show() 'Exibindo


                txt_nome_da_pasta.Focus() 'Movendo foco


                '--------------------------------------------




            Else




                'Informe e mova o foco ------------------------------------------------------------------------------------------------------------------------------

                MsgBox("A pasta '" & v_novo_nome & "' já existe, tente outro nome.", MsgBoxStyle.Information, "Informação ao usuário") 'Mensagem ao usuário

                txt_nome_da_pasta.Focus() 'Movendo foco

                '----------------------------------------------------------------------------------------------------------------------------------------------------




            End If


            '----------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'Retorno e saida ----------------------

            Return Nothing

            Exit Function

            '--------------------------------------




        End If




        'Renomeando pasta agora -------------------------------------------------------------------------------

        My.Computer.FileSystem.RenameDirectory(v_endereco_da_pasta_selecionada, v_novo_nome) 'Renomeando pasta

        '------------------------------------------------------------------------------------------------------




        'Atualizando lista --------------------------------------------------

        proc_listar_pastas_raizes() 'Lista todas as pastas raizes

        '--------------------------------------------------------------------




    End Function

    Private Sub proc_excluir_pasta() 'Exclui a pasta em foco
        On Error Resume Next


        'Pergunta ao usuário -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (MsgBox("Se você prosseguir todo o conteúdo da pasta '" & v_nome_da_pasta_selecionada & "' será apagado, deseja continuar?", MsgBoxStyle.YesNo, "Excluir pasta - " & v_nome_da_pasta_selecionada) = MsgBoxResult.No) Then

            Exit Sub 'Saindo do procedimento

        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Apagando arquivos e pasta ---------------------------------------------------------------------------------


        'Arquivos removendo --------------------------------------------

        Kill(v_endereco_da_pasta_selecionada & "\*.*") 'Apagando todos os arquivos

        '---------------------------------------------------------------




        'Pasta removendo -----------------------------------------------

        RmDir(v_endereco_da_pasta_selecionada) 'Removendo pasta

        '-----------------------------------------------------------------------------------------------------------




        'Mensagem com janela e voz ao usuário ---------------------------------------------------------------------------------------------------------------------------------


        If (V_VAL_CONFIG_USAR_RECURSO_DE_VOZ = True) Then



            'Ocultando janela atual ----------------

            Me.Hide() 'Ocultando

            '---------------------------------------




            'Mensagem com voz ao usuário -----------------------------------------------------------------------------------------------------

            proc_chamar_mensagem_ao_usuario(V_MS_4, v_tipo_ms_1) 'Chama a janela de mensagem ao usuario

            '---------------------------------------------------------------------------------------------------------------------------------




            'Exibindo janela novamente ----------

            Me.Show() 'Exibindo

            '------------------------------------



        End If


        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Atualizando lista --------------------------------------------------

        proc_listar_pastas_raizes() 'Lista todas as pastas raizes

        '--------------------------------------------------------------------


    End Sub

    Private Sub proc_nova_pasta() 'Nova pasta
        On Error Resume Next

        Dim v_local_nova_pasta As String 'Informa o nome e local da nova pasta





        'Inicializando ---------------------------------------------------------------

        v_local_nova_pasta = V_PASTA_DE_FAVORITOS & "\" & v_nome_da_nova_pasta 'Nova pasta

        '-----------------------------------------------------------------------------




        'Verificando se a pasta já existe ---------------------------------------------------------------------------------------------------------------------------

        If (My.Computer.FileSystem.DirectoryExists(v_local_nova_pasta) = True) Then


            'Mensagem com janela e voz ao usuário ---------------------------------------------------------------------------------------------------------------------------------


            If (V_VAL_CONFIG_USAR_RECURSO_DE_VOZ = True) Then



                'Ocultando janela atual ----------------

                Me.Hide() 'Ocultando

                '---------------------------------------




                'Mensagem com voz ao usuário -----------------------------------------------------------------------------------------------------

                proc_chamar_mensagem_ao_usuario(V_MS_5, v_tipo_ms_1) 'Chama a janela de mensagem ao usuario

                '---------------------------------------------------------------------------------------------------------------------------------




                'Exibindo janela novamente ----------

                Me.Show() 'Exibindo

                '------------------------------------



            End If


            '----------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'Informando e saindo -------------------------------------------------------------------------------------------------------------------------------

            MsgBox("Antes de criar uma nova pasta, renomeie a nova pasta já existente!", MsgBoxStyle.Information, "Informação ao usuário") 'Informação ao usuário

            Exit Sub 'Saindo do procedimento

            '---------------------------------------------------------------------------------------------------------------------------------------------------




        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Criando nova pasta ---------------------------------------------------------------------------------

        My.Computer.FileSystem.CreateDirectory(v_local_nova_pasta) 'Criando pasta

        '----------------------------------------------------------------------------------------------------




        'Atualizando lista --------------------------------------------------

        proc_listar_pastas_raizes() 'Lista todas as pastas raizes

        '--------------------------------------------------------------------


    End Sub

    Private Sub proc_listar_somente_pastas_em_lista_de_combinacao() 'Lista somente as pastas na lista de combinação
        On Error Resume Next

        Dim v_lista_de_sub_diretorios As System.Collections.ObjectModel.ReadOnlyCollection(Of String) 'Listagem de sub-diretorios

        Dim v_contador As Integer 'Contador de looping

        Dim v_quantidade_de_pastas As Integer 'Informa a quantidade de pastas

        Dim v_nome_da_pasta_a_adicionar As Array 'Informa o nome da pasta a ser adicionada

        Dim v_separador As String = "\" 'Separador do array






        'Inicializando -------------------------------------------------------------------------------------------------------------------------------------

        v_lista_de_sub_diretorios = My.Computer.FileSystem.GetDirectories(V_PASTA_DE_FAVORITOS, FileIO.SearchOption.SearchTopLevelOnly)

        v_contador = 0 'Contador de looping

        v_quantidade_de_pastas = v_lista_de_sub_diretorios.Count - 1 'Informa a quantidade de pastas

        cbo_pasta.Items.Clear() 'Limpando items

        '---------------------------------------------------------------------------------------------------------------------------------------------------




        'Varrendo -------------------------------------------------------------------------------------------------------------------------

        For v_contador = v_contador To v_quantidade_de_pastas


            'Separando nomes de pastas em array -----------------------------------------------------------------------------------------------

            v_nome_da_pasta_a_adicionar = Split(v_lista_de_sub_diretorios(v_contador), v_separador) 'Nome da pasta

            '---------------------------------------------------------------------------------------------------------------------------------------------------




            'Adicionando ------------------------------------------------------------------------------------------------------------------

            cbo_pasta.Items.Add(v_nome_da_pasta_a_adicionar(v_nome_da_pasta_a_adicionar.Length - 1)) 'Adicionando pasta...

            '------------------------------------------------------------------------------------------------------------------------------


        Next

        '----------------------------------------------------------------------------------------------------------------------------------




        'Separando nomes de pastas em array -----------------------------------------------------------------------------------------------

        v_nome_da_pasta_a_adicionar = Split(v_lista_de_sub_diretorios(0), v_separador) 'Nome da pasta

        '---------------------------------------------------------------------------------------------------------------------------------------------------




        'Selecionando a primeira pasta da lista ------------------------------------------------------------------------

        cbo_pasta.Text = v_nome_da_pasta_a_adicionar(v_nome_da_pasta_a_adicionar.Length - 1) 'Primeira pasta

        '---------------------------------------------------------------------------------------------------------------


    End Sub




    'Procedimentos para salvar o favorito

    Private Sub proc_definir_pasta_onde_sera_salvo() 'Definindo onde será salvo o favoríto
        On Error Resume Next

        'Obtendo endereço de pasta ----------------------------------------------------------------------------------------------------

        v_salvar_na_pasta = V_PASTA_DE_FAVORITOS & "\" & cbo_pasta.SelectedItem & "\" 'Endereço da pasta que será salvo o favorito

        '------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Function func_verificador() 'Verifica se tudo está ok
        On Error Resume Next


        'Url ok ------------------------------------------------------------------------------------------------------------

        If (txt_favorito_endereco.Text = Nothing) Then


            'Informando e saindo -----------------------------------------------------------------------

            MsgBox("Informe a url do favoríto.          ", MsgBoxStyle.Exclamation, "Globe - Alerta") 'Mensagem

            txt_favorito_endereco.Focus() 'Movendo o foco

            Return False 'Retorno

            Exit Function 'Saindo da função

            '-------------------------------------------------------------------------------------------


        End If

        '-------------------------------------------------------------------------------------------------------------------




        'titulo ok ---------------------------------------------------------------------------------------------------------

        If (txt_titulo.Text = Nothing) Then


            'Informando e saindo -----------------------------------------------------------------------

            MsgBox("Informe o título do favoríto.          ", MsgBoxStyle.Exclamation, "Globe - Alerta") 'Mensagem

            txt_titulo.Focus() 'Movendo o foco

            Return False 'Retorno

            Exit Function 'Saindo da função

            '-------------------------------------------------------------------------------------------


        End If

        '-------------------------------------------------------------------------------------------------------------------




        'Url ok ------------------------------------------------------------------------------------------------------------

        If (v_salvar_na_pasta = Nothing) Then


            'Informando e saindo -----------------------------------------------------------------------

            MsgBox("Informe a pasta do favoríto.          ", MsgBoxStyle.Exclamation, "Globe - Alerta") 'Mensagem

            cbo_pasta.Focus() 'Movendo o foco

            Return False 'Retorno

            Exit Function 'Saindo da função

            '-------------------------------------------------------------------------------------------


        End If

        '-------------------------------------------------------------------------------------------------------------------


        'Retorna verdadeiro -----------------

        Return True 'Retorno

        '------------------------------------


    End Function

    Public Sub proc_salvar_favorito() 'Salva o favoríto
        On Error Resume Next

        Dim v_conteudo_a_salvar As String 'Conteudo a ser salvo

        Dim V_PASTA_DE_FAVORITOS_arquivo As String 'Endereço completo do arquivo onde sera salvo o favorito

        Dim v_mensagem_a_ler As String 'Mensagem temporaria a ser lida

        Dim v_titulo_da_pagina As String 'Título da página






        'Convertendo campos para minusulo ----------------------------------------------------------------------------------------------

        txt_favorito_endereco.Text = txt_favorito_endereco.Text.ToLower 'Minúsculo

        v_titulo_da_pagina = txt_titulo.Text.ToLower 'Minúsculo

        v_titulo_da_pagina = v_titulo_da_pagina.Substring(0, 100) 'Título da página

        v_titulo_da_pagina = v_titulo_da_pagina.Replace("\", " ") 'Removendo

        v_titulo_da_pagina = v_titulo_da_pagina.Replace("/", " ") 'Removendo

        v_titulo_da_pagina = v_titulo_da_pagina.Replace(":", " ") 'Removendo

        v_titulo_da_pagina = v_titulo_da_pagina.Replace("?", " ") 'Removendo

        v_titulo_da_pagina = v_titulo_da_pagina.Replace("*", " ") 'Removendo

        v_titulo_da_pagina = v_titulo_da_pagina.Replace("""", " ") 'Removendo

        v_titulo_da_pagina = v_titulo_da_pagina.Replace("<", " ") 'Removendo

        v_titulo_da_pagina = v_titulo_da_pagina.Replace(">", " ") 'Removendo

        v_titulo_da_pagina = v_titulo_da_pagina.Replace("|", " ") 'Removendo

        v_titulo_da_pagina = v_titulo_da_pagina.Replace(",", " ") 'Removendo

        txt_titulo.Text = v_titulo_da_pagina 'Título da página

        '-------------------------------------------------------------------------------------------------------------------------------




        'Inicializando -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        v_conteudo_a_salvar = txt_favorito_endereco.Text 'Código

        V_PASTA_DE_FAVORITOS_arquivo = v_salvar_na_pasta & v_titulo_da_pagina & v_extencao 'Destino completo do arquivo

        v_mensagem_a_ler = "O favoríto '" & txt_titulo.Text & "' já exíste. Escolha outro nome para o favoríto." 'Mensagem

        '------------------------------------------------------------------------------------------------------------------




        'Verificando se o favoríto já existe -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (My.Computer.FileSystem.FileExists(V_PASTA_DE_FAVORITOS_arquivo) = True) Then


            'Mensagem com janela e voz ao usuário ---------------------------------------------------------------------------------------------------------------------------------


            If (V_VAL_CONFIG_USAR_RECURSO_DE_VOZ = True) Then



                'Ocultando janela atual ----------------

                Me.Hide() 'Ocultando

                '---------------------------------------


                'Mensagem com voz ao usuário -----------------------------------------------------------------------------------------------------

                proc_chamar_mensagem_ao_usuario(v_mensagem_a_ler, v_tipo_ms_1) 'Chama a janela de mensagem ao usuario

                '---------------------------------------------------------------------------------------------------------------------------------


                'Exibindo janela novamente ----------

                Me.Show() 'Exibindo

                '------------------------------------




            Else




                'Mensagem -------------------------------------------------------------------------

                MsgBox(v_mensagem_a_ler, MsgBoxStyle.Exclamation, "Globe - Alerta") 'Alerta

                '----------------------------------------------------------------------------------




            End If


            '----------------------------------------------------------------------------------------------------------------------------------------------------------------------








            Exit Sub 'Saindo do procedimento

        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------




        'Salvar o favoríto agora -------------------------------------------------------------------------------------------------------------------------------

        If (func_verificador() = True) Then


            'Salvando conteúdo ----------------------------------------------------------------------------------

            My.Computer.FileSystem.WriteAllText(V_PASTA_DE_FAVORITOS_arquivo, v_conteudo_a_salvar, True) 'Salvando conteúdo

            '----------------------------------------------------------------------------------------------------


            'Mensagem com janela e voz ao usuário ---------------------------------------------------------------------------------------------------------------------------------


            If (V_VAL_CONFIG_USAR_RECURSO_DE_VOZ = True) Then



                'Ocultando janela atual ----------------

                Me.Hide() 'Ocultando

                '---------------------------------------


                'Mensagem com voz ao usuário -----------------------------------------------------------------------------------------------------

                proc_chamar_mensagem_ao_usuario(V_MS_7, v_tipo_ms_1) 'Chama a janela de mensagem ao usuario

                '---------------------------------------------------------------------------------------------------------------------------------


                'Exibindo janela novamente ----------

                Me.Show() 'Exibindo

                '------------------------------------



            End If


            '----------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'Limpando campos ---------------------------------------------------

            txt_favorito_endereco.Text = Nothing

            cbo_pasta.Text = Nothing

            txt_titulo.Text = Nothing

            v_salvar_na_pasta = Nothing

            '-------------------------------------------------------------------


        End If

        '--------------------------------------------------------------------------------------------------------------




        'Atualizando a lista -------------------------------------------------------------

        proc_listar_pastas_raizes() 'Lista todas as pastas raizes

        '---------------------------------------------------------------------------------


    End Sub




    'Gerenciamento de favorítos

    Private Sub proc_favorito_inicial() 'Ir para o favorito inicial
        On Error Resume Next

        'Selecionando primeira pasta da lista -----------------------------------------------------------------------------

        tree_pastas_de_favoritos.SelectedNode = tree_pastas_de_favoritos.Nodes.Item(v_index_do_favorito) 'favorito da lista

        tree_pastas_de_favoritos.SelectedNode.Nodes.Item(v_index_do_favorito).Checked = True 'Checando favorito

        '------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub proc_listar_favoritos() 'Listar todos os favorítos
        On Error Resume Next

        Dim v_lista_de_sub_diretorios As System.Collections.ObjectModel.ReadOnlyCollection(Of String) 'Listagem de sub-diretorios

        Dim v_contador As Integer 'Contador de looping

        Dim v_quantidade_de_favoritos As Integer 'Informa a quantidade de pastas

        Dim v_nome_da_pasta_a_adicionar As Array 'Informa o nome da pasta a ser adicionada

        Dim v_separador As String = "\" 'Separador do array

        Dim v_nome_na_lista As String 'Nome a ser colocado na listagem




        'Inicializando -------------------------------------------------------------------------------------------------------------------------------------

        v_lista_de_sub_diretorios = My.Computer.FileSystem.GetFiles(v_endereco_da_pasta_selecionada, FileIO.SearchOption.SearchTopLevelOnly)

        v_contador = 0 'Contador de looping

        v_quantidade_de_favoritos = v_lista_de_sub_diretorios.Count - 1 'Informa a quantidade de pastas

        tree_pastas_de_favoritos.Nodes.Item(tree_pastas_de_favoritos.SelectedNode.Index).Nodes.Clear() 'Limpando

        txt_nome_da_pasta.Text = Nothing 'Limpando nome

        '---------------------------------------------------------------------------------------------------------------------------------------------------



        'Varrendo -------------------------------------------------------------------------------------------------------------------------

        For v_contador = v_contador To v_quantidade_de_favoritos


            'Adicionando --------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            v_nome_da_pasta_a_adicionar = Split(v_lista_de_sub_diretorios(v_contador), v_separador) 'Nome da pasta


            v_nome_na_lista = v_nome_da_pasta_a_adicionar(v_nome_da_pasta_a_adicionar.Length - 1) 'Nome a ser colocado na listagem


            tree_pastas_de_favoritos.Nodes.Item(tree_pastas_de_favoritos.SelectedNode.Index).Nodes.Add(v_nome_na_lista, v_nome_na_lista.Replace(v_extencao, Nothing), 2, 2) 'Adicionando pasta...

            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        Next

        '----------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_excluir_favorito() 'Exclui o favoríto em foco
        On Error Resume Next


        'Pergunta ao usuário ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (MsgBox("Deseja mesmo remover o favoríto '" & v_nome_do_favorito_selecionado & "' ?", MsgBoxStyle.YesNo, "Excluir Favoríto - " & v_nome_do_favorito_selecionado) = MsgBoxResult.No) Then

            Exit Sub 'Saindo do procedimento

        End If

        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        'Removendo favoríto ------------------------------------------------------------------------------

        My.Computer.FileSystem.DeleteFile(v_endereco_do_favorito_selecionado) 'Removendo...

        '-------------------------------------------------------------------------------------------------


        'Mensagem com janela e voz ao usuário ---------------------------------------------------------------------------------------------------------------------------------


        If (V_VAL_CONFIG_USAR_RECURSO_DE_VOZ = True) Then



            'Ocultando janela atual ----------------

            Me.Hide() 'Ocultando

            '---------------------------------------


            'Mensagem com voz ao usuário -----------------------------------------------------------------------------------------------------

            proc_chamar_mensagem_ao_usuario(V_MS_6, v_tipo_ms_1) 'Chama a janela de mensagem ao usuario

            '---------------------------------------------------------------------------------------------------------------------------------


            'Exibindo janela novamente ----------

            Me.Show() 'Exibindo

            '------------------------------------



        End If


        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------


        'Atualizando lista --------------------------------------------------

        proc_listar_pastas_raizes() 'Lista todas as pastas raizes

        '--------------------------------------------------------------------


        'Restaurando index --------------------------------------------------

        proc_favorito_inicial() 'Ir para o favorito inicial

        '--------------------------------------------------------------------


    End Sub

    Private Function func_renomear_favorito(ByVal v_novo_nome As String) 'Renomeia o favoríto desejado
        On Error Resume Next

        Dim v_favorito_de_comparacao As String 'Nome de favorito de comparação de existencia

        Dim v_arquivo_a_ser_renomeado As String 'Informa o nome do arquivo a ser renomeado

        Dim v_mensagem_temporaria As String 'Informa a mensagem temporaria






        'Inicializando -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        v_favorito_de_comparacao = v_endereco_da_pasta_selecionada & "\" & v_novo_nome & v_extencao 'Novo nome do arquivo

        v_arquivo_a_ser_renomeado = v_endereco_do_favorito_selecionado 'Endereço do favorito selecionado

        v_mensagem_temporaria = "O nome do favoríto '" & v_novo_nome & "' já existe, tente outro nome." 'Mensagem

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Não pode ser nome em branco -----------------------------------------------------------------------------------------

        If (v_novo_nome = Nothing) Then




            'Informe ao usuário ----------------------------------------------------------------------------------------------

            MsgBox("Você não informou o novo nome do favoríto.", MsgBoxStyle.Information, "Informação ao usuário") 'Informação

            txt_nome_da_pasta.Focus() 'Movendo o foco

            '-----------------------------------------------------------------------------------------------------------------




            'Retorno e saida ----------------------

            Return Nothing

            Exit Function

            '--------------------------------------




        End If

        '---------------------------------------------------------------------------------------------------------------------




        'Verificando se o favoríto já existe ---------------------------------------------------------------------------------


        If (My.Computer.FileSystem.FileExists(v_favorito_de_comparacao) = True) Then




            'Mensagem com janela e voz ao usuário ---------------------------------------------------------------------------------------------------------------------------------


            If (V_VAL_CONFIG_USAR_RECURSO_DE_VOZ = True) Then



                'Ocultando janela atual ----------------

                Me.Hide() 'Ocultando

                '---------------------------------------




                'Mensagem com voz ao usuário -----------------------------------------------------------------------------------------------------

                proc_chamar_mensagem_ao_usuario(v_mensagem_temporaria, v_tipo_ms_1) 'Chama a janela de mensagem ao usuario

                '---------------------------------------------------------------------------------------------------------------------------------




                'Exibindo janela novamente ------------------

                Me.Show() 'Exibindo

                txt_nome_da_pasta.Focus() 'Movendo o foco

                '--------------------------------------------




            Else




                'Informe e mova o foco ------------------------------------------------------------------------------------------------------------------------------

                MsgBox(v_mensagem_temporaria, MsgBoxStyle.Information, "Informação ao usuário") 'Mensagem ao usuário

                txt_nome_da_pasta.Focus() 'Movendo foco

                '----------------------------------------------------------------------------------------------------------------------------------------------------




            End If


            '----------------------------------------------------------------------------------------------------------------------------------------------------------------------




            'Retorno e saida ----------------------

            Return Nothing

            Exit Function

            '--------------------------------------




        End If

        '---------------------------------------------------------------------------------------------------------------------




        'Renomeando pasta agora -------------------------------------------------------------------------------

        v_novo_nome = v_novo_nome & v_extencao 'Nome e extenção

        My.Computer.FileSystem.RenameFile(v_arquivo_a_ser_renomeado, v_novo_nome) 'Renomeando arquivo

        '------------------------------------------------------------------------------------------------------




        'Atualizando lista --------------------------------------------------

        proc_listar_pastas_raizes() 'Lista todas as pastas raizes

        '--------------------------------------------------------------------


    End Function

    Private Sub proc_renomear_item_selecionado() 'Renomeia o item selecionado se é pasta ou favoríto
        On Error Resume Next


        'Verificando nível atual ---------------------------------------------------------------------------------------

        Select Case v_nivel_atual


            Case 0

                'Renomeando a pasta ------------------------------------------------------------------------------------

                func_renomear_pasta(txt_nome_da_pasta.Text) 'Renomeia a pasta desejada

                '-------------------------------------------------------------------------------------------------------




            Case 1

                'Renomear favorito -------------------------------------------------------------------------------------

                func_renomear_favorito(txt_nome_da_pasta.Text) 'Renomeando favorito

                '-------------------------------------------------------------------------------------------------------


        End Select

        '---------------------------------------------------------------------------------------------------------------




        'Voltando a posição original -----------------------------------------------------------------------------------

        proc_pasta_inicial() 'Ir para a pasta inicial

        proc_favorito_inicial() 'Ir para o favorito inicial

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_adicionar_em_visualizacao() 'Adiciona o favorito em visualização
        On Error Resume Next

        'Informando url e título da página -----------------------------------------------------------------------------

        txt_favorito_endereco.Text = func_retorne_o_site_em_aberto() 'Retorna o endereço do site em aberto 'Url

        txt_titulo.Text = func_retorne_o_titulo_do_site_em_aberto() 'Retorna o titulo do site em aberto

        '---------------------------------------------------------------------------------------------------------------

    End Sub




    'Abrindo conteúdo agora

    Private Function func_obter_url_de_favorito(ByVal v_origem_de_arquivo As String) 'Retorna a url do favorito
        On Error Resume Next

        Dim v_url_obtida As String 'Url obtida




        'Inicializar -------------------------------------------------------------------------------------------

        v_url_obtida = My.Computer.FileSystem.ReadAllText(v_origem_de_arquivo) 'Lendo arquivo

        '-------------------------------------------------------------------------------------------------------


        'Retorno ------------------------------------

        Return v_url_obtida 'Url obtida

        '--------------------------------------------


    End Function

    Private Sub proc_abrir_em_pagina_atual() 'Abre a url do favorito na página  atual
        On Error Resume Next

        Dim v_url_a_abrir_favorito As String = Nothing 'Url a ser aberta




        'Obtem endereço de favorito e navega ------------------------------------------------------------------------------------------------

        v_url_a_abrir_favorito = func_obter_url_de_favorito(v_endereco_do_favorito_selecionado) 'Retorna a url do favorito

        proc_navegar(v_url_a_abrir_favorito, v_tipo_de_motor_layout_engine_em_uso_agora, v_qual_motor_esta_em_uso) 'NAVEGA NO SITE SOLICITADO PELO USUARIO

        '------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub proc_abrir_em_nova_aba() 'Abre a url do favorito em uma nova aba
        On Error Resume Next

        Dim v_url_a_abrir_favorito As String = Nothing 'Url a ser aberta




        'Obtem endereço de favorito e navega ------------------------------------------------------------------------------------------------

        v_url_a_abrir_favorito = func_obter_url_de_favorito(v_endereco_do_favorito_selecionado) 'Retorna a url do favorito

        proc_adicionador_de_nova_aba_e_motor(True) 'Adiciona o motor geckofx ou não. True para sim e false para nao

        FRM_NAVEGACAO.TabControl1.SelectedTabIndex = FRM_NAVEGACAO.TabControl1.Tabs.Count - 1

        proc_navegar(v_url_a_abrir_favorito, v_tipo_de_motor_layout_engine_em_uso_agora, v_qual_motor_esta_em_uso) 'NAVEGA NO SITE SOLICITADO PELO USUARIO

        '------------------------------------------------------------------------------------------------------------------------------------


    End Sub




    'Procedimentos básicos

    Private Sub proc_sair() 'Sai da janela atual
        On Error Resume Next

        Me.Close() 'Saindo

    End Sub

    Private Sub proc_voz_calar() 'Não falar mais ao sair
        On Error Resume Next

        proc_calar_voz_do_motor_tts() 'Cala a voz do motor tts

    End Sub

    Private Sub proc_listar_favoritos_solicitado() 'Listar os favoritos solicitado
        On Error Resume Next


        'Somente lista ou adiciona aos favoritos ------------------------------------------------------------------------

        If (v_listar_favoritos = True) Then

            TabControl1.SelectedTab = TabItem3 'Selecionando o listar favoritos

        Else

            proc_adicionar_em_visualizacao() 'Adiciona o favorito em visualização

            TabControl1.SelectedTab = TabItem1 'Adicionar

        End If

        '----------------------------------------------------------------------------------------------------------------




        'Gerencia -------------------------------------------------------------------------------------------------------

        If (v_gerenciar_favoritos = True) Then


            TabControl1.SelectedTab = TabItem2 'Gerenciamento


        End If

    End Sub

    Private Sub proc_inicializador() 'Inicializador de variáveis e procedimentos
        On Error Resume Next


        'Procedimentos -----------------------------------------------------------------------------------------------

        proc_listar_favoritos_solicitado() 'Listar os favoritos solicitado

        proc_listar_pastas_raizes() 'Lista todas as pastas raizes

        proc_listar_somente_pastas_em_lista_de_combinacao() 'Lista somente as pastas na lista de combinação

        '------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual
        On Error Resume Next

        Me.Opacity = V_VAL_CONFIG_TRANSPARENCIA 'Aplicando a transparencia

    End Sub








    'Procedimentos basicos

    'Fazendo o navegador trabalhar menos temporariamente

    Private Sub proc_ativa_modo_menos_processamento() 'Ativa o modo menos processamento
        On Error Resume Next


        'Lendo configuração ---------------------------------------------------------------------------------------------

        v_ultima_configuracao_do_modo_geek = V_VAL_CONFIG_MODO_GEEK_ATIVADO 'Atualizando valor original da configuração

        '----------------------------------------------------------------------------------------------------------------




        'Definindo configuração temporaria ------------------------------------------------------------------------------

        V_VAL_CONFIG_MODO_GEEK_ATIVADO = True 'Ativando o modo geek temporario

        '----------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub proc_desativa_modo_menos_processamento() 'Desativa o modo menos processamento
        On Error Resume Next

        'Restaurando valor original ------------------------------------------------------------------------------------

        V_VAL_CONFIG_MODO_GEEK_ATIVADO = v_ultima_configuracao_do_modo_geek 'Restaurando valor original

        '---------------------------------------------------------------------------------------------------------------




        'Removendo valor de variável -----------------------------------------------------------------------------------

        v_ultima_configuracao_do_modo_geek = Nothing 'Valor nulo

        '---------------------------------------------------------------------------------------------------------------




        'Atualizando propriedades nao atualizadas ----------------------------------------------------------------------------------------------------------------

        Proc_atualizar_propriedades_site_carregar_completo(v_qual_motor_esta_em_uso) 'Atualiza as propriedades quando a pagina estiver carregada por completo

        '---------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub




















    Private Sub frm_favoritos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next


        'Inicializando procedimentos -----------------------------------------------------------------------------------

        proc_ativa_modo_menos_processamento() 'Ativa o modo menos processamento

        proc_aplicar_transparencia() 'Aplica a transparencia no formulário atual

        proc_inicializador() 'Inicializador de variáveis e procedimentos

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub frm_favoritos_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next

        proc_desativa_modo_menos_processamento() 'Desativa o modo menos processamento

        proc_voz_calar() 'Não falar mais ao sair

    End Sub

    Private Sub tree_pastas_de_favoritos_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tree_pastas_de_favoritos.AfterSelect
        On Error Resume Next


        'Informando index da lista ----------------------------------------------------------------

        If (e.Node.Level = 0) Then

            v_index_da_pasta = tree_pastas_de_favoritos.SelectedNode.Index 'Index

        End If

        '------------------------------------------------------------------------------------------




        'Informando o index do favorito -----------------------------------------------------------

        If (e.Node.Level = 0) Then

            v_index_do_favorito = tree_pastas_de_favoritos.SelectedNode.Index 'Index

        End If

        '------------------------------------------------------------------------------------------




        'Só aceitar pasta raiz ---------------------------------------------------------------------------------------------------------------


        If (e.Node.Level = 0) Then




            'Informando o nome da pasta selecionada ----------------------------------------------------------------------

            v_nome_da_pasta_selecionada = e.Node.Text 'Nome da pasta selecionada

            '-------------------------------------------------------------------------------------------------------------




            'Informando o endereço da pasta selecionada ------------------------------------------------------------------

            v_endereco_da_pasta_selecionada = V_PASTA_DE_FAVORITOS & "\" & e.Node.Text 'Endereço da pasta

            '-------------------------------------------------------------------------------------------------------------




        End If


        '-------------------------------------------------------------------------------------------------------------------------------------




        'So aceitar favoritos ----------------------------------------------------------------------------------------------------------------


        If (e.Node.Level = 1) Then




            'Nome do favorito -------------------------------------------------------------------------

            v_nome_do_favorito_selecionado = e.Node.Text 'Nome do favorito selecionado

            '------------------------------------------------------------------------------------------




            'Endereço do favorito -----------------------------------------------------------------------------------------------------------------------

            v_endereco_do_favorito_selecionado = V_PASTA_DE_FAVORITOS & "\" & v_nome_da_pasta_selecionada & "\" & e.Node.Text & v_extencao 'Endereço do favorito

            '--------------------------------------------------------------------------------------------------------------------------------------------




        End If


        '-------------------------------------------------------------------------------------------------------------------------------------




        'Selecionando tipo de menu agora ---------------------------------------------

        Select Case e.Node.Level


            Case 0

                tree_pastas_de_favoritos.ContextMenuStrip = mnu_pastas 'Pastas


            Case 1

                tree_pastas_de_favoritos.ContextMenuStrip = mnu_favoritos 'Favoritos


        End Select

        '----------------------------------------------------------------------------




        'Verificando nível e atualizando listagem --------------------------------------------------------------------------------------------

        If (e.Node.Level = 0) Then




            'Listar favorítos --------------------------------------------------------------------------------------

            proc_listar_favoritos() 'Listar todos os favorítos

            '-------------------------------------------------------------------------------------------------------




            'Listando agora as pastas na lista de combinação -------------------------------------------------------

            proc_listar_somente_pastas_em_lista_de_combinacao() 'Lista somente as pastas na lista de combinação

            '-------------------------------------------------------------------------------------------------------




        End If

        '-------------------------------------------------------------------------------------------------------------------------------------




        'Exibição de controles ---------------------------------------------------------------------

        'Não

        If (e.Node.Level = 1) Then


            cmd_excluir.Enabled = False 'Excluir desabilitado

            cmd_nova.Enabled = False 'Nova desabilitado


        End If




        'Sim

        If (e.Node.Level = 0) Then


            cmd_excluir.Enabled = True 'Excluir habilitado

            cmd_nova.Enabled = True 'Nova habilitado


        End If

        '-------------------------------------------------------------------------------------------




        'Informando o nivel atual --------------------------------

        v_nivel_atual = e.Node.Level 'Nível atual

        '---------------------------------------------------------




        'Informando o nome na caixa de nome ------------------------------------------

        txt_nome_da_pasta.Text = e.Node.Text 'Nome da pasta selecionada

        '-----------------------------------------------------------------------------


    End Sub

    Private Sub ButtonX7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_renomear.Click
        On Error Resume Next

        proc_renomear_item_selecionado() 'Renomeia o item selecionado se é pasta ou favoríto

    End Sub

    Private Sub ButtonX8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_excluir.Click
        On Error Resume Next

        proc_excluir_pasta() 'Exclui a pasta em foco

    End Sub

    Private Sub txt_nome_da_pasta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_nome_da_pasta.KeyDown
        On Error Resume Next


        'Ao pressionar enter --------------------------------------------------------------------------------------------------------

        If (e.KeyCode = Keys.Enter) Then


            'Não emitir bip ------------------------------------------

            e.SuppressKeyPress = True 'Não emitir bip sonoro

            '---------------------------------------------------------


            'Renomeando item ---------------------------------------------------------------------------------------

            proc_renomear_item_selecionado() 'Renomeia o item selecionado se é pasta ou favoríto

            '-------------------------------------------------------------------------------------------------------


        End If

        '----------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub ButtonX5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nova.Click
        On Error Resume Next

        proc_nova_pasta() 'Nova pasta

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        On Error Resume Next

        proc_nova_pasta() 'Nova pasta

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        On Error Resume Next

        proc_excluir_pasta() 'Exclui a pasta em foco

    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        On Error Resume Next

        'Renomeando a pasta ------------------------------------------------------------------------------------

        func_renomear_pasta(txt_nome_da_pasta.Text) 'Renomeia a pasta desejada

        '-------------------------------------------------------------------------------------------------------
    End Sub

    Private Sub ButtonX3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        On Error Resume Next

        proc_sair() 'Sai da janela atual

    End Sub

    Private Sub cbo_pasta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_pasta.SelectedIndexChanged
        On Error Resume Next

        proc_definir_pasta_onde_sera_salvo() 'Definindo onde será salvo o favoríto

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        On Error Resume Next

        proc_salvar_favorito() 'Salva o favoríto

    End Sub

    Private Sub RemoverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoverToolStripMenuItem.Click
        On Error Resume Next

        proc_excluir_favorito() 'Exclui o favoríto em foco

    End Sub

    Private Sub AbrirFavorítoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirFavorítoToolStripMenuItem.Click
        On Error Resume Next

        proc_abrir_em_pagina_atual() 'Abre a url do favorito na página  atual

    End Sub

    Private Sub AbrirFavorítoEmNovaAbaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirFavorítoEmNovaAbaToolStripMenuItem.Click
        On Error Resume Next

        proc_abrir_em_nova_aba() 'Abre a url do favorito em uma nova aba

    End Sub

    Private Sub tree_pastas_de_favoritos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tree_pastas_de_favoritos.DoubleClick
        On Error Resume Next


        'Verifica nivel atual -------------------------------------------------------------------------------------

        If (v_nivel_atual = 1) Then

            proc_abrir_em_pagina_atual() 'Abre a url do favorito na página  atual

        End If

        '----------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        On Error Resume Next

        proc_adicionar_em_visualizacao() 'Adiciona o favorito em visualização

    End Sub

    Private Sub ReToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReToolStripMenuItem.Click
        On Error Resume Next


        'Renomeando item ---------------------------------------------------------------------------------------

        proc_renomear_item_selecionado() 'Renomeia o item selecionado se é pasta ou favoríto

        '-------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        On Error Resume Next

        proc_fazer_backup_de_todos_os_favoritos() 'Faz backup de todos os favoritos

    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        On Error Resume Next

        proc_restaurar_backup_de_todos_os_favoritos() 'Restaura o backup de todos os favoritos

    End Sub

    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        On Error Resume Next

        proc_sair() 'Sai da janela atual

    End Sub

End Class