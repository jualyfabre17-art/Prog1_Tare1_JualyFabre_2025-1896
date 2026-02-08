// Tarea 1- Jualy Fabre 2025-1896//

//1.Declarar variable de los diferentes tipos, asignarles valor e imprimir el valor. 
string name = "Jualy";
int number = 98;
double distance = 2.23;
bool response = false;
float path = 5.01f;

Console.WriteLine("1.Declarar variable de los diferentes tipos, asignarles valor e imprimir el valor.");
Console.WriteLine("Nombre: " + name + " Numero: " + number +
    " Distancia: " + distance + "m Respoesta: "
    + response + " Camino: " + path + "\n");
/* 2.Buscar cómo se declara una constante en C# e imprimir el valor. Probar de cambiar su valor luego y
ver que es lo que pasa.*/
Console.WriteLine("2.CONSTANTES: Se usa para valores que conoces antes de ejecutar el programa\r" +
    "\n y que nunca, bajo ninguna circunstancia, van a cambiar como el valor de PI o los meses del año\n");
 /*Se usa para valores que conoces antes de ejecutar el programa
 y que nunca, bajo ninguna circunstancia, van a cambiar como el valor de PI o los meses del año.
 */
const int hoursOfDay = 24;
const string endOfDay = "Llego el final del dia";
Console.WriteLine("Horas del dia: " + hoursOfDay);
Console.WriteLine("Mensaje: " + endOfDay + "\n");
/*
 const int hoursOfDay = 24;
 const string endOfDay = "Llego el final del dia";
 hoursOfDay = 48;
 endOfDay= "Buenos Dias";

-Esto daria como resultado un error ya que a una constante se le asigna el valor 
 al momento de declararse y este no puede ser modificado deespues.
 */

//3.Declara un entero, incrementarlo, decrementarlo, hacer operaciones con el. 


int numberOfStudens = 60;

Console.WriteLine("3.Declara un entero, incrementarlo, decrementarlo, hacer operaciones con el.");
numberOfStudens++;
Console.WriteLine("numero incrementado "+ numberOfStudens);

numberOfStudens--;
Console.WriteLine("numero decrementado" + numberOfStudens);

int addition = numberOfStudens + 10;
int subtraction = numberOfStudens - 2;
int multiplication = numberOfStudens * 3;
Console.WriteLine("Resultado de la suma: " + addition);
Console.WriteLine("Resultado de la resta: " + subtraction);
Console.WriteLine("Resultado de la multiplicacion: " + multiplication + "\n");

//4.Declarar un float con valor=10152466.25. Declara un byte que es igual a 5 + el float.

float value = 10152466.25f;
Console.WriteLine("4.Declarar un float con valor=10152466.25. Declara un byte que es igual a 5 + el float");
byte myByte = (byte)(5 + value);
Console.WriteLine("Byte: " + myByte + "\n");

//5.Adjuntar comentario de una y de varias líneas un su código.  Imprimir la fecha y hora del sistema. 

DateTime date = DateTime.Now;
Console.WriteLine("5.Adjuntar comentario de una y de varias líneas un su código.  Imprimir la fecha y hora del sistema.");
Console.WriteLine("Fecha: " + date);