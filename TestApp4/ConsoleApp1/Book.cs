using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn.library
{
    internal class Book : Object
    {
        public string Author { get; private set; }
        public string Title { get; private set; }
        private static Random random = new Random();

        private int _internal_id = random.Next(1_000_000);

        public Book(string author, string title)
        {
            Author = author;
            Title = title;
        }

        public void Loan() {
            WriteLine("Loan Book.");
        }
        public override string ToString()
        {
            return $"Book: \"{Title}\" by {Author}, internalId: {_internal_id}.";
        }

    }

    internal class RareBook : Book{
        public string SpecialStoreId { get; private set; }

        public RareBook(string author, string title, string specialStoreId):
            base(author, title)
        {
            SpecialStoreId = specialStoreId;
        }

        public new void Loan()
        {
            WriteLine("Loan RareBook imposible. Meet library superviser..");
        }

        public override string ToString()
        {
            return $"{base.ToString()}\b, sId: {SpecialStoreId}";
        }

    }

}
