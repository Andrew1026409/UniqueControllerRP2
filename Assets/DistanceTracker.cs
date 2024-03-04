using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTracker : MonoBehaviour
{
    public Transform player; // Player's transform
    public GameObject[] objectsToTrack; // Array of game objects to track
    public TextMesh distanceText; // TextMesh to display distance
    public float minimumRange = 5f; // Minimum range to detect objects

    private GameObject closestObject; // Closest object to the player

    void Update()
    {
        float minDistance = Mathf.Infinity;
        closestObject = null;

        foreach (GameObject obj in objectsToTrack)
        {
            float distance = Vector3.Distance(player.position, obj.transform.position);

            // Check if the object is within minimum range and closer than the current closest object
            if (distance < minimumRange && distance < minDistance)
            {
                minDistance = distance;
                closestObject = obj;
            }
        }

        if (closestObject != null)
        {
            // Display the distance to the closest object on the TextMesh
            distanceText.text = "Distance: " + minDistance.ToString("F2");
        }
        else
        {
            // If no object is within minimum range, display a message or hide the TextMesh
            distanceText.text = "No Resources detected";
        }
    }
}
