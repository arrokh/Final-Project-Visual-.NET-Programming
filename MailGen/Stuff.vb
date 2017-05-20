Imports System.Data.OleDb
Module Stuff
    Public connect As OleDbConnection
    Public command As OleDbCommand
    Public ds As New DataSet
    Public ad As OleDbDataAdapter
    Public dr As OleDbDataReader
    Public dataLocation As String
    Public saveItemQuery As String
    Public editItemQuery As String
    Public deleteItemQuery As String
    Public sqlBinding As String

    Public Sub Connection()
        dataLocation = "provider=microsoft.jet.oledb.4.0;data source=Database1.mdb"
        Try
            connect = New OleDbConnection(dataLocation)
            If connect.State = ConnectionState.Closed Then
                connect.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub


End Module
