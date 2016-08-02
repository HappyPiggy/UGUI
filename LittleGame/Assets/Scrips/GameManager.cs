using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    

    public void OnStartButtonDown( int index)
    {
        SceneManager.LoadScene(index);
    }

    
}
