using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Singleton
    {
        public static readonly DemoEntities demoEntities = new DemoEntities();
    }
}
