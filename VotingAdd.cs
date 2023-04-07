namespace Voting.Voting
{
    class VotingAdd
    {
        public static void Voting(List<Categories> categorielist)
        {
            List<Users> userlist;
            WriteCategories.Write(Database.categorielist);
            
                Console.Write("Oy vermek istediğiniz Kategorinin Id nosunu girin: ");
                int ıdno = int.Parse(Console.ReadLine());
            foreach (Categories categorie in categorielist)
            {    
                if (ıdno == categorie.Categoryid)
                {
                    Console.WriteLine("Oy verme işlemini gerçekleştirdiniz.");
                    categorie.Categoryvote++;
                    break;
                }
            }


            
        }
    }
}