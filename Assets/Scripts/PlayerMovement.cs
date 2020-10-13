using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //ne referim la Rigibbody(componenta unui corp pe care o tragem in script cu "rigib"
    public Rigidbody rigidb;
    public float fixedForce = 300f,forwardForce=1500f,sidewayForce=600f;
    void FixedUpdate()
    {
    /*Unity prefera FixedUpdate peste Update + ii bun la chestii de fizica gen force si velocitati
    /fiecare pc are frame rate diferit deci folosim "Time.deltaTime" ca sa mearga la fel la toate*/
        rigidb.AddForce( fixedForce*Time.deltaTime ,0 ,0 ); //adaugi o anumita forta pe axa x(1500),y(0),z(0)
        /*if (Input.GetKey("w"))
        {
            rigidb.AddForce(forwardForce*Time.deltaTime, 0, 0);
        }*/
        if (Input.GetKey("d"))
        {
            rigidb.AddForce(0,0, -sidewayForce * Time.deltaTime,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rigidb.AddForce(0, 0, sidewayForce * Time.deltaTime,ForceMode.VelocityChange);
        }
        if( rigidb.position.y < -0.5f )
        {
            FindObjectOfType<GameManagerS>().GameOver();
        }
    }
}
