using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AopInDotNet.CastleWindsor
{
    public class King
        : IKing
    {
        public ILogger Logger { get; set; }

        public void RuleTheCastle()
        {
            Logger.Info("Begin RuleTheCastle");
            
        }
    }
}
