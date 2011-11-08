using System;
using PennedObjects.RateLimiting;

namespace BiblioCommons
{
    /// <summary>
    /// Provides singleton access to a RateGate instance which is used
    /// to control the rate of some occurrence per unit of time.
    /// </summary>
    internal sealed class RateGateSingleton
    {
        public RateGate Gate { get; private set; }

        private static volatile RateGateSingleton _instance;
        private static readonly object syncRoot = new Object();

        public static RateGateSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                            _instance = new RateGateSingleton();
                    }
                }

                return _instance;
            }
        }

        private RateGateSingleton()
        {
            Gate = new RateGate(Configuration.Settings.CacheSlidingExpiration, TimeSpan.FromMilliseconds(1200));
        }
    }
}
