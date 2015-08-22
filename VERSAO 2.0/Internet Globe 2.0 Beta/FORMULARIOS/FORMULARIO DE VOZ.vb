Imports SpeechLib




Public Class FRM_FORMULARIO_DE_VOZ


    'VARIÁVEIS

    Public V_TEXTO_A_SER_TRABALHADO As String = Nothing 'TEXTO A SER TRABALHADO NO RECURSO DE VÓZ




















    'PROCEDIMENTOS

    Private Sub PROC_LER_CONTEUDO(ByVal V_CONTEUDO As String) 'LÊ O CONTEUDO INFORMADO
        On Error Resume Next

        Dim V_VOZ As String = FUNC_LER_ARQUIVO(V_ARQUIVO_END_18) 'LENDO A VOZ SELECIONADA

        Dim V_VOZ_NUMERO As Integer 'NÚMERO DA VOZ PADRÃO






        'INFORMA O TEXTO A SER LIDO ------------------------------------------------------------------------------------

        V_TEXTO_A_SER_TRABALHADO = V_CONTEUDO 'REPASSANDO

        '---------------------------------------------------------------------------------------------------------------




        'VERIFICA A VOZ ------------------------------------------------------------------------------------------------

        If (V_VOZ = Nothing) Or (V_VOZ = "") Then


            V_VOZ_NUMERO = 0 'VOZ PADRÃO


        Else


            V_VOZ_NUMERO = V_VOZ 'NUMERO DA VOZ INSTALADA


        End If

        '---------------------------------------------------------------------------------------------------------------




        'LENDO O CONTEÚDO ----------------------------------------------------------------------------------------------

        If (OBJ_VOZ_LEITOR.Status.RunningState = SpeechRunState.SRSEDone) Then


            OBJ_VOZ_LEITOR.Speak("", SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak) 'PARANDO VOZ ANTERIOR

            OBJ_VOZ_LEITOR.Voice = OBJ_VOZ_LEITOR.GetVoices.Item(V_VOZ_NUMERO) 'VOZ SELECIONADA

            OBJ_VOZ_LEITOR.Speak(V_CONTEUDO, SpeechVoiceSpeakFlags.SVSFlagsAsync) 'LENDO O CONTEÚDO


        Else


            OBJ_VOZ_LEITOR.Resume() 'CONTINUA DE ONDE PAROU

            OBJ_VOZ_LEITOR.Speak("", SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak) 'PARANDO VOZ ANTERIOR

            OBJ_VOZ_LEITOR.Voice = OBJ_VOZ_LEITOR.GetVoices.Item(V_VOZ_NUMERO) 'VOZ SELECIONADA

            OBJ_VOZ_LEITOR.Speak(V_CONTEUDO, SpeechVoiceSpeakFlags.SVSFlagsAsync) 'LENDO O CONTEÚDO


        End If
        
        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_ANALISA_SE_LER_OU_EXIBE_FORMULARIO() 'ANALISA SE LÊ O CONTEÚDO OU SÓ EXIBE O FORMULÁRIO
        On Error Resume Next


        'ANALISA SE LÊ OU SÓ EXIBE O FORMULARIO ------------------------------------------------------------------------

        If (V_TEXTO_A_SER_TRABALHADO <> Nothing) And (V_TEXTO_A_SER_TRABALHADO <> "") Then


            PROC_LER_CONTEUDO(V_TEXTO_A_SER_TRABALHADO) 'LÊ O CONTEUDO INFORMADO


        End If

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_BOTOES_DE_VOZ_EXIBIR_CORRETAMENTE() 'EXIBIR BOTOES DE VOZ CORRETAMENTE
        On Error Resume Next


        'VERIFICA O STATUS DA LEITURA -------------------------------------------------------------------------------------------------------------

        If (OBJ_VOZ_LEITOR.Status.RunningState = SpeechRunState.SRSEIsSpeaking) Then


            ToolStripButton1.Enabled = False 'DESABILITA
            ToolStripButton5.Text = "Pausar" 'CONTINUAR


        Else


            ToolStripButton1.Enabled = True 'HABILITA
            ToolStripButton5.Text = "Continuar" 'PAUSAR


        End If

        '------------------------------------------------------------------------------------------------------------------------------------------




        'BOTÃO SALVAR AUDIO -----------------------------------------------------------------------------------------------------------------------

        If ((RCH_TEXTO.Text.Length > 0)) Then


            ToolStripButton2.Enabled = True 'HABILITA


        Else


            ToolStripButton2.Enabled = False 'DESABILITA


        End If

        '------------------------------------------------------------------------------------------------------------------------------------------




        'BOTAO PAUSAR NAO EXIBIR AO INICIAR NOVO TEXTO --------------------------------------------------------------------------------------------

        If (OBJ_VOZ_LEITOR.Status.RunningState = SpeechRunState.SRSEDone) Then


            ToolStripButton5.Enabled = False 'DESABILITA


        Else


            ToolStripButton5.Enabled = True 'HABILITA


        End If

        '------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_PAUSA_VOZ() 'PAUSA A VOZ
        On Error Resume Next


        If (OBJ_VOZ_LEITOR.Status.RunningState = SpeechRunState.SRSEIsSpeaking) Then


            OBJ_VOZ_LEITOR.Pause() 'PAUSANDO


        Else


            OBJ_VOZ_LEITOR.Resume() 'INICIANDO DE ONDE PAROU


        End If




    End Sub

    Private Sub PROC_NOVO_TEXTO_DE_VOZ() 'NOVO TEXTO DE VOZ
        On Error Resume Next


        'LIMPA VARIÁVEL ------------------------------------------------------------------------------------------------

        V_TEXTO_A_SER_TRABALHADO = Nothing 'LIMPANDO

        RCH_TEXTO.Text = Nothing 'LIMPANDO

        '---------------------------------------------------------------------------------------------------------------




        'PARA VOZ ------------------------------------------------------------------------------------------------------

        OBJ_VOZ_LEITOR.Resume() 'CONTINUA DE ONDE PAROU

        OBJ_VOZ_LEITOR.Speak("", SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak) 'PARANDO VOZ ANTERIOR

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_AO_SAIR_FORM_DE_VOZ_PARAR_VOZ() 'AO SAIR DO FORMULARIO DE VOZ PARAR SERVIÇOS DE VOZ
        On Error Resume Next


        'PARA VOZ ------------------------------------------------------------------------------------------------------

        OBJ_VOZ_LEITOR.Resume() 'CONTINUA DE ONDE PAROU

        OBJ_VOZ_LEITOR.Speak("", SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak) 'PARANDO VOZ ANTERIOR

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_SALVAR_O_TEXTO_EM_FORMATO_DE_AUDIO() 'SALVA O TEXTO NO FORMATO DE ÁUDIO
        On Error Resume Next

        Dim V_VOZ As String = FUNC_LER_ARQUIVO(V_ARQUIVO_END_18) 'LENDO A VOZ SELECIONADA

        Dim V_VOZ_NUMERO As Integer 'NÚMERO DA VOZ PADRÃO

        Dim V_TEXTO_A_LER As String = RCH_TEXTO.Text 'TEXTO A SER LIDO

        OBJ_DIALOGO_SALVAR_ARQUIVO = New SaveFileDialog 'NOVO DIÁLOGO DE SALVAR ARQUIVO

        Static V_CONTADOR As Integer 'CONTADOR DE SALVAR ARQUIVO PARA NOME






        'PROPRIEDADES DE CAIXA DE DIÁLOGO DE SALVAR ARQUIVO ------------------------------------------------------------

        OBJ_DIALOGO_SALVAR_ARQUIVO.Filter = "Formato (*.wav)|*.wav|Todos os formatos (*.*)|*.*" 'EXTENÇÃO DO ARQUIVO

        OBJ_DIALOGO_SALVAR_ARQUIVO.FileName = "Novo som wav " & V_CONTADOR 'NOVO SOM

        '---------------------------------------------------------------------------------------------------------------




        'VERIFICA A VOZ ------------------------------------------------------------------------------------------------

        If (V_VOZ = Nothing) Or (V_VOZ = "") Then


            V_VOZ_NUMERO = 0 'VOZ PADRÃO


        Else


            V_VOZ_NUMERO = V_VOZ 'NUMERO DA VOZ INSTALADA


        End If

        '---------------------------------------------------------------------------------------------------------------




        'SALVANDO VOZ EM FORMATO DE AUDIO ----------------------------------------------------------------------------------------------------------------------------

        If (OBJ_DIALOGO_SALVAR_ARQUIVO.ShowDialog = Windows.Forms.DialogResult.OK) Then




            'SALVANDO -------------------------------------------------------------------------------------------------------------------------

            Dim OBJ_VOZ_SALVAR_TEMP As New SpeechLib.SpVoice 'NOVA VOZ

            Dim cpFileStream As New SpeechLib.SpFileStream 'STREAM

            cpFileStream.Open(OBJ_DIALOGO_SALVAR_ARQUIVO.FileName, SpeechLib.SpeechStreamFileMode.SSFMCreateForWrite, False) 'ARQUIVO

            OBJ_VOZ_SALVAR_TEMP.AudioOutputStream = cpFileStream 'STREAM DE AUDIO

            OBJ_VOZ_SALVAR_TEMP.Voice = OBJ_VOZ_SALVAR_TEMP.GetVoices.Item(V_VOZ_NUMERO) 'VOZ SELECIONADA

            OBJ_VOZ_SALVAR_TEMP.Volume = 100 'VOLUME

            OBJ_VOZ_SALVAR_TEMP.Speak(V_TEXTO_A_LER, SpeechLib.SpeechVoiceSpeakFlags.SVSFDefault) 'TEXTO A SER CONVERTIDO

            OBJ_VOZ_SALVAR_TEMP = Nothing 'LIMPANDO...

            cpFileStream.Close() 'FECHANDO STREAM

            cpFileStream = Nothing 'LIMPANDO

            '----------------------------------------------------------------------------------------------------------------------------------




            'ATUALIZA O CONTADOR ----------------------------------------

            V_CONTADOR = V_CONTADOR + 1 'ATUALIZA O CONTADOR

            '------------------------------------------------------------




        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_PORCENTAGEM_DE_LEITURA_DE_TEXTO() 'PORCENTAGEM DA LEITURA DO TEXTO
        On Error Resume Next

        Dim V_JA_LIDO As String = V_TEXTO_A_SER_TRABALHADO.Substring(0, OBJ_VOZ_LEITOR.Status.InputWordPosition) 'CONTEÚDO JÁ LIDO

        Dim V_VALOR_ORIGINAL As String = V_TEXTO_A_SER_TRABALHADO 'VALOR ORIGINAL

        Dim V_AINDA_FALTA As Integer = V_VALOR_ORIGINAL.Length - V_JA_LIDO.Length 'VALOR QUE AINDA FALTA

        Dim V_VALOR_ATUAL As String 'VALOR ATUAL






        'VERIFICA O STATUS DA LEITURA --------------------------------------------------------------------------------------------------------------------------------

        If (OBJ_VOZ_LEITOR.Status.RunningState = SpeechRunState.SRSEIsSpeaking) Then


            V_VALOR_ATUAL = V_JA_LIDO 'ATUALIZA

            LBL_STATUS.Text = "Lendo..." 'INFORMA QUE ESTÁ LENDO


        Else


            V_VALOR_ATUAL = V_JA_LIDO & V_TEXTO_A_SER_TRABALHADO.Substring(V_TEXTO_A_SER_TRABALHADO.Length - V_AINDA_FALTA) 'VALOR ATUALIZADO

            LBL_STATUS.Text = "Parado" 'INFORMA QUE ESTÁ PARADO


        End If

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------




        'REPASSA A PORCENTAGEM -----------------------------------------------------------------------------------------

        PRG_PROGRESSO.Maximum = V_VALOR_ORIGINAL.Length 'VALOR MAXIMO

        PRG_PROGRESSO.Value = V_VALOR_ATUAL.Length 'VALOR ATUAL

        '---------------------------------------------------------------------------------------------------------------


    End Sub

    Private Sub PROC_OPCOES_DE_MENU_LOCAL() 'OPÇÕES DE MENU LOCAL
        On Error Resume Next


        'RECORTAR, COPIAR, EXCLUIR -------------------------------------------------------------------------------------

        If (RCH_TEXTO.SelectedText.Length > 0) Then


            RecortarToolStripMenuItem.Enabled = True 'HABILITA
            CopiarToolStripMenuItem.Enabled = True 'HABILITA
            ExcluirToolStripMenuItem.Enabled = True 'HABILITA


        Else


            RecortarToolStripMenuItem.Enabled = False 'DESABILITA
            CopiarToolStripMenuItem.Enabled = False 'DESABILITA
            ExcluirToolStripMenuItem.Enabled = False 'DESABILITA


        End If

        '---------------------------------------------------------------------------------------------------------------




        'COLAR ---------------------------------------------------------------------------------------------------------

        If (My.Computer.Clipboard.GetText.Length > 0) Then

            ColarToolStripMenuItem.Enabled = True 'HABILITA

        Else

            ColarToolStripMenuItem.Enabled = False 'DESABILITA

        End If


        '---------------------------------------------------------------------------------------------------------------


    End Sub





























    Private Sub FRM_FORMULARIO_DE_VOZ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next


        'APLICA O FADIN ------------------------------------------------------------------------------------------------

        PROC_APLICAR_FADIN_EM_FORMULARIO(Me) 'APLICA O FADIN EM FORMULARIO

        '---------------------------------------------------------------------------------------------------------------




        'SOM DE SISTEMA ------------------------------------------------------------------------------------------------

        PROC_EXIBIR_SOM_DE_SISTEMA(0) 'EXIBE OS SONS INSTALADOS NO SISTEMA

        '---------------------------------------------------------------------------------------------------------------




        PROC_ANALISA_SE_LER_OU_EXIBE_FORMULARIO() 'ANALISA SE LÊ O CONTEÚDO OU SÓ EXIBE O FORMULÁRIO

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        On Error Resume Next

        PROC_LER_CONTEUDO(RCH_TEXTO.Text) 'LÊ O CONTEUDO INFORMADO

    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        On Error Resume Next

        PROC_BOTOES_DE_VOZ_EXIBIR_CORRETAMENTE() 'EXIBIR BOTOES DE VOZ CORRETAMENTE

    End Sub

    Private Sub TMR_ATUALIZADOR_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMR_ATUALIZADOR.Tick
        On Error Resume Next

        PROC_BOTOES_DE_VOZ_EXIBIR_CORRETAMENTE() 'EXIBIR BOTOES DE VOZ CORRETAMENTE

        PROC_PORCENTAGEM_DE_LEITURA_DE_TEXTO() 'PORCENTAGEM DA LEITURA DO TEXTO

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        On Error Resume Next

        PROC_PAUSA_VOZ() 'PAUSA A VOZ

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        On Error Resume Next

        PROC_NOVO_TEXTO_DE_VOZ() 'NOVO TEXTO DE VOZ

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        On Error Resume Next

        Me.Close() 'SAINDO

    End Sub

    Private Sub FRM_FORMULARIO_DE_VOZ_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next

        PROC_AO_SAIR_FORM_DE_VOZ_PARAR_VOZ() 'AO SAIR DO FORMULARIO DE VOZ PARAR SERVIÇOS DE VOZ

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        On Error Resume Next

        PROC_SALVAR_O_TEXTO_EM_FORMATO_DE_AUDIO() 'SALVA O TEXTO NO FORMATO DE ÁUDIO

    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        On Error Resume Next

        Me.Hide() 'OCULTANDO...

    End Sub

    Private Sub MNU_MENU_CORPO_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MNU_MENU_CORPO.Opening
        On Error Resume Next

        PROC_OPCOES_DE_MENU_LOCAL() 'OPÇÕES DE MENU LOCAL

    End Sub

    Private Sub RecortarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecortarToolStripMenuItem.Click
        On Error Resume Next

        RCH_TEXTO.Cut() 'RECORTAR

    End Sub

    Private Sub CopiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItem.Click
        On Error Resume Next

        RCH_TEXTO.Copy() 'COPIAR

    End Sub

    Private Sub ColarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColarToolStripMenuItem.Click
        On Error Resume Next

        RCH_TEXTO.Paste() 'COLAR

    End Sub

    Private Sub ExcluirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripMenuItem.Click
        On Error Resume Next

        RCH_TEXTO.SelectedText = "" 'EXCLUIR

    End Sub

End Class