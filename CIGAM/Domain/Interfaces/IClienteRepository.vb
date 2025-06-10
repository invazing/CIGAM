' Interface que define os métodos para manipular dados de clientes
Public Interface IClienteRepository

    ' Retorna uma lista com todos os clientes cadastrados
    Function BuscarTodos() As List(Of Cliente)

    ' Busca clientes pelo nome ou CPF, retornando uma lista com os resultados
    Function BuscarPorNomeOuCPF(nome As String, cpf As String) As List(Of Cliente)

    ' Insere um novo cliente no repositório
    Sub Inserir(cliente As Cliente)

    ' Atualiza os dados de um cliente já existente
    Sub Atualizar(cliente As Cliente)

    ' Remove um cliente com base no código dele
    Sub Excluir(codigo As Integer)

End Interface
