using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    public int collisionCount = 0;
    private void OnCollisionEnter(Collision collision)
    {
        collisionCount++;
        Debug.Log("You have bumped into an obstacle this many times: " + collisionCount);
    }
}
