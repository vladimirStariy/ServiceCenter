namespace ServiceCenter.Domain.Entity
{
    public class Service
    {
        public uint Service_ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
