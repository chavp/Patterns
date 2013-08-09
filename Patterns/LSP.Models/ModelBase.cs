using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Models
{
    public abstract class ModelBase : ICloneable
    {
        #region Public Method
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    }
}
