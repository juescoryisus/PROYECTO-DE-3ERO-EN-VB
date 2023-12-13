Imports System
Imports PROYECTO_DE_3ERO_EN_VB.Poyecto_de_3er_semestre

Module Quicksort
    Sub Quick()
        Dim array As Integer() = New Integer(0) {}

        Do
            Console.WriteLine("1. Agregar valor")
            Console.WriteLine("2. Ordenar con QuickSort")
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
                    QuickSort(array, 0, array.Length - 1)
                    Console.WriteLine("Array ordenado con QuickSort")
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

    Sub QuickSort(array As Integer(), izquierda As Integer, derecha As Integer)
        If izquierda < derecha Then
            Dim indiceParticion As Integer = Particionar(array, izquierda, derecha)

            ' Ordenar recursivamente los elementos antes y después de la partición
            QuickSort(array, izquierda, indiceParticion - 1)
            QuickSort(array, indiceParticion + 1, derecha)
        End If
    End Sub

    Function Particionar(array As Integer(), izquierda As Integer, derecha As Integer) As Integer
        Dim pivote As Integer = array(derecha)
        Dim i As Integer = izquierda - 1

        For j As Integer = izquierda To derecha - 1
            If array(j) <= pivote Then
                i += 1
                Swap(array(i), array(j))
            End If
        Next

        Swap(array(i + 1), array(derecha))
        Return i + 1
    End Function

    Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer = a
        a = b
        b = temp
    End Sub
End Module
