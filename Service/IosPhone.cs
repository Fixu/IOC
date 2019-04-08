using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Service
{
    public class IosPhone : IPhone
    {
        
        public IHead Head { get; set; }
        public IMicro Micro { get; set; }
        [Dependency]
        public IPower Power { get; set; }

        [InjectionConstructor]
        public IosPhone(IHead head)
        {
            this.Head = head;
            Console.WriteLine();
        }
        public void Show()
        {
            Console.WriteLine($"this is IosPhone{this.GetType()}");
        }
        [InjectionMethod]
        public void UseMicro(IMicro micro)
        {
            this.Micro = micro;
            Console.WriteLine($" this is useMicro{micro.GetType()}");
        }
    }
}
