namespace EmployeeLayerArchitectureApp.DAO
{
    public class Employee
    {
        public Employee()
        {
            ADesignation = new Designation();
        }

        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public Designation ADesignation { set; get; }

    }
}
