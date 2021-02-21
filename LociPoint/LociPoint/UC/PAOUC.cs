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
    public partial class PAOUC : UserControl
    {
        public List<Pao> pao;
        private List<Button> edit = new List<Button>();
        private List<Button> delete = new List<Button>();

        public PAOUC()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
         
        }

        private void PAOUC_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Pao WHERE userId = @userId";
            string[] keys = { "@userId" };
            object[] vals = { SignInUC.userId };
            pao = Database.selectionQuery<Pao>(query, Input.generateDictionary(keys, vals));

            int y = lblSystemName.Location.Y - 110;
            //show palaces on screen
            for (int i = 0; i < pao.Count; i++)
            {
                y += 50;
                Input.createLabel(panel, pao[i].paoName, lblSystemName, y);

                Input.createLabel(panel, pao[i].range, lblRange, y);

                //rooms Button
                int x = lblEdit.Location.X - 70;
                Button btn = Input.createButton(panel, "View", x, y);
                btn.Click += new EventHandler(btn_Click);
                edit.Add(btn);

                //delete button
                x = lblEdit.Location.X + 90;
                Button btn2 = Input.createButton(panel, "Delete", x, y);
                btn2.Click += new EventHandler(btn2_Click);
                delete.Add(btn2);

                y += 50;
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            int count = Input.getId(btn, edit);
     
       
            PAOSysUC.paoId = pao[count].id;
            MenuForm.changeUserControl(new PAOSysUC());

        }
        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            int count = Input.getId(btn, delete);

            int paoId = pao[count].id;

            //delete query for palaces
            string query = "DELETE FROM Pao WHERE id = @paoId";
            string[] keys = { "@paoId" };
            object[] values = { paoId };
            Database.executeQuery(query, Input.generateDictionary(keys, values));

          
            MenuForm.changeUserControl(new PAOUC());

        }
    }
}
