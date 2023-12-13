Imports System
Imports PROYECTO_DE_3ERO_EN_VB.estructura_de_datoss

Namespace Poyecto_de_3er_semestre
    Friend Class StackDinamic
        Private Primero As NodosDinamic = New NodosDinamic()

        Public Sub New()
            Primero = Nothing
        End Sub

        Public Sub insertarNodo()
            Dim Nuevo As NodosDinamic = New NodosDinamic()
            Console.Write("Ingrese el dato que contendrá el nuevo Nodo:")
            Nuevo.Tods = Integer.Parse(Console.ReadLine())

            Nuevo.Sig = Primero
            Primero = Nuevo

            Console.WriteLine(vbLf & " Nodo ingresado" & vbLf & vbLf)
        End Sub

        Public Sub desplegarPila()
            Dim Actual As NodosDinamic = New NodosDinamic()
            Actual = Primero

            If Primero IsNot Nothing Then
                While Actual IsNot Nothing
                    Console.WriteLine(" " & Actual.Tods)
                    Actual = Actual.Sig
                End While
            Else
                Console.WriteLine(vbLf & " La pila se encuentra vacía" & vbLf & vbLf)
            End If
        End Sub
    End Class
End Namespace

Namespace estructura_de_datoss
    Friend Class NodosDinamic
        Private dato As Integer
        Private siguiente As NodosDinamic

        Public Property Tods() As Integer
            Get
                Return dato
            End Get
            Set(value As Integer)
                dato = value
            End Set
        End Property

        Public Property Sig() As NodosDinamic
            Get
                Return siguiente
            End Get
            Set(value As NodosDinamic)
                siguiente = value
            End Set
        End Property
    End Class
End Namespace

