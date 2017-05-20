<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvitationMailOne
    Inherits MetroFramework.Forms.MetroForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.btnNextHeader = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.txtAbout = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtAttachment = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtMailNumber = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.btnPrevContent = New MetroFramework.Controls.MetroButton()
        Me.btnNextContent = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtEventTheme = New MetroFramework.Controls.MetroTextBox()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.txtEventName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.btnPrevFooter = New MetroFramework.Controls.MetroButton()
        Me.btnProccess = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.txtPlaceEvent = New MetroFramework.Controls.MetroTextBox()
        Me.txtTimeEvent = New MetroFramework.Controls.MetroTextBox()
        Me.txtDateEvent = New MetroFramework.Controls.MetroTextBox()
        Me.txtDayEvent = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTabPage4 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.btnDelete = New MetroFramework.Controls.MetroButton()
        Me.btnEdit = New MetroFramework.Controls.MetroButton()
        Me.btnPrint = New MetroFramework.Controls.MetroButton()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        Me.MetroTabPage4.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage4)
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 63)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 3
        Me.MetroTabControl1.Size = New System.Drawing.Size(633, 329)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel12)
        Me.MetroTabPage1.Controls.Add(Me.btnNextHeader)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel4)
        Me.MetroTabPage1.Controls.Add(Me.MetroDateTime1)
        Me.MetroTabPage1.Controls.Add(Me.txtAbout)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage1.Controls.Add(Me.txtAttachment)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel1)
        Me.MetroTabPage1.Controls.Add(Me.txtMailNumber)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(625, 287)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Header"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MetroLabel12.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.MetroLabel12.Location = New System.Drawing.Point(119, 9)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(0, 0)
        Me.MetroLabel12.TabIndex = 11
        '
        'btnNextHeader
        '
        Me.btnNextHeader.Location = New System.Drawing.Point(537, 225)
        Me.btnNextHeader.Name = "btnNextHeader"
        Me.btnNextHeader.Size = New System.Drawing.Size(88, 27)
        Me.btnNextHeader.TabIndex = 10
        Me.btnNextHeader.Text = "Next"
        Me.btnNextHeader.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(359, 9)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "Tanggal Surat"
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.Location = New System.Drawing.Point(391, 41)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(4, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(200, 29)
        Me.MetroDateTime1.TabIndex = 8
        '
        'txtAbout
        '
        '
        '
        '
        Me.txtAbout.CustomButton.Image = Nothing
        Me.txtAbout.CustomButton.Location = New System.Drawing.Point(254, 1)
        Me.txtAbout.CustomButton.Name = ""
        Me.txtAbout.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtAbout.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAbout.CustomButton.TabIndex = 1
        Me.txtAbout.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAbout.CustomButton.UseSelectable = True
        Me.txtAbout.CustomButton.Visible = False
        Me.txtAbout.Enabled = False
        Me.txtAbout.Lines = New String() {"Undangan"}
        Me.txtAbout.Location = New System.Drawing.Point(40, 180)
        Me.txtAbout.MaxLength = 32767
        Me.txtAbout.Name = "txtAbout"
        Me.txtAbout.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAbout.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAbout.SelectedText = ""
        Me.txtAbout.SelectionLength = 0
        Me.txtAbout.SelectionStart = 0
        Me.txtAbout.Size = New System.Drawing.Size(276, 23)
        Me.txtAbout.TabIndex = 7
        Me.txtAbout.Text = "Undangan"
        Me.txtAbout.UseSelectable = True
        Me.txtAbout.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAbout.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(14, 146)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Perihal"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(14, 78)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "Lampiran"
        '
        'txtAttachment
        '
        '
        '
        '
        Me.txtAttachment.CustomButton.Image = Nothing
        Me.txtAttachment.CustomButton.Location = New System.Drawing.Point(254, 1)
        Me.txtAttachment.CustomButton.Name = ""
        Me.txtAttachment.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtAttachment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAttachment.CustomButton.TabIndex = 1
        Me.txtAttachment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAttachment.CustomButton.UseSelectable = True
        Me.txtAttachment.CustomButton.Visible = False
        Me.txtAttachment.Lines = New String(-1) {}
        Me.txtAttachment.Location = New System.Drawing.Point(40, 110)
        Me.txtAttachment.MaxLength = 32767
        Me.txtAttachment.Name = "txtAttachment"
        Me.txtAttachment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAttachment.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAttachment.SelectedText = ""
        Me.txtAttachment.SelectionLength = 0
        Me.txtAttachment.SelectionStart = 0
        Me.txtAttachment.Size = New System.Drawing.Size(276, 23)
        Me.txtAttachment.TabIndex = 4
        Me.MetroToolTip1.SetToolTip(Me.txtAttachment, "ex: 1 (satu) lembar")
        Me.txtAttachment.UseSelectable = True
        Me.txtAttachment.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAttachment.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(14, 9)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "Nomor Surat"
        '
        'txtMailNumber
        '
        '
        '
        '
        Me.txtMailNumber.CustomButton.Image = Nothing
        Me.txtMailNumber.CustomButton.Location = New System.Drawing.Point(254, 1)
        Me.txtMailNumber.CustomButton.Name = ""
        Me.txtMailNumber.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMailNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMailNumber.CustomButton.TabIndex = 1
        Me.txtMailNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMailNumber.CustomButton.UseSelectable = True
        Me.txtMailNumber.CustomButton.Visible = False
        Me.txtMailNumber.Lines = New String(-1) {}
        Me.txtMailNumber.Location = New System.Drawing.Point(40, 41)
        Me.txtMailNumber.MaxLength = 32767
        Me.txtMailNumber.Name = "txtMailNumber"
        Me.txtMailNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMailNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMailNumber.SelectedText = ""
        Me.txtMailNumber.SelectionLength = 0
        Me.txtMailNumber.SelectionStart = 0
        Me.txtMailNumber.Size = New System.Drawing.Size(276, 23)
        Me.txtMailNumber.TabIndex = 2
        Me.MetroToolTip1.SetToolTip(Me.txtMailNumber, "ex: 11.8.6/UN32.5.6.6/LK/2015")
        Me.txtMailNumber.UseSelectable = True
        Me.txtMailNumber.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMailNumber.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.btnPrevContent)
        Me.MetroTabPage2.Controls.Add(Me.btnNextContent)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel7)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel6)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel5)
        Me.MetroTabPage2.Controls.Add(Me.txtEventTheme)
        Me.MetroTabPage2.Controls.Add(Me.txtDestination)
        Me.MetroTabPage2.Controls.Add(Me.txtEventName)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(625, 287)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Content"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'btnPrevContent
        '
        Me.btnPrevContent.Location = New System.Drawing.Point(445, 225)
        Me.btnPrevContent.Name = "btnPrevContent"
        Me.btnPrevContent.Size = New System.Drawing.Size(88, 27)
        Me.btnPrevContent.TabIndex = 12
        Me.btnPrevContent.Text = "Previous"
        Me.btnPrevContent.UseSelectable = True
        '
        'btnNextContent
        '
        Me.btnNextContent.Location = New System.Drawing.Point(537, 225)
        Me.btnNextContent.Name = "btnNextContent"
        Me.btnNextContent.Size = New System.Drawing.Size(88, 27)
        Me.btnNextContent.TabIndex = 11
        Me.btnNextContent.Text = "Next"
        Me.btnNextContent.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(12, 131)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(85, 19)
        Me.MetroLabel7.TabIndex = 7
        Me.MetroLabel7.Text = "Alamat Surat"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(12, 69)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(94, 19)
        Me.MetroLabel6.TabIndex = 6
        Me.MetroLabel6.Text = "Tema Kegiatan"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(12, 10)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(99, 19)
        Me.MetroLabel5.TabIndex = 5
        Me.MetroLabel5.Text = "Nama Kegiatan"
        '
        'txtEventTheme
        '
        '
        '
        '
        Me.txtEventTheme.CustomButton.Image = Nothing
        Me.txtEventTheme.CustomButton.Location = New System.Drawing.Point(436, 1)
        Me.txtEventTheme.CustomButton.Name = ""
        Me.txtEventTheme.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEventTheme.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEventTheme.CustomButton.TabIndex = 1
        Me.txtEventTheme.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEventTheme.CustomButton.UseSelectable = True
        Me.txtEventTheme.CustomButton.Visible = False
        Me.txtEventTheme.Lines = New String(-1) {}
        Me.txtEventTheme.Location = New System.Drawing.Point(37, 99)
        Me.txtEventTheme.MaxLength = 32767
        Me.txtEventTheme.Name = "txtEventTheme"
        Me.txtEventTheme.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEventTheme.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEventTheme.SelectedText = ""
        Me.txtEventTheme.SelectionLength = 0
        Me.txtEventTheme.SelectionStart = 0
        Me.txtEventTheme.Size = New System.Drawing.Size(458, 23)
        Me.txtEventTheme.TabIndex = 4
        Me.txtEventTheme.UseSelectable = True
        Me.txtEventTheme.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEventTheme.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDestination
        '
        Me.txtDestination.Location = New System.Drawing.Point(37, 158)
        Me.txtDestination.Multiline = True
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(282, 77)
        Me.txtDestination.TabIndex = 3
        Me.MetroToolTip1.SetToolTip(Me.txtDestination, "ex : Yth. Ketua Jurusan Teknik Elektro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fakultas Teknik Universitas Negeri Malang" & _
        "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jalan Semarang 5, Malang" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'txtEventName
        '
        '
        '
        '
        Me.txtEventName.CustomButton.Image = Nothing
        Me.txtEventName.CustomButton.Location = New System.Drawing.Point(484, 1)
        Me.txtEventName.CustomButton.Name = ""
        Me.txtEventName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEventName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEventName.CustomButton.TabIndex = 1
        Me.txtEventName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEventName.CustomButton.UseSelectable = True
        Me.txtEventName.CustomButton.Visible = False
        Me.txtEventName.Lines = New String(-1) {}
        Me.txtEventName.Location = New System.Drawing.Point(37, 38)
        Me.txtEventName.MaxLength = 32767
        Me.txtEventName.Name = "txtEventName"
        Me.txtEventName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEventName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEventName.SelectedText = ""
        Me.txtEventName.SelectionLength = 0
        Me.txtEventName.SelectionStart = 0
        Me.txtEventName.Size = New System.Drawing.Size(506, 23)
        Me.txtEventName.TabIndex = 2
        Me.txtEventName.UseSelectable = True
        Me.txtEventName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEventName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.btnPrevFooter)
        Me.MetroTabPage3.Controls.Add(Me.btnProccess)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel11)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel10)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel9)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel8)
        Me.MetroTabPage3.Controls.Add(Me.txtPlaceEvent)
        Me.MetroTabPage3.Controls.Add(Me.txtTimeEvent)
        Me.MetroTabPage3.Controls.Add(Me.txtDateEvent)
        Me.MetroTabPage3.Controls.Add(Me.txtDayEvent)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(625, 287)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Footer"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'btnPrevFooter
        '
        Me.btnPrevFooter.Location = New System.Drawing.Point(445, 225)
        Me.btnPrevFooter.Name = "btnPrevFooter"
        Me.btnPrevFooter.Size = New System.Drawing.Size(88, 27)
        Me.btnPrevFooter.TabIndex = 14
        Me.btnPrevFooter.Text = "Previous"
        Me.btnPrevFooter.UseSelectable = True
        '
        'btnProccess
        '
        Me.btnProccess.Location = New System.Drawing.Point(537, 225)
        Me.btnProccess.Name = "btnProccess"
        Me.btnProccess.Size = New System.Drawing.Size(88, 27)
        Me.btnProccess.TabIndex = 13
        Me.btnProccess.Text = "Proccess"
        Me.btnProccess.UseSelectable = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(53, 160)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel11.TabIndex = 10
        Me.MetroLabel11.Text = "Tempat"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(51, 109)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel10.TabIndex = 9
        Me.MetroLabel10.Text = "Waktu"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(51, 57)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel9.TabIndex = 8
        Me.MetroLabel9.Text = "Tanggal"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(51, 6)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(33, 19)
        Me.MetroLabel8.TabIndex = 7
        Me.MetroLabel8.Text = "Hari"
        '
        'txtPlaceEvent
        '
        '
        '
        '
        Me.txtPlaceEvent.CustomButton.Image = Nothing
        Me.txtPlaceEvent.CustomButton.Location = New System.Drawing.Point(276, 1)
        Me.txtPlaceEvent.CustomButton.Name = ""
        Me.txtPlaceEvent.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPlaceEvent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPlaceEvent.CustomButton.TabIndex = 1
        Me.txtPlaceEvent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPlaceEvent.CustomButton.UseSelectable = True
        Me.txtPlaceEvent.CustomButton.Visible = False
        Me.txtPlaceEvent.Lines = New String(-1) {}
        Me.txtPlaceEvent.Location = New System.Drawing.Point(84, 184)
        Me.txtPlaceEvent.MaxLength = 32767
        Me.txtPlaceEvent.Name = "txtPlaceEvent"
        Me.txtPlaceEvent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPlaceEvent.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPlaceEvent.SelectedText = ""
        Me.txtPlaceEvent.SelectionLength = 0
        Me.txtPlaceEvent.SelectionStart = 0
        Me.txtPlaceEvent.Size = New System.Drawing.Size(298, 23)
        Me.txtPlaceEvent.TabIndex = 6
        Me.txtPlaceEvent.UseSelectable = True
        Me.txtPlaceEvent.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPlaceEvent.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTimeEvent
        '
        '
        '
        '
        Me.txtTimeEvent.CustomButton.Image = Nothing
        Me.txtTimeEvent.CustomButton.Location = New System.Drawing.Point(199, 1)
        Me.txtTimeEvent.CustomButton.Name = ""
        Me.txtTimeEvent.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTimeEvent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTimeEvent.CustomButton.TabIndex = 1
        Me.txtTimeEvent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTimeEvent.CustomButton.UseSelectable = True
        Me.txtTimeEvent.CustomButton.Visible = False
        Me.txtTimeEvent.Lines = New String(-1) {}
        Me.txtTimeEvent.Location = New System.Drawing.Point(84, 134)
        Me.txtTimeEvent.MaxLength = 32767
        Me.txtTimeEvent.Name = "txtTimeEvent"
        Me.txtTimeEvent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTimeEvent.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTimeEvent.SelectedText = ""
        Me.txtTimeEvent.SelectionLength = 0
        Me.txtTimeEvent.SelectionStart = 0
        Me.txtTimeEvent.Size = New System.Drawing.Size(221, 23)
        Me.txtTimeEvent.TabIndex = 5
        Me.MetroToolTip1.SetToolTip(Me.txtTimeEvent, "08.00-10.00 WIB")
        Me.txtTimeEvent.UseSelectable = True
        Me.txtTimeEvent.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTimeEvent.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDateEvent
        '
        '
        '
        '
        Me.txtDateEvent.CustomButton.Image = Nothing
        Me.txtDateEvent.CustomButton.Location = New System.Drawing.Point(199, 1)
        Me.txtDateEvent.CustomButton.Name = ""
        Me.txtDateEvent.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDateEvent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDateEvent.CustomButton.TabIndex = 1
        Me.txtDateEvent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDateEvent.CustomButton.UseSelectable = True
        Me.txtDateEvent.CustomButton.Visible = False
        Me.txtDateEvent.Lines = New String(-1) {}
        Me.txtDateEvent.Location = New System.Drawing.Point(84, 83)
        Me.txtDateEvent.MaxLength = 32767
        Me.txtDateEvent.Name = "txtDateEvent"
        Me.txtDateEvent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDateEvent.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDateEvent.SelectedText = ""
        Me.txtDateEvent.SelectionLength = 0
        Me.txtDateEvent.SelectionStart = 0
        Me.txtDateEvent.Size = New System.Drawing.Size(221, 23)
        Me.txtDateEvent.TabIndex = 4
        Me.MetroToolTip1.SetToolTip(Me.txtDateEvent, "ex: 20 - 21 Agustus 2015")
        Me.txtDateEvent.UseSelectable = True
        Me.txtDateEvent.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDateEvent.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDayEvent
        '
        '
        '
        '
        Me.txtDayEvent.CustomButton.Image = Nothing
        Me.txtDayEvent.CustomButton.Location = New System.Drawing.Point(276, 1)
        Me.txtDayEvent.CustomButton.Name = ""
        Me.txtDayEvent.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDayEvent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDayEvent.CustomButton.TabIndex = 1
        Me.txtDayEvent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDayEvent.CustomButton.UseSelectable = True
        Me.txtDayEvent.CustomButton.Visible = False
        Me.txtDayEvent.Lines = New String(-1) {}
        Me.txtDayEvent.Location = New System.Drawing.Point(84, 28)
        Me.txtDayEvent.MaxLength = 32767
        Me.txtDayEvent.Name = "txtDayEvent"
        Me.txtDayEvent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDayEvent.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDayEvent.SelectedText = ""
        Me.txtDayEvent.SelectionLength = 0
        Me.txtDayEvent.SelectionStart = 0
        Me.txtDayEvent.Size = New System.Drawing.Size(298, 23)
        Me.txtDayEvent.TabIndex = 3
        Me.MetroToolTip1.SetToolTip(Me.txtDayEvent, "ex: Sabtu s/d Minggu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.txtDayEvent.UseSelectable = True
        Me.txtDayEvent.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDayEvent.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTabPage4
        '
        Me.MetroTabPage4.Controls.Add(Me.MetroLabel13)
        Me.MetroTabPage4.Controls.Add(Me.MetroTextBox1)
        Me.MetroTabPage4.Controls.Add(Me.btnDelete)
        Me.MetroTabPage4.Controls.Add(Me.btnEdit)
        Me.MetroTabPage4.Controls.Add(Me.btnPrint)
        Me.MetroTabPage4.Controls.Add(Me.MetroGrid1)
        Me.MetroTabPage4.HorizontalScrollbarBarColor = True
        Me.MetroTabPage4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.HorizontalScrollbarSize = 10
        Me.MetroTabPage4.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage4.Name = "MetroTabPage4"
        Me.MetroTabPage4.Size = New System.Drawing.Size(625, 287)
        Me.MetroTabPage4.TabIndex = 3
        Me.MetroTabPage4.Text = "Value"
        Me.MetroTabPage4.VerticalScrollbarBarColor = True
        Me.MetroTabPage4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.VerticalScrollbarSize = 10
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(348, 7)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel13.TabIndex = 7
        Me.MetroLabel13.Text = "Search"
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(188, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(412, 7)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.Size = New System.Drawing.Size(210, 23)
        Me.MetroTextBox1.TabIndex = 6
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(269, 247)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(99, 27)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseSelectable = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(152, 247)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(99, 27)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseSelectable = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(35, 247)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(99, 27)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseSelectable = True
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(0, 39)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(626, 187)
        Me.MetroGrid1.TabIndex = 2
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Tag = "info"
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'InvitationMailOne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 426)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Name = "InvitationMailOne"
        Me.Text = "Surat Undangan"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage3.PerformLayout()
        Me.MetroTabPage4.ResumeLayout(False)
        Me.MetroTabPage4.PerformLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txtAbout As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtAttachment As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMailNumber As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btnNextHeader As MetroFramework.Controls.MetroButton
    Friend WithEvents txtEventName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEventTheme As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDestination As System.Windows.Forms.TextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnPrevContent As MetroFramework.Controls.MetroButton
    Friend WithEvents btnNextContent As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPlaceEvent As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTimeEvent As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDateEvent As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDayEvent As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTabPage4 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnPrevFooter As MetroFramework.Controls.MetroButton
    Friend WithEvents btnProccess As MetroFramework.Controls.MetroButton
    Friend WithEvents btnPrint As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEdit As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDelete As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
End Class
