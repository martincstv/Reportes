using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AuthorsEntidades
    {
        public string State { get; set; }

        public AuthorsEntidades()
        {

        }

        public AuthorsEntidades(string state)
        {
            State = state;
        }
    }
}
