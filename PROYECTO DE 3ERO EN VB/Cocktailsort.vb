Imports System
Imports PROYECTO_DE_3ERO_EN_VB.Poyecto_de_3er_semestre

Module Cocktailsort
    Sub COCK()
        Dim exitProgram As Boolean = False
        Dim array As Integer() = Nothing

        Do
            Console.WriteLine("Menú:")
            Console.WriteLine("1. Cocktail Sort")
            Console.WriteLine("2. Otra opción")
            Console.WriteLine("3. Regresar al menú de Algoritmos")
            Console.Write("Selecciona una opción: ")

            Dim op As String = Console.ReadLine()

            Select Case op
                Case "1"
                    array = GetIntArrayFromUser()
                    Console.WriteLine(vbCrLf & "Array original:")
                    PrintArray(array)
                    CocktailSort(array)
                    Console.WriteLine(vbCrLf & "Array ordenado con Cocktail Sort:")
                    PrintArray(array)
                    Exit Select
                Case "2"
                    ' Lógica para la otra opción
                    Exit Select
                Case "3"
                    Algoritmos.Ordenamiento()
                    Exit Select
                Case Else
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.")
                    Exit Select
            End Select

        Loop While Not exitProgram
    End Sub

    Sub CocktailSort(ByRef array As Integer())
        Dim swapped As Boolean

        Do
            swapped = False

            For i As Integer = 0 To array.Length - 2
                If array(i) > array(i + 1) Then
                    Swap(array(i), array(i + 1))
                    swapped = True
                End If
            Next

            If Not swapped Then
                Exit Do
            End If

            swapped = False

            For i As Integer = array.Length - 2 To 0 Step -1
                If array(i) > array(i + 1) Then
                    Swap(array(i), array(i + 1))
                    swapped = True
                End If
            Next
        Loop While swapped
    End Sub

    Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer = a
        a = b
        b = temp
    End Sub

    Function GetIntArrayFromUser() As Integer()
        Console.WriteLine("Ingrese la cantidad de elementos:")
        Dim size As Integer = Integer.Parse(Console.ReadLine())

        Dim array As Integer() = New Integer(size - 1) {}

        Console.WriteLine("Ingrese los elementos (números enteros):")
        For i As Integer = 0 To size - 1
            Console.Write($"Elemento {i + 1}: ")
            array(i) = Integer.Parse(Console.ReadLine())
        Next

        Return array
    End Function

    Sub PrintArray(array As Integer())
        For Each item In array
            Console.Write(item & " ")
        Next
        Console.WriteLine()
    End Sub
End Module
