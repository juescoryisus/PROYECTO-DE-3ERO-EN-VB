Imports System
Imports PROYECTO_DE_3ERO_EN_VB.Poyecto_de_3er_semestre

Module Insertionsort
    Sub Inser()
        Dim array As Integer() = New Integer(0) {}

        Do
            Console.WriteLine("1. Agregar valor")
            Console.WriteLine("2. Ordenar con Insertion Sort")
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
                    InsertionSort(array)
                    Console.WriteLine("Array ordenado con Insertion Sort")
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

    Sub InsertionSort(array As Integer())
        If array.Length = 0 Then
            Console.WriteLine("El array está vacío. No hay nada que ordenar.")
            Return
        End If

        For i As Integer = 1 To array.Length - 1
            Dim clave As Integer = array(i)
            Dim j As Integer = i - 1

            ' Mover los elementos del array[0..i-1] que son mayores que la clave
            ' a una posición por delante de su posición actual
            While j >= 0 AndAlso array(j) > clave
                array(j + 1) = array(j)
                j = j - 1
            End While
            array(j + 1) = clave
        Next
    End Sub
End Module
