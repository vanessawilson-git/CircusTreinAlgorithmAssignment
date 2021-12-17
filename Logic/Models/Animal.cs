namespace Logic.Classes
{
    public class Animal
    {
        public string Name { get; private set; }

        public Diet Diet { get; private set; }

        public Size Size { get; private set; }

        
        public Animal(string name, Diet diet, Size size)
        {
            Name = name;
            Diet = diet;
            Size = size;
        }

    }
}
