using System;

namespace StructVSClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.change = "not changed";

            MyStruct myStruct = new MyStruct();
            myStruct.change = "not changed";

            ClassTaker(myClass);
            StruktTaker(myStruct);

            Console.WriteLine("myClass.change: {0}", myClass.change); //значение на которое ссылается объект изменилось, увидим новое значение
            Console.WriteLine("myStruct.change: {0}", myStruct.change); //в классе Program значение осталось без изменения, метод работал с копией и ничего не вернул в основной метод программы

            Console.ReadLine();

        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed"; //ссылка на значение
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "changed"; //В метод передается копия. Новое значение так и останется в методе, чтобы его увидеть в кассе Program надо возвращать переменную с новым значением
                                         //    Console.WriteLine("myStruct.change in method: {0}", myStruct.change);
        }

    }

    class MyClass
    {
        public string change;
    }

    struct MyStruct
    {
        public string change;
    }


}
