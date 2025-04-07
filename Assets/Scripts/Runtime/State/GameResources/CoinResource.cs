using UnityEngine;

public class CoinResource : Resource, IResource
{
    public static CoinResource _instance;

    private void Awake()
    {
        _instance = this;
    }

    public void Add(int _heal)
    {
        throw new System.NotImplementedException();
    }

    public void Check()
    {
        
    }

    public void Remove(int _damage)
    {
        _amount -= _damage;

        if (_amount <= 0) _amount = 0;
    }
}