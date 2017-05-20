Public Class MailOne
    Private m_id As Integer
    Public Property id() As Integer
        Get
            Return m_id
        End Get
        Set(ByVal value As Integer)
            m_id = value
        End Set
    End Property


    Private m_nomor As String
    Public Property nomor() As String
        Get
            Return m_nomor
        End Get
        Set(ByVal value As String)
            m_nomor = value
        End Set
    End Property

    Private m_lampiran As String
    Public Property lampiran() As String
        Get
            Return m_lampiran
        End Get
        Set(ByVal value As String)
            m_lampiran = value
        End Set
    End Property

    Private m_hal As String
    Public Property hal() As String
        Get
            Return m_hal
        End Get
        Set(ByVal value As String)
            m_hal = value
        End Set
    End Property

    Private m_tanggal_surat As String
    Public Property tanggal_surat() As String
        Get
            Return m_tanggal_surat
        End Get
        Set(ByVal value As String)
            m_tanggal_surat = value
        End Set
    End Property

    Private m_diperuntukan As String
    Public Property diperuntukan() As String
        Get
            Return m_diperuntukan
        End Get
        Set(ByVal value As String)
            m_diperuntukan = value
        End Set
    End Property

    Private m_nama_kegiatan As String
    Public Property nama_kegiatan() As String
        Get
            Return m_nama_kegiatan
        End Get
        Set(ByVal value As String)
            m_nama_kegiatan = value
        End Set
    End Property

    Private m_tema_kegiatan As String
    Public Property tema_kegiatan() As String
        Get
            Return m_tema_kegiatan
        End Get
        Set(ByVal value As String)
            m_tema_kegiatan = value
        End Set
    End Property

    Private m_hari_kegiatan As String
    Public Property hari_kegiatan() As String
        Get
            Return m_hari_kegiatan
        End Get
        Set(ByVal value As String)
            m_hari_kegiatan = value
        End Set
    End Property

    Private m_tanggal_kegiatan As String
    Public Property tanggal_kegiatan() As String
        Get
            Return m_tanggal_kegiatan
        End Get
        Set(ByVal value As String)
            m_tanggal_kegiatan = value
        End Set
    End Property

    Private m_waktu_kegiatan As String
    Public Property waktu_kegiatan() As String
        Get
            Return m_waktu_kegiatan
        End Get
        Set(ByVal value As String)
            m_waktu_kegiatan = value
        End Set
    End Property

    Private m_tempat_kegiatan As String
    Public Property tempat_kegiatan() As String
        Get
            Return m_tempat_kegiatan
        End Get
        Set(ByVal value As String)
            m_tempat_kegiatan = value
        End Set
    End Property


    Public Sub CheckMember()
        MsgBox(
            "id : " & m_id & vbNewLine &
            "nomor : " & m_nomor & vbNewLine &
            "lampiran : " & m_lampiran & vbNewLine &
            "hal : " & m_hal & vbNewLine &
            "tanggal surat : " & m_tanggal_surat & vbNewLine &
            "diperuntukan : " & m_diperuntukan & vbNewLine &
            "nama kegiatan : " & m_nama_kegiatan & vbNewLine &
            "tema kegiatan : " & m_tema_kegiatan & vbNewLine &
            "hari kegiatan : " & m_hari_kegiatan & vbNewLine &
            "tanggal kegiatan : " & m_tanggal_kegiatan & vbNewLine &
            "waktu kegiatan : " & m_waktu_kegiatan & vbNewLine &
            "tempat kegiatan : " & m_tempat_kegiatan & vbNewLine
            )
    End Sub






End Class
