Imports System
Imports PROYECTO_DE_3ERO_EN_VB.Poyecto_de_3er_semestre

Module Pigeonhole
    Sub Pinge()
        Dim array As Integer() = New Integer(0) {}

        Do
            Console.WriteLine("1. Agregar valor")
            Console.WriteLine("2. Ordenar con Pigeonhole Sort")
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
                    PigeonholeSort(array)
                    Console.WriteLine("Array ordenado con Pigeonhole Sort")
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

    Sub PigeonholeSort(array As Integer())
        If array.Length = 0 Then
            Console.WriteLine("El array está vacío. No hay nada que ordenar.")
            Return
        End If

        Dim min As Integer = array(0)
        Dim max As Integer = array(0)

        ' Encontrar el rango del array
        For i As Integer = 1 To array.Length - 1
            If array(i) < min Then
                min = array(i)
            End If
            If array(i) > max Then
                max = array(i)
            End If
        Next

        Dim rango As Integer = max - min + 1
        Dim pigeonHoles As Integer() = New Integer(rango - 1) {}

        ' Inicializar los agujeros del palomar con 0
        For i As Integer = 0 To rango - 1
            pigeonHoles(i) = 0
        Next

        ' Llenar el palomar
        For i As Integer = 0 To array.Length - 1
            pigeonHoles(array(i) - min) += 1
        Next

        ' Reconstruir el array ordenado
        Dim indice As Integer = 0
        For i As Integer = 0 To rango - 1
            While pigeonHoles(i) > 0
                array(indice) = i + min
                indice += 1
                pigeonHoles(i) -= 1
            End While
        Next
    End Sub
End Module
