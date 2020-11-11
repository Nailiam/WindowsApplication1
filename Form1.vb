Public Class Form1
    Private Property No_Pelanggan As Object

    Sub KosongkanForm()
        txt_Nopel.Text = ""
        txt_Noktp.Text = ""
        txt_Nama.Text = ""
        txt_Alamat.Text = ""
        txt_Notelepon.Text = ""
        txt_Nopel.Focus()
    End Sub

    Sub MatikanForm()
        txt_Nopel.Enabled = False
        txt_Noktp.Enabled = False
        txt_Nama.Enabled = False
        txt_Alamat.Enabled = False
        txt_Notelepon.Enabled = False
    End Sub

    Sub HidupkanForm()
        txt_Nopel.Enabled = True
        txt_Noktp.Enabled = True
        txt_Nama.Enabled = True
        txt_Alamat.Enabled = True
        txt_Notelepon.Enabled = True
    End Sub

    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select  * From Pelanggan ", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles Input_Data_Pelanggan.Enter
        Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnInput_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInput.Click
        Call HidupkanForm()
        Call KosongkanForm()
    End Sub


    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Call MatikanForm()
        Call KosongkanForm()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If txt_Nopel.Text = "" Or txt_Noktp.Text = "" Or txt_Nama.Text =
         "" Or txt_Alamat.Text = "" Or txt_Notelepon.Text = "" Then
            MsgBox("Data Pelanggan Belum Lengkap")
            Exit Sub

        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Pelanggan where No.Pelanggan='" & txt_Nopel.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()

            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Menu values ('" & txt_Nopel.Text &
       "', '" & txt_Noktp.Text & "', '" & txt_Nama.Text & "','" &
       txt_Alamat.Text & "','" & txt_Notelepon.Text & "')"
                CMD = New OleDb.OleDbCommand(simpan, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("Input Data Sukses")
            Else
                MsgBox("Data Sudah Ada")
            End If
            Call MatikanForm()
            Call KosongkanForm()
            Call TampilkanData()
        End If
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        On Error Resume Next
        txt_Nopel.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        txt_Noktp.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        txt_Nama.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        txt_Alamat.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        txt_Notelepon.Text = DGV.Rows(e.RowIndex).Cells(4).Value

        Call HidupkanForm()
        txt_Nopel.Enabled = False
    End Sub

    Private Sub btnedit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        If txt_Nopel.Text = "" Or txt_Noktp.Text = "" Or txt_Nama.Text = "" Or txt_Alamat.Text = "" Or txt_Notelepon.Text = "" Then
            MsgBox("Data Menu Belum Lengkap")
            Exit Sub

        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" update Pelanggan set No.Ktp ='" & txt_Noktp.Text & "', Nama_Pelanggan = '" &
   txt_Nama.Text & "', Alamat = '" & txt_Alamat.Text & "',  No.Telepon = '" &
   txt_Notelepon.Text & "'  where No.Ktp ='" & txt_Nopel.Text & "'", Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")

        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()

    End Sub

    Private Sub btndelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If txt_Nopel.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub

        Else
            If MessageBox.Show("Are you sure to delete this data ? ",
   "Konfirmasi", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then

                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Pelanggan where No_Pelanggan ='" & txt_Nopel.Text & "'", Conn)
                DM = CMD.ExecuteReader
                MsgBox("Hapus Data Berhasil")
                Call MatikanForm()
                Call KosongkanForm()
                Call TampilkanData()
            Else
                Call KosongkanForm()
                Call TampilkanData()
            End If
        End If
    End Sub

    Private Sub btn_FormMobil_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_FormMobil.Click
        Form_Mobil.Show()
    End Sub
End Class


