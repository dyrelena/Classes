using System;
using System.Collections.Generic;

namespace Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
        Accauntant dirBonus = new Accauntant { hours = 10, worker = Post.director };

            if (dirBonus.AskForBonus(dirBonus.worker, dirBonus.hours))
            {
                Console.WriteLine($"Hours of work: {dirBonus.hours} \nmust work: {PostHours.postHours[Post.director]} \nGive a bonus for {dirBonus.worker}");
            }
            else
            {
                Console.WriteLine($"Hours of work: {dirBonus.hours} \nmust work: {PostHours.postHours[Post.director]} \nNo bonus for {dirBonus.worker}");
            }

            Console.ReadLine();
        }
    }

    enum Post
    {
        director,
        shopAssistant,
        cleaner,
        secretary
    }

    class Accauntant
    {
        public int hours;
        public Post worker;

      public bool AskForBonus(Post worker, int hours)
        {
            bool res = false;
        int _hours = (int) PostHours.postHours[worker];

            if (_hours < hours)
            {
                res = true;
            }
            return res;

        }
    }

 static class PostHours
{
    public static Dictionary<Post, int> postHours = new Dictionary<Post, int>()
    { { Post.director, 8 }, { Post.shopAssistant, 12 }, { Post.cleaner, 4 }, { Post.secretary, 8 } };
}
}
    
