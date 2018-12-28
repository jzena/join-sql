using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JoinSQL
{
    public partial class MyWaitForm : Form
    {
        public MyWaitForm()
        {
            InitializeComponent();
        }

        private void MyWaitForm_Load(object sender, EventArgs e)
        {

        }

        public void SetMessage(string mensaje)
        {
            lblMensaje.Text = mensaje;
        }
    }
}
