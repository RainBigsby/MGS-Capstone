using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBrain : MonoBehaviour
{
    [SerializeField] private Character owner;
    enum AIState {jump, moveLeft, moveRight};

    [SerializeField] private int currentState;

    private void Update()
    {
        owner.checkGrounded();

        //AIState currentState = (AIState)Random.Range((int)AIState.jump, (int)AIState.moveRight + 1);
        Invoke("performAction", Random.Range(3, 100));
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
    }
}
