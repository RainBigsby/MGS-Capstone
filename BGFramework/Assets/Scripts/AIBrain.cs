using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBrain : MonoBehaviour
{
    [SerializeField] private Character owner;
    [SerializeField] private GameObject player;
    enum AIState {staticMovement, followPlayer};
    enum MoveDirection {upMove, downMove, leftMove, rightMove};
    [SerializeField] private int currentState;
    [SerializeField] private int currentMoveDirection;
    private float distanceFromPlayer;

    private void Update()
    {
        owner.checkGrounded();
        if(currentState == (int)AIState.staticMovement)
        {
            switch(currentMoveDirection)
            {
                case (int)MoveDirection.upMove:
                    owner.moveCharacterUp();
                    break;

                case (int)MoveDirection.downMove:
                    owner.moveCharacterDown();
                    break;

                case (int)MoveDirection.leftMove:
                    owner.moveCharacterLeft();
                    break;

                case (int)MoveDirection.rightMove:
                    owner.moveCharacterRight();
                    break;
            }
        }

        else if(currentState == (int)AIState.followPlayer)
        {
            distanceFromPlayer = Vector2.Distance(this.transform.position, player.transform.position);
            Vector2 direction = player.transform.position - transform.position;
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, owner.moveSpeed * Time.deltaTime);
        }
        //owner.moveCharacterDown();
        //AIState currentState = (AIState)Random.Range((int)AIState.jump, (int)AIState.moveRight + 1);
        //Invoke("performAction", Random.Range(3, 100));
        /*
        switch(currentState)
        {
            case (int)AIState.jump:
                owner.characterJump();
                break;

            case (int)AIState.moveLeft:
                owner.moveCharacterLeft();
                owner.resetJump();
                break;

            case (int)AIState.moveRight:
                owner.moveCharacterRight();
                owner.resetJump();
                break;
        }
        */

    }

    /*
    private void performAction()
    {
        AIState currentState = (AIState)Random.Range((int)AIState.jump, (int)AIState.moveRight + 1);
        switch (currentState)
        {
            case AIState.jump:
                owner.characterJump();
                //yield return new WaitForSeconds(5);
                break;

            case AIState.moveLeft:
                owner.moveCharacterLeft();
                owner.resetJump();
                //yield return new WaitForSeconds(5);
                break;

            case AIState.moveRight:
                owner.moveCharacterRight();
                owner.resetJump();
                //yield return new WaitForSeconds(5);
                break;
        }
    }*/
}
