Imports PROYECTO_DE_3ERO_EN_VB.Poyecto_de_3er_semestre
Imports PROYECTO_DE_3ERO_EN_VB.PROYECTO_DE_3ERO_EN_VB
Imports System

Friend Class Bubblesort
    Public Shared Sub BUBBLE()
        Dim array As Integer() = New Integer(0) {}

        Do
            Console.WriteLine("1. Agregar valor")
            Console.WriteLine("2. Ordenar con Bubble Sort")
            Console.WriteLine("3. Mostrar array")
            Console.WriteLine("4. Regresar al Menu de Estructuras")

            Dim opcion As Integer = ObtenerOpcion()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese un valor: ")
                    Dim valor As Integer = Integer.Parse(Console.ReadLine())
                    array = AgregarValor(array, valor)
                    Exit Select

                Case 2
                    BubbleSort(array)
                    Console.WriteLine("Array ordenado con Bubble Sort")
                    Exit Select

                Case 3
                    MostrarArray(array)
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

    Private Shared Function ObtenerOpcion() As Integer
        Console.Write("Ingrese su opción: ")
        Return Integer.Parse(Console.ReadLine())
    End Function

    Private Shared Function AgregarValor(array As Integer(), valor As Integer) As Integer()
        Dim newArray As Integer() = New Integer(array.Length) {}
        array.Copy(array, newArray, array.Length)
        newArray(array.Length) = valor
        Return newArray
    End Function

    Private Shared Sub MostrarArray(array As Integer())
        Console.WriteLine("Contenido del array:")
        For Each valor In array
            Console.Write(valor & " ")
        Next
        Console.WriteLine()
    End Sub

    Private Shared Sub BubbleSort(array As Integer())
        If array.Length = 0 Then
            Console.WriteLine("El array está vacío. No hay nada que ordenar.")
            Return
        End If

        Dim n As Integer = array.Length
        Dim swapped As Boolean

        Do
            swapped = False
            For i As Integer = 1 To n - 1
                If array(i - 1) > array(i) Then
                    Swap(array(i - 1), array(i))
                    swapped = True
                End If
            Next
            n -= 1
        Loop While swapped
    End Sub

    Private Shared Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer = a
        a = b
        b = temp
    End Sub
End Class
