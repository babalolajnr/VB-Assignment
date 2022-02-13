Imports System.Net.Mail
Imports System.Text.RegularExpressions


'Name: Babalola Abdulqudduus Luqmaan
'Matric Number: 15/30GM031
Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim firstName As String
        Dim surname As String
        Dim otherName As String
        Dim department As String
        Dim status As String
        Dim gender As String
        Dim email As MailAddress
        Dim phone As String
        Dim homeAddr As String
        Dim nextOfKin As String
        Dim relationshipNextOfKin As String
        Dim dateOfBirth As Date

        firstName = txtFirstName.Text
        surname = txtSurname.Text
        otherName = txtOtherName.Text
        department = cmbDepartment.Text
        status = cmbStatus.Text
        gender = cmbGender.Text
        phone = txtPhone.Text
        homeAddr = txtHomeAddr.Text
        nextOfKin = txtNOK.Text
        relationshipNextOfKin = txtRelationshipNOK.Text
        dateOfBirth = dtpDOB.Text

        Dim payload() As String

        payload = {firstName, surname, otherName, department, status, gender,
             homeAddr, nextOfKin, relationshipNextOfKin, dateOfBirth}

        'Check if any of the fields are empty
        For Each entity As String In payload
            If entity = "" Then
                MessageBox.Show("Some Fields are empty")
                Exit Sub
            End If
        Next

        Try
            email = New MailAddress(txtEmail.Text)
        Catch ex As Exception
            MessageBox.Show("Invalid Email Address")
        End Try

        'Check if phone number contains letters
        If Regex.IsMatch(phone, "[a-zA-Z]") Then
            MessageBox.Show("Phone number contains illegal characters")
        ElseIf phone.Length < 11 Then
            'Check if phone number is less than 11 digits
            MessageBox.Show("Phone Number is less than 11 digits")
        ElseIf phone.Length > 11 Then
            'Check if phone number is more than 11 digits
            MessageBox.Show("Phone Number is more than 11 digits")
        End If

        'Calculate age
        Dim age As TimeSpan = Now.Subtract(dateOfBirth)
        Dim ageInyears = age.TotalDays / 365
        txtAge.Text = Math.Floor(ageInyears)

    End Sub
End Class
