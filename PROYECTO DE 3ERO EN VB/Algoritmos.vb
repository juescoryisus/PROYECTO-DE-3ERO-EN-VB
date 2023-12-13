Imports System
Imports PROYECTO_DE_3ERO_EN_VB.PROYECTO_DE_3ERO_EN_VB

Namespace Poyecto_de_3er_semestre
    Friend Class Algoritmos
        Public Shared Sub Ordenamiento()
            Console.WriteLine("===============Entraste a los Algoritmos de ordenamiento=====================")
            Dim Opciones As Integer
            Console.WriteLine("============Menu de los Algoritmos=============")
            Console.WriteLine(" (1) BinaryTreeSort")
            Console.WriteLine(" (2) BubbleSort")
            Console.WriteLine(" (3) BucketSort")
            Console.WriteLine(" (4) CocktailSort")
            Console.WriteLine(" (5) CombSort")
            Console.WriteLine(" (6) CountingSort")
            Console.WriteLine(" (7) GnomeSort")
            Console.WriteLine(" (8) Heapsort")
            Console.WriteLine(" (9) InsertionSort")
            Console.WriteLine(" (10) Mergesort")
            Console.WriteLine(" (11) PigeonholeSort")
            Console.WriteLine(" (12) Quicksort")
            Console.WriteLine(" (13) RadixSort")
            Console.WriteLine(" (14) SelectionSort")
            Console.WriteLine(" (15) ShellSort")
            Console.WriteLine(" (16) SmoothSort")
            Console.WriteLine("(17) Regresar")
            Console.WriteLine("Eligió La Opción:")
            Opciones = Convert.ToByte(Console.ReadLine())

            Select Case Opciones
                Case 1
                    Console.WriteLine("==================BinaryTreeSort======================")
                    Binarytreesort.BINARYTREESORT()
                    Exit Select
                Case 2
                    Console.WriteLine("==================BubbleSort======================")
                    Bubblesort.BUBBLE()
                    Exit Select
                Case 3
                    Console.WriteLine("==================BucketSort======================")
                    Bucketsort.BUCKET()
                    Exit Select
                Case 4
                    Console.WriteLine("==================CocktailSort======================")
                    Cocktailsort.COCK()
                    Exit Select
                Case 5
                    Console.WriteLine("==================CombSort======================")
                    Combsort.COMB()
                    Exit Select
                Case 6
                    Console.WriteLine("==================CountingSort======================")
                    Cou.Couting()
                    Exit Select
                Case 7
                    Console.WriteLine("==================GnomeSort======================")
                    Gnomesort.Gnome()
                    Exit Select
                Case 8
                    Console.WriteLine("==================HeapSort======================")
                    Heapsort.Heap()
                    Exit Select
                Case 9
                    Console.WriteLine("==================InsertionSort======================")
                    Insertionsort.Inser()
                    Exit Select
                Case 10
                    Console.WriteLine("==================Mergesort======================")
                    Margesort.Marge()
                    Exit Select
                Case 11
                    Console.WriteLine("==================PigeonholeSort======================")
                    Pigeonhole.Pinge()
                    Exit Select
                Case 12
                    Console.WriteLine("==================QuickSort======================")
                    Quicksort.Quick()
                    Exit Select
                Case 13
                    Console.WriteLine("==================RadixSort======================")
                    Radixsort.Radix()
                    Exit Select
                Case 14
                    Console.WriteLine("==================SelectionSort======================")
                    Selectionsort.Selection()
                    Exit Select
                Case 15
                    Console.WriteLine("==================ArrayHalperSort======================")
                    ArrayHalper.Array()
                    Exit Select
                Case 16
                    Console.WriteLine("==================ShellSort======================")
                    Shellsort.Shell()
                    Exit Select
                Case 17
                    Console.WriteLine("==================SmoothSort======================")
                    Smooth.Smoot()
                    Exit Select
                Case 18
                    Program.Main()
                    Exit Select
            End Select
        End Sub

        Private Shared Sub PrintArray(array As Integer())
            For Each num In array
                Console.Write(num & " ")
            Next
            Console.WriteLine()
        End Sub

        Private Shared Sub DisplayArray(arr As Integer())
            For Each num In arr
                Console.Write(num & " ")
            Next

            Console.WriteLine()
        End Sub
    End Class
End Namespace
