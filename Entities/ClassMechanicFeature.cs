﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ClassMechanicFeature
    {
        public string Class { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string CharacterSheetText { get; set; }


        public ClassMechanicFeature(string Class, string Name, string Text, string CharacterSheetText)
        {
            this.Class = Class;
            this.Name = Name;
            this.Text = Text;
            this.CharacterSheetText = CharacterSheetText;
        }

    }
}
