using System;
using System.Linq;
using System.Collections.Generic;

namespace EX04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArguments = command.Split();                    //разделяме командата на части, тъй като може да бъде от 1, 2 или 3 аргумента
                string action = commandArguments[0];                            //на индекс [0] входът е действието, което ще извършваме

                if (action == "Add")
                {
                    int element = int.Parse(commandArguments[1]);               //прочитаме елемент, които е на индекс [1] от командата
                    numbers.Add(element);                                       //Добавяме го в края на листа
                }
                else if (action == "Insert")
                {
                    int number = int.Parse(commandArguments[1]);                //прочитаме елемент, който е на индекс [1] от командата
                    int index = int.Parse(commandArguments[2]);                 //прочитаме индекса, на който трябва да застане новия елемент (това е [2] от командата)

                    if (index < 0 || index >= numbers.Count)                    //ако индексът е извън границите на листа
                    {
                        Console.WriteLine("Invalid index");                     //принтираме командата по условието
                        command = Console.ReadLine();                           //прочитаме нов вход
                        continue;                                               //пропускаме изпълнението на оставащия код в проверката и продължаваме да проверяваме новия вход
                    }

                    numbers.Insert(index, number);
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(commandArguments[1]);                 //прочитаме индекса, който трябва да се премахне (който е на [1] от командата

                    if (index < 0 || index >= numbers.Count)                    //ако индексът е извън границите на листа
                    {
                        Console.WriteLine("Invalid index");                     //принтираме командата по условието
                        command = Console.ReadLine();                           //прочитаме нов вход
                        continue;                                               //пропускаме изпълнението на оставащия код в проверката и продължаваме да проверяваме новия вход
                    }

                    numbers.RemoveAt(index);
                }
                else if (commandArguments[1] == "left")                         //първият елемент трябва да отиде най-отзад, а всички останали да се изместят на ляво
                {
                    int count = int.Parse(commandArguments[2]);                 //четем [3] от командата

                    for (int j = 0; j < count; j++)                             //външният for служи за изпълняване на необходимия брой итерации, които са подадени от входа част[3] от командата
                    {
                        int firstElement = numbers[0];                          //присвояваме първия елемент на индекс [0]

                        for (int i = 0; i < numbers.Count - 1; i++)              //Count-1 за да не излезем от листа когато стигнем до последния елемент
                        {
                            numbers[i] = numbers[i + 1];                         //индекс [0] става индекс [1], индекс [1] става индекс [2] и т.н. премества всеки индекс на ляво
                        }                                                        //вътрешният for работи само за едно завъртане

                        numbers[numbers.Count - 1] = firstElement;               //последният елемент се замества от първия елемент
                    }
                }
                else if (commandArguments[1] == "right")
                {
                    int count = int.Parse(commandArguments[2]);                 //четем [3] от командата

                    for (int j = 0; j < count; j++)                             //външният for служи за изпълняване на необходимия брой итерации, които са подадени от входа част[3] от командата
                    {
                        int lastElement = numbers[numbers.Count - 1];           //присвояваме последния елемент на последния индекс Count-1
                        for (int i = numbers.Count - 1; i >= 1; i--)            //с намаляващ цикъл изместваме всичките на дясно с един индекс
                        {
                            numbers[i] = numbers[i - 1];                        //[0] става последен, индекс[1] става [2], [2] става [3] и т.н. преместват се с едно на дясно колкото итерации са зададени по условие
                        }
                        numbers[0] = lastElement;                               //първият елемент се замества от последния, след като всички останали са се преместили с един индекс на дясно
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
//4.List Operations
//The first input line will hold a list of integers. Until we receive the "End" command, we will be given operations we have to apply to the list.
//The possible commands are:
//•	Add
//{ number} – add the given number to the end of the list
//•	Insert {number} { index} – insert the number at the given index
//•	Remove {index} – remove the number at the given index
//•	Shift left {count} – first number becomes last. This has to be repeated the specified number of times
//•	Shift right {count} – last number becomes first. To be repeated the specified number of times
//Note: the index given may be outside of the bounds of the array. In that case print: "Invalid index".
//Examples
//Input	
//1 23 29 18 43 21 20
//Add 5
//Remove 5
//Shift left 3
//Shift left 1
//End	

//Output
//43 20 5 1 23 29 18

//Input
//5 12 42 95 32 1
//Insert 3 0
//Remove 10
//Insert 8 6
//Shift right 1
//Shift left 2
//End	

//Output
//Invalid index
//5 12 42 95 32 8 1 3
