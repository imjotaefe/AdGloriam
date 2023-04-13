using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FloatReference
{
   public bool useConstant = true;
   public float constantValue;
   public FloatVariable variable;

   public float Value => useConstant ? constantValue : variable.Value;
   public void SetValue(float newValue) => variable.Value = newValue;
}
