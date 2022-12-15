using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTrackerManager
{
    public partial class Settings : Form
    {
        private int name1Hours = 8;
        private int name2Hours = 8;
        private int name3Hours = 8;
        private const int totalHours = 24;
        
        /// <summary>
        ///Constructor with no parameters 
        /// </summary>
        public Settings()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// Method to initialize GUI
        /// </summary>
        private void InitializeGUI()
        {
            this.Text = "Settings";
            DefaultSettings();
            UpdateGUI();
        }
        /// <summary>
        /// Personal hours property
        /// Both read and write function
        /// </summary>
        public int PersonalHours
        {
            get { return name1Hours; }
        }
        /// <summary>
        /// Work hours property
        /// Both read and write function
        /// </summary>
        public int WorkHours
        {
            get { return name2Hours; }
        }
        /// <summary>
        /// Relax hours property
        /// Both read and write function
        /// </summary>
        public int RelaxHours
        {
            get { return name3Hours; }
        }
        /// <summary>
        /// Method to read input with error control
        /// </summary>
        private bool ReadHourChange()
        {
            bool isValid = true;
            if (!int.TryParse(txtName1Hours.Text, out name1Hours))
            {
                MessageBox.Show("Please enter a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
                return isValid;
            }


            if (!int.TryParse(txtName2Hours.Text, out name2Hours))
            {
                MessageBox.Show("Please enter a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
                return isValid;
            }


            if (!int.TryParse(txtName3Hours.Text, out name3Hours))
            {
                MessageBox.Show("Please enter a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
                return isValid;
            }

            if (name1Hours + name2Hours + name3Hours > totalHours)
            {
                MessageBox.Show("Total Hours can not exceed 24!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
                return isValid;
            }
            return isValid;
        }
        /// <summary>
        /// Event handler for save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ReadHourChange())
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        /// <summary>
        /// Event handler for default button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDefault_Click_1(object sender, EventArgs e)
        {
            DefaultSettings();
            UpdateGUI();
        }
        /// <summary>
        /// Method for default settings
        /// </summary>
        private void DefaultSettings()
        {
            name1Hours = 8;
            name2Hours = 8;
            name3Hours = 8;
            UpdateGUI();
        }
        /// <summary>
        /// Method to update GUI
        /// </summary>
        private void UpdateGUI()
        {
            txtName1Hours.Text = name1Hours.ToString();
            txtName2Hours.Text = name2Hours.ToString();
            txtName3Hours.Text = name3Hours.ToString();
        }
    }
}
