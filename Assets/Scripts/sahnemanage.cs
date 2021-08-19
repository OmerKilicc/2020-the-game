using UnityEngine;
using UnityEngine.SceneManagement;
public class sahnemanage : MonoBehaviour
{
    public void ReplayButton()
    {
        SceneManager.LoadScene("MainLevel");
    }
    
    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
