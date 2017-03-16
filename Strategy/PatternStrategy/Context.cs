using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Context
    {
        private static Dictionary<Roles, IRoles> _strategies = new Dictionary<Roles, IRoles>();

        static Context()
        {
            _strategies.Add(Roles.Usuario, new Usuario());
            _strategies.Add(Roles.Administrador, new Administrador());
            _strategies.Add(Roles.Invitado, new Invitado());
        }

        public static void Login(Roles rol)
        {
            _strategies[rol].Login();
        }
    }
}
