using System.Collections.Generic;
using System.Text;

namespace Training.Composite
{
    public  class CompoundOrgan : IOrgan
    {
        private string _name;
        private List<IOrgan> _children=new List<IOrgan>();

        public CompoundOrgan( string name)
        {
            _name = name;
        }

        public string GetInfo()
        {
            var info= new StringBuilder();

            info.Append($"this is {_name}");

            foreach (var child in _children)
            {
                info.Append(child.GetInfo());
            }

            return info.ToString();
        }

        public int GetRevenue()
        {
            throw new System.NotImplementedException();
        }

        public void AddChild(IOrgan organ)
        {
            _children.Add(organ);
        }


    }
}