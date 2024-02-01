Imports System.Data.SqlClient

Public Class main_Form
    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Guna2ControlBox1.PerformClick()
        Application.Exit()
    End Sub

    Private Sub btnMaximize_Click_1(sender As Object, e As EventArgs) Handles btnMaximize.Click
        Guna2ControlBox2.PerformClick()
    End Sub

    Private Sub btnMinimize_Click_1(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Guna2ControlBox3.PerformClick()
    End Sub

    Private Sub main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnMaximize.PerformClick()
        LoadDataIntoDataGridView()
    End Sub

    Public Sub LoadDataIntoDataGridView()
        Try
            If cbTable.SelectedIndex = 0 Then

                DataGridView.DataSource = Nothing
                connDB()
                query = "SELECT transaction_tbl.SequenceNo as #, master_tbl.PropertyNo as PROPERTY_NO, master_tbl.UnitUser as UNIT_USER, transaction_tbl.Name as NAME, master_tbl.Department as DEPARTMENT, master_tbl.ContactNo as CONTACT_NO, transaction_tbl.Category as CATEGORY, transaction_tbl.Type as TYPE, transaction_tbl.Date as DATE, transaction_tbl.TimeIn as TIME_IN, transaction_tbl.TimeOut as TIME_OUT, transaction_tbl.Diagnosis as DIAGNOSIS, transaction_tbl.AssignedStaff as ASSIGNED_STAFF, transaction_tbl.Remarks as REMARKS FROM master_tbl INNER JOIN transaction_tbl ON master_tbl.PropertyNo = transaction_tbl.PropertyNo WHERE (master_tbl.Status = 0 AND transaction_tbl.Status = 0) ORDER BY transaction_tbl.SequenceNo"
                adapter = New SqlDataAdapter(query, conn)
                dataTable = New DataTable()
                adapter.Fill(dataTable)
                DataGridView.DataSource = dataTable
                conn.Close()

                DataGridView.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                DataGridView.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                'DataGridView.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                'DataGridView.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                'DataGridView.Columns(4).Width = 106
                DataGridView.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                'DataGridView.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                'DataGridView.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                DataGridView.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                DataGridView.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                DataGridView.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                'DataGridView.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                DataGridView.Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                'DataGridView.Columns(13).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            ElseIf cbTable.SelectedIndex = 1 Then

                DataGridView.DataSource = Nothing
                connDB()
                query = "SELECT transaction_tbl.SequenceNo as #, transaction_tbl.PropertyNo as PROPERTY_NO, transaction_tbl.Name as NAME, transaction_tbl.Category as CATEGORY, transaction_tbl.Type as TYPE, transaction_tbl.Date as DATE, transaction_tbl.TimeIn as TIME_IN, transaction_tbl.TimeOut as TIME_OUT, transaction_tbl.Diagnosis as DIAGNOSIS, transaction_tbl.AssignedStaff as ASSIGNED_STAFF, transaction_tbl.Remarks as REMARKS FROM transaction_tbl WHERE transaction_tbl.Status = 0 ORDER BY transaction_tbl.SequenceNo"
                adapter = New SqlDataAdapter(query, conn)
                dataTable = New DataTable()
                adapter.Fill(dataTable)
                DataGridView.DataSource = dataTable
                conn.Close()

                DataGridView.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                DataGridView.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                DataGridView.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                DataGridView.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                DataGridView.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            ElseIf cbTable.SelectedIndex = 2 Then

                DataGridView.DataSource = Nothing
                connDB()
                query = "SELECT master_tbl.PropertyNo as PROPERTY_NO, master_tbl.UnitUser as UNIT_USER, master_tbl.Department as DEPARTMENT, master_tbl.ContactNo as CONTACT_NO FROM master_tbl WHERE master_tbl.Status = 0 ORDER BY master_tbl.PropertyNo"
                adapter = New SqlDataAdapter(query, conn)
                dataTable = New DataTable()
                adapter.Fill(dataTable)
                DataGridView.DataSource = dataTable
                conn.Close()

                'DataGridView.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                ''DataGridView.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                ''DataGridView.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                'DataGridView.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

            End If

            DataGridView.FirstDisplayedScrollingRowIndex = DataGridView.RowCount - 1
        Catch ex As Exception
            'MsgBox(ex.Message)
            'conn.Close()
        End Try
    End Sub

    Private Sub DataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellDoubleClick
        anima.ShowSync(Guna2Panel2)
        If cbTable.Text = "MASTER" Then
            propertyID = DataGridView.CurrentRow.Cells(0).Value
        Else
            sequenceID = DataGridView.CurrentRow.Cells(0).Value
            propertyIDMaster = DataGridView.CurrentRow.Cells(1).Value
        End If
    End Sub

    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellClick
        anima.HideSync(Guna2Panel2)
    End Sub

    Private Sub Guna2Panel4_MouseDown(sender As Object, e As MouseEventArgs) Handles Guna2Panel4.MouseDown
        anima.HideSync(Guna2Panel2)
    End Sub

    Private Sub DataGridView_MouseDown(sender As Object, e As MouseEventArgs) Handles DataGridView.MouseDown
        anima.HideSync(Guna2Panel2)
    End Sub

    Private Sub Guna2Panel3_MouseClick(sender As Object, e As MouseEventArgs) Handles Guna2Panel3.MouseClick
        anima.HideSync(Guna2Panel2)
    End Sub

    Private Sub txtSearch_MouseDown(sender As Object, e As MouseEventArgs) Handles txtSearch.MouseDown
        anima.HideSync(Guna2Panel2)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        label = "ADD RECORD"
        cbText = cbTable.Text
        add_Patient.Show()
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        label = "MODIFY RECORD"
        cbText = cbTable.Text
        add_Patient.Show()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        label = "VIEW RECORD"
        cbText = cbTable.Text
        add_Patient.Show()
    End Sub

    Private Sub cbTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTable.SelectedIndexChanged
        LoadDataIntoDataGridView()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadDataIntoDataGridView()
    End Sub

    Dim status As Integer = 1
    Sub RecordToBeDeleted()
        Try
            If cbTable.SelectedIndex = 0 Then
                connDB()
                query = "UPDATE master_tbl SET status = @status WHERE propertyno = '" & propertyIDMaster & "'"
                Using cmdMaster As New SqlCommand(query, conn)
                    cmdMaster.Parameters.Clear()
                    cmdMaster.Parameters.AddWithValue("@status", status)
                    cmdMaster.ExecuteNonQuery()
                End Using


                query1 = "UPDATE transaction_tbl SET status = @status WHERE sequenceno = '" & sequenceID & "'"
                Using cmdTransaction As New SqlCommand(query1, conn)
                    cmdTransaction.Parameters.Clear()
                    cmdTransaction.Parameters.AddWithValue("@status", status)
                    cmdTransaction.ExecuteNonQuery()
                End Using
                conn.Close()
            ElseIf cbTable.SelectedIndex = 1 Then
                connDB()
                query1 = "UPDATE transaction_tbl SET status = @status WHERE sequenceno = '" & sequenceID & "'"
                Using cmdTransaction As New SqlCommand(query1, conn)
                    cmdTransaction.Parameters.Clear()
                    cmdTransaction.Parameters.AddWithValue("@status", status)
                    cmdTransaction.ExecuteNonQuery()
                End Using
                conn.Close()
            ElseIf cbTable.SelectedIndex = 2 Then
                connDB()
                query = "UPDATE master_tbl SET status = @status WHERE propertyno = '" & propertyIDMaster & "'"
                Using cmdMaster As New SqlCommand(query, conn)
                    cmdMaster.Parameters.Clear()
                    cmdMaster.Parameters.AddWithValue("@status", status)
                    cmdMaster.ExecuteNonQuery()
                End Using
                conn.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        msgInfo.Caption = "Delete"
        msgInfo.Text = "Your about to Delete this Record" + vbCrLf + "Are you sure? you want to proceed ?"
        msgInfo.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo
        msgInfo.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning
        Dim result = msgInfo.Show
        If result = DialogResult.Yes Then
            RecordToBeDeleted()
            LoadDataIntoDataGridView()
        End If
    End Sub
End Class