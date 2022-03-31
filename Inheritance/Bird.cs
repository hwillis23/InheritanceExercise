using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Age = 2;
            Weight = 18;
            HasFur = false;
            Color = $"blue";
  
        }
        public bool CanFly  { get; set; }
        public bool CanTalk  { get; set; }
        public int WingSpane  { get; set; }
        public string WingColor { get; set; }

    }

}
