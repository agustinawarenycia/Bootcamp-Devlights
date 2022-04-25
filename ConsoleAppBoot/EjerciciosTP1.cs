//1.Dado un valor, devolver un mensaje que diga “El valor es mayor que 100”
//sólo cuando se cumpla dicha condición.

Console.WriteLine("Ingrese un numero"); //Escribe en la consola lo que le pasemos
var num1 = Convert.ToInt32(Console.ReadLine());

if (num1 > 100)
    Console.WriteLine("El valor es mayor que 100");

//************************************************************************************************************

//2.Pedir un número entero por teclado y calcular si es par o impar.


Console.WriteLine("Ingrese un numero"); //Escribe en la consola lo que le pasemos
var num2 = Convert.ToInt32(Console.ReadLine());

if ((num2 % 2) == 0)
{ //Operador % que nos devuelve el resto de la división
    Console.WriteLine("El numero ingresado es par");
}
else
    Console.WriteLine("El numero ingresado es impar");

//**********************************************************************************************************************
//3.Teniendo un valor entero, verificar si se cumple o no que ese valor es el doble
//de un impar. Por ejemplo, 14 cumple con esta condición.

Console.WriteLine("Ingrese un numero"); //Escribe en la consola lo que le pasemos
var num3 = Convert.ToInt32(Console.ReadLine());
var num4 = num3 / 2;
if ((num4 % 2) == 0)
{ //Operador % que nos devuelve el resto de la división
    Console.WriteLine("El numero ingresado no es doble de un impar");
}
else Console.WriteLine("El numero ingresado es doble de un impar");


//**********************************************************************************************************************
//4.Dada un número del 1 al 10, devolver su “versión” en números romanos.

var numRomanoz = 1;
do
{
    Console.WriteLine("Ingrese un numero del 1 al 10"); //Escribe en la consola lo que le pasemos
    numRomanoz = Convert.ToInt32(Console.ReadLine());
    switch (numRomanoz)
    {
        case 1:
            Console.WriteLine("El valor en numeros romanos es: I");
            break;
        case 2:
            Console.WriteLine("El valor en numeros romanos es: II");
            break;
        case 3:
            Console.WriteLine("El valor en numeros romanos es: III");
            break;
        case 4:
            Console.WriteLine("El valor en numeros romanos es: IV");
            break;
        case 5:
            Console.WriteLine("El valor en numeros romanos es: V");
            break;
        case 6:
            Console.WriteLine("El valor en numeros romanos es: VI");
            break;
        case 7:
            Console.WriteLine("El valor en numeros romanos es: VII");
            break;
        case 8:
            Console.WriteLine("El valor en numeros romanos es: VIII");
            break;
        case 9:
            Console.WriteLine("El valor en numeros romanos es: IX");
            break;
        case 10:
            Console.WriteLine("El valor en numeros romanos es: X");
            break;
        default:
            Console.WriteLine("No ha ingresado un numero entre el 1 y el 10");
            break;

    }

} while (numRomanoz > 0 && numRomanoz >= 10);

//**********************************************************************************************************************
//5.Leer el nombre y las edades de dos personas y devolver el nombre del
//menor. En caso de que tengan la misma edad también debe indicarse.
//Devolver también la diferencia de edad en caso de corresponder.


Console.WriteLine("Ingrese el nombre de la primer persona");
var nombre1 = Console.ReadLine();

Console.WriteLine("Ingrese la edad de la primer persona");
var edad1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el nombre de la segunda persona");
var nombre2 = Console.ReadLine();

Console.WriteLine("Ingrese la edad de la primer persona");
var edad2 = Convert.ToInt32(Console.ReadLine());

if (edad1 > edad2)
{
    Console.WriteLine($"La persona menor es {nombre2}");
    int diferencia = edad1 - edad2;
    Console.WriteLine($"La diferencia es de {diferencia}");
}
else
{
    if (edad1 < edad2)
    {
        Console.WriteLine($"La persona menor es {nombre1}");
        int diferencia = edad2 - edad1;
        Console.WriteLine($"La diferencia es de {diferencia}");
    }
    else
    {
        Console.WriteLine($"{nombre1} tiene la misma edad que {nombre2} y no tienen una diferencia de edad");
    }
}

//***************************************************************************************************************************************

//6.Escribir un programa que calcule el tipo de un triángulo conociendo la
//longitud de sus 3 lados. También que calcule su perímetro y su área.

Console.WriteLine("Ingrese la base");
var baseT = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese la longitud del primer lado");
var lado1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese la longitud del segundo lado");
var lado2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese la altura");
var altura = Convert.ToInt32(Console.ReadLine());

if (baseT == lado1 && lado1 == lado2)
{
    Console.WriteLine("Es un equilatero");
}
else if (lado2 == lado1)
{
    Console.WriteLine("Es isoseles");
}
else
{
    Console.WriteLine("Es un escaleno");
}

var area = (baseT + altura) / 2;
var perimetro = (baseT + lado1 + lado2);

Console.WriteLine($"El area del triangulo es {area}");
Console.WriteLine($"El perimetro del triangulo es {perimetro}");

//***************************************************************************************************************************************************
//7.Desarrolle un programa que calcule el desglose de una cantidad dada, en
//billetes y monedas tal que se minimice la cantidad de monedas y billetes.
//Considere las denominaciones $1000, $500, $100, $50, $20, $10, $5, $2, $1,
//donde los últimos tres son monedas. (Por ejemplo, para $1,723 se debe
//imprimir: “1 billete de $1000, 1 billete de $500, 1 billete de $200, 1 billete de
//$20, 1 moneda de $2, 1 moneda de $1). Obviar los signos de billete ($) y
//tratar todos los valores como números, para los cálculos.


Console.WriteLine("Ingrese la cantidad de dinero");
var dinero = Convert.ToInt32(Console.ReadLine());

if (dinero >= 1000)
{
    double total1 = dinero / 1000;
    Console.WriteLine("La cantiadad de billetes de $1000 es: " + Math.Truncate(total1));
}
if (dinero >= 500)
{
    double total1 = dinero / 500;
    Console.WriteLine("La cantiadad de billetes de $500 es: " + Math.Truncate(total1));
}
if (dinero >= 200)
{
    double total1 = dinero / 200;
    Console.WriteLine("La cantiadad de billetes de $200 es: " + Math.Truncate(total1));
}
if (dinero >= 20)
{
    double total1 = dinero / 20;
    Console.WriteLine("La cantiadad de billetes de $20 es: " + Math.Truncate(total1));
}
if (dinero >= 2)
{
    double total1 = dinero / 2;
    Console.WriteLine("La cantiadad de monedad de $2 es: " + Math.Truncate(total1));
}

Console.WriteLine($"La cantiadad de monedads de $1 es: {dinero}");

//NOTA: Como caso alternativo se puede hacer un array y recorrerlo haciendo las operaciones

//******************************************************************************************************************************************
//8.Pide un número N, y muestra todos los números del 1 al N.


Console.WriteLine("Ingrese un numero");
var numero = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i <= numero)
{
    Console.WriteLine(i);
    i++;
}

//******************************************************************************************************************************************
//9.Pedir 15 números y escribir la suma total.
int x = 0;
int suma;
//Solucion 1
do
{
    Console.WriteLine("Ingrese un numero");
    var numeross = Convert.ToInt32(Console.ReadLine());
    suma = +numero;
    x++;

} while (x <= 15);

Console.WriteLine(suma);

//Solucion 2
for (int i2 = 0; i2 < 15; i2++)
{
    Console.WriteLine("Ingrese un numero");
    var numerosss = Convert.ToInt32(Console.ReadLine());
    suma = +numerosss;

}
Console.WriteLine(suma);

//******************************************************************************************************************************************
//10.Pide 5 números e indica si alguno es múltiplo de 3.

int numeros, multiplo;

for (int i1 = 0; i1 < 5; i1++)
{
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Ingrese un numero");
    numeros = Convert.ToInt32(Console.ReadLine());
    multiplo = numeros % 3;
    if (multiplo == 0)
    {
        Console.WriteLine($"El numero {numeros} es multiplo de 3");
    }
    else
        Console.WriteLine($"El numero {numeros} no es multiplo de 3");
}
//******************************************************************************************************************************************

//11.Escriba un programa que solicite una contraseña (el texto de la contraseña
//no es importante) y la vuelva a solicitar hasta que las dos contraseñas
//coincidan.
String contra1, contra2;
do
{
    Console.Write("***************************************");
    Console.Write("Ingrese una contraseña");
    contra1 = Console.ReadLine();
    Console.Write("Ingrese de nuevo su contraseña");
    contra2 = Console.ReadLine();
    if (contra1.Equals(contra2))
    {
        Console.Write("Contraseñas iguales!");
    }
    else
        Console.Write("Contraseñas diferentes, ingrese nuevamente");
} while (contra1 != contra2);

//******************************************************************************************************************************************
//12.Mismo que el anterior pero con un límite de tres peticiones. Luego de las tres
//peticiones no debe solicitar más la contraseña y terminar el programa.

String contras1, contras2;
int cont = 0;
do
{
    Console.Write("*************************************** \n");
    Console.Write("Ingrese una contraseña\n");
    contras1 = Console.ReadLine();
    Console.Write("Ingrese de nuevo su contraseña\n");
    contras2 = Console.ReadLine();
    if (contra1.Equals(contras2))
    {
        Console.Write("Contraseñas iguales!\n");
    }
    else
        if (cont <= 3)
        Console.Write("Contraseñas diferentes, ingrese nuevamente\n");
    cont++;

} while (contras1 != contras2 && cont <= 3);

//******************************************************************************************************************************************
//13.Proponer al usuario que adivine un número a base de intentarlo.
//int numero;


Random random = new Random();
int numeroRandom = random.Next(1, 10);

do
{
    Console.Write("Ingrese un numero del 1 al 10 \n");
    numero = Convert.ToInt32(Console.ReadLine());
    if (numeroRandom == numero)
    {
        Console.WriteLine("Felicidades, haz acertado!!!");
    }
    else
        Console.WriteLine("No son los mismo, suerte para la proxima");
} while (numeroRandom == numero);


//******************************************************************************************************************************************
//14.Modificar el programa anterior para que vaya dando pistas del tipo «mayor» o
//«menor».

int numero1;

Random random1 = new Random();
int numeroRandom1 = random.Next(1, 10);

do
{
    Console.Write("Ingrese un numero del 1 al 10 \n");
    numero1 = Convert.ToInt32(Console.ReadLine());
    if (numeroRandom1 == numero1)
    {
        Console.WriteLine("Felicidades, haz acertado!!!");
    }
    else
        if (numeroRandom1 < numero1)
    {
        Console.Write("El numero es menor al que ingresaste");
    }
    else
        Console.WriteLine("El numero es mayor al que ingresaste");

} while (numeroRandom1 == numero1);

//******************************************************************************************************************************************
//15.Crea un programa que permita sumar N números. El usuario decide cuándo
//termina de introducir números al indicar la palabra ‘fin’.
var ingreso="";
int suma1 = 0, total = 0;
String fin = "fin";
do
{
    Console.WriteLine("Ingresa un numero o ingrese 'fin' para salir \n");
    ingreso = Console.ReadLine();
    Int32.TryParse(ingreso, out suma);
    suma1 = Int32.Parse(ingreso);
    total = total + suma1;
    if (suma1 != 0)
    {
        Console.Write($"La suma hasta ahora es {total} \n");
    }
} while (!ingreso.Equals("fin"));