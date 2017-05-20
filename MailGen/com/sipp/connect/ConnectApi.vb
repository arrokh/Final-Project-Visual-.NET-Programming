Imports RestSharp

Namespace com.sipp.connect
    Public Module ConnectApi
        Public Enum MethodApi
            GET_ALL
            GET_BY_ID
            POST
            PUT
            DELETE
            PUT_ELIMINATE_DUPLICATE
        End Enum

        'Private restClient As RestClient = New RestClient("http://192.168.137.1/sipp/")
        Private restClient As RestClient = New RestClient("http://localhost/sipp/")

        Private requestUser As RestRequest

        Private tokenId As String = "cxmvbajcb2u3idb2ua4irh48r7hq48rhdjkfanjkcsnd"

        Public Function User(method As MethodApi, ByVal ParamArray passData() As Object) As Object
            Dim data As Object = New Object
            Select Case method
                Case MethodApi.GET_ALL
                    requestUser = New RestRequest("api/user", RestSharp.Method.GET)
                    Dim response As RestResponse = restClient.Execute(requestUser)
                    data = SimpleJson.DeserializeObject(response.Content)
                Case MethodApi.GET_BY_ID
                    requestUser = New RestRequest("api/user/{token}/{id}", RestSharp.Method.GET)
                    requestUser.Parameters.Clear()
                    requestUser.AddUrlSegment("token", tokenId)
                    requestUser.AddUrlSegment("id", passData(0))
                    Dim response As RestResponse = restClient.Execute(requestUser)
                    data = SimpleJson.DeserializeObject(response.Content)
                Case MethodApi.POST
                    requestUser = New RestRequest("api/user/{token}", RestSharp.Method.POST)
                    requestUser.Parameters.Clear()
                    requestUser.AddUrlSegment("token", tokenId)
                    requestUser.RequestFormat = DataFormat.Json
                    requestUser.AddBody(passData(0))
                    Dim response As RestResponse = restClient.Execute(requestUser)
                    data = response.StatusDescription
                Case MethodApi.PUT
                    requestUser = New RestRequest("api/user/{token}/{id}", RestSharp.Method.PUT)
                    requestUser.Parameters.Clear()
                    requestUser.AddUrlSegment("token", tokenId)
                    requestUser.AddUrlSegment("id", passData(0))
                    requestUser.RequestFormat = DataFormat.Json
                    requestUser.AddBody(passData(1))
                    Dim response As RestResponse = restClient.Execute(requestUser)
                    data = response.StatusDescription
                Case MethodApi.DELETE
                    requestUser = New RestRequest("api/user/{token}/{id}", RestSharp.Method.DELETE)
                    requestUser.Parameters.Clear()
                    requestUser.AddUrlSegment("token", tokenId)
                    requestUser.AddUrlSegment("id", passData(0))
                    Dim response As RestResponse = restClient.Execute(requestUser)
                    data = response.StatusDescription
            End Select
            Return data
        End Function

        Public Function MailOne(method As MethodApi, ByVal ParamArray passData() As Object) As Object
            Dim data As Object = New Object
            Select Case method
                Case MethodApi.GET_ALL
                    requestUser = New RestRequest("api/mail/one", RestSharp.Method.GET)
                    Dim response As RestResponse = restClient.Execute(requestUser)
                    data = SimpleJson.DeserializeObject(response.Content)
                Case MethodApi.GET_BY_ID
                    requestUser = New RestRequest("api/nail/one/{token}/{id}", RestSharp.Method.GET)
                    requestUser.Parameters.Clear()
                    requestUser.AddUrlSegment("token", tokenId)
                    requestUser.AddUrlSegment("id", passData(0))
                    Dim response As RestResponse = restClient.Execute(requestUser)
                    data = SimpleJson.DeserializeObject(response.Content)
                Case MethodApi.POST
                    requestUser = New RestRequest("api/mail/one/{token}", RestSharp.Method.POST)
                    requestUser.Parameters.Clear()
                    requestUser.AddUrlSegment("token", tokenId)
                    requestUser.RequestFormat = DataFormat.Json
                    requestUser.AddBody(passData(0))
                    Dim response As RestResponse = restClient.Execute(requestUser)
                    data = response.StatusDescription
                Case MethodApi.PUT
                    requestUser = New RestRequest("api/mail/one/{token}/{id}", RestSharp.Method.PUT)
                    requestUser.Parameters.Clear()
                    requestUser.AddUrlSegment("token", tokenId)
                    requestUser.AddUrlSegment("id", passData(0))
                    requestUser.RequestFormat = DataFormat.Json
                    requestUser.AddBody(passData(1))
                    Dim response As RestResponse = restClient.Execute(requestUser)
                    data = response.StatusDescription
                Case MethodApi.DELETE
                    requestUser = New RestRequest("api/mail/one/{token}/{id}", RestSharp.Method.DELETE)
                    requestUser.Parameters.Clear()
                    requestUser.AddUrlSegment("token", tokenId)
                    requestUser.AddUrlSegment("id", passData(0))
                    Dim response As RestResponse = restClient.Execute(requestUser)
                    data = response.StatusDescription
                Case MethodApi.PUT_ELIMINATE_DUPLICATE
                    requestUser = New RestRequest("api/mail/one/{token}`", RestSharp.Method.PUT)
                    requestUser.Parameters.Clear()
                    requestUser.AddUrlSegment("token", tokenId)
                    Dim response As RestResponse = restClient.Execute(requestUser)
                    data = response.StatusDescription
            End Select
            Return data
        End Function

        Public Function MailTwo(method As MethodApi, ByVal ParamArray passData() As Object) As Object
            Dim data As Object = New Object
            Select Case method
                Case MethodApi.GET_ALL
                    requestUser = New RestRequest("api/mail/two", RestSharp.Method.GET)
                    Dim response As RestResponse = restClient.Execute(requestUser)
                    data = SimpleJson.DeserializeObject(response.Content)
                Case MethodApi.GET_BY_ID
                    requestUser = New RestRequest("api/nail/two/{token}/{id}", RestSharp.Method.GET)
                    requestUser.Parameters.Clear()
                    requestUser.AddUrlSegment("token", tokenId)
                    requestUser.AddUrlSegment("id", passData(0))
                    Dim response As RestResponse = restClient.Execute(requestUser)
                    data = SimpleJson.DeserializeObject(response.Content)
                Case MethodApi.POST
                    requestUser = New RestRequest("api/mail/two/{token}", RestSharp.Method.POST)
                    requestUser.Parameters.Clear()
                    requestUser.AddUrlSegment("token", tokenId)
                    requestUser.RequestFormat = DataFormat.Json
                    requestUser.AddBody(passData(0))
                    Dim response As RestResponse = restClient.Execute(requestUser)
                    data = response.StatusDescription
                Case MethodApi.PUT
                    requestUser = New RestRequest("api/mail/two/{token}/{id}", RestSharp.Method.PUT)
                    requestUser.Parameters.Clear()
                    requestUser.AddUrlSegment("token", tokenId)
                    requestUser.AddUrlSegment("id", passData(0))
                    requestUser.RequestFormat = DataFormat.Json
                    requestUser.AddBody(passData(1))
                    Dim response As RestResponse = restClient.Execute(requestUser)
                    data = response.StatusDescription
                Case MethodApi.DELETE
                    requestUser = New RestRequest("api/mail/two/{token}/{id}", RestSharp.Method.DELETE)
                    requestUser.Parameters.Clear()
                    requestUser.AddUrlSegment("token", tokenId)
                    requestUser.AddUrlSegment("id", passData(0))
                    Dim response As RestResponse = restClient.Execute(requestUser)
                    data = response.StatusDescription
                Case MethodApi.PUT_ELIMINATE_DUPLICATE
                    requestUser = New RestRequest("api/mail/two/{token}`", RestSharp.Method.PUT)
                    requestUser.Parameters.Clear()
                    requestUser.AddUrlSegment("token", tokenId)
                    Dim response As RestResponse = restClient.Execute(requestUser)
                    data = response.StatusDescription
            End Select
            Return data
        End Function
    End Module
End Namespace

