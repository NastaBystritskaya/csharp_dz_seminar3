// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.Write("Введите 1 координату:");
int[] coord1 = Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);

System.Console.Write("Введите 2 координату:");
int[] coord2 = Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);

double pwX = Math.Pow((coord1[0] - coord2[0]), 2);
double pwY = Math.Pow((coord1[1] - coord2[1]), 2);
double pwZ = Math.Pow((coord1[2] - coord2[2]), 2);

double pwSumm = pwX + pwY + pwZ;
double way = Math.Sqrt(pwSumm);

System.Console.WriteLine($"Расстояние между ккординатами {Math.Round(way, 3)}");