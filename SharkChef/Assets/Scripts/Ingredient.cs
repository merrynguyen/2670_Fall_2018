using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Ingredient : ScriptableObject
{

    public string ObjName;

    public enum Type
    {
        Carb, Meat, Veggie, Garbage
    }

    public Type type;

    public Sprite IngredientSprite;
}
