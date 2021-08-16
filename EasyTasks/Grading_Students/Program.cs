using System;
using System.Collections.Generic;

namespace Grading_Students
{
    class Program
    {
        static int[] gradingStudents(int numbers)
        {
            int[] resultArr = new int[numbers];
            for (int i = 0; i < numbers; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());

                if(currNumber >= 38)
                {
                    int count = 0;
                    int temp = currNumber;
                    while(temp % 5 != 0)
                    {
                        count++;
                        temp++;
                    }

                    if(count < 3)
                    {
                        currNumber = temp;
                    }
                }


                resultArr[i] = currNumber;
            }

            return resultArr;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var resultArr = gradingStudents(n);

            Console.WriteLine(String.Join("\n", resultArr));
        }
    }
}
