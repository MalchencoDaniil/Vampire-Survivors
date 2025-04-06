using UnityEngine;

public abstract class Resource : ScriptableObject
{
    public string _name;

    public int _amount;

    public virtual void Add(int amount) => _amount += amount;

    public virtual bool TrySubtract(int amount)
    {
        if (_amount >= amount)
        {
            _amount -= amount;
            return true;
        }

        return false;
    }
}