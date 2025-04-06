using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Runtime
{
    public class CharacterSelection : MonoBehaviour
    {
        [SerializeField]
        private Transform _descriptionView;

        [SerializeField]
        private Image _characterIcon, _baseWeaponIcon;

        [SerializeField]
        private Text _descriptionText, _nameText;

        [SerializeField]
        private List<UI.CharacterSelection.CharacterItem> _characterItems = new List<UI.CharacterSelection.CharacterItem>();

        private void Start()
        {
            _descriptionView.gameObject.SetActive(false);
        }

        public void SelectInitialize(UI.CharacterSelection.CharacterItem _characterItem, string _characterName, string _description, Sprite _characterIcon, Sprite _baseWeaponIcon)
        {
            _descriptionView.gameObject.SetActive(true);

            _nameText.text = _characterName;
            _descriptionText.text = _description;

            this._characterIcon.sprite = _characterIcon;
            this._baseWeaponIcon.sprite = _baseWeaponIcon;

            PlayerPrefs.SetInt(PrefsNames.characterIndex, _characterItems.IndexOf(_characterItem));
        }
    }
}