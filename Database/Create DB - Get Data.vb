Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("BMSQL-POLICY").ConnectionString)
Dim UsernameQuery As String = "SELECT * FROM _AllpointsToIBMLoginRelation " _
                            & "WHERE AgentCode = '" & TextBoxAgencyCode.Text & "' and AllpointsUserID = '" & UserName & "'"
Try
    Dim adp As SqlDataAdapter = New SqlDataAdapter(UsernameQuery, connection)
    Dim ds As DataSet = New DataSet()
    adp.Fill(ds)
    If ds.Tables(0).Rows.Count = 0 Then
        Return True
    End If
Catch ex As Exception
    MsgBox("Unable to check username for agency")
End Try
