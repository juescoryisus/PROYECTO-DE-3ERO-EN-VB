Imports System
Imports PROYECTO_DE_3ERO_EN_VB.Poyecto_de_3er_semestre

Module Selectionsort
    Sub Selection()
        Dim array As Integer() = New Integer(0) {}

        Do
            Console.WriteLine("1. Agregar valor")
            Console.WriteLine("2. Ordenar con Selection Sort")
            Console.WriteLine("3. Mostrar array")
            Console.WriteLine("4. Regresar a Algoritmos")

            Dim opcion As Integer = ObtenerOpcion()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese un valor: ")
                    Dim valor As Integer = Integer.Parse(Console.ReadLine())
                    array = AgregarValor(array, valor)
                    Exit Select

                Case 2
                    SelectionSort(array)
                    Console.WriteLine("Array ordenado con Selection Sort")
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

    Function ObtenerOpcion() As Integer
        Console.Write("Ingrese su opción: ")
        Return Integer.Parse(Console.ReadLine())
    End Function

    Function AgregarValor(array As Integer(), valor As Integer) As Integer()
        Dim newArray As Integer() = New Integer(array.Length) {}
        array.Copy(array, newArray, array.Length)
        newArray(array.Length) = valor
        Return newArray
    End Function

    Sub MostrarArray(array As Integer())
        Console.WriteLine("Contenido del array:")
        For Each valor In array
            Console.Write(valor & " ")
        Next
        Console.WriteLine()
    End Sub

    Sub SelectionSort(array As Integer())
        If array.Length = 0 Then
            Console.WriteLine("El array está vacío. No hay nada que ordenar.")
            Return
        End If

        Dim n As Integer = array.Length

        For i As Integer = 0 To n - 2
            ' Encontrar el mínimo elemento en el array no ordenado
            Dim indiceMinimo As Integer = i
            For j As Integer = i + 1 To n - 1
                If array(j) < array(indiceMinimo) Then
                    indiceMinimo = j
                End If
            Next

            ' Intercambiar el mínimo encontrado con el primer elemento no ordenado
            Swap(array, indiceMinimo, i)
        Next
    End Sub

    Sub Swap(ByRef array As Integer(), a As Integer, b As Integer)
        Dim temp As Integer = array(a)
        array(a) = array(b)
        array(b) = temp
    End Sub
End Module
