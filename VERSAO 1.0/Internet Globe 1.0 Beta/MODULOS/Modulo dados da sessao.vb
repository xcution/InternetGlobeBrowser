Module Modulo_dados_da_sessao


    'Variáveis de sessão

    Public v_pilha_de_sessao_de_navegacao_atual(v_quant_maxima_de_abas_abertas) As String 'Pilha da sessao de navegação atual

    Public v_resposta_reabre_ou_inicia_nova_sessao As Boolean 'Informa se restaura a sessao anterior, ou inicia uma nova

    Public v_pode_encerrar_formulario_principal As Boolean 'Informa se pode ou nao encerrar o formulario principal

    Public v_sessao_encerrou_corretamente As Boolean  'Informa se a sessão encerrou corretamente

    Public v_quantidade_de_pop_ups_abertas As Integer = 0 'Informa a quantidade de pop-ups abertas

    Public v_pilha_da_sessao_atual_navegacao_pop_up(v_quant_maxima_de_pop_ups_abertas) As String 'Pilha das pop-ups
















    'Procedimentos basicos para salvar a sessao

    Public Sub proc_atualize_variaveis_de_sessao(ByVal v_url As String, ByVal v_token As Integer) 'Atualiza as variáveis de sessao
        On Error Resume Next

        v_pilha_de_sessao_de_navegacao_atual(v_token) = v_url 'Atualizando variável de sessao de navegação

    End Sub

    Public Sub proc_salvar_sessao_de_navegacao_atual() 'Salva a sessão de navegação atual
        On Error Resume Next

        Dim v_sessao_atual_url As String = Nothing 'Variável de sessão geral






        'Atualizando valores ------------------------------------------------------------------------------------------------------------------

        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(0) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(1) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(2) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(3) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(4) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(5) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(6) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(7) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(8) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(9) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(10) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(11) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(12) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(13) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(14) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(15) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(16) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(17) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(18) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(19) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(20) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(21) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(22) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(23) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(24) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(25) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(26) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(27) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(28) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(29) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(30) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(31) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(32) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(33) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(34) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(35) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(36) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(37) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(38) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(39) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(40) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(41) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(42) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(43) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(44) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(45) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(46) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(47) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(48) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(49) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(50) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(51) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(52) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(53) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(54) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(55) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(56) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(57) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(58) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(59) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(60) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(61) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(62) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(63) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(64) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(65) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(66) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(67) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(68) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(69) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(70) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(71) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(72) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(73) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(74) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(75) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(76) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(77) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(78) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(79) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(80) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(81) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(82) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(83) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(84) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(85) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(86) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(87) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(88) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(89) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(90) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(91) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(92) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(93) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(94) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(95) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(96) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(97) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(98) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(99) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(100) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(101) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(102) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(103) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(104) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(105) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(106) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(107) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(108) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(109) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(110) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(111) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(112) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(113) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(114) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(115) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(116) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(117) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(118) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(119) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(120) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(121) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(122) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(123) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(124) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(125) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(126) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(127) 'Valor da url
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_de_sessao_de_navegacao_atual(128) 'Valor da url

        '--------------------------------------------------------------------------------------------------------------------------------------




        'Removendo valores invalidos -----------------------------------------------------------------------------------

        v_sessao_atual_url = v_sessao_atual_url.Replace("about:blank,", Nothing) 'Pagina em branco

        '---------------------------------------------------------------------------------------------------------------




        'Salva sessão atual, e informa se o navegador foi encerrado corretamente --------------------------------------------------------------

        proc_salvar_valor(v_sessao_atual_url, V_ARQ_CONFIG_SESSAO_URLS_SALVAS) 'Salva a configuração

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_informar_encerrou_sessao_corretamente(ByVal v_valor As Boolean) 'Informa que encerrou a sessão corretamente
        On Error Resume Next

        proc_salvar_valor(v_valor, V_ARQ_CONFIG_SESSAO_ENCERROU_CORRETAMENTE) 'Salva a configuração

    End Sub




    'Procedimentos basicos para reabrir a sessao

    Private Sub proc_restaure_sessao_agora() 'Restaura a sessao propriamente dito
        On Error Resume Next

        Dim V_LISTA_SESSAO_URL As String = func_ler_valor(V_ARQ_CONFIG_SESSAO_URLS_SALVAS) 'Retorna o valor do arquivo lido

        Dim V_LISTA_SESSAO_URL_ARRAY As Array = Split(V_LISTA_SESSAO_URL, v_separador_de_string_2) 'Separando urls

        Dim V_QUANTIDADE_DE_ITENS As Integer = V_LISTA_SESSAO_URL_ARRAY.Length 'Quantidade de itens

        Dim V_CONTADOR As Integer = 0 'Contador de looping






        'Varrendo e reabrindo abas -----------------------------------------------------------------------------------------------------------------------------------

        For V_CONTADOR = V_CONTADOR To V_QUANTIDADE_DE_ITENS




            'Obtendo o valor de url de sessão -----------------------------------------------------------------------------------------------------------------------

            Dim V_VALOR_OBTIDO_TEMP As String = V_LISTA_SESSAO_URL_ARRAY(V_CONTADOR) 'Valor de url

            '--------------------------------------------------------------------------------------------------------------------------------------------------------




            'Adicionando nova aba -----------------------------------------------------------------------------------------------------------------------------------

            If (V_VALOR_OBTIDO_TEMP <> Nothing) Then


                proc_adicionador_de_nova_aba_e_motor(True) 'Adiciona o motor geckofx ou não. True para sim e false para nao

                proc_abrir_site_motor_geckofx(V_VALOR_OBTIDO_TEMP, v_qual_motor_esta_em_uso) 'Abre a página solicitada no Geckofx


            End If

            '--------------------------------------------------------------------------------------------------------------------------------------------------------




        Next

        '--------------------------------------------------------------------------------------------------------------------------------------------------------




        'Restaura as pop ups agora caso necessario ----------------------------------------------------------------------------------

        proc_inicializar_e_restaurar_ultima_sessao_pop_up() 'Inicializa e restaura a ultima sessao pop up

        '----------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_inicializar_e_restaurar_ultima_sessao() 'Inicializa e restaura a ultima sessao
        On Error Resume Next

        Dim v_resposta_do_arquivo_de_configuracao As String 'Armazena a resposta do arquivo de configuração






        'Lendo valor de configuração ----------------------------------------------------------------------------------------------------------

        v_resposta_do_arquivo_de_configuracao = func_ler_valor(V_ARQ_CONFIG_SESSAO_ENCERROU_CORRETAMENTE) 'Retorna o valor do arquivo lido

        '--------------------------------------------------------------------------------------------------------------------------------------




        'Verificando se o navegador foi aberto, via comando externo ----------------------------------------------------

        If (V_VAL_ENDERECO_URL_RECEBIDO_VIA_COMANDO_EXTERNO <> Nothing) Then

            v_resposta_do_arquivo_de_configuracao = True 'Informando que a sessao foi encerrada corretamente

        End If

        '---------------------------------------------------------------------------------------------------------------




        'Caso não haja resposta lida o arquivo -------------------------------------------------------------------------

        If (v_resposta_do_arquivo_de_configuracao = "") Then


            v_sessao_encerrou_corretamente = True 'Encerrou corretamente


        Else


            v_sessao_encerrou_corretamente = v_resposta_do_arquivo_de_configuracao 'Encerrou corretamente


        End If

        '---------------------------------------------------------------------------------------------------------------


        '--------------------------------------------------------------------------------------------------------------------------------------




        'Restaura ou inicia nova sessao -------------------------------------------------------------------------------------------------------


        If (v_sessao_encerrou_corretamente = True) Then




            proc_adicionador_de_nova_aba_e_motor(True) 'Adiciona o motor geckofx ou não. True para sim e false para nao




        Else




            '2ª IF ----------------------------------------------------------------------------------------------------------------------------

            '# 1ª Chama a janela restauradoda de sessao

            proc_chamar_janela_de_restaurar_sessao() 'Chama a janela de restauração de sessao




            '2ª Informa que não pode exibir a janela de apresentação, em caso da configuração dizer que pode

            V_VAL_CONFIG_TELA_DE_BOAS_VINDAS = False 'Não exibir a tela de boas vindas




            '# 3ª Comparando a resposta repassada pelo usuario

            If (v_resposta_reabre_ou_inicia_nova_sessao = True) Then




                v_sessao_encerrou_corretamente = True 'Informando que pode abrir a pagina inicial home

                proc_adicionador_de_nova_aba_e_motor(True) 'Adiciona o motor geckofx ou não. True para sim e false para nao




            Else




                proc_restaure_sessao_agora() 'Restaura a sessao propriamente dito




            End If

            '----------------------------------------------------------------------------------------------------------------------------------



        End If

        '--------------------------------------------------------------------------------------------------------------------------------------




        'Informando que uma nova sessao foi iniciada --------------------------------------------------------------------------------

        proc_informar_encerrou_sessao_corretamente(False) 'Informa que encerrou a sessão corretamente

        '----------------------------------------------------------------------------------------------------------------------------




        'Informando que uma nova sessao foi iniciada -------------------------------------------------------------------

        proc_informar_encerrou_sessao_corretamente_pop_up(False) 'Informa que encerrou a sessão corretamente

        proc_salvar_valor(Nothing, V_ARQ_CONFIG_SESSAO_URLS_SALVAS_POP_UPS) 'Salva a configuração

        '---------------------------------------------------------------------------------------------------------------


    End Sub








    'Procedimentos de sessao pop up

    Public Sub proc_atualize_variaveis_de_sessao_pop_up(ByVal v_url As String, ByVal v_token As Integer) 'Atualiza as variáveis de sessao pop-up
        On Error Resume Next

        v_pilha_da_sessao_atual_navegacao_pop_up(v_token) = v_url 'Atualizando variável de sessao de navegação

    End Sub

    Public Sub proc_salvar_sessao_de_navegacao_atual_pop_up() 'Salva a sessão de navegação atual das pop ups
        On Error Resume Next

        Dim v_sessao_atual_url As String = Nothing 'Variável de sessão geral






        'Atualizando valores ------------------------------------------------------------------------------------------------------------------


        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(1)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(2)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(3)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(4)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(5)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(6)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(7)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(8)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(9)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(10)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(11)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(12)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(13)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(14)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(15)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(16)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(17)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(18)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(19)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(20)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(21)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(22)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(23)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(24)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(25)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(26)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(27)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(28)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(29)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(30)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(31)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(32)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(33)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(34)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(35)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(36)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(37)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(38)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(39)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(40)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(41)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(42)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(43)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(44)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(45)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(46)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(47)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(48)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(49)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(50)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(51)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(52)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(53)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(54)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(55)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(56)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(57)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(58)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(59)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(60)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(61)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(62)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(63)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(64)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(65)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(66)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(67)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(68)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(69)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(70)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(71)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(72)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(73)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(74)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(75)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(76)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(77)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(78)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(79)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(80)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(81)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(82)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(83)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(84)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(85)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(86)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(87)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(88)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(89)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(90)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(91)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(92)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(93)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(94)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(95)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(96)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(97)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(98)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(99)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(100)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(101)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(102)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(103)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(104)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(105)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(106)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(107)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(108)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(109)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(110)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(111)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(112)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(113)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(114)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(115)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(116)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(117)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(118)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(119)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(120)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(121)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(122)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(123)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(124)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(125)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(126)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(127)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(128)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(129)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(130)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(131)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(132)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(133)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(134)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(135)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(136)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(137)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(138)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(139)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(140)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(141)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(142)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(143)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(144)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(145)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(146)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(147)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(148)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(149)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(150)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(151)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(152)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(153)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(154)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(155)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(156)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(157)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(158)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(159)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(160)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(161)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(162)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(163)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(164)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(165)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(166)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(167)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(168)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(169)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(170)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(171)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(172)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(173)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(174)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(175)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(176)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(177)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(178)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(179)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(180)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(181)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(182)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(183)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(184)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(185)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(186)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(187)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(188)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(189)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(190)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(191)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(192)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(193)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(194)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(195)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(196)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(197)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(198)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(199)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(200)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(201)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(202)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(203)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(204)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(205)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(206)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(207)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(208)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(209)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(210)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(211)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(212)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(213)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(214)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(215)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(216)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(217)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(218)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(219)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(220)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(221)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(222)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(223)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(224)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(225)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(226)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(227)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(228)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(229)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(230)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(231)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(232)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(233)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(234)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(235)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(236)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(237)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(238)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(239)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(240)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(241)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(242)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(243)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(244)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(245)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(246)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(247)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(248)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(249)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(250)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(251)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(252)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(253)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(254)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(255)
        v_sessao_atual_url = v_sessao_atual_url & v_separador_de_string_2 & v_pilha_da_sessao_atual_navegacao_pop_up(256)


        '--------------------------------------------------------------------------------------------------------------------------------------




        'Removendo valores invalidos -----------------------------------------------------------------------------------

        v_sessao_atual_url = v_sessao_atual_url.Replace("about:blank,", Nothing) 'Pagina em branco

        '---------------------------------------------------------------------------------------------------------------




        'Salva sessão atual, e informa se o navegador foi encerrado corretamente --------------------------------------------------------------

        proc_salvar_valor(v_sessao_atual_url, V_ARQ_CONFIG_SESSAO_URLS_SALVAS_POP_UPS) 'Salva a configuração

        '--------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_informar_encerrou_sessao_corretamente_pop_up(ByVal v_valor As Boolean) 'Informa que encerrou a sessão corretamente
        On Error Resume Next

        proc_salvar_valor(v_valor, V_ARQ_CONFIG_SESSAO_ENCERROU_CORRETAMENTE_POP_UP) 'Salva a configuração

    End Sub




    'Procedimentos basicos para reabrir a sessao pop up

    Private Sub proc_restaure_sessao_agora_pop_up() 'Restaura a sessao propriamente dito
        On Error Resume Next

        Dim V_LISTA_SESSAO_URL As String = func_ler_valor(V_ARQ_CONFIG_SESSAO_URLS_SALVAS_POP_UPS) 'Retorna o valor do arquivo lido

        Dim V_LISTA_SESSAO_URL_ARRAY As Array = Split(V_LISTA_SESSAO_URL, v_separador_de_string_2) 'Separando urls

        Dim V_QUANTIDADE_DE_ITENS As Integer = V_LISTA_SESSAO_URL_ARRAY.Length 'Quantidade de itens

        Dim V_CONTADOR As Integer = 0 'Contador de looping






        'Informa que encerrou as pop-ups corretamente ------------------------------------------------------------------

        proc_informar_encerrou_sessao_corretamente_pop_up(True) 'Informa que encerrou a sessão corretamente

        '---------------------------------------------------------------------------------------------------------------




        'Varrendo e reabrindo abas -----------------------------------------------------------------------------------------------------------------------------------

        For V_CONTADOR = V_CONTADOR To V_QUANTIDADE_DE_ITENS




            'Obtendo o valor de url de sessão -----------------------------------------------------------------------------------------------------------------------

            Dim V_VALOR_OBTIDO_TEMP As String = V_LISTA_SESSAO_URL_ARRAY(V_CONTADOR) 'Valor de url

            '--------------------------------------------------------------------------------------------------------------------------------------------------------




            'Adicionando nova aba -----------------------------------------------------------------------------------------------------------------------------------

            If (V_VALOR_OBTIDO_TEMP <> Nothing) Then


                Dim OBJ_JANELA_POP_UP As New FRM_POP_UP 'Nova janela de pop-up




                OBJ_JANELA_POP_UP.Show() 'Abrindo a janela

                OBJ_JANELA_POP_UP.GECKOFX_POP_UP.Navigate(V_VALOR_OBTIDO_TEMP) 'Abrindo url


            End If

            '--------------------------------------------------------------------------------------------------------------------------------------------------------




        Next

        '--------------------------------------------------------------------------------------------------------------------------------------------------------




    End Sub

    Public Sub proc_inicializar_e_restaurar_ultima_sessao_pop_up() 'Inicializa e restaura a ultima sessao pop up
        On Error Resume Next


        'Lendo valor de configuração ----------------------------------------------------------------------------------------------------------

        Dim v_pop_up_encerrou_correto = func_ler_valor(V_ARQ_CONFIG_SESSAO_ENCERROU_CORRETAMENTE_POP_UP) 'Retorna o valor do arquivo lido

        '--------------------------------------------------------------------------------------------------------------------------------------




        'Analizando resposta -------------------------------------------------------------------------------------------

        If (v_pop_up_encerrou_correto = False) Then


            proc_restaure_sessao_agora_pop_up() 'Restaura a sessao propriamente dito


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

























End Module
