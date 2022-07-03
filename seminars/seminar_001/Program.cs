// //запрашиваем у пользователя число
// Console.Write("Input number: ");

// // создаем переменную number и сохраняем в нее значение, введенное из консоли
// int number = Convert.ToInt32(Console.ReadLine());

// //объявляем переменную q и сохраняем в нее квадрат числа number
// int q = number * number;

// //выыодим значение переменных number и 
// Console.WriteLine(number + " -> " + q);

//Напишите программу, 
// a = 25, b = 5 -> да

//вводим первое число
Console.Write("Input first number: ");


//сохраняем значение в переменную
int number_1 = Convert.ToInt32(Console.ReadLine());

//вводим второе число

Console.Write("Input first number: ");

//сохраняем значение в переменную
int number_2 = Convert.ToInt32(Console.ReadLine());

// объявляем переменную q, в которую сохраняю  
int q = number_2 * number_2;

//сравниваем значение первой переменной, со значением второй переменной, умноженной на самого себя number_2 * number_2 числа
if (number_1 == q){
    Console.Write("a = " + number_1 + ", b = " + number_2 + " -> " + " yes");
}
else{
      Console.Write("a = " + number_1 + ", b = " + number_2 + " -> " + " no");
}