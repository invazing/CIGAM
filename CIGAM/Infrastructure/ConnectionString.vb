' Módulo que guarda a string de conexão com o banco de dados Access
Public Module ConnectionString

    ' String de conexão pronta para usar com o banco Access (.accdb)
    ' Usa o provedor OLEDB da Microsoft e aponta para o caminho do arquivo do banco
    Public ReadOnly StringConexao As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\manel\source\repos\CIGAM\CIGAM\Database.accdb;"

End Module
