﻿using System.Diagnostics.Tracing;

NewMethod();

static void NewMethod()
{
    Console.Write("Digite um valor entre 1 e 7 para saber o dia referente da semana: ");
    int x = int.Parse(Console.ReadLine());

    string dia;

    switch (x)
    {
        case 1: 
             dia = "Domingo";
             break;
        case 2:
            dia = "Segunda";
            break;
        case 3:
            dia = "Terça";
            break;
        case 4:
            dia = "Quarta";
            break;
        case 5:
            dia = "Quinta";
            break;
        case 6:
            dia = "Sexta";
            break;
        case 7:
            dia = "Sábado";
            break;
        default:
            dia = "Valor inválido";
            break;
    }
    Console.WriteLine("Dia " + dia);
}
