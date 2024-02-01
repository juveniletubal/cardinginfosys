<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_Patient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.popupLabel = New System.Windows.Forms.Label()
        Me.btnClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPropertyNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtContact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRemarks = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAssignedStaff = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDiagnosis = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cbDepartment = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cbCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtTimeIn = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtTimeOut = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.msgInfo = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cbDeviceType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ComboBox2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 6
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragForm = False
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.popupLabel)
        Me.Guna2Panel1.Controls.Add(Me.btnClose)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(690, 57)
        Me.Guna2Panel1.TabIndex = 0
        '
        'popupLabel
        '
        Me.popupLabel.AutoSize = True
        Me.popupLabel.Font = New System.Drawing.Font("Poppins SemiBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.popupLabel.ForeColor = System.Drawing.Color.Black
        Me.popupLabel.Location = New System.Drawing.Point(24, 14)
        Me.popupLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.popupLabel.Name = "popupLabel"
        Me.popupLabel.Size = New System.Drawing.Size(151, 37)
        Me.popupLabel.TabIndex = 34
        Me.popupLabel.Text = "ADD RECORD"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnClose.HoverState.Image = Global.Patient_Record.My.Resources.Resources.icons8_close_50__2_
        Me.btnClose.HoverState.ImageSize = New System.Drawing.Size(36, 36)
        Me.btnClose.Image = Global.Patient_Record.My.Resources.Resources.icons8_close_50
        Me.btnClose.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnClose.ImageRotate = 0!
        Me.btnClose.ImageSize = New System.Drawing.Size(26, 26)
        Me.btnClose.Location = New System.Drawing.Point(644, 7)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PressedState.ImageSize = New System.Drawing.Size(36, 36)
        Me.btnClose.Size = New System.Drawing.Size(38, 36)
        Me.btnClose.TabIndex = 7
        '
        'txtName
        '
        Me.txtName.Animated = True
        Me.txtName.AutoCompleteCustomSource.AddRange(New String() {"Patac", "Pasuelo", "Magat", "Genive", "Zapatos", "De Los Reyes", "Rolando ", "Percival", "Celso ", "Renante" & Global.Microsoft.VisualBasic.ChrW(9), "Mark Kristofer"})
        Me.txtName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtName.BackColor = System.Drawing.Color.Transparent
        Me.txtName.BorderColor = System.Drawing.Color.DodgerBlue
        Me.txtName.BorderRadius = 6
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.DimGray
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.DarkGray
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(56, 167)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtName.MaxLength = 20
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtName.PlaceholderText = "ENTER NAME"
        Me.txtName.SelectedText = ""
        Me.txtName.Size = New System.Drawing.Size(267, 37)
        Me.txtName.TabIndex = 1
        Me.txtName.TextOffset = New System.Drawing.Point(1, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(51, 140)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 26)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Name"
        '
        'txtPropertyNo
        '
        Me.txtPropertyNo.Animated = True
        Me.txtPropertyNo.AutoCompleteCustomSource.AddRange(New String() {"Patac", "Pasuelo", "Magat", "Genive", "Zapatos", "De Los Reyes", "Rolando ", "Percival", "Celso ", "Renante" & Global.Microsoft.VisualBasic.ChrW(9), "Mark Kristofer"})
        Me.txtPropertyNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtPropertyNo.BackColor = System.Drawing.Color.Transparent
        Me.txtPropertyNo.BorderColor = System.Drawing.Color.DodgerBlue
        Me.txtPropertyNo.BorderRadius = 6
        Me.txtPropertyNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPropertyNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPropertyNo.DefaultText = ""
        Me.txtPropertyNo.DisabledState.BorderColor = System.Drawing.Color.DimGray
        Me.txtPropertyNo.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtPropertyNo.DisabledState.ForeColor = System.Drawing.Color.DarkGray
        Me.txtPropertyNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPropertyNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPropertyNo.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropertyNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPropertyNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPropertyNo.Location = New System.Drawing.Point(56, 93)
        Me.txtPropertyNo.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtPropertyNo.MaxLength = 20
        Me.txtPropertyNo.Name = "txtPropertyNo"
        Me.txtPropertyNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropertyNo.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtPropertyNo.PlaceholderText = "ENTER PROPERTY NO."
        Me.txtPropertyNo.SelectedText = ""
        Me.txtPropertyNo.Size = New System.Drawing.Size(267, 37)
        Me.txtPropertyNo.TabIndex = 0
        Me.txtPropertyNo.TextOffset = New System.Drawing.Point(1, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(51, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 26)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Property No."
        '
        'txtContact
        '
        Me.txtContact.Animated = True
        Me.txtContact.AutoCompleteCustomSource.AddRange(New String() {"Patac", "Pasuelo", "Magat", "Genive", "Zapatos", "De Los Reyes", "Rolando ", "Percival", "Celso ", "Renante" & Global.Microsoft.VisualBasic.ChrW(9), "Mark Kristofer"})
        Me.txtContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtContact.BackColor = System.Drawing.Color.Transparent
        Me.txtContact.BorderColor = System.Drawing.Color.DodgerBlue
        Me.txtContact.BorderRadius = 6
        Me.txtContact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContact.DefaultText = ""
        Me.txtContact.DisabledState.BorderColor = System.Drawing.Color.DimGray
        Me.txtContact.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtContact.DisabledState.ForeColor = System.Drawing.Color.DarkGray
        Me.txtContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContact.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContact.Location = New System.Drawing.Point(57, 316)
        Me.txtContact.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtContact.MaxLength = 20
        Me.txtContact.Name = "txtContact"
        Me.txtContact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContact.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtContact.PlaceholderText = "ENTER CONTACT NO."
        Me.txtContact.SelectedText = ""
        Me.txtContact.Size = New System.Drawing.Size(267, 37)
        Me.txtContact.TabIndex = 2
        Me.txtContact.TextOffset = New System.Drawing.Point(1, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(52, 289)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 26)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Contact No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(51, 214)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 26)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Department"
        '
        'txtRemarks
        '
        Me.txtRemarks.Animated = True
        Me.txtRemarks.AutoCompleteCustomSource.AddRange(New String() {"Patac", "Pasuelo", "Magat", "Genive", "Zapatos", "De Los Reyes", "Rolando ", "Percival", "Celso ", "Renante" & Global.Microsoft.VisualBasic.ChrW(9), "Mark Kristofer"})
        Me.txtRemarks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtRemarks.BackColor = System.Drawing.Color.Transparent
        Me.txtRemarks.BorderColor = System.Drawing.Color.DodgerBlue
        Me.txtRemarks.BorderRadius = 6
        Me.txtRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemarks.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRemarks.DefaultText = ""
        Me.txtRemarks.DisabledState.BorderColor = System.Drawing.Color.DimGray
        Me.txtRemarks.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtRemarks.DisabledState.ForeColor = System.Drawing.Color.DarkGray
        Me.txtRemarks.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRemarks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRemarks.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRemarks.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRemarks.Location = New System.Drawing.Point(366, 391)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtRemarks.MaxLength = 20
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRemarks.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtRemarks.PlaceholderText = "ENTER REMARKS"
        Me.txtRemarks.SelectedText = ""
        Me.txtRemarks.Size = New System.Drawing.Size(267, 37)
        Me.txtRemarks.TabIndex = 6
        Me.txtRemarks.TextOffset = New System.Drawing.Point(1, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(361, 364)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 26)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Remarks"
        '
        'txtAssignedStaff
        '
        Me.txtAssignedStaff.Animated = True
        Me.txtAssignedStaff.AutoCompleteCustomSource.AddRange(New String() {"Patac", "Pasuelo", "Magat", "Genive", "Zapatos", "De Los Reyes", "Rolando ", "Percival", "Celso ", "Renante" & Global.Microsoft.VisualBasic.ChrW(9), "Mark Kristofer"})
        Me.txtAssignedStaff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtAssignedStaff.BackColor = System.Drawing.Color.Transparent
        Me.txtAssignedStaff.BorderColor = System.Drawing.Color.DodgerBlue
        Me.txtAssignedStaff.BorderRadius = 6
        Me.txtAssignedStaff.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAssignedStaff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAssignedStaff.DefaultText = ""
        Me.txtAssignedStaff.DisabledState.BorderColor = System.Drawing.Color.DimGray
        Me.txtAssignedStaff.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtAssignedStaff.DisabledState.ForeColor = System.Drawing.Color.DarkGray
        Me.txtAssignedStaff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAssignedStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAssignedStaff.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssignedStaff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAssignedStaff.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAssignedStaff.Location = New System.Drawing.Point(366, 316)
        Me.txtAssignedStaff.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtAssignedStaff.MaxLength = 20
        Me.txtAssignedStaff.Name = "txtAssignedStaff"
        Me.txtAssignedStaff.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAssignedStaff.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtAssignedStaff.PlaceholderText = "ENTER ASSIGNED STAFF"
        Me.txtAssignedStaff.SelectedText = ""
        Me.txtAssignedStaff.Size = New System.Drawing.Size(267, 37)
        Me.txtAssignedStaff.TabIndex = 5
        Me.txtAssignedStaff.TextOffset = New System.Drawing.Point(1, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(361, 289)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 26)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Assigned Staff"
        '
        'txtDiagnosis
        '
        Me.txtDiagnosis.Animated = True
        Me.txtDiagnosis.AutoCompleteCustomSource.AddRange(New String() {"Patac", "Pasuelo", "Magat", "Genive", "Zapatos", "De Los Reyes", "Rolando ", "Percival", "Celso ", "Renante" & Global.Microsoft.VisualBasic.ChrW(9), "Mark Kristofer"})
        Me.txtDiagnosis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtDiagnosis.BackColor = System.Drawing.Color.Transparent
        Me.txtDiagnosis.BorderColor = System.Drawing.Color.DodgerBlue
        Me.txtDiagnosis.BorderRadius = 6
        Me.txtDiagnosis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiagnosis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiagnosis.DefaultText = ""
        Me.txtDiagnosis.DisabledState.BorderColor = System.Drawing.Color.DimGray
        Me.txtDiagnosis.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtDiagnosis.DisabledState.ForeColor = System.Drawing.Color.DarkGray
        Me.txtDiagnosis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDiagnosis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDiagnosis.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiagnosis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDiagnosis.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDiagnosis.Location = New System.Drawing.Point(366, 241)
        Me.txtDiagnosis.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtDiagnosis.MaxLength = 20
        Me.txtDiagnosis.Name = "txtDiagnosis"
        Me.txtDiagnosis.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDiagnosis.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtDiagnosis.PlaceholderText = "ENTER DIAGNOSIS"
        Me.txtDiagnosis.SelectedText = ""
        Me.txtDiagnosis.Size = New System.Drawing.Size(267, 37)
        Me.txtDiagnosis.TabIndex = 4
        Me.txtDiagnosis.TextOffset = New System.Drawing.Point(1, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(361, 214)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 26)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Diagnosis"
        '
        'txtUser
        '
        Me.txtUser.Animated = True
        Me.txtUser.AutoCompleteCustomSource.AddRange(New String() {"Patac", "Pasuelo", "Magat", "Genive", "Zapatos", "De Los Reyes", "Rolando ", "Percival", "Celso ", "Renante" & Global.Microsoft.VisualBasic.ChrW(9), "Mark Kristofer"})
        Me.txtUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtUser.BackColor = System.Drawing.Color.Transparent
        Me.txtUser.BorderColor = System.Drawing.Color.DodgerBlue
        Me.txtUser.BorderRadius = 6
        Me.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser.DefaultText = ""
        Me.txtUser.DisabledState.BorderColor = System.Drawing.Color.DimGray
        Me.txtUser.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtUser.DisabledState.ForeColor = System.Drawing.Color.DarkGray
        Me.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUser.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUser.Location = New System.Drawing.Point(366, 465)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtUser.MaxLength = 20
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUser.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtUser.PlaceholderText = "ENTER USER"
        Me.txtUser.SelectedText = ""
        Me.txtUser.Size = New System.Drawing.Size(267, 37)
        Me.txtUser.TabIndex = 3
        Me.txtUser.TextOffset = New System.Drawing.Point(1, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(361, 438)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 26)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "User"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Guna2Panel2.BorderRadius = 6
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.cbDepartment)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Panel2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel2.Location = New System.Drawing.Point(56, 241)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Guna2Panel2.Size = New System.Drawing.Size(267, 37)
        Me.Guna2Panel2.TabIndex = 52
        '
        'cbDepartment
        '
        Me.cbDepartment.BackColor = System.Drawing.Color.Transparent
        Me.cbDepartment.BorderRadius = 6
        Me.cbDepartment.BorderThickness = 0
        Me.cbDepartment.DisabledState.BorderColor = System.Drawing.Color.DimGray
        Me.cbDepartment.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.cbDepartment.DisabledState.ForeColor = System.Drawing.Color.DarkGray
        Me.cbDepartment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartment.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbDepartment.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.cbDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbDepartment.IntegralHeight = False
        Me.cbDepartment.ItemHeight = 30
        Me.cbDepartment.Items.AddRange(New Object() {"SELECT DEPARTMENT", "Office of the City Mayor", "CMO - Bids and Awards Committee Office", "CMO - Integrated Barangay Affairs Division", "CMO - Public Employment Service Office", "CMO - Sports & Games Development Division", "CMO - Youth Affairs Division Office", "PSO - Civil Security Division", "CMO - BPLO", "CMO - CPIO", "CMO - ICTD", "CMO - Integrated Cultural Communities Affairs Division", "CMO - OSCA", "CMO - PDAO", "CMO - NBI", "CMO - AMPING", "CMO - AKLAT", "Public Safety Office", "Sangguniang Panlungsod - Vice Mayors Office", "Sangguniang Panlungsod - Legislative Support Services", "Sangguniang Panlungsod - City Councilors Office", "City Administrators Office", "City Administrators Office - Public Market Administration", "City Budget Office", "City Agriculturist Office", "City Veterinarians Office", "City Planning and Development Office", "Local Civil Registrars Office", "City General Services Office", "City Economic Management and Cooperative Development Office", "City Housing and Land Management Office", "City Accountants Office", "City Treasurers Office", "City Treasurers Office - Public Market", "City Assessors Office", "City Internal Audit Services", "City Social Welfare and Development Office", "Public Attorneys Office", "City Legal Office", "City Health Office", "Dr. Jorge P. Royeca City Hospital", "GSC Hospital Services Department", "City Environment and  Natural Resources Office", "Waste Management Office", "Human Resource Management and Development Office", "City Population Management Office", "City Engineers Office", "Office of the Building Official", "RTC Branch 23", "Peoples Law Enforcement Services", "Peace and Order Program - Local Task Force", "Commission on Elections (COMELEC)", "Liga ng mga Barangays", "Department of Interior and Local Government", "Parole and Probation Office", "RTC Branch 37", "Municipal Trial Court in Cities Branch 1", "RTC Branch 60", "Municipal Trial Court in Cities Branch 3", "Municipal Trial Court in Cities Branch 2"})
        Me.cbDepartment.Location = New System.Drawing.Point(1, 1)
        Me.cbDepartment.Margin = New System.Windows.Forms.Padding(2)
        Me.cbDepartment.Name = "cbDepartment"
        Me.cbDepartment.Size = New System.Drawing.Size(265, 36)
        Me.cbDepartment.StartIndex = 0
        Me.cbDepartment.TabIndex = 7
        Me.cbDepartment.TextOffset = New System.Drawing.Point(1, 0)
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Guna2Panel3.BorderRadius = 6
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.cbCategory)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Panel3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel3.Location = New System.Drawing.Point(57, 394)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Padding = New System.Windows.Forms.Padding(1)
        Me.Guna2Panel3.Size = New System.Drawing.Size(267, 37)
        Me.Guna2Panel3.TabIndex = 54
        '
        'cbCategory
        '
        Me.cbCategory.BackColor = System.Drawing.Color.Transparent
        Me.cbCategory.BorderRadius = 6
        Me.cbCategory.BorderThickness = 0
        Me.cbCategory.DisabledState.BorderColor = System.Drawing.Color.DimGray
        Me.cbCategory.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.cbCategory.DisabledState.ForeColor = System.Drawing.Color.DarkGray
        Me.cbCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategory.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCategory.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.cbCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbCategory.ItemHeight = 30
        Me.cbCategory.Items.AddRange(New Object() {"SELECT CATEGORY", "HARDWARE", "SOFTWARE", "COMMON ICT SERVICES"})
        Me.cbCategory.Location = New System.Drawing.Point(1, 1)
        Me.cbCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(265, 36)
        Me.cbCategory.StartIndex = 0
        Me.cbCategory.TabIndex = 8
        Me.cbCategory.TextOffset = New System.Drawing.Point(1, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(52, 367)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 26)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Category"
        '
        'dtDate
        '
        Me.dtDate.BackColor = System.Drawing.Color.Transparent
        Me.dtDate.BorderRadius = 6
        Me.dtDate.BorderThickness = 1
        Me.dtDate.Checked = True
        Me.dtDate.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.dtDate.CheckedState.FillColor = System.Drawing.Color.White
        Me.dtDate.CustomFormat = "MM/dd/yyyyy"
        Me.dtDate.FillColor = System.Drawing.Color.White
        Me.dtDate.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDate.Location = New System.Drawing.Point(366, 93)
        Me.dtDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dtDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtDate.MaximumSize = New System.Drawing.Size(287, 37)
        Me.dtDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(267, 37)
        Me.dtDate.TabIndex = 9
        Me.dtDate.TextOffset = New System.Drawing.Point(2, 1)
        Me.dtDate.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase
        Me.dtDate.UseTransparentBackground = True
        Me.dtDate.Value = New Date(2023, 10, 14, 18, 40, 0, 710)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(361, 66)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 26)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Date"
        '
        'dtTimeIn
        '
        Me.dtTimeIn.BackColor = System.Drawing.Color.Transparent
        Me.dtTimeIn.BorderColor = System.Drawing.Color.DodgerBlue
        Me.dtTimeIn.BorderRadius = 6
        Me.dtTimeIn.BorderThickness = 1
        Me.dtTimeIn.Checked = True
        Me.dtTimeIn.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.dtTimeIn.CheckedState.FillColor = System.Drawing.Color.White
        Me.dtTimeIn.CustomFormat = "hh:mm tt"
        Me.dtTimeIn.FillColor = System.Drawing.Color.White
        Me.dtTimeIn.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTimeIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTimeIn.Location = New System.Drawing.Point(366, 167)
        Me.dtTimeIn.Margin = New System.Windows.Forms.Padding(2)
        Me.dtTimeIn.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtTimeIn.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtTimeIn.Name = "dtTimeIn"
        Me.dtTimeIn.ShowUpDown = True
        Me.dtTimeIn.Size = New System.Drawing.Size(129, 37)
        Me.dtTimeIn.TabIndex = 10
        Me.dtTimeIn.TextOffset = New System.Drawing.Point(2, 1)
        Me.dtTimeIn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase
        Me.dtTimeIn.UseTransparentBackground = True
        Me.dtTimeIn.Value = New Date(2023, 10, 14, 18, 40, 0, 710)
        '
        'dtTimeOut
        '
        Me.dtTimeOut.BackColor = System.Drawing.Color.Transparent
        Me.dtTimeOut.BorderColor = System.Drawing.Color.DodgerBlue
        Me.dtTimeOut.BorderRadius = 6
        Me.dtTimeOut.BorderThickness = 1
        Me.dtTimeOut.Checked = True
        Me.dtTimeOut.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.dtTimeOut.CheckedState.FillColor = System.Drawing.Color.White
        Me.dtTimeOut.CustomFormat = "hh:mm tt"
        Me.dtTimeOut.FillColor = System.Drawing.Color.White
        Me.dtTimeOut.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTimeOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTimeOut.Location = New System.Drawing.Point(504, 167)
        Me.dtTimeOut.Margin = New System.Windows.Forms.Padding(2)
        Me.dtTimeOut.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtTimeOut.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtTimeOut.Name = "dtTimeOut"
        Me.dtTimeOut.ShowUpDown = True
        Me.dtTimeOut.Size = New System.Drawing.Size(129, 37)
        Me.dtTimeOut.TabIndex = 11
        Me.dtTimeOut.TextOffset = New System.Drawing.Point(2, 1)
        Me.dtTimeOut.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase
        Me.dtTimeOut.UseTransparentBackground = True
        Me.dtTimeOut.Value = New Date(2023, 10, 14, 18, 40, 0, 710)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(361, 140)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 26)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Time In"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(499, 140)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 26)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Time Out"
        '
        'btnSave
        '
        Me.btnSave.Animated = True
        Me.btnSave.BorderRadius = 8
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(57, 530)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(577, 45)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.TextOffset = New System.Drawing.Point(0, 1)
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        Me.Guna2DragControl1.TransparentWhileDrag = False
        '
        'msgInfo
        '
        Me.msgInfo.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.msgInfo.Caption = Nothing
        Me.msgInfo.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information
        Me.msgInfo.Parent = Me
        Me.msgInfo.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.msgInfo.Text = Nothing
        '
        'panel1
        '
        Me.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.BorderColor = System.Drawing.Color.DodgerBlue
        Me.panel1.BorderRadius = 6
        Me.panel1.BorderThickness = 1
        Me.panel1.Controls.Add(Me.cbDeviceType)
        Me.panel1.FillColor = System.Drawing.Color.White
        Me.panel1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.panel1.Location = New System.Drawing.Point(56, 465)
        Me.panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.panel1.Size = New System.Drawing.Size(267, 37)
        Me.panel1.TabIndex = 62
        Me.panel1.Visible = False
        '
        'cbDeviceType
        '
        Me.cbDeviceType.BackColor = System.Drawing.Color.Transparent
        Me.cbDeviceType.BorderRadius = 6
        Me.cbDeviceType.BorderThickness = 0
        Me.cbDeviceType.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.cbDeviceType.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.cbDeviceType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbDeviceType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDeviceType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbDeviceType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbDeviceType.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.cbDeviceType.ForeColor = System.Drawing.Color.Black
        Me.cbDeviceType.ItemHeight = 30
        Me.cbDeviceType.Items.AddRange(New Object() {"SELECT HARDWARE TYPE", "HARD DRIVE", "MOTHER BOARD", "POWER SUPPLY", "DISPLAY", "RAM", "PRINTER"})
        Me.cbDeviceType.Location = New System.Drawing.Point(1, 1)
        Me.cbDeviceType.Margin = New System.Windows.Forms.Padding(2)
        Me.cbDeviceType.Name = "cbDeviceType"
        Me.cbDeviceType.Size = New System.Drawing.Size(265, 36)
        Me.cbDeviceType.StartIndex = 0
        Me.cbDeviceType.TabIndex = 8
        Me.cbDeviceType.TextOffset = New System.Drawing.Point(1, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(51, 438)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 26)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Device Type"
        '
        'panel2
        '
        Me.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panel2.BackColor = System.Drawing.Color.Transparent
        Me.panel2.BorderColor = System.Drawing.Color.DodgerBlue
        Me.panel2.BorderRadius = 6
        Me.panel2.BorderThickness = 1
        Me.panel2.Controls.Add(Me.Guna2ComboBox1)
        Me.panel2.FillColor = System.Drawing.Color.White
        Me.panel2.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.panel2.Location = New System.Drawing.Point(56, 465)
        Me.panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.panel2.Name = "panel2"
        Me.panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.panel2.Size = New System.Drawing.Size(267, 37)
        Me.panel2.TabIndex = 63
        Me.panel2.Visible = False
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.BorderRadius = 6
        Me.Guna2ComboBox1.BorderThickness = 0
        Me.Guna2ComboBox1.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.Guna2ComboBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Guna2ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.Items.AddRange(New Object() {"SELECT SOFTWARE TYPE", "OPERATING SYSTEM", "APPLICATION SOFTWARE"})
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(1, 1)
        Me.Guna2ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(265, 36)
        Me.Guna2ComboBox1.StartIndex = 0
        Me.Guna2ComboBox1.TabIndex = 8
        Me.Guna2ComboBox1.TextOffset = New System.Drawing.Point(1, 0)
        '
        'panel3
        '
        Me.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panel3.BackColor = System.Drawing.Color.Transparent
        Me.panel3.BorderColor = System.Drawing.Color.DodgerBlue
        Me.panel3.BorderRadius = 6
        Me.panel3.BorderThickness = 1
        Me.panel3.Controls.Add(Me.Guna2ComboBox2)
        Me.panel3.FillColor = System.Drawing.Color.White
        Me.panel3.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.panel3.Location = New System.Drawing.Point(56, 465)
        Me.panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.panel3.Name = "panel3"
        Me.panel3.Padding = New System.Windows.Forms.Padding(1)
        Me.panel3.Size = New System.Drawing.Size(267, 37)
        Me.panel3.TabIndex = 64
        '
        'Guna2ComboBox2
        '
        Me.Guna2ComboBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox2.BorderRadius = 6
        Me.Guna2ComboBox2.BorderThickness = 0
        Me.Guna2ComboBox2.DisabledState.BorderColor = System.Drawing.Color.DimGray
        Me.Guna2ComboBox2.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2ComboBox2.DisabledState.ForeColor = System.Drawing.Color.DarkGray
        Me.Guna2ComboBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox2.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.Guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2ComboBox2.ItemHeight = 30
        Me.Guna2ComboBox2.Items.AddRange(New Object() {"SELECT CIS TYPE", "VIRUS REMOVAL PROTECTION", "INSTALL/RE-INSTALL SOFTWARE", "CONNECTION PROTOCOL", "ASSESSMENT HW SW PW"})
        Me.Guna2ComboBox2.Location = New System.Drawing.Point(1, 1)
        Me.Guna2ComboBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2ComboBox2.Name = "Guna2ComboBox2"
        Me.Guna2ComboBox2.Size = New System.Drawing.Size(265, 36)
        Me.Guna2ComboBox2.StartIndex = 0
        Me.Guna2ComboBox2.TabIndex = 8
        Me.Guna2ComboBox2.TextOffset = New System.Drawing.Point(1, 0)
        '
        'add_Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(690, 606)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtTimeOut)
        Me.Controls.Add(Me.dtTimeIn)
        Me.Controls.Add(Me.dtDate)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.txtDiagnosis)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtAssignedStaff)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtPropertyNo)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "add_Patient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add_Patient"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents popupLabel As Label
    Friend WithEvents txtDiagnosis As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRemarks As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAssignedStaff As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtContact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPropertyNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cbDepartment As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cbCategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dtDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents dtTimeOut As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dtTimeIn As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents msgInfo As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cbDeviceType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ComboBox2 As Guna.UI2.WinForms.Guna2ComboBox
End Class
