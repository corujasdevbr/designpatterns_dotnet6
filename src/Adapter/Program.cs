﻿// See https://aka.ms/new-console-template for more information
using Adapter;

Console.WriteLine("Adapter");

string[,] alunosArray = new string[5, 4]
            {
                {"101","Maria","Artes","1000"},
                {"102","Pedro","Engenharia","2000"},
                {"103","Bianca","Veterinária","3000"},
                {"104","Pamela","Moda","900"},
                {"105","Sergio","Desenho","850"}
            };

ITarget target = new AlunoAdapter();

Console.WriteLine("SistemaMensalidades passa o " +
                  "array de string para o Adapter\n");

target.ProcessaCalculoMensalidade(alunosArray);

Console.ReadKey();