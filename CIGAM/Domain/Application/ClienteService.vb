' Classe responsável por centralizar as regras de negócio relacionadas ao Cliente.
' Atua como uma camada de serviço entre a interface gráfica (Forms) e o repositório (acesso ao banco).
Public Class ClienteService

    ' Dependência do repositório de cliente (injeção de dependência via construtor).
    Private ReadOnly _repo As IClienteRepository

    ' Construtor da classe, exige uma implementação do IClienteRepository.
    Public Sub New(repo As IClienteRepository)
        _repo = repo
    End Sub

    ' Retorna uma lista com todos os clientes cadastrados no banco de dados.
    Public Function ListarTodos() As List(Of Cliente)
        Return _repo.BuscarTodos()
    End Function

    ' Busca clientes no banco de dados filtrando por nome e/ou CPF.
    Public Function Buscar(nome As String, cpf As String) As List(Of Cliente)
        Return _repo.BuscarPorNomeOuCPF(nome, cpf)
    End Function

    ' Salva um cliente no banco.
    ' Se o código for 0, considera um novo cliente e insere.
    ' Caso contrário, atualiza um cliente existente.
    Public Sub Salvar(cliente As Cliente)
        If cliente.Codigo = 0 Then
            _repo.Inserir(cliente)
        Else
            _repo.Atualizar(cliente)
        End If
    End Sub

    ' Remove um cliente do banco de dados com base no código.
    Public Sub Remover(codigo As Integer)
        _repo.Excluir(codigo)
    End Sub

End Class
