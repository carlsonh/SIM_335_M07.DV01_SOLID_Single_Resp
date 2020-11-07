using UnityEngine;

public class NPCParticles : MonoBehaviour {
    

    [SerializeField] private ParticleSystem deathParticlePrefab = null;

    public void PlayDeathParticle()
    {
        Debug.Log("Particles");
        //var deathparticle = Instantiate(deathParticlePrefab, transform.position, deathParticlePrefab.transform.rotation);
        //Destroy(deathparticle, 4f);
    }
}