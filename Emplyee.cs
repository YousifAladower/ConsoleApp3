using System;

namespace ConsoleApp3
{
    public class Emplyee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public string description { get; set; }
       

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 19;
                hash = hash * 397 + id.GetHashCode();
                hash = hash * 397 + name.GetHashCode();
                return hash;
            }
            
        }
        public override bool Equals(object obj)
        {
            var  emplyee = obj as Emplyee;

            if (emplyee is null)
                return false;
            return this.name.Equals(emplyee.name, StringComparison.OrdinalIgnoreCase) && this.id.Equals(emplyee.id);
           // return base.Equals(obj);
        }
        public override string ToString()
        {
            return $"{id} -~ {name}-~ {age}";
        }
    }
}
 