using System;
using UnityEngine;
using UnityEngine.UI;

namespace Runtime.UI
{
    public class TimeVisualizer : MonoBehaviour
    {
        [SerializeField]
        private Text _timeText;

        private void Update()
        {
            TimeSpan _timeSpan = TimeSpan.FromSeconds(CurrentTime.gameTime);
            string _currentTime = string.Format("{0:D2}:{1:D2}:{2:D2}", _timeSpan.Hours, _timeSpan.Minutes, _timeSpan.Seconds);

            _timeText.text = _currentTime;
        }
    }
}