using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IPhone
    {
        void Show();
        IHead Head { get; set; }
        IMicro Micro { get; set; }
        IPower Power { get; set; }
    }
}
