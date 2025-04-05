using UnityEngine;

namespace Runtime.UI.CharacterSelection
{
    public class CharacterItem : MonoBehaviour
    {
        public Description description;

        [SerializeField]
        private Sprite _characterIcon, _baseWeaponIcon;

        [SerializeField]
        private Runtime.CharacterSelection _characterSelection;

        public void SelectItem()
        {
            _characterSelection.SelectInitialize(this, description._characterName, description._characterDescription, _characterIcon, _baseWeaponIcon);
        }
    }
}