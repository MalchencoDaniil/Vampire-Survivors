using UnityEngine;

namespace Runtime
{
    public class CurrentTime : MonoBehaviour
    {
        private static float _currentTime = 0;

        public static float gameTime => _currentTime;

        private void Awake()
        {
            _currentTime = 0;
        }

        private void Update()
        {
            _currentTime += Time.deltaTime;
        }
    }
}