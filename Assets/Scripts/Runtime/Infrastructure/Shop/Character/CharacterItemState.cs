using UnityEngine;

[CreateAssetMenu(menuName = "Character/CharacterItemState", fileName = "CharacterItemState")]
public class CharacterItemState : ScriptableObject
{
    public enum CharacterState
    {
        Purchased,
        NotPurchased
    }

    public CharacterState characterState;

    public int _price;

    private void Awake()
    {
        characterState = (CharacterState)PlayerPrefs.GetInt(PrefsNames.characterBuyState);
    }
}