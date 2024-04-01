using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsManager : MonoBehaviour
{
    private GameObject player;
    public static ItemsManager instance;
    private int scoreHearts;
    private int scoreSpinCoins;
    private int scoreShineCoins;

    private void Awake()
    {
        instance = this;
    }

    public void AddScoreHeart()
    {
        scoreHearts++;
        if(scoreHearts == 1) { Debug.Log("He recogido: " + scoreHearts + " corazón"); }
        if (scoreHearts >= 2) { Debug.Log("He recogido: " + scoreHearts + " corazones"); }
        if (scoreHearts == 5)
        {
            GameObject.Find("Player").GetComponent<PlayerExtrasTracker>().CanDoubleJump = true;
            Debug.Log("Ahora puedo saltar");
        }
    }

    public void AddScoreCoinShine()
    {
        scoreShineCoins++;
        if (scoreShineCoins == 1) { Debug.Log("He recogido: " + scoreShineCoins + " moneda brillante"); }
        if (scoreShineCoins >= 2) { Debug.Log("He recogido: " + scoreShineCoins + " monedas brillantes"); }
        if (scoreShineCoins == 10)
        {
            GameObject.Find("Player").GetComponent<PlayerExtrasTracker>().CanEnterBallMode = true;
            GameObject.Find("Player").GetComponent<PlayerExtrasTracker>().CanDropBombs = true;
            Debug.Log("Ahora puedo tirar bombas y agacharme");
        }
    }

    public void AddScoreCoinSpin()
    {
        scoreSpinCoins++;
        if (scoreSpinCoins == 1) { Debug.Log("He recogido: " + scoreSpinCoins + " moneda girando"); }
        if (scoreSpinCoins >= 2) { Debug.Log("He recogido: " + scoreSpinCoins + " monedas girando"); }
        if (scoreSpinCoins == 6)
        {
            GameObject.Find("Player").GetComponent<PlayerExtrasTracker>().CanDash = true;
            Debug.Log("Ahora puedo hacer dash");
        }
    }

}
