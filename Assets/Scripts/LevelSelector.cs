using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public void Select (string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
