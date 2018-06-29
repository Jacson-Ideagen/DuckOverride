using System;

namespace DuckOverride
{
    public class Duck : IComparable<Duck>
    {
        public Duck(string name, string type, int weightInGrams, int ageInMonths)
        {
            Name = name;
            Type = type;
            WeightInGrams = weightInGrams;
            AgeInMonths = ageInMonths;

        }

        public string Name { get; }

        public string Type { get; }

        public int WeightInGrams { get; }

        public int AgeInMonths { get; }

        public override int GetHashCode()
        {
            var Hash = WeightInGrams;
            Hash = Hash * 17 + Name.GetHashCode();
            Hash = Hash * 17 + Type.GetHashCode();
            Hash = Hash * 17 + AgeInMonths.GetHashCode();
            return Hash;
        }

        private int GetNamelessHashCode()
        {
            var Hash = WeightInGrams;
            Hash = Hash * 17 + Type.GetHashCode();
            Hash = Hash * 17 + AgeInMonths.GetHashCode();
            return Hash;

        }

        public override bool Equals(object obj)
        {
            try
            {
                return GetNamelessHashCode().Equals(((Duck)obj).GetNamelessHashCode());
            }
            catch
            {
                return false;
            }
        }

        public int CompareTo(Duck other)
        {
            return WeightInGrams.CompareTo(other.WeightInGrams);
        }

        public static bool operator ==(Duck duckLeft, object duckRight)
        {
            return Equals(duckLeft, duckRight);
        }

        public static bool operator !=(Duck duckLeft, object duckRight)
        {
            return !Equals(duckLeft, duckRight);
        }
    }
}
