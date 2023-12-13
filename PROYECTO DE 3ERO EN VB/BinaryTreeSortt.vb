Imports PROYECTO_DE_3ERO_EN_VB.Poyecto_de_3er_semestre
Imports PROYECTO_DE_3ERO_EN_VB.PROYECTO_DE_3ERO_EN_VB
Imports System

Friend Class Binarytreesort
    Private Class Nodo
        Public Valor As Integer
        Public Izquierda As Nodo
        Public Derecha As Nodo

        Public Sub New(valor As Integer)
            Me.Valor = valor
            Izquierda = Nothing
            Derecha = Nothing
        End Sub
    End Class

    Private Shared raiz As Nodo = Nothing

    Public Shared Sub BINARYTREESORT()
        Do
            Console.WriteLine("1. Agregar valor")
            Console.WriteLine("2. Ordenar con Binary Tree Sort")
            Console.WriteLine("3. Mostrar en orden")
            Console.WriteLine("4. Regresar al Menu de Estructuras")

            Dim opcion As Integer = ObtenerOpcion()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese un valor: ")
                    Dim valor As Integer = Integer.Parse(Console.ReadLine())
                    raiz = AgregarValor(raiz, valor)
                    Exit Select

                Case 2
                    Console.WriteLine("Ordenando con Binary Tree Sort")
                    BinaryTreeSort(raiz)
                    Exit Select

                Case 3
                    Console.WriteLine("Mostrando en orden:")
                    MostrarEnOrden(raiz)
                    Console.WriteLine()
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

    Private Shared Function AgregarValor(nodo As Nodo, valor As Integer) As Nodo
        If nodo Is Nothing Then
            Return New Nodo(valor)
        End If

        If valor < nodo.Valor Then
            nodo.Izquierda = AgregarValor(nodo.Izquierda, valor)
        ElseIf valor > nodo.Valor Then
            nodo.Derecha = AgregarValor(nodo.Derecha, valor)
        End If

        Return nodo
    End Function

    Private Shared Sub BinaryTreeSort(ByRef nodo As Nodo)
        If nodo Is Nothing Then
            Return
        End If

        BinaryTreeSort(nodo.Izquierda)

        Console.Write(nodo.Valor & " ")

        BinaryTreeSort(nodo.Derecha)
    End Sub

    Private Shared Sub MostrarEnOrden(nodo As Nodo)
        BinaryTreeSort(nodo)
    End Sub
End Class
