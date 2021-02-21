using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LociPoint.UC
{
    public partial class PalaceUC : UserControl
    {
        private int palaceId;
        private List<Room> rooms = new List<Room>();
        private List<Button> delete = new List<Button>();
        private List<Button> edit = new List<Button>();
        private List<TextBox> roomNames = new List<TextBox>();
        private List<TextBox> roomDes = new List<TextBox>();
        private string palaceName;


        public PalaceUC(int palaceId, string palaceName)
        {
            InitializeComponent();
            this.palaceId = palaceId;
            this.palaceName = palaceName;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           
        }

        private void PalaceUC_Load(object sender, EventArgs e)
        {
            lblPalace.Text = palaceName;
            //select all rooms query
            Console.WriteLine(palaceId);
            string query = "SELECT * FROM rooms WHERE palaceId = @palaceId";
            string[] keys = { "@palaceId" };
            object[] vals = { palaceId };
            rooms = Database.selectionQuery<Room>(query, Input.generateDictionary(keys, vals));
            int y = lblRoomName.Location.Y - 110;
            //show rooms on screen
            for (int i = 0; i < rooms.Count; i++)
            {
                y += 50;
                int x= lblRoomName.Location.X -70;
                Input.createLabel(panelRooms, i.ToString(), x, y, 30,40);

                x = lblRoomName.Location.X;
                //create textbox for every label
                TextBox tb = Input.createTb(panelRooms, x, y, rooms[i].roomName, 250, 90);
                roomNames.Add(tb);

                x = lblRoomDes.Location.X + 20;
                tb = Input.createTb(panelRooms, x, y, rooms[i].roomDescription, 250, 90);
                roomDes.Add(tb);

                //edit Button
                 x = lblEdit.Location.X - 70;
                Button btn = Input.createButton(panelRooms, "Edit", x, y);
                btn.Click += new EventHandler(btn_Click);
                edit.Add(btn);

                //delete button
                x = lblEdit.Location.X + 90;
                Button btn2 = Input.createButton(panelRooms, "Delete", x, y);
                btn2.Click += new EventHandler(btn2_Click);
                delete.Add(btn2);

                y += 50;
            }


        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            int count = Input.getId(btn, edit);
            string roomName = roomNames[count].Text;
            string roomDesc = roomDes[count].Text;
            int roomId = rooms[count].id;
            string query = "UPDATE Rooms SET roomName = @roomName, roomDescription= @roomDes WHERE id = @roomId; ";
            string[] keys = { "@roomName", "@roomDes", "@roomId" };
            object[] values = { roomName, roomDesc, roomId };
            Database.executeQuery(query, Input.generateDictionary(keys, values));
            MenuForm.changeUserControl(new PalaceUC(palaceId, palaceName));

        }
        private void btn2_Click(object sender, EventArgs e)
        {
            //delete button
            Button btn = (Button)sender;

            int count = Input.getId(btn, delete);

            //delete query for room
            string query = "DELETE FROM Rooms WHERE palaceId = @palaceId AND id= @id";
            string[] keys = { "@palaceId", "@id" };
            object[] values = { palaceId, rooms[count].id };
            Database.executeQuery(query, Input.generateDictionary(keys, values));
            MenuForm.changeUserControl(new PalaceUC(palaceId, palaceName));
        }
        private void panelPalaces_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
