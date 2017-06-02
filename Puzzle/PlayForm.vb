Public Class PlayForm

    Private ctrls_imgs As List(Of PictureBox) = New List(Of PictureBox)
    Private images As List(Of String) = New List(Of String)
    Private images_random As List(Of String) = New List(Of String)

    Private start_time As Date


    Private temp_indexes As List(Of Integer) = New List(Of Integer)


    Private Sub PlayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        GlobalObj.users_list.ToArray()

        fill_images()

        fill_ctrls()

        MsgBox("Start Playing!")

        start_time = DateTime.Now

    End Sub

    Private Sub fill_images()
        images_random.Clear()

        Dim images_temp As List(Of String) = images.Select(Function(x) x.Clone()).Cast(Of String).ToList()

        While images_temp.Count > 0
            Dim next_i = CInt(Math.Ceiling(Rnd() * (images_temp.Count - 1))) + 0
            Dim str = images_temp(next_i)
            images_random.Add(str)
            images_temp.RemoveAt(next_i)
        End While

        If Are_Lists_Equal() Then
            fill_images()
        End If

    End Sub
    Private Sub fill_ctrls()
        For i As Integer = 0 To images_random.Count - 1 Step 1
            ctrls_imgs(i).ImageLocation = images_random(i)
        Next
    End Sub

    Private Function Are_Lists_Equal() As Boolean

        For i As Integer = 0 To images.Count - 1 Step 1

            If Not images(i).Equals(images_random(i)) Then
                Return False
            End If

        Next

        Return True

    End Function

    Private Sub pb_0_0_Click(sender As Object, e As EventArgs) Handles pb_0_0.Click, pb_0_1.Click, pb_0_2.Click, pb_0_3.Click, pb_1_0.Click, pb_1_1.Click, pb_1_2.Click, pb_1_3.Click, pb_2_0.Click, pb_2_1.Click, pb_2_2.Click, pb_2_3.Click

        Dim c_index = ctrls_imgs.IndexOf(sender)

        temp_indexes.Add(c_index)

        If temp_indexes.Count = 2 Then

            Dim tmp = images_random(temp_indexes(0))
            images_random(temp_indexes(0)) = images_random(temp_indexes(1))
            images_random(temp_indexes(1)) = tmp

            temp_indexes.Clear()

            fill_ctrls()

            If Are_Lists_Equal() Then
                MsgBox("You Do It !")

                Dim total_time = DateTime.Now - start_time

                MsgBox("Congratulations " & GlobalObj.user_name & ", you do it, and you took just " & total_time.Seconds & " seconds!")

                GlobalObj.Add_User(New User(GlobalObj.user_name, total_time.Seconds))

                quit_here()

            End If

        End If

    End Sub

    Private Sub quit_here()

        Dim menu As Menu = New Menu
        menu.Show()
        Me.Close()
    End Sub

    Private Sub quit_btn_Click(sender As Object, e As EventArgs) Handles quit_btn.Click
        quit_here()
    End Sub

End Class