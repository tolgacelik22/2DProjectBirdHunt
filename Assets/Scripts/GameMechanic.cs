using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMechanic : MonoBehaviour
{
    public GameObject gun, target;

    public float speed;
    public float goBackSpeed;
    private Vector3 oldTarget;
    // Start is called before the first frame update
    void Start()
    {
        oldTarget = gun.transform.position;
    }

    bool isClicked;
    bool targetSuccess;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isClicked = true;
        }

        if(isClicked == true)
        {
            gun.transform.position = Vector3.MoveTowards(gun.transform.position, target.transform.position, speed * Time.deltaTime);
        }

        if(gun.transform.position == target.transform.position)
        {
            targetSuccess = true;
        }

        if(targetSuccess == true)
        {
            gun.transform.position = Vector3.MoveTowards(gun.transform.position, oldTarget, goBackSpeed * Time.deltaTime);
        }

        if(gun.transform.position == oldTarget)
        {
            targetSuccess = false;
            isClicked = false;
        }
    }
}
