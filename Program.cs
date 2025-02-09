
Mark.ProstoTak(); //Статистическая функция выполняется не над элементом калсса
Console.WriteLine("Введите переменную Mark (строка число)");
string p = Console.ReadLine(); //консольный ввод переменной классa Mark
Mark a = new Mark(p.Split()[0], int.Parse(p.Split()[1]));
a.Pr(); //Вывод переменной
string grade = a.Pb(); //Инициализация переменной в пятибальной системе
Console.WriteLine($"Оценка по пятибальной шкале: {grade}");//Вывод выше упомянутой переменной
a.Zagl(); //Перевод символов в верхний регистр
a.Obnull(); //Обнуления оценки
Console.WriteLine($"Длина названия предмета: {a.Len()}"); // Вывод длины названия предмета
Console.WriteLine("Обнуленный да еще и вверхнем регистре:");
a.Pr(); //Вывод переменной
Console.WriteLine("Введите новое название предмета");
string newname = Console.ReadLine(); //Ввод нового имени предмета
a.newName(newname); //Функция замены имени предмета
Console.WriteLine("Измененная переменная:");
a.Pr();//вывод переменной
//
Console.WriteLine("Введите две переменные Mark (строка число)");
string t = Console.ReadLine(); //консольный ввод переменной классa Mark
Mark b = new Mark(t.Split()[0], int.Parse(t.Split()[1]));
string t2 = Console.ReadLine(); //консольный ввод переменной классa Mark
Mark c = new Mark(t2.Split()[0], int.Parse(t2.Split()[1]));
Console.WriteLine("Результат <=");
Console.WriteLine(b <= c); //булевая функция <=
Console.WriteLine("Результат >=");
Console.WriteLine(b >= c); //булевая функция >=
//
MarkArray s = new MarkArray();//Инийциализая массива с классом данных Mark
Console.WriteLine("Введите количество переменных для создания массива");
int n = int.Parse(Console.ReadLine()); // колличество переменных
Console.WriteLine("Теперь введите столько переменных (строка число)");
for (int i = 0;  i < n; i++)//Ввод данных с консоли в массив 
{
    string s2 = Console.ReadLine();
    Mark a2 = new Mark(s2.Split()[0], int.Parse(s2.Split()[1]));
    s.PuBa(a2); //прошу заметить в функцию подается только переменная, массив динамический его длину мы не указываем

}
Console.WriteLine("Ваш массив:");
s.Pr(); //Вывод введенного массива
MarkArray cl = new MarkArray(); //Инициализая подопытного чтоб вставить в него значение предыдущего массива
cl.Clone(s); //Копирование массива
Console.WriteLine("Скопированный массив:");
cl.Pr(); //Вывод скопированного массива
MarkArray rs = new MarkArray(); //Инициализируем массив который будем генерировать рандомно
Console.WriteLine("Ведите длину массива который хотите сгенерировать рандомно");
int rn =  int.Parse(Console.ReadLine()); //ВВод длины массива который будем генерировать рандомно
rs.RandGen(rn); //Функция которая генерирует массив рандомно
Console.WriteLine("Ваш массив:");
rs.Pr();//Вывод этого массива
Console.WriteLine("Теперь выведем только те предметы у которых оценка выше средней:");
MarkArray sr = rs.SrZnach(); //C помощью встроенной функции создадим список хранящий оценки выше средней в bo
sr.Pr();
MarkArray bo = new MarkArray();
bo.RandGen(3);
Console.WriteLine("Рандомно сгенерируем массив из 3 элементов:");
bo.Pr();
Console.WriteLine("Поменяем первый элемент на переменную с которой работали вначале и выведем его теперь:");
bo[0] = a; // Присваивание значения элементу массива
bo.Pr(); //Вывод массива
Console.WriteLine("Выведем первый элемент:");
bo[0].Pr();
Console.WriteLine("Теперь выйдем за пределы массива:");
try //Пробуем ошибиться
{
    Console.WriteLine(bo[5].name, bo[5].mark); // ошибка
}
catch (ArgumentException e)
{
    Console.WriteLine($"Processing failed: {e.Message}, (ошибка при чтении)");
}
try
{
    bo[60] = a; //ошибка
}
catch (ArgumentException e)
{
    Console.WriteLine($"Processing failed: {e.Message}, (ошибка при вводе)");
}