Public Class Form_Mobil
    Private Sub Form_Mobil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MatikanForm()
        Call TampilkanData()
    End Sub
    Sub KosongkanForm()
        txt_Id.Text = ""
        txt_Platmobil.Text = ""
        txt_Tahunbuat.Text = ""
        txt_Merk.Text = ""
        txt_Jenis.Text = ""
        txt_Tipe.Text = ""
        txt_Harga.Text = ""
        txt_Bb.Text = ""
        txt_Armada.Text = ""
        txt_Penumpang.Text = ""
        txt_CC.Text = ""
        txt_Id.Focus()
    End Sub
    Sub MatikanForm()
        txt_Id.Enabled = False
        txt_Platmobil.Enabled = False
        txt_Tahunbuat.Enabled = False
        txt_Merk.Enabled = False
        txt_Jenis.Enabled = False
        txt_Tipe.Enabled = False
        txt_Harga.Enabled = False
        txt_Bb.Enabled = False
        txt_Armada.Enabled = False
        txt_Penumpang.Enabled = False

        txt_CC.Enabled = False
    End Sub
    Sub HidupkanForm()
        txt_Id.Enabled = True
        txt_Platmobil.Enabled = True
        txt_Tahunbuat.Enabled = True
        txt_Merk.Enabled = True
        txt_Jenis.Enabled = True
        txt_Tipe.Enabled = True
        txt_Harga.Enabled = True
        txt_Bb.Enabled = True
        txt_Armada.Enabled = True
        txt_Penumpang.Enabled = True
        txt_CC.Enabled = True
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from mobil", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Call HidupkanForm()
        Call KosongkanForm()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call MatikanForm()
        Call KosongkanForm()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txt_Id.Text = "" Or txt_Platmobil.Text = "" Or txt_Tahunbuat.Text =
         "" Or txt_Merk.Text = "" Or txt_Jenis.Text = "" Or txt_Tipe.Text = "" Or txt_Harga.Text =
         "" Or txt_Bb.Text = "" Or txt_Armada.Text = "" Or txt_Penumpang.Text = "" Or txt_CC.Text = "" Then
            MsgBox("Data mobil Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from mobil where ID_mobil ='" & txt_Id.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()

            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Menu values ('" & txt_Platmobil.Text &
       "', '" & txt_Tahunbuat.Text & "', '" & txt_Merk.Text & "','" &
       txt_Jenis.Text & "','" & txt_Tipe.Text & "','" & txt_Harga.Text &
 "','" & txt_Bb.Text & "','" & txt_Armada.Text & "','" & txt_Penumpang.Text & "','" & txt_CC.Text & "')"
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

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        txt_Id.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        txt_Platmobil.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        txt_Tahunbuat.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        txt_Merk.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        txt_Jenis.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        txt_Tipe.Text = DGV.Rows(e.RowIndex).Cells(5).Value
        txt_Harga.Text = DGV.Rows(e.RowIndex).Cells(6).Value
        txt_Bb.Text = DGV.Rows(e.RowIndex).Cells(7).Value
        txt_Armada.Text = DGV.Rows(e.RowIndex).Cells(8).Value
        txt_Penumpang.Text = DGV.Rows(e.RowIndex).Cells(9).Value
        txt_CC.Text = DGV.Rows(e.RowIndex).Cells(10).Value
        Call HidupkanForm()
        txt_Id.Enabled = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txt_Id.Text = "" Or txt_Platmobil.Text = "" Or txt_Tahunbuat.Text =
         "" Or txt_Merk.Text = "" Or txt_Jenis.Text = "" Or txt_Tipe.Text = "" Or txt_Harga.Text =
         "" Or txt_Bb.Text = "" Or txt_Armada.Text = "" Or txt_Penumpang.Text = "" Or txt_CC.Text = "" Then
            MsgBox("Data mobil Belum Lengkap")
            Exit Sub

        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" update mobil set no_plat_mobil = '" &
   txt_Platmobil.Text & "', tahun_pembuatan = '" & txt_Tahunbuat.Text & "',  merk = '" &
   txt_Merk.Text & "', jenis= '" & txt_Jenis.Text & "', tipe = '" & txt_Tipe.Text & "' ,
   harga_sewa = '" & txt_Harga.Text & "', bahan_bakar = '" & txt_Bb.Text & "' ,  jumlah_armada ='" & txt_Armada.Text & "', jumlah_penumpang ='" & txt_Penumpang.Text & "', CC ='" & txt_CC.Text & "' where ID_mobil ='" & txt_Id.Text & "'", Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")

        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txt_Id.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub

        Else
            If MessageBox.Show("Are you sure to delete this data ? ",
   "Konfirmasi", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then

                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from mobil where ID_mobil ='" & txt_Id.Text & "'", Conn)
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

    Private Sub btn_Menyewa_Click(sender As Object, e As EventArgs) Handles btn_Menyewa.Click
        sewa.Show()
    End Sub
End Class