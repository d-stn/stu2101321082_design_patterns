using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stu2101321082_design_patterns.factory {
    internal class InternationalPackage : PackageProduct {
        public override void Create() => Console.WriteLine("Created an international package!");
    }
}
