using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.Extention
{
   public class CbbItem
    {
        public CbbItem() { }
        public CbbItem(int value, string text)
        {
            this.Value = value;
            this.text = text;
        }
        public int Value { get; set; }

        public string text { get; set; }
        public override string ToString()
        {
            return this.text;
        }
    }
}
