using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class MoneyUI : MonoBehaviour
{
    public Text moneyText;
    void Update()
    {
        moneyText.text = string.Format("{0:00000}", PlayerStats.Money.ToString());
    }
}
