using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="LevelData",menuName ="ScriptableObjects/LevelData",order =3)]
public class LevelData : ScriptableObject
{
    public int rural_Restuarent_juiceMakerCount;
    public int rural_Restuarent_coffeeMaker_Count;
    public int rural_Restuarent_fryingPan_Count;
    public int rural_Restuarent_plate_Count;

    // Start is called before the first frame update
    public void FetchData()
    {
        switch (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name)
        {
            case "RuralRestaurent":
                if (!PlayerPrefs.HasKey("rural_Restuarent_juiceMakerCount"))
                    PlayerPrefs.SetInt("rural_Restuarent_juiceMakerCount", 1);
                else
                    rural_Restuarent_juiceMakerCount = PlayerPrefs.GetInt("rural_Restuarent_juiceMakerCount");
                if (!PlayerPrefs.HasKey("rural_Restuarent_coffeeMaker_Count"))
                    PlayerPrefs.SetInt("rural_Restuarent_coffeeMaker_Count", 1);
                else
                    rural_Restuarent_coffeeMaker_Count = PlayerPrefs.GetInt("rural_Restuarent_coffeeMaker_Count");
                if (!PlayerPrefs.HasKey("rural_Restuarent_fryingPan_Count"))
                    PlayerPrefs.SetInt("rural_Restuarent_fryingPan_Count", 1);
                else
                    rural_Restuarent_fryingPan_Count = PlayerPrefs.GetInt("rural_Restuarent_fryingPan_Count");
                if (!PlayerPrefs.HasKey("rural_Restuarent_plate_Count"))
                    PlayerPrefs.SetInt("rural_Restuarent_plate_Count", 2);
                else
                    rural_Restuarent_plate_Count = PlayerPrefs.GetInt("rural_Restuarent_plate_Count");
                break;
                
        }

        

    }

 
}
