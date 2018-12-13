using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Store : ScriptableObject
{
    public Object Sunglasses;
    public Object Mustache;
    public Object Knife;
    public List<object> Purchased;
    public int ItemValue;
    public SaveData save;
    
    
    public void Purchase()
    {
        if (save.points >= ItemValue)
        {
            Purchased.Add(Sunglasses);
            save.points -= ItemValue;
        }
    }

    public void AddObjectToGame()
    {
        if (Purchased.Contains(Sunglasses))
        {
            save.unlockSunglasses = true;
        }
        if (Purchased.Contains(Mustache))
        {
            save.unlockSunglasses = true;
        }
        if (Purchased.Contains(Knife))
        {
            save.unlockSunglasses = true; 
        }
    }
}
