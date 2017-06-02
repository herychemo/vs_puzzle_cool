Public Class User

    Public Property name As String
    Public Property seconds As Integer

    Public Sub New(ByRef name As String, ByRef seconds As Integer)
        Me.name = name
        Me.seconds = seconds
    End Sub

End Class
