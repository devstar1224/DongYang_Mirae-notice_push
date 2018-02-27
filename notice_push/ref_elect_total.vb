Module ref_elect_total
    Public winhttp As New WinHttp.WinHttpRequest
    Public href_index_elect_total(15) As String
    Public http_source_elect_total As String
    Public Function refresh_elect_total()
        Try
            Form1.ListBox2.Items.Clear()
            Dim date_hash As String
            With winhttp
                .Open("GET", "http://www.dongyang.ac.kr/web/epower/-19")
                .Send()
                http_source_elect_total = Split(Split(Split(.ResponseText, "table-list full-table remove-08 remove-07 i-reset")(1), "</ul>")(0), "<ul>")(0)
                For i = 2 To 16
                    date_hash = date_hash & Split(Split(http_source_elect_total, "col-05"">")(i), "</div>")(0)
                    Form1.ListBox2.Items.Add(Split(Split(http_source_elect_total, "<span class=""t""")(i - 1), "</span>")(0))
                    href_index_elect_total(i - 2) = Split(Split(http_source_elect_total, "href=""")(i - 1), """ class")(0)
                Next i
                If (GetSetting("dongyang", "last_refresh", "date_elect_total") = GetMd5Hash(date_hash)) Then
                    Form1.Label7.Text = "NO"
                Else
                    Form1.Label7.Text = "YES"
                    If Form1.CheckBox2.Checked = True Then
                        My.Computer.Audio.Play(Application.StartupPath & "\sound\ring.wav")
                    End If
                End If
                SaveSetting("dongyang", "last_refresh", "date_elect_total", GetMd5Hash(date_hash)) '게시글 날자만 잘라서 md5으로 유효성검사
            End With
            Form1.Label9.Text = My.Computer.Clock.LocalTime
        Catch
            MsgBox("새로고침도중 오류가 발생하였습니다. 오류 내용은 다음과 같습니다." & vbCrLf & ErrorToString())
        End Try
    End Function
End Module
