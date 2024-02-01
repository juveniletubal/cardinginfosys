<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_Form))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.DataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnMaximize = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRefresh = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cbTable = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnView = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnModify = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlToolTip1 = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.anima = New Guna.UI2.WinForms.Guna2Transition()
        Me.msgInfo = New Guna.UI2.WinForms.Guna2MessageDialog()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 6
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me.DataGridView
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView.ColumnHeadersHeight = 38
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.anima.SetDecoration(Me.DataGridView, Guna.UI2.AnimatorNS.DecorationType.None)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DataGridView.Location = New System.Drawing.Point(2, 2)
        Me.DataGridView.MultiSelect = False
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.RowTemplate.Height = 38
        Me.DataGridView.Size = New System.Drawing.Size(1181, 587)
        Me.DataGridView.TabIndex = 0
        Me.DataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue
        Me.DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DataGridView.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView.ThemeStyle.HeaderStyle.Height = 38
        Me.DataGridView.ThemeStyle.ReadOnly = True
        Me.DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView.ThemeStyle.RowsStyle.Height = 38
        Me.DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockForm = True
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel3
        Me.Guna2DragControl1.TransparentWhileDrag = False
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel3.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel3.Controls.Add(Me.Guna2ControlBox3)
        Me.Guna2Panel3.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel3.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel3.Controls.Add(Me.Label9)
        Me.Guna2Panel3.Controls.Add(Me.btnMinimize)
        Me.Guna2Panel3.Controls.Add(Me.btnMaximize)
        Me.Guna2Panel3.Controls.Add(Me.btnClose)
        Me.anima.SetDecoration(Me.Guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(1203, 78)
        Me.Guna2Panel3.TabIndex = 71
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.anima.SetDecoration(Me.Guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox2.Image = Global.Patient_Record.My.Resources.Resources.hand
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(964, 19)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(56, 49)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 87
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.anima.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.Image = Global.Patient_Record.My.Resources.Resources._4230963
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(182, 19)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(56, 49)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 86
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.anima.SetDecoration(Me.Guna2ControlBox3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(1133, 48)
        Me.Guna2ControlBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(16, 18)
        Me.Guna2ControlBox3.TabIndex = 78
        Me.Guna2ControlBox3.Visible = False
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.anima.SetDecoration(Me.Guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1153, 48)
        Me.Guna2ControlBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(16, 18)
        Me.Guna2ControlBox2.TabIndex = 77
        Me.Guna2ControlBox2.Visible = False
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.anima.SetDecoration(Me.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1173, 48)
        Me.Guna2ControlBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(16, 18)
        Me.Guna2ControlBox1.TabIndex = 76
        Me.Guna2ControlBox1.Visible = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.anima.SetDecoration(Me.Label9, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label9.Font = New System.Drawing.Font("Poppins SemiBold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(243, 18)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(716, 51)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "TECH-SUPPORT CARDING INFORMATION SYSTEM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.anima.SetDecoration(Me.btnMinimize, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnMinimize.HoverState.ImageSize = New System.Drawing.Size(36, 36)
        Me.btnMinimize.Image = Global.Patient_Record.My.Resources.Resources.icons8_minimize_50
        Me.btnMinimize.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnMinimize.ImageRotate = 0!
        Me.btnMinimize.ImageSize = New System.Drawing.Size(26, 26)
        Me.btnMinimize.Location = New System.Drawing.Point(1086, 12)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.PressedState.ImageSize = New System.Drawing.Size(36, 36)
        Me.btnMinimize.Size = New System.Drawing.Size(38, 36)
        Me.btnMinimize.TabIndex = 73
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.anima.SetDecoration(Me.btnMaximize, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnMaximize.HoverState.ImageSize = New System.Drawing.Size(36, 36)
        Me.btnMaximize.Image = Global.Patient_Record.My.Resources.Resources.icons8_maximize_50
        Me.btnMaximize.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnMaximize.ImageRotate = 0!
        Me.btnMaximize.ImageSize = New System.Drawing.Size(26, 26)
        Me.btnMaximize.Location = New System.Drawing.Point(1124, 6)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.PressedState.ImageSize = New System.Drawing.Size(36, 36)
        Me.btnMaximize.Size = New System.Drawing.Size(38, 36)
        Me.btnMaximize.TabIndex = 72
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.anima.SetDecoration(Me.btnClose, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnClose.HoverState.Image = Global.Patient_Record.My.Resources.Resources.icons8_close_50__2_
        Me.btnClose.HoverState.ImageSize = New System.Drawing.Size(36, 36)
        Me.btnClose.Image = Global.Patient_Record.My.Resources.Resources.icons8_close_50
        Me.btnClose.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnClose.ImageRotate = 0!
        Me.btnClose.ImageSize = New System.Drawing.Size(26, 26)
        Me.btnClose.Location = New System.Drawing.Point(1158, 6)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PressedState.ImageSize = New System.Drawing.Size(36, 36)
        Me.btnClose.Size = New System.Drawing.Size(38, 36)
        Me.btnClose.TabIndex = 71
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel4.Controls.Add(Me.btnRefresh)
        Me.Guna2Panel4.Controls.Add(Me.Guna2Panel5)
        Me.Guna2Panel4.Controls.Add(Me.Guna2Panel1)
        Me.Guna2Panel4.Controls.Add(Me.txtSearch)
        Me.Guna2Panel4.Controls.Add(Me.btnAdd)
        Me.Guna2Panel4.Controls.Add(Me.Guna2Panel2)
        Me.anima.SetDecoration(Me.Guna2Panel4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 78)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(1203, 662)
        Me.Guna2Panel4.TabIndex = 72
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BorderRadius = 8
        Me.anima.SetDecoration(Me.Guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Red
        Me.Guna2Button1.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = Global.Patient_Record.My.Resources.Resources.icons8_print_50
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(24, 24)
        Me.Guna2Button1.Location = New System.Drawing.Point(682, 20)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(55, 37)
        Me.Guna2Button1.TabIndex = 73
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(0, 1)
        Me.Guna2HtmlToolTip1.SetToolTip(Me.Guna2Button1, "View Record")
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.anima.SetDecoration(Me.btnRefresh, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnRefresh.HoverState.ImageSize = New System.Drawing.Size(44, 44)
        Me.btnRefresh.Image = Global.Patient_Record.My.Resources.Resources.icons8_refresh_60
        Me.btnRefresh.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnRefresh.ImageRotate = 0!
        Me.btnRefresh.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnRefresh.Location = New System.Drawing.Point(624, 20)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.PressedState.ImageSize = New System.Drawing.Size(36, 36)
        Me.btnRefresh.Size = New System.Drawing.Size(48, 36)
        Me.btnRefresh.TabIndex = 72
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Guna2Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel5.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Guna2Panel5.BorderRadius = 6
        Me.Guna2Panel5.BorderThickness = 1
        Me.Guna2Panel5.Controls.Add(Me.cbTable)
        Me.anima.SetDecoration(Me.Guna2Panel5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel5.FillColor = System.Drawing.Color.White
        Me.Guna2Panel5.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Panel5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel5.Location = New System.Drawing.Point(757, 20)
        Me.Guna2Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Padding = New System.Windows.Forms.Padding(1)
        Me.Guna2Panel5.Size = New System.Drawing.Size(155, 37)
        Me.Guna2Panel5.TabIndex = 69
        '
        'cbTable
        '
        Me.cbTable.BackColor = System.Drawing.Color.Transparent
        Me.cbTable.BorderRadius = 6
        Me.cbTable.BorderThickness = 0
        Me.anima.SetDecoration(Me.cbTable, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.cbTable.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.cbTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.cbTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTable.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbTable.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.cbTable.ForeColor = System.Drawing.Color.Black
        Me.cbTable.ItemHeight = 30
        Me.cbTable.Items.AddRange(New Object() {"ALL", "TRANSACTION", "MASTER"})
        Me.cbTable.Location = New System.Drawing.Point(1, 1)
        Me.cbTable.Margin = New System.Windows.Forms.Padding(2)
        Me.cbTable.Name = "cbTable"
        Me.cbTable.Size = New System.Drawing.Size(153, 36)
        Me.cbTable.StartIndex = 0
        Me.cbTable.TabIndex = 8
        Me.cbTable.TextOffset = New System.Drawing.Point(1, 0)
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.Controls.Add(Me.DataGridView)
        Me.anima.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel1.Location = New System.Drawing.Point(9, 63)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel1.Size = New System.Drawing.Size(1185, 591)
        Me.Guna2Panel1.TabIndex = 66
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Animated = True
        Me.txtSearch.BorderColor = System.Drawing.Color.DodgerBlue
        Me.txtSearch.BorderRadius = 6
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima.SetDecoration(Me.txtSearch, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.IconLeft = Global.Patient_Record.My.Resources.Resources.icons8_search_28
        Me.txtSearch.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtSearch.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.txtSearch.Location = New System.Drawing.Point(917, 20)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtSearch.PlaceholderText = "Search Here"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(275, 37)
        Me.txtSearch.TabIndex = 67
        Me.txtSearch.TextOffset = New System.Drawing.Point(5, -1)
        '
        'btnAdd
        '
        Me.btnAdd.Animated = True
        Me.btnAdd.BorderRadius = 8
        Me.anima.SetDecoration(Me.btnAdd, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Image = Global.Patient_Record.My.Resources.Resources.icons8_plus_50__1_
        Me.btnAdd.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnAdd.Location = New System.Drawing.Point(11, 20)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(55, 37)
        Me.btnAdd.TabIndex = 65
        Me.btnAdd.TextOffset = New System.Drawing.Point(0, 1)
        Me.Guna2HtmlToolTip1.SetToolTip(Me.btnAdd, "Add Record")
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.btnView)
        Me.Guna2Panel2.Controls.Add(Me.btnDelete)
        Me.Guna2Panel2.Controls.Add(Me.btnModify)
        Me.anima.SetDecoration(Me.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel2.Location = New System.Drawing.Point(72, 17)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(211, 42)
        Me.Guna2Panel2.TabIndex = 68
        Me.Guna2Panel2.Visible = False
        '
        'btnView
        '
        Me.btnView.Animated = True
        Me.btnView.BorderRadius = 8
        Me.anima.SetDecoration(Me.btnView, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnView.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnView.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnView.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnView.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Image = Global.Patient_Record.My.Resources.Resources.icons8_view_quilt_50
        Me.btnView.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnView.Location = New System.Drawing.Point(149, 3)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(55, 37)
        Me.btnView.TabIndex = 68
        Me.btnView.TextOffset = New System.Drawing.Point(0, 1)
        Me.Guna2HtmlToolTip1.SetToolTip(Me.btnView, "View Record")
        '
        'btnDelete
        '
        Me.btnDelete.Animated = True
        Me.btnDelete.BorderRadius = 8
        Me.anima.SetDecoration(Me.btnDelete, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDelete.FillColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Global.Patient_Record.My.Resources.Resources.icons8_delete_50
        Me.btnDelete.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnDelete.Location = New System.Drawing.Point(79, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(55, 37)
        Me.btnDelete.TabIndex = 67
        Me.btnDelete.TextOffset = New System.Drawing.Point(0, 1)
        Me.Guna2HtmlToolTip1.SetToolTip(Me.btnDelete, "Delete Record")
        '
        'btnModify
        '
        Me.btnModify.Animated = True
        Me.btnModify.BorderRadius = 8
        Me.anima.SetDecoration(Me.btnModify, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnModify.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnModify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnModify.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnModify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnModify.FillColor = System.Drawing.Color.ForestGreen
        Me.btnModify.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.ForeColor = System.Drawing.Color.White
        Me.btnModify.Image = Global.Patient_Record.My.Resources.Resources.icons8_design_50
        Me.btnModify.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnModify.Location = New System.Drawing.Point(9, 3)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(55, 37)
        Me.btnModify.TabIndex = 66
        Me.btnModify.TextOffset = New System.Drawing.Point(0, 1)
        Me.Guna2HtmlToolTip1.SetToolTip(Me.btnModify, "Modify Record")
        '
        'Guna2HtmlToolTip1
        '
        Me.Guna2HtmlToolTip1.AllowLinksHandling = True
        Me.Guna2HtmlToolTip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlToolTip1.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlToolTip1.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'anima
        '
        Me.anima.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizBlind
        Me.anima.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.anima.DefaultAnimation = Animation1
        Me.anima.MaxAnimationTime = 1200
        '
        'msgInfo
        '
        Me.msgInfo.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.msgInfo.Caption = Nothing
        Me.msgInfo.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information
        Me.msgInfo.Parent = Nothing
        Me.msgInfo.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.msgInfo.Text = Nothing
        '
        'main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1203, 740)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.anima.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "main_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "main_Form"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnMaximize As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2HtmlToolTip1 As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnView As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnModify As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents anima As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cbTable As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnRefresh As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents msgInfo As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
