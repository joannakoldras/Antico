namespace AnticoWebApi.DbModels
{
    public class Order
    {
        public int Id { get; set; } 
        public string LongTextId { get; set; } //id zam
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}
