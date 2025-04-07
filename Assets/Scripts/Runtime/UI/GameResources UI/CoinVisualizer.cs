using UnityEngine;
using UnityEngine.UI;

public class CoinVisualizer : MonoBehaviour
{
    private CoinResource _coinResource;

    private Text _coinText;

    private void Start()
    {
        _coinText = GetComponent<Text>();

        _coinResource = FindObjectOfType<CoinResource>();
    }

    private void Update()
    {
        _coinText.text = _coinResource._amount.ToString();
    }
}