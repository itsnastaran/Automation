using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.ViewModel.User
{
    public class ListViewFullName
    {
        public string Name { get; set; }
        public string Family { get; set; }

        public string GetFullName
        {
            get
            {
                if (this.Name != null && this.Family != null)
                {
                    return this.Name + " " + this.Family;
                }
                else
                {
                    return "Null";
                }
            }
        }
    }
}
