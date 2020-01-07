using System;
using System.Collections.Generic;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trainsList = new Train[8];
            int index;

            for (index = 0; index < trainsList.Length; index++)
            {
                Console.WriteLine($"Train {index+1} from {trainsList.Length} \n Enter number:");
                trainsList[index].trainNumber = Console.ReadLine();
                Console.WriteLine("Enter Destination:");
                trainsList[index].destination = Console.ReadLine();
                Console.WriteLine("Enter Departure Time:");
                trainsList[index].departureTime = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("\n");
            }
            Array.Sort(trainsList, new TrainCompare());

            foreach (Train element in trainsList)
            {
                Console.WriteLine($"{element.trainNumber} {element.destination} {element.departureTime:t}");
            }

            Console.WriteLine("\nEnter train # to get info:");
             string requestNum = Console.ReadLine();
            Train? foundTrain = null;

            foreach (Train element in trainsList)
            {
                if (element.trainNumber == requestNum)
                {                    
                    foundTrain = element;                    
                    break;
                }
            }

            if (foundTrain != null)
            {
                Console.WriteLine($"\n{foundTrain.Value.trainNumber} {foundTrain.Value.destination} {foundTrain.Value.departureTime:t}");
            }
            else
            {
                Console.WriteLine("Wrong train number");
            }
            


            Console.ReadLine();
        }
    }

    struct Train 
    {
        public string destination;
        public string trainNumber;
        public DateTime departureTime;  
        
        public Train (string destination, string trainNumber, DateTime departureTime)
        {
            this.destination = destination;
            this.trainNumber = trainNumber;
            this.departureTime = departureTime;
        }
    }

    class TrainCompare : IComparer<Train>
    {
        public int compare;
        public int Compare(Train t1, Train t2)
        {   
            compare = String.Compare(t1.trainNumber, t2.trainNumber);
            return compare;
        }
    }


}
