using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     class DTO_Administrador
    {
        private string UserAdmin, pass;

        public string userAdmin
        {
            get
            {
                return UserAdmin;
            }

            set
            {
                UserAdmin = value;
            }
        }

        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }
     }
}
