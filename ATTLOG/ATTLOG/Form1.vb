﻿Public Class Form1
    Private Sub BranchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BranchToolStripMenuItem.Click
        Branch.Show()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click
        Employee.Show()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeString
        Label2.Text = DateTime.Now.ToString("MMMM dd, yyyy")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            con.Open()

            If con.State = ConnectionState.Open Then
                MsgBox("Connected")
            Else
                MsgBox("Not Connected!")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            con.Open()
            If con.State = ConnectionState.Open Then
                Dim query = " select * from InfoWithTimeIn where externalID like '%" + TextBox1.Text + "%'"
                Dim strsql As New OleDb.OleDbCommand(query, con)
                Dim myreader As OleDb.OleDbDataReader = strsql.ExecuteReader
                While myreader.Read()

                    If (TextBox1.Text = "") Then
                        TextBox2.Text = ""
                        TextBox3.Text = ""
                        TextBox4.Text = ""

                    Else
                        TextBox2.Text = myreader("externalID")
                        TextBox3.Text = myreader("realName")
                        TextBox4.Text = myreader("branchName")
                    End If

                End While

            Else
                MsgBox("Not Connected!")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub
End Class
