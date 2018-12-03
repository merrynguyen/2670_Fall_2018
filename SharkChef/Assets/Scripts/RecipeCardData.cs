using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeCardData : MonoBehaviour
{
	public RecipeCard recipecard;
	public Image Ingredient1;
	public Image Ingredient2;
	public Image Ingredient3;
	
	// Use this for initialization
	void Start () {
		recipecard.DeleteRecipe();
		recipecard.CreateRecipe();
		Display();
			
	}

	public void Display()
	{
		Ingredient1.sprite = recipecard.Recipe[0].IngredientSprite;
		Ingredient2.sprite = recipecard.Recipe[1].IngredientSprite;
		Ingredient3.sprite = recipecard.Recipe[2].IngredientSprite;
	}
	
	
}
