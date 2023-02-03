using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkFase3itens : MonoBehaviour
{
    public GameObject obj1;
    public bool checkObj1 = false;

    public GameObject obj2;
    public bool checkObj2 = false;

    public GameObject obj3;
    public bool checkObj3 = false;

    public string scene;
    
    //int countCheck = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkObj1 = obj1.GetComponent<checkElement>().checkedTrue;
        checkObj2 = obj2.GetComponent<checkElement>().checkedTrue;
        checkObj3 = obj3.GetComponent<checkElement>().checkedTrue;

        if(checkObj1 == true & checkObj2 == true & checkObj3 == true){
            Debug.Log("Elemento checado");
            SceneManager.LoadScene(scene);
        }
    }
}
