using UnityEngine;

namespace Runtime.UI.CharacterSelection
{
    [CreateAssetMenu(menuName ="Character/UI_CharacterDescription", fileName = "UI_CharacterItem")]
    public class Description : ScriptableObject
    {
        public string _characterDescription;
        public string _characterName;
    }
}