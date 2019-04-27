namespace Kpable.Utilities
{
    public class Singleton<T> where T : new()
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
                    instance = new T();                    
                }

                return instance;
            }
        }

        #endregion

        protected static T instance;
    }
}
