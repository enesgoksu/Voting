namespace Voting.Voting
{
    class AddUsers
    {
        public static void Add(List<Users> userlist)
        {
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Parola: ");
            string password = Console.ReadLine();
            bool control = true;
            while (control)
            {
                
                foreach (Users user in userlist)
                {
                    if (email == user.Email)
                    {
                        Console.WriteLine("Bu email kullanılmaktadır.");
                        control = true;
                    }
            
                    else
                    {
                        Users newuser = new Users{Email = email,Password = password};
                        userlist.Add(newuser);
                        Console.WriteLine("Üyeliliğiniz tamamlanmıştır.Oy verme işlemine geçebilirsiniz.");
                        Console.WriteLine("************************");
                        Console.WriteLine("(1) Oy verme işlemi");
                        int cevap = int.Parse(Console.ReadLine());
                        control = false;
                        switch (cevap)
                        {
                        case 1:
                        VotingAdd.Voting(Database.categorielist);
                        break;
                        }   
                    }

                }
    
                
            }
                        
                    
                
        }
    }
}