Module Modulo_de_navegacao



    'Variáveis de processamento de informações

    Public v_tipo_de_motor_layout_engine_em_uso_agora As Boolean 'Informa o tipo de motor layout engine em uso agora

    Public v_qual_motor_esta_em_uso As Integer 'Informa qual motor esta em uso

















    'Função necessaria

    Public Function func_retorne_tipo_de_motor(ByVal V_NOME_TAB_FECHADA As String) 'Retorna tipo de motor em uso
        On Error Resume Next

        Dim v_motor_em_foco As Integer 'Informa a aba fechada






        'Informando qual aba foi fechada ----------------------------------------------------------------------------

        Select Case V_NOME_TAB_FECHADA


            Case v_nome_generico_da_tab & 1
                v_motor_em_foco = 1
                Exit Select
            Case v_nome_generico_da_tab & 2
                v_motor_em_foco = 2
                Exit Select
            Case v_nome_generico_da_tab & 3
                v_motor_em_foco = 3
                Exit Select
            Case v_nome_generico_da_tab & 4
                v_motor_em_foco = 4
                Exit Select
            Case v_nome_generico_da_tab & 5
                v_motor_em_foco = 5
                Exit Select
            Case v_nome_generico_da_tab & 6
                v_motor_em_foco = 6
                Exit Select
            Case v_nome_generico_da_tab & 7
                v_motor_em_foco = 7
                Exit Select
            Case v_nome_generico_da_tab & 8
                v_motor_em_foco = 8
                Exit Select
            Case v_nome_generico_da_tab & 9
                v_motor_em_foco = 9
                Exit Select
            Case v_nome_generico_da_tab & 10
                v_motor_em_foco = 10
                Exit Select
            Case v_nome_generico_da_tab & 11
                v_motor_em_foco = 11
                Exit Select
            Case v_nome_generico_da_tab & 12
                v_motor_em_foco = 12
                Exit Select
            Case v_nome_generico_da_tab & 13
                v_motor_em_foco = 13
                Exit Select
            Case v_nome_generico_da_tab & 14
                v_motor_em_foco = 14
                Exit Select
            Case v_nome_generico_da_tab & 15
                v_motor_em_foco = 15
                Exit Select
            Case v_nome_generico_da_tab & 16
                v_motor_em_foco = 16
                Exit Select
            Case v_nome_generico_da_tab & 17
                v_motor_em_foco = 17
                Exit Select
            Case v_nome_generico_da_tab & 18
                v_motor_em_foco = 18
                Exit Select
            Case v_nome_generico_da_tab & 19
                v_motor_em_foco = 19
                Exit Select
            Case v_nome_generico_da_tab & 20
                v_motor_em_foco = 20
                Exit Select
            Case v_nome_generico_da_tab & 21
                v_motor_em_foco = 21
                Exit Select
            Case v_nome_generico_da_tab & 22
                v_motor_em_foco = 22
                Exit Select
            Case v_nome_generico_da_tab & 23
                v_motor_em_foco = 23
                Exit Select
            Case v_nome_generico_da_tab & 24
                v_motor_em_foco = 24
                Exit Select
            Case v_nome_generico_da_tab & 25
                v_motor_em_foco = 25
                Exit Select
            Case v_nome_generico_da_tab & 26
                v_motor_em_foco = 26
                Exit Select
            Case v_nome_generico_da_tab & 27
                v_motor_em_foco = 27
                Exit Select
            Case v_nome_generico_da_tab & 28
                v_motor_em_foco = 28
                Exit Select
            Case v_nome_generico_da_tab & 29
                v_motor_em_foco = 29
                Exit Select
            Case v_nome_generico_da_tab & 30
                v_motor_em_foco = 30
                Exit Select
            Case v_nome_generico_da_tab & 31
                v_motor_em_foco = 31
                Exit Select
            Case v_nome_generico_da_tab & 32
                v_motor_em_foco = 32
                Exit Select
            Case v_nome_generico_da_tab & 33
                v_motor_em_foco = 33
                Exit Select
            Case v_nome_generico_da_tab & 34
                v_motor_em_foco = 34
                Exit Select
            Case v_nome_generico_da_tab & 35
                v_motor_em_foco = 35
                Exit Select
            Case v_nome_generico_da_tab & 36
                v_motor_em_foco = 36
                Exit Select
            Case v_nome_generico_da_tab & 37
                v_motor_em_foco = 37
                Exit Select
            Case v_nome_generico_da_tab & 38
                v_motor_em_foco = 38
                Exit Select
            Case v_nome_generico_da_tab & 39
                v_motor_em_foco = 39
                Exit Select
            Case v_nome_generico_da_tab & 40
                v_motor_em_foco = 40
                Exit Select
            Case v_nome_generico_da_tab & 41
                v_motor_em_foco = 41
                Exit Select
            Case v_nome_generico_da_tab & 42
                v_motor_em_foco = 42
                Exit Select
            Case v_nome_generico_da_tab & 43
                v_motor_em_foco = 43
                Exit Select
            Case v_nome_generico_da_tab & 44
                v_motor_em_foco = 44
                Exit Select
            Case v_nome_generico_da_tab & 45
                v_motor_em_foco = 45
                Exit Select
            Case v_nome_generico_da_tab & 46
                v_motor_em_foco = 46
                Exit Select
            Case v_nome_generico_da_tab & 47
                v_motor_em_foco = 47
                Exit Select
            Case v_nome_generico_da_tab & 48
                v_motor_em_foco = 48
                Exit Select
            Case v_nome_generico_da_tab & 49
                v_motor_em_foco = 49
                Exit Select
            Case v_nome_generico_da_tab & 50
                v_motor_em_foco = 50
                Exit Select
            Case v_nome_generico_da_tab & 51
                v_motor_em_foco = 51
                Exit Select
            Case v_nome_generico_da_tab & 52
                v_motor_em_foco = 52
                Exit Select
            Case v_nome_generico_da_tab & 53
                v_motor_em_foco = 53
                Exit Select
            Case v_nome_generico_da_tab & 54
                v_motor_em_foco = 54
                Exit Select
            Case v_nome_generico_da_tab & 55
                v_motor_em_foco = 55
                Exit Select
            Case v_nome_generico_da_tab & 56
                v_motor_em_foco = 56
                Exit Select
            Case v_nome_generico_da_tab & 57
                v_motor_em_foco = 57
                Exit Select
            Case v_nome_generico_da_tab & 58
                v_motor_em_foco = 58
                Exit Select
            Case v_nome_generico_da_tab & 59
                v_motor_em_foco = 59
                Exit Select
            Case v_nome_generico_da_tab & 60
                v_motor_em_foco = 60
                Exit Select
            Case v_nome_generico_da_tab & 61
                v_motor_em_foco = 61
                Exit Select
            Case v_nome_generico_da_tab & 62
                v_motor_em_foco = 62
                Exit Select
            Case v_nome_generico_da_tab & 63
                v_motor_em_foco = 63
                Exit Select
            Case v_nome_generico_da_tab & 64
                v_motor_em_foco = 64
                Exit Select
            Case v_nome_generico_da_tab & 65
                v_motor_em_foco = 65
                Exit Select
            Case v_nome_generico_da_tab & 66
                v_motor_em_foco = 66
                Exit Select
            Case v_nome_generico_da_tab & 67
                v_motor_em_foco = 67
                Exit Select
            Case v_nome_generico_da_tab & 68
                v_motor_em_foco = 68
                Exit Select
            Case v_nome_generico_da_tab & 69
                v_motor_em_foco = 69
                Exit Select
            Case v_nome_generico_da_tab & 70
                v_motor_em_foco = 70
                Exit Select
            Case v_nome_generico_da_tab & 71
                v_motor_em_foco = 71
                Exit Select
            Case v_nome_generico_da_tab & 72
                v_motor_em_foco = 72
                Exit Select
            Case v_nome_generico_da_tab & 73
                v_motor_em_foco = 73
                Exit Select
            Case v_nome_generico_da_tab & 74
                v_motor_em_foco = 74
                Exit Select
            Case v_nome_generico_da_tab & 75
                v_motor_em_foco = 75
                Exit Select
            Case v_nome_generico_da_tab & 76
                v_motor_em_foco = 76
                Exit Select
            Case v_nome_generico_da_tab & 77
                v_motor_em_foco = 77
                Exit Select
            Case v_nome_generico_da_tab & 78
                v_motor_em_foco = 78
                Exit Select
            Case v_nome_generico_da_tab & 79
                v_motor_em_foco = 79
                Exit Select
            Case v_nome_generico_da_tab & 80
                v_motor_em_foco = 80
                Exit Select
            Case v_nome_generico_da_tab & 81
                v_motor_em_foco = 81
                Exit Select
            Case v_nome_generico_da_tab & 82
                v_motor_em_foco = 82
                Exit Select
            Case v_nome_generico_da_tab & 83
                v_motor_em_foco = 83
                Exit Select
            Case v_nome_generico_da_tab & 84
                v_motor_em_foco = 84
                Exit Select
            Case v_nome_generico_da_tab & 85
                v_motor_em_foco = 85
                Exit Select
            Case v_nome_generico_da_tab & 86
                v_motor_em_foco = 86
                Exit Select
            Case v_nome_generico_da_tab & 87
                v_motor_em_foco = 87
                Exit Select
            Case v_nome_generico_da_tab & 88
                v_motor_em_foco = 88
                Exit Select
            Case v_nome_generico_da_tab & 89
                v_motor_em_foco = 89
                Exit Select
            Case v_nome_generico_da_tab & 90
                v_motor_em_foco = 90
                Exit Select
            Case v_nome_generico_da_tab & 91
                v_motor_em_foco = 91
                Exit Select
            Case v_nome_generico_da_tab & 92
                v_motor_em_foco = 92
                Exit Select
            Case v_nome_generico_da_tab & 93
                v_motor_em_foco = 93
                Exit Select
            Case v_nome_generico_da_tab & 94
                v_motor_em_foco = 94
                Exit Select
            Case v_nome_generico_da_tab & 95
                v_motor_em_foco = 95
                Exit Select
            Case v_nome_generico_da_tab & 96
                v_motor_em_foco = 96
                Exit Select
            Case v_nome_generico_da_tab & 97
                v_motor_em_foco = 97
                Exit Select
            Case v_nome_generico_da_tab & 98
                v_motor_em_foco = 98
                Exit Select
            Case v_nome_generico_da_tab & 99
                v_motor_em_foco = 99
                Exit Select
            Case v_nome_generico_da_tab & 100
                v_motor_em_foco = 100
                Exit Select
            Case v_nome_generico_da_tab & 101
                v_motor_em_foco = 101
                Exit Select
            Case v_nome_generico_da_tab & 102
                v_motor_em_foco = 102
                Exit Select
            Case v_nome_generico_da_tab & 103
                v_motor_em_foco = 103
                Exit Select
            Case v_nome_generico_da_tab & 104
                v_motor_em_foco = 104
                Exit Select
            Case v_nome_generico_da_tab & 105
                v_motor_em_foco = 105
                Exit Select
            Case v_nome_generico_da_tab & 106
                v_motor_em_foco = 106
                Exit Select
            Case v_nome_generico_da_tab & 107
                v_motor_em_foco = 107
                Exit Select
            Case v_nome_generico_da_tab & 108
                v_motor_em_foco = 108
                Exit Select
            Case v_nome_generico_da_tab & 109
                v_motor_em_foco = 109
                Exit Select
            Case v_nome_generico_da_tab & 110
                v_motor_em_foco = 110
                Exit Select
            Case v_nome_generico_da_tab & 111
                v_motor_em_foco = 111
                Exit Select
            Case v_nome_generico_da_tab & 112
                v_motor_em_foco = 112
                Exit Select
            Case v_nome_generico_da_tab & 113
                v_motor_em_foco = 113
                Exit Select
            Case v_nome_generico_da_tab & 114
                v_motor_em_foco = 114
                Exit Select
            Case v_nome_generico_da_tab & 115
                v_motor_em_foco = 115
                Exit Select
            Case v_nome_generico_da_tab & 116
                v_motor_em_foco = 116
                Exit Select
            Case v_nome_generico_da_tab & 117
                v_motor_em_foco = 117
                Exit Select
            Case v_nome_generico_da_tab & 118
                v_motor_em_foco = 118
                Exit Select
            Case v_nome_generico_da_tab & 119
                v_motor_em_foco = 119
                Exit Select
            Case v_nome_generico_da_tab & 120
                v_motor_em_foco = 120
                Exit Select
            Case v_nome_generico_da_tab & 121
                v_motor_em_foco = 121
                Exit Select
            Case v_nome_generico_da_tab & 122
                v_motor_em_foco = 122
                Exit Select
            Case v_nome_generico_da_tab & 123
                v_motor_em_foco = 123
                Exit Select
            Case v_nome_generico_da_tab & 124
                v_motor_em_foco = 124
                Exit Select
            Case v_nome_generico_da_tab & 125
                v_motor_em_foco = 125
                Exit Select
            Case v_nome_generico_da_tab & 126
                v_motor_em_foco = 126
                Exit Select
            Case v_nome_generico_da_tab & 127
                v_motor_em_foco = 127
                Exit Select
            Case v_nome_generico_da_tab & 128
                v_motor_em_foco = 128
                Exit Select



        End Select

        '------------------------------------------------------------------------------------------------------------


        'Informe o tipo de motor em uso -----------------------------------------------------------------------------

        v_qual_motor_esta_em_uso = v_motor_em_foco

        '------------------------------------------------------------------------------------------------------------


        'Retorno ----------------------------------------------------------------

        Return v_tipo_de_motor_adicionado(v_motor_em_foco) 'Retorno

        '------------------------------------------------------------------------

    End Function




    'Navegue com tipo de motor

    Public Sub proc_abrir_site_motor_geckofx(ByVal V_URL As String, ByVal V_MOTOR_NUM As Integer) 'Abre a página solicitada no Geckofx
        On Error Resume Next


        Select Case V_MOTOR_NUM


            Case 1
                OBJ_MOTOR_GECKOFX_1.Navigate(V_URL)
                Exit Select
            Case 2
                OBJ_MOTOR_GECKOFX_2.Navigate(V_URL)
                Exit Select
            Case 3
                OBJ_MOTOR_GECKOFX_3.Navigate(V_URL)
                Exit Select
            Case 4
                OBJ_MOTOR_GECKOFX_4.Navigate(V_URL)
                Exit Select
            Case 5
                OBJ_MOTOR_GECKOFX_5.Navigate(V_URL)
                Exit Select
            Case 6
                OBJ_MOTOR_GECKOFX_6.Navigate(V_URL)
                Exit Select
            Case 7
                OBJ_MOTOR_GECKOFX_7.Navigate(V_URL)
                Exit Select
            Case 8
                OBJ_MOTOR_GECKOFX_8.Navigate(V_URL)
                Exit Select
            Case 9
                OBJ_MOTOR_GECKOFX_9.Navigate(V_URL)
                Exit Select
            Case 10
                OBJ_MOTOR_GECKOFX_10.Navigate(V_URL)
                Exit Select
            Case 11
                OBJ_MOTOR_GECKOFX_11.Navigate(V_URL)
                Exit Select
            Case 12
                OBJ_MOTOR_GECKOFX_12.Navigate(V_URL)
                Exit Select
            Case 13
                OBJ_MOTOR_GECKOFX_13.Navigate(V_URL)
                Exit Select
            Case 14
                OBJ_MOTOR_GECKOFX_14.Navigate(V_URL)
                Exit Select
            Case 15
                OBJ_MOTOR_GECKOFX_15.Navigate(V_URL)
                Exit Select
            Case 16
                OBJ_MOTOR_GECKOFX_16.Navigate(V_URL)
                Exit Select
            Case 17
                OBJ_MOTOR_GECKOFX_17.Navigate(V_URL)
                Exit Select
            Case 18
                OBJ_MOTOR_GECKOFX_18.Navigate(V_URL)
                Exit Select
            Case 19
                OBJ_MOTOR_GECKOFX_19.Navigate(V_URL)
                Exit Select
            Case 20
                OBJ_MOTOR_GECKOFX_20.Navigate(V_URL)
                Exit Select
            Case 21
                OBJ_MOTOR_GECKOFX_21.Navigate(V_URL)
                Exit Select
            Case 22
                OBJ_MOTOR_GECKOFX_22.Navigate(V_URL)
                Exit Select
            Case 23
                OBJ_MOTOR_GECKOFX_23.Navigate(V_URL)
                Exit Select
            Case 24
                OBJ_MOTOR_GECKOFX_24.Navigate(V_URL)
                Exit Select
            Case 25
                OBJ_MOTOR_GECKOFX_25.Navigate(V_URL)
                Exit Select
            Case 26
                OBJ_MOTOR_GECKOFX_26.Navigate(V_URL)
                Exit Select
            Case 27
                OBJ_MOTOR_GECKOFX_27.Navigate(V_URL)
                Exit Select
            Case 28
                OBJ_MOTOR_GECKOFX_28.Navigate(V_URL)
                Exit Select
            Case 29
                OBJ_MOTOR_GECKOFX_29.Navigate(V_URL)
                Exit Select
            Case 30
                OBJ_MOTOR_GECKOFX_30.Navigate(V_URL)
                Exit Select
            Case 31
                OBJ_MOTOR_GECKOFX_31.Navigate(V_URL)
                Exit Select
            Case 32
                OBJ_MOTOR_GECKOFX_32.Navigate(V_URL)
                Exit Select
            Case 33
                OBJ_MOTOR_GECKOFX_33.Navigate(V_URL)
                Exit Select
            Case 34
                OBJ_MOTOR_GECKOFX_34.Navigate(V_URL)
                Exit Select
            Case 35
                OBJ_MOTOR_GECKOFX_35.Navigate(V_URL)
                Exit Select
            Case 36
                OBJ_MOTOR_GECKOFX_36.Navigate(V_URL)
                Exit Select
            Case 37
                OBJ_MOTOR_GECKOFX_37.Navigate(V_URL)
                Exit Select
            Case 38
                OBJ_MOTOR_GECKOFX_38.Navigate(V_URL)
                Exit Select
            Case 39
                OBJ_MOTOR_GECKOFX_39.Navigate(V_URL)
                Exit Select
            Case 40
                OBJ_MOTOR_GECKOFX_40.Navigate(V_URL)
                Exit Select
            Case 41
                OBJ_MOTOR_GECKOFX_41.Navigate(V_URL)
                Exit Select
            Case 42
                OBJ_MOTOR_GECKOFX_42.Navigate(V_URL)
                Exit Select
            Case 43
                OBJ_MOTOR_GECKOFX_43.Navigate(V_URL)
                Exit Select
            Case 44
                OBJ_MOTOR_GECKOFX_44.Navigate(V_URL)
                Exit Select
            Case 45
                OBJ_MOTOR_GECKOFX_45.Navigate(V_URL)
                Exit Select
            Case 46
                OBJ_MOTOR_GECKOFX_46.Navigate(V_URL)
                Exit Select
            Case 47
                OBJ_MOTOR_GECKOFX_47.Navigate(V_URL)
                Exit Select
            Case 48
                OBJ_MOTOR_GECKOFX_48.Navigate(V_URL)
                Exit Select
            Case 49
                OBJ_MOTOR_GECKOFX_49.Navigate(V_URL)
                Exit Select
            Case 50
                OBJ_MOTOR_GECKOFX_50.Navigate(V_URL)
                Exit Select
            Case 51
                OBJ_MOTOR_GECKOFX_51.Navigate(V_URL)
                Exit Select
            Case 52
                OBJ_MOTOR_GECKOFX_52.Navigate(V_URL)
                Exit Select
            Case 53
                OBJ_MOTOR_GECKOFX_53.Navigate(V_URL)
                Exit Select
            Case 54
                OBJ_MOTOR_GECKOFX_54.Navigate(V_URL)
                Exit Select
            Case 55
                OBJ_MOTOR_GECKOFX_55.Navigate(V_URL)
                Exit Select
            Case 56
                OBJ_MOTOR_GECKOFX_56.Navigate(V_URL)
                Exit Select
            Case 57
                OBJ_MOTOR_GECKOFX_57.Navigate(V_URL)
                Exit Select
            Case 58
                OBJ_MOTOR_GECKOFX_58.Navigate(V_URL)
                Exit Select
            Case 59
                OBJ_MOTOR_GECKOFX_59.Navigate(V_URL)
                Exit Select
            Case 60
                OBJ_MOTOR_GECKOFX_60.Navigate(V_URL)
                Exit Select
            Case 61
                OBJ_MOTOR_GECKOFX_61.Navigate(V_URL)
                Exit Select
            Case 62
                OBJ_MOTOR_GECKOFX_62.Navigate(V_URL)
                Exit Select
            Case 63
                OBJ_MOTOR_GECKOFX_63.Navigate(V_URL)
                Exit Select
            Case 64
                OBJ_MOTOR_GECKOFX_64.Navigate(V_URL)
                Exit Select
            Case 65
                OBJ_MOTOR_GECKOFX_65.Navigate(V_URL)
                Exit Select
            Case 66
                OBJ_MOTOR_GECKOFX_66.Navigate(V_URL)
                Exit Select
            Case 67
                OBJ_MOTOR_GECKOFX_67.Navigate(V_URL)
                Exit Select
            Case 68
                OBJ_MOTOR_GECKOFX_68.Navigate(V_URL)
                Exit Select
            Case 69
                OBJ_MOTOR_GECKOFX_69.Navigate(V_URL)
                Exit Select
            Case 70
                OBJ_MOTOR_GECKOFX_70.Navigate(V_URL)
                Exit Select
            Case 71
                OBJ_MOTOR_GECKOFX_71.Navigate(V_URL)
                Exit Select
            Case 72
                OBJ_MOTOR_GECKOFX_72.Navigate(V_URL)
                Exit Select
            Case 73
                OBJ_MOTOR_GECKOFX_73.Navigate(V_URL)
                Exit Select
            Case 74
                OBJ_MOTOR_GECKOFX_74.Navigate(V_URL)
                Exit Select
            Case 75
                OBJ_MOTOR_GECKOFX_75.Navigate(V_URL)
                Exit Select
            Case 76
                OBJ_MOTOR_GECKOFX_76.Navigate(V_URL)
                Exit Select
            Case 77
                OBJ_MOTOR_GECKOFX_77.Navigate(V_URL)
                Exit Select
            Case 78
                OBJ_MOTOR_GECKOFX_78.Navigate(V_URL)
                Exit Select
            Case 79
                OBJ_MOTOR_GECKOFX_79.Navigate(V_URL)
                Exit Select
            Case 80
                OBJ_MOTOR_GECKOFX_80.Navigate(V_URL)
                Exit Select
            Case 81
                OBJ_MOTOR_GECKOFX_81.Navigate(V_URL)
                Exit Select
            Case 82
                OBJ_MOTOR_GECKOFX_82.Navigate(V_URL)
                Exit Select
            Case 83
                OBJ_MOTOR_GECKOFX_83.Navigate(V_URL)
                Exit Select
            Case 84
                OBJ_MOTOR_GECKOFX_84.Navigate(V_URL)
                Exit Select
            Case 85
                OBJ_MOTOR_GECKOFX_85.Navigate(V_URL)
                Exit Select
            Case 86
                OBJ_MOTOR_GECKOFX_86.Navigate(V_URL)
                Exit Select
            Case 87
                OBJ_MOTOR_GECKOFX_87.Navigate(V_URL)
                Exit Select
            Case 88
                OBJ_MOTOR_GECKOFX_88.Navigate(V_URL)
                Exit Select
            Case 89
                OBJ_MOTOR_GECKOFX_89.Navigate(V_URL)
                Exit Select
            Case 90
                OBJ_MOTOR_GECKOFX_90.Navigate(V_URL)
                Exit Select
            Case 91
                OBJ_MOTOR_GECKOFX_91.Navigate(V_URL)
                Exit Select
            Case 92
                OBJ_MOTOR_GECKOFX_92.Navigate(V_URL)
                Exit Select
            Case 93
                OBJ_MOTOR_GECKOFX_93.Navigate(V_URL)
                Exit Select
            Case 94
                OBJ_MOTOR_GECKOFX_94.Navigate(V_URL)
                Exit Select
            Case 95
                OBJ_MOTOR_GECKOFX_95.Navigate(V_URL)
                Exit Select
            Case 96
                OBJ_MOTOR_GECKOFX_96.Navigate(V_URL)
                Exit Select
            Case 97
                OBJ_MOTOR_GECKOFX_97.Navigate(V_URL)
                Exit Select
            Case 98
                OBJ_MOTOR_GECKOFX_98.Navigate(V_URL)
                Exit Select
            Case 99
                OBJ_MOTOR_GECKOFX_99.Navigate(V_URL)
                Exit Select
            Case 100
                OBJ_MOTOR_GECKOFX_100.Navigate(V_URL)
                Exit Select
            Case 101
                OBJ_MOTOR_GECKOFX_101.Navigate(V_URL)
                Exit Select
            Case 102
                OBJ_MOTOR_GECKOFX_102.Navigate(V_URL)
                Exit Select
            Case 103
                OBJ_MOTOR_GECKOFX_103.Navigate(V_URL)
                Exit Select
            Case 104
                OBJ_MOTOR_GECKOFX_104.Navigate(V_URL)
                Exit Select
            Case 105
                OBJ_MOTOR_GECKOFX_105.Navigate(V_URL)
                Exit Select
            Case 106
                OBJ_MOTOR_GECKOFX_106.Navigate(V_URL)
                Exit Select
            Case 107
                OBJ_MOTOR_GECKOFX_107.Navigate(V_URL)
                Exit Select
            Case 108
                OBJ_MOTOR_GECKOFX_108.Navigate(V_URL)
                Exit Select
            Case 109
                OBJ_MOTOR_GECKOFX_109.Navigate(V_URL)
                Exit Select
            Case 110
                OBJ_MOTOR_GECKOFX_110.Navigate(V_URL)
                Exit Select
            Case 111
                OBJ_MOTOR_GECKOFX_111.Navigate(V_URL)
                Exit Select
            Case 112
                OBJ_MOTOR_GECKOFX_112.Navigate(V_URL)
                Exit Select
            Case 113
                OBJ_MOTOR_GECKOFX_113.Navigate(V_URL)
                Exit Select
            Case 114
                OBJ_MOTOR_GECKOFX_114.Navigate(V_URL)
                Exit Select
            Case 115
                OBJ_MOTOR_GECKOFX_115.Navigate(V_URL)
                Exit Select
            Case 116
                OBJ_MOTOR_GECKOFX_116.Navigate(V_URL)
                Exit Select
            Case 117
                OBJ_MOTOR_GECKOFX_117.Navigate(V_URL)
                Exit Select
            Case 118
                OBJ_MOTOR_GECKOFX_118.Navigate(V_URL)
                Exit Select
            Case 119
                OBJ_MOTOR_GECKOFX_119.Navigate(V_URL)
                Exit Select
            Case 120
                OBJ_MOTOR_GECKOFX_120.Navigate(V_URL)
                Exit Select
            Case 121
                OBJ_MOTOR_GECKOFX_121.Navigate(V_URL)
                Exit Select
            Case 122
                OBJ_MOTOR_GECKOFX_122.Navigate(V_URL)
                Exit Select
            Case 123
                OBJ_MOTOR_GECKOFX_123.Navigate(V_URL)
                Exit Select
            Case 124
                OBJ_MOTOR_GECKOFX_124.Navigate(V_URL)
                Exit Select
            Case 125
                OBJ_MOTOR_GECKOFX_125.Navigate(V_URL)
                Exit Select
            Case 126
                OBJ_MOTOR_GECKOFX_126.Navigate(V_URL)
                Exit Select
            Case 127
                OBJ_MOTOR_GECKOFX_127.Navigate(V_URL)
                Exit Select
            Case 128
                OBJ_MOTOR_GECKOFX_128.Navigate(V_URL)
                Exit Select





        End Select


    End Sub

    Public Sub proc_abrir_site_motor_trident(ByVal V_URL As String, ByVal V_MOTOR_NUM As Integer) 'Abre a página solicitada no Trident
        On Error Resume Next


        Select Case V_MOTOR_NUM


            Case 1
                OBJ_MOTOR_WEB_BROWSER_1.Navigate(V_URL)
                Exit Select
            Case 2
                OBJ_MOTOR_WEB_BROWSER_2.Navigate(V_URL)
                Exit Select
            Case 3
                OBJ_MOTOR_WEB_BROWSER_3.Navigate(V_URL)
                Exit Select
            Case 4
                OBJ_MOTOR_WEB_BROWSER_4.Navigate(V_URL)
                Exit Select
            Case 5
                OBJ_MOTOR_WEB_BROWSER_5.Navigate(V_URL)
                Exit Select
            Case 6
                OBJ_MOTOR_WEB_BROWSER_6.Navigate(V_URL)
                Exit Select
            Case 7
                OBJ_MOTOR_WEB_BROWSER_7.Navigate(V_URL)
                Exit Select
            Case 8
                OBJ_MOTOR_WEB_BROWSER_8.Navigate(V_URL)
                Exit Select
            Case 9
                OBJ_MOTOR_WEB_BROWSER_9.Navigate(V_URL)
                Exit Select
            Case 10
                OBJ_MOTOR_WEB_BROWSER_10.Navigate(V_URL)
                Exit Select
            Case 11
                OBJ_MOTOR_WEB_BROWSER_11.Navigate(V_URL)
                Exit Select
            Case 12
                OBJ_MOTOR_WEB_BROWSER_12.Navigate(V_URL)
                Exit Select
            Case 13
                OBJ_MOTOR_WEB_BROWSER_13.Navigate(V_URL)
                Exit Select
            Case 14
                OBJ_MOTOR_WEB_BROWSER_14.Navigate(V_URL)
                Exit Select
            Case 15
                OBJ_MOTOR_WEB_BROWSER_15.Navigate(V_URL)
                Exit Select
            Case 16
                OBJ_MOTOR_WEB_BROWSER_16.Navigate(V_URL)
                Exit Select
            Case 17
                OBJ_MOTOR_WEB_BROWSER_17.Navigate(V_URL)
                Exit Select
            Case 18
                OBJ_MOTOR_WEB_BROWSER_18.Navigate(V_URL)
                Exit Select
            Case 19
                OBJ_MOTOR_WEB_BROWSER_19.Navigate(V_URL)
                Exit Select
            Case 20
                OBJ_MOTOR_WEB_BROWSER_20.Navigate(V_URL)
                Exit Select
            Case 21
                OBJ_MOTOR_WEB_BROWSER_21.Navigate(V_URL)
                Exit Select
            Case 22
                OBJ_MOTOR_WEB_BROWSER_22.Navigate(V_URL)
                Exit Select
            Case 23
                OBJ_MOTOR_WEB_BROWSER_23.Navigate(V_URL)
                Exit Select
            Case 24
                OBJ_MOTOR_WEB_BROWSER_24.Navigate(V_URL)
                Exit Select
            Case 25
                OBJ_MOTOR_WEB_BROWSER_25.Navigate(V_URL)
                Exit Select
            Case 26
                OBJ_MOTOR_WEB_BROWSER_26.Navigate(V_URL)
                Exit Select
            Case 27
                OBJ_MOTOR_WEB_BROWSER_27.Navigate(V_URL)
                Exit Select
            Case 28
                OBJ_MOTOR_WEB_BROWSER_28.Navigate(V_URL)
                Exit Select
            Case 29
                OBJ_MOTOR_WEB_BROWSER_29.Navigate(V_URL)
                Exit Select
            Case 30
                OBJ_MOTOR_WEB_BROWSER_30.Navigate(V_URL)
                Exit Select
            Case 31
                OBJ_MOTOR_WEB_BROWSER_31.Navigate(V_URL)
                Exit Select
            Case 32
                OBJ_MOTOR_WEB_BROWSER_32.Navigate(V_URL)
                Exit Select
            Case 33
                OBJ_MOTOR_WEB_BROWSER_33.Navigate(V_URL)
                Exit Select
            Case 34
                OBJ_MOTOR_WEB_BROWSER_34.Navigate(V_URL)
                Exit Select
            Case 35
                OBJ_MOTOR_WEB_BROWSER_35.Navigate(V_URL)
                Exit Select
            Case 36
                OBJ_MOTOR_WEB_BROWSER_36.Navigate(V_URL)
                Exit Select
            Case 37
                OBJ_MOTOR_WEB_BROWSER_37.Navigate(V_URL)
                Exit Select
            Case 38
                OBJ_MOTOR_WEB_BROWSER_38.Navigate(V_URL)
                Exit Select
            Case 39
                OBJ_MOTOR_WEB_BROWSER_39.Navigate(V_URL)
                Exit Select
            Case 40
                OBJ_MOTOR_WEB_BROWSER_40.Navigate(V_URL)
                Exit Select
            Case 41
                OBJ_MOTOR_WEB_BROWSER_41.Navigate(V_URL)
                Exit Select
            Case 42
                OBJ_MOTOR_WEB_BROWSER_42.Navigate(V_URL)
                Exit Select
            Case 43
                OBJ_MOTOR_WEB_BROWSER_43.Navigate(V_URL)
                Exit Select
            Case 44
                OBJ_MOTOR_WEB_BROWSER_44.Navigate(V_URL)
                Exit Select
            Case 45
                OBJ_MOTOR_WEB_BROWSER_45.Navigate(V_URL)
                Exit Select
            Case 46
                OBJ_MOTOR_WEB_BROWSER_46.Navigate(V_URL)
                Exit Select
            Case 47
                OBJ_MOTOR_WEB_BROWSER_47.Navigate(V_URL)
                Exit Select
            Case 48
                OBJ_MOTOR_WEB_BROWSER_48.Navigate(V_URL)
                Exit Select
            Case 49
                OBJ_MOTOR_WEB_BROWSER_49.Navigate(V_URL)
                Exit Select
            Case 50
                OBJ_MOTOR_WEB_BROWSER_50.Navigate(V_URL)
                Exit Select
            Case 51
                OBJ_MOTOR_WEB_BROWSER_51.Navigate(V_URL)
                Exit Select
            Case 52
                OBJ_MOTOR_WEB_BROWSER_52.Navigate(V_URL)
                Exit Select
            Case 53
                OBJ_MOTOR_WEB_BROWSER_53.Navigate(V_URL)
                Exit Select
            Case 54
                OBJ_MOTOR_WEB_BROWSER_54.Navigate(V_URL)
                Exit Select
            Case 55
                OBJ_MOTOR_WEB_BROWSER_55.Navigate(V_URL)
                Exit Select
            Case 56
                OBJ_MOTOR_WEB_BROWSER_56.Navigate(V_URL)
                Exit Select
            Case 57
                OBJ_MOTOR_WEB_BROWSER_57.Navigate(V_URL)
                Exit Select
            Case 58
                OBJ_MOTOR_WEB_BROWSER_58.Navigate(V_URL)
                Exit Select
            Case 59
                OBJ_MOTOR_WEB_BROWSER_59.Navigate(V_URL)
                Exit Select
            Case 60
                OBJ_MOTOR_WEB_BROWSER_60.Navigate(V_URL)
                Exit Select
            Case 61
                OBJ_MOTOR_WEB_BROWSER_61.Navigate(V_URL)
                Exit Select
            Case 62
                OBJ_MOTOR_WEB_BROWSER_62.Navigate(V_URL)
                Exit Select
            Case 63
                OBJ_MOTOR_WEB_BROWSER_63.Navigate(V_URL)
                Exit Select
            Case 64
                OBJ_MOTOR_WEB_BROWSER_64.Navigate(V_URL)
                Exit Select
            Case 65
                OBJ_MOTOR_WEB_BROWSER_65.Navigate(V_URL)
                Exit Select
            Case 66
                OBJ_MOTOR_WEB_BROWSER_66.Navigate(V_URL)
                Exit Select
            Case 67
                OBJ_MOTOR_WEB_BROWSER_67.Navigate(V_URL)
                Exit Select
            Case 68
                OBJ_MOTOR_WEB_BROWSER_68.Navigate(V_URL)
                Exit Select
            Case 69
                OBJ_MOTOR_WEB_BROWSER_69.Navigate(V_URL)
                Exit Select
            Case 70
                OBJ_MOTOR_WEB_BROWSER_70.Navigate(V_URL)
                Exit Select
            Case 71
                OBJ_MOTOR_WEB_BROWSER_71.Navigate(V_URL)
                Exit Select
            Case 72
                OBJ_MOTOR_WEB_BROWSER_72.Navigate(V_URL)
                Exit Select
            Case 73
                OBJ_MOTOR_WEB_BROWSER_73.Navigate(V_URL)
                Exit Select
            Case 74
                OBJ_MOTOR_WEB_BROWSER_74.Navigate(V_URL)
                Exit Select
            Case 75
                OBJ_MOTOR_WEB_BROWSER_75.Navigate(V_URL)
                Exit Select
            Case 76
                OBJ_MOTOR_WEB_BROWSER_76.Navigate(V_URL)
                Exit Select
            Case 77
                OBJ_MOTOR_WEB_BROWSER_77.Navigate(V_URL)
                Exit Select
            Case 78
                OBJ_MOTOR_WEB_BROWSER_78.Navigate(V_URL)
                Exit Select
            Case 79
                OBJ_MOTOR_WEB_BROWSER_79.Navigate(V_URL)
                Exit Select
            Case 80
                OBJ_MOTOR_WEB_BROWSER_80.Navigate(V_URL)
                Exit Select
            Case 81
                OBJ_MOTOR_WEB_BROWSER_81.Navigate(V_URL)
                Exit Select
            Case 82
                OBJ_MOTOR_WEB_BROWSER_82.Navigate(V_URL)
                Exit Select
            Case 83
                OBJ_MOTOR_WEB_BROWSER_83.Navigate(V_URL)
                Exit Select
            Case 84
                OBJ_MOTOR_WEB_BROWSER_84.Navigate(V_URL)
                Exit Select
            Case 85
                OBJ_MOTOR_WEB_BROWSER_85.Navigate(V_URL)
                Exit Select
            Case 86
                OBJ_MOTOR_WEB_BROWSER_86.Navigate(V_URL)
                Exit Select
            Case 87
                OBJ_MOTOR_WEB_BROWSER_87.Navigate(V_URL)
                Exit Select
            Case 88
                OBJ_MOTOR_WEB_BROWSER_88.Navigate(V_URL)
                Exit Select
            Case 89
                OBJ_MOTOR_WEB_BROWSER_89.Navigate(V_URL)
                Exit Select
            Case 90
                OBJ_MOTOR_WEB_BROWSER_90.Navigate(V_URL)
                Exit Select
            Case 91
                OBJ_MOTOR_WEB_BROWSER_91.Navigate(V_URL)
                Exit Select
            Case 92
                OBJ_MOTOR_WEB_BROWSER_92.Navigate(V_URL)
                Exit Select
            Case 93
                OBJ_MOTOR_WEB_BROWSER_93.Navigate(V_URL)
                Exit Select
            Case 94
                OBJ_MOTOR_WEB_BROWSER_94.Navigate(V_URL)
                Exit Select
            Case 95
                OBJ_MOTOR_WEB_BROWSER_95.Navigate(V_URL)
                Exit Select
            Case 96
                OBJ_MOTOR_WEB_BROWSER_96.Navigate(V_URL)
                Exit Select
            Case 97
                OBJ_MOTOR_WEB_BROWSER_97.Navigate(V_URL)
                Exit Select
            Case 98
                OBJ_MOTOR_WEB_BROWSER_98.Navigate(V_URL)
                Exit Select
            Case 99
                OBJ_MOTOR_WEB_BROWSER_99.Navigate(V_URL)
                Exit Select
            Case 100
                OBJ_MOTOR_WEB_BROWSER_100.Navigate(V_URL)
                Exit Select
            Case 101
                OBJ_MOTOR_WEB_BROWSER_101.Navigate(V_URL)
                Exit Select
            Case 102
                OBJ_MOTOR_WEB_BROWSER_102.Navigate(V_URL)
                Exit Select
            Case 103
                OBJ_MOTOR_WEB_BROWSER_103.Navigate(V_URL)
                Exit Select
            Case 104
                OBJ_MOTOR_WEB_BROWSER_104.Navigate(V_URL)
                Exit Select
            Case 105
                OBJ_MOTOR_WEB_BROWSER_105.Navigate(V_URL)
                Exit Select
            Case 106
                OBJ_MOTOR_WEB_BROWSER_106.Navigate(V_URL)
                Exit Select
            Case 107
                OBJ_MOTOR_WEB_BROWSER_107.Navigate(V_URL)
                Exit Select
            Case 108
                OBJ_MOTOR_WEB_BROWSER_108.Navigate(V_URL)
                Exit Select
            Case 109
                OBJ_MOTOR_WEB_BROWSER_109.Navigate(V_URL)
                Exit Select
            Case 110
                OBJ_MOTOR_WEB_BROWSER_110.Navigate(V_URL)
                Exit Select
            Case 111
                OBJ_MOTOR_WEB_BROWSER_111.Navigate(V_URL)
                Exit Select
            Case 112
                OBJ_MOTOR_WEB_BROWSER_112.Navigate(V_URL)
                Exit Select
            Case 113
                OBJ_MOTOR_WEB_BROWSER_113.Navigate(V_URL)
                Exit Select
            Case 114
                OBJ_MOTOR_WEB_BROWSER_114.Navigate(V_URL)
                Exit Select
            Case 115
                OBJ_MOTOR_WEB_BROWSER_115.Navigate(V_URL)
                Exit Select
            Case 116
                OBJ_MOTOR_WEB_BROWSER_116.Navigate(V_URL)
                Exit Select
            Case 117
                OBJ_MOTOR_WEB_BROWSER_117.Navigate(V_URL)
                Exit Select
            Case 118
                OBJ_MOTOR_WEB_BROWSER_118.Navigate(V_URL)
                Exit Select
            Case 119
                OBJ_MOTOR_WEB_BROWSER_119.Navigate(V_URL)
                Exit Select
            Case 120
                OBJ_MOTOR_WEB_BROWSER_120.Navigate(V_URL)
                Exit Select
            Case 121
                OBJ_MOTOR_WEB_BROWSER_121.Navigate(V_URL)
                Exit Select
            Case 122
                OBJ_MOTOR_WEB_BROWSER_122.Navigate(V_URL)
                Exit Select
            Case 123
                OBJ_MOTOR_WEB_BROWSER_123.Navigate(V_URL)
                Exit Select
            Case 124
                OBJ_MOTOR_WEB_BROWSER_124.Navigate(V_URL)
                Exit Select
            Case 125
                OBJ_MOTOR_WEB_BROWSER_125.Navigate(V_URL)
                Exit Select
            Case 126
                OBJ_MOTOR_WEB_BROWSER_126.Navigate(V_URL)
                Exit Select
            Case 127
                OBJ_MOTOR_WEB_BROWSER_127.Navigate(V_URL)
                Exit Select
            Case 128
                OBJ_MOTOR_WEB_BROWSER_128.Navigate(V_URL)
                Exit Select





        End Select


    End Sub




    'Focar aba

    Public Sub proc_focar_aba_selecionada(ByVal V_NUM_ABA) 'Foca a aba selecionada anteriormente
        On Error Resume Next


        Select Case V_NUM_ABA

            Case 1


            Case 1
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab1
                Exit Select

            Case 2
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab2
                Exit Select

            Case 3
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab3
                Exit Select

            Case 4
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab4
                Exit Select

            Case 5
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab5
                Exit Select

            Case 6
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab6
                Exit Select

            Case 7
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab7
                Exit Select

            Case 8
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab8
                Exit Select

            Case 9
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab9
                Exit Select

            Case 10
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab10
                Exit Select

            Case 11
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab11
                Exit Select

            Case 12
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab12
                Exit Select

            Case 13
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab13
                Exit Select

            Case 14
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab14
                Exit Select

            Case 15
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab15
                Exit Select

            Case 16
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab16
                Exit Select

            Case 17
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab17
                Exit Select

            Case 18
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab18
                Exit Select

            Case 19
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab19
                Exit Select

            Case 20
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab20
                Exit Select

            Case 21
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab21
                Exit Select

            Case 22
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab22
                Exit Select

            Case 23
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab23
                Exit Select

            Case 24
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab24
                Exit Select

            Case 25
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab25
                Exit Select

            Case 26
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab26
                Exit Select

            Case 27
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab27
                Exit Select

            Case 28
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab28
                Exit Select

            Case 29
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab29
                Exit Select

            Case 30
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab30
                Exit Select

            Case 31
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab31
                Exit Select

            Case 32
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab32
                Exit Select

            Case 33
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab33
                Exit Select

            Case 34
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab34
                Exit Select

            Case 35
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab35
                Exit Select

            Case 36
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab36
                Exit Select

            Case 37
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab37
                Exit Select

            Case 38
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab38
                Exit Select

            Case 39
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab39
                Exit Select

            Case 40
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab40
                Exit Select

            Case 41
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab41
                Exit Select

            Case 42
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab42
                Exit Select

            Case 43
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab43
                Exit Select

            Case 44
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab44
                Exit Select

            Case 45
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab45
                Exit Select

            Case 46
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab46
                Exit Select

            Case 47
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab47
                Exit Select

            Case 48
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab48
                Exit Select

            Case 49
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab49
                Exit Select

            Case 50
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab50
                Exit Select

            Case 51
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab51
                Exit Select

            Case 52
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab52
                Exit Select

            Case 53
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab53
                Exit Select

            Case 54
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab54
                Exit Select

            Case 55
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab55
                Exit Select

            Case 56
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab56
                Exit Select

            Case 57
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab57
                Exit Select

            Case 58
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab58
                Exit Select

            Case 59
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab59
                Exit Select

            Case 60
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab60
                Exit Select

            Case 61
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab61
                Exit Select

            Case 62
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab62
                Exit Select

            Case 63
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab63
                Exit Select

            Case 64
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab64
                Exit Select

            Case 65
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab65
                Exit Select

            Case 66
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab66
                Exit Select

            Case 67
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab67
                Exit Select

            Case 68
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab68
                Exit Select

            Case 69
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab69
                Exit Select

            Case 70
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab70
                Exit Select

            Case 71
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab71
                Exit Select

            Case 72
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab72
                Exit Select

            Case 73
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab73
                Exit Select

            Case 74
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab74
                Exit Select

            Case 75
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab75
                Exit Select

            Case 76
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab76
                Exit Select

            Case 77
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab77
                Exit Select

            Case 78
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab78
                Exit Select

            Case 79
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab79
                Exit Select

            Case 80
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab80
                Exit Select

            Case 81
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab81
                Exit Select

            Case 82
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab82
                Exit Select

            Case 83
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab83
                Exit Select

            Case 84
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab84
                Exit Select

            Case 85
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab85
                Exit Select

            Case 86
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab86
                Exit Select

            Case 87
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab87
                Exit Select

            Case 88
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab88
                Exit Select

            Case 89
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab89
                Exit Select

            Case 90
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab90
                Exit Select

            Case 91
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab91
                Exit Select

            Case 92
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab92
                Exit Select

            Case 93
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab93
                Exit Select

            Case 94
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab94
                Exit Select

            Case 95
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab95
                Exit Select

            Case 96
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab96
                Exit Select

            Case 97
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab97
                Exit Select

            Case 98
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab98
                Exit Select

            Case 99
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab99
                Exit Select

            Case 100
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab100
                Exit Select

            Case 101
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab101
                Exit Select

            Case 102
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab102
                Exit Select

            Case 103
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab103
                Exit Select

            Case 104
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab104
                Exit Select

            Case 105
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab105
                Exit Select

            Case 106
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab106
                Exit Select

            Case 107
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab107
                Exit Select

            Case 108
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab108
                Exit Select

            Case 109
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab109
                Exit Select

            Case 110
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab110
                Exit Select

            Case 111
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab111
                Exit Select

            Case 112
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab112
                Exit Select

            Case 113
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab113
                Exit Select

            Case 114
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab114
                Exit Select

            Case 115
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab115
                Exit Select

            Case 116
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab116
                Exit Select

            Case 117
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab117
                Exit Select

            Case 118
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab118
                Exit Select

            Case 119
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab119
                Exit Select

            Case 120
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab120
                Exit Select

            Case 121
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab121
                Exit Select

            Case 122
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab122
                Exit Select

            Case 123
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab123
                Exit Select

            Case 124
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab124
                Exit Select

            Case 125
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab125
                Exit Select

            Case 126
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab126
                Exit Select

            Case 127
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab127
                Exit Select

            Case 128
                FRM_NAVEGACAO.TabControl1.SelectedTab = tab128
                Exit Select






        End Select


    End Sub



    'Navegar

    Public Sub proc_navegar(ByVal V_URL As String, ByVal V_TIPO_DE_MOTOR As Boolean, ByVal V_NUMERO_DO_MOTOR As Integer) 'NAVEGA NO SITE SOLICITADO PELO USUARIO
        On Error Resume Next

        Dim V_HOST_DE_URL_INFORMADA As New Uri(V_URL) 'Informa o host da url informada






        'Verifica se o recurso de codigo malicioso está ativado -----------------------------------------------------------------------------------------------------------------------------

        If (V_VAL_CONFIG_PROTEGER_CONTRA_CODIGOS_MALICIOSOS = True) And (v_lista_de_codigos_que_nao_podem_ser_executados.Contains(V_URL) = True) Then


            proc_chamar_mensagem_ao_usuario(V_MS_24, v_tipo_ms_1) 'Mensagem ao usuário

            Exit Sub 'Saindo...


        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Verifica se obteve o host ----------------------------------------------------------------------------------------------------------------------------------------------------------

        If (V_HOST_DE_URL_INFORMADA.Scheme.Length > 0) Then


            proc_verificar_se_endereco_informado_esta_disponivel(V_URL) 'Informa se o endereço do site informado esta, ou não disponivel


        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------





        'Verificando o tipo do motor e abrindo site -----------------------------------------------------------------------------------------------------------------------------------------

        If (V_TIPO_DE_MOTOR = True) Then


            proc_abrir_site_motor_geckofx(V_URL, V_NUMERO_DO_MOTOR) 'Abre a página solicitada no Geckofx


        Else


            proc_abrir_site_motor_trident(V_URL, V_NUMERO_DO_MOTOR) 'Abre a página solicitada no trident


        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Exibe a barra de progresso ---------------------------------------------------------------------------------------------------------------------------------------------------------

        Proc_exibir_ou_ocultar_barra_de_progresso(True) 'Oculta ou exibe a barra de carregamento

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Focando a aba ----------------------------------------------------------------------------------------------------------------------------------------------------------------------

        proc_focar_aba_selecionada(V_NUMERO_DO_MOTOR) 'Foca a aba selecionada anteriormente

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Oculta a aba de historico autocompletar --------------------------------------------------------------------------------------------------------------------------------------------

        proc_ocultar_aba_de_historico_autocompletar(False) 'Habilita ou desabilita a aba de historico

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Motor de historico com página em branco --------------------------------------------------------------------------------------------------------------------------------------------

        FRM_NAVEGACAO.GECK_MOTOR_DE_AUTO_COMPLETAR_HIST.Navigate("about:blank") 'Navegar até pagina branca

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------












    End Sub




    'Página home

    Public Sub proc_abrir_pagina_inicial() 'Abre a página inicial agora
        On Error Resume Next


        proc_navegar(V_VAL_CONFIG_PAGINA_INICIAL, v_tipo_de_motor_layout_engine_em_uso_agora, v_qual_motor_esta_em_uso) 'NAVEGA NO SITE SOLICITADO PELO USUARIO


    End Sub

    Public Sub proc_abrir_pagina_inicial_ao_inicializar_navegador() 'Abre a página inicial ao inicializar o navegador
        On Error Resume Next

        Dim V_BACKUP_DE_PAGINA_INICIAL As String = V_VAL_CONFIG_PAGINA_INICIAL 'Backup da pagina inicial

        Dim V_BACKUP_MODO_ABRIR_PAGINA_INICIAL As String = V_VAL_CONFIG_PAGINA_INICIAL_EM_BRANCO_OU_HOME 'Backup de modo de abrir pagina inicial






        'Verificando se o navegador foi aberto, via comando externo ----------------------------------------------------

        If (V_VAL_ENDERECO_URL_RECEBIDO_VIA_COMANDO_EXTERNO <> Nothing) Then




            'Informando que encerrou a sessão corretamente -------------------------------------------------------------

            v_sessao_encerrou_corretamente = True 'Informando que encerrou a sessao corretamento

            '-----------------------------------------------------------------------------------------------------------




            'Setando novas configuraçoes temporarias ----------------------------------------------------------------------------------------------

            V_VAL_CONFIG_PAGINA_INICIAL = V_VAL_ENDERECO_URL_RECEBIDO_VIA_COMANDO_EXTERNO.Replace("""", Nothing) 'Abrir o comando externo

            V_VAL_CONFIG_PAGINA_INICIAL_EM_BRANCO_OU_HOME = True 'Informa que é para abrir a página inicial

            '--------------------------------------------------------------------------------------------------------------------------------------




        End If

        '---------------------------------------------------------------------------------------------------------------




        'Não permite abrir pagina em branco, ou pagina home se o navegador nao tiver encerrado corretamente --------------------------------------

        If (v_sessao_encerrou_corretamente = False) Then

            Exit Sub 'Saindo...

        End If

        '-----------------------------------------------------------------------------------------------------------------------------------------




        'Verifica se abre a página inicial ou não -------------------------------------------------------------------------------------------------------------------------------------------

        If (V_VAL_CONFIG_PAGINA_INICIAL_EM_BRANCO_OU_HOME = True) Then


            proc_navegar(V_VAL_CONFIG_PAGINA_INICIAL, v_tipo_de_motor_layout_engine_em_uso_agora, v_qual_motor_esta_em_uso) 'NAVEGA NO SITE SOLICITADO PELO USUARIO


        Else


            proc_navegar(V_PAGINA_EM_BRANCO_ABRIR, v_tipo_de_motor_layout_engine_em_uso_agora, v_qual_motor_esta_em_uso) 'NAVEGA NO SITE SOLICITADO PELO USUARIO


        End If

        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        'Restaurando configuração de backup --------------------------------------------------------------------------------

        V_VAL_CONFIG_PAGINA_INICIAL = V_BACKUP_DE_PAGINA_INICIAL 'Abrir o comando externo

        V_VAL_CONFIG_PAGINA_INICIAL_EM_BRANCO_OU_HOME = V_BACKUP_MODO_ABRIR_PAGINA_INICIAL 'Informa que é para abrir a página inicial

        '-------------------------------------------------------------------------------------------------------------------




    End Sub




    'Esquema voltar página

    Private Sub proc_voltar_geckofx() 'Voltar uma página geckofx
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso


            Case 1
                OBJ_MOTOR_GECKOFX_1.GoBack() 'Voltando uma página
                Exit Select
            Case 2
                OBJ_MOTOR_GECKOFX_2.GoBack() 'Voltando uma página
                Exit Select
            Case 3
                OBJ_MOTOR_GECKOFX_3.GoBack() 'Voltando uma página
                Exit Select
            Case 4
                OBJ_MOTOR_GECKOFX_4.GoBack() 'Voltando uma página
                Exit Select
            Case 5
                OBJ_MOTOR_GECKOFX_5.GoBack() 'Voltando uma página
                Exit Select
            Case 6
                OBJ_MOTOR_GECKOFX_6.GoBack() 'Voltando uma página
                Exit Select
            Case 7
                OBJ_MOTOR_GECKOFX_7.GoBack() 'Voltando uma página
                Exit Select
            Case 8
                OBJ_MOTOR_GECKOFX_8.GoBack() 'Voltando uma página
                Exit Select
            Case 9
                OBJ_MOTOR_GECKOFX_9.GoBack() 'Voltando uma página
                Exit Select
            Case 10
                OBJ_MOTOR_GECKOFX_10.GoBack() 'Voltando uma página
                Exit Select
            Case 11
                OBJ_MOTOR_GECKOFX_11.GoBack() 'Voltando uma página
                Exit Select
            Case 12
                OBJ_MOTOR_GECKOFX_12.GoBack() 'Voltando uma página
                Exit Select
            Case 13
                OBJ_MOTOR_GECKOFX_13.GoBack() 'Voltando uma página
                Exit Select
            Case 14
                OBJ_MOTOR_GECKOFX_14.GoBack() 'Voltando uma página
                Exit Select
            Case 15
                OBJ_MOTOR_GECKOFX_15.GoBack() 'Voltando uma página
                Exit Select
            Case 16
                OBJ_MOTOR_GECKOFX_16.GoBack() 'Voltando uma página
                Exit Select
            Case 17
                OBJ_MOTOR_GECKOFX_17.GoBack() 'Voltando uma página
                Exit Select
            Case 18
                OBJ_MOTOR_GECKOFX_18.GoBack() 'Voltando uma página
                Exit Select
            Case 19
                OBJ_MOTOR_GECKOFX_19.GoBack() 'Voltando uma página
                Exit Select
            Case 20
                OBJ_MOTOR_GECKOFX_20.GoBack() 'Voltando uma página
                Exit Select
            Case 21
                OBJ_MOTOR_GECKOFX_21.GoBack() 'Voltando uma página
                Exit Select
            Case 22
                OBJ_MOTOR_GECKOFX_22.GoBack() 'Voltando uma página
                Exit Select
            Case 23
                OBJ_MOTOR_GECKOFX_23.GoBack() 'Voltando uma página
                Exit Select
            Case 24
                OBJ_MOTOR_GECKOFX_24.GoBack() 'Voltando uma página
                Exit Select
            Case 25
                OBJ_MOTOR_GECKOFX_25.GoBack() 'Voltando uma página
                Exit Select
            Case 26
                OBJ_MOTOR_GECKOFX_26.GoBack() 'Voltando uma página
                Exit Select
            Case 27
                OBJ_MOTOR_GECKOFX_27.GoBack() 'Voltando uma página
                Exit Select
            Case 28
                OBJ_MOTOR_GECKOFX_28.GoBack() 'Voltando uma página
                Exit Select
            Case 29
                OBJ_MOTOR_GECKOFX_29.GoBack() 'Voltando uma página
                Exit Select
            Case 30
                OBJ_MOTOR_GECKOFX_30.GoBack() 'Voltando uma página
                Exit Select
            Case 31
                OBJ_MOTOR_GECKOFX_31.GoBack() 'Voltando uma página
                Exit Select
            Case 32
                OBJ_MOTOR_GECKOFX_32.GoBack() 'Voltando uma página
                Exit Select
            Case 33
                OBJ_MOTOR_GECKOFX_33.GoBack() 'Voltando uma página
                Exit Select
            Case 34
                OBJ_MOTOR_GECKOFX_34.GoBack() 'Voltando uma página
                Exit Select
            Case 35
                OBJ_MOTOR_GECKOFX_35.GoBack() 'Voltando uma página
                Exit Select
            Case 36
                OBJ_MOTOR_GECKOFX_36.GoBack() 'Voltando uma página
                Exit Select
            Case 37
                OBJ_MOTOR_GECKOFX_37.GoBack() 'Voltando uma página
                Exit Select
            Case 38
                OBJ_MOTOR_GECKOFX_38.GoBack() 'Voltando uma página
                Exit Select
            Case 39
                OBJ_MOTOR_GECKOFX_39.GoBack() 'Voltando uma página
                Exit Select
            Case 40
                OBJ_MOTOR_GECKOFX_40.GoBack() 'Voltando uma página
                Exit Select
            Case 41
                OBJ_MOTOR_GECKOFX_41.GoBack() 'Voltando uma página
                Exit Select
            Case 42
                OBJ_MOTOR_GECKOFX_42.GoBack() 'Voltando uma página
                Exit Select
            Case 43
                OBJ_MOTOR_GECKOFX_43.GoBack() 'Voltando uma página
                Exit Select
            Case 44
                OBJ_MOTOR_GECKOFX_44.GoBack() 'Voltando uma página
                Exit Select
            Case 45
                OBJ_MOTOR_GECKOFX_45.GoBack() 'Voltando uma página
                Exit Select
            Case 46
                OBJ_MOTOR_GECKOFX_46.GoBack() 'Voltando uma página
                Exit Select
            Case 47
                OBJ_MOTOR_GECKOFX_47.GoBack() 'Voltando uma página
                Exit Select
            Case 48
                OBJ_MOTOR_GECKOFX_48.GoBack() 'Voltando uma página
                Exit Select
            Case 49
                OBJ_MOTOR_GECKOFX_49.GoBack() 'Voltando uma página
                Exit Select
            Case 50
                OBJ_MOTOR_GECKOFX_50.GoBack() 'Voltando uma página
                Exit Select
            Case 51
                OBJ_MOTOR_GECKOFX_51.GoBack() 'Voltando uma página
                Exit Select
            Case 52
                OBJ_MOTOR_GECKOFX_52.GoBack() 'Voltando uma página
                Exit Select
            Case 53
                OBJ_MOTOR_GECKOFX_53.GoBack() 'Voltando uma página
                Exit Select
            Case 54
                OBJ_MOTOR_GECKOFX_54.GoBack() 'Voltando uma página
                Exit Select
            Case 55
                OBJ_MOTOR_GECKOFX_55.GoBack() 'Voltando uma página
                Exit Select
            Case 56
                OBJ_MOTOR_GECKOFX_56.GoBack() 'Voltando uma página
                Exit Select
            Case 57
                OBJ_MOTOR_GECKOFX_57.GoBack() 'Voltando uma página
                Exit Select
            Case 58
                OBJ_MOTOR_GECKOFX_58.GoBack() 'Voltando uma página
                Exit Select
            Case 59
                OBJ_MOTOR_GECKOFX_59.GoBack() 'Voltando uma página
                Exit Select
            Case 60
                OBJ_MOTOR_GECKOFX_60.GoBack() 'Voltando uma página
                Exit Select
            Case 61
                OBJ_MOTOR_GECKOFX_61.GoBack() 'Voltando uma página
                Exit Select
            Case 62
                OBJ_MOTOR_GECKOFX_62.GoBack() 'Voltando uma página
                Exit Select
            Case 63
                OBJ_MOTOR_GECKOFX_63.GoBack() 'Voltando uma página
                Exit Select
            Case 64
                OBJ_MOTOR_GECKOFX_64.GoBack() 'Voltando uma página
                Exit Select
            Case 65
                OBJ_MOTOR_GECKOFX_65.GoBack() 'Voltando uma página
                Exit Select
            Case 66
                OBJ_MOTOR_GECKOFX_66.GoBack() 'Voltando uma página
                Exit Select
            Case 67
                OBJ_MOTOR_GECKOFX_67.GoBack() 'Voltando uma página
                Exit Select
            Case 68
                OBJ_MOTOR_GECKOFX_68.GoBack() 'Voltando uma página
                Exit Select
            Case 69
                OBJ_MOTOR_GECKOFX_69.GoBack() 'Voltando uma página
                Exit Select
            Case 70
                OBJ_MOTOR_GECKOFX_70.GoBack() 'Voltando uma página
                Exit Select
            Case 71
                OBJ_MOTOR_GECKOFX_71.GoBack() 'Voltando uma página
                Exit Select
            Case 72
                OBJ_MOTOR_GECKOFX_72.GoBack() 'Voltando uma página
                Exit Select
            Case 73
                OBJ_MOTOR_GECKOFX_73.GoBack() 'Voltando uma página
                Exit Select
            Case 74
                OBJ_MOTOR_GECKOFX_74.GoBack() 'Voltando uma página
                Exit Select
            Case 75
                OBJ_MOTOR_GECKOFX_75.GoBack() 'Voltando uma página
                Exit Select
            Case 76
                OBJ_MOTOR_GECKOFX_76.GoBack() 'Voltando uma página
                Exit Select
            Case 77
                OBJ_MOTOR_GECKOFX_77.GoBack() 'Voltando uma página
                Exit Select
            Case 78
                OBJ_MOTOR_GECKOFX_78.GoBack() 'Voltando uma página
                Exit Select
            Case 79
                OBJ_MOTOR_GECKOFX_79.GoBack() 'Voltando uma página
                Exit Select
            Case 80
                OBJ_MOTOR_GECKOFX_80.GoBack() 'Voltando uma página
                Exit Select
            Case 81
                OBJ_MOTOR_GECKOFX_81.GoBack() 'Voltando uma página
                Exit Select
            Case 82
                OBJ_MOTOR_GECKOFX_82.GoBack() 'Voltando uma página
                Exit Select
            Case 83
                OBJ_MOTOR_GECKOFX_83.GoBack() 'Voltando uma página
                Exit Select
            Case 84
                OBJ_MOTOR_GECKOFX_84.GoBack() 'Voltando uma página
                Exit Select
            Case 85
                OBJ_MOTOR_GECKOFX_85.GoBack() 'Voltando uma página
                Exit Select
            Case 86
                OBJ_MOTOR_GECKOFX_86.GoBack() 'Voltando uma página
                Exit Select
            Case 87
                OBJ_MOTOR_GECKOFX_87.GoBack() 'Voltando uma página
                Exit Select
            Case 88
                OBJ_MOTOR_GECKOFX_88.GoBack() 'Voltando uma página
                Exit Select
            Case 89
                OBJ_MOTOR_GECKOFX_89.GoBack() 'Voltando uma página
                Exit Select
            Case 90
                OBJ_MOTOR_GECKOFX_90.GoBack() 'Voltando uma página
                Exit Select
            Case 91
                OBJ_MOTOR_GECKOFX_91.GoBack() 'Voltando uma página
                Exit Select
            Case 92
                OBJ_MOTOR_GECKOFX_92.GoBack() 'Voltando uma página
                Exit Select
            Case 93
                OBJ_MOTOR_GECKOFX_93.GoBack() 'Voltando uma página
                Exit Select
            Case 94
                OBJ_MOTOR_GECKOFX_94.GoBack() 'Voltando uma página
                Exit Select
            Case 95
                OBJ_MOTOR_GECKOFX_95.GoBack() 'Voltando uma página
                Exit Select
            Case 96
                OBJ_MOTOR_GECKOFX_96.GoBack() 'Voltando uma página
                Exit Select
            Case 97
                OBJ_MOTOR_GECKOFX_97.GoBack() 'Voltando uma página
                Exit Select
            Case 98
                OBJ_MOTOR_GECKOFX_98.GoBack() 'Voltando uma página
                Exit Select
            Case 99
                OBJ_MOTOR_GECKOFX_99.GoBack() 'Voltando uma página
                Exit Select
            Case 100
                OBJ_MOTOR_GECKOFX_100.GoBack() 'Voltando uma página
                Exit Select
            Case 101
                OBJ_MOTOR_GECKOFX_101.GoBack() 'Voltando uma página
                Exit Select
            Case 102
                OBJ_MOTOR_GECKOFX_102.GoBack() 'Voltando uma página
                Exit Select
            Case 103
                OBJ_MOTOR_GECKOFX_103.GoBack() 'Voltando uma página
                Exit Select
            Case 104
                OBJ_MOTOR_GECKOFX_104.GoBack() 'Voltando uma página
                Exit Select
            Case 105
                OBJ_MOTOR_GECKOFX_105.GoBack() 'Voltando uma página
                Exit Select
            Case 106
                OBJ_MOTOR_GECKOFX_106.GoBack() 'Voltando uma página
                Exit Select
            Case 107
                OBJ_MOTOR_GECKOFX_107.GoBack() 'Voltando uma página
                Exit Select
            Case 108
                OBJ_MOTOR_GECKOFX_108.GoBack() 'Voltando uma página
                Exit Select
            Case 109
                OBJ_MOTOR_GECKOFX_109.GoBack() 'Voltando uma página
                Exit Select
            Case 110
                OBJ_MOTOR_GECKOFX_110.GoBack() 'Voltando uma página
                Exit Select
            Case 111
                OBJ_MOTOR_GECKOFX_111.GoBack() 'Voltando uma página
                Exit Select
            Case 112
                OBJ_MOTOR_GECKOFX_112.GoBack() 'Voltando uma página
                Exit Select
            Case 113
                OBJ_MOTOR_GECKOFX_113.GoBack() 'Voltando uma página
                Exit Select
            Case 114
                OBJ_MOTOR_GECKOFX_114.GoBack() 'Voltando uma página
                Exit Select
            Case 115
                OBJ_MOTOR_GECKOFX_115.GoBack() 'Voltando uma página
                Exit Select
            Case 116
                OBJ_MOTOR_GECKOFX_116.GoBack() 'Voltando uma página
                Exit Select
            Case 117
                OBJ_MOTOR_GECKOFX_117.GoBack() 'Voltando uma página
                Exit Select
            Case 118
                OBJ_MOTOR_GECKOFX_118.GoBack() 'Voltando uma página
                Exit Select
            Case 119
                OBJ_MOTOR_GECKOFX_119.GoBack() 'Voltando uma página
                Exit Select
            Case 120
                OBJ_MOTOR_GECKOFX_120.GoBack() 'Voltando uma página
                Exit Select
            Case 121
                OBJ_MOTOR_GECKOFX_121.GoBack() 'Voltando uma página
                Exit Select
            Case 122
                OBJ_MOTOR_GECKOFX_122.GoBack() 'Voltando uma página
                Exit Select
            Case 123
                OBJ_MOTOR_GECKOFX_123.GoBack() 'Voltando uma página
                Exit Select
            Case 124
                OBJ_MOTOR_GECKOFX_124.GoBack() 'Voltando uma página
                Exit Select
            Case 125
                OBJ_MOTOR_GECKOFX_125.GoBack() 'Voltando uma página
                Exit Select
            Case 126
                OBJ_MOTOR_GECKOFX_126.GoBack() 'Voltando uma página
                Exit Select
            Case 127
                OBJ_MOTOR_GECKOFX_127.GoBack() 'Voltando uma página
                Exit Select
            Case 128
                OBJ_MOTOR_GECKOFX_128.GoBack() 'Voltando uma página
                Exit Select





        End Select


    End Sub

    Private Sub proc_voltar_trident() 'Voltar uma página trident
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso


            Case 1
                OBJ_MOTOR_WEB_BROWSER_1.GoBack() 'Voltando uma página
                Exit Select
            Case 2
                OBJ_MOTOR_WEB_BROWSER_2.GoBack() 'Voltando uma página
                Exit Select
            Case 3
                OBJ_MOTOR_WEB_BROWSER_3.GoBack() 'Voltando uma página
                Exit Select
            Case 4
                OBJ_MOTOR_WEB_BROWSER_4.GoBack() 'Voltando uma página
                Exit Select
            Case 5
                OBJ_MOTOR_WEB_BROWSER_5.GoBack() 'Voltando uma página
                Exit Select
            Case 6
                OBJ_MOTOR_WEB_BROWSER_6.GoBack() 'Voltando uma página
                Exit Select
            Case 7
                OBJ_MOTOR_WEB_BROWSER_7.GoBack() 'Voltando uma página
                Exit Select
            Case 8
                OBJ_MOTOR_WEB_BROWSER_8.GoBack() 'Voltando uma página
                Exit Select
            Case 9
                OBJ_MOTOR_WEB_BROWSER_9.GoBack() 'Voltando uma página
                Exit Select
            Case 10
                OBJ_MOTOR_WEB_BROWSER_10.GoBack() 'Voltando uma página
                Exit Select
            Case 11
                OBJ_MOTOR_WEB_BROWSER_11.GoBack() 'Voltando uma página
                Exit Select
            Case 12
                OBJ_MOTOR_WEB_BROWSER_12.GoBack() 'Voltando uma página
                Exit Select
            Case 13
                OBJ_MOTOR_WEB_BROWSER_13.GoBack() 'Voltando uma página
                Exit Select
            Case 14
                OBJ_MOTOR_WEB_BROWSER_14.GoBack() 'Voltando uma página
                Exit Select
            Case 15
                OBJ_MOTOR_WEB_BROWSER_15.GoBack() 'Voltando uma página
                Exit Select
            Case 16
                OBJ_MOTOR_WEB_BROWSER_16.GoBack() 'Voltando uma página
                Exit Select
            Case 17
                OBJ_MOTOR_WEB_BROWSER_17.GoBack() 'Voltando uma página
                Exit Select
            Case 18
                OBJ_MOTOR_WEB_BROWSER_18.GoBack() 'Voltando uma página
                Exit Select
            Case 19
                OBJ_MOTOR_WEB_BROWSER_19.GoBack() 'Voltando uma página
                Exit Select
            Case 20
                OBJ_MOTOR_WEB_BROWSER_20.GoBack() 'Voltando uma página
                Exit Select
            Case 21
                OBJ_MOTOR_WEB_BROWSER_21.GoBack() 'Voltando uma página
                Exit Select
            Case 22
                OBJ_MOTOR_WEB_BROWSER_22.GoBack() 'Voltando uma página
                Exit Select
            Case 23
                OBJ_MOTOR_WEB_BROWSER_23.GoBack() 'Voltando uma página
                Exit Select
            Case 24
                OBJ_MOTOR_WEB_BROWSER_24.GoBack() 'Voltando uma página
                Exit Select
            Case 25
                OBJ_MOTOR_WEB_BROWSER_25.GoBack() 'Voltando uma página
                Exit Select
            Case 26
                OBJ_MOTOR_WEB_BROWSER_26.GoBack() 'Voltando uma página
                Exit Select
            Case 27
                OBJ_MOTOR_WEB_BROWSER_27.GoBack() 'Voltando uma página
                Exit Select
            Case 28
                OBJ_MOTOR_WEB_BROWSER_28.GoBack() 'Voltando uma página
                Exit Select
            Case 29
                OBJ_MOTOR_WEB_BROWSER_29.GoBack() 'Voltando uma página
                Exit Select
            Case 30
                OBJ_MOTOR_WEB_BROWSER_30.GoBack() 'Voltando uma página
                Exit Select
            Case 31
                OBJ_MOTOR_WEB_BROWSER_31.GoBack() 'Voltando uma página
                Exit Select
            Case 32
                OBJ_MOTOR_WEB_BROWSER_32.GoBack() 'Voltando uma página
                Exit Select
            Case 33
                OBJ_MOTOR_WEB_BROWSER_33.GoBack() 'Voltando uma página
                Exit Select
            Case 34
                OBJ_MOTOR_WEB_BROWSER_34.GoBack() 'Voltando uma página
                Exit Select
            Case 35
                OBJ_MOTOR_WEB_BROWSER_35.GoBack() 'Voltando uma página
                Exit Select
            Case 36
                OBJ_MOTOR_WEB_BROWSER_36.GoBack() 'Voltando uma página
                Exit Select
            Case 37
                OBJ_MOTOR_WEB_BROWSER_37.GoBack() 'Voltando uma página
                Exit Select
            Case 38
                OBJ_MOTOR_WEB_BROWSER_38.GoBack() 'Voltando uma página
                Exit Select
            Case 39
                OBJ_MOTOR_WEB_BROWSER_39.GoBack() 'Voltando uma página
                Exit Select
            Case 40
                OBJ_MOTOR_WEB_BROWSER_40.GoBack() 'Voltando uma página
                Exit Select
            Case 41
                OBJ_MOTOR_WEB_BROWSER_41.GoBack() 'Voltando uma página
                Exit Select
            Case 42
                OBJ_MOTOR_WEB_BROWSER_42.GoBack() 'Voltando uma página
                Exit Select
            Case 43
                OBJ_MOTOR_WEB_BROWSER_43.GoBack() 'Voltando uma página
                Exit Select
            Case 44
                OBJ_MOTOR_WEB_BROWSER_44.GoBack() 'Voltando uma página
                Exit Select
            Case 45
                OBJ_MOTOR_WEB_BROWSER_45.GoBack() 'Voltando uma página
                Exit Select
            Case 46
                OBJ_MOTOR_WEB_BROWSER_46.GoBack() 'Voltando uma página
                Exit Select
            Case 47
                OBJ_MOTOR_WEB_BROWSER_47.GoBack() 'Voltando uma página
                Exit Select
            Case 48
                OBJ_MOTOR_WEB_BROWSER_48.GoBack() 'Voltando uma página
                Exit Select
            Case 49
                OBJ_MOTOR_WEB_BROWSER_49.GoBack() 'Voltando uma página
                Exit Select
            Case 50
                OBJ_MOTOR_WEB_BROWSER_50.GoBack() 'Voltando uma página
                Exit Select
            Case 51
                OBJ_MOTOR_WEB_BROWSER_51.GoBack() 'Voltando uma página
                Exit Select
            Case 52
                OBJ_MOTOR_WEB_BROWSER_52.GoBack() 'Voltando uma página
                Exit Select
            Case 53
                OBJ_MOTOR_WEB_BROWSER_53.GoBack() 'Voltando uma página
                Exit Select
            Case 54
                OBJ_MOTOR_WEB_BROWSER_54.GoBack() 'Voltando uma página
                Exit Select
            Case 55
                OBJ_MOTOR_WEB_BROWSER_55.GoBack() 'Voltando uma página
                Exit Select
            Case 56
                OBJ_MOTOR_WEB_BROWSER_56.GoBack() 'Voltando uma página
                Exit Select
            Case 57
                OBJ_MOTOR_WEB_BROWSER_57.GoBack() 'Voltando uma página
                Exit Select
            Case 58
                OBJ_MOTOR_WEB_BROWSER_58.GoBack() 'Voltando uma página
                Exit Select
            Case 59
                OBJ_MOTOR_WEB_BROWSER_59.GoBack() 'Voltando uma página
                Exit Select
            Case 60
                OBJ_MOTOR_WEB_BROWSER_60.GoBack() 'Voltando uma página
                Exit Select
            Case 61
                OBJ_MOTOR_WEB_BROWSER_61.GoBack() 'Voltando uma página
                Exit Select
            Case 62
                OBJ_MOTOR_WEB_BROWSER_62.GoBack() 'Voltando uma página
                Exit Select
            Case 63
                OBJ_MOTOR_WEB_BROWSER_63.GoBack() 'Voltando uma página
                Exit Select
            Case 64
                OBJ_MOTOR_WEB_BROWSER_64.GoBack() 'Voltando uma página
                Exit Select
            Case 65
                OBJ_MOTOR_WEB_BROWSER_65.GoBack() 'Voltando uma página
                Exit Select
            Case 66
                OBJ_MOTOR_WEB_BROWSER_66.GoBack() 'Voltando uma página
                Exit Select
            Case 67
                OBJ_MOTOR_WEB_BROWSER_67.GoBack() 'Voltando uma página
                Exit Select
            Case 68
                OBJ_MOTOR_WEB_BROWSER_68.GoBack() 'Voltando uma página
                Exit Select
            Case 69
                OBJ_MOTOR_WEB_BROWSER_69.GoBack() 'Voltando uma página
                Exit Select
            Case 70
                OBJ_MOTOR_WEB_BROWSER_70.GoBack() 'Voltando uma página
                Exit Select
            Case 71
                OBJ_MOTOR_WEB_BROWSER_71.GoBack() 'Voltando uma página
                Exit Select
            Case 72
                OBJ_MOTOR_WEB_BROWSER_72.GoBack() 'Voltando uma página
                Exit Select
            Case 73
                OBJ_MOTOR_WEB_BROWSER_73.GoBack() 'Voltando uma página
                Exit Select
            Case 74
                OBJ_MOTOR_WEB_BROWSER_74.GoBack() 'Voltando uma página
                Exit Select
            Case 75
                OBJ_MOTOR_WEB_BROWSER_75.GoBack() 'Voltando uma página
                Exit Select
            Case 76
                OBJ_MOTOR_WEB_BROWSER_76.GoBack() 'Voltando uma página
                Exit Select
            Case 77
                OBJ_MOTOR_WEB_BROWSER_77.GoBack() 'Voltando uma página
                Exit Select
            Case 78
                OBJ_MOTOR_WEB_BROWSER_78.GoBack() 'Voltando uma página
                Exit Select
            Case 79
                OBJ_MOTOR_WEB_BROWSER_79.GoBack() 'Voltando uma página
                Exit Select
            Case 80
                OBJ_MOTOR_WEB_BROWSER_80.GoBack() 'Voltando uma página
                Exit Select
            Case 81
                OBJ_MOTOR_WEB_BROWSER_81.GoBack() 'Voltando uma página
                Exit Select
            Case 82
                OBJ_MOTOR_WEB_BROWSER_82.GoBack() 'Voltando uma página
                Exit Select
            Case 83
                OBJ_MOTOR_WEB_BROWSER_83.GoBack() 'Voltando uma página
                Exit Select
            Case 84
                OBJ_MOTOR_WEB_BROWSER_84.GoBack() 'Voltando uma página
                Exit Select
            Case 85
                OBJ_MOTOR_WEB_BROWSER_85.GoBack() 'Voltando uma página
                Exit Select
            Case 86
                OBJ_MOTOR_WEB_BROWSER_86.GoBack() 'Voltando uma página
                Exit Select
            Case 87
                OBJ_MOTOR_WEB_BROWSER_87.GoBack() 'Voltando uma página
                Exit Select
            Case 88
                OBJ_MOTOR_WEB_BROWSER_88.GoBack() 'Voltando uma página
                Exit Select
            Case 89
                OBJ_MOTOR_WEB_BROWSER_89.GoBack() 'Voltando uma página
                Exit Select
            Case 90
                OBJ_MOTOR_WEB_BROWSER_90.GoBack() 'Voltando uma página
                Exit Select
            Case 91
                OBJ_MOTOR_WEB_BROWSER_91.GoBack() 'Voltando uma página
                Exit Select
            Case 92
                OBJ_MOTOR_WEB_BROWSER_92.GoBack() 'Voltando uma página
                Exit Select
            Case 93
                OBJ_MOTOR_WEB_BROWSER_93.GoBack() 'Voltando uma página
                Exit Select
            Case 94
                OBJ_MOTOR_WEB_BROWSER_94.GoBack() 'Voltando uma página
                Exit Select
            Case 95
                OBJ_MOTOR_WEB_BROWSER_95.GoBack() 'Voltando uma página
                Exit Select
            Case 96
                OBJ_MOTOR_WEB_BROWSER_96.GoBack() 'Voltando uma página
                Exit Select
            Case 97
                OBJ_MOTOR_WEB_BROWSER_97.GoBack() 'Voltando uma página
                Exit Select
            Case 98
                OBJ_MOTOR_WEB_BROWSER_98.GoBack() 'Voltando uma página
                Exit Select
            Case 99
                OBJ_MOTOR_WEB_BROWSER_99.GoBack() 'Voltando uma página
                Exit Select
            Case 100
                OBJ_MOTOR_WEB_BROWSER_100.GoBack() 'Voltando uma página
                Exit Select
            Case 101
                OBJ_MOTOR_WEB_BROWSER_101.GoBack() 'Voltando uma página
                Exit Select
            Case 102
                OBJ_MOTOR_WEB_BROWSER_102.GoBack() 'Voltando uma página
                Exit Select
            Case 103
                OBJ_MOTOR_WEB_BROWSER_103.GoBack() 'Voltando uma página
                Exit Select
            Case 104
                OBJ_MOTOR_WEB_BROWSER_104.GoBack() 'Voltando uma página
                Exit Select
            Case 105
                OBJ_MOTOR_WEB_BROWSER_105.GoBack() 'Voltando uma página
                Exit Select
            Case 106
                OBJ_MOTOR_WEB_BROWSER_106.GoBack() 'Voltando uma página
                Exit Select
            Case 107
                OBJ_MOTOR_WEB_BROWSER_107.GoBack() 'Voltando uma página
                Exit Select
            Case 108
                OBJ_MOTOR_WEB_BROWSER_108.GoBack() 'Voltando uma página
                Exit Select
            Case 109
                OBJ_MOTOR_WEB_BROWSER_109.GoBack() 'Voltando uma página
                Exit Select
            Case 110
                OBJ_MOTOR_WEB_BROWSER_110.GoBack() 'Voltando uma página
                Exit Select
            Case 111
                OBJ_MOTOR_WEB_BROWSER_111.GoBack() 'Voltando uma página
                Exit Select
            Case 112
                OBJ_MOTOR_WEB_BROWSER_112.GoBack() 'Voltando uma página
                Exit Select
            Case 113
                OBJ_MOTOR_WEB_BROWSER_113.GoBack() 'Voltando uma página
                Exit Select
            Case 114
                OBJ_MOTOR_WEB_BROWSER_114.GoBack() 'Voltando uma página
                Exit Select
            Case 115
                OBJ_MOTOR_WEB_BROWSER_115.GoBack() 'Voltando uma página
                Exit Select
            Case 116
                OBJ_MOTOR_WEB_BROWSER_116.GoBack() 'Voltando uma página
                Exit Select
            Case 117
                OBJ_MOTOR_WEB_BROWSER_117.GoBack() 'Voltando uma página
                Exit Select
            Case 118
                OBJ_MOTOR_WEB_BROWSER_118.GoBack() 'Voltando uma página
                Exit Select
            Case 119
                OBJ_MOTOR_WEB_BROWSER_119.GoBack() 'Voltando uma página
                Exit Select
            Case 120
                OBJ_MOTOR_WEB_BROWSER_120.GoBack() 'Voltando uma página
                Exit Select
            Case 121
                OBJ_MOTOR_WEB_BROWSER_121.GoBack() 'Voltando uma página
                Exit Select
            Case 122
                OBJ_MOTOR_WEB_BROWSER_122.GoBack() 'Voltando uma página
                Exit Select
            Case 123
                OBJ_MOTOR_WEB_BROWSER_123.GoBack() 'Voltando uma página
                Exit Select
            Case 124
                OBJ_MOTOR_WEB_BROWSER_124.GoBack() 'Voltando uma página
                Exit Select
            Case 125
                OBJ_MOTOR_WEB_BROWSER_125.GoBack() 'Voltando uma página
                Exit Select
            Case 126
                OBJ_MOTOR_WEB_BROWSER_126.GoBack() 'Voltando uma página
                Exit Select
            Case 127
                OBJ_MOTOR_WEB_BROWSER_127.GoBack() 'Voltando uma página
                Exit Select
            Case 128
                OBJ_MOTOR_WEB_BROWSER_128.GoBack() 'Voltando uma página
                Exit Select





        End Select


    End Sub

    Public Sub proc_voltar_pagina_anterior() 'Volta uma pagina anterior
        On Error Resume Next


        'Selecionando o tipo de motor ----------------------------------------------------------------------------------

        If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then


            proc_voltar_geckofx() 'Voltar uma página geckofx


        Else


            proc_voltar_trident() 'Voltar uma página trident


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub




    'Esquema de avançar página

    Private Sub proc_avancar_geckofx() 'Avançar uma página geckofx
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso


            Case 1
                OBJ_MOTOR_GECKOFX_1.GoForward() 'Avançando uma página
                Exit Select
            Case 2
                OBJ_MOTOR_GECKOFX_2.GoForward() 'Avançando uma página
                Exit Select
            Case 3
                OBJ_MOTOR_GECKOFX_3.GoForward() 'Avançando uma página
                Exit Select
            Case 4
                OBJ_MOTOR_GECKOFX_4.GoForward() 'Avançando uma página
                Exit Select
            Case 5
                OBJ_MOTOR_GECKOFX_5.GoForward() 'Avançando uma página
                Exit Select
            Case 6
                OBJ_MOTOR_GECKOFX_6.GoForward() 'Avançando uma página
                Exit Select
            Case 7
                OBJ_MOTOR_GECKOFX_7.GoForward() 'Avançando uma página
                Exit Select
            Case 8
                OBJ_MOTOR_GECKOFX_8.GoForward() 'Avançando uma página
                Exit Select
            Case 9
                OBJ_MOTOR_GECKOFX_9.GoForward() 'Avançando uma página
                Exit Select
            Case 10
                OBJ_MOTOR_GECKOFX_10.GoForward() 'Avançando uma página
                Exit Select
            Case 11
                OBJ_MOTOR_GECKOFX_11.GoForward() 'Avançando uma página
                Exit Select
            Case 12
                OBJ_MOTOR_GECKOFX_12.GoForward() 'Avançando uma página
                Exit Select
            Case 13
                OBJ_MOTOR_GECKOFX_13.GoForward() 'Avançando uma página
                Exit Select
            Case 14
                OBJ_MOTOR_GECKOFX_14.GoForward() 'Avançando uma página
                Exit Select
            Case 15
                OBJ_MOTOR_GECKOFX_15.GoForward() 'Avançando uma página
                Exit Select
            Case 16
                OBJ_MOTOR_GECKOFX_16.GoForward() 'Avançando uma página
                Exit Select
            Case 17
                OBJ_MOTOR_GECKOFX_17.GoForward() 'Avançando uma página
                Exit Select
            Case 18
                OBJ_MOTOR_GECKOFX_18.GoForward() 'Avançando uma página
                Exit Select
            Case 19
                OBJ_MOTOR_GECKOFX_19.GoForward() 'Avançando uma página
                Exit Select
            Case 20
                OBJ_MOTOR_GECKOFX_20.GoForward() 'Avançando uma página
                Exit Select
            Case 21
                OBJ_MOTOR_GECKOFX_21.GoForward() 'Avançando uma página
                Exit Select
            Case 22
                OBJ_MOTOR_GECKOFX_22.GoForward() 'Avançando uma página
                Exit Select
            Case 23
                OBJ_MOTOR_GECKOFX_23.GoForward() 'Avançando uma página
                Exit Select
            Case 24
                OBJ_MOTOR_GECKOFX_24.GoForward() 'Avançando uma página
                Exit Select
            Case 25
                OBJ_MOTOR_GECKOFX_25.GoForward() 'Avançando uma página
                Exit Select
            Case 26
                OBJ_MOTOR_GECKOFX_26.GoForward() 'Avançando uma página
                Exit Select
            Case 27
                OBJ_MOTOR_GECKOFX_27.GoForward() 'Avançando uma página
                Exit Select
            Case 28
                OBJ_MOTOR_GECKOFX_28.GoForward() 'Avançando uma página
                Exit Select
            Case 29
                OBJ_MOTOR_GECKOFX_29.GoForward() 'Avançando uma página
                Exit Select
            Case 30
                OBJ_MOTOR_GECKOFX_30.GoForward() 'Avançando uma página
                Exit Select
            Case 31
                OBJ_MOTOR_GECKOFX_31.GoForward() 'Avançando uma página
                Exit Select
            Case 32
                OBJ_MOTOR_GECKOFX_32.GoForward() 'Avançando uma página
                Exit Select
            Case 33
                OBJ_MOTOR_GECKOFX_33.GoForward() 'Avançando uma página
                Exit Select
            Case 34
                OBJ_MOTOR_GECKOFX_34.GoForward() 'Avançando uma página
                Exit Select
            Case 35
                OBJ_MOTOR_GECKOFX_35.GoForward() 'Avançando uma página
                Exit Select
            Case 36
                OBJ_MOTOR_GECKOFX_36.GoForward() 'Avançando uma página
                Exit Select
            Case 37
                OBJ_MOTOR_GECKOFX_37.GoForward() 'Avançando uma página
                Exit Select
            Case 38
                OBJ_MOTOR_GECKOFX_38.GoForward() 'Avançando uma página
                Exit Select
            Case 39
                OBJ_MOTOR_GECKOFX_39.GoForward() 'Avançando uma página
                Exit Select
            Case 40
                OBJ_MOTOR_GECKOFX_40.GoForward() 'Avançando uma página
                Exit Select
            Case 41
                OBJ_MOTOR_GECKOFX_41.GoForward() 'Avançando uma página
                Exit Select
            Case 42
                OBJ_MOTOR_GECKOFX_42.GoForward() 'Avançando uma página
                Exit Select
            Case 43
                OBJ_MOTOR_GECKOFX_43.GoForward() 'Avançando uma página
                Exit Select
            Case 44
                OBJ_MOTOR_GECKOFX_44.GoForward() 'Avançando uma página
                Exit Select
            Case 45
                OBJ_MOTOR_GECKOFX_45.GoForward() 'Avançando uma página
                Exit Select
            Case 46
                OBJ_MOTOR_GECKOFX_46.GoForward() 'Avançando uma página
                Exit Select
            Case 47
                OBJ_MOTOR_GECKOFX_47.GoForward() 'Avançando uma página
                Exit Select
            Case 48
                OBJ_MOTOR_GECKOFX_48.GoForward() 'Avançando uma página
                Exit Select
            Case 49
                OBJ_MOTOR_GECKOFX_49.GoForward() 'Avançando uma página
                Exit Select
            Case 50
                OBJ_MOTOR_GECKOFX_50.GoForward() 'Avançando uma página
                Exit Select
            Case 51
                OBJ_MOTOR_GECKOFX_51.GoForward() 'Avançando uma página
                Exit Select
            Case 52
                OBJ_MOTOR_GECKOFX_52.GoForward() 'Avançando uma página
                Exit Select
            Case 53
                OBJ_MOTOR_GECKOFX_53.GoForward() 'Avançando uma página
                Exit Select
            Case 54
                OBJ_MOTOR_GECKOFX_54.GoForward() 'Avançando uma página
                Exit Select
            Case 55
                OBJ_MOTOR_GECKOFX_55.GoForward() 'Avançando uma página
                Exit Select
            Case 56
                OBJ_MOTOR_GECKOFX_56.GoForward() 'Avançando uma página
                Exit Select
            Case 57
                OBJ_MOTOR_GECKOFX_57.GoForward() 'Avançando uma página
                Exit Select
            Case 58
                OBJ_MOTOR_GECKOFX_58.GoForward() 'Avançando uma página
                Exit Select
            Case 59
                OBJ_MOTOR_GECKOFX_59.GoForward() 'Avançando uma página
                Exit Select
            Case 60
                OBJ_MOTOR_GECKOFX_60.GoForward() 'Avançando uma página
                Exit Select
            Case 61
                OBJ_MOTOR_GECKOFX_61.GoForward() 'Avançando uma página
                Exit Select
            Case 62
                OBJ_MOTOR_GECKOFX_62.GoForward() 'Avançando uma página
                Exit Select
            Case 63
                OBJ_MOTOR_GECKOFX_63.GoForward() 'Avançando uma página
                Exit Select
            Case 64
                OBJ_MOTOR_GECKOFX_64.GoForward() 'Avançando uma página
                Exit Select
            Case 65
                OBJ_MOTOR_GECKOFX_65.GoForward() 'Avançando uma página
                Exit Select
            Case 66
                OBJ_MOTOR_GECKOFX_66.GoForward() 'Avançando uma página
                Exit Select
            Case 67
                OBJ_MOTOR_GECKOFX_67.GoForward() 'Avançando uma página
                Exit Select
            Case 68
                OBJ_MOTOR_GECKOFX_68.GoForward() 'Avançando uma página
                Exit Select
            Case 69
                OBJ_MOTOR_GECKOFX_69.GoForward() 'Avançando uma página
                Exit Select
            Case 70
                OBJ_MOTOR_GECKOFX_70.GoForward() 'Avançando uma página
                Exit Select
            Case 71
                OBJ_MOTOR_GECKOFX_71.GoForward() 'Avançando uma página
                Exit Select
            Case 72
                OBJ_MOTOR_GECKOFX_72.GoForward() 'Avançando uma página
                Exit Select
            Case 73
                OBJ_MOTOR_GECKOFX_73.GoForward() 'Avançando uma página
                Exit Select
            Case 74
                OBJ_MOTOR_GECKOFX_74.GoForward() 'Avançando uma página
                Exit Select
            Case 75
                OBJ_MOTOR_GECKOFX_75.GoForward() 'Avançando uma página
                Exit Select
            Case 76
                OBJ_MOTOR_GECKOFX_76.GoForward() 'Avançando uma página
                Exit Select
            Case 77
                OBJ_MOTOR_GECKOFX_77.GoForward() 'Avançando uma página
                Exit Select
            Case 78
                OBJ_MOTOR_GECKOFX_78.GoForward() 'Avançando uma página
                Exit Select
            Case 79
                OBJ_MOTOR_GECKOFX_79.GoForward() 'Avançando uma página
                Exit Select
            Case 80
                OBJ_MOTOR_GECKOFX_80.GoForward() 'Avançando uma página
                Exit Select
            Case 81
                OBJ_MOTOR_GECKOFX_81.GoForward() 'Avançando uma página
                Exit Select
            Case 82
                OBJ_MOTOR_GECKOFX_82.GoForward() 'Avançando uma página
                Exit Select
            Case 83
                OBJ_MOTOR_GECKOFX_83.GoForward() 'Avançando uma página
                Exit Select
            Case 84
                OBJ_MOTOR_GECKOFX_84.GoForward() 'Avançando uma página
                Exit Select
            Case 85
                OBJ_MOTOR_GECKOFX_85.GoForward() 'Avançando uma página
                Exit Select
            Case 86
                OBJ_MOTOR_GECKOFX_86.GoForward() 'Avançando uma página
                Exit Select
            Case 87
                OBJ_MOTOR_GECKOFX_87.GoForward() 'Avançando uma página
                Exit Select
            Case 88
                OBJ_MOTOR_GECKOFX_88.GoForward() 'Avançando uma página
                Exit Select
            Case 89
                OBJ_MOTOR_GECKOFX_89.GoForward() 'Avançando uma página
                Exit Select
            Case 90
                OBJ_MOTOR_GECKOFX_90.GoForward() 'Avançando uma página
                Exit Select
            Case 91
                OBJ_MOTOR_GECKOFX_91.GoForward() 'Avançando uma página
                Exit Select
            Case 92
                OBJ_MOTOR_GECKOFX_92.GoForward() 'Avançando uma página
                Exit Select
            Case 93
                OBJ_MOTOR_GECKOFX_93.GoForward() 'Avançando uma página
                Exit Select
            Case 94
                OBJ_MOTOR_GECKOFX_94.GoForward() 'Avançando uma página
                Exit Select
            Case 95
                OBJ_MOTOR_GECKOFX_95.GoForward() 'Avançando uma página
                Exit Select
            Case 96
                OBJ_MOTOR_GECKOFX_96.GoForward() 'Avançando uma página
                Exit Select
            Case 97
                OBJ_MOTOR_GECKOFX_97.GoForward() 'Avançando uma página
                Exit Select
            Case 98
                OBJ_MOTOR_GECKOFX_98.GoForward() 'Avançando uma página
                Exit Select
            Case 99
                OBJ_MOTOR_GECKOFX_99.GoForward() 'Avançando uma página
                Exit Select
            Case 100
                OBJ_MOTOR_GECKOFX_100.GoForward() 'Avançando uma página
                Exit Select
            Case 101
                OBJ_MOTOR_GECKOFX_101.GoForward() 'Avançando uma página
                Exit Select
            Case 102
                OBJ_MOTOR_GECKOFX_102.GoForward() 'Avançando uma página
                Exit Select
            Case 103
                OBJ_MOTOR_GECKOFX_103.GoForward() 'Avançando uma página
                Exit Select
            Case 104
                OBJ_MOTOR_GECKOFX_104.GoForward() 'Avançando uma página
                Exit Select
            Case 105
                OBJ_MOTOR_GECKOFX_105.GoForward() 'Avançando uma página
                Exit Select
            Case 106
                OBJ_MOTOR_GECKOFX_106.GoForward() 'Avançando uma página
                Exit Select
            Case 107
                OBJ_MOTOR_GECKOFX_107.GoForward() 'Avançando uma página
                Exit Select
            Case 108
                OBJ_MOTOR_GECKOFX_108.GoForward() 'Avançando uma página
                Exit Select
            Case 109
                OBJ_MOTOR_GECKOFX_109.GoForward() 'Avançando uma página
                Exit Select
            Case 110
                OBJ_MOTOR_GECKOFX_110.GoForward() 'Avançando uma página
                Exit Select
            Case 111
                OBJ_MOTOR_GECKOFX_111.GoForward() 'Avançando uma página
                Exit Select
            Case 112
                OBJ_MOTOR_GECKOFX_112.GoForward() 'Avançando uma página
                Exit Select
            Case 113
                OBJ_MOTOR_GECKOFX_113.GoForward() 'Avançando uma página
                Exit Select
            Case 114
                OBJ_MOTOR_GECKOFX_114.GoForward() 'Avançando uma página
                Exit Select
            Case 115
                OBJ_MOTOR_GECKOFX_115.GoForward() 'Avançando uma página
                Exit Select
            Case 116
                OBJ_MOTOR_GECKOFX_116.GoForward() 'Avançando uma página
                Exit Select
            Case 117
                OBJ_MOTOR_GECKOFX_117.GoForward() 'Avançando uma página
                Exit Select
            Case 118
                OBJ_MOTOR_GECKOFX_118.GoForward() 'Avançando uma página
                Exit Select
            Case 119
                OBJ_MOTOR_GECKOFX_119.GoForward() 'Avançando uma página
                Exit Select
            Case 120
                OBJ_MOTOR_GECKOFX_120.GoForward() 'Avançando uma página
                Exit Select
            Case 121
                OBJ_MOTOR_GECKOFX_121.GoForward() 'Avançando uma página
                Exit Select
            Case 122
                OBJ_MOTOR_GECKOFX_122.GoForward() 'Avançando uma página
                Exit Select
            Case 123
                OBJ_MOTOR_GECKOFX_123.GoForward() 'Avançando uma página
                Exit Select
            Case 124
                OBJ_MOTOR_GECKOFX_124.GoForward() 'Avançando uma página
                Exit Select
            Case 125
                OBJ_MOTOR_GECKOFX_125.GoForward() 'Avançando uma página
                Exit Select
            Case 126
                OBJ_MOTOR_GECKOFX_126.GoForward() 'Avançando uma página
                Exit Select
            Case 127
                OBJ_MOTOR_GECKOFX_127.GoForward() 'Avançando uma página
                Exit Select
            Case 128
                OBJ_MOTOR_GECKOFX_128.GoForward() 'Avançando uma página
                Exit Select




        End Select


    End Sub

    Private Sub proc_avancar_trident() 'Avançar uma página trident
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso


            Case 1
                OBJ_MOTOR_WEB_BROWSER_1.GoForward() 'Avançando uma página
                Exit Select
            Case 2
                OBJ_MOTOR_WEB_BROWSER_2.GoForward() 'Avançando uma página
                Exit Select
            Case 3
                OBJ_MOTOR_WEB_BROWSER_3.GoForward() 'Avançando uma página
                Exit Select
            Case 4
                OBJ_MOTOR_WEB_BROWSER_4.GoForward() 'Avançando uma página
                Exit Select
            Case 5
                OBJ_MOTOR_WEB_BROWSER_5.GoForward() 'Avançando uma página
                Exit Select
            Case 6
                OBJ_MOTOR_WEB_BROWSER_6.GoForward() 'Avançando uma página
                Exit Select
            Case 7
                OBJ_MOTOR_WEB_BROWSER_7.GoForward() 'Avançando uma página
                Exit Select
            Case 8
                OBJ_MOTOR_WEB_BROWSER_8.GoForward() 'Avançando uma página
                Exit Select
            Case 9
                OBJ_MOTOR_WEB_BROWSER_9.GoForward() 'Avançando uma página
                Exit Select
            Case 10
                OBJ_MOTOR_WEB_BROWSER_10.GoForward() 'Avançando uma página
                Exit Select
            Case 11
                OBJ_MOTOR_WEB_BROWSER_11.GoForward() 'Avançando uma página
                Exit Select
            Case 12
                OBJ_MOTOR_WEB_BROWSER_12.GoForward() 'Avançando uma página
                Exit Select
            Case 13
                OBJ_MOTOR_WEB_BROWSER_13.GoForward() 'Avançando uma página
                Exit Select
            Case 14
                OBJ_MOTOR_WEB_BROWSER_14.GoForward() 'Avançando uma página
                Exit Select
            Case 15
                OBJ_MOTOR_WEB_BROWSER_15.GoForward() 'Avançando uma página
                Exit Select
            Case 16
                OBJ_MOTOR_WEB_BROWSER_16.GoForward() 'Avançando uma página
                Exit Select
            Case 17
                OBJ_MOTOR_WEB_BROWSER_17.GoForward() 'Avançando uma página
                Exit Select
            Case 18
                OBJ_MOTOR_WEB_BROWSER_18.GoForward() 'Avançando uma página
                Exit Select
            Case 19
                OBJ_MOTOR_WEB_BROWSER_19.GoForward() 'Avançando uma página
                Exit Select
            Case 20
                OBJ_MOTOR_WEB_BROWSER_20.GoForward() 'Avançando uma página
                Exit Select
            Case 21
                OBJ_MOTOR_WEB_BROWSER_21.GoForward() 'Avançando uma página
                Exit Select
            Case 22
                OBJ_MOTOR_WEB_BROWSER_22.GoForward() 'Avançando uma página
                Exit Select
            Case 23
                OBJ_MOTOR_WEB_BROWSER_23.GoForward() 'Avançando uma página
                Exit Select
            Case 24
                OBJ_MOTOR_WEB_BROWSER_24.GoForward() 'Avançando uma página
                Exit Select
            Case 25
                OBJ_MOTOR_WEB_BROWSER_25.GoForward() 'Avançando uma página
                Exit Select
            Case 26
                OBJ_MOTOR_WEB_BROWSER_26.GoForward() 'Avançando uma página
                Exit Select
            Case 27
                OBJ_MOTOR_WEB_BROWSER_27.GoForward() 'Avançando uma página
                Exit Select
            Case 28
                OBJ_MOTOR_WEB_BROWSER_28.GoForward() 'Avançando uma página
                Exit Select
            Case 29
                OBJ_MOTOR_WEB_BROWSER_29.GoForward() 'Avançando uma página
                Exit Select
            Case 30
                OBJ_MOTOR_WEB_BROWSER_30.GoForward() 'Avançando uma página
                Exit Select
            Case 31
                OBJ_MOTOR_WEB_BROWSER_31.GoForward() 'Avançando uma página
                Exit Select
            Case 32
                OBJ_MOTOR_WEB_BROWSER_32.GoForward() 'Avançando uma página
                Exit Select
            Case 33
                OBJ_MOTOR_WEB_BROWSER_33.GoForward() 'Avançando uma página
                Exit Select
            Case 34
                OBJ_MOTOR_WEB_BROWSER_34.GoForward() 'Avançando uma página
                Exit Select
            Case 35
                OBJ_MOTOR_WEB_BROWSER_35.GoForward() 'Avançando uma página
                Exit Select
            Case 36
                OBJ_MOTOR_WEB_BROWSER_36.GoForward() 'Avançando uma página
                Exit Select
            Case 37
                OBJ_MOTOR_WEB_BROWSER_37.GoForward() 'Avançando uma página
                Exit Select
            Case 38
                OBJ_MOTOR_WEB_BROWSER_38.GoForward() 'Avançando uma página
                Exit Select
            Case 39
                OBJ_MOTOR_WEB_BROWSER_39.GoForward() 'Avançando uma página
                Exit Select
            Case 40
                OBJ_MOTOR_WEB_BROWSER_40.GoForward() 'Avançando uma página
                Exit Select
            Case 41
                OBJ_MOTOR_WEB_BROWSER_41.GoForward() 'Avançando uma página
                Exit Select
            Case 42
                OBJ_MOTOR_WEB_BROWSER_42.GoForward() 'Avançando uma página
                Exit Select
            Case 43
                OBJ_MOTOR_WEB_BROWSER_43.GoForward() 'Avançando uma página
                Exit Select
            Case 44
                OBJ_MOTOR_WEB_BROWSER_44.GoForward() 'Avançando uma página
                Exit Select
            Case 45
                OBJ_MOTOR_WEB_BROWSER_45.GoForward() 'Avançando uma página
                Exit Select
            Case 46
                OBJ_MOTOR_WEB_BROWSER_46.GoForward() 'Avançando uma página
                Exit Select
            Case 47
                OBJ_MOTOR_WEB_BROWSER_47.GoForward() 'Avançando uma página
                Exit Select
            Case 48
                OBJ_MOTOR_WEB_BROWSER_48.GoForward() 'Avançando uma página
                Exit Select
            Case 49
                OBJ_MOTOR_WEB_BROWSER_49.GoForward() 'Avançando uma página
                Exit Select
            Case 50
                OBJ_MOTOR_WEB_BROWSER_50.GoForward() 'Avançando uma página
                Exit Select
            Case 51
                OBJ_MOTOR_WEB_BROWSER_51.GoForward() 'Avançando uma página
                Exit Select
            Case 52
                OBJ_MOTOR_WEB_BROWSER_52.GoForward() 'Avançando uma página
                Exit Select
            Case 53
                OBJ_MOTOR_WEB_BROWSER_53.GoForward() 'Avançando uma página
                Exit Select
            Case 54
                OBJ_MOTOR_WEB_BROWSER_54.GoForward() 'Avançando uma página
                Exit Select
            Case 55
                OBJ_MOTOR_WEB_BROWSER_55.GoForward() 'Avançando uma página
                Exit Select
            Case 56
                OBJ_MOTOR_WEB_BROWSER_56.GoForward() 'Avançando uma página
                Exit Select
            Case 57
                OBJ_MOTOR_WEB_BROWSER_57.GoForward() 'Avançando uma página
                Exit Select
            Case 58
                OBJ_MOTOR_WEB_BROWSER_58.GoForward() 'Avançando uma página
                Exit Select
            Case 59
                OBJ_MOTOR_WEB_BROWSER_59.GoForward() 'Avançando uma página
                Exit Select
            Case 60
                OBJ_MOTOR_WEB_BROWSER_60.GoForward() 'Avançando uma página
                Exit Select
            Case 61
                OBJ_MOTOR_WEB_BROWSER_61.GoForward() 'Avançando uma página
                Exit Select
            Case 62
                OBJ_MOTOR_WEB_BROWSER_62.GoForward() 'Avançando uma página
                Exit Select
            Case 63
                OBJ_MOTOR_WEB_BROWSER_63.GoForward() 'Avançando uma página
                Exit Select
            Case 64
                OBJ_MOTOR_WEB_BROWSER_64.GoForward() 'Avançando uma página
                Exit Select
            Case 65
                OBJ_MOTOR_WEB_BROWSER_65.GoForward() 'Avançando uma página
                Exit Select
            Case 66
                OBJ_MOTOR_WEB_BROWSER_66.GoForward() 'Avançando uma página
                Exit Select
            Case 67
                OBJ_MOTOR_WEB_BROWSER_67.GoForward() 'Avançando uma página
                Exit Select
            Case 68
                OBJ_MOTOR_WEB_BROWSER_68.GoForward() 'Avançando uma página
                Exit Select
            Case 69
                OBJ_MOTOR_WEB_BROWSER_69.GoForward() 'Avançando uma página
                Exit Select
            Case 70
                OBJ_MOTOR_WEB_BROWSER_70.GoForward() 'Avançando uma página
                Exit Select
            Case 71
                OBJ_MOTOR_WEB_BROWSER_71.GoForward() 'Avançando uma página
                Exit Select
            Case 72
                OBJ_MOTOR_WEB_BROWSER_72.GoForward() 'Avançando uma página
                Exit Select
            Case 73
                OBJ_MOTOR_WEB_BROWSER_73.GoForward() 'Avançando uma página
                Exit Select
            Case 74
                OBJ_MOTOR_WEB_BROWSER_74.GoForward() 'Avançando uma página
                Exit Select
            Case 75
                OBJ_MOTOR_WEB_BROWSER_75.GoForward() 'Avançando uma página
                Exit Select
            Case 76
                OBJ_MOTOR_WEB_BROWSER_76.GoForward() 'Avançando uma página
                Exit Select
            Case 77
                OBJ_MOTOR_WEB_BROWSER_77.GoForward() 'Avançando uma página
                Exit Select
            Case 78
                OBJ_MOTOR_WEB_BROWSER_78.GoForward() 'Avançando uma página
                Exit Select
            Case 79
                OBJ_MOTOR_WEB_BROWSER_79.GoForward() 'Avançando uma página
                Exit Select
            Case 80
                OBJ_MOTOR_WEB_BROWSER_80.GoForward() 'Avançando uma página
                Exit Select
            Case 81
                OBJ_MOTOR_WEB_BROWSER_81.GoForward() 'Avançando uma página
                Exit Select
            Case 82
                OBJ_MOTOR_WEB_BROWSER_82.GoForward() 'Avançando uma página
                Exit Select
            Case 83
                OBJ_MOTOR_WEB_BROWSER_83.GoForward() 'Avançando uma página
                Exit Select
            Case 84
                OBJ_MOTOR_WEB_BROWSER_84.GoForward() 'Avançando uma página
                Exit Select
            Case 85
                OBJ_MOTOR_WEB_BROWSER_85.GoForward() 'Avançando uma página
                Exit Select
            Case 86
                OBJ_MOTOR_WEB_BROWSER_86.GoForward() 'Avançando uma página
                Exit Select
            Case 87
                OBJ_MOTOR_WEB_BROWSER_87.GoForward() 'Avançando uma página
                Exit Select
            Case 88
                OBJ_MOTOR_WEB_BROWSER_88.GoForward() 'Avançando uma página
                Exit Select
            Case 89
                OBJ_MOTOR_WEB_BROWSER_89.GoForward() 'Avançando uma página
                Exit Select
            Case 90
                OBJ_MOTOR_WEB_BROWSER_90.GoForward() 'Avançando uma página
                Exit Select
            Case 91
                OBJ_MOTOR_WEB_BROWSER_91.GoForward() 'Avançando uma página
                Exit Select
            Case 92
                OBJ_MOTOR_WEB_BROWSER_92.GoForward() 'Avançando uma página
                Exit Select
            Case 93
                OBJ_MOTOR_WEB_BROWSER_93.GoForward() 'Avançando uma página
                Exit Select
            Case 94
                OBJ_MOTOR_WEB_BROWSER_94.GoForward() 'Avançando uma página
                Exit Select
            Case 95
                OBJ_MOTOR_WEB_BROWSER_95.GoForward() 'Avançando uma página
                Exit Select
            Case 96
                OBJ_MOTOR_WEB_BROWSER_96.GoForward() 'Avançando uma página
                Exit Select
            Case 97
                OBJ_MOTOR_WEB_BROWSER_97.GoForward() 'Avançando uma página
                Exit Select
            Case 98
                OBJ_MOTOR_WEB_BROWSER_98.GoForward() 'Avançando uma página
                Exit Select
            Case 99
                OBJ_MOTOR_WEB_BROWSER_99.GoForward() 'Avançando uma página
                Exit Select
            Case 100
                OBJ_MOTOR_WEB_BROWSER_100.GoForward() 'Avançando uma página
                Exit Select
            Case 101
                OBJ_MOTOR_WEB_BROWSER_101.GoForward() 'Avançando uma página
                Exit Select
            Case 102
                OBJ_MOTOR_WEB_BROWSER_102.GoForward() 'Avançando uma página
                Exit Select
            Case 103
                OBJ_MOTOR_WEB_BROWSER_103.GoForward() 'Avançando uma página
                Exit Select
            Case 104
                OBJ_MOTOR_WEB_BROWSER_104.GoForward() 'Avançando uma página
                Exit Select
            Case 105
                OBJ_MOTOR_WEB_BROWSER_105.GoForward() 'Avançando uma página
                Exit Select
            Case 106
                OBJ_MOTOR_WEB_BROWSER_106.GoForward() 'Avançando uma página
                Exit Select
            Case 107
                OBJ_MOTOR_WEB_BROWSER_107.GoForward() 'Avançando uma página
                Exit Select
            Case 108
                OBJ_MOTOR_WEB_BROWSER_108.GoForward() 'Avançando uma página
                Exit Select
            Case 109
                OBJ_MOTOR_WEB_BROWSER_109.GoForward() 'Avançando uma página
                Exit Select
            Case 110
                OBJ_MOTOR_WEB_BROWSER_110.GoForward() 'Avançando uma página
                Exit Select
            Case 111
                OBJ_MOTOR_WEB_BROWSER_111.GoForward() 'Avançando uma página
                Exit Select
            Case 112
                OBJ_MOTOR_WEB_BROWSER_112.GoForward() 'Avançando uma página
                Exit Select
            Case 113
                OBJ_MOTOR_WEB_BROWSER_113.GoForward() 'Avançando uma página
                Exit Select
            Case 114
                OBJ_MOTOR_WEB_BROWSER_114.GoForward() 'Avançando uma página
                Exit Select
            Case 115
                OBJ_MOTOR_WEB_BROWSER_115.GoForward() 'Avançando uma página
                Exit Select
            Case 116
                OBJ_MOTOR_WEB_BROWSER_116.GoForward() 'Avançando uma página
                Exit Select
            Case 117
                OBJ_MOTOR_WEB_BROWSER_117.GoForward() 'Avançando uma página
                Exit Select
            Case 118
                OBJ_MOTOR_WEB_BROWSER_118.GoForward() 'Avançando uma página
                Exit Select
            Case 119
                OBJ_MOTOR_WEB_BROWSER_119.GoForward() 'Avançando uma página
                Exit Select
            Case 120
                OBJ_MOTOR_WEB_BROWSER_120.GoForward() 'Avançando uma página
                Exit Select
            Case 121
                OBJ_MOTOR_WEB_BROWSER_121.GoForward() 'Avançando uma página
                Exit Select
            Case 122
                OBJ_MOTOR_WEB_BROWSER_122.GoForward() 'Avançando uma página
                Exit Select
            Case 123
                OBJ_MOTOR_WEB_BROWSER_123.GoForward() 'Avançando uma página
                Exit Select
            Case 124
                OBJ_MOTOR_WEB_BROWSER_124.GoForward() 'Avançando uma página
                Exit Select
            Case 125
                OBJ_MOTOR_WEB_BROWSER_125.GoForward() 'Avançando uma página
                Exit Select
            Case 126
                OBJ_MOTOR_WEB_BROWSER_126.GoForward() 'Avançando uma página
                Exit Select
            Case 127
                OBJ_MOTOR_WEB_BROWSER_127.GoForward() 'Avançando uma página
                Exit Select
            Case 128
                OBJ_MOTOR_WEB_BROWSER_128.GoForward() 'Avançando uma página
                Exit Select





        End Select


    End Sub

    Public Sub proc_avancar_pagina_anterior() 'Avança uma pagina posterior
        On Error Resume Next


        'Selecionando o tipo de motor ----------------------------------------------------------------------------------

        If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then


            proc_avancar_geckofx() 'Avançar uma página geckofx


        Else


            proc_avancar_trident() 'Avançar uma página trident


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub




    'Esquema de atualizar página

    Private Sub proc_atualizar_geckofx() 'Atualiza a página do geckofx
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso


            Case 1
                OBJ_MOTOR_GECKOFX_1.Reload() 'Atualiza a página
                Exit Select
            Case 2
                OBJ_MOTOR_GECKOFX_2.Reload() 'Atualiza a página
                Exit Select
            Case 3
                OBJ_MOTOR_GECKOFX_3.Reload() 'Atualiza a página
                Exit Select
            Case 4
                OBJ_MOTOR_GECKOFX_4.Reload() 'Atualiza a página
                Exit Select
            Case 5
                OBJ_MOTOR_GECKOFX_5.Reload() 'Atualiza a página
                Exit Select
            Case 6
                OBJ_MOTOR_GECKOFX_6.Reload() 'Atualiza a página
                Exit Select
            Case 7
                OBJ_MOTOR_GECKOFX_7.Reload() 'Atualiza a página
                Exit Select
            Case 8
                OBJ_MOTOR_GECKOFX_8.Reload() 'Atualiza a página
                Exit Select
            Case 9
                OBJ_MOTOR_GECKOFX_9.Reload() 'Atualiza a página
                Exit Select
            Case 10
                OBJ_MOTOR_GECKOFX_10.Reload() 'Atualiza a página
                Exit Select
            Case 11
                OBJ_MOTOR_GECKOFX_11.Reload() 'Atualiza a página
                Exit Select
            Case 12
                OBJ_MOTOR_GECKOFX_12.Reload() 'Atualiza a página
                Exit Select
            Case 13
                OBJ_MOTOR_GECKOFX_13.Reload() 'Atualiza a página
                Exit Select
            Case 14
                OBJ_MOTOR_GECKOFX_14.Reload() 'Atualiza a página
                Exit Select
            Case 15
                OBJ_MOTOR_GECKOFX_15.Reload() 'Atualiza a página
                Exit Select
            Case 16
                OBJ_MOTOR_GECKOFX_16.Reload() 'Atualiza a página
                Exit Select
            Case 17
                OBJ_MOTOR_GECKOFX_17.Reload() 'Atualiza a página
                Exit Select
            Case 18
                OBJ_MOTOR_GECKOFX_18.Reload() 'Atualiza a página
                Exit Select
            Case 19
                OBJ_MOTOR_GECKOFX_19.Reload() 'Atualiza a página
                Exit Select
            Case 20
                OBJ_MOTOR_GECKOFX_20.Reload() 'Atualiza a página
                Exit Select
            Case 21
                OBJ_MOTOR_GECKOFX_21.Reload() 'Atualiza a página
                Exit Select
            Case 22
                OBJ_MOTOR_GECKOFX_22.Reload() 'Atualiza a página
                Exit Select
            Case 23
                OBJ_MOTOR_GECKOFX_23.Reload() 'Atualiza a página
                Exit Select
            Case 24
                OBJ_MOTOR_GECKOFX_24.Reload() 'Atualiza a página
                Exit Select
            Case 25
                OBJ_MOTOR_GECKOFX_25.Reload() 'Atualiza a página
                Exit Select
            Case 26
                OBJ_MOTOR_GECKOFX_26.Reload() 'Atualiza a página
                Exit Select
            Case 27
                OBJ_MOTOR_GECKOFX_27.Reload() 'Atualiza a página
                Exit Select
            Case 28
                OBJ_MOTOR_GECKOFX_28.Reload() 'Atualiza a página
                Exit Select
            Case 29
                OBJ_MOTOR_GECKOFX_29.Reload() 'Atualiza a página
                Exit Select
            Case 30
                OBJ_MOTOR_GECKOFX_30.Reload() 'Atualiza a página
                Exit Select
            Case 31
                OBJ_MOTOR_GECKOFX_31.Reload() 'Atualiza a página
                Exit Select
            Case 32
                OBJ_MOTOR_GECKOFX_32.Reload() 'Atualiza a página
                Exit Select
            Case 33
                OBJ_MOTOR_GECKOFX_33.Reload() 'Atualiza a página
                Exit Select
            Case 34
                OBJ_MOTOR_GECKOFX_34.Reload() 'Atualiza a página
                Exit Select
            Case 35
                OBJ_MOTOR_GECKOFX_35.Reload() 'Atualiza a página
                Exit Select
            Case 36
                OBJ_MOTOR_GECKOFX_36.Reload() 'Atualiza a página
                Exit Select
            Case 37
                OBJ_MOTOR_GECKOFX_37.Reload() 'Atualiza a página
                Exit Select
            Case 38
                OBJ_MOTOR_GECKOFX_38.Reload() 'Atualiza a página
                Exit Select
            Case 39
                OBJ_MOTOR_GECKOFX_39.Reload() 'Atualiza a página
                Exit Select
            Case 40
                OBJ_MOTOR_GECKOFX_40.Reload() 'Atualiza a página
                Exit Select
            Case 41
                OBJ_MOTOR_GECKOFX_41.Reload() 'Atualiza a página
                Exit Select
            Case 42
                OBJ_MOTOR_GECKOFX_42.Reload() 'Atualiza a página
                Exit Select
            Case 43
                OBJ_MOTOR_GECKOFX_43.Reload() 'Atualiza a página
                Exit Select
            Case 44
                OBJ_MOTOR_GECKOFX_44.Reload() 'Atualiza a página
                Exit Select
            Case 45
                OBJ_MOTOR_GECKOFX_45.Reload() 'Atualiza a página
                Exit Select
            Case 46
                OBJ_MOTOR_GECKOFX_46.Reload() 'Atualiza a página
                Exit Select
            Case 47
                OBJ_MOTOR_GECKOFX_47.Reload() 'Atualiza a página
                Exit Select
            Case 48
                OBJ_MOTOR_GECKOFX_48.Reload() 'Atualiza a página
                Exit Select
            Case 49
                OBJ_MOTOR_GECKOFX_49.Reload() 'Atualiza a página
                Exit Select
            Case 50
                OBJ_MOTOR_GECKOFX_50.Reload() 'Atualiza a página
                Exit Select
            Case 51
                OBJ_MOTOR_GECKOFX_51.Reload() 'Atualiza a página
                Exit Select
            Case 52
                OBJ_MOTOR_GECKOFX_52.Reload() 'Atualiza a página
                Exit Select
            Case 53
                OBJ_MOTOR_GECKOFX_53.Reload() 'Atualiza a página
                Exit Select
            Case 54
                OBJ_MOTOR_GECKOFX_54.Reload() 'Atualiza a página
                Exit Select
            Case 55
                OBJ_MOTOR_GECKOFX_55.Reload() 'Atualiza a página
                Exit Select
            Case 56
                OBJ_MOTOR_GECKOFX_56.Reload() 'Atualiza a página
                Exit Select
            Case 57
                OBJ_MOTOR_GECKOFX_57.Reload() 'Atualiza a página
                Exit Select
            Case 58
                OBJ_MOTOR_GECKOFX_58.Reload() 'Atualiza a página
                Exit Select
            Case 59
                OBJ_MOTOR_GECKOFX_59.Reload() 'Atualiza a página
                Exit Select
            Case 60
                OBJ_MOTOR_GECKOFX_60.Reload() 'Atualiza a página
                Exit Select
            Case 61
                OBJ_MOTOR_GECKOFX_61.Reload() 'Atualiza a página
                Exit Select
            Case 62
                OBJ_MOTOR_GECKOFX_62.Reload() 'Atualiza a página
                Exit Select
            Case 63
                OBJ_MOTOR_GECKOFX_63.Reload() 'Atualiza a página
                Exit Select
            Case 64
                OBJ_MOTOR_GECKOFX_64.Reload() 'Atualiza a página
                Exit Select
            Case 65
                OBJ_MOTOR_GECKOFX_65.Reload() 'Atualiza a página
                Exit Select
            Case 66
                OBJ_MOTOR_GECKOFX_66.Reload() 'Atualiza a página
                Exit Select
            Case 67
                OBJ_MOTOR_GECKOFX_67.Reload() 'Atualiza a página
                Exit Select
            Case 68
                OBJ_MOTOR_GECKOFX_68.Reload() 'Atualiza a página
                Exit Select
            Case 69
                OBJ_MOTOR_GECKOFX_69.Reload() 'Atualiza a página
                Exit Select
            Case 70
                OBJ_MOTOR_GECKOFX_70.Reload() 'Atualiza a página
                Exit Select
            Case 71
                OBJ_MOTOR_GECKOFX_71.Reload() 'Atualiza a página
                Exit Select
            Case 72
                OBJ_MOTOR_GECKOFX_72.Reload() 'Atualiza a página
                Exit Select
            Case 73
                OBJ_MOTOR_GECKOFX_73.Reload() 'Atualiza a página
                Exit Select
            Case 74
                OBJ_MOTOR_GECKOFX_74.Reload() 'Atualiza a página
                Exit Select
            Case 75
                OBJ_MOTOR_GECKOFX_75.Reload() 'Atualiza a página
                Exit Select
            Case 76
                OBJ_MOTOR_GECKOFX_76.Reload() 'Atualiza a página
                Exit Select
            Case 77
                OBJ_MOTOR_GECKOFX_77.Reload() 'Atualiza a página
                Exit Select
            Case 78
                OBJ_MOTOR_GECKOFX_78.Reload() 'Atualiza a página
                Exit Select
            Case 79
                OBJ_MOTOR_GECKOFX_79.Reload() 'Atualiza a página
                Exit Select
            Case 80
                OBJ_MOTOR_GECKOFX_80.Reload() 'Atualiza a página
                Exit Select
            Case 81
                OBJ_MOTOR_GECKOFX_81.Reload() 'Atualiza a página
                Exit Select
            Case 82
                OBJ_MOTOR_GECKOFX_82.Reload() 'Atualiza a página
                Exit Select
            Case 83
                OBJ_MOTOR_GECKOFX_83.Reload() 'Atualiza a página
                Exit Select
            Case 84
                OBJ_MOTOR_GECKOFX_84.Reload() 'Atualiza a página
                Exit Select
            Case 85
                OBJ_MOTOR_GECKOFX_85.Reload() 'Atualiza a página
                Exit Select
            Case 86
                OBJ_MOTOR_GECKOFX_86.Reload() 'Atualiza a página
                Exit Select
            Case 87
                OBJ_MOTOR_GECKOFX_87.Reload() 'Atualiza a página
                Exit Select
            Case 88
                OBJ_MOTOR_GECKOFX_88.Reload() 'Atualiza a página
                Exit Select
            Case 89
                OBJ_MOTOR_GECKOFX_89.Reload() 'Atualiza a página
                Exit Select
            Case 90
                OBJ_MOTOR_GECKOFX_90.Reload() 'Atualiza a página
                Exit Select
            Case 91
                OBJ_MOTOR_GECKOFX_91.Reload() 'Atualiza a página
                Exit Select
            Case 92
                OBJ_MOTOR_GECKOFX_92.Reload() 'Atualiza a página
                Exit Select
            Case 93
                OBJ_MOTOR_GECKOFX_93.Reload() 'Atualiza a página
                Exit Select
            Case 94
                OBJ_MOTOR_GECKOFX_94.Reload() 'Atualiza a página
                Exit Select
            Case 95
                OBJ_MOTOR_GECKOFX_95.Reload() 'Atualiza a página
                Exit Select
            Case 96
                OBJ_MOTOR_GECKOFX_96.Reload() 'Atualiza a página
                Exit Select
            Case 97
                OBJ_MOTOR_GECKOFX_97.Reload() 'Atualiza a página
                Exit Select
            Case 98
                OBJ_MOTOR_GECKOFX_98.Reload() 'Atualiza a página
                Exit Select
            Case 99
                OBJ_MOTOR_GECKOFX_99.Reload() 'Atualiza a página
                Exit Select
            Case 100
                OBJ_MOTOR_GECKOFX_100.Reload() 'Atualiza a página
                Exit Select
            Case 101
                OBJ_MOTOR_GECKOFX_101.Reload() 'Atualiza a página
                Exit Select
            Case 102
                OBJ_MOTOR_GECKOFX_102.Reload() 'Atualiza a página
                Exit Select
            Case 103
                OBJ_MOTOR_GECKOFX_103.Reload() 'Atualiza a página
                Exit Select
            Case 104
                OBJ_MOTOR_GECKOFX_104.Reload() 'Atualiza a página
                Exit Select
            Case 105
                OBJ_MOTOR_GECKOFX_105.Reload() 'Atualiza a página
                Exit Select
            Case 106
                OBJ_MOTOR_GECKOFX_106.Reload() 'Atualiza a página
                Exit Select
            Case 107
                OBJ_MOTOR_GECKOFX_107.Reload() 'Atualiza a página
                Exit Select
            Case 108
                OBJ_MOTOR_GECKOFX_108.Reload() 'Atualiza a página
                Exit Select
            Case 109
                OBJ_MOTOR_GECKOFX_109.Reload() 'Atualiza a página
                Exit Select
            Case 110
                OBJ_MOTOR_GECKOFX_110.Reload() 'Atualiza a página
                Exit Select
            Case 111
                OBJ_MOTOR_GECKOFX_111.Reload() 'Atualiza a página
                Exit Select
            Case 112
                OBJ_MOTOR_GECKOFX_112.Reload() 'Atualiza a página
                Exit Select
            Case 113
                OBJ_MOTOR_GECKOFX_113.Reload() 'Atualiza a página
                Exit Select
            Case 114
                OBJ_MOTOR_GECKOFX_114.Reload() 'Atualiza a página
                Exit Select
            Case 115
                OBJ_MOTOR_GECKOFX_115.Reload() 'Atualiza a página
                Exit Select
            Case 116
                OBJ_MOTOR_GECKOFX_116.Reload() 'Atualiza a página
                Exit Select
            Case 117
                OBJ_MOTOR_GECKOFX_117.Reload() 'Atualiza a página
                Exit Select
            Case 118
                OBJ_MOTOR_GECKOFX_118.Reload() 'Atualiza a página
                Exit Select
            Case 119
                OBJ_MOTOR_GECKOFX_119.Reload() 'Atualiza a página
                Exit Select
            Case 120
                OBJ_MOTOR_GECKOFX_120.Reload() 'Atualiza a página
                Exit Select
            Case 121
                OBJ_MOTOR_GECKOFX_121.Reload() 'Atualiza a página
                Exit Select
            Case 122
                OBJ_MOTOR_GECKOFX_122.Reload() 'Atualiza a página
                Exit Select
            Case 123
                OBJ_MOTOR_GECKOFX_123.Reload() 'Atualiza a página
                Exit Select
            Case 124
                OBJ_MOTOR_GECKOFX_124.Reload() 'Atualiza a página
                Exit Select
            Case 125
                OBJ_MOTOR_GECKOFX_125.Reload() 'Atualiza a página
                Exit Select
            Case 126
                OBJ_MOTOR_GECKOFX_126.Reload() 'Atualiza a página
                Exit Select
            Case 127
                OBJ_MOTOR_GECKOFX_127.Reload() 'Atualiza a página
                Exit Select
            Case 128
                OBJ_MOTOR_GECKOFX_128.Reload() 'Atualiza a página
                Exit Select





        End Select


    End Sub

    Private Sub proc_atualizar_trident() 'Atualiza a página do trident
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso


            Case 1
                OBJ_MOTOR_WEB_BROWSER_1.Refresh() 'Atualiza a página
                Exit Select
            Case 2
                OBJ_MOTOR_WEB_BROWSER_2.Refresh() 'Atualiza a página
                Exit Select
            Case 3
                OBJ_MOTOR_WEB_BROWSER_3.Refresh() 'Atualiza a página
                Exit Select
            Case 4
                OBJ_MOTOR_WEB_BROWSER_4.Refresh() 'Atualiza a página
                Exit Select
            Case 5
                OBJ_MOTOR_WEB_BROWSER_5.Refresh() 'Atualiza a página
                Exit Select
            Case 6
                OBJ_MOTOR_WEB_BROWSER_6.Refresh() 'Atualiza a página
                Exit Select
            Case 7
                OBJ_MOTOR_WEB_BROWSER_7.Refresh() 'Atualiza a página
                Exit Select
            Case 8
                OBJ_MOTOR_WEB_BROWSER_8.Refresh() 'Atualiza a página
                Exit Select
            Case 9
                OBJ_MOTOR_WEB_BROWSER_9.Refresh() 'Atualiza a página
                Exit Select
            Case 10
                OBJ_MOTOR_WEB_BROWSER_10.Refresh() 'Atualiza a página
                Exit Select
            Case 11
                OBJ_MOTOR_WEB_BROWSER_11.Refresh() 'Atualiza a página
                Exit Select
            Case 12
                OBJ_MOTOR_WEB_BROWSER_12.Refresh() 'Atualiza a página
                Exit Select
            Case 13
                OBJ_MOTOR_WEB_BROWSER_13.Refresh() 'Atualiza a página
                Exit Select
            Case 14
                OBJ_MOTOR_WEB_BROWSER_14.Refresh() 'Atualiza a página
                Exit Select
            Case 15
                OBJ_MOTOR_WEB_BROWSER_15.Refresh() 'Atualiza a página
                Exit Select
            Case 16
                OBJ_MOTOR_WEB_BROWSER_16.Refresh() 'Atualiza a página
                Exit Select
            Case 17
                OBJ_MOTOR_WEB_BROWSER_17.Refresh() 'Atualiza a página
                Exit Select
            Case 18
                OBJ_MOTOR_WEB_BROWSER_18.Refresh() 'Atualiza a página
                Exit Select
            Case 19
                OBJ_MOTOR_WEB_BROWSER_19.Refresh() 'Atualiza a página
                Exit Select
            Case 20
                OBJ_MOTOR_WEB_BROWSER_20.Refresh() 'Atualiza a página
                Exit Select
            Case 21
                OBJ_MOTOR_WEB_BROWSER_21.Refresh() 'Atualiza a página
                Exit Select
            Case 22
                OBJ_MOTOR_WEB_BROWSER_22.Refresh() 'Atualiza a página
                Exit Select
            Case 23
                OBJ_MOTOR_WEB_BROWSER_23.Refresh() 'Atualiza a página
                Exit Select
            Case 24
                OBJ_MOTOR_WEB_BROWSER_24.Refresh() 'Atualiza a página
                Exit Select
            Case 25
                OBJ_MOTOR_WEB_BROWSER_25.Refresh() 'Atualiza a página
                Exit Select
            Case 26
                OBJ_MOTOR_WEB_BROWSER_26.Refresh() 'Atualiza a página
                Exit Select
            Case 27
                OBJ_MOTOR_WEB_BROWSER_27.Refresh() 'Atualiza a página
                Exit Select
            Case 28
                OBJ_MOTOR_WEB_BROWSER_28.Refresh() 'Atualiza a página
                Exit Select
            Case 29
                OBJ_MOTOR_WEB_BROWSER_29.Refresh() 'Atualiza a página
                Exit Select
            Case 30
                OBJ_MOTOR_WEB_BROWSER_30.Refresh() 'Atualiza a página
                Exit Select
            Case 31
                OBJ_MOTOR_WEB_BROWSER_31.Refresh() 'Atualiza a página
                Exit Select
            Case 32
                OBJ_MOTOR_WEB_BROWSER_32.Refresh() 'Atualiza a página
                Exit Select
            Case 33
                OBJ_MOTOR_WEB_BROWSER_33.Refresh() 'Atualiza a página
                Exit Select
            Case 34
                OBJ_MOTOR_WEB_BROWSER_34.Refresh() 'Atualiza a página
                Exit Select
            Case 35
                OBJ_MOTOR_WEB_BROWSER_35.Refresh() 'Atualiza a página
                Exit Select
            Case 36
                OBJ_MOTOR_WEB_BROWSER_36.Refresh() 'Atualiza a página
                Exit Select
            Case 37
                OBJ_MOTOR_WEB_BROWSER_37.Refresh() 'Atualiza a página
                Exit Select
            Case 38
                OBJ_MOTOR_WEB_BROWSER_38.Refresh() 'Atualiza a página
                Exit Select
            Case 39
                OBJ_MOTOR_WEB_BROWSER_39.Refresh() 'Atualiza a página
                Exit Select
            Case 40
                OBJ_MOTOR_WEB_BROWSER_40.Refresh() 'Atualiza a página
                Exit Select
            Case 41
                OBJ_MOTOR_WEB_BROWSER_41.Refresh() 'Atualiza a página
                Exit Select
            Case 42
                OBJ_MOTOR_WEB_BROWSER_42.Refresh() 'Atualiza a página
                Exit Select
            Case 43
                OBJ_MOTOR_WEB_BROWSER_43.Refresh() 'Atualiza a página
                Exit Select
            Case 44
                OBJ_MOTOR_WEB_BROWSER_44.Refresh() 'Atualiza a página
                Exit Select
            Case 45
                OBJ_MOTOR_WEB_BROWSER_45.Refresh() 'Atualiza a página
                Exit Select
            Case 46
                OBJ_MOTOR_WEB_BROWSER_46.Refresh() 'Atualiza a página
                Exit Select
            Case 47
                OBJ_MOTOR_WEB_BROWSER_47.Refresh() 'Atualiza a página
                Exit Select
            Case 48
                OBJ_MOTOR_WEB_BROWSER_48.Refresh() 'Atualiza a página
                Exit Select
            Case 49
                OBJ_MOTOR_WEB_BROWSER_49.Refresh() 'Atualiza a página
                Exit Select
            Case 50
                OBJ_MOTOR_WEB_BROWSER_50.Refresh() 'Atualiza a página
                Exit Select
            Case 51
                OBJ_MOTOR_WEB_BROWSER_51.Refresh() 'Atualiza a página
                Exit Select
            Case 52
                OBJ_MOTOR_WEB_BROWSER_52.Refresh() 'Atualiza a página
                Exit Select
            Case 53
                OBJ_MOTOR_WEB_BROWSER_53.Refresh() 'Atualiza a página
                Exit Select
            Case 54
                OBJ_MOTOR_WEB_BROWSER_54.Refresh() 'Atualiza a página
                Exit Select
            Case 55
                OBJ_MOTOR_WEB_BROWSER_55.Refresh() 'Atualiza a página
                Exit Select
            Case 56
                OBJ_MOTOR_WEB_BROWSER_56.Refresh() 'Atualiza a página
                Exit Select
            Case 57
                OBJ_MOTOR_WEB_BROWSER_57.Refresh() 'Atualiza a página
                Exit Select
            Case 58
                OBJ_MOTOR_WEB_BROWSER_58.Refresh() 'Atualiza a página
                Exit Select
            Case 59
                OBJ_MOTOR_WEB_BROWSER_59.Refresh() 'Atualiza a página
                Exit Select
            Case 60
                OBJ_MOTOR_WEB_BROWSER_60.Refresh() 'Atualiza a página
                Exit Select
            Case 61
                OBJ_MOTOR_WEB_BROWSER_61.Refresh() 'Atualiza a página
                Exit Select
            Case 62
                OBJ_MOTOR_WEB_BROWSER_62.Refresh() 'Atualiza a página
                Exit Select
            Case 63
                OBJ_MOTOR_WEB_BROWSER_63.Refresh() 'Atualiza a página
                Exit Select
            Case 64
                OBJ_MOTOR_WEB_BROWSER_64.Refresh() 'Atualiza a página
                Exit Select
            Case 65
                OBJ_MOTOR_WEB_BROWSER_65.Refresh() 'Atualiza a página
                Exit Select
            Case 66
                OBJ_MOTOR_WEB_BROWSER_66.Refresh() 'Atualiza a página
                Exit Select
            Case 67
                OBJ_MOTOR_WEB_BROWSER_67.Refresh() 'Atualiza a página
                Exit Select
            Case 68
                OBJ_MOTOR_WEB_BROWSER_68.Refresh() 'Atualiza a página
                Exit Select
            Case 69
                OBJ_MOTOR_WEB_BROWSER_69.Refresh() 'Atualiza a página
                Exit Select
            Case 70
                OBJ_MOTOR_WEB_BROWSER_70.Refresh() 'Atualiza a página
                Exit Select
            Case 71
                OBJ_MOTOR_WEB_BROWSER_71.Refresh() 'Atualiza a página
                Exit Select
            Case 72
                OBJ_MOTOR_WEB_BROWSER_72.Refresh() 'Atualiza a página
                Exit Select
            Case 73
                OBJ_MOTOR_WEB_BROWSER_73.Refresh() 'Atualiza a página
                Exit Select
            Case 74
                OBJ_MOTOR_WEB_BROWSER_74.Refresh() 'Atualiza a página
                Exit Select
            Case 75
                OBJ_MOTOR_WEB_BROWSER_75.Refresh() 'Atualiza a página
                Exit Select
            Case 76
                OBJ_MOTOR_WEB_BROWSER_76.Refresh() 'Atualiza a página
                Exit Select
            Case 77
                OBJ_MOTOR_WEB_BROWSER_77.Refresh() 'Atualiza a página
                Exit Select
            Case 78
                OBJ_MOTOR_WEB_BROWSER_78.Refresh() 'Atualiza a página
                Exit Select
            Case 79
                OBJ_MOTOR_WEB_BROWSER_79.Refresh() 'Atualiza a página
                Exit Select
            Case 80
                OBJ_MOTOR_WEB_BROWSER_80.Refresh() 'Atualiza a página
                Exit Select
            Case 81
                OBJ_MOTOR_WEB_BROWSER_81.Refresh() 'Atualiza a página
                Exit Select
            Case 82
                OBJ_MOTOR_WEB_BROWSER_82.Refresh() 'Atualiza a página
                Exit Select
            Case 83
                OBJ_MOTOR_WEB_BROWSER_83.Refresh() 'Atualiza a página
                Exit Select
            Case 84
                OBJ_MOTOR_WEB_BROWSER_84.Refresh() 'Atualiza a página
                Exit Select
            Case 85
                OBJ_MOTOR_WEB_BROWSER_85.Refresh() 'Atualiza a página
                Exit Select
            Case 86
                OBJ_MOTOR_WEB_BROWSER_86.Refresh() 'Atualiza a página
                Exit Select
            Case 87
                OBJ_MOTOR_WEB_BROWSER_87.Refresh() 'Atualiza a página
                Exit Select
            Case 88
                OBJ_MOTOR_WEB_BROWSER_88.Refresh() 'Atualiza a página
                Exit Select
            Case 89
                OBJ_MOTOR_WEB_BROWSER_89.Refresh() 'Atualiza a página
                Exit Select
            Case 90
                OBJ_MOTOR_WEB_BROWSER_90.Refresh() 'Atualiza a página
                Exit Select
            Case 91
                OBJ_MOTOR_WEB_BROWSER_91.Refresh() 'Atualiza a página
                Exit Select
            Case 92
                OBJ_MOTOR_WEB_BROWSER_92.Refresh() 'Atualiza a página
                Exit Select
            Case 93
                OBJ_MOTOR_WEB_BROWSER_93.Refresh() 'Atualiza a página
                Exit Select
            Case 94
                OBJ_MOTOR_WEB_BROWSER_94.Refresh() 'Atualiza a página
                Exit Select
            Case 95
                OBJ_MOTOR_WEB_BROWSER_95.Refresh() 'Atualiza a página
                Exit Select
            Case 96
                OBJ_MOTOR_WEB_BROWSER_96.Refresh() 'Atualiza a página
                Exit Select
            Case 97
                OBJ_MOTOR_WEB_BROWSER_97.Refresh() 'Atualiza a página
                Exit Select
            Case 98
                OBJ_MOTOR_WEB_BROWSER_98.Refresh() 'Atualiza a página
                Exit Select
            Case 99
                OBJ_MOTOR_WEB_BROWSER_99.Refresh() 'Atualiza a página
                Exit Select
            Case 100
                OBJ_MOTOR_WEB_BROWSER_100.Refresh() 'Atualiza a página
                Exit Select
            Case 101
                OBJ_MOTOR_WEB_BROWSER_101.Refresh() 'Atualiza a página
                Exit Select
            Case 102
                OBJ_MOTOR_WEB_BROWSER_102.Refresh() 'Atualiza a página
                Exit Select
            Case 103
                OBJ_MOTOR_WEB_BROWSER_103.Refresh() 'Atualiza a página
                Exit Select
            Case 104
                OBJ_MOTOR_WEB_BROWSER_104.Refresh() 'Atualiza a página
                Exit Select
            Case 105
                OBJ_MOTOR_WEB_BROWSER_105.Refresh() 'Atualiza a página
                Exit Select
            Case 106
                OBJ_MOTOR_WEB_BROWSER_106.Refresh() 'Atualiza a página
                Exit Select
            Case 107
                OBJ_MOTOR_WEB_BROWSER_107.Refresh() 'Atualiza a página
                Exit Select
            Case 108
                OBJ_MOTOR_WEB_BROWSER_108.Refresh() 'Atualiza a página
                Exit Select
            Case 109
                OBJ_MOTOR_WEB_BROWSER_109.Refresh() 'Atualiza a página
                Exit Select
            Case 110
                OBJ_MOTOR_WEB_BROWSER_110.Refresh() 'Atualiza a página
                Exit Select
            Case 111
                OBJ_MOTOR_WEB_BROWSER_111.Refresh() 'Atualiza a página
                Exit Select
            Case 112
                OBJ_MOTOR_WEB_BROWSER_112.Refresh() 'Atualiza a página
                Exit Select
            Case 113
                OBJ_MOTOR_WEB_BROWSER_113.Refresh() 'Atualiza a página
                Exit Select
            Case 114
                OBJ_MOTOR_WEB_BROWSER_114.Refresh() 'Atualiza a página
                Exit Select
            Case 115
                OBJ_MOTOR_WEB_BROWSER_115.Refresh() 'Atualiza a página
                Exit Select
            Case 116
                OBJ_MOTOR_WEB_BROWSER_116.Refresh() 'Atualiza a página
                Exit Select
            Case 117
                OBJ_MOTOR_WEB_BROWSER_117.Refresh() 'Atualiza a página
                Exit Select
            Case 118
                OBJ_MOTOR_WEB_BROWSER_118.Refresh() 'Atualiza a página
                Exit Select
            Case 119
                OBJ_MOTOR_WEB_BROWSER_119.Refresh() 'Atualiza a página
                Exit Select
            Case 120
                OBJ_MOTOR_WEB_BROWSER_120.Refresh() 'Atualiza a página
                Exit Select
            Case 121
                OBJ_MOTOR_WEB_BROWSER_121.Refresh() 'Atualiza a página
                Exit Select
            Case 122
                OBJ_MOTOR_WEB_BROWSER_122.Refresh() 'Atualiza a página
                Exit Select
            Case 123
                OBJ_MOTOR_WEB_BROWSER_123.Refresh() 'Atualiza a página
                Exit Select
            Case 124
                OBJ_MOTOR_WEB_BROWSER_124.Refresh() 'Atualiza a página
                Exit Select
            Case 125
                OBJ_MOTOR_WEB_BROWSER_125.Refresh() 'Atualiza a página
                Exit Select
            Case 126
                OBJ_MOTOR_WEB_BROWSER_126.Refresh() 'Atualiza a página
                Exit Select
            Case 127
                OBJ_MOTOR_WEB_BROWSER_127.Refresh() 'Atualiza a página
                Exit Select
            Case 128
                OBJ_MOTOR_WEB_BROWSER_128.Refresh() 'Atualiza a página
                Exit Select





        End Select


    End Sub

    Public Sub proc_atualiza_a_pagina() 'Atualiza a página em visualização
        On Error Resume Next


        'Selecionando o tipo de motor ----------------------------------------------------------------------------------

        If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then


            proc_atualizar_geckofx() 'Atualiza a página do geckofx


        Else


            proc_atualizar_trident() 'Atualiza a página do trident


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub




    'Esquema de parar carregamento

    Private Sub proc_parar_carregamento_geckofx() 'Para o carregamento da página geckofx
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso


            Case 1
                OBJ_MOTOR_GECKOFX_1.Stop() 'Para o carregamento
                Exit Select
            Case 2
                OBJ_MOTOR_GECKOFX_2.Stop() 'Para o carregamento
                Exit Select
            Case 3
                OBJ_MOTOR_GECKOFX_3.Stop() 'Para o carregamento
                Exit Select
            Case 4
                OBJ_MOTOR_GECKOFX_4.Stop() 'Para o carregamento
                Exit Select
            Case 5
                OBJ_MOTOR_GECKOFX_5.Stop() 'Para o carregamento
                Exit Select
            Case 6
                OBJ_MOTOR_GECKOFX_6.Stop() 'Para o carregamento
                Exit Select
            Case 7
                OBJ_MOTOR_GECKOFX_7.Stop() 'Para o carregamento
                Exit Select
            Case 8
                OBJ_MOTOR_GECKOFX_8.Stop() 'Para o carregamento
                Exit Select
            Case 9
                OBJ_MOTOR_GECKOFX_9.Stop() 'Para o carregamento
                Exit Select
            Case 10
                OBJ_MOTOR_GECKOFX_10.Stop() 'Para o carregamento
                Exit Select
            Case 11
                OBJ_MOTOR_GECKOFX_11.Stop() 'Para o carregamento
                Exit Select
            Case 12
                OBJ_MOTOR_GECKOFX_12.Stop() 'Para o carregamento
                Exit Select
            Case 13
                OBJ_MOTOR_GECKOFX_13.Stop() 'Para o carregamento
                Exit Select
            Case 14
                OBJ_MOTOR_GECKOFX_14.Stop() 'Para o carregamento
                Exit Select
            Case 15
                OBJ_MOTOR_GECKOFX_15.Stop() 'Para o carregamento
                Exit Select
            Case 16
                OBJ_MOTOR_GECKOFX_16.Stop() 'Para o carregamento
                Exit Select
            Case 17
                OBJ_MOTOR_GECKOFX_17.Stop() 'Para o carregamento
                Exit Select
            Case 18
                OBJ_MOTOR_GECKOFX_18.Stop() 'Para o carregamento
                Exit Select
            Case 19
                OBJ_MOTOR_GECKOFX_19.Stop() 'Para o carregamento
                Exit Select
            Case 20
                OBJ_MOTOR_GECKOFX_20.Stop() 'Para o carregamento
                Exit Select
            Case 21
                OBJ_MOTOR_GECKOFX_21.Stop() 'Para o carregamento
                Exit Select
            Case 22
                OBJ_MOTOR_GECKOFX_22.Stop() 'Para o carregamento
                Exit Select
            Case 23
                OBJ_MOTOR_GECKOFX_23.Stop() 'Para o carregamento
                Exit Select
            Case 24
                OBJ_MOTOR_GECKOFX_24.Stop() 'Para o carregamento
                Exit Select
            Case 25
                OBJ_MOTOR_GECKOFX_25.Stop() 'Para o carregamento
                Exit Select
            Case 26
                OBJ_MOTOR_GECKOFX_26.Stop() 'Para o carregamento
                Exit Select
            Case 27
                OBJ_MOTOR_GECKOFX_27.Stop() 'Para o carregamento
                Exit Select
            Case 28
                OBJ_MOTOR_GECKOFX_28.Stop() 'Para o carregamento
                Exit Select
            Case 29
                OBJ_MOTOR_GECKOFX_29.Stop() 'Para o carregamento
                Exit Select
            Case 30
                OBJ_MOTOR_GECKOFX_30.Stop() 'Para o carregamento
                Exit Select
            Case 31
                OBJ_MOTOR_GECKOFX_31.Stop() 'Para o carregamento
                Exit Select
            Case 32
                OBJ_MOTOR_GECKOFX_32.Stop() 'Para o carregamento
                Exit Select
            Case 33
                OBJ_MOTOR_GECKOFX_33.Stop() 'Para o carregamento
                Exit Select
            Case 34
                OBJ_MOTOR_GECKOFX_34.Stop() 'Para o carregamento
                Exit Select
            Case 35
                OBJ_MOTOR_GECKOFX_35.Stop() 'Para o carregamento
                Exit Select
            Case 36
                OBJ_MOTOR_GECKOFX_36.Stop() 'Para o carregamento
                Exit Select
            Case 37
                OBJ_MOTOR_GECKOFX_37.Stop() 'Para o carregamento
                Exit Select
            Case 38
                OBJ_MOTOR_GECKOFX_38.Stop() 'Para o carregamento
                Exit Select
            Case 39
                OBJ_MOTOR_GECKOFX_39.Stop() 'Para o carregamento
                Exit Select
            Case 40
                OBJ_MOTOR_GECKOFX_40.Stop() 'Para o carregamento
                Exit Select
            Case 41
                OBJ_MOTOR_GECKOFX_41.Stop() 'Para o carregamento
                Exit Select
            Case 42
                OBJ_MOTOR_GECKOFX_42.Stop() 'Para o carregamento
                Exit Select
            Case 43
                OBJ_MOTOR_GECKOFX_43.Stop() 'Para o carregamento
                Exit Select
            Case 44
                OBJ_MOTOR_GECKOFX_44.Stop() 'Para o carregamento
                Exit Select
            Case 45
                OBJ_MOTOR_GECKOFX_45.Stop() 'Para o carregamento
                Exit Select
            Case 46
                OBJ_MOTOR_GECKOFX_46.Stop() 'Para o carregamento
                Exit Select
            Case 47
                OBJ_MOTOR_GECKOFX_47.Stop() 'Para o carregamento
                Exit Select
            Case 48
                OBJ_MOTOR_GECKOFX_48.Stop() 'Para o carregamento
                Exit Select
            Case 49
                OBJ_MOTOR_GECKOFX_49.Stop() 'Para o carregamento
                Exit Select
            Case 50
                OBJ_MOTOR_GECKOFX_50.Stop() 'Para o carregamento
                Exit Select
            Case 51
                OBJ_MOTOR_GECKOFX_51.Stop() 'Para o carregamento
                Exit Select
            Case 52
                OBJ_MOTOR_GECKOFX_52.Stop() 'Para o carregamento
                Exit Select
            Case 53
                OBJ_MOTOR_GECKOFX_53.Stop() 'Para o carregamento
                Exit Select
            Case 54
                OBJ_MOTOR_GECKOFX_54.Stop() 'Para o carregamento
                Exit Select
            Case 55
                OBJ_MOTOR_GECKOFX_55.Stop() 'Para o carregamento
                Exit Select
            Case 56
                OBJ_MOTOR_GECKOFX_56.Stop() 'Para o carregamento
                Exit Select
            Case 57
                OBJ_MOTOR_GECKOFX_57.Stop() 'Para o carregamento
                Exit Select
            Case 58
                OBJ_MOTOR_GECKOFX_58.Stop() 'Para o carregamento
                Exit Select
            Case 59
                OBJ_MOTOR_GECKOFX_59.Stop() 'Para o carregamento
                Exit Select
            Case 60
                OBJ_MOTOR_GECKOFX_60.Stop() 'Para o carregamento
                Exit Select
            Case 61
                OBJ_MOTOR_GECKOFX_61.Stop() 'Para o carregamento
                Exit Select
            Case 62
                OBJ_MOTOR_GECKOFX_62.Stop() 'Para o carregamento
                Exit Select
            Case 63
                OBJ_MOTOR_GECKOFX_63.Stop() 'Para o carregamento
                Exit Select
            Case 64
                OBJ_MOTOR_GECKOFX_64.Stop() 'Para o carregamento
                Exit Select
            Case 65
                OBJ_MOTOR_GECKOFX_65.Stop() 'Para o carregamento
                Exit Select
            Case 66
                OBJ_MOTOR_GECKOFX_66.Stop() 'Para o carregamento
                Exit Select
            Case 67
                OBJ_MOTOR_GECKOFX_67.Stop() 'Para o carregamento
                Exit Select
            Case 68
                OBJ_MOTOR_GECKOFX_68.Stop() 'Para o carregamento
                Exit Select
            Case 69
                OBJ_MOTOR_GECKOFX_69.Stop() 'Para o carregamento
                Exit Select
            Case 70
                OBJ_MOTOR_GECKOFX_70.Stop() 'Para o carregamento
                Exit Select
            Case 71
                OBJ_MOTOR_GECKOFX_71.Stop() 'Para o carregamento
                Exit Select
            Case 72
                OBJ_MOTOR_GECKOFX_72.Stop() 'Para o carregamento
                Exit Select
            Case 73
                OBJ_MOTOR_GECKOFX_73.Stop() 'Para o carregamento
                Exit Select
            Case 74
                OBJ_MOTOR_GECKOFX_74.Stop() 'Para o carregamento
                Exit Select
            Case 75
                OBJ_MOTOR_GECKOFX_75.Stop() 'Para o carregamento
                Exit Select
            Case 76
                OBJ_MOTOR_GECKOFX_76.Stop() 'Para o carregamento
                Exit Select
            Case 77
                OBJ_MOTOR_GECKOFX_77.Stop() 'Para o carregamento
                Exit Select
            Case 78
                OBJ_MOTOR_GECKOFX_78.Stop() 'Para o carregamento
                Exit Select
            Case 79
                OBJ_MOTOR_GECKOFX_79.Stop() 'Para o carregamento
                Exit Select
            Case 80
                OBJ_MOTOR_GECKOFX_80.Stop() 'Para o carregamento
                Exit Select
            Case 81
                OBJ_MOTOR_GECKOFX_81.Stop() 'Para o carregamento
                Exit Select
            Case 82
                OBJ_MOTOR_GECKOFX_82.Stop() 'Para o carregamento
                Exit Select
            Case 83
                OBJ_MOTOR_GECKOFX_83.Stop() 'Para o carregamento
                Exit Select
            Case 84
                OBJ_MOTOR_GECKOFX_84.Stop() 'Para o carregamento
                Exit Select
            Case 85
                OBJ_MOTOR_GECKOFX_85.Stop() 'Para o carregamento
                Exit Select
            Case 86
                OBJ_MOTOR_GECKOFX_86.Stop() 'Para o carregamento
                Exit Select
            Case 87
                OBJ_MOTOR_GECKOFX_87.Stop() 'Para o carregamento
                Exit Select
            Case 88
                OBJ_MOTOR_GECKOFX_88.Stop() 'Para o carregamento
                Exit Select
            Case 89
                OBJ_MOTOR_GECKOFX_89.Stop() 'Para o carregamento
                Exit Select
            Case 90
                OBJ_MOTOR_GECKOFX_90.Stop() 'Para o carregamento
                Exit Select
            Case 91
                OBJ_MOTOR_GECKOFX_91.Stop() 'Para o carregamento
                Exit Select
            Case 92
                OBJ_MOTOR_GECKOFX_92.Stop() 'Para o carregamento
                Exit Select
            Case 93
                OBJ_MOTOR_GECKOFX_93.Stop() 'Para o carregamento
                Exit Select
            Case 94
                OBJ_MOTOR_GECKOFX_94.Stop() 'Para o carregamento
                Exit Select
            Case 95
                OBJ_MOTOR_GECKOFX_95.Stop() 'Para o carregamento
                Exit Select
            Case 96
                OBJ_MOTOR_GECKOFX_96.Stop() 'Para o carregamento
                Exit Select
            Case 97
                OBJ_MOTOR_GECKOFX_97.Stop() 'Para o carregamento
                Exit Select
            Case 98
                OBJ_MOTOR_GECKOFX_98.Stop() 'Para o carregamento
                Exit Select
            Case 99
                OBJ_MOTOR_GECKOFX_99.Stop() 'Para o carregamento
                Exit Select
            Case 100
                OBJ_MOTOR_GECKOFX_100.Stop() 'Para o carregamento
                Exit Select
            Case 101
                OBJ_MOTOR_GECKOFX_101.Stop() 'Para o carregamento
                Exit Select
            Case 102
                OBJ_MOTOR_GECKOFX_102.Stop() 'Para o carregamento
                Exit Select
            Case 103
                OBJ_MOTOR_GECKOFX_103.Stop() 'Para o carregamento
                Exit Select
            Case 104
                OBJ_MOTOR_GECKOFX_104.Stop() 'Para o carregamento
                Exit Select
            Case 105
                OBJ_MOTOR_GECKOFX_105.Stop() 'Para o carregamento
                Exit Select
            Case 106
                OBJ_MOTOR_GECKOFX_106.Stop() 'Para o carregamento
                Exit Select
            Case 107
                OBJ_MOTOR_GECKOFX_107.Stop() 'Para o carregamento
                Exit Select
            Case 108
                OBJ_MOTOR_GECKOFX_108.Stop() 'Para o carregamento
                Exit Select
            Case 109
                OBJ_MOTOR_GECKOFX_109.Stop() 'Para o carregamento
                Exit Select
            Case 110
                OBJ_MOTOR_GECKOFX_110.Stop() 'Para o carregamento
                Exit Select
            Case 111
                OBJ_MOTOR_GECKOFX_111.Stop() 'Para o carregamento
                Exit Select
            Case 112
                OBJ_MOTOR_GECKOFX_112.Stop() 'Para o carregamento
                Exit Select
            Case 113
                OBJ_MOTOR_GECKOFX_113.Stop() 'Para o carregamento
                Exit Select
            Case 114
                OBJ_MOTOR_GECKOFX_114.Stop() 'Para o carregamento
                Exit Select
            Case 115
                OBJ_MOTOR_GECKOFX_115.Stop() 'Para o carregamento
                Exit Select
            Case 116
                OBJ_MOTOR_GECKOFX_116.Stop() 'Para o carregamento
                Exit Select
            Case 117
                OBJ_MOTOR_GECKOFX_117.Stop() 'Para o carregamento
                Exit Select
            Case 118
                OBJ_MOTOR_GECKOFX_118.Stop() 'Para o carregamento
                Exit Select
            Case 119
                OBJ_MOTOR_GECKOFX_119.Stop() 'Para o carregamento
                Exit Select
            Case 120
                OBJ_MOTOR_GECKOFX_120.Stop() 'Para o carregamento
                Exit Select
            Case 121
                OBJ_MOTOR_GECKOFX_121.Stop() 'Para o carregamento
                Exit Select
            Case 122
                OBJ_MOTOR_GECKOFX_122.Stop() 'Para o carregamento
                Exit Select
            Case 123
                OBJ_MOTOR_GECKOFX_123.Stop() 'Para o carregamento
                Exit Select
            Case 124
                OBJ_MOTOR_GECKOFX_124.Stop() 'Para o carregamento
                Exit Select
            Case 125
                OBJ_MOTOR_GECKOFX_125.Stop() 'Para o carregamento
                Exit Select
            Case 126
                OBJ_MOTOR_GECKOFX_126.Stop() 'Para o carregamento
                Exit Select
            Case 127
                OBJ_MOTOR_GECKOFX_127.Stop() 'Para o carregamento
                Exit Select
            Case 128
                OBJ_MOTOR_GECKOFX_128.Stop() 'Para o carregamento
                Exit Select





        End Select


    End Sub

    Private Sub proc_parar_carregamento_trident() 'Para o carregamento da página trident
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso


            Case 1
                OBJ_MOTOR_WEB_BROWSER_1.Stop() 'Parar o carregamento
                Exit Select
            Case 2
                OBJ_MOTOR_WEB_BROWSER_2.Stop() 'Parar o carregamento
                Exit Select
            Case 3
                OBJ_MOTOR_WEB_BROWSER_3.Stop() 'Parar o carregamento
                Exit Select
            Case 4
                OBJ_MOTOR_WEB_BROWSER_4.Stop() 'Parar o carregamento
                Exit Select
            Case 5
                OBJ_MOTOR_WEB_BROWSER_5.Stop() 'Parar o carregamento
                Exit Select
            Case 6
                OBJ_MOTOR_WEB_BROWSER_6.Stop() 'Parar o carregamento
                Exit Select
            Case 7
                OBJ_MOTOR_WEB_BROWSER_7.Stop() 'Parar o carregamento
                Exit Select
            Case 8
                OBJ_MOTOR_WEB_BROWSER_8.Stop() 'Parar o carregamento
                Exit Select
            Case 9
                OBJ_MOTOR_WEB_BROWSER_9.Stop() 'Parar o carregamento
                Exit Select
            Case 10
                OBJ_MOTOR_WEB_BROWSER_10.Stop() 'Parar o carregamento
                Exit Select
            Case 11
                OBJ_MOTOR_WEB_BROWSER_11.Stop() 'Parar o carregamento
                Exit Select
            Case 12
                OBJ_MOTOR_WEB_BROWSER_12.Stop() 'Parar o carregamento
                Exit Select
            Case 13
                OBJ_MOTOR_WEB_BROWSER_13.Stop() 'Parar o carregamento
                Exit Select
            Case 14
                OBJ_MOTOR_WEB_BROWSER_14.Stop() 'Parar o carregamento
                Exit Select
            Case 15
                OBJ_MOTOR_WEB_BROWSER_15.Stop() 'Parar o carregamento
                Exit Select
            Case 16
                OBJ_MOTOR_WEB_BROWSER_16.Stop() 'Parar o carregamento
                Exit Select
            Case 17
                OBJ_MOTOR_WEB_BROWSER_17.Stop() 'Parar o carregamento
                Exit Select
            Case 18
                OBJ_MOTOR_WEB_BROWSER_18.Stop() 'Parar o carregamento
                Exit Select
            Case 19
                OBJ_MOTOR_WEB_BROWSER_19.Stop() 'Parar o carregamento
                Exit Select
            Case 20
                OBJ_MOTOR_WEB_BROWSER_20.Stop() 'Parar o carregamento
                Exit Select
            Case 21
                OBJ_MOTOR_WEB_BROWSER_21.Stop() 'Parar o carregamento
                Exit Select
            Case 22
                OBJ_MOTOR_WEB_BROWSER_22.Stop() 'Parar o carregamento
                Exit Select
            Case 23
                OBJ_MOTOR_WEB_BROWSER_23.Stop() 'Parar o carregamento
                Exit Select
            Case 24
                OBJ_MOTOR_WEB_BROWSER_24.Stop() 'Parar o carregamento
                Exit Select
            Case 25
                OBJ_MOTOR_WEB_BROWSER_25.Stop() 'Parar o carregamento
                Exit Select
            Case 26
                OBJ_MOTOR_WEB_BROWSER_26.Stop() 'Parar o carregamento
                Exit Select
            Case 27
                OBJ_MOTOR_WEB_BROWSER_27.Stop() 'Parar o carregamento
                Exit Select
            Case 28
                OBJ_MOTOR_WEB_BROWSER_28.Stop() 'Parar o carregamento
                Exit Select
            Case 29
                OBJ_MOTOR_WEB_BROWSER_29.Stop() 'Parar o carregamento
                Exit Select
            Case 30
                OBJ_MOTOR_WEB_BROWSER_30.Stop() 'Parar o carregamento
                Exit Select
            Case 31
                OBJ_MOTOR_WEB_BROWSER_31.Stop() 'Parar o carregamento
                Exit Select
            Case 32
                OBJ_MOTOR_WEB_BROWSER_32.Stop() 'Parar o carregamento
                Exit Select
            Case 33
                OBJ_MOTOR_WEB_BROWSER_33.Stop() 'Parar o carregamento
                Exit Select
            Case 34
                OBJ_MOTOR_WEB_BROWSER_34.Stop() 'Parar o carregamento
                Exit Select
            Case 35
                OBJ_MOTOR_WEB_BROWSER_35.Stop() 'Parar o carregamento
                Exit Select
            Case 36
                OBJ_MOTOR_WEB_BROWSER_36.Stop() 'Parar o carregamento
                Exit Select
            Case 37
                OBJ_MOTOR_WEB_BROWSER_37.Stop() 'Parar o carregamento
                Exit Select
            Case 38
                OBJ_MOTOR_WEB_BROWSER_38.Stop() 'Parar o carregamento
                Exit Select
            Case 39
                OBJ_MOTOR_WEB_BROWSER_39.Stop() 'Parar o carregamento
                Exit Select
            Case 40
                OBJ_MOTOR_WEB_BROWSER_40.Stop() 'Parar o carregamento
                Exit Select
            Case 41
                OBJ_MOTOR_WEB_BROWSER_41.Stop() 'Parar o carregamento
                Exit Select
            Case 42
                OBJ_MOTOR_WEB_BROWSER_42.Stop() 'Parar o carregamento
                Exit Select
            Case 43
                OBJ_MOTOR_WEB_BROWSER_43.Stop() 'Parar o carregamento
                Exit Select
            Case 44
                OBJ_MOTOR_WEB_BROWSER_44.Stop() 'Parar o carregamento
                Exit Select
            Case 45
                OBJ_MOTOR_WEB_BROWSER_45.Stop() 'Parar o carregamento
                Exit Select
            Case 46
                OBJ_MOTOR_WEB_BROWSER_46.Stop() 'Parar o carregamento
                Exit Select
            Case 47
                OBJ_MOTOR_WEB_BROWSER_47.Stop() 'Parar o carregamento
                Exit Select
            Case 48
                OBJ_MOTOR_WEB_BROWSER_48.Stop() 'Parar o carregamento
                Exit Select
            Case 49
                OBJ_MOTOR_WEB_BROWSER_49.Stop() 'Parar o carregamento
                Exit Select
            Case 50
                OBJ_MOTOR_WEB_BROWSER_50.Stop() 'Parar o carregamento
                Exit Select
            Case 51
                OBJ_MOTOR_WEB_BROWSER_51.Stop() 'Parar o carregamento
                Exit Select
            Case 52
                OBJ_MOTOR_WEB_BROWSER_52.Stop() 'Parar o carregamento
                Exit Select
            Case 53
                OBJ_MOTOR_WEB_BROWSER_53.Stop() 'Parar o carregamento
                Exit Select
            Case 54
                OBJ_MOTOR_WEB_BROWSER_54.Stop() 'Parar o carregamento
                Exit Select
            Case 55
                OBJ_MOTOR_WEB_BROWSER_55.Stop() 'Parar o carregamento
                Exit Select
            Case 56
                OBJ_MOTOR_WEB_BROWSER_56.Stop() 'Parar o carregamento
                Exit Select
            Case 57
                OBJ_MOTOR_WEB_BROWSER_57.Stop() 'Parar o carregamento
                Exit Select
            Case 58
                OBJ_MOTOR_WEB_BROWSER_58.Stop() 'Parar o carregamento
                Exit Select
            Case 59
                OBJ_MOTOR_WEB_BROWSER_59.Stop() 'Parar o carregamento
                Exit Select
            Case 60
                OBJ_MOTOR_WEB_BROWSER_60.Stop() 'Parar o carregamento
                Exit Select
            Case 61
                OBJ_MOTOR_WEB_BROWSER_61.Stop() 'Parar o carregamento
                Exit Select
            Case 62
                OBJ_MOTOR_WEB_BROWSER_62.Stop() 'Parar o carregamento
                Exit Select
            Case 63
                OBJ_MOTOR_WEB_BROWSER_63.Stop() 'Parar o carregamento
                Exit Select
            Case 64
                OBJ_MOTOR_WEB_BROWSER_64.Stop() 'Parar o carregamento
                Exit Select
            Case 65
                OBJ_MOTOR_WEB_BROWSER_65.Stop() 'Parar o carregamento
                Exit Select
            Case 66
                OBJ_MOTOR_WEB_BROWSER_66.Stop() 'Parar o carregamento
                Exit Select
            Case 67
                OBJ_MOTOR_WEB_BROWSER_67.Stop() 'Parar o carregamento
                Exit Select
            Case 68
                OBJ_MOTOR_WEB_BROWSER_68.Stop() 'Parar o carregamento
                Exit Select
            Case 69
                OBJ_MOTOR_WEB_BROWSER_69.Stop() 'Parar o carregamento
                Exit Select
            Case 70
                OBJ_MOTOR_WEB_BROWSER_70.Stop() 'Parar o carregamento
                Exit Select
            Case 71
                OBJ_MOTOR_WEB_BROWSER_71.Stop() 'Parar o carregamento
                Exit Select
            Case 72
                OBJ_MOTOR_WEB_BROWSER_72.Stop() 'Parar o carregamento
                Exit Select
            Case 73
                OBJ_MOTOR_WEB_BROWSER_73.Stop() 'Parar o carregamento
                Exit Select
            Case 74
                OBJ_MOTOR_WEB_BROWSER_74.Stop() 'Parar o carregamento
                Exit Select
            Case 75
                OBJ_MOTOR_WEB_BROWSER_75.Stop() 'Parar o carregamento
                Exit Select
            Case 76
                OBJ_MOTOR_WEB_BROWSER_76.Stop() 'Parar o carregamento
                Exit Select
            Case 77
                OBJ_MOTOR_WEB_BROWSER_77.Stop() 'Parar o carregamento
                Exit Select
            Case 78
                OBJ_MOTOR_WEB_BROWSER_78.Stop() 'Parar o carregamento
                Exit Select
            Case 79
                OBJ_MOTOR_WEB_BROWSER_79.Stop() 'Parar o carregamento
                Exit Select
            Case 80
                OBJ_MOTOR_WEB_BROWSER_80.Stop() 'Parar o carregamento
                Exit Select
            Case 81
                OBJ_MOTOR_WEB_BROWSER_81.Stop() 'Parar o carregamento
                Exit Select
            Case 82
                OBJ_MOTOR_WEB_BROWSER_82.Stop() 'Parar o carregamento
                Exit Select
            Case 83
                OBJ_MOTOR_WEB_BROWSER_83.Stop() 'Parar o carregamento
                Exit Select
            Case 84
                OBJ_MOTOR_WEB_BROWSER_84.Stop() 'Parar o carregamento
                Exit Select
            Case 85
                OBJ_MOTOR_WEB_BROWSER_85.Stop() 'Parar o carregamento
                Exit Select
            Case 86
                OBJ_MOTOR_WEB_BROWSER_86.Stop() 'Parar o carregamento
                Exit Select
            Case 87
                OBJ_MOTOR_WEB_BROWSER_87.Stop() 'Parar o carregamento
                Exit Select
            Case 88
                OBJ_MOTOR_WEB_BROWSER_88.Stop() 'Parar o carregamento
                Exit Select
            Case 89
                OBJ_MOTOR_WEB_BROWSER_89.Stop() 'Parar o carregamento
                Exit Select
            Case 90
                OBJ_MOTOR_WEB_BROWSER_90.Stop() 'Parar o carregamento
                Exit Select
            Case 91
                OBJ_MOTOR_WEB_BROWSER_91.Stop() 'Parar o carregamento
                Exit Select
            Case 92
                OBJ_MOTOR_WEB_BROWSER_92.Stop() 'Parar o carregamento
                Exit Select
            Case 93
                OBJ_MOTOR_WEB_BROWSER_93.Stop() 'Parar o carregamento
                Exit Select
            Case 94
                OBJ_MOTOR_WEB_BROWSER_94.Stop() 'Parar o carregamento
                Exit Select
            Case 95
                OBJ_MOTOR_WEB_BROWSER_95.Stop() 'Parar o carregamento
                Exit Select
            Case 96
                OBJ_MOTOR_WEB_BROWSER_96.Stop() 'Parar o carregamento
                Exit Select
            Case 97
                OBJ_MOTOR_WEB_BROWSER_97.Stop() 'Parar o carregamento
                Exit Select
            Case 98
                OBJ_MOTOR_WEB_BROWSER_98.Stop() 'Parar o carregamento
                Exit Select
            Case 99
                OBJ_MOTOR_WEB_BROWSER_99.Stop() 'Parar o carregamento
                Exit Select
            Case 100
                OBJ_MOTOR_WEB_BROWSER_100.Stop() 'Parar o carregamento
                Exit Select
            Case 101
                OBJ_MOTOR_WEB_BROWSER_101.Stop() 'Parar o carregamento
                Exit Select
            Case 102
                OBJ_MOTOR_WEB_BROWSER_102.Stop() 'Parar o carregamento
                Exit Select
            Case 103
                OBJ_MOTOR_WEB_BROWSER_103.Stop() 'Parar o carregamento
                Exit Select
            Case 104
                OBJ_MOTOR_WEB_BROWSER_104.Stop() 'Parar o carregamento
                Exit Select
            Case 105
                OBJ_MOTOR_WEB_BROWSER_105.Stop() 'Parar o carregamento
                Exit Select
            Case 106
                OBJ_MOTOR_WEB_BROWSER_106.Stop() 'Parar o carregamento
                Exit Select
            Case 107
                OBJ_MOTOR_WEB_BROWSER_107.Stop() 'Parar o carregamento
                Exit Select
            Case 108
                OBJ_MOTOR_WEB_BROWSER_108.Stop() 'Parar o carregamento
                Exit Select
            Case 109
                OBJ_MOTOR_WEB_BROWSER_109.Stop() 'Parar o carregamento
                Exit Select
            Case 110
                OBJ_MOTOR_WEB_BROWSER_110.Stop() 'Parar o carregamento
                Exit Select
            Case 111
                OBJ_MOTOR_WEB_BROWSER_111.Stop() 'Parar o carregamento
                Exit Select
            Case 112
                OBJ_MOTOR_WEB_BROWSER_112.Stop() 'Parar o carregamento
                Exit Select
            Case 113
                OBJ_MOTOR_WEB_BROWSER_113.Stop() 'Parar o carregamento
                Exit Select
            Case 114
                OBJ_MOTOR_WEB_BROWSER_114.Stop() 'Parar o carregamento
                Exit Select
            Case 115
                OBJ_MOTOR_WEB_BROWSER_115.Stop() 'Parar o carregamento
                Exit Select
            Case 116
                OBJ_MOTOR_WEB_BROWSER_116.Stop() 'Parar o carregamento
                Exit Select
            Case 117
                OBJ_MOTOR_WEB_BROWSER_117.Stop() 'Parar o carregamento
                Exit Select
            Case 118
                OBJ_MOTOR_WEB_BROWSER_118.Stop() 'Parar o carregamento
                Exit Select
            Case 119
                OBJ_MOTOR_WEB_BROWSER_119.Stop() 'Parar o carregamento
                Exit Select
            Case 120
                OBJ_MOTOR_WEB_BROWSER_120.Stop() 'Parar o carregamento
                Exit Select
            Case 121
                OBJ_MOTOR_WEB_BROWSER_121.Stop() 'Parar o carregamento
                Exit Select
            Case 122
                OBJ_MOTOR_WEB_BROWSER_122.Stop() 'Parar o carregamento
                Exit Select
            Case 123
                OBJ_MOTOR_WEB_BROWSER_123.Stop() 'Parar o carregamento
                Exit Select
            Case 124
                OBJ_MOTOR_WEB_BROWSER_124.Stop() 'Parar o carregamento
                Exit Select
            Case 125
                OBJ_MOTOR_WEB_BROWSER_125.Stop() 'Parar o carregamento
                Exit Select
            Case 126
                OBJ_MOTOR_WEB_BROWSER_126.Stop() 'Parar o carregamento
                Exit Select
            Case 127
                OBJ_MOTOR_WEB_BROWSER_127.Stop() 'Parar o carregamento
                Exit Select
            Case 128
                OBJ_MOTOR_WEB_BROWSER_128.Stop() 'Parar o carregamento
                Exit Select





        End Select


    End Sub

    Public Sub proc_para_carregamento_pagina_visualizacao() 'Para o carregamento da página em visualização
        On Error Resume Next


        'Selecionando o tipo de motor ----------------------------------------------------------------------------------

        If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then


            proc_parar_carregamento_geckofx() 'Para o carregamento da página geckofx


        Else


            proc_parar_carregamento_trident() 'Para o carregamento da página trident


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

































End Module
