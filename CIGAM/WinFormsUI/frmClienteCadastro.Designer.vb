<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClienteCadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClienteCadastro))
        date_nascimento = New DateTimePicker()
        tbx_nome = New TextBox()
        tbx_cpf = New TextBox()
        tbx_codigo = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        btnSalvar = New Button()
        GroupBox2 = New GroupBox()
        btnExcluir = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' date_nascimento
        ' 
        date_nascimento.Format = DateTimePickerFormat.Short
        date_nascimento.Location = New Point(86, 130)
        date_nascimento.Name = "date_nascimento"
        date_nascimento.Size = New Size(118, 23)
        date_nascimento.TabIndex = 4
        ' 
        ' tbx_nome
        ' 
        tbx_nome.Location = New Point(72, 100)
        tbx_nome.MaxLength = 100
        tbx_nome.Name = "tbx_nome"
        tbx_nome.Size = New Size(308, 23)
        tbx_nome.TabIndex = 3
        ' 
        ' tbx_cpf
        ' 
        tbx_cpf.Location = New Point(72, 70)
        tbx_cpf.MaxLength = 11
        tbx_cpf.Name = "tbx_cpf"
        tbx_cpf.Size = New Size(132, 23)
        tbx_cpf.TabIndex = 2
        ' 
        ' tbx_codigo
        ' 
        tbx_codigo.Location = New Point(72, 41)
        tbx_codigo.Name = "tbx_codigo"
        tbx_codigo.Size = New Size(58, 23)
        tbx_codigo.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(17, 136)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 15)
        Label5.TabIndex = 13
        Label5.Text = "Data Nasc:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 73)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 12
        Label4.Text = "CPF:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 15)
        Label2.TabIndex = 11
        Label2.Text = "Código:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 15)
        Label1.TabIndex = 18
        Label1.Text = "Nome:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(date_nascimento)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(tbx_nome)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(tbx_cpf)
        GroupBox1.Controls.Add(tbx_codigo)
        GroupBox1.Location = New Point(6, 7)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(642, 355)
        GroupBox1.TabIndex = 19
        GroupBox1.TabStop = False
        GroupBox1.Text = "Informações"
        ' 
        ' btnSalvar
        ' 
        btnSalvar.Location = New Point(6, 23)
        btnSalvar.Name = "btnSalvar"
        btnSalvar.Size = New Size(90, 56)
        btnSalvar.TabIndex = 5
        btnSalvar.Text = "Salvar"
        btnSalvar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnExcluir)
        GroupBox2.Controls.Add(btnSalvar)
        GroupBox2.Location = New Point(654, 7)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(103, 355)
        GroupBox2.TabIndex = 20
        GroupBox2.TabStop = False
        ' 
        ' btnExcluir
        ' 
        btnExcluir.Location = New Point(7, 85)
        btnExcluir.Name = "btnExcluir"
        btnExcluir.Size = New Size(90, 56)
        btnExcluir.TabIndex = 6
        btnExcluir.Text = "Excluir"
        btnExcluir.UseVisualStyleBackColor = True
        ' 
        ' frmClienteCadastro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(769, 365)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmClienteCadastro"
        Text = "Cadastro de Clientes"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents date_nascimento As DateTimePicker
    Friend WithEvents tbx_nome As TextBox
    Friend WithEvents tbx_cpf As TextBox
    Friend WithEvents tbx_codigo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSalvar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnExcluir As Button
End Class
