Option Strict On
Option Explicit On
Option Infer Off

Public Class frm_departments
    'record structures and other variables
    Private Structure DepartmentRec
        Public Name As String
        Public NumStudents As Integer
        Public Average As Double
        Public Rating As Integer
    End Structure
    Private Structure ModuleRec
        Public ModuleCode As String
        Public sizeupload() As Double       'nW
        Public Total As Double
    End Structure
    Private Departments() As DepartmentRec  'nD
    Private Modules() As ModuleRec          'nM
    Private nD, nM, nW As Integer

    'subroutines and functions 

    Private Sub PT(ByVal r As Integer, ByVal c As Integer, ByVal t As String)
        grd_departments.Row = r
        grd_departments.Col = c
        grd_departments.Text = t
    End Sub



    Private Sub Setup()
        'input from user
        nD = CInt(InputBox("Enter Number of Departments"))
        nM = CInt(InputBox("Enter the number of Modules"))
        nW = CInt(InputBox("Enter the number of weeks"))

        'resize arrays
        ReDim Departments(nD)
        For d As Integer = 1 To nD
            ReDim Modules(nM)
        Next
        For i As Integer = 1 To nM
            ReDim Modules(i).sizeupload(nW)
        Next
        'resize uj grid
        grd_departments.Rows = nD + 1
        grd_departments.Cols = nM + 1 + 2

        'label uj grid
        For d As Integer = 1 To nD
            PT(d, 0, "Department #" & CStr(d))
        Next
        For m As Integer = 1 To nM
            PT(0, m, "Module #" & CStr(m))
        Next

        PT(0, nM + 1, "Average")
        PT(0, nM + 2, "Rating")

    End Sub

    Private Function ConvertG(ByVal size As Double) As Double

        Return size / 1000
    End Function

    Private Function CalcAve(ByVal total As Double, ByVal num As Integer) As Double
        Return total / num
    End Function
    Private Function DetermineRating(ByVal rating As Double) As String
        Dim response As String
        If rating >= 0 And rating < 0.75 Then
            response = "1"
        Else
            If rating >= 0.75 And rating < 2.5 Then
                response = "2"
            Else
                If rating >= 2.5 Then
                    response = "3"
                End If
            End If
        End If
        Return response
    End Function

    'input from the user
    Private Sub btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click
        Setup()
        For d As Integer = 1 To nD
            Departments(d).Name = InputBox("Enter Name of the Department #" & CStr(d))
            Departments(d).NumStudents = CInt(InputBox("Enter number of students in the department #") & CStr(d))
            For m As Integer = 1 To nM
                Modules(m).Total = 0
                Modules(m).ModuleCode = InputBox("Enter Module code for module #" & CStr(m))
                For w As Integer = 1 To nW
                    Modules(m).sizeupload(w) = CDbl(InputBox("Enter Size of File upload for module #" & CStr(m) & "in week # " & CStr(w)))
                    Modules(m).Total = Modules(m).Total + Modules(m).sizeupload(w)

                Next w
                PT(d, m, CStr(Modules(m).Total))
            Next m
        Next d
    End Sub


    'Calculating average
    Private Sub btn_average_Click(sender As Object, e As EventArgs) Handles btn_average.Click
        Dim Total As Double
        For d As Integer = 1 To nD
            Total = 0
            For m As Integer = 1 To nM

                Total += Modules(m).Total
            Next m
            Departments(d).Average = CalcAve(Total, nM)
            'display
            PT(d, nM + 1, Format(Departments(d).Average, "0.0000"))
            Next d

    End Sub
    'rating and display
    Private Sub btn_Rating_Click(sender As Object, e As EventArgs) Handles btn_Rating.Click
        Dim Avg As Double = 0
        For d As Integer = 1 To nD
            Avg = ConvertG(Departments(d).Average)
            Departments(d).Rating = CInt(DetermineRating(Avg))
            PT(d, nM + 2, CStr(Departments(d).Rating))
        Next d

    End Sub
    'highest size upload module and the displays 
    Private Sub btn_highest_Click(sender As Object, e As EventArgs) Handles btn_highest.Click
        Dim max As Double
        For d As Integer = 1 To nD
            max = Departments(1).Average
            If Departments(d).Average >= max Then
                max = Departments(d).Average
                txt_name.Text = Departments(d).Name
                txt_rating.Text = CStr(Departments(d).Rating)
            End If
        Next d

    End Sub


End Class
