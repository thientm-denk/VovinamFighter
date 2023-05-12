using System;
using UnityEngine;

namespace Game
{
    public enum AnimationState
    {
        Idle,
        MoveUp,
        MoveDown
    }

    public class PlayerAnimationController : MonoBehaviour
    {
        [SerializeField] private AnimationState currenAnimation;
        [SerializeField] private Animator playerOneAnim;

        private static readonly int Idle = Animator.StringToHash("Idle");
        private static readonly int MoveUp = Animator.StringToHash("MoveUp");
        private static readonly int MoveDown = Animator.StringToHash("MoveDown");


        public void ChangeAnimation(AnimationState nameAnim)
        {
            if (currenAnimation != nameAnim)
            {
                playerOneAnim.ResetTrigger(currenAnimation.ToString());
                playerOneAnim.SetTrigger(nameAnim.ToString());
                currenAnimation = nameAnim;
            }
        }
    }
}