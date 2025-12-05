using UnityEngine;

// 0 references | Unity Script
public class EnemyJump : MonoBehaviour
{
    // 1 reference | Unity Serialized Field
    public float jumpForce;

    // 0 references | Unity Message
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
            collision.gameObject.SendMessage("Jump", jumpForce);
    }
}