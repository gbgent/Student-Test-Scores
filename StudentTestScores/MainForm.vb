Imports System.IO

Public Class MainForm

    'Class Variables and Constants
    Private Const int_NUMBER_TESTS As Integer = 5           'Number of Tests for Class
    Private Const int_NUMBER_STUDENTS As Integer = 6        'Number of Students in Class
    Private Const dbl_LOW_TEST_SCORE As Double = 0.0        'Lowest Possible Test Score
    Private Const dbl_HIGH_TEST_SCORE As Double = 100.0     'Highest Possible Test Score
    Private Const str_SEPERATOR As String = ","
    Private ItemsChanged As Boolean = False

    'Student Structure to hold Name Test Scores and Average
    Structure StudentGrades
        Dim str_Name As String
        Dim TestScores() As Double
        Dim dec_Average As Double
    End Structure

    'Array of Students
    Private Students() As StudentGrades

    'Define File Name
    Dim str_fileName As String

    'Load Event Procedure
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Redimension the number of Students
        ReDim Students(int_NUMBER_STUDENTS - 1)

        'Redimension Tests Scores for each Student
        For x As Integer = 0 To int_NUMBER_STUDENTS - 1
            ReDim Students(x).TestScores(int_NUMBER_TESTS - 1)
        Next

        'Set Open File Dialog and Save File Dialog Initial Directory to the App's Directory
        ofdOpenFile.InitialDirectory = Application.StartupPath
        sfdSaveDialog.InitialDirectory = Application.StartupPath

    End Sub

    '*****************************
    ' Menu Item Routines
    '*****************************

    ' File - Clear
    Private Sub mnu_MainFileClear_Click(sender As Object, e As EventArgs) Handles mnu_MainFileClear.Click

        'See if Items are Changed
        If ItemsChanged Then
            'Verify Action
            If VerifyActionItemsChanged() Then
                'Proceed to clear form
                ClearForm()
            End If
        Else
            'Clear the form
            ClearForm()

        End If
    End Sub

    ' File - Open
    Private Sub mnu_MainFileOpen_Click(sender As Object, e As EventArgs) Handles mnu_MainFileOpen.Click

        'Check to see if Form has been Changed
        If ItemsChanged Then
            If VerifyActionItemsChanged() Then
                'Get File Name to Open
                If ofdOpenFile.ShowDialog() = DialogResult.OK Then
                    str_fileName = ofdOpenFile.FileName
                    'Call to open file and load data
                    LoadData()
                End If
            End If
        Else
            'Get File Name to Open
            If ofdOpenFile.ShowDialog() = DialogResult.OK Then
                str_fileName = ofdOpenFile.FileName
                'Call to open file and load data 
                LoadData()
            End If
        End If
    End Sub

    ' File - Save
    Private Sub mnu_MainFileSave_Click(sender As Object, e As EventArgs) Handles mnu_MainFileSave.Click
        'Check to see if Data has been Saved before
        If str_fileName = String.Empty Then
            'Data has not been saved, use save dialog to save data
            If sfdSaveDialog.ShowDialog = DialogResult.OK Then
                str_fileName = sfdSaveDialog.FileName
                SaveData()
            End If
        Else
            SaveData()
        End If
    End Sub

    ' File - SaveAs
    Private Sub mnu_FileSaveAs_Click(sender As Object, e As EventArgs) Handles mnu_FileSaveAs.Click
        'Save the current document under a new file name
        If sfdSaveDialog.ShowDialog = DialogResult.OK Then
            str_fileName = sfdSaveDialog.FileName
            SaveData()
        End If
    End Sub

    ' File - Exit
    Private Sub mnu_MainFileExit_Click(sender As Object, e As EventArgs) Handles mnu_MainFileExit.Click

        If ItemsChanged Then
            If VerifyActionItemsChanged() Then
                'Close this Form
                Me.Close()
            End If
        Else
            'Close this form
            Me.Close()
        End If
    End Sub

    ' Report - Print
    Private Sub mnu_MainReportPrint_Click(sender As Object, e As EventArgs) Handles mnu_MainReportPrint.Click
        'Call the Print Dialog Control to get the printer information
        If pddPrintDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then

            'Get the Printer Settings
            pdPrint.PrinterSettings = pddPrintDialog.PrinterSettings

            'Print the page
            pdPrint.Print()
        End If
    End Sub

    ' Help - About
    Private Sub mnu_MainHelpAbout_Click(sender As Object, e As EventArgs) Handles mnu_MainHelpAbout.Click
        Dim msg As String

        msg = String.Format("Test Scores" & vbCrLf &
                            "Version : 1.00" & vbCrLf &
                            "Author : Gerald Glass" & vbCrLf &
                            "Date : 03/02/2019")

        MessageBox.Show(msg, "About")
    End Sub



    '***********************************
    ' Form Controls Procedures
    '***********************************

    ' Procedure when Leaving Student Name Text Box
    Private Sub tx_StudentName_Leave(sender As Object, e As EventArgs) Handles tx_Stu1Name.Leave, tx_Stu2Name.Leave,
                                                                tx_Stu3Name.Leave, tx_Stu4Name.Leave, tx_Stu5Name.Leave, tx_Stu6Name.Leave

        'Set a local variable to represent the textbox sending
        Dim txtbox As TextBox = DirectCast(sender, TextBox)

        'Check to see if the Textbox Value has changed
        If txtbox.Modified Then
            'Declare local variable to hold the Text Box Number
            Dim x As Integer = CInt(txtbox.Name.Substring(6, 1))
            'Assign TextBox Value to Student Name
            Students(x - 1).str_Name = txtbox.Text
            'Set Items Change Flag to True
            ItemsChanged = True
        End If
    End Sub

    ' Procedure when Leaving a Text Score Text Box
    Private Sub tx_StudentTestScore_Leave(sender As Object, e As EventArgs) Handles tx_Stu1Test1Score.Leave, tx_Stu1Test2Score.Leave,
                                                                         tx_Stu1Test3Score.Leave, tx_Stu1Test4Score.Leave, tx_Stu1Test5Score.Leave,
                                                                         tx_Stu2Test1Score.Leave, tx_Stu2Test2Score.Leave, tx_Stu2Test3Score.Leave,
                                                                         tx_Stu2Test4Score.Leave, tx_Stu2Test5Score.Leave, tx_Stu3Test1Score.Leave,
                                                                         tx_Stu3Test2Score.Leave, tx_Stu3Test3Score.Leave, tx_Stu3Test4Score.Leave,
                                                                         tx_Stu3Test5Score.Leave, tx_Stu4Test1Score.Leave, tx_Stu4Test2Score.Leave,
                                                                         tx_Stu4Test3Score.Leave, tx_Stu4Test4Score.Leave, tx_Stu4Test5Score.Leave,
                                                                         tx_Stu5Test1Score.Leave, tx_Stu5Test2Score.Leave, tx_Stu5Test3Score.Leave,
                                                                         tx_Stu5Test4Score.Leave, tx_Stu5Test5Score.Leave, tx_Stu6Test1Score.Leave,
                                                                         tx_Stu6Test2Score.Leave, tx_Stu6Test3Score.Leave, tx_Stu6Test4Score.Leave,
                                                                         tx_Stu6Test5Score.Leave

        'Set a local variable to represent the textbox sending
        Dim txtbox As TextBox = DirectCast(sender, TextBox)
        Dim StuNum As Integer = CInt(txtbox.Name.Substring(6, 1))
        Dim TestNum As Integer = CInt(txtbox.Name.Substring(11, 1))

        If txtbox.Modified Then
            ' Set Items Change Flag to True
            ItemsChanged = True
            'Convert Score to a Double 
            Try
                Dim score As Double = CDbl(txtbox.Text)
                'Check that score is between 0 and 100
                If score >= dbl_LOW_TEST_SCORE And score <= dbl_HIGH_TEST_SCORE Then
                    Students(StuNum - 1).TestScores(TestNum - 1) = score
                Else
                    ' Display Error Message
                    MessageBox.Show("Test Score must be between 0 and 100.", "Out of Range Error")
                    txtbox.Clear()
                    txtbox.Focus()
                End If
            Catch ex As Exception
                'Display Non Number Error
                MessageBox.Show("Test Score must be a Number between 0 and 100", "Invalid Entry Error")
                txtbox.Clear()
                txtbox.Focus()
            End Try
        End If
    End Sub

    ' Procedure for Calculate Average Button
    Private Sub btn_CalAverage_Click(sender As Object, e As EventArgs) Handles btn_CalcAverage.Click

        'Find the text boxes in the Panel and determine which student to use
        For Each ctl As Object In pnl_Averages.Controls
            ' Check to see if ctl is of type textbox
            If TypeOf (ctl) Is TextBox Then
                ' if ctl is a Textbox assign it to txbox.
                Dim txbox As TextBox = CType(ctl, TextBox)

                'Get the Student Number
                Dim x As Integer = CInt(txbox.Name.Substring(6, 1))
                Dim avg As Double = 0

                ' Check to see if Row has a Student Name
                ' If name is null or empty then next row
                If String.IsNullOrEmpty(Students(x - 1).str_Name) Then
                    Continue For
                Else
                    For y As Integer = 0 To int_NUMBER_TESTS - 1
                        avg += Students(x - 1).TestScores(y)
                    Next
                    Students(x - 1).dec_Average = avg / int_NUMBER_TESTS
                    txbox.Text = Students(x - 1).dec_Average.ToString("n")
                    'Set Items Change Flag to True
                    ItemsChanged = True
                End If

            End If
        Next
    End Sub

    '**************************************
    ' Procedures Called by Menu and Controls Procedures
    '***************************************

    ' Verify Continue if Form Items have Changed
    Private Function VerifyActionItemsChanged() As Boolean
        'Display Warning Message
        Dim Result As DialogResult = MessageBox.Show("You have made changes." & vbCrLf &
                                                     "Continue without Saving?", "Warning",
                                                     MessageBoxButtons.YesNo)
        'Return Button Result
        If Result = DialogResult.Yes Then
            Return True
        Else
            Return False
        End If

    End Function

    ' Procedure to Clear all Text Boxes on Form
    Private Sub ClearForm()
        'Get Each Control in Group Box Sudent Data
        For Each ctl As Object In gb_StudentData.Controls
            ' If control is a Textbox, set text to empty
            If TypeOf (ctl) Is TextBox Then
                Dim txbox As TextBox = CType(ctl, TextBox)
                txbox.Text = String.Empty
            End If
        Next
        'Get Each Control in Panel Averages
        For Each ctl As Object In pnl_Averages.Controls
            ' If control is a Textbox, set text to empty
            If TypeOf (ctl) Is TextBox Then
                Dim txbox As TextBox = CType(ctl, TextBox)
                txbox.Text = String.Empty
            End If

        Next
        'Clear Student Information
        ClearStudents()
        'Set focus to student 1 Name
        tx_Stu1Name.Focus()
        ' Set Items Changed Flag to False
        ItemsChanged = False
    End Sub

    'Clear Student Information
    Private Sub ClearStudents()
        Dim x, y As Integer

        For x = 0 To int_NUMBER_STUDENTS - 1
            Students(x).str_Name = String.Empty
            For y = 0 To int_NUMBER_TESTS - 1
                Students(x).TestScores(y) = 0
            Next
        Next
    End Sub

    'Procedure that Creates the Printed Page
    Private Sub pdPrint_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdPrint.PrintPage
        'Create Header Font
        Dim headerFont As New Drawing.Font("Courier New", 16, FontStyle.Bold)
        Dim colHeaderFont As New Drawing.Font("Courier New", 12, FontStyle.Bold)
        Dim bodyFont As New Drawing.Font("Courier New", 12, FontStyle.Regular)
        Dim x As Integer
        Dim vertLocation As Integer = 76

        'Print the Header
        e.Graphics.DrawString("Advanced Visual Basic", headerFont, Brushes.Black, 238, 36)
        e.Graphics.DrawString("Student Grades", headerFont, Brushes.Black, 294, 56)

        'Print Column Headings
        vertLocation += (14 * 3)
        Dim columnHeaders As String = String.Format("{0,10}{1,32}{2,22}", "Name", "Test Scores", "Average")
        e.Graphics.DrawString(columnHeaders, colHeaderFont, Brushes.Black, 36, vertLocation)

        'Print Report Body
        Dim bodyLine As String



        For x = 0 To int_NUMBER_STUDENTS - 1
            vertLocation += 14  'Font size + 2

            bodyLine = String.Format("{0, -20} {1,5} {2,5} {3,5} {4,5} {5,5}   {6,8}",
                                     Students(x).str_Name, Students(x).TestScores(0), Students(x).TestScores(1),
                                     Students(x).TestScores(2), Students(x).TestScores(3),
                                     Students(x).TestScores(4), Students(x).dec_Average)

            e.Graphics.DrawString(bodyLine, bodyFont, Brushes.Black, 36, vertLocation)
        Next

    End Sub

    ' Procedure that Loads the Data
    Private Sub LoadData()
        Dim counter As Integer = 0

        Try
            'open the file
            Dim inputFile As StreamReader
            inputFile = File.OpenText(str_fileName)

            'Clear the Student List
            ClearForm()

            'create buffer object to hold each line
            Dim str_Buffer As String
            str_Buffer = inputFile.ReadLine  ' Priming read

            'Repeat these steps until end of file or counter = one more than number of tests
            Do Until counter = int_NUMBER_STUDENTS

                'Parse Line into Data structure
                Dim ind_counter As Integer = 0
                Dim ind_start As Integer = 0
                Dim length As Integer = 0

                'Find the first comma
                ind_counter = str_Buffer.IndexOf(str_SEPERATOR)
                'Determine Length of Name
                length = ind_counter - ind_start
                'Assign String to Name
                Students(counter).str_Name = str_Buffer.Substring(ind_start, length)
                'Set Index Starting position to 1 more then Seperator Location
                ind_start = ind_counter + 1

                'Load Test Scores
                For y As Integer = 0 To int_NUMBER_TESTS - 1
                    ind_counter = str_Buffer.IndexOf(str_SEPERATOR, ind_start)
                    If ind_counter > 0 Then
                        length = ind_counter - ind_start
                        Students(counter).TestScores(y) = CInt(str_Buffer.Substring(ind_start, length))
                        ind_start = ind_counter + 1
                    Else
                        Students(counter).TestScores(y) = CInt(str_Buffer.Substring(ind_start))
                    End If

                Next
                counter += 1
                str_Buffer = inputFile.ReadLine
            Loop
            'Close input file
            inputFile.Close()

            'Display Data
            DisplayData()

            'Set Change Flag to false
            ItemsChanged = False

        Catch ex As Exception
            'File Not Found Error
            MessageBox.Show("File could not be opened.", "Error")

        End Try
    End Sub

    'Procedure to Display Data
    Private Sub DisplayData()
        Dim txtbox As TextBox
        Dim stunum As Integer
        Dim testnum As Integer

        For Each ctl As Object In gb_StudentData.Controls

            'Verify if Object is a text box
            If TypeOf ctl Is TextBox Then
                'assign control object to a textbox variable
                txtbox = DirectCast(ctl, TextBox)
                'Get the student's number (at 7th position)
                stunum = CInt(txtbox.Name.Substring(6, 1)) - 1

                'Check to see Textbox is Less than or equal to 11 (Name or Average Text Box)
                'Average is not stored so it will require new calculation
                If txtbox.Name.Length <= 11 Then
                    'check to see if last part of textbox name is "Name"
                    If txtbox.Name.Substring(7) = "Name" Then

                        ' Assign Student's Name to Textbox Text Value
                        txtbox.Text = Students(stunum).str_Name
                    End If
                Else
                    'Determine which test score belongs in the textbox
                    testnum = CInt(txtbox.Name.Substring(11, 1)) - 1
                    'Assign test score to textbox
                    txtbox.Text = Students(stunum).TestScores(testnum).ToString()
                End If
            End If
        Next
    End Sub

    'Procedure to Save Data
    Private Sub SaveData()
        'Declare the output File
        Dim outPutFile As StreamWriter
        Dim outputline As String

        Try
            'Create the File/overwrite
            outPutFile = File.CreateText(str_fileName)

            For x As Integer = 0 To int_NUMBER_STUDENTS - 1
                outputline = Students(x).str_Name
                For y As Integer = 0 To int_NUMBER_TESTS - 1
                    outputline = outputline & "," &
                                 Students(x).TestScores(y).ToString
                Next
                outPutFile.WriteLine(outputline)
            Next
            outPutFile.Close()
            ItemsChanged = False

        Catch ex As Exception
            'Error Message could not open file
            MessageBox.Show("Error Creating File", "Error")
        End Try

    End Sub
End Class
