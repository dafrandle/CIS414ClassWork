using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    internal class ActionForward : MonoBehaviour, IAction
    {
        private PlayerObject player_object;
        public PlayerObject PlayerObject { get => player_object; set => player_object = value; }

        public ActionForward(PlayerObject player_object)
        {
            PlayerObject = player_object;
        }

        public void Execute()
        {
            if(PlayerObject.CheckMove(new Vector3(0, 0, 1)))
            {
                PlayerObject.Player.transform.Translate(Vector3.forward);
            }
        }
        public void Undo()
        {
            if(PlayerObject.CheckMove(new Vector3(0, 0, -1)))
            {
                PlayerObject.Player.transform.Translate(Vector3.back);
            }
        }

        public override string ToString()
        {
            return "Forward Action";
        }
    }
}
