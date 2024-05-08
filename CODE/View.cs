using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace XMLandJSON
{
    public partial class View : Form, IView
    {
        public View()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }

        string IView.FirstDirectory()
        { 
            return firstDirectoryTextBox.Text;
        }
        string IView.SecondDirectory()
        {
            return secondDirectoryTextBox.Text;
        }

        void IView.Synchronize(List<string> messages)
        {
            Results.Items.Clear();
            List<string> outputList = messages;

            foreach (string output in outputList)
            {
                Results.Items.Add(output);
            }
        }

        public event EventHandler<EventArgs> SynchronizeDirectories;

        private void SynchronizeButton_Click(object sender, EventArgs newEvent)
        {
            SynchronizeDirectories(sender, newEvent);
        }
    }
}