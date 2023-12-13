Imports System
Imports PROYECTO_DE_3ERO_EN_VB.Poyecto_de_3er_semestre

Module Combsort
    Sub COMB()
        Dim array As Integer() = New Integer(0) {}

        Do
            Console.WriteLine("1. Agregar valor")
            Console.WriteLine("2. Ordenar con Combsort")
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
                    COMB(array)
                    Console.WriteLine("Array ordenado con Combsort")
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

    Sub COMB(array As Integer())
        Dim gap As Integer = array.Length
        Dim swapped As Boolean = True

        Do While gap > 1 OrElse swapped
            If gap > 1 Then
                gap = CInt(gap / 1.3)
            End If

            Dim i As Integer = 0
            swapped = False

            Do While i + gap < array.Length
                If array(i) > array(i + gap) Then
                    Swap(array(i), array(i + gap))
                    swapped = True
                End If

                i += 1
            Loop
        Loop
    End Sub

    Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer = a
        a = b
        b = temp
    End Sub
End Module
