using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisAndThat : MonoBehaviour
{
    [SerializeField] GameObject blueCube, redCube, door;

    bool isRedCubeDetected, isBlueCubeDeteced, areBothCubesDetected;

    // DIRECTIONS: This script is missing a crucial "if statement" in the Update() method.
    // Nothing in Update() needs to change, but something must be added...
    //
    // The "if statements" in OnTriggerEnter() also need to be fixed.
    //
    // The goal is that the door should open when both cubes are in the trigger zone. 
    //
    // The next Unit, Unit03, should also work the same way (door opens when both cubes enter trigger zone)
    // if you fix this script, but there's something missing in Unit03's scene as well...


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Set areBothCubesDetected to true if both blue and red flags are true
        if (isBlueCubeDeteced && isRedCubeDetected) {
            areBothCubesDetected = true;
        }

        if (areBothCubesDetected)
        {
            door.GetComponent<MoveToLocation>().enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Set blue and red flags when each collide
        if (other.gameObject == blueCube)
        {
            isBlueCubeDeteced = true;
        }

        if (other.gameObject == redCube)
        {
            isRedCubeDetected = true;
        }
    }
}
