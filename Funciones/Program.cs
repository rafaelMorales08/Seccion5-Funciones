//ejemplo 1: funciones simples.

using System.Reflection.Metadata;

string ObtenerNombre()
{

    return "Rafael";

}


var niNombre = ObtenerNombre(); 

var miNombre2 = ObtenerNombre();


//funcion que no retorna

void ImprimirFechaYhoraActual()
{
    var fechayHora = DateTime.Now;
    var mensaje = $"hoy es {fechayHora.ToString("yyyy-dd-MM")}";
    Console.WriteLine(mensaje);
}

ImprimirFechaYhoraActual();



//parametros

int duplicar (int valor) {

    return valor * 2;
}

var doblede5 = duplicar(valor: 2);

int Sumar(int su1 , int su2)
{
    return su1 + su2;
}

var SUMA = Sumar(su1: 1, su2: 2);


//arreglo con parametros

 double Promedio (int [] numeros)
{
    var suma = 0.0;

    foreach(var numero in numeros)
    {
        suma += numero;
    }

    return suma/ numeros.Length;
}

var promedio1 = Promedio(new int [] {7,3,4,4,6});
Console.WriteLine(promedio1);


double promedio2(params int[] numeros)
{
    var suma = 0.0;

    foreach (var numero in numeros)
    {
        suma += numero;
    }

    return suma / numeros.Length;

}

var Promedio2 = promedio2(2,3,4,5);
Console.WriteLine(Promedio2);



//parametros con ref

int cantidad = 5;

void DuplicarConRef (ref int n)
{
    n *= 2;
    Console.WriteLine("El valor de la funcion es: " + n);

}

DuplicarConRef(ref cantidad);
Console.WriteLine("El valor fuera de la funcion es " + cantidad);


//parametros out - debe ser tratado como no inicializado

int cantidad2;

void DuplicarConOut(int operando ,out int n)
{
    operando *= 2; // n = n*2
    n = operando;
    Console.WriteLine("El valor de la funcion es: " + n);

}

DuplicarConOut(3, out cantidad2);
Console.WriteLine("El valor fuera de la funcion es " + cantidad);


//ejemplo 2 de out

int cantidad3;

void DuplicaryTriplicar (int operando ,out int doble, out int triple)
{

    doble = operando * 2;
    triple = operando * 3;
    
}

int doble, triple;

DuplicaryTriplicar(3, out doble, out triple);
Console.WriteLine("doble: " + doble);
Console.WriteLine("triple: " + triple);


//tuplas - permite escribir un codigo mas legible



(int edad, int mes, string nombre) tupla = (99, 45, "flufppi");

Console.WriteLine(tupla);
Console.WriteLine(tupla.edad);
Console.WriteLine(tupla.mes);
Console.WriteLine(tupla.nombre);

if (tupla.nombre == "fluppi")
{
    Console.WriteLine("es igual");
}


//ejemplo 2 : devolviendo varios valores de una funcion

(int duplo, int triplo) dupTri (int valor)
{
    return (valor * 2, valor * 3);
}

var cantidad4 = 10;
var resultado = dupTri(cantidad4);
Console.WriteLine(cantidad4);
Console.WriteLine($"su duplo es: {resultado.duplo}");
Console.WriteLine($"su triplo es: {resultado.triplo}");

//funciones locales
void sumasImprimir()
{
    var numero = 3;
    imprimir(numero);
    numero++;
    imprimir(numero);

}
void imprimir(int numero)
{
    Console.WriteLine("imprimir valor: " + numero);
}

sumasImprimir();


//expreciones lambda

int sumar(int a, int b )=> a + b;
var resultado7 = sumar(2,4);
Console.WriteLine(resultado7);


//accion - funcion que no retorna nada

Action imprimirMensaje;

void ImprimirFecha()
{
    Console.WriteLine(DateTime.Now.ToString());
}

void ImprimirMiNombre()
{
    Console.WriteLine("Rafa");
}


imprimirMensaje = ImprimirFecha;
imprimirMensaje();
imprimirMensaje = ImprimirMiNombre;
imprimirMensaje();


//funk
Func<String> retormaStrig;

string ObtenerFecha()
{
    return DateTime.Now.ToString();
}

retormaStrig= ObtenerFecha;
var resultado8 = retormaStrig();
Console.WriteLine(resultado8);
