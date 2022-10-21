#define FLAG1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using static System.Console;
using System.Diagnostics;


namespace andestech.learning2022.krasn
{
    internal class ReflectionTest
    {
        static void Main2(string[] args)
        {
            Type type = typeof(Book);
            var Props = type.GetProperties();

            foreach (PropertyInfo prop in Props)
            {
                WriteLine(prop.Name + " --- " + prop.Module);
            }


            Book book = new Book() { Title = "Aelita", Author = "A.Tolstoy" };
            FieldInfo f1 = type.GetField("_id", BindingFlags.NonPublic | BindingFlags.Instance);
            WriteLine( f1?.GetValue(book));
            // Invoke(this, new object[]{1,2,3})

            F1();

            F2();

            Type type2 = typeof(Library);
            MethodInfo mi = type2.GetMethod("Add");
            Attribute ma = mi.GetCustomAttribute(typeof(RoleAttribute));
            WriteLine(((RoleAttribute)ma).Role);

        }
        [Conditional("FLAG1")]
        static void F1() => WriteLine("F1");
       
        [Conditional("FLAG2")]
        static void F2() => WriteLine("F2");


    }
}
