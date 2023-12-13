Imports System
Imports PROYECTO_DE_3ERO_EN_VB.Poyecto_de_3er_semestre

Module Cou
    Sub Couting()
        Dim array As Integer() = New Integer(0) {}

        Do
            Console.WriteLine("1. Agregar valor")
            Console.WriteLine("2. Ordenar con Counting Sort")
            Console.WriteLine("3. Mostrar array")
            Console.WriteLine("4. Regresar al Menú de Algoritmos")

            Dim opcion As Integer = ObtenerOpcion()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese un valor: ")
                    Dim valor As Integer = Integer.Parse(Console.ReadLine())
                    array = AgregarValor(array, valor)
                    Exit Select

                Case 2
                    CountingSort(array)
                    Console.WriteLine("Array ordenado con Counting Sort")
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

    Sub CountingSort(array As Integer())
        If array.Length = 0 Then
            Console.WriteLine("El array está vacío. No hay nada que ordenar.")
            Return
        End If

        Dim max As Integer = array(0)
        Dim min As Integer = array(0)

        ' Encontrar el valor máximo y mínimo en el array
        For i As Integer = 1 To array.Length - 1
            If array(i) > max Then
                max = array(i)
            End If

            If array(i) < min Then
                min = array(i)
            End If
        Next

        Dim range As Integer = max - min + 1
        Dim count As Integer() = New Integer(range - 1) {}
        Dim output As Integer() = New Integer(array.Length - 1) {}

        ' Inicializar el array de conteo
        For i As Integer = 0 To range - 1
            count(i) = 0
        Next

        ' Contar la frecuencia de cada elemento
        For i As Integer = 0 To array.Length - 1
            count(array(i) - min) += 1
        Next

        ' Actualizar el array de conteo para almacenar la posición real de cada elemento
        For i As Integer = 1 To range - 1
            count(i) += count(i - 1)
        Next

        ' Construir el array de salida
        For i As Integer = array.Length - 1 To 0 Step -1
            output(count(array(i) - min) - 1) = array(i)
            count(array(i) - min) -= 1
        Next

        ' Copiar el array ordenado de vuelta al array original
        array.Copy(output, array, array.Length)
    End Sub
End Module
