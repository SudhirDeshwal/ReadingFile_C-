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
        private const string Dir = @"C:\Files\";
        private const string Path = Dir + "CustomersX23.txt";


        public static List<Friends> GetFriends()
        {
            List<Friends> friends = new List<Friends>();

            StreamReader textIn = new StreamReader(
                new FileStream(Path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                Friends friend = new Friends();
                friend.FriendID = Convert.ToInt32(columns[0]);
                friend.Name = columns[1];
                friends.Add(friend);
            }

            textIn.Close();
            return friends;
        }
    }
}
