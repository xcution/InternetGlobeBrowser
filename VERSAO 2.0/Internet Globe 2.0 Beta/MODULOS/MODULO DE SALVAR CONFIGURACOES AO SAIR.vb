Module MODULO_DE_SALVAR_CONFIGURACOES_AO_SAIR


    'PROCEDIMENTO SALVADOR DE TUDO

    Public Sub PROC_SALVAR_TODAS_AS_CONFIGURACOES_AO_SAIR() 'SALVA TODAS AS CONFIGURAÇÕES AO SAIR DO NAVEGADOR
        On Error Resume Next


        'VERIFICA SE ESTA NAVEGANDO ANONIMO ---------------------------------------------------------------------

        PROC_NAVEGACAO_ANONIMA_UTILIZAR() 'NAVEGAÇÃO ANONIMA UTILIZAR

        '--------------------------------------------------------------------------------------------------------




        'LIMPA O HISTORICO NO MODO SILENCIOSO -------------------------------------------------------------------

        PROC_LIMPAR_HISTORICO_EM_MODO_SILENCIOSO() 'LIMPA O HISTÓRICO NO MODO SILENCIOSO

        '--------------------------------------------------------------------------------------------------------


    End Sub










































End Module
