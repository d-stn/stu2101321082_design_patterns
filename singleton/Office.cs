using stu2101321082_design_patterns.chain_of_responsibility;
using stu2101321082_design_patterns.factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stu2101321082_design_patterns.singleton {
    internal class Office {
        private static Office _instance;

        // Prevent direct creation of instances
        private Office() { }

        public static Office GetInstance() {
            if (_instance == null ) {
                _instance = new Office();
            }

            return _instance;
        }

        private Handler CreateHandlerChain() {
            Handler plovdivHandler = new PlovdivHandler();
            Handler bulgariaHandler = new BulgariaHandler();
            Handler internationalHandler = new InternationalHandler();

            plovdivHandler.SetNext(bulgariaHandler);
            bulgariaHandler.SetNext(internationalHandler);

            return plovdivHandler;
        }

        public void ProcessPackage(string dest) {
            if (dest == "International") {
                Console.WriteLine($"Received items for international shipping");
            }
            else {
                Console.WriteLine($"Received items for {dest}");
            }
               
            PackageFactory packageFactory = new PackageFactory();
            PackageProduct packageProduct = packageFactory.createProduct(dest);

            if (packageProduct != null) {
                packageProduct.Create();

                Handler chain = CreateHandlerChain();
                chain.Handle(packageProduct);
            }
        }
    }   
}
