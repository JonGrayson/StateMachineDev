using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingState : IPlayerState
{
    public void Enter(Player player)
    {
        player.m_CurrentState = new StandingState();
        Debug.Log("Standing: Player is standing");
    }

    public void Execute(Player player)
    {
        if (Input.GetKeyDown("w"))
        {
            JumpingState jump = new JumpingState();
            jump.Enter(player);
        }

        if(Input.GetKeyDown("s"))
        {
            DuckingState duck = new DuckingState();
            duck.Enter(player);
        }
    }
}
