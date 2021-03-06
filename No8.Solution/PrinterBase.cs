﻿using System;
using System.IO;
using System.Windows.Forms;

namespace No8.Solution
{
    /// <summary>
    /// Base abstract class whch describes printer
    /// </summary>
    public abstract class PrinterBase
    {
        public abstract string Name { get; set; }
        public abstract string Model { get; set; }

        /// <summary>
        /// For print document
        /// </summary>
        virtual public void Print(string inputText)
        {            
            Console.WriteLine(inputText);
        }

        /// <summary>
        /// Override ToString method for display name and model together
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Name + " " + Model;
    }
}
