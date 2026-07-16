using UnityEngine;

public class Player_MoveState : Player_GroudedState
{
    public Player_MoveState(Player player, StateMachine stateMachine, string stateName) : base(player, stateMachine, stateName)
    {
    }

    public override void Update()
    {
        base.Update();

        if (player.moveInput.x == 0  || player.wallDetected)
            stateMachine.ChangeState(player.idleState);

        player.setVelocity(player.moveInput.x * player.moveSpeed, rb.linearVelocity.y);
    }
}
