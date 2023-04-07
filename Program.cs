namespace Voting.Voting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1) Oy verme işlemi");
            Console.WriteLine("(2) Sonuçları gör");
            Console.WriteLine("(3) Kayıt ol");
            Console.Write("Lütfen yapmak istediğiniz işlemi seçin: ");
            int islemNo = int.Parse(Console.ReadLine());

            Database database = new Database();
            switch (islemNo)
            {
                case 1:
                    LoginUsers.Login(Database.userlist);
                    break;
                case 3:
                    AddUsers.Add(Database.userlist);
                    break;
                
            }
        }
    }
}