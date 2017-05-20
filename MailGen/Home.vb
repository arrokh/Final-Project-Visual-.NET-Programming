Imports MetroFramework
Imports MetroFramework.Forms
Imports MetroFramework.Controls
Imports System.Data.OleDb
Imports Newtonsoft.Json
Imports MailGen.com.sipp.connect

Public Class Home
    Dim colorState As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTabControl1.SelectTab(0)
        Call Connection()
        Call yearGenerate()
    End Sub

    Private Sub yearGenerate()
        Dim a As Integer
        For a = 2013 To 2030
            cbxSelectYear.Items.Add(a)
        Next
    End Sub

    Private Sub searchProccess()
        Dim optionSelect As String = CStr(cbxSelectDb.SelectedItem)

        Try
            If optionSelect.Equals("Undangan 1 Waktu") Then
                ad = New OleDbDataAdapter("select Nomor, Lampiran, Hal, Tanggal_Surat, Nama_Kegiatan from Undangan1Waktu where Tanggal_Surat like '%" &
                                          cbxSelectMonth.SelectedItem & "%' and Tanggal_Surat like '%" & cbxSelectYear.SelectedItem & "'", connect)
                ds = New DataSet
                ad.Fill(ds, "Undangan1Waktu")
                MetroGrid1.DataSource = ds.Tables("Undangan1Waktu")

            ElseIf optionSelect.Equals("Undangan 2 Waktu") Then
                ad = New OleDbDataAdapter("select Nomor, Lampiran, Hal, Tanggal_Surat, Nama_Kegiatan from Undangan2Waktu where Tanggal_Surat like '%" &
                                          cbxSelectMonth.SelectedItem & "%' and Tanggal_Surat like '%" & cbxSelectYear.SelectedItem & "'", connect)
                ds = New DataSet
                ad.Fill(ds, "Undangan2Waktu")
                MetroGrid1.DataSource = ds.Tables("Undangan2Waktu")

            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        Dim MailOne As New InvitationMailOne
        If colorState.Equals(True) Then
            MailOne.Theme = MetroThemeStyle.Dark
            MailOne.MetroTabControl1.Theme = MetroThemeStyle.Dark
            MailOne.MetroTabPage1.Theme = MetroThemeStyle.Dark
            MailOne.MetroTabPage2.Theme = MetroThemeStyle.Dark
            MailOne.MetroTabPage3.Theme = MetroThemeStyle.Dark
            MailOne.MetroTabPage4.Theme = MetroThemeStyle.Dark
            MailOne.MetroLabel1.Theme = MetroThemeStyle.Dark
            MailOne.MetroLabel2.Theme = MetroThemeStyle.Dark
            MailOne.MetroLabel3.Theme = MetroThemeStyle.Dark
            MailOne.MetroLabel4.Theme = MetroThemeStyle.Dark
            MailOne.MetroLabel5.Theme = MetroThemeStyle.Dark
            MailOne.MetroLabel6.Theme = MetroThemeStyle.Dark
            MailOne.MetroLabel7.Theme = MetroThemeStyle.Dark
            MailOne.MetroLabel8.Theme = MetroThemeStyle.Dark
            MailOne.MetroLabel9.Theme = MetroThemeStyle.Dark
            MailOne.MetroLabel10.Theme = MetroThemeStyle.Dark
            MailOne.MetroLabel11.Theme = MetroThemeStyle.Dark
            MailOne.MetroLabel12.Theme = MetroThemeStyle.Dark
            MailOne.MetroLabel13.Theme = MetroThemeStyle.Dark
        Else
            MailOne.Theme = MetroThemeStyle.Light
            MailOne.MetroTabControl1.Theme = MetroThemeStyle.Light
            MailOne.MetroTabPage1.Theme = MetroThemeStyle.Light
            MailOne.MetroTabPage2.Theme = MetroThemeStyle.Light
            MailOne.MetroTabPage3.Theme = MetroThemeStyle.Light
            MailOne.MetroTabPage4.Theme = MetroThemeStyle.Light
            MailOne.MetroLabel1.Theme = MetroThemeStyle.Light
            MailOne.MetroLabel2.Theme = MetroThemeStyle.Light
            MailOne.MetroLabel3.Theme = MetroThemeStyle.Light
            MailOne.MetroLabel4.Theme = MetroThemeStyle.Light
            MailOne.MetroLabel5.Theme = MetroThemeStyle.Light
            MailOne.MetroLabel6.Theme = MetroThemeStyle.Light
            MailOne.MetroLabel7.Theme = MetroThemeStyle.Light
            MailOne.MetroLabel8.Theme = MetroThemeStyle.Light
            MailOne.MetroLabel9.Theme = MetroThemeStyle.Light
            MailOne.MetroLabel10.Theme = MetroThemeStyle.Light
            MailOne.MetroLabel11.Theme = MetroThemeStyle.Light
            MailOne.MetroLabel12.Theme = MetroThemeStyle.Light
            MailOne.MetroLabel13.Theme = MetroThemeStyle.Light
        End If
        MailOne.Show()

    End Sub
    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        Dim MailTwo As New InvitationMailTwo
        If colorState.Equals(True) Then
            MailTwo.Theme = MetroThemeStyle.Dark
            MailTwo.MetroTabControl1.Theme = MetroThemeStyle.Dark
            MailTwo.MetroTabPage1.Theme = MetroThemeStyle.Dark
            MailTwo.MetroTabPage2.Theme = MetroThemeStyle.Dark
            MailTwo.MetroTabPage3.Theme = MetroThemeStyle.Dark
            MailTwo.MetroTabPage4.Theme = MetroThemeStyle.Dark
            MailTwo.MetroLabel1.Theme = MetroThemeStyle.Dark
            MailTwo.MetroLabel2.Theme = MetroThemeStyle.Dark
            MailTwo.MetroLabel3.Theme = MetroThemeStyle.Dark
            MailTwo.MetroLabel4.Theme = MetroThemeStyle.Dark
            MailTwo.MetroLabel5.Theme = MetroThemeStyle.Dark
            MailTwo.MetroLabel6.Theme = MetroThemeStyle.Dark
            MailTwo.MetroLabel7.Theme = MetroThemeStyle.Dark
            MailTwo.MetroLabel9.Theme = MetroThemeStyle.Dark
            MailTwo.MetroLabel10.Theme = MetroThemeStyle.Dark
            MailTwo.MetroLabel11.Theme = MetroThemeStyle.Dark
            MailTwo.MetroLabel12.Theme = MetroThemeStyle.Dark
            MailTwo.MetroLabel13.Theme = MetroThemeStyle.Dark
            MailTwo.MetroLabel14.Theme = MetroThemeStyle.Dark
            MailTwo.MetroLabel15.Theme = MetroThemeStyle.Dark
            MailTwo.MetroLabel16.Theme = MetroThemeStyle.Dark
            MailTwo.MetroLabel17.Theme = MetroThemeStyle.Dark

        Else
            MailTwo.Theme = MetroThemeStyle.Light
            MailTwo.MetroTabControl1.Theme = MetroThemeStyle.Light
            MailTwo.MetroTabPage1.Theme = MetroThemeStyle.Light
            MailTwo.MetroTabPage2.Theme = MetroThemeStyle.Light
            MailTwo.MetroTabPage3.Theme = MetroThemeStyle.Light
            MailTwo.MetroTabPage4.Theme = MetroThemeStyle.Light
            MailTwo.MetroLabel1.Theme = MetroThemeStyle.Light
            MailTwo.MetroLabel2.Theme = MetroThemeStyle.Light
            MailTwo.MetroLabel3.Theme = MetroThemeStyle.Light
            MailTwo.MetroLabel5.Theme = MetroThemeStyle.Light
            MailTwo.MetroLabel4.Theme = MetroThemeStyle.Light
            MailTwo.MetroLabel6.Theme = MetroThemeStyle.Light
            MailTwo.MetroLabel7.Theme = MetroThemeStyle.Light
            MailTwo.MetroLabel9.Theme = MetroThemeStyle.Light
            MailTwo.MetroLabel10.Theme = MetroThemeStyle.Light
            MailTwo.MetroLabel11.Theme = MetroThemeStyle.Light
            MailTwo.MetroLabel12.Theme = MetroThemeStyle.Light
            MailTwo.MetroLabel13.Theme = MetroThemeStyle.Light
            MailTwo.MetroLabel14.Theme = MetroThemeStyle.Light
            MailTwo.MetroLabel15.Theme = MetroThemeStyle.Light
            MailTwo.MetroLabel16.Theme = MetroThemeStyle.Light
            MailTwo.MetroLabel17.Theme = MetroThemeStyle.Light
        End If
        MailTwo.Show()
    End Sub


    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Call searchProccess()
    End Sub



    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        colorState = True
        Me.Theme = MetroThemeStyle.Dark
        Me.MetroTabControl1.Theme = MetroThemeStyle.Dark
        Me.MetroTabPage1.Theme = MetroThemeStyle.Dark
        Me.MetroTabPage2.Theme = MetroThemeStyle.Dark
        Me.MetroTabPage3.Theme = MetroThemeStyle.Dark
        Me.MetroTabPage4.Theme = MetroThemeStyle.Dark
        Me.MetroLabel1.Theme = MetroThemeStyle.Dark
        Me.MetroLabel2.Theme = MetroThemeStyle.Dark
        Me.MetroLabel4.Theme = MetroThemeStyle.Dark
        Me.MetroLabel3.Theme = MetroThemeStyle.Dark
        Me.MetroLabel5.Theme = MetroThemeStyle.Dark
        Me.MetroLabel6.Theme = MetroThemeStyle.Dark
        Me.MetroLabel8.Theme = MetroThemeStyle.Dark
        Me.MetroGrid1.Theme = MetroThemeStyle.Dark


        Me.Refresh()
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        colorState = False
        Me.Theme = MetroThemeStyle.Light
        Me.MetroTabControl1.Theme = MetroThemeStyle.Light
        Me.MetroTabPage1.Theme = MetroThemeStyle.Light
        Me.MetroTabPage2.Theme = MetroThemeStyle.Light
        Me.MetroTabPage3.Theme = MetroThemeStyle.Light
        Me.MetroTabPage4.Theme = MetroThemeStyle.Light
        Me.MetroLabel1.Theme = MetroThemeStyle.Light
        Me.MetroLabel2.Theme = MetroThemeStyle.Light
        Me.MetroLabel4.Theme = MetroThemeStyle.Light
        Me.MetroLabel3.Theme = MetroThemeStyle.Light
        Me.MetroLabel5.Theme = MetroThemeStyle.Light
        Me.MetroLabel6.Theme = MetroThemeStyle.Light
        Me.MetroLabel8.Theme = MetroThemeStyle.Light
        Me.MetroGrid1.Theme = MetroThemeStyle.Light
        Me.Refresh()
    End Sub


    Private Sub MetroTile3_Click(sender As Object, e As EventArgs) Handles MetroTile3.Click
        ''''''  Mail One - Client
        ad = New OleDbDataAdapter("select nomor, lampiran, hal, tanggal_surat, diperuntukan, nama_kegiatan, tema_kegiatan, hari_kegiatan, tanggal_kegiatan, waktu_kegiatan, tempat_kegiatan from Undangan1Waktu", connect)
        ds = New DataSet
        ad.Fill(ds, "Undangan1Waktu")
        dgClientMailOne.DataSource = ds.Tables("Undangan1Waktu")
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ''''''  Mail Two - Client
        Dim ad2 = New OleDbDataAdapter("select nomor, lampiran, hal, tanggal_surat, diperuntukan, nama_kegiatan, tema_kegiatan, hari_kegiatan1, tanggal_kegiatan1, waktu_kegiatan1, tempat_kegiatan1, hari_kegiatan2, tanggal_kegiatan2, waktu_kegiatan2, tempat_kegiatan2 from Undangan2Waktu", connect)
        Dim ds2 = New DataSet
        ad2.Fill(ds2, "Undangan2Waktu")
        dgClientMailTwo.DataSource = ds2.Tables("Undangan2Waktu")
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ''''''  Mail One - Server
        Dim data1 = JsonConvert.DeserializeObject(Of List(Of MailOne))(ConnectApi.MailOne(MethodApi.GET_ALL).ToString())

        dgServerMailOne.Columns.Clear()

        dgServerMailOne.Columns.Add("nomor", "Nomor")
        dgServerMailOne.Columns.Add("lampiran", "Lampiran")
        dgServerMailOne.Columns.Add("hal", "Hal")
        dgServerMailOne.Columns.Add("tanggal_surat", "Tanggal Surat")
        dgServerMailOne.Columns.Add("diperuntukan", "Diperuntukan")
        dgServerMailOne.Columns.Add("nama_kegiatan", "Nama Kegiatan")
        dgServerMailOne.Columns.Add("tema_kegiatan", "Tema Kegiatan")
        dgServerMailOne.Columns.Add("hari_kegiatan", "Hari Kegiatan")
        dgServerMailOne.Columns.Add("tanggal_kegiatan", "Tanggal Kegiatan")
        dgServerMailOne.Columns.Add("waktu_kegiatan", "Waktu Kegiatan")
        dgServerMailOne.Columns.Add("tempat_kegiatan", "Tempat Kegiatan")

        For index = 0 To data1.Count - 1
            dgServerMailOne.Rows.Add({
                data1.Item(index).nomor,
                data1.Item(index).lampiran,
                data1.Item(index).hal,
                data1.Item(index).tanggal_surat,
                data1.Item(index).diperuntukan,
                data1.Item(index).nama_kegiatan,
                data1.Item(index).tema_kegiatan,
                data1.Item(index).hari_kegiatan,
                data1.Item(index).tanggal_kegiatan,
                data1.Item(index).waktu_kegiatan,
                data1.Item(index).tempat_kegiatan
            })
        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


        ''''''  Mail Two - Server
        Dim data2 = JsonConvert.DeserializeObject(Of List(Of MailTwo))(ConnectApi.MailTwo(MethodApi.GET_ALL).ToString())

        dgServerMailTwo.Columns.Clear()

        dgServerMailTwo.Columns.Add("nomor", "Nomor")
        dgServerMailTwo.Columns.Add("lampiran", "Lampiran")
        dgServerMailTwo.Columns.Add("hal", "Hal")
        dgServerMailTwo.Columns.Add("tanggal_surat", "Tanggal Surat")
        dgServerMailTwo.Columns.Add("diperuntukan", "Diperuntukan")
        dgServerMailTwo.Columns.Add("nama_kegiatan", "Nama Kegiatan")
        dgServerMailTwo.Columns.Add("tema_kegiatan", "Tema Kegiatan")
        dgServerMailTwo.Columns.Add("hari_kegiatan1", "Hari Kegiatan 1")
        dgServerMailTwo.Columns.Add("tanggal_kegiatan1", "Tanggal Kegiatan 1")
        dgServerMailTwo.Columns.Add("waktu_kegiatan1", "Waktu Kegiatan 1")
        dgServerMailTwo.Columns.Add("tempat_kegiatan1", "Tempat Kegiatan 1")
        dgServerMailTwo.Columns.Add("hari_kegiatan2", "Hari Kegiatan 2")
        dgServerMailTwo.Columns.Add("tanggal_kegiatan2", "Tanggal Kegiatan 2")
        dgServerMailTwo.Columns.Add("waktu_kegiatan2", "Waktu Kegiatan 2")
        dgServerMailTwo.Columns.Add("tempat_kegiatan2", "Tempat Kegiatan 2")

        For index = 0 To data2.Count - 1
            dgServerMailTwo.Rows.Add({
                data2.Item(index).nomor,
                data2.Item(index).lampiran,
                data2.Item(index).hal,
                data2.Item(index).tanggal_surat,
                data2.Item(index).diperuntukan,
                data2.Item(index).nama_kegiatan,
                data2.Item(index).tema_kegiatan,
                data2.Item(index).hari_kegiatan1,
                data2.Item(index).tanggal_kegiatan1,
                data2.Item(index).waktu_kegiatan1,
                data2.Item(index).tempat_kegiatan1,
                data2.Item(index).hari_kegiatan2,
                data2.Item(index).tanggal_kegiatan2,
                data2.Item(index).waktu_kegiatan2,
                data2.Item(index).tempat_kegiatan2
            })
        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    End Sub

    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles MetroTile4.Click
        Dim lengthMailOneClient As Integer = dgClientMailOne.RowCount

        For index = 0 To lengthMailOneClient - 1
            Dim dataToServer As MailOne = New MailOne()
            dataToServer.nomor = dgClientMailOne.Rows(index).Cells("nomor").Value.ToString()
            dataToServer.lampiran = dgClientMailOne.Rows(index).Cells("lampiran").Value.ToString()
            dataToServer.hal = dgClientMailOne.Rows(index).Cells("hal").Value.ToString()
            dataToServer.tanggal_surat = dgClientMailOne.Rows(index).Cells("tanggal_surat").Value.ToString()
            dataToServer.diperuntukan = dgClientMailOne.Rows(index).Cells("diperuntukan").Value.ToString()
            dataToServer.nama_kegiatan = dgClientMailOne.Rows(index).Cells("nama_kegiatan").Value.ToString()
            dataToServer.tema_kegiatan = dgClientMailOne.Rows(index).Cells("tema_kegiatan").Value.ToString()
            dataToServer.hari_kegiatan = dgClientMailOne.Rows(index).Cells("hari_kegiatan").Value.ToString()
            dataToServer.tanggal_kegiatan = dgClientMailOne.Rows(index).Cells("tanggal_kegiatan").Value.ToString()
            dataToServer.waktu_kegiatan = dgClientMailOne.Rows(index).Cells("waktu_kegiatan").Value.ToString()
            dataToServer.tempat_kegiatan = dgClientMailOne.Rows(index).Cells("tempat_kegiatan").Value.ToString()
            ConnectApi.MailOne(MethodApi.POST, dataToServer)
        Next

        deleteItemQuery = "delete from Undangan1Waktu"
        Try
            ad = New OleDbDataAdapter()
            ad.InsertCommand = New OleDbCommand(deleteItemQuery, connect)
            ad.InsertCommand.ExecuteNonQuery()
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
                ConnectAccess.Connection()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Next

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Dim lengthMailTwoClient As Integer = dgClientMailTwo.RowCount

        For index = 0 To lengthMailTwoClient - 1
            Dim dataToServer As MailTwo = New MailTwo()
            dataToServer.nomor = dgClientMailTwo.Rows(index).Cells("nomor").Value.ToString()
            dataToServer.lampiran = dgClientMailTwo.Rows(index).Cells("lampiran").Value.ToString()
            dataToServer.hal = dgClientMailTwo.Rows(index).Cells("hal").Value.ToString()
            dataToServer.tanggal_surat = dgClientMailTwo.Rows(index).Cells("tanggal_surat").Value.ToString()
            dataToServer.diperuntukan = dgClientMailTwo.Rows(index).Cells("diperuntukan").Value.ToString()
            dataToServer.nama_kegiatan = dgClientMailTwo.Rows(index).Cells("nama_kegiatan").Value.ToString()
            dataToServer.tema_kegiatan = dgClientMailTwo.Rows(index).Cells("tema_kegiatan").Value.ToString()
            dataToServer.hari_kegiatan1 = dgClientMailTwo.Rows(index).Cells("hari_kegiatan1").Value.ToString()
            dataToServer.tanggal_kegiatan1 = dgClientMailTwo.Rows(index).Cells("tanggal_kegiatan1").Value.ToString()
            dataToServer.waktu_kegiatan1 = dgClientMailTwo.Rows(index).Cells("waktu_kegiatan1").Value.ToString()
            dataToServer.tempat_kegiatan1 = dgClientMailTwo.Rows(index).Cells("tempat_kegiatan1").Value.ToString()
            dataToServer.hari_kegiatan2 = dgClientMailTwo.Rows(index).Cells("hari_kegiatan2").Value.ToString()
            dataToServer.tanggal_kegiatan2 = dgClientMailTwo.Rows(index).Cells("tanggal_kegiatan2").Value.ToString()
            dataToServer.waktu_kegiatan2 = dgClientMailTwo.Rows(index).Cells("waktu_kegiatan2").Value.ToString()
            dataToServer.tempat_kegiatan2 = dgClientMailTwo.Rows(index).Cells("tempat_kegiatan2").Value.ToString()
            ConnectApi.MailTwo(MethodApi.POST, dataToServer)
        Next

        deleteItemQuery = "delete from Undangan2Waktu"
        Try
            ad = New OleDbDataAdapter()
            ad.InsertCommand = New OleDbCommand(deleteItemQuery, connect)
            ad.InsertCommand.ExecuteNonQuery()
            ConnectAccess.Connection()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        ConnectApi.MailTwo(MethodApi.PUT_ELIMINATE_DUPLICATE)

        Dim dataToClient2 = JsonConvert.DeserializeObject(Of List(Of MailTwo))(ConnectApi.MailTwo(MethodApi.GET_ALL).ToString())

        For index = 0 To dataToClient2.Count - 1

            Dim saveItemQuery2 As String =
                "insert into Undangan2Waktu " &
            "(nomor, lampiran, hal, tanggal_surat, diperuntukan, nama_kegiatan, tema_kegiatan, hari_kegiatan1, tanggal_kegiatan1, waktu_kegiatan1, tempat_kegiatan1, hari_kegiatan2, tanggal_kegiatan2, waktu_kegiatan2, tempat_kegiatan2)" &
                "values ('" &
                dataToClient2.Item(index).nomor & "', '" &
                dataToClient2.Item(index).lampiran & "', '" &
                dataToClient2.Item(index).hal & "', '" &
                dataToClient2.Item(index).tanggal_surat & "', '" &
                dataToClient2.Item(index).diperuntukan & "', '" &
                dataToClient2.Item(index).nama_kegiatan & "', '" &
                dataToClient2.Item(index).tema_kegiatan & "', '" &
                dataToClient2.Item(index).hari_kegiatan1 & "', '" &
                dataToClient2.Item(index).tanggal_kegiatan1 & "', '" &
                dataToClient2.Item(index).waktu_kegiatan1 & "', '" &
                dataToClient2.Item(index).tempat_kegiatan1 &
                dataToClient2.Item(index).hari_kegiatan2 & "', '" &
                dataToClient2.Item(index).tanggal_kegiatan2 & "', '" &
                dataToClient2.Item(index).waktu_kegiatan2 & "', '" &
                dataToClient2.Item(index).tempat_kegiatan2 & "')"

            Try
                Dim ad2 = New OleDbDataAdapter
                ad2.InsertCommand = New OleDbCommand(saveItemQuery2, connect)
                ad2.InsertCommand.ExecuteNonQuery()
                ConnectAccess.Connection()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Next
    End Sub
End Class
