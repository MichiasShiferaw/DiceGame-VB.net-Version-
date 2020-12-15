'Import any necessary to perform the program
Imports System

Public Class DiceGame
    Private Sub DiceGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       'Declare nescarry variable 
        Dim roll As New Random()
        Dim randomNumber As Integer = roll.Next(6)
        Dim guess As Integer
        Dim counter As Integer
