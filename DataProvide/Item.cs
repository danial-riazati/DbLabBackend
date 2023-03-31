namespace DbLabBackend.DataProvide
{
    public class Item
    {
        public int Id { get; set; }
        public string? Value { get; set; }
        public DateTime Date { get; set; }
        public bool isRemoved { get; set; }
    }
}