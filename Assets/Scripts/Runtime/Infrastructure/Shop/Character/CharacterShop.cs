using UnityEngine;

public class CharacterShop : MonoBehaviour, IShop
{
    public static CharacterShop instance;

    private void Awake()
    {
        instance = this;
    }

    public void Buy(Product _product)
    {
        _product.UnLocked();
    }

    public void Cancel()
    {
        throw new System.NotImplementedException();
    }
}