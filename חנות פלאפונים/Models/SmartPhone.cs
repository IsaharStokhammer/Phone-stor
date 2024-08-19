namespace חנות_פלאפונים.Models
{
    public class SmartPhone : IPhone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company {  get; set; }
        public int price { get; set; }
        public int Post(string Name, string Price, string Company)
        {
            return Id;
        }
        public int Get(int Id)
        {
            return Id;
        }
        public int Put(int Id, IPhone phone)
        {
            return Id;
        }
        public int Delete(int Id)
        {
            return Id;
        }


    }
}
