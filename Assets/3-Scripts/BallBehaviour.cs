using UnityEngine;
using Random = UnityEngine.Random;

public class BallBehaviour : MonoBehaviour
{
    //Represent the direction of the ball
    private Vector2 m_direction;
    
    //Represent the speed
    public int m_speed;
    
    private void Start()
    {
        Debug.Log(new Vector2(Mathf.Sign(Random.Range(-1, 1)), Mathf.Sign(Random.Range(-1, 1))));
        m_direction = new Vector2(Mathf.Sign(Random.Range(-1, 1)), Mathf.Sign(Random.Range(-1, 1)));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(m_direction * (m_speed * Time.deltaTime));
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        m_direction *= -1;
    }
}
