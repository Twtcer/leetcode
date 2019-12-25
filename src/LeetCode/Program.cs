using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var lessons = Assembly.GetExecutingAssembly().GetTypes().Where(a => a.GetInterfaces().Contains(typeof(ILesson)) && !a.IsAbstract).ToList();
            lessons.ForEach(lesson =>
            {
                try
                {
                    var task = Activator.CreateInstance(lesson) as ILesson;
                    task.Action();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"has happen error:{ex.Message},{ex.StackTrace}");
                }
            });

            Console.ReadLine();
        }
    }
}
