namespace party.core.attributes
{
    [System.AttributeUsage(System.AttributeTargets.Property, AllowMultiple = false)]
    public class VisibleGrid : System.Attribute
    {
        public bool IsVisible { get; set; }
        public string Header { get; set; }
        public int Order { get; set; }
        public VisibleGrid(string header,int order)
        {
            IsVisible = true;
            Header = header;
            Order = order;
        }
    }
}
