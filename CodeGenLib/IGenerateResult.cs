﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenLib
{
   public interface IGenerateResult<T>
   {
      T Result { get; }
      object this[string Key] { get; }
   }
}
