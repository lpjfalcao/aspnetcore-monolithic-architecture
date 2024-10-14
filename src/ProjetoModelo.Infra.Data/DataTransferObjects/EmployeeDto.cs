namespace ProjetoModeloDDD.Infra.Data.DataTransferObjects
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public Guid CompanyId { get; set; }
        public CompanyDto Company { get; set; }
    }
}
