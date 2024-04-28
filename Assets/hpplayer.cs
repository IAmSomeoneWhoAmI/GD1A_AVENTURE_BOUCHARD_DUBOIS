using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class hpplayer : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    public Image healthBar;
    public Sprite hearts5;
    public Sprite hearts4;
    public Sprite hearts3;
    public Sprite hearts2;
    public Sprite hearts1;
    public Sprite hearts0;
    private Vector3 initialPosition;
    public GameObject FP;
    public GameObject GP;
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    public GameObject Trigger;
    private bool isHealed = false;
    private float healTime;

    private void Start()
    {
        currentHealth = maxHealth;
        initialPosition = transform.position;
        



    }




    private void Update()
    {
        if (Trigger.activeSelf )
    {
        isHealed = false;
    }
    else 
    {
        if (!isHealed && currentHealth < 5) // Check if the player has been healed
        {
            currentHealth += 1; // Heal the player instantly 
            isHealed = true; // Set isHealed to true after healing the player
        }
    
    
    }
    
    

        
        if (currentHealth <= 0)
        {
            Die();
        }
        if (currentHealth == 5)
        {
            healthBar.sprite = hearts5;

        }
        if (currentHealth == 4)
        {
            healthBar.sprite = hearts4;

        }
        if (currentHealth == 3)
        {
            healthBar.sprite = hearts3;

        }
        if (currentHealth == 2)
        {
            healthBar.sprite = hearts2;

        }
        if (currentHealth == 1)
        {
            healthBar.sprite = hearts1;

        }
        if (currentHealth == 0)
        {
            healthBar.sprite = hearts0;

        }

    }
    
    void Die()
    {
        // Implement any other logic you need when the player dies
        Respawn(); // Call the respawn method
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = maxHealth;
            Die();

        }


        
    }
    void Respawn()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        // Reset the player's position to the initial position
        if (sceneName == "ville") 
        { 
            SceneManager.LoadScene("ville");
            P1.transform.position = initialPosition;
            P2.transform.position = initialPosition;
            P3.transform.position = initialPosition;
            P4.transform.position = initialPosition;
        }
        if (sceneName == "foret")
        {
            SceneManager.LoadScene("foret");
            P1.transform.position = FP.transform.position;
            P2.transform.position = FP.transform.position;
            P3.transform.position = FP.transform.position;
            P4.transform.position = FP.transform.position;

        }
        if (sceneName == "grotte")
        {
            SceneManager.LoadScene("grotte");
            P1.transform.position = GP.transform.position;
            P2.transform.position = GP.transform.position;
            P3.transform.position = GP.transform.position;
            P4.transform.position = GP.transform.position;

        }
        
}
}

    



