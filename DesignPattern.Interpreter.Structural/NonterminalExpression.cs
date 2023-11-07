using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Interpreter.Structural
{
    /// <summary>
    /// The 'NonterminalExpression' class
    /// </summary>
    public class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Nonterminal.Interpret()");
        }
    }
}
