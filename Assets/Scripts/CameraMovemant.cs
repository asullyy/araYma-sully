using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovemant : MonoBehaviour
{
    [Header("Variaveis de Posição")]
    public Transform target;
    public float smoothing;
    public Vector2 maxPosition;
    public Vector2 minPosition;
    
    [Header("Animator")]
    public Animator anim;

    [Header("Position Reset")]
    public VectorValue camMinReset;
    public VectorValue camMaxReset;
    // Start is called before the first frame update
    void Start(){
        minPosition = camMinReset.initialValue;
        maxPosition = camMaxReset.initialValue;
        anim = GetComponent<Animator>();
        transform.position = new Vector3(target.position.x, target.position.y, target.position.z-1);
    }

    
    void LateUpdate(){
        if (transform.position != target.position){
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y,transform.position.z);

            targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x, maxPosition.x);

            targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y, maxPosition.y);

            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);

            
        }
    }

    public void BeginKick(){
        anim.SetBool("kick_active", true);
        StartCoroutine(KickCo());
    }

    public IEnumerator KickCo(){
        yield return null;
        anim.SetBool("kick_active", false);
    }
}
