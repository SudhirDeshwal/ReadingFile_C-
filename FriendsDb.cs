using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingFile_Csharp
{
    public static class FriendsDb
    {

        //Reading file from mention path
        private const string Dir = @"C:\Files\";
        private const string Path = Dir + "Friends.txt";


        //creating list of type frineds with function GetFriends
        public static List<Friends> GetFriends()
        {
            List<Friends> friends = new List<Friends>();


            //reading text file
            StreamReader textIn = new StreamReader(
                new FileStream(Path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                Friends friend = new Friends();
                friend.Name = columns[1];
                friends.Add(friend);
            }
            //closing file
            textIn.Close();
            return friends;
        }
    }
}
