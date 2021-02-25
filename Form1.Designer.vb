<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMcadcliente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTNnovoregistro = New System.Windows.Forms.Button()
        Me.BTNInserir = New System.Windows.Forms.Button()
        Me.BTNpesquisar = New System.Windows.Forms.Button()
        Me.BTNlocalizar = New System.Windows.Forms.Button()
        Me.BTNalterar = New System.Windows.Forms.Button()
        Me.BTNgravaralteracao = New System.Windows.Forms.Button()
        Me.BTNdeletar = New System.Windows.Forms.Button()
        Me.BTNcancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTnome = New System.Windows.Forms.TextBox()
        Me.TXTemail = New System.Windows.Forms.TextBox()
        Me.TXTcelular = New System.Windows.Forms.TextBox()
        Me.BTNsair = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTNnovoregistro
        '
        Me.BTNnovoregistro.Location = New System.Drawing.Point(128, 224)
        Me.BTNnovoregistro.Name = "BTNnovoregistro"
        Me.BTNnovoregistro.Size = New System.Drawing.Size(86, 42)
        Me.BTNnovoregistro.TabIndex = 0
        Me.BTNnovoregistro.Text = "Novo cadastro"
        Me.BTNnovoregistro.UseVisualStyleBackColor = True
        '
        'BTNInserir
        '
        Me.BTNInserir.Location = New System.Drawing.Point(128, 267)
        Me.BTNInserir.Name = "BTNInserir"
        Me.BTNInserir.Size = New System.Drawing.Size(86, 42)
        Me.BTNInserir.TabIndex = 1
        Me.BTNInserir.Text = "Inserir"
        Me.BTNInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BTNInserir.UseVisualStyleBackColor = True
        '
        'BTNpesquisar
        '
        Me.BTNpesquisar.Location = New System.Drawing.Point(220, 224)
        Me.BTNpesquisar.Name = "BTNpesquisar"
        Me.BTNpesquisar.Size = New System.Drawing.Size(86, 42)
        Me.BTNpesquisar.TabIndex = 2
        Me.BTNpesquisar.Text = "Pesquisar"
        Me.BTNpesquisar.UseVisualStyleBackColor = True
        '
        'BTNlocalizar
        '
        Me.BTNlocalizar.Location = New System.Drawing.Point(220, 267)
        Me.BTNlocalizar.Name = "BTNlocalizar"
        Me.BTNlocalizar.Size = New System.Drawing.Size(86, 42)
        Me.BTNlocalizar.TabIndex = 3
        Me.BTNlocalizar.Text = "Localizar"
        Me.BTNlocalizar.UseVisualStyleBackColor = True
        '
        'BTNalterar
        '
        Me.BTNalterar.Location = New System.Drawing.Point(312, 224)
        Me.BTNalterar.Name = "BTNalterar"
        Me.BTNalterar.Size = New System.Drawing.Size(86, 42)
        Me.BTNalterar.TabIndex = 4
        Me.BTNalterar.Text = "Alterar"
        Me.BTNalterar.UseVisualStyleBackColor = True
        '
        'BTNgravaralteracao
        '
        Me.BTNgravaralteracao.Location = New System.Drawing.Point(312, 267)
        Me.BTNgravaralteracao.Name = "BTNgravaralteracao"
        Me.BTNgravaralteracao.Size = New System.Drawing.Size(86, 42)
        Me.BTNgravaralteracao.TabIndex = 5
        Me.BTNgravaralteracao.Text = "Gravar Alteração"
        Me.BTNgravaralteracao.UseVisualStyleBackColor = True
        '
        'BTNdeletar
        '
        Me.BTNdeletar.Location = New System.Drawing.Point(407, 224)
        Me.BTNdeletar.Name = "BTNdeletar"
        Me.BTNdeletar.Size = New System.Drawing.Size(86, 42)
        Me.BTNdeletar.TabIndex = 6
        Me.BTNdeletar.Text = "Deletar"
        Me.BTNdeletar.UseVisualStyleBackColor = True
        '
        'BTNcancelar
        '
        Me.BTNcancelar.Location = New System.Drawing.Point(407, 267)
        Me.BTNcancelar.Name = "BTNcancelar"
        Me.BTNcancelar.Size = New System.Drawing.Size(86, 42)
        Me.BTNcancelar.TabIndex = 7
        Me.BTNcancelar.Text = "Cancelar"
        Me.BTNcancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nome completo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "E-mail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Telefone "
        '
        'TXTnome
        '
        Me.TXTnome.Location = New System.Drawing.Point(69, 79)
        Me.TXTnome.Name = "TXTnome"
        Me.TXTnome.Size = New System.Drawing.Size(488, 20)
        Me.TXTnome.TabIndex = 11
        '
        'TXTemail
        '
        Me.TXTemail.Location = New System.Drawing.Point(69, 121)
        Me.TXTemail.Name = "TXTemail"
        Me.TXTemail.Size = New System.Drawing.Size(488, 20)
        Me.TXTemail.TabIndex = 12
        '
        'TXTcelular
        '
        Me.TXTcelular.Location = New System.Drawing.Point(69, 168)
        Me.TXTcelular.Name = "TXTcelular"
        Me.TXTcelular.Size = New System.Drawing.Size(227, 20)
        Me.TXTcelular.TabIndex = 13
        '
        'BTNsair
        '
        Me.BTNsair.Location = New System.Drawing.Point(561, 273)
        Me.BTNsair.Name = "BTNsair"
        Me.BTNsair.Size = New System.Drawing.Size(75, 42)
        Me.BTNsair.TabIndex = 14
        Me.BTNsair.Text = "Sair"
        Me.BTNsair.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(215, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Cadastro de Clientes"
        '
        'FRMcadcliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 330)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BTNsair)
        Me.Controls.Add(Me.TXTcelular)
        Me.Controls.Add(Me.TXTemail)
        Me.Controls.Add(Me.TXTnome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNcancelar)
        Me.Controls.Add(Me.BTNdeletar)
        Me.Controls.Add(Me.BTNgravaralteracao)
        Me.Controls.Add(Me.BTNalterar)
        Me.Controls.Add(Me.BTNlocalizar)
        Me.Controls.Add(Me.BTNpesquisar)
        Me.Controls.Add(Me.BTNInserir)
        Me.Controls.Add(Me.BTNnovoregistro)
        Me.Name = "FRMcadcliente"
        Me.Text = "Cadastro de usuário"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNnovoregistro As Button
    Friend WithEvents BTNInserir As Button
    Friend WithEvents BTNpesquisar As Button
    Friend WithEvents BTNlocalizar As Button
    Friend WithEvents BTNalterar As Button
    Friend WithEvents BTNgravaralteracao As Button
    Friend WithEvents BTNdeletar As Button
    Friend WithEvents BTNcancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTnome As TextBox
    Friend WithEvents TXTemail As TextBox
    Friend WithEvents TXTcelular As TextBox
    Friend WithEvents BTNsair As Button
    Friend WithEvents Label4 As Label
End Class
