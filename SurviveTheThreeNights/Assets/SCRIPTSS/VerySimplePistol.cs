using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerySimplePistol : MonoBehaviour
{
	public  Transform m_raycastSpot;

	public bool machinegun;	

	public ParticleSystem disparo;				
	public  float     m_damage        = 80.0f;				
	public  float     m_forceToApply  = 20.0f;				
	public  float     m_weaponRange   = 9999.0f;						
	public  Texture2D m_crosshairTexture;					
    public  AudioClip m_fireSound;	

	public int muni = 30;

	public Animator m_animation;						
    private bool      m_canShot;

	public float shootvelocity;

	private void Update()
	{
		shootvelocity += Time.deltaTime;
		m_canShot = machinegun ? true: m_canShot;
		disparo.Stop();
        if (m_canShot)
		{
		
			if (Input.GetButton("Fire1") && shootvelocity > 0.15f)
			{
				shootvelocity = 0.0f;
					if(muni > 0)
		 		{
				Shot();
				m_animation.SetBool("shooted",true);
				GetComponent<AudioSource>().PlayOneShot(m_fireSound);
				if (muni == 0)
				{
					m_animation.SetBool("shooted",false);
				}
				disparo.Play();
		 		}
			}
			

			else if (Input.GetButtonUp("Fire1"))
        	{ 
				
				Debug.Log("UP");
				m_animation.SetBool("shooted",false);
				disparo.Stop();
				
			
        	}
		 	
		
		}
		else if (Input.GetButtonUp("Fire1"))
        { 
			Debug.Log("UP");
			m_canShot = true;
			m_animation.SetBool("shooted",false);
			
        }
	}

	private void OnGUI()
	{
		Vector2 center = new Vector2(Screen.width / 2, Screen.height / 2);
		Rect auxRect = new Rect(center.x - 20, center.y - 20, 20, 20);
		GUI.DrawTexture(auxRect, m_crosshairTexture, ScaleMode.StretchToFill);
	}


	private void Shot()
	{
		
		if(muni == 0)
		{
			return;
		}

		muni--;
		m_canShot = false;
   RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, transform.forward, 100.0F);

        for (int i = 0; i < hits.Length; i++)
        {
            RaycastHit hit = hits[i];
            Renderer rend = hit.transform.GetComponent<Renderer>();

			if(hits[i].transform.GetComponent<EnemyBehaviour>() != null)
			{
				hits[i].transform.GetComponent<EnemyBehaviour>().vidaE--;
			}

            if (rend)
            {
                // Change the material of all hit colliders
                // to use a transparent shader.
                  if (hit.rigidbody)
			{
				hit.rigidbody.AddForce(transform.forward * m_forceToApply);
                Debug.Log("Hit");
			}
                Color tempColor = rend.material.color;
                tempColor.a = 0.3F;
                rend.material.color = tempColor;
            }
        }

		
	}

	private void stopshoot()
	{
		//
	}
}
