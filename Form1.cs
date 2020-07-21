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

            //making list of type friends with data from friendsDB as a datasource for linq
            List<Friends> friendList = FriendsDb.GetFriends();

            // LINQ Query :A statement that defines the query expression
            var friends = from f in friendList
                           select f;


            //Code that executes the query
            int i = 0;
            foreach (var f in friends)
            {
              
                //adding items into the list view
            listView.Items.Add(f.Name);

                i += 1;
            }
        }
    }
}
