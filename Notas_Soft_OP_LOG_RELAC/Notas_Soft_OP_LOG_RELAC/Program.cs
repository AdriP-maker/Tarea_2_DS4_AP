// See https://aka.ms/new-console-template for more information//

//Programa para ver resultados de piedra, papel, tijerausando operadores lógicos y relacionales

using Microsoft.VisualBasic;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Vamos a ver como podemos jugar piedra, papel o tijera");
Console.WriteLine("");

int piedra, papel,tijera;
piedra = 5;
papel = 1;
tijera = 3;


// Operadores Relaciones
/*
    == igual a
    != diferente a
    > mayor que
    < menor que
    >= mayor o igual
    <= menor o igual
*/


//Ejemplos de uso de los operadores relaciones

Console.WriteLine("¿Puede papel vencerse a si mismo");
Console.WriteLine("");
bool resultado_empate = papel == papel; // Como se aplica el mismo valor nos va arrojar TRUE
string salidaemparte= $"No, ya que ambos elementos son los mismos, correcto?.\n" + //Se hace uso del tema del video 13 la manipulación de los strings
    $"El resultado es {resultado_empate} , entonces eso lo confirma";

Console.WriteLine(salidaemparte); //Como usamos el almacenamiento de la variable pues solo la imprimimos

Console.WriteLine("");
Console.WriteLine("¿Puede la piedra vencer a la tijera?");
bool resultadomayor = piedra >= tijera;
Console.WriteLine("Veamos el resultado es:"+resultadomayor+" ,entonces piedra gana");

Console.WriteLine("");
Console.WriteLine("¿Puede la tijera vencer a la piedra?");
bool resultadomenor = piedra <= tijera;
Console.WriteLine("Veamos el resultado es:" + resultadomenor + " ,entonces tijera pierde");

Console.WriteLine("");
Console.WriteLine("¿Puede la tijera vencer al papel?");
bool resultadomax = tijera > papel;
Console.WriteLine("Veamos el resultado es:" + resultadomax + " ,entonces tijera gana");

Console.WriteLine("");
Console.WriteLine("¿Puede el papel vencer a la piedra? ");
bool resultadomin = papel < piedra;
Console.WriteLine("Veamos el resultado es:" + resultadomax + " ,entonces piedra pierde");


Console.WriteLine("");
Console.WriteLine("¿Dos piedras son iguales?");
bool resultdistint = piedra != piedra;
Console.WriteLine("Veamos el resultado es:" + resultdistint + " ,entonces dos piedras no pueden ser las mismas ");


//Ejemplos de uso de los operadores lógicos

// Operadores Lógicos
// Operadores Relaciones
/*
    && Operador AND-Devuelve verdadero si ambos operandos son verdaderos.
    || Operador OR-Devuelve verdadero si al menos uno de los operandos es verdadero.
    ! Operador NOT-Invierte el valor booleano del operando.
    ^ Operador XOR-Devuelve verdadero si sólo uno de los operandos es verdadero.
*/


bool piedra1, papel1,tijera1;
piedra1= true; papel1= true; tijera1 = true;
bool tijera2 = false;


Console.WriteLine("");
Console.WriteLine("¿Puede el papel vencer a la piedra? ");
bool resultAnd = papel1 && piedra1;
Console.WriteLine("Vemos que el resultado es:  " + resultAnd+ " ,entonces es posible");


Console.WriteLine("");
Console.WriteLine("¿Puede tijera vencerse a si misma?");
bool resultOr = tijera1 || tijera1;
Console.WriteLine("Vemos que el resultado es:" + !resultOr + " ,entonces es posible"); //Aca aplicamos el operador NOT por que sabemos que esta condición deberia ser FALSE

Console.WriteLine("");
Console.WriteLine("¿La piedra vence a la tijera?");
bool resultXor = piedra1 ^ tijera2;
Console.WriteLine("El resultado que observamos es: " + resultXor+", entonces vemos que la piedra gana");
