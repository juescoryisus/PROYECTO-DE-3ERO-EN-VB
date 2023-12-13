Imports System
Imports PROYECTO_DE_3ERO_EN_VB.Poyecto_de_3er_semestre

Module Bucketsort
    Sub BUCKET()
        Dim exitProgram As Boolean = False

        Do
            Console.WriteLine("Menú:")
            Console.WriteLine("1. Agregar elementos y ordenar con Bucket Sort")
            Console.WriteLine("2. Otra opción")
            Console.WriteLine("3. Regresar al Menu de Algoritmos")
            Console.Write("Selecciona una opción: ")

            Dim op As String = Console.ReadLine()

            Select Case op
                Case "1"
                    Console.WriteLine("Ingrese la cantidad de elementos:")
                    Dim size As Integer = Integer.Parse(Console.ReadLine())

                    Dim array As Single() = New Single(size - 1) {}

                    Console.WriteLine("Ingrese los elementos (números decimales entre 0 y 1):")
                    For i As Integer = 0 To size - 1
                        Console.Write($"Elemento {i + 1}: ")
                        array(i) = Single.Parse(Console.ReadLine())
                    Next

                    Console.WriteLine(vbCrLf & "Array original:")
                    DisplayArray(array)

                    Console.WriteLine(vbCrLf & "Array ordenado con Bucket Sort:")
                    BucketSort(array)
                    DisplayArray(array)

                    Console.WriteLine("Presiona Enter para continuar...")
                    Console.ReadLine()
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

    Private Sub BucketSort(array As Single())
        ' Implementación de Bucket Sort
        ' (El código de la función BucketSort del ejemplo anterior)
        ' Aquí puedes implementar la lógica de tu algoritmo Bucket Sort
    End Sub

    Private Sub DisplayArray(array As Single())
        For Each item In array
            Console.Write(item & " ")
        Next
        Console.WriteLine()
    End Sub
End Module
