namespace Voting.Voting
{
    class Categories
    {
        private int categoryid;
        private string categoryname;
        private int categoryvote;

        public int Categoryid { get => categoryid; set => categoryid = value; }
        public string Categoryname { get => categoryname; set => categoryname = value; }
        public int Categoryvote { get => categoryvote; set => categoryvote = value; }
    }
}