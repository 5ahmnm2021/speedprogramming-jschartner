using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculate : MonoBehaviour
{

    public InputField a;
    public InputField b;
    public Text result;

    public int number1;
    public int number2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
   
    }

    public void addition()
    {
        try
        {
            number1 = int.Parse(a.text);
            a.image.color = new Color32(255, 255, 255, 255);
        }
        catch (System.Exception)
        {
            a.image.color = new Color32(255, 0, 0, 255);
            a.text = "Try a number!";
        }
        try
        {
            number2 = int.Parse(b.text);
            b.image.color = new Color32(255, 255, 255, 255);
        }
        catch (System.Exception)
        {
            b.image.color = new Color32(255, 0, 0, 255);
            b.text = "Try a number!";
        }
        int resultInt = number1 + number2;

        result.text = resultInt.ToString();

        Debug.Log(result);


    }
}

