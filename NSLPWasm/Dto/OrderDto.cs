namespace NSLPWasm.Dto
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime From { get; set; }
        public DateTime Till { get; set; }
        public bool Completed { get; set; }
        public List<OrderDetailDto> OrderDetails { get; set; }
    }
}
