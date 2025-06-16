using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stu2101321082_design_patterns.factory {
    internal class PackageFactory {
        public PackageProduct? createProduct(string dest) {
            switch (dest) {
                case "Plovdiv":
                    return new PlovdivPackage();
                case "Bulgaria":
                    return new BulgariaPackage();
                case "International":
                    return new InternationalPackage();
                default:
                    Console.WriteLine($"Error: destination '{dest}' does not exist.");
                    return null;

            }
        }
    }
}
