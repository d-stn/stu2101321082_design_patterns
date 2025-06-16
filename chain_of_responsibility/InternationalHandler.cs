using stu2101321082_design_patterns.factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stu2101321082_design_patterns.chain_of_responsibility {
    internal class InternationalHandler : Handler{
        public override void Handle(PackageProduct packageProduct) {
            if (packageProduct is InternationalPackage) {
                Console.WriteLine("Package was processed by the department for international packages.");
            }
            else {
                Console.WriteLine("No suitable handler could proccess package.");
            }
        }

    }
}
