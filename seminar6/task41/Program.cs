// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 
// 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int PositiveNumberCount()
{
   int count = 0;
   System.Console.WriteLine("Введите числа по очереди(чтобы приостановить ввод введите stop)");

   while (true)
   {
      var answer = Console.ReadLine();
      if (answer != "stop")
      {
         int number = Convert.ToInt32(answer);
         if (number > 0)
         {
            count++;
         }
      }
      else
      {
         break;
      }
   }
   return count;
}

int posNum = PositiveNumberCount();
System.Console.WriteLine(posNum);