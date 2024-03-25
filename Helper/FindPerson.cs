using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;

namespace WpfApp2.Helper
{
    internal class FindPerson
    {
        int id;

        public FindPerson(int id)
        {
            this.id = id;
        }

        public bool PersonPredicate(Person obj)
        {
            return obj.Id == id;
        }
    }
}
