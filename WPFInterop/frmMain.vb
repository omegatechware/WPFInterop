Imports System.IO
Imports System.Text
Imports System.Windows
Public Class frmMain
    Private mLastError As String = ""
    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        Dim Element As UIElement = Nothing
        Element = XAMLFromString(txtXAML.Text)
        If IsNothing(Element) Then
            MsgBox("Parse error. Please check your XAML:" & vbCrLf & vbTab & mLastError)
            hstMain.Child = Nothing
        Else
            hstMain.Child = Element
        End If
    End Sub
    Private Function XAMLFromString(Data As String) As UIElement
        Dim Bytes() As Byte = Nothing
        Try
            Bytes = Encoding.ASCII.GetBytes(Data)
            Using Stream As MemoryStream = New MemoryStream(Bytes)
                Return CType(System.Windows.Markup.XamlReader.Load(Stream), UIElement)
            End Using
        Catch ex As Exception
            mLastError = "WPFInterop.frmMain.XAMLFromString(String): " & ex.Message
            Return Nothing
        End Try
    End Function
End Class
