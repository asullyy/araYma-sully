using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkFaseCompleta : MonoBehaviour
{

    public GameObject obj1;
    public bool checkObj1 = false;
    public string scene;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkObj1 = obj1.GetComponent<checkElement>().checkedTrue;
        if(checkObj1 == true){
            Debug.Log("Elemento checado");
            SceneManager.LoadScene(scene);
        }
    }
}
