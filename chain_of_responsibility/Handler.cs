using stu2101321082_design_patterns.factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stu2101321082_design_patterns.chain_of_responsibility {
    internal abstract class Handler {
        public Handler Next;
        
        public void SetNext(Handler next) => Next = next;
        public abstract void Handle(PackageProduct packageProduct);
    }
}
