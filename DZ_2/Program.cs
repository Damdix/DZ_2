Console.WriteLine("\t\t=== Калькулятор Индекса Массы Тела (ИМТ) ===");

Console.WriteLine("\nВведите ваш вес в килограммах: ");
double user_weight = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nВведите ваш рост в метрах: ");
double user_height = Convert.ToDouble(Console.ReadLine());

double IMT = user_weight / user_height;             //Расчитываем ИМТ и присваймаем его переменной

Console.WriteLine($"Ваш индекс ИМТ: {IMT}");


Console.ReadLine();