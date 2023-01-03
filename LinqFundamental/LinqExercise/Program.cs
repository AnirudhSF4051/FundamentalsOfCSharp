using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //You can get the trainee details from the GetTraineeDetails() method in TraineeData class
            Console.WriteLine("Enter Menu Number");
            int option = Convert.ToInt32(Console.ReadLine());
            TraineeDetails obj = new TraineeDetails();
            TraineeData ob1 = new TraineeData();
            List<TraineeDetails> b = ob1.GetTraineeDetails();


            switch (option)
            {
                case 1:
                {
                    IEnumerable<string> query = from trainee in b select trainee.TraineeId;
                    foreach (string id in query)
                    {
                        System.Console.WriteLine(id);
                    }
                    break;
                }
                case 2:
                {
                    IEnumerable<string> query = (from trainee in b select trainee.TraineeId).Take(3);
                    foreach (string id in query)
                    {
                        System.Console.WriteLine(id);
                    }

                    break;
                }

                case 3:
                {
                    IEnumerable<string> query = (from trainee in b select trainee.TraineeId).Skip(3);
                    foreach (string id in query)
                    {
                        System.Console.WriteLine(id);
                    }
                    break;
                }
                case 4:
                {
                     IEnumerable<string> query = from trainee in b select trainee.TraineeId;
                     System.Console.WriteLine(query.Count());   
                    break;
                }
                case 5:
                {                                    //<alias>  //<col|arr>                                 //<alias>
                     IEnumerable<string> query = from trainee in b where trainee.YearPassedOut>=2019 select trainee.TraineeName;
                     foreach(string yearofpassing in query)
                     {
                        System.Console.WriteLine(yearofpassing);
                     }
                    break;
                }
                case 6:
                {
                    IEnumerable<TraineeDetails>query=b.OrderBy(c=>c.TraineeName);
                    foreach(TraineeDetails order in query)
                    {
                        System.Console.WriteLine($"{order.TraineeId}     {order.TraineeName}");
                    }

                    break;
                }
                case 8:
                {
                    IEnumerable<int>query=(from trainee in b select trainee.YearPassedOut).Distinct();
                    foreach(int distnictYear in query)
                    {
                        System.Console.WriteLine(distnictYear);
                    }
                    break;
                }
                case 9:
                {
                    System.Console.WriteLine("Enter trainee ID: ");
                    string traineeID=Console.ReadLine().ToUpper();
                    IEnumerable<int> marks=from trainee in b where trainee.TraineeId==traineeID select trainee.TotalScore;
                    if(marks.Count()==0)
                    {
                        System.Console.WriteLine("Invalid ID");
                    }
                    else 
                    {
                        foreach(int mark in marks)
                        {
                            System.Console.WriteLine(mark);
                        }
                    }
                    break;
                }
                case 10:
                {
                    TraineeDetails trainee=b.First();
                    System.Console.WriteLine(trainee.TraineeId + " : " +trainee.TraineeName);
                    break;
                }
                case 11:
                {
                    TraineeDetails trainee=b.Last();
                    System.Console.WriteLine(trainee.TraineeId + " : " +trainee.TraineeName);
                    break;
                }
                case 12:
                {
                    IEnumerable<TraineeDetails>query=from trainee in b select trainee;
                    foreach(TraineeDetails trainee in query)
                    {
                        System.Console.WriteLine(trainee.TotalScore);
                    }
                    break;
                }
                case 13: 
                {
                    int maxScore=(from trainee in b select trainee.TotalScore).Max();
                    System.Console.WriteLine(maxScore);
                    break;
                }
                case 14:
                {
                    int minScore=(from trainee in b select trainee.TotalScore).Min();
                    System.Console.WriteLine(minScore);
                    break;
                }
                case 15: 
                {
                    double avgScore=(from trainee in b select trainee.TotalScore).Average();
                    System.Console.WriteLine(avgScore);
                    break;
                }




            }

        }
    }
}
