using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotDown : MonoBehaviour
{
    public Score scoreObject;
    private void OnTriggerEnter2D(Collider2D shotingObject)
    {
        if (shotingObject.CompareTag("RedBird"))
        {
            Debug.Log("The red bird was shoot.");
            scoreObject.ScoreKazan();
            Destroy(shotingObject.gameObject);
        }

        else if (shotingObject.CompareTag("BlueBird"))
        {
            Debug.Log("The blue bird was shoot.");
            scoreObject.ScoreKazan();
            Destroy(shotingObject.gameObject);
        }

        else if (shotingObject.CompareTag("OrangeBird"))
        {
            Debug.Log("The orange bird was shoot.");
            scoreObject.ScoreKazan();
            Destroy(shotingObject.gameObject);
        }
    }
}
