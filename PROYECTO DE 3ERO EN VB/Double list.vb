Imports System
Imports PROYECTO_DE_3ERO_EN_VB.PROYECTO_DE_3ERO_EN_VB

Namespace ListaDobleEjemplo
    Friend Class Double_list
        Public Shared Sub D()
            Dim listaDoble As New list()

            Console.WriteLine("==============Lista Doble=================")

            Do
                Console.WriteLine("Elige una opción:")
                Console.WriteLine("1. Agregar dato")
                Console.WriteLine("2. Mostrar lista hacia adelante")
                Console.WriteLine("3. Mostrar lista hacia atrás")
                Console.WriteLine("4. Regresar al Menu de Estructuras")

                Dim opcion As String = Console.ReadLine()

                Select Case opcion
                    Case "1"
                        listaDoble.insertarNodo()
                    Case "2"
                        Console.WriteLine("Lista hacia adelante:")
                        listaDoble.desplegarlista()
                    Case "3"
                        Console.WriteLine("Lista hacia atrás:")
                        listaDoble.desplegarlistaa()
                    Case "4"
                        Program.Main()
                        Exit Do
                    Case Else
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.")
                End Select

            Loop While True

            Console.ReadLine()
        End Sub
    End Class

    Friend Class list
        Private primero As Nodo = Nothing
        Private ultimo As Nodo = Nothing

        Public Sub insertarNodo()
            Dim nuevo As New Nodo()
            Console.Write("Ingrese el nuevo dato que contendrá el Nodo:")
            nuevo.Resivir = Integer.Parse(Console.ReadLine())

            If primero Is Nothing Then
                primero = nuevo
                primero.Siguiente = Nothing
                primero.Atras = Nothing
                ultimo = primero
            Else
                ultimo.Siguiente = nuevo
                nuevo.Siguiente = Nothing
                nuevo.Atras = ultimo
                ultimo = nuevo
            End If

            Console.Write(vbLf & " Nuevo nodo ingresado con éxito" & vbLf)
        End Sub

        Public Sub desplegarlista()
            Dim actual As Nodo = primero
            While actual IsNot Nothing
                Console.WriteLine(" " & actual.Resivir)
                actual = actual.Siguiente
            End While
        End Sub

        Public Sub desplegarlistaa()
            Dim actual As Nodo = ultimo
            While actual IsNot Nothing
                Console.WriteLine(" " & actual.Resivir)
                actual = actual.Atras
            End While
        End Sub
    End Class

    Friend Class Nodo
        Private dato As Integer
        Private siguienteNodo As Nodo
        Private atrasNodo As Nodo

        Public Property Resivir() As Integer
            Get
                Return dato
            End Get
            Set(value As Integer)
                dato = value
            End Set
        End Property

        Public Property Siguiente() As Nodo
            Get
                Return siguienteNodo
            End Get
            Set(value As Nodo)
                siguienteNodo = value
            End Set
        End Property

        Public Property Atras() As Nodo
            Get
                Return atrasNodo
            End Get
            Set(value As Nodo)
                atrasNodo = value
            End Set
        End Property
    End Class
End Namespace
