using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{


    private CharacterController controller;
    public MovePattern Pattern;
    public Pantry pantry;
    public GameObject RecipeCardHolder;
    public RecipeCardData recipeCard;
   

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        recipeCard = RecipeCardHolder.GetComponent<RecipeCardData>();
    }
    

    void Update()
    
    {
        Pattern.Invoke(controller, transform);
        if (transform.position.z != 0)
        {
            
            Vector3 pos = transform.position;
            pos.z = 0;
            transform.position = pos;
        }
    }



    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.GetComponent<IngredientData>().IngredientObj.type ==
            recipeCard.recipecard.Recipe[recipeCard.currentiteminrecipe].type)
        {
            
            if (recipeCard.currentiteminrecipe == 0)
            {
                recipeCard.ingredient1Complete = true;
            }

            if (recipeCard.currentiteminrecipe == 1)
            {
                recipeCard.ingredient2Complete = true;
            }

            if (recipeCard.currentiteminrecipe == 2)
            {
                recipeCard.ingredient3Complete = true;
            }

            if (recipeCard.currentiteminrecipe < 2)
            {
                recipeCard.currentiteminrecipe += 1;
            }

        }


        int ingredientype = (int) other.gameObject.GetComponent<IngredientData>().IngredientObj.type;
        

        switch (ingredientype)

        {
            case 0:
                print("I am a carb.");

                pantry.carbNum++;
                print("Carb Number " + pantry.carbNum);
                break;
            case 1:
                print("I am a meat.");
                pantry.meatNum++;
                print("Meat Number " + pantry.meatNum);
                break;
            case 2:
                print("I am a veggie.");
                pantry.veggieNum++;
                print("Veggie Number " + pantry.veggieNum);
                break;
            case 3:
                print("I am garbage.");
                break;
        }
        /*other.gameObject.SetActive(false);
        
        {
            if (other.gameObject.CompareTag("Kill"))
            {
                Debug.Log("player is dead");
            }
        
    }*/




    }
}