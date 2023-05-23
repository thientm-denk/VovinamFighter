using UnityEngine;

namespace Game
{
    public enum PlayerState
    {
        Idle,
        MoveUp,
        MoveDown,
        StraightHand,
        Kick,
        KnockDown,
        Hook,
    }
    public class GameModel : MonoBehaviour
    {
        [SerializeField] private float playerMoveSpeed = 2f;

        public float PlayerMoveSpeed => playerMoveSpeed;
        
        
    }
}