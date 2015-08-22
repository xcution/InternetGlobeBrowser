Module Evento_clicar_na_pagina


    'Eventos de clicar sobre a página

    Public Sub proc_clicar_na_pagina_geckofx(ByVal sender As System.Object, ByVal e As Skybound.Gecko.GeckoDomEventArgs) 'Evento ao clicar na página
        On Error Resume Next

        proc_ocultar_menu_autocompletar_barra_end_navegacao() 'Oculta o menu de autocompletar na barra de endereços

    End Sub










End Module
