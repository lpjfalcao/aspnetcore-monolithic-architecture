namespace ProjetoModeloDDD.Infra.Data.DataTransferObjects
{
    public class CompanyDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public ICollection<EmployeeDto> Employees { get; set; }
    }
}
