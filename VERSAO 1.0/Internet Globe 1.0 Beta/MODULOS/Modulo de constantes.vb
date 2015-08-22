Module Modulo_de_constantes


    'Nome interno do navegador ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Public v_logotipo As String = " - Microsete SLM" 'Logotipo

    Public v_versao_de_compilacao_atual_do_navegador As String = "1.0" 'Informa a versão atual de compilação do navegador

    Public v_versao_do_navegador As String = " - Internet Globe" 'Versão

    Public v_nome_de_sistema_de_voz As String = "Olá sou o sistema de vóz Camila, sou a parte de fala do navegador Internet Glóbe, desenvolvido pela empresa Micro 7 SLM, empresa criada por Salomão francisco da silva, dono da Micro 7 SLM."

    Public v_pasta_de_sons_do_sistema_atual As String = CurDir() 'Informa a pasta de sons do sistema atualmente

    Public v_pagina_inicial_site_empresa As String = "http://www.baixabit.com.br/" 'Site da empresa







    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



    'Ação pop-up --------------------------------------------------------------------------------------------

    Public v_acao_pop_up_1 As Byte = 1 'Ação pop-up
    Public v_acao_pop_up_2 As Byte = 2 'Ação pop-up
    Public v_acao_pop_up_3 As Byte = 3 'Ação pop-up

    '--------------------------------------------------------------------------------------------------------


    'Pasta padrao de downloads ----------------------------------------------------------------------------------------

    Public v_pasta_padrao_de_downloads As String = My.Computer.FileSystem.SpecialDirectories.Desktop 'Pasta padrão

    '------------------------------------------------------------------------------------------------------------------


    'Opção de tema ----------------------------------------------------------------------------------------------------

    Public v_acao_tema_1 As Byte = 1 'Ação tema
    Public v_acao_tema_2 As Byte = 2 'Ação tema
    Public v_acao_tema_3 As Byte = 3 'Ação tema

    '------------------------------------------------------------------------------------------------------------------


    'Opção computador lento -------------------------------------------------------------------------------------------

    Public v_acao_computador_lento_1 As Byte = 1 'Ação computador lento
    Public v_acao_computador_lento_2 As Byte = 2 'Ação computador lento
    Public v_acao_computador_lento_3 As Byte = 3 'Ação computador lento

    '------------------------------------------------------------------------------------------------------------------


    'Valor máximo do timer ----------------------------------------------------------------------------------------------------------------------------------------

    Public v_valor_maximo_do_timer_tela_de_boas_vindas As Integer = 3000 'Armazena o valor máximo do tempo de exibição tela de boas vindas

    '--------------------------------------------------------------------------------------------------------------------------------------------------------------



    'Esquema de abas --------------------------------------------------------------------------------------------------

    Public v_esquema_de_aba_1 As Integer = 1 'Esquema de aba
    Public v_esquema_de_aba_2 As Integer = 2 'Esquema de aba
    Public v_esquema_de_aba_3 As Integer = 3 'Esquema de aba
    Public v_esquema_de_aba_4 As Integer = 4 'Esquema de aba
    Public v_esquema_de_aba_5 As Integer = 5 'Esquema de aba
    Public v_esquema_de_aba_6 As Integer = 6 'Esquema de aba

    '------------------------------------------------------------------------------------------------------------------



    'Barra de navegação -----------------------------------------------------------------------------------------------

    Public v_barra_de_navegacao_exibir As Boolean = True 'Barra de navegação

    '------------------------------------------------------------------------------------------------------------------



    'Barra de status --------------------------------------------------------------------------------------------------

    Public v_barra_de_staus_exibir As Boolean = True 'Barra de status

    '------------------------------------------------------------------------------------------------------------------



    'Manipuladores de strings ------------------------------------------------------------------------------------------

    Public v_separador_de_string As String = "," 'Separador de string

    Public v_separador_de_string_2 As String = "+<%>-------+<%>"  'Separador de string


    '------------------------------------------------------------------------------------------------------------------



    'Nomes dos objetos genericos ---------------------------------------------------------------------------------------

    Public v_nome_generico_motor_geckofx As String = "MTGKFX_" 'Nome generico do motor geckofx

    Public v_nome_generico_motor_trdt As String = "MTTRDT_" 'Nome generico do motor trident

    Public v_nome_generico_da_tab As String = "TAB_NOME_GEN_" 'Nome generico da tab

    Public v_nome_generico_da_tab_referencia As String = "TAB_NOME_GEN_REFERENCIA_" 'Nome generico da tab da referencia



    '-------------------------------------------------------------------------------------------------------------------



    'Quantidade maxima de abas abertas ---------------------------------------------------------------------------------------

    Public v_quant_maxima_de_abas_abertas As Integer = 128 'Informa a quantidade maxima de abas que podem ser abertas

    Public v_quant_maxima_de_pop_ups_abertas As Integer = 256 'Informa a quantidade maxima de pop ups que podem ser abertas

    '-------------------------------------------------------------------------------------------------------------------------



    'Extenção de arquivos ----------------------------------------------------------------------------------------------

    Public v_extencao_1 As String = ".html" 'Extenção de arquivo
    Public v_extencao_2 As String = ".png" 'Extenção de arquivo
    Public v_extencao_3 As String = ".wav" 'Extenção de arquivo








    '-------------------------------------------------------------------------------------------------------------------



    'Nome generico de imagem temporaria de impressao -------------------------------------------------------------------

    Public v_nome_generico_de_imagem_de_impressao As String = "imgimprimirnum" 'Nome de imagem de impressao

    '-------------------------------------------------------------------------------------------------------------------




    'Nome generico de favicon temporaria de impressao ------------------------------------------------------------------

    Public v_nome_generico_de_favicon As String = "imgfavicon" 'Nome de imagem de favicon

    '-------------------------------------------------------------------------------------------------------------------




    'Nome generico da pasta de favoritos -------------------------------------------------------------------------------

    Public v_nome_generico_de_pasta_de_favoritos As String = "FavoritosIGlobe" 'Nome de imagem de favicon

    '-------------------------------------------------------------------------------------------------------------------




    'Nome generico da de configurações ---------------------------------------------------------------------------------

    Public v_nome_generico_de_pasta_de_configuracoes_gerais As String = "IG1.0BETA1.0" 'Nome de imagem de favicon

    '-------------------------------------------------------------------------------------------------------------------




    'Eventos de som ----------------------------------------------------------------------------------------------------

    Public v_som_de_pop_up As String = v_pasta_de_sons_do_sistema_atual & "\sons\popup.wav" 'Som de pop-up
    Public v_som_limpar As String = v_pasta_de_sons_do_sistema_atual & "\sons\limpar.wav" 'Som de limpar
    Public v_som_de_inicializacao As String = v_pasta_de_sons_do_sistema_atual & "\sons\inicializar.wav" 'Som de inicialização
    Public v_som_de_online As String = v_pasta_de_sons_do_sistema_atual & "\sons\on.wav" 'Som de online
    Public v_som_de_offline As String = v_pasta_de_sons_do_sistema_atual & "\sons\of.wav" 'Som de ofline







    '-------------------------------------------------------------------------------------------------------------------









    'Relacionado ao teste de conexão -----------------------------------------------------------------------------------

    Public host_teste_1 As String = "www.google.com.br" 'Host de teste de conexão

    Public host_teste_2 As String = "www.microsoft.com.br" 'Host de teste de conexão

    Public host_teste_3 As String = "www.yahoo.com.br" 'Host de teste de conexão

    '-------------------------------------------------------------------------------------------------------------------




    'Codigos maliciosos que nao podem ser executados -------------------------------------------------------------------

    Public Const v_lista_de_codigos_que_nao_podem_ser_executados As String = "javascript:, about:config" 'Lista de codigos

    '-------------------------------------------------------------------------------------------------------------------





    'Quantidade máxima de itens de historico que podem ser salvos ------------------------------------------------------------------------------

    Public Const v_quantidade_maxima_de_itens_de_historico_que_pode_ser_salvo As Integer = 60 'Quantidade de itens de historico

    Public Const v_quantidade_a_remover_itens_hist_atingir_limite As Integer = 25 'Quantidade a remover ao atingir o limite de historico

    '--------------------------------------------------------------------------------------------------------------------------------------------































End Module
