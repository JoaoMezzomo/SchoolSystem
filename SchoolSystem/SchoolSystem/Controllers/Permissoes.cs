using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolSystem.Models;

namespace SchoolSystem.Controllers
{
    public class Permissoes
    {
        public static List<CAD_PERMISSOES> BuscarTodasPermissoes() 
        {
            return CAD_PERMISSOES.SELECT_ALL();
        }
    }
}