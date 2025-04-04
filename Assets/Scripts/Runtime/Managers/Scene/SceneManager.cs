using UnityEngine;

namespace Runtime
{
    public class SceneManager : MonoBehaviour
    {
        public static void LoadScene(string _sceneName)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneName);
        }
    }
}
