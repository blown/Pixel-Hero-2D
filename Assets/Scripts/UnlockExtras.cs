using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockExtras : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private PlayerExtrasTracker playerExtrasTracker;
    [SerializeField] public bool canDoubleJump, canDash, canEnterBallMode, canDropBombs;

    private void Start()
    {
        player = GameObject.Find("Player");
        playerExtrasTracker=player.GetComponent<PlayerExtrasTracker>();
    }

    private void SetTracker()
    {
        if (canDoubleJump) playerExtrasTracker.CanDoubleJump = true;
        if (canDash) playerExtrasTracker.CanDash = true;
        if (canEnterBallMode) playerExtrasTracker.CanEnterBallMode = true;
        if (canDropBombs) playerExtrasTracker.CanDropBombs = true;
    }

}
