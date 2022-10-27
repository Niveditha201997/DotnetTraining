using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharptraining
{
    public abstract class  Mobile
    {
        private int IMENo;
        public String Model { get; set; }
        public int Year { get; set; }
    }

    public class Nokia : Mobile
    {
        public void Nokiaonfig() { }
    }
    public class Samsung : Mobile
    {
        public void Samsungfig() { }
    }
}
