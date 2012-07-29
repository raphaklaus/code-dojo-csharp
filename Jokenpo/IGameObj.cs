using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDojoJokenpo
{
    public interface IGameObj
    {
        //IGameObj next;
        string doWin(string param1, string param2);

        IGameObj next { get; set; }
    }
}
