﻿using COLEGIO;
using PERSONAS;


Estudiante e1 = new Estudiante();
Estudiante e2 = new Estudiante();
Estudiante e3 = new Estudiante();


Entrenador E = new Entrenador();

Console.WriteLine("Ingrese el nombre del estudiante 1: ");
e1.Nombre = Console.ReadLine();


Console.WriteLine("Ingrese edad del estudiante 1: ");
e1.Edad = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el nombre del estudiante 2: ");
e2.Nombre = Console.ReadLine();


Console.WriteLine("Ingrese edad del estudiante 2: ");
e2.Edad = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el nombre del estudiante 3: ");
e3.Nombre = Console.ReadLine();


Console.WriteLine("Ingrese edad del estudiante 3: ");
e3.Edad = int.Parse(Console.ReadLine());



Console.WriteLine("Ingrese el nombre del Entrenador: ");
E.Nombre = Console.ReadLine();

Console.WriteLine("Ingrese el deporte del Entrenador: ");
E.Deporte = Console.ReadLine();



Console.WriteLine();