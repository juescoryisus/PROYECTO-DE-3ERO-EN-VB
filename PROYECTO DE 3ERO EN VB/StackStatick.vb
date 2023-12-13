Imports System
Imports PROYECTO_DE_3ERO_EN_VB.PROYECTO_DE_3ERO_EN_VB

Namespace Poyecto_de_3er_semestre
    Friend Class StackStatick
        Public Sub ver()
            Console.WriteLine("Ingrese el tamaño de la Pila:")
            Dim tamano As Integer = Integer.Parse(Console.ReadLine())

            Dim miPila As New PilaE(tamano)

            Dim opcion As Integer
            Do
                Console.WriteLine(vbLf & vbLf & vbTab & vbTab & "Pila Estática")
                Console.WriteLine("  1. Insertar un dato")
                Console.WriteLine("  2. Sacar un dato")
                Console.WriteLine("  3. Visualizar Pila")
                Console.WriteLine("  4. Regresar al Menú de Estructuras")
                Console.Write("Seleccione una opción: ")
                opcion = Integer.Parse(Console.ReadLine())

                Select Case opcion
                    Case 1
                        Console.Write("Ingrese el dato a insertar: ")
                        Dim datoInsertar As Integer = Integer.Parse(Console.ReadLine())
                        miPila.Insertar(datoInsertar)
                    Case 2
                        Dim datoSacar As Integer = miPila.Sacar()
                        If datoSacar <> -1 Then
                            Console.WriteLine($"Dato sacado: {datoSacar}")
                        End If
                    Case 3
                        miPila.VerPila()
                    Case 4
                        Program.Main()
                    Case Else
                        Console.WriteLine("Opción no válida.")
                End Select
            Loop While opcion <> 0
        End Sub
    End Class
End Namespace

Class PilaE
    Private tam, tope As Integer
    Private P As Integer()

    Public Sub New(n As Integer)
        tope = 0
        tam = n
        P = New Integer(tam - 1) {}
    End Sub

    Public Sub Insertar(dato As Integer)
        If tope < tam Then
            P(tope) = dato
            tope += 1
            Console.WriteLine("Dato insertado correctamente.")
        Else
            Console.WriteLine("La Pila está llena. No se pueden agregar más elementos.")
        End If
    End Sub

    Public Function Sacar() As Integer
        If tope > 0 Then
            tope -= 1
            Return P(tope)
        Else
            Console.WriteLine("La Pila está vacía. No se pueden sacar más elementos.")
            Return -1 ' Valor indicando que la pila está vacía
        End If
    End Function

    Public Function EstaVaciaPila() As Boolean
        Return tope = 0
    End Function

    Public Function EstaLlenaPila() As Boolean
        Return tope = tam
    End Function

    Public Sub VerPila()
        If tope > 0 Then
            Console.Write("Contenido de la Pila: ")
            For i As Integer = 0 To tope - 1
                Console.Write($"{P(i)} ")
            Next
            Console.WriteLine()
        Else
            Console.WriteLine("La Pila está vacía.")
        End If
    End Sub
End Class
