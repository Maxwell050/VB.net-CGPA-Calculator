Public Class Form1


    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click, ComputeToolStripMenuItem.Click
        Try
            If NameTextBox.Text.Trim = String.Empty Then

                MessageBox.Show("Name and Program of Study is required", "Name Missing Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NameTextBox.Focus()
                NameTextBox.SelectAll()



            ElseIf ProgramTextBox.Text.Trim = String.Empty Then
                MessageBox.Show("Name and Program of Study is required", "Program of Study Missing Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ProgramTextBox.Focus()
                ProgramTextBox.SelectAll()

            Else

                Dim calculate As Decimal
                Dim creditHours As Decimal
                Dim gpa As Decimal
                calculate = ((CDbl(WebTextBox.Text) * CDbl(Web1.Text)) + (CDbl(DbmsTextBox.Text) * CDbl(Dbms1.Text)) + (CDbl(MobileAppTextBox.Text) * CDbl(MobileApp1.Text)) + (CDbl(NetworkingTextBox.Text) * CDbl(Networking1.Text)) + (CDbl(SoftwareTextBox.Text) * CDbl(Software1.Text)) + (CDbl(VbTextBox.Text) * CDbl(Vb1.Text)) + (CDbl(OperatingTextBox.Text) * CDbl(Operating1.Text)) + (CDbl(CriticalTextBox.Text) * CDbl(Critical1.Text)))
                creditHours = (CDbl(Web1.Text) + CDbl(Dbms1.Text) + CDbl(MobileApp1.Text) + CDbl(Networking1.Text) + CDbl(Software1.Text) + CDbl(Vb1.Text) + CDbl(Operating1.Text) + CDbl(Critical1.Text))
                gpa = Decimal.Round(calculate / creditHours, 2)



                MessageBox.Show(NameTextBox.Text + " offering " + ProgramTextBox.Text + " GPA is: " & gpa.ToString(), "GPA", MessageBoxButtons.OK, MessageBoxIcon.Information)





            End If





        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ControlChars.NewLine & ex.Message, "Compute Button Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem1.Click, ExitToolStripMenuItem.Click
        Dim MessageString As String = "Do you want to close the form?"
        Dim ButtonDialogResult As DialogResult = MessageBox.Show(MessageString, "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ButtonDialogResult = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click, ResetToolStripMenuItem.Click
        WebTextBox.Clear()
        DbmsTextBox.Clear()
        MobileAppTextBox.Clear()
        NetworkingTextBox.Clear()
        SoftwareTextBox.Clear()
        VbTextBox.Clear()
        OperatingTextBox.Clear()
        CriticalTextBox.Clear()
        NameTextBox.Clear()
        ProgramTextBox.Clear()
        Web1.Clear()
        Dbms1.Clear()
        MobileApp1.Clear()
        Networking1.Clear()
        Software1.Clear()
        Vb1.Clear()
        Operating1.Clear()
        Critical1.Clear()













    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click

    End Sub

    Private Sub ComputeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComputeToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class
