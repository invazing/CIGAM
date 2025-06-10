' Classe que representa a entidade Cliente, usada para armazenar os dados de um cliente.
Public Class Cliente

    ' Código identificador do cliente (chave primária no banco de dados).
    Public Property CODIGO As Integer

    ' Nome completo do cliente.
    Public Property NOME As String

    ' CPF do cliente (documento de identificação).
    Public Property CPF As String

    ' Data de nascimento do cliente.
    Public Property DATA_NASCIMENTO As Date

End Class
