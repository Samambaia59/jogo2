using UnityEngine;

public class Bullet : MonoBehaviour
{
    // A velocidade que o projétil se moverá.
    public float speed = 20f;

    // O dano que o projétil causará (se for para atingir inimigos).
    public int damage = 10; 

    // O Rigidbody2D do projétil.
    public Rigidbody2D rb;

    // Quanto tempo o projétil existirá antes de ser destruído (para evitar sujeira na cena).
    public float lifetime = 3f;

    void Start()
    {
        // Faz o projétil se mover na direção 'para frente' (que é a direção do seu 'firePoint').
        rb.linearVelocity = transform.right * speed; 
        
        // Destrói o projétil após 'lifetime' segundos.
        Destroy(gameObject, lifetime);
    }

    // Chamado quando o projétil colide com outro objeto.
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        // Exemplo: Se você tiver um inimigo, você pode pegar o script dele e chamar uma função de dano.
        // Exemplo de código:
        /*
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        */

        // Destrói o projétil após a colisão (pode-se adicionar um efeito de explosão aqui).
        if(!hitInfo.CompareTag("Player")) Destroy(gameObject);
    }
}