using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dicionario : MonoBehaviour
{
    public void SetPagina(GameObject pagina){
        pagina.SetActive(true);
        
    }
    public void ClosePagina(GameObject pagina){
        pagina.SetActive(false);
    }


}
