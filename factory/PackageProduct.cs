using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stu2101321082_design_patterns.factory {
    internal abstract class PackageProduct {
        // Destination
        private string dest;

        public string getDest() => dest;

        public void setDest(string dest) => this.dest = dest;

        public abstract void Create();
    }
}
