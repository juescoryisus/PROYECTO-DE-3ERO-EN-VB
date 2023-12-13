Imports System
Imports PROYECTO_DE_3ERO_EN_VB.Poyecto_de_3er_semestre

Module Heapsort
    Sub Heap()
        Dim array As Integer() = New Integer(0) {}

        Do
            Console.WriteLine("1. Agregar valor")
            Console.WriteLine("2. Ordenar con Heap Sort")
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
                    HeapSort(array)
                    Console.WriteLine("Array ordenado con Heap Sort")
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

    Sub HeapSort(array As Integer())
        If array.Length = 0 Then
            Console.WriteLine("El array está vacío. No hay nada que ordenar.")
            Return
        End If

        ' Construir un heap máximo
        For i As Integer = array.Length \ 2 - 1 To 0 Step -1
            Heapify(array, array.Length, i)
        Next

        ' Extraer elementos uno por uno del heap
        For i As Integer = array.Length - 1 To 1 Step -1
            ' Mover la raíz (máximo elemento) al final del array
            Swap(array(0), array(i))

            ' Llamar a Heapify en el heap reducido
            Heapify(array, i, 0)
        Next
    End Sub

    Sub Heapify(array As Integer(), n As Integer, i As Integer)
        Dim max As Integer = i ' Inicializar el máximo como la raíz
        Dim izquierda As Integer = 2 * i + 1
        Dim derecha As Integer = 2 * i + 2

        ' Si el hijo izquierdo es mayor que la raíz
        If izquierda < n AndAlso array(izquierda) > array(max) Then
            max = izquierda
        End If

        ' Si el hijo derecho es mayor que el máximo hasta ahora
        If derecha < n AndAlso array(derecha) > array(max) Then
            max = derecha
        End If

        ' Si el máximo no es la raíz
        If max <> i Then
            Swap(array(i), array(max))

            ' Recursivamente Heapify el subárbol afectado
            Heapify(array, n, max)
        End If
    End Sub

    Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer = a
        a = b
        b = temp
    End Sub
End Module
