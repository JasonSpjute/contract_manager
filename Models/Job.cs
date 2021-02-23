namespace contract_manager.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Estimate { get; set; }
    }
    public class ContractViewModel : Job
    {
        public int ContractId { get; set; }
    }
}