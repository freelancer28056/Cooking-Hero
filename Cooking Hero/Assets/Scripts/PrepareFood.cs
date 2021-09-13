using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrepareFood : MonoBehaviour
{
    [SerializeField] private FoodItems foodItems;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MakeTheFood(string itemName)
    {
        Debug.Log(itemName);
    }
}
