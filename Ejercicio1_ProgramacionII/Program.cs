////Realizar un programa en C# o el lenguaje que estudió en 1er año que resuelva el siguiente programa:


//Ingresar tres enteros válidos que representan una fecha: dd, mm, aaaa, se pide obtener y mostrar la fecha del día siguiente en formato narrado. Por ejemplo, se ingresa 15, 6, 1995 y se debe mostrar 16 de Junio de 1995

//NO se puede utilizar las propiedades de tipo de dato DateTime

//Entrega hasta donde se llegue, sólo diagnóstico

using System;

int dia=0;
int mes = 0;
int anio = 0;
bool result= true;

{

   

    do
    {

        Console.Write("Ingrese el día: ");
      result = int.TryParse(Console.ReadLine(), out dia);

        if (!result)
        {
            Console.WriteLine("Dato no valido, reintente");
           

        }
    } while (!(dia >= 1 && dia <= 31));

    do
    {
        Console.Write("Ingrese el mes: ");
        result = int.TryParse(Console.ReadLine(), out mes);

        if (!result)
        {
            Console.WriteLine("Dato no valido, reintente");

        }

    } while (!(mes >= 1 && mes <= 12));

    do
    {
        Console.Write("Ingrese el año: ");
        result = int.TryParse(Console.ReadLine(), out anio);
        if (!result)
        {
            Console.WriteLine("Dato no valido, reintente");

        }

    } while (!(anio >= 1900 && anio < 2030));
    Console.WriteLine();




    bool añoBisiesto = (anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0;

    int[] diasDelMes = { 0, 31, añoBisiesto ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


    if (dia < 1 || dia > diasDelMes[mes])
    {
        Console.WriteLine("La fecha ingresada no es válida.");
        return;
    }


    string nombreMes = "";
    switch (mes)
    {
        case 1:
            nombreMes = "Enero";
            break;

        case 2:
            nombreMes = "Febrero";
        
            break;

        case 3:
            nombreMes = "Marzo";
            break;

        case 4:
            nombreMes = "Abril";

            break;

        case 5:
            nombreMes = "Mayo";
            break;

        case 6:
            nombreMes = "Junio";
            break;

        case 7:
            nombreMes = "Julio";
            break;

        case 8:
            nombreMes = "Agosto";
            break;

        case 9:
            nombreMes = "Septiembre";
            break;

        case 10:
            nombreMes = "Octubre";
            break;

        case 11:
            nombreMes = "Noviembre";
            break;

        case 12:
            nombreMes = "Diciembre";
            break;

    }
    if (añoBisiesto)
    {
        Console.WriteLine("Es año bisiesto");
    }
    Console.WriteLine($"{dia} de {nombreMes} de {anio}");


}



