Imports PROYECTO_DE_3ERO_EN_VB.PROYECTO_DE_3ERO_EN_VB

Friend Class PioridadQueue
    Public Sub observar()
        Dim cola As New Queue()

        While True
            Console.WriteLine("1. Encolar")
            Console.WriteLine("2. Desencolar")
            Console.WriteLine("3. Mostrar elementos")
            Console.WriteLine("4. Regresar al Menú de Estructuras")

            Console.Write("Seleccione una opción: ")
            Dim opcion As String = Console.ReadLine()

            Select Case opcion
                Case "1"
                    Console.Write("Ingrese el dato a encolar: ")
                    Dim datoEncolar As String = Console.ReadLine()
                    cola.Enqueue(datoEncolar)
                    Console.WriteLine("Dato encolado: " & datoEncolar)

                Case "2"
                    If cola.Count > 0 Then
                        Dim datoDesencolar As Object = cola.Dequeue()
                        Console.WriteLine("Dato desencolado: " & datoDesencolar)
                    Else
                        Console.WriteLine("La cola está vacía.")
                    End If

                Case "3"
                    Console.WriteLine("Elementos en la cola:")
                    For Each elemento In cola
                        Console.WriteLine(elemento)
                    Next

                Case "4"
                    Program.Main()

                Case Else
                    Console.WriteLine("Opción no válida")
            End Select

            Console.WriteLine() ' Separador para mejor legibilidad
        End While
    End Sub
End Class