using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalClasses
{
    public class NinjectHub
    {
        public static IKernel Kernel = new StandardKernel();
    }
}
