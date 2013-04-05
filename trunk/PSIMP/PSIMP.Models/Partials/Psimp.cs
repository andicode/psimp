using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSIMP.Models
{
    public abstract partial class Psimp
    {
        public bool IsAdd()
        {
            return this.Id == default(long);
        }
    }
}
