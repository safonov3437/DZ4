//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*

int A = 5;
int B = 7;
int result = 1;
for (int i = 1; i <= B; i++)
{
    result *=A;
}
Console.WriteLine(result);

*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int SumNumber(int numberN){
int count = Convert.ToString(numberN).Length;
int advance = 0;
int result = 0;
for (int i = 0; i < count; i++){
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
 }
   return result;
}
int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);//только не понял вывод всегда нужно писать через $ или это добровольно?

*/

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1,2,3,4,5,6,7,8->[1,2,3,4,5,6,7,8]
// length = 8, massiv=8



int[] GetArray(int length, int massiv)
{
int[] resultArray = new int[length];
for (int i = 0; i < resultArray.Length; i++)
{
resultArray[i] = new Random().Next(massiv);
}
return resultArray;
}
int[] array = GetArray(8, 8);
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");

