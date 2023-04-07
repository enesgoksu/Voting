namespace Voting.Voting
{
    class WriteCategories
    {
        public static void Write(List<Categories> categorielist)
        {
            foreach (Categories categorie in categorielist)
            {
                Console.WriteLine("CategoryID: "+ categorie.Categoryid);
                Console.WriteLine("CategoryName: "+ categorie.Categoryname);
                Console.WriteLine("****************************************");
            }
        }
    }
}