using UnityEngine;

public class PlatformMoveY : MonoBehaviour
{
    public float distanse;
    public float speed;
    private float maxDist;
    private float minDist;
    private bool moveUp;
    private void Start()
    {
        maxDist = transform.position.y + distanse;
        minDist = transform.position.y - distanse;
    }


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > maxDist)
        {
            moveUp = false;
        }
        else if (transform.position.y < minDist)
        {
            moveUp = true;
        }
        if (moveUp)
        {
            transform.position = new Vector2(transform.position.x , transform.position.y+ speed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x , transform.position.y- speed * Time.deltaTime);
        }
    }
}
