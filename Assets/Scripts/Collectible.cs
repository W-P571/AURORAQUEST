using UnityEngine;

public class Collectible : MonoBehaviour
{
    public AudioClip collectSound;
    private AudioSource audioSource;

    void Start() {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            // Play sound effect
            audioSource.PlayOneShot(collectSound);

            // Notify the GameManager (ensure your GameManager has the tag "GameManager" or reference it via a singleton)
            GameObject gmObj = GameObject.Find("GameManager");
            if(gmObj != null) {
                GameManager gm = gmObj.GetComponent<GameManager>();
                if(gm != null) {
                    gm.CollectiblePicked();
                }
            }

            // Destroy collectible after a short delay
            Destroy(gameObject, 0.5f);
        }
    }
}
