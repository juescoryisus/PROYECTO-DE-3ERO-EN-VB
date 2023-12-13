Imports System

Namespace Poyecto_de_3er_semestre
    Friend Class NodeAlgoritmos
        Public Data As Integer
        Public Left, Right As NodeAlgoritmos

        Public Sub New(data As Integer)
            Me.Data = data
            Left = Nothing
            Right = Nothing
        End Sub
    End Class
End Namespace