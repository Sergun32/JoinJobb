﻿// Что требуется:

// Создать репозиторий на GitHub
// Создать readme-файл c описанием основных пунктов решения задачи.
// Дополнительно добавить в репозиторий блок-схему с алгоритмом самой сложной(по вашему мнению) 
// части задачи из п.2
// Написать программу, решающую поставленную задачу
// Вся работа разбивается на логические единицы зафиксированнаые отдельным коммитом
// Задача: Написать программу, которая из сформированного массива строк содержащих символы и числа создать массив из строк, в который попадут только символы, не являющиеця цифрами.

// // Входные данные можно получить путём ввода с клавиатуры, но лучше сделать автогенерацию данных. 

// 1. Сформировать массив содержащий символы и числа
// 2. Проверить массив на наличие в нем чисел
// 3. Сформировать новый пустой массив
// 4. Поместить символы в новый массив
// 5. Распечатать результат

// 1. Сформировать массив содержащий символы и числа
char [] array = new char [20];
Random rnd = new Random();
    Console.WriteLine("Так выглядит наш массив с символами и числами:  ");
for(int i = 0; i< array.Length; i++)
{
    array[i]= Convert.ToChar(rnd.Next(48, 122));
    Console.Write("{0} ", array[i]);
}
Console.WriteLine();

// 2. Проверка массива на наличие чисел
    Console.WriteLine("Выполняем проверку: False = символ   True = цифра ");
for(int i = 0; i< array.Length; i++)
{
    char symb = array[i];
    bool flag = symb >= '0' && symb <= '9';
    Console.Write($" {flag}");

}
Console.WriteLine();
// 3 и 4 . Сформируем новый пустой массив и заполним с учетом проверки

char [] finish = new char [20];
for(int i = 0; i < array.Length; i++)
{
    char symb = array[i];
    if(symb > 57)
    {
        finish[i] = symb;
    }
}
// 5 Распечатаем новый массив с результатом
Console.WriteLine("Так выглядит наш массив без чисел:  ");
for(int i = 0; i < finish.Length; i++)
{
    Console.Write("{0} ", finish[i]);
}