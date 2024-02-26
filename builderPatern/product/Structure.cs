using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDesignPartens.builderPatern.product
{
    public abstract class Structure
    {
        protected string name;
        public Structure(string name)
        {
            this.name = name;
        }
    }
}
