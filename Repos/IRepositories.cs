using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_EventsPoster.Repos
{
    interface IRepositories<T>
    {
        void GetById(int id, ListView list);
        void Add(ListView list);
        void Delete(ListView list);
        void Update(ListView list, bool add = false, bool delete = false);
        void All(ListView list);
        void new_list(ListView list);
        void OrderBy_List(ColumnClickEventArgs e, ListView list, bool n = true);

    }
}
