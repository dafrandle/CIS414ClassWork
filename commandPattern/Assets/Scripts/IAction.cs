using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public interface IAction
    {
        public PlayerObject PlayerObject { get; set;}
        void Execute();
        void Undo();
    }
}
