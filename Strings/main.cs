using System;
namespace ImportingFiles
{
    using IS;
    using StringCompair;
    using StrComp;
    using CompairEquals;
    using IndexFunction;
    using AditionalMethodsFunction ;
    using StringManipulation_Program;
}

namespace MainProgram

{
    class ModuleString

    {

        static void Main(string[] args)

        {
            //StrComp.Startswith.CompairStartsWith("João", "João");
            //CompairEquals.Equals.CompairEquals("Tiago","João");
            //IndexFunction.IndexOf.FindIndexOf("Tiago", "T");
            //AditionalMethodsFunction.AddMeth.UsingAddMethods("Tiago");
            StringManipulation_Program.String_Manipulation.Manipulacao();
        }

    }

}