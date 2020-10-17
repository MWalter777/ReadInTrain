using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadInTrain
{
    class Travel
    {
        private int _hourTrain;
        private int _hourRead;
        private int _levelMinForRead;
        private int _levelMaxForRead;
        private List<LevelLight> _levels;

        #region constructors

        public Travel(int hourTrain, int hourRead)
        {
            _hourTrain = hourTrain;
            _hourRead = hourRead;
            _levels = new List<LevelLight>();
        }

        public Travel(int hourTrain, int hourRead, int levelMinForRead, int levelMaxForRead) : this(hourTrain, hourRead)
        {
            _levelMinForRead = levelMinForRead;
            _levelMaxForRead = levelMaxForRead;
        }
        #endregion constructors


        #region sets and getters

        public int hourTrain
        {
            set
            {
                _hourTrain = value;
            }
            get
            {
                return _hourTrain;
            }
        }

        public int hourRead
        {
            set
            {
                _hourRead = value;
            }
            get
            {
                return _hourRead;
            }
        }

        public int levelMinForRead
        {
            set
            {
                _levelMinForRead = value;
            }
            get
            {
                return _levelMinForRead;
            }
        }

        public int levelMaxForRead
        {
            set
            {
                _levelMaxForRead = value;
            }
            get
            {
                return _levelMaxForRead;
            }
        }

        public List<LevelLight> levels
        {
            set
            {
                _levels = value;
            }
            get
            {
                return _levels;
            }
        }

        #endregion sets and getter

        public void addToLevel(LevelLight level)
        {
            _levels.Add(level);
        }

    }
}
