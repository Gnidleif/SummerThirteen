using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// SeatManager.cs
// Tim Fielding 08/07/2013

namespace Assignment4
{
    /// <summary>
    /// Class to handle the output shown int the list of reservations
    /// </summary>
    class SeatManager
    {
        private string[] mNameList = null;
        private double[] mPriceList = null;
        private readonly int mTotalSeats;

        /// <summary>
        /// Constructor for the SeatManager class
        /// </summary>
        /// <param name="maxSeats">
        /// Sets the mTotalSeats variable
        /// </param>
        public SeatManager(int maxSeats)
        {
            mTotalSeats = maxSeats;
            mNameList = new string[mTotalSeats];
            mPriceList = new double[mTotalSeats];
        }
        /// <summary>
        /// Checks if the index sent as parameter is valid
        /// </summary>
        /// <param name="index">
        /// The index to be tested
        /// </param>
        /// <returns>
        /// Returns true if the index is within the range, false if not
        /// </returns>
        private bool CheckIndex(int index)
        {
            return index >= 0 && index < mTotalSeats;
        }
        /// <summary>
        /// Method to check how many reserved seats there are
        /// </summary>
        /// <returns>
        /// Returns the total number of reserved seats
        /// </returns>
        public int GetNumReserved()
        {
            int amount = 0;
            for (int i = 0; i < mTotalSeats; ++i)
            {
                if(!string.IsNullOrEmpty(mNameList[i]))
                {
                    amount++; // Increments if the mNameList at the given index is not empty
                }
            }
            return amount;
        }
        /// <summary>
        /// Pretty much the same as the above method
        /// </summary>
        /// <returns>
        /// Returns the amount of vacant seats
        /// </returns>
        public int GetNumVacant()
        {
            int amount = 0;
            for (int i = 0; i < mTotalSeats; ++i)
            {
                if(string.IsNullOrEmpty(mNameList[i]))
                {
                    amount++; // Increments if the mNameList at the given index is empty
                }
            }
            return amount;
        }
        /// <summary>
        /// Since the mTotalSeats is private, this is used by the MainForm to get the total amount of seats
        /// </summary>
        /// <returns>
        /// Returns the mTotalSeats variable
        /// </returns>
        public int GetNumSeats()
        {
            return mTotalSeats;
        }
        /// <summary>
        /// Method to cancel a seat
        /// </summary>
        /// <param name="index">
        /// Index parameter for the program to know which index is to be cancelled
        /// </param>
        /// <returns>
        /// Returns false if the index is outside of the mTotalSeats range
        /// </returns>
        public bool CancelSeat(int index)
        {
            if(CheckIndex(index))
            {
                mNameList[index] = string.Empty;
                mPriceList[index] = 0.0d;
                return true;
            }
            return false;
        }
        /// <summary>
        /// The opposite of the CancelSeat method
        /// </summary>
        /// <param name="index">
        /// Index parameter for the program to know which index is to be reserved
        /// </param>
        /// <param name="name">
        /// The name of the person reserving the seat
        /// </param>
        /// <param name="price">
        /// The price of the seat to be reserved
        /// </param>
        /// <returns>
        /// Returns true if CheckIndex(index) succeeds, otherwise false
        /// </returns>
        public bool ReserveSeat(int index, string name, double price)
        {
            if (CheckIndex(index))
            {
                mNameList[index] = name;
                mPriceList[index] = price;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Method building a single string with seat info
        /// </summary>
        /// <param name="index">
        /// Parameter to show which seat is to be built as a string
        /// </param>
        /// <returns>
        /// Returns the built string if CheckIndex(index) succeeds, otherwise it just returns an empty string
        /// </returns>
        public string GetSeatInfoAt(int index)
        {
            if (CheckIndex(index))
            {
                string status = string.Empty;
                if (InputUtility.ValidateString(mNameList[index])) // If the namelist[index] isn't empty, set status to reserved
                {
                    status = "Reserved";
                }
                else // If the namelist[index] is empty, set status to vacant
                {
                    status = "Vacant";
                }
                return string.Format("{0, 5} {1, -8} {2, -18} {3, 10:f2}", index + 1, status, mNameList[index], mPriceList[index]);
            }
            return string.Empty;
        }
    }
}
