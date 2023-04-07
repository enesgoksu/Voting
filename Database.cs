namespace Voting.Voting
{
    class Database
    {
        public static List<Users> userlist = new List<Users>();
        public static List<Categories> categorielist = new List<Categories>();
        public Database()
        {
            Users user1 = new Users{Email = "enesgoksu", Password = "123456"};
            Users user2 = new Users{Email = "ardaguler", Password = "123456789"};
            Users user3 = new Users{Email = "volkandemırel", Password = "123789"};
            userlist.Add(user1);
            userlist.Add(user2);
            userlist.Add(user3);

            Categories categorie1 = new Categories{Categoryid = 1,Categoryname = "Filmler",Categoryvote = 0};
            Categories categorie2 = new Categories{Categoryid = 2,Categoryname = "Spor",Categoryvote = 0};
            Categories categorie3 = new Categories{Categoryid = 3,Categoryname = "Oyunlar",Categoryvote = 0};

            categorielist.Add(categorie1);
            categorielist.Add(categorie2);
            categorielist.Add(categorie3);
        }

    }
}