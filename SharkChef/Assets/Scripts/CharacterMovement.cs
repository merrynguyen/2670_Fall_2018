using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{


    private CharacterController controller;
    public MovePattern Pattern;
    public Pantry pantry;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Pattern.Invoke(controller, transform);
    }

    void OnTriggerEnter(Collider other)
    {
        /*if (other.gameObject.CompareTag("food"))
        {
            other.gameObject.SetActive(false);
            Debug.Log("hello");
        }*/





        int ingredientype = (int)other.gameObject.GetComponent<IngredientData>().IngredientObj.type;

        switch (ingredientype)
       
        {
            
            case 0: 
                print("I am a carb.");
                
                pantry.carbNum++;
                print("Carb Number "+pantry.carbNum);
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
        other.gameObject.SetActive(false);
        
        
    }
    
  
}