using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal 
    {

        public Reptile()
        {
            Age = 3;
            Weight = 72;
            HasFur = false;
            Color = $"black";
        }
        public bool PoisionousOrNot { get; set; }
        public int Lifespan  { get; set; }
        public int Length { get; set; }
        public string TypeOfHabitat  { get; set; }


    }
}
