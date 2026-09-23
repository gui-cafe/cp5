using System;
using UnityEngine;

public class ParticleSpawn : MonoBehaviour
{
    [SerializeField] GameObject particulas;

    public void SpawnParticles()
    {
        Instantiate(particulas, transform.position, transform.rotation);
    }

}
