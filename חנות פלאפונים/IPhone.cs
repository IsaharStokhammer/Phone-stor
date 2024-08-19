namespace חנות_פלאפונים
{
    public interface IPhone
    {
        string Name { get; }
        string Company { get; }
        string Price { get; }
        int Post (string Name,  string Price, string Company);
        int Get (int Id);
        int Put(int Id, IPhone phone);
        int Delete (int Id);
    }
}
