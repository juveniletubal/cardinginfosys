Imports System.Data.SqlClient

Public Class add_Patient
    Dim status As Integer = 0

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub add_Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopUpChoices()

        txtPropertyNo.Focus()
        'Me.TopMost = True
    End Sub

    Sub AddingItemInComboBox()
        If cbCategory.Text = "COMMON ICT SERVICES" Then
            panel1.Visible = False
            panel2.Visible = False
            panel3.Visible = True
        End If

        If cbCategory.Text = "HARDWARE" Then
            panel1.Visible = True
            panel2.Visible = False
            panel3.Visible = False
        End If

        If cbCategory.Text = "SOFTWARE" Then
            panel1.Visible = False
            panel2.Visible = True
            panel3.Visible = False
        End If

        If cbCategory.Text = "SELECT CATEGORY" Then
            panel1.Visible = False
            panel2.Visible = False
            panel3.Visible = False
        End If
    End Sub

    Private Sub cbCategory_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbCategory.SelectedValueChanged
        AddingItemInComboBox()
    End Sub

    Public Sub PopUpChoices()
        If label = "ADD RECORD" Then
            popupLabel.Text = "ADD RECORD"
            dtDate.Value = Date.Now
            dtTimeIn.Text = TimeOfDay
            dtTimeOut.Text = TimeOfDay
        ElseIf label = "MODIFY RECORD" Then
            popupLabel.Text = "MODIFY RECORD"
            DisplayRecordToBeUpdated()
            btnSave.FillColor = Color.ForestGreen
            btnSave.Text = "Update"
        ElseIf label = "VIEW RECORD" Then
            popupLabel.Text = "VIEW RECORD"
            DisplayRecordOnly()
            btnSave.Enabled = False
        End If
    End Sub

    Sub ClearAllFields()
        txtPropertyNo.Clear()
        txtName.Clear()
        cbDepartment.SelectedIndex = 0
        txtContact.Clear()
        cbCategory.SelectedIndex = 0
        cbDeviceType.SelectedIndex = 0
        Guna2ComboBox1.SelectedIndex = 0
        Guna2ComboBox2.SelectedIndex = 0
        dtDate.Value = Date.Now
        dtTimeIn.Text = TimeOfDay
        dtTimeOut.Text = TimeOfDay
        txtDiagnosis.Clear()
        txtAssignedStaff.Clear()
        txtRemarks.Clear()
        txtUser.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtPropertyNo.Text = "" Or txtName.Text = "" Or cbDepartment.SelectedIndex = 0 Or cbCategory.SelectedIndex = 0 Then
            msgInfo.Caption = "Error"
            msgInfo.Text = "Please fill-up all fields !"
            msgInfo.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
            msgInfo.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
            msgInfo.Show()
        Else
            If btnSave.Text = "Save" Then
                Dim propertyNo As String = txtPropertyNo.Text

                ' Check if the PropertyNo already exists in master_tbl
                If Not PropertyNoExistsInMaster(propertyNo) Then
                    ' Insert into master_tbl
                    InsertIntoMaster()
                End If

                InsertIntoTransaction()

                main_Form.LoadDataIntoDataGridView()

                msgInfo.Caption = "Success"
                msgInfo.Text = "Record Inserted Successfuly"
                msgInfo.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information
                msgInfo.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
                msgInfo.Show()

                ClearAllFields()
            ElseIf btnSave.Text = "Update" Then
                RecordUpdate()

                main_Form.LoadDataIntoDataGridView()

                msgInfo.Caption = "Updated"
                msgInfo.Text = "Record Updated Successfuly"
                msgInfo.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information
                msgInfo.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
                msgInfo.Show()
            End If
        End If
    End Sub

    Function PropertyNoExistsInMaster(propertyNo As String)
        connDB()
        query = "SELECT COUNT(*) FROM master_tbl WHERE PropertyNo = @PropertyNo"
        cmd = New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@PropertyNo", propertyNo)
        Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
    End Function

    Public Sub InsertIntoMaster()
        Try
            connDB()
            query = "INSERT INTO master_tbl(propertyno, unituser, department, contactno, status) VALUES (@propertyno, @unituser, @department, @contactno, @status)"
            cmd = New SqlCommand(query, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@propertyno", txtPropertyNo.Text)
            cmd.Parameters.AddWithValue("@unituser", txtUser.Text)
            cmd.Parameters.AddWithValue("@department", cbDepartment.Text)
            cmd.Parameters.AddWithValue("@contactno", txtContact.Text)
            cmd.Parameters.AddWithValue("@status", status)
            'cmd.Parameters.AddWithValue("@category", cbCategory.Text)

            'If cbCategory.Text = "COMMON ICT SERVICES" Then
            '    cmd.Parameters.AddWithValue("@devicetype", Guna2ComboBox2.Text)
            'ElseIf cbCategory.Text = "HARDWARE" Then
            '    cmd.Parameters.AddWithValue("@devicetype", cbDeviceType.Text)
            'ElseIf cbCategory.Text = "SOFTWARE" Then
            '    cmd.Parameters.AddWithValue("@devicetype", Guna2ComboBox1.Text)
            'End If

            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            'conn.Close()
        End Try
    End Sub

    Public Sub InsertIntoTransaction()
        Try
            connDB()
            query = "INSERT INTO transaction_tbl(propertyno, date, timein, timeout, diagnosis, assignedstaff, name, category, type, remarks, status) VALUES 
                            (@propertyno, @date, @timein, @timeout, @diagnosis, @assignedstaff, @name, @category, @type, @remarks, @status)"
            cmd = New SqlCommand(query, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@propertyno", txtPropertyNo.Text)
            cmd.Parameters.AddWithValue("@date", Format(dtDate.Value, "MM/dd/yyyy").ToString)
            cmd.Parameters.AddWithValue("@timein", Format(dtTimeIn.Value, "hh:mm tt").ToString)
            cmd.Parameters.AddWithValue("@timeout", Format(dtTimeOut.Value, "hh:mm tt").ToString)
            cmd.Parameters.AddWithValue("@diagnosis", txtDiagnosis.Text)
            cmd.Parameters.AddWithValue("@assignedstaff", txtAssignedStaff.Text)
            cmd.Parameters.AddWithValue("@name", txtName.Text)
            cmd.Parameters.AddWithValue("@category", cbCategory.Text)

            If cbCategory.Text = "COMMON ICT SERVICES" Then
                cmd.Parameters.AddWithValue("@type", Guna2ComboBox2.Text)
            ElseIf cbCategory.Text = "HARDWARE" Then
                cmd.Parameters.AddWithValue("@type", cbDeviceType.Text)
            ElseIf cbCategory.Text = "SOFTWARE" Then
                cmd.Parameters.AddWithValue("@type", Guna2ComboBox1.Text)
            End If

            cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text)
            cmd.Parameters.AddWithValue("@status", status)
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            'conn.Close()
        End Try
    End Sub

    Sub DisplayRecordToBeUpdated()
        If cbText = "ALL" Then
            Try
                connDB()
                query = "SELECT master_tbl.PropertyNo, master_tbl.UnitUser, transaction_tbl.Name, master_tbl.Department, master_tbl.ContactNo, transaction_tbl.Category, transaction_tbl.Type, transaction_tbl.Date, transaction_tbl.TimeIn, transaction_tbl.TimeOut, transaction_tbl.Diagnosis, transaction_tbl.AssignedStaff, transaction_tbl.Remarks FROM master_tbl INNER JOIN transaction_tbl ON master_tbl.PropertyNo = transaction_tbl.PropertyNo WHERE transaction_tbl.SequenceNo = '" & sequenceID & "'"
                'cmd = New SqlCommand(query, conn)
                dataTable = New DataTable()
                adapter = New SqlDataAdapter(query, conn)
                adapter.Fill(dataTable)

                txtPropertyNo.Text = dataTable.Rows(0)(0).ToString()
                txtName.Text = dataTable.Rows(0)(2).ToString()
                txtUser.Text = dataTable.Rows(0)(1).ToString()
                cbDepartment.Text = dataTable.Rows(0)(3).ToString()
                txtContact.Text = dataTable.Rows(0)(4).ToString()
                cbCategory.Text = dataTable.Rows(0)(5).ToString()
                cbDeviceType.Text = dataTable.Rows(0)(6).ToString()
                dtDate.Text = dataTable.Rows(0)(7).ToString()
                dtTimeIn.Text = dataTable.Rows(0)(8).ToString()
                dtTimeOut.Text = dataTable.Rows(0)(9).ToString()
                txtDiagnosis.Text = dataTable.Rows(0)(10).ToString()
                txtAssignedStaff.Text = dataTable.Rows(0)(11).ToString()
                txtRemarks.Text = dataTable.Rows(0)(12).ToString()

                txtPropertyNo.Enabled = False

                conn.Close()
            Catch ex As Exception

            End Try
        ElseIf cbText = "TRANSACTION" Then
            Try
                connDB()
                query = "SELECT PropertyNo, Name, Category, Type, Date, TimeIn, TimeOut, Diagnosis, AssignedStaff, Remarks FROM transaction_tbl WHERE SequenceNo = '" & sequenceID & "'"
                'cmd = New SqlCommand(query, conn)
                dataTable = New DataTable()
                adapter = New SqlDataAdapter(query, conn)
                adapter.Fill(dataTable)

                txtPropertyNo.Text = dataTable.Rows(0)(0).ToString()
                txtName.Text = dataTable.Rows(0)(1).ToString()
                cbCategory.Text = dataTable.Rows(0)(2).ToString()
                cbDeviceType.Text = dataTable.Rows(0)(3).ToString()
                dtDate.Text = dataTable.Rows(0)(4).ToString()
                dtTimeIn.Text = dataTable.Rows(0)(5).ToString()
                dtTimeOut.Text = dataTable.Rows(0)(6).ToString()
                txtDiagnosis.Text = dataTable.Rows(0)(7).ToString()
                txtAssignedStaff.Text = dataTable.Rows(0)(8).ToString()
                txtRemarks.Text = dataTable.Rows(0)(9).ToString()

                txtPropertyNo.Enabled = False
                txtUser.Enabled = False
                cbDepartment.Enabled = False
                txtContact.Enabled = False

                conn.Close()
            Catch ex As Exception

            End Try
        ElseIf cbText = "MASTER" Then
            Try
                connDB()
                query = "SELECT PropertyNo, UnitUser, Department, ContactNo FROM master_tbl WHERE PropertyNo = '" & propertyID & "'"
                'cmd = New SqlCommand(query, conn)
                dataTable = New DataTable()
                adapter = New SqlDataAdapter(query, conn)
                adapter.Fill(dataTable)

                txtPropertyNo.Text = dataTable.Rows(0)(0).ToString()
                txtUser.Text = dataTable.Rows(0)(1).ToString()
                cbDepartment.Text = dataTable.Rows(0)(2).ToString()
                txtContact.Text = dataTable.Rows(0)(3).ToString()

                txtPropertyNo.Enabled = False
                txtName.Enabled = False
                cbCategory.Enabled = False
                cbDeviceType.Enabled = False
                dtDate.Enabled = False
                dtTimeIn.Enabled = False
                dtTimeOut.Enabled = False
                txtDiagnosis.Enabled = False
                txtAssignedStaff.Enabled = False
                txtRemarks.Enabled = False

                conn.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Sub DisplayRecordOnly()
        If cbText = "ALL" Then
            Try
                connDB()
                query = "SELECT master_tbl.PropertyNo, master_tbl.UnitUser, transaction_tbl.Name, master_tbl.Department, master_tbl.ContactNo, transaction_tbl.Category, transaction_tbl.Type, transaction_tbl.Date, transaction_tbl.TimeIn, transaction_tbl.TimeOut, transaction_tbl.Diagnosis, transaction_tbl.AssignedStaff, transaction_tbl.Remarks FROM master_tbl INNER JOIN transaction_tbl ON master_tbl.PropertyNo = transaction_tbl.PropertyNo WHERE transaction_tbl.SequenceNo = '" & sequenceID & "'"
                'cmd = New SqlCommand(query, conn)
                dataTable = New DataTable()
                adapter = New SqlDataAdapter(query, conn)
                adapter.Fill(dataTable)

                txtPropertyNo.Text = dataTable.Rows(0)(0).ToString()
                txtName.Text = dataTable.Rows(0)(2).ToString()
                txtUser.Text = dataTable.Rows(0)(1).ToString()
                cbDepartment.Text = dataTable.Rows(0)(3).ToString()
                txtContact.Text = dataTable.Rows(0)(4).ToString()
                cbCategory.Text = dataTable.Rows(0)(5).ToString()
                cbDeviceType.Text = dataTable.Rows(0)(6).ToString()
                dtDate.Text = dataTable.Rows(0)(7).ToString()
                dtTimeIn.Text = dataTable.Rows(0)(8).ToString()
                dtTimeOut.Text = dataTable.Rows(0)(9).ToString()
                txtDiagnosis.Text = dataTable.Rows(0)(10).ToString()
                txtAssignedStaff.Text = dataTable.Rows(0)(11).ToString()
                txtRemarks.Text = dataTable.Rows(0)(12).ToString()

                txtPropertyNo.Enabled = False
                txtUser.Enabled = False
                cbDepartment.Enabled = False
                txtContact.Enabled = False
                txtName.Enabled = False
                cbCategory.Enabled = False
                cbDeviceType.Enabled = False
                dtDate.Enabled = False
                dtTimeIn.Enabled = False
                dtTimeOut.Enabled = False
                txtDiagnosis.Enabled = False
                txtAssignedStaff.Enabled = False
                txtRemarks.Enabled = False

                conn.Close()
            Catch ex As Exception

            End Try
        ElseIf cbText = "TRANSACTION" Then
            Try
                connDB()
                query = "SELECT PropertyNo, Name, Category, Type, Date, TimeIn, TimeOut, Diagnosis, AssignedStaff, Remarks FROM transaction_tbl WHERE SequenceNo = '" & sequenceID & "'"
                'cmd = New SqlCommand(query, conn)
                dataTable = New DataTable()
                adapter = New SqlDataAdapter(query, conn)
                adapter.Fill(dataTable)

                txtPropertyNo.Text = dataTable.Rows(0)(0).ToString()
                txtName.Text = dataTable.Rows(0)(1).ToString()
                cbCategory.Text = dataTable.Rows(0)(2).ToString()
                cbDeviceType.Text = dataTable.Rows(0)(3).ToString()
                dtDate.Text = dataTable.Rows(0)(4).ToString()
                dtTimeIn.Text = dataTable.Rows(0)(5).ToString()
                dtTimeOut.Text = dataTable.Rows(0)(6).ToString()
                txtDiagnosis.Text = dataTable.Rows(0)(7).ToString()
                txtAssignedStaff.Text = dataTable.Rows(0)(8).ToString()
                txtRemarks.Text = dataTable.Rows(0)(9).ToString()

                txtPropertyNo.Enabled = False
                txtUser.Enabled = False
                cbDepartment.Enabled = False
                txtContact.Enabled = False
                txtName.Enabled = False
                cbCategory.Enabled = False
                cbDeviceType.Enabled = False
                dtDate.Enabled = False
                dtTimeIn.Enabled = False
                dtTimeOut.Enabled = False
                txtDiagnosis.Enabled = False
                txtAssignedStaff.Enabled = False
                txtRemarks.Enabled = False

                conn.Close()
            Catch ex As Exception

            End Try
        ElseIf cbText = "MASTER" Then
            Try
                connDB()
                query = "SELECT PropertyNo, UnitUser, Department, ContactNo FROM master_tbl WHERE PropertyNo = '" & propertyID & "'"
                'cmd = New SqlCommand(query, conn)
                dataTable = New DataTable()
                adapter = New SqlDataAdapter(query, conn)
                adapter.Fill(dataTable)

                txtPropertyNo.Text = dataTable.Rows(0)(0).ToString()
                txtUser.Text = dataTable.Rows(0)(1).ToString()
                cbDepartment.Text = dataTable.Rows(0)(2).ToString()
                txtContact.Text = dataTable.Rows(0)(3).ToString()

                txtPropertyNo.Enabled = False
                txtUser.Enabled = False
                cbDepartment.Enabled = False
                txtContact.Enabled = False
                txtName.Enabled = False
                cbCategory.Enabled = False
                cbDeviceType.Enabled = False
                dtDate.Enabled = False
                dtTimeIn.Enabled = False
                dtTimeOut.Enabled = False
                txtDiagnosis.Enabled = False
                txtAssignedStaff.Enabled = False
                txtRemarks.Enabled = False

                conn.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Sub RecordUpdate()
        If cbText = "ALL" Then
            Try
                connDB()
                query = "UPDATE master_tbl SET unituser = @unituser, department = @department, contactno = @contactno WHERE propertyno = '" & propertyIDMaster & "'"
                Using cmdMaster As New SqlCommand(query, conn)
                    cmdMaster.Parameters.Clear()
                    cmdMaster.Parameters.AddWithValue("@unituser", txtUser.Text)
                    cmdMaster.Parameters.AddWithValue("@department", cbDepartment.Text)
                    cmdMaster.Parameters.AddWithValue("@contactno", txtContact.Text)
                    cmdMaster.ExecuteNonQuery()
                End Using


                query1 = "UPDATE transaction_tbl SET name = @name, category = @category, type = @type, date = @date, timein = @timein, timeout = @timeout, diagnosis = @diagnosis, assignedstaff = @assignedstaff, remarks = @remarks WHERE sequenceno = '" & sequenceID & "'"
                Using cmdTransaction As New SqlCommand(query1, conn)
                    cmdTransaction.Parameters.Clear()
                    cmdTransaction.Parameters.AddWithValue("@date", Format(dtDate.Value, "MM/dd/yyyy").ToString)
                    cmdTransaction.Parameters.AddWithValue("@timein", Format(dtTimeIn.Value, "hh:mm tt").ToString)
                    cmdTransaction.Parameters.AddWithValue("@timeout", Format(dtTimeOut.Value, "hh:mm tt").ToString)
                    cmdTransaction.Parameters.AddWithValue("@diagnosis", txtDiagnosis.Text)
                    cmdTransaction.Parameters.AddWithValue("@assignedstaff", txtAssignedStaff.Text)
                    cmdTransaction.Parameters.AddWithValue("@name", txtName.Text)
                    cmdTransaction.Parameters.AddWithValue("@category", cbCategory.Text)

                    If cbCategory.Text = "COMMON ICT SERVICES" Then
                        cmdTransaction.Parameters.AddWithValue("@type", Guna2ComboBox2.Text)
                    ElseIf cbCategory.Text = "HARDWARE" Then
                        cmdTransaction.Parameters.AddWithValue("@type", cbDeviceType.Text)
                    ElseIf cbCategory.Text = "SOFTWARE" Then
                        cmdTransaction.Parameters.AddWithValue("@type", Guna2ComboBox1.Text)
                    End If

                    cmdTransaction.Parameters.AddWithValue("@remarks", txtRemarks.Text)
                    cmdTransaction.ExecuteNonQuery()
                End Using
                conn.Close()
            Catch ex As Exception

            End Try
        ElseIf cbText = "TRANSACTION" Then
            Try
                connDB()
                query1 = "UPDATE transaction_tbl SET name = @name, category = @category, type = @type, date = @date, timein = @timein, timeout = @timeout, diagnosis = @diagnosis, assignedstaff = @assignedstaff, remarks = @remarks WHERE sequenceno = '" & sequenceID & "'"
                Using cmdTransaction As New SqlCommand(query1, conn)
                    cmdTransaction.Parameters.Clear()
                    cmdTransaction.Parameters.AddWithValue("@date", Format(dtDate.Value, "MM/dd/yyyy").ToString)
                    cmdTransaction.Parameters.AddWithValue("@timein", Format(dtTimeIn.Value, "hh:mm tt").ToString)
                    cmdTransaction.Parameters.AddWithValue("@timeout", Format(dtTimeOut.Value, "hh:mm tt").ToString)
                    cmdTransaction.Parameters.AddWithValue("@diagnosis", txtDiagnosis.Text)
                    cmdTransaction.Parameters.AddWithValue("@assignedstaff", txtAssignedStaff.Text)
                    cmdTransaction.Parameters.AddWithValue("@name", txtName.Text)
                    cmdTransaction.Parameters.AddWithValue("@category", cbCategory.Text)

                    If cbCategory.Text = "COMMON ICT SERVICES" Then
                        cmdTransaction.Parameters.AddWithValue("@type", Guna2ComboBox2.Text)
                    ElseIf cbCategory.Text = "HARDWARE" Then
                        cmdTransaction.Parameters.AddWithValue("@type", cbDeviceType.Text)
                    ElseIf cbCategory.Text = "SOFTWARE" Then
                        cmdTransaction.Parameters.AddWithValue("@type", Guna2ComboBox1.Text)
                    End If

                    cmdTransaction.Parameters.AddWithValue("@remarks", txtRemarks.Text)
                    cmdTransaction.ExecuteNonQuery()
                End Using
                conn.Close()
            Catch ex As Exception

            End Try
        ElseIf cbText = "MASTER" Then
            Try
                connDB()
                query = "UPDATE master_tbl SET unituser = @unituser, department = @department, contactno = @contactno WHERE propertyno = '" & propertyID & "'"
                Using cmdMaster As New SqlCommand(query, conn)
                    cmdMaster.Parameters.Clear()
                    cmdMaster.Parameters.AddWithValue("@unituser", txtUser.Text)
                    cmdMaster.Parameters.AddWithValue("@department", cbDepartment.Text)
                    cmdMaster.Parameters.AddWithValue("@contactno", txtContact.Text)
                    cmdMaster.ExecuteNonQuery()
                End Using
                conn.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

End Class