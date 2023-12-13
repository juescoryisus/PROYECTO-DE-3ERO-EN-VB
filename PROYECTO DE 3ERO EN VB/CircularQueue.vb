Imports System
Imports PROYECTO_DE_3ERO_EN_VB.PROYECTO_DE_3ERO_EN_VB

Module CircularQueue


    Sub CIRCULAR()
        Dim circularQueue As New CircularQueue(Of String)(5)

        While True
            Console.WriteLine("1. Encolar")
            Console.WriteLine("2. Desencolar")
            Console.WriteLine("3. Mostrar elementos")
            Console.WriteLine("4. Regresar al Menu de Estructuras")

            Console.Write("Seleccione una opción: ")
            Dim opcion As String = Console.ReadLine()

            Select Case opcion
                Case "1"
                    Console.Write("Ingrese el dato a encolar: ")
                    Dim datoEncolar As String = Console.ReadLine()
                    circularQueue.Enqueue(datoEncolar)
                    Console.WriteLine("Dato encolado: " & datoEncolar)

                Case "2"
                    If Not circularQueue.IsEmpty() Then
                        Dim datoDesencolar As String = circularQueue.Dequeue()
                        Console.WriteLine("Dato desencolado: " & datoDesencolar)
                    Else
                        Console.WriteLine("La cola está vacía.")
                    End If

                Case "3"
                    Console.WriteLine("Elementos en la cola:")
                    circularQueue.Display()

                Case "4"
                    Program.Main()

                Case Else
                    Console.WriteLine("Opción no válida")
            End Select

            Console.WriteLine() ' Separador para mejor legibilidad
        End While
    End Sub
End Module

Class CircularQueue(Of T)
    Private array As T()
    Private size As Integer
    Private front As Integer
    Private rear As Integer

    Public Sub New(capacity As Integer)
        array = New T(capacity - 1) {}
        size = 0
        front = 0
        rear = -1
    End Sub

    Public Sub Enqueue(item As T)
        If IsFull() Then
            Console.WriteLine("La cola está llena. No se puede encolar.")
            Return
        End If

        rear = (rear + 1) Mod array.Length
        array(rear) = item
        size += 1
    End Sub

    Public Function Dequeue() As T
        If IsEmpty() Then
            Console.WriteLine("La cola está vacía. No se puede desencolar.")
            Return Nothing
        End If

        Dim item As T = array(front)
        front = (front + 1) Mod array.Length
        size -= 1
        Return item
    End Function

    Public Function IsEmpty() As Boolean
        Return size = 0
    End Function

    Public Function IsFull() As Boolean
        Return size = array.Length
    End Function

    Public Sub Display()
        If size > 0 Then
            Console.Write("Contenido de la Cola Circular: ")
            For i As Integer = 0 To size - 1
                Dim index As Integer = (front + i) Mod array.Length
                Console.Write($"{array(index)} ")
            Next
            Console.WriteLine()
        Else
            Console.WriteLine("La cola está vacía.")
        End If
    End Sub
End Class
