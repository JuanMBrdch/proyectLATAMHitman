using Player;
using UnityEngine;
namespace Model
{
    public class PlayerModel : MonoBehaviour
    {
        public PlayerEntity Entity
        {
            get { return new PlayerEntity(); }
        }

        public static PlayerModel LocalPlayerModel;

        private void Awake()
        {
            LocalPlayerModel = GetComponent<PlayerModel>();
        }
    }
}
