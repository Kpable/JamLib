﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Kpable.Utilities
{
    public class SingletonBehaviour<T> : MonoBehaviour where T : MonoBehaviour
    {

        #region  Properties

        /// <summary>
        /// Returns the instance of this singleton.
        /// </summary>
        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = (T)FindObjectOfType(typeof(T));

                    DontDestroyOnLoad(instance);

                    if (instance == null)
                    {
                        Debug.LogError("An instance of " + typeof(T) + " is needed in the scene, but there is none.");
                    }
                }

                return instance;
            }
        }

        #endregion

        protected static T instance;

        protected void Awake()
        {
            if (instance != null) Destroy(gameObject);
        }
    }
}
