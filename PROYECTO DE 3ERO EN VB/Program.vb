Imports System
Imports PROYECTO_DE_3ERO_EN_VB.ListaDobleEjemplo
Imports PROYECTO_DE_3ERO_EN_VB.Poyecto_de_3er_semestre

Namespace PROYECTO_DE_3ERO_EN_VB
    Friend Class Program
        Public Shared Sub Main()
            Console.WriteLine("==============Entrto a la estructiura de datos=================")
            Console.WriteLine("Elige una de las Estructuras")
            Console.WriteLine("1.Listas")
            Console.WriteLine("2.Pilas")
            Console.WriteLine("3.Colas")
            Console.WriteLine("4.Arboles")
            Console.WriteLine("5.Grafos")
            Console.WriteLine("6.Algoritmos")
            Dim valores As Integer = Nothing
            If Integer.TryParse(Console.ReadLine(), valores) Then


                Select Case valores
                    Case 1
                        Console.WriteLine("Entraste a las listas")
                        Console.WriteLine("Ingrese una opción (1).Simple List | (2).Double Lits | (3).Circular List | (4).Circular Doubly Linked List")
                        Dim opcion As String = Console.ReadLine()



                        Select Case opcion
                            Case "1"
                                Simple_list.List()
                            Case "2"
                                Double_list.D()
                            Case "3"
                                Dim C As New Circular_list()
                                C.insertarNodo()
                                C.insertarNodo()
                                C.insertarNodo()
                                C.insertarNodo()
                                C.insertarNodo()
                                Console.WriteLine(" " & vbLf & " La lista ingresada")
                                C.desplegarlista()

                                Dim op As Integer = ObteneOpcion()

                                Select Case op
                                    Case 1
                                        Program.Main()
                                        Exit Select
                                End Select
                                Exit Select
                            Case "4"
                                Dim CDLL As New CirularDoublyLinkedList()
                                CDLL.insertarNodo()
                                CDLL.insertarNodo()
                                CDLL.insertarNodo()
                                CDLL.insertarNodo()
                                CDLL.insertarNodo()
                                Console.WriteLine("Desplegar lista primero al ultimo")
                                CDLL.desplegarlistaPU()
                                Console.WriteLine("Desplegar lista ultimo al primero")
                                CDLL.desplegarlistasUP()
                                Console.ReadLine()

                                Dim o As Integer = ObteneOpciones()

                                Select Case o
                                    Case 1
                                        Program.Main()
                                        Exit Select
                                End Select
                                Exit Select
                            Case Else
                                Console.WriteLine("Opción no válida")
                                Exit Select
                        End Select
                        Exit Select

                    Case 2
                        Console.WriteLine("===============Entraste a las pilas=====================")
                        Console.WriteLine("Ingrese una opción | (1).StackStatick | (2).StackDinamic:")
                        Dim opc As String = Console.ReadLine()

                        Select Case opc
                            Case "1"
                                Console.WriteLine("==================Entraste a la pila estatica")
                                Dim clase As New StackStatick()
                                clase.ver()
                                Exit Select
                            Case "2"
                                Console.WriteLine("================Entro a la pila dinamica=============")
                                Dim s As New StackDinamic()

                                s.insertarNodo()
                                s.insertarNodo()
                                s.insertarNodo()
                                s.insertarNodo()
                                s.insertarNodo()

                                Console.WriteLine(vbLf & " La pila ingresada" & vbLf & vbLf)
                                s.desplegarPila()
                                Console.ReadLine()

                                Dim p As Integer = ObOpcion()

                                Select Case p
                                    Case 1
                                        Program.Main()
                                        Exit Select
                                End Select
                                Exit Select
                            Case Else
                                Console.WriteLine("Opción no válida")
                                Exit Select
                        End Select
                        Exit Select

                    Case 3
                        Console.WriteLine("===============Entraste a las colas=====================")
                        Console.WriteLine("Ingrese una opción (1).Cola | (2).PrioridadQueue | (3).CircularQueue")
                        Dim opciones As String = Console.ReadLine()

                        Select Case opciones
                            Case "1"
                                Console.WriteLine("==================Cola======================")
                                Dim clase As New Cola()
                                clase.hola()
                                Exit Select
                            Case "2"
                                Console.WriteLine("==================PropiedadQueue======================")
                                Dim clasi As New PioridadQueue()
                                clasi.observar()
                                Exit Select
                            Case "3"
                                Console.WriteLine("==================CircularQueue======================")
                                CircularQueue.CIRCULAR()
                                Exit Select
                            Case Else
                                Console.WriteLine("Opción no válida")
                                Exit Select
                        End Select
                        Exit Select
                    Case 4
                        Console.WriteLine("===============Entraste a los arboles=====================")
                        Console.WriteLine("==================Binary tree======================")
                        Dim binario As New BinaryTree()
                        binario.arbol()
                        Exit Select
                    Case 5
                        Console.WriteLine("===============Entraste a los grafos=====================")
                        Console.WriteLine("Ingrese una opción (1).Graph | (2).Unidirected Graph")
                        Dim opcionesGraph As String = Console.ReadLine()

                        Select Case opcionesGraph
                            Case "1"
                                Console.WriteLine("==================Graph======================")
                                Dim claseGraph As New DirectedGraph()
                                claseGraph.Dirigido()
                                Exit Select
                            Case "2"
                                Console.WriteLine("==================UnidirectedGraph======================")
                                Dim grafo As New UnidirectedGraph()
                                grafo.Unidirected()
                                Exit Select
                            Case Else
                                Console.WriteLine("Opción no válida")
                                Exit Select
                        End Select
                        Exit Select
                    Case 6
                        Algoritmos.Ordenamiento()
                        Exit Select
                End Select




            End If

        End Sub
        Private Shared Function ObOpcion() As Integer
            Console.Write("Ingrese el Numero (1) para Regresar al Menu de Estructuras")
            Return Integer.Parse(Console.ReadLine())
        End Function

        Private Shared Function ObteneOpcion() As Integer
            Console.Write("Ingrese el Numero 1 para Regresar al Menu de Estructuras")
            Return Integer.Parse(Console.ReadLine())
        End Function

        Private Shared Function ObteneOpciones() As Integer
            Console.Write("Ingrese el Numero (1) para Regresar al Menu de Estructuras")
            Return Integer.Parse(Console.ReadLine())
        End Function
    End Class

End Namespace

