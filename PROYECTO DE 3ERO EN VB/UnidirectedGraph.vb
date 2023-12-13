Imports PROYECTO_DE_3ERO_EN_VB.estructura_de_datoss
Imports PROYECTO_DE_3ERO_EN_VB.PROYECTO_DE_3ERO_EN_VB

Namespace Poyecto_de_3er_semestre
    Friend Class UnidirectedGraph
        Public Sub Unidirected()
            Dim grafo As New GrafoNoDirigido()

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
                        Console.Write("Ingrese el valor del primer nodo: ")
                        Dim valorNodo1 As Integer = Convert.ToInt32(Console.ReadLine())
                        Console.Write("Ingrese el valor del segundo nodo: ")
                        Dim valorNodo2 As Integer = Convert.ToInt32(Console.ReadLine())
                        grafo.AgregarArista(valorNodo1, valorNodo2)
                        Console.WriteLine($"Arista agregada entre {valorNodo1} y {valorNodo2}.")

                    Case "3"
                        Console.WriteLine("Grafo actual:")
                        grafo.ImprimirGrafo()

                    Case "4"
                        Program.Main()

                    Case Else
                        Console.WriteLine("Opción no válida")
                End Select
            End While

            Console.WriteLine() ' Separador para mejor legibilidad
        End Sub
    End Class
End Namespace

Namespace estructura_de_datoss
    Class NodoUnidirected
        Public Property Valor As Integer

        Public Sub New(valor As Integer)
            Me.Valor = valor
        End Sub
    End Class

    Class GrafoNoDirigido
        Private adyacencias As Dictionary(Of NodoUnidirected, List(Of NodoUnidirected))

        Public Sub New()
            adyacencias = New Dictionary(Of NodoUnidirected, List(Of NodoUnidirected))()
        End Sub

        Public Sub AgregarNodo(valor As Integer)
            Dim nuevoNodo As New NodoUnidirected(valor)
            adyacencias(nuevoNodo) = New List(Of NodoUnidirected)()
        End Sub

        Public Sub AgregarArista(valorNodo1 As Integer, valorNodo2 As Integer)
            Dim nodo1 As NodoUnidirected = ObtenerNodo(valorNodo1)
            Dim nodo2 As NodoUnidirected = ObtenerNodo(valorNodo2)

            If nodo1 IsNot Nothing AndAlso nodo2 IsNot Nothing Then
                adyacencias(nodo1).Add(nodo2)
                adyacencias(nodo2).Add(nodo1) ' Para un grafo no dirigido, se agrega una arista en ambas direcciones
            End If
        End Sub

        Private Function ObtenerNodo(valor As Integer) As NodoUnidirected
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
