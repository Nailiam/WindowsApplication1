Public Class sewa
    Private Sub sewa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MatikanForm()
        Call TampilkanData()
    End Sub
    Sub KosongkanForm()
        kode_kontrak.Text = ""
        jml_mobil.Text = ""
        harga_total.Text = ""
        no_pel.Text = ""
        ID_mobil.Text = ""
        kode_kontrak.Focus()
    End Sub
    Sub MatikanForm()
        kode_kontrak.Enabled = False
        jml_mobil.Enabled = False
        harga_total.Enabled = False
        no_pel.Enabled = False
        ID_mobil.Enabled = False
    End Sub

    Sub HidupkanForm()
        kode_kontrak.Enabled = True
        jml_mobil.Enabled = True
        harga_total.Enabled = True
        no_pel.Enabled = True
        ID_mobil.Enabled = True
    End Sub

    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select  * From menyewa ", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
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
        If kode_kontrak.Text = "" Or jml_mobil.Text = "" Or harga_total.Text =
         "" Or no_pel.Text = "" Or ID_mobil.Text = "" Then
            MsgBox("Data sewa Belum Lengkap")
            Exit Sub

        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from menyewa where kode_kontrak ='" & kode_kontrak.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()

            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Menu values ('" & kode_kontrak.Text &
       "', '" & jml_mobil.Text & "', '" & harga_total.Text & "','" &
       no_pel.Text & "','" & ID_mobil.Text & "')"
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
        kode_kontrak.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dddd, dd/MM/yyyy"
        DateTimePicker1.Value = Format(DGV.Rows(e.RowIndex).Cells(1).Value)
        jml_mobil.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        harga_total.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "dddd, dd/MM/yyyy"
        DateTimePicker2.Value = Format(DGV.Rows(e.RowIndex).Cells(4).Value)
        no_pel.Text = DGV.Rows(e.RowIndex).Cells(5).Value
        ID_mobil.Text = DGV.Rows(e.RowIndex).Cells(6).Value

        Call HidupkanForm()
        kode_kontrak.Enabled = False
    End Sub

    Private Sub btnedit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        If kode_kontrak.Text = "" Or jml_mobil.Text = "" Or harga_total.Text =
         "" Or no_pel.Text = "" Or ID_mobil.Text = "" Then
            MsgBox("Data sewa Belum Lengkap")
            Exit Sub

        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" update menyewa set jumlah_mobil_yang_disewa = '" &
   jml_mobil.Text & "', harga_total = '" & harga_total.Text & "',  no_pelanggan = '" &
   no_pel.Text & "', ID_Mobil = '" & ID_mobil.Text & "'  where kode_kontrak ='" & kode_kontrak.Text & "'", Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")

        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()

    End Sub

    Private Sub btndelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If kode_kontrak.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub

        Else
            If MessageBox.Show("Are you sure to delete this data ? ",
   "Konfirmasi", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then

                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from menyewa where kode_kontrak ='" & kode_kontrak.Text & "'", Conn)
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
End Class