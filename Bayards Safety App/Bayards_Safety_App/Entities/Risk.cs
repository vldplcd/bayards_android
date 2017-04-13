using System;
using System.Collections.Generic;
using System.Text;

namespace Bayards_Safety_App.Entities
{
    public class Risk : SafetyObject
    {
        public string Text { get; set; }
        public List<string> Media { get; set; }
    }
}
