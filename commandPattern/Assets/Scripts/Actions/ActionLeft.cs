using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Actions
{
    internal class ActionLeft : MonoBehaviour, IAction
    {
        private PlayerObject player_object;
        public PlayerObject PlayerObject { get => player_object; set => player_object = value; }

        public ActionLeft(PlayerObject player_object)
        {
            PlayerObject = player_object;
        }
        public void Execute()
        {
            if (PlayerObject.CheckMove(new Vector3(-1, 0, 0)))
            {
                PlayerObject.Player.transform.Translate(Vector3.left);
            }
        }
        public void Undo()
        {
            if (PlayerObject.CheckMove(new Vector3(1, 0, 0)))
            {
                PlayerObject.Player.transform.Translate(Vector3.right);
            }
        }

        public override string ToString()
        {
            return "Left Action";
        }   
    }
}
