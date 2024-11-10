using OOPGenericcollections;

namespace EmployeeManagement
{
    // Skapa klassen Employee
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string name, string gender, decimal salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Gender: {Gender}, Salary: {Salary:C}";
        }
    }
}
