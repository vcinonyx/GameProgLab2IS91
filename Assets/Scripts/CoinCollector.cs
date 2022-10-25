using TMPro;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinScoreText;
    private int _currentCoins = 0;

    private void Awake()
    {
        SetTextScore();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            _currentCoins += 10;
            SetTextScore();
        }
    }

    private void SetTextScore()
    {
        coinScoreText.text = $"SCORE: {_currentCoins}";
    }
}
