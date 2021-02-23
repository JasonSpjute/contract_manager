namespace contract_manager.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public int ContractorId { get; set; }
        public int JobId { get; set; }
        public float FinalPrice { get; set; } = 0;
        public bool Completed { get; set; } = false;
    }
}