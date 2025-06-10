Public Class frmClientePesquisa

    ' Instância do serviço que vai lidar com a lógica de cliente
    Private _clienteService As ClienteService

    ' Evento que roda quando o formulário carrega
    Private Sub frmClientePesquisa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Cria o repositório e o serviço para usar na busca dos clientes
        Dim repo As New ClienteRepository()
        _clienteService = New ClienteService(repo)
        dtgv_clientes.AutoGenerateColumns = True

        ' Realiza a busca ao iniciar a interface
        dtgv_clientes.DataSource = _clienteService.ListarTodos()

    End Sub

    ' Evento que roda quando o botão buscar é clicado
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        ' Pega o texto dos campos nome e cpf da interface
        Dim nome = tbx_nome.Text
        Dim cpf = tbx_cpf.Text

        ' Usa o serviço para buscar os clientes e já mostra o resultado na grid
        dtgv_clientes.DataSource = _clienteService.Buscar(nome, cpf)

    End Sub

    ' Evento que roda quando o botão novo é clicado
    Private Sub btn_novo_Click(sender As Object, e As EventArgs) Handles btn_novo.Click
        ' Cria o formulário de cadastro passando o mesmo clienteService que já existe aqui
        Dim frmCadastro As New frmClienteCadastro(_clienteService)

        ' Abre o formulário de cadastro como modal (pra bloquear até fechar)
        frmCadastro.tbx_codigo.Text = "0"
        frmCadastro.tbx_codigo.ReadOnly = True
        frmCadastro.btnExcluir.Enabled = False
        frmCadastro.ShowDialog()

        ' Depois que fechar o cadastro, atualiza a grid pra refletir as mudanças
        Dim nome = tbx_nome.Text
        Dim cpf = tbx_cpf.Text
        dtgv_clientes.DataSource = _clienteService.Buscar(nome, cpf)

    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs)
        ' Cria o formulário de cadastro passando o mesmo clienteService que já existe aqui
        Dim frmCadastro As New frmClienteCadastro(_clienteService)

        ' Abre o formulário de cadastro como modal (pra bloquear até fechar)
        frmCadastro.tbx_codigo.Text = dtgv_clientes.CurrentRow.Cells("CODIGO").Value.ToString
        frmCadastro.tbx_cpf.Text = dtgv_clientes.CurrentRow.Cells("CPF").Value.ToString
        frmCadastro.tbx_nome.Text = dtgv_clientes.CurrentRow.Cells("NOME").Value.ToString
        frmCadastro.date_nascimento.Text = dtgv_clientes.CurrentRow.Cells("DATA_NASCIMENTO").Value.ToString

        frmCadastro.tbx_codigo.ReadOnly = True
        frmCadastro.btnExcluir.Enabled = True
        frmCadastro.ShowDialog

        ' Depois que fechar o cadastro, atualiza a grid pra refletir as mudanças
        Dim nome = tbx_nome.Text
        Dim cpf = tbx_cpf.Text
        dtgv_clientes.DataSource = _clienteService.Buscar(nome, cpf)

    End Sub

    Private Sub dtgv_clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_clientes.CellContentClick

        If e.ColumnIndex = dtgv_clientes.Columns("EDIT").Index AndAlso e.RowIndex >= 0 Then
            ' Obtem os dados da linha clicada
            Dim row As DataGridViewRow = dtgv_clientes.Rows(e.RowIndex)

            ' Cria e preenche o formulário de edição
            Dim frmCadastro As New frmClienteCadastro(_clienteService)
            frmCadastro.tbx_codigo.Text = row.Cells("CODIGO").Value.ToString()
            frmCadastro.tbx_nome.Text = row.Cells("NOME").Value.ToString()
            frmCadastro.tbx_cpf.Text = row.Cells("CPF").Value.ToString()
            frmCadastro.date_nascimento.Text = row.Cells("DATA_NASCIMENTO").Value.ToString()

            frmCadastro.tbx_codigo.ReadOnly = True
            frmCadastro.btnExcluir.Enabled = True
            frmCadastro.ShowDialog()

            ' Recarrega a grid depois da edição
            Dim nome = tbx_nome.Text
            Dim cpf = tbx_cpf.Text
            dtgv_clientes.DataSource = _clienteService.Buscar(nome, cpf)
        End If

    End Sub
End Class
