using UnityEngine;

public class Player_JumpAttackState : EntityState
{
    private bool touchedGround;
    public Player_JumpAttackState(Player player, StateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {

    }

    public override void Enter()
    {
        base.Enter();
        touchedGround = false;

        player.setVelocity(player.jumpAttackVelocity.x * player.facingDir, player.jumpAttackVelocity.y);
    }

    public override void Update()
    {
        base.Update();

        if(player.groundDetected && touchedGround == false)
        {
            touchedGround = true;
            anim.SetTrigger("jumpAttackTrigger");
            player.setVelocity(0, rb.linearVelocity.y);
        }

        if (triggerCalled && player.groundDetected)
            stateMachine.ChangeState(player.idleState);
    }
}
