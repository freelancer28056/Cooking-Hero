using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadAsynchronously : MonoBehaviour
{
     AsyncOperation loadingOperation;
    
    [SerializeField]private Slider progressBar;
    // Start is called before the first frame update
    void Start()
    {
        loadingOperation = SceneManager.LoadSceneAsync("Lobby");
    }

    // Update is called once per frame
    void Update()
    {
        if(!loadingOperation.isDone)
        progressBar.value = Mathf.Clamp01(loadingOperation.progress / 0.9f);
    }
}
