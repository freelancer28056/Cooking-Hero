using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]private GamePlayManagers gamePlayManagers;
    [SerializeField] private LevelData levelData;
    public Transform[] plates;
    public Transform[] juiceMachinesGlass;
    public Transform[] CoffeeMachinesSaucer;
   
    // Start is called before the first frame update
    void Start()
    {
        levelData.FetchData();
        gamePlayManagers.gamePlayManagers.GetComponent<PrepareFood>().SetupTheRestaurent();

    }

    // Update is called once per frame
    void Update()
    {
        #region mobileinput
#if UNITY_ANDROID
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector2 touchPos2D = new Vector2(touchPos.x, touchPos.y);
            RaycastHit2D hit = Physics2D.Raycast(touchPos2D, Vector2.zero);
            if (hit.collider != null)
                gamePlayManagers.gamePlayManagers.GetComponent<PrepareFood>().MakeTheFood(hit.collider.tag);



        }
#endif
#endregion
        #region pcInput

#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if(hit.collider!=null)
            gamePlayManagers.gamePlayManagers.GetComponent<PrepareFood>().MakeTheFood(hit.collider.tag);

        }
#endif
#endregion
    }
}
