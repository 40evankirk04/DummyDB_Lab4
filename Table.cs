namespace DummyDB
{
    public class Table
    {
        public List<Row> Rows { get; set; }
        public Table()
        {
            Rows = new List<Row>();
        }
    }
}
