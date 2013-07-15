using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// MainForm.cs
// Tim Fielding 08/07/2013

namespace Assignment4
{
    /// <summary>
    /// Class to handle input/output from the user
    /// </summary>
    public partial class MainForm : Form
    {
        private const int mNumSeats = 60;
        private SeatManager mSeatManager;
        /// <summary>
        /// Constructor, initializes component, seatmanager and GUI
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            mSeatManager = new SeatManager(mNumSeats);
            InitializeGUI();
            UpdateGUI();
        }
        /// <summary>
        /// Sets the lblTotal.text to it's initial value, everything else is set in the UpdateGUI method
        /// </summary>
        private void InitializeGUI()
        {
            lblTotal.Text = "Total number of seats: " + mSeatManager.GetNumSeats().ToString();
        }
        /// <summary>
        /// Method to check if anything is selected in the list
        /// </summary>
        /// <returns>
        /// Returns true if SelectedIndex isn't -1
        /// </returns>
        private bool CheckSelectedIndex()
        {
            return lstReservations.SelectedIndex != -1;
        }
        /// <summary>
        /// Calls the validatestring method in the InputUtility class
        /// </summary>
        /// <param name="name">
        /// The parameter to be checked
        /// </param>
        /// <returns>
        /// Returns whatever the corresponding inpututility method returns
        /// </returns>
        private bool ReadAndValidateName(string name)
        {
            return InputUtility.ValidateString(name);
        }
        /// <summary>
        /// Same as above
        /// </summary>
        /// <param name="price">
        /// Same as above
        /// </param>
        /// <returns>
        /// Same as above
        /// </returns>
        private bool ReadAndValidatePrice(double price)
        {
            return InputUtility.ValidateDouble(price);
        }
        /// <summary>
        /// Calls the other read and validate methods
        /// </summary>
        /// <param name="name">
        /// String to be checked
        /// </param>
        /// <param name="price">
        /// Double to be checked
        /// </param>
        /// <returns>
        /// Returns true if both of the other methods return true
        /// </returns>
        private bool ReadAndValidateInput(string name, double price)
        {
            return ReadAndValidateName(name) && ReadAndValidatePrice(price);
        }
        /// <summary>
        /// Method to handle whatever is supposed to happen when the btnOK is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            ReserveOrCancelSeat();
        }
        /// <summary>
        /// Method that checks all the ifs and stuff before detirmining if the user made a valid input
        /// and then updates the GUI depending on if the user did or not
        /// </summary>
        private void ReserveOrCancelSeat()
        {
            if (CheckSelectedIndex())
            {
                int index = lstReservations.SelectedIndex;
                double price = 0.0d;
                string name = txtName.Text;
                InputUtility.GetDouble(txtPrice.Text, out price);
                if (rbtnReserve.Checked && ReadAndValidateInput(name, price))
                {
                    mSeatManager.ReserveSeat(index, name, price);
                    UpdateGUI();
                }
                else if (rbtnCancel.Checked)
                {
                    mSeatManager.CancelSeat(index);
                    UpdateGUI();
                }
                else
                    MessageBox.Show("No correct input made.", "Input error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("No correct selection made.", "Selection error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Updates the GUI to it's current state
        /// </summary>
        private void UpdateGUI()
        {
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            rbtnReserve.Checked = true;

            lstReservations.Items.Clear();
            for (int i = 0; i < mSeatManager.GetNumSeats(); ++i)
            {
                lstReservations.Items.Add(mSeatManager.GetSeatInfoAt(i));
            }

            lblReserved.Text = "Reserved seats: " + mSeatManager.GetNumReserved().ToString();
            lblVacant.Text = "Vacant seats: " + mSeatManager.GetNumVacant().ToString();
        }
        /// <summary>
        /// Accidentally made this when double clicking a label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
