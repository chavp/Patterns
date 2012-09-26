using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PatternsFixture
{
    using fit;
    using Patterns.Examples;

    public class SetUpTestEnvironment : ColumnFixture
    {
        internal static IPlayerManager playerManager;
        internal static IDrawManager drawManager;

        public SetUpTestEnvironment()
        {
            playerManager = new PlayerManager();
            drawManager = new DrawManager();

        }
        public DateTime CreateDraw
        {
            set
            {
                drawManager.CreateDraw(value);
            }
        }
    }

    
}
