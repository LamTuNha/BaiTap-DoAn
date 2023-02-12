Public Class QLSV

    Private Sub loaddata()
        OleDbDataAdapter1.Fill(DataSet5)
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

    Private Sub QLSV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbTK()
        loaddata()
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "DELETE FROM SV
WHERE  MaSV = N'" & txtMaSV.Text & "' "
            OleDbInsertCommand1.CommandText = sql
            OleDbInsertCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet5.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        Dim gt As String = ""

        If rbNam.Checked = True Then
            gt = "Nam"
        Else
            rbNu.Checked = True
            gt = "Nu"
        End If
        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO SV
                  (MaKhoa, Lop, MaSV, TenSV, NgaySinh, GioiTinh, DiaChi, MaMH)
VALUES (N'" & cbMaKhoa.Text & "',N'" & cbLop.Text & "',N'" & txtMaSV.Text & "',N'" & txtHoTenSV.Text & "',N'" & dtpNgaySinh.Text & "',N'" & gt & "',N'" & txtDiaChi.Text & "',N'" & cbMaMH.Text & "')"
            OleDbInsertCommand1.CommandText = sql
            OleDbInsertCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet5.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btCapNhat_Click(sender As Object, e As EventArgs) Handles btCapNhat.Click
        Dim gt As String = ""

        If rbNam.Checked = True Then
            gt = "Nam"
        Else
            rbNu.Checked = True
            gt = "Nu"
        End If
        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE SV
SET         MaKhoa = N'" & cbMaKhoa.Text & "', Lop = N'" & cbLop.Text & "', MaSV = N'" & txtMaSV.Text & "', TenSV = N'" & txtHoTenSV.Text & "', NgaySinh = N'" & dtpNgaySinh.Text & "', GioiTinh = N'" & gt & "', DiaChi = N'" & txtDiaChi.Text & "', MaMH = N'" & cbMaMH.Text & "'
WHERE  MaSV = N'" & txtMaSV.Text & "'"
            OleDbInsertCommand1.CommandText = sql
            OleDbInsertCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet5.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cbTK()
        cbTimKiem.Items.Add("")
        cbTimKiem.Items.Add("MaSV:")
        cbTimKiem.Items.Add("Khoa:")
        cbTimKiem.Items.Add("Lop:")
        cbTimKiem.Items.Add("Mon Hoc:")
    End Sub
End Class