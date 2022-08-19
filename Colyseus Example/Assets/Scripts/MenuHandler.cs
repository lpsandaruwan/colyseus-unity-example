using System.Collections;
using System.Collections.Generic;
using Colyseus;
using UnityEngine;

public class MenuHandler
{
   //private static ColyseusClient client = new ColyseusClient("");

   public void Play()
   {
      var cfg = new Configuration();
      Debug.Log(cfg.GetHostAddress());
   }
}
