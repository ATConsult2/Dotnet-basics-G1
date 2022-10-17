using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn.library
{
    internal abstract class Book3 : ILonable
    {
        public string Author { get; private set; }
        public string Title { get; private set; }
        private static Random random = new Random();

        private int _internal_id = random.Next(1_000_000);

        protected Book3(string author, string title)
        {
            Author = author;
            Title = title;
        }

        public abstract void Loan();

        public override string ToString()
        {
            return $"Book3: \"{Title}\" by {Author}, internalId: {_internal_id}.";
        }

    }

    internal class RareBook3 : Book3{
        public string SpecialStoreId { get; private set; }

        public RareBook3(string author, string title, string specialStoreId):
            base(author, title)
        {
            SpecialStoreId = specialStoreId;
        }

        public override void Loan()
        {
            WriteLine("Loan RareBook3 imposible. Meet library superviser.." +
                GetHashCode());
        }

        public override string ToString()
        {
            return $"{base.ToString()}\b, sId: {SpecialStoreId}";
        }

    }

    class OrdinaryBook : Book3
    {
        public OrdinaryBook(string author, string title) : base(author, title)
        {
        }

        public override void Loan()
        {
            WriteLine("Loan Ordinary Book" + GetHashCode());
        }
    }

    class ElectronicBook3 : Book3
    {
        public ElectronicBook3(string author, string title) : base(author, title)
        {
        }
        public override void Loan()
        {
            WriteLine("Loan Electronic Book. Check email." + GetHashCode());
        }


    }

}
