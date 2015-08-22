Module Modulo_de_conexao_com_a_internet


    'Variáveis de resposta de testes

    Public v_site_online_resp_teste_conexao As Boolean 'Resposta do teste de conexão

    Public v_endereco_da_pagina_teste_de_site_online As String = Nothing 'Informa o endereço do site a ser feito o teste de site online

    Public v_endereco_do_endereco_url_ou_host_a_ser_aberto As String = Nothing 'Informa o endereço do site a ser feito o teste de conectividade, para ver se o mesmo está online ou não

    Public v_host_url_esta_online_1 As Boolean = True 'Informa se o host ou url está ou não disponivel

    Public v_host_url_esta_online_2 As Boolean = True 'Informa se o host ou url está ou não disponivel

    Public v_host_url_esta_online_3 As Boolean = True 'Informa se o host ou url está ou não disponivel

    Public v_tem_internet As Boolean = True 'Informa se tem ou nao internet

















    'Procedimentos

    '# SITE ONLINE PARA TESTE COM LINKS

    Public Sub proc_teste_de_pagina() 'Teste de página pra ver se responde a requisição WebRequest

        'Define uma URL válida para consultar

        Dim url As New System.Uri(v_endereco_da_pagina_teste_de_site_online)



        'Monta a requisição HTTP

        Dim req As System.Net.WebRequest

        req = System.Net.WebRequest.Create(url)



        'Tenta fazer a requisição

        Try

            Dim resp As System.Net.WebResponse

            resp = req.GetResponse()

            resp.Close()

            req = Nothing



            'Tudo certo... Temos conexão com a Internet

            v_site_online_resp_teste_conexao = True 'Sim



        Catch ex As Exception

            'Não deu... Conexão não dispon¡vel

            req = Nothing

            v_site_online_resp_teste_conexao = False 'Não



        End Try


    End Sub

    Public Sub processar_resposta_teste_site_online() 'Resposta do teste de site online
        On Error Resume Next

        Dim OBJ_ITEM As New ToolStripMenuItem 'Novo item do menu

        Static V_NUM As Integer 'Numero da mensagem






        'Não permite valor nulo ou em branco -----------------------------------------------------------------------------------------

        If (v_endereco_da_pagina_teste_de_site_online = Nothing) Or (v_endereco_da_pagina_teste_de_site_online = "") Then

            Exit Sub

        End If

        '-----------------------------------------------------------------------------------------------------------------------------




        'Informa se o site esta ou não online -------------------------------------------------------------------------------------------------------------------------------

        If (v_site_online_resp_teste_conexao = True) Then


            FRM_NAVEGACAO.ToolStripStatusLabel1.Text = "On-line" 'Online
            FRM_NAVEGACAO.ToolStripStatusLabel1.Image = FRM_NAVEGACAO.LST_3.Images.Item(1) 'Online
            proc_som_de_evento_ouvir(v_som_de_online) 'Ouvir o som de evento


        Else


            FRM_NAVEGACAO.ToolStripStatusLabel1.Text = "Possívelmente Off-line" 'Offline
            FRM_NAVEGACAO.ToolStripStatusLabel1.Image = FRM_NAVEGACAO.LST_3.Images.Item(2) 'Offline
            proc_som_de_evento_ouvir(v_som_de_offline) 'Ouvir o som de evento
            V_NUM = V_NUM + 1 'Incrementando numero
            OBJ_ITEM.Text = "Mensagem " & V_NUM & " O endereço abaixo pode estar indisponível." & vbCrLf & v_endereco_da_pagina_teste_de_site_online & vbCrLf 'Mensagem
            FRM_NAVEGACAO.ToolStripStatusLabel1.DropDownItems.Add(OBJ_ITEM) 'Atualizando...


        End If

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_iniciar_teste_site_online(ByVal v_origem As String) 'Inicia o teste do site online
        On Error Resume Next

        Static v_ultimo_valor As String 'Informa ultimo valor de origem






        'Inicializando variáveis necessárias ---------------------------------------------------------------------------

        v_endereco_da_pagina_teste_de_site_online = v_origem 'Informando o endereço a ser usado

        '---------------------------------------------------------------------------------------------------------------




        'Verifica condições -----------------------------------------------------------------------------------------------------------------------------------------------------------------

        If (v_origem = Nothing) Or (V_VAL_CONFIG_RECURSO_TESTE_DE_PAGINA_ONLINE = False) Or (v_origem.StartsWith("javascript:") = True) Or (v_ultimo_valor = v_origem) Then


            v_ultimo_valor = v_origem 'Informando...

            Exit Sub 'Saindo...


        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Iniciando processo --------------------------------------------------------------------------------------------

        FRM_NAVEGACAO.BCK_SITE_ONLINE.RunWorkerAsync() 'Rodando processo

        '---------------------------------------------------------------------------------------------------------------




        'Informando ultimo valor lido ------------------

        v_ultimo_valor = v_origem 'Informando...

        '-----------------------------------------------


    End Sub










    'SITE ONLINE PARA TESTE DE URL PARA ABRIR PAGINA DE SITE

    'Ping

    Public Sub proc_teste_de_ter_internet_ao_abrir_site() 'Teste de internet ao abrir site
        On Error Resume Next

        'Não permite host sem protocolo --------------------------------------------------------------------------------


        If (host_teste_1.StartsWith("http://") = False) Then

            host_teste_1 = "http://" & host_teste_1

        End If


        If (host_teste_2.StartsWith("http://") = False) Then

            host_teste_2 = "http://" & host_teste_2

        End If


        If (host_teste_3.StartsWith("http://") = False) Then

            host_teste_3 = "http://" & host_teste_3

        End If


        '---------------------------------------------------------------------------------------------------------------




        Dim url_1 As New System.Uri(host_teste_1) 'Host

        Dim url_2 As New System.Uri(host_teste_2) 'Host

        Dim url_3 As New System.Uri(host_teste_3) 'Host

        Dim v_ping_1, v_ping_2, v_ping_3 As Boolean 'Pings






        'Efetuando ping ------------------------------------------------------------------------------------------------

        v_ping_1 = My.Computer.Network.Ping(url_1.Host) 'Ping 1

        v_ping_2 = My.Computer.Network.Ping(url_2.Host) 'Ping 2

        v_ping_3 = My.Computer.Network.Ping(url_3.Host) 'Ping 3

        '---------------------------------------------------------------------------------------------------------------




        'Resposta do teste de conexao ----------------------------------------------------------------------------------

        If (v_ping_1 = True) Or (v_ping_2 = True) Or (v_ping_3 = True) Then

            v_tem_internet = True 'Informa que tem internet

            Exit Sub 'Saindo...

        End If

        '---------------------------------------------------------------------------------------------------------------




        'Resposta do teste de conexao ----------------------------------------------------------------------------------

        If (v_ping_1 = False) And (v_ping_2 = False) And (v_ping_3 = False) Then

            v_tem_internet = False 'Informa que nao tem internet

        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub




    'Webrequest

    Public Sub proc_teste_de_url_ou_host_disponivel_1() 'Informa se a url ou host está ou não disponivel

        'Define uma URL válida para consultar

        Dim url As New System.Uri(v_endereco_do_endereco_url_ou_host_a_ser_aberto)



        'Monta a requisição HTTP

        Dim req As System.Net.WebRequest

        req = System.Net.WebRequest.Create(url)



        'Tenta fazer a requisição

        Try

            Dim resp As System.Net.WebResponse

            resp = req.GetResponse()

            resp.Close()

            req = Nothing



            'Tudo certo... Temos conexão com a Internet

            v_host_url_esta_online_1 = True 'Sim



        Catch ex As Exception

            'Não deu... Conexão não dispon¡vel

            req = Nothing

            v_host_url_esta_online_1 = False 'Não




        End Try


    End Sub

    Public Sub proc_teste_de_url_ou_host_disponivel_2() 'Informa se a url ou host está ou não disponivel

        'Define uma URL válida para consultar

        Dim url As New System.Uri(v_endereco_do_endereco_url_ou_host_a_ser_aberto)



        'Monta a requisição HTTP

        Dim req As System.Net.WebRequest

        req = System.Net.WebRequest.Create(url)



        'Tenta fazer a requisição

        Try

            Dim resp As System.Net.WebResponse

            resp = req.GetResponse()

            resp.Close()

            req = Nothing



            'Tudo certo... Temos conexão com a Internet

            v_host_url_esta_online_2 = True 'Sim



        Catch ex As Exception

            'Não deu... Conexão não dispon¡vel

            req = Nothing

            v_host_url_esta_online_2 = False 'Não

            proc_teste_de_url_ou_host_disponivel_1() 'Informa se a url ou host está ou não disponivel


        End Try


    End Sub

    Public Sub proc_teste_de_url_ou_host_disponivel_3() 'Informa se a url ou host está ou não disponivel

        'Define uma URL válida para consultar

        Dim url As New System.Uri(v_endereco_do_endereco_url_ou_host_a_ser_aberto)



        'Monta a requisição HTTP

        Dim req As System.Net.WebRequest

        req = System.Net.WebRequest.Create(url)



        'Tenta fazer a requisição

        Try

            Dim resp As System.Net.WebResponse

            resp = req.GetResponse()

            resp.Close()

            req = Nothing



            'Tudo certo... Temos conexão com a Internet

            v_host_url_esta_online_3 = True 'Sim



        Catch ex As Exception

            'Não deu... Conexão não dispon¡vel

            req = Nothing

            v_host_url_esta_online_3 = False 'Não

            proc_teste_de_url_ou_host_disponivel_2() 'Informa se a url ou host está ou não disponivel


        End Try


    End Sub

    Public Sub proc_verificar_se_endereco_informado_esta_disponivel(ByVal v_endereco_host_ou_url As String) 'Informa se o endereço do site informado esta, ou não disponivel
        On Error Resume Next


        'Não permite valores nulos ou em branco ---------------------------------------------------------------------------------------------------

        If (v_endereco_host_ou_url = Nothing) Or (v_endereco_host_ou_url = "") Or (V_VAL_CONFIG_AVISE_ERRO_ABRIR_SITE = False) Then

            Exit Sub

        End If

        '------------------------------------------------------------------------------------------------------------------------------------------




        'Setando variável de teste de conexao ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        v_endereco_do_endereco_url_ou_host_a_ser_aberto = v_endereco_host_ou_url 'Setando valor de host ou url




        '# ADICIONANDO PROTOCOLO

        If (v_endereco_do_endereco_url_ou_host_a_ser_aberto.StartsWith("http://") = False) And (v_endereco_do_endereco_url_ou_host_a_ser_aberto.StartsWith("https://") = False) And (v_endereco_do_endereco_url_ou_host_a_ser_aberto.StartsWith("ftp://") = False) Then


            v_endereco_do_endereco_url_ou_host_a_ser_aberto = "http://" & v_endereco_do_endereco_url_ou_host_a_ser_aberto


        End If


        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Iniciando processo de teste -----------------------------------------------------------------------------------

        FRM_NAVEGACAO.BCK_HOST_URL_ONLINE.CancelAsync() 'Cancela ultimo teste

        FRM_NAVEGACAO.BCK_HOST_URL_ONLINE.RunWorkerAsync() 'Ativando novo processo

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_resposta_do_teste_de_url_host_disponivel_abrir_site() 'Informa a resposta do teste de host e url disponivel
        On Error Resume Next


        'Verificando se a resposta do teste é offline -----------------------------------------------------------------------------------------------------------------

        If (v_host_url_esta_online_1 = False) And (v_host_url_esta_online_2 = False) And (v_host_url_esta_online_3 = False) Then




            'Exibe ou nao o erro dependendo de quem chamou -----------------------------------------------


            proc_chamar_janela_de_erro_ao_abrir_site() 'Chama a janela de erro ao abrir site


            '---------------------------------------------------------------------------------------------




        End If

        '--------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub






















End Module
