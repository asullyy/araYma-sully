using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeImageDicionario : MonoBehaviour
{
    public RawImage theImage;
    public Texture[] myTextures = new Texture [10];
    private int currentItem = 0;
    // Start is called before the first frame update
    void Start()
    {
        theImage.texture = myTextures[currentItem];
    }
    
    public void NextButton(){
        currentItem++;
        if(currentItem > myTextures.Length - 1){
            currentItem = 0;
        }
        theImage.texture = myTextures[currentItem];
    }

    public void BackButton(){
        currentItem--;
        if(currentItem < 0){
            currentItem = 0;
        }
        theImage.texture = myTextures[currentItem];
    }

    /*
    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
