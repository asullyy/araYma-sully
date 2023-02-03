using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiatePrefab : MonoBehaviour
{
    private GameObject redePrefab;

    private RaycastHit2D hit;

    private Vector2 _mouse;

    [SerializeField] private LayerMask layer; 

    void Start()
    {
        _mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        hit = Physics2D.Raycast(_mouse, Vector2.zero);
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetMouseButtonDown(0) && hit){
            CriaElementoRede();
        }
    }
    
    private void CriaElementoRede(){
        redePrefab = Resources.Load<GameObject>("armarios_0");

        Instantiate(redePrefab, Vector3.zero, Quaternion.identity);
    }
}
