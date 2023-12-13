Imports System
Imports PROYECTO_DE_3ERO_EN_VB.Poyecto_de_3er_semestre

Public Class SmoothSort
    Private array As Integer()
    Private size As Integer

    Public Sub New(inputArray As Integer())
        array = inputArray
        size = inputArray.Length
    End Sub

    Public Sub Sort()
        For i As Integer = 0 To size - 1
            SiftDown(i)
        Next

        For i As Integer = size - 1 To 1 Step -1
            Swap(0, i)
            SiftUp(0, i - 1)
        Next
    End Sub

    Private Sub SiftDown(i As Integer)
        Dim leftChild, rightChild, j As Integer

        While 2 * i + 1 < size
            leftChild = 2 * i + 1
            rightChild = leftChild + 1
            j = i

            If rightChild < size AndAlso array(rightChild) > array(j) Then
                j = rightChild
            End If

            If array(leftChild) > array(j) Then
                j = leftChild
            End If

            If i = j Then
                Exit While
            End If

            Swap(i, j)
            i = j
        End While
    End Sub

    Private Sub SiftUp(i As Integer, last As Integer)
        While i < last
            Dim j As Integer = 2 * i + 1

            If j + 1 <= last AndAlso array(j) < array(j + 1) Then
                j += 1
            End If

            If j <= last AndAlso array(i) < array(j) Then
                Swap(i, j)
                i = j
            Else
                Exit While
            End If
        End While
    End Sub

    Private Sub Swap(i As Integer, j As Integer)
        Dim temp As Integer = array(i)
        array(i) = array(j)
        array(j) = temp
    End Sub
End Class

Module Smooth
    Public Sub Smoot()
        Dim exi As Boolean = False
        Dim array As Integer() = Nothing

        Do
            Console.WriteLine("Menú:")
            Console.WriteLine("1. Smooth Sort")
            Console.WriteLine("2. Regresar a Algoritmos")
            Console.Write("Selecciona una opción: ")

            Dim cion As String = Console.ReadLine()

            Select Case cion
                Case "1"
                    array = GetIntArrayFromUser()
                    Console.WriteLine(vbCrLf & "Original array:")
                    PrintArray(array)

                    Dim smoothSort As New SmoothSort(array)
                    smoothSort.Sort()

                    Console.WriteLine(vbCrLf & "Smooth Sorted array:")
                    PrintArray(array)
                    Exit Select

                Case "2"
                    Algoritmos.Ordenamiento()
                    Exit Select

                Case Else
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.")
                    Exit Select
            End Select

        Loop While Not [exi]
    End Sub

    Private Function GetIntArrayFromUser() As Integer()
        Console.WriteLine("Enter the number of elements:")
        Dim size As Integer = Integer.Parse(Console.ReadLine())

        Dim array As Integer() = New Integer(size - 1) {}

        Console.WriteLine("Enter the elements (integer numbers):")
        For i As Integer = 0 To size - 1
            Console.Write($"Element {i + 1}: ")
            array(i) = Integer.Parse(Console.ReadLine())
        Next

        Return array
    End Function

    Private Sub PrintArray(array As Integer())
        For Each item In array
            Console.Write(item & " ")
        Next
        Console.WriteLine()
    End Sub
End Module
