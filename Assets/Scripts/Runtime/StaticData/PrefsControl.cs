using UnityEngine;

public class PrefsControl : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
            PlayerPrefs.DeleteAll();
    }
}