Public Class Form1
    Dim Ciphertext As String = ""
    Dim Plaintext As String = ""
    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        txt_input.Text = ""
        txt_output.Text = ""
        ComboBox_algo.Text = ""
        txt_Key.Visible = False
        lbl_key.Visible = False

    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub ComboBox_algo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_algo.SelectedIndexChanged

        If (ComboBox_algo.Text = "Caesar Cipher" Or ComboBox_algo.Text = "MonoAlphabetic Cipher") Then
            txt_Key.Visible = True
            lbl_key.Visible = True
        Else
            txt_Key.Visible = False
            lbl_key.Visible = False
        End If

    End Sub
    Private Function caesar(text As String, key As Integer, flag As Boolean)
        Dim Ciphertext As String = ""
        Dim Plaintext As String = ""
        Dim newascii As Integer = 0

        If (flag = True) Then

            For Each c As Char In text
                If Char.IsLetter(c) AndAlso Char.IsUpper(c) Then
                    newascii = Asc(c) + key

                    If (newascii > Asc("Z"c)) Then
                        newascii -= 26

                    End If
                    Ciphertext &= Chr(newascii)

                Else
                    Ciphertext &= c
                End If
            Next

            Return Ciphertext

        Else
            For Each c As Char In text
                If Char.IsLetter(c) AndAlso Char.IsUpper(c) Then
                    newascii = Asc(c) - key

                    If (newascii < Asc("A"c)) Then
                        newascii += 26

                    End If
                    Plaintext &= Chr(newascii)

                Else
                    Plaintext &= c
                End If
            Next

            Return Plaintext
        End If
    End Function
    Private Function GenerateKey_Mono(userInput As String) As String
        Dim Key As String = ""
        Dim check As New HashSet(Of Char)()

        For Each c As Char In userInput.ToUpper()
            If Char.IsLetter(c) AndAlso Not check.Contains(c) Then
                Key &= c
                check.Add(c)
            End If
        Next

        For Each c As Char In "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            If Not check.Contains(c) Then
                Key &= c
                check.Add(c)

            End If
        Next

        Return Key
    End Function

    Private Sub btn_Encrypt_Click(sender As Object, e As EventArgs) Handles btn_Encrypt.Click
        Ciphertext = ""
        Dim Input As String = txt_input.Text.ToUpper()
        Dim selectedValue As String
        selectedValue = ComboBox_algo.Text
        Dim flag As Boolean = True

        If (selectedValue = "Caesar Cipher") Then
            Dim Key As Integer = txt_Key.Text
            If (Key > 26) Then
                MessageBox.Show("Key maximum Value is 26")
            End If

            Ciphertext = caesar(Input, Key, flag)
                txt_output.Text = Ciphertext

            ElseIf (selectedValue = "MonoAlphabetic Cipher") Then
                Dim userInput As String = txt_Key.Text
            Dim Key As String = GenerateKey_Mono(userInput)

            For Each c In Input

                If Char.IsLetter(c) Then
                    Dim index As Integer = Asc(c) - Asc("A"c)
                    Ciphertext &= Key(index)
                Else
                    Ciphertext &= c
                End If
            Next
        End If

        txt_output.Text = Ciphertext
    End Sub

    Private Sub btn_Decrypt_Click(sender As Object, e As EventArgs) Handles btn_Decrypt.Click
        Plaintext = ""
        Dim Input As String = txt_input.Text.ToUpper()
        Dim selectedValue As String
        selectedValue = ComboBox_algo.Text
        Dim flag As Boolean = False

        If (selectedValue = "Caesar Cipher") Then
            Dim Key As Integer = txt_Key.Text
            If (Key > 26) Then
                MessageBox.Show("Key maximum Value is 26")
            End If

            Plaintext = caesar(Input, Key, flag)
            txt_output.Text = Plaintext

        ElseIf (selectedValue = "MonoAlphabetic Cipher") Then
            Dim userInput As String = txt_Key.Text
            Dim Key As String = GenerateKey_Mono(userInput)

            For Each c As Char In Input

                If Char.IsLetter(c) Then
                    Dim index As Integer = Key.IndexOf(c)
                    Plaintext &= Chr(Asc("A"c) + index)
                Else
                    Plaintext &= c
                End If
            Next
        End If

        txt_output.Text = Plaintext
    End Sub
End Class
