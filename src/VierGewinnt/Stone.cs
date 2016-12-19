using System;

namespace VierGewinnt
{
    public class Stone
    {
        #region [ Properties ]
            
        /// <summary>
        /// Coordinat cotain x and y values. 
        /// </summary>
        /// <returns></returns>
        Tuple<int,int> Coordinate {get; set;}
        Owner CurrentOwner{get; set;}

        #endregion

        #region [Constructor]

        public Stone(int horizintalCord, int verticalCoord)
        {
            Coordinate = new Tuple<int,int>(horizintalCord,verticalCoord);
            CurrentOwner = Owner.VOID; 
        }

        #endregion
    }
}