﻿namespace Entities
{
    public class Animal
    {
        public int Id { get; set; }
        public Color Color { get; set; }
        public int Size { get; set; }

        public Animal()
        {

        }

        public Animal(int id, Color color, int size) : this()
        {
            Id = id;
            Color = color;
            Size = size;
        }
    }
}