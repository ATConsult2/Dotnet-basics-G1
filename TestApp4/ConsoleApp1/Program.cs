using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using andestech.learning2022.krasn.library;
using andestech.learning2022.krasn.game;

namespace andestech.learning2022.krasn
{
    internal class Singleton { 
     // private static Singleton[] _instance = new Singleton[3];
     // private int counter;
        private static Singleton _instance;
              
      public static Singleton Instance {
            get
            {
                if (_instance == null) _instance = new Singleton();
                return _instance;
            }
                        }

        private Singleton()
        {
            WriteLine("+++ Singleton: " + GetHashCode());
         
        }
    
    }

    internal class Program
    {
        static void LoanBook(Book2 book)
        {
            book.Loan();
        }

        static void LoanBook2(object book)
        {
            if (book is Book2 b2) b2.Loan();
        }

        static void Tetris(IMovable movable) {
            ///
            movable.MoveLeft();
            movable.MoveLeft();
            movable.MoveLeft();
            movable.Rotate(120);
            movable.MoveRight();

        }

        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;

            Book book1 = new Book(author: "Jack London", title: "White silence");
            WriteLine(book1);
            book1.Loan();

            RareBook book2 = new RareBook(author: "Leonaro da Vinci", title: "Opus 1112", "AA-dd-44-2022");
            WriteLine(book2);
            book2.Loan();

            //new Singleton(); private constructor!!!

            Book2 book22 = new RareBook2(author: "Galileo", title: "omnis in pertubum", "G2-GG-22");
            Object o = new RareBook2(author: "Galileo", title: "omnis in pertubum", "G2-GG-22");

            //0------
            ((RareBook2)o).Loan();
            //
            //((RareBook)o).Loan();

            //1-------
            RareBook rbook = o as RareBook;
            //if (rbook != null) rbook.Loan();
            rbook?.Loan();
            //-------
            RareBook2 rbook2 = o as RareBook2;
            //if (rbook != null) rbook.Loan();
            rbook2?.Loan();
            //2-------
            if (o is RareBook rbook1)
            {
                rbook1.Loan();
            }

            // --- poly test -----
            Book2 bk2 = new RareBook2(author: "Galileo", title: "omnis in pertubum", "G2-GG-22");
            bk2.Loan();

            LoanBook(new RareBook2(author: "Galileo", title: "omnis in pertubum", "G2-GG-22"));
            LoanBook(new ElectronicBook("AAA", "AA"));
            LoanBook(new Book2("AAA", "AA"));

            // ---- abstarct test -----
            Book3 ordirayBook = new OrdinaryBook(
                title: "War and Piece",
                author: "Leo Tolstoy");
            WriteLine(ordirayBook);
            ordirayBook.Loan();

            //------ interface test ----
            ILonable il1 = new OrdinaryBook(
                title: "War and Piece",
                author: "Leo Tolstoy");
            il1.Loan();

            //------ game test -----------
            Tetris(new MoveTesris1());
            WriteLine();




        }
    }
}
