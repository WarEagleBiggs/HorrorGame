using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDetect : MonoBehaviour
{
	public Transform Tele_Apt1_EXT;
	public Transform Tele_Apt1_INT;
	
	public Transform Tele_Apt2_EXT;
	public Transform Tele_Apt2_INT;
	
	public GameObject PressTxt;
	
	private RaycastHit hit;
	
	public GameObject Player;
	public FirstPersonMovement m_move;
	public FirstPersonLook m_look;

	public GameObject DialogueObj;

	private void Start()
	{
		m_move = Player.GetComponent<FirstPersonMovement>();
		m_look = Player.GetComponentInChildren<FirstPersonLook>();

	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			m_move.enabled = false;
			m_look.enabled = false;
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;

		}
	}

	protected void FixedUpdate()
	{
		RaycastHit hit;
 
		if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
		{
			if (hit.transform.CompareTag("LandLord"))
			{
				PressTxt.SetActive((true));
				if (Input.GetKeyDown(KeyCode.E))
				{
					DialogueObj.SetActive(!DialogueObj.activeSelf);
					m_move.enabled = !m_move.isActiveAndEnabled;
					m_look.enabled = !m_look.isActiveAndEnabled;
				}
			}

			if(hit.transform.CompareTag("Door1"))
			{
				PressTxt.SetActive(true);
				if (Input.GetKeyDown(KeyCode.E)) {
				Debug.Log("Hit");
					Player.transform.position = Tele_Apt1_INT.
						position;
				}
			} else if(hit.transform.CompareTag("Door2"))
			{
				PressTxt.SetActive(true);
				if (Input.GetKeyDown(KeyCode.E)) {
				Debug.Log("Hit");
					Player.transform.position = Tele_Apt1_EXT.position;
				}
			} else if(hit.transform.CompareTag("Door3"))
			{
				PressTxt.SetActive(true);
				if (Input.GetKeyDown(KeyCode.E)) {
				Debug.Log("Hit");
					Player.transform.position = Tele_Apt2_INT.position;
				}
			} else if(hit.transform.CompareTag("Door4"))
			{
				PressTxt.SetActive(true);
				if (Input.GetKeyDown(KeyCode.E)) {
				Debug.Log("Hit");
					Player.transform.position = Tele_Apt2_EXT.position;
				}
			}
		} else 
		{
			PressTxt.SetActive(false);
			
		}
	}

}
