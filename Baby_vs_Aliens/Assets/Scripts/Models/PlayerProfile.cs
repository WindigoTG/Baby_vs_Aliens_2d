using UnityEngine;
using Baby_vs_Aliens.Tools;

namespace Baby_vs_Aliens
{
    public class PlayerProfile : MonoBehaviour
    {
        public SubscriptionProperty<GameState> CurrentState { get; }

        public PlayerProfile()
        {
            CurrentState = new SubscriptionProperty<GameState>();
        }
    }
}