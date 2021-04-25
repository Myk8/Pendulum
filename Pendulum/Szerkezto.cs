using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Pendulum
{
    public partial class Szerkezto : Form
    {
        public TextBox TBTitle
        {
            get { return tBTitle; }
            set { tBTitle = value; }
        }
        public TextBox TBLength
        {
            get { return tBLength; }
            set { tBLength = value; }
        }
        public TextBox TBId
        {
            get { return tBId; }
            set { tBId = value; }
        }
        public TextBox TBUrl
        {
            get { return tBUrl; }
            set { tBUrl = value; }
        }
        public Szerkezto()
        {
            InitializeComponent();
        }
    }
}
