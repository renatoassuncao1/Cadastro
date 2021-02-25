Imports System.Data.SQLite
Public Class FRMcadcliente
    Dim bancodedados As String
    Private Sub BTNsair_Click(sender As Object, e As EventArgs) Handles BTNsair.Click
        Application.Exit()
    End Sub

    Private Sub FRMcadcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        TXTnome.Enabled = False
        TXTemail.Enabled = False
        TXTcelular.Enabled = False
        BTNcancelar.Enabled = False
        BTNInserir.Enabled = False
        BTNlocalizar.Enabled = False
        BTNgravaralteracao.Enabled = False
        BTNdeletar.Enabled = False
        BTNalterar.Enabled = False
    End Sub

    Private Sub BTNnovoregistro_Click(sender As Object, e As EventArgs) Handles BTNnovoregistro.Click
        BTNInserir.Enabled = True
        TXTnome.Enabled = True
        TXTemail.Enabled = True
        TXTcelular.Enabled = True
        BTNcancelar.Enabled = True
    End Sub

    Private Sub BTNcancelar_Click(sender As Object, e As EventArgs) Handles BTNcancelar.Click
        TXTnome.Text = ""
        TXTemail.Text = ""
        TXTcelular.Text = ""
        TXTnome.Enabled = False
        TXTemail.Enabled = False
        TXTcelular.Enabled = False
        BTNcancelar.Enabled = False
        BTNInserir.Enabled = False
        BTNlocalizar.Enabled = False
        BTNgravaralteracao.Enabled = False
        BTNdeletar.Enabled = False
        BTNpesquisar.Enabled = True
        BTNnovoregistro.Enabled = True
        BTNalterar.Enabled = False

    End Sub

    Private Sub BTNInserir_Click(sender As Object, e As EventArgs) Handles BTNInserir.Click
        'Rotina para incluir um novo registro no Banco de Dados.
        'StartupPath é uma variável que contem o caminho onde está a aplicação
        bancodedados = "Data Source=" & Application.StartupPath & "\DBsistema.db"
        Dim SQlitecon As New SQLiteConnection(bancodedados)
        'bancodedados = "Data Source =C:\DOCS\PRESSMEDIA\1_CURSO_VBNET_JUL_2020\AULA_5\NovoSistema\bin\Debug\BDsistema.db
        Try
            SQlitecon.Open()
            Dim insertCliente As String = "INSERT INTO  TBcliente (nomecli,emailcli,celularcli) VALUES (@vnomecli,@vemailcli,@vcelularcli)"
            Dim cmd As New SQLiteCommand(insertCliente, SQlitecon)
            cmd.Parameters.AddWithValue("@vnomecli", TXTnome.Text)
            cmd.Parameters.AddWithValue("@vemailcli", TXTemail.Text)
            cmd.Parameters.AddWithValue("@vcelularcli", TXTcelular.Text)
            cmd.ExecuteNonQuery()
            MsgBox("O Registro foi Gravado!", MsgBoxStyle.Information, "Sistema")
        Catch ex As Exception
            MsgBox("Não foi possível incluir o registro " & ex.Message,
MsgBoxStyle.Critical, "Sistema")
        End Try
        SQlitecon.Close()
    End Sub

    Private Sub BTNpesquisar_Click(sender As Object, e As EventArgs) Handles BTNpesquisar.Click
        TXTnome.Enabled = True
        TXTnome.Focus()
        BTNlocalizar.Enabled = True
        BTNnovoregistro.Enabled = False
        BTNcancelar.Enabled = True
    End Sub

    Private Sub BTNlocalizar_Click(sender As Object, e As EventArgs) Handles BTNlocalizar.Click
        bancodedados = "Data Source=" & Application.StartupPath & "\DBsistema.db"
        Dim SQliteCon As New SQLiteConnection(bancodedados)
        Try
            SQliteCon.Open()
            Dim selectCliente As String = "SELECT * FROM TBcliente WHERE nomecli = @vnomecli"
            Dim cmd As New SQLiteCommand(selectCliente, SQliteCon)
            cmd.Parameters.AddWithValue("@vnomecli", TXTnome.Text)
            Dim registro As SQLiteDataReader = cmd.ExecuteReader()
            If registro.HasRows = True Then
                While (registro.Read())
                    TXTemail.Text = registro("emailcli").ToString()
                    TXTcelular.Text = registro("celularcli").ToString()
                    BTNalterar.Enabled = True
                    BTNcancelar.Enabled = True
                    TXTnome.Enabled = False
                    BTNpesquisar.Enabled = True
                    BTNdeletar.Enabled = True
                End While
            Else

                MsgBox("Cliente não encontrado.", MsgBoxStyle.Information, "Sistema")
                BTNalterar.Enabled = False
                BTNcancelar.Enabled = True
                BTNpesquisar.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Erro ao pesquisar o Banco de Dados " & ex.Message, MsgBoxStyle.Critical, "Sistema")
        End Try
        SQliteCon.Close()
    End Sub

    Private Sub BTNalterar_Click(sender As Object, e As EventArgs) Handles BTNalterar.Click
        BTNgravaralteracao.Enabled = True
        TXTnome.Enabled = True
        TXTemail.Enabled = True
        TXTcelular.Enabled = True
    End Sub
End Class
