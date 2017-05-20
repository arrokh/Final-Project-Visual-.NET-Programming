Imports System.Data.OleDb
Imports Word = Microsoft.Office.Interop.Word
Imports System.IO


Public Class InvitationMailOne
    Public changeStateFunc As Boolean = False
    Private Sub InvitationMailOne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        saveItemQuery = "insert into Undangan1Waktu " &
            "(nomor, lampiran, hal, tanggal_surat, diperuntukan, nama_kegiatan, tema_kegiatan, hari_kegiatan, tanggal_kegiatan, waktu_kegiatan, tempat_kegiatan)" &
            "values ('" & txtMailNumber.Text & "', '" & txtAttachment.Text & "', '" & txtAbout.Text & "', '" &
                                                           MetroDateTime1.Text & "', '" & txtDestination.Text & "', '" & txtEventName.Text & "', '" &
                                                           txtEventTheme.Text & "', '" & txtDayEvent.Text & "', '" & txtDateEvent.Text & "', '" &
                                                           txtTimeEvent.Text & "', '" & txtPlaceEvent.Text & "')"
        Try
            ad = New OleDbDataAdapter()
            ad.InsertCommand = New OleDbCommand(saveItemQuery, connect)
            ad.InsertCommand.ExecuteNonQuery()
            connect.Close()
            Connection()
            MetroFramework.MetroMessageBox.Show(Me, "Successfully save data", "Success", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub updateItemDb()
        Dim i As Integer
        i = MetroGrid1.CurrentRow.Index

        editItemQuery = "update Undangan1Waktu set Nomor = '" & txtMailNumber.Text & "', Lampiran = '" & txtAttachment.Text & "', Hal = '" & txtAbout.Text & "', Tanggal_Surat = '" &
                                                            MetroDateTime1.Text & "', Diperuntukan = '" & txtDestination.Text & "', Nama_Kegiatan = '" & txtEventName.Text & "', Tema_Kegiatan = '" &
                                                            txtEventTheme.Text & "', Hari_Kegiatan = '" & txtDayEvent.Text & "', Tanggal_Kegiatan = '" & txtDateEvent.Text & "', Waktu_Kegiatan = '" &
                                                            txtTimeEvent.Text & "', Tempat_Kegiatan = '" & txtPlaceEvent.Text & "' where Nomor = '" & MetroGrid1.Item(1, i).Value & "'"
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
        Dim confirmDelete As String
        Dim i As Integer
        i = MetroGrid1.CurrentRow.Index
        confirmDelete = MetroFramework.MetroMessageBox.Show(Me, "Are you sure to delete this selected data ?", "Warning", _
                                                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If confirmDelete = vbOK Then
            deleteItemQuery = "delete from Undangan1Waktu where Nomor = '" & MetroGrid1.Item(1, i).Value & "'"
            Try
                ad = New OleDbDataAdapter()
                ad.InsertCommand = New OleDbCommand(deleteItemQuery, connect)
                ad.InsertCommand.ExecuteNonQuery()
                connect.Close()
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
            ad = New OleDbDataAdapter("select * from Undangan1Waktu", connect)
            ds = New DataSet
            ad.Fill(ds, "Undangan1Waktu")
            MetroGrid1.DataSource = ds.Tables("Undangan1Waktu")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
       
    End Sub

    Private Sub pickDbItem()
        Try
            Dim i As Integer
            i = MetroGrid1.CurrentRow.Index
            Me.txtMailNumber.Text = MetroGrid1.Item(1, i).Value
            Me.txtAttachment.Text = MetroGrid1.Item(2, i).Value
            Me.txtAbout.Text = MetroGrid1.Item(3, i).Value
            Me.txtDestination.Text = MetroGrid1(4, i).Value
            Me.txtEventName.Text = MetroGrid1(5, i).Value
            Me.txtEventTheme.Text = MetroGrid1(6, i).Value
            Me.txtDayEvent.Text = MetroGrid1(7, i).Value
            Me.txtDateEvent.Text = MetroGrid1(8, i).Value
            Me.txtTimeEvent.Text = MetroGrid1(9, i).Value
            Me.txtPlaceEvent.Text = MetroGrid1(10, i).Value
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub printDbItem()
        Try
            Dim ObjAppWord As New Word.Application
            Dim ObjDocWord As New Word.Document

            ObjDocWord = ObjAppWord.Documents.Open(Application.StartupPath & "\Surat undangan 1 format.docx")
            ObjDocWord.Bookmarks("NoSu").Select()
            ObjAppWord.Selection.TypeText(txtMailNumber.Text)

            ObjDocWord.Bookmarks("TanggalSurat").Select()
            ObjAppWord.Selection.TypeText(MetroDateTime1.Text)

            ObjDocWord.Bookmarks("Hal").Select()
            ObjAppWord.Selection.TypeText(txtAbout.Text)

            ObjDocWord.Bookmarks("Lampiran").Select()
            ObjAppWord.Selection.TypeText(txtAttachment.Text)

            ObjDocWord.Bookmarks("Diperuntukan").Select()
            ObjAppWord.Selection.TypeText(txtDestination.Text)

            ObjDocWord.Bookmarks("NamaKegiatan").Select()
            ObjAppWord.Selection.TypeText(txtEventName.Text)

            ObjDocWord.Bookmarks("TemaKegiatan").Select()
            ObjAppWord.Selection.TypeText(txtEventTheme.Text)

            ObjDocWord.Bookmarks("HariKegiatan").Select()
            ObjAppWord.Selection.TypeText(txtDayEvent.Text)

            ObjDocWord.Bookmarks("TanggalKegiatan").Select()
            ObjAppWord.Selection.TypeText(txtDateEvent.Text)

            ObjDocWord.Bookmarks("WaktuKegiatan").Select()
            ObjAppWord.Selection.TypeText(txtTimeEvent.Text)

            ObjDocWord.Bookmarks("TempatKegiatan").Select()
            ObjAppWord.Selection.TypeText(txtPlaceEvent.Text)

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
  
    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call deleteItemDb()
        Call ShowDataGridView()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call pickDbItem()
        Call printDbItem()
    End Sub

    Private Sub MetroTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MetroTextBox1.TextChanged

        Try
            ad = New OleDbDataAdapter("select * from Undangan1Waktu where nomor like  '%" & MetroTextBox1.Text & "%' ", connect)
            ds = New DataSet
            ad.Fill(ds, "Undangan1Waktu")
            MetroGrid1.DataSource = ds.Tables("Undangan1Waktu")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

End Class