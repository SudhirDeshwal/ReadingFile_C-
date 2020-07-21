using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingFile_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Friends> friendList = FriendsDb.GetFriends();


            var friends = from f in friendList
                           select f;

            int i = 0;
            foreach (var f in friends)
            {

            listView.Items.Add(f.Name);

                i += 1;
            }
        }
    }
}
