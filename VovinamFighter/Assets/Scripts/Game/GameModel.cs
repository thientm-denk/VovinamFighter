using UnityEngine;

namespace Game
{
    public class GameModel : MonoBehaviour
    {
        [SerializeField] private float playerMoveSpeed = 2f;

        public float PlayerMoveSpeed => playerMoveSpeed;
    }
}