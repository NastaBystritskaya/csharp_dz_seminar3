// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
string? input= Console.ReadLine();
string? input2 = input; 
char[] input_array = input!.ToCharArray();
Array.Reverse(input_array);
input = new string(input_array);
if (input == input2) {
    System.Console.WriteLine("да");
}
else {
    System.Console.WriteLine("нет");
}




