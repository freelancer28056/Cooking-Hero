using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrepareFood : MonoBehaviour
{
    [SerializeField] private Machineries machineries;
    [SerializeField] private FoodItems foodItems;
    [SerializeField] private LevelData levelData;
    private GameManager gameManager;
    // Start is called before the first frame update
    public void SetupTheRestaurent()
    {
        print("Preparing");
        gameManager = FindObjectOfType<GameManager>();
        switch (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name)
        {
            case "RuralRestaurent":
                for(int i=0;i<levelData.rural_Restuarent_juiceMakerCount;i++)
                    Instantiate(foodItems.juice, gameManager.juiceMachinesGlass[i].position, Quaternion.identity);
                for (int i = 0; i < levelData.rural_Restuarent_coffeeMaker_Count; i++)
                    Instantiate(foodItems.coffee, gameManager.CoffeeMachinesSaucer[i].position, Quaternion.identity);
                for (int i = 0; i < levelData.rural_Restuarent_plate_Count; i++)
                {
                    GameObject plate = Instantiate(machineries.plates[i]);
                    plate.transform.SetParent(GameObject.FindGameObjectWithTag("Plate Tray").transform);
                    plate.transform.localPosition = gameManager.plates[i].localPosition;
                    plate.transform.localScale = gameManager.plates[i].localScale;
                }
                   
                break;
            default:
                break;
        }
       
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
