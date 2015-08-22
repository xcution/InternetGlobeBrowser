Imports System.ComponentModel
Imports SpeechLib




Module MODULO_DE_OBJETOS_GLOBAIS


    'OBJETOS GLOBAIS

    Public OBJ_DIALOGO_ABRIR_ARQUIVO As OpenFileDialog 'CAIXA DE DIÁLOGO DE ABRIR ARQUIVO

    Public OBJ_DIALOGO_ABRIR_PASTA As FolderBrowserDialog 'CAIXA DE DIÁLOGO DE ABRIR SOMENTE PASTA

    Public OBJ_DIALOGO_SALVAR_ARQUIVO As SaveFileDialog 'CAIXA DE DIÁLOGO DE SALVAR ARQUIVO

    Public BCK_EXECUTADOR_DE_DOWNLOAD As BackgroundWorker 'EXECUTADOR DE DOWNLOAD

    Public BCK_EXECUTADOR_DE_DOWNLOAD_2 As BackgroundWorker 'EXECUTADOR DE DOWNLOAD

    Public OBJ_MOTOR_DE_ACAO_EM_USO As New Gecko.GeckoWebBrowser 'MOTOR DE AÇÃO EM USO

    Public OBJ_BCK_PROCESSADOR_DE_HISTORICO As New BackgroundWorker 'NOVO PROCESSADOR DE HISTORICO BAKCGROUNDWORKER

    Public OBJ_VOZ_SINTETIZADOR_DE_FALA_HUMANA As New SpeechLib.SpVoice 'NOVO SINTETIZADOR DE FALA HUMANA

    Public OBJ_FORMULARIO_DE_TRABALHO As New Form 'NOVO FORMULARIO DE TRABALHO

    Public OBJ_TIMER_EXECUTADOR_DE_TESTE_DE_INTELIGENCIA As New Timer 'TIMER EXECUTADOR DE TESTES DE INTELIGENCIA

    Public OBJ_MENU_DE_CONTEXTO As New ContextMenuStrip 'NOVO MENU DE CONTEXTO





















    'PROCEDIMENTOS DE OBJETOS

    Public Sub PROC_DEFINE_MOTOR_DE_ACAO_EM_USO(ByVal OBJ As Object) 'DEFINE O MOTOR DE AÇÃO EM USO
        On Error Resume Next


        'IGUALA OBJETOS E HERDA VALORES --------------------------------------------------------------------------------

        OBJ_MOTOR_DE_ACAO_EM_USO = DirectCast(OBJ, Gecko.GeckoWebBrowser) 'IGUALANDO...

        '---------------------------------------------------------------------------------------------------------------




        'DESABILITA MENU DESCONHECIDO ----------------------------------------------------------------------------------

        OBJ_MOTOR_DE_ACAO_EM_USO.DisableWmImeSetContext = True 'DESABILITANDO

        '---------------------------------------------------------------------------------------------------------------


    End Sub




































End Module
