﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Interpreter.RealWorld
{
    /// <summary>
    /// A 'TerminalExpression' class
    /// <remarks>
    /// Thousand checks for the Roman Numeral M 
    /// </remarks>
    /// </summary>
    public class ThousandExpression : Expression
    {
        public override string Five()
        {
            return " ";
        }

        public override string Four()
        {
            return " ";
        }

        public override int Multiplier()
        {
            return 1000;
        }

        public override string Nine()
        {
            return " ";
        }

        public override string One()
        {
            return "M";
        }
    }
}
