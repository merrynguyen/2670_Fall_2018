using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
[CreateAssetMenu]
public class RecipeCard : ScriptableObject
{
    public List<Ingredient> IngList;
    public List<Ingredient> Recipe;

    public void CreateRecipe()
    {
        for (int i = 0; i < 3; i++)
        {
             int IngNum = Random.Range(0, IngList.Count - 1);
                    Recipe.Add(IngList[IngNum]);
            Debug.Log(Recipe[i].type);
        }

       

    }


}
