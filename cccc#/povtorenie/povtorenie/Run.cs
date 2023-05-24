using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace povtorenie
{
    interface IRun
    {
        float speed { get; set; }

        void RobotRun();
    }
}
