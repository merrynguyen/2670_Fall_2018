using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeCardData : MonoBehaviour
{
	public SaveData save;
	public RecipeCard recipecard;
	public Image Ingredient1;
	public Image Ingredient2;
	public Image Ingredient3;
	public bool ingredient1Complete = false;
	public bool ingredient2Complete = false;
	public bool ingredient3Complete = false;
	public bool recipeComplete = false;
	
	public int currentiteminrecipe = 0;

	public Image checkmark1;
	public Image checkmark2;
	public Image checkmark3;
	
	
	void Start () {
		RefreshRecipe();	
	}

	void Update()
	{
		Checkmarkcheck();
		if (recipeComplete)
		{
			save.points += 1;
			RefreshRecipe();
			recipeComplete = false;
		}
	}

	public void Display()
	{
		Ingredient1.sprite = recipecard.Recipe[0].IngredientSprite;
		Ingredient2.sprite = recipecard.Recipe[1].IngredientSprite;
		Ingredient3.sprite = recipecard.Recipe[2].IngredientSprite;
	}

	public void Checkmarkcheck()
	{
		if (ingredient1Complete)
		{
			checkmark1.gameObject.SetActive(true);
		}
		if (ingredient2Complete)
		{
			checkmark2.gameObject.SetActive(true);
		}
		if (ingredient3Complete)
		{
			checkmark3.gameObject.SetActive(true);
		}

		if (ingredient1Complete && ingredient2Complete && ingredient3Complete)
		{
			recipeComplete = true;
		}
	}

	public void RefreshRecipe()
	{
		recipecard.DeleteRecipe();
		recipecard.CreateRecipe();
		ingredient1Complete = false;
		ingredient2Complete = false;
		ingredient3Complete = false;
		checkmark1.gameObject.SetActive(false);
		checkmark2.gameObject.SetActive(false);
		checkmark3.gameObject.SetActive(false);
		currentiteminrecipe = 0;
		
		Display();
	}
}
