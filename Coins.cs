using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;  // Value of each coin
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CollectCoin();
        }
    }

    private void CollectCoin()
    {
        // Add the coin value to the player's total score
        GameManager.Instance.AddCoins(coinValue);

        // Destroy the coin object
        Destroy(gameObject);
    }
}



