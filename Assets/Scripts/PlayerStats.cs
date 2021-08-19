using System.Collections;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //Statik Money sahne değiştirildiğine taşınmasını sağlıyormuş.
    public static int Money;
    public int startMoney = 350;

    public static int Lives;
    public int startLives = 10;

    void Start () 
    {
        Money = startMoney;
        Lives = startLives;
    }
}
