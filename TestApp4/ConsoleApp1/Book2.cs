using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn.library
{
    internal class Book2
    {
        public string Author { get; private set; }
        public string Title { get; private set; }
        private static Random random = new Random();

        private int _internal_id = random.Next(1_000_000);

        public Book2(string author, string title)
        {
            Author = author;
            Title = title;
        }

        public virtual void Loan() {
            WriteLine("Loan Book2. " + GetHashCode());
        }
        public override string ToString()
        {
            return $"Book2: \"{Title}\" by {Author}, internalId: {_internal_id}.";
        }

    }

    internal class RareBook2 : Book2{
        public string SpecialStoreId { get; private set; }

        public RareBook2(string author, string title, string specialStoreId):
            base(author, title)
        {
            SpecialStoreId = specialStoreId;
        }

        public override void Loan()
        {
            WriteLine("Loan RareBook2 imposible. Meet library superviser.." +
                GetHashCode());
        }

        public override string ToString()
        {
            return $"{base.ToString()}\b, sId: {SpecialStoreId}";
        }

    }

    class ElectronicBook : Book2
    {
        public ElectronicBook(string author, string title) : base(author, title)
        {
        }
        public override void Loan()
        {
            WriteLine("Loan Electronic Book. Check email." + GetHashCode());
        }


    }

}
