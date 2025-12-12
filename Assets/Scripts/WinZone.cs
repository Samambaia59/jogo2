using UnityEngine;
using UnityEngine.SceneManagement; // Necessário para reiniciar a cena

public class WinZone : MonoBehaviour
{
    [Header("Arraste o Painel de Vitória aqui")]
    public GameObject winScreenUI; // O painel que contém o texto e o botão

    // Detecta quando o jogador entra na área
    void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se quem entrou foi o Player
        // (Certifique-se que seu personagem tem a Tag "Player")
        if (other.CompareTag("Player"))
        {
            WinGame();
        }
    }

    void WinGame()
    {
        Debug.Log("Você Ganhou!");
        
        // 1. Ativa a tela de vitória
        if (winScreenUI != null)
        {
            winScreenUI.SetActive(true);
        }

        // 2. Opcional: Pausa o jogo (para o personagem não sair andando)
        Time.timeScale = 0f; 
    }

    // Esta função será chamada pelo BOTÃO DE RECOMEÇAR
    public void RestartGame()
    {
        // Despausa o jogo antes de recarregar
        Time.timeScale = 1f; 
        
        // Recarrega a cena atual
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}