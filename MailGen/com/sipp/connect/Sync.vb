Imports System.Data.OleDb
Imports Newtonsoft.Json

Namespace com.sipp.connect
    Module Sync
        Public Sub MailOne(ByVal dgvClientMail1 As DataGridView)
            Dim lengthMailOneClient As Integer = dgvClientMail1.RowCount

            For index = 0 To lengthMailOneClient - 1
                Dim dataToServer As MailOne = New MailOne()
                dataToServer.nomor = dgvClientMail1.Rows(index).Cells("nomor").Value.ToString()
                dataToServer.lampiran = dgvClientMail1.Rows(index).Cells("lampiran").Value.ToString()
                dataToServer.hal = dgvClientMail1.Rows(index).Cells("hal").Value.ToString()
                dataToServer.tanggal_surat = dgvClientMail1.Rows(index).Cells("tanggal_surat").Value.ToString()
                dataToServer.diperuntukan = dgvClientMail1.Rows(index).Cells("diperuntukan").Value.ToString()
                dataToServer.nama_kegiatan = dgvClientMail1.Rows(index).Cells("nama_kegiatan").Value.ToString()
                dataToServer.tema_kegiatan = dgvClientMail1.Rows(index).Cells("tema_kegiatan").Value.ToString()
                dataToServer.hari_kegiatan = dgvClientMail1.Rows(index).Cells("hari_kegiatan").Value.ToString()
                dataToServer.tanggal_kegiatan = dgvClientMail1.Rows(index).Cells("tanggal_kegiatan").Value.ToString()
                dataToServer.waktu_kegiatan = dgvClientMail1.Rows(index).Cells("waktu_kegiatan").Value.ToString()
                dataToServer.tempat_kegiatan = dgvClientMail1.Rows(index).Cells("tempat_kegiatan").Value.ToString()
                ConnectApi.MailOne(MethodApi.POST, dataToServer)
            Next

            deleteItemQuery = "delete from Undangan1Waktu"
            Try
                ad = New OleDbDataAdapter()
                ad.InsertCommand = New OleDbCommand(deleteItemQuery, connect)
                ad.InsertCommand.ExecuteNonQuery()
                'connect.Close()
                ConnectAccess.Connection()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

            ConnectApi.MailOne(MethodApi.PUT_ELIMINATE_DUPLICATE)

            Dim dataToClient = JsonConvert.DeserializeObject(Of List(Of MailOne))(ConnectApi.MailOne(MethodApi.GET_ALL).ToString())

            For index = 0 To dataToClient.Count - 1
                saveItemQuery =
                    "insert into Undangan1Waktu values ('" &
                    dataToClient.Item(index).id & "', '" &
                    dataToClient.Item(index).nomor & "', '" &
                    dataToClient.Item(index).lampiran & "', '" &
                    dataToClient.Item(index).hal & "', '" &
                    dataToClient.Item(index).tanggal_surat & "', '" &
                    dataToClient.Item(index).diperuntukan & "', '" &
                    dataToClient.Item(index).nama_kegiatan & "', '" &
                    dataToClient.Item(index).tema_kegiatan & "', '" &
                    dataToClient.Item(index).hari_kegiatan & "', '" &
                    dataToClient.Item(index).tanggal_kegiatan & "', '" &
                    dataToClient.Item(index).waktu_kegiatan & "', '" &
                    dataToClient.Item(index).tempat_kegiatan & "')"
                Try
                    ad = New OleDbDataAdapter()
                    ad.InsertCommand = New OleDbCommand(saveItemQuery, connect)
                    ad.InsertCommand.ExecuteNonQuery()
                    'connect.Close()
                    ConnectAccess.Connection()
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
            Next
        End Sub

        Public Sub MailTwo(ByVal dgvClientMail2 As DataGridView)
            Dim lengthMailTwoClient As Integer = dgvClientMail2.RowCount

            For index = 0 To lengthMailTwoClient - 1
                Dim dataToServer As MailTwo = New MailTwo()
                dataToServer.nomor = dgvClientMail2.Rows(index).Cells("nomor").Value.ToString()
                dataToServer.lampiran = dgvClientMail2.Rows(index).Cells("lampiran").Value.ToString()
                dataToServer.hal = dgvClientMail2.Rows(index).Cells("hal").Value.ToString()
                dataToServer.tanggal_surat = dgvClientMail2.Rows(index).Cells("tanggal_surat").Value.ToString()
                dataToServer.diperuntukan = dgvClientMail2.Rows(index).Cells("diperuntukan").Value.ToString()
                dataToServer.nama_kegiatan = dgvClientMail2.Rows(index).Cells("nama_kegiatan").Value.ToString()
                dataToServer.tema_kegiatan = dgvClientMail2.Rows(index).Cells("tema_kegiatan").Value.ToString()
                dataToServer.hari_kegiatan1 = dgvClientMail2.Rows(index).Cells("hari_kegiatan1").Value.ToString()
                dataToServer.tanggal_kegiatan1 = dgvClientMail2.Rows(index).Cells("tanggal_kegiatan1").Value.ToString()
                dataToServer.waktu_kegiatan1 = dgvClientMail2.Rows(index).Cells("waktu_kegiatan1").Value.ToString()
                dataToServer.tempat_kegiatan1 = dgvClientMail2.Rows(index).Cells("tempat_kegiatan1").Value.ToString()
                dataToServer.hari_kegiatan2 = dgvClientMail2.Rows(index).Cells("hari_kegiatan2").Value.ToString()
                dataToServer.tanggal_kegiatan2 = dgvClientMail2.Rows(index).Cells("tanggal_kegiatan2").Value.ToString()
                dataToServer.waktu_kegiatan2 = dgvClientMail2.Rows(index).Cells("waktu_kegiatan2").Value.ToString()
                dataToServer.tempat_kegiatan2 = dgvClientMail2.Rows(index).Cells("tempat_kegiatan2").Value.ToString()
                ConnectApi.MailTwo(MethodApi.POST, dataToServer)
            Next

            deleteItemQuery = "delete from Undangan2Waktu"
            Try
                ad = New OleDbDataAdapter()
                ad.InsertCommand = New OleDbCommand(deleteItemQuery, connect)
                ad.InsertCommand.ExecuteNonQuery()
                connect.Close()
                ConnectAccess.Connection()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

            ConnectApi.MailTwo(MethodApi.PUT_ELIMINATE_DUPLICATE)

            Dim dataToClient = JsonConvert.DeserializeObject(Of List(Of MailTwo))(ConnectApi.MailTwo(MethodApi.GET_ALL).ToString())

            For index = 0 To dataToClient.Count - 1

                saveItemQuery =
                    "insert into Undangan2Waktu " &
                    "(nomor, lampiran, hal, tanggal_surat, diperuntukan, nama_kegiatan, tema_kegiatan, hari_kegiatan1, tanggal_kegiatan1, waktu_kegiatan1, tempat_kegiatan1, hari_kegiatan2, tanggal_kegiatan2, waktu_kegiatan2, tempat_kegiatan2)" &
                    "values ('" &
                    dataToClient.Item(index).id & "', '" &
                    dataToClient.Item(index).nomor & "', '" &
                    dataToClient.Item(index).lampiran & "', '" &
                    dataToClient.Item(index).hal & "', '" &
                    dataToClient.Item(index).tanggal_surat & "', '" &
                    dataToClient.Item(index).diperuntukan & "', '" &
                    dataToClient.Item(index).nama_kegiatan & "', '" &
                    dataToClient.Item(index).tema_kegiatan & "', '" &
                    dataToClient.Item(index).hari_kegiatan1 & "', '" &
                    dataToClient.Item(index).tanggal_kegiatan1 & "', '" &
                    dataToClient.Item(index).waktu_kegiatan1 & "', '" &
                    dataToClient.Item(index).tempat_kegiatan1 &
                    dataToClient.Item(index).hari_kegiatan2 & "', '" &
                    dataToClient.Item(index).tanggal_kegiatan2 & "', '" &
                    dataToClient.Item(index).waktu_kegiatan2 & "', '" &
                    dataToClient.Item(index).tempat_kegiatan2 & "')"

                Try
                    ad = New OleDbDataAdapter()
                    ad.InsertCommand = New OleDbCommand(saveItemQuery, connect)
                    ad.InsertCommand.ExecuteNonQuery()
                    connect.Close()
                    ConnectAccess.Connection()
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
            Next
        End Sub
    End Module
End Namespace


