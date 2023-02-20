using Oil.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil.Data
{
    public class OilContext: DbContext
    {
        public OilContext():
            base("OilDb")
        {
                
        }
        public List<OilClass> Oils { get; set; }
    }
}
