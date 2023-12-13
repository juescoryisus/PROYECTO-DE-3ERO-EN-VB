Friend Class CirularDoublyLinkedList
    ' Lista circular doble --- Cabeza y cual es el final
    Private primero As New NodoCDL()
    Private ultimo As New NodoCDL()

    Public Sub New()
        primero = Nothing
        ultimo = Nothing
    End Sub

    ' Lista circular doble 
    ' primero = null    ultimo = null 
    Public Sub insertarNodo()
        Dim nuevo As New NodoCDL()
        Console.Write("Ingrese el dato del nuevo Nodo:")
        nuevo.d = Integer.Parse(Console.ReadLine())
        If primero Is Nothing Then
            primero = nuevo
            ultimo = nuevo
            primero.siguiente = primero
            primero.atras = ultimo
        Else
            ultimo.siguiente = nuevo
            nuevo.atras = ultimo
            nuevo.siguiente = primero
            ultimo = nuevo
            primero.atras = ultimo
        End If

        Console.WriteLine(" " & vbLf & " Nuevo nodo ingresado con éxito:")
    End Sub

    Public Sub desplegarlistaPU()
        Dim actual As New NodoCDL()
        actual = primero
        If actual IsNot Nothing Then
            Do
                Console.WriteLine(" " & actual.d)
                actual = actual.siguiente
            Loop While actual IsNot primero
        Else
            Console.WriteLine(vbLf & " La lista se encuentra vacía" & vbLf)
        End If
    End Sub

    Public Sub desplegarlistasUP()
        Dim actual As New NodoCDL()
        actual = ultimo
        If actual IsNot Nothing Then
            Do
                Console.WriteLine(" " & actual.d)
                actual = actual.atras
            Loop While actual IsNot ultimo
        Else
            Console.WriteLine(vbLf & " La lista se encuentra vacía" & vbLf)
        End If
    End Sub
End Class

Class NodoCDL
    Private Dato As Integer
    Private SiguienteNodo As NodoCDL
    Private AtrasNodo As NodoCDL

    Public Property d() As Integer
        Get
            Return Dato
        End Get
        Set(value As Integer)
            Dato = value
        End Set
    End Property

    Public Property siguiente() As NodoCDL
        Get
            Return SiguienteNodo
        End Get
        Set(value As NodoCDL)
            SiguienteNodo = value
        End Set
    End Property

    Public Property atras() As NodoCDL
        Get
            Return AtrasNodo
        End Get
        Set(value As NodoCDL)
            AtrasNodo = value
        End Set
    End Property
End Class