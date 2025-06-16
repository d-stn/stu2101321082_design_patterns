using stu2101321082_design_patterns.factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stu2101321082_design_patterns.chain_of_responsibility {
    internal class PlovdivHandler : Handler {
        public override void Handle(PackageProduct packageProduct) {
            if (packageProduct is PlovdivPackage) {
                Console.WriteLine("Package was processed by the local Plovdiv package department.");
            }
            else {
                Next.Handle(packageProduct);
            }
        }
    }
}
