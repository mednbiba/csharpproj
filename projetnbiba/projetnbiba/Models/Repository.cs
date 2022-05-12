namespace projetnbiba.Models
{
    public class Repository
    {
        private static List<Employee> ListEmployees = new List<Employee>();
        public static IEnumerable<Employee> GetEmployees()
        {
            return ListEmployees;
        }
        public static void AddEmployee(Employee emp)
        {
            ListEmployees.Add(emp);
        }

    }
}
