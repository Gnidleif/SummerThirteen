using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// File: MainForm.cs
/// Name: Tim Fielding
/// Date: 08/07/2013

namespace Assignment3
{
    /// <summary>
    /// Class to handle showing output to the user
    /// </summary>
    public partial class MainForm : Form
    {
        private string mName = string.Empty;
        private double mPrice = 0.0d;
        private int mReserved = 0;
        private const int mTotalSeats = 250;
        private int mVacant = mTotalSeats;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        /// <summary>
        /// Initializes stuff that only needs to be set once
        /// </summary>
        private void InitializeGUI()
        {
            rbtnReserve.Checked = true;

            lstReservations.Items.Clear();
            for (int i = 0; i < mTotalSeats; ++i)
            {
                string strOut = string.Format("{0, 5} {1, -8} {2, -18} {3, 10:f2}",
                    i + 1, "Vacant", mName, mPrice);
                lstReservations.Items.Add(strOut);
            }   
            lstReservations.SelectedIndex = -1;

            lblTotSeats.Text = "Total number of seats: " + mTotalSeats.ToString();

            UpdateGUI();
        }
        /// <summary>
        /// Called every time the GUI is updated to show updated values / reset variables
        /// </summary>
        private void UpdateGUI()
        {
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            mName = string.Empty;
            mPrice = 0.0d;

            lblVacSeats.Text = "Number of vacant seats: " + mVacant.ToString();
            lblRsvdSeats.Text = "Number of reservered seats: " + mReserved.ToString();
        }
        /// <summary>
        /// Decides what happens when the OK-button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(rbtnReserve.Checked)
            {
                HandleReservation();
            }
            else if(rbtnCancel.Checked)
            {
                HandleCancellation();
            }
            UpdateGUI();
        }
        /// <summary>
        /// Method that takes care of stuff that needs to happen on a ticket-reservation
        /// </summary>
        private void HandleReservation()
        {
            // Lots of stuff needs to be true for a reservation to happen
            if (InputUtility.ValidateString(txtName.Text) &&
                InputUtility.ValidateString(txtPrice.Text) &&
                mReserved != mTotalSeats && 
                lstReservations.SelectedIndex != -1)
            {
                InputUtility.GetDouble(txtPrice.Text, out mPrice);
                mReserved++;
                mVacant--;
                mName = txtName.Text;
                int index = lstReservations.SelectedIndex;
                UpdateReservations(index, "Reserved");
            }
            else // If any of the stuff aren't true, a messagebox appears
            {
                MessageBox.Show(
                    "Not a guilty name/price.", 
                    "Name/price error.", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// Checks if anything in the list is selected and if the amount of reserved spots are more than 0
        /// before proceeding to cancellation
        /// </summary>
        private void HandleCancellation()
        {
            // Same deal here, except less stuff that needs to be true :D
            if (lstReservations.SelectedIndex != -1 && mReserved > 0)
            {
                mReserved--;
                mVacant++;
                int index = lstReservations.SelectedIndex;
                UpdateReservations(index, "Vacant");
            }
            else
            {
                MessageBox.Show(
                    "You need to select a reservation before you can cancel.",
                    "Selection error.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }   
        }
        /// <summary>
        /// Updates the list of reservations, 
        /// the index parameter decides where in the list an update is needed,
        /// and the status parameter sets what status is supposed to be shown at the selected index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="status"></param>
        private void UpdateReservations(int index, string status)
        {
            string strOut = string.Format("{0, 5} {1, -8} {2, -18} {3, 10:f2}",
                 index + 1, status, mName, mPrice);
            lstReservations.Items.RemoveAt(index);
            lstReservations.Items.Insert(index, strOut);
        }

        /// <summary>
        /// The methods below were accdentally created when I double-clicked different parts of the [Design]-window,
        /// removing them messes up the program, so I just left them here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnReserve_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnCancel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblRsvdSeats_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblTotSeats_Click(object sender, EventArgs e)
        {

        }
    }
}
