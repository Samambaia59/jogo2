using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 30; // Vida total do inimigo
    int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Função que a bala vai chamar para causar dano
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Inimigo tomou dano! Vida restante: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Inimigo Morreu!");
        
        // Aqui você pode colocar uma animação antes de destruir
        // anim.SetTrigger("die"); 

        Destroy(gameObject); // Remove o inimigo do jogo
    }
}