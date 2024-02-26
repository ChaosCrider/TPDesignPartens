using System.Security.AccessControl;
using TPDesignPartens.builderPatern.product;

namespace TPDesignPartens.builderPatern.Builder
{
    public class QuantitativeCompo : IStructuralComponent
    {
        public string name { get; set; }
        public int quantity { get; set; }

        public QuantitativeCompo(string name, int quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }

        public override string ToString()
        {
            return "Type: "+name+", Value: "+quantity;
        }
    }
}