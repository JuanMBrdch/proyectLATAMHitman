using Characters;
using Model;
using UnityEngine;
namespace Player
{
    public class CharacterRendererController : MonoBehaviour
    {
        private GameObject m_characterRenderer;
        // Start is called before the first frame update
        void Awake()
        {
        }

        public void InstantiateRenderer(Character character) 
        {
            m_characterRenderer = Instantiate(character.Model);
        }
    }
}
