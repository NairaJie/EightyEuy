Imports MySql.Data.MySqlClient
Public Class Form1
    Dim strkon As String = "server=localhost;uid=root;database=warnet_22"
    Dim kon As New MySqlConnection(strkon)
    Dim perintah As New MySqlCommand
    Dim mda As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim cek As MySqlDataReader
    Dim harga, potongan, total As Double

    Sub tidakaktif()
        TxtId.Enabled = False
        TxtNama.Enabled = False
        DTPTransaksi.Enabled = False
        CmbPaket.Enabled = False
        TxtHarga.Enabled = False
        TxtLama.Enabled = False
        TxtPotongan.Enabled = False
        TxtTotal.Enabled = False

        TxtId.BackColor = Color.Gray
        TxtNama.BackColor = Color.Gray
        DTPTransaksi.BackColor = Color.Gray
        CmbPaket.BackColor = Color.Gray
        TxtHarga.BackColor = Color.Gray
        TxtLama.BackColor = Color.Gray
        TxtNama.BackColor = Color.Gray
        TxtTotal.BackColor = Color.Gray


        CmdSimpan.Enabled = False
        CmdHapus.Enabled = False
    End Sub

    Sub aktif()
        TxtId.Enabled = True
        TxtNama.Enabled = True
        DTPTransaksi.Enabled = True
        CmbPaket.Enabled = True
        TxtHarga.Enabled = True
        TxtLama.Enabled = True
        TxtPotongan.Enabled = True
        TxtTotal.Enabled = True

        TxtId.BackColor = Color.White
        TxtNama.BackColor = Color.White
        DTPTransaksi.BackColor = Color.White
        CmbPaket.BackColor = Color.White
        TxtHarga.BackColor = Color.White
        TxtLama.BackColor = Color.White
        TxtNama.BackColor = Color.White
        TxtTotal.BackColor = Color.White


        CmdSimpan.Enabled = True
        CmdHapus.Enabled = True
    End Sub

    Sub bersih()
        TxtId.Text = ""
        TxtNama.Text = ""
        DTPTransaksi.Text = ""
        CmbPaket.Text = ""
        TxtHarga.Text = ""
        TxtLama.Text = ""
        TxtPotongan.Text = ""
        TxtTotal.Text = ""
    End Sub

    Sub tampil()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from warnet"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "warnet")
        DgTampil.DataSource = ds.Tables("warnet")
        kon.Close()
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As KeyEventArgs) Handles TxtId.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                kon.Open()
                perintah.Connection = kon
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "select * from warnet " &
                " where Id='" & TxtId.Text & "'"
                cek = perintah.ExecuteReader
                cek.Read()
                MsgBox("data sudah ada...!", MsgBoxStyle.Information, "Pesan")
                If cek.HasRows Then
                    TxtNama.Text = cek.Item("NamaPelanggan")
                    DTPTransaksi.Value = cek.Item("TanggalTransaksi")
                    CmbPaket.Text = cek.Item("JenisPaket")
                    TxtHarga.Text = cek.Item("Harga")
                    TxtLama.Text = cek.Item("lama")
                    TxtPotongan.Text = cek.Item("Potongan")
                    TxtTotal.Text = cek.Item("Total")
                    CmdSimpan.Enabled = False
                End If
                kon.Close()
                ' tidakaktif()
                CmdTambah.Enabled = True
        End Select
    End Sub

    Private Sub CmdTambah_Click(sender As Object, e As EventArgs) Handles CmdTambah.Click
        aktif()
        TxtId.Focus()
        CmdTambah.Enabled = False
    End Sub

    Private Sub CmdSimpan_Click(sender As Object, e As EventArgs) Handles CmdSimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into warnet values " &
        " ('" & TxtId.Text & "', '" & TxtNama.Text & "', " &
        " '" & Format(DTPTransaksi.Value, "yyyy-MM-dd") & "', " &
        " '" & CmbPaket.Text & "', '" & harga & "','" & TxtLama.Text & "', " &
        " '" & potongan & "', ' " & total & " ')"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("data berhasil disimpan", MsgBoxStyle.Information, "Pesan")
        tampil()
        bersih()
        tidakaktif()
        CmdTambah.Enabled = True
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tidakaktif()
        bersih()
        tampil()
    End Sub

    Private Sub CmdHapus_Click(sender As Object, e As EventArgs) Handles CmdHapus.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from warnet where Id='" & TxtId.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampil()
        bersih()
    End Sub

    Private Sub CmbPaket_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPaket.SelectedIndexChanged
        Select Case CmbPaket.SelectedIndex
            Case 0
                harga = 4500
            Case 1
                harga = 6500
            Case 2
                harga = 10000
        End Select
        TxtHarga.Text = Format(harga, "Rp ###,###,##")
    End Sub

    Private Sub TxtLama_TextChanged(sender As Object, e As EventArgs) Handles TxtLama.TextChanged
        If Val(TxtLama.Text) > 3 Then
            potongan = 1000
        Else
            potongan = 0
        End If
        TxtPotongan.Text = Format(potongan, "Rp ###,###,##")
        total = harga * Val(TxtLama.Text) - potongan
        TxtTotal.Text = Format(total, "Rp ###,###,##")
    End Sub
End Class
