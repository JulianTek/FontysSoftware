using System;

namespace DBUnitTestMockup
{
    class Program
    {
        static void Main(string[] args)
        {
            DBTestMockup.Data.DatabaseManager databaseManager = new DBTestMockup.Data.DatabaseManager();

            Console.WriteLine(databaseManager.getEmployee(7));

            var employees = databaseManager.GetEmps();

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
