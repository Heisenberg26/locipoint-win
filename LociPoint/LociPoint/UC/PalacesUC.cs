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
    public partial class PalacesUC : UserControl
    {

        public List<Palace> palaces;
        private List<Button> edit = new List<Button>();
        private List<Button> delete = new List<Button>();
        public PalacesUC()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           
        }

        private void PalacesUC_Load(object sender, EventArgs e)
        {
            //select all palaces query
            string query = "SELECT * FROM Palaces WHERE userId = @userId";
            string[] keys = { "@userId" };
            object[] vals = { SignInUC.userId};
            palaces = Database.selectionQuery<Palace>(query, Input.generateDictionary(keys, vals));

            int y = lblPalaceName.Location.Y - 110;
            //show palaces on screen
            for (int i=0; i<palaces.Count; i++)
            {
                y += 50;
                Input.createLabel(panelPalaces, palaces[i].palaceName, lblPalaceName, y);
                
                Input.createLabel(panelPalaces, palaces[i].rooms.ToString(), lblTotalRooms, y);

                //rooms Button
                int x = lblEdit.Location.X - 70;
                Button btn = Input.createButton(panelPalaces, "Rooms", x, y);
                btn.Click += new EventHandler(btn_Click);
                edit.Add(btn);

                //delete button
                x = lblEdit.Location.X + 90;
                Button btn2 = Input.createButton(panelPalaces, "Delete", x, y);
                btn2.Click += new EventHandler(btn2_Click);
                delete.Add(btn2);

                y += 50;
            }
            
            
        }
      
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            int count = Input.getId(btn, edit);
            int palaceId = palaces[count].id;
            string palaceName = palaces[count].palaceName;

            MenuForm.changeUserControl(new PalaceUC(palaceId, palaceName));

        }
        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            int count = Input.getId(btn, delete);
            
            int palaceId = palaces[count].id;

            //delete query for palaces
            string query = "DELETE FROM Palaces WHERE id = @palaceId";
            string[] keys = { "@palaceId"};
            object[] values = { palaceId };
            Database.executeQuery(query, Input.generateDictionary(keys, values));

            //delete all rooms of palace
            query = "DELETE FROM Rooms WHERE palaceId = @palaceId";
            keys = new string[]{ "@palaceId" };
            values = new object[]{ palaceId };
            Database.executeQuery(query, Input.generateDictionary(keys, values));
            MenuForm.changeUserControl(new PalacesUC());

        }
       
    }
}
