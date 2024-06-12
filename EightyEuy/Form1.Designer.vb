<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DTPTransaksi = New System.Windows.Forms.DateTimePicker()
        Me.CmbPaket = New System.Windows.Forms.ComboBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.TxtLama = New System.Windows.Forms.TextBox()
        Me.TxtPotongan = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.CmdTambah = New System.Windows.Forms.Button()
        Me.CmdSimpan = New System.Windows.Forms.Button()
        Me.CmdHapus = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.DgTampil = New System.Windows.Forms.DataGridView()
        CType(Me.DgTampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Pelanggan Warnet "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID PELANGGAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NAMA PELANGGAN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TANGGAL TRANSAKSI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "JENIS PAKET"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(60, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "HARGA/JAM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "LAMA MAIN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(60, 312)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "POTONGAN "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(60, 356)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "TOTAL BAYAR"
        '
        'DTPTransaksi
        '
        Me.DTPTransaksi.Location = New System.Drawing.Point(241, 163)
        Me.DTPTransaksi.Name = "DTPTransaksi"
        Me.DTPTransaksi.Size = New System.Drawing.Size(200, 20)
        Me.DTPTransaksi.TabIndex = 9
        '
        'CmbPaket
        '
        Me.CmbPaket.FormattingEnabled = True
        Me.CmbPaket.Items.AddRange(New Object() {"Paket 1", "Paket 2", "Paket 3"})
        Me.CmbPaket.Location = New System.Drawing.Point(241, 200)
        Me.CmbPaket.Name = "CmbPaket"
        Me.CmbPaket.Size = New System.Drawing.Size(200, 21)
        Me.CmbPaket.TabIndex = 10
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(241, 95)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(200, 20)
        Me.TxtId.TabIndex = 11
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(241, 128)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(200, 20)
        Me.TxtNama.TabIndex = 12
        '
        'TxtHarga
        '
        Me.TxtHarga.Location = New System.Drawing.Point(241, 236)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(200, 20)
        Me.TxtHarga.TabIndex = 13
        '
        'TxtLama
        '
        Me.TxtLama.Location = New System.Drawing.Point(241, 267)
        Me.TxtLama.Name = "TxtLama"
        Me.TxtLama.Size = New System.Drawing.Size(200, 20)
        Me.TxtLama.TabIndex = 14
        '
        'TxtPotongan
        '
        Me.TxtPotongan.Location = New System.Drawing.Point(241, 309)
        Me.TxtPotongan.Name = "TxtPotongan"
        Me.TxtPotongan.Size = New System.Drawing.Size(200, 20)
        Me.TxtPotongan.TabIndex = 15
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(241, 353)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(200, 20)
        Me.TxtTotal.TabIndex = 16
        '
        'CmdTambah
        '
        Me.CmdTambah.Location = New System.Drawing.Point(63, 413)
        Me.CmdTambah.Name = "CmdTambah"
        Me.CmdTambah.Size = New System.Drawing.Size(119, 23)
        Me.CmdTambah.TabIndex = 17
        Me.CmdTambah.Text = "Tambah"
        Me.CmdTambah.UseVisualStyleBackColor = True
        '
        'CmdSimpan
        '
        Me.CmdSimpan.Location = New System.Drawing.Point(241, 413)
        Me.CmdSimpan.Name = "CmdSimpan"
        Me.CmdSimpan.Size = New System.Drawing.Size(119, 23)
        Me.CmdSimpan.TabIndex = 18
        Me.CmdSimpan.Text = "Simpan"
        Me.CmdSimpan.UseVisualStyleBackColor = True
        '
        'CmdHapus
        '
        Me.CmdHapus.Location = New System.Drawing.Point(414, 413)
        Me.CmdHapus.Name = "CmdHapus"
        Me.CmdHapus.Size = New System.Drawing.Size(119, 23)
        Me.CmdHapus.TabIndex = 19
        Me.CmdHapus.Text = "Hapus"
        Me.CmdHapus.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(595, 413)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(119, 23)
        Me.BtnKeluar.TabIndex = 20
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'DgTampil
        '
        Me.DgTampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgTampil.Location = New System.Drawing.Point(63, 462)
        Me.DgTampil.Name = "DgTampil"
        Me.DgTampil.Size = New System.Drawing.Size(651, 150)
        Me.DgTampil.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 547)
        Me.Controls.Add(Me.DgTampil)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.CmdHapus)
        Me.Controls.Add(Me.CmdSimpan)
        Me.Controls.Add(Me.CmdTambah)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.TxtPotongan)
        Me.Controls.Add(Me.TxtLama)
        Me.Controls.Add(Me.TxtHarga)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.CmbPaket)
        Me.Controls.Add(Me.DTPTransaksi)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DgTampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DTPTransaksi As DateTimePicker
    Friend WithEvents CmbPaket As ComboBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents TxtLama As TextBox
    Friend WithEvents TxtPotongan As TextBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents CmdTambah As Button
    Friend WithEvents CmdSimpan As Button
    Friend WithEvents CmdHapus As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents DgTampil As DataGridView
End Class
