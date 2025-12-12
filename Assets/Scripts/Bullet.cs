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
        // Tenta achar o script "Enemy" no objeto que a bala acertou
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        
        // Se achou o script (significa que acertou um inimigo)
        if (enemy != null)
        {
            enemy.TakeDamage(damage); // Causa o dano definido na bala (ex: 10)
        }
        // Destrói a bala ao bater em qualquer coisa (chão, parede ou inimigo)
        if(!hitInfo.CompareTag("Player")) Destroy(gameObject);
    }
}