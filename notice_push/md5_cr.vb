Imports System.Security.Cryptography
Imports System.Text
Module md5_cr
    Public Function GetMd5Hash(input As String) As String
        Dim data As Byte() = MD5.Create.ComputeHash(Encoding.UTF8.GetBytes(input))
        Dim sBuilder As New StringBuilder()
        For i As Integer = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next
        Return sBuilder.ToString()
    End Function
End Module
