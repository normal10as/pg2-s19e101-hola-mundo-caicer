Imports System

Module Program
    Sub Main()
        Dim palabra As String
        Console.WriteLine("escribir una palabra ")
        palabra = Console.ReadLine()
        ' cadena a buscar
        Dim caracter1 As String = "a"
        Dim caracter2 As String = "o"
        Dim posicion As Byte = 1
        'Console.WriteLine("Buscar {0} en {1} empezando en la posición {2}", SearchChar, SearchString, startPosition)
        Console.WriteLine("Buscar {0} en {1} empezando en la posición {2}", caracter1, palabra, posicion)
        Console.WriteLine("Buscar {0} en {1} empezando en la posición {2}", caracter2, palabra, posicion)
        'Console.WriteLine(posicion & palabra & caracter1 & caracter2) ', CompareMethod.Binary)

    End Sub
End Module
