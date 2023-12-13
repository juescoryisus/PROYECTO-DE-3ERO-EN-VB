Imports Poyecto_de_3er_semestre
Imports PROYECTO_DE_3ERO_EN_VB.PROYECTO_DE_3ERO_EN_VB
Imports System

Class Node
    Public Property Data As Integer
    Public Property NextNode As Node

    Public Sub New(data As Integer)
        Me.Data = data
        Me.NextNode = Nothing
    End Sub
End Class

Class SimpleList
    Private head As Node

    Public Sub New()
        head = Nothing
    End Sub

    Public Sub AgregarElemento(data As Integer)
        Dim nuevoNodo As New Node(data)
        If head Is Nothing Then
            head = nuevoNodo
        Else
            Dim temp As Node = head
            While temp.NextNode IsNot Nothing
                temp = temp.NextNode
            End While
            temp.NextNode = nuevoNodo
        End If
    End Sub

    Public Sub MostrarLista()
        Dim temp As Node = head
        While temp IsNot Nothing
            Console.Write(temp.Data & " ")
            temp = temp.NextNode
        End While
        Console.WriteLine()
    End Sub
End Class

Public Module Simple_list
    Public Sub List()
        Dim lista As New SimpleList()

        Do
            Console.WriteLine("1. Agregar elemento")
            Console.WriteLine("2. Mostrar lista")
            Console.WriteLine("3. Regresar al Menu de Estructuras")

            Dim opcion As Integer = ObtenerOpcion()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese un valor: ")
                    Dim valor As Integer = Integer.Parse(Console.ReadLine())
                    lista.AgregarElemento(valor)
                Case 2
                    Console.WriteLine("Contenido de la lista:")
                    lista.MostrarLista()
                Case 3
                    Program.Main()
                Case Else
                    Console.WriteLine("Opción no válida")
            End Select

        Loop While True
    End Sub

    Function ObtenerOpcion() As Integer
        Console.Write("Ingrese su opción: ")
        Return Integer.Parse(Console.ReadLine())
    End Function
End Module
