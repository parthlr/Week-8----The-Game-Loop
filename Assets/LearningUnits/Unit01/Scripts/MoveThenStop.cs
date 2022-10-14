using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveThenStop : MonoBehaviour
{
    Vector3 moveDirection;
    Vector3 destination;

    // DIRECTIONS: In this Unit, no new code should be written. The goal is to use
    // the existing code lines, rearranged (as in, move line 10 to line 12, and 12 to 10, etc), to get the
    // cube to stop moving when it reaches its destination;

    // Start is called before the first frame update
    void Start()
    {
        moveDirection = new Vector3(.01f, 0, 0);
        destination = transform.position + new Vector3(10, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Moved translate into the if statement and made it move only if the distance was greater than 0.1
        if (Vector3.Distance(transform.position, destination) >= .1f)
        {
            transform.Translate(moveDirection);
        }

        return;
    }
}
