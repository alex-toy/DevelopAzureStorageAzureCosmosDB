namespace Helpers
{
    public interface IItem
    {
        string partitionKey { get; }
        string id { get; set; }
    }
}
