using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andestech.learning2022.krasn
{
    enum Roles {
        Admin,
        Reader,
        Writer,
        Student
    }

    [AttributeUsage(AttributeTargets.Method)]
    internal class RoleAttribute : Attribute
    {
        public Roles Role { get;}
        public RoleAttribute(Roles role)
        {
            Role = role;
        }
        public RoleAttribute() { }
    }
}
