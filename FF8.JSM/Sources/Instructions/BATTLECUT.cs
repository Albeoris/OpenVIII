﻿using System;
using FF8.Framework;

namespace FF8.JSM.Instructions
{
    internal sealed class BATTLECUT : JsmInstruction
    {
        public BATTLECUT()
        {
        }

        public BATTLECUT(Int32 parameter, IStack<IJsmExpression> stack)
            : this()
        {
        }

        public override String ToString()
        {
            return $"{nameof(BATTLECUT)}()";
        }
    }
}