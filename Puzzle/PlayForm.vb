Public Class PlayForm

    'lista de controles, en la cual guardamos todos los PictureBox
    Private ctrls_imgs As List(Of PictureBox) = New List(Of PictureBox)

    'Lista de imagenes, en la cual se guardan todas las imagenes en el orden correcto
    Private images As List(Of String) = New List(Of String)

    'lista de imagenes random, se almacenan los datos actuales de juego,
    Private images_random As List(Of String) = New List(Of String)

    'se almacena la hora a la que comienza el juego
    Private start_time As Date

    'se utiliza para saber que imagenes cambiar de lugar
    Private temp_indexes As List(Of Integer) = New List(Of Integer)


    Private Sub PlayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'cuando se inicie el programa, primero hay que meter todos los controles PictureBox, a nuestra lista de controles
        ctrls_imgs.Add(pb_0_0)
        ctrls_imgs.Add(pb_0_1)
        ctrls_imgs.Add(pb_0_2)
        ctrls_imgs.Add(pb_0_3)
        ctrls_imgs.Add(pb_1_0)
        ctrls_imgs.Add(pb_1_1)
        ctrls_imgs.Add(pb_1_2)
        ctrls_imgs.Add(pb_1_3)
        ctrls_imgs.Add(pb_2_0)
        ctrls_imgs.Add(pb_2_1)
        ctrls_imgs.Add(pb_2_2)
        ctrls_imgs.Add(pb_2_3)

        'Luego hay que traer todas las imagenes en su orden correcto.
        images.Add("D:\Downloads\images\0.png")
        images.Add("D:\Downloads\images\1.png")
        images.Add("D:\Downloads\images\2.png")
        images.Add("D:\Downloads\images\3.png")
        images.Add("D:\Downloads\images\4.png")
        images.Add("D:\Downloads\images\5.png")
        images.Add("D:\Downloads\images\6.png")
        images.Add("D:\Downloads\images\7.png")
        images.Add("D:\Downloads\images\8.png")
        images.Add("D:\Downloads\images\9.png")
        images.Add("D:\Downloads\images\10.png")
        images.Add("D:\Downloads\images\11.png")

        fill_images()       'generamos un orden random de imagenes
        fill_ctrls()        'mostramos el nuevo orden en la interface

        MsgBox("Start Playing!")    'Informamos que le juego va a comenzar.

        start_time = DateTime.Now   'Se obtiene hora actual de inicio de juego

    End Sub

    Private Sub fill_images()
        images_random.Clear()   'Se limpia la lista de imagenes random


        'Se clona la lista de imagenes ordenadas, para poder jugar con ellas sin alterar la lista
        '   que ya tiene el orden correcto, es como trabajar con un respaldo, y que a lista original
        '   No sea modificada.
        Dim images_temp As List(Of String) = images.Select(Function(x) x.Clone()).Cast(Of String).ToList()

        While images_temp.Count > 0     'Mientras la lista temporal de imagenes, aun tenga datos, vamos a iterar
            Dim next_i = CInt(Math.Ceiling(Rnd() * (images_temp.Count - 1))) + 0        '' Se obtiene un numero random, 
            'entre 0, y numero maximo de indice

            Dim str = images_temp(next_i)   'se obtiene una imagen random, y se guarda en la lista random
            images_random.Add(str)
            images_temp.RemoveAt(next_i)    'luego se quita de la lista temporal, para no repetir su asignacion.
        End While

        If Are_Lists_Equal() Then   ' En caso de que la lista, haya quedado ordenada, habra que intentar generar numeros random otra vez, 
            fill_images()
        End If

    End Sub
    Private Sub fill_ctrls()    'Llena los PictureBox, con las imagenes del arreglo
        For i As Integer = 0 To images_random.Count - 1 Step 1
            ctrls_imgs(i).ImageLocation = images_random(i)
        Next
    End Sub

    Private Function Are_Lists_Equal() As Boolean

        For i As Integer = 0 To images.Count - 1 Step 1 ' iteramos, todos los elementos de images
            If Not images(i).Equals(images_random(i)) Then
                Return False    ' si hay alguna diferencia entre las listas, devuelve false
            End If
        Next        ' si no se encontraron diferencias entonces true
        Return True
    End Function

    Private Sub pb_0_0_Click(sender As Object, e As EventArgs) Handles pb_0_0.Click, pb_0_1.Click, pb_0_2.Click, pb_0_3.Click, pb_1_0.Click, pb_1_1.Click, pb_1_2.Click, pb_1_3.Click, pb_2_0.Click, pb_2_1.Click, pb_2_2.Click, pb_2_3.Click
        'este evento es llamado por cualquier click en cualquier imagen.


        Dim c_index = ctrls_imgs.IndexOf(sender)    '   obtenemos el index del elemento seleccionado 
        temp_indexes.Add(c_index)           '   se agrega su indice a la mini lista temporal

        If temp_indexes.Count = 2 Then  ' Si se han agregado dos imtems a la mini lista temporal entonces ejecutamos lo siguiente

            Dim tmp = images_random(temp_indexes(0))    ' Guardamos el dato del primer valor
            images_random(temp_indexes(0)) = images_random(temp_indexes(1)) 'guardamos el segundo valor en el primero
            images_random(temp_indexes(1)) = tmp        ' al segundo valor, ahora le corresponde el valor del primero

            temp_indexes.Clear()    ' se limpia la lista auxiliar

            fill_ctrls()    ' actualizamos las imagenes de la interface.

            If Are_Lists_Equal() Then   ' Si ahora esta ordenada, entonces hacemos lo siguiente
                MsgBox("You Do It !")   ' Mostrar mensaje ganador

                Dim total_time = DateTime.Now - start_time  ' calcular el tiempo que tardo

                'Enviar mensaje de felicitacion con datos del usuario.
                MsgBox("Congratulations " & GlobalObj.user_name & ", you do it, and you took just " & total_time.Seconds & " seconds!")

                'agregar al usuario a la lista de ganadores
                GlobalObj.Add_User(New User(GlobalObj.user_name, total_time.Seconds))

                quit_here() ' salir

            End If

        End If

    End Sub

    Private Sub quit_here()
        'volvemos al menu
        Dim menu As Menu = New Menu
        menu.Show()
        Me.Close()
    End Sub

    Private Sub quit_btn_Click(sender As Object, e As EventArgs) Handles quit_btn.Click
        quit_here()
    End Sub

End Class