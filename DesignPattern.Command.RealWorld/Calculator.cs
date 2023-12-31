﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command.RealWorld
{
    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    public class Calculator
    {
        int curr = 0;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': curr += operand; break;
                case '-': curr -= operand; break;
                case '*': curr *= operand; break;
                case '/': curr /= operand; break;
            }

            Console.WriteLine("Current value = {0,3} (following {1} {2})", curr, @operator, operand);
        }
    }
}
