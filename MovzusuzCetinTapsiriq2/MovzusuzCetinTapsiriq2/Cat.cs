

namespace MovzusuzCetinTapsiriq2
{
    internal class Cat :Animal
    {
        public string name;
        public int age;
        public string type;
        public string breed;
        public string colour;

        public Cat(string name, int age, string type, string breed,string colour)
        {
            this.name = name;
            this.age = age;
            this.type = type;
            this.breed = breed;
        }
        public string GetInfo()
        {
            return $"Name: {name}, Age: {age}, Type: {type}, Breed: {breed}, Colour: {colour}";
        }
    }
}

