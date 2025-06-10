' Classe do formulário de cadastro de cliente
Public Class frmClienteCadastro
    ' Declaração de um campo privado para o serviço de cliente
    Private _clienteService As ClienteService

    ' Construtor da classe, recebe o serviço de cliente por injeção de dependência
    Public Sub New(clienteService As ClienteService)
        InitializeComponent() ' Inicializa os componentes do formulário
        _clienteService = clienteService ' Atribui o serviço recebido à variável privada
    End Sub

    ' Evento do botão "Salvar"
    Private Sub btnSalvar_Click_1(sender As Object, e As EventArgs) Handles btnSalvar.Click
        ' Cria uma nova instância de Cliente
        Dim cliente As New Cliente()
        ' Preenche os dados do cliente com as informações dos campos do formulário
        cliente.CODIGO = Integer.Parse(tbx_codigo.Text)
        cliente.NOME = tbx_nome.Text
        cliente.CPF = tbx_cpf.Text
        cliente.DATA_NASCIMENTO = date_nascimento.Value.ToShortDateString

        ' Chama o método de serviço para salvar o cliente
        _clienteService.Salvar(cliente)

        ' Exibe mensagem de sucesso
        MessageBox.Show("Cliente salvo com sucesso!")
        Me.Close()

    End Sub

    ' Evento do botão "Excluir"
    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        ' Mostra uma caixa de diálogo perguntando se o usuário realmente quer excluir
        Dim resultado As DialogResult = MessageBox.Show(
            "Tem certeza de que deseja excluir este cliente?",
            "Confirmação de Exclusão",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        ' Se o usuário clicar em "Sim", a exclusão é realizada
        If resultado = DialogResult.Yes Then
            ' Cria uma nova instância de Cliente apenas com o código
            Dim cliente As New Cliente()
            cliente.CODIGO = Integer.Parse(tbx_codigo.Text)

            ' Chama o método de serviço para remover o cliente
            _clienteService.Remover(cliente.CODIGO)

            ' Exibe mensagem de sucesso
            MessageBox.Show("Cliente excluído com sucesso!")

            ' Fecha o formulário
            Me.Close()
        End If
    End Sub

End Class
