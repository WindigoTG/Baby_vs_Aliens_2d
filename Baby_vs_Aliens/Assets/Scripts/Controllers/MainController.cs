using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Baby_vs_Aliens
{
    public class MainController : BaseController
    {
        PlayerProfile _playerProfile;

        public MainController(PlayerProfile playerProfile)
        {
            _playerProfile = playerProfile;
            OnChangeGameState(_playerProfile.CurrentState.Value);
            playerProfile.CurrentState.SubscribeOnChange(OnChangeGameState);
        }

        private void OnChangeGameState(GameState state)
        {
            switch (state)
            {
                case GameState.Menu:

                    break;
                case GameState.Game:

                    break;
                default:

                    break;
            }
        }

        protected override void OnDispose()
        {
            _playerProfile.CurrentState.UnSubscriptionOnChange(OnChangeGameState);
            base.OnDispose();
        }
    }
}