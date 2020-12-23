using System;
using UnityEngine;

namespace FPS.Scripts
{
    public class ClickableObject : MonoBehaviour
    {
        [SerializeField]
        private GameObject action;

        private void OnMouseEnter()
        {
            action.SetActive(true);
        }

        private void OnMouseExit()
        {
            action.SetActive(false);
        }
    }
}
