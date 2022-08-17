namespace Builder
{
    public interface IBuilder
    {
        EmailBuilder Body(string content);
        EmailBuilder From(string address);
        EmailBuilder To(string address);
        EmailBuilder Subject(string title);
        Email Build();
    }
}
