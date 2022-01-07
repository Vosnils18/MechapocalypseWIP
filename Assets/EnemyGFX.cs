using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    public AIPath aiPath;
    public string direction;

    // Update is called once per frame
    void Update()
    {
        if(aiPath.desiredVelocity.x >= 0.01f && aiPath.desiredVelocity.y >=0.01f) {
            direction = "upRight";
            transform.localScale = new Vector3(-5f, -5f, 0f);
        } else if(aiPath.desiredVelocity.x <= -0.01f && aiPath.desiredVelocity.y >= 0.01f) {
            direction = "upLeft";
            transform.localScale = new Vector3(5f, -5f, 0f);
        } else if(aiPath.desiredVelocity.x >= 0.01f && aiPath.desiredVelocity.y <= -0.01f) {
            direction = "downRight";
            transform.localScale = new Vector3(-5f, 5f, 0f);
        } else if(aiPath.desiredVelocity.x <= -0.01f && aiPath.desiredVelocity.y <= -0.01f) {
            direction = "downLeft";
            transform.localScale = new Vector3(5f, 5f, 0f);
        } else if(aiPath.desiredVelocity.x >= 0.01f) {
            direction = "right";
            transform.localScale = new Vector3(-5f, 5f, 0f);
        } else if(aiPath.desiredVelocity.x <= -0.01f) {
            direction = "left";
            transform.localScale = new Vector3(5f, 5f, 0f);
        }else if(aiPath.desiredVelocity.y >= 0.01f) {
            direction = "up";
            transform.localScale = new Vector3(5f, -5f, 0f);
        } else if(aiPath.desiredVelocity.y <= -0.01f) {
            direction = "down";
            transform.localScale = new Vector3(5f, 5f, 0f);
        }
        print(direction);
    }
}
