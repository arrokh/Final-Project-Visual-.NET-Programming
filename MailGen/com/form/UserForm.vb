Imports Newtonsoft.Json
Imports MailGen.com.sipp.connect
Public Class UserForm

    Private Sub btnLoadUserGetAll_Click(sender As Object, e As EventArgs) Handles btnLoadGetAll.Click
        Dim data = JsonConvert.DeserializeObject(Of List(Of User))(ConnectApi.User(MethodApi.GET_ALL).ToString())

        dgvUserGetAll.Columns.Clear()

        dgvUserGetAll.Columns.Add("id", "Id")
        dgvUserGetAll.Columns.Add("username", "Username")
        dgvUserGetAll.Columns.Add("password", "Password")
        dgvUserGetAll.Columns.Add("email", "Email")
        dgvUserGetAll.Columns.Add("full_name", "Full Name")
        dgvUserGetAll.Columns.Add("position", "Position")

        For index = 0 To data.Count - 1
            dgvUserGetAll.Rows.Add({
                data.Item(index).id.ToString(),
                data.Item(index).username,
                data.Item(index).password,
                data.Item(index).email,
                data.Item(index).full_name,
                data.Item(index).position
            })
        Next


    End Sub

    Private Sub btnLoadById_Click(sender As Object, e As EventArgs) Handles btnLoadById.Click
        Dim data = JsonConvert.DeserializeObject(Of List(Of User))(ConnectApi.User(MethodApi.GET_ALL).ToString())

        cbxId.Enabled = True

        cbxId.Items.Clear()

        For index = 0 To data.Count - 1
            cbxId.Items.Add(data.Item(index).id.ToString())
        Next

    End Sub

    Private Sub cbxId_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxId.SelectedValueChanged

        Dim selectedId As String = cbxId.SelectedItem.ToString()

        Dim data = JsonConvert.DeserializeObject(Of List(Of User))(ConnectApi.User(MethodApi.GET_BY_ID, selectedId).ToString())

        txtGetById.Text = data(0).id &
              vbNewLine & data(0).username &
              vbNewLine & data(0).password &
              vbNewLine & data(0).email &
              vbNewLine & data(0).full_name &
              vbNewLine & data(0).position

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim user As User = New User()
        user.username = txtUsername.Text
        user.password = txtPassword.Text
        user.full_name = txtFullName.Text
        user.email = txtEmail.Text
        user.position = txtPosition.Text

        ConnectApi.User(MethodApi.POST, user)

        txtUsername.Clear()
        txtPassword.Clear()
        txtFullName.Clear()
        txtEmail.Clear()
        txtPosition.Clear()

    End Sub

    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles TabPage3.Enter
        Dim data = JsonConvert.DeserializeObject(Of List(Of User))(ConnectApi.User(MethodApi.GET_ALL).ToString())

        ComboBox1.Enabled = True

        ComboBox1.Items.Clear()

        For index = 0 To data.Count - 1
            ComboBox1.Items.Add(data.Item(index).id.ToString())
        Next

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        Dim selectedId As String = ComboBox1.SelectedItem.ToString()

        Dim data = JsonConvert.DeserializeObject(Of List(Of User))(ConnectApi.User(MethodApi.GET_BY_ID, selectedId).ToString())

        txtUsernamePut.Text = data(0).username
        txtPasswordPut.Text = data(0).password
        txtEmailPut.Text = data(0).email
        txtFullnamePut.Text = data(0).full_name
        txtPositionPut.Text = data(0).position
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As User = New User()
        user.id = ComboBox1.SelectedItem
        user.username = txtUsernamePut.Text
        user.password = txtPasswordPut.Text
        user.full_name = txtFullnamePut.Text
        user.email = txtEmailPut.Text
        user.position = txtPositionPut.Text

        Dim data = ConnectApi.User(MethodApi.PUT, ComboBox1.SelectedItem.ToString(), user)

        MsgBox(data.ToString())

        txtUsernamePut.Clear()
        txtPasswordPut.Clear()
        txtEmailPut.Clear()
        txtFullnamePut.Clear()
        txtPositionPut.Clear()
    End Sub

    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
        Dim data = JsonConvert.DeserializeObject(Of List(Of User))(ConnectApi.User(MethodApi.GET_ALL).ToString())

        ComboBox2.Enabled = True

        ComboBox2.Items.Clear()

        For index = 0 To data.Count - 1
            ComboBox2.Items.Add(data.Item(index).id.ToString())
        Next
    End Sub

    Private Sub ComboBox2_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedValueChanged
        Dim selectedId As String = ComboBox2.SelectedItem.ToString()

        Dim data = JsonConvert.DeserializeObject(Of List(Of User))(ConnectApi.User(MethodApi.GET_BY_ID, selectedId).ToString())

        TextBox1.Text = data(0).id &
              vbNewLine & data(0).username &
              vbNewLine & data(0).password &
              vbNewLine & data(0).email &
              vbNewLine & data(0).full_name &
              vbNewLine & data(0).position
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Are you sure?", MsgBoxStyle.OkCancel) Then
            ConnectApi.User(MethodApi.DELETE, ComboBox2.SelectedItem.ToString())
        End If

    End Sub
End Class