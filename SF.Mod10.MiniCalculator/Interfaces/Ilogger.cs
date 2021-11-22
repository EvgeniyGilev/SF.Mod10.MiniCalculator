using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Mod10.MiniCalculator.Interfaces
{
    public interface ILogger
    {
        public void Event(string message, int severity);


    }
}
