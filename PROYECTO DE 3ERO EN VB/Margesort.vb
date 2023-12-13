Imports System
Imports PROYECTO_DE_3ERO_EN_VB.Poyecto_de_3er_semestre

Module Margesort
    Sub Marge()
        Dim array As Integer() = New Integer(0) {}

        Do
            Console.WriteLine("1. Agregar valor")
            Console.WriteLine("2. Ordenar con Merge Sort")
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
                    MergeSort(array)
                    Console.WriteLine("Array ordenado con Merge Sort")
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

    Sub MergeSort(array As Integer())
        If array.Length = 0 Then
            Console.WriteLine("El array está vacío. No hay nada que ordenar.")
            Return
        End If

        Dim aux As Integer() = New Integer(array.Length - 1) {}
        MergeSort(array, aux, 0, array.Length - 1)
    End Sub

    Sub MergeSort(array As Integer(), aux As Integer(), izquierda As Integer, derecha As Integer)
        If izquierda < derecha Then
            Dim medio As Integer = (izquierda + derecha) \ 2

            ' Ordenar la primera mitad y la segunda mitad
            MergeSort(array, aux, izquierda, medio)
            MergeSort(array, aux, medio + 1, derecha)

            ' Combinar las mitades ordenadas
            Merge(array, aux, izquierda, medio, derecha)
        End If
    End Sub

    Sub Merge(array As Integer(), aux As Integer(), izquierda As Integer, medio As Integer, derecha As Integer)
        ' Copiar los elementos a un array auxiliar
        For i As Integer = izquierda To derecha
            aux(i) = array(i)
        Next

        Dim indiceIzquierda As Integer = izquierda
        Dim indiceDerecha As Integer = medio + 1
        Dim indiceActual As Integer = izquierda

        ' Fusionar las dos mitades ordenadas
        While indiceIzquierda <= medio AndAlso indiceDerecha <= derecha
            If aux(indiceIzquierda) <= aux(indiceDerecha) Then
                array(indiceActual) = aux(indiceIzquierda)
                indiceIzquierda += 1
            Else
                array(indiceActual) = aux(indiceDerecha)
                indiceDerecha += 1
            End If
            indiceActual += 1
        End While

        ' Copiar los elementos restantes de la mitad izquierda
        While indiceIzquierda <= medio
            array(indiceActual) = aux(indiceIzquierda)
            indiceIzquierda += 1
            indiceActual += 1
        End While
    End Sub
End Module
