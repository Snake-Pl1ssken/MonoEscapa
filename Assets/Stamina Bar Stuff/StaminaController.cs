//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using UnityStandardAssets.Characters.FirstPerson;

//public class StaminaController : MonoBehaviour
//{
//    [Header("Stamina Main Parameters")]
//    public float playerStamina = 100.0f;
//    [SerializeField] private float maxStamina = 100.0f;
//    [SerializeField] private float jumpCost = 20.0f;
//    [HideInInspector] public bool hasRegenerated = true;
//    [HideInInspector] public bool weAreSprinting = false;

//    [Header("Stamina Regen Parameters")]
//    [Range(0, 50)][SerializeField] private float staminaDrian = 0.5f;
//    [Range(0, 50)][SerializeField] private float staminaRegen = 0.5f;

//    [Header("Stamina Speed Parameters")]
//    [SerializeField] private int slowRunSpeed = 4;
//    [SerializeField] private int normalRunSpeed = 8;

//    [Header("Stamina UI Elements")]
//    [SerializeField] private Image staminaProgressUI = null;
//    [SerializeField] private CanvasGroup sliderCanvasGroup = null;

//    private FirstPersonControllerCustom playerController;

//    private void Start()
//    {
//        playerController = GetComponent<FirstPersonControllerCustom>();
//    }

//    private void Update()
//    {
//        if (!weAreSprinting)
//        {
//            if (playerStamina <= maxStamina - 0.01)
//            {
//                playerStamina += staminaRegen * Time.deltaTime;
//                UpdateStamina(1);

//                if (playerStamina >= maxStamina)
//                {
//                    playerController.SetRunSpeed(normalRunSpeed);
//                    sliderCanvasGroup.alpha = 0;
//                    hasRegenerated = true;
//                }
//            }
//        }
//    }

//    public void Sprinting()
//    {
//        if (hasRegenerated)
//        { 
//            weAreSprinting = true;
//            playerStamina -= staminaDrian * Time.deltaTime;
//            UpdateStamina(1);

//            if (playerStamina <= 0)
//            {
//                hasRegenerated = false;
//                playerController.SetRunSpeed(slowRunSpeed);
//                sliderCanvasGroup.alpha = 0;    
//            }
//        }
//    }

//    public void StaminaJump()
//    {
//        if (playerStamina >= (maxStamina * jumpCost / maxStamina))
//        { 
//            playerStamina -= jumpCost;
//            playerController.PlayerJump();
//            UpdateStamina(1);
//        }
//    }

//    void UpdateStamina(int value)
//    { 
//        staminaProgressUI.fillAmount = playerStamina / maxStamina;

//        if (value == 0)
//        { 
//            sliderCanvasGroup.alpha = 0;
//        }
//        else
//        {
//            sliderCanvasGroup.alpha = 1;
//        }
//    }
//}
