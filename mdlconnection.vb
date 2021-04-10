Imports Oracle.DataAccess.Client

Module mdlconnection
    Dim query As String
    Public con As New OracleConnection

    Public Sub dbcon()
        con.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false"
        con.Open()
    End Sub
    Public Sub dbclose()
        con.Close()
    End Sub
    Public Sub insquery(ByRef query As String)
        Dim temp As Long = 0
        Try
            Using cmd As New OracleCommand(query, con)
                temp = cmd.ExecuteNonQuery()
            End Using
            If temp > 0 Then
                MsgBox("Insert successfully")
            Else
                MsgBox("values not inserted")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Public Sub updquery(ByRef query As String)
        Dim temp As Long = 0
        Try
            Using cmd As New OracleCommand(query, con)
                temp = cmd.ExecuteNonQuery()
            End Using
            If temp > 0 Then
                MsgBox("Updated successfully")
            Else
                MsgBox("values not update")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Public Sub delquery(ByRef query As String)
        Dim temp As Long = 0
        Try
            Using cmd As New OracleCommand(query, con)
                temp = cmd.ExecuteNonQuery()
            End Using
            If temp > 0 Then
                MsgBox("Deleted successfully")
            Else
                MsgBox("Row not Deleted")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Public Function selquery(ByRef query As String)
        Dim dt As New DataTable
        Try
            Using cmd As New OracleCommand(query, con)
                Using ada As New OracleDataAdapter(cmd)
                    ada.Fill(dt)
                End Using
            End Using
            If dt.Rows.Count > 0 Then
                Return dt
            Else
                MsgBox("THERE IS NO ROW IN TABLE")
                Return dt
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
            Return dt
        End Try
    End Function
End Module
