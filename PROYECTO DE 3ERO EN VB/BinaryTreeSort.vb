Imports PROYECTO_DE_3ERO_EN_VB.estructura_de_datoss
Imports PROYECTO_DE_3ERO_EN_VB.PROYECTO_DE_3ERO_EN_VB

Namespace Poyecto_de_3er_semestre
    Friend Class BinaryTree
        Public Sub arbol()
            Dim arbol As New ArbolBinario()

            While True
                Console.WriteLine("1. Agregar dato al árbol")
                Console.WriteLine("2. Imprimir en orden")
                Console.WriteLine("3. Regresar al Menú de Estructuras")

                Console.Write("Seleccione una opción: ")
                Dim opcion As String = Console.ReadLine()

                Select Case opcion
                    Case "1"
                        Console.Write("Ingrese el dato a agregar al árbol: ")
                        Dim datoAgregar As Integer = Convert.ToInt32(Console.ReadLine())
                        arbol.Insertar(datoAgregar)
                        Console.WriteLine("Dato agregado al árbol: " & datoAgregar)

                    Case "2"
                        Console.WriteLine("Recorrido en orden del árbol:")
                        arbol.ImprimirInorden()
                        Console.WriteLine()

                    Case "3"
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
    Class NodoArbol
        Public Property Valor As Integer
        Public Property Izquierdo As NodoArbol
        Public Property Derecho As NodoArbol

        Public Sub New(valor As Integer)
            Me.Valor = valor
            Izquierdo = Nothing
            Derecho = Nothing
        End Sub
    End Class

    Class ArbolBinario
        Private raiz As NodoArbol

        Public Sub New()
            raiz = Nothing
        End Sub

        Public Sub Insertar(valor As Integer)
            raiz = InsertarRec(raiz, valor)
        End Sub

        Private Function InsertarRec(raizActual As NodoArbol, valor As Integer) As NodoArbol
            If raizActual Is Nothing Then
                Return New NodoArbol(valor)
            End If

            If valor < raizActual.Valor Then
                raizActual.Izquierdo = InsertarRec(raizActual.Izquierdo, valor)
            ElseIf valor > raizActual.Valor Then
                raizActual.Derecho = InsertarRec(raizActual.Derecho, valor)
            End If

            Return raizActual
        End Function

        Public Sub ImprimirInorden()
            ImprimirInordenRec(raiz)
        End Sub

        Private Sub ImprimirInordenRec(raizActual As NodoArbol)
            If raizActual IsNot Nothing Then
                ImprimirInordenRec(raizActual.Izquierdo)
                Console.Write(raizActual.Valor & " ")
                ImprimirInordenRec(raizActual.Derecho)
            End If
        End Sub
    End Class
End Namespace
