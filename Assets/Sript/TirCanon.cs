using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TirCanon : MonoBehaviour
{
    public GameObject Projectile;
    [SerializeField] private Transform CanonTip;
    public int force = 1;


    public int nombreDeVie;
    public int currentNombreDeVie;
    public Slider healthSlider;
    public GameObject vfx;
    public GameObject pauseMenu;
    public GameObject victoryMenu;
    public Text vieRestante;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!pauseMenu.activeSelf && !victoryMenu.activeSelf)
        {
            Tir();
            if (nombreDeVie < 0)
            {
                SceneManager.LoadScene(4);
            }
        }
    }

    public void VieRestante()
    {
        if (victoryMenu.activeSelf)
        {
            vieRestante.text = currentNombreDeVie.ToString();
        }
    }

    private void Tir()
    {
        
        
            Boulet boulet = FindObjectOfType<Boulet>();
            if (boulet == null )
            {
                vfx.SetActive(true);
                if (Input.GetMouseButtonDown(0))
                {
                    PerteVie();

                    GameObject Boule = Instantiate(Projectile, CanonTip.position, CanonTip.rotation) as GameObject;
                    healthSlider.value = currentNombreDeVie;
                    
                    
                }
            }
            else if (boulet != null)
            {
                vfx.SetActive(false);
            }
        
    }

    private void PerteVie()
    {
        
        
            currentNombreDeVie = nombreDeVie;
            currentNombreDeVie -= 1;
            nombreDeVie = currentNombreDeVie;
            
            Debug.Log("Perd une vie " + currentNombreDeVie);
            
        
    }
}