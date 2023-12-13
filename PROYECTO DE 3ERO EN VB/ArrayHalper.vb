Imports System
Imports PROYECTO_DE_3ERO_EN_VB.Poyecto_de_3er_semestre

Module ArrayHelper
    Public Function AgregarValor(array As Integer(), valor As Integer) As Integer()
        Dim newArray As Integer() = New Integer(array.Length) {}
        array.Copy(array, newArray, array.Length)
        newArray(array.Length) = valor
        Return newArray
    End Function

    Public Sub MostrarArray(array As Integer())
        Console.WriteLine("Contenido del array:")
        For Each valor In array
            Console.Write(valor & " ")
        Next
        Console.WriteLine()
    End Sub

    Public Sub OrdenarArray(array As Integer(), algoritmo As String)
        Select Case algoritmo.ToLower()
            Case "bubblesort"
                BubbleSort(array)
                Console.WriteLine("Array ordenado con Bubble Sort")
                Exit Select

            Case "selectionsort"
                SelectionSort(array)
                Console.WriteLine("Array ordenado con Selection Sort")
                Exit Select

            Case "insertionsort"
                InsertionSort(array)
                Console.WriteLine("Array ordenado con Insertion Sort")
                Exit Select

                ' Puedes agregar más casos para otros algoritmos

            Case Else
                Console.WriteLine("Algoritmo no válido")
                Exit Select
        End Select
    End Sub

    Private Sub BubbleSort(array As Integer())
        ' Implementación de Bubble Sort
    End Sub

    Private Sub SelectionSort(array As Integer())
        ' Implementación de Selection Sort
    End Sub

    Private Sub InsertionSort(array As Integer())
        ' Implementación de Insertion Sort
    End Sub
End Module

Module ArrayHalper
    Public Sub [Array]()
        Dim array As Integer() = New Integer(0) {}

        Do
            Console.WriteLine("1. Agregar valor")
            Console.WriteLine("2. Ordenar array")
            Console.WriteLine("3. Mostrar array")
            Console.WriteLine("4. Regresar a Algoritmos")

            Dim opcion As Integer = ObtenerOpcion()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese un valor: ")
                    Dim valor As Integer = Integer.Parse(Console.ReadLine())
                    array = ArrayHelper.AgregarValor(array, valor)
                    Exit Select

                Case 2
                    Console.Write("Ingrese el nombre del algoritmo de ordenamiento (bubblesort, selectionsort, insertionsort, etc.): ")
                    Dim algoritmo As String = Console.ReadLine()
                    ArrayHelper.OrdenarArray(array, algoritmo)
                    Exit Select

                Case 3
                    ArrayHelper.MostrarArray(array)
                    Exit Select

                Case 4
                    Algoritmos.Ordenamiento()
                    Exit Select

                Case Else
                    Console.WriteLine("Opción no válida")
                    Exit Select
            End Select

        Loop While True
    End Sub

    Function ObtenerOpcion() As Integer
        Console.Write("Ingrese su opción: ")
        Return Integer.Parse(Console.ReadLine())
    End Function
End Module
