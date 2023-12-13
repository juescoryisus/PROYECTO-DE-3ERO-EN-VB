Imports PROYECTO_DE_3ERO_EN_VB.estructura_de_datoss
Imports PROYECTO_DE_3ERO_EN_VB.PROYECTO_DE_3ERO_EN_VB

Namespace Poyecto_de_3er_semestre
    Friend Class DirectedGraph
        Public Sub Dirigido()
            Dim grafo As New GrafoDirigido()

            While True
                Console.WriteLine("1. Agregar nodo al grafo")
                Console.WriteLine("2. Agregar arista al grafo")
                Console.WriteLine("3. Imprimir grafo")
                Console.WriteLine("4. Regresar al Menu de Estructuras")

                Console.Write("Seleccione una opción: ")
                Dim opcion As String = Console.ReadLine()

                Select Case opcion
                    Case "1"
                        Console.Write("Ingrese el valor del nuevo nodo: ")
                        Dim valorNodo As Integer = Convert.ToInt32(Console.ReadLine())
                        grafo.AgregarNodo(valorNodo)
                        Console.WriteLine($"Nodo {valorNodo} agregado al grafo.")

                    Case "2"
                        Console.Write("Ingrese el valor del nodo de origen: ")
                        Dim valorOrigen As Integer = Convert.ToInt32(Console.ReadLine())
                        Console.Write("Ingrese el valor del nodo de destino: ")
                        Dim valorDestino As Integer = Convert.ToInt32(Console.ReadLine())
                        grafo.AgregarArista(valorOrigen, valorDestino)
                        Console.WriteLine($"Arista agregada de {valorOrigen} a {valorDestino}.")

                    Case "3"
                        Console.WriteLine("Grafo actual:")
                        grafo.ImprimirGrafo()

                    Case "4"
                        Program.Main()

                    Case Else
                        Console.WriteLine("Opción no válida")
                End Select

                Console.WriteLine() ' Separador para mejor legibilidad
            End While
        End Sub
    End Class
End Namespace

Namespace estructura_de_datoss
    Class NodoGraph
        Public Property Valor As Integer

        Public Sub New(valor As Integer)
            Me.Valor = valor
        End Sub
    End Class

    Class GrafoDirigido
        Private adyacencias As Dictionary(Of NodoGraph, List(Of NodoGraph))

        Public Sub New()
            adyacencias = New Dictionary(Of NodoGraph, List(Of NodoGraph))()
        End Sub

        Public Sub AgregarNodo(valor As Integer)
            Dim nuevoNodo As New NodoGraph(valor)
            adyacencias(nuevoNodo) = New List(Of NodoGraph)()
        End Sub

        Public Sub AgregarArista(valorOrigen As Integer, valorDestino As Integer)
            Dim nodoOrigen As NodoGraph = ObtenerNodo(valorOrigen)
            Dim nodoDestino As NodoGraph = ObtenerNodo(valorDestino)

            If nodoOrigen IsNot Nothing AndAlso nodoDestino IsNot Nothing Then
                adyacencias(nodoOrigen).Add(nodoDestino)
            End If
        End Sub

        Private Function ObtenerNodo(valor As Integer) As NodoGraph
            For Each nodo In adyacencias.Keys
                If nodo.Valor = valor Then
                    Return nodo
                End If
            Next

            Return Nothing
        End Function

        Public Sub ImprimirGrafo()
            For Each nodo In adyacencias.Keys
                Console.Write($"Nodo {nodo.Valor}: ")

                For Each vecino In adyacencias(nodo)
                    Console.Write($"{vecino.Valor} ")
                Next

                Console.WriteLine()
            Next
        End Sub
    End Class
End Namespace
