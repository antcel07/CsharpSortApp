using System;

namespace exams2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            SortedList studentRecords = new SortedList();
            studentRecords.Add("Tomy");
            studentRecords.Add("Duffy");
            studentRecords.Add("Carlos");
            studentRecords.Add("Alex");
            studentRecords.Add("Anna");
            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();
            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();
            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();
            
            Console.ReadKey();
        }
    }

}
