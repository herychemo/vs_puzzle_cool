Public Class User

    'Datos del usuario, nombre y segundos, en formato propiedad.

    Public Property name As String
    Public Property seconds As Integer

    Public Sub New(ByRef name As String, ByRef seconds As Integer)
        Me.name = name
        Me.seconds = seconds    ' en el constructor llenamos los datos del usuario
    End Sub

End Class
