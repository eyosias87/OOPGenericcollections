using EmployeeManagement;
namespace OOPGenericcollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Del 1 – Stack
            Stack<Employee> employeeStack = new Stack<Employee>();

            // Skapa fem Employee-objekt
            Employee emp01 = new Employee(01, "Helena", "Female", 50000);
            Employee emp02 = new Employee(02, "Eyosias", "Male", 60000);
            Employee emp03 = new Employee(03, "Charlie", "Male", 55000);
            Employee emp04 = new Employee(04, "Nina", "Female", 62000);
            Employee emp05 = new Employee(05, "Erik", "Male", 58000);

            // Lägg till Employee-objekt i stacken med Push()
            employeeStack.Push(emp01);
            employeeStack.Push(emp02);
            employeeStack.Push(emp03);
            employeeStack.Push(emp04);
            employeeStack.Push(emp05);

            Console.WriteLine("Stack Contents:");
            // Skriv ut alla objekt i stacken
            foreach (var employee in employeeStack)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine($"Total items in stack: {employeeStack.Count}\n");

            // Hämta alla objekt med Pop() och skriv ut dem
            Console.WriteLine("Popping all items from stack:");
            while (employeeStack.Count > 0)
            {
                Console.WriteLine(employeeStack.Pop());
                Console.WriteLine($"Items left in stack: {employeeStack.Count}");
            }

            // Lägg till alla objekt igen med Push()
            employeeStack.Push(emp01);
            employeeStack.Push(emp02);
            employeeStack.Push(emp03);
            employeeStack.Push(emp04);
            employeeStack.Push(emp05);

            // Hämta objekt med Peek()-metoden och skriv ut dem
            Console.WriteLine("\nPeeking at top items in stack:");
            Console.WriteLine(employeeStack.Peek());
            Console.WriteLine($"Items left in stack after first Peek: {employeeStack.Count}");
            Console.WriteLine(employeeStack.Peek());
            Console.WriteLine($"Items left in stack after second Peek: {employeeStack.Count}\n");

            // Del 2 – List
            List<Employee> employeeList = new List<Employee> { emp01, emp02, emp03, emp04, emp05 };

            // Kontrollera om Employee2 finns i listan med Contains()
            Console.WriteLine("Checking if Employee2 exists in the list:");
            if (employeeList.Contains(emp02))
            {
                Console.WriteLine("Employee2 object exists in the list.");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list.");
            }

            // Använd Find() för att hitta första objektet med Gender = "Male"
            Employee? firstMaleEmployee = employeeList.Find(emp => emp.Gender == "Male");
            Console.WriteLine("\nFirst Male Employee:");
            Console.WriteLine(firstMaleEmployee != null ? firstMaleEmployee.ToString() : "No male employee found.");

            // Använd FindAll() för att hitta och skriva ut alla objekt med Gender = "Male"
            List<Employee> allMaleEmployees = employeeList.FindAll(emp => emp.Gender == "Male");
            Console.WriteLine("\nAll Male Employees:");
            foreach (var maleEmployee in allMaleEmployees)
            {
                Console.WriteLine(maleEmployee);
            }
        }
    }
}