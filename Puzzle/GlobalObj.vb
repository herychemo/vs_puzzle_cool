Public Class GlobalObj

    'esta variable es para guardar temporalmente el nombre del usuario
    Public Shared user_name As String = ""

    'aqui se guarda la lista de usuarios que han jugado
    Public Shared users_list As List(Of User) = New List(Of User)

    'este metodo se encarga deagregar un nuevo usuario, y ordenar la lista, segun el tiempo que hayan usado para armar el puzzle
    Public Shared Sub Add_User(ByRef user As User)
        users_list.Add(user) 'agrega usuario
        users_list = users_list.OrderBy(Function(x) x.seconds).ToList() ' ordena lista
        'lista es igual a lista, ordenada en base a los segundos.
    End Sub

End Class
