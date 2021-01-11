using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int numberOfCoins;

    public static Inventory instance;

    private void Awake()
    {
        instance = this;
    }

    public void addCoins(int numberOfCoins)
    {
        this.numberOfCoins += numberOfCoins;
    }

    public int getOnesDigitOfNumberOfCoins()
    {
        return numberOfCoins % 10;
    }

    public int getTensDigitOfNumberOfCoins()
    {
        return Mathf.FloorToInt(numberOfCoins / 10) % 10;
    }

    public int getHundredsDigitOfNumberOfCoins()
    {
        return Mathf.FloorToInt(numberOfCoins / 100) % 10;
    }
}
