namespace Voting.Voting
{
    class LoginUsers
    {
        public static void Login(List<Users> userlist)
        {
            Console.WriteLine("Oy verme işlemini gerçekleştirmek için üyelik girişi yapın.");
            Console.WriteLine("******************************************");
            Console.WriteLine("Email: ");
            string iemail = Console.ReadLine();
            Console.WriteLine("Parola: ");
            string ipassword = Console.ReadLine();
            
            
            
                foreach (Users user in userlist)
                {
                    if (iemail == user.Email && ipassword == user.Password)
                    {
                        Console.WriteLine("Giriş işlemi başarılı");
                        Console.WriteLine("*********************************");
                        Console.WriteLine("(1) Oy verme işlemi");
                        int cevap = int.Parse(Console.ReadLine());

                        switch (cevap)
                        {
                           case 1:
                           VotingAdd.Voting(Database.categorielist);
                           break;
                           
                        }
                    }
                    else
                    {
                        Console.WriteLine("Giriş bilgilerinizi kontrol ediniz, eğer üyeliğiniz yoksa üye olmadan oy kullanamazsınız.");
                        break;
                    }
                }
            
        }
    }
}