﻿double lado = 5;
double altura = 8;
int n_lados= 6;
double radio=4;
double perimetro = Application.Poligono_R.Perimetro(lado,n_lados);
double area = Application.Poligono_R.Area(lado,n_lados,radio);
double volumen = Application.PrismaRegular.Volumen(area, altura);

Console.WriteLine($"El perímetro de la base de un Prisma Regular de {n_lados} lados de {lado}cm por lado es de {perimetro}cm");
Console.WriteLine($"El área de la base de un Prisma Regular de {n_lados} lados de {lado}cm por lado y un radio de {radio}cm es {area}cm2");
Console.WriteLine($"El volumen un Prisma Regular con un área de la base de {area}cm2 y {altura}cm de altura es {volumen}cm3");