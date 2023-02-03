using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkMissaoII : MonoBehaviour
{
    public GameObject obj1;
    public bool checkObj1 = false;

    public GameObject obj2;
    public bool checkObj2 = false;

    public GameObject obj3;
    public bool checkObj3 = false;

    public GameObject obj4;
    public bool checkObj4 = false;

    public GameObject obj5;
    public bool checkObj5 = false;

    public GameObject obj6;
    public bool checkObj6 = false;

    public GameObject obj7;
    public bool checkObj7 = false;

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
        checkObj4 = obj4.GetComponent<checkElement>().checkedTrue;
        checkObj5 = obj5.GetComponent<checkElement>().checkedTrue;
        checkObj6 = obj6.GetComponent<checkElement>().checkedTrue;
        checkObj7 = obj7.GetComponent<checkElement>().checkedTrue;

        if(checkObj1 == true & checkObj2 == true & checkObj3 == true & checkObj4 == true & checkObj5 == true & checkObj6 == true & checkObj7 == true){
            Debug.Log("Elemento checado");
            SceneManager.LoadScene(scene);
        }
    }
}
