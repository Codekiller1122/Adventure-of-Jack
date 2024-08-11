using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public Text coinText;  // Reference to a UI text component to display the coin count
    private int coinCount = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddCoins(int amount)
    {
        coinCount += amount;
        UpdateCoinText();
    }

    private void UpdateCoinText()
    {
        coinText.text = "Coins: " + coinCount;
    }
}


