Public Class GlobalObj

    Public Shared user_name As String = ""

    Public Shared users_list As List(Of User) = New List(Of User)

    Public Shared Sub Add_User(ByRef user As User)
        users_list.Add(user)
        users_list = users_list.OrderBy(Function(x) x.seconds).ToList()
    End Sub

End Class
