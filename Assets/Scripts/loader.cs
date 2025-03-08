using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loader : MonoBehaviour
{

    public GameObject player;
    public GameObject dpoint;
    bool isCoroutineStarted = false;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadYourAsyncScene1());
    }

    // Update is called once per frame
    void Update()
    {
        // Press the space key to start coroutine
         //if(!isCoroutineStarted)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Use a coroutine to load the Scene in the background
            //StartCoroutine(LoadYourAsyncScene1());
        }

if (Input.GetKeyDown(KeyCode.N))
        {
            // Use a coroutine to load the Scene in the background
            // StartCoroutine(MovePlayer());
        }
    }

   IEnumerator MovePlayer()
    {
        player.transform.position = dpoint.transform.position;

        yield return null;
    }

    IEnumerator LoadYourAsyncScene1()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.


        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);


        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        AsyncOperation asyncLoad2 = SceneManager.LoadSceneAsync(2, LoadSceneMode.Additive);
        while (!asyncLoad2.isDone)
        {
            yield return null;
        }

         AsyncOperation asyncLoad3 = SceneManager.LoadSceneAsync(3, LoadSceneMode.Additive);
        while (!asyncLoad3.isDone)
        {
            yield return null;
        }

        AsyncOperation asyncLoad4 = SceneManager.LoadSceneAsync(4, LoadSceneMode.Additive);
        while (!asyncLoad3.isDone)
        {
            yield return null;
        }

        AsyncOperation asyncLoad5 = SceneManager.LoadSceneAsync(5, LoadSceneMode.Additive);
        while (!asyncLoad3.isDone)
        {
            yield return null;
        }

        AsyncOperation asyncLoad6 = SceneManager.LoadSceneAsync(6, LoadSceneMode.Additive);
        while (!asyncLoad3.isDone)
        {
            yield return null;
        }

        AsyncOperation asyncLoad7 = SceneManager.LoadSceneAsync(7, LoadSceneMode.Additive);
        while (!asyncLoad3.isDone)
        {
            yield return null;
        }

        AsyncOperation asyncLoad8 = SceneManager.LoadSceneAsync(8, LoadSceneMode.Additive);
        while (!asyncLoad3.isDone)
        {
            yield return null;
        }

        AsyncOperation asyncLoad9 = SceneManager.LoadSceneAsync(9, LoadSceneMode.Additive);
        while (!asyncLoad3.isDone)
        {
            yield return null;
        }

        isCoroutineStarted = true;
        Debug.Log("isCoroutineStart = true");

    }

    

     
}
