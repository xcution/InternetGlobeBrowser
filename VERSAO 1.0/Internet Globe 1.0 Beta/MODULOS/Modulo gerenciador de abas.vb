Imports DevComponents.DotNetBar


Module Modulo_gerenciador_de_abas


    'Variáveis necessárias

    Public v_aba_disponivel(v_quant_maxima_de_abas_abertas) As Boolean 'Informa qual aba esta ou não disponivel

    Public v_tipo_de_motor_adicionado(v_quant_maxima_de_abas_abertas) As Boolean 'Informa o tipo de motor adicionado

    Public v_quantidade_de_abas_abertas As Integer = 0 'Informa a quantidade de abas abertas

    Public v_ultima_aba_adicionada_numero As Integer = 0 'Informa o numero da ultima aba adicionada

















    'Mensagens sobre as abas

    Public Sub proc_informar_que_abriu_abas_demais() 'Informa ao usuario que muitas abas foram abertas
        On Error Resume Next

        Dim OBJ_JANELA As New FRM_ABAS_DEMAIS 'Janela de abas demais

        Dim V_NUM_QUANT_ABAS_ABERTAS As Integer = v_quantidade_de_abas_abertas - 1 'Informa a quantidade de abas abertas





        'Verifica a quantidade de abas abertas, e se o recurso de informar esta disponivel ---------------------------------------------------------------------------

        If (V_NUM_QUANT_ABAS_ABERTAS > V_QUANTIDADE_DE_ABAS_ABERTAS_ALERTAR_SOBRE_LENTIDAO) And (V_VAL_CONFIG_ALERTAR_ABRIR_ABAS_DEMAIS = True) Then


            OBJ_JANELA.V_ABERTAS = V_NUM_QUANT_ABAS_ABERTAS 'Informa a quantidade de abas abertas

            OBJ_JANELA.V_RECOMENDAVEL = V_QUANTIDADE_DE_ABAS_ABERTAS_ALERTAR_SOBRE_LENTIDAO 'Informa o recomendavel

            OBJ_JANELA.Show() 'Abrindo formulario

            OBJ_JANELA.TopMost = True 'Ativar topmost


        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Public Sub proc_sair_informar_abas_abertas() 'Informa ao sair se há abas abertas
        On Error Resume Next

        Dim OBJ_JANELA As New FRM_INFORMA_ABAS_ABERTAS 'Informar abas abertas ao sair






        'Verifica a quantidade de abas abertas, e se o recurso de informar esta disponivel ---------------------------------------------------------------------------

        If ((V_VAL_CONFIG_ALERTAR_ABAS_ABERTAS_AO_SAIR = True)) Then



            'Obtendo o numero real de abas abertas ---------------------------------------------------------------------

            v_quantidade_de_abas_abertas = FRM_NAVEGACAO.TabControl1.Tabs.Count 'Obtendo...

            '-----------------------------------------------------------------------------------------------------------




            '#Verifica a quantidade de abas abertas --------------------------------------------------------------------

            If (v_quantidade_de_abas_abertas >= 3) Then


                OBJ_JANELA.V_ABERTAS = v_quantidade_de_abas_abertas - 1 'Informa a quantidade de abas abertas

                OBJ_JANELA.ShowDialog() 'Abrindo formulario

                Exit Sub 'Saindo do procedimento




            Else




                'Salva a sessao atual -----------------------------------------------------------------------------------------------------

                proc_informar_encerrou_sessao_corretamente(True) 'Informa que encerrou a sessão corretamente

                '--------------------------------------------------------------------------------------------------------------------------




                'Zerar configuração de nao poder sair do navegador ---------------------------------------------------------

                v_pode_encerrar_formulario_principal = False 'Zera a configuração de não poder sair do navegador

                '-----------------------------------------------------------------------------------------------------------




            End If

            '-----------------------------------------------------------------------------------------------------------




        Else




            'Salva a sessao atual -----------------------------------------------------------------------------------------------------

            proc_informar_encerrou_sessao_corretamente(True) 'Informa que encerrou a sessão corretamente

            '--------------------------------------------------------------------------------------------------------------------------




            'Informando que pode fechar as abas normalmente ------------------------------------------------------------

            v_pode_encerrar_formulario_principal = False 'Pode encerrar normalmente

            '-----------------------------------------------------------------------------------------------------------




        End If


        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




    End Sub












    'Procedimentos


    Private Sub proc_prototico_geckofx_definir(ByVal V_NUMERO As Integer) 'Define o motor prototico do geckofx
        On Error Resume Next

        Dim obj_prototico As New FRM_PROTOTICO 'Novo formulario de motor prototico




        Select Case V_NUMERO


            Case 1
                OBJ_MOTOR_GECKOFX_1 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 2
                OBJ_MOTOR_GECKOFX_2 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 3
                OBJ_MOTOR_GECKOFX_3 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 4
                OBJ_MOTOR_GECKOFX_4 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 5
                OBJ_MOTOR_GECKOFX_5 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 6
                OBJ_MOTOR_GECKOFX_6 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 7
                OBJ_MOTOR_GECKOFX_7 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 8
                OBJ_MOTOR_GECKOFX_8 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 9
                OBJ_MOTOR_GECKOFX_9 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 10
                OBJ_MOTOR_GECKOFX_10 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 11
                OBJ_MOTOR_GECKOFX_11 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 12
                OBJ_MOTOR_GECKOFX_12 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 13
                OBJ_MOTOR_GECKOFX_13 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 14
                OBJ_MOTOR_GECKOFX_14 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 15
                OBJ_MOTOR_GECKOFX_15 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 16
                OBJ_MOTOR_GECKOFX_16 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 17
                OBJ_MOTOR_GECKOFX_17 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 18
                OBJ_MOTOR_GECKOFX_18 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 19
                OBJ_MOTOR_GECKOFX_19 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 20
                OBJ_MOTOR_GECKOFX_20 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 21
                OBJ_MOTOR_GECKOFX_21 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 22
                OBJ_MOTOR_GECKOFX_22 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 23
                OBJ_MOTOR_GECKOFX_23 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 24
                OBJ_MOTOR_GECKOFX_24 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 25
                OBJ_MOTOR_GECKOFX_25 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 26
                OBJ_MOTOR_GECKOFX_26 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 27
                OBJ_MOTOR_GECKOFX_27 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 28
                OBJ_MOTOR_GECKOFX_28 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 29
                OBJ_MOTOR_GECKOFX_29 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 30
                OBJ_MOTOR_GECKOFX_30 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 31
                OBJ_MOTOR_GECKOFX_31 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 32
                OBJ_MOTOR_GECKOFX_32 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 33
                OBJ_MOTOR_GECKOFX_33 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 34
                OBJ_MOTOR_GECKOFX_34 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 35
                OBJ_MOTOR_GECKOFX_35 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 36
                OBJ_MOTOR_GECKOFX_36 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 37
                OBJ_MOTOR_GECKOFX_37 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 38
                OBJ_MOTOR_GECKOFX_38 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 39
                OBJ_MOTOR_GECKOFX_39 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 40
                OBJ_MOTOR_GECKOFX_40 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 41
                OBJ_MOTOR_GECKOFX_41 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 42
                OBJ_MOTOR_GECKOFX_42 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 43
                OBJ_MOTOR_GECKOFX_43 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 44
                OBJ_MOTOR_GECKOFX_44 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 45
                OBJ_MOTOR_GECKOFX_45 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 46
                OBJ_MOTOR_GECKOFX_46 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 47
                OBJ_MOTOR_GECKOFX_47 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 48
                OBJ_MOTOR_GECKOFX_48 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 49
                OBJ_MOTOR_GECKOFX_49 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 50
                OBJ_MOTOR_GECKOFX_50 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 51
                OBJ_MOTOR_GECKOFX_51 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 52
                OBJ_MOTOR_GECKOFX_52 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 53
                OBJ_MOTOR_GECKOFX_53 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 54
                OBJ_MOTOR_GECKOFX_54 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 55
                OBJ_MOTOR_GECKOFX_55 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 56
                OBJ_MOTOR_GECKOFX_56 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 57
                OBJ_MOTOR_GECKOFX_57 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 58
                OBJ_MOTOR_GECKOFX_58 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 59
                OBJ_MOTOR_GECKOFX_59 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 60
                OBJ_MOTOR_GECKOFX_60 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 61
                OBJ_MOTOR_GECKOFX_61 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 62
                OBJ_MOTOR_GECKOFX_62 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 63
                OBJ_MOTOR_GECKOFX_63 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 64
                OBJ_MOTOR_GECKOFX_64 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 65
                OBJ_MOTOR_GECKOFX_65 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 66
                OBJ_MOTOR_GECKOFX_66 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 67
                OBJ_MOTOR_GECKOFX_67 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 68
                OBJ_MOTOR_GECKOFX_68 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 69
                OBJ_MOTOR_GECKOFX_69 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 70
                OBJ_MOTOR_GECKOFX_70 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 71
                OBJ_MOTOR_GECKOFX_71 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 72
                OBJ_MOTOR_GECKOFX_72 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 73
                OBJ_MOTOR_GECKOFX_73 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 74
                OBJ_MOTOR_GECKOFX_74 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 75
                OBJ_MOTOR_GECKOFX_75 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 76
                OBJ_MOTOR_GECKOFX_76 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 77
                OBJ_MOTOR_GECKOFX_77 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 78
                OBJ_MOTOR_GECKOFX_78 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 79
                OBJ_MOTOR_GECKOFX_79 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 80
                OBJ_MOTOR_GECKOFX_80 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 81
                OBJ_MOTOR_GECKOFX_81 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 82
                OBJ_MOTOR_GECKOFX_82 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 83
                OBJ_MOTOR_GECKOFX_83 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 84
                OBJ_MOTOR_GECKOFX_84 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 85
                OBJ_MOTOR_GECKOFX_85 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 86
                OBJ_MOTOR_GECKOFX_86 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 87
                OBJ_MOTOR_GECKOFX_87 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 88
                OBJ_MOTOR_GECKOFX_88 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 89
                OBJ_MOTOR_GECKOFX_89 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 90
                OBJ_MOTOR_GECKOFX_90 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 91
                OBJ_MOTOR_GECKOFX_91 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 92
                OBJ_MOTOR_GECKOFX_92 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 93
                OBJ_MOTOR_GECKOFX_93 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 94
                OBJ_MOTOR_GECKOFX_94 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 95
                OBJ_MOTOR_GECKOFX_95 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 96
                OBJ_MOTOR_GECKOFX_96 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 97
                OBJ_MOTOR_GECKOFX_97 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 98
                OBJ_MOTOR_GECKOFX_98 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 99
                OBJ_MOTOR_GECKOFX_99 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 100
                OBJ_MOTOR_GECKOFX_100 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 101
                OBJ_MOTOR_GECKOFX_101 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 102
                OBJ_MOTOR_GECKOFX_102 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 103
                OBJ_MOTOR_GECKOFX_103 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 104
                OBJ_MOTOR_GECKOFX_104 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 105
                OBJ_MOTOR_GECKOFX_105 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 106
                OBJ_MOTOR_GECKOFX_106 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 107
                OBJ_MOTOR_GECKOFX_107 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 108
                OBJ_MOTOR_GECKOFX_108 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 109
                OBJ_MOTOR_GECKOFX_109 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 110
                OBJ_MOTOR_GECKOFX_110 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 111
                OBJ_MOTOR_GECKOFX_111 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 112
                OBJ_MOTOR_GECKOFX_112 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 113
                OBJ_MOTOR_GECKOFX_113 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 114
                OBJ_MOTOR_GECKOFX_114 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 115
                OBJ_MOTOR_GECKOFX_115 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 116
                OBJ_MOTOR_GECKOFX_116 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 117
                OBJ_MOTOR_GECKOFX_117 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 118
                OBJ_MOTOR_GECKOFX_118 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 119
                OBJ_MOTOR_GECKOFX_119 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 120
                OBJ_MOTOR_GECKOFX_120 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 121
                OBJ_MOTOR_GECKOFX_121 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 122
                OBJ_MOTOR_GECKOFX_122 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 123
                OBJ_MOTOR_GECKOFX_123 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 124
                OBJ_MOTOR_GECKOFX_124 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 125
                OBJ_MOTOR_GECKOFX_125 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 126
                OBJ_MOTOR_GECKOFX_126 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 127
                OBJ_MOTOR_GECKOFX_127 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            Case 128
                OBJ_MOTOR_GECKOFX_128 = obj_prototico.GECKOFX_PROT 'Igualando motores layout
                Exit Select
            



        End Select


    End Sub


    Private Sub proc_prototico_trident_definir(ByVal V_NUMERO As Integer) 'Define o motor prototico do trident
        On Error Resume Next

        Dim obj_prototico As New FRM_PROTOTICO 'Novo formulario de motor prototico



        Select Case V_NUMERO


            Case 1
                OBJ_MOTOR_WEB_BROWSER_1 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 2
                OBJ_MOTOR_WEB_BROWSER_2 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 3
                OBJ_MOTOR_WEB_BROWSER_3 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 4
                OBJ_MOTOR_WEB_BROWSER_4 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 5
                OBJ_MOTOR_WEB_BROWSER_5 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 6
                OBJ_MOTOR_WEB_BROWSER_6 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 7
                OBJ_MOTOR_WEB_BROWSER_7 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 8
                OBJ_MOTOR_WEB_BROWSER_8 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 9
                OBJ_MOTOR_WEB_BROWSER_9 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 10
                OBJ_MOTOR_WEB_BROWSER_10 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 11
                OBJ_MOTOR_WEB_BROWSER_11 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 12
                OBJ_MOTOR_WEB_BROWSER_12 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 13
                OBJ_MOTOR_WEB_BROWSER_13 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 14
                OBJ_MOTOR_WEB_BROWSER_14 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 15
                OBJ_MOTOR_WEB_BROWSER_15 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 16
                OBJ_MOTOR_WEB_BROWSER_16 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 17
                OBJ_MOTOR_WEB_BROWSER_17 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 18
                OBJ_MOTOR_WEB_BROWSER_18 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 19
                OBJ_MOTOR_WEB_BROWSER_19 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 20
                OBJ_MOTOR_WEB_BROWSER_20 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 21
                OBJ_MOTOR_WEB_BROWSER_21 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 22
                OBJ_MOTOR_WEB_BROWSER_22 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 23
                OBJ_MOTOR_WEB_BROWSER_23 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 24
                OBJ_MOTOR_WEB_BROWSER_24 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 25
                OBJ_MOTOR_WEB_BROWSER_25 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 26
                OBJ_MOTOR_WEB_BROWSER_26 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 27
                OBJ_MOTOR_WEB_BROWSER_27 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 28
                OBJ_MOTOR_WEB_BROWSER_28 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 29
                OBJ_MOTOR_WEB_BROWSER_29 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 30
                OBJ_MOTOR_WEB_BROWSER_30 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 31
                OBJ_MOTOR_WEB_BROWSER_31 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 32
                OBJ_MOTOR_WEB_BROWSER_32 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 33
                OBJ_MOTOR_WEB_BROWSER_33 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 34
                OBJ_MOTOR_WEB_BROWSER_34 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 35
                OBJ_MOTOR_WEB_BROWSER_35 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 36
                OBJ_MOTOR_WEB_BROWSER_36 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 37
                OBJ_MOTOR_WEB_BROWSER_37 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 38
                OBJ_MOTOR_WEB_BROWSER_38 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 39
                OBJ_MOTOR_WEB_BROWSER_39 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 40
                OBJ_MOTOR_WEB_BROWSER_40 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 41
                OBJ_MOTOR_WEB_BROWSER_41 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 42
                OBJ_MOTOR_WEB_BROWSER_42 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 43
                OBJ_MOTOR_WEB_BROWSER_43 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 44
                OBJ_MOTOR_WEB_BROWSER_44 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 45
                OBJ_MOTOR_WEB_BROWSER_45 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 46
                OBJ_MOTOR_WEB_BROWSER_46 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 47
                OBJ_MOTOR_WEB_BROWSER_47 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 48
                OBJ_MOTOR_WEB_BROWSER_48 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 49
                OBJ_MOTOR_WEB_BROWSER_49 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 50
                OBJ_MOTOR_WEB_BROWSER_50 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 51
                OBJ_MOTOR_WEB_BROWSER_51 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 52
                OBJ_MOTOR_WEB_BROWSER_52 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 53
                OBJ_MOTOR_WEB_BROWSER_53 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 54
                OBJ_MOTOR_WEB_BROWSER_54 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 55
                OBJ_MOTOR_WEB_BROWSER_55 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 56
                OBJ_MOTOR_WEB_BROWSER_56 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 57
                OBJ_MOTOR_WEB_BROWSER_57 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 58
                OBJ_MOTOR_WEB_BROWSER_58 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 59
                OBJ_MOTOR_WEB_BROWSER_59 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 60
                OBJ_MOTOR_WEB_BROWSER_60 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 61
                OBJ_MOTOR_WEB_BROWSER_61 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 62
                OBJ_MOTOR_WEB_BROWSER_62 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 63
                OBJ_MOTOR_WEB_BROWSER_63 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 64
                OBJ_MOTOR_WEB_BROWSER_64 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 65
                OBJ_MOTOR_WEB_BROWSER_65 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 66
                OBJ_MOTOR_WEB_BROWSER_66 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 67
                OBJ_MOTOR_WEB_BROWSER_67 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 68
                OBJ_MOTOR_WEB_BROWSER_68 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 69
                OBJ_MOTOR_WEB_BROWSER_69 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 70
                OBJ_MOTOR_WEB_BROWSER_70 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 71
                OBJ_MOTOR_WEB_BROWSER_71 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 72
                OBJ_MOTOR_WEB_BROWSER_72 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 73
                OBJ_MOTOR_WEB_BROWSER_73 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 74
                OBJ_MOTOR_WEB_BROWSER_74 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 75
                OBJ_MOTOR_WEB_BROWSER_75 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 76
                OBJ_MOTOR_WEB_BROWSER_76 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 77
                OBJ_MOTOR_WEB_BROWSER_77 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 78
                OBJ_MOTOR_WEB_BROWSER_78 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 79
                OBJ_MOTOR_WEB_BROWSER_79 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 80
                OBJ_MOTOR_WEB_BROWSER_80 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 81
                OBJ_MOTOR_WEB_BROWSER_81 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 82
                OBJ_MOTOR_WEB_BROWSER_82 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 83
                OBJ_MOTOR_WEB_BROWSER_83 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 84
                OBJ_MOTOR_WEB_BROWSER_84 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 85
                OBJ_MOTOR_WEB_BROWSER_85 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 86
                OBJ_MOTOR_WEB_BROWSER_86 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 87
                OBJ_MOTOR_WEB_BROWSER_87 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 88
                OBJ_MOTOR_WEB_BROWSER_88 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 89
                OBJ_MOTOR_WEB_BROWSER_89 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 90
                OBJ_MOTOR_WEB_BROWSER_90 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 91
                OBJ_MOTOR_WEB_BROWSER_91 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 92
                OBJ_MOTOR_WEB_BROWSER_92 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 93
                OBJ_MOTOR_WEB_BROWSER_93 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 94
                OBJ_MOTOR_WEB_BROWSER_94 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 95
                OBJ_MOTOR_WEB_BROWSER_95 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 96
                OBJ_MOTOR_WEB_BROWSER_96 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 97
                OBJ_MOTOR_WEB_BROWSER_97 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 98
                OBJ_MOTOR_WEB_BROWSER_98 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 99
                OBJ_MOTOR_WEB_BROWSER_99 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 100
                OBJ_MOTOR_WEB_BROWSER_100 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 101
                OBJ_MOTOR_WEB_BROWSER_101 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 102
                OBJ_MOTOR_WEB_BROWSER_102 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 103
                OBJ_MOTOR_WEB_BROWSER_103 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 104
                OBJ_MOTOR_WEB_BROWSER_104 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 105
                OBJ_MOTOR_WEB_BROWSER_105 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 106
                OBJ_MOTOR_WEB_BROWSER_106 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 107
                OBJ_MOTOR_WEB_BROWSER_107 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 108
                OBJ_MOTOR_WEB_BROWSER_108 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 109
                OBJ_MOTOR_WEB_BROWSER_109 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 110
                OBJ_MOTOR_WEB_BROWSER_110 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 111
                OBJ_MOTOR_WEB_BROWSER_111 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 112
                OBJ_MOTOR_WEB_BROWSER_112 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 113
                OBJ_MOTOR_WEB_BROWSER_113 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 114
                OBJ_MOTOR_WEB_BROWSER_114 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 115
                OBJ_MOTOR_WEB_BROWSER_115 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 116
                OBJ_MOTOR_WEB_BROWSER_116 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 117
                OBJ_MOTOR_WEB_BROWSER_117 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 118
                OBJ_MOTOR_WEB_BROWSER_118 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 119
                OBJ_MOTOR_WEB_BROWSER_119 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 120
                OBJ_MOTOR_WEB_BROWSER_120 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 121
                OBJ_MOTOR_WEB_BROWSER_121 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 122
                OBJ_MOTOR_WEB_BROWSER_122 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 123
                OBJ_MOTOR_WEB_BROWSER_123 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 124
                OBJ_MOTOR_WEB_BROWSER_124 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 125
                OBJ_MOTOR_WEB_BROWSER_125 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 126
                OBJ_MOTOR_WEB_BROWSER_126 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 127
                OBJ_MOTOR_WEB_BROWSER_127 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            Case 128
                OBJ_MOTOR_WEB_BROWSER_128 = obj_prototico.TRIDENT_PROT 'Igualando motores layout
                Exit Select
            



        End Select


    End Sub


    Private Sub proc_adiciona_painel(ByVal V_NUMERO As Integer) 'Painel do motor layout engine 'Adiciona o painel na aba
        On Error Resume Next


        'Selecionando o numero a usar ------------------------------------------------------------------------------------------------------

        Select Case V_NUMERO


            Case 1
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_1)
                Exit Select
            Case 2
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_2)
                Exit Select
            Case 3
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_3)
                Exit Select
            Case 4
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_4)
                Exit Select
            Case 5
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_5)
                Exit Select
            Case 6
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_6)
                Exit Select
            Case 7
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_7)
                Exit Select
            Case 8
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_8)
                Exit Select
            Case 9
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_9)
                Exit Select
            Case 10
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_10)
                Exit Select
            Case 11
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_11)
                Exit Select
            Case 12
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_12)
                Exit Select
            Case 13
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_13)
                Exit Select
            Case 14
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_14)
                Exit Select
            Case 15
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_15)
                Exit Select
            Case 16
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_16)
                Exit Select
            Case 17
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_17)
                Exit Select
            Case 18
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_18)
                Exit Select
            Case 19
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_19)
                Exit Select
            Case 20
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_20)
                Exit Select
            Case 21
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_21)
                Exit Select
            Case 22
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_22)
                Exit Select
            Case 23
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_23)
                Exit Select
            Case 24
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_24)
                Exit Select
            Case 25
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_25)
                Exit Select
            Case 26
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_26)
                Exit Select
            Case 27
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_27)
                Exit Select
            Case 28
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_28)
                Exit Select
            Case 29
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_29)
                Exit Select
            Case 30
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_30)
                Exit Select
            Case 31
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_31)
                Exit Select
            Case 32
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_32)
                Exit Select
            Case 33
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_33)
                Exit Select
            Case 34
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_34)
                Exit Select
            Case 35
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_35)
                Exit Select
            Case 36
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_36)
                Exit Select
            Case 37
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_37)
                Exit Select
            Case 38
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_38)
                Exit Select
            Case 39
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_39)
                Exit Select
            Case 40
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_40)
                Exit Select
            Case 41
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_41)
                Exit Select
            Case 42
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_42)
                Exit Select
            Case 43
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_43)
                Exit Select
            Case 44
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_44)
                Exit Select
            Case 45
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_45)
                Exit Select
            Case 46
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_46)
                Exit Select
            Case 47
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_47)
                Exit Select
            Case 48
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_48)
                Exit Select
            Case 49
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_49)
                Exit Select
            Case 50
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_50)
                Exit Select
            Case 51
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_51)
                Exit Select
            Case 52
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_52)
                Exit Select
            Case 53
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_53)
                Exit Select
            Case 54
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_54)
                Exit Select
            Case 55
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_55)
                Exit Select
            Case 56
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_56)
                Exit Select
            Case 57
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_57)
                Exit Select
            Case 58
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_58)
                Exit Select
            Case 59
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_59)
                Exit Select
            Case 60
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_60)
                Exit Select
            Case 61
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_61)
                Exit Select
            Case 62
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_62)
                Exit Select
            Case 63
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_63)
                Exit Select
            Case 64
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_64)
                Exit Select
            Case 65
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_65)
                Exit Select
            Case 66
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_66)
                Exit Select
            Case 67
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_67)
                Exit Select
            Case 68
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_68)
                Exit Select
            Case 69
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_69)
                Exit Select
            Case 70
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_70)
                Exit Select
            Case 71
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_71)
                Exit Select
            Case 72
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_72)
                Exit Select
            Case 73
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_73)
                Exit Select
            Case 74
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_74)
                Exit Select
            Case 75
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_75)
                Exit Select
            Case 76
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_76)
                Exit Select
            Case 77
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_77)
                Exit Select
            Case 78
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_78)
                Exit Select
            Case 79
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_79)
                Exit Select
            Case 80
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_80)
                Exit Select
            Case 81
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_81)
                Exit Select
            Case 82
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_82)
                Exit Select
            Case 83
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_83)
                Exit Select
            Case 84
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_84)
                Exit Select
            Case 85
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_85)
                Exit Select
            Case 86
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_86)
                Exit Select
            Case 87
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_87)
                Exit Select
            Case 88
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_88)
                Exit Select
            Case 89
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_89)
                Exit Select
            Case 90
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_90)
                Exit Select
            Case 91
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_91)
                Exit Select
            Case 92
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_92)
                Exit Select
            Case 93
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_93)
                Exit Select
            Case 94
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_94)
                Exit Select
            Case 95
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_95)
                Exit Select
            Case 96
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_96)
                Exit Select
            Case 97
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_97)
                Exit Select
            Case 98
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_98)
                Exit Select
            Case 99
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_99)
                Exit Select
            Case 100
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_100)
                Exit Select
            Case 101
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_101)
                Exit Select
            Case 102
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_102)
                Exit Select
            Case 103
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_103)
                Exit Select
            Case 104
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_104)
                Exit Select
            Case 105
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_105)
                Exit Select
            Case 106
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_106)
                Exit Select
            Case 107
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_107)
                Exit Select
            Case 108
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_108)
                Exit Select
            Case 109
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_109)
                Exit Select
            Case 110
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_110)
                Exit Select
            Case 111
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_111)
                Exit Select
            Case 112
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_112)
                Exit Select
            Case 113
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_113)
                Exit Select
            Case 114
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_114)
                Exit Select
            Case 115
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_115)
                Exit Select
            Case 116
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_116)
                Exit Select
            Case 117
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_117)
                Exit Select
            Case 118
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_118)
                Exit Select
            Case 119
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_119)
                Exit Select
            Case 120
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_120)
                Exit Select
            Case 121
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_121)
                Exit Select
            Case 122
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_122)
                Exit Select
            Case 123
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_123)
                Exit Select
            Case 124
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_124)
                Exit Select
            Case 125
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_125)
                Exit Select
            Case 126
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_126)
                Exit Select
            Case 127
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_127)
                Exit Select
            Case 128
                FRM_NAVEGACAO.TabControl1.Controls.Add(painel_do_motor_128)
                Exit Select
            



        End Select

        '------------------------------------------------------------------------------------------------------------------------------------


    End Sub


    Private Sub proc_adicionar_aba(ByVal V_NUMERO As Integer) 'Adicionar a nova aba


        'Selecionando o numero a usar ------------------------------------------------------------------------------------------------------

        Select Case V_NUMERO


            Case 1
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab1)
                Exit Select
            Case 2
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab2)
                Exit Select
            Case 3
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab3)
                Exit Select
            Case 4
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab4)
                Exit Select
            Case 5
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab5)
                Exit Select
            Case 6
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab6)
                Exit Select
            Case 7
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab7)
                Exit Select
            Case 8
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab8)
                Exit Select
            Case 9
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab9)
                Exit Select
            Case 10
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab10)
                Exit Select
            Case 11
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab11)
                Exit Select
            Case 12
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab12)
                Exit Select
            Case 13
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab13)
                Exit Select
            Case 14
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab14)
                Exit Select
            Case 15
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab15)
                Exit Select
            Case 16
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab16)
                Exit Select
            Case 17
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab17)
                Exit Select
            Case 18
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab18)
                Exit Select
            Case 19
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab19)
                Exit Select
            Case 20
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab20)
                Exit Select
            Case 21
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab21)
                Exit Select
            Case 22
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab22)
                Exit Select
            Case 23
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab23)
                Exit Select
            Case 24
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab24)
                Exit Select
            Case 25
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab25)
                Exit Select
            Case 26
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab26)
                Exit Select
            Case 27
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab27)
                Exit Select
            Case 28
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab28)
                Exit Select
            Case 29
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab29)
                Exit Select
            Case 30
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab30)
                Exit Select
            Case 31
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab31)
                Exit Select
            Case 32
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab32)
                Exit Select
            Case 33
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab33)
                Exit Select
            Case 34
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab34)
                Exit Select
            Case 35
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab35)
                Exit Select
            Case 36
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab36)
                Exit Select
            Case 37
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab37)
                Exit Select
            Case 38
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab38)
                Exit Select
            Case 39
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab39)
                Exit Select
            Case 40
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab40)
                Exit Select
            Case 41
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab41)
                Exit Select
            Case 42
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab42)
                Exit Select
            Case 43
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab43)
                Exit Select
            Case 44
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab44)
                Exit Select
            Case 45
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab45)
                Exit Select
            Case 46
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab46)
                Exit Select
            Case 47
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab47)
                Exit Select
            Case 48
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab48)
                Exit Select
            Case 49
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab49)
                Exit Select
            Case 50
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab50)
                Exit Select
            Case 51
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab51)
                Exit Select
            Case 52
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab52)
                Exit Select
            Case 53
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab53)
                Exit Select
            Case 54
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab54)
                Exit Select
            Case 55
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab55)
                Exit Select
            Case 56
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab56)
                Exit Select
            Case 57
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab57)
                Exit Select
            Case 58
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab58)
                Exit Select
            Case 59
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab59)
                Exit Select
            Case 60
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab60)
                Exit Select
            Case 61
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab61)
                Exit Select
            Case 62
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab62)
                Exit Select
            Case 63
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab63)
                Exit Select
            Case 64
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab64)
                Exit Select
            Case 65
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab65)
                Exit Select
            Case 66
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab66)
                Exit Select
            Case 67
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab67)
                Exit Select
            Case 68
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab68)
                Exit Select
            Case 69
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab69)
                Exit Select
            Case 70
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab70)
                Exit Select
            Case 71
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab71)
                Exit Select
            Case 72
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab72)
                Exit Select
            Case 73
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab73)
                Exit Select
            Case 74
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab74)
                Exit Select
            Case 75
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab75)
                Exit Select
            Case 76
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab76)
                Exit Select
            Case 77
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab77)
                Exit Select
            Case 78
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab78)
                Exit Select
            Case 79
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab79)
                Exit Select
            Case 80
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab80)
                Exit Select
            Case 81
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab81)
                Exit Select
            Case 82
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab82)
                Exit Select
            Case 83
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab83)
                Exit Select
            Case 84
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab84)
                Exit Select
            Case 85
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab85)
                Exit Select
            Case 86
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab86)
                Exit Select
            Case 87
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab87)
                Exit Select
            Case 88
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab88)
                Exit Select
            Case 89
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab89)
                Exit Select
            Case 90
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab90)
                Exit Select
            Case 91
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab91)
                Exit Select
            Case 92
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab92)
                Exit Select
            Case 93
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab93)
                Exit Select
            Case 94
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab94)
                Exit Select
            Case 95
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab95)
                Exit Select
            Case 96
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab96)
                Exit Select
            Case 97
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab97)
                Exit Select
            Case 98
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab98)
                Exit Select
            Case 99
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab99)
                Exit Select
            Case 100
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab100)
                Exit Select
            Case 101
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab101)
                Exit Select
            Case 102
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab102)
                Exit Select
            Case 103
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab103)
                Exit Select
            Case 104
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab104)
                Exit Select
            Case 105
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab105)
                Exit Select
            Case 106
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab106)
                Exit Select
            Case 107
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab107)
                Exit Select
            Case 108
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab108)
                Exit Select
            Case 109
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab109)
                Exit Select
            Case 110
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab110)
                Exit Select
            Case 111
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab111)
                Exit Select
            Case 112
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab112)
                Exit Select
            Case 113
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab113)
                Exit Select
            Case 114
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab114)
                Exit Select
            Case 115
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab115)
                Exit Select
            Case 116
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab116)
                Exit Select
            Case 117
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab117)
                Exit Select
            Case 118
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab118)
                Exit Select
            Case 119
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab119)
                Exit Select
            Case 120
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab120)
                Exit Select
            Case 121
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab121)
                Exit Select
            Case 122
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab122)
                Exit Select
            Case 123
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab123)
                Exit Select
            Case 124
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab124)
                Exit Select
            Case 125
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab125)
                Exit Select
            Case 126
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab126)
                Exit Select
            Case 127
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab127)
                Exit Select
            Case 128
                FRM_NAVEGACAO.TabControl1.Tabs.Add(tab128)
                Exit Select
            



        End Select

        '------------------------------------------------------------------------------------------------------------------------------------



    End Sub


    Private Sub proc_ligar_tab_e_painel(ByVal V_NUMERO As Integer) 'Liga a tab ao painel
        On Error Resume Next


        'Selecionando o numero a usar ------------------------------------------------------------------------------------------------------

        Select Case V_NUMERO


            Case 1
                tab1.AttachedControl = painel_do_motor_1
                Exit Select
            Case 2
                tab2.AttachedControl = painel_do_motor_2
                Exit Select
            Case 3
                tab3.AttachedControl = painel_do_motor_3
                Exit Select
            Case 4
                tab4.AttachedControl = painel_do_motor_4
                Exit Select
            Case 5
                tab5.AttachedControl = painel_do_motor_5
                Exit Select
            Case 6
                tab6.AttachedControl = painel_do_motor_6
                Exit Select
            Case 7
                tab7.AttachedControl = painel_do_motor_7
                Exit Select
            Case 8
                tab8.AttachedControl = painel_do_motor_8
                Exit Select
            Case 9
                tab9.AttachedControl = painel_do_motor_9
                Exit Select
            Case 10
                tab10.AttachedControl = painel_do_motor_10
                Exit Select
            Case 11
                tab11.AttachedControl = painel_do_motor_11
                Exit Select
            Case 12
                tab12.AttachedControl = painel_do_motor_12
                Exit Select
            Case 13
                tab13.AttachedControl = painel_do_motor_13
                Exit Select
            Case 14
                tab14.AttachedControl = painel_do_motor_14
                Exit Select
            Case 15
                tab15.AttachedControl = painel_do_motor_15
                Exit Select
            Case 16
                tab16.AttachedControl = painel_do_motor_16
                Exit Select
            Case 17
                tab17.AttachedControl = painel_do_motor_17
                Exit Select
            Case 18
                tab18.AttachedControl = painel_do_motor_18
                Exit Select
            Case 19
                tab19.AttachedControl = painel_do_motor_19
                Exit Select
            Case 20
                tab20.AttachedControl = painel_do_motor_20
                Exit Select
            Case 21
                tab21.AttachedControl = painel_do_motor_21
                Exit Select
            Case 22
                tab22.AttachedControl = painel_do_motor_22
                Exit Select
            Case 23
                tab23.AttachedControl = painel_do_motor_23
                Exit Select
            Case 24
                tab24.AttachedControl = painel_do_motor_24
                Exit Select
            Case 25
                tab25.AttachedControl = painel_do_motor_25
                Exit Select
            Case 26
                tab26.AttachedControl = painel_do_motor_26
                Exit Select
            Case 27
                tab27.AttachedControl = painel_do_motor_27
                Exit Select
            Case 28
                tab28.AttachedControl = painel_do_motor_28
                Exit Select
            Case 29
                tab29.AttachedControl = painel_do_motor_29
                Exit Select
            Case 30
                tab30.AttachedControl = painel_do_motor_30
                Exit Select
            Case 31
                tab31.AttachedControl = painel_do_motor_31
                Exit Select
            Case 32
                tab32.AttachedControl = painel_do_motor_32
                Exit Select
            Case 33
                tab33.AttachedControl = painel_do_motor_33
                Exit Select
            Case 34
                tab34.AttachedControl = painel_do_motor_34
                Exit Select
            Case 35
                tab35.AttachedControl = painel_do_motor_35
                Exit Select
            Case 36
                tab36.AttachedControl = painel_do_motor_36
                Exit Select
            Case 37
                tab37.AttachedControl = painel_do_motor_37
                Exit Select
            Case 38
                tab38.AttachedControl = painel_do_motor_38
                Exit Select
            Case 39
                tab39.AttachedControl = painel_do_motor_39
                Exit Select
            Case 40
                tab40.AttachedControl = painel_do_motor_40
                Exit Select
            Case 41
                tab41.AttachedControl = painel_do_motor_41
                Exit Select
            Case 42
                tab42.AttachedControl = painel_do_motor_42
                Exit Select
            Case 43
                tab43.AttachedControl = painel_do_motor_43
                Exit Select
            Case 44
                tab44.AttachedControl = painel_do_motor_44
                Exit Select
            Case 45
                tab45.AttachedControl = painel_do_motor_45
                Exit Select
            Case 46
                tab46.AttachedControl = painel_do_motor_46
                Exit Select
            Case 47
                tab47.AttachedControl = painel_do_motor_47
                Exit Select
            Case 48
                tab48.AttachedControl = painel_do_motor_48
                Exit Select
            Case 49
                tab49.AttachedControl = painel_do_motor_49
                Exit Select
            Case 50
                tab50.AttachedControl = painel_do_motor_50
                Exit Select
            Case 51
                tab51.AttachedControl = painel_do_motor_51
                Exit Select
            Case 52
                tab52.AttachedControl = painel_do_motor_52
                Exit Select
            Case 53
                tab53.AttachedControl = painel_do_motor_53
                Exit Select
            Case 54
                tab54.AttachedControl = painel_do_motor_54
                Exit Select
            Case 55
                tab55.AttachedControl = painel_do_motor_55
                Exit Select
            Case 56
                tab56.AttachedControl = painel_do_motor_56
                Exit Select
            Case 57
                tab57.AttachedControl = painel_do_motor_57
                Exit Select
            Case 58
                tab58.AttachedControl = painel_do_motor_58
                Exit Select
            Case 59
                tab59.AttachedControl = painel_do_motor_59
                Exit Select
            Case 60
                tab60.AttachedControl = painel_do_motor_60
                Exit Select
            Case 61
                tab61.AttachedControl = painel_do_motor_61
                Exit Select
            Case 62
                tab62.AttachedControl = painel_do_motor_62
                Exit Select
            Case 63
                tab63.AttachedControl = painel_do_motor_63
                Exit Select
            Case 64
                tab64.AttachedControl = painel_do_motor_64
                Exit Select
            Case 65
                tab65.AttachedControl = painel_do_motor_65
                Exit Select
            Case 66
                tab66.AttachedControl = painel_do_motor_66
                Exit Select
            Case 67
                tab67.AttachedControl = painel_do_motor_67
                Exit Select
            Case 68
                tab68.AttachedControl = painel_do_motor_68
                Exit Select
            Case 69
                tab69.AttachedControl = painel_do_motor_69
                Exit Select
            Case 70
                tab70.AttachedControl = painel_do_motor_70
                Exit Select
            Case 71
                tab71.AttachedControl = painel_do_motor_71
                Exit Select
            Case 72
                tab72.AttachedControl = painel_do_motor_72
                Exit Select
            Case 73
                tab73.AttachedControl = painel_do_motor_73
                Exit Select
            Case 74
                tab74.AttachedControl = painel_do_motor_74
                Exit Select
            Case 75
                tab75.AttachedControl = painel_do_motor_75
                Exit Select
            Case 76
                tab76.AttachedControl = painel_do_motor_76
                Exit Select
            Case 77
                tab77.AttachedControl = painel_do_motor_77
                Exit Select
            Case 78
                tab78.AttachedControl = painel_do_motor_78
                Exit Select
            Case 79
                tab79.AttachedControl = painel_do_motor_79
                Exit Select
            Case 80
                tab80.AttachedControl = painel_do_motor_80
                Exit Select
            Case 81
                tab81.AttachedControl = painel_do_motor_81
                Exit Select
            Case 82
                tab82.AttachedControl = painel_do_motor_82
                Exit Select
            Case 83
                tab83.AttachedControl = painel_do_motor_83
                Exit Select
            Case 84
                tab84.AttachedControl = painel_do_motor_84
                Exit Select
            Case 85
                tab85.AttachedControl = painel_do_motor_85
                Exit Select
            Case 86
                tab86.AttachedControl = painel_do_motor_86
                Exit Select
            Case 87
                tab87.AttachedControl = painel_do_motor_87
                Exit Select
            Case 88
                tab88.AttachedControl = painel_do_motor_88
                Exit Select
            Case 89
                tab89.AttachedControl = painel_do_motor_89
                Exit Select
            Case 90
                tab90.AttachedControl = painel_do_motor_90
                Exit Select
            Case 91
                tab91.AttachedControl = painel_do_motor_91
                Exit Select
            Case 92
                tab92.AttachedControl = painel_do_motor_92
                Exit Select
            Case 93
                tab93.AttachedControl = painel_do_motor_93
                Exit Select
            Case 94
                tab94.AttachedControl = painel_do_motor_94
                Exit Select
            Case 95
                tab95.AttachedControl = painel_do_motor_95
                Exit Select
            Case 96
                tab96.AttachedControl = painel_do_motor_96
                Exit Select
            Case 97
                tab97.AttachedControl = painel_do_motor_97
                Exit Select
            Case 98
                tab98.AttachedControl = painel_do_motor_98
                Exit Select
            Case 99
                tab99.AttachedControl = painel_do_motor_99
                Exit Select
            Case 100
                tab100.AttachedControl = painel_do_motor_100
                Exit Select
            Case 101
                tab101.AttachedControl = painel_do_motor_101
                Exit Select
            Case 102
                tab102.AttachedControl = painel_do_motor_102
                Exit Select
            Case 103
                tab103.AttachedControl = painel_do_motor_103
                Exit Select
            Case 104
                tab104.AttachedControl = painel_do_motor_104
                Exit Select
            Case 105
                tab105.AttachedControl = painel_do_motor_105
                Exit Select
            Case 106
                tab106.AttachedControl = painel_do_motor_106
                Exit Select
            Case 107
                tab107.AttachedControl = painel_do_motor_107
                Exit Select
            Case 108
                tab108.AttachedControl = painel_do_motor_108
                Exit Select
            Case 109
                tab109.AttachedControl = painel_do_motor_109
                Exit Select
            Case 110
                tab110.AttachedControl = painel_do_motor_110
                Exit Select
            Case 111
                tab111.AttachedControl = painel_do_motor_111
                Exit Select
            Case 112
                tab112.AttachedControl = painel_do_motor_112
                Exit Select
            Case 113
                tab113.AttachedControl = painel_do_motor_113
                Exit Select
            Case 114
                tab114.AttachedControl = painel_do_motor_114
                Exit Select
            Case 115
                tab115.AttachedControl = painel_do_motor_115
                Exit Select
            Case 116
                tab116.AttachedControl = painel_do_motor_116
                Exit Select
            Case 117
                tab117.AttachedControl = painel_do_motor_117
                Exit Select
            Case 118
                tab118.AttachedControl = painel_do_motor_118
                Exit Select
            Case 119
                tab119.AttachedControl = painel_do_motor_119
                Exit Select
            Case 120
                tab120.AttachedControl = painel_do_motor_120
                Exit Select
            Case 121
                tab121.AttachedControl = painel_do_motor_121
                Exit Select
            Case 122
                tab122.AttachedControl = painel_do_motor_122
                Exit Select
            Case 123
                tab123.AttachedControl = painel_do_motor_123
                Exit Select
            Case 124
                tab124.AttachedControl = painel_do_motor_124
                Exit Select
            Case 125
                tab125.AttachedControl = painel_do_motor_125
                Exit Select
            Case 126
                tab126.AttachedControl = painel_do_motor_126
                Exit Select
            Case 127
                tab127.AttachedControl = painel_do_motor_127
                Exit Select
            Case 128
                tab128.AttachedControl = painel_do_motor_128
                Exit Select
            



        End Select

        '------------------------------------------------------------------------------------------------------------------------------------


    End Sub


    Private Sub proc_adiciona_motor_geckofx_no_painel(ByVal V_NUMERO As Integer) 'Adiciona o motor geckofx no painel de motores
        On Error Resume Next


        'Selecionando o numero a usar ------------------------------------------------------------------------------------------------------

        Select Case V_NUMERO


            Case 1
                painel_do_motor_1.Controls.Add(OBJ_MOTOR_GECKOFX_1)
                Exit Select
            Case 2
                painel_do_motor_2.Controls.Add(OBJ_MOTOR_GECKOFX_2)
                Exit Select
            Case 3
                painel_do_motor_3.Controls.Add(OBJ_MOTOR_GECKOFX_3)
                Exit Select
            Case 4
                painel_do_motor_4.Controls.Add(OBJ_MOTOR_GECKOFX_4)
                Exit Select
            Case 5
                painel_do_motor_5.Controls.Add(OBJ_MOTOR_GECKOFX_5)
                Exit Select
            Case 6
                painel_do_motor_6.Controls.Add(OBJ_MOTOR_GECKOFX_6)
                Exit Select
            Case 7
                painel_do_motor_7.Controls.Add(OBJ_MOTOR_GECKOFX_7)
                Exit Select
            Case 8
                painel_do_motor_8.Controls.Add(OBJ_MOTOR_GECKOFX_8)
                Exit Select
            Case 9
                painel_do_motor_9.Controls.Add(OBJ_MOTOR_GECKOFX_9)
                Exit Select
            Case 10
                painel_do_motor_10.Controls.Add(OBJ_MOTOR_GECKOFX_10)
                Exit Select
            Case 11
                painel_do_motor_11.Controls.Add(OBJ_MOTOR_GECKOFX_11)
                Exit Select
            Case 12
                painel_do_motor_12.Controls.Add(OBJ_MOTOR_GECKOFX_12)
                Exit Select
            Case 13
                painel_do_motor_13.Controls.Add(OBJ_MOTOR_GECKOFX_13)
                Exit Select
            Case 14
                painel_do_motor_14.Controls.Add(OBJ_MOTOR_GECKOFX_14)
                Exit Select
            Case 15
                painel_do_motor_15.Controls.Add(OBJ_MOTOR_GECKOFX_15)
                Exit Select
            Case 16
                painel_do_motor_16.Controls.Add(OBJ_MOTOR_GECKOFX_16)
                Exit Select
            Case 17
                painel_do_motor_17.Controls.Add(OBJ_MOTOR_GECKOFX_17)
                Exit Select
            Case 18
                painel_do_motor_18.Controls.Add(OBJ_MOTOR_GECKOFX_18)
                Exit Select
            Case 19
                painel_do_motor_19.Controls.Add(OBJ_MOTOR_GECKOFX_19)
                Exit Select
            Case 20
                painel_do_motor_20.Controls.Add(OBJ_MOTOR_GECKOFX_20)
                Exit Select
            Case 21
                painel_do_motor_21.Controls.Add(OBJ_MOTOR_GECKOFX_21)
                Exit Select
            Case 22
                painel_do_motor_22.Controls.Add(OBJ_MOTOR_GECKOFX_22)
                Exit Select
            Case 23
                painel_do_motor_23.Controls.Add(OBJ_MOTOR_GECKOFX_23)
                Exit Select
            Case 24
                painel_do_motor_24.Controls.Add(OBJ_MOTOR_GECKOFX_24)
                Exit Select
            Case 25
                painel_do_motor_25.Controls.Add(OBJ_MOTOR_GECKOFX_25)
                Exit Select
            Case 26
                painel_do_motor_26.Controls.Add(OBJ_MOTOR_GECKOFX_26)
                Exit Select
            Case 27
                painel_do_motor_27.Controls.Add(OBJ_MOTOR_GECKOFX_27)
                Exit Select
            Case 28
                painel_do_motor_28.Controls.Add(OBJ_MOTOR_GECKOFX_28)
                Exit Select
            Case 29
                painel_do_motor_29.Controls.Add(OBJ_MOTOR_GECKOFX_29)
                Exit Select
            Case 30
                painel_do_motor_30.Controls.Add(OBJ_MOTOR_GECKOFX_30)
                Exit Select
            Case 31
                painel_do_motor_31.Controls.Add(OBJ_MOTOR_GECKOFX_31)
                Exit Select
            Case 32
                painel_do_motor_32.Controls.Add(OBJ_MOTOR_GECKOFX_32)
                Exit Select
            Case 33
                painel_do_motor_33.Controls.Add(OBJ_MOTOR_GECKOFX_33)
                Exit Select
            Case 34
                painel_do_motor_34.Controls.Add(OBJ_MOTOR_GECKOFX_34)
                Exit Select
            Case 35
                painel_do_motor_35.Controls.Add(OBJ_MOTOR_GECKOFX_35)
                Exit Select
            Case 36
                painel_do_motor_36.Controls.Add(OBJ_MOTOR_GECKOFX_36)
                Exit Select
            Case 37
                painel_do_motor_37.Controls.Add(OBJ_MOTOR_GECKOFX_37)
                Exit Select
            Case 38
                painel_do_motor_38.Controls.Add(OBJ_MOTOR_GECKOFX_38)
                Exit Select
            Case 39
                painel_do_motor_39.Controls.Add(OBJ_MOTOR_GECKOFX_39)
                Exit Select
            Case 40
                painel_do_motor_40.Controls.Add(OBJ_MOTOR_GECKOFX_40)
                Exit Select
            Case 41
                painel_do_motor_41.Controls.Add(OBJ_MOTOR_GECKOFX_41)
                Exit Select
            Case 42
                painel_do_motor_42.Controls.Add(OBJ_MOTOR_GECKOFX_42)
                Exit Select
            Case 43
                painel_do_motor_43.Controls.Add(OBJ_MOTOR_GECKOFX_43)
                Exit Select
            Case 44
                painel_do_motor_44.Controls.Add(OBJ_MOTOR_GECKOFX_44)
                Exit Select
            Case 45
                painel_do_motor_45.Controls.Add(OBJ_MOTOR_GECKOFX_45)
                Exit Select
            Case 46
                painel_do_motor_46.Controls.Add(OBJ_MOTOR_GECKOFX_46)
                Exit Select
            Case 47
                painel_do_motor_47.Controls.Add(OBJ_MOTOR_GECKOFX_47)
                Exit Select
            Case 48
                painel_do_motor_48.Controls.Add(OBJ_MOTOR_GECKOFX_48)
                Exit Select
            Case 49
                painel_do_motor_49.Controls.Add(OBJ_MOTOR_GECKOFX_49)
                Exit Select
            Case 50
                painel_do_motor_50.Controls.Add(OBJ_MOTOR_GECKOFX_50)
                Exit Select
            Case 51
                painel_do_motor_51.Controls.Add(OBJ_MOTOR_GECKOFX_51)
                Exit Select
            Case 52
                painel_do_motor_52.Controls.Add(OBJ_MOTOR_GECKOFX_52)
                Exit Select
            Case 53
                painel_do_motor_53.Controls.Add(OBJ_MOTOR_GECKOFX_53)
                Exit Select
            Case 54
                painel_do_motor_54.Controls.Add(OBJ_MOTOR_GECKOFX_54)
                Exit Select
            Case 55
                painel_do_motor_55.Controls.Add(OBJ_MOTOR_GECKOFX_55)
                Exit Select
            Case 56
                painel_do_motor_56.Controls.Add(OBJ_MOTOR_GECKOFX_56)
                Exit Select
            Case 57
                painel_do_motor_57.Controls.Add(OBJ_MOTOR_GECKOFX_57)
                Exit Select
            Case 58
                painel_do_motor_58.Controls.Add(OBJ_MOTOR_GECKOFX_58)
                Exit Select
            Case 59
                painel_do_motor_59.Controls.Add(OBJ_MOTOR_GECKOFX_59)
                Exit Select
            Case 60
                painel_do_motor_60.Controls.Add(OBJ_MOTOR_GECKOFX_60)
                Exit Select
            Case 61
                painel_do_motor_61.Controls.Add(OBJ_MOTOR_GECKOFX_61)
                Exit Select
            Case 62
                painel_do_motor_62.Controls.Add(OBJ_MOTOR_GECKOFX_62)
                Exit Select
            Case 63
                painel_do_motor_63.Controls.Add(OBJ_MOTOR_GECKOFX_63)
                Exit Select
            Case 64
                painel_do_motor_64.Controls.Add(OBJ_MOTOR_GECKOFX_64)
                Exit Select
            Case 65
                painel_do_motor_65.Controls.Add(OBJ_MOTOR_GECKOFX_65)
                Exit Select
            Case 66
                painel_do_motor_66.Controls.Add(OBJ_MOTOR_GECKOFX_66)
                Exit Select
            Case 67
                painel_do_motor_67.Controls.Add(OBJ_MOTOR_GECKOFX_67)
                Exit Select
            Case 68
                painel_do_motor_68.Controls.Add(OBJ_MOTOR_GECKOFX_68)
                Exit Select
            Case 69
                painel_do_motor_69.Controls.Add(OBJ_MOTOR_GECKOFX_69)
                Exit Select
            Case 70
                painel_do_motor_70.Controls.Add(OBJ_MOTOR_GECKOFX_70)
                Exit Select
            Case 71
                painel_do_motor_71.Controls.Add(OBJ_MOTOR_GECKOFX_71)
                Exit Select
            Case 72
                painel_do_motor_72.Controls.Add(OBJ_MOTOR_GECKOFX_72)
                Exit Select
            Case 73
                painel_do_motor_73.Controls.Add(OBJ_MOTOR_GECKOFX_73)
                Exit Select
            Case 74
                painel_do_motor_74.Controls.Add(OBJ_MOTOR_GECKOFX_74)
                Exit Select
            Case 75
                painel_do_motor_75.Controls.Add(OBJ_MOTOR_GECKOFX_75)
                Exit Select
            Case 76
                painel_do_motor_76.Controls.Add(OBJ_MOTOR_GECKOFX_76)
                Exit Select
            Case 77
                painel_do_motor_77.Controls.Add(OBJ_MOTOR_GECKOFX_77)
                Exit Select
            Case 78
                painel_do_motor_78.Controls.Add(OBJ_MOTOR_GECKOFX_78)
                Exit Select
            Case 79
                painel_do_motor_79.Controls.Add(OBJ_MOTOR_GECKOFX_79)
                Exit Select
            Case 80
                painel_do_motor_80.Controls.Add(OBJ_MOTOR_GECKOFX_80)
                Exit Select
            Case 81
                painel_do_motor_81.Controls.Add(OBJ_MOTOR_GECKOFX_81)
                Exit Select
            Case 82
                painel_do_motor_82.Controls.Add(OBJ_MOTOR_GECKOFX_82)
                Exit Select
            Case 83
                painel_do_motor_83.Controls.Add(OBJ_MOTOR_GECKOFX_83)
                Exit Select
            Case 84
                painel_do_motor_84.Controls.Add(OBJ_MOTOR_GECKOFX_84)
                Exit Select
            Case 85
                painel_do_motor_85.Controls.Add(OBJ_MOTOR_GECKOFX_85)
                Exit Select
            Case 86
                painel_do_motor_86.Controls.Add(OBJ_MOTOR_GECKOFX_86)
                Exit Select
            Case 87
                painel_do_motor_87.Controls.Add(OBJ_MOTOR_GECKOFX_87)
                Exit Select
            Case 88
                painel_do_motor_88.Controls.Add(OBJ_MOTOR_GECKOFX_88)
                Exit Select
            Case 89
                painel_do_motor_89.Controls.Add(OBJ_MOTOR_GECKOFX_89)
                Exit Select
            Case 90
                painel_do_motor_90.Controls.Add(OBJ_MOTOR_GECKOFX_90)
                Exit Select
            Case 91
                painel_do_motor_91.Controls.Add(OBJ_MOTOR_GECKOFX_91)
                Exit Select
            Case 92
                painel_do_motor_92.Controls.Add(OBJ_MOTOR_GECKOFX_92)
                Exit Select
            Case 93
                painel_do_motor_93.Controls.Add(OBJ_MOTOR_GECKOFX_93)
                Exit Select
            Case 94
                painel_do_motor_94.Controls.Add(OBJ_MOTOR_GECKOFX_94)
                Exit Select
            Case 95
                painel_do_motor_95.Controls.Add(OBJ_MOTOR_GECKOFX_95)
                Exit Select
            Case 96
                painel_do_motor_96.Controls.Add(OBJ_MOTOR_GECKOFX_96)
                Exit Select
            Case 97
                painel_do_motor_97.Controls.Add(OBJ_MOTOR_GECKOFX_97)
                Exit Select
            Case 98
                painel_do_motor_98.Controls.Add(OBJ_MOTOR_GECKOFX_98)
                Exit Select
            Case 99
                painel_do_motor_99.Controls.Add(OBJ_MOTOR_GECKOFX_99)
                Exit Select
            Case 100
                painel_do_motor_100.Controls.Add(OBJ_MOTOR_GECKOFX_100)
                Exit Select
            Case 101
                painel_do_motor_101.Controls.Add(OBJ_MOTOR_GECKOFX_101)
                Exit Select
            Case 102
                painel_do_motor_102.Controls.Add(OBJ_MOTOR_GECKOFX_102)
                Exit Select
            Case 103
                painel_do_motor_103.Controls.Add(OBJ_MOTOR_GECKOFX_103)
                Exit Select
            Case 104
                painel_do_motor_104.Controls.Add(OBJ_MOTOR_GECKOFX_104)
                Exit Select
            Case 105
                painel_do_motor_105.Controls.Add(OBJ_MOTOR_GECKOFX_105)
                Exit Select
            Case 106
                painel_do_motor_106.Controls.Add(OBJ_MOTOR_GECKOFX_106)
                Exit Select
            Case 107
                painel_do_motor_107.Controls.Add(OBJ_MOTOR_GECKOFX_107)
                Exit Select
            Case 108
                painel_do_motor_108.Controls.Add(OBJ_MOTOR_GECKOFX_108)
                Exit Select
            Case 109
                painel_do_motor_109.Controls.Add(OBJ_MOTOR_GECKOFX_109)
                Exit Select
            Case 110
                painel_do_motor_110.Controls.Add(OBJ_MOTOR_GECKOFX_110)
                Exit Select
            Case 111
                painel_do_motor_111.Controls.Add(OBJ_MOTOR_GECKOFX_111)
                Exit Select
            Case 112
                painel_do_motor_112.Controls.Add(OBJ_MOTOR_GECKOFX_112)
                Exit Select
            Case 113
                painel_do_motor_113.Controls.Add(OBJ_MOTOR_GECKOFX_113)
                Exit Select
            Case 114
                painel_do_motor_114.Controls.Add(OBJ_MOTOR_GECKOFX_114)
                Exit Select
            Case 115
                painel_do_motor_115.Controls.Add(OBJ_MOTOR_GECKOFX_115)
                Exit Select
            Case 116
                painel_do_motor_116.Controls.Add(OBJ_MOTOR_GECKOFX_116)
                Exit Select
            Case 117
                painel_do_motor_117.Controls.Add(OBJ_MOTOR_GECKOFX_117)
                Exit Select
            Case 118
                painel_do_motor_118.Controls.Add(OBJ_MOTOR_GECKOFX_118)
                Exit Select
            Case 119
                painel_do_motor_119.Controls.Add(OBJ_MOTOR_GECKOFX_119)
                Exit Select
            Case 120
                painel_do_motor_120.Controls.Add(OBJ_MOTOR_GECKOFX_120)
                Exit Select
            Case 121
                painel_do_motor_121.Controls.Add(OBJ_MOTOR_GECKOFX_121)
                Exit Select
            Case 122
                painel_do_motor_122.Controls.Add(OBJ_MOTOR_GECKOFX_122)
                Exit Select
            Case 123
                painel_do_motor_123.Controls.Add(OBJ_MOTOR_GECKOFX_123)
                Exit Select
            Case 124
                painel_do_motor_124.Controls.Add(OBJ_MOTOR_GECKOFX_124)
                Exit Select
            Case 125
                painel_do_motor_125.Controls.Add(OBJ_MOTOR_GECKOFX_125)
                Exit Select
            Case 126
                painel_do_motor_126.Controls.Add(OBJ_MOTOR_GECKOFX_126)
                Exit Select
            Case 127
                painel_do_motor_127.Controls.Add(OBJ_MOTOR_GECKOFX_127)
                Exit Select
            Case 128
                painel_do_motor_128.Controls.Add(OBJ_MOTOR_GECKOFX_128)
                Exit Select
            



        End Select

        '------------------------------------------------------------------------------------------------------------------------------------


    End Sub


    Private Sub proc_adiciona_motor_trident_no_painel(ByVal V_NUMERO As Integer) 'Adiciona o motor trident no painel de motores
        On Error Resume Next


        'Selecionando o numero a usar ------------------------------------------------------------------------------------------------------

        Select Case V_NUMERO


            Case 1
                painel_do_motor_1.Controls.Add(OBJ_MOTOR_WEB_BROWSER_1)
                Exit Select
            Case 2
                painel_do_motor_2.Controls.Add(OBJ_MOTOR_WEB_BROWSER_2)
                Exit Select
            Case 3
                painel_do_motor_3.Controls.Add(OBJ_MOTOR_WEB_BROWSER_3)
                Exit Select
            Case 4
                painel_do_motor_4.Controls.Add(OBJ_MOTOR_WEB_BROWSER_4)
                Exit Select
            Case 5
                painel_do_motor_5.Controls.Add(OBJ_MOTOR_WEB_BROWSER_5)
                Exit Select
            Case 6
                painel_do_motor_6.Controls.Add(OBJ_MOTOR_WEB_BROWSER_6)
                Exit Select
            Case 7
                painel_do_motor_7.Controls.Add(OBJ_MOTOR_WEB_BROWSER_7)
                Exit Select
            Case 8
                painel_do_motor_8.Controls.Add(OBJ_MOTOR_WEB_BROWSER_8)
                Exit Select
            Case 9
                painel_do_motor_9.Controls.Add(OBJ_MOTOR_WEB_BROWSER_9)
                Exit Select
            Case 10
                painel_do_motor_10.Controls.Add(OBJ_MOTOR_WEB_BROWSER_10)
                Exit Select
            Case 11
                painel_do_motor_11.Controls.Add(OBJ_MOTOR_WEB_BROWSER_11)
                Exit Select
            Case 12
                painel_do_motor_12.Controls.Add(OBJ_MOTOR_WEB_BROWSER_12)
                Exit Select
            Case 13
                painel_do_motor_13.Controls.Add(OBJ_MOTOR_WEB_BROWSER_13)
                Exit Select
            Case 14
                painel_do_motor_14.Controls.Add(OBJ_MOTOR_WEB_BROWSER_14)
                Exit Select
            Case 15
                painel_do_motor_15.Controls.Add(OBJ_MOTOR_WEB_BROWSER_15)
                Exit Select
            Case 16
                painel_do_motor_16.Controls.Add(OBJ_MOTOR_WEB_BROWSER_16)
                Exit Select
            Case 17
                painel_do_motor_17.Controls.Add(OBJ_MOTOR_WEB_BROWSER_17)
                Exit Select
            Case 18
                painel_do_motor_18.Controls.Add(OBJ_MOTOR_WEB_BROWSER_18)
                Exit Select
            Case 19
                painel_do_motor_19.Controls.Add(OBJ_MOTOR_WEB_BROWSER_19)
                Exit Select
            Case 20
                painel_do_motor_20.Controls.Add(OBJ_MOTOR_WEB_BROWSER_20)
                Exit Select
            Case 21
                painel_do_motor_21.Controls.Add(OBJ_MOTOR_WEB_BROWSER_21)
                Exit Select
            Case 22
                painel_do_motor_22.Controls.Add(OBJ_MOTOR_WEB_BROWSER_22)
                Exit Select
            Case 23
                painel_do_motor_23.Controls.Add(OBJ_MOTOR_WEB_BROWSER_23)
                Exit Select
            Case 24
                painel_do_motor_24.Controls.Add(OBJ_MOTOR_WEB_BROWSER_24)
                Exit Select
            Case 25
                painel_do_motor_25.Controls.Add(OBJ_MOTOR_WEB_BROWSER_25)
                Exit Select
            Case 26
                painel_do_motor_26.Controls.Add(OBJ_MOTOR_WEB_BROWSER_26)
                Exit Select
            Case 27
                painel_do_motor_27.Controls.Add(OBJ_MOTOR_WEB_BROWSER_27)
                Exit Select
            Case 28
                painel_do_motor_28.Controls.Add(OBJ_MOTOR_WEB_BROWSER_28)
                Exit Select
            Case 29
                painel_do_motor_29.Controls.Add(OBJ_MOTOR_WEB_BROWSER_29)
                Exit Select
            Case 30
                painel_do_motor_30.Controls.Add(OBJ_MOTOR_WEB_BROWSER_30)
                Exit Select
            Case 31
                painel_do_motor_31.Controls.Add(OBJ_MOTOR_WEB_BROWSER_31)
                Exit Select
            Case 32
                painel_do_motor_32.Controls.Add(OBJ_MOTOR_WEB_BROWSER_32)
                Exit Select
            Case 33
                painel_do_motor_33.Controls.Add(OBJ_MOTOR_WEB_BROWSER_33)
                Exit Select
            Case 34
                painel_do_motor_34.Controls.Add(OBJ_MOTOR_WEB_BROWSER_34)
                Exit Select
            Case 35
                painel_do_motor_35.Controls.Add(OBJ_MOTOR_WEB_BROWSER_35)
                Exit Select
            Case 36
                painel_do_motor_36.Controls.Add(OBJ_MOTOR_WEB_BROWSER_36)
                Exit Select
            Case 37
                painel_do_motor_37.Controls.Add(OBJ_MOTOR_WEB_BROWSER_37)
                Exit Select
            Case 38
                painel_do_motor_38.Controls.Add(OBJ_MOTOR_WEB_BROWSER_38)
                Exit Select
            Case 39
                painel_do_motor_39.Controls.Add(OBJ_MOTOR_WEB_BROWSER_39)
                Exit Select
            Case 40
                painel_do_motor_40.Controls.Add(OBJ_MOTOR_WEB_BROWSER_40)
                Exit Select
            Case 41
                painel_do_motor_41.Controls.Add(OBJ_MOTOR_WEB_BROWSER_41)
                Exit Select
            Case 42
                painel_do_motor_42.Controls.Add(OBJ_MOTOR_WEB_BROWSER_42)
                Exit Select
            Case 43
                painel_do_motor_43.Controls.Add(OBJ_MOTOR_WEB_BROWSER_43)
                Exit Select
            Case 44
                painel_do_motor_44.Controls.Add(OBJ_MOTOR_WEB_BROWSER_44)
                Exit Select
            Case 45
                painel_do_motor_45.Controls.Add(OBJ_MOTOR_WEB_BROWSER_45)
                Exit Select
            Case 46
                painel_do_motor_46.Controls.Add(OBJ_MOTOR_WEB_BROWSER_46)
                Exit Select
            Case 47
                painel_do_motor_47.Controls.Add(OBJ_MOTOR_WEB_BROWSER_47)
                Exit Select
            Case 48
                painel_do_motor_48.Controls.Add(OBJ_MOTOR_WEB_BROWSER_48)
                Exit Select
            Case 49
                painel_do_motor_49.Controls.Add(OBJ_MOTOR_WEB_BROWSER_49)
                Exit Select
            Case 50
                painel_do_motor_50.Controls.Add(OBJ_MOTOR_WEB_BROWSER_50)
                Exit Select
            Case 51
                painel_do_motor_51.Controls.Add(OBJ_MOTOR_WEB_BROWSER_51)
                Exit Select
            Case 52
                painel_do_motor_52.Controls.Add(OBJ_MOTOR_WEB_BROWSER_52)
                Exit Select
            Case 53
                painel_do_motor_53.Controls.Add(OBJ_MOTOR_WEB_BROWSER_53)
                Exit Select
            Case 54
                painel_do_motor_54.Controls.Add(OBJ_MOTOR_WEB_BROWSER_54)
                Exit Select
            Case 55
                painel_do_motor_55.Controls.Add(OBJ_MOTOR_WEB_BROWSER_55)
                Exit Select
            Case 56
                painel_do_motor_56.Controls.Add(OBJ_MOTOR_WEB_BROWSER_56)
                Exit Select
            Case 57
                painel_do_motor_57.Controls.Add(OBJ_MOTOR_WEB_BROWSER_57)
                Exit Select
            Case 58
                painel_do_motor_58.Controls.Add(OBJ_MOTOR_WEB_BROWSER_58)
                Exit Select
            Case 59
                painel_do_motor_59.Controls.Add(OBJ_MOTOR_WEB_BROWSER_59)
                Exit Select
            Case 60
                painel_do_motor_60.Controls.Add(OBJ_MOTOR_WEB_BROWSER_60)
                Exit Select
            Case 61
                painel_do_motor_61.Controls.Add(OBJ_MOTOR_WEB_BROWSER_61)
                Exit Select
            Case 62
                painel_do_motor_62.Controls.Add(OBJ_MOTOR_WEB_BROWSER_62)
                Exit Select
            Case 63
                painel_do_motor_63.Controls.Add(OBJ_MOTOR_WEB_BROWSER_63)
                Exit Select
            Case 64
                painel_do_motor_64.Controls.Add(OBJ_MOTOR_WEB_BROWSER_64)
                Exit Select
            Case 65
                painel_do_motor_65.Controls.Add(OBJ_MOTOR_WEB_BROWSER_65)
                Exit Select
            Case 66
                painel_do_motor_66.Controls.Add(OBJ_MOTOR_WEB_BROWSER_66)
                Exit Select
            Case 67
                painel_do_motor_67.Controls.Add(OBJ_MOTOR_WEB_BROWSER_67)
                Exit Select
            Case 68
                painel_do_motor_68.Controls.Add(OBJ_MOTOR_WEB_BROWSER_68)
                Exit Select
            Case 69
                painel_do_motor_69.Controls.Add(OBJ_MOTOR_WEB_BROWSER_69)
                Exit Select
            Case 70
                painel_do_motor_70.Controls.Add(OBJ_MOTOR_WEB_BROWSER_70)
                Exit Select
            Case 71
                painel_do_motor_71.Controls.Add(OBJ_MOTOR_WEB_BROWSER_71)
                Exit Select
            Case 72
                painel_do_motor_72.Controls.Add(OBJ_MOTOR_WEB_BROWSER_72)
                Exit Select
            Case 73
                painel_do_motor_73.Controls.Add(OBJ_MOTOR_WEB_BROWSER_73)
                Exit Select
            Case 74
                painel_do_motor_74.Controls.Add(OBJ_MOTOR_WEB_BROWSER_74)
                Exit Select
            Case 75
                painel_do_motor_75.Controls.Add(OBJ_MOTOR_WEB_BROWSER_75)
                Exit Select
            Case 76
                painel_do_motor_76.Controls.Add(OBJ_MOTOR_WEB_BROWSER_76)
                Exit Select
            Case 77
                painel_do_motor_77.Controls.Add(OBJ_MOTOR_WEB_BROWSER_77)
                Exit Select
            Case 78
                painel_do_motor_78.Controls.Add(OBJ_MOTOR_WEB_BROWSER_78)
                Exit Select
            Case 79
                painel_do_motor_79.Controls.Add(OBJ_MOTOR_WEB_BROWSER_79)
                Exit Select
            Case 80
                painel_do_motor_80.Controls.Add(OBJ_MOTOR_WEB_BROWSER_80)
                Exit Select
            Case 81
                painel_do_motor_81.Controls.Add(OBJ_MOTOR_WEB_BROWSER_81)
                Exit Select
            Case 82
                painel_do_motor_82.Controls.Add(OBJ_MOTOR_WEB_BROWSER_82)
                Exit Select
            Case 83
                painel_do_motor_83.Controls.Add(OBJ_MOTOR_WEB_BROWSER_83)
                Exit Select
            Case 84
                painel_do_motor_84.Controls.Add(OBJ_MOTOR_WEB_BROWSER_84)
                Exit Select
            Case 85
                painel_do_motor_85.Controls.Add(OBJ_MOTOR_WEB_BROWSER_85)
                Exit Select
            Case 86
                painel_do_motor_86.Controls.Add(OBJ_MOTOR_WEB_BROWSER_86)
                Exit Select
            Case 87
                painel_do_motor_87.Controls.Add(OBJ_MOTOR_WEB_BROWSER_87)
                Exit Select
            Case 88
                painel_do_motor_88.Controls.Add(OBJ_MOTOR_WEB_BROWSER_88)
                Exit Select
            Case 89
                painel_do_motor_89.Controls.Add(OBJ_MOTOR_WEB_BROWSER_89)
                Exit Select
            Case 90
                painel_do_motor_90.Controls.Add(OBJ_MOTOR_WEB_BROWSER_90)
                Exit Select
            Case 91
                painel_do_motor_91.Controls.Add(OBJ_MOTOR_WEB_BROWSER_91)
                Exit Select
            Case 92
                painel_do_motor_92.Controls.Add(OBJ_MOTOR_WEB_BROWSER_92)
                Exit Select
            Case 93
                painel_do_motor_93.Controls.Add(OBJ_MOTOR_WEB_BROWSER_93)
                Exit Select
            Case 94
                painel_do_motor_94.Controls.Add(OBJ_MOTOR_WEB_BROWSER_94)
                Exit Select
            Case 95
                painel_do_motor_95.Controls.Add(OBJ_MOTOR_WEB_BROWSER_95)
                Exit Select
            Case 96
                painel_do_motor_96.Controls.Add(OBJ_MOTOR_WEB_BROWSER_96)
                Exit Select
            Case 97
                painel_do_motor_97.Controls.Add(OBJ_MOTOR_WEB_BROWSER_97)
                Exit Select
            Case 98
                painel_do_motor_98.Controls.Add(OBJ_MOTOR_WEB_BROWSER_98)
                Exit Select
            Case 99
                painel_do_motor_99.Controls.Add(OBJ_MOTOR_WEB_BROWSER_99)
                Exit Select
            Case 100
                painel_do_motor_100.Controls.Add(OBJ_MOTOR_WEB_BROWSER_100)
                Exit Select
            Case 101
                painel_do_motor_101.Controls.Add(OBJ_MOTOR_WEB_BROWSER_101)
                Exit Select
            Case 102
                painel_do_motor_102.Controls.Add(OBJ_MOTOR_WEB_BROWSER_102)
                Exit Select
            Case 103
                painel_do_motor_103.Controls.Add(OBJ_MOTOR_WEB_BROWSER_103)
                Exit Select
            Case 104
                painel_do_motor_104.Controls.Add(OBJ_MOTOR_WEB_BROWSER_104)
                Exit Select
            Case 105
                painel_do_motor_105.Controls.Add(OBJ_MOTOR_WEB_BROWSER_105)
                Exit Select
            Case 106
                painel_do_motor_106.Controls.Add(OBJ_MOTOR_WEB_BROWSER_106)
                Exit Select
            Case 107
                painel_do_motor_107.Controls.Add(OBJ_MOTOR_WEB_BROWSER_107)
                Exit Select
            Case 108
                painel_do_motor_108.Controls.Add(OBJ_MOTOR_WEB_BROWSER_108)
                Exit Select
            Case 109
                painel_do_motor_109.Controls.Add(OBJ_MOTOR_WEB_BROWSER_109)
                Exit Select
            Case 110
                painel_do_motor_110.Controls.Add(OBJ_MOTOR_WEB_BROWSER_110)
                Exit Select
            Case 111
                painel_do_motor_111.Controls.Add(OBJ_MOTOR_WEB_BROWSER_111)
                Exit Select
            Case 112
                painel_do_motor_112.Controls.Add(OBJ_MOTOR_WEB_BROWSER_112)
                Exit Select
            Case 113
                painel_do_motor_113.Controls.Add(OBJ_MOTOR_WEB_BROWSER_113)
                Exit Select
            Case 114
                painel_do_motor_114.Controls.Add(OBJ_MOTOR_WEB_BROWSER_114)
                Exit Select
            Case 115
                painel_do_motor_115.Controls.Add(OBJ_MOTOR_WEB_BROWSER_115)
                Exit Select
            Case 116
                painel_do_motor_116.Controls.Add(OBJ_MOTOR_WEB_BROWSER_116)
                Exit Select
            Case 117
                painel_do_motor_117.Controls.Add(OBJ_MOTOR_WEB_BROWSER_117)
                Exit Select
            Case 118
                painel_do_motor_118.Controls.Add(OBJ_MOTOR_WEB_BROWSER_118)
                Exit Select
            Case 119
                painel_do_motor_119.Controls.Add(OBJ_MOTOR_WEB_BROWSER_119)
                Exit Select
            Case 120
                painel_do_motor_120.Controls.Add(OBJ_MOTOR_WEB_BROWSER_120)
                Exit Select
            Case 121
                painel_do_motor_121.Controls.Add(OBJ_MOTOR_WEB_BROWSER_121)
                Exit Select
            Case 122
                painel_do_motor_122.Controls.Add(OBJ_MOTOR_WEB_BROWSER_122)
                Exit Select
            Case 123
                painel_do_motor_123.Controls.Add(OBJ_MOTOR_WEB_BROWSER_123)
                Exit Select
            Case 124
                painel_do_motor_124.Controls.Add(OBJ_MOTOR_WEB_BROWSER_124)
                Exit Select
            Case 125
                painel_do_motor_125.Controls.Add(OBJ_MOTOR_WEB_BROWSER_125)
                Exit Select
            Case 126
                painel_do_motor_126.Controls.Add(OBJ_MOTOR_WEB_BROWSER_126)
                Exit Select
            Case 127
                painel_do_motor_127.Controls.Add(OBJ_MOTOR_WEB_BROWSER_127)
                Exit Select
            Case 128
                painel_do_motor_128.Controls.Add(OBJ_MOTOR_WEB_BROWSER_128)
                Exit Select
            



        End Select

        '------------------------------------------------------------------------------------------------------------------------------------


    End Sub


    Private Sub proc_painel_ocupar_toda_a_area(ByVal V_NUMERO As Integer) 'Painel ocupa toda a área
        On Error Resume Next


        'Selecionando o numero a usar ------------------------------------------------------------------------------------------------------

        Select Case V_NUMERO


            Case 1
                painel_do_motor_1.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 2
                painel_do_motor_2.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 3
                painel_do_motor_3.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 4
                painel_do_motor_4.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 5
                painel_do_motor_5.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 6
                painel_do_motor_6.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 7
                painel_do_motor_7.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 8
                painel_do_motor_8.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 9
                painel_do_motor_9.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 10
                painel_do_motor_10.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 11
                painel_do_motor_11.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 12
                painel_do_motor_12.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 13
                painel_do_motor_13.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 14
                painel_do_motor_14.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 15
                painel_do_motor_15.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 16
                painel_do_motor_16.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 17
                painel_do_motor_17.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 18
                painel_do_motor_18.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 19
                painel_do_motor_19.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 20
                painel_do_motor_20.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 21
                painel_do_motor_21.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 22
                painel_do_motor_22.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 23
                painel_do_motor_23.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 24
                painel_do_motor_24.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 25
                painel_do_motor_25.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 26
                painel_do_motor_26.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 27
                painel_do_motor_27.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 28
                painel_do_motor_28.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 29
                painel_do_motor_29.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 30
                painel_do_motor_30.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 31
                painel_do_motor_31.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 32
                painel_do_motor_32.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 33
                painel_do_motor_33.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 34
                painel_do_motor_34.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 35
                painel_do_motor_35.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 36
                painel_do_motor_36.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 37
                painel_do_motor_37.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 38
                painel_do_motor_38.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 39
                painel_do_motor_39.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 40
                painel_do_motor_40.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 41
                painel_do_motor_41.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 42
                painel_do_motor_42.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 43
                painel_do_motor_43.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 44
                painel_do_motor_44.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 45
                painel_do_motor_45.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 46
                painel_do_motor_46.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 47
                painel_do_motor_47.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 48
                painel_do_motor_48.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 49
                painel_do_motor_49.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 50
                painel_do_motor_50.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 51
                painel_do_motor_51.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 52
                painel_do_motor_52.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 53
                painel_do_motor_53.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 54
                painel_do_motor_54.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 55
                painel_do_motor_55.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 56
                painel_do_motor_56.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 57
                painel_do_motor_57.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 58
                painel_do_motor_58.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 59
                painel_do_motor_59.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 60
                painel_do_motor_60.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 61
                painel_do_motor_61.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 62
                painel_do_motor_62.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 63
                painel_do_motor_63.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 64
                painel_do_motor_64.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 65
                painel_do_motor_65.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 66
                painel_do_motor_66.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 67
                painel_do_motor_67.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 68
                painel_do_motor_68.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 69
                painel_do_motor_69.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 70
                painel_do_motor_70.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 71
                painel_do_motor_71.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 72
                painel_do_motor_72.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 73
                painel_do_motor_73.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 74
                painel_do_motor_74.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 75
                painel_do_motor_75.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 76
                painel_do_motor_76.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 77
                painel_do_motor_77.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 78
                painel_do_motor_78.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 79
                painel_do_motor_79.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 80
                painel_do_motor_80.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 81
                painel_do_motor_81.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 82
                painel_do_motor_82.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 83
                painel_do_motor_83.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 84
                painel_do_motor_84.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 85
                painel_do_motor_85.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 86
                painel_do_motor_86.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 87
                painel_do_motor_87.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 88
                painel_do_motor_88.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 89
                painel_do_motor_89.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 90
                painel_do_motor_90.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 91
                painel_do_motor_91.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 92
                painel_do_motor_92.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 93
                painel_do_motor_93.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 94
                painel_do_motor_94.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 95
                painel_do_motor_95.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 96
                painel_do_motor_96.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 97
                painel_do_motor_97.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 98
                painel_do_motor_98.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 99
                painel_do_motor_99.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 100
                painel_do_motor_100.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 101
                painel_do_motor_101.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 102
                painel_do_motor_102.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 103
                painel_do_motor_103.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 104
                painel_do_motor_104.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 105
                painel_do_motor_105.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 106
                painel_do_motor_106.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 107
                painel_do_motor_107.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 108
                painel_do_motor_108.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 109
                painel_do_motor_109.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 110
                painel_do_motor_110.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 111
                painel_do_motor_111.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 112
                painel_do_motor_112.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 113
                painel_do_motor_113.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 114
                painel_do_motor_114.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 115
                painel_do_motor_115.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 116
                painel_do_motor_116.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 117
                painel_do_motor_117.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 118
                painel_do_motor_118.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 119
                painel_do_motor_119.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 120
                painel_do_motor_120.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 121
                painel_do_motor_121.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 122
                painel_do_motor_122.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 123
                painel_do_motor_123.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 124
                painel_do_motor_124.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 125
                painel_do_motor_125.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 126
                painel_do_motor_126.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 127
                painel_do_motor_127.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            Case 128
                painel_do_motor_128.Dock = DockStyle.Fill 'Toda a área
                Exit Select
            



        End Select

        '------------------------------------------------------------------------------------------------------------------------------------


    End Sub


    Private Sub proc_nome_do_motor_geckofx(ByVal V_NUMERO As Integer) 'Dá um novo nome generico ao motor geckofx
        On Error Resume Next


        'Selecionando o numero a usar ------------------------------------------------------------------------------------------------------

        Select Case V_NUMERO


            Case 1
                OBJ_MOTOR_GECKOFX_1.Name = v_nome_generico_motor_geckofx & 1
                Exit Select
            Case 2
                OBJ_MOTOR_GECKOFX_2.Name = v_nome_generico_motor_geckofx & 2
                Exit Select
            Case 3
                OBJ_MOTOR_GECKOFX_3.Name = v_nome_generico_motor_geckofx & 3
                Exit Select
            Case 4
                OBJ_MOTOR_GECKOFX_4.Name = v_nome_generico_motor_geckofx & 4
                Exit Select
            Case 5
                OBJ_MOTOR_GECKOFX_5.Name = v_nome_generico_motor_geckofx & 5
                Exit Select
            Case 6
                OBJ_MOTOR_GECKOFX_6.Name = v_nome_generico_motor_geckofx & 6
                Exit Select
            Case 7
                OBJ_MOTOR_GECKOFX_7.Name = v_nome_generico_motor_geckofx & 7
                Exit Select
            Case 8
                OBJ_MOTOR_GECKOFX_8.Name = v_nome_generico_motor_geckofx & 8
                Exit Select
            Case 9
                OBJ_MOTOR_GECKOFX_9.Name = v_nome_generico_motor_geckofx & 9
                Exit Select
            Case 10
                OBJ_MOTOR_GECKOFX_10.Name = v_nome_generico_motor_geckofx & 10
                Exit Select
            Case 11
                OBJ_MOTOR_GECKOFX_11.Name = v_nome_generico_motor_geckofx & 11
                Exit Select
            Case 12
                OBJ_MOTOR_GECKOFX_12.Name = v_nome_generico_motor_geckofx & 12
                Exit Select
            Case 13
                OBJ_MOTOR_GECKOFX_13.Name = v_nome_generico_motor_geckofx & 13
                Exit Select
            Case 14
                OBJ_MOTOR_GECKOFX_14.Name = v_nome_generico_motor_geckofx & 14
                Exit Select
            Case 15
                OBJ_MOTOR_GECKOFX_15.Name = v_nome_generico_motor_geckofx & 15
                Exit Select
            Case 16
                OBJ_MOTOR_GECKOFX_16.Name = v_nome_generico_motor_geckofx & 16
                Exit Select
            Case 17
                OBJ_MOTOR_GECKOFX_17.Name = v_nome_generico_motor_geckofx & 17
                Exit Select
            Case 18
                OBJ_MOTOR_GECKOFX_18.Name = v_nome_generico_motor_geckofx & 18
                Exit Select
            Case 19
                OBJ_MOTOR_GECKOFX_19.Name = v_nome_generico_motor_geckofx & 19
                Exit Select
            Case 20
                OBJ_MOTOR_GECKOFX_20.Name = v_nome_generico_motor_geckofx & 20
                Exit Select
            Case 21
                OBJ_MOTOR_GECKOFX_21.Name = v_nome_generico_motor_geckofx & 21
                Exit Select
            Case 22
                OBJ_MOTOR_GECKOFX_22.Name = v_nome_generico_motor_geckofx & 22
                Exit Select
            Case 23
                OBJ_MOTOR_GECKOFX_23.Name = v_nome_generico_motor_geckofx & 23
                Exit Select
            Case 24
                OBJ_MOTOR_GECKOFX_24.Name = v_nome_generico_motor_geckofx & 24
                Exit Select
            Case 25
                OBJ_MOTOR_GECKOFX_25.Name = v_nome_generico_motor_geckofx & 25
                Exit Select
            Case 26
                OBJ_MOTOR_GECKOFX_26.Name = v_nome_generico_motor_geckofx & 26
                Exit Select
            Case 27
                OBJ_MOTOR_GECKOFX_27.Name = v_nome_generico_motor_geckofx & 27
                Exit Select
            Case 28
                OBJ_MOTOR_GECKOFX_28.Name = v_nome_generico_motor_geckofx & 28
                Exit Select
            Case 29
                OBJ_MOTOR_GECKOFX_29.Name = v_nome_generico_motor_geckofx & 29
                Exit Select
            Case 30
                OBJ_MOTOR_GECKOFX_30.Name = v_nome_generico_motor_geckofx & 30
                Exit Select
            Case 31
                OBJ_MOTOR_GECKOFX_31.Name = v_nome_generico_motor_geckofx & 31
                Exit Select
            Case 32
                OBJ_MOTOR_GECKOFX_32.Name = v_nome_generico_motor_geckofx & 32
                Exit Select
            Case 33
                OBJ_MOTOR_GECKOFX_33.Name = v_nome_generico_motor_geckofx & 33
                Exit Select
            Case 34
                OBJ_MOTOR_GECKOFX_34.Name = v_nome_generico_motor_geckofx & 34
                Exit Select
            Case 35
                OBJ_MOTOR_GECKOFX_35.Name = v_nome_generico_motor_geckofx & 35
                Exit Select
            Case 36
                OBJ_MOTOR_GECKOFX_36.Name = v_nome_generico_motor_geckofx & 36
                Exit Select
            Case 37
                OBJ_MOTOR_GECKOFX_37.Name = v_nome_generico_motor_geckofx & 37
                Exit Select
            Case 38
                OBJ_MOTOR_GECKOFX_38.Name = v_nome_generico_motor_geckofx & 38
                Exit Select
            Case 39
                OBJ_MOTOR_GECKOFX_39.Name = v_nome_generico_motor_geckofx & 39
                Exit Select
            Case 40
                OBJ_MOTOR_GECKOFX_40.Name = v_nome_generico_motor_geckofx & 40
                Exit Select
            Case 41
                OBJ_MOTOR_GECKOFX_41.Name = v_nome_generico_motor_geckofx & 41
                Exit Select
            Case 42
                OBJ_MOTOR_GECKOFX_42.Name = v_nome_generico_motor_geckofx & 42
                Exit Select
            Case 43
                OBJ_MOTOR_GECKOFX_43.Name = v_nome_generico_motor_geckofx & 43
                Exit Select
            Case 44
                OBJ_MOTOR_GECKOFX_44.Name = v_nome_generico_motor_geckofx & 44
                Exit Select
            Case 45
                OBJ_MOTOR_GECKOFX_45.Name = v_nome_generico_motor_geckofx & 45
                Exit Select
            Case 46
                OBJ_MOTOR_GECKOFX_46.Name = v_nome_generico_motor_geckofx & 46
                Exit Select
            Case 47
                OBJ_MOTOR_GECKOFX_47.Name = v_nome_generico_motor_geckofx & 47
                Exit Select
            Case 48
                OBJ_MOTOR_GECKOFX_48.Name = v_nome_generico_motor_geckofx & 48
                Exit Select
            Case 49
                OBJ_MOTOR_GECKOFX_49.Name = v_nome_generico_motor_geckofx & 49
                Exit Select
            Case 50
                OBJ_MOTOR_GECKOFX_50.Name = v_nome_generico_motor_geckofx & 50
                Exit Select
            Case 51
                OBJ_MOTOR_GECKOFX_51.Name = v_nome_generico_motor_geckofx & 51
                Exit Select
            Case 52
                OBJ_MOTOR_GECKOFX_52.Name = v_nome_generico_motor_geckofx & 52
                Exit Select
            Case 53
                OBJ_MOTOR_GECKOFX_53.Name = v_nome_generico_motor_geckofx & 53
                Exit Select
            Case 54
                OBJ_MOTOR_GECKOFX_54.Name = v_nome_generico_motor_geckofx & 54
                Exit Select
            Case 55
                OBJ_MOTOR_GECKOFX_55.Name = v_nome_generico_motor_geckofx & 55
                Exit Select
            Case 56
                OBJ_MOTOR_GECKOFX_56.Name = v_nome_generico_motor_geckofx & 56
                Exit Select
            Case 57
                OBJ_MOTOR_GECKOFX_57.Name = v_nome_generico_motor_geckofx & 57
                Exit Select
            Case 58
                OBJ_MOTOR_GECKOFX_58.Name = v_nome_generico_motor_geckofx & 58
                Exit Select
            Case 59
                OBJ_MOTOR_GECKOFX_59.Name = v_nome_generico_motor_geckofx & 59
                Exit Select
            Case 60
                OBJ_MOTOR_GECKOFX_60.Name = v_nome_generico_motor_geckofx & 60
                Exit Select
            Case 61
                OBJ_MOTOR_GECKOFX_61.Name = v_nome_generico_motor_geckofx & 61
                Exit Select
            Case 62
                OBJ_MOTOR_GECKOFX_62.Name = v_nome_generico_motor_geckofx & 62
                Exit Select
            Case 63
                OBJ_MOTOR_GECKOFX_63.Name = v_nome_generico_motor_geckofx & 63
                Exit Select
            Case 64
                OBJ_MOTOR_GECKOFX_64.Name = v_nome_generico_motor_geckofx & 64
                Exit Select
            Case 65
                OBJ_MOTOR_GECKOFX_65.Name = v_nome_generico_motor_geckofx & 65
                Exit Select
            Case 66
                OBJ_MOTOR_GECKOFX_66.Name = v_nome_generico_motor_geckofx & 66
                Exit Select
            Case 67
                OBJ_MOTOR_GECKOFX_67.Name = v_nome_generico_motor_geckofx & 67
                Exit Select
            Case 68
                OBJ_MOTOR_GECKOFX_68.Name = v_nome_generico_motor_geckofx & 68
                Exit Select
            Case 69
                OBJ_MOTOR_GECKOFX_69.Name = v_nome_generico_motor_geckofx & 69
                Exit Select
            Case 70
                OBJ_MOTOR_GECKOFX_70.Name = v_nome_generico_motor_geckofx & 70
                Exit Select
            Case 71
                OBJ_MOTOR_GECKOFX_71.Name = v_nome_generico_motor_geckofx & 71
                Exit Select
            Case 72
                OBJ_MOTOR_GECKOFX_72.Name = v_nome_generico_motor_geckofx & 72
                Exit Select
            Case 73
                OBJ_MOTOR_GECKOFX_73.Name = v_nome_generico_motor_geckofx & 73
                Exit Select
            Case 74
                OBJ_MOTOR_GECKOFX_74.Name = v_nome_generico_motor_geckofx & 74
                Exit Select
            Case 75
                OBJ_MOTOR_GECKOFX_75.Name = v_nome_generico_motor_geckofx & 75
                Exit Select
            Case 76
                OBJ_MOTOR_GECKOFX_76.Name = v_nome_generico_motor_geckofx & 76
                Exit Select
            Case 77
                OBJ_MOTOR_GECKOFX_77.Name = v_nome_generico_motor_geckofx & 77
                Exit Select
            Case 78
                OBJ_MOTOR_GECKOFX_78.Name = v_nome_generico_motor_geckofx & 78
                Exit Select
            Case 79
                OBJ_MOTOR_GECKOFX_79.Name = v_nome_generico_motor_geckofx & 79
                Exit Select
            Case 80
                OBJ_MOTOR_GECKOFX_80.Name = v_nome_generico_motor_geckofx & 80
                Exit Select
            Case 81
                OBJ_MOTOR_GECKOFX_81.Name = v_nome_generico_motor_geckofx & 81
                Exit Select
            Case 82
                OBJ_MOTOR_GECKOFX_82.Name = v_nome_generico_motor_geckofx & 82
                Exit Select
            Case 83
                OBJ_MOTOR_GECKOFX_83.Name = v_nome_generico_motor_geckofx & 83
                Exit Select
            Case 84
                OBJ_MOTOR_GECKOFX_84.Name = v_nome_generico_motor_geckofx & 84
                Exit Select
            Case 85
                OBJ_MOTOR_GECKOFX_85.Name = v_nome_generico_motor_geckofx & 85
                Exit Select
            Case 86
                OBJ_MOTOR_GECKOFX_86.Name = v_nome_generico_motor_geckofx & 86
                Exit Select
            Case 87
                OBJ_MOTOR_GECKOFX_87.Name = v_nome_generico_motor_geckofx & 87
                Exit Select
            Case 88
                OBJ_MOTOR_GECKOFX_88.Name = v_nome_generico_motor_geckofx & 88
                Exit Select
            Case 89
                OBJ_MOTOR_GECKOFX_89.Name = v_nome_generico_motor_geckofx & 89
                Exit Select
            Case 90
                OBJ_MOTOR_GECKOFX_90.Name = v_nome_generico_motor_geckofx & 90
                Exit Select
            Case 91
                OBJ_MOTOR_GECKOFX_91.Name = v_nome_generico_motor_geckofx & 91
                Exit Select
            Case 92
                OBJ_MOTOR_GECKOFX_92.Name = v_nome_generico_motor_geckofx & 92
                Exit Select
            Case 93
                OBJ_MOTOR_GECKOFX_93.Name = v_nome_generico_motor_geckofx & 93
                Exit Select
            Case 94
                OBJ_MOTOR_GECKOFX_94.Name = v_nome_generico_motor_geckofx & 94
                Exit Select
            Case 95
                OBJ_MOTOR_GECKOFX_95.Name = v_nome_generico_motor_geckofx & 95
                Exit Select
            Case 96
                OBJ_MOTOR_GECKOFX_96.Name = v_nome_generico_motor_geckofx & 96
                Exit Select
            Case 97
                OBJ_MOTOR_GECKOFX_97.Name = v_nome_generico_motor_geckofx & 97
                Exit Select
            Case 98
                OBJ_MOTOR_GECKOFX_98.Name = v_nome_generico_motor_geckofx & 98
                Exit Select
            Case 99
                OBJ_MOTOR_GECKOFX_99.Name = v_nome_generico_motor_geckofx & 99
                Exit Select
            Case 100
                OBJ_MOTOR_GECKOFX_100.Name = v_nome_generico_motor_geckofx & 100
                Exit Select
            Case 101
                OBJ_MOTOR_GECKOFX_101.Name = v_nome_generico_motor_geckofx & 101
                Exit Select
            Case 102
                OBJ_MOTOR_GECKOFX_102.Name = v_nome_generico_motor_geckofx & 102
                Exit Select
            Case 103
                OBJ_MOTOR_GECKOFX_103.Name = v_nome_generico_motor_geckofx & 103
                Exit Select
            Case 104
                OBJ_MOTOR_GECKOFX_104.Name = v_nome_generico_motor_geckofx & 104
                Exit Select
            Case 105
                OBJ_MOTOR_GECKOFX_105.Name = v_nome_generico_motor_geckofx & 105
                Exit Select
            Case 106
                OBJ_MOTOR_GECKOFX_106.Name = v_nome_generico_motor_geckofx & 106
                Exit Select
            Case 107
                OBJ_MOTOR_GECKOFX_107.Name = v_nome_generico_motor_geckofx & 107
                Exit Select
            Case 108
                OBJ_MOTOR_GECKOFX_108.Name = v_nome_generico_motor_geckofx & 108
                Exit Select
            Case 109
                OBJ_MOTOR_GECKOFX_109.Name = v_nome_generico_motor_geckofx & 109
                Exit Select
            Case 110
                OBJ_MOTOR_GECKOFX_110.Name = v_nome_generico_motor_geckofx & 110
                Exit Select
            Case 111
                OBJ_MOTOR_GECKOFX_111.Name = v_nome_generico_motor_geckofx & 111
                Exit Select
            Case 112
                OBJ_MOTOR_GECKOFX_112.Name = v_nome_generico_motor_geckofx & 112
                Exit Select
            Case 113
                OBJ_MOTOR_GECKOFX_113.Name = v_nome_generico_motor_geckofx & 113
                Exit Select
            Case 114
                OBJ_MOTOR_GECKOFX_114.Name = v_nome_generico_motor_geckofx & 114
                Exit Select
            Case 115
                OBJ_MOTOR_GECKOFX_115.Name = v_nome_generico_motor_geckofx & 115
                Exit Select
            Case 116
                OBJ_MOTOR_GECKOFX_116.Name = v_nome_generico_motor_geckofx & 116
                Exit Select
            Case 117
                OBJ_MOTOR_GECKOFX_117.Name = v_nome_generico_motor_geckofx & 117
                Exit Select
            Case 118
                OBJ_MOTOR_GECKOFX_118.Name = v_nome_generico_motor_geckofx & 118
                Exit Select
            Case 119
                OBJ_MOTOR_GECKOFX_119.Name = v_nome_generico_motor_geckofx & 119
                Exit Select
            Case 120
                OBJ_MOTOR_GECKOFX_120.Name = v_nome_generico_motor_geckofx & 120
                Exit Select
            Case 121
                OBJ_MOTOR_GECKOFX_121.Name = v_nome_generico_motor_geckofx & 121
                Exit Select
            Case 122
                OBJ_MOTOR_GECKOFX_122.Name = v_nome_generico_motor_geckofx & 122
                Exit Select
            Case 123
                OBJ_MOTOR_GECKOFX_123.Name = v_nome_generico_motor_geckofx & 123
                Exit Select
            Case 124
                OBJ_MOTOR_GECKOFX_124.Name = v_nome_generico_motor_geckofx & 124
                Exit Select
            Case 125
                OBJ_MOTOR_GECKOFX_125.Name = v_nome_generico_motor_geckofx & 125
                Exit Select
            Case 126
                OBJ_MOTOR_GECKOFX_126.Name = v_nome_generico_motor_geckofx & 126
                Exit Select
            Case 127
                OBJ_MOTOR_GECKOFX_127.Name = v_nome_generico_motor_geckofx & 127
                Exit Select
            Case 128
                OBJ_MOTOR_GECKOFX_128.Name = v_nome_generico_motor_geckofx & 128
                Exit Select
            



        End Select

        '------------------------------------------------------------------------------------------------------------------------------------


    End Sub


    Private Sub proc_nome_do_motor_trident(ByVal V_NUMERO As Integer) 'Dá um novo nome generico ao motor trident
        On Error Resume Next


        'Selecionando o numero a usar ------------------------------------------------------------------------------------------------------

        Select Case V_NUMERO


            Case 1
                OBJ_MOTOR_WEB_BROWSER_1.Name = v_nome_generico_motor_trdt & 1
                Exit Select
            Case 2
                OBJ_MOTOR_WEB_BROWSER_2.Name = v_nome_generico_motor_trdt & 2
                Exit Select
            Case 3
                OBJ_MOTOR_WEB_BROWSER_3.Name = v_nome_generico_motor_trdt & 3
                Exit Select
            Case 4
                OBJ_MOTOR_WEB_BROWSER_4.Name = v_nome_generico_motor_trdt & 4
                Exit Select
            Case 5
                OBJ_MOTOR_WEB_BROWSER_5.Name = v_nome_generico_motor_trdt & 5
                Exit Select
            Case 6
                OBJ_MOTOR_WEB_BROWSER_6.Name = v_nome_generico_motor_trdt & 6
                Exit Select
            Case 7
                OBJ_MOTOR_WEB_BROWSER_7.Name = v_nome_generico_motor_trdt & 7
                Exit Select
            Case 8
                OBJ_MOTOR_WEB_BROWSER_8.Name = v_nome_generico_motor_trdt & 8
                Exit Select
            Case 9
                OBJ_MOTOR_WEB_BROWSER_9.Name = v_nome_generico_motor_trdt & 9
                Exit Select
            Case 10
                OBJ_MOTOR_WEB_BROWSER_10.Name = v_nome_generico_motor_trdt & 10
                Exit Select
            Case 11
                OBJ_MOTOR_WEB_BROWSER_11.Name = v_nome_generico_motor_trdt & 11
                Exit Select
            Case 12
                OBJ_MOTOR_WEB_BROWSER_12.Name = v_nome_generico_motor_trdt & 12
                Exit Select
            Case 13
                OBJ_MOTOR_WEB_BROWSER_13.Name = v_nome_generico_motor_trdt & 13
                Exit Select
            Case 14
                OBJ_MOTOR_WEB_BROWSER_14.Name = v_nome_generico_motor_trdt & 14
                Exit Select
            Case 15
                OBJ_MOTOR_WEB_BROWSER_15.Name = v_nome_generico_motor_trdt & 15
                Exit Select
            Case 16
                OBJ_MOTOR_WEB_BROWSER_16.Name = v_nome_generico_motor_trdt & 16
                Exit Select
            Case 17
                OBJ_MOTOR_WEB_BROWSER_17.Name = v_nome_generico_motor_trdt & 17
                Exit Select
            Case 18
                OBJ_MOTOR_WEB_BROWSER_18.Name = v_nome_generico_motor_trdt & 18
                Exit Select
            Case 19
                OBJ_MOTOR_WEB_BROWSER_19.Name = v_nome_generico_motor_trdt & 19
                Exit Select
            Case 20
                OBJ_MOTOR_WEB_BROWSER_20.Name = v_nome_generico_motor_trdt & 20
                Exit Select
            Case 21
                OBJ_MOTOR_WEB_BROWSER_21.Name = v_nome_generico_motor_trdt & 21
                Exit Select
            Case 22
                OBJ_MOTOR_WEB_BROWSER_22.Name = v_nome_generico_motor_trdt & 22
                Exit Select
            Case 23
                OBJ_MOTOR_WEB_BROWSER_23.Name = v_nome_generico_motor_trdt & 23
                Exit Select
            Case 24
                OBJ_MOTOR_WEB_BROWSER_24.Name = v_nome_generico_motor_trdt & 24
                Exit Select
            Case 25
                OBJ_MOTOR_WEB_BROWSER_25.Name = v_nome_generico_motor_trdt & 25
                Exit Select
            Case 26
                OBJ_MOTOR_WEB_BROWSER_26.Name = v_nome_generico_motor_trdt & 26
                Exit Select
            Case 27
                OBJ_MOTOR_WEB_BROWSER_27.Name = v_nome_generico_motor_trdt & 27
                Exit Select
            Case 28
                OBJ_MOTOR_WEB_BROWSER_28.Name = v_nome_generico_motor_trdt & 28
                Exit Select
            Case 29
                OBJ_MOTOR_WEB_BROWSER_29.Name = v_nome_generico_motor_trdt & 29
                Exit Select
            Case 30
                OBJ_MOTOR_WEB_BROWSER_30.Name = v_nome_generico_motor_trdt & 30
                Exit Select
            Case 31
                OBJ_MOTOR_WEB_BROWSER_31.Name = v_nome_generico_motor_trdt & 31
                Exit Select
            Case 32
                OBJ_MOTOR_WEB_BROWSER_32.Name = v_nome_generico_motor_trdt & 32
                Exit Select
            Case 33
                OBJ_MOTOR_WEB_BROWSER_33.Name = v_nome_generico_motor_trdt & 33
                Exit Select
            Case 34
                OBJ_MOTOR_WEB_BROWSER_34.Name = v_nome_generico_motor_trdt & 34
                Exit Select
            Case 35
                OBJ_MOTOR_WEB_BROWSER_35.Name = v_nome_generico_motor_trdt & 35
                Exit Select
            Case 36
                OBJ_MOTOR_WEB_BROWSER_36.Name = v_nome_generico_motor_trdt & 36
                Exit Select
            Case 37
                OBJ_MOTOR_WEB_BROWSER_37.Name = v_nome_generico_motor_trdt & 37
                Exit Select
            Case 38
                OBJ_MOTOR_WEB_BROWSER_38.Name = v_nome_generico_motor_trdt & 38
                Exit Select
            Case 39
                OBJ_MOTOR_WEB_BROWSER_39.Name = v_nome_generico_motor_trdt & 39
                Exit Select
            Case 40
                OBJ_MOTOR_WEB_BROWSER_40.Name = v_nome_generico_motor_trdt & 40
                Exit Select
            Case 41
                OBJ_MOTOR_WEB_BROWSER_41.Name = v_nome_generico_motor_trdt & 41
                Exit Select
            Case 42
                OBJ_MOTOR_WEB_BROWSER_42.Name = v_nome_generico_motor_trdt & 42
                Exit Select
            Case 43
                OBJ_MOTOR_WEB_BROWSER_43.Name = v_nome_generico_motor_trdt & 43
                Exit Select
            Case 44
                OBJ_MOTOR_WEB_BROWSER_44.Name = v_nome_generico_motor_trdt & 44
                Exit Select
            Case 45
                OBJ_MOTOR_WEB_BROWSER_45.Name = v_nome_generico_motor_trdt & 45
                Exit Select
            Case 46
                OBJ_MOTOR_WEB_BROWSER_46.Name = v_nome_generico_motor_trdt & 46
                Exit Select
            Case 47
                OBJ_MOTOR_WEB_BROWSER_47.Name = v_nome_generico_motor_trdt & 47
                Exit Select
            Case 48
                OBJ_MOTOR_WEB_BROWSER_48.Name = v_nome_generico_motor_trdt & 48
                Exit Select
            Case 49
                OBJ_MOTOR_WEB_BROWSER_49.Name = v_nome_generico_motor_trdt & 49
                Exit Select
            Case 50
                OBJ_MOTOR_WEB_BROWSER_50.Name = v_nome_generico_motor_trdt & 50
                Exit Select
            Case 51
                OBJ_MOTOR_WEB_BROWSER_51.Name = v_nome_generico_motor_trdt & 51
                Exit Select
            Case 52
                OBJ_MOTOR_WEB_BROWSER_52.Name = v_nome_generico_motor_trdt & 52
                Exit Select
            Case 53
                OBJ_MOTOR_WEB_BROWSER_53.Name = v_nome_generico_motor_trdt & 53
                Exit Select
            Case 54
                OBJ_MOTOR_WEB_BROWSER_54.Name = v_nome_generico_motor_trdt & 54
                Exit Select
            Case 55
                OBJ_MOTOR_WEB_BROWSER_55.Name = v_nome_generico_motor_trdt & 55
                Exit Select
            Case 56
                OBJ_MOTOR_WEB_BROWSER_56.Name = v_nome_generico_motor_trdt & 56
                Exit Select
            Case 57
                OBJ_MOTOR_WEB_BROWSER_57.Name = v_nome_generico_motor_trdt & 57
                Exit Select
            Case 58
                OBJ_MOTOR_WEB_BROWSER_58.Name = v_nome_generico_motor_trdt & 58
                Exit Select
            Case 59
                OBJ_MOTOR_WEB_BROWSER_59.Name = v_nome_generico_motor_trdt & 59
                Exit Select
            Case 60
                OBJ_MOTOR_WEB_BROWSER_60.Name = v_nome_generico_motor_trdt & 60
                Exit Select
            Case 61
                OBJ_MOTOR_WEB_BROWSER_61.Name = v_nome_generico_motor_trdt & 61
                Exit Select
            Case 62
                OBJ_MOTOR_WEB_BROWSER_62.Name = v_nome_generico_motor_trdt & 62
                Exit Select
            Case 63
                OBJ_MOTOR_WEB_BROWSER_63.Name = v_nome_generico_motor_trdt & 63
                Exit Select
            Case 64
                OBJ_MOTOR_WEB_BROWSER_64.Name = v_nome_generico_motor_trdt & 64
                Exit Select
            Case 65
                OBJ_MOTOR_WEB_BROWSER_65.Name = v_nome_generico_motor_trdt & 65
                Exit Select
            Case 66
                OBJ_MOTOR_WEB_BROWSER_66.Name = v_nome_generico_motor_trdt & 66
                Exit Select
            Case 67
                OBJ_MOTOR_WEB_BROWSER_67.Name = v_nome_generico_motor_trdt & 67
                Exit Select
            Case 68
                OBJ_MOTOR_WEB_BROWSER_68.Name = v_nome_generico_motor_trdt & 68
                Exit Select
            Case 69
                OBJ_MOTOR_WEB_BROWSER_69.Name = v_nome_generico_motor_trdt & 69
                Exit Select
            Case 70
                OBJ_MOTOR_WEB_BROWSER_70.Name = v_nome_generico_motor_trdt & 70
                Exit Select
            Case 71
                OBJ_MOTOR_WEB_BROWSER_71.Name = v_nome_generico_motor_trdt & 71
                Exit Select
            Case 72
                OBJ_MOTOR_WEB_BROWSER_72.Name = v_nome_generico_motor_trdt & 72
                Exit Select
            Case 73
                OBJ_MOTOR_WEB_BROWSER_73.Name = v_nome_generico_motor_trdt & 73
                Exit Select
            Case 74
                OBJ_MOTOR_WEB_BROWSER_74.Name = v_nome_generico_motor_trdt & 74
                Exit Select
            Case 75
                OBJ_MOTOR_WEB_BROWSER_75.Name = v_nome_generico_motor_trdt & 75
                Exit Select
            Case 76
                OBJ_MOTOR_WEB_BROWSER_76.Name = v_nome_generico_motor_trdt & 76
                Exit Select
            Case 77
                OBJ_MOTOR_WEB_BROWSER_77.Name = v_nome_generico_motor_trdt & 77
                Exit Select
            Case 78
                OBJ_MOTOR_WEB_BROWSER_78.Name = v_nome_generico_motor_trdt & 78
                Exit Select
            Case 79
                OBJ_MOTOR_WEB_BROWSER_79.Name = v_nome_generico_motor_trdt & 79
                Exit Select
            Case 80
                OBJ_MOTOR_WEB_BROWSER_80.Name = v_nome_generico_motor_trdt & 80
                Exit Select
            Case 81
                OBJ_MOTOR_WEB_BROWSER_81.Name = v_nome_generico_motor_trdt & 81
                Exit Select
            Case 82
                OBJ_MOTOR_WEB_BROWSER_82.Name = v_nome_generico_motor_trdt & 82
                Exit Select
            Case 83
                OBJ_MOTOR_WEB_BROWSER_83.Name = v_nome_generico_motor_trdt & 83
                Exit Select
            Case 84
                OBJ_MOTOR_WEB_BROWSER_84.Name = v_nome_generico_motor_trdt & 84
                Exit Select
            Case 85
                OBJ_MOTOR_WEB_BROWSER_85.Name = v_nome_generico_motor_trdt & 85
                Exit Select
            Case 86
                OBJ_MOTOR_WEB_BROWSER_86.Name = v_nome_generico_motor_trdt & 86
                Exit Select
            Case 87
                OBJ_MOTOR_WEB_BROWSER_87.Name = v_nome_generico_motor_trdt & 87
                Exit Select
            Case 88
                OBJ_MOTOR_WEB_BROWSER_88.Name = v_nome_generico_motor_trdt & 88
                Exit Select
            Case 89
                OBJ_MOTOR_WEB_BROWSER_89.Name = v_nome_generico_motor_trdt & 89
                Exit Select
            Case 90
                OBJ_MOTOR_WEB_BROWSER_90.Name = v_nome_generico_motor_trdt & 90
                Exit Select
            Case 91
                OBJ_MOTOR_WEB_BROWSER_91.Name = v_nome_generico_motor_trdt & 91
                Exit Select
            Case 92
                OBJ_MOTOR_WEB_BROWSER_92.Name = v_nome_generico_motor_trdt & 92
                Exit Select
            Case 93
                OBJ_MOTOR_WEB_BROWSER_93.Name = v_nome_generico_motor_trdt & 93
                Exit Select
            Case 94
                OBJ_MOTOR_WEB_BROWSER_94.Name = v_nome_generico_motor_trdt & 94
                Exit Select
            Case 95
                OBJ_MOTOR_WEB_BROWSER_95.Name = v_nome_generico_motor_trdt & 95
                Exit Select
            Case 96
                OBJ_MOTOR_WEB_BROWSER_96.Name = v_nome_generico_motor_trdt & 96
                Exit Select
            Case 97
                OBJ_MOTOR_WEB_BROWSER_97.Name = v_nome_generico_motor_trdt & 97
                Exit Select
            Case 98
                OBJ_MOTOR_WEB_BROWSER_98.Name = v_nome_generico_motor_trdt & 98
                Exit Select
            Case 99
                OBJ_MOTOR_WEB_BROWSER_99.Name = v_nome_generico_motor_trdt & 99
                Exit Select
            Case 100
                OBJ_MOTOR_WEB_BROWSER_100.Name = v_nome_generico_motor_trdt & 100
                Exit Select
            Case 101
                OBJ_MOTOR_WEB_BROWSER_101.Name = v_nome_generico_motor_trdt & 101
                Exit Select
            Case 102
                OBJ_MOTOR_WEB_BROWSER_102.Name = v_nome_generico_motor_trdt & 102
                Exit Select
            Case 103
                OBJ_MOTOR_WEB_BROWSER_103.Name = v_nome_generico_motor_trdt & 103
                Exit Select
            Case 104
                OBJ_MOTOR_WEB_BROWSER_104.Name = v_nome_generico_motor_trdt & 104
                Exit Select
            Case 105
                OBJ_MOTOR_WEB_BROWSER_105.Name = v_nome_generico_motor_trdt & 105
                Exit Select
            Case 106
                OBJ_MOTOR_WEB_BROWSER_106.Name = v_nome_generico_motor_trdt & 106
                Exit Select
            Case 107
                OBJ_MOTOR_WEB_BROWSER_107.Name = v_nome_generico_motor_trdt & 107
                Exit Select
            Case 108
                OBJ_MOTOR_WEB_BROWSER_108.Name = v_nome_generico_motor_trdt & 108
                Exit Select
            Case 109
                OBJ_MOTOR_WEB_BROWSER_109.Name = v_nome_generico_motor_trdt & 109
                Exit Select
            Case 110
                OBJ_MOTOR_WEB_BROWSER_110.Name = v_nome_generico_motor_trdt & 110
                Exit Select
            Case 111
                OBJ_MOTOR_WEB_BROWSER_111.Name = v_nome_generico_motor_trdt & 111
                Exit Select
            Case 112
                OBJ_MOTOR_WEB_BROWSER_112.Name = v_nome_generico_motor_trdt & 112
                Exit Select
            Case 113
                OBJ_MOTOR_WEB_BROWSER_113.Name = v_nome_generico_motor_trdt & 113
                Exit Select
            Case 114
                OBJ_MOTOR_WEB_BROWSER_114.Name = v_nome_generico_motor_trdt & 114
                Exit Select
            Case 115
                OBJ_MOTOR_WEB_BROWSER_115.Name = v_nome_generico_motor_trdt & 115
                Exit Select
            Case 116
                OBJ_MOTOR_WEB_BROWSER_116.Name = v_nome_generico_motor_trdt & 116
                Exit Select
            Case 117
                OBJ_MOTOR_WEB_BROWSER_117.Name = v_nome_generico_motor_trdt & 117
                Exit Select
            Case 118
                OBJ_MOTOR_WEB_BROWSER_118.Name = v_nome_generico_motor_trdt & 118
                Exit Select
            Case 119
                OBJ_MOTOR_WEB_BROWSER_119.Name = v_nome_generico_motor_trdt & 119
                Exit Select
            Case 120
                OBJ_MOTOR_WEB_BROWSER_120.Name = v_nome_generico_motor_trdt & 120
                Exit Select
            Case 121
                OBJ_MOTOR_WEB_BROWSER_121.Name = v_nome_generico_motor_trdt & 121
                Exit Select
            Case 122
                OBJ_MOTOR_WEB_BROWSER_122.Name = v_nome_generico_motor_trdt & 122
                Exit Select
            Case 123
                OBJ_MOTOR_WEB_BROWSER_123.Name = v_nome_generico_motor_trdt & 123
                Exit Select
            Case 124
                OBJ_MOTOR_WEB_BROWSER_124.Name = v_nome_generico_motor_trdt & 124
                Exit Select
            Case 125
                OBJ_MOTOR_WEB_BROWSER_125.Name = v_nome_generico_motor_trdt & 125
                Exit Select
            Case 126
                OBJ_MOTOR_WEB_BROWSER_126.Name = v_nome_generico_motor_trdt & 126
                Exit Select
            Case 127
                OBJ_MOTOR_WEB_BROWSER_127.Name = v_nome_generico_motor_trdt & 127
                Exit Select
            Case 128
                OBJ_MOTOR_WEB_BROWSER_128.Name = v_nome_generico_motor_trdt & 128
                Exit Select
            



        End Select

        '------------------------------------------------------------------------------------------------------------------------------------


    End Sub


    Private Sub proc_nome_da_tab(ByVal V_NUMERO As Integer) 'Dá um novo nome generico a tab
        On Error Resume Next


        'Selecionando o numero a usar ------------------------------------------------------------------------------------------------------

        Select Case V_NUMERO


            Case 1
                tab1.Name = v_nome_generico_da_tab & 1
                Exit Select
            Case 2
                tab2.Name = v_nome_generico_da_tab & 2
                Exit Select
            Case 3
                tab3.Name = v_nome_generico_da_tab & 3
                Exit Select
            Case 4
                tab4.Name = v_nome_generico_da_tab & 4
                Exit Select
            Case 5
                tab5.Name = v_nome_generico_da_tab & 5
                Exit Select
            Case 6
                tab6.Name = v_nome_generico_da_tab & 6
                Exit Select
            Case 7
                tab7.Name = v_nome_generico_da_tab & 7
                Exit Select
            Case 8
                tab8.Name = v_nome_generico_da_tab & 8
                Exit Select
            Case 9
                tab9.Name = v_nome_generico_da_tab & 9
                Exit Select
            Case 10
                tab10.Name = v_nome_generico_da_tab & 10
                Exit Select
            Case 11
                tab11.Name = v_nome_generico_da_tab & 11
                Exit Select
            Case 12
                tab12.Name = v_nome_generico_da_tab & 12
                Exit Select
            Case 13
                tab13.Name = v_nome_generico_da_tab & 13
                Exit Select
            Case 14
                tab14.Name = v_nome_generico_da_tab & 14
                Exit Select
            Case 15
                tab15.Name = v_nome_generico_da_tab & 15
                Exit Select
            Case 16
                tab16.Name = v_nome_generico_da_tab & 16
                Exit Select
            Case 17
                tab17.Name = v_nome_generico_da_tab & 17
                Exit Select
            Case 18
                tab18.Name = v_nome_generico_da_tab & 18
                Exit Select
            Case 19
                tab19.Name = v_nome_generico_da_tab & 19
                Exit Select
            Case 20
                tab20.Name = v_nome_generico_da_tab & 20
                Exit Select
            Case 21
                tab21.Name = v_nome_generico_da_tab & 21
                Exit Select
            Case 22
                tab22.Name = v_nome_generico_da_tab & 22
                Exit Select
            Case 23
                tab23.Name = v_nome_generico_da_tab & 23
                Exit Select
            Case 24
                tab24.Name = v_nome_generico_da_tab & 24
                Exit Select
            Case 25
                tab25.Name = v_nome_generico_da_tab & 25
                Exit Select
            Case 26
                tab26.Name = v_nome_generico_da_tab & 26
                Exit Select
            Case 27
                tab27.Name = v_nome_generico_da_tab & 27
                Exit Select
            Case 28
                tab28.Name = v_nome_generico_da_tab & 28
                Exit Select
            Case 29
                tab29.Name = v_nome_generico_da_tab & 29
                Exit Select
            Case 30
                tab30.Name = v_nome_generico_da_tab & 30
                Exit Select
            Case 31
                tab31.Name = v_nome_generico_da_tab & 31
                Exit Select
            Case 32
                tab32.Name = v_nome_generico_da_tab & 32
                Exit Select
            Case 33
                tab33.Name = v_nome_generico_da_tab & 33
                Exit Select
            Case 34
                tab34.Name = v_nome_generico_da_tab & 34
                Exit Select
            Case 35
                tab35.Name = v_nome_generico_da_tab & 35
                Exit Select
            Case 36
                tab36.Name = v_nome_generico_da_tab & 36
                Exit Select
            Case 37
                tab37.Name = v_nome_generico_da_tab & 37
                Exit Select
            Case 38
                tab38.Name = v_nome_generico_da_tab & 38
                Exit Select
            Case 39
                tab39.Name = v_nome_generico_da_tab & 39
                Exit Select
            Case 40
                tab40.Name = v_nome_generico_da_tab & 40
                Exit Select
            Case 41
                tab41.Name = v_nome_generico_da_tab & 41
                Exit Select
            Case 42
                tab42.Name = v_nome_generico_da_tab & 42
                Exit Select
            Case 43
                tab43.Name = v_nome_generico_da_tab & 43
                Exit Select
            Case 44
                tab44.Name = v_nome_generico_da_tab & 44
                Exit Select
            Case 45
                tab45.Name = v_nome_generico_da_tab & 45
                Exit Select
            Case 46
                tab46.Name = v_nome_generico_da_tab & 46
                Exit Select
            Case 47
                tab47.Name = v_nome_generico_da_tab & 47
                Exit Select
            Case 48
                tab48.Name = v_nome_generico_da_tab & 48
                Exit Select
            Case 49
                tab49.Name = v_nome_generico_da_tab & 49
                Exit Select
            Case 50
                tab50.Name = v_nome_generico_da_tab & 50
                Exit Select
            Case 51
                tab51.Name = v_nome_generico_da_tab & 51
                Exit Select
            Case 52
                tab52.Name = v_nome_generico_da_tab & 52
                Exit Select
            Case 53
                tab53.Name = v_nome_generico_da_tab & 53
                Exit Select
            Case 54
                tab54.Name = v_nome_generico_da_tab & 54
                Exit Select
            Case 55
                tab55.Name = v_nome_generico_da_tab & 55
                Exit Select
            Case 56
                tab56.Name = v_nome_generico_da_tab & 56
                Exit Select
            Case 57
                tab57.Name = v_nome_generico_da_tab & 57
                Exit Select
            Case 58
                tab58.Name = v_nome_generico_da_tab & 58
                Exit Select
            Case 59
                tab59.Name = v_nome_generico_da_tab & 59
                Exit Select
            Case 60
                tab60.Name = v_nome_generico_da_tab & 60
                Exit Select
            Case 61
                tab61.Name = v_nome_generico_da_tab & 61
                Exit Select
            Case 62
                tab62.Name = v_nome_generico_da_tab & 62
                Exit Select
            Case 63
                tab63.Name = v_nome_generico_da_tab & 63
                Exit Select
            Case 64
                tab64.Name = v_nome_generico_da_tab & 64
                Exit Select
            Case 65
                tab65.Name = v_nome_generico_da_tab & 65
                Exit Select
            Case 66
                tab66.Name = v_nome_generico_da_tab & 66
                Exit Select
            Case 67
                tab67.Name = v_nome_generico_da_tab & 67
                Exit Select
            Case 68
                tab68.Name = v_nome_generico_da_tab & 68
                Exit Select
            Case 69
                tab69.Name = v_nome_generico_da_tab & 69
                Exit Select
            Case 70
                tab70.Name = v_nome_generico_da_tab & 70
                Exit Select
            Case 71
                tab71.Name = v_nome_generico_da_tab & 71
                Exit Select
            Case 72
                tab72.Name = v_nome_generico_da_tab & 72
                Exit Select
            Case 73
                tab73.Name = v_nome_generico_da_tab & 73
                Exit Select
            Case 74
                tab74.Name = v_nome_generico_da_tab & 74
                Exit Select
            Case 75
                tab75.Name = v_nome_generico_da_tab & 75
                Exit Select
            Case 76
                tab76.Name = v_nome_generico_da_tab & 76
                Exit Select
            Case 77
                tab77.Name = v_nome_generico_da_tab & 77
                Exit Select
            Case 78
                tab78.Name = v_nome_generico_da_tab & 78
                Exit Select
            Case 79
                tab79.Name = v_nome_generico_da_tab & 79
                Exit Select
            Case 80
                tab80.Name = v_nome_generico_da_tab & 80
                Exit Select
            Case 81
                tab81.Name = v_nome_generico_da_tab & 81
                Exit Select
            Case 82
                tab82.Name = v_nome_generico_da_tab & 82
                Exit Select
            Case 83
                tab83.Name = v_nome_generico_da_tab & 83
                Exit Select
            Case 84
                tab84.Name = v_nome_generico_da_tab & 84
                Exit Select
            Case 85
                tab85.Name = v_nome_generico_da_tab & 85
                Exit Select
            Case 86
                tab86.Name = v_nome_generico_da_tab & 86
                Exit Select
            Case 87
                tab87.Name = v_nome_generico_da_tab & 87
                Exit Select
            Case 88
                tab88.Name = v_nome_generico_da_tab & 88
                Exit Select
            Case 89
                tab89.Name = v_nome_generico_da_tab & 89
                Exit Select
            Case 90
                tab90.Name = v_nome_generico_da_tab & 90
                Exit Select
            Case 91
                tab91.Name = v_nome_generico_da_tab & 91
                Exit Select
            Case 92
                tab92.Name = v_nome_generico_da_tab & 92
                Exit Select
            Case 93
                tab93.Name = v_nome_generico_da_tab & 93
                Exit Select
            Case 94
                tab94.Name = v_nome_generico_da_tab & 94
                Exit Select
            Case 95
                tab95.Name = v_nome_generico_da_tab & 95
                Exit Select
            Case 96
                tab96.Name = v_nome_generico_da_tab & 96
                Exit Select
            Case 97
                tab97.Name = v_nome_generico_da_tab & 97
                Exit Select
            Case 98
                tab98.Name = v_nome_generico_da_tab & 98
                Exit Select
            Case 99
                tab99.Name = v_nome_generico_da_tab & 99
                Exit Select
            Case 100
                tab100.Name = v_nome_generico_da_tab & 100
                Exit Select
            Case 101
                tab101.Name = v_nome_generico_da_tab & 101
                Exit Select
            Case 102
                tab102.Name = v_nome_generico_da_tab & 102
                Exit Select
            Case 103
                tab103.Name = v_nome_generico_da_tab & 103
                Exit Select
            Case 104
                tab104.Name = v_nome_generico_da_tab & 104
                Exit Select
            Case 105
                tab105.Name = v_nome_generico_da_tab & 105
                Exit Select
            Case 106
                tab106.Name = v_nome_generico_da_tab & 106
                Exit Select
            Case 107
                tab107.Name = v_nome_generico_da_tab & 107
                Exit Select
            Case 108
                tab108.Name = v_nome_generico_da_tab & 108
                Exit Select
            Case 109
                tab109.Name = v_nome_generico_da_tab & 109
                Exit Select
            Case 110
                tab110.Name = v_nome_generico_da_tab & 110
                Exit Select
            Case 111
                tab111.Name = v_nome_generico_da_tab & 111
                Exit Select
            Case 112
                tab112.Name = v_nome_generico_da_tab & 112
                Exit Select
            Case 113
                tab113.Name = v_nome_generico_da_tab & 113
                Exit Select
            Case 114
                tab114.Name = v_nome_generico_da_tab & 114
                Exit Select
            Case 115
                tab115.Name = v_nome_generico_da_tab & 115
                Exit Select
            Case 116
                tab116.Name = v_nome_generico_da_tab & 116
                Exit Select
            Case 117
                tab117.Name = v_nome_generico_da_tab & 117
                Exit Select
            Case 118
                tab118.Name = v_nome_generico_da_tab & 118
                Exit Select
            Case 119
                tab119.Name = v_nome_generico_da_tab & 119
                Exit Select
            Case 120
                tab120.Name = v_nome_generico_da_tab & 120
                Exit Select
            Case 121
                tab121.Name = v_nome_generico_da_tab & 121
                Exit Select
            Case 122
                tab122.Name = v_nome_generico_da_tab & 122
                Exit Select
            Case 123
                tab123.Name = v_nome_generico_da_tab & 123
                Exit Select
            Case 124
                tab124.Name = v_nome_generico_da_tab & 124
                Exit Select
            Case 125
                tab125.Name = v_nome_generico_da_tab & 125
                Exit Select
            Case 126
                tab126.Name = v_nome_generico_da_tab & 126
                Exit Select
            Case 127
                tab127.Name = v_nome_generico_da_tab & 127
                Exit Select
            Case 128
                tab128.Name = v_nome_generico_da_tab & 128
                Exit Select
            



        End Select

        '------------------------------------------------------------------------------------------------------------------------------------


    End Sub






    'Lista das abas na barra de status

    Public Sub proc_nova_referencia_aba_lista_na_barra_de_status(ByVal V_NUMERO As Integer) 'Ao adicionar uma aba adicionar a referencia dela na lista, da barra de status
        On Error Resume Next


        Select Case V_NUMERO

            Case 1
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_1)
                Tool_aba_referencia_1.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_1.Name = v_nome_generico_da_tab_referencia & 1
                Exit Select

            Case 2
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_2)
                Tool_aba_referencia_2.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_2.Name = v_nome_generico_da_tab_referencia & 2
                Exit Select

            Case 3
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_3)
                Tool_aba_referencia_3.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_3.Name = v_nome_generico_da_tab_referencia & 3
                Exit Select

            Case 4
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_4)
                Tool_aba_referencia_4.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_4.Name = v_nome_generico_da_tab_referencia & 4
                Exit Select

            Case 5
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_5)
                Tool_aba_referencia_5.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_5.Name = v_nome_generico_da_tab_referencia & 5
                Exit Select

            Case 6
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_6)
                Tool_aba_referencia_6.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_6.Name = v_nome_generico_da_tab_referencia & 6
                Exit Select

            Case 7
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_7)
                Tool_aba_referencia_7.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_7.Name = v_nome_generico_da_tab_referencia & 7
                Exit Select

            Case 8
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_8)
                Tool_aba_referencia_8.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_8.Name = v_nome_generico_da_tab_referencia & 8
                Exit Select

            Case 9
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_9)
                Tool_aba_referencia_9.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_9.Name = v_nome_generico_da_tab_referencia & 9
                Exit Select

            Case 10
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_10)
                Tool_aba_referencia_10.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_10.Name = v_nome_generico_da_tab_referencia & 10
                Exit Select

            Case 11
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_11)
                Tool_aba_referencia_11.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_11.Name = v_nome_generico_da_tab_referencia & 11
                Exit Select

            Case 12
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_12)
                Tool_aba_referencia_12.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_12.Name = v_nome_generico_da_tab_referencia & 12
                Exit Select

            Case 13
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_13)
                Tool_aba_referencia_13.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_13.Name = v_nome_generico_da_tab_referencia & 13
                Exit Select

            Case 14
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_14)
                Tool_aba_referencia_14.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_14.Name = v_nome_generico_da_tab_referencia & 14
                Exit Select

            Case 15
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_15)
                Tool_aba_referencia_15.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_15.Name = v_nome_generico_da_tab_referencia & 15
                Exit Select

            Case 16
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_16)
                Tool_aba_referencia_16.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_16.Name = v_nome_generico_da_tab_referencia & 16
                Exit Select

            Case 17
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_17)
                Tool_aba_referencia_17.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_17.Name = v_nome_generico_da_tab_referencia & 17
                Exit Select

            Case 18
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_18)
                Tool_aba_referencia_18.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_18.Name = v_nome_generico_da_tab_referencia & 18
                Exit Select

            Case 19
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_19)
                Tool_aba_referencia_19.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_19.Name = v_nome_generico_da_tab_referencia & 19
                Exit Select

            Case 20
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_20)
                Tool_aba_referencia_20.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_20.Name = v_nome_generico_da_tab_referencia & 20
                Exit Select

            Case 21
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_21)
                Tool_aba_referencia_21.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_21.Name = v_nome_generico_da_tab_referencia & 21
                Exit Select

            Case 22
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_22)
                Tool_aba_referencia_22.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_22.Name = v_nome_generico_da_tab_referencia & 22
                Exit Select

            Case 23
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_23)
                Tool_aba_referencia_23.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_23.Name = v_nome_generico_da_tab_referencia & 23
                Exit Select

            Case 24
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_24)
                Tool_aba_referencia_24.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_24.Name = v_nome_generico_da_tab_referencia & 24
                Exit Select

            Case 25
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_25)
                Tool_aba_referencia_25.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_25.Name = v_nome_generico_da_tab_referencia & 25
                Exit Select

            Case 26
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_26)
                Tool_aba_referencia_26.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_26.Name = v_nome_generico_da_tab_referencia & 26
                Exit Select

            Case 27
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_27)
                Tool_aba_referencia_27.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_27.Name = v_nome_generico_da_tab_referencia & 27
                Exit Select

            Case 28
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_28)
                Tool_aba_referencia_28.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_28.Name = v_nome_generico_da_tab_referencia & 28
                Exit Select

            Case 29
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_29)
                Tool_aba_referencia_29.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_29.Name = v_nome_generico_da_tab_referencia & 29
                Exit Select

            Case 30
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_30)
                Tool_aba_referencia_30.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_30.Name = v_nome_generico_da_tab_referencia & 30
                Exit Select

            Case 31
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_31)
                Tool_aba_referencia_31.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_31.Name = v_nome_generico_da_tab_referencia & 31
                Exit Select

            Case 32
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_32)
                Tool_aba_referencia_32.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_32.Name = v_nome_generico_da_tab_referencia & 32
                Exit Select

            Case 33
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_33)
                Tool_aba_referencia_33.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_33.Name = v_nome_generico_da_tab_referencia & 33
                Exit Select

            Case 34
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_34)
                Tool_aba_referencia_34.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_34.Name = v_nome_generico_da_tab_referencia & 34
                Exit Select

            Case 35
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_35)
                Tool_aba_referencia_35.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_35.Name = v_nome_generico_da_tab_referencia & 35
                Exit Select

            Case 36
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_36)
                Tool_aba_referencia_36.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_36.Name = v_nome_generico_da_tab_referencia & 36
                Exit Select

            Case 37
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_37)
                Tool_aba_referencia_37.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_37.Name = v_nome_generico_da_tab_referencia & 37
                Exit Select

            Case 38
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_38)
                Tool_aba_referencia_38.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_38.Name = v_nome_generico_da_tab_referencia & 38
                Exit Select

            Case 39
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_39)
                Tool_aba_referencia_39.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_39.Name = v_nome_generico_da_tab_referencia & 39
                Exit Select

            Case 40
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_40)
                Tool_aba_referencia_40.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_40.Name = v_nome_generico_da_tab_referencia & 40
                Exit Select

            Case 41
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_41)
                Tool_aba_referencia_41.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_41.Name = v_nome_generico_da_tab_referencia & 41
                Exit Select

            Case 42
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_42)
                Tool_aba_referencia_42.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_42.Name = v_nome_generico_da_tab_referencia & 42
                Exit Select

            Case 43
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_43)
                Tool_aba_referencia_43.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_43.Name = v_nome_generico_da_tab_referencia & 43
                Exit Select

            Case 44
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_44)
                Tool_aba_referencia_44.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_44.Name = v_nome_generico_da_tab_referencia & 44
                Exit Select

            Case 45
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_45)
                Tool_aba_referencia_45.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_45.Name = v_nome_generico_da_tab_referencia & 45
                Exit Select

            Case 46
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_46)
                Tool_aba_referencia_46.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_46.Name = v_nome_generico_da_tab_referencia & 46
                Exit Select

            Case 47
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_47)
                Tool_aba_referencia_47.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_47.Name = v_nome_generico_da_tab_referencia & 47
                Exit Select

            Case 48
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_48)
                Tool_aba_referencia_48.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_48.Name = v_nome_generico_da_tab_referencia & 48
                Exit Select

            Case 49
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_49)
                Tool_aba_referencia_49.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_49.Name = v_nome_generico_da_tab_referencia & 49
                Exit Select

            Case 50
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_50)
                Tool_aba_referencia_50.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_50.Name = v_nome_generico_da_tab_referencia & 50
                Exit Select

            Case 51
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_51)
                Tool_aba_referencia_51.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_51.Name = v_nome_generico_da_tab_referencia & 51
                Exit Select

            Case 52
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_52)
                Tool_aba_referencia_52.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_52.Name = v_nome_generico_da_tab_referencia & 52
                Exit Select

            Case 53
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_53)
                Tool_aba_referencia_53.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_53.Name = v_nome_generico_da_tab_referencia & 53
                Exit Select

            Case 54
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_54)
                Tool_aba_referencia_54.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_54.Name = v_nome_generico_da_tab_referencia & 54
                Exit Select

            Case 55
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_55)
                Tool_aba_referencia_55.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_55.Name = v_nome_generico_da_tab_referencia & 55
                Exit Select

            Case 56
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_56)
                Tool_aba_referencia_56.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_56.Name = v_nome_generico_da_tab_referencia & 56
                Exit Select

            Case 57
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_57)
                Tool_aba_referencia_57.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_57.Name = v_nome_generico_da_tab_referencia & 57
                Exit Select

            Case 58
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_58)
                Tool_aba_referencia_58.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_58.Name = v_nome_generico_da_tab_referencia & 58
                Exit Select

            Case 59
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_59)
                Tool_aba_referencia_59.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_59.Name = v_nome_generico_da_tab_referencia & 59
                Exit Select

            Case 60
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_60)
                Tool_aba_referencia_60.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_60.Name = v_nome_generico_da_tab_referencia & 60
                Exit Select

            Case 61
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_61)
                Tool_aba_referencia_61.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_61.Name = v_nome_generico_da_tab_referencia & 61
                Exit Select

            Case 62
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_62)
                Tool_aba_referencia_62.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_62.Name = v_nome_generico_da_tab_referencia & 62
                Exit Select

            Case 63
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_63)
                Tool_aba_referencia_63.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_63.Name = v_nome_generico_da_tab_referencia & 63
                Exit Select

            Case 64
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_64)
                Tool_aba_referencia_64.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_64.Name = v_nome_generico_da_tab_referencia & 64
                Exit Select

            Case 65
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_65)
                Tool_aba_referencia_65.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_65.Name = v_nome_generico_da_tab_referencia & 65
                Exit Select

            Case 66
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_66)
                Tool_aba_referencia_66.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_66.Name = v_nome_generico_da_tab_referencia & 66
                Exit Select

            Case 67
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_67)
                Tool_aba_referencia_67.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_67.Name = v_nome_generico_da_tab_referencia & 67
                Exit Select

            Case 68
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_68)
                Tool_aba_referencia_68.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_68.Name = v_nome_generico_da_tab_referencia & 68
                Exit Select

            Case 69
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_69)
                Tool_aba_referencia_69.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_69.Name = v_nome_generico_da_tab_referencia & 69
                Exit Select

            Case 70
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_70)
                Tool_aba_referencia_70.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_70.Name = v_nome_generico_da_tab_referencia & 70
                Exit Select

            Case 71
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_71)
                Tool_aba_referencia_71.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_71.Name = v_nome_generico_da_tab_referencia & 71
                Exit Select

            Case 72
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_72)
                Tool_aba_referencia_72.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_72.Name = v_nome_generico_da_tab_referencia & 72
                Exit Select

            Case 73
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_73)
                Tool_aba_referencia_73.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_73.Name = v_nome_generico_da_tab_referencia & 73
                Exit Select

            Case 74
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_74)
                Tool_aba_referencia_74.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_74.Name = v_nome_generico_da_tab_referencia & 74
                Exit Select

            Case 75
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_75)
                Tool_aba_referencia_75.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_75.Name = v_nome_generico_da_tab_referencia & 75
                Exit Select

            Case 76
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_76)
                Tool_aba_referencia_76.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_76.Name = v_nome_generico_da_tab_referencia & 76
                Exit Select

            Case 77
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_77)
                Tool_aba_referencia_77.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_77.Name = v_nome_generico_da_tab_referencia & 77
                Exit Select

            Case 78
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_78)
                Tool_aba_referencia_78.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_78.Name = v_nome_generico_da_tab_referencia & 78
                Exit Select

            Case 79
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_79)
                Tool_aba_referencia_79.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_79.Name = v_nome_generico_da_tab_referencia & 79
                Exit Select

            Case 80
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_80)
                Tool_aba_referencia_80.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_80.Name = v_nome_generico_da_tab_referencia & 80
                Exit Select

            Case 81
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_81)
                Tool_aba_referencia_81.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_81.Name = v_nome_generico_da_tab_referencia & 81
                Exit Select

            Case 82
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_82)
                Tool_aba_referencia_82.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_82.Name = v_nome_generico_da_tab_referencia & 82
                Exit Select

            Case 83
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_83)
                Tool_aba_referencia_83.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_83.Name = v_nome_generico_da_tab_referencia & 83
                Exit Select

            Case 84
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_84)
                Tool_aba_referencia_84.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_84.Name = v_nome_generico_da_tab_referencia & 84
                Exit Select

            Case 85
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_85)
                Tool_aba_referencia_85.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_85.Name = v_nome_generico_da_tab_referencia & 85
                Exit Select

            Case 86
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_86)
                Tool_aba_referencia_86.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_86.Name = v_nome_generico_da_tab_referencia & 86
                Exit Select

            Case 87
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_87)
                Tool_aba_referencia_87.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_87.Name = v_nome_generico_da_tab_referencia & 87
                Exit Select

            Case 88
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_88)
                Tool_aba_referencia_88.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_88.Name = v_nome_generico_da_tab_referencia & 88
                Exit Select

            Case 89
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_89)
                Tool_aba_referencia_89.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_89.Name = v_nome_generico_da_tab_referencia & 89
                Exit Select

            Case 90
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_90)
                Tool_aba_referencia_90.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_90.Name = v_nome_generico_da_tab_referencia & 90
                Exit Select

            Case 91
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_91)
                Tool_aba_referencia_91.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_91.Name = v_nome_generico_da_tab_referencia & 91
                Exit Select

            Case 92
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_92)
                Tool_aba_referencia_92.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_92.Name = v_nome_generico_da_tab_referencia & 92
                Exit Select

            Case 93
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_93)
                Tool_aba_referencia_93.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_93.Name = v_nome_generico_da_tab_referencia & 93
                Exit Select

            Case 94
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_94)
                Tool_aba_referencia_94.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_94.Name = v_nome_generico_da_tab_referencia & 94
                Exit Select

            Case 95
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_95)
                Tool_aba_referencia_95.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_95.Name = v_nome_generico_da_tab_referencia & 95
                Exit Select

            Case 96
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_96)
                Tool_aba_referencia_96.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_96.Name = v_nome_generico_da_tab_referencia & 96
                Exit Select

            Case 97
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_97)
                Tool_aba_referencia_97.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_97.Name = v_nome_generico_da_tab_referencia & 97
                Exit Select

            Case 98
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_98)
                Tool_aba_referencia_98.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_98.Name = v_nome_generico_da_tab_referencia & 98
                Exit Select

            Case 99
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_99)
                Tool_aba_referencia_99.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_99.Name = v_nome_generico_da_tab_referencia & 99
                Exit Select

            Case 100
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_100)
                Tool_aba_referencia_100.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_100.Name = v_nome_generico_da_tab_referencia & 100
                Exit Select

            Case 101
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_101)
                Tool_aba_referencia_101.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_101.Name = v_nome_generico_da_tab_referencia & 101
                Exit Select

            Case 102
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_102)
                Tool_aba_referencia_102.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_102.Name = v_nome_generico_da_tab_referencia & 102
                Exit Select

            Case 103
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_103)
                Tool_aba_referencia_103.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_103.Name = v_nome_generico_da_tab_referencia & 103
                Exit Select

            Case 104
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_104)
                Tool_aba_referencia_104.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_104.Name = v_nome_generico_da_tab_referencia & 104
                Exit Select

            Case 105
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_105)
                Tool_aba_referencia_105.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_105.Name = v_nome_generico_da_tab_referencia & 105
                Exit Select

            Case 106
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_106)
                Tool_aba_referencia_106.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_106.Name = v_nome_generico_da_tab_referencia & 106
                Exit Select

            Case 107
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_107)
                Tool_aba_referencia_107.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_107.Name = v_nome_generico_da_tab_referencia & 107
                Exit Select

            Case 108
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_108)
                Tool_aba_referencia_108.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_108.Name = v_nome_generico_da_tab_referencia & 108
                Exit Select

            Case 109
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_109)
                Tool_aba_referencia_109.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_109.Name = v_nome_generico_da_tab_referencia & 109
                Exit Select

            Case 110
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_110)
                Tool_aba_referencia_110.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_110.Name = v_nome_generico_da_tab_referencia & 110
                Exit Select

            Case 111
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_111)
                Tool_aba_referencia_111.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_111.Name = v_nome_generico_da_tab_referencia & 111
                Exit Select

            Case 112
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_112)
                Tool_aba_referencia_112.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_112.Name = v_nome_generico_da_tab_referencia & 112
                Exit Select

            Case 113
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_113)
                Tool_aba_referencia_113.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_113.Name = v_nome_generico_da_tab_referencia & 113
                Exit Select

            Case 114
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_114)
                Tool_aba_referencia_114.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_114.Name = v_nome_generico_da_tab_referencia & 114
                Exit Select

            Case 115
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_115)
                Tool_aba_referencia_115.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_115.Name = v_nome_generico_da_tab_referencia & 115
                Exit Select

            Case 116
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_116)
                Tool_aba_referencia_116.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_116.Name = v_nome_generico_da_tab_referencia & 116
                Exit Select

            Case 117
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_117)
                Tool_aba_referencia_117.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_117.Name = v_nome_generico_da_tab_referencia & 117
                Exit Select

            Case 118
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_118)
                Tool_aba_referencia_118.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_118.Name = v_nome_generico_da_tab_referencia & 118
                Exit Select

            Case 119
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_119)
                Tool_aba_referencia_119.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_119.Name = v_nome_generico_da_tab_referencia & 119
                Exit Select

            Case 120
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_120)
                Tool_aba_referencia_120.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_120.Name = v_nome_generico_da_tab_referencia & 120
                Exit Select

            Case 121
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_121)
                Tool_aba_referencia_121.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_121.Name = v_nome_generico_da_tab_referencia & 121
                Exit Select

            Case 122
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_122)
                Tool_aba_referencia_122.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_122.Name = v_nome_generico_da_tab_referencia & 122
                Exit Select

            Case 123
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_123)
                Tool_aba_referencia_123.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_123.Name = v_nome_generico_da_tab_referencia & 123
                Exit Select

            Case 124
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_124)
                Tool_aba_referencia_124.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_124.Name = v_nome_generico_da_tab_referencia & 124
                Exit Select

            Case 125
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_125)
                Tool_aba_referencia_125.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_125.Name = v_nome_generico_da_tab_referencia & 125
                Exit Select

            Case 126
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_126)
                Tool_aba_referencia_126.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_126.Name = v_nome_generico_da_tab_referencia & 126
                Exit Select

            Case 127
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_127)
                Tool_aba_referencia_127.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_127.Name = v_nome_generico_da_tab_referencia & 127
                Exit Select

            Case 128
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Add(Tool_aba_referencia_128)
                Tool_aba_referencia_128.ToolTipText = "Aba número " & V_NUMERO
                Tool_aba_referencia_128.Name = v_nome_generico_da_tab_referencia & 128
                Exit Select

            



        End Select


    End Sub










    'Adicionador de abas e motores

    Public Function func_retorne_aba_disponivel() 'Retorna a aba disponivel
        On Error Resume Next

        Dim v_retorno As Integer 'Retorno




        'Varre e informa qual aba esta disponivel ---------------------------------------------------------

        For i = 1 To v_quant_maxima_de_abas_abertas



            'Analizando ------------------------------------------------------------

            If (v_aba_disponivel(i) = False) Then



                v_retorno = i 'Retorno definido


                Exit For 'Saindo do looping



            End If

            '-----------------------------------------------------------------------



        Next

        '--------------------------------------------------------------------------------------------------


        'Retorno -------------------------------------------

        Return v_retorno 'Retorno

        '---------------------------------------------------


    End Function

    Public Sub proc_adicionador_de_nova_aba_e_motor(ByVal v_motor_geckofx As Boolean) 'Adiciona o motor geckofx ou não. True para sim e false para nao
        On Error Resume Next

        Dim v_aba_disponivel_numero As Integer 'Informa a aba disponivel






        'Verifica se o computador tem memoria -----------------------------------------------------------------------

        If (V_COMPUTADOR_TEM_MUITA_MEMORIA_LIVRE = False) And (V_VAL_CONFIG_COMPUTADOR_LENTO_SOLUCAO = 3) Then




            If (MsgBox(V_MS_25, MsgBoxStyle.YesNo, "Pouca memória dispinível!") = MsgBoxResult.No) Then

                Exit Sub 'Saindo...

            End If




        End If

        '------------------------------------------------------------------------------------------------------------




        'Inicializando valores --------------------------------------------------------------------------------------

        v_aba_disponivel_numero = func_retorne_aba_disponivel() 'Retorna a aba disponivel

        '------------------------------------------------------------------------------------------------------------




        'Informa numero a ultima aba aberta -------------------------------------------------------------------------

        v_ultima_aba_adicionada_numero = v_aba_disponivel_numero 'Informando...

        '------------------------------------------------------------------------------------------------------------




        'Informa que a aba esta ocupada -----------------------------------------------------------------------------

        v_aba_disponivel(v_aba_disponivel_numero) = True 'Informa que esta aba esta ocupada

        '------------------------------------------------------------------------------------------------------------




        'Adicionando aba e motor ------------------------------------------------------------------------------------


        'Escolhendo o motor certo...

        If (v_motor_geckofx = True) Then


            proc_prototico_geckofx_definir(v_aba_disponivel_numero) 'Define o motor prototico do geckofx

            v_tipo_de_motor_adicionado(v_aba_disponivel_numero) = True 'Informa o tipo de motor adicionado


        Else


            proc_prototico_trident_definir(v_aba_disponivel_numero) 'Define o motor prototico do trident

            v_tipo_de_motor_adicionado(v_aba_disponivel_numero) = False 'Informa o tipo de motor adicionado


        End If

        '------------------------------------------------------------------------------------------------------------




        'Adiciona o painel, aba e liga os controles -----------------------------------------------------------------

        proc_adiciona_painel(v_aba_disponivel_numero) 'Painel do motor layout engine 'Adiciona o painel na aba

        proc_adicionar_aba(v_aba_disponivel_numero) 'Adicionar a nova aba

        proc_ligar_tab_e_painel(v_aba_disponivel_numero) 'Liga a tab ao painel

        '------------------------------------------------------------------------------------------------------------




        'Escolhe qual motor adicionar -------------------------------------------------------------------------------

        If (v_motor_geckofx = True) Then


            proc_adiciona_motor_geckofx_no_painel(v_aba_disponivel_numero) 'Adiciona o motor geckofx no painel de motores


        Else


            proc_adiciona_motor_trident_no_painel(v_aba_disponivel_numero) 'Adiciona o motor trident no painel de motores


        End If

        '------------------------------------------------------------------------------------------------------------




        'Prenchimento do painel -------------------------------------------------------------------------------------

        proc_painel_ocupar_toda_a_area(v_aba_disponivel_numero) 'Painel ocupa toda a área

        '------------------------------------------------------------------------------------------------------------




        'Escolhe qual motor nomear ----------------------------------------------------------------------------------

        If (v_motor_geckofx = True) Then


            proc_nome_do_motor_geckofx(v_aba_disponivel_numero) 'Dá um novo nome generico ao motor geckofx


        Else


            proc_nome_do_motor_trident(v_aba_disponivel_numero) 'Dá um novo nome generico ao motor trident


        End If

        '------------------------------------------------------------------------------------------------------------




        'Nome da aba ---------------------------------------------------------

        proc_nome_da_tab(v_aba_disponivel_numero) 'Dá um novo nome generico a tab

        '---------------------------------------------------------------------




        'Informa agora qual motor esta em uso agora -----------------------------------------------------------------

        v_tipo_de_motor_layout_engine_em_uso_agora = v_motor_geckofx 'Informa o tipo de motor em uso

        v_qual_motor_esta_em_uso = v_aba_disponivel_numero 'Informa qual motor esta em uso

        '------------------------------------------------------------------------------------------------------------




        'Adiciona agora os eventos de tempo de execução -------------------------------------------------------------

        proc_adicionador_de_eventos_em_tempo_de_execucao() 'Adiciona o evento em tempo de execução

        '------------------------------------------------------------------------------------------------------------




        'Atualiza o objeto de tabs ----------------------------------------------------------------------------------

        FRM_NAVEGACAO.TabControl1.Refresh() 'Atualizando...

        '------------------------------------------------------------------------------------------------------------




        'Informa ao usuario que talvez tenha aberto abas demais -----------------------------------------------------

        proc_informar_que_abriu_abas_demais() 'Informa ao usuario que muitas abas foram abertas

        '------------------------------------------------------------------------------------------------------------




        'Atualiza nova aba na lista de abas abertas, na barra de status ------------------------------------------------------------------------

        proc_nova_referencia_aba_lista_na_barra_de_status(v_aba_disponivel_numero) 'Ao adicionar uma aba adicionar a referencia dela na lista, da barra de status

        '---------------------------------------------------------------------------------------------------------------------------------------



    End Sub










    'Removedor de motores

    Public Sub proc_atualize_aba_disponivel(ByVal V_NOME_TAB_FECHADA As String) 'Toda vez que uma tab for fechada atualizar para adicionar nova aba posteriormente.
        On Error Resume Next


        Select Case V_NOME_TAB_FECHADA


            Case v_nome_generico_da_tab & 1
                v_aba_disponivel(1) = False
                Exit Select
            Case v_nome_generico_da_tab & 2
                v_aba_disponivel(2) = False
                Exit Select
            Case v_nome_generico_da_tab & 3
                v_aba_disponivel(3) = False
                Exit Select
            Case v_nome_generico_da_tab & 4
                v_aba_disponivel(4) = False
                Exit Select
            Case v_nome_generico_da_tab & 5
                v_aba_disponivel(5) = False
                Exit Select
            Case v_nome_generico_da_tab & 6
                v_aba_disponivel(6) = False
                Exit Select
            Case v_nome_generico_da_tab & 7
                v_aba_disponivel(7) = False
                Exit Select
            Case v_nome_generico_da_tab & 8
                v_aba_disponivel(8) = False
                Exit Select
            Case v_nome_generico_da_tab & 9
                v_aba_disponivel(9) = False
                Exit Select
            Case v_nome_generico_da_tab & 10
                v_aba_disponivel(10) = False
                Exit Select
            Case v_nome_generico_da_tab & 11
                v_aba_disponivel(11) = False
                Exit Select
            Case v_nome_generico_da_tab & 12
                v_aba_disponivel(12) = False
                Exit Select
            Case v_nome_generico_da_tab & 13
                v_aba_disponivel(13) = False
                Exit Select
            Case v_nome_generico_da_tab & 14
                v_aba_disponivel(14) = False
                Exit Select
            Case v_nome_generico_da_tab & 15
                v_aba_disponivel(15) = False
                Exit Select
            Case v_nome_generico_da_tab & 16
                v_aba_disponivel(16) = False
                Exit Select
            Case v_nome_generico_da_tab & 17
                v_aba_disponivel(17) = False
                Exit Select
            Case v_nome_generico_da_tab & 18
                v_aba_disponivel(18) = False
                Exit Select
            Case v_nome_generico_da_tab & 19
                v_aba_disponivel(19) = False
                Exit Select
            Case v_nome_generico_da_tab & 20
                v_aba_disponivel(20) = False
                Exit Select
            Case v_nome_generico_da_tab & 21
                v_aba_disponivel(21) = False
                Exit Select
            Case v_nome_generico_da_tab & 22
                v_aba_disponivel(22) = False
                Exit Select
            Case v_nome_generico_da_tab & 23
                v_aba_disponivel(23) = False
                Exit Select
            Case v_nome_generico_da_tab & 24
                v_aba_disponivel(24) = False
                Exit Select
            Case v_nome_generico_da_tab & 25
                v_aba_disponivel(25) = False
                Exit Select
            Case v_nome_generico_da_tab & 26
                v_aba_disponivel(26) = False
                Exit Select
            Case v_nome_generico_da_tab & 27
                v_aba_disponivel(27) = False
                Exit Select
            Case v_nome_generico_da_tab & 28
                v_aba_disponivel(28) = False
                Exit Select
            Case v_nome_generico_da_tab & 29
                v_aba_disponivel(29) = False
                Exit Select
            Case v_nome_generico_da_tab & 30
                v_aba_disponivel(30) = False
                Exit Select
            Case v_nome_generico_da_tab & 31
                v_aba_disponivel(31) = False
                Exit Select
            Case v_nome_generico_da_tab & 32
                v_aba_disponivel(32) = False
                Exit Select
            Case v_nome_generico_da_tab & 33
                v_aba_disponivel(33) = False
                Exit Select
            Case v_nome_generico_da_tab & 34
                v_aba_disponivel(34) = False
                Exit Select
            Case v_nome_generico_da_tab & 35
                v_aba_disponivel(35) = False
                Exit Select
            Case v_nome_generico_da_tab & 36
                v_aba_disponivel(36) = False
                Exit Select
            Case v_nome_generico_da_tab & 37
                v_aba_disponivel(37) = False
                Exit Select
            Case v_nome_generico_da_tab & 38
                v_aba_disponivel(38) = False
                Exit Select
            Case v_nome_generico_da_tab & 39
                v_aba_disponivel(39) = False
                Exit Select
            Case v_nome_generico_da_tab & 40
                v_aba_disponivel(40) = False
                Exit Select
            Case v_nome_generico_da_tab & 41
                v_aba_disponivel(41) = False
                Exit Select
            Case v_nome_generico_da_tab & 42
                v_aba_disponivel(42) = False
                Exit Select
            Case v_nome_generico_da_tab & 43
                v_aba_disponivel(43) = False
                Exit Select
            Case v_nome_generico_da_tab & 44
                v_aba_disponivel(44) = False
                Exit Select
            Case v_nome_generico_da_tab & 45
                v_aba_disponivel(45) = False
                Exit Select
            Case v_nome_generico_da_tab & 46
                v_aba_disponivel(46) = False
                Exit Select
            Case v_nome_generico_da_tab & 47
                v_aba_disponivel(47) = False
                Exit Select
            Case v_nome_generico_da_tab & 48
                v_aba_disponivel(48) = False
                Exit Select
            Case v_nome_generico_da_tab & 49
                v_aba_disponivel(49) = False
                Exit Select
            Case v_nome_generico_da_tab & 50
                v_aba_disponivel(50) = False
                Exit Select
            Case v_nome_generico_da_tab & 51
                v_aba_disponivel(51) = False
                Exit Select
            Case v_nome_generico_da_tab & 52
                v_aba_disponivel(52) = False
                Exit Select
            Case v_nome_generico_da_tab & 53
                v_aba_disponivel(53) = False
                Exit Select
            Case v_nome_generico_da_tab & 54
                v_aba_disponivel(54) = False
                Exit Select
            Case v_nome_generico_da_tab & 55
                v_aba_disponivel(55) = False
                Exit Select
            Case v_nome_generico_da_tab & 56
                v_aba_disponivel(56) = False
                Exit Select
            Case v_nome_generico_da_tab & 57
                v_aba_disponivel(57) = False
                Exit Select
            Case v_nome_generico_da_tab & 58
                v_aba_disponivel(58) = False
                Exit Select
            Case v_nome_generico_da_tab & 59
                v_aba_disponivel(59) = False
                Exit Select
            Case v_nome_generico_da_tab & 60
                v_aba_disponivel(60) = False
                Exit Select
            Case v_nome_generico_da_tab & 61
                v_aba_disponivel(61) = False
                Exit Select
            Case v_nome_generico_da_tab & 62
                v_aba_disponivel(62) = False
                Exit Select
            Case v_nome_generico_da_tab & 63
                v_aba_disponivel(63) = False
                Exit Select
            Case v_nome_generico_da_tab & 64
                v_aba_disponivel(64) = False
                Exit Select
            Case v_nome_generico_da_tab & 65
                v_aba_disponivel(65) = False
                Exit Select
            Case v_nome_generico_da_tab & 66
                v_aba_disponivel(66) = False
                Exit Select
            Case v_nome_generico_da_tab & 67
                v_aba_disponivel(67) = False
                Exit Select
            Case v_nome_generico_da_tab & 68
                v_aba_disponivel(68) = False
                Exit Select
            Case v_nome_generico_da_tab & 69
                v_aba_disponivel(69) = False
                Exit Select
            Case v_nome_generico_da_tab & 70
                v_aba_disponivel(70) = False
                Exit Select
            Case v_nome_generico_da_tab & 71
                v_aba_disponivel(71) = False
                Exit Select
            Case v_nome_generico_da_tab & 72
                v_aba_disponivel(72) = False
                Exit Select
            Case v_nome_generico_da_tab & 73
                v_aba_disponivel(73) = False
                Exit Select
            Case v_nome_generico_da_tab & 74
                v_aba_disponivel(74) = False
                Exit Select
            Case v_nome_generico_da_tab & 75
                v_aba_disponivel(75) = False
                Exit Select
            Case v_nome_generico_da_tab & 76
                v_aba_disponivel(76) = False
                Exit Select
            Case v_nome_generico_da_tab & 77
                v_aba_disponivel(77) = False
                Exit Select
            Case v_nome_generico_da_tab & 78
                v_aba_disponivel(78) = False
                Exit Select
            Case v_nome_generico_da_tab & 79
                v_aba_disponivel(79) = False
                Exit Select
            Case v_nome_generico_da_tab & 80
                v_aba_disponivel(80) = False
                Exit Select
            Case v_nome_generico_da_tab & 81
                v_aba_disponivel(81) = False
                Exit Select
            Case v_nome_generico_da_tab & 82
                v_aba_disponivel(82) = False
                Exit Select
            Case v_nome_generico_da_tab & 83
                v_aba_disponivel(83) = False
                Exit Select
            Case v_nome_generico_da_tab & 84
                v_aba_disponivel(84) = False
                Exit Select
            Case v_nome_generico_da_tab & 85
                v_aba_disponivel(85) = False
                Exit Select
            Case v_nome_generico_da_tab & 86
                v_aba_disponivel(86) = False
                Exit Select
            Case v_nome_generico_da_tab & 87
                v_aba_disponivel(87) = False
                Exit Select
            Case v_nome_generico_da_tab & 88
                v_aba_disponivel(88) = False
                Exit Select
            Case v_nome_generico_da_tab & 89
                v_aba_disponivel(89) = False
                Exit Select
            Case v_nome_generico_da_tab & 90
                v_aba_disponivel(90) = False
                Exit Select
            Case v_nome_generico_da_tab & 91
                v_aba_disponivel(91) = False
                Exit Select
            Case v_nome_generico_da_tab & 92
                v_aba_disponivel(92) = False
                Exit Select
            Case v_nome_generico_da_tab & 93
                v_aba_disponivel(93) = False
                Exit Select
            Case v_nome_generico_da_tab & 94
                v_aba_disponivel(94) = False
                Exit Select
            Case v_nome_generico_da_tab & 95
                v_aba_disponivel(95) = False
                Exit Select
            Case v_nome_generico_da_tab & 96
                v_aba_disponivel(96) = False
                Exit Select
            Case v_nome_generico_da_tab & 97
                v_aba_disponivel(97) = False
                Exit Select
            Case v_nome_generico_da_tab & 98
                v_aba_disponivel(98) = False
                Exit Select
            Case v_nome_generico_da_tab & 99
                v_aba_disponivel(99) = False
                Exit Select
            Case v_nome_generico_da_tab & 100
                v_aba_disponivel(100) = False
                Exit Select
            Case v_nome_generico_da_tab & 101
                v_aba_disponivel(101) = False
                Exit Select
            Case v_nome_generico_da_tab & 102
                v_aba_disponivel(102) = False
                Exit Select
            Case v_nome_generico_da_tab & 103
                v_aba_disponivel(103) = False
                Exit Select
            Case v_nome_generico_da_tab & 104
                v_aba_disponivel(104) = False
                Exit Select
            Case v_nome_generico_da_tab & 105
                v_aba_disponivel(105) = False
                Exit Select
            Case v_nome_generico_da_tab & 106
                v_aba_disponivel(106) = False
                Exit Select
            Case v_nome_generico_da_tab & 107
                v_aba_disponivel(107) = False
                Exit Select
            Case v_nome_generico_da_tab & 108
                v_aba_disponivel(108) = False
                Exit Select
            Case v_nome_generico_da_tab & 109
                v_aba_disponivel(109) = False
                Exit Select
            Case v_nome_generico_da_tab & 110
                v_aba_disponivel(110) = False
                Exit Select
            Case v_nome_generico_da_tab & 111
                v_aba_disponivel(111) = False
                Exit Select
            Case v_nome_generico_da_tab & 112
                v_aba_disponivel(112) = False
                Exit Select
            Case v_nome_generico_da_tab & 113
                v_aba_disponivel(113) = False
                Exit Select
            Case v_nome_generico_da_tab & 114
                v_aba_disponivel(114) = False
                Exit Select
            Case v_nome_generico_da_tab & 115
                v_aba_disponivel(115) = False
                Exit Select
            Case v_nome_generico_da_tab & 116
                v_aba_disponivel(116) = False
                Exit Select
            Case v_nome_generico_da_tab & 117
                v_aba_disponivel(117) = False
                Exit Select
            Case v_nome_generico_da_tab & 118
                v_aba_disponivel(118) = False
                Exit Select
            Case v_nome_generico_da_tab & 119
                v_aba_disponivel(119) = False
                Exit Select
            Case v_nome_generico_da_tab & 120
                v_aba_disponivel(120) = False
                Exit Select
            Case v_nome_generico_da_tab & 121
                v_aba_disponivel(121) = False
                Exit Select
            Case v_nome_generico_da_tab & 122
                v_aba_disponivel(122) = False
                Exit Select
            Case v_nome_generico_da_tab & 123
                v_aba_disponivel(123) = False
                Exit Select
            Case v_nome_generico_da_tab & 124
                v_aba_disponivel(124) = False
                Exit Select
            Case v_nome_generico_da_tab & 125
                v_aba_disponivel(125) = False
                Exit Select
            Case v_nome_generico_da_tab & 126
                v_aba_disponivel(126) = False
                Exit Select
            Case v_nome_generico_da_tab & 127
                v_aba_disponivel(127) = False
                Exit Select
            Case v_nome_generico_da_tab & 128
                v_aba_disponivel(128) = False
                Exit Select
            




        End Select


    End Sub

    Public Sub proc_remove_ligacao_entre_paineis_de_motores(ByVal V_NOME_TAB_FECHADA As String) 'Remove a ligação entre paineis dos motores
        On Error Resume Next


        Select Case V_NOME_TAB_FECHADA


            Case v_nome_generico_da_tab & 1
                tab1.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 2
                tab2.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 3
                tab3.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 4
                tab4.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 5
                tab5.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 6
                tab6.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 7
                tab7.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 8
                tab8.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 9
                tab9.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 10
                tab10.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 11
                tab11.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 12
                tab12.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 13
                tab13.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 14
                tab14.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 15
                tab15.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 16
                tab16.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 17
                tab17.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 18
                tab18.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 19
                tab19.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 20
                tab20.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 21
                tab21.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 22
                tab22.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 23
                tab23.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 24
                tab24.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 25
                tab25.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 26
                tab26.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 27
                tab27.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 28
                tab28.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 29
                tab29.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 30
                tab30.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 31
                tab31.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 32
                tab32.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 33
                tab33.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 34
                tab34.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 35
                tab35.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 36
                tab36.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 37
                tab37.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 38
                tab38.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 39
                tab39.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 40
                tab40.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 41
                tab41.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 42
                tab42.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 43
                tab43.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 44
                tab44.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 45
                tab45.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 46
                tab46.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 47
                tab47.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 48
                tab48.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 49
                tab49.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 50
                tab50.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 51
                tab51.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 52
                tab52.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 53
                tab53.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 54
                tab54.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 55
                tab55.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 56
                tab56.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 57
                tab57.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 58
                tab58.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 59
                tab59.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 60
                tab60.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 61
                tab61.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 62
                tab62.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 63
                tab63.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 64
                tab64.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 65
                tab65.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 66
                tab66.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 67
                tab67.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 68
                tab68.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 69
                tab69.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 70
                tab70.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 71
                tab71.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 72
                tab72.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 73
                tab73.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 74
                tab74.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 75
                tab75.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 76
                tab76.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 77
                tab77.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 78
                tab78.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 79
                tab79.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 80
                tab80.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 81
                tab81.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 82
                tab82.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 83
                tab83.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 84
                tab84.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 85
                tab85.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 86
                tab86.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 87
                tab87.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 88
                tab88.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 89
                tab89.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 90
                tab90.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 91
                tab91.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 92
                tab92.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 93
                tab93.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 94
                tab94.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 95
                tab95.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 96
                tab96.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 97
                tab97.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 98
                tab98.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 99
                tab99.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 100
                tab100.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 101
                tab101.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 102
                tab102.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 103
                tab103.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 104
                tab104.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 105
                tab105.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 106
                tab106.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 107
                tab107.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 108
                tab108.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 109
                tab109.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 110
                tab110.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 111
                tab111.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 112
                tab112.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 113
                tab113.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 114
                tab114.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 115
                tab115.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 116
                tab116.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 117
                tab117.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 118
                tab118.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 119
                tab119.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 120
                tab120.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 121
                tab121.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 122
                tab122.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 123
                tab123.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 124
                tab124.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 125
                tab125.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 126
                tab126.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 127
                tab127.AttachedControl = Nothing
                Exit Select
            Case v_nome_generico_da_tab & 128
                tab128.AttachedControl = Nothing
                Exit Select
            


        End Select


    End Sub

    Public Sub proc_para_execucao_de_motor_geckofx(ByVal V_NOME_TAB_FECHADA As String) 'Fecha o motor geckofx
        On Error Resume Next


        Select Case V_NOME_TAB_FECHADA


            Case v_nome_generico_da_tab & 1
                painel_do_motor_1.Controls.Remove(OBJ_MOTOR_GECKOFX_1)
                OBJ_MOTOR_GECKOFX_1.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 2
                painel_do_motor_2.Controls.Remove(OBJ_MOTOR_GECKOFX_2)
                OBJ_MOTOR_GECKOFX_2.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 3
                painel_do_motor_3.Controls.Remove(OBJ_MOTOR_GECKOFX_3)
                OBJ_MOTOR_GECKOFX_3.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 4
                painel_do_motor_4.Controls.Remove(OBJ_MOTOR_GECKOFX_4)
                OBJ_MOTOR_GECKOFX_4.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 5
                painel_do_motor_5.Controls.Remove(OBJ_MOTOR_GECKOFX_5)
                OBJ_MOTOR_GECKOFX_5.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 6
                painel_do_motor_6.Controls.Remove(OBJ_MOTOR_GECKOFX_6)
                OBJ_MOTOR_GECKOFX_6.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 7
                painel_do_motor_7.Controls.Remove(OBJ_MOTOR_GECKOFX_7)
                OBJ_MOTOR_GECKOFX_7.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 8
                painel_do_motor_8.Controls.Remove(OBJ_MOTOR_GECKOFX_8)
                OBJ_MOTOR_GECKOFX_8.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 9
                painel_do_motor_9.Controls.Remove(OBJ_MOTOR_GECKOFX_9)
                OBJ_MOTOR_GECKOFX_9.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 10
                painel_do_motor_10.Controls.Remove(OBJ_MOTOR_GECKOFX_10)
                OBJ_MOTOR_GECKOFX_10.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 11
                painel_do_motor_11.Controls.Remove(OBJ_MOTOR_GECKOFX_11)
                OBJ_MOTOR_GECKOFX_11.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 12
                painel_do_motor_12.Controls.Remove(OBJ_MOTOR_GECKOFX_12)
                OBJ_MOTOR_GECKOFX_12.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 13
                painel_do_motor_13.Controls.Remove(OBJ_MOTOR_GECKOFX_13)
                OBJ_MOTOR_GECKOFX_13.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 14
                painel_do_motor_14.Controls.Remove(OBJ_MOTOR_GECKOFX_14)
                OBJ_MOTOR_GECKOFX_14.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 15
                painel_do_motor_15.Controls.Remove(OBJ_MOTOR_GECKOFX_15)
                OBJ_MOTOR_GECKOFX_15.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 16
                painel_do_motor_16.Controls.Remove(OBJ_MOTOR_GECKOFX_16)
                OBJ_MOTOR_GECKOFX_16.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 17
                painel_do_motor_17.Controls.Remove(OBJ_MOTOR_GECKOFX_17)
                OBJ_MOTOR_GECKOFX_17.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 18
                painel_do_motor_18.Controls.Remove(OBJ_MOTOR_GECKOFX_18)
                OBJ_MOTOR_GECKOFX_18.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 19
                painel_do_motor_19.Controls.Remove(OBJ_MOTOR_GECKOFX_19)
                OBJ_MOTOR_GECKOFX_19.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 20
                painel_do_motor_20.Controls.Remove(OBJ_MOTOR_GECKOFX_20)
                OBJ_MOTOR_GECKOFX_20.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 21
                painel_do_motor_21.Controls.Remove(OBJ_MOTOR_GECKOFX_21)
                OBJ_MOTOR_GECKOFX_21.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 22
                painel_do_motor_22.Controls.Remove(OBJ_MOTOR_GECKOFX_22)
                OBJ_MOTOR_GECKOFX_22.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 23
                painel_do_motor_23.Controls.Remove(OBJ_MOTOR_GECKOFX_23)
                OBJ_MOTOR_GECKOFX_23.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 24
                painel_do_motor_24.Controls.Remove(OBJ_MOTOR_GECKOFX_24)
                OBJ_MOTOR_GECKOFX_24.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 25
                painel_do_motor_25.Controls.Remove(OBJ_MOTOR_GECKOFX_25)
                OBJ_MOTOR_GECKOFX_25.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 26
                painel_do_motor_26.Controls.Remove(OBJ_MOTOR_GECKOFX_26)
                OBJ_MOTOR_GECKOFX_26.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 27
                painel_do_motor_27.Controls.Remove(OBJ_MOTOR_GECKOFX_27)
                OBJ_MOTOR_GECKOFX_27.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 28
                painel_do_motor_28.Controls.Remove(OBJ_MOTOR_GECKOFX_28)
                OBJ_MOTOR_GECKOFX_28.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 29
                painel_do_motor_29.Controls.Remove(OBJ_MOTOR_GECKOFX_29)
                OBJ_MOTOR_GECKOFX_29.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 30
                painel_do_motor_30.Controls.Remove(OBJ_MOTOR_GECKOFX_30)
                OBJ_MOTOR_GECKOFX_30.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 31
                painel_do_motor_31.Controls.Remove(OBJ_MOTOR_GECKOFX_31)
                OBJ_MOTOR_GECKOFX_31.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 32
                painel_do_motor_32.Controls.Remove(OBJ_MOTOR_GECKOFX_32)
                OBJ_MOTOR_GECKOFX_32.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 33
                painel_do_motor_33.Controls.Remove(OBJ_MOTOR_GECKOFX_33)
                OBJ_MOTOR_GECKOFX_33.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 34
                painel_do_motor_34.Controls.Remove(OBJ_MOTOR_GECKOFX_34)
                OBJ_MOTOR_GECKOFX_34.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 35
                painel_do_motor_35.Controls.Remove(OBJ_MOTOR_GECKOFX_35)
                OBJ_MOTOR_GECKOFX_35.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 36
                painel_do_motor_36.Controls.Remove(OBJ_MOTOR_GECKOFX_36)
                OBJ_MOTOR_GECKOFX_36.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 37
                painel_do_motor_37.Controls.Remove(OBJ_MOTOR_GECKOFX_37)
                OBJ_MOTOR_GECKOFX_37.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 38
                painel_do_motor_38.Controls.Remove(OBJ_MOTOR_GECKOFX_38)
                OBJ_MOTOR_GECKOFX_38.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 39
                painel_do_motor_39.Controls.Remove(OBJ_MOTOR_GECKOFX_39)
                OBJ_MOTOR_GECKOFX_39.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 40
                painel_do_motor_40.Controls.Remove(OBJ_MOTOR_GECKOFX_40)
                OBJ_MOTOR_GECKOFX_40.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 41
                painel_do_motor_41.Controls.Remove(OBJ_MOTOR_GECKOFX_41)
                OBJ_MOTOR_GECKOFX_41.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 42
                painel_do_motor_42.Controls.Remove(OBJ_MOTOR_GECKOFX_42)
                OBJ_MOTOR_GECKOFX_42.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 43
                painel_do_motor_43.Controls.Remove(OBJ_MOTOR_GECKOFX_43)
                OBJ_MOTOR_GECKOFX_43.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 44
                painel_do_motor_44.Controls.Remove(OBJ_MOTOR_GECKOFX_44)
                OBJ_MOTOR_GECKOFX_44.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 45
                painel_do_motor_45.Controls.Remove(OBJ_MOTOR_GECKOFX_45)
                OBJ_MOTOR_GECKOFX_45.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 46
                painel_do_motor_46.Controls.Remove(OBJ_MOTOR_GECKOFX_46)
                OBJ_MOTOR_GECKOFX_46.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 47
                painel_do_motor_47.Controls.Remove(OBJ_MOTOR_GECKOFX_47)
                OBJ_MOTOR_GECKOFX_47.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 48
                painel_do_motor_48.Controls.Remove(OBJ_MOTOR_GECKOFX_48)
                OBJ_MOTOR_GECKOFX_48.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 49
                painel_do_motor_49.Controls.Remove(OBJ_MOTOR_GECKOFX_49)
                OBJ_MOTOR_GECKOFX_49.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 50
                painel_do_motor_50.Controls.Remove(OBJ_MOTOR_GECKOFX_50)
                OBJ_MOTOR_GECKOFX_50.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 51
                painel_do_motor_51.Controls.Remove(OBJ_MOTOR_GECKOFX_51)
                OBJ_MOTOR_GECKOFX_51.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 52
                painel_do_motor_52.Controls.Remove(OBJ_MOTOR_GECKOFX_52)
                OBJ_MOTOR_GECKOFX_52.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 53
                painel_do_motor_53.Controls.Remove(OBJ_MOTOR_GECKOFX_53)
                OBJ_MOTOR_GECKOFX_53.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 54
                painel_do_motor_54.Controls.Remove(OBJ_MOTOR_GECKOFX_54)
                OBJ_MOTOR_GECKOFX_54.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 55
                painel_do_motor_55.Controls.Remove(OBJ_MOTOR_GECKOFX_55)
                OBJ_MOTOR_GECKOFX_55.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 56
                painel_do_motor_56.Controls.Remove(OBJ_MOTOR_GECKOFX_56)
                OBJ_MOTOR_GECKOFX_56.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 57
                painel_do_motor_57.Controls.Remove(OBJ_MOTOR_GECKOFX_57)
                OBJ_MOTOR_GECKOFX_57.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 58
                painel_do_motor_58.Controls.Remove(OBJ_MOTOR_GECKOFX_58)
                OBJ_MOTOR_GECKOFX_58.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 59
                painel_do_motor_59.Controls.Remove(OBJ_MOTOR_GECKOFX_59)
                OBJ_MOTOR_GECKOFX_59.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 60
                painel_do_motor_60.Controls.Remove(OBJ_MOTOR_GECKOFX_60)
                OBJ_MOTOR_GECKOFX_60.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 61
                painel_do_motor_61.Controls.Remove(OBJ_MOTOR_GECKOFX_61)
                OBJ_MOTOR_GECKOFX_61.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 62
                painel_do_motor_62.Controls.Remove(OBJ_MOTOR_GECKOFX_62)
                OBJ_MOTOR_GECKOFX_62.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 63
                painel_do_motor_63.Controls.Remove(OBJ_MOTOR_GECKOFX_63)
                OBJ_MOTOR_GECKOFX_63.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 64
                painel_do_motor_64.Controls.Remove(OBJ_MOTOR_GECKOFX_64)
                OBJ_MOTOR_GECKOFX_64.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 65
                painel_do_motor_65.Controls.Remove(OBJ_MOTOR_GECKOFX_65)
                OBJ_MOTOR_GECKOFX_65.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 66
                painel_do_motor_66.Controls.Remove(OBJ_MOTOR_GECKOFX_66)
                OBJ_MOTOR_GECKOFX_66.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 67
                painel_do_motor_67.Controls.Remove(OBJ_MOTOR_GECKOFX_67)
                OBJ_MOTOR_GECKOFX_67.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 68
                painel_do_motor_68.Controls.Remove(OBJ_MOTOR_GECKOFX_68)
                OBJ_MOTOR_GECKOFX_68.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 69
                painel_do_motor_69.Controls.Remove(OBJ_MOTOR_GECKOFX_69)
                OBJ_MOTOR_GECKOFX_69.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 70
                painel_do_motor_70.Controls.Remove(OBJ_MOTOR_GECKOFX_70)
                OBJ_MOTOR_GECKOFX_70.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 71
                painel_do_motor_71.Controls.Remove(OBJ_MOTOR_GECKOFX_71)
                OBJ_MOTOR_GECKOFX_71.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 72
                painel_do_motor_72.Controls.Remove(OBJ_MOTOR_GECKOFX_72)
                OBJ_MOTOR_GECKOFX_72.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 73
                painel_do_motor_73.Controls.Remove(OBJ_MOTOR_GECKOFX_73)
                OBJ_MOTOR_GECKOFX_73.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 74
                painel_do_motor_74.Controls.Remove(OBJ_MOTOR_GECKOFX_74)
                OBJ_MOTOR_GECKOFX_74.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 75
                painel_do_motor_75.Controls.Remove(OBJ_MOTOR_GECKOFX_75)
                OBJ_MOTOR_GECKOFX_75.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 76
                painel_do_motor_76.Controls.Remove(OBJ_MOTOR_GECKOFX_76)
                OBJ_MOTOR_GECKOFX_76.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 77
                painel_do_motor_77.Controls.Remove(OBJ_MOTOR_GECKOFX_77)
                OBJ_MOTOR_GECKOFX_77.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 78
                painel_do_motor_78.Controls.Remove(OBJ_MOTOR_GECKOFX_78)
                OBJ_MOTOR_GECKOFX_78.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 79
                painel_do_motor_79.Controls.Remove(OBJ_MOTOR_GECKOFX_79)
                OBJ_MOTOR_GECKOFX_79.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 80
                painel_do_motor_80.Controls.Remove(OBJ_MOTOR_GECKOFX_80)
                OBJ_MOTOR_GECKOFX_80.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 81
                painel_do_motor_81.Controls.Remove(OBJ_MOTOR_GECKOFX_81)
                OBJ_MOTOR_GECKOFX_81.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 82
                painel_do_motor_82.Controls.Remove(OBJ_MOTOR_GECKOFX_82)
                OBJ_MOTOR_GECKOFX_82.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 83
                painel_do_motor_83.Controls.Remove(OBJ_MOTOR_GECKOFX_83)
                OBJ_MOTOR_GECKOFX_83.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 84
                painel_do_motor_84.Controls.Remove(OBJ_MOTOR_GECKOFX_84)
                OBJ_MOTOR_GECKOFX_84.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 85
                painel_do_motor_85.Controls.Remove(OBJ_MOTOR_GECKOFX_85)
                OBJ_MOTOR_GECKOFX_85.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 86
                painel_do_motor_86.Controls.Remove(OBJ_MOTOR_GECKOFX_86)
                OBJ_MOTOR_GECKOFX_86.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 87
                painel_do_motor_87.Controls.Remove(OBJ_MOTOR_GECKOFX_87)
                OBJ_MOTOR_GECKOFX_87.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 88
                painel_do_motor_88.Controls.Remove(OBJ_MOTOR_GECKOFX_88)
                OBJ_MOTOR_GECKOFX_88.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 89
                painel_do_motor_89.Controls.Remove(OBJ_MOTOR_GECKOFX_89)
                OBJ_MOTOR_GECKOFX_89.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 90
                painel_do_motor_90.Controls.Remove(OBJ_MOTOR_GECKOFX_90)
                OBJ_MOTOR_GECKOFX_90.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 91
                painel_do_motor_91.Controls.Remove(OBJ_MOTOR_GECKOFX_91)
                OBJ_MOTOR_GECKOFX_91.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 92
                painel_do_motor_92.Controls.Remove(OBJ_MOTOR_GECKOFX_92)
                OBJ_MOTOR_GECKOFX_92.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 93
                painel_do_motor_93.Controls.Remove(OBJ_MOTOR_GECKOFX_93)
                OBJ_MOTOR_GECKOFX_93.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 94
                painel_do_motor_94.Controls.Remove(OBJ_MOTOR_GECKOFX_94)
                OBJ_MOTOR_GECKOFX_94.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 95
                painel_do_motor_95.Controls.Remove(OBJ_MOTOR_GECKOFX_95)
                OBJ_MOTOR_GECKOFX_95.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 96
                painel_do_motor_96.Controls.Remove(OBJ_MOTOR_GECKOFX_96)
                OBJ_MOTOR_GECKOFX_96.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 97
                painel_do_motor_97.Controls.Remove(OBJ_MOTOR_GECKOFX_97)
                OBJ_MOTOR_GECKOFX_97.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 98
                painel_do_motor_98.Controls.Remove(OBJ_MOTOR_GECKOFX_98)
                OBJ_MOTOR_GECKOFX_98.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 99
                painel_do_motor_99.Controls.Remove(OBJ_MOTOR_GECKOFX_99)
                OBJ_MOTOR_GECKOFX_99.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 100
                painel_do_motor_100.Controls.Remove(OBJ_MOTOR_GECKOFX_100)
                OBJ_MOTOR_GECKOFX_100.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 101
                painel_do_motor_101.Controls.Remove(OBJ_MOTOR_GECKOFX_101)
                OBJ_MOTOR_GECKOFX_101.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 102
                painel_do_motor_102.Controls.Remove(OBJ_MOTOR_GECKOFX_102)
                OBJ_MOTOR_GECKOFX_102.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 103
                painel_do_motor_103.Controls.Remove(OBJ_MOTOR_GECKOFX_103)
                OBJ_MOTOR_GECKOFX_103.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 104
                painel_do_motor_104.Controls.Remove(OBJ_MOTOR_GECKOFX_104)
                OBJ_MOTOR_GECKOFX_104.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 105
                painel_do_motor_105.Controls.Remove(OBJ_MOTOR_GECKOFX_105)
                OBJ_MOTOR_GECKOFX_105.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 106
                painel_do_motor_106.Controls.Remove(OBJ_MOTOR_GECKOFX_106)
                OBJ_MOTOR_GECKOFX_106.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 107
                painel_do_motor_107.Controls.Remove(OBJ_MOTOR_GECKOFX_107)
                OBJ_MOTOR_GECKOFX_107.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 108
                painel_do_motor_108.Controls.Remove(OBJ_MOTOR_GECKOFX_108)
                OBJ_MOTOR_GECKOFX_108.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 109
                painel_do_motor_109.Controls.Remove(OBJ_MOTOR_GECKOFX_109)
                OBJ_MOTOR_GECKOFX_109.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 110
                painel_do_motor_110.Controls.Remove(OBJ_MOTOR_GECKOFX_110)
                OBJ_MOTOR_GECKOFX_110.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 111
                painel_do_motor_111.Controls.Remove(OBJ_MOTOR_GECKOFX_111)
                OBJ_MOTOR_GECKOFX_111.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 112
                painel_do_motor_112.Controls.Remove(OBJ_MOTOR_GECKOFX_112)
                OBJ_MOTOR_GECKOFX_112.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 113
                painel_do_motor_113.Controls.Remove(OBJ_MOTOR_GECKOFX_113)
                OBJ_MOTOR_GECKOFX_113.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 114
                painel_do_motor_114.Controls.Remove(OBJ_MOTOR_GECKOFX_114)
                OBJ_MOTOR_GECKOFX_114.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 115
                painel_do_motor_115.Controls.Remove(OBJ_MOTOR_GECKOFX_115)
                OBJ_MOTOR_GECKOFX_115.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 116
                painel_do_motor_116.Controls.Remove(OBJ_MOTOR_GECKOFX_116)
                OBJ_MOTOR_GECKOFX_116.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 117
                painel_do_motor_117.Controls.Remove(OBJ_MOTOR_GECKOFX_117)
                OBJ_MOTOR_GECKOFX_117.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 118
                painel_do_motor_118.Controls.Remove(OBJ_MOTOR_GECKOFX_118)
                OBJ_MOTOR_GECKOFX_118.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 119
                painel_do_motor_119.Controls.Remove(OBJ_MOTOR_GECKOFX_119)
                OBJ_MOTOR_GECKOFX_119.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 120
                painel_do_motor_120.Controls.Remove(OBJ_MOTOR_GECKOFX_120)
                OBJ_MOTOR_GECKOFX_120.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 121
                painel_do_motor_121.Controls.Remove(OBJ_MOTOR_GECKOFX_121)
                OBJ_MOTOR_GECKOFX_121.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 122
                painel_do_motor_122.Controls.Remove(OBJ_MOTOR_GECKOFX_122)
                OBJ_MOTOR_GECKOFX_122.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 123
                painel_do_motor_123.Controls.Remove(OBJ_MOTOR_GECKOFX_123)
                OBJ_MOTOR_GECKOFX_123.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 124
                painel_do_motor_124.Controls.Remove(OBJ_MOTOR_GECKOFX_124)
                OBJ_MOTOR_GECKOFX_124.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 125
                painel_do_motor_125.Controls.Remove(OBJ_MOTOR_GECKOFX_125)
                OBJ_MOTOR_GECKOFX_125.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 126
                painel_do_motor_126.Controls.Remove(OBJ_MOTOR_GECKOFX_126)
                OBJ_MOTOR_GECKOFX_126.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 127
                painel_do_motor_127.Controls.Remove(OBJ_MOTOR_GECKOFX_127)
                OBJ_MOTOR_GECKOFX_127.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 128
                painel_do_motor_128.Controls.Remove(OBJ_MOTOR_GECKOFX_128)
                OBJ_MOTOR_GECKOFX_128.Navigate("about:blank")
                Exit Select
            



        End Select


    End Sub

    Public Sub proc_para_execucao_de_motor_trident(ByVal V_NOME_TAB_FECHADA As String) 'Fecha o motor trident
        On Error Resume Next


        Select Case V_NOME_TAB_FECHADA


            Case v_nome_generico_da_tab & 1
                painel_do_motor_1.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_1)
                OBJ_MOTOR_WEB_BROWSER_1.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 2
                painel_do_motor_2.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_2)
                OBJ_MOTOR_WEB_BROWSER_2.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 3
                painel_do_motor_3.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_3)
                OBJ_MOTOR_WEB_BROWSER_3.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 4
                painel_do_motor_4.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_4)
                OBJ_MOTOR_WEB_BROWSER_4.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 5
                painel_do_motor_5.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_5)
                OBJ_MOTOR_WEB_BROWSER_5.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 6
                painel_do_motor_6.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_6)
                OBJ_MOTOR_WEB_BROWSER_6.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 7
                painel_do_motor_7.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_7)
                OBJ_MOTOR_WEB_BROWSER_7.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 8
                painel_do_motor_8.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_8)
                OBJ_MOTOR_WEB_BROWSER_8.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 9
                painel_do_motor_9.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_9)
                OBJ_MOTOR_WEB_BROWSER_9.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 10
                painel_do_motor_10.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_10)
                OBJ_MOTOR_WEB_BROWSER_10.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 11
                painel_do_motor_11.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_11)
                OBJ_MOTOR_WEB_BROWSER_11.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 12
                painel_do_motor_12.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_12)
                OBJ_MOTOR_WEB_BROWSER_12.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 13
                painel_do_motor_13.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_13)
                OBJ_MOTOR_WEB_BROWSER_13.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 14
                painel_do_motor_14.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_14)
                OBJ_MOTOR_WEB_BROWSER_14.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 15
                painel_do_motor_15.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_15)
                OBJ_MOTOR_WEB_BROWSER_15.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 16
                painel_do_motor_16.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_16)
                OBJ_MOTOR_WEB_BROWSER_16.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 17
                painel_do_motor_17.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_17)
                OBJ_MOTOR_WEB_BROWSER_17.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 18
                painel_do_motor_18.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_18)
                OBJ_MOTOR_WEB_BROWSER_18.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 19
                painel_do_motor_19.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_19)
                OBJ_MOTOR_WEB_BROWSER_19.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 20
                painel_do_motor_20.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_20)
                OBJ_MOTOR_WEB_BROWSER_20.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 21
                painel_do_motor_21.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_21)
                OBJ_MOTOR_WEB_BROWSER_21.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 22
                painel_do_motor_22.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_22)
                OBJ_MOTOR_WEB_BROWSER_22.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 23
                painel_do_motor_23.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_23)
                OBJ_MOTOR_WEB_BROWSER_23.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 24
                painel_do_motor_24.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_24)
                OBJ_MOTOR_WEB_BROWSER_24.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 25
                painel_do_motor_25.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_25)
                OBJ_MOTOR_WEB_BROWSER_25.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 26
                painel_do_motor_26.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_26)
                OBJ_MOTOR_WEB_BROWSER_26.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 27
                painel_do_motor_27.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_27)
                OBJ_MOTOR_WEB_BROWSER_27.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 28
                painel_do_motor_28.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_28)
                OBJ_MOTOR_WEB_BROWSER_28.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 29
                painel_do_motor_29.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_29)
                OBJ_MOTOR_WEB_BROWSER_29.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 30
                painel_do_motor_30.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_30)
                OBJ_MOTOR_WEB_BROWSER_30.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 31
                painel_do_motor_31.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_31)
                OBJ_MOTOR_WEB_BROWSER_31.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 32
                painel_do_motor_32.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_32)
                OBJ_MOTOR_WEB_BROWSER_32.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 33
                painel_do_motor_33.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_33)
                OBJ_MOTOR_WEB_BROWSER_33.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 34
                painel_do_motor_34.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_34)
                OBJ_MOTOR_WEB_BROWSER_34.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 35
                painel_do_motor_35.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_35)
                OBJ_MOTOR_WEB_BROWSER_35.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 36
                painel_do_motor_36.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_36)
                OBJ_MOTOR_WEB_BROWSER_36.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 37
                painel_do_motor_37.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_37)
                OBJ_MOTOR_WEB_BROWSER_37.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 38
                painel_do_motor_38.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_38)
                OBJ_MOTOR_WEB_BROWSER_38.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 39
                painel_do_motor_39.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_39)
                OBJ_MOTOR_WEB_BROWSER_39.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 40
                painel_do_motor_40.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_40)
                OBJ_MOTOR_WEB_BROWSER_40.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 41
                painel_do_motor_41.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_41)
                OBJ_MOTOR_WEB_BROWSER_41.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 42
                painel_do_motor_42.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_42)
                OBJ_MOTOR_WEB_BROWSER_42.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 43
                painel_do_motor_43.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_43)
                OBJ_MOTOR_WEB_BROWSER_43.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 44
                painel_do_motor_44.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_44)
                OBJ_MOTOR_WEB_BROWSER_44.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 45
                painel_do_motor_45.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_45)
                OBJ_MOTOR_WEB_BROWSER_45.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 46
                painel_do_motor_46.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_46)
                OBJ_MOTOR_WEB_BROWSER_46.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 47
                painel_do_motor_47.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_47)
                OBJ_MOTOR_WEB_BROWSER_47.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 48
                painel_do_motor_48.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_48)
                OBJ_MOTOR_WEB_BROWSER_48.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 49
                painel_do_motor_49.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_49)
                OBJ_MOTOR_WEB_BROWSER_49.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 50
                painel_do_motor_50.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_50)
                OBJ_MOTOR_WEB_BROWSER_50.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 51
                painel_do_motor_51.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_51)
                OBJ_MOTOR_WEB_BROWSER_51.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 52
                painel_do_motor_52.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_52)
                OBJ_MOTOR_WEB_BROWSER_52.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 53
                painel_do_motor_53.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_53)
                OBJ_MOTOR_WEB_BROWSER_53.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 54
                painel_do_motor_54.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_54)
                OBJ_MOTOR_WEB_BROWSER_54.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 55
                painel_do_motor_55.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_55)
                OBJ_MOTOR_WEB_BROWSER_55.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 56
                painel_do_motor_56.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_56)
                OBJ_MOTOR_WEB_BROWSER_56.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 57
                painel_do_motor_57.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_57)
                OBJ_MOTOR_WEB_BROWSER_57.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 58
                painel_do_motor_58.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_58)
                OBJ_MOTOR_WEB_BROWSER_58.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 59
                painel_do_motor_59.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_59)
                OBJ_MOTOR_WEB_BROWSER_59.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 60
                painel_do_motor_60.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_60)
                OBJ_MOTOR_WEB_BROWSER_60.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 61
                painel_do_motor_61.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_61)
                OBJ_MOTOR_WEB_BROWSER_61.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 62
                painel_do_motor_62.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_62)
                OBJ_MOTOR_WEB_BROWSER_62.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 63
                painel_do_motor_63.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_63)
                OBJ_MOTOR_WEB_BROWSER_63.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 64
                painel_do_motor_64.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_64)
                OBJ_MOTOR_WEB_BROWSER_64.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 65
                painel_do_motor_65.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_65)
                OBJ_MOTOR_WEB_BROWSER_65.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 66
                painel_do_motor_66.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_66)
                OBJ_MOTOR_WEB_BROWSER_66.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 67
                painel_do_motor_67.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_67)
                OBJ_MOTOR_WEB_BROWSER_67.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 68
                painel_do_motor_68.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_68)
                OBJ_MOTOR_WEB_BROWSER_68.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 69
                painel_do_motor_69.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_69)
                OBJ_MOTOR_WEB_BROWSER_69.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 70
                painel_do_motor_70.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_70)
                OBJ_MOTOR_WEB_BROWSER_70.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 71
                painel_do_motor_71.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_71)
                OBJ_MOTOR_WEB_BROWSER_71.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 72
                painel_do_motor_72.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_72)
                OBJ_MOTOR_WEB_BROWSER_72.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 73
                painel_do_motor_73.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_73)
                OBJ_MOTOR_WEB_BROWSER_73.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 74
                painel_do_motor_74.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_74)
                OBJ_MOTOR_WEB_BROWSER_74.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 75
                painel_do_motor_75.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_75)
                OBJ_MOTOR_WEB_BROWSER_75.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 76
                painel_do_motor_76.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_76)
                OBJ_MOTOR_WEB_BROWSER_76.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 77
                painel_do_motor_77.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_77)
                OBJ_MOTOR_WEB_BROWSER_77.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 78
                painel_do_motor_78.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_78)
                OBJ_MOTOR_WEB_BROWSER_78.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 79
                painel_do_motor_79.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_79)
                OBJ_MOTOR_WEB_BROWSER_79.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 80
                painel_do_motor_80.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_80)
                OBJ_MOTOR_WEB_BROWSER_80.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 81
                painel_do_motor_81.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_81)
                OBJ_MOTOR_WEB_BROWSER_81.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 82
                painel_do_motor_82.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_82)
                OBJ_MOTOR_WEB_BROWSER_82.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 83
                painel_do_motor_83.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_83)
                OBJ_MOTOR_WEB_BROWSER_83.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 84
                painel_do_motor_84.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_84)
                OBJ_MOTOR_WEB_BROWSER_84.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 85
                painel_do_motor_85.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_85)
                OBJ_MOTOR_WEB_BROWSER_85.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 86
                painel_do_motor_86.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_86)
                OBJ_MOTOR_WEB_BROWSER_86.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 87
                painel_do_motor_87.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_87)
                OBJ_MOTOR_WEB_BROWSER_87.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 88
                painel_do_motor_88.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_88)
                OBJ_MOTOR_WEB_BROWSER_88.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 89
                painel_do_motor_89.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_89)
                OBJ_MOTOR_WEB_BROWSER_89.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 90
                painel_do_motor_90.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_90)
                OBJ_MOTOR_WEB_BROWSER_90.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 91
                painel_do_motor_91.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_91)
                OBJ_MOTOR_WEB_BROWSER_91.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 92
                painel_do_motor_92.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_92)
                OBJ_MOTOR_WEB_BROWSER_92.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 93
                painel_do_motor_93.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_93)
                OBJ_MOTOR_WEB_BROWSER_93.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 94
                painel_do_motor_94.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_94)
                OBJ_MOTOR_WEB_BROWSER_94.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 95
                painel_do_motor_95.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_95)
                OBJ_MOTOR_WEB_BROWSER_95.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 96
                painel_do_motor_96.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_96)
                OBJ_MOTOR_WEB_BROWSER_96.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 97
                painel_do_motor_97.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_97)
                OBJ_MOTOR_WEB_BROWSER_97.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 98
                painel_do_motor_98.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_98)
                OBJ_MOTOR_WEB_BROWSER_98.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 99
                painel_do_motor_99.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_99)
                OBJ_MOTOR_WEB_BROWSER_99.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 100
                painel_do_motor_100.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_100)
                OBJ_MOTOR_WEB_BROWSER_100.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 101
                painel_do_motor_101.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_101)
                OBJ_MOTOR_WEB_BROWSER_101.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 102
                painel_do_motor_102.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_102)
                OBJ_MOTOR_WEB_BROWSER_102.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 103
                painel_do_motor_103.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_103)
                OBJ_MOTOR_WEB_BROWSER_103.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 104
                painel_do_motor_104.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_104)
                OBJ_MOTOR_WEB_BROWSER_104.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 105
                painel_do_motor_105.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_105)
                OBJ_MOTOR_WEB_BROWSER_105.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 106
                painel_do_motor_106.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_106)
                OBJ_MOTOR_WEB_BROWSER_106.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 107
                painel_do_motor_107.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_107)
                OBJ_MOTOR_WEB_BROWSER_107.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 108
                painel_do_motor_108.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_108)
                OBJ_MOTOR_WEB_BROWSER_108.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 109
                painel_do_motor_109.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_109)
                OBJ_MOTOR_WEB_BROWSER_109.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 110
                painel_do_motor_110.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_110)
                OBJ_MOTOR_WEB_BROWSER_110.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 111
                painel_do_motor_111.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_111)
                OBJ_MOTOR_WEB_BROWSER_111.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 112
                painel_do_motor_112.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_112)
                OBJ_MOTOR_WEB_BROWSER_112.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 113
                painel_do_motor_113.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_113)
                OBJ_MOTOR_WEB_BROWSER_113.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 114
                painel_do_motor_114.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_114)
                OBJ_MOTOR_WEB_BROWSER_114.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 115
                painel_do_motor_115.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_115)
                OBJ_MOTOR_WEB_BROWSER_115.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 116
                painel_do_motor_116.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_116)
                OBJ_MOTOR_WEB_BROWSER_116.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 117
                painel_do_motor_117.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_117)
                OBJ_MOTOR_WEB_BROWSER_117.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 118
                painel_do_motor_118.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_118)
                OBJ_MOTOR_WEB_BROWSER_118.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 119
                painel_do_motor_119.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_119)
                OBJ_MOTOR_WEB_BROWSER_119.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 120
                painel_do_motor_120.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_120)
                OBJ_MOTOR_WEB_BROWSER_120.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 121
                painel_do_motor_121.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_121)
                OBJ_MOTOR_WEB_BROWSER_121.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 122
                painel_do_motor_122.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_122)
                OBJ_MOTOR_WEB_BROWSER_122.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 123
                painel_do_motor_123.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_123)
                OBJ_MOTOR_WEB_BROWSER_123.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 124
                painel_do_motor_124.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_124)
                OBJ_MOTOR_WEB_BROWSER_124.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 125
                painel_do_motor_125.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_125)
                OBJ_MOTOR_WEB_BROWSER_125.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 126
                painel_do_motor_126.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_126)
                OBJ_MOTOR_WEB_BROWSER_126.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 127
                painel_do_motor_127.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_127)
                OBJ_MOTOR_WEB_BROWSER_127.Navigate("about:blank")
                Exit Select
            Case v_nome_generico_da_tab & 128
                painel_do_motor_128.Controls.Remove(OBJ_MOTOR_WEB_BROWSER_128)
                OBJ_MOTOR_WEB_BROWSER_128.Navigate("about:blank")
                Exit Select
            



        End Select


    End Sub

    Public Sub proc_remove_referencia_aba_barra_de_status(ByVal V_NOME_TAB_FECHADA As String) 'Toda vez que uma tab for fechada atualizar a referencia da aba na barra de status
        On Error Resume Next


        Select Case V_NOME_TAB_FECHADA


            Case v_nome_generico_da_tab & 1
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_1) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 2
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_2) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 3
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_3) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 4
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_4) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 5
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_5) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 6
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_6) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 7
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_7) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 8
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_8) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 9
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_9) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 10
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_10) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 11
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_11) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 12
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_12) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 13
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_13) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 14
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_14) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 15
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_15) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 16
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_16) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 17
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_17) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 18
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_18) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 19
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_19) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 20
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_20) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 21
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_21) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 22
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_22) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 23
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_23) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 24
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_24) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 25
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_25) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 26
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_26) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 27
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_27) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 28
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_28) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 29
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_29) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 30
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_30) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 31
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_31) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 32
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_32) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 33
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_33) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 34
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_34) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 35
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_35) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 36
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_36) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 37
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_37) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 38
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_38) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 39
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_39) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 40
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_40) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 41
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_41) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 42
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_42) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 43
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_43) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 44
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_44) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 45
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_45) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 46
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_46) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 47
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_47) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 48
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_48) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 49
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_49) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 50
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_50) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 51
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_51) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 52
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_52) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 53
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_53) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 54
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_54) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 55
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_55) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 56
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_56) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 57
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_57) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 58
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_58) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 59
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_59) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 60
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_60) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 61
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_61) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 62
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_62) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 63
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_63) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 64
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_64) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 65
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_65) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 66
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_66) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 67
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_67) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 68
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_68) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 69
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_69) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 70
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_70) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 71
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_71) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 72
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_72) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 73
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_73) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 74
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_74) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 75
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_75) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 76
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_76) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 77
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_77) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 78
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_78) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 79
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_79) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 80
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_80) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 81
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_81) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 82
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_82) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 83
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_83) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 84
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_84) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 85
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_85) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 86
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_86) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 87
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_87) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 88
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_88) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 89
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_89) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 90
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_90) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 91
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_91) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 92
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_92) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 93
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_93) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 94
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_94) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 95
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_95) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 96
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_96) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 97
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_97) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 98
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_98) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 99
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_99) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 100
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_100) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 101
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_101) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 102
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_102) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 103
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_103) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 104
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_104) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 105
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_105) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 106
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_106) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 107
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_107) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 108
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_108) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 109
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_109) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 110
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_110) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 111
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_111) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 112
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_112) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 113
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_113) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 114
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_114) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 115
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_115) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 116
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_116) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 117
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_117) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 118
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_118) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 119
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_119) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 120
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_120) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 121
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_121) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 122
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_122) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 123
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_123) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 124
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_124) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 125
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_125) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 126
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_126) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 127
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_127) 'Removendo referencia
                Exit Select
            Case v_nome_generico_da_tab & 128
                FRM_NAVEGACAO.drop_lista_de_abas.DropDownItems.Remove(Tool_aba_referencia_128) 'Removendo referencia
                Exit Select
            


        End Select


    End Sub







    'Escolhe qual tipo de motor fechar

    Public Sub proc_fechar_motor_geckofx_ou_trident(ByVal V_NOME_TAB_FECHADA As String) 'Escolhe qual motor fechar
        On Error Resume Next

        Dim v_fechada As Integer 'Informa a aba fechada






        'Informando qual aba foi fechada ----------------------------------------------------------------------------

        Select Case V_NOME_TAB_FECHADA


            Case v_nome_generico_da_tab & 1
                v_fechada = 1
                Exit Select
            Case v_nome_generico_da_tab & 2
                v_fechada = 2
                Exit Select
            Case v_nome_generico_da_tab & 3
                v_fechada = 3
                Exit Select
            Case v_nome_generico_da_tab & 4
                v_fechada = 4
                Exit Select
            Case v_nome_generico_da_tab & 5
                v_fechada = 5
                Exit Select
            Case v_nome_generico_da_tab & 6
                v_fechada = 6
                Exit Select
            Case v_nome_generico_da_tab & 7
                v_fechada = 7
                Exit Select
            Case v_nome_generico_da_tab & 8
                v_fechada = 8
                Exit Select
            Case v_nome_generico_da_tab & 9
                v_fechada = 9
                Exit Select
            Case v_nome_generico_da_tab & 10
                v_fechada = 10
                Exit Select
            Case v_nome_generico_da_tab & 11
                v_fechada = 11
                Exit Select
            Case v_nome_generico_da_tab & 12
                v_fechada = 12
                Exit Select
            Case v_nome_generico_da_tab & 13
                v_fechada = 13
                Exit Select
            Case v_nome_generico_da_tab & 14
                v_fechada = 14
                Exit Select
            Case v_nome_generico_da_tab & 15
                v_fechada = 15
                Exit Select
            Case v_nome_generico_da_tab & 16
                v_fechada = 16
                Exit Select
            Case v_nome_generico_da_tab & 17
                v_fechada = 17
                Exit Select
            Case v_nome_generico_da_tab & 18
                v_fechada = 18
                Exit Select
            Case v_nome_generico_da_tab & 19
                v_fechada = 19
                Exit Select
            Case v_nome_generico_da_tab & 20
                v_fechada = 20
                Exit Select
            Case v_nome_generico_da_tab & 21
                v_fechada = 21
                Exit Select
            Case v_nome_generico_da_tab & 22
                v_fechada = 22
                Exit Select
            Case v_nome_generico_da_tab & 23
                v_fechada = 23
                Exit Select
            Case v_nome_generico_da_tab & 24
                v_fechada = 24
                Exit Select
            Case v_nome_generico_da_tab & 25
                v_fechada = 25
                Exit Select
            Case v_nome_generico_da_tab & 26
                v_fechada = 26
                Exit Select
            Case v_nome_generico_da_tab & 27
                v_fechada = 27
                Exit Select
            Case v_nome_generico_da_tab & 28
                v_fechada = 28
                Exit Select
            Case v_nome_generico_da_tab & 29
                v_fechada = 29
                Exit Select
            Case v_nome_generico_da_tab & 30
                v_fechada = 30
                Exit Select
            Case v_nome_generico_da_tab & 31
                v_fechada = 31
                Exit Select
            Case v_nome_generico_da_tab & 32
                v_fechada = 32
                Exit Select
            Case v_nome_generico_da_tab & 33
                v_fechada = 33
                Exit Select
            Case v_nome_generico_da_tab & 34
                v_fechada = 34
                Exit Select
            Case v_nome_generico_da_tab & 35
                v_fechada = 35
                Exit Select
            Case v_nome_generico_da_tab & 36
                v_fechada = 36
                Exit Select
            Case v_nome_generico_da_tab & 37
                v_fechada = 37
                Exit Select
            Case v_nome_generico_da_tab & 38
                v_fechada = 38
                Exit Select
            Case v_nome_generico_da_tab & 39
                v_fechada = 39
                Exit Select
            Case v_nome_generico_da_tab & 40
                v_fechada = 40
                Exit Select
            Case v_nome_generico_da_tab & 41
                v_fechada = 41
                Exit Select
            Case v_nome_generico_da_tab & 42
                v_fechada = 42
                Exit Select
            Case v_nome_generico_da_tab & 43
                v_fechada = 43
                Exit Select
            Case v_nome_generico_da_tab & 44
                v_fechada = 44
                Exit Select
            Case v_nome_generico_da_tab & 45
                v_fechada = 45
                Exit Select
            Case v_nome_generico_da_tab & 46
                v_fechada = 46
                Exit Select
            Case v_nome_generico_da_tab & 47
                v_fechada = 47
                Exit Select
            Case v_nome_generico_da_tab & 48
                v_fechada = 48
                Exit Select
            Case v_nome_generico_da_tab & 49
                v_fechada = 49
                Exit Select
            Case v_nome_generico_da_tab & 50
                v_fechada = 50
                Exit Select
            Case v_nome_generico_da_tab & 51
                v_fechada = 51
                Exit Select
            Case v_nome_generico_da_tab & 52
                v_fechada = 52
                Exit Select
            Case v_nome_generico_da_tab & 53
                v_fechada = 53
                Exit Select
            Case v_nome_generico_da_tab & 54
                v_fechada = 54
                Exit Select
            Case v_nome_generico_da_tab & 55
                v_fechada = 55
                Exit Select
            Case v_nome_generico_da_tab & 56
                v_fechada = 56
                Exit Select
            Case v_nome_generico_da_tab & 57
                v_fechada = 57
                Exit Select
            Case v_nome_generico_da_tab & 58
                v_fechada = 58
                Exit Select
            Case v_nome_generico_da_tab & 59
                v_fechada = 59
                Exit Select
            Case v_nome_generico_da_tab & 60
                v_fechada = 60
                Exit Select
            Case v_nome_generico_da_tab & 61
                v_fechada = 61
                Exit Select
            Case v_nome_generico_da_tab & 62
                v_fechada = 62
                Exit Select
            Case v_nome_generico_da_tab & 63
                v_fechada = 63
                Exit Select
            Case v_nome_generico_da_tab & 64
                v_fechada = 64
                Exit Select
            Case v_nome_generico_da_tab & 65
                v_fechada = 65
                Exit Select
            Case v_nome_generico_da_tab & 66
                v_fechada = 66
                Exit Select
            Case v_nome_generico_da_tab & 67
                v_fechada = 67
                Exit Select
            Case v_nome_generico_da_tab & 68
                v_fechada = 68
                Exit Select
            Case v_nome_generico_da_tab & 69
                v_fechada = 69
                Exit Select
            Case v_nome_generico_da_tab & 70
                v_fechada = 70
                Exit Select
            Case v_nome_generico_da_tab & 71
                v_fechada = 71
                Exit Select
            Case v_nome_generico_da_tab & 72
                v_fechada = 72
                Exit Select
            Case v_nome_generico_da_tab & 73
                v_fechada = 73
                Exit Select
            Case v_nome_generico_da_tab & 74
                v_fechada = 74
                Exit Select
            Case v_nome_generico_da_tab & 75
                v_fechada = 75
                Exit Select
            Case v_nome_generico_da_tab & 76
                v_fechada = 76
                Exit Select
            Case v_nome_generico_da_tab & 77
                v_fechada = 77
                Exit Select
            Case v_nome_generico_da_tab & 78
                v_fechada = 78
                Exit Select
            Case v_nome_generico_da_tab & 79
                v_fechada = 79
                Exit Select
            Case v_nome_generico_da_tab & 80
                v_fechada = 80
                Exit Select
            Case v_nome_generico_da_tab & 81
                v_fechada = 81
                Exit Select
            Case v_nome_generico_da_tab & 82
                v_fechada = 82
                Exit Select
            Case v_nome_generico_da_tab & 83
                v_fechada = 83
                Exit Select
            Case v_nome_generico_da_tab & 84
                v_fechada = 84
                Exit Select
            Case v_nome_generico_da_tab & 85
                v_fechada = 85
                Exit Select
            Case v_nome_generico_da_tab & 86
                v_fechada = 86
                Exit Select
            Case v_nome_generico_da_tab & 87
                v_fechada = 87
                Exit Select
            Case v_nome_generico_da_tab & 88
                v_fechada = 88
                Exit Select
            Case v_nome_generico_da_tab & 89
                v_fechada = 89
                Exit Select
            Case v_nome_generico_da_tab & 90
                v_fechada = 90
                Exit Select
            Case v_nome_generico_da_tab & 91
                v_fechada = 91
                Exit Select
            Case v_nome_generico_da_tab & 92
                v_fechada = 92
                Exit Select
            Case v_nome_generico_da_tab & 93
                v_fechada = 93
                Exit Select
            Case v_nome_generico_da_tab & 94
                v_fechada = 94
                Exit Select
            Case v_nome_generico_da_tab & 95
                v_fechada = 95
                Exit Select
            Case v_nome_generico_da_tab & 96
                v_fechada = 96
                Exit Select
            Case v_nome_generico_da_tab & 97
                v_fechada = 97
                Exit Select
            Case v_nome_generico_da_tab & 98
                v_fechada = 98
                Exit Select
            Case v_nome_generico_da_tab & 99
                v_fechada = 99
                Exit Select
            Case v_nome_generico_da_tab & 100
                v_fechada = 100
                Exit Select
            Case v_nome_generico_da_tab & 101
                v_fechada = 101
                Exit Select
            Case v_nome_generico_da_tab & 102
                v_fechada = 102
                Exit Select
            Case v_nome_generico_da_tab & 103
                v_fechada = 103
                Exit Select
            Case v_nome_generico_da_tab & 104
                v_fechada = 104
                Exit Select
            Case v_nome_generico_da_tab & 105
                v_fechada = 105
                Exit Select
            Case v_nome_generico_da_tab & 106
                v_fechada = 106
                Exit Select
            Case v_nome_generico_da_tab & 107
                v_fechada = 107
                Exit Select
            Case v_nome_generico_da_tab & 108
                v_fechada = 108
                Exit Select
            Case v_nome_generico_da_tab & 109
                v_fechada = 109
                Exit Select
            Case v_nome_generico_da_tab & 110
                v_fechada = 110
                Exit Select
            Case v_nome_generico_da_tab & 111
                v_fechada = 111
                Exit Select
            Case v_nome_generico_da_tab & 112
                v_fechada = 112
                Exit Select
            Case v_nome_generico_da_tab & 113
                v_fechada = 113
                Exit Select
            Case v_nome_generico_da_tab & 114
                v_fechada = 114
                Exit Select
            Case v_nome_generico_da_tab & 115
                v_fechada = 115
                Exit Select
            Case v_nome_generico_da_tab & 116
                v_fechada = 116
                Exit Select
            Case v_nome_generico_da_tab & 117
                v_fechada = 117
                Exit Select
            Case v_nome_generico_da_tab & 118
                v_fechada = 118
                Exit Select
            Case v_nome_generico_da_tab & 119
                v_fechada = 119
                Exit Select
            Case v_nome_generico_da_tab & 120
                v_fechada = 120
                Exit Select
            Case v_nome_generico_da_tab & 121
                v_fechada = 121
                Exit Select
            Case v_nome_generico_da_tab & 122
                v_fechada = 122
                Exit Select
            Case v_nome_generico_da_tab & 123
                v_fechada = 123
                Exit Select
            Case v_nome_generico_da_tab & 124
                v_fechada = 124
                Exit Select
            Case v_nome_generico_da_tab & 125
                v_fechada = 125
                Exit Select
            Case v_nome_generico_da_tab & 126
                v_fechada = 126
                Exit Select
            Case v_nome_generico_da_tab & 127
                v_fechada = 127
                Exit Select
            Case v_nome_generico_da_tab & 128
                v_fechada = 128
                Exit Select





        End Select

        '------------------------------------------------------------------------------------------------------------


        'Processando informação ---------------------------------------------------------------

        If (v_tipo_de_motor_adicionado(v_fechada) = True) Then


            proc_para_execucao_de_motor_geckofx(V_NOME_TAB_FECHADA) 'Fecha o motor geckofx


        Else


            proc_para_execucao_de_motor_trident(V_NOME_TAB_FECHADA) 'Fecha o motor trident


        End If

        '--------------------------------------------------------------------------------------



    End Sub








    'Fechar aba via menu

    Public Sub proc_fechar_aba_via_menu() 'Fechar aba via menu
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso



            Case 1
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab1)
                Exit Select

            Case 2
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab2)
                Exit Select

            Case 3
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab3)
                Exit Select

            Case 4
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab4)
                Exit Select

            Case 5
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab5)
                Exit Select

            Case 6
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab6)
                Exit Select

            Case 7
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab7)
                Exit Select

            Case 8
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab8)
                Exit Select

            Case 9
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab9)
                Exit Select

            Case 10
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab10)
                Exit Select

            Case 11
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab11)
                Exit Select

            Case 12
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab12)
                Exit Select

            Case 13
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab13)
                Exit Select

            Case 14
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab14)
                Exit Select

            Case 15
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab15)
                Exit Select

            Case 16
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab16)
                Exit Select

            Case 17
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab17)
                Exit Select

            Case 18
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab18)
                Exit Select

            Case 19
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab19)
                Exit Select

            Case 20
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab20)
                Exit Select

            Case 21
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab21)
                Exit Select

            Case 22
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab22)
                Exit Select

            Case 23
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab23)
                Exit Select

            Case 24
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab24)
                Exit Select

            Case 25
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab25)
                Exit Select

            Case 26
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab26)
                Exit Select

            Case 27
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab27)
                Exit Select

            Case 28
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab28)
                Exit Select

            Case 29
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab29)
                Exit Select

            Case 30
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab30)
                Exit Select

            Case 31
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab31)
                Exit Select

            Case 32
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab32)
                Exit Select

            Case 33
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab33)
                Exit Select

            Case 34
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab34)
                Exit Select

            Case 35
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab35)
                Exit Select

            Case 36
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab36)
                Exit Select

            Case 37
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab37)
                Exit Select

            Case 38
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab38)
                Exit Select

            Case 39
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab39)
                Exit Select

            Case 40
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab40)
                Exit Select

            Case 41
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab41)
                Exit Select

            Case 42
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab42)
                Exit Select

            Case 43
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab43)
                Exit Select

            Case 44
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab44)
                Exit Select

            Case 45
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab45)
                Exit Select

            Case 46
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab46)
                Exit Select

            Case 47
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab47)
                Exit Select

            Case 48
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab48)
                Exit Select

            Case 49
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab49)
                Exit Select

            Case 50
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab50)
                Exit Select

            Case 51
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab51)
                Exit Select

            Case 52
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab52)
                Exit Select

            Case 53
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab53)
                Exit Select

            Case 54
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab54)
                Exit Select

            Case 55
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab55)
                Exit Select

            Case 56
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab56)
                Exit Select

            Case 57
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab57)
                Exit Select

            Case 58
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab58)
                Exit Select

            Case 59
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab59)
                Exit Select

            Case 60
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab60)
                Exit Select

            Case 61
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab61)
                Exit Select

            Case 62
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab62)
                Exit Select

            Case 63
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab63)
                Exit Select

            Case 64
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab64)
                Exit Select

            Case 65
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab65)
                Exit Select

            Case 66
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab66)
                Exit Select

            Case 67
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab67)
                Exit Select

            Case 68
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab68)
                Exit Select

            Case 69
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab69)
                Exit Select

            Case 70
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab70)
                Exit Select

            Case 71
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab71)
                Exit Select

            Case 72
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab72)
                Exit Select

            Case 73
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab73)
                Exit Select

            Case 74
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab74)
                Exit Select

            Case 75
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab75)
                Exit Select

            Case 76
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab76)
                Exit Select

            Case 77
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab77)
                Exit Select

            Case 78
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab78)
                Exit Select

            Case 79
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab79)
                Exit Select

            Case 80
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab80)
                Exit Select

            Case 81
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab81)
                Exit Select

            Case 82
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab82)
                Exit Select

            Case 83
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab83)
                Exit Select

            Case 84
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab84)
                Exit Select

            Case 85
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab85)
                Exit Select

            Case 86
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab86)
                Exit Select

            Case 87
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab87)
                Exit Select

            Case 88
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab88)
                Exit Select

            Case 89
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab89)
                Exit Select

            Case 90
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab90)
                Exit Select

            Case 91
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab91)
                Exit Select

            Case 92
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab92)
                Exit Select

            Case 93
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab93)
                Exit Select

            Case 94
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab94)
                Exit Select

            Case 95
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab95)
                Exit Select

            Case 96
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab96)
                Exit Select

            Case 97
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab97)
                Exit Select

            Case 98
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab98)
                Exit Select

            Case 99
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab99)
                Exit Select

            Case 100
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab100)
                Exit Select

            Case 101
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab101)
                Exit Select

            Case 102
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab102)
                Exit Select

            Case 103
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab103)
                Exit Select

            Case 104
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab104)
                Exit Select

            Case 105
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab105)
                Exit Select

            Case 106
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab106)
                Exit Select

            Case 107
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab107)
                Exit Select

            Case 108
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab108)
                Exit Select

            Case 109
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab109)
                Exit Select

            Case 110
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab110)
                Exit Select

            Case 111
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab111)
                Exit Select

            Case 112
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab112)
                Exit Select

            Case 113
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab113)
                Exit Select

            Case 114
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab114)
                Exit Select

            Case 115
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab115)
                Exit Select

            Case 116
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab116)
                Exit Select

            Case 117
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab117)
                Exit Select

            Case 118
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab118)
                Exit Select

            Case 119
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab119)
                Exit Select

            Case 120
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab120)
                Exit Select

            Case 121
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab121)
                Exit Select

            Case 122
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab122)
                Exit Select

            Case 123
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab123)
                Exit Select

            Case 124
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab124)
                Exit Select

            Case 125
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab125)
                Exit Select

            Case 126
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab126)
                Exit Select

            Case 127
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab127)
                Exit Select

            Case 128
                FRM_NAVEGACAO.TabControl1.Tabs.Remove(tab128)
                Exit Select

            





        End Select


    End Sub









    'Referente a aba de historico de sites visitados para recurso de autocompletar

    Public Sub proc_inicializar_motor_geckofx_em_aba_de_historico_de_rec_auto_completar() 'Inicializa e cria o motor geckofx da aba do recurso de autocompletar
        On Error Resume Next


        'Adicionando o controle geckofx do recurso de autocompletar -----------------------------------------------------------------------------------------------

        FRM_NAVEGACAO.PN_PAINEL_DO_REC_AUTO_COMPL.Controls.Add(FRM_NAVEGACAO.GECK_MOTOR_DE_AUTO_COMPLETAR_HIST) 'Adicionando objeto

        FRM_NAVEGACAO.GECK_MOTOR_DE_AUTO_COMPLETAR_HIST.Visible = True 'Visivel

        FRM_NAVEGACAO.GECK_MOTOR_DE_AUTO_COMPLETAR_HIST.NoDefaultContextMenu = True 'Sem menu de contexto padrao

        FRM_NAVEGACAO.GECK_MOTOR_DE_AUTO_COMPLETAR_HIST.Dock = DockStyle.Fill 'Ocupar todo o espaço

        AddHandler FRM_NAVEGACAO.GECK_MOTOR_DE_AUTO_COMPLETAR_HIST.ShowContextMenu, AddressOf GECK_MOTOR_DE_AUTO_COMPLETAR_HIST_ShowContextMenu 'Evento

        AddHandler FRM_NAVEGACAO.GECK_MOTOR_DE_AUTO_COMPLETAR_HIST.DomMouseUp, AddressOf GECK_MOTOR_DE_AUTO_COMPLETAR_HIST_DOM_MOUSE_UP 'Evento

        AddHandler FRM_NAVEGACAO.GECK_MOTOR_DE_AUTO_COMPLETAR_HIST.DomMouseMove, AddressOf GECKO_MOTOR_DE_AUTO_COMPLETAR_HIST_DOM_MOUSE_MOVE 'Evento

        '----------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub


































  














End Module
