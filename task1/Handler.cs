using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Handler
    {
        public void ClassTaker(MyClass myClass)
        {
            myClass.SetClassField("changed");
        }

        public void StructTaker(MyStruct myStruct)
        {
            myStruct.SetStructureField("changed");
        }

        public void Execute()
        {
            MyClass instanceClass = new MyClass();
            instanceClass.SetClassField("old string");

            MyStruct instanceStruct = new MyStruct();
            instanceStruct.SetStructureField("old string");

            this.ClassTaker(instanceClass);
            this.StructTaker(instanceStruct);
            Console.WriteLine("Class field " + instanceClass.GetClassField());
            Console.WriteLine("Struct field " + instanceStruct.GetStructureField());
        }
    }
}
