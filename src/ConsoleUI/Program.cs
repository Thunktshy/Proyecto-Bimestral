﻿using Application;

double perimetro;
double area;

Console.WriteLine("Calculadora de Area y Perímetro Poligono Regular");

Console.WriteLine("Dame la medida de la base (lado): ");
double lado = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Dame el numero de lados");
int n_lados = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Dame el radio del poligono");
double radio = Convert.ToDouble(Console.ReadLine());

perimetro = Poligono_R.Perimetro(lado,n_lados);
area = Poligono_R.Area(lado,n_lados,radio);

Console.WriteLine();
Console.WriteLine($"Perímetro: {perimetro}cm\nÁrea: {area}cm2");