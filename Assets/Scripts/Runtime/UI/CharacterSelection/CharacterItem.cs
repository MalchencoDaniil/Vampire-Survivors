using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Runtime.UI.CharacterSelection
{
    public class CharacterItem : Product
    {
        private Button _itemButton;

        public Description description;

        public CharacterItemState _itemState;

        [SerializeField]
        private Sprite _characterIcon, _baseWeaponIcon;

        [SerializeField]
        private Runtime.CharacterSelection _characterSelection;

        [SerializeField]
        private Button _buyButton;

        private void Start()
        {
            _itemButton = GetComponent<Button>();

            bool _canInteractable = _itemState.characterState == CharacterItemState.CharacterState.Purchased ? true : false;
            _itemButton.interactable = _canInteractable;


            _buyButton.onClick.AddListener(() => CharacterShop.instance.Buy(this));
            _buyButton.gameObject.SetActive(!_canInteractable);
        }

        public void SelectItem()
        {
            _characterSelection.SelectInitialize(this, description._characterName, description._characterDescription, _characterIcon, _baseWeaponIcon);
        }

        public override void UnLocked()
        {
            if (CoinResource._instance._amount < _itemState._price)
                return;

            CoinResource._instance.Remove(_itemState._price);

            _itemState.characterState = CharacterItemState.CharacterState.Purchased;
            _itemButton.interactable = true;

            PlayerPrefs.SetInt(PrefsNames.characterBuyState,(int)_itemState.characterState);
            _buyButton.gameObject.SetActive(false);
        }
    }
}