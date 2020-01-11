using System;

namespace Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            Accauntant[] staff = new Accauntant[] {
        new Accauntant(hours:10, worker:Post.director),
        new Accauntant(hours:24, worker:Post.secretary),
        new Accauntant(hours: 10, worker: Post.shop_Assistant),
        new Accauntant(hours: 0, worker: Post.cleaner) };


            foreach (Accauntant elem in staff)
            {

                if (elem.AskForBonus(elem.worker, elem.hours))
                {
                    Console.WriteLine($"Staff position: {elem.worker} \nHours of work: {elem.hours} \nmust work: {(int)elem.worker} \nGive a bonus for {elem.worker}\n\n");
                }
                else
                {
                    Console.WriteLine($"Staff position: {elem.worker} \nHours of work: {elem.hours} \nmust work: {(int)elem.worker} \nNo bonus for {elem.worker}\n\n");
                }
            }

            Console.ReadLine();
        }
    }

    enum Post
    {
        director = 8,
        shop_Assistant = 12,
        cleaner = 4,
        secretary = 6
    }

    class Accauntant
    {
        public int hours;
        public Post worker;

        public Accauntant (int hours, Post worker)
        {
            this.hours = hours;
            this.worker = worker;
        }

      public bool AskForBonus(Post worker, int hours)
        {
            bool res = false;
            int _hours = (int)worker;

            if (_hours < hours)
            {
                res = true;
            }
            return res;

        }
    }
}
    
