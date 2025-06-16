using stu2101321082_design_patterns.factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace stu2101321082_design_patterns.chain_of_responsibility {
    internal class BulgariaHandler : Handler {
        public override void Handle(PackageProduct packageProduct) {
            if (packageProduct is BulgariaPackage) {
                Console.WriteLine("Package was processed by the department for Bulgarian packages.");
            }
            else {
                Next.Handle(packageProduct);
            }
        }
    }
}
