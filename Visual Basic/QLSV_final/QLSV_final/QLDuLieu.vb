Public Class QLDuLieu
    Private Sub btMH_Click(sender As Object, e As EventArgs) Handles btMH.Click
        pnMH.Visible = True
        pnKhoa.Visible = False
        pnLop.Visible = False

    End Sub

    Private Sub btDMKhoa_Click(sender As Object, e As EventArgs) Handles btKhoa.Click
        pnMH.Visible = False
        pnKhoa.Visible = True
        pnLop.Visible = False
    End Sub

    Private Sub btLop_Click(sender As Object, e As EventArgs) Handles btLop.Click
        pnMH.Visible = False
        pnKhoa.Visible = False
        pnLop.Visible = True
    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Dim Msg As Integer
        Msg = MsgBox("Bạn có muốn thoát chương trình không?", vbYesNo + vbExclamation, "Exit")
        If (Msg = vbYes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub btMenu_Click(sender As Object, e As EventArgs) Handles btMenu.Click
        Me.Close()
    End Sub

    Private Sub loaddata()
        OleDbDataAdapter1.Fill(DataSet2)
        OleDbDataAdapter2.Fill(DataSet3)
        OleDbDataAdapter3.Fill(DataSet4)
    End Sub

    Private Sub QLDuLieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub btThemMH_Click(sender As Object, e As EventArgs) Handles btThemMH.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO MH
                  (MaMH, TenMH, TinChi)
VALUES (N'" & txtMaMH.Text & "',N'" & txtTenMH.Text & "',N'" & txtTinChi.Text & "')"
            OleDbInsertCommand1.CommandText = sql
            OleDbInsertCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet2.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btCapNhatMH_Click(sender As Object, e As EventArgs) Handles btCapNhatMH.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE MH
SET          MaMH = N'" & txtMaMH.Text & "', TenMH = N'" & txtTenMH.Text & "', TinChi = N'" & txtTinChi.Text & "'
WHERE  MaMH = N'" & txtMaMH.Text & "'"
            OleDbInsertCommand1.CommandText = sql
            OleDbInsertCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet2.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btXoaMH_Click(sender As Object, e As EventArgs) Handles btXoaMH.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "DELETE FROM MH
WHERE  MaMH = N'" & txtMaMH.Text & "' "
            OleDbInsertCommand1.CommandText = sql
            OleDbInsertCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet2.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btThemL_Click(sender As Object, e As EventArgs) Handles btThemL.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO Lop
                  (Lop)
VALUES (N'" & txtLop.Text & "')"
            OleDbInsertCommand2.CommandText = sql
            OleDbInsertCommand2.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet3.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btXoaL_Click(sender As Object, e As EventArgs) Handles btXoaL.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "DELETE FROM Lop
WHERE  (Lop = N'" & txtLop.Text & "' )"
            OleDbInsertCommand2.CommandText = sql
            OleDbInsertCommand2.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet3.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO Khoa
                  (MaKhoa, TenKhoa)
VALUES (N'" & txtMaKhoa.Text & "',N'" & txtTenKhoa.Text & "')"
            OleDbInsertCommand3.CommandText = sql
            OleDbInsertCommand3.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet4.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btCapNhat_Click(sender As Object, e As EventArgs) Handles btCapNhat.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE Khoa
SET          MaKhoa = N'" & txtMaKhoa.Text & "', TenKhoa = N'" & txtTenKhoa.Text & "'
WHERE  MaKhoa = N'" & txtMaKhoa.Text & "'"
            OleDbInsertCommand3.CommandText = sql
            OleDbInsertCommand3.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet4.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "DELETE FROM Khoa
WHERE  MaKhoa = N'" & txtMaKhoa.Text & "' "
            OleDbInsertCommand3.CommandText = sql
            OleDbInsertCommand3.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet4.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class