﻿using System;

namespace Task_2_part_1
{
    public class Tomato : VegetableAndDressing
    {
        public const double WATER = 92;
        public const double PROTEINS = 1.1;
        public const double FATS = 0.2;
        public const double CARBOHYDRATES = 3.8;
        public override double Water
        {
            get { return WATER; }
        }

        public override double Proteins
        {
            get { return PROTEINS; }

        }

        public override double Fats
        {
            get { return FATS; }

        }

        public override double Carbohydrates
        {
            get { return CARBOHYDRATES; }

        }

        public Tomato(String name, String colour, double weight) : base(name, colour, weight)
        {

        }

        public override void Eat()
        {
            Console.WriteLine("\"" + this + "\" has been digested!");
        }
    }
}
