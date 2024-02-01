Imports System.Data.SqlClient

Module DBConnection
    Public ConnectionString As String = "Data Source=WIN-A0B4LB2BR7H\LOCALHOST;Initial Catalog=hrrs_db;User ID=nile;Password=password"
    Public conn As SqlConnection
    Public cmd As SqlCommand
    Public query As String
    Public query1 As String
    Public dataTable As DataTable
    Public adapter As SqlDataAdapter
    Public reader As SqlDataReader
    Public label As String
    Public cbText As String
    Public propertyID As String
    Public propertyIDMaster As String
    Public sequenceID As String

    Public Sub connDB()
        Try
            ' SQL SERVER Connection
            If ConnectionString <> "" Then
                conn = New SqlConnection(ConnectionString)
                conn.Open()
            Else
                MsgBox("Cannot Find any Database")
            End If
        Catch ex As Exception
            MsgBox("Connection is Failed to Connect !" + vbCrLf + vbCrLf + "Error: " + ex.Message)
            conn.Close()
            Application.Exit()
        End Try
    End Sub
End Module
