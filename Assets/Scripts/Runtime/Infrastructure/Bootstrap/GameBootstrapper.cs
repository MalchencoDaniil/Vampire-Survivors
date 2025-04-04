using UnityEngine;

namespace Runtime.Infrastructure.Bootstrap
{
    public class GameBootstrapper : MonoBehaviour
    {
        private void Update()
        {
            if (Input.anyKeyDown)
                SceneManager.LoadScene(SceneNames.menu);
        }
    }
}