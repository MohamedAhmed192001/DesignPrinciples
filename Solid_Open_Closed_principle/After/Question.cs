using SOLID_Open_Closed_principle.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Open_Closed_principle.After
{
    internal abstract class Question
    {
        public string Title { get; set; }
        public int Mark { get; set; }
        public abstract void Print();
    }
}


