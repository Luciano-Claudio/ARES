using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void OnChange(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
