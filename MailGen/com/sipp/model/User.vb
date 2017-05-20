Public Class User
    Private m_id As Integer
    Public Property id() As Integer
        Get
            Return m_id
        End Get
        Set(ByVal value As Integer)
            m_id = value
        End Set
    End Property

    Private m_username As String
    Public Property username() As String
        Get
            Return m_username
        End Get
        Set(ByVal value As String)
            m_username = value
        End Set
    End Property

    Private m_password As String
    Public Property password() As String
        Get
            Return m_password
        End Get
        Set(ByVal value As String)
            m_password = value
        End Set
    End Property

    Private m_email As String
    Public Property email() As String
        Get
            Return m_email
        End Get
        Set(ByVal value As String)
            m_email = value
        End Set
    End Property

    Private m_fullName As String
    Public Property full_name() As String
        Get
            Return m_fullName
        End Get
        Set(ByVal value As String)
            m_fullName = value
        End Set
    End Property

    Private m_position As String
    Public Property position() As String
        Get
            Return m_position
        End Get
        Set(ByVal value As String)
            m_position = value
        End Set
    End Property

    Public Function CheckMember() As String
        Dim data As String = _
            "id : " & m_id.ToString() & vbNewLine & _
            "username : " & m_username & vbNewLine & _
            "password : " & m_password & vbNewLine & _
            "full name : " & m_fullName & vbNewLine & _
            "email : " & m_email & vbNewLine & _
            "position : " & m_position

        Return data
    End Function



End Class
