using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WrongAnswer : MonoBehaviour
{

    public Button a;
 



    public void FalseAnswer()
    {
        
           
            a.image.color = new Color32(255, 0, 0, 255);
            
            


    }

}

