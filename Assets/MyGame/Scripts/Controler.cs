using UnityEngine;
using UnityEngine.SceneManagement;

public class Controler : MonoBehaviour
{
    
    


    public void LoadScene ()
    {
        SceneManager.LoadScene("01Colorscene");

    }

    public void LoadNextSceneAutomated()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void correctAnswer()
    {

    };

}
