using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuild
{
    public enum FoodType { Fat, Carb, Fruit, Veg,}
    class Food
    {
        private readonly String _foodName;
        private readonly FoodType _foodType;

        public Food(string aName, FoodType aFoodType)
        {
            _foodName = aName;
            _foodType = aFoodType;
        }

        public String FoodName { get { return _foodName; } }
        public FoodType FoodType { get { return _foodType; } }

        public override string ToString()
        {
            return FoodName;
        }

        public static bool operator ==(Food f1, Food f2)
        {
            return object.Equals(f1,f2);
        }

        public static bool operator !=(Food f1, Food f2)
        {
            return !object.Equals(f1, f2);
        }

        public override bool Equals(object obj)
        {
            
            if (obj == null)
                return false;
            //The same object reference and so is true
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Food food = obj as Food;
            return this._foodName == food._foodName && this._foodType == food._foodType;
        }

        public override int GetHashCode()
        {
            return this._foodType.GetHashCode() ^ this._foodName.GetHashCode();
        }
    }
}
