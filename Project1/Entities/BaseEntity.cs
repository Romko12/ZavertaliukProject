using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project1.Entities
{
    public abstract class BaseEntity
    {
        protected string _name;
        public readonly int Id;
        private static int _nextId = 1;
        public BaseEntity(string name)
        {
            Id = _nextId;
            _nextId++;
            _name = name;
        }
         
        public string GetName() => _name;
        public void SetName(string name) => _name = name;



    }
}
