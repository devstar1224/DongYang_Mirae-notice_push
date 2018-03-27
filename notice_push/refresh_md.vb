Module refresh_md
    Function refresh_menu(select_item As String)
        Dim error_msg As String
        Select Case (select_item)
            Case "all"
                error_msg = refresh_main()
                If error_msg IsNot Nothing Then
                    MsgBox("에러 발생 : " & error_msg)
                    End
                End If
                error_msg = refresh_elec()
                If error_msg IsNot Nothing Then
                    MsgBox("에러 발생 : " & error_msg)
                    End
                End If
                error_msg = refresh_elect_total()
                If error_msg IsNot Nothing Then
                    MsgBox("에러 발생 : " & error_msg)
                    End
                End If
                error_msg = refresh_soft()
                If error_msg IsNot Nothing Then
                    MsgBox("에러 발생 : " & error_msg)
                    End
                End If
            Case "elec"
                error_msg = refresh_elec()
                If error_msg IsNot Nothing Then
                    MsgBox("에러 발생 : " & error_msg)
                    End
                End If
            Case "elect_total"
                error_msg = refresh_elect_total()
                If error_msg IsNot Nothing Then
                    MsgBox("에러 발생 : " & error_msg)
                    End
                End If
            Case "soft"
                error_msg = refresh_soft()
                If error_msg IsNot Nothing Then
                    MsgBox("에러 발생 : " & error_msg)
                    End
                End If
        End Select
    End Function
End Module
