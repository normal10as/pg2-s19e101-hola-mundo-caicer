Imports System

Module Program
    Sub Main(args As String())
        Dim palabra, palabra2 As String
        Console.WriteLine("ingrese las palabras")
        palabra = Console.ReadLine
        palabra2 = "Aunque la cadena sea de oro, sirve para lo mismo."

        Console.WriteLine("Reemplazar en '{0}' la o por la i", palabra)
        Console.WriteLine(Replace(palabra, "o", "i"))
        Console.WriteLine("Hello World!")
    End Sub
End Module
