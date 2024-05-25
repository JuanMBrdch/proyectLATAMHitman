using Characters;
using Player;
using UnityEngine;
namespace Model
{
    public class PlayerModel : MonoBehaviour
    {

        //TODO: Move after
        public string CharacterDataID = "PlayerCharacter";


        public PlayerEntity Entity
        {
            get { return new PlayerEntity(); }
        }

        public static PlayerModel LocalPlayerModel;

        private void Awake()
        {
            LocalPlayerModel = GetComponent<PlayerModel>();

            Entity.CharacterData = Character.GetCharacter(CharacterDataID);
        }



    }
}
