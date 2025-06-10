' Importa o namespace necessário para trabalhar com banco de dados Access via OleDb.
Imports System.Data.OleDb

' Classe que implementa a interface IClienteRepository.
' Responsável por acessar o banco de dados e executar as operações de CRUD dos clientes.
Public Class ClienteRepository
    Implements IClienteRepository

    ' Busca todos os clientes cadastrados no banco de dados.
    Public Function BuscarTodos() As List(Of Cliente) Implements IClienteRepository.BuscarTodos
        Dim clientes As New List(Of Cliente)()

        Using conn As New OleDbConnection(ConnectionString.StringConexao)
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT * FROM CLIENTE", conn)

            Using reader As OleDbDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ' Preenche a lista com os dados dos clientes encontrados
                    clientes.Add(New Cliente With {
                        .CODIGO = reader.GetInt32(0),
                        .NOME = reader.GetString(1),
                        .CPF = reader.GetString(2),
                        .DATA_NASCIMENTO = reader.GetDateTime(3)
                    })
                End While
            End Using
        End Using

        Return clientes
    End Function

    ' Busca clientes pelo nome usando LIKE ou pelo CPF.
    Public Function BuscarPorNomeOuCPF(nome As String, cpf As String) As List(Of Cliente) Implements IClienteRepository.BuscarPorNomeOuCPF
        Dim clientes As New List(Of Cliente)()
        Dim sql As String = "SELECT * FROM CLIENTE WHERE 1=1"

        Using conn As New OleDbConnection(ConnectionString.StringConexao)
            conn.Open()

            Dim cmd As New OleDbCommand()
            cmd.Connection = conn

            ' Filtros dinâmicos verificando se os campos estão nulos para usar a regra de NOME ou CPF.
            If Not String.IsNullOrWhiteSpace(nome) Then
                sql &= " AND NOME LIKE @NOME"
                cmd.Parameters.AddWithValue("@NOME", "%" & nome & "%")
            End If

            If Not String.IsNullOrWhiteSpace(cpf) Then
                sql &= " AND CPF LIKE @CPF"
                cmd.Parameters.AddWithValue("@CPF", "%" & cpf & "%")
            End If

            cmd.CommandText = sql
            Using reader As OleDbDataReader = cmd.ExecuteReader()
                While reader.Read()
                    clientes.Add(New Cliente With {
                    .CODIGO = reader.GetInt32(0),
                    .NOME = reader.GetString(1),
                    .CPF = reader.GetString(2),
                    .DATA_NASCIMENTO = reader.GetDateTime(3)
                })
                End While
            End Using
        End Using

        Return clientes
    End Function

    ' Insere um novo cliente no banco de dados.
    Public Sub Inserir(cliente As Cliente) Implements IClienteRepository.Inserir
        Using conn As New OleDbConnection(ConnectionString.StringConexao)
            conn.Open()
            Dim cmd As New OleDbCommand("INSERT INTO CLIENTE (NOME, CPF, DATA_NASCIMENTO) VALUES (@NOME, @CPF, @DATA_NASCIMENTO)", conn)
            cmd.Parameters.AddWithValue("@NOME", cliente.NOME)
            cmd.Parameters.AddWithValue("@CPF", cliente.CPF)
            cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", cliente.DATA_NASCIMENTO)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' Atualiza os dados de um cliente existente no banco.
    Public Sub Atualizar(cliente As Cliente) Implements IClienteRepository.Atualizar
        Using conn As New OleDbConnection(ConnectionString.StringConexao)
            conn.Open()
            Dim cmd As New OleDbCommand("UPDATE CLIENTE SET NOME = @NOME, CPF = @CPF, DATA_NASCIMENTO = @DATA_NASCIMENTO WHERE CODIGO = @CODIGO", conn)
            cmd.Parameters.AddWithValue("@NOME", cliente.NOME)
            cmd.Parameters.AddWithValue("@CPF", cliente.CPF)
            cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", cliente.DATA_NASCIMENTO)
            cmd.Parameters.AddWithValue("@CODIGO", cliente.CODIGO)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' Exclui um cliente do banco de dados com base no código.
    Public Sub Excluir(codigo As Integer) Implements IClienteRepository.Excluir
        Using conn As New OleDbConnection(ConnectionString.StringConexao)
            conn.Open()
            Dim cmd As New OleDbCommand("DELETE FROM CLIENTE WHERE CODIGO = @CODIGO", conn)
            cmd.Parameters.AddWithValue("@CODIGO", codigo)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class
