using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int sceneIndex;

    void OnEnable()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
