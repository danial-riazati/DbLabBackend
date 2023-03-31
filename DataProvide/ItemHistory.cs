namespace DbLabBackend.DataProvide
{
    public class ItemHistory
    {
        public int Id { get; set; }
        public string? Value { get; set; }
        public DateTime Date { get; set; }
        public virtual Item Item {get; set;}
}
}