Imports System.Data.OleDb
Imports Word = Microsoft.Office.Interop.Word

Public Class InvitationMailTwo
    Public changeStateFunc As Boolean = False
    Private Sub InvitationMailTwo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTabControl1.SelectTab(0)
        Call Connection()
        Call dateHolder()
        Call ShowDataGridView()

    End Sub

    Sub dateHolder()
        Dim month As String = MetroDateTime1.Value.Date.Month
        Dim monthName As String = ""

        If month.Equals("1") Then
            monthName = "Januari"
        ElseIf month.Equals("2") Then
            monthName = "Februari"
        ElseIf month.Equals("3") Then
            monthName = "Maret"
        ElseIf month.Equals("4") Then
            monthName = "April"
        ElseIf month.Equals("5") Then
            monthName = "Mei"
        ElseIf month.Equals("6") Then
            monthName = "Juni"
        ElseIf month.Equals("7") Then
            monthName = "Juli"
        ElseIf month.Equals("8") Then
            monthName = "Agustus"
        ElseIf month.Equals("9") Then
            monthName = "September"
        ElseIf month.Equals("10") Then
            monthName = "Oktober"
        ElseIf month.Equals("11") Then
            monthName = "November"
        ElseIf month.Equals("12") Then
            monthName = "Desember"
        End If
        MetroDateTime1.Format = DateTimePickerFormat.Custom
        MetroDateTime1.CustomFormat = "dd " & monthName & " yyyy"

    End Sub

    Private Sub insertItemDb()
        saveItemQuery = "insert into Undangan2Waktu " &
            "(nomor, lampiran, hal, tanggal_surat, diperuntukan, nama_kegiatan, tema_kegiatan, hari_kegiatan1, tanggal_kegiatan1, waktu_kegiatan1, tempat_kegiatan1, hari_kegiatan2, tanggal_kegiatan2, waktu_kegiatan2, tempat_kegiatan2)" &
            " values ('" & txtMailNumber.Text & "', '" & txtAttachment.Text & "', '" & txtAbout.Text & "', '" &
                                                            MetroDateTime1.Text & "', '" & txtDestinationMail.Text & "', '" & txtEventName.Text & "', '" &
                                                            txtEventTheme.Text & "', '" & txtDayEvent1.Text & "', '" & txtDateEvent1.Text & "', '" &
                                                            txtTimeEvent1.Text & "', '" & txtPlaceEvent.Text & "', '" & txtDayEvent2.Text & "', '" &
                                                            txtDateEvent2.Text & "', '" & txtTimeEvent2.Text & "', '" & txtPlaceEvent2.Text & "')"
        Try
            ad = New OleDbDataAdapter
            ad.InsertCommand = New OleDbCommand(saveItemQuery, connect)
            ad.InsertCommand.ExecuteNonQuery()
            Connection()
            MetroFramework.MetroMessageBox.Show(Me, "Successfully save data", "Berhasil", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub updateItemDb()
        Dim i As Integer
        i = MetroGrid1.CurrentRow.Index
        editItemQuery = "update Undangan2Waktu set Nomor = '" & txtMailNumber.Text & "', Lampiran = '" & txtAttachment.Text & "', Hal = '" & txtAbout.Text &
                                                           "', Tanggal_Surat ='" & MetroDateTime1.Text & "', Diperuntukan = '" & txtDestinationMail.Text &
                                                           "', Nama_Kegiatan = '" & txtEventName.Text & "', Tema_Kegiatan = '" & txtEventTheme.Text &
                                                           "', Hari_Kegiatan1 ='" & txtDayEvent1.Text & "', Tanggal_Kegiatan1 = '" & txtDateEvent1.Text &
                                                           "', Waktu_Kegiatan1 = '" & txtTimeEvent1.Text & "', Tempat_Kegiatan1 = '" & txtPlaceEvent.Text &
                                                           "', Hari_Kegiatan2 ='" & txtDayEvent2.Text & "', Tanggal_Kegiatan2 = '" & txtDateEvent2.Text &
                                                           "', Waktu_Kegiatan2 = '" & txtTimeEvent2.Text & "', Tempat_Kegiatan2 = '" & txtPlaceEvent2.Text & "' where Nomor = '" & MetroGrid1.Item(1, i).Value & "'"
        Try
            ad = New OleDbDataAdapter()
            ad.InsertCommand = New OleDbCommand(editItemQuery, connect)
            ad.InsertCommand.ExecuteNonQuery()
            Connection()
            MetroFramework.MetroMessageBox.Show(Me, "Successfully change data", "Success", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub
    Private Sub deleteItemDb()
        Dim i As Integer
        Dim confirmDelete As String
        i = MetroGrid1.CurrentRow.Index
        confirmDelete = MetroFramework.MetroMessageBox.Show(Me, "Are you sure to delete this selected data ?", "Warning", _
                                                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If confirmDelete = vbOK Then
            deleteItemQuery = "delete from Undangan2Waktu where Nomor = '" & MetroGrid1.Item(1, i).Value & "'"
            Try
                ad = New OleDbDataAdapter()
                ad.InsertCommand = New OleDbCommand(deleteItemQuery, connect)
                ad.InsertCommand.ExecuteNonQuery()
                Connection()
                MetroFramework.MetroMessageBox.Show(Me, "Successfully delete selected data", "Success", _
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End If
    End Sub

    Private Sub ShowDataGridView()
        Try
            ad = New OleDbDataAdapter("select * from Undangan2Waktu", connect)
            ds = New DataSet
            ad.Fill(ds, "Undangan2Waktu")
            MetroGrid1.DataSource = ds.Tables("UNdangan2Waktu")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub pickDbItem()
        Try
            Dim i As Integer
            i = MetroGrid1.CurrentRow.Index
            Me.txtMailNumber.Text = MetroGrid1.Item(0, i).Value
            Me.txtAttachment.Text = MetroGrid1.Item(1, i).Value
            Me.txtAbout.Text = MetroGrid1.Item(2, i).Value
            Me.txtDestinationMail.Text = MetroGrid1.Item(4, i).Value
            Me.txtEventName.Text = MetroGrid1.Item(5, i).Value
            Me.txtEventTheme.Text = MetroGrid1.Item(6, i).Value
            Me.txtDayEvent1.Text = MetroGrid1.Item(7, i).Value
            Me.txtDateEvent1.Text = MetroGrid1.Item(8, i).Value
            Me.txtTimeEvent1.Text = MetroGrid1.Item(9, i).Value
            Me.txtPlaceEvent.Text = MetroGrid1.Item(10, i).Value
            Me.txtDayEvent2.Text = MetroGrid1.Item(11, i).Value
            Me.txtDateEvent2.Text = MetroGrid1.Item(12, i).Value
            Me.txtTimeEvent2.Text = MetroGrid1.Item(13, i).Value
            Me.txtPlaceEvent2.Text = MetroGrid1.Item(14, i).Value
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub printDbItem()

        Dim ObjAppWord As New Word.Application
        Dim ObjDocWord As New Word.Document

        Try
            ObjDocWord = ObjAppWord.Documents.Open(Application.StartupPath & "\Surat undangan 2 format.docx")
            ObjDocWord.Bookmarks("NoSu").Select()
            ObjAppWord.Selection.TypeText(txtMailNumber.Text)

            ObjDocWord.Bookmarks("TanggalSurat").Select()
            ObjAppWord.Selection.TypeText(MetroDateTime1.Text)

            ObjDocWord.Bookmarks("Hal").Select()
            ObjAppWord.Selection.TypeText(txtAbout.Text)

            ObjDocWord.Bookmarks("Lampiran").Select()
            ObjAppWord.Selection.TypeText(txtAttachment.Text)

            ObjDocWord.Bookmarks("Diperuntukan").Select()
            ObjAppWord.Selection.TypeText(txtDestinationMail.Text)

            ObjDocWord.Bookmarks("NamaKegiatan").Select()
            ObjAppWord.Selection.TypeText(txtEventName.Text)

            ObjDocWord.Bookmarks("TemaKegiatan").Select()
            ObjAppWord.Selection.TypeText(txtEventTheme.Text)

            ObjDocWord.Bookmarks("HariKegiatan1").Select()
            ObjAppWord.Selection.TypeText(txtDayEvent1.Text)

            ObjDocWord.Bookmarks("TanggalKegiatan1").Select()
            ObjAppWord.Selection.TypeText(txtDateEvent1.Text)

            ObjDocWord.Bookmarks("WaktuKegiatan1").Select()
            ObjAppWord.Selection.TypeText(txtTimeEvent1.Text)

            ObjDocWord.Bookmarks("TempatKegiatan1").Select()
            ObjAppWord.Selection.TypeText(txtPlaceEvent.Text)

            ObjDocWord.Bookmarks("HariKegiatan2").Select()
            ObjAppWord.Selection.TypeText(txtDayEvent2.Text)

            ObjDocWord.Bookmarks("TanggalKegiatan2").Select()
            ObjAppWord.Selection.TypeText(txtDateEvent2.Text)

            ObjDocWord.Bookmarks("WaktuKegiatan2").Select()
            ObjAppWord.Selection.TypeText(txtTimeEvent2.Text)

            ObjDocWord.Bookmarks("TempatKegiatan2").Select()
            ObjAppWord.Selection.TypeText(txtPlaceEvent2.Text)
            ObjAppWord.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
       
    End Sub
    Private Sub btnNextHeader_Click(sender As Object, e As EventArgs) Handles btnNextHeader.Click
        MetroTabControl1.SelectTab(1)
    End Sub

    Private Sub btnNextContent_Click(sender As Object, e As EventArgs) Handles btnNextContent.Click
        MetroTabControl1.SelectTab(2)
    End Sub
    Private Sub btnPrevContent_Click(sender As Object, e As EventArgs) Handles btnPrevContent.Click
        MetroTabControl1.SelectTab(0)
    End Sub
    Private Sub btnPrevFooter_Click(sender As Object, e As EventArgs) Handles btnPrevFooter.Click
        MetroTabControl1.SelectTab(1)
    End Sub

    Private Sub btnProccess_Click(sender As Object, e As EventArgs) Handles btnProccess.Click
        If changeStateFunc = False Then
            Call insertItemDb()
            Call ShowDataGridView()
            MetroTabControl1.SelectTab(3)
        ElseIf changeStateFunc = True Then
            Call updateItemDb()
            Call ShowDataGridView()
            MetroTabControl1.SelectTab(3)
            changeStateFunc = False
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        changeStateFunc = True
        Call pickDbItem()
        MetroTabControl1.SelectTab(0)
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call deleteItemDb()
        Call ShowDataGridView()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call pickDbItem()
        Call printDbItem()
    End Sub

    Private Sub MetroTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MetroTextBox1.TextChanged
        Try
            ad = New OleDbDataAdapter("select * from Undangan2Waktu where nomor like  '%" & MetroTextBox1.Text & "%' ", connect)
            ds = New DataSet
            ad.Fill(ds, "Undangan2Waktu")
            MetroGrid1.DataSource = ds.Tables("Undangan2Waktu")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
End Class