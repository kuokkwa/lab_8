﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3.Components;

namespace Task_3.ProcessorType
{
    public class IntelCore : Processor
    {
        public override string GetDescription()
        {
            return "Intel Core";
        }
    }
}
