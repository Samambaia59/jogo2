using UnityEngine;

public class atirar : MonoBehaviour
{
    // A referência ao Prefab do projétil que será instanciado.
    public GameObject bulletPrefab;

    // O ponto de onde o projétil será gerado (pode ser um GameObject vazio filho do jogador).
    public Transform firePoint;

    // A taxa de tiro (quantos segundos entre cada tiro).
    public float fireRate = 0.5f;

    // Variável para controlar o tempo do próximo tiro.
    private float nextFireTime = 0f;

    void Update()
    {
        // Verifica se o jogador pressionou o botão de "Fire1" (configuração padrão: mouse esquerdo/Ctrl)
        // E se o tempo atual é maior que o tempo permitido para o próximo tiro.
        if (Input.GetButton("Fire1") && Time.time >= nextFireTime)
        {
            Shoot();
            // Atualiza o tempo do próximo tiro
            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        // 1. Instancia o Prefab do projétil na posição e rotação do 'firePoint'.
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // 2. Opcional: Adiciona um componente de som de tiro aqui se quiser.
        // GetComponent<AudioSource>().Play(); 
    }
}