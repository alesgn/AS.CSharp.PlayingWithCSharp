//DIRECTIVE: Using - allow us to write less code. It preappend the defined namespace to class name to get the fully qualified Class name.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics //NAMESPACE: logical separation of classes
{
    //TYPE and INSTANCES
    class Program //CLASS DECLARATION
    {
        static void Main(string[] args) //METHOD DECLARATION
        {
            //COMMENT: Single line

            /*COMMENT: multi 
                       line */

            //STATEMENT: single code line ended by a semicolon
            var literalExpression = 12 * 3;

            //CODE BLOCK: multi code line ended by a semicolon



            //Avoid keyword conflict: use a keyword as a variable name.
            var @class = "ciao";

            //Contextual keyword
            var await = "ola";

            }

        public 
        static
        int                 //RETURN TYPE
        GetDoubleResult(
            int operand)    //ARGUMENT
        {   //PUNCTUATORS: braces (contain statement blocks) and semicolon

            //STATEMENT BLOCK:   
            const int constantValue = 1;    //CONSTANT: always represent same value

            var result          //LOCAL VARIABLE: denotes storage location for different values over time
                    =           //ASSIGNMENT OPERATOR
                    //EXPRESSION
                    operand 
                    *           //OPERATOR: transforms and combine expressions (. () * + -)
                    2;          //LITERAL: primitive pieces of data embedded in the code

            return result;
        }

        //EQUALITY COMPARISON
        
        
        
        //PARAMETER

        //FUNCTIONS: OPERATOR, CONSTRUCTOR, PROPERTY, EVENT, INDEXER, FINALIZER

        //IDENTIFIERS: names used for programmer custom classes, variables,... Case sensitive, whole unicode word, no spaces
        
        //KEYWORDS: names that mean something for compiler (using, class). They are RESERVED, not usable for Indetifiers
        
        //abstract
        //as
        //base
        //bool
        //break
        //byte
        //case
        //catch
        //char
        //checked
        //class
        //const
        //continue
        //decimal
        //default
        //delegate
        //do
        //double
        //else
        //enum
        //event
        //explicit
        //extern
        //false
        //finally
        //fixed
        //float
        //for
        //foreach
        //goto
        //if
        //implicit
        //in
        //int
        //interface
        //internal
        //is
        //lock
        //longnamespace
        //new
        //null
        //object
        //operator
        //out
        //override
        //params
        //private
        //protected
        //public
        //readonly
        //ref
        //return
        //sbyte
        //sealed
        //short
        //sizeof
        //stackalloc
        //static
        //string
        //struct
        //switch
        //this
        //throw
        //true
        //try
        //typeof
        //uint
        //ulong
        //unchecked
        //unsafe
        //ushort
        //using
        //virtual
        //void
        //volatile
        //while


        //CONTEXTUAL KEYWORDS: usable as identifier outside the context where they are keywords

        //add
        //ascending
        //async
        //await
        //by
        //descending
        //dynamic
        //equals
        //from
        //get
        //global
        //group
        //in
        //into
        //join
        //let
        //nameof
        //on
        //orderby
        //partial
        //remove
        //select
        //set
        //value
        //var
        //when
        //where
        //yield

    }
}
