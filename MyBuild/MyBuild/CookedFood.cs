using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuild
{
    public enum CookType { Melted,Fried,Toasted}
    class CookedFood : Food
    {
        private readonly CookType _howCooked;

        public CookedFood(CookType howCooked, String name, FoodType type)
            :base(name,type)
        {
            this._howCooked = howCooked;
        }
        public CookType HowCooked { get { return _howCooked; } }

        public static bool operator ==(CookedFood f1, CookedFood f2)
        {
            return object.Equals(f1, f2);
        }

        public static bool operator !=(CookedFood f1, CookedFood f2)
        {
            return !object.Equals(f1, f2);
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
                return false;
            CookedFood cf = obj as CookedFood;
            return this._howCooked == cf._howCooked;
        }
        public override string ToString()
        {
            return String.Format("{0} {1}", base.ToString(),HowCooked.ToString()); 
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ _howCooked.GetHashCode();
        }
    }
}
