using System;
using DefaultNamespace;
using UnityEngine;

namespace Game
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private GameModel model;
        [SerializeField] private GameView view;
        [SerializeField] private Transform playerOne;
        [SerializeField] private PlayerAnimationController playerAnimationController;

        [SerializeField] public PlayerState playerOneState;

        private float _timer;
        // Update is called once per frame
        void Update()
        {
            
            if (Input.GetKeyDown(KeyCode.P))
            {
                playerOneState = PlayerState.KnockDown;
            }
            switch (playerOneState)
            {
                case PlayerState.Idle:
                    HandleInput(); // get input for move if idle
                    break;
                case PlayerState.MoveUp:
                    PlayerOneMove();
                    break;
                case PlayerState.MoveDown:
                    PlayerOneMove();
                    break;
                case PlayerState.StraightHand:
                    
                    AttackStraightHand();
                    break;
                case PlayerState.Kick:
                    
                    AttackKick();
                    break;
                case PlayerState.KnockDown:
                    
                    playerAnimationController.ChangeAnimation(PlayerState.KnockDown);
                    break;
            }
        }

        private float _horizontal = 0;

        private void HandleInput()
        {
            playerAnimationController.ChangeAnimation(PlayerState.Idle);
            _horizontal = Input.GetAxisRaw(Constants.Horizontal);
            _timer = 0f;
            
            // player move
            if (Mathf.Abs(_horizontal) > 0)
            {
                playerOneState = _horizontal > 0
                    ? PlayerState.MoveUp
                    : PlayerState.MoveDown;
                return;
            }
            
            // player attack
            var input = Input.GetAxisRaw(Constants.StraightHand);
            if (input > 0)
            {
                playerOneState = PlayerState.StraightHand;
                return;
            }

            // player attack2
            var input2 = Input.GetAxisRaw(Constants.Kick);
            if (input2 > 0)
            {
                playerOneState = PlayerState.Kick;
                return;
            }

        }

        private void PlayerOneMove()
        {
            _horizontal = Input.GetAxisRaw(Constants.Horizontal);
            var newPos = playerOne.position;
            newPos.x += _horizontal * Time.deltaTime * model.PlayerMoveSpeed;
            if (Mathf.Abs(_horizontal) > 0)
            {
                playerAnimationController.ChangeAnimation(_horizontal > 0
                    ? PlayerState.MoveUp
                    : PlayerState.MoveDown);
                playerOne.position = newPos;
            }
            else
            {
                playerOneState = PlayerState.Idle;
            }
            
        }

        private void AttackStraightHand()
        {
            playerAnimationController.ChangeAnimation(PlayerState.StraightHand);
            _timer += Time.deltaTime;
            if (_timer >= 0.5f)
            {
                playerOneState = PlayerState.Idle;
            }
        }
        
        private void AttackKick()
        {
            playerAnimationController.ChangeAnimation(PlayerState.Kick);
            _timer += Time.deltaTime;
            if (_timer >= 0.83f)
            {
                playerOneState = PlayerState.Idle;
            }
        }
        
    }
}