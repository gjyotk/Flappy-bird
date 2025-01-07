using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public ScoreLogic logic;
    public bool birdIsAlive = true;
    // Start is called before the first frame update. Runs only once
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<ScoreLogic>();
    }

    // Update is called once per frame
    void Update()
    {   if( Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true) {
            myRigidBody.velocity = Vector2.up * flapStrength;
    }
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision){
        logic.gameOver();
        birdIsAlive = false;
    }
}
