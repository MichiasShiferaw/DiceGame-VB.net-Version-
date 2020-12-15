'Import any necessary to perform the program
Imports System

Public Class DiceGame
    Private Sub DiceGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       'Declare nescarry variable 
        Dim roll As New Random()
        Dim randomNumber As Integer = roll.Next(6)
        Dim guess As Integer
        Dim counter As Integer
        'Add one so that the range no longer from 0-5 but is from 1 - 6 
        randomNumber += 1
        counter = 0

        ' Asks the user what the number is from an inputbox
        guess = InputBox("I got a number that you got to try and guess it is between 1 & 6. ")
       
        Do
            ' One more trial that you took is added to the total
            counter += 1
             ' ask for user input again
            guess = InputBox("I got a number that you got to try and guess it is between 1 & 6. ")
            If guess = randomNumber Then
                ‘ Leave the Do as the guess is the randomized number   
                Exit Do
            End If
            MsgBox("That number is incorrect! ")
