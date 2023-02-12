Public Class Login_Menu
    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        txtUsername.Text = ""
    End Sub

    Private Sub txtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
        txtPassword.Text = ""
    End Sub

    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        If txtPassword.Text = "admin" And txtUsername.Text = "admin" Then
            pnLogin.Visible = False
            pnMenu.Visible = True
        ElseIf txtPassword.Text = "" And txtUsername.Text = "" Then
            MsgBox("Vui lòng nhập Username và Password!")
        ElseIf txtUsername.Text = "" Then
            MsgBox("Vui lòng nhập Username!")
        ElseIf txtPassword.Text = "" Then
            MsgBox("Vui lòng nhập Password!")
        Else
            MsgBox("Đăng Nhập thất bại!")
        End If
    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Dim Msg As Integer
        Msg = MsgBox("Bạn có muốn thoát chương trình không?", vbYesNo + vbExclamation, "Exit")
        If (Msg = vbYes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub btLogout_Click(sender As Object, e As EventArgs) Handles btLogout.Click
        Dim Msg As Integer
        Msg = MsgBox("Bạn có muốn đăng xuất không?", vbYesNo + vbExclamation, "Logout")
        If (Msg = vbYes) Then
            pnLogin.Visible = True
            pnMenu.Visible = False
            txtPassword.Text = ""
            txtUsername.Text = ""
        End If

    End Sub

    Private Sub btExit2_Click(sender As Object, e As EventArgs) Handles btExit2.Click
        Dim Msg As Integer
        Msg = MsgBox("Bạn có muốn thoát chương trình không?", vbYesNo + vbExclamation, "Exit")
        If (Msg = vbYes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub btQLSV_Click(sender As Object, e As EventArgs) Handles btQLSV.Click
        QLSV.ShowDialog()

    End Sub

    Private Sub btK_MH_Click(sender As Object, e As EventArgs) Handles btK_MH.Click
        QLDuLieu.ShowDialog()
    End Sub
End Class
