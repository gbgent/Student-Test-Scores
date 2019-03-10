<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.mnu_Main = New System.Windows.Forms.MenuStrip()
        Me.mnu_MainFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_MainFileClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_MainFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_MainFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_FileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_MainFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_MainReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_MainReportPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_MainHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_MainHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.gb_StudentData = New System.Windows.Forms.GroupBox()
        Me.pnl_Averages = New System.Windows.Forms.Panel()
        Me.tx_Stu6Avg = New System.Windows.Forms.TextBox()
        Me.tx_Stu5Avg = New System.Windows.Forms.TextBox()
        Me.tx_Stu4Avg = New System.Windows.Forms.TextBox()
        Me.tx_Stu3Avg = New System.Windows.Forms.TextBox()
        Me.tx_Stu2Avg = New System.Windows.Forms.TextBox()
        Me.tx_Stu1Avg = New System.Windows.Forms.TextBox()
        Me.lbl_Average = New System.Windows.Forms.Label()
        Me.tx_Stu6Test5Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu6Test4Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu6Test3Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu6Test2Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu6Test1Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu5Test5Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu5Test4Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu5Test3Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu5Test2Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu5Test1Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu4Test5Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu4Test4Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu4Test3Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu4Test2Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu4Test1Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu3Test5Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu3Test4Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu3Test3Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu3Test2Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu3Test1Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu2Test5Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu2Test4Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu2Test3Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu2Test2Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu2Test1Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu6Name = New System.Windows.Forms.TextBox()
        Me.tx_Stu5Name = New System.Windows.Forms.TextBox()
        Me.tx_Stu4Name = New System.Windows.Forms.TextBox()
        Me.tx_Stu3Name = New System.Windows.Forms.TextBox()
        Me.tx_Stu2Name = New System.Windows.Forms.TextBox()
        Me.tx_Stu1Test5Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu1Test4Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu1Test3Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu1Test2Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu1Test1Score = New System.Windows.Forms.TextBox()
        Me.tx_Stu1Name = New System.Windows.Forms.TextBox()
        Me.lbl_TestScores = New System.Windows.Forms.Label()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.btn_CalcAverage = New System.Windows.Forms.Button()
        Me.pdPrint = New System.Drawing.Printing.PrintDocument()
        Me.pddPrintDialog = New System.Windows.Forms.PrintDialog()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.mnu_Main.SuspendLayout()
        Me.gb_StudentData.SuspendLayout()
        Me.pnl_Averages.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnu_Main
        '
        Me.mnu_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_MainFile, Me.mnu_MainReport, Me.mnu_MainHelp})
        Me.mnu_Main.Location = New System.Drawing.Point(0, 0)
        Me.mnu_Main.Name = "mnu_Main"
        Me.mnu_Main.Size = New System.Drawing.Size(746, 24)
        Me.mnu_Main.TabIndex = 0
        Me.mnu_Main.Text = "MenuStrip1"
        '
        'mnu_MainFile
        '
        Me.mnu_MainFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_MainFileClear, Me.ToolStripSeparator1, Me.mnu_MainFileOpen, Me.mnu_MainFileSave, Me.mnu_FileSaveAs, Me.ToolStripSeparator2, Me.mnu_MainFileExit})
        Me.mnu_MainFile.Name = "mnu_MainFile"
        Me.mnu_MainFile.Size = New System.Drawing.Size(37, 20)
        Me.mnu_MainFile.Text = "File"
        '
        'mnu_MainFileClear
        '
        Me.mnu_MainFileClear.Name = "mnu_MainFileClear"
        Me.mnu_MainFileClear.Size = New System.Drawing.Size(114, 22)
        Me.mnu_MainFileClear.Text = "&Clear"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(111, 6)
        '
        'mnu_MainFileOpen
        '
        Me.mnu_MainFileOpen.Name = "mnu_MainFileOpen"
        Me.mnu_MainFileOpen.Size = New System.Drawing.Size(114, 22)
        Me.mnu_MainFileOpen.Text = "&Open"
        '
        'mnu_MainFileSave
        '
        Me.mnu_MainFileSave.Name = "mnu_MainFileSave"
        Me.mnu_MainFileSave.Size = New System.Drawing.Size(114, 22)
        Me.mnu_MainFileSave.Text = "&Save"
        '
        'mnu_FileSaveAs
        '
        Me.mnu_FileSaveAs.Name = "mnu_FileSaveAs"
        Me.mnu_FileSaveAs.Size = New System.Drawing.Size(114, 22)
        Me.mnu_FileSaveAs.Text = "Save &As"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(111, 6)
        '
        'mnu_MainFileExit
        '
        Me.mnu_MainFileExit.Name = "mnu_MainFileExit"
        Me.mnu_MainFileExit.Size = New System.Drawing.Size(114, 22)
        Me.mnu_MainFileExit.Text = "E&xit"
        '
        'mnu_MainReport
        '
        Me.mnu_MainReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_MainReportPrint})
        Me.mnu_MainReport.Name = "mnu_MainReport"
        Me.mnu_MainReport.Size = New System.Drawing.Size(54, 20)
        Me.mnu_MainReport.Text = "Report"
        '
        'mnu_MainReportPrint
        '
        Me.mnu_MainReportPrint.Name = "mnu_MainReportPrint"
        Me.mnu_MainReportPrint.Size = New System.Drawing.Size(99, 22)
        Me.mnu_MainReportPrint.Text = "&Print"
        '
        'mnu_MainHelp
        '
        Me.mnu_MainHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_MainHelpAbout})
        Me.mnu_MainHelp.Name = "mnu_MainHelp"
        Me.mnu_MainHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnu_MainHelp.Text = "Help"
        '
        'mnu_MainHelpAbout
        '
        Me.mnu_MainHelpAbout.Name = "mnu_MainHelpAbout"
        Me.mnu_MainHelpAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnu_MainHelpAbout.Text = "&About"
        '
        'gb_StudentData
        '
        Me.gb_StudentData.Controls.Add(Me.pnl_Averages)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu6Test5Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu6Test4Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu6Test3Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu6Test2Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu6Test1Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu5Test5Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu5Test4Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu5Test3Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu5Test2Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu5Test1Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu4Test5Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu4Test4Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu4Test3Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu4Test2Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu4Test1Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu3Test5Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu3Test4Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu3Test3Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu3Test2Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu3Test1Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu2Test5Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu2Test4Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu2Test3Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu2Test2Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu2Test1Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu6Name)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu5Name)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu4Name)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu3Name)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu2Name)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu1Test5Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu1Test4Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu1Test3Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu1Test2Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu1Test1Score)
        Me.gb_StudentData.Controls.Add(Me.tx_Stu1Name)
        Me.gb_StudentData.Controls.Add(Me.lbl_TestScores)
        Me.gb_StudentData.Controls.Add(Me.lbl_Name)
        Me.gb_StudentData.Location = New System.Drawing.Point(12, 38)
        Me.gb_StudentData.Name = "gb_StudentData"
        Me.gb_StudentData.Size = New System.Drawing.Size(722, 341)
        Me.gb_StudentData.TabIndex = 1
        Me.gb_StudentData.TabStop = False
        Me.gb_StudentData.Text = "Student Data"
        '
        'pnl_Averages
        '
        Me.pnl_Averages.Controls.Add(Me.tx_Stu6Avg)
        Me.pnl_Averages.Controls.Add(Me.tx_Stu5Avg)
        Me.pnl_Averages.Controls.Add(Me.tx_Stu4Avg)
        Me.pnl_Averages.Controls.Add(Me.tx_Stu3Avg)
        Me.pnl_Averages.Controls.Add(Me.tx_Stu2Avg)
        Me.pnl_Averages.Controls.Add(Me.tx_Stu1Avg)
        Me.pnl_Averages.Controls.Add(Me.lbl_Average)
        Me.pnl_Averages.Enabled = False
        Me.pnl_Averages.Location = New System.Drawing.Point(591, 37)
        Me.pnl_Averages.Name = "pnl_Averages"
        Me.pnl_Averages.Size = New System.Drawing.Size(108, 303)
        Me.pnl_Averages.TabIndex = 45
        '
        'tx_Stu6Avg
        '
        Me.tx_Stu6Avg.Enabled = False
        Me.tx_Stu6Avg.Location = New System.Drawing.Point(24, 251)
        Me.tx_Stu6Avg.Name = "tx_Stu6Avg"
        Me.tx_Stu6Avg.Size = New System.Drawing.Size(55, 29)
        Me.tx_Stu6Avg.TabIndex = 44
        Me.tx_Stu6Avg.TabStop = False
        Me.tx_Stu6Avg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu5Avg
        '
        Me.tx_Stu5Avg.Enabled = False
        Me.tx_Stu5Avg.Location = New System.Drawing.Point(24, 208)
        Me.tx_Stu5Avg.Name = "tx_Stu5Avg"
        Me.tx_Stu5Avg.Size = New System.Drawing.Size(55, 29)
        Me.tx_Stu5Avg.TabIndex = 38
        Me.tx_Stu5Avg.TabStop = False
        Me.tx_Stu5Avg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu4Avg
        '
        Me.tx_Stu4Avg.Enabled = False
        Me.tx_Stu4Avg.Location = New System.Drawing.Point(24, 165)
        Me.tx_Stu4Avg.Name = "tx_Stu4Avg"
        Me.tx_Stu4Avg.Size = New System.Drawing.Size(55, 29)
        Me.tx_Stu4Avg.TabIndex = 32
        Me.tx_Stu4Avg.TabStop = False
        Me.tx_Stu4Avg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu3Avg
        '
        Me.tx_Stu3Avg.Enabled = False
        Me.tx_Stu3Avg.Location = New System.Drawing.Point(24, 122)
        Me.tx_Stu3Avg.Name = "tx_Stu3Avg"
        Me.tx_Stu3Avg.Size = New System.Drawing.Size(55, 29)
        Me.tx_Stu3Avg.TabIndex = 26
        Me.tx_Stu3Avg.TabStop = False
        Me.tx_Stu3Avg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu2Avg
        '
        Me.tx_Stu2Avg.Enabled = False
        Me.tx_Stu2Avg.Location = New System.Drawing.Point(24, 79)
        Me.tx_Stu2Avg.Name = "tx_Stu2Avg"
        Me.tx_Stu2Avg.Size = New System.Drawing.Size(55, 29)
        Me.tx_Stu2Avg.TabIndex = 20
        Me.tx_Stu2Avg.TabStop = False
        Me.tx_Stu2Avg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu1Avg
        '
        Me.tx_Stu1Avg.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.tx_Stu1Avg.Location = New System.Drawing.Point(24, 36)
        Me.tx_Stu1Avg.Name = "tx_Stu1Avg"
        Me.tx_Stu1Avg.Size = New System.Drawing.Size(55, 29)
        Me.tx_Stu1Avg.TabIndex = 9
        Me.tx_Stu1Avg.TabStop = False
        Me.tx_Stu1Avg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_Average
        '
        Me.lbl_Average.AutoSize = True
        Me.lbl_Average.Location = New System.Drawing.Point(13, 1)
        Me.lbl_Average.Name = "lbl_Average"
        Me.lbl_Average.Size = New System.Drawing.Size(67, 21)
        Me.lbl_Average.TabIndex = 2
        Me.lbl_Average.Text = "Average"
        '
        'tx_Stu6Test5Score
        '
        Me.tx_Stu6Test5Score.Location = New System.Drawing.Point(515, 288)
        Me.tx_Stu6Test5Score.Name = "tx_Stu6Test5Score"
        Me.tx_Stu6Test5Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu6Test5Score.TabIndex = 36
        Me.tx_Stu6Test5Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu6Test4Score
        '
        Me.tx_Stu6Test4Score.Location = New System.Drawing.Point(453, 288)
        Me.tx_Stu6Test4Score.Name = "tx_Stu6Test4Score"
        Me.tx_Stu6Test4Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu6Test4Score.TabIndex = 35
        Me.tx_Stu6Test4Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu6Test3Score
        '
        Me.tx_Stu6Test3Score.Location = New System.Drawing.Point(391, 288)
        Me.tx_Stu6Test3Score.Name = "tx_Stu6Test3Score"
        Me.tx_Stu6Test3Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu6Test3Score.TabIndex = 34
        Me.tx_Stu6Test3Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu6Test2Score
        '
        Me.tx_Stu6Test2Score.Location = New System.Drawing.Point(329, 288)
        Me.tx_Stu6Test2Score.Name = "tx_Stu6Test2Score"
        Me.tx_Stu6Test2Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu6Test2Score.TabIndex = 33
        Me.tx_Stu6Test2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu6Test1Score
        '
        Me.tx_Stu6Test1Score.Location = New System.Drawing.Point(267, 288)
        Me.tx_Stu6Test1Score.Name = "tx_Stu6Test1Score"
        Me.tx_Stu6Test1Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu6Test1Score.TabIndex = 32
        Me.tx_Stu6Test1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu5Test5Score
        '
        Me.tx_Stu5Test5Score.Location = New System.Drawing.Point(515, 245)
        Me.tx_Stu5Test5Score.Name = "tx_Stu5Test5Score"
        Me.tx_Stu5Test5Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu5Test5Score.TabIndex = 30
        Me.tx_Stu5Test5Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu5Test4Score
        '
        Me.tx_Stu5Test4Score.Location = New System.Drawing.Point(453, 245)
        Me.tx_Stu5Test4Score.Name = "tx_Stu5Test4Score"
        Me.tx_Stu5Test4Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu5Test4Score.TabIndex = 29
        Me.tx_Stu5Test4Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu5Test3Score
        '
        Me.tx_Stu5Test3Score.Location = New System.Drawing.Point(391, 245)
        Me.tx_Stu5Test3Score.Name = "tx_Stu5Test3Score"
        Me.tx_Stu5Test3Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu5Test3Score.TabIndex = 28
        Me.tx_Stu5Test3Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu5Test2Score
        '
        Me.tx_Stu5Test2Score.Location = New System.Drawing.Point(329, 245)
        Me.tx_Stu5Test2Score.Name = "tx_Stu5Test2Score"
        Me.tx_Stu5Test2Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu5Test2Score.TabIndex = 27
        Me.tx_Stu5Test2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu5Test1Score
        '
        Me.tx_Stu5Test1Score.Location = New System.Drawing.Point(267, 245)
        Me.tx_Stu5Test1Score.Name = "tx_Stu5Test1Score"
        Me.tx_Stu5Test1Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu5Test1Score.TabIndex = 26
        Me.tx_Stu5Test1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu4Test5Score
        '
        Me.tx_Stu4Test5Score.Location = New System.Drawing.Point(515, 202)
        Me.tx_Stu4Test5Score.Name = "tx_Stu4Test5Score"
        Me.tx_Stu4Test5Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu4Test5Score.TabIndex = 24
        Me.tx_Stu4Test5Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu4Test4Score
        '
        Me.tx_Stu4Test4Score.Location = New System.Drawing.Point(453, 202)
        Me.tx_Stu4Test4Score.Name = "tx_Stu4Test4Score"
        Me.tx_Stu4Test4Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu4Test4Score.TabIndex = 23
        Me.tx_Stu4Test4Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu4Test3Score
        '
        Me.tx_Stu4Test3Score.Location = New System.Drawing.Point(391, 202)
        Me.tx_Stu4Test3Score.Name = "tx_Stu4Test3Score"
        Me.tx_Stu4Test3Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu4Test3Score.TabIndex = 22
        Me.tx_Stu4Test3Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu4Test2Score
        '
        Me.tx_Stu4Test2Score.Location = New System.Drawing.Point(329, 202)
        Me.tx_Stu4Test2Score.Name = "tx_Stu4Test2Score"
        Me.tx_Stu4Test2Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu4Test2Score.TabIndex = 21
        Me.tx_Stu4Test2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu4Test1Score
        '
        Me.tx_Stu4Test1Score.Location = New System.Drawing.Point(267, 202)
        Me.tx_Stu4Test1Score.Name = "tx_Stu4Test1Score"
        Me.tx_Stu4Test1Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu4Test1Score.TabIndex = 20
        Me.tx_Stu4Test1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu3Test5Score
        '
        Me.tx_Stu3Test5Score.Location = New System.Drawing.Point(515, 159)
        Me.tx_Stu3Test5Score.Name = "tx_Stu3Test5Score"
        Me.tx_Stu3Test5Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu3Test5Score.TabIndex = 18
        Me.tx_Stu3Test5Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu3Test4Score
        '
        Me.tx_Stu3Test4Score.Location = New System.Drawing.Point(453, 159)
        Me.tx_Stu3Test4Score.Name = "tx_Stu3Test4Score"
        Me.tx_Stu3Test4Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu3Test4Score.TabIndex = 17
        Me.tx_Stu3Test4Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu3Test3Score
        '
        Me.tx_Stu3Test3Score.Location = New System.Drawing.Point(391, 159)
        Me.tx_Stu3Test3Score.Name = "tx_Stu3Test3Score"
        Me.tx_Stu3Test3Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu3Test3Score.TabIndex = 16
        Me.tx_Stu3Test3Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu3Test2Score
        '
        Me.tx_Stu3Test2Score.Location = New System.Drawing.Point(329, 159)
        Me.tx_Stu3Test2Score.Name = "tx_Stu3Test2Score"
        Me.tx_Stu3Test2Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu3Test2Score.TabIndex = 15
        Me.tx_Stu3Test2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu3Test1Score
        '
        Me.tx_Stu3Test1Score.Location = New System.Drawing.Point(267, 159)
        Me.tx_Stu3Test1Score.Name = "tx_Stu3Test1Score"
        Me.tx_Stu3Test1Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu3Test1Score.TabIndex = 14
        Me.tx_Stu3Test1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu2Test5Score
        '
        Me.tx_Stu2Test5Score.Location = New System.Drawing.Point(515, 116)
        Me.tx_Stu2Test5Score.Name = "tx_Stu2Test5Score"
        Me.tx_Stu2Test5Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu2Test5Score.TabIndex = 12
        Me.tx_Stu2Test5Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu2Test4Score
        '
        Me.tx_Stu2Test4Score.Location = New System.Drawing.Point(453, 116)
        Me.tx_Stu2Test4Score.Name = "tx_Stu2Test4Score"
        Me.tx_Stu2Test4Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu2Test4Score.TabIndex = 11
        Me.tx_Stu2Test4Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu2Test3Score
        '
        Me.tx_Stu2Test3Score.Location = New System.Drawing.Point(391, 116)
        Me.tx_Stu2Test3Score.Name = "tx_Stu2Test3Score"
        Me.tx_Stu2Test3Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu2Test3Score.TabIndex = 10
        Me.tx_Stu2Test3Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu2Test2Score
        '
        Me.tx_Stu2Test2Score.Location = New System.Drawing.Point(329, 116)
        Me.tx_Stu2Test2Score.Name = "tx_Stu2Test2Score"
        Me.tx_Stu2Test2Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu2Test2Score.TabIndex = 9
        Me.tx_Stu2Test2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu2Test1Score
        '
        Me.tx_Stu2Test1Score.Location = New System.Drawing.Point(267, 116)
        Me.tx_Stu2Test1Score.Name = "tx_Stu2Test1Score"
        Me.tx_Stu2Test1Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu2Test1Score.TabIndex = 8
        Me.tx_Stu2Test1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu6Name
        '
        Me.tx_Stu6Name.Location = New System.Drawing.Point(25, 288)
        Me.tx_Stu6Name.Name = "tx_Stu6Name"
        Me.tx_Stu6Name.Size = New System.Drawing.Size(191, 29)
        Me.tx_Stu6Name.TabIndex = 31
        '
        'tx_Stu5Name
        '
        Me.tx_Stu5Name.Location = New System.Drawing.Point(25, 245)
        Me.tx_Stu5Name.Name = "tx_Stu5Name"
        Me.tx_Stu5Name.Size = New System.Drawing.Size(191, 29)
        Me.tx_Stu5Name.TabIndex = 25
        '
        'tx_Stu4Name
        '
        Me.tx_Stu4Name.Location = New System.Drawing.Point(25, 202)
        Me.tx_Stu4Name.Name = "tx_Stu4Name"
        Me.tx_Stu4Name.Size = New System.Drawing.Size(191, 29)
        Me.tx_Stu4Name.TabIndex = 19
        '
        'tx_Stu3Name
        '
        Me.tx_Stu3Name.Location = New System.Drawing.Point(25, 159)
        Me.tx_Stu3Name.Name = "tx_Stu3Name"
        Me.tx_Stu3Name.Size = New System.Drawing.Size(191, 29)
        Me.tx_Stu3Name.TabIndex = 13
        '
        'tx_Stu2Name
        '
        Me.tx_Stu2Name.Location = New System.Drawing.Point(25, 116)
        Me.tx_Stu2Name.Name = "tx_Stu2Name"
        Me.tx_Stu2Name.Size = New System.Drawing.Size(191, 29)
        Me.tx_Stu2Name.TabIndex = 7
        '
        'tx_Stu1Test5Score
        '
        Me.tx_Stu1Test5Score.Location = New System.Drawing.Point(515, 73)
        Me.tx_Stu1Test5Score.Name = "tx_Stu1Test5Score"
        Me.tx_Stu1Test5Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu1Test5Score.TabIndex = 6
        Me.tx_Stu1Test5Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu1Test4Score
        '
        Me.tx_Stu1Test4Score.Location = New System.Drawing.Point(453, 73)
        Me.tx_Stu1Test4Score.Name = "tx_Stu1Test4Score"
        Me.tx_Stu1Test4Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu1Test4Score.TabIndex = 5
        Me.tx_Stu1Test4Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu1Test3Score
        '
        Me.tx_Stu1Test3Score.Location = New System.Drawing.Point(391, 73)
        Me.tx_Stu1Test3Score.Name = "tx_Stu1Test3Score"
        Me.tx_Stu1Test3Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu1Test3Score.TabIndex = 4
        Me.tx_Stu1Test3Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu1Test2Score
        '
        Me.tx_Stu1Test2Score.Location = New System.Drawing.Point(329, 73)
        Me.tx_Stu1Test2Score.Name = "tx_Stu1Test2Score"
        Me.tx_Stu1Test2Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu1Test2Score.TabIndex = 3
        Me.tx_Stu1Test2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu1Test1Score
        '
        Me.tx_Stu1Test1Score.Location = New System.Drawing.Point(267, 73)
        Me.tx_Stu1Test1Score.Name = "tx_Stu1Test1Score"
        Me.tx_Stu1Test1Score.Size = New System.Drawing.Size(45, 29)
        Me.tx_Stu1Test1Score.TabIndex = 2
        Me.tx_Stu1Test1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Stu1Name
        '
        Me.tx_Stu1Name.Location = New System.Drawing.Point(25, 73)
        Me.tx_Stu1Name.Name = "tx_Stu1Name"
        Me.tx_Stu1Name.Size = New System.Drawing.Size(191, 29)
        Me.tx_Stu1Name.TabIndex = 1
        '
        'lbl_TestScores
        '
        Me.lbl_TestScores.Location = New System.Drawing.Point(267, 38)
        Me.lbl_TestScores.Name = "lbl_TestScores"
        Me.lbl_TestScores.Size = New System.Drawing.Size(293, 29)
        Me.lbl_TestScores.TabIndex = 1
        Me.lbl_TestScores.Text = "Test Scores"
        Me.lbl_TestScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Name
        '
        Me.lbl_Name.Location = New System.Drawing.Point(25, 38)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(191, 29)
        Me.lbl_Name.TabIndex = 0
        Me.lbl_Name.Text = "Name"
        Me.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_CalcAverage
        '
        Me.btn_CalcAverage.Location = New System.Drawing.Point(621, 385)
        Me.btn_CalcAverage.Name = "btn_CalcAverage"
        Me.btn_CalcAverage.Size = New System.Drawing.Size(113, 54)
        Me.btn_CalcAverage.TabIndex = 2
        Me.btn_CalcAverage.Text = "Calculate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Averages"
        Me.btn_CalcAverage.UseVisualStyleBackColor = True
        '
        'pdPrint
        '
        '
        'pddPrintDialog
        '
        Me.pddPrintDialog.UseEXDialog = True
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.DefaultExt = "sgv"
        Me.ofdOpenFile.Filter = "Student Grade File (*.SGV)|*.sgv"
        '
        'sfdSaveDialog
        '
        Me.sfdSaveDialog.Filter = "Student Grade File (*.SGV)|*.sgv"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 450)
        Me.Controls.Add(Me.btn_CalcAverage)
        Me.Controls.Add(Me.gb_StudentData)
        Me.Controls.Add(Me.mnu_Main)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.mnu_Main
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Student Text Scores"
        Me.mnu_Main.ResumeLayout(False)
        Me.mnu_Main.PerformLayout()
        Me.gb_StudentData.ResumeLayout(False)
        Me.gb_StudentData.PerformLayout()
        Me.pnl_Averages.ResumeLayout(False)
        Me.pnl_Averages.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnu_Main As MenuStrip
    Friend WithEvents mnu_MainFile As ToolStripMenuItem
    Friend WithEvents mnu_MainFileOpen As ToolStripMenuItem
    Friend WithEvents mnu_MainFileSave As ToolStripMenuItem
    Friend WithEvents mnu_MainFileExit As ToolStripMenuItem
    Friend WithEvents mnu_MainReport As ToolStripMenuItem
    Friend WithEvents mnu_MainReportPrint As ToolStripMenuItem
    Friend WithEvents mnu_MainHelp As ToolStripMenuItem
    Friend WithEvents mnu_MainHelpAbout As ToolStripMenuItem
    Friend WithEvents gb_StudentData As GroupBox
    Friend WithEvents tx_Stu6Avg As TextBox
    Friend WithEvents tx_Stu6Test5Score As TextBox
    Friend WithEvents tx_Stu6Test4Score As TextBox
    Friend WithEvents tx_Stu6Test3Score As TextBox
    Friend WithEvents tx_Stu6Test2Score As TextBox
    Friend WithEvents tx_Stu6Test1Score As TextBox
    Friend WithEvents tx_Stu5Avg As TextBox
    Friend WithEvents tx_Stu5Test5Score As TextBox
    Friend WithEvents tx_Stu5Test4Score As TextBox
    Friend WithEvents tx_Stu5Test3Score As TextBox
    Friend WithEvents tx_Stu5Test2Score As TextBox
    Friend WithEvents tx_Stu5Test1Score As TextBox
    Friend WithEvents tx_Stu4Avg As TextBox
    Friend WithEvents tx_Stu4Test5Score As TextBox
    Friend WithEvents tx_Stu4Test4Score As TextBox
    Friend WithEvents tx_Stu4Test3Score As TextBox
    Friend WithEvents tx_Stu4Test2Score As TextBox
    Friend WithEvents tx_Stu4Test1Score As TextBox
    Friend WithEvents tx_Stu3Avg As TextBox
    Friend WithEvents tx_Stu3Test5Score As TextBox
    Friend WithEvents tx_Stu3Test4Score As TextBox
    Friend WithEvents tx_Stu3Test3Score As TextBox
    Friend WithEvents tx_Stu3Test2Score As TextBox
    Friend WithEvents tx_Stu3Test1Score As TextBox
    Friend WithEvents tx_Stu2Avg As TextBox
    Friend WithEvents tx_Stu2Test5Score As TextBox
    Friend WithEvents tx_Stu2Test4Score As TextBox
    Friend WithEvents tx_Stu2Test3Score As TextBox
    Friend WithEvents tx_Stu2Test2Score As TextBox
    Friend WithEvents tx_Stu2Test1Score As TextBox
    Friend WithEvents tx_Stu6Name As TextBox
    Friend WithEvents tx_Stu5Name As TextBox
    Friend WithEvents tx_Stu4Name As TextBox
    Friend WithEvents tx_Stu3Name As TextBox
    Friend WithEvents tx_Stu2Name As TextBox
    Friend WithEvents tx_Stu1Avg As TextBox
    Friend WithEvents tx_Stu1Test5Score As TextBox
    Friend WithEvents tx_Stu1Test4Score As TextBox
    Friend WithEvents tx_Stu1Test3Score As TextBox
    Friend WithEvents tx_Stu1Test2Score As TextBox
    Friend WithEvents tx_Stu1Test1Score As TextBox
    Friend WithEvents tx_Stu1Name As TextBox
    Friend WithEvents lbl_Average As Label
    Friend WithEvents lbl_TestScores As Label
    Friend WithEvents lbl_Name As Label
    Friend WithEvents btn_CalcAverage As Button
    Friend WithEvents pnl_Averages As Panel
    Friend WithEvents mnu_MainFileClear As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents pdPrint As Printing.PrintDocument
    Friend WithEvents pddPrintDialog As PrintDialog
    Friend WithEvents ofdOpenFile As OpenFileDialog
    Friend WithEvents sfdSaveDialog As SaveFileDialog
    Friend WithEvents mnu_FileSaveAs As ToolStripMenuItem
End Class
