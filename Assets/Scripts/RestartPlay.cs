// using System.Collections;
// using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement; 

public class RestartPlay : MonoBehaviour{
    void OnMouseDown (){
        SceneManager.LoadScene("SampleScene"); 
    }
}
