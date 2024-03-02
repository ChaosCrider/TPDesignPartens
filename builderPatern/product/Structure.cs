using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDesignPartens.builderPatern.product
{
    public abstract class Structure :IStructure
    {
        protected string name;
        public Structure(string name)
        {
            this.name = name;
        }

        public void describe()
        {
            throw new NotImplementedException();
        }
    }
}
