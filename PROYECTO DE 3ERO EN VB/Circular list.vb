Namespace PROYECTO_DE_3ERO_EN_VB
    Friend Class Circular_list
        Private primero As New Nodo()
        Private ultimo As New Nodo()

        Public Sub New()
            primero = Nothing
            ultimo = Nothing

        End Sub

        Public Sub insertarNodo()
            Dim nuevo As New Nodo()
            Console.WriteLine("Ingrese el valor del nuevo valor:")
            nuevo.datos = Integer.Parse(Console.ReadLine())

            If primero Is Nothing Then
                primero = nuevo
                primero.Siguiente = primero
                ultimo = primero
            Else
                ultimo.Siguiente = nuevo
                nuevo.Siguiente = primero
                ultimo = nuevo
            End If
            Console.WriteLine(vbLf & "Nodo ingresado con exito" & vbLf & vbLf)
        End Sub
        Public Sub desplegarlista()
            Dim actual As New Nodo()
            actual = primero
            If actual IsNot Nothing Then
                ' recorrer la lista
                Do
                    Console.WriteLine(" " & actual.datos)
                    actual = actual.Siguiente
                Loop While actual IsNot primero
            Else
                Console.WriteLine(vbLf & " La lista se encuentra vacía" & vbLf)
            End If
        End Sub
    End Class

    Class Nodo
        Private Dato As Integer
        Private SiguienteNodo As Nodo

        Public Property datos() As Integer
            Get
                Return Dato
            End Get
            Set(value As Integer)
                Dato = value
            End Set
        End Property


        Public Property Siguiente() As Nodo
            Get
                Return SiguienteNodo
            End Get
            Set(value As Nodo)
                SiguienteNodo = value
            End Set
        End Property
    End Class

End Namespace