using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson8B
{
    public partial class Lab8 : Form
    {
        //Class Properties
        public string UserName { get; set; }
        public float UserAge { get; set; }
        /// <summary>
        /// This is the constructor for Lab08Form
        /// </summary>
        public Lab8()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the SubmitButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;

            UserAge = float.Parse(AgeTextBox.Text);

            OutputLabel.Text = NameTextBox.Text + " " + AgeTextBox.Text;

            ClearForm();

            //Option B
            //NameTextBox.Text = string.Empty;

        }
        /// <summary>
        /// This method clears the text boxes
        /// </summary>

        private void ClearForm()
        {
            NameTextBox.Clear();
            AgeTextBox.Clear();
        }

        /// <summary>
        /// This is the event handler for the AgeTextBox TextChanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            //Simple input validation
           try
           {
              float.Parse(AgeTextBox.Text);
              SubmitButton.Enabled = true;
           }
           catch
           {
              SubmitButton.Enabled = false;
           }

        }

        /// <summary>
        /// This is the Event Handler for the Lab08Form Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab8_Load(object sender, EventArgs e)
        {
            ClearForm();

        }

        /// <summary>
        /// This is the event handler for the NameTextBox TextChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
           SubmitButton.Enabled = (NameTextBox.Text.Length < 2) ? false : true;
        }
    }
}
