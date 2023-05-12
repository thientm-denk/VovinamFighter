using System;
using UnityEngine;

namespace Game
{
  

    public class PlayerAnimationController : MonoBehaviour
    {
        [SerializeField] public PlayerState currenPlayer = PlayerState.Idle;
        [SerializeField] private Animator playerOneAnim;
        


        public void ChangeAnimation(PlayerState nameAnim)
        {
            if (currenPlayer != nameAnim)
            {
                playerOneAnim.ResetTrigger(currenPlayer.ToString());
                playerOneAnim.SetTrigger(nameAnim.ToString());
                currenPlayer = nameAnim;
            }
        }
    }
}