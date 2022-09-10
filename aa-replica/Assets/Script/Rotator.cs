using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
   public float rotationSpeed = 100f;

   private void Update()
   {
      transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
   }
}
