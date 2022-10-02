namespace Entities
{
    public class Dog : Animal
    {
        public string Name { get; set; }
        public string Feature { get; set; }
        public int Leg { get; set; }


        public Dog()
        {

        }
        public Dog(int id, Color color, int size, string name, string feature, int leg) : this()
        {
            Id = id;
            Color = color;
            Size = size;
            Name = name;
            Feature = feature;  
            Leg = leg;  
        }
    }
}