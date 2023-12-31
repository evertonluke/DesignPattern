﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Interpreter.Structural
{
    /// <summary>
    /// The 'AbstractExpression' abstract class
    /// </summary>
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}
