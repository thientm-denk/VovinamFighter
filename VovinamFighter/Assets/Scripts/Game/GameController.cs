
using DefaultNamespace;
using UnityEngine;

namespace Game
{
    public class GameController : MonoBehaviour
    {

        [SerializeField] private GameModel model;
        [SerializeField] private GameView  view;
        [SerializeField] private Transform playerOne;
        [SerializeField] private PlayerAnimationController playerAnimationController;

        // Update is called once per frame
        void Update()
        {
            PlayerOneMove();
        }

        private void PlayerOneMove()
        {
            var horizontal = Input.GetAxisRaw(Constants.Horizontal);
            var newPos = playerOne.position;
            
            newPos.x += horizontal * Time.deltaTime * model.PlayerMoveSpeed;
            if (Mathf.Abs(horizontal) > 0)
            {
                playerAnimationController.ChangeAnimation(horizontal > 0
                    ? AnimationState.MoveUp
                    : AnimationState.MoveDown);
            }
            else
            {
                playerAnimationController.ChangeAnimation(AnimationState.Idle);
            }
            playerOne.position = newPos;
        }
        
        
    }
}
