using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.ORM
{
    public static class ORMUsuarios
    {
        public static Admin SelectAdmin(string username)
        {
            Admin _admin =
                    (from p in ORM.bd.Admin
                     where p.nombre.Equals(username)
                     select p
                     ).FirstOrDefault();
            return _admin;
        }

        public static Boolean UserExist(String username, String password)
        {
            bool response;
            Admin _admin =
                    (from p in ORM.bd.Admin
                     where (p.nombre.Equals(username) && p.contrasenya.Equals(password))
                     select p
                     ).FirstOrDefault();

            if (_admin!=null)
            {
                response = true;
            }
            else
                response = false;

            return response;
        }
    }
}
