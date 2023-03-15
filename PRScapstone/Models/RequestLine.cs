namespace PRScapstone.Models
{
    public class RequestLine
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public virtual ICollection<Request>? Requests { get; set; }
        public int ProductId { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
        public int Quantity { get; set; }

    }
}
