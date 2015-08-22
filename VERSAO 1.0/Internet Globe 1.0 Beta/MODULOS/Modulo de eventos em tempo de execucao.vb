Imports System.ComponentModel

Module Modulo_de_eventos_em_tempo_de_execucao









    'Ligando eventos...


    'Carregamento de pagina progresso

    Private Sub proc_ligar_evento_carregamento_de_pagina_geckofx() 'Liga o evento de carregamento de página
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso


            Case 1
                AddHandler OBJ_MOTOR_GECKOFX_1.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_1
                Exit Select
            Case 2
                AddHandler OBJ_MOTOR_GECKOFX_2.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_2
                Exit Select
            Case 3
                AddHandler OBJ_MOTOR_GECKOFX_3.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_3
                Exit Select
            Case 4
                AddHandler OBJ_MOTOR_GECKOFX_4.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_4
                Exit Select
            Case 5
                AddHandler OBJ_MOTOR_GECKOFX_5.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_5
                Exit Select
            Case 6
                AddHandler OBJ_MOTOR_GECKOFX_6.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_6
                Exit Select
            Case 7
                AddHandler OBJ_MOTOR_GECKOFX_7.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_7
                Exit Select
            Case 8
                AddHandler OBJ_MOTOR_GECKOFX_8.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_8
                Exit Select
            Case 9
                AddHandler OBJ_MOTOR_GECKOFX_9.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_9
                Exit Select
            Case 10
                AddHandler OBJ_MOTOR_GECKOFX_10.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_10
                Exit Select
            Case 11
                AddHandler OBJ_MOTOR_GECKOFX_11.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_11
                Exit Select
            Case 12
                AddHandler OBJ_MOTOR_GECKOFX_12.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_12
                Exit Select
            Case 13
                AddHandler OBJ_MOTOR_GECKOFX_13.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_13
                Exit Select
            Case 14
                AddHandler OBJ_MOTOR_GECKOFX_14.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_14
                Exit Select
            Case 15
                AddHandler OBJ_MOTOR_GECKOFX_15.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_15
                Exit Select
            Case 16
                AddHandler OBJ_MOTOR_GECKOFX_16.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_16
                Exit Select
            Case 17
                AddHandler OBJ_MOTOR_GECKOFX_17.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_17
                Exit Select
            Case 18
                AddHandler OBJ_MOTOR_GECKOFX_18.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_18
                Exit Select
            Case 19
                AddHandler OBJ_MOTOR_GECKOFX_19.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_19
                Exit Select
            Case 20
                AddHandler OBJ_MOTOR_GECKOFX_20.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_20
                Exit Select
            Case 21
                AddHandler OBJ_MOTOR_GECKOFX_21.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_21
                Exit Select
            Case 22
                AddHandler OBJ_MOTOR_GECKOFX_22.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_22
                Exit Select
            Case 23
                AddHandler OBJ_MOTOR_GECKOFX_23.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_23
                Exit Select
            Case 24
                AddHandler OBJ_MOTOR_GECKOFX_24.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_24
                Exit Select
            Case 25
                AddHandler OBJ_MOTOR_GECKOFX_25.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_25
                Exit Select
            Case 26
                AddHandler OBJ_MOTOR_GECKOFX_26.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_26
                Exit Select
            Case 27
                AddHandler OBJ_MOTOR_GECKOFX_27.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_27
                Exit Select
            Case 28
                AddHandler OBJ_MOTOR_GECKOFX_28.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_28
                Exit Select
            Case 29
                AddHandler OBJ_MOTOR_GECKOFX_29.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_29
                Exit Select
            Case 30
                AddHandler OBJ_MOTOR_GECKOFX_30.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_30
                Exit Select
            Case 31
                AddHandler OBJ_MOTOR_GECKOFX_31.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_31
                Exit Select
            Case 32
                AddHandler OBJ_MOTOR_GECKOFX_32.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_32
                Exit Select
            Case 33
                AddHandler OBJ_MOTOR_GECKOFX_33.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_33
                Exit Select
            Case 34
                AddHandler OBJ_MOTOR_GECKOFX_34.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_34
                Exit Select
            Case 35
                AddHandler OBJ_MOTOR_GECKOFX_35.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_35
                Exit Select
            Case 36
                AddHandler OBJ_MOTOR_GECKOFX_36.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_36
                Exit Select
            Case 37
                AddHandler OBJ_MOTOR_GECKOFX_37.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_37
                Exit Select
            Case 38
                AddHandler OBJ_MOTOR_GECKOFX_38.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_38
                Exit Select
            Case 39
                AddHandler OBJ_MOTOR_GECKOFX_39.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_39
                Exit Select
            Case 40
                AddHandler OBJ_MOTOR_GECKOFX_40.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_40
                Exit Select
            Case 41
                AddHandler OBJ_MOTOR_GECKOFX_41.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_41
                Exit Select
            Case 42
                AddHandler OBJ_MOTOR_GECKOFX_42.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_42
                Exit Select
            Case 43
                AddHandler OBJ_MOTOR_GECKOFX_43.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_43
                Exit Select
            Case 44
                AddHandler OBJ_MOTOR_GECKOFX_44.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_44
                Exit Select
            Case 45
                AddHandler OBJ_MOTOR_GECKOFX_45.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_45
                Exit Select
            Case 46
                AddHandler OBJ_MOTOR_GECKOFX_46.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_46
                Exit Select
            Case 47
                AddHandler OBJ_MOTOR_GECKOFX_47.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_47
                Exit Select
            Case 48
                AddHandler OBJ_MOTOR_GECKOFX_48.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_48
                Exit Select
            Case 49
                AddHandler OBJ_MOTOR_GECKOFX_49.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_49
                Exit Select
            Case 50
                AddHandler OBJ_MOTOR_GECKOFX_50.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_50
                Exit Select
            Case 51
                AddHandler OBJ_MOTOR_GECKOFX_51.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_51
                Exit Select
            Case 52
                AddHandler OBJ_MOTOR_GECKOFX_52.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_52
                Exit Select
            Case 53
                AddHandler OBJ_MOTOR_GECKOFX_53.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_53
                Exit Select
            Case 54
                AddHandler OBJ_MOTOR_GECKOFX_54.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_54
                Exit Select
            Case 55
                AddHandler OBJ_MOTOR_GECKOFX_55.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_55
                Exit Select
            Case 56
                AddHandler OBJ_MOTOR_GECKOFX_56.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_56
                Exit Select
            Case 57
                AddHandler OBJ_MOTOR_GECKOFX_57.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_57
                Exit Select
            Case 58
                AddHandler OBJ_MOTOR_GECKOFX_58.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_58
                Exit Select
            Case 59
                AddHandler OBJ_MOTOR_GECKOFX_59.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_59
                Exit Select
            Case 60
                AddHandler OBJ_MOTOR_GECKOFX_60.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_60
                Exit Select
            Case 61
                AddHandler OBJ_MOTOR_GECKOFX_61.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_61
                Exit Select
            Case 62
                AddHandler OBJ_MOTOR_GECKOFX_62.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_62
                Exit Select
            Case 63
                AddHandler OBJ_MOTOR_GECKOFX_63.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_63
                Exit Select
            Case 64
                AddHandler OBJ_MOTOR_GECKOFX_64.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_64
                Exit Select
            Case 65
                AddHandler OBJ_MOTOR_GECKOFX_65.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_65
                Exit Select
            Case 66
                AddHandler OBJ_MOTOR_GECKOFX_66.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_66
                Exit Select
            Case 67
                AddHandler OBJ_MOTOR_GECKOFX_67.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_67
                Exit Select
            Case 68
                AddHandler OBJ_MOTOR_GECKOFX_68.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_68
                Exit Select
            Case 69
                AddHandler OBJ_MOTOR_GECKOFX_69.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_69
                Exit Select
            Case 70
                AddHandler OBJ_MOTOR_GECKOFX_70.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_70
                Exit Select
            Case 71
                AddHandler OBJ_MOTOR_GECKOFX_71.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_71
                Exit Select
            Case 72
                AddHandler OBJ_MOTOR_GECKOFX_72.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_72
                Exit Select
            Case 73
                AddHandler OBJ_MOTOR_GECKOFX_73.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_73
                Exit Select
            Case 74
                AddHandler OBJ_MOTOR_GECKOFX_74.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_74
                Exit Select
            Case 75
                AddHandler OBJ_MOTOR_GECKOFX_75.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_75
                Exit Select
            Case 76
                AddHandler OBJ_MOTOR_GECKOFX_76.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_76
                Exit Select
            Case 77
                AddHandler OBJ_MOTOR_GECKOFX_77.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_77
                Exit Select
            Case 78
                AddHandler OBJ_MOTOR_GECKOFX_78.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_78
                Exit Select
            Case 79
                AddHandler OBJ_MOTOR_GECKOFX_79.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_79
                Exit Select
            Case 80
                AddHandler OBJ_MOTOR_GECKOFX_80.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_80
                Exit Select
            Case 81
                AddHandler OBJ_MOTOR_GECKOFX_81.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_81
                Exit Select
            Case 82
                AddHandler OBJ_MOTOR_GECKOFX_82.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_82
                Exit Select
            Case 83
                AddHandler OBJ_MOTOR_GECKOFX_83.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_83
                Exit Select
            Case 84
                AddHandler OBJ_MOTOR_GECKOFX_84.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_84
                Exit Select
            Case 85
                AddHandler OBJ_MOTOR_GECKOFX_85.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_85
                Exit Select
            Case 86
                AddHandler OBJ_MOTOR_GECKOFX_86.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_86
                Exit Select
            Case 87
                AddHandler OBJ_MOTOR_GECKOFX_87.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_87
                Exit Select
            Case 88
                AddHandler OBJ_MOTOR_GECKOFX_88.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_88
                Exit Select
            Case 89
                AddHandler OBJ_MOTOR_GECKOFX_89.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_89
                Exit Select
            Case 90
                AddHandler OBJ_MOTOR_GECKOFX_90.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_90
                Exit Select
            Case 91
                AddHandler OBJ_MOTOR_GECKOFX_91.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_91
                Exit Select
            Case 92
                AddHandler OBJ_MOTOR_GECKOFX_92.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_92
                Exit Select
            Case 93
                AddHandler OBJ_MOTOR_GECKOFX_93.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_93
                Exit Select
            Case 94
                AddHandler OBJ_MOTOR_GECKOFX_94.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_94
                Exit Select
            Case 95
                AddHandler OBJ_MOTOR_GECKOFX_95.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_95
                Exit Select
            Case 96
                AddHandler OBJ_MOTOR_GECKOFX_96.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_96
                Exit Select
            Case 97
                AddHandler OBJ_MOTOR_GECKOFX_97.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_97
                Exit Select
            Case 98
                AddHandler OBJ_MOTOR_GECKOFX_98.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_98
                Exit Select
            Case 99
                AddHandler OBJ_MOTOR_GECKOFX_99.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_99
                Exit Select
            Case 100
                AddHandler OBJ_MOTOR_GECKOFX_100.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_100
                Exit Select
            Case 101
                AddHandler OBJ_MOTOR_GECKOFX_101.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_101
                Exit Select
            Case 102
                AddHandler OBJ_MOTOR_GECKOFX_102.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_102
                Exit Select
            Case 103
                AddHandler OBJ_MOTOR_GECKOFX_103.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_103
                Exit Select
            Case 104
                AddHandler OBJ_MOTOR_GECKOFX_104.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_104
                Exit Select
            Case 105
                AddHandler OBJ_MOTOR_GECKOFX_105.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_105
                Exit Select
            Case 106
                AddHandler OBJ_MOTOR_GECKOFX_106.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_106
                Exit Select
            Case 107
                AddHandler OBJ_MOTOR_GECKOFX_107.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_107
                Exit Select
            Case 108
                AddHandler OBJ_MOTOR_GECKOFX_108.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_108
                Exit Select
            Case 109
                AddHandler OBJ_MOTOR_GECKOFX_109.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_109
                Exit Select
            Case 110
                AddHandler OBJ_MOTOR_GECKOFX_110.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_110
                Exit Select
            Case 111
                AddHandler OBJ_MOTOR_GECKOFX_111.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_111
                Exit Select
            Case 112
                AddHandler OBJ_MOTOR_GECKOFX_112.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_112
                Exit Select
            Case 113
                AddHandler OBJ_MOTOR_GECKOFX_113.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_113
                Exit Select
            Case 114
                AddHandler OBJ_MOTOR_GECKOFX_114.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_114
                Exit Select
            Case 115
                AddHandler OBJ_MOTOR_GECKOFX_115.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_115
                Exit Select
            Case 116
                AddHandler OBJ_MOTOR_GECKOFX_116.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_116
                Exit Select
            Case 117
                AddHandler OBJ_MOTOR_GECKOFX_117.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_117
                Exit Select
            Case 118
                AddHandler OBJ_MOTOR_GECKOFX_118.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_118
                Exit Select
            Case 119
                AddHandler OBJ_MOTOR_GECKOFX_119.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_119
                Exit Select
            Case 120
                AddHandler OBJ_MOTOR_GECKOFX_120.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_120
                Exit Select
            Case 121
                AddHandler OBJ_MOTOR_GECKOFX_121.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_121
                Exit Select
            Case 122
                AddHandler OBJ_MOTOR_GECKOFX_122.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_122
                Exit Select
            Case 123
                AddHandler OBJ_MOTOR_GECKOFX_123.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_123
                Exit Select
            Case 124
                AddHandler OBJ_MOTOR_GECKOFX_124.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_124
                Exit Select
            Case 125
                AddHandler OBJ_MOTOR_GECKOFX_125.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_125
                Exit Select
            Case 126
                AddHandler OBJ_MOTOR_GECKOFX_126.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_126
                Exit Select
            Case 127
                AddHandler OBJ_MOTOR_GECKOFX_127.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_127
                Exit Select
            Case 128
                AddHandler OBJ_MOTOR_GECKOFX_128.ProgressChanged, AddressOf proc_carregamento_motor_geckofx_128
                Exit Select
            



        End Select


    End Sub

    Private Sub proc_ligar_evento_carregamento_de_pagina_trident() 'Liga o evento de carregamento de página
        On Error Resume Next



        Select Case v_qual_motor_esta_em_uso


            Case 1
                AddHandler OBJ_MOTOR_WEB_BROWSER_1.ProgressChanged, AddressOf proc_carregamento_motor_trident_1
                Exit Select
            Case 2
                AddHandler OBJ_MOTOR_WEB_BROWSER_2.ProgressChanged, AddressOf proc_carregamento_motor_trident_2
                Exit Select
            Case 3
                AddHandler OBJ_MOTOR_WEB_BROWSER_3.ProgressChanged, AddressOf proc_carregamento_motor_trident_3
                Exit Select
            Case 4
                AddHandler OBJ_MOTOR_WEB_BROWSER_4.ProgressChanged, AddressOf proc_carregamento_motor_trident_4
                Exit Select
            Case 5
                AddHandler OBJ_MOTOR_WEB_BROWSER_5.ProgressChanged, AddressOf proc_carregamento_motor_trident_5
                Exit Select
            Case 6
                AddHandler OBJ_MOTOR_WEB_BROWSER_6.ProgressChanged, AddressOf proc_carregamento_motor_trident_6
                Exit Select
            Case 7
                AddHandler OBJ_MOTOR_WEB_BROWSER_7.ProgressChanged, AddressOf proc_carregamento_motor_trident_7
                Exit Select
            Case 8
                AddHandler OBJ_MOTOR_WEB_BROWSER_8.ProgressChanged, AddressOf proc_carregamento_motor_trident_8
                Exit Select
            Case 9
                AddHandler OBJ_MOTOR_WEB_BROWSER_9.ProgressChanged, AddressOf proc_carregamento_motor_trident_9
                Exit Select
            Case 10
                AddHandler OBJ_MOTOR_WEB_BROWSER_10.ProgressChanged, AddressOf proc_carregamento_motor_trident_10
                Exit Select
            Case 11
                AddHandler OBJ_MOTOR_WEB_BROWSER_11.ProgressChanged, AddressOf proc_carregamento_motor_trident_11
                Exit Select
            Case 12
                AddHandler OBJ_MOTOR_WEB_BROWSER_12.ProgressChanged, AddressOf proc_carregamento_motor_trident_12
                Exit Select
            Case 13
                AddHandler OBJ_MOTOR_WEB_BROWSER_13.ProgressChanged, AddressOf proc_carregamento_motor_trident_13
                Exit Select
            Case 14
                AddHandler OBJ_MOTOR_WEB_BROWSER_14.ProgressChanged, AddressOf proc_carregamento_motor_trident_14
                Exit Select
            Case 15
                AddHandler OBJ_MOTOR_WEB_BROWSER_15.ProgressChanged, AddressOf proc_carregamento_motor_trident_15
                Exit Select
            Case 16
                AddHandler OBJ_MOTOR_WEB_BROWSER_16.ProgressChanged, AddressOf proc_carregamento_motor_trident_16
                Exit Select
            Case 17
                AddHandler OBJ_MOTOR_WEB_BROWSER_17.ProgressChanged, AddressOf proc_carregamento_motor_trident_17
                Exit Select
            Case 18
                AddHandler OBJ_MOTOR_WEB_BROWSER_18.ProgressChanged, AddressOf proc_carregamento_motor_trident_18
                Exit Select
            Case 19
                AddHandler OBJ_MOTOR_WEB_BROWSER_19.ProgressChanged, AddressOf proc_carregamento_motor_trident_19
                Exit Select
            Case 20
                AddHandler OBJ_MOTOR_WEB_BROWSER_20.ProgressChanged, AddressOf proc_carregamento_motor_trident_20
                Exit Select
            Case 21
                AddHandler OBJ_MOTOR_WEB_BROWSER_21.ProgressChanged, AddressOf proc_carregamento_motor_trident_21
                Exit Select
            Case 22
                AddHandler OBJ_MOTOR_WEB_BROWSER_22.ProgressChanged, AddressOf proc_carregamento_motor_trident_22
                Exit Select
            Case 23
                AddHandler OBJ_MOTOR_WEB_BROWSER_23.ProgressChanged, AddressOf proc_carregamento_motor_trident_23
                Exit Select
            Case 24
                AddHandler OBJ_MOTOR_WEB_BROWSER_24.ProgressChanged, AddressOf proc_carregamento_motor_trident_24
                Exit Select
            Case 25
                AddHandler OBJ_MOTOR_WEB_BROWSER_25.ProgressChanged, AddressOf proc_carregamento_motor_trident_25
                Exit Select
            Case 26
                AddHandler OBJ_MOTOR_WEB_BROWSER_26.ProgressChanged, AddressOf proc_carregamento_motor_trident_26
                Exit Select
            Case 27
                AddHandler OBJ_MOTOR_WEB_BROWSER_27.ProgressChanged, AddressOf proc_carregamento_motor_trident_27
                Exit Select
            Case 28
                AddHandler OBJ_MOTOR_WEB_BROWSER_28.ProgressChanged, AddressOf proc_carregamento_motor_trident_28
                Exit Select
            Case 29
                AddHandler OBJ_MOTOR_WEB_BROWSER_29.ProgressChanged, AddressOf proc_carregamento_motor_trident_29
                Exit Select
            Case 30
                AddHandler OBJ_MOTOR_WEB_BROWSER_30.ProgressChanged, AddressOf proc_carregamento_motor_trident_30
                Exit Select
            Case 31
                AddHandler OBJ_MOTOR_WEB_BROWSER_31.ProgressChanged, AddressOf proc_carregamento_motor_trident_31
                Exit Select
            Case 32
                AddHandler OBJ_MOTOR_WEB_BROWSER_32.ProgressChanged, AddressOf proc_carregamento_motor_trident_32
                Exit Select
            Case 33
                AddHandler OBJ_MOTOR_WEB_BROWSER_33.ProgressChanged, AddressOf proc_carregamento_motor_trident_33
                Exit Select
            Case 34
                AddHandler OBJ_MOTOR_WEB_BROWSER_34.ProgressChanged, AddressOf proc_carregamento_motor_trident_34
                Exit Select
            Case 35
                AddHandler OBJ_MOTOR_WEB_BROWSER_35.ProgressChanged, AddressOf proc_carregamento_motor_trident_35
                Exit Select
            Case 36
                AddHandler OBJ_MOTOR_WEB_BROWSER_36.ProgressChanged, AddressOf proc_carregamento_motor_trident_36
                Exit Select
            Case 37
                AddHandler OBJ_MOTOR_WEB_BROWSER_37.ProgressChanged, AddressOf proc_carregamento_motor_trident_37
                Exit Select
            Case 38
                AddHandler OBJ_MOTOR_WEB_BROWSER_38.ProgressChanged, AddressOf proc_carregamento_motor_trident_38
                Exit Select
            Case 39
                AddHandler OBJ_MOTOR_WEB_BROWSER_39.ProgressChanged, AddressOf proc_carregamento_motor_trident_39
                Exit Select
            Case 40
                AddHandler OBJ_MOTOR_WEB_BROWSER_40.ProgressChanged, AddressOf proc_carregamento_motor_trident_40
                Exit Select
            Case 41
                AddHandler OBJ_MOTOR_WEB_BROWSER_41.ProgressChanged, AddressOf proc_carregamento_motor_trident_41
                Exit Select
            Case 42
                AddHandler OBJ_MOTOR_WEB_BROWSER_42.ProgressChanged, AddressOf proc_carregamento_motor_trident_42
                Exit Select
            Case 43
                AddHandler OBJ_MOTOR_WEB_BROWSER_43.ProgressChanged, AddressOf proc_carregamento_motor_trident_43
                Exit Select
            Case 44
                AddHandler OBJ_MOTOR_WEB_BROWSER_44.ProgressChanged, AddressOf proc_carregamento_motor_trident_44
                Exit Select
            Case 45
                AddHandler OBJ_MOTOR_WEB_BROWSER_45.ProgressChanged, AddressOf proc_carregamento_motor_trident_45
                Exit Select
            Case 46
                AddHandler OBJ_MOTOR_WEB_BROWSER_46.ProgressChanged, AddressOf proc_carregamento_motor_trident_46
                Exit Select
            Case 47
                AddHandler OBJ_MOTOR_WEB_BROWSER_47.ProgressChanged, AddressOf proc_carregamento_motor_trident_47
                Exit Select
            Case 48
                AddHandler OBJ_MOTOR_WEB_BROWSER_48.ProgressChanged, AddressOf proc_carregamento_motor_trident_48
                Exit Select
            Case 49
                AddHandler OBJ_MOTOR_WEB_BROWSER_49.ProgressChanged, AddressOf proc_carregamento_motor_trident_49
                Exit Select
            Case 50
                AddHandler OBJ_MOTOR_WEB_BROWSER_50.ProgressChanged, AddressOf proc_carregamento_motor_trident_50
                Exit Select
            Case 51
                AddHandler OBJ_MOTOR_WEB_BROWSER_51.ProgressChanged, AddressOf proc_carregamento_motor_trident_51
                Exit Select
            Case 52
                AddHandler OBJ_MOTOR_WEB_BROWSER_52.ProgressChanged, AddressOf proc_carregamento_motor_trident_52
                Exit Select
            Case 53
                AddHandler OBJ_MOTOR_WEB_BROWSER_53.ProgressChanged, AddressOf proc_carregamento_motor_trident_53
                Exit Select
            Case 54
                AddHandler OBJ_MOTOR_WEB_BROWSER_54.ProgressChanged, AddressOf proc_carregamento_motor_trident_54
                Exit Select
            Case 55
                AddHandler OBJ_MOTOR_WEB_BROWSER_55.ProgressChanged, AddressOf proc_carregamento_motor_trident_55
                Exit Select
            Case 56
                AddHandler OBJ_MOTOR_WEB_BROWSER_56.ProgressChanged, AddressOf proc_carregamento_motor_trident_56
                Exit Select
            Case 57
                AddHandler OBJ_MOTOR_WEB_BROWSER_57.ProgressChanged, AddressOf proc_carregamento_motor_trident_57
                Exit Select
            Case 58
                AddHandler OBJ_MOTOR_WEB_BROWSER_58.ProgressChanged, AddressOf proc_carregamento_motor_trident_58
                Exit Select
            Case 59
                AddHandler OBJ_MOTOR_WEB_BROWSER_59.ProgressChanged, AddressOf proc_carregamento_motor_trident_59
                Exit Select
            Case 60
                AddHandler OBJ_MOTOR_WEB_BROWSER_60.ProgressChanged, AddressOf proc_carregamento_motor_trident_60
                Exit Select
            Case 61
                AddHandler OBJ_MOTOR_WEB_BROWSER_61.ProgressChanged, AddressOf proc_carregamento_motor_trident_61
                Exit Select
            Case 62
                AddHandler OBJ_MOTOR_WEB_BROWSER_62.ProgressChanged, AddressOf proc_carregamento_motor_trident_62
                Exit Select
            Case 63
                AddHandler OBJ_MOTOR_WEB_BROWSER_63.ProgressChanged, AddressOf proc_carregamento_motor_trident_63
                Exit Select
            Case 64
                AddHandler OBJ_MOTOR_WEB_BROWSER_64.ProgressChanged, AddressOf proc_carregamento_motor_trident_64
                Exit Select
            Case 65
                AddHandler OBJ_MOTOR_WEB_BROWSER_65.ProgressChanged, AddressOf proc_carregamento_motor_trident_65
                Exit Select
            Case 66
                AddHandler OBJ_MOTOR_WEB_BROWSER_66.ProgressChanged, AddressOf proc_carregamento_motor_trident_66
                Exit Select
            Case 67
                AddHandler OBJ_MOTOR_WEB_BROWSER_67.ProgressChanged, AddressOf proc_carregamento_motor_trident_67
                Exit Select
            Case 68
                AddHandler OBJ_MOTOR_WEB_BROWSER_68.ProgressChanged, AddressOf proc_carregamento_motor_trident_68
                Exit Select
            Case 69
                AddHandler OBJ_MOTOR_WEB_BROWSER_69.ProgressChanged, AddressOf proc_carregamento_motor_trident_69
                Exit Select
            Case 70
                AddHandler OBJ_MOTOR_WEB_BROWSER_70.ProgressChanged, AddressOf proc_carregamento_motor_trident_70
                Exit Select
            Case 71
                AddHandler OBJ_MOTOR_WEB_BROWSER_71.ProgressChanged, AddressOf proc_carregamento_motor_trident_71
                Exit Select
            Case 72
                AddHandler OBJ_MOTOR_WEB_BROWSER_72.ProgressChanged, AddressOf proc_carregamento_motor_trident_72
                Exit Select
            Case 73
                AddHandler OBJ_MOTOR_WEB_BROWSER_73.ProgressChanged, AddressOf proc_carregamento_motor_trident_73
                Exit Select
            Case 74
                AddHandler OBJ_MOTOR_WEB_BROWSER_74.ProgressChanged, AddressOf proc_carregamento_motor_trident_74
                Exit Select
            Case 75
                AddHandler OBJ_MOTOR_WEB_BROWSER_75.ProgressChanged, AddressOf proc_carregamento_motor_trident_75
                Exit Select
            Case 76
                AddHandler OBJ_MOTOR_WEB_BROWSER_76.ProgressChanged, AddressOf proc_carregamento_motor_trident_76
                Exit Select
            Case 77
                AddHandler OBJ_MOTOR_WEB_BROWSER_77.ProgressChanged, AddressOf proc_carregamento_motor_trident_77
                Exit Select
            Case 78
                AddHandler OBJ_MOTOR_WEB_BROWSER_78.ProgressChanged, AddressOf proc_carregamento_motor_trident_78
                Exit Select
            Case 79
                AddHandler OBJ_MOTOR_WEB_BROWSER_79.ProgressChanged, AddressOf proc_carregamento_motor_trident_79
                Exit Select
            Case 80
                AddHandler OBJ_MOTOR_WEB_BROWSER_80.ProgressChanged, AddressOf proc_carregamento_motor_trident_80
                Exit Select
            Case 81
                AddHandler OBJ_MOTOR_WEB_BROWSER_81.ProgressChanged, AddressOf proc_carregamento_motor_trident_81
                Exit Select
            Case 82
                AddHandler OBJ_MOTOR_WEB_BROWSER_82.ProgressChanged, AddressOf proc_carregamento_motor_trident_82
                Exit Select
            Case 83
                AddHandler OBJ_MOTOR_WEB_BROWSER_83.ProgressChanged, AddressOf proc_carregamento_motor_trident_83
                Exit Select
            Case 84
                AddHandler OBJ_MOTOR_WEB_BROWSER_84.ProgressChanged, AddressOf proc_carregamento_motor_trident_84
                Exit Select
            Case 85
                AddHandler OBJ_MOTOR_WEB_BROWSER_85.ProgressChanged, AddressOf proc_carregamento_motor_trident_85
                Exit Select
            Case 86
                AddHandler OBJ_MOTOR_WEB_BROWSER_86.ProgressChanged, AddressOf proc_carregamento_motor_trident_86
                Exit Select
            Case 87
                AddHandler OBJ_MOTOR_WEB_BROWSER_87.ProgressChanged, AddressOf proc_carregamento_motor_trident_87
                Exit Select
            Case 88
                AddHandler OBJ_MOTOR_WEB_BROWSER_88.ProgressChanged, AddressOf proc_carregamento_motor_trident_88
                Exit Select
            Case 89
                AddHandler OBJ_MOTOR_WEB_BROWSER_89.ProgressChanged, AddressOf proc_carregamento_motor_trident_89
                Exit Select
            Case 90
                AddHandler OBJ_MOTOR_WEB_BROWSER_90.ProgressChanged, AddressOf proc_carregamento_motor_trident_90
                Exit Select
            Case 91
                AddHandler OBJ_MOTOR_WEB_BROWSER_91.ProgressChanged, AddressOf proc_carregamento_motor_trident_91
                Exit Select
            Case 92
                AddHandler OBJ_MOTOR_WEB_BROWSER_92.ProgressChanged, AddressOf proc_carregamento_motor_trident_92
                Exit Select
            Case 93
                AddHandler OBJ_MOTOR_WEB_BROWSER_93.ProgressChanged, AddressOf proc_carregamento_motor_trident_93
                Exit Select
            Case 94
                AddHandler OBJ_MOTOR_WEB_BROWSER_94.ProgressChanged, AddressOf proc_carregamento_motor_trident_94
                Exit Select
            Case 95
                AddHandler OBJ_MOTOR_WEB_BROWSER_95.ProgressChanged, AddressOf proc_carregamento_motor_trident_95
                Exit Select
            Case 96
                AddHandler OBJ_MOTOR_WEB_BROWSER_96.ProgressChanged, AddressOf proc_carregamento_motor_trident_96
                Exit Select
            Case 97
                AddHandler OBJ_MOTOR_WEB_BROWSER_97.ProgressChanged, AddressOf proc_carregamento_motor_trident_97
                Exit Select
            Case 98
                AddHandler OBJ_MOTOR_WEB_BROWSER_98.ProgressChanged, AddressOf proc_carregamento_motor_trident_98
                Exit Select
            Case 99
                AddHandler OBJ_MOTOR_WEB_BROWSER_99.ProgressChanged, AddressOf proc_carregamento_motor_trident_99
                Exit Select
            Case 100
                AddHandler OBJ_MOTOR_WEB_BROWSER_100.ProgressChanged, AddressOf proc_carregamento_motor_trident_100
                Exit Select
            Case 101
                AddHandler OBJ_MOTOR_WEB_BROWSER_101.ProgressChanged, AddressOf proc_carregamento_motor_trident_101
                Exit Select
            Case 102
                AddHandler OBJ_MOTOR_WEB_BROWSER_102.ProgressChanged, AddressOf proc_carregamento_motor_trident_102
                Exit Select
            Case 103
                AddHandler OBJ_MOTOR_WEB_BROWSER_103.ProgressChanged, AddressOf proc_carregamento_motor_trident_103
                Exit Select
            Case 104
                AddHandler OBJ_MOTOR_WEB_BROWSER_104.ProgressChanged, AddressOf proc_carregamento_motor_trident_104
                Exit Select
            Case 105
                AddHandler OBJ_MOTOR_WEB_BROWSER_105.ProgressChanged, AddressOf proc_carregamento_motor_trident_105
                Exit Select
            Case 106
                AddHandler OBJ_MOTOR_WEB_BROWSER_106.ProgressChanged, AddressOf proc_carregamento_motor_trident_106
                Exit Select
            Case 107
                AddHandler OBJ_MOTOR_WEB_BROWSER_107.ProgressChanged, AddressOf proc_carregamento_motor_trident_107
                Exit Select
            Case 108
                AddHandler OBJ_MOTOR_WEB_BROWSER_108.ProgressChanged, AddressOf proc_carregamento_motor_trident_108
                Exit Select
            Case 109
                AddHandler OBJ_MOTOR_WEB_BROWSER_109.ProgressChanged, AddressOf proc_carregamento_motor_trident_109
                Exit Select
            Case 110
                AddHandler OBJ_MOTOR_WEB_BROWSER_110.ProgressChanged, AddressOf proc_carregamento_motor_trident_110
                Exit Select
            Case 111
                AddHandler OBJ_MOTOR_WEB_BROWSER_111.ProgressChanged, AddressOf proc_carregamento_motor_trident_111
                Exit Select
            Case 112
                AddHandler OBJ_MOTOR_WEB_BROWSER_112.ProgressChanged, AddressOf proc_carregamento_motor_trident_112
                Exit Select
            Case 113
                AddHandler OBJ_MOTOR_WEB_BROWSER_113.ProgressChanged, AddressOf proc_carregamento_motor_trident_113
                Exit Select
            Case 114
                AddHandler OBJ_MOTOR_WEB_BROWSER_114.ProgressChanged, AddressOf proc_carregamento_motor_trident_114
                Exit Select
            Case 115
                AddHandler OBJ_MOTOR_WEB_BROWSER_115.ProgressChanged, AddressOf proc_carregamento_motor_trident_115
                Exit Select
            Case 116
                AddHandler OBJ_MOTOR_WEB_BROWSER_116.ProgressChanged, AddressOf proc_carregamento_motor_trident_116
                Exit Select
            Case 117
                AddHandler OBJ_MOTOR_WEB_BROWSER_117.ProgressChanged, AddressOf proc_carregamento_motor_trident_117
                Exit Select
            Case 118
                AddHandler OBJ_MOTOR_WEB_BROWSER_118.ProgressChanged, AddressOf proc_carregamento_motor_trident_118
                Exit Select
            Case 119
                AddHandler OBJ_MOTOR_WEB_BROWSER_119.ProgressChanged, AddressOf proc_carregamento_motor_trident_119
                Exit Select
            Case 120
                AddHandler OBJ_MOTOR_WEB_BROWSER_120.ProgressChanged, AddressOf proc_carregamento_motor_trident_120
                Exit Select
            Case 121
                AddHandler OBJ_MOTOR_WEB_BROWSER_121.ProgressChanged, AddressOf proc_carregamento_motor_trident_121
                Exit Select
            Case 122
                AddHandler OBJ_MOTOR_WEB_BROWSER_122.ProgressChanged, AddressOf proc_carregamento_motor_trident_122
                Exit Select
            Case 123
                AddHandler OBJ_MOTOR_WEB_BROWSER_123.ProgressChanged, AddressOf proc_carregamento_motor_trident_123
                Exit Select
            Case 124
                AddHandler OBJ_MOTOR_WEB_BROWSER_124.ProgressChanged, AddressOf proc_carregamento_motor_trident_124
                Exit Select
            Case 125
                AddHandler OBJ_MOTOR_WEB_BROWSER_125.ProgressChanged, AddressOf proc_carregamento_motor_trident_125
                Exit Select
            Case 126
                AddHandler OBJ_MOTOR_WEB_BROWSER_126.ProgressChanged, AddressOf proc_carregamento_motor_trident_126
                Exit Select
            Case 127
                AddHandler OBJ_MOTOR_WEB_BROWSER_127.ProgressChanged, AddressOf proc_carregamento_motor_trident_127
                Exit Select
            Case 128
                AddHandler OBJ_MOTOR_WEB_BROWSER_128.ProgressChanged, AddressOf proc_carregamento_motor_trident_128
                Exit Select
            



        End Select


    End Sub






    'Carregamento da pagina concluido

    Private Sub proc_ligar_evento_carregamento_completo_de_pagina_geckofx() 'Liga o evento de carregamento completo de página
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso


            Case 1
                AddHandler OBJ_MOTOR_GECKOFX_1.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_1
                Exit Select
            Case 2
                AddHandler OBJ_MOTOR_GECKOFX_2.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_2
                Exit Select
            Case 3
                AddHandler OBJ_MOTOR_GECKOFX_3.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_3
                Exit Select
            Case 4
                AddHandler OBJ_MOTOR_GECKOFX_4.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_4
                Exit Select
            Case 5
                AddHandler OBJ_MOTOR_GECKOFX_5.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_5
                Exit Select
            Case 6
                AddHandler OBJ_MOTOR_GECKOFX_6.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_6
                Exit Select
            Case 7
                AddHandler OBJ_MOTOR_GECKOFX_7.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_7
                Exit Select
            Case 8
                AddHandler OBJ_MOTOR_GECKOFX_8.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_8
                Exit Select
            Case 9
                AddHandler OBJ_MOTOR_GECKOFX_9.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_9
                Exit Select
            Case 10
                AddHandler OBJ_MOTOR_GECKOFX_10.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_10
                Exit Select
            Case 11
                AddHandler OBJ_MOTOR_GECKOFX_11.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_11
                Exit Select
            Case 12
                AddHandler OBJ_MOTOR_GECKOFX_12.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_12
                Exit Select
            Case 13
                AddHandler OBJ_MOTOR_GECKOFX_13.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_13
                Exit Select
            Case 14
                AddHandler OBJ_MOTOR_GECKOFX_14.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_14
                Exit Select
            Case 15
                AddHandler OBJ_MOTOR_GECKOFX_15.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_15
                Exit Select
            Case 16
                AddHandler OBJ_MOTOR_GECKOFX_16.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_16
                Exit Select
            Case 17
                AddHandler OBJ_MOTOR_GECKOFX_17.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_17
                Exit Select
            Case 18
                AddHandler OBJ_MOTOR_GECKOFX_18.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_18
                Exit Select
            Case 19
                AddHandler OBJ_MOTOR_GECKOFX_19.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_19
                Exit Select
            Case 20
                AddHandler OBJ_MOTOR_GECKOFX_20.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_20
                Exit Select
            Case 21
                AddHandler OBJ_MOTOR_GECKOFX_21.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_21
                Exit Select
            Case 22
                AddHandler OBJ_MOTOR_GECKOFX_22.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_22
                Exit Select
            Case 23
                AddHandler OBJ_MOTOR_GECKOFX_23.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_23
                Exit Select
            Case 24
                AddHandler OBJ_MOTOR_GECKOFX_24.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_24
                Exit Select
            Case 25
                AddHandler OBJ_MOTOR_GECKOFX_25.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_25
                Exit Select
            Case 26
                AddHandler OBJ_MOTOR_GECKOFX_26.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_26
                Exit Select
            Case 27
                AddHandler OBJ_MOTOR_GECKOFX_27.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_27
                Exit Select
            Case 28
                AddHandler OBJ_MOTOR_GECKOFX_28.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_28
                Exit Select
            Case 29
                AddHandler OBJ_MOTOR_GECKOFX_29.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_29
                Exit Select
            Case 30
                AddHandler OBJ_MOTOR_GECKOFX_30.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_30
                Exit Select
            Case 31
                AddHandler OBJ_MOTOR_GECKOFX_31.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_31
                Exit Select
            Case 32
                AddHandler OBJ_MOTOR_GECKOFX_32.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_32
                Exit Select
            Case 33
                AddHandler OBJ_MOTOR_GECKOFX_33.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_33
                Exit Select
            Case 34
                AddHandler OBJ_MOTOR_GECKOFX_34.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_34
                Exit Select
            Case 35
                AddHandler OBJ_MOTOR_GECKOFX_35.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_35
                Exit Select
            Case 36
                AddHandler OBJ_MOTOR_GECKOFX_36.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_36
                Exit Select
            Case 37
                AddHandler OBJ_MOTOR_GECKOFX_37.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_37
                Exit Select
            Case 38
                AddHandler OBJ_MOTOR_GECKOFX_38.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_38
                Exit Select
            Case 39
                AddHandler OBJ_MOTOR_GECKOFX_39.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_39
                Exit Select
            Case 40
                AddHandler OBJ_MOTOR_GECKOFX_40.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_40
                Exit Select
            Case 41
                AddHandler OBJ_MOTOR_GECKOFX_41.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_41
                Exit Select
            Case 42
                AddHandler OBJ_MOTOR_GECKOFX_42.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_42
                Exit Select
            Case 43
                AddHandler OBJ_MOTOR_GECKOFX_43.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_43
                Exit Select
            Case 44
                AddHandler OBJ_MOTOR_GECKOFX_44.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_44
                Exit Select
            Case 45
                AddHandler OBJ_MOTOR_GECKOFX_45.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_45
                Exit Select
            Case 46
                AddHandler OBJ_MOTOR_GECKOFX_46.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_46
                Exit Select
            Case 47
                AddHandler OBJ_MOTOR_GECKOFX_47.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_47
                Exit Select
            Case 48
                AddHandler OBJ_MOTOR_GECKOFX_48.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_48
                Exit Select
            Case 49
                AddHandler OBJ_MOTOR_GECKOFX_49.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_49
                Exit Select
            Case 50
                AddHandler OBJ_MOTOR_GECKOFX_50.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_50
                Exit Select
            Case 51
                AddHandler OBJ_MOTOR_GECKOFX_51.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_51
                Exit Select
            Case 52
                AddHandler OBJ_MOTOR_GECKOFX_52.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_52
                Exit Select
            Case 53
                AddHandler OBJ_MOTOR_GECKOFX_53.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_53
                Exit Select
            Case 54
                AddHandler OBJ_MOTOR_GECKOFX_54.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_54
                Exit Select
            Case 55
                AddHandler OBJ_MOTOR_GECKOFX_55.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_55
                Exit Select
            Case 56
                AddHandler OBJ_MOTOR_GECKOFX_56.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_56
                Exit Select
            Case 57
                AddHandler OBJ_MOTOR_GECKOFX_57.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_57
                Exit Select
            Case 58
                AddHandler OBJ_MOTOR_GECKOFX_58.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_58
                Exit Select
            Case 59
                AddHandler OBJ_MOTOR_GECKOFX_59.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_59
                Exit Select
            Case 60
                AddHandler OBJ_MOTOR_GECKOFX_60.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_60
                Exit Select
            Case 61
                AddHandler OBJ_MOTOR_GECKOFX_61.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_61
                Exit Select
            Case 62
                AddHandler OBJ_MOTOR_GECKOFX_62.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_62
                Exit Select
            Case 63
                AddHandler OBJ_MOTOR_GECKOFX_63.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_63
                Exit Select
            Case 64
                AddHandler OBJ_MOTOR_GECKOFX_64.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_64
                Exit Select
            Case 65
                AddHandler OBJ_MOTOR_GECKOFX_65.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_65
                Exit Select
            Case 66
                AddHandler OBJ_MOTOR_GECKOFX_66.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_66
                Exit Select
            Case 67
                AddHandler OBJ_MOTOR_GECKOFX_67.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_67
                Exit Select
            Case 68
                AddHandler OBJ_MOTOR_GECKOFX_68.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_68
                Exit Select
            Case 69
                AddHandler OBJ_MOTOR_GECKOFX_69.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_69
                Exit Select
            Case 70
                AddHandler OBJ_MOTOR_GECKOFX_70.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_70
                Exit Select
            Case 71
                AddHandler OBJ_MOTOR_GECKOFX_71.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_71
                Exit Select
            Case 72
                AddHandler OBJ_MOTOR_GECKOFX_72.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_72
                Exit Select
            Case 73
                AddHandler OBJ_MOTOR_GECKOFX_73.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_73
                Exit Select
            Case 74
                AddHandler OBJ_MOTOR_GECKOFX_74.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_74
                Exit Select
            Case 75
                AddHandler OBJ_MOTOR_GECKOFX_75.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_75
                Exit Select
            Case 76
                AddHandler OBJ_MOTOR_GECKOFX_76.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_76
                Exit Select
            Case 77
                AddHandler OBJ_MOTOR_GECKOFX_77.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_77
                Exit Select
            Case 78
                AddHandler OBJ_MOTOR_GECKOFX_78.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_78
                Exit Select
            Case 79
                AddHandler OBJ_MOTOR_GECKOFX_79.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_79
                Exit Select
            Case 80
                AddHandler OBJ_MOTOR_GECKOFX_80.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_80
                Exit Select
            Case 81
                AddHandler OBJ_MOTOR_GECKOFX_81.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_81
                Exit Select
            Case 82
                AddHandler OBJ_MOTOR_GECKOFX_82.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_82
                Exit Select
            Case 83
                AddHandler OBJ_MOTOR_GECKOFX_83.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_83
                Exit Select
            Case 84
                AddHandler OBJ_MOTOR_GECKOFX_84.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_84
                Exit Select
            Case 85
                AddHandler OBJ_MOTOR_GECKOFX_85.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_85
                Exit Select
            Case 86
                AddHandler OBJ_MOTOR_GECKOFX_86.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_86
                Exit Select
            Case 87
                AddHandler OBJ_MOTOR_GECKOFX_87.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_87
                Exit Select
            Case 88
                AddHandler OBJ_MOTOR_GECKOFX_88.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_88
                Exit Select
            Case 89
                AddHandler OBJ_MOTOR_GECKOFX_89.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_89
                Exit Select
            Case 90
                AddHandler OBJ_MOTOR_GECKOFX_90.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_90
                Exit Select
            Case 91
                AddHandler OBJ_MOTOR_GECKOFX_91.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_91
                Exit Select
            Case 92
                AddHandler OBJ_MOTOR_GECKOFX_92.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_92
                Exit Select
            Case 93
                AddHandler OBJ_MOTOR_GECKOFX_93.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_93
                Exit Select
            Case 94
                AddHandler OBJ_MOTOR_GECKOFX_94.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_94
                Exit Select
            Case 95
                AddHandler OBJ_MOTOR_GECKOFX_95.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_95
                Exit Select
            Case 96
                AddHandler OBJ_MOTOR_GECKOFX_96.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_96
                Exit Select
            Case 97
                AddHandler OBJ_MOTOR_GECKOFX_97.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_97
                Exit Select
            Case 98
                AddHandler OBJ_MOTOR_GECKOFX_98.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_98
                Exit Select
            Case 99
                AddHandler OBJ_MOTOR_GECKOFX_99.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_99
                Exit Select
            Case 100
                AddHandler OBJ_MOTOR_GECKOFX_100.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_100
                Exit Select
            Case 101
                AddHandler OBJ_MOTOR_GECKOFX_101.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_101
                Exit Select
            Case 102
                AddHandler OBJ_MOTOR_GECKOFX_102.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_102
                Exit Select
            Case 103
                AddHandler OBJ_MOTOR_GECKOFX_103.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_103
                Exit Select
            Case 104
                AddHandler OBJ_MOTOR_GECKOFX_104.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_104
                Exit Select
            Case 105
                AddHandler OBJ_MOTOR_GECKOFX_105.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_105
                Exit Select
            Case 106
                AddHandler OBJ_MOTOR_GECKOFX_106.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_106
                Exit Select
            Case 107
                AddHandler OBJ_MOTOR_GECKOFX_107.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_107
                Exit Select
            Case 108
                AddHandler OBJ_MOTOR_GECKOFX_108.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_108
                Exit Select
            Case 109
                AddHandler OBJ_MOTOR_GECKOFX_109.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_109
                Exit Select
            Case 110
                AddHandler OBJ_MOTOR_GECKOFX_110.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_110
                Exit Select
            Case 111
                AddHandler OBJ_MOTOR_GECKOFX_111.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_111
                Exit Select
            Case 112
                AddHandler OBJ_MOTOR_GECKOFX_112.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_112
                Exit Select
            Case 113
                AddHandler OBJ_MOTOR_GECKOFX_113.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_113
                Exit Select
            Case 114
                AddHandler OBJ_MOTOR_GECKOFX_114.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_114
                Exit Select
            Case 115
                AddHandler OBJ_MOTOR_GECKOFX_115.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_115
                Exit Select
            Case 116
                AddHandler OBJ_MOTOR_GECKOFX_116.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_116
                Exit Select
            Case 117
                AddHandler OBJ_MOTOR_GECKOFX_117.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_117
                Exit Select
            Case 118
                AddHandler OBJ_MOTOR_GECKOFX_118.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_118
                Exit Select
            Case 119
                AddHandler OBJ_MOTOR_GECKOFX_119.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_119
                Exit Select
            Case 120
                AddHandler OBJ_MOTOR_GECKOFX_120.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_120
                Exit Select
            Case 121
                AddHandler OBJ_MOTOR_GECKOFX_121.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_121
                Exit Select
            Case 122
                AddHandler OBJ_MOTOR_GECKOFX_122.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_122
                Exit Select
            Case 123
                AddHandler OBJ_MOTOR_GECKOFX_123.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_123
                Exit Select
            Case 124
                AddHandler OBJ_MOTOR_GECKOFX_124.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_124
                Exit Select
            Case 125
                AddHandler OBJ_MOTOR_GECKOFX_125.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_125
                Exit Select
            Case 126
                AddHandler OBJ_MOTOR_GECKOFX_126.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_126
                Exit Select
            Case 127
                AddHandler OBJ_MOTOR_GECKOFX_127.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_127
                Exit Select
            Case 128
                AddHandler OBJ_MOTOR_GECKOFX_128.DocumentCompleted, AddressOf proc_carregamento_completado_motor_geckofx_128
                Exit Select
            



        End Select


    End Sub

    Private Sub proc_ligar_evento_carregamento_completo_de_pagina_trident() 'Liga o evento de carregamento completo de página
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso


            Case 1
                AddHandler OBJ_MOTOR_WEB_BROWSER_1.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_1
                Exit Select
            Case 2
                AddHandler OBJ_MOTOR_WEB_BROWSER_2.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_2
                Exit Select
            Case 3
                AddHandler OBJ_MOTOR_WEB_BROWSER_3.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_3
                Exit Select
            Case 4
                AddHandler OBJ_MOTOR_WEB_BROWSER_4.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_4
                Exit Select
            Case 5
                AddHandler OBJ_MOTOR_WEB_BROWSER_5.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_5
                Exit Select
            Case 6
                AddHandler OBJ_MOTOR_WEB_BROWSER_6.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_6
                Exit Select
            Case 7
                AddHandler OBJ_MOTOR_WEB_BROWSER_7.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_7
                Exit Select
            Case 8
                AddHandler OBJ_MOTOR_WEB_BROWSER_8.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_8
                Exit Select
            Case 9
                AddHandler OBJ_MOTOR_WEB_BROWSER_9.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_9
                Exit Select
            Case 10
                AddHandler OBJ_MOTOR_WEB_BROWSER_10.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_10
                Exit Select
            Case 11
                AddHandler OBJ_MOTOR_WEB_BROWSER_11.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_11
                Exit Select
            Case 12
                AddHandler OBJ_MOTOR_WEB_BROWSER_12.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_12
                Exit Select
            Case 13
                AddHandler OBJ_MOTOR_WEB_BROWSER_13.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_13
                Exit Select
            Case 14
                AddHandler OBJ_MOTOR_WEB_BROWSER_14.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_14
                Exit Select
            Case 15
                AddHandler OBJ_MOTOR_WEB_BROWSER_15.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_15
                Exit Select
            Case 16
                AddHandler OBJ_MOTOR_WEB_BROWSER_16.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_16
                Exit Select
            Case 17
                AddHandler OBJ_MOTOR_WEB_BROWSER_17.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_17
                Exit Select
            Case 18
                AddHandler OBJ_MOTOR_WEB_BROWSER_18.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_18
                Exit Select
            Case 19
                AddHandler OBJ_MOTOR_WEB_BROWSER_19.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_19
                Exit Select
            Case 20
                AddHandler OBJ_MOTOR_WEB_BROWSER_20.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_20
                Exit Select
            Case 21
                AddHandler OBJ_MOTOR_WEB_BROWSER_21.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_21
                Exit Select
            Case 22
                AddHandler OBJ_MOTOR_WEB_BROWSER_22.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_22
                Exit Select
            Case 23
                AddHandler OBJ_MOTOR_WEB_BROWSER_23.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_23
                Exit Select
            Case 24
                AddHandler OBJ_MOTOR_WEB_BROWSER_24.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_24
                Exit Select
            Case 25
                AddHandler OBJ_MOTOR_WEB_BROWSER_25.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_25
                Exit Select
            Case 26
                AddHandler OBJ_MOTOR_WEB_BROWSER_26.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_26
                Exit Select
            Case 27
                AddHandler OBJ_MOTOR_WEB_BROWSER_27.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_27
                Exit Select
            Case 28
                AddHandler OBJ_MOTOR_WEB_BROWSER_28.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_28
                Exit Select
            Case 29
                AddHandler OBJ_MOTOR_WEB_BROWSER_29.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_29
                Exit Select
            Case 30
                AddHandler OBJ_MOTOR_WEB_BROWSER_30.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_30
                Exit Select
            Case 31
                AddHandler OBJ_MOTOR_WEB_BROWSER_31.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_31
                Exit Select
            Case 32
                AddHandler OBJ_MOTOR_WEB_BROWSER_32.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_32
                Exit Select
            Case 33
                AddHandler OBJ_MOTOR_WEB_BROWSER_33.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_33
                Exit Select
            Case 34
                AddHandler OBJ_MOTOR_WEB_BROWSER_34.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_34
                Exit Select
            Case 35
                AddHandler OBJ_MOTOR_WEB_BROWSER_35.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_35
                Exit Select
            Case 36
                AddHandler OBJ_MOTOR_WEB_BROWSER_36.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_36
                Exit Select
            Case 37
                AddHandler OBJ_MOTOR_WEB_BROWSER_37.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_37
                Exit Select
            Case 38
                AddHandler OBJ_MOTOR_WEB_BROWSER_38.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_38
                Exit Select
            Case 39
                AddHandler OBJ_MOTOR_WEB_BROWSER_39.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_39
                Exit Select
            Case 40
                AddHandler OBJ_MOTOR_WEB_BROWSER_40.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_40
                Exit Select
            Case 41
                AddHandler OBJ_MOTOR_WEB_BROWSER_41.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_41
                Exit Select
            Case 42
                AddHandler OBJ_MOTOR_WEB_BROWSER_42.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_42
                Exit Select
            Case 43
                AddHandler OBJ_MOTOR_WEB_BROWSER_43.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_43
                Exit Select
            Case 44
                AddHandler OBJ_MOTOR_WEB_BROWSER_44.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_44
                Exit Select
            Case 45
                AddHandler OBJ_MOTOR_WEB_BROWSER_45.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_45
                Exit Select
            Case 46
                AddHandler OBJ_MOTOR_WEB_BROWSER_46.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_46
                Exit Select
            Case 47
                AddHandler OBJ_MOTOR_WEB_BROWSER_47.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_47
                Exit Select
            Case 48
                AddHandler OBJ_MOTOR_WEB_BROWSER_48.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_48
                Exit Select
            Case 49
                AddHandler OBJ_MOTOR_WEB_BROWSER_49.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_49
                Exit Select
            Case 50
                AddHandler OBJ_MOTOR_WEB_BROWSER_50.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_50
                Exit Select
            Case 51
                AddHandler OBJ_MOTOR_WEB_BROWSER_51.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_51
                Exit Select
            Case 52
                AddHandler OBJ_MOTOR_WEB_BROWSER_52.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_52
                Exit Select
            Case 53
                AddHandler OBJ_MOTOR_WEB_BROWSER_53.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_53
                Exit Select
            Case 54
                AddHandler OBJ_MOTOR_WEB_BROWSER_54.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_54
                Exit Select
            Case 55
                AddHandler OBJ_MOTOR_WEB_BROWSER_55.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_55
                Exit Select
            Case 56
                AddHandler OBJ_MOTOR_WEB_BROWSER_56.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_56
                Exit Select
            Case 57
                AddHandler OBJ_MOTOR_WEB_BROWSER_57.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_57
                Exit Select
            Case 58
                AddHandler OBJ_MOTOR_WEB_BROWSER_58.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_58
                Exit Select
            Case 59
                AddHandler OBJ_MOTOR_WEB_BROWSER_59.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_59
                Exit Select
            Case 60
                AddHandler OBJ_MOTOR_WEB_BROWSER_60.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_60
                Exit Select
            Case 61
                AddHandler OBJ_MOTOR_WEB_BROWSER_61.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_61
                Exit Select
            Case 62
                AddHandler OBJ_MOTOR_WEB_BROWSER_62.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_62
                Exit Select
            Case 63
                AddHandler OBJ_MOTOR_WEB_BROWSER_63.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_63
                Exit Select
            Case 64
                AddHandler OBJ_MOTOR_WEB_BROWSER_64.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_64
                Exit Select
            Case 65
                AddHandler OBJ_MOTOR_WEB_BROWSER_65.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_65
                Exit Select
            Case 66
                AddHandler OBJ_MOTOR_WEB_BROWSER_66.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_66
                Exit Select
            Case 67
                AddHandler OBJ_MOTOR_WEB_BROWSER_67.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_67
                Exit Select
            Case 68
                AddHandler OBJ_MOTOR_WEB_BROWSER_68.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_68
                Exit Select
            Case 69
                AddHandler OBJ_MOTOR_WEB_BROWSER_69.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_69
                Exit Select
            Case 70
                AddHandler OBJ_MOTOR_WEB_BROWSER_70.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_70
                Exit Select
            Case 71
                AddHandler OBJ_MOTOR_WEB_BROWSER_71.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_71
                Exit Select
            Case 72
                AddHandler OBJ_MOTOR_WEB_BROWSER_72.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_72
                Exit Select
            Case 73
                AddHandler OBJ_MOTOR_WEB_BROWSER_73.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_73
                Exit Select
            Case 74
                AddHandler OBJ_MOTOR_WEB_BROWSER_74.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_74
                Exit Select
            Case 75
                AddHandler OBJ_MOTOR_WEB_BROWSER_75.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_75
                Exit Select
            Case 76
                AddHandler OBJ_MOTOR_WEB_BROWSER_76.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_76
                Exit Select
            Case 77
                AddHandler OBJ_MOTOR_WEB_BROWSER_77.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_77
                Exit Select
            Case 78
                AddHandler OBJ_MOTOR_WEB_BROWSER_78.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_78
                Exit Select
            Case 79
                AddHandler OBJ_MOTOR_WEB_BROWSER_79.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_79
                Exit Select
            Case 80
                AddHandler OBJ_MOTOR_WEB_BROWSER_80.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_80
                Exit Select
            Case 81
                AddHandler OBJ_MOTOR_WEB_BROWSER_81.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_81
                Exit Select
            Case 82
                AddHandler OBJ_MOTOR_WEB_BROWSER_82.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_82
                Exit Select
            Case 83
                AddHandler OBJ_MOTOR_WEB_BROWSER_83.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_83
                Exit Select
            Case 84
                AddHandler OBJ_MOTOR_WEB_BROWSER_84.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_84
                Exit Select
            Case 85
                AddHandler OBJ_MOTOR_WEB_BROWSER_85.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_85
                Exit Select
            Case 86
                AddHandler OBJ_MOTOR_WEB_BROWSER_86.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_86
                Exit Select
            Case 87
                AddHandler OBJ_MOTOR_WEB_BROWSER_87.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_87
                Exit Select
            Case 88
                AddHandler OBJ_MOTOR_WEB_BROWSER_88.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_88
                Exit Select
            Case 89
                AddHandler OBJ_MOTOR_WEB_BROWSER_89.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_89
                Exit Select
            Case 90
                AddHandler OBJ_MOTOR_WEB_BROWSER_90.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_90
                Exit Select
            Case 91
                AddHandler OBJ_MOTOR_WEB_BROWSER_91.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_91
                Exit Select
            Case 92
                AddHandler OBJ_MOTOR_WEB_BROWSER_92.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_92
                Exit Select
            Case 93
                AddHandler OBJ_MOTOR_WEB_BROWSER_93.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_93
                Exit Select
            Case 94
                AddHandler OBJ_MOTOR_WEB_BROWSER_94.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_94
                Exit Select
            Case 95
                AddHandler OBJ_MOTOR_WEB_BROWSER_95.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_95
                Exit Select
            Case 96
                AddHandler OBJ_MOTOR_WEB_BROWSER_96.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_96
                Exit Select
            Case 97
                AddHandler OBJ_MOTOR_WEB_BROWSER_97.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_97
                Exit Select
            Case 98
                AddHandler OBJ_MOTOR_WEB_BROWSER_98.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_98
                Exit Select
            Case 99
                AddHandler OBJ_MOTOR_WEB_BROWSER_99.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_99
                Exit Select
            Case 100
                AddHandler OBJ_MOTOR_WEB_BROWSER_100.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_100
                Exit Select
            Case 101
                AddHandler OBJ_MOTOR_WEB_BROWSER_101.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_101
                Exit Select
            Case 102
                AddHandler OBJ_MOTOR_WEB_BROWSER_102.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_102
                Exit Select
            Case 103
                AddHandler OBJ_MOTOR_WEB_BROWSER_103.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_103
                Exit Select
            Case 104
                AddHandler OBJ_MOTOR_WEB_BROWSER_104.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_104
                Exit Select
            Case 105
                AddHandler OBJ_MOTOR_WEB_BROWSER_105.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_105
                Exit Select
            Case 106
                AddHandler OBJ_MOTOR_WEB_BROWSER_106.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_106
                Exit Select
            Case 107
                AddHandler OBJ_MOTOR_WEB_BROWSER_107.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_107
                Exit Select
            Case 108
                AddHandler OBJ_MOTOR_WEB_BROWSER_108.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_108
                Exit Select
            Case 109
                AddHandler OBJ_MOTOR_WEB_BROWSER_109.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_109
                Exit Select
            Case 110
                AddHandler OBJ_MOTOR_WEB_BROWSER_110.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_110
                Exit Select
            Case 111
                AddHandler OBJ_MOTOR_WEB_BROWSER_111.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_111
                Exit Select
            Case 112
                AddHandler OBJ_MOTOR_WEB_BROWSER_112.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_112
                Exit Select
            Case 113
                AddHandler OBJ_MOTOR_WEB_BROWSER_113.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_113
                Exit Select
            Case 114
                AddHandler OBJ_MOTOR_WEB_BROWSER_114.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_114
                Exit Select
            Case 115
                AddHandler OBJ_MOTOR_WEB_BROWSER_115.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_115
                Exit Select
            Case 116
                AddHandler OBJ_MOTOR_WEB_BROWSER_116.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_116
                Exit Select
            Case 117
                AddHandler OBJ_MOTOR_WEB_BROWSER_117.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_117
                Exit Select
            Case 118
                AddHandler OBJ_MOTOR_WEB_BROWSER_118.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_118
                Exit Select
            Case 119
                AddHandler OBJ_MOTOR_WEB_BROWSER_119.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_119
                Exit Select
            Case 120
                AddHandler OBJ_MOTOR_WEB_BROWSER_120.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_120
                Exit Select
            Case 121
                AddHandler OBJ_MOTOR_WEB_BROWSER_121.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_121
                Exit Select
            Case 122
                AddHandler OBJ_MOTOR_WEB_BROWSER_122.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_122
                Exit Select
            Case 123
                AddHandler OBJ_MOTOR_WEB_BROWSER_123.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_123
                Exit Select
            Case 124
                AddHandler OBJ_MOTOR_WEB_BROWSER_124.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_124
                Exit Select
            Case 125
                AddHandler OBJ_MOTOR_WEB_BROWSER_125.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_125
                Exit Select
            Case 126
                AddHandler OBJ_MOTOR_WEB_BROWSER_126.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_126
                Exit Select
            Case 127
                AddHandler OBJ_MOTOR_WEB_BROWSER_127.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_127
                Exit Select
            Case 128
                AddHandler OBJ_MOTOR_WEB_BROWSER_128.DocumentCompleted, AddressOf proc_carregamento_completado_motor_trident_128
                Exit Select
            



        End Select


    End Sub






    'Status text mudar

    Private Sub proc_ligar_evento_statustext_geckofx() 'Liga o evento de statustext de página
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso


            Case 1
                AddHandler OBJ_MOTOR_GECKOFX_1.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_1
                Exit Select
            Case 2
                AddHandler OBJ_MOTOR_GECKOFX_2.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_2
                Exit Select
            Case 3
                AddHandler OBJ_MOTOR_GECKOFX_3.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_3
                Exit Select
            Case 4
                AddHandler OBJ_MOTOR_GECKOFX_4.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_4
                Exit Select
            Case 5
                AddHandler OBJ_MOTOR_GECKOFX_5.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_5
                Exit Select
            Case 6
                AddHandler OBJ_MOTOR_GECKOFX_6.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_6
                Exit Select
            Case 7
                AddHandler OBJ_MOTOR_GECKOFX_7.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_7
                Exit Select
            Case 8
                AddHandler OBJ_MOTOR_GECKOFX_8.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_8
                Exit Select
            Case 9
                AddHandler OBJ_MOTOR_GECKOFX_9.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_9
                Exit Select
            Case 10
                AddHandler OBJ_MOTOR_GECKOFX_10.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_10
                Exit Select
            Case 11
                AddHandler OBJ_MOTOR_GECKOFX_11.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_11
                Exit Select
            Case 12
                AddHandler OBJ_MOTOR_GECKOFX_12.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_12
                Exit Select
            Case 13
                AddHandler OBJ_MOTOR_GECKOFX_13.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_13
                Exit Select
            Case 14
                AddHandler OBJ_MOTOR_GECKOFX_14.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_14
                Exit Select
            Case 15
                AddHandler OBJ_MOTOR_GECKOFX_15.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_15
                Exit Select
            Case 16
                AddHandler OBJ_MOTOR_GECKOFX_16.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_16
                Exit Select
            Case 17
                AddHandler OBJ_MOTOR_GECKOFX_17.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_17
                Exit Select
            Case 18
                AddHandler OBJ_MOTOR_GECKOFX_18.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_18
                Exit Select
            Case 19
                AddHandler OBJ_MOTOR_GECKOFX_19.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_19
                Exit Select
            Case 20
                AddHandler OBJ_MOTOR_GECKOFX_20.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_20
                Exit Select
            Case 21
                AddHandler OBJ_MOTOR_GECKOFX_21.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_21
                Exit Select
            Case 22
                AddHandler OBJ_MOTOR_GECKOFX_22.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_22
                Exit Select
            Case 23
                AddHandler OBJ_MOTOR_GECKOFX_23.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_23
                Exit Select
            Case 24
                AddHandler OBJ_MOTOR_GECKOFX_24.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_24
                Exit Select
            Case 25
                AddHandler OBJ_MOTOR_GECKOFX_25.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_25
                Exit Select
            Case 26
                AddHandler OBJ_MOTOR_GECKOFX_26.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_26
                Exit Select
            Case 27
                AddHandler OBJ_MOTOR_GECKOFX_27.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_27
                Exit Select
            Case 28
                AddHandler OBJ_MOTOR_GECKOFX_28.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_28
                Exit Select
            Case 29
                AddHandler OBJ_MOTOR_GECKOFX_29.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_29
                Exit Select
            Case 30
                AddHandler OBJ_MOTOR_GECKOFX_30.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_30
                Exit Select
            Case 31
                AddHandler OBJ_MOTOR_GECKOFX_31.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_31
                Exit Select
            Case 32
                AddHandler OBJ_MOTOR_GECKOFX_32.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_32
                Exit Select
            Case 33
                AddHandler OBJ_MOTOR_GECKOFX_33.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_33
                Exit Select
            Case 34
                AddHandler OBJ_MOTOR_GECKOFX_34.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_34
                Exit Select
            Case 35
                AddHandler OBJ_MOTOR_GECKOFX_35.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_35
                Exit Select
            Case 36
                AddHandler OBJ_MOTOR_GECKOFX_36.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_36
                Exit Select
            Case 37
                AddHandler OBJ_MOTOR_GECKOFX_37.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_37
                Exit Select
            Case 38
                AddHandler OBJ_MOTOR_GECKOFX_38.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_38
                Exit Select
            Case 39
                AddHandler OBJ_MOTOR_GECKOFX_39.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_39
                Exit Select
            Case 40
                AddHandler OBJ_MOTOR_GECKOFX_40.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_40
                Exit Select
            Case 41
                AddHandler OBJ_MOTOR_GECKOFX_41.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_41
                Exit Select
            Case 42
                AddHandler OBJ_MOTOR_GECKOFX_42.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_42
                Exit Select
            Case 43
                AddHandler OBJ_MOTOR_GECKOFX_43.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_43
                Exit Select
            Case 44
                AddHandler OBJ_MOTOR_GECKOFX_44.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_44
                Exit Select
            Case 45
                AddHandler OBJ_MOTOR_GECKOFX_45.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_45
                Exit Select
            Case 46
                AddHandler OBJ_MOTOR_GECKOFX_46.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_46
                Exit Select
            Case 47
                AddHandler OBJ_MOTOR_GECKOFX_47.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_47
                Exit Select
            Case 48
                AddHandler OBJ_MOTOR_GECKOFX_48.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_48
                Exit Select
            Case 49
                AddHandler OBJ_MOTOR_GECKOFX_49.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_49
                Exit Select
            Case 50
                AddHandler OBJ_MOTOR_GECKOFX_50.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_50
                Exit Select
            Case 51
                AddHandler OBJ_MOTOR_GECKOFX_51.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_51
                Exit Select
            Case 52
                AddHandler OBJ_MOTOR_GECKOFX_52.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_52
                Exit Select
            Case 53
                AddHandler OBJ_MOTOR_GECKOFX_53.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_53
                Exit Select
            Case 54
                AddHandler OBJ_MOTOR_GECKOFX_54.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_54
                Exit Select
            Case 55
                AddHandler OBJ_MOTOR_GECKOFX_55.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_55
                Exit Select
            Case 56
                AddHandler OBJ_MOTOR_GECKOFX_56.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_56
                Exit Select
            Case 57
                AddHandler OBJ_MOTOR_GECKOFX_57.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_57
                Exit Select
            Case 58
                AddHandler OBJ_MOTOR_GECKOFX_58.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_58
                Exit Select
            Case 59
                AddHandler OBJ_MOTOR_GECKOFX_59.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_59
                Exit Select
            Case 60
                AddHandler OBJ_MOTOR_GECKOFX_60.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_60
                Exit Select
            Case 61
                AddHandler OBJ_MOTOR_GECKOFX_61.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_61
                Exit Select
            Case 62
                AddHandler OBJ_MOTOR_GECKOFX_62.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_62
                Exit Select
            Case 63
                AddHandler OBJ_MOTOR_GECKOFX_63.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_63
                Exit Select
            Case 64
                AddHandler OBJ_MOTOR_GECKOFX_64.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_64
                Exit Select
            Case 65
                AddHandler OBJ_MOTOR_GECKOFX_65.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_65
                Exit Select
            Case 66
                AddHandler OBJ_MOTOR_GECKOFX_66.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_66
                Exit Select
            Case 67
                AddHandler OBJ_MOTOR_GECKOFX_67.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_67
                Exit Select
            Case 68
                AddHandler OBJ_MOTOR_GECKOFX_68.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_68
                Exit Select
            Case 69
                AddHandler OBJ_MOTOR_GECKOFX_69.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_69
                Exit Select
            Case 70
                AddHandler OBJ_MOTOR_GECKOFX_70.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_70
                Exit Select
            Case 71
                AddHandler OBJ_MOTOR_GECKOFX_71.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_71
                Exit Select
            Case 72
                AddHandler OBJ_MOTOR_GECKOFX_72.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_72
                Exit Select
            Case 73
                AddHandler OBJ_MOTOR_GECKOFX_73.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_73
                Exit Select
            Case 74
                AddHandler OBJ_MOTOR_GECKOFX_74.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_74
                Exit Select
            Case 75
                AddHandler OBJ_MOTOR_GECKOFX_75.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_75
                Exit Select
            Case 76
                AddHandler OBJ_MOTOR_GECKOFX_76.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_76
                Exit Select
            Case 77
                AddHandler OBJ_MOTOR_GECKOFX_77.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_77
                Exit Select
            Case 78
                AddHandler OBJ_MOTOR_GECKOFX_78.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_78
                Exit Select
            Case 79
                AddHandler OBJ_MOTOR_GECKOFX_79.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_79
                Exit Select
            Case 80
                AddHandler OBJ_MOTOR_GECKOFX_80.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_80
                Exit Select
            Case 81
                AddHandler OBJ_MOTOR_GECKOFX_81.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_81
                Exit Select
            Case 82
                AddHandler OBJ_MOTOR_GECKOFX_82.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_82
                Exit Select
            Case 83
                AddHandler OBJ_MOTOR_GECKOFX_83.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_83
                Exit Select
            Case 84
                AddHandler OBJ_MOTOR_GECKOFX_84.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_84
                Exit Select
            Case 85
                AddHandler OBJ_MOTOR_GECKOFX_85.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_85
                Exit Select
            Case 86
                AddHandler OBJ_MOTOR_GECKOFX_86.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_86
                Exit Select
            Case 87
                AddHandler OBJ_MOTOR_GECKOFX_87.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_87
                Exit Select
            Case 88
                AddHandler OBJ_MOTOR_GECKOFX_88.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_88
                Exit Select
            Case 89
                AddHandler OBJ_MOTOR_GECKOFX_89.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_89
                Exit Select
            Case 90
                AddHandler OBJ_MOTOR_GECKOFX_90.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_90
                Exit Select
            Case 91
                AddHandler OBJ_MOTOR_GECKOFX_91.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_91
                Exit Select
            Case 92
                AddHandler OBJ_MOTOR_GECKOFX_92.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_92
                Exit Select
            Case 93
                AddHandler OBJ_MOTOR_GECKOFX_93.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_93
                Exit Select
            Case 94
                AddHandler OBJ_MOTOR_GECKOFX_94.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_94
                Exit Select
            Case 95
                AddHandler OBJ_MOTOR_GECKOFX_95.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_95
                Exit Select
            Case 96
                AddHandler OBJ_MOTOR_GECKOFX_96.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_96
                Exit Select
            Case 97
                AddHandler OBJ_MOTOR_GECKOFX_97.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_97
                Exit Select
            Case 98
                AddHandler OBJ_MOTOR_GECKOFX_98.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_98
                Exit Select
            Case 99
                AddHandler OBJ_MOTOR_GECKOFX_99.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_99
                Exit Select
            Case 100
                AddHandler OBJ_MOTOR_GECKOFX_100.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_100
                Exit Select
            Case 101
                AddHandler OBJ_MOTOR_GECKOFX_101.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_101
                Exit Select
            Case 102
                AddHandler OBJ_MOTOR_GECKOFX_102.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_102
                Exit Select
            Case 103
                AddHandler OBJ_MOTOR_GECKOFX_103.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_103
                Exit Select
            Case 104
                AddHandler OBJ_MOTOR_GECKOFX_104.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_104
                Exit Select
            Case 105
                AddHandler OBJ_MOTOR_GECKOFX_105.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_105
                Exit Select
            Case 106
                AddHandler OBJ_MOTOR_GECKOFX_106.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_106
                Exit Select
            Case 107
                AddHandler OBJ_MOTOR_GECKOFX_107.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_107
                Exit Select
            Case 108
                AddHandler OBJ_MOTOR_GECKOFX_108.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_108
                Exit Select
            Case 109
                AddHandler OBJ_MOTOR_GECKOFX_109.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_109
                Exit Select
            Case 110
                AddHandler OBJ_MOTOR_GECKOFX_110.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_110
                Exit Select
            Case 111
                AddHandler OBJ_MOTOR_GECKOFX_111.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_111
                Exit Select
            Case 112
                AddHandler OBJ_MOTOR_GECKOFX_112.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_112
                Exit Select
            Case 113
                AddHandler OBJ_MOTOR_GECKOFX_113.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_113
                Exit Select
            Case 114
                AddHandler OBJ_MOTOR_GECKOFX_114.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_114
                Exit Select
            Case 115
                AddHandler OBJ_MOTOR_GECKOFX_115.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_115
                Exit Select
            Case 116
                AddHandler OBJ_MOTOR_GECKOFX_116.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_116
                Exit Select
            Case 117
                AddHandler OBJ_MOTOR_GECKOFX_117.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_117
                Exit Select
            Case 118
                AddHandler OBJ_MOTOR_GECKOFX_118.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_118
                Exit Select
            Case 119
                AddHandler OBJ_MOTOR_GECKOFX_119.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_119
                Exit Select
            Case 120
                AddHandler OBJ_MOTOR_GECKOFX_120.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_120
                Exit Select
            Case 121
                AddHandler OBJ_MOTOR_GECKOFX_121.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_121
                Exit Select
            Case 122
                AddHandler OBJ_MOTOR_GECKOFX_122.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_122
                Exit Select
            Case 123
                AddHandler OBJ_MOTOR_GECKOFX_123.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_123
                Exit Select
            Case 124
                AddHandler OBJ_MOTOR_GECKOFX_124.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_124
                Exit Select
            Case 125
                AddHandler OBJ_MOTOR_GECKOFX_125.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_125
                Exit Select
            Case 126
                AddHandler OBJ_MOTOR_GECKOFX_126.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_126
                Exit Select
            Case 127
                AddHandler OBJ_MOTOR_GECKOFX_127.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_127
                Exit Select
            Case 128
                AddHandler OBJ_MOTOR_GECKOFX_128.StatusTextChanged, AddressOf proc_carregamento_statustext_geckofx_128
                Exit Select
            



        End Select


    End Sub






    'Evento de clicar na página

    Private Sub proc_ligar_evento_clicar_na_pagina_geckofx() 'Liga o evento de Domclick de página
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso


            Case 1
                AddHandler OBJ_MOTOR_GECKOFX_1.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 2
                AddHandler OBJ_MOTOR_GECKOFX_2.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 3
                AddHandler OBJ_MOTOR_GECKOFX_3.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 4
                AddHandler OBJ_MOTOR_GECKOFX_4.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 5
                AddHandler OBJ_MOTOR_GECKOFX_5.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 6
                AddHandler OBJ_MOTOR_GECKOFX_6.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 7
                AddHandler OBJ_MOTOR_GECKOFX_7.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 8
                AddHandler OBJ_MOTOR_GECKOFX_8.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 9
                AddHandler OBJ_MOTOR_GECKOFX_9.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 10
                AddHandler OBJ_MOTOR_GECKOFX_10.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 11
                AddHandler OBJ_MOTOR_GECKOFX_11.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 12
                AddHandler OBJ_MOTOR_GECKOFX_12.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 13
                AddHandler OBJ_MOTOR_GECKOFX_13.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 14
                AddHandler OBJ_MOTOR_GECKOFX_14.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 15
                AddHandler OBJ_MOTOR_GECKOFX_15.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 16
                AddHandler OBJ_MOTOR_GECKOFX_16.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 17
                AddHandler OBJ_MOTOR_GECKOFX_17.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 18
                AddHandler OBJ_MOTOR_GECKOFX_18.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 19
                AddHandler OBJ_MOTOR_GECKOFX_19.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 20
                AddHandler OBJ_MOTOR_GECKOFX_20.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 21
                AddHandler OBJ_MOTOR_GECKOFX_21.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 22
                AddHandler OBJ_MOTOR_GECKOFX_22.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 23
                AddHandler OBJ_MOTOR_GECKOFX_23.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 24
                AddHandler OBJ_MOTOR_GECKOFX_24.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 25
                AddHandler OBJ_MOTOR_GECKOFX_25.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 26
                AddHandler OBJ_MOTOR_GECKOFX_26.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 27
                AddHandler OBJ_MOTOR_GECKOFX_27.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 28
                AddHandler OBJ_MOTOR_GECKOFX_28.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 29
                AddHandler OBJ_MOTOR_GECKOFX_29.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 30
                AddHandler OBJ_MOTOR_GECKOFX_30.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 31
                AddHandler OBJ_MOTOR_GECKOFX_31.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 32
                AddHandler OBJ_MOTOR_GECKOFX_32.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 33
                AddHandler OBJ_MOTOR_GECKOFX_33.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 34
                AddHandler OBJ_MOTOR_GECKOFX_34.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 35
                AddHandler OBJ_MOTOR_GECKOFX_35.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 36
                AddHandler OBJ_MOTOR_GECKOFX_36.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 37
                AddHandler OBJ_MOTOR_GECKOFX_37.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 38
                AddHandler OBJ_MOTOR_GECKOFX_38.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 39
                AddHandler OBJ_MOTOR_GECKOFX_39.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 40
                AddHandler OBJ_MOTOR_GECKOFX_40.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 41
                AddHandler OBJ_MOTOR_GECKOFX_41.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 42
                AddHandler OBJ_MOTOR_GECKOFX_42.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 43
                AddHandler OBJ_MOTOR_GECKOFX_43.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 44
                AddHandler OBJ_MOTOR_GECKOFX_44.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 45
                AddHandler OBJ_MOTOR_GECKOFX_45.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 46
                AddHandler OBJ_MOTOR_GECKOFX_46.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 47
                AddHandler OBJ_MOTOR_GECKOFX_47.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 48
                AddHandler OBJ_MOTOR_GECKOFX_48.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 49
                AddHandler OBJ_MOTOR_GECKOFX_49.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 50
                AddHandler OBJ_MOTOR_GECKOFX_50.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 51
                AddHandler OBJ_MOTOR_GECKOFX_51.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 52
                AddHandler OBJ_MOTOR_GECKOFX_52.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 53
                AddHandler OBJ_MOTOR_GECKOFX_53.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 54
                AddHandler OBJ_MOTOR_GECKOFX_54.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 55
                AddHandler OBJ_MOTOR_GECKOFX_55.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 56
                AddHandler OBJ_MOTOR_GECKOFX_56.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 57
                AddHandler OBJ_MOTOR_GECKOFX_57.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 58
                AddHandler OBJ_MOTOR_GECKOFX_58.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 59
                AddHandler OBJ_MOTOR_GECKOFX_59.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 60
                AddHandler OBJ_MOTOR_GECKOFX_60.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 61
                AddHandler OBJ_MOTOR_GECKOFX_61.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 62
                AddHandler OBJ_MOTOR_GECKOFX_62.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 63
                AddHandler OBJ_MOTOR_GECKOFX_63.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 64
                AddHandler OBJ_MOTOR_GECKOFX_64.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 65
                AddHandler OBJ_MOTOR_GECKOFX_65.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 66
                AddHandler OBJ_MOTOR_GECKOFX_66.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 67
                AddHandler OBJ_MOTOR_GECKOFX_67.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 68
                AddHandler OBJ_MOTOR_GECKOFX_68.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 69
                AddHandler OBJ_MOTOR_GECKOFX_69.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 70
                AddHandler OBJ_MOTOR_GECKOFX_70.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 71
                AddHandler OBJ_MOTOR_GECKOFX_71.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 72
                AddHandler OBJ_MOTOR_GECKOFX_72.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 73
                AddHandler OBJ_MOTOR_GECKOFX_73.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 74
                AddHandler OBJ_MOTOR_GECKOFX_74.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 75
                AddHandler OBJ_MOTOR_GECKOFX_75.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 76
                AddHandler OBJ_MOTOR_GECKOFX_76.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 77
                AddHandler OBJ_MOTOR_GECKOFX_77.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 78
                AddHandler OBJ_MOTOR_GECKOFX_78.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 79
                AddHandler OBJ_MOTOR_GECKOFX_79.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 80
                AddHandler OBJ_MOTOR_GECKOFX_80.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 81
                AddHandler OBJ_MOTOR_GECKOFX_81.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 82
                AddHandler OBJ_MOTOR_GECKOFX_82.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 83
                AddHandler OBJ_MOTOR_GECKOFX_83.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 84
                AddHandler OBJ_MOTOR_GECKOFX_84.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 85
                AddHandler OBJ_MOTOR_GECKOFX_85.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 86
                AddHandler OBJ_MOTOR_GECKOFX_86.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 87
                AddHandler OBJ_MOTOR_GECKOFX_87.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 88
                AddHandler OBJ_MOTOR_GECKOFX_88.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 89
                AddHandler OBJ_MOTOR_GECKOFX_89.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 90
                AddHandler OBJ_MOTOR_GECKOFX_90.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 91
                AddHandler OBJ_MOTOR_GECKOFX_91.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 92
                AddHandler OBJ_MOTOR_GECKOFX_92.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 93
                AddHandler OBJ_MOTOR_GECKOFX_93.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 94
                AddHandler OBJ_MOTOR_GECKOFX_94.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 95
                AddHandler OBJ_MOTOR_GECKOFX_95.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 96
                AddHandler OBJ_MOTOR_GECKOFX_96.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 97
                AddHandler OBJ_MOTOR_GECKOFX_97.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 98
                AddHandler OBJ_MOTOR_GECKOFX_98.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 99
                AddHandler OBJ_MOTOR_GECKOFX_99.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 100
                AddHandler OBJ_MOTOR_GECKOFX_100.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 101
                AddHandler OBJ_MOTOR_GECKOFX_101.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 102
                AddHandler OBJ_MOTOR_GECKOFX_102.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 103
                AddHandler OBJ_MOTOR_GECKOFX_103.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 104
                AddHandler OBJ_MOTOR_GECKOFX_104.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 105
                AddHandler OBJ_MOTOR_GECKOFX_105.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 106
                AddHandler OBJ_MOTOR_GECKOFX_106.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 107
                AddHandler OBJ_MOTOR_GECKOFX_107.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 108
                AddHandler OBJ_MOTOR_GECKOFX_108.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 109
                AddHandler OBJ_MOTOR_GECKOFX_109.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 110
                AddHandler OBJ_MOTOR_GECKOFX_110.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 111
                AddHandler OBJ_MOTOR_GECKOFX_111.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 112
                AddHandler OBJ_MOTOR_GECKOFX_112.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 113
                AddHandler OBJ_MOTOR_GECKOFX_113.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 114
                AddHandler OBJ_MOTOR_GECKOFX_114.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 115
                AddHandler OBJ_MOTOR_GECKOFX_115.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 116
                AddHandler OBJ_MOTOR_GECKOFX_116.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 117
                AddHandler OBJ_MOTOR_GECKOFX_117.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 118
                AddHandler OBJ_MOTOR_GECKOFX_118.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 119
                AddHandler OBJ_MOTOR_GECKOFX_119.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 120
                AddHandler OBJ_MOTOR_GECKOFX_120.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 121
                AddHandler OBJ_MOTOR_GECKOFX_121.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 122
                AddHandler OBJ_MOTOR_GECKOFX_122.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 123
                AddHandler OBJ_MOTOR_GECKOFX_123.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 124
                AddHandler OBJ_MOTOR_GECKOFX_124.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 125
                AddHandler OBJ_MOTOR_GECKOFX_125.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 126
                AddHandler OBJ_MOTOR_GECKOFX_126.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 127
                AddHandler OBJ_MOTOR_GECKOFX_127.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

            Case 128
                AddHandler OBJ_MOTOR_GECKOFX_128.DomClick, AddressOf proc_clicar_na_pagina_geckofx 'Clicar na página
                Exit Select

           




        End Select


    End Sub
    





    'Evento mover mouse sobre motor geckofx

    Private Sub proc_ligar_evento_mover_mouse_geckofx() 'Liga o evento de mover mouse sobre o motor geckofx
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso


            Case 1
                AddHandler OBJ_MOTOR_GECKOFX_1.DomMouseMove, AddressOf evento_mouse_mover_geckofx_1
                Exit Select
            Case 2
                AddHandler OBJ_MOTOR_GECKOFX_2.DomMouseMove, AddressOf evento_mouse_mover_geckofx_2
                Exit Select
            Case 3
                AddHandler OBJ_MOTOR_GECKOFX_3.DomMouseMove, AddressOf evento_mouse_mover_geckofx_3
                Exit Select
            Case 4
                AddHandler OBJ_MOTOR_GECKOFX_4.DomMouseMove, AddressOf evento_mouse_mover_geckofx_4
                Exit Select
            Case 5
                AddHandler OBJ_MOTOR_GECKOFX_5.DomMouseMove, AddressOf evento_mouse_mover_geckofx_5
                Exit Select
            Case 6
                AddHandler OBJ_MOTOR_GECKOFX_6.DomMouseMove, AddressOf evento_mouse_mover_geckofx_6
                Exit Select
            Case 7
                AddHandler OBJ_MOTOR_GECKOFX_7.DomMouseMove, AddressOf evento_mouse_mover_geckofx_7
                Exit Select
            Case 8
                AddHandler OBJ_MOTOR_GECKOFX_8.DomMouseMove, AddressOf evento_mouse_mover_geckofx_8
                Exit Select
            Case 9
                AddHandler OBJ_MOTOR_GECKOFX_9.DomMouseMove, AddressOf evento_mouse_mover_geckofx_9
                Exit Select
            Case 10
                AddHandler OBJ_MOTOR_GECKOFX_10.DomMouseMove, AddressOf evento_mouse_mover_geckofx_10
                Exit Select
            Case 11
                AddHandler OBJ_MOTOR_GECKOFX_11.DomMouseMove, AddressOf evento_mouse_mover_geckofx_11
                Exit Select
            Case 12
                AddHandler OBJ_MOTOR_GECKOFX_12.DomMouseMove, AddressOf evento_mouse_mover_geckofx_12
                Exit Select
            Case 13
                AddHandler OBJ_MOTOR_GECKOFX_13.DomMouseMove, AddressOf evento_mouse_mover_geckofx_13
                Exit Select
            Case 14
                AddHandler OBJ_MOTOR_GECKOFX_14.DomMouseMove, AddressOf evento_mouse_mover_geckofx_14
                Exit Select
            Case 15
                AddHandler OBJ_MOTOR_GECKOFX_15.DomMouseMove, AddressOf evento_mouse_mover_geckofx_15
                Exit Select
            Case 16
                AddHandler OBJ_MOTOR_GECKOFX_16.DomMouseMove, AddressOf evento_mouse_mover_geckofx_16
                Exit Select
            Case 17
                AddHandler OBJ_MOTOR_GECKOFX_17.DomMouseMove, AddressOf evento_mouse_mover_geckofx_17
                Exit Select
            Case 18
                AddHandler OBJ_MOTOR_GECKOFX_18.DomMouseMove, AddressOf evento_mouse_mover_geckofx_18
                Exit Select
            Case 19
                AddHandler OBJ_MOTOR_GECKOFX_19.DomMouseMove, AddressOf evento_mouse_mover_geckofx_19
                Exit Select
            Case 20
                AddHandler OBJ_MOTOR_GECKOFX_20.DomMouseMove, AddressOf evento_mouse_mover_geckofx_20
                Exit Select
            Case 21
                AddHandler OBJ_MOTOR_GECKOFX_21.DomMouseMove, AddressOf evento_mouse_mover_geckofx_21
                Exit Select
            Case 22
                AddHandler OBJ_MOTOR_GECKOFX_22.DomMouseMove, AddressOf evento_mouse_mover_geckofx_22
                Exit Select
            Case 23
                AddHandler OBJ_MOTOR_GECKOFX_23.DomMouseMove, AddressOf evento_mouse_mover_geckofx_23
                Exit Select
            Case 24
                AddHandler OBJ_MOTOR_GECKOFX_24.DomMouseMove, AddressOf evento_mouse_mover_geckofx_24
                Exit Select
            Case 25
                AddHandler OBJ_MOTOR_GECKOFX_25.DomMouseMove, AddressOf evento_mouse_mover_geckofx_25
                Exit Select
            Case 26
                AddHandler OBJ_MOTOR_GECKOFX_26.DomMouseMove, AddressOf evento_mouse_mover_geckofx_26
                Exit Select
            Case 27
                AddHandler OBJ_MOTOR_GECKOFX_27.DomMouseMove, AddressOf evento_mouse_mover_geckofx_27
                Exit Select
            Case 28
                AddHandler OBJ_MOTOR_GECKOFX_28.DomMouseMove, AddressOf evento_mouse_mover_geckofx_28
                Exit Select
            Case 29
                AddHandler OBJ_MOTOR_GECKOFX_29.DomMouseMove, AddressOf evento_mouse_mover_geckofx_29
                Exit Select
            Case 30
                AddHandler OBJ_MOTOR_GECKOFX_30.DomMouseMove, AddressOf evento_mouse_mover_geckofx_30
                Exit Select
            Case 31
                AddHandler OBJ_MOTOR_GECKOFX_31.DomMouseMove, AddressOf evento_mouse_mover_geckofx_31
                Exit Select
            Case 32
                AddHandler OBJ_MOTOR_GECKOFX_32.DomMouseMove, AddressOf evento_mouse_mover_geckofx_32
                Exit Select
            Case 33
                AddHandler OBJ_MOTOR_GECKOFX_33.DomMouseMove, AddressOf evento_mouse_mover_geckofx_33
                Exit Select
            Case 34
                AddHandler OBJ_MOTOR_GECKOFX_34.DomMouseMove, AddressOf evento_mouse_mover_geckofx_34
                Exit Select
            Case 35
                AddHandler OBJ_MOTOR_GECKOFX_35.DomMouseMove, AddressOf evento_mouse_mover_geckofx_35
                Exit Select
            Case 36
                AddHandler OBJ_MOTOR_GECKOFX_36.DomMouseMove, AddressOf evento_mouse_mover_geckofx_36
                Exit Select
            Case 37
                AddHandler OBJ_MOTOR_GECKOFX_37.DomMouseMove, AddressOf evento_mouse_mover_geckofx_37
                Exit Select
            Case 38
                AddHandler OBJ_MOTOR_GECKOFX_38.DomMouseMove, AddressOf evento_mouse_mover_geckofx_38
                Exit Select
            Case 39
                AddHandler OBJ_MOTOR_GECKOFX_39.DomMouseMove, AddressOf evento_mouse_mover_geckofx_39
                Exit Select
            Case 40
                AddHandler OBJ_MOTOR_GECKOFX_40.DomMouseMove, AddressOf evento_mouse_mover_geckofx_40
                Exit Select
            Case 41
                AddHandler OBJ_MOTOR_GECKOFX_41.DomMouseMove, AddressOf evento_mouse_mover_geckofx_41
                Exit Select
            Case 42
                AddHandler OBJ_MOTOR_GECKOFX_42.DomMouseMove, AddressOf evento_mouse_mover_geckofx_42
                Exit Select
            Case 43
                AddHandler OBJ_MOTOR_GECKOFX_43.DomMouseMove, AddressOf evento_mouse_mover_geckofx_43
                Exit Select
            Case 44
                AddHandler OBJ_MOTOR_GECKOFX_44.DomMouseMove, AddressOf evento_mouse_mover_geckofx_44
                Exit Select
            Case 45
                AddHandler OBJ_MOTOR_GECKOFX_45.DomMouseMove, AddressOf evento_mouse_mover_geckofx_45
                Exit Select
            Case 46
                AddHandler OBJ_MOTOR_GECKOFX_46.DomMouseMove, AddressOf evento_mouse_mover_geckofx_46
                Exit Select
            Case 47
                AddHandler OBJ_MOTOR_GECKOFX_47.DomMouseMove, AddressOf evento_mouse_mover_geckofx_47
                Exit Select
            Case 48
                AddHandler OBJ_MOTOR_GECKOFX_48.DomMouseMove, AddressOf evento_mouse_mover_geckofx_48
                Exit Select
            Case 49
                AddHandler OBJ_MOTOR_GECKOFX_49.DomMouseMove, AddressOf evento_mouse_mover_geckofx_49
                Exit Select
            Case 50
                AddHandler OBJ_MOTOR_GECKOFX_50.DomMouseMove, AddressOf evento_mouse_mover_geckofx_50
                Exit Select
            Case 51
                AddHandler OBJ_MOTOR_GECKOFX_51.DomMouseMove, AddressOf evento_mouse_mover_geckofx_51
                Exit Select
            Case 52
                AddHandler OBJ_MOTOR_GECKOFX_52.DomMouseMove, AddressOf evento_mouse_mover_geckofx_52
                Exit Select
            Case 53
                AddHandler OBJ_MOTOR_GECKOFX_53.DomMouseMove, AddressOf evento_mouse_mover_geckofx_53
                Exit Select
            Case 54
                AddHandler OBJ_MOTOR_GECKOFX_54.DomMouseMove, AddressOf evento_mouse_mover_geckofx_54
                Exit Select
            Case 55
                AddHandler OBJ_MOTOR_GECKOFX_55.DomMouseMove, AddressOf evento_mouse_mover_geckofx_55
                Exit Select
            Case 56
                AddHandler OBJ_MOTOR_GECKOFX_56.DomMouseMove, AddressOf evento_mouse_mover_geckofx_56
                Exit Select
            Case 57
                AddHandler OBJ_MOTOR_GECKOFX_57.DomMouseMove, AddressOf evento_mouse_mover_geckofx_57
                Exit Select
            Case 58
                AddHandler OBJ_MOTOR_GECKOFX_58.DomMouseMove, AddressOf evento_mouse_mover_geckofx_58
                Exit Select
            Case 59
                AddHandler OBJ_MOTOR_GECKOFX_59.DomMouseMove, AddressOf evento_mouse_mover_geckofx_59
                Exit Select
            Case 60
                AddHandler OBJ_MOTOR_GECKOFX_60.DomMouseMove, AddressOf evento_mouse_mover_geckofx_60
                Exit Select
            Case 61
                AddHandler OBJ_MOTOR_GECKOFX_61.DomMouseMove, AddressOf evento_mouse_mover_geckofx_61
                Exit Select
            Case 62
                AddHandler OBJ_MOTOR_GECKOFX_62.DomMouseMove, AddressOf evento_mouse_mover_geckofx_62
                Exit Select
            Case 63
                AddHandler OBJ_MOTOR_GECKOFX_63.DomMouseMove, AddressOf evento_mouse_mover_geckofx_63
                Exit Select
            Case 64
                AddHandler OBJ_MOTOR_GECKOFX_64.DomMouseMove, AddressOf evento_mouse_mover_geckofx_64
                Exit Select
            Case 65
                AddHandler OBJ_MOTOR_GECKOFX_65.DomMouseMove, AddressOf evento_mouse_mover_geckofx_65
                Exit Select
            Case 66
                AddHandler OBJ_MOTOR_GECKOFX_66.DomMouseMove, AddressOf evento_mouse_mover_geckofx_66
                Exit Select
            Case 67
                AddHandler OBJ_MOTOR_GECKOFX_67.DomMouseMove, AddressOf evento_mouse_mover_geckofx_67
                Exit Select
            Case 68
                AddHandler OBJ_MOTOR_GECKOFX_68.DomMouseMove, AddressOf evento_mouse_mover_geckofx_68
                Exit Select
            Case 69
                AddHandler OBJ_MOTOR_GECKOFX_69.DomMouseMove, AddressOf evento_mouse_mover_geckofx_69
                Exit Select
            Case 70
                AddHandler OBJ_MOTOR_GECKOFX_70.DomMouseMove, AddressOf evento_mouse_mover_geckofx_70
                Exit Select
            Case 71
                AddHandler OBJ_MOTOR_GECKOFX_71.DomMouseMove, AddressOf evento_mouse_mover_geckofx_71
                Exit Select
            Case 72
                AddHandler OBJ_MOTOR_GECKOFX_72.DomMouseMove, AddressOf evento_mouse_mover_geckofx_72
                Exit Select
            Case 73
                AddHandler OBJ_MOTOR_GECKOFX_73.DomMouseMove, AddressOf evento_mouse_mover_geckofx_73
                Exit Select
            Case 74
                AddHandler OBJ_MOTOR_GECKOFX_74.DomMouseMove, AddressOf evento_mouse_mover_geckofx_74
                Exit Select
            Case 75
                AddHandler OBJ_MOTOR_GECKOFX_75.DomMouseMove, AddressOf evento_mouse_mover_geckofx_75
                Exit Select
            Case 76
                AddHandler OBJ_MOTOR_GECKOFX_76.DomMouseMove, AddressOf evento_mouse_mover_geckofx_76
                Exit Select
            Case 77
                AddHandler OBJ_MOTOR_GECKOFX_77.DomMouseMove, AddressOf evento_mouse_mover_geckofx_77
                Exit Select
            Case 78
                AddHandler OBJ_MOTOR_GECKOFX_78.DomMouseMove, AddressOf evento_mouse_mover_geckofx_78
                Exit Select
            Case 79
                AddHandler OBJ_MOTOR_GECKOFX_79.DomMouseMove, AddressOf evento_mouse_mover_geckofx_79
                Exit Select
            Case 80
                AddHandler OBJ_MOTOR_GECKOFX_80.DomMouseMove, AddressOf evento_mouse_mover_geckofx_80
                Exit Select
            Case 81
                AddHandler OBJ_MOTOR_GECKOFX_81.DomMouseMove, AddressOf evento_mouse_mover_geckofx_81
                Exit Select
            Case 82
                AddHandler OBJ_MOTOR_GECKOFX_82.DomMouseMove, AddressOf evento_mouse_mover_geckofx_82
                Exit Select
            Case 83
                AddHandler OBJ_MOTOR_GECKOFX_83.DomMouseMove, AddressOf evento_mouse_mover_geckofx_83
                Exit Select
            Case 84
                AddHandler OBJ_MOTOR_GECKOFX_84.DomMouseMove, AddressOf evento_mouse_mover_geckofx_84
                Exit Select
            Case 85
                AddHandler OBJ_MOTOR_GECKOFX_85.DomMouseMove, AddressOf evento_mouse_mover_geckofx_85
                Exit Select
            Case 86
                AddHandler OBJ_MOTOR_GECKOFX_86.DomMouseMove, AddressOf evento_mouse_mover_geckofx_86
                Exit Select
            Case 87
                AddHandler OBJ_MOTOR_GECKOFX_87.DomMouseMove, AddressOf evento_mouse_mover_geckofx_87
                Exit Select
            Case 88
                AddHandler OBJ_MOTOR_GECKOFX_88.DomMouseMove, AddressOf evento_mouse_mover_geckofx_88
                Exit Select
            Case 89
                AddHandler OBJ_MOTOR_GECKOFX_89.DomMouseMove, AddressOf evento_mouse_mover_geckofx_89
                Exit Select
            Case 90
                AddHandler OBJ_MOTOR_GECKOFX_90.DomMouseMove, AddressOf evento_mouse_mover_geckofx_90
                Exit Select
            Case 91
                AddHandler OBJ_MOTOR_GECKOFX_91.DomMouseMove, AddressOf evento_mouse_mover_geckofx_91
                Exit Select
            Case 92
                AddHandler OBJ_MOTOR_GECKOFX_92.DomMouseMove, AddressOf evento_mouse_mover_geckofx_92
                Exit Select
            Case 93
                AddHandler OBJ_MOTOR_GECKOFX_93.DomMouseMove, AddressOf evento_mouse_mover_geckofx_93
                Exit Select
            Case 94
                AddHandler OBJ_MOTOR_GECKOFX_94.DomMouseMove, AddressOf evento_mouse_mover_geckofx_94
                Exit Select
            Case 95
                AddHandler OBJ_MOTOR_GECKOFX_95.DomMouseMove, AddressOf evento_mouse_mover_geckofx_95
                Exit Select
            Case 96
                AddHandler OBJ_MOTOR_GECKOFX_96.DomMouseMove, AddressOf evento_mouse_mover_geckofx_96
                Exit Select
            Case 97
                AddHandler OBJ_MOTOR_GECKOFX_97.DomMouseMove, AddressOf evento_mouse_mover_geckofx_97
                Exit Select
            Case 98
                AddHandler OBJ_MOTOR_GECKOFX_98.DomMouseMove, AddressOf evento_mouse_mover_geckofx_98
                Exit Select
            Case 99
                AddHandler OBJ_MOTOR_GECKOFX_99.DomMouseMove, AddressOf evento_mouse_mover_geckofx_99
                Exit Select
            Case 100
                AddHandler OBJ_MOTOR_GECKOFX_100.DomMouseMove, AddressOf evento_mouse_mover_geckofx_100
                Exit Select
            Case 101
                AddHandler OBJ_MOTOR_GECKOFX_101.DomMouseMove, AddressOf evento_mouse_mover_geckofx_101
                Exit Select
            Case 102
                AddHandler OBJ_MOTOR_GECKOFX_102.DomMouseMove, AddressOf evento_mouse_mover_geckofx_102
                Exit Select
            Case 103
                AddHandler OBJ_MOTOR_GECKOFX_103.DomMouseMove, AddressOf evento_mouse_mover_geckofx_103
                Exit Select
            Case 104
                AddHandler OBJ_MOTOR_GECKOFX_104.DomMouseMove, AddressOf evento_mouse_mover_geckofx_104
                Exit Select
            Case 105
                AddHandler OBJ_MOTOR_GECKOFX_105.DomMouseMove, AddressOf evento_mouse_mover_geckofx_105
                Exit Select
            Case 106
                AddHandler OBJ_MOTOR_GECKOFX_106.DomMouseMove, AddressOf evento_mouse_mover_geckofx_106
                Exit Select
            Case 107
                AddHandler OBJ_MOTOR_GECKOFX_107.DomMouseMove, AddressOf evento_mouse_mover_geckofx_107
                Exit Select
            Case 108
                AddHandler OBJ_MOTOR_GECKOFX_108.DomMouseMove, AddressOf evento_mouse_mover_geckofx_108
                Exit Select
            Case 109
                AddHandler OBJ_MOTOR_GECKOFX_109.DomMouseMove, AddressOf evento_mouse_mover_geckofx_109
                Exit Select
            Case 110
                AddHandler OBJ_MOTOR_GECKOFX_110.DomMouseMove, AddressOf evento_mouse_mover_geckofx_110
                Exit Select
            Case 111
                AddHandler OBJ_MOTOR_GECKOFX_111.DomMouseMove, AddressOf evento_mouse_mover_geckofx_111
                Exit Select
            Case 112
                AddHandler OBJ_MOTOR_GECKOFX_112.DomMouseMove, AddressOf evento_mouse_mover_geckofx_112
                Exit Select
            Case 113
                AddHandler OBJ_MOTOR_GECKOFX_113.DomMouseMove, AddressOf evento_mouse_mover_geckofx_113
                Exit Select
            Case 114
                AddHandler OBJ_MOTOR_GECKOFX_114.DomMouseMove, AddressOf evento_mouse_mover_geckofx_114
                Exit Select
            Case 115
                AddHandler OBJ_MOTOR_GECKOFX_115.DomMouseMove, AddressOf evento_mouse_mover_geckofx_115
                Exit Select
            Case 116
                AddHandler OBJ_MOTOR_GECKOFX_116.DomMouseMove, AddressOf evento_mouse_mover_geckofx_116
                Exit Select
            Case 117
                AddHandler OBJ_MOTOR_GECKOFX_117.DomMouseMove, AddressOf evento_mouse_mover_geckofx_117
                Exit Select
            Case 118
                AddHandler OBJ_MOTOR_GECKOFX_118.DomMouseMove, AddressOf evento_mouse_mover_geckofx_118
                Exit Select
            Case 119
                AddHandler OBJ_MOTOR_GECKOFX_119.DomMouseMove, AddressOf evento_mouse_mover_geckofx_119
                Exit Select
            Case 120
                AddHandler OBJ_MOTOR_GECKOFX_120.DomMouseMove, AddressOf evento_mouse_mover_geckofx_120
                Exit Select
            Case 121
                AddHandler OBJ_MOTOR_GECKOFX_121.DomMouseMove, AddressOf evento_mouse_mover_geckofx_121
                Exit Select
            Case 122
                AddHandler OBJ_MOTOR_GECKOFX_122.DomMouseMove, AddressOf evento_mouse_mover_geckofx_122
                Exit Select
            Case 123
                AddHandler OBJ_MOTOR_GECKOFX_123.DomMouseMove, AddressOf evento_mouse_mover_geckofx_123
                Exit Select
            Case 124
                AddHandler OBJ_MOTOR_GECKOFX_124.DomMouseMove, AddressOf evento_mouse_mover_geckofx_124
                Exit Select
            Case 125
                AddHandler OBJ_MOTOR_GECKOFX_125.DomMouseMove, AddressOf evento_mouse_mover_geckofx_125
                Exit Select
            Case 126
                AddHandler OBJ_MOTOR_GECKOFX_126.DomMouseMove, AddressOf evento_mouse_mover_geckofx_126
                Exit Select
            Case 127
                AddHandler OBJ_MOTOR_GECKOFX_127.DomMouseMove, AddressOf evento_mouse_mover_geckofx_127
                Exit Select
            Case 128
                AddHandler OBJ_MOTOR_GECKOFX_128.DomMouseMove, AddressOf evento_mouse_mover_geckofx_128
                Exit Select





        End Select


    End Sub








    'Eventos de cada backgroundworker virtual

    Private Sub proc_ligar_evento_backgroundworkers_virtuais() 'Liga os eventos dos backgroundworkers virtuais
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso


            Case 1
                AddHandler OBJ_BACKGROUNDWORKER_1.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_1
                Exit Select
            Case 2
                AddHandler OBJ_BACKGROUNDWORKER_2.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_2
                Exit Select
            Case 3
                AddHandler OBJ_BACKGROUNDWORKER_3.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_3
                Exit Select
            Case 4
                AddHandler OBJ_BACKGROUNDWORKER_4.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_4
                Exit Select
            Case 5
                AddHandler OBJ_BACKGROUNDWORKER_5.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_5
                Exit Select
            Case 6
                AddHandler OBJ_BACKGROUNDWORKER_6.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_6
                Exit Select
            Case 7
                AddHandler OBJ_BACKGROUNDWORKER_7.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_7
                Exit Select
            Case 8
                AddHandler OBJ_BACKGROUNDWORKER_8.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_8
                Exit Select
            Case 9
                AddHandler OBJ_BACKGROUNDWORKER_9.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_9
                Exit Select
            Case 10
                AddHandler OBJ_BACKGROUNDWORKER_10.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_10
                Exit Select
            Case 11
                AddHandler OBJ_BACKGROUNDWORKER_11.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_11
                Exit Select
            Case 12
                AddHandler OBJ_BACKGROUNDWORKER_12.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_12
                Exit Select
            Case 13
                AddHandler OBJ_BACKGROUNDWORKER_13.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_13
                Exit Select
            Case 14
                AddHandler OBJ_BACKGROUNDWORKER_14.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_14
                Exit Select
            Case 15
                AddHandler OBJ_BACKGROUNDWORKER_15.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_15
                Exit Select
            Case 16
                AddHandler OBJ_BACKGROUNDWORKER_16.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_16
                Exit Select
            Case 17
                AddHandler OBJ_BACKGROUNDWORKER_17.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_17
                Exit Select
            Case 18
                AddHandler OBJ_BACKGROUNDWORKER_18.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_18
                Exit Select
            Case 19
                AddHandler OBJ_BACKGROUNDWORKER_19.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_19
                Exit Select
            Case 20
                AddHandler OBJ_BACKGROUNDWORKER_20.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_20
                Exit Select
            Case 21
                AddHandler OBJ_BACKGROUNDWORKER_21.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_21
                Exit Select
            Case 22
                AddHandler OBJ_BACKGROUNDWORKER_22.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_22
                Exit Select
            Case 23
                AddHandler OBJ_BACKGROUNDWORKER_23.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_23
                Exit Select
            Case 24
                AddHandler OBJ_BACKGROUNDWORKER_24.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_24
                Exit Select
            Case 25
                AddHandler OBJ_BACKGROUNDWORKER_25.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_25
                Exit Select
            Case 26
                AddHandler OBJ_BACKGROUNDWORKER_26.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_26
                Exit Select
            Case 27
                AddHandler OBJ_BACKGROUNDWORKER_27.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_27
                Exit Select
            Case 28
                AddHandler OBJ_BACKGROUNDWORKER_28.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_28
                Exit Select
            Case 29
                AddHandler OBJ_BACKGROUNDWORKER_29.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_29
                Exit Select
            Case 30
                AddHandler OBJ_BACKGROUNDWORKER_30.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_30
                Exit Select
            Case 31
                AddHandler OBJ_BACKGROUNDWORKER_31.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_31
                Exit Select
            Case 32
                AddHandler OBJ_BACKGROUNDWORKER_32.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_32
                Exit Select
            Case 33
                AddHandler OBJ_BACKGROUNDWORKER_33.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_33
                Exit Select
            Case 34
                AddHandler OBJ_BACKGROUNDWORKER_34.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_34
                Exit Select
            Case 35
                AddHandler OBJ_BACKGROUNDWORKER_35.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_35
                Exit Select
            Case 36
                AddHandler OBJ_BACKGROUNDWORKER_36.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_36
                Exit Select
            Case 37
                AddHandler OBJ_BACKGROUNDWORKER_37.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_37
                Exit Select
            Case 38
                AddHandler OBJ_BACKGROUNDWORKER_38.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_38
                Exit Select
            Case 39
                AddHandler OBJ_BACKGROUNDWORKER_39.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_39
                Exit Select
            Case 40
                AddHandler OBJ_BACKGROUNDWORKER_40.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_40
                Exit Select
            Case 41
                AddHandler OBJ_BACKGROUNDWORKER_41.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_41
                Exit Select
            Case 42
                AddHandler OBJ_BACKGROUNDWORKER_42.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_42
                Exit Select
            Case 43
                AddHandler OBJ_BACKGROUNDWORKER_43.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_43
                Exit Select
            Case 44
                AddHandler OBJ_BACKGROUNDWORKER_44.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_44
                Exit Select
            Case 45
                AddHandler OBJ_BACKGROUNDWORKER_45.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_45
                Exit Select
            Case 46
                AddHandler OBJ_BACKGROUNDWORKER_46.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_46
                Exit Select
            Case 47
                AddHandler OBJ_BACKGROUNDWORKER_47.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_47
                Exit Select
            Case 48
                AddHandler OBJ_BACKGROUNDWORKER_48.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_48
                Exit Select
            Case 49
                AddHandler OBJ_BACKGROUNDWORKER_49.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_49
                Exit Select
            Case 50
                AddHandler OBJ_BACKGROUNDWORKER_50.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_50
                Exit Select
            Case 51
                AddHandler OBJ_BACKGROUNDWORKER_51.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_51
                Exit Select
            Case 52
                AddHandler OBJ_BACKGROUNDWORKER_52.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_52
                Exit Select
            Case 53
                AddHandler OBJ_BACKGROUNDWORKER_53.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_53
                Exit Select
            Case 54
                AddHandler OBJ_BACKGROUNDWORKER_54.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_54
                Exit Select
            Case 55
                AddHandler OBJ_BACKGROUNDWORKER_55.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_55
                Exit Select
            Case 56
                AddHandler OBJ_BACKGROUNDWORKER_56.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_56
                Exit Select
            Case 57
                AddHandler OBJ_BACKGROUNDWORKER_57.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_57
                Exit Select
            Case 58
                AddHandler OBJ_BACKGROUNDWORKER_58.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_58
                Exit Select
            Case 59
                AddHandler OBJ_BACKGROUNDWORKER_59.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_59
                Exit Select
            Case 60
                AddHandler OBJ_BACKGROUNDWORKER_60.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_60
                Exit Select
            Case 61
                AddHandler OBJ_BACKGROUNDWORKER_61.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_61
                Exit Select
            Case 62
                AddHandler OBJ_BACKGROUNDWORKER_62.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_62
                Exit Select
            Case 63
                AddHandler OBJ_BACKGROUNDWORKER_63.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_63
                Exit Select
            Case 64
                AddHandler OBJ_BACKGROUNDWORKER_64.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_64
                Exit Select
            Case 65
                AddHandler OBJ_BACKGROUNDWORKER_65.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_65
                Exit Select
            Case 66
                AddHandler OBJ_BACKGROUNDWORKER_66.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_66
                Exit Select
            Case 67
                AddHandler OBJ_BACKGROUNDWORKER_67.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_67
                Exit Select
            Case 68
                AddHandler OBJ_BACKGROUNDWORKER_68.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_68
                Exit Select
            Case 69
                AddHandler OBJ_BACKGROUNDWORKER_69.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_69
                Exit Select
            Case 70
                AddHandler OBJ_BACKGROUNDWORKER_70.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_70
                Exit Select
            Case 71
                AddHandler OBJ_BACKGROUNDWORKER_71.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_71
                Exit Select
            Case 72
                AddHandler OBJ_BACKGROUNDWORKER_72.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_72
                Exit Select
            Case 73
                AddHandler OBJ_BACKGROUNDWORKER_73.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_73
                Exit Select
            Case 74
                AddHandler OBJ_BACKGROUNDWORKER_74.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_74
                Exit Select
            Case 75
                AddHandler OBJ_BACKGROUNDWORKER_75.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_75
                Exit Select
            Case 76
                AddHandler OBJ_BACKGROUNDWORKER_76.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_76
                Exit Select
            Case 77
                AddHandler OBJ_BACKGROUNDWORKER_77.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_77
                Exit Select
            Case 78
                AddHandler OBJ_BACKGROUNDWORKER_78.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_78
                Exit Select
            Case 79
                AddHandler OBJ_BACKGROUNDWORKER_79.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_79
                Exit Select
            Case 80
                AddHandler OBJ_BACKGROUNDWORKER_80.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_80
                Exit Select
            Case 81
                AddHandler OBJ_BACKGROUNDWORKER_81.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_81
                Exit Select
            Case 82
                AddHandler OBJ_BACKGROUNDWORKER_82.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_82
                Exit Select
            Case 83
                AddHandler OBJ_BACKGROUNDWORKER_83.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_83
                Exit Select
            Case 84
                AddHandler OBJ_BACKGROUNDWORKER_84.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_84
                Exit Select
            Case 85
                AddHandler OBJ_BACKGROUNDWORKER_85.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_85
                Exit Select
            Case 86
                AddHandler OBJ_BACKGROUNDWORKER_86.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_86
                Exit Select
            Case 87
                AddHandler OBJ_BACKGROUNDWORKER_87.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_87
                Exit Select
            Case 88
                AddHandler OBJ_BACKGROUNDWORKER_88.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_88
                Exit Select
            Case 89
                AddHandler OBJ_BACKGROUNDWORKER_89.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_89
                Exit Select
            Case 90
                AddHandler OBJ_BACKGROUNDWORKER_90.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_90
                Exit Select
            Case 91
                AddHandler OBJ_BACKGROUNDWORKER_91.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_91
                Exit Select
            Case 92
                AddHandler OBJ_BACKGROUNDWORKER_92.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_92
                Exit Select
            Case 93
                AddHandler OBJ_BACKGROUNDWORKER_93.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_93
                Exit Select
            Case 94
                AddHandler OBJ_BACKGROUNDWORKER_94.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_94
                Exit Select
            Case 95
                AddHandler OBJ_BACKGROUNDWORKER_95.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_95
                Exit Select
            Case 96
                AddHandler OBJ_BACKGROUNDWORKER_96.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_96
                Exit Select
            Case 97
                AddHandler OBJ_BACKGROUNDWORKER_97.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_97
                Exit Select
            Case 98
                AddHandler OBJ_BACKGROUNDWORKER_98.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_98
                Exit Select
            Case 99
                AddHandler OBJ_BACKGROUNDWORKER_99.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_99
                Exit Select
            Case 100
                AddHandler OBJ_BACKGROUNDWORKER_100.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_100
                Exit Select
            Case 101
                AddHandler OBJ_BACKGROUNDWORKER_101.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_101
                Exit Select
            Case 102
                AddHandler OBJ_BACKGROUNDWORKER_102.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_102
                Exit Select
            Case 103
                AddHandler OBJ_BACKGROUNDWORKER_103.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_103
                Exit Select
            Case 104
                AddHandler OBJ_BACKGROUNDWORKER_104.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_104
                Exit Select
            Case 105
                AddHandler OBJ_BACKGROUNDWORKER_105.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_105
                Exit Select
            Case 106
                AddHandler OBJ_BACKGROUNDWORKER_106.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_106
                Exit Select
            Case 107
                AddHandler OBJ_BACKGROUNDWORKER_107.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_107
                Exit Select
            Case 108
                AddHandler OBJ_BACKGROUNDWORKER_108.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_108
                Exit Select
            Case 109
                AddHandler OBJ_BACKGROUNDWORKER_109.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_109
                Exit Select
            Case 110
                AddHandler OBJ_BACKGROUNDWORKER_110.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_110
                Exit Select
            Case 111
                AddHandler OBJ_BACKGROUNDWORKER_111.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_111
                Exit Select
            Case 112
                AddHandler OBJ_BACKGROUNDWORKER_112.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_112
                Exit Select
            Case 113
                AddHandler OBJ_BACKGROUNDWORKER_113.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_113
                Exit Select
            Case 114
                AddHandler OBJ_BACKGROUNDWORKER_114.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_114
                Exit Select
            Case 115
                AddHandler OBJ_BACKGROUNDWORKER_115.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_115
                Exit Select
            Case 116
                AddHandler OBJ_BACKGROUNDWORKER_116.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_116
                Exit Select
            Case 117
                AddHandler OBJ_BACKGROUNDWORKER_117.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_117
                Exit Select
            Case 118
                AddHandler OBJ_BACKGROUNDWORKER_118.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_118
                Exit Select
            Case 119
                AddHandler OBJ_BACKGROUNDWORKER_119.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_119
                Exit Select
            Case 120
                AddHandler OBJ_BACKGROUNDWORKER_120.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_120
                Exit Select
            Case 121
                AddHandler OBJ_BACKGROUNDWORKER_121.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_121
                Exit Select
            Case 122
                AddHandler OBJ_BACKGROUNDWORKER_122.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_122
                Exit Select
            Case 123
                AddHandler OBJ_BACKGROUNDWORKER_123.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_123
                Exit Select
            Case 124
                AddHandler OBJ_BACKGROUNDWORKER_124.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_124
                Exit Select
            Case 125
                AddHandler OBJ_BACKGROUNDWORKER_125.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_125
                Exit Select
            Case 126
                AddHandler OBJ_BACKGROUNDWORKER_126.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_126
                Exit Select
            Case 127
                AddHandler OBJ_BACKGROUNDWORKER_127.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_127
                Exit Select
            Case 128
                AddHandler OBJ_BACKGROUNDWORKER_128.DoWork, AddressOf OBJ_BACKGROUNDWORKER_TRABALHAR_128
                Exit Select
            



        End Select


    End Sub

    Private Sub proc_ligar_evento_backgroundworkers_virtuais_completado() 'Liga os eventos dos backgroundworkers virtuais evento completado
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso


            Case 1
                AddHandler OBJ_BACKGROUNDWORKER_1.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_1
                Exit Select
            Case 2
                AddHandler OBJ_BACKGROUNDWORKER_2.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_2
                Exit Select
            Case 3
                AddHandler OBJ_BACKGROUNDWORKER_3.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_3
                Exit Select
            Case 4
                AddHandler OBJ_BACKGROUNDWORKER_4.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_4
                Exit Select
            Case 5
                AddHandler OBJ_BACKGROUNDWORKER_5.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_5
                Exit Select
            Case 6
                AddHandler OBJ_BACKGROUNDWORKER_6.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_6
                Exit Select
            Case 7
                AddHandler OBJ_BACKGROUNDWORKER_7.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_7
                Exit Select
            Case 8
                AddHandler OBJ_BACKGROUNDWORKER_8.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_8
                Exit Select
            Case 9
                AddHandler OBJ_BACKGROUNDWORKER_9.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_9
                Exit Select
            Case 10
                AddHandler OBJ_BACKGROUNDWORKER_10.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_10
                Exit Select
            Case 11
                AddHandler OBJ_BACKGROUNDWORKER_11.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_11
                Exit Select
            Case 12
                AddHandler OBJ_BACKGROUNDWORKER_12.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_12
                Exit Select
            Case 13
                AddHandler OBJ_BACKGROUNDWORKER_13.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_13
                Exit Select
            Case 14
                AddHandler OBJ_BACKGROUNDWORKER_14.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_14
                Exit Select
            Case 15
                AddHandler OBJ_BACKGROUNDWORKER_15.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_15
                Exit Select
            Case 16
                AddHandler OBJ_BACKGROUNDWORKER_16.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_16
                Exit Select
            Case 17
                AddHandler OBJ_BACKGROUNDWORKER_17.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_17
                Exit Select
            Case 18
                AddHandler OBJ_BACKGROUNDWORKER_18.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_18
                Exit Select
            Case 19
                AddHandler OBJ_BACKGROUNDWORKER_19.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_19
                Exit Select
            Case 20
                AddHandler OBJ_BACKGROUNDWORKER_20.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_20
                Exit Select
            Case 21
                AddHandler OBJ_BACKGROUNDWORKER_21.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_21
                Exit Select
            Case 22
                AddHandler OBJ_BACKGROUNDWORKER_22.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_22
                Exit Select
            Case 23
                AddHandler OBJ_BACKGROUNDWORKER_23.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_23
                Exit Select
            Case 24
                AddHandler OBJ_BACKGROUNDWORKER_24.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_24
                Exit Select
            Case 25
                AddHandler OBJ_BACKGROUNDWORKER_25.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_25
                Exit Select
            Case 26
                AddHandler OBJ_BACKGROUNDWORKER_26.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_26
                Exit Select
            Case 27
                AddHandler OBJ_BACKGROUNDWORKER_27.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_27
                Exit Select
            Case 28
                AddHandler OBJ_BACKGROUNDWORKER_28.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_28
                Exit Select
            Case 29
                AddHandler OBJ_BACKGROUNDWORKER_29.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_29
                Exit Select
            Case 30
                AddHandler OBJ_BACKGROUNDWORKER_30.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_30
                Exit Select
            Case 31
                AddHandler OBJ_BACKGROUNDWORKER_31.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_31
                Exit Select
            Case 32
                AddHandler OBJ_BACKGROUNDWORKER_32.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_32
                Exit Select
            Case 33
                AddHandler OBJ_BACKGROUNDWORKER_33.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_33
                Exit Select
            Case 34
                AddHandler OBJ_BACKGROUNDWORKER_34.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_34
                Exit Select
            Case 35
                AddHandler OBJ_BACKGROUNDWORKER_35.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_35
                Exit Select
            Case 36
                AddHandler OBJ_BACKGROUNDWORKER_36.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_36
                Exit Select
            Case 37
                AddHandler OBJ_BACKGROUNDWORKER_37.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_37
                Exit Select
            Case 38
                AddHandler OBJ_BACKGROUNDWORKER_38.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_38
                Exit Select
            Case 39
                AddHandler OBJ_BACKGROUNDWORKER_39.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_39
                Exit Select
            Case 40
                AddHandler OBJ_BACKGROUNDWORKER_40.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_40
                Exit Select
            Case 41
                AddHandler OBJ_BACKGROUNDWORKER_41.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_41
                Exit Select
            Case 42
                AddHandler OBJ_BACKGROUNDWORKER_42.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_42
                Exit Select
            Case 43
                AddHandler OBJ_BACKGROUNDWORKER_43.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_43
                Exit Select
            Case 44
                AddHandler OBJ_BACKGROUNDWORKER_44.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_44
                Exit Select
            Case 45
                AddHandler OBJ_BACKGROUNDWORKER_45.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_45
                Exit Select
            Case 46
                AddHandler OBJ_BACKGROUNDWORKER_46.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_46
                Exit Select
            Case 47
                AddHandler OBJ_BACKGROUNDWORKER_47.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_47
                Exit Select
            Case 48
                AddHandler OBJ_BACKGROUNDWORKER_48.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_48
                Exit Select
            Case 49
                AddHandler OBJ_BACKGROUNDWORKER_49.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_49
                Exit Select
            Case 50
                AddHandler OBJ_BACKGROUNDWORKER_50.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_50
                Exit Select
            Case 51
                AddHandler OBJ_BACKGROUNDWORKER_51.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_51
                Exit Select
            Case 52
                AddHandler OBJ_BACKGROUNDWORKER_52.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_52
                Exit Select
            Case 53
                AddHandler OBJ_BACKGROUNDWORKER_53.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_53
                Exit Select
            Case 54
                AddHandler OBJ_BACKGROUNDWORKER_54.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_54
                Exit Select
            Case 55
                AddHandler OBJ_BACKGROUNDWORKER_55.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_55
                Exit Select
            Case 56
                AddHandler OBJ_BACKGROUNDWORKER_56.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_56
                Exit Select
            Case 57
                AddHandler OBJ_BACKGROUNDWORKER_57.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_57
                Exit Select
            Case 58
                AddHandler OBJ_BACKGROUNDWORKER_58.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_58
                Exit Select
            Case 59
                AddHandler OBJ_BACKGROUNDWORKER_59.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_59
                Exit Select
            Case 60
                AddHandler OBJ_BACKGROUNDWORKER_60.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_60
                Exit Select
            Case 61
                AddHandler OBJ_BACKGROUNDWORKER_61.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_61
                Exit Select
            Case 62
                AddHandler OBJ_BACKGROUNDWORKER_62.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_62
                Exit Select
            Case 63
                AddHandler OBJ_BACKGROUNDWORKER_63.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_63
                Exit Select
            Case 64
                AddHandler OBJ_BACKGROUNDWORKER_64.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_64
                Exit Select
            Case 65
                AddHandler OBJ_BACKGROUNDWORKER_65.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_65
                Exit Select
            Case 66
                AddHandler OBJ_BACKGROUNDWORKER_66.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_66
                Exit Select
            Case 67
                AddHandler OBJ_BACKGROUNDWORKER_67.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_67
                Exit Select
            Case 68
                AddHandler OBJ_BACKGROUNDWORKER_68.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_68
                Exit Select
            Case 69
                AddHandler OBJ_BACKGROUNDWORKER_69.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_69
                Exit Select
            Case 70
                AddHandler OBJ_BACKGROUNDWORKER_70.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_70
                Exit Select
            Case 71
                AddHandler OBJ_BACKGROUNDWORKER_71.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_71
                Exit Select
            Case 72
                AddHandler OBJ_BACKGROUNDWORKER_72.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_72
                Exit Select
            Case 73
                AddHandler OBJ_BACKGROUNDWORKER_73.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_73
                Exit Select
            Case 74
                AddHandler OBJ_BACKGROUNDWORKER_74.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_74
                Exit Select
            Case 75
                AddHandler OBJ_BACKGROUNDWORKER_75.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_75
                Exit Select
            Case 76
                AddHandler OBJ_BACKGROUNDWORKER_76.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_76
                Exit Select
            Case 77
                AddHandler OBJ_BACKGROUNDWORKER_77.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_77
                Exit Select
            Case 78
                AddHandler OBJ_BACKGROUNDWORKER_78.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_78
                Exit Select
            Case 79
                AddHandler OBJ_BACKGROUNDWORKER_79.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_79
                Exit Select
            Case 80
                AddHandler OBJ_BACKGROUNDWORKER_80.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_80
                Exit Select
            Case 81
                AddHandler OBJ_BACKGROUNDWORKER_81.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_81
                Exit Select
            Case 82
                AddHandler OBJ_BACKGROUNDWORKER_82.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_82
                Exit Select
            Case 83
                AddHandler OBJ_BACKGROUNDWORKER_83.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_83
                Exit Select
            Case 84
                AddHandler OBJ_BACKGROUNDWORKER_84.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_84
                Exit Select
            Case 85
                AddHandler OBJ_BACKGROUNDWORKER_85.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_85
                Exit Select
            Case 86
                AddHandler OBJ_BACKGROUNDWORKER_86.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_86
                Exit Select
            Case 87
                AddHandler OBJ_BACKGROUNDWORKER_87.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_87
                Exit Select
            Case 88
                AddHandler OBJ_BACKGROUNDWORKER_88.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_88
                Exit Select
            Case 89
                AddHandler OBJ_BACKGROUNDWORKER_89.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_89
                Exit Select
            Case 90
                AddHandler OBJ_BACKGROUNDWORKER_90.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_90
                Exit Select
            Case 91
                AddHandler OBJ_BACKGROUNDWORKER_91.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_91
                Exit Select
            Case 92
                AddHandler OBJ_BACKGROUNDWORKER_92.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_92
                Exit Select
            Case 93
                AddHandler OBJ_BACKGROUNDWORKER_93.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_93
                Exit Select
            Case 94
                AddHandler OBJ_BACKGROUNDWORKER_94.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_94
                Exit Select
            Case 95
                AddHandler OBJ_BACKGROUNDWORKER_95.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_95
                Exit Select
            Case 96
                AddHandler OBJ_BACKGROUNDWORKER_96.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_96
                Exit Select
            Case 97
                AddHandler OBJ_BACKGROUNDWORKER_97.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_97
                Exit Select
            Case 98
                AddHandler OBJ_BACKGROUNDWORKER_98.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_98
                Exit Select
            Case 99
                AddHandler OBJ_BACKGROUNDWORKER_99.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_99
                Exit Select
            Case 100
                AddHandler OBJ_BACKGROUNDWORKER_100.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_100
                Exit Select
            Case 101
                AddHandler OBJ_BACKGROUNDWORKER_101.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_101
                Exit Select
            Case 102
                AddHandler OBJ_BACKGROUNDWORKER_102.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_102
                Exit Select
            Case 103
                AddHandler OBJ_BACKGROUNDWORKER_103.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_103
                Exit Select
            Case 104
                AddHandler OBJ_BACKGROUNDWORKER_104.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_104
                Exit Select
            Case 105
                AddHandler OBJ_BACKGROUNDWORKER_105.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_105
                Exit Select
            Case 106
                AddHandler OBJ_BACKGROUNDWORKER_106.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_106
                Exit Select
            Case 107
                AddHandler OBJ_BACKGROUNDWORKER_107.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_107
                Exit Select
            Case 108
                AddHandler OBJ_BACKGROUNDWORKER_108.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_108
                Exit Select
            Case 109
                AddHandler OBJ_BACKGROUNDWORKER_109.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_109
                Exit Select
            Case 110
                AddHandler OBJ_BACKGROUNDWORKER_110.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_110
                Exit Select
            Case 111
                AddHandler OBJ_BACKGROUNDWORKER_111.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_111
                Exit Select
            Case 112
                AddHandler OBJ_BACKGROUNDWORKER_112.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_112
                Exit Select
            Case 113
                AddHandler OBJ_BACKGROUNDWORKER_113.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_113
                Exit Select
            Case 114
                AddHandler OBJ_BACKGROUNDWORKER_114.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_114
                Exit Select
            Case 115
                AddHandler OBJ_BACKGROUNDWORKER_115.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_115
                Exit Select
            Case 116
                AddHandler OBJ_BACKGROUNDWORKER_116.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_116
                Exit Select
            Case 117
                AddHandler OBJ_BACKGROUNDWORKER_117.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_117
                Exit Select
            Case 118
                AddHandler OBJ_BACKGROUNDWORKER_118.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_118
                Exit Select
            Case 119
                AddHandler OBJ_BACKGROUNDWORKER_119.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_119
                Exit Select
            Case 120
                AddHandler OBJ_BACKGROUNDWORKER_120.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_120
                Exit Select
            Case 121
                AddHandler OBJ_BACKGROUNDWORKER_121.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_121
                Exit Select
            Case 122
                AddHandler OBJ_BACKGROUNDWORKER_122.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_122
                Exit Select
            Case 123
                AddHandler OBJ_BACKGROUNDWORKER_123.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_123
                Exit Select
            Case 124
                AddHandler OBJ_BACKGROUNDWORKER_124.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_124
                Exit Select
            Case 125
                AddHandler OBJ_BACKGROUNDWORKER_125.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_125
                Exit Select
            Case 126
                AddHandler OBJ_BACKGROUNDWORKER_126.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_126
                Exit Select
            Case 127
                AddHandler OBJ_BACKGROUNDWORKER_127.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_127
                Exit Select
            Case 128
                AddHandler OBJ_BACKGROUNDWORKER_128.RunWorkerCompleted, AddressOf OBJ_BACKGROUNDWORKER_COMPLETO_128
                Exit Select
            



        End Select


    End Sub








    'Evento navigating dos motores

    Private Sub proc_ligar_evento_navigating_de_pagina_geckofx() 'Liga o evento de navigating geckofx
        On Error Resume Next


        Select Case v_qual_motor_esta_em_uso


            Case 1
                AddHandler OBJ_MOTOR_GECKOFX_1.Navigating, AddressOf proc_navigating_geckofx_motor_1
                Exit Select
            Case 2
                AddHandler OBJ_MOTOR_GECKOFX_2.Navigating, AddressOf proc_navigating_geckofx_motor_2
                Exit Select
            Case 3
                AddHandler OBJ_MOTOR_GECKOFX_3.Navigating, AddressOf proc_navigating_geckofx_motor_3
                Exit Select
            Case 4
                AddHandler OBJ_MOTOR_GECKOFX_4.Navigating, AddressOf proc_navigating_geckofx_motor_4
                Exit Select
            Case 5
                AddHandler OBJ_MOTOR_GECKOFX_5.Navigating, AddressOf proc_navigating_geckofx_motor_5
                Exit Select
            Case 6
                AddHandler OBJ_MOTOR_GECKOFX_6.Navigating, AddressOf proc_navigating_geckofx_motor_6
                Exit Select
            Case 7
                AddHandler OBJ_MOTOR_GECKOFX_7.Navigating, AddressOf proc_navigating_geckofx_motor_7
                Exit Select
            Case 8
                AddHandler OBJ_MOTOR_GECKOFX_8.Navigating, AddressOf proc_navigating_geckofx_motor_8
                Exit Select
            Case 9
                AddHandler OBJ_MOTOR_GECKOFX_9.Navigating, AddressOf proc_navigating_geckofx_motor_9
                Exit Select
            Case 10
                AddHandler OBJ_MOTOR_GECKOFX_10.Navigating, AddressOf proc_navigating_geckofx_motor_10
                Exit Select
            Case 11
                AddHandler OBJ_MOTOR_GECKOFX_11.Navigating, AddressOf proc_navigating_geckofx_motor_11
                Exit Select
            Case 12
                AddHandler OBJ_MOTOR_GECKOFX_12.Navigating, AddressOf proc_navigating_geckofx_motor_12
                Exit Select
            Case 13
                AddHandler OBJ_MOTOR_GECKOFX_13.Navigating, AddressOf proc_navigating_geckofx_motor_13
                Exit Select
            Case 14
                AddHandler OBJ_MOTOR_GECKOFX_14.Navigating, AddressOf proc_navigating_geckofx_motor_14
                Exit Select
            Case 15
                AddHandler OBJ_MOTOR_GECKOFX_15.Navigating, AddressOf proc_navigating_geckofx_motor_15
                Exit Select
            Case 16
                AddHandler OBJ_MOTOR_GECKOFX_16.Navigating, AddressOf proc_navigating_geckofx_motor_16
                Exit Select
            Case 17
                AddHandler OBJ_MOTOR_GECKOFX_17.Navigating, AddressOf proc_navigating_geckofx_motor_17
                Exit Select
            Case 18
                AddHandler OBJ_MOTOR_GECKOFX_18.Navigating, AddressOf proc_navigating_geckofx_motor_18
                Exit Select
            Case 19
                AddHandler OBJ_MOTOR_GECKOFX_19.Navigating, AddressOf proc_navigating_geckofx_motor_19
                Exit Select
            Case 20
                AddHandler OBJ_MOTOR_GECKOFX_20.Navigating, AddressOf proc_navigating_geckofx_motor_20
                Exit Select
            Case 21
                AddHandler OBJ_MOTOR_GECKOFX_21.Navigating, AddressOf proc_navigating_geckofx_motor_21
                Exit Select
            Case 22
                AddHandler OBJ_MOTOR_GECKOFX_22.Navigating, AddressOf proc_navigating_geckofx_motor_22
                Exit Select
            Case 23
                AddHandler OBJ_MOTOR_GECKOFX_23.Navigating, AddressOf proc_navigating_geckofx_motor_23
                Exit Select
            Case 24
                AddHandler OBJ_MOTOR_GECKOFX_24.Navigating, AddressOf proc_navigating_geckofx_motor_24
                Exit Select
            Case 25
                AddHandler OBJ_MOTOR_GECKOFX_25.Navigating, AddressOf proc_navigating_geckofx_motor_25
                Exit Select
            Case 26
                AddHandler OBJ_MOTOR_GECKOFX_26.Navigating, AddressOf proc_navigating_geckofx_motor_26
                Exit Select
            Case 27
                AddHandler OBJ_MOTOR_GECKOFX_27.Navigating, AddressOf proc_navigating_geckofx_motor_27
                Exit Select
            Case 28
                AddHandler OBJ_MOTOR_GECKOFX_28.Navigating, AddressOf proc_navigating_geckofx_motor_28
                Exit Select
            Case 29
                AddHandler OBJ_MOTOR_GECKOFX_29.Navigating, AddressOf proc_navigating_geckofx_motor_29
                Exit Select
            Case 30
                AddHandler OBJ_MOTOR_GECKOFX_30.Navigating, AddressOf proc_navigating_geckofx_motor_30
                Exit Select
            Case 31
                AddHandler OBJ_MOTOR_GECKOFX_31.Navigating, AddressOf proc_navigating_geckofx_motor_31
                Exit Select
            Case 32
                AddHandler OBJ_MOTOR_GECKOFX_32.Navigating, AddressOf proc_navigating_geckofx_motor_32
                Exit Select
            Case 33
                AddHandler OBJ_MOTOR_GECKOFX_33.Navigating, AddressOf proc_navigating_geckofx_motor_33
                Exit Select
            Case 34
                AddHandler OBJ_MOTOR_GECKOFX_34.Navigating, AddressOf proc_navigating_geckofx_motor_34
                Exit Select
            Case 35
                AddHandler OBJ_MOTOR_GECKOFX_35.Navigating, AddressOf proc_navigating_geckofx_motor_35
                Exit Select
            Case 36
                AddHandler OBJ_MOTOR_GECKOFX_36.Navigating, AddressOf proc_navigating_geckofx_motor_36
                Exit Select
            Case 37
                AddHandler OBJ_MOTOR_GECKOFX_37.Navigating, AddressOf proc_navigating_geckofx_motor_37
                Exit Select
            Case 38
                AddHandler OBJ_MOTOR_GECKOFX_38.Navigating, AddressOf proc_navigating_geckofx_motor_38
                Exit Select
            Case 39
                AddHandler OBJ_MOTOR_GECKOFX_39.Navigating, AddressOf proc_navigating_geckofx_motor_39
                Exit Select
            Case 40
                AddHandler OBJ_MOTOR_GECKOFX_40.Navigating, AddressOf proc_navigating_geckofx_motor_40
                Exit Select
            Case 41
                AddHandler OBJ_MOTOR_GECKOFX_41.Navigating, AddressOf proc_navigating_geckofx_motor_41
                Exit Select
            Case 42
                AddHandler OBJ_MOTOR_GECKOFX_42.Navigating, AddressOf proc_navigating_geckofx_motor_42
                Exit Select
            Case 43
                AddHandler OBJ_MOTOR_GECKOFX_43.Navigating, AddressOf proc_navigating_geckofx_motor_43
                Exit Select
            Case 44
                AddHandler OBJ_MOTOR_GECKOFX_44.Navigating, AddressOf proc_navigating_geckofx_motor_44
                Exit Select
            Case 45
                AddHandler OBJ_MOTOR_GECKOFX_45.Navigating, AddressOf proc_navigating_geckofx_motor_45
                Exit Select
            Case 46
                AddHandler OBJ_MOTOR_GECKOFX_46.Navigating, AddressOf proc_navigating_geckofx_motor_46
                Exit Select
            Case 47
                AddHandler OBJ_MOTOR_GECKOFX_47.Navigating, AddressOf proc_navigating_geckofx_motor_47
                Exit Select
            Case 48
                AddHandler OBJ_MOTOR_GECKOFX_48.Navigating, AddressOf proc_navigating_geckofx_motor_48
                Exit Select
            Case 49
                AddHandler OBJ_MOTOR_GECKOFX_49.Navigating, AddressOf proc_navigating_geckofx_motor_49
                Exit Select
            Case 50
                AddHandler OBJ_MOTOR_GECKOFX_50.Navigating, AddressOf proc_navigating_geckofx_motor_50
                Exit Select
            Case 51
                AddHandler OBJ_MOTOR_GECKOFX_51.Navigating, AddressOf proc_navigating_geckofx_motor_51
                Exit Select
            Case 52
                AddHandler OBJ_MOTOR_GECKOFX_52.Navigating, AddressOf proc_navigating_geckofx_motor_52
                Exit Select
            Case 53
                AddHandler OBJ_MOTOR_GECKOFX_53.Navigating, AddressOf proc_navigating_geckofx_motor_53
                Exit Select
            Case 54
                AddHandler OBJ_MOTOR_GECKOFX_54.Navigating, AddressOf proc_navigating_geckofx_motor_54
                Exit Select
            Case 55
                AddHandler OBJ_MOTOR_GECKOFX_55.Navigating, AddressOf proc_navigating_geckofx_motor_55
                Exit Select
            Case 56
                AddHandler OBJ_MOTOR_GECKOFX_56.Navigating, AddressOf proc_navigating_geckofx_motor_56
                Exit Select
            Case 57
                AddHandler OBJ_MOTOR_GECKOFX_57.Navigating, AddressOf proc_navigating_geckofx_motor_57
                Exit Select
            Case 58
                AddHandler OBJ_MOTOR_GECKOFX_58.Navigating, AddressOf proc_navigating_geckofx_motor_58
                Exit Select
            Case 59
                AddHandler OBJ_MOTOR_GECKOFX_59.Navigating, AddressOf proc_navigating_geckofx_motor_59
                Exit Select
            Case 60
                AddHandler OBJ_MOTOR_GECKOFX_60.Navigating, AddressOf proc_navigating_geckofx_motor_60
                Exit Select
            Case 61
                AddHandler OBJ_MOTOR_GECKOFX_61.Navigating, AddressOf proc_navigating_geckofx_motor_61
                Exit Select
            Case 62
                AddHandler OBJ_MOTOR_GECKOFX_62.Navigating, AddressOf proc_navigating_geckofx_motor_62
                Exit Select
            Case 63
                AddHandler OBJ_MOTOR_GECKOFX_63.Navigating, AddressOf proc_navigating_geckofx_motor_63
                Exit Select
            Case 64
                AddHandler OBJ_MOTOR_GECKOFX_64.Navigating, AddressOf proc_navigating_geckofx_motor_64
                Exit Select
            Case 65
                AddHandler OBJ_MOTOR_GECKOFX_65.Navigating, AddressOf proc_navigating_geckofx_motor_65
                Exit Select
            Case 66
                AddHandler OBJ_MOTOR_GECKOFX_66.Navigating, AddressOf proc_navigating_geckofx_motor_66
                Exit Select
            Case 67
                AddHandler OBJ_MOTOR_GECKOFX_67.Navigating, AddressOf proc_navigating_geckofx_motor_67
                Exit Select
            Case 68
                AddHandler OBJ_MOTOR_GECKOFX_68.Navigating, AddressOf proc_navigating_geckofx_motor_68
                Exit Select
            Case 69
                AddHandler OBJ_MOTOR_GECKOFX_69.Navigating, AddressOf proc_navigating_geckofx_motor_69
                Exit Select
            Case 70
                AddHandler OBJ_MOTOR_GECKOFX_70.Navigating, AddressOf proc_navigating_geckofx_motor_70
                Exit Select
            Case 71
                AddHandler OBJ_MOTOR_GECKOFX_71.Navigating, AddressOf proc_navigating_geckofx_motor_71
                Exit Select
            Case 72
                AddHandler OBJ_MOTOR_GECKOFX_72.Navigating, AddressOf proc_navigating_geckofx_motor_72
                Exit Select
            Case 73
                AddHandler OBJ_MOTOR_GECKOFX_73.Navigating, AddressOf proc_navigating_geckofx_motor_73
                Exit Select
            Case 74
                AddHandler OBJ_MOTOR_GECKOFX_74.Navigating, AddressOf proc_navigating_geckofx_motor_74
                Exit Select
            Case 75
                AddHandler OBJ_MOTOR_GECKOFX_75.Navigating, AddressOf proc_navigating_geckofx_motor_75
                Exit Select
            Case 76
                AddHandler OBJ_MOTOR_GECKOFX_76.Navigating, AddressOf proc_navigating_geckofx_motor_76
                Exit Select
            Case 77
                AddHandler OBJ_MOTOR_GECKOFX_77.Navigating, AddressOf proc_navigating_geckofx_motor_77
                Exit Select
            Case 78
                AddHandler OBJ_MOTOR_GECKOFX_78.Navigating, AddressOf proc_navigating_geckofx_motor_78
                Exit Select
            Case 79
                AddHandler OBJ_MOTOR_GECKOFX_79.Navigating, AddressOf proc_navigating_geckofx_motor_79
                Exit Select
            Case 80
                AddHandler OBJ_MOTOR_GECKOFX_80.Navigating, AddressOf proc_navigating_geckofx_motor_80
                Exit Select
            Case 81
                AddHandler OBJ_MOTOR_GECKOFX_81.Navigating, AddressOf proc_navigating_geckofx_motor_81
                Exit Select
            Case 82
                AddHandler OBJ_MOTOR_GECKOFX_82.Navigating, AddressOf proc_navigating_geckofx_motor_82
                Exit Select
            Case 83
                AddHandler OBJ_MOTOR_GECKOFX_83.Navigating, AddressOf proc_navigating_geckofx_motor_83
                Exit Select
            Case 84
                AddHandler OBJ_MOTOR_GECKOFX_84.Navigating, AddressOf proc_navigating_geckofx_motor_84
                Exit Select
            Case 85
                AddHandler OBJ_MOTOR_GECKOFX_85.Navigating, AddressOf proc_navigating_geckofx_motor_85
                Exit Select
            Case 86
                AddHandler OBJ_MOTOR_GECKOFX_86.Navigating, AddressOf proc_navigating_geckofx_motor_86
                Exit Select
            Case 87
                AddHandler OBJ_MOTOR_GECKOFX_87.Navigating, AddressOf proc_navigating_geckofx_motor_87
                Exit Select
            Case 88
                AddHandler OBJ_MOTOR_GECKOFX_88.Navigating, AddressOf proc_navigating_geckofx_motor_88
                Exit Select
            Case 89
                AddHandler OBJ_MOTOR_GECKOFX_89.Navigating, AddressOf proc_navigating_geckofx_motor_89
                Exit Select
            Case 90
                AddHandler OBJ_MOTOR_GECKOFX_90.Navigating, AddressOf proc_navigating_geckofx_motor_90
                Exit Select
            Case 91
                AddHandler OBJ_MOTOR_GECKOFX_91.Navigating, AddressOf proc_navigating_geckofx_motor_91
                Exit Select
            Case 92
                AddHandler OBJ_MOTOR_GECKOFX_92.Navigating, AddressOf proc_navigating_geckofx_motor_92
                Exit Select
            Case 93
                AddHandler OBJ_MOTOR_GECKOFX_93.Navigating, AddressOf proc_navigating_geckofx_motor_93
                Exit Select
            Case 94
                AddHandler OBJ_MOTOR_GECKOFX_94.Navigating, AddressOf proc_navigating_geckofx_motor_94
                Exit Select
            Case 95
                AddHandler OBJ_MOTOR_GECKOFX_95.Navigating, AddressOf proc_navigating_geckofx_motor_95
                Exit Select
            Case 96
                AddHandler OBJ_MOTOR_GECKOFX_96.Navigating, AddressOf proc_navigating_geckofx_motor_96
                Exit Select
            Case 97
                AddHandler OBJ_MOTOR_GECKOFX_97.Navigating, AddressOf proc_navigating_geckofx_motor_97
                Exit Select
            Case 98
                AddHandler OBJ_MOTOR_GECKOFX_98.Navigating, AddressOf proc_navigating_geckofx_motor_98
                Exit Select
            Case 99
                AddHandler OBJ_MOTOR_GECKOFX_99.Navigating, AddressOf proc_navigating_geckofx_motor_99
                Exit Select
            Case 100
                AddHandler OBJ_MOTOR_GECKOFX_100.Navigating, AddressOf proc_navigating_geckofx_motor_100
                Exit Select
            Case 101
                AddHandler OBJ_MOTOR_GECKOFX_101.Navigating, AddressOf proc_navigating_geckofx_motor_101
                Exit Select
            Case 102
                AddHandler OBJ_MOTOR_GECKOFX_102.Navigating, AddressOf proc_navigating_geckofx_motor_102
                Exit Select
            Case 103
                AddHandler OBJ_MOTOR_GECKOFX_103.Navigating, AddressOf proc_navigating_geckofx_motor_103
                Exit Select
            Case 104
                AddHandler OBJ_MOTOR_GECKOFX_104.Navigating, AddressOf proc_navigating_geckofx_motor_104
                Exit Select
            Case 105
                AddHandler OBJ_MOTOR_GECKOFX_105.Navigating, AddressOf proc_navigating_geckofx_motor_105
                Exit Select
            Case 106
                AddHandler OBJ_MOTOR_GECKOFX_106.Navigating, AddressOf proc_navigating_geckofx_motor_106
                Exit Select
            Case 107
                AddHandler OBJ_MOTOR_GECKOFX_107.Navigating, AddressOf proc_navigating_geckofx_motor_107
                Exit Select
            Case 108
                AddHandler OBJ_MOTOR_GECKOFX_108.Navigating, AddressOf proc_navigating_geckofx_motor_108
                Exit Select
            Case 109
                AddHandler OBJ_MOTOR_GECKOFX_109.Navigating, AddressOf proc_navigating_geckofx_motor_109
                Exit Select
            Case 110
                AddHandler OBJ_MOTOR_GECKOFX_110.Navigating, AddressOf proc_navigating_geckofx_motor_110
                Exit Select
            Case 111
                AddHandler OBJ_MOTOR_GECKOFX_111.Navigating, AddressOf proc_navigating_geckofx_motor_111
                Exit Select
            Case 112
                AddHandler OBJ_MOTOR_GECKOFX_112.Navigating, AddressOf proc_navigating_geckofx_motor_112
                Exit Select
            Case 113
                AddHandler OBJ_MOTOR_GECKOFX_113.Navigating, AddressOf proc_navigating_geckofx_motor_113
                Exit Select
            Case 114
                AddHandler OBJ_MOTOR_GECKOFX_114.Navigating, AddressOf proc_navigating_geckofx_motor_114
                Exit Select
            Case 115
                AddHandler OBJ_MOTOR_GECKOFX_115.Navigating, AddressOf proc_navigating_geckofx_motor_115
                Exit Select
            Case 116
                AddHandler OBJ_MOTOR_GECKOFX_116.Navigating, AddressOf proc_navigating_geckofx_motor_116
                Exit Select
            Case 117
                AddHandler OBJ_MOTOR_GECKOFX_117.Navigating, AddressOf proc_navigating_geckofx_motor_117
                Exit Select
            Case 118
                AddHandler OBJ_MOTOR_GECKOFX_118.Navigating, AddressOf proc_navigating_geckofx_motor_118
                Exit Select
            Case 119
                AddHandler OBJ_MOTOR_GECKOFX_119.Navigating, AddressOf proc_navigating_geckofx_motor_119
                Exit Select
            Case 120
                AddHandler OBJ_MOTOR_GECKOFX_120.Navigating, AddressOf proc_navigating_geckofx_motor_120
                Exit Select
            Case 121
                AddHandler OBJ_MOTOR_GECKOFX_121.Navigating, AddressOf proc_navigating_geckofx_motor_121
                Exit Select
            Case 122
                AddHandler OBJ_MOTOR_GECKOFX_122.Navigating, AddressOf proc_navigating_geckofx_motor_122
                Exit Select
            Case 123
                AddHandler OBJ_MOTOR_GECKOFX_123.Navigating, AddressOf proc_navigating_geckofx_motor_123
                Exit Select
            Case 124
                AddHandler OBJ_MOTOR_GECKOFX_124.Navigating, AddressOf proc_navigating_geckofx_motor_124
                Exit Select
            Case 125
                AddHandler OBJ_MOTOR_GECKOFX_125.Navigating, AddressOf proc_navigating_geckofx_motor_125
                Exit Select
            Case 126
                AddHandler OBJ_MOTOR_GECKOFX_126.Navigating, AddressOf proc_navigating_geckofx_motor_126
                Exit Select
            Case 127
                AddHandler OBJ_MOTOR_GECKOFX_127.Navigating, AddressOf proc_navigating_geckofx_motor_127
                Exit Select
            Case 128
                AddHandler OBJ_MOTOR_GECKOFX_128.Navigating, AddressOf proc_navigating_geckofx_motor_128
                Exit Select




        End Select


    End Sub

    Private Sub proc_ligar_evento_navigating_de_pagina_trident() 'Liga o evento de navigating de página trident
        On Error Resume Next



        Select Case v_qual_motor_esta_em_uso


            Case 1
                AddHandler OBJ_MOTOR_WEB_BROWSER_1.Navigating, AddressOf proc_navigating_trident_motor_1
                Exit Select
            Case 2
                AddHandler OBJ_MOTOR_WEB_BROWSER_2.Navigating, AddressOf proc_navigating_trident_motor_2
                Exit Select
            Case 3
                AddHandler OBJ_MOTOR_WEB_BROWSER_3.Navigating, AddressOf proc_navigating_trident_motor_3
                Exit Select
            Case 4
                AddHandler OBJ_MOTOR_WEB_BROWSER_4.Navigating, AddressOf proc_navigating_trident_motor_4
                Exit Select
            Case 5
                AddHandler OBJ_MOTOR_WEB_BROWSER_5.Navigating, AddressOf proc_navigating_trident_motor_5
                Exit Select
            Case 6
                AddHandler OBJ_MOTOR_WEB_BROWSER_6.Navigating, AddressOf proc_navigating_trident_motor_6
                Exit Select
            Case 7
                AddHandler OBJ_MOTOR_WEB_BROWSER_7.Navigating, AddressOf proc_navigating_trident_motor_7
                Exit Select
            Case 8
                AddHandler OBJ_MOTOR_WEB_BROWSER_8.Navigating, AddressOf proc_navigating_trident_motor_8
                Exit Select
            Case 9
                AddHandler OBJ_MOTOR_WEB_BROWSER_9.Navigating, AddressOf proc_navigating_trident_motor_9
                Exit Select
            Case 10
                AddHandler OBJ_MOTOR_WEB_BROWSER_10.Navigating, AddressOf proc_navigating_trident_motor_10
                Exit Select
            Case 11
                AddHandler OBJ_MOTOR_WEB_BROWSER_11.Navigating, AddressOf proc_navigating_trident_motor_11
                Exit Select
            Case 12
                AddHandler OBJ_MOTOR_WEB_BROWSER_12.Navigating, AddressOf proc_navigating_trident_motor_12
                Exit Select
            Case 13
                AddHandler OBJ_MOTOR_WEB_BROWSER_13.Navigating, AddressOf proc_navigating_trident_motor_13
                Exit Select
            Case 14
                AddHandler OBJ_MOTOR_WEB_BROWSER_14.Navigating, AddressOf proc_navigating_trident_motor_14
                Exit Select
            Case 15
                AddHandler OBJ_MOTOR_WEB_BROWSER_15.Navigating, AddressOf proc_navigating_trident_motor_15
                Exit Select
            Case 16
                AddHandler OBJ_MOTOR_WEB_BROWSER_16.Navigating, AddressOf proc_navigating_trident_motor_16
                Exit Select
            Case 17
                AddHandler OBJ_MOTOR_WEB_BROWSER_17.Navigating, AddressOf proc_navigating_trident_motor_17
                Exit Select
            Case 18
                AddHandler OBJ_MOTOR_WEB_BROWSER_18.Navigating, AddressOf proc_navigating_trident_motor_18
                Exit Select
            Case 19
                AddHandler OBJ_MOTOR_WEB_BROWSER_19.Navigating, AddressOf proc_navigating_trident_motor_19
                Exit Select
            Case 20
                AddHandler OBJ_MOTOR_WEB_BROWSER_20.Navigating, AddressOf proc_navigating_trident_motor_20
                Exit Select
            Case 21
                AddHandler OBJ_MOTOR_WEB_BROWSER_21.Navigating, AddressOf proc_navigating_trident_motor_21
                Exit Select
            Case 22
                AddHandler OBJ_MOTOR_WEB_BROWSER_22.Navigating, AddressOf proc_navigating_trident_motor_22
                Exit Select
            Case 23
                AddHandler OBJ_MOTOR_WEB_BROWSER_23.Navigating, AddressOf proc_navigating_trident_motor_23
                Exit Select
            Case 24
                AddHandler OBJ_MOTOR_WEB_BROWSER_24.Navigating, AddressOf proc_navigating_trident_motor_24
                Exit Select
            Case 25
                AddHandler OBJ_MOTOR_WEB_BROWSER_25.Navigating, AddressOf proc_navigating_trident_motor_25
                Exit Select
            Case 26
                AddHandler OBJ_MOTOR_WEB_BROWSER_26.Navigating, AddressOf proc_navigating_trident_motor_26
                Exit Select
            Case 27
                AddHandler OBJ_MOTOR_WEB_BROWSER_27.Navigating, AddressOf proc_navigating_trident_motor_27
                Exit Select
            Case 28
                AddHandler OBJ_MOTOR_WEB_BROWSER_28.Navigating, AddressOf proc_navigating_trident_motor_28
                Exit Select
            Case 29
                AddHandler OBJ_MOTOR_WEB_BROWSER_29.Navigating, AddressOf proc_navigating_trident_motor_29
                Exit Select
            Case 30
                AddHandler OBJ_MOTOR_WEB_BROWSER_30.Navigating, AddressOf proc_navigating_trident_motor_30
                Exit Select
            Case 31
                AddHandler OBJ_MOTOR_WEB_BROWSER_31.Navigating, AddressOf proc_navigating_trident_motor_31
                Exit Select
            Case 32
                AddHandler OBJ_MOTOR_WEB_BROWSER_32.Navigating, AddressOf proc_navigating_trident_motor_32
                Exit Select
            Case 33
                AddHandler OBJ_MOTOR_WEB_BROWSER_33.Navigating, AddressOf proc_navigating_trident_motor_33
                Exit Select
            Case 34
                AddHandler OBJ_MOTOR_WEB_BROWSER_34.Navigating, AddressOf proc_navigating_trident_motor_34
                Exit Select
            Case 35
                AddHandler OBJ_MOTOR_WEB_BROWSER_35.Navigating, AddressOf proc_navigating_trident_motor_35
                Exit Select
            Case 36
                AddHandler OBJ_MOTOR_WEB_BROWSER_36.Navigating, AddressOf proc_navigating_trident_motor_36
                Exit Select
            Case 37
                AddHandler OBJ_MOTOR_WEB_BROWSER_37.Navigating, AddressOf proc_navigating_trident_motor_37
                Exit Select
            Case 38
                AddHandler OBJ_MOTOR_WEB_BROWSER_38.Navigating, AddressOf proc_navigating_trident_motor_38
                Exit Select
            Case 39
                AddHandler OBJ_MOTOR_WEB_BROWSER_39.Navigating, AddressOf proc_navigating_trident_motor_39
                Exit Select
            Case 40
                AddHandler OBJ_MOTOR_WEB_BROWSER_40.Navigating, AddressOf proc_navigating_trident_motor_40
                Exit Select
            Case 41
                AddHandler OBJ_MOTOR_WEB_BROWSER_41.Navigating, AddressOf proc_navigating_trident_motor_41
                Exit Select
            Case 42
                AddHandler OBJ_MOTOR_WEB_BROWSER_42.Navigating, AddressOf proc_navigating_trident_motor_42
                Exit Select
            Case 43
                AddHandler OBJ_MOTOR_WEB_BROWSER_43.Navigating, AddressOf proc_navigating_trident_motor_43
                Exit Select
            Case 44
                AddHandler OBJ_MOTOR_WEB_BROWSER_44.Navigating, AddressOf proc_navigating_trident_motor_44
                Exit Select
            Case 45
                AddHandler OBJ_MOTOR_WEB_BROWSER_45.Navigating, AddressOf proc_navigating_trident_motor_45
                Exit Select
            Case 46
                AddHandler OBJ_MOTOR_WEB_BROWSER_46.Navigating, AddressOf proc_navigating_trident_motor_46
                Exit Select
            Case 47
                AddHandler OBJ_MOTOR_WEB_BROWSER_47.Navigating, AddressOf proc_navigating_trident_motor_47
                Exit Select
            Case 48
                AddHandler OBJ_MOTOR_WEB_BROWSER_48.Navigating, AddressOf proc_navigating_trident_motor_48
                Exit Select
            Case 49
                AddHandler OBJ_MOTOR_WEB_BROWSER_49.Navigating, AddressOf proc_navigating_trident_motor_49
                Exit Select
            Case 50
                AddHandler OBJ_MOTOR_WEB_BROWSER_50.Navigating, AddressOf proc_navigating_trident_motor_50
                Exit Select
            Case 51
                AddHandler OBJ_MOTOR_WEB_BROWSER_51.Navigating, AddressOf proc_navigating_trident_motor_51
                Exit Select
            Case 52
                AddHandler OBJ_MOTOR_WEB_BROWSER_52.Navigating, AddressOf proc_navigating_trident_motor_52
                Exit Select
            Case 53
                AddHandler OBJ_MOTOR_WEB_BROWSER_53.Navigating, AddressOf proc_navigating_trident_motor_53
                Exit Select
            Case 54
                AddHandler OBJ_MOTOR_WEB_BROWSER_54.Navigating, AddressOf proc_navigating_trident_motor_54
                Exit Select
            Case 55
                AddHandler OBJ_MOTOR_WEB_BROWSER_55.Navigating, AddressOf proc_navigating_trident_motor_55
                Exit Select
            Case 56
                AddHandler OBJ_MOTOR_WEB_BROWSER_56.Navigating, AddressOf proc_navigating_trident_motor_56
                Exit Select
            Case 57
                AddHandler OBJ_MOTOR_WEB_BROWSER_57.Navigating, AddressOf proc_navigating_trident_motor_57
                Exit Select
            Case 58
                AddHandler OBJ_MOTOR_WEB_BROWSER_58.Navigating, AddressOf proc_navigating_trident_motor_58
                Exit Select
            Case 59
                AddHandler OBJ_MOTOR_WEB_BROWSER_59.Navigating, AddressOf proc_navigating_trident_motor_59
                Exit Select
            Case 60
                AddHandler OBJ_MOTOR_WEB_BROWSER_60.Navigating, AddressOf proc_navigating_trident_motor_60
                Exit Select
            Case 61
                AddHandler OBJ_MOTOR_WEB_BROWSER_61.Navigating, AddressOf proc_navigating_trident_motor_61
                Exit Select
            Case 62
                AddHandler OBJ_MOTOR_WEB_BROWSER_62.Navigating, AddressOf proc_navigating_trident_motor_62
                Exit Select
            Case 63
                AddHandler OBJ_MOTOR_WEB_BROWSER_63.Navigating, AddressOf proc_navigating_trident_motor_63
                Exit Select
            Case 64
                AddHandler OBJ_MOTOR_WEB_BROWSER_64.Navigating, AddressOf proc_navigating_trident_motor_64
                Exit Select
            Case 65
                AddHandler OBJ_MOTOR_WEB_BROWSER_65.Navigating, AddressOf proc_navigating_trident_motor_65
                Exit Select
            Case 66
                AddHandler OBJ_MOTOR_WEB_BROWSER_66.Navigating, AddressOf proc_navigating_trident_motor_66
                Exit Select
            Case 67
                AddHandler OBJ_MOTOR_WEB_BROWSER_67.Navigating, AddressOf proc_navigating_trident_motor_67
                Exit Select
            Case 68
                AddHandler OBJ_MOTOR_WEB_BROWSER_68.Navigating, AddressOf proc_navigating_trident_motor_68
                Exit Select
            Case 69
                AddHandler OBJ_MOTOR_WEB_BROWSER_69.Navigating, AddressOf proc_navigating_trident_motor_69
                Exit Select
            Case 70
                AddHandler OBJ_MOTOR_WEB_BROWSER_70.Navigating, AddressOf proc_navigating_trident_motor_70
                Exit Select
            Case 71
                AddHandler OBJ_MOTOR_WEB_BROWSER_71.Navigating, AddressOf proc_navigating_trident_motor_71
                Exit Select
            Case 72
                AddHandler OBJ_MOTOR_WEB_BROWSER_72.Navigating, AddressOf proc_navigating_trident_motor_72
                Exit Select
            Case 73
                AddHandler OBJ_MOTOR_WEB_BROWSER_73.Navigating, AddressOf proc_navigating_trident_motor_73
                Exit Select
            Case 74
                AddHandler OBJ_MOTOR_WEB_BROWSER_74.Navigating, AddressOf proc_navigating_trident_motor_74
                Exit Select
            Case 75
                AddHandler OBJ_MOTOR_WEB_BROWSER_75.Navigating, AddressOf proc_navigating_trident_motor_75
                Exit Select
            Case 76
                AddHandler OBJ_MOTOR_WEB_BROWSER_76.Navigating, AddressOf proc_navigating_trident_motor_76
                Exit Select
            Case 77
                AddHandler OBJ_MOTOR_WEB_BROWSER_77.Navigating, AddressOf proc_navigating_trident_motor_77
                Exit Select
            Case 78
                AddHandler OBJ_MOTOR_WEB_BROWSER_78.Navigating, AddressOf proc_navigating_trident_motor_78
                Exit Select
            Case 79
                AddHandler OBJ_MOTOR_WEB_BROWSER_79.Navigating, AddressOf proc_navigating_trident_motor_79
                Exit Select
            Case 80
                AddHandler OBJ_MOTOR_WEB_BROWSER_80.Navigating, AddressOf proc_navigating_trident_motor_80
                Exit Select
            Case 81
                AddHandler OBJ_MOTOR_WEB_BROWSER_81.Navigating, AddressOf proc_navigating_trident_motor_81
                Exit Select
            Case 82
                AddHandler OBJ_MOTOR_WEB_BROWSER_82.Navigating, AddressOf proc_navigating_trident_motor_82
                Exit Select
            Case 83
                AddHandler OBJ_MOTOR_WEB_BROWSER_83.Navigating, AddressOf proc_navigating_trident_motor_83
                Exit Select
            Case 84
                AddHandler OBJ_MOTOR_WEB_BROWSER_84.Navigating, AddressOf proc_navigating_trident_motor_84
                Exit Select
            Case 85
                AddHandler OBJ_MOTOR_WEB_BROWSER_85.Navigating, AddressOf proc_navigating_trident_motor_85
                Exit Select
            Case 86
                AddHandler OBJ_MOTOR_WEB_BROWSER_86.Navigating, AddressOf proc_navigating_trident_motor_86
                Exit Select
            Case 87
                AddHandler OBJ_MOTOR_WEB_BROWSER_87.Navigating, AddressOf proc_navigating_trident_motor_87
                Exit Select
            Case 88
                AddHandler OBJ_MOTOR_WEB_BROWSER_88.Navigating, AddressOf proc_navigating_trident_motor_88
                Exit Select
            Case 89
                AddHandler OBJ_MOTOR_WEB_BROWSER_89.Navigating, AddressOf proc_navigating_trident_motor_89
                Exit Select
            Case 90
                AddHandler OBJ_MOTOR_WEB_BROWSER_90.Navigating, AddressOf proc_navigating_trident_motor_90
                Exit Select
            Case 91
                AddHandler OBJ_MOTOR_WEB_BROWSER_91.Navigating, AddressOf proc_navigating_trident_motor_91
                Exit Select
            Case 92
                AddHandler OBJ_MOTOR_WEB_BROWSER_92.Navigating, AddressOf proc_navigating_trident_motor_92
                Exit Select
            Case 93
                AddHandler OBJ_MOTOR_WEB_BROWSER_93.Navigating, AddressOf proc_navigating_trident_motor_93
                Exit Select
            Case 94
                AddHandler OBJ_MOTOR_WEB_BROWSER_94.Navigating, AddressOf proc_navigating_trident_motor_94
                Exit Select
            Case 95
                AddHandler OBJ_MOTOR_WEB_BROWSER_95.Navigating, AddressOf proc_navigating_trident_motor_95
                Exit Select
            Case 96
                AddHandler OBJ_MOTOR_WEB_BROWSER_96.Navigating, AddressOf proc_navigating_trident_motor_96
                Exit Select
            Case 97
                AddHandler OBJ_MOTOR_WEB_BROWSER_97.Navigating, AddressOf proc_navigating_trident_motor_97
                Exit Select
            Case 98
                AddHandler OBJ_MOTOR_WEB_BROWSER_98.Navigating, AddressOf proc_navigating_trident_motor_98
                Exit Select
            Case 99
                AddHandler OBJ_MOTOR_WEB_BROWSER_99.Navigating, AddressOf proc_navigating_trident_motor_99
                Exit Select
            Case 100
                AddHandler OBJ_MOTOR_WEB_BROWSER_100.Navigating, AddressOf proc_navigating_trident_motor_100
                Exit Select
            Case 101
                AddHandler OBJ_MOTOR_WEB_BROWSER_101.Navigating, AddressOf proc_navigating_trident_motor_101
                Exit Select
            Case 102
                AddHandler OBJ_MOTOR_WEB_BROWSER_102.Navigating, AddressOf proc_navigating_trident_motor_102
                Exit Select
            Case 103
                AddHandler OBJ_MOTOR_WEB_BROWSER_103.Navigating, AddressOf proc_navigating_trident_motor_103
                Exit Select
            Case 104
                AddHandler OBJ_MOTOR_WEB_BROWSER_104.Navigating, AddressOf proc_navigating_trident_motor_104
                Exit Select
            Case 105
                AddHandler OBJ_MOTOR_WEB_BROWSER_105.Navigating, AddressOf proc_navigating_trident_motor_105
                Exit Select
            Case 106
                AddHandler OBJ_MOTOR_WEB_BROWSER_106.Navigating, AddressOf proc_navigating_trident_motor_106
                Exit Select
            Case 107
                AddHandler OBJ_MOTOR_WEB_BROWSER_107.Navigating, AddressOf proc_navigating_trident_motor_107
                Exit Select
            Case 108
                AddHandler OBJ_MOTOR_WEB_BROWSER_108.Navigating, AddressOf proc_navigating_trident_motor_108
                Exit Select
            Case 109
                AddHandler OBJ_MOTOR_WEB_BROWSER_109.Navigating, AddressOf proc_navigating_trident_motor_109
                Exit Select
            Case 110
                AddHandler OBJ_MOTOR_WEB_BROWSER_110.Navigating, AddressOf proc_navigating_trident_motor_110
                Exit Select
            Case 111
                AddHandler OBJ_MOTOR_WEB_BROWSER_111.Navigating, AddressOf proc_navigating_trident_motor_111
                Exit Select
            Case 112
                AddHandler OBJ_MOTOR_WEB_BROWSER_112.Navigating, AddressOf proc_navigating_trident_motor_112
                Exit Select
            Case 113
                AddHandler OBJ_MOTOR_WEB_BROWSER_113.Navigating, AddressOf proc_navigating_trident_motor_113
                Exit Select
            Case 114
                AddHandler OBJ_MOTOR_WEB_BROWSER_114.Navigating, AddressOf proc_navigating_trident_motor_114
                Exit Select
            Case 115
                AddHandler OBJ_MOTOR_WEB_BROWSER_115.Navigating, AddressOf proc_navigating_trident_motor_115
                Exit Select
            Case 116
                AddHandler OBJ_MOTOR_WEB_BROWSER_116.Navigating, AddressOf proc_navigating_trident_motor_116
                Exit Select
            Case 117
                AddHandler OBJ_MOTOR_WEB_BROWSER_117.Navigating, AddressOf proc_navigating_trident_motor_117
                Exit Select
            Case 118
                AddHandler OBJ_MOTOR_WEB_BROWSER_118.Navigating, AddressOf proc_navigating_trident_motor_118
                Exit Select
            Case 119
                AddHandler OBJ_MOTOR_WEB_BROWSER_119.Navigating, AddressOf proc_navigating_trident_motor_119
                Exit Select
            Case 120
                AddHandler OBJ_MOTOR_WEB_BROWSER_120.Navigating, AddressOf proc_navigating_trident_motor_120
                Exit Select
            Case 121
                AddHandler OBJ_MOTOR_WEB_BROWSER_121.Navigating, AddressOf proc_navigating_trident_motor_121
                Exit Select
            Case 122
                AddHandler OBJ_MOTOR_WEB_BROWSER_122.Navigating, AddressOf proc_navigating_trident_motor_122
                Exit Select
            Case 123
                AddHandler OBJ_MOTOR_WEB_BROWSER_123.Navigating, AddressOf proc_navigating_trident_motor_123
                Exit Select
            Case 124
                AddHandler OBJ_MOTOR_WEB_BROWSER_124.Navigating, AddressOf proc_navigating_trident_motor_124
                Exit Select
            Case 125
                AddHandler OBJ_MOTOR_WEB_BROWSER_125.Navigating, AddressOf proc_navigating_trident_motor_125
                Exit Select
            Case 126
                AddHandler OBJ_MOTOR_WEB_BROWSER_126.Navigating, AddressOf proc_navigating_trident_motor_126
                Exit Select
            Case 127
                AddHandler OBJ_MOTOR_WEB_BROWSER_127.Navigating, AddressOf proc_navigating_trident_motor_127
                Exit Select
            Case 128
                AddHandler OBJ_MOTOR_WEB_BROWSER_128.Navigating, AddressOf proc_navigating_trident_motor_128
                Exit Select




        End Select


    End Sub







    'Ligador de eventos

    Public Sub proc_adicionador_de_eventos_em_tempo_de_execucao() 'Adiciona o evento em tempo de execução
        On Error Resume Next


        'Verifica o tipo de motor a ser trabalhado --------------------------------------------------------------------------------------------

        If (v_tipo_de_motor_layout_engine_em_uso_agora = True) Then



            proc_ligar_evento_carregamento_de_pagina_geckofx() 'Liga o evento de carregamento de página
            proc_ligar_evento_carregamento_completo_de_pagina_geckofx() 'Liga o evento de carregamento completo de página
            proc_ligar_evento_statustext_geckofx() 'Liga o evento de statustext de página
            proc_ligar_evento_clicar_na_pagina_geckofx() 'Liga o evento de Domclick de página
            proc_ligar_evento_mover_mouse_geckofx() 'Liga o evento de mover mouse sobre o motor geckofx
            proc_ligar_evento_navigating_de_pagina_geckofx() 'Liga o evento de navigating geckofx



        Else



            proc_ligar_evento_carregamento_de_pagina_trident() 'Liga o evento de carregamento de página
            proc_ligar_evento_carregamento_completo_de_pagina_trident() 'Liga o evento de carregamento completo de página
            proc_ligar_evento_navigating_de_pagina_trident() 'Liga o evento de navigating de página trident




        End If

        '--------------------------------------------------------------------------------------------------------------------------------------




        'Eventos que nao dependem do tipo de motor layout engine ------------------------------------------------------------------------------

        proc_ligar_evento_backgroundworkers_virtuais() 'Liga os eventos dos backgroundworkers virtuais

        proc_ligar_evento_backgroundworkers_virtuais_completado() 'Liga os eventos dos backgroundworkers virtuais evento completado

        '--------------------------------------------------------------------------------------------------------------------------------------





















    End Sub








End Module
