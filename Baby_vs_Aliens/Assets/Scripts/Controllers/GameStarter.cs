using UnityEngine;

namespace Baby_vs_Aliens
{
    public class GameStarter : MonoBehaviour
    {
        private MainController _mainController;

        private void Awake()
        {
            var playerProfile = new PlayerProfile();
            playerProfile.CurrentState.Value = GameState.Game;
            _mainController = new MainController(playerProfile);
        }

        protected void OnDestroy()
        {
            _mainController?.Dispose();
        }
    }
}