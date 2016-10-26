using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//PREDEFINED TYPES or BUILT-IN TYPES: all CLS types which have a keyword associated (int, string,... no DateTime)
namespace CSharpBasics
{
    public class PredefinedTypes
    {

        private int GetInt()
        {
            //INT: represents 32 bits integers, from −2^31 to 2^31−1 (-2147483648 a +2147483647). Default type for numeric literals within this range.
            return 12;
        }

        private string GetString()
        {
            //STRING: represents a sequence of characters
            string message = "Hello world";
            string upperMessage = message.ToUpper();
            
            return upperMessage;
        }

        private bool GetBool()
        {
            //BOOL: has exactly two possible values: true and false.
            bool simpleVar = false;
            return simpleVar;
        }
    }
}
