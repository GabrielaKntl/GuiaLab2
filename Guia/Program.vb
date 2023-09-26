Imports System

Module Program
    Sub Main()
        Ejercicio1()
        Ejercicio2()
        Ejercicio3()
        Ejercicio4()
    End Sub
    Sub Ejercicio1()
        ' Pedir al usuario  el tiempo en horas y minutos

        Dim Km As Double = 42195

        Console.Write("Ingrese las horas: ")
        Dim Horas As Double = CDbl(Console.ReadLine())

        Console.Write("Ingrese los minutos: ")
        Dim Minutos As Double = CDbl(Console.ReadLine())

        ' Calcular el tiempo total en horas
        Dim tiempoTotalHoras As Double = Horas + Minutos / 60

        ' Calcular la velocidad media en las diferentes unidades
        Dim velocidadKmPorH As Double = Km / tiempoTotalHoras
        Dim velocidadKmPorM As Double = Km / (tiempoTotalHoras * 60)
        Dim velocidadKmPorS As Double = Km / (tiempoTotalHoras * 3600)
        Dim velocidadMPorM As Double = Km * 1000 / (tiempoTotalHoras * 60)
        Dim velocidadMPorS As Double = Km * 1000 / (tiempoTotalHoras * 3600)

        ' Mostrar los resultados 
        Console.WriteLine("Velocidad  en Km/h: " & velocidadKmPorH)
        Console.WriteLine("Velocidad  en Km/min: " & velocidadKmPorM)
        Console.WriteLine("Velocidad  en Km/s: " & velocidadKmPorS)
        Console.WriteLine("Velocidad  en m/min: " & velocidadMPorM)
        Console.WriteLine("Velocidad  en m/s: " & velocidadMPorS)

        Console.ReadLine()
    End Sub
    Sub Ejercicio2()
        ' Pedir al usuario el promedio mensual de infracciones
        Console.Write("Ingrese el promedio mensual de infracciones: ")
        Dim proMensual As Integer = CInt(Console.ReadLine())

        ' Calcular el promedio diario de infracciones para cada jornada
        Dim proMatutino As Double = proMensual * 0.2 / 30
        Dim proTarde As Double = proMensual * 0.35 / 30
        Dim proNocturno As Double = proMensual * 0.45 / 30

        ' Mostrar los resultados en la consola
        Console.WriteLine("Promedio diario matutino de infracciones: " & proMatutino)
        Console.WriteLine("Promedio diario en la tarde de infracciones: " & proTarde)
        Console.WriteLine("Promedio diario nocturno de infracciones: " & proNocturno)

        Console.ReadLine()
    End Sub
    Sub Ejercicio3()
        ' Pedir al usuario los dos números enteros
        Console.Write("Ingrese el primer número entero: ")
        Dim num1 As Integer = CInt(Console.ReadLine())

        Console.Write("Ingrese el segundo número entero: ")
        Dim num2 As Integer = CInt(Console.ReadLine())

        ' Verificar si num1 es divisor de num2
        If num2 Mod num1 = 0 Then
            Console.WriteLine(num1 & " es divisor de " & num2)
        Else
            Console.WriteLine(num1 & " no es divisor de " & num2)
        End If

        Console.ReadLine()
    End Sub
    Sub Ejercicio4()
        ' Pedir al usuario los tres números enteros
        Console.Write("Ingrese el primer número entero: ")
        Dim num1 As Integer = CInt(Console.ReadLine())

        Console.Write("Ingrese el segundo número entero: ")
        Dim num2 As Integer = CInt(Console.ReadLine())

        Console.Write("Ingrese el tercer número entero: ")
        Dim num3 As Integer = CInt(Console.ReadLine())

        ' Encontrar el mayor, medio y menor sin importar el orden de entrada
        Dim mayor As Integer
        Dim medio As Integer
        Dim menor As Integer

        If num1 >= num2 AndAlso num1 >= num3 Then
            mayor = num1
            If num2 >= num3 Then
                medio = num2
                menor = num3
            Else
                medio = num3
                menor = num2
            End If
        ElseIf num2 >= num1 AndAlso num2 >= num3 Then
            mayor = num2
            If num1 >= num3 Then
                medio = num1
                menor = num3
            Else
                medio = num3
                menor = num1
            End If
        Else
            mayor = num3
            If num1 >= num2 Then
                medio = num1
                menor = num2
            Else
                medio = num2
                menor = num1
            End If
        End If

        ' Mostrar los resultados en la consola
        Console.WriteLine("El mayor número es: " & mayor)
        Console.WriteLine("El número medio es: " & medio)
        Console.WriteLine("El menor número es: " & menor)

        Console.ReadLine()
    End Sub
End Module
