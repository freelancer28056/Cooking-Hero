using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrepareFood : MonoBehaviour
{
    [SerializeField] private FoodItems foodItems;
    private GameManager gameManager;
    // Start is called before the first frame update
    public void SetupTheRestaurent()
    {
        print("Preparing");
        gameManager = FindObjectOfType<GameManager>();
        Instantiate(foodItems.juice,gameManager.juiceMachinesGlass[0].position,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MakeTheFood(string itemName)
    {
       switch(itemName)
        {
            case "BurgerMeatStorage":
                break;
            case "BunStorage":
                break;
            default:
                break;
        }
    }
}
