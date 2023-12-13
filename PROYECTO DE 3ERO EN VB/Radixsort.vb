Imports System
Imports PROYECTO_DE_3ERO_EN_VB.Poyecto_de_3er_semestre

Module Radixsort
    Sub Radix()
        Dim array As Integer() = New Integer(0) {}

        Do
            Console.WriteLine("1. Agregar valor")
            Console.WriteLine("2. Ordenar con Radix Sort")
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
                    RadixSort(array)
                    Console.WriteLine("Array ordenado con Radix Sort")
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

    Sub RadixSort(array As Integer())
        If array.Length = 0 Then
            Console.WriteLine("El array está vacío. No hay nada que ordenar.")
            Return
        End If

        Dim maximo As Integer = EncontrarMaximo(array)

        ' Realizar el sort para cada dígito
        For exp As Integer = 1 To maximo \ 10
            ContarSort(array, exp)
        Next
    End Sub

    Sub ContarSort(array As Integer(), exp As Integer)
        Dim n As Integer = array.Length
        Dim resultado As Integer() = New Integer(n - 1) {}
        Dim contador As Integer() = New Integer(9) {}

        ' Inicializar el contador
        For i As Integer = 0 To 9
            contador(i) = 0
        Next

        ' Contar la ocurrencia de cada dígito en la posición actual
        For i As Integer = 0 To n - 1
            contador((array(i) \ exp) Mod 10) += 1
        Next

        ' Modificar el contador para contener la posición real de los dígitos en el resultado
        For i As Integer = 1 To 9
            contador(i) += contador(i - 1)
        Next

        ' Construir el array resultado
        For i As Integer = n - 1 To 0 Step -1
            resultado(contador((array(i) \ exp) Mod 10) - 1) = array(i)
            contador((array(i) \ exp) Mod 10) -= 1
        Next

        ' Copiar el array resultado de vuelta al array original
        array.Copy(resultado, array, n)
    End Sub

    Function EncontrarMaximo(array As Integer()) As Integer
        Dim maximo As Integer = array(0)
        For Each valor In array
            If valor > maximo Then
                maximo = valor
            End If
        Next
        Return maximo
    End Function
End Module
