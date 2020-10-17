using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadInTrain
{
    class LevelLight : IRead
    {
        private int _level;
        private int _hour;

        #region constructors
        public LevelLight(int level, int hour)
        {
            _level = level;
            _hour = hour;
        }
        #endregion constructors

        #region setters and getters
        public int level
        {
            set
            {
                _level = value;
            }
            get
            {
                return _level;
            }
        }

        public int hour
        {
            set
            {
                _hour = value;
            }
            get
            {
                return _hour;
            }
        }

        #endregion setters and getters

        public bool canRead(int levelMin, int levelMax)
        {
            return _level >= levelMin && _level <= levelMax;
        }



    }
}
