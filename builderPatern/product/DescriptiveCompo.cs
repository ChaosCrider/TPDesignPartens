using TPDesignPartens.builderPatern.product;

namespace TPDesignPartens.builderPatern.Builder
{
    public class DescriptiveCompo : IStructuralComponent
    {
        public string name { get; set; }
        public string description { get; set; }

        public DescriptiveCompo(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override string ToString()
        {
            return "Type: "+name+", Descriptor: "+description;
        }
    }
}