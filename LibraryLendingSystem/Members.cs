using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLendingSystem
{
    public class Member
    {
        public string id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

    }
    public class Books
    {
        public int bookId { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string ISBN { get; set; }
        public int availablebooks { get; set; }
        public int totalbooks { get; set; }
    }
    internal class Members
    {

    }
}
