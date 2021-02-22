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
    public partial class PAOSysUC : UserControl
    {
        private static Pao pao;
        private List<TextBox> people = new List<TextBox>();
        private List<TextBox> actions = new List<TextBox>();
        private List<TextBox> objects = new List<TextBox>();
        private string[] strPeople,strActions, strObjects;
        public static int paoId;

        private List<Button> edit = new List<Button>();
     
        public PAOSysUC()
        {
           
            InitializeComponent();
        }

       

        private void PAOSysUC_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Pao WHERE id= @id";
            string[] keys = new string[] { "@id"};
            object[] values = new object[] { paoId};
            List<Pao> paoList = Database.selectionQuery<Pao>(query, Input.generateDictionary(keys, values));
            pao = paoList[0];
            strPeople = Input.generateArr(pao.people,',');
            strActions = Input.generateArr(pao.actions, ',');
            strObjects = Input.generateArr(pao.objects, ',');
            Console.WriteLine(strPeople.Length);
            int y = lblEdit.Location.Y - 110;
          
            
            
            for (int i=0; i<Int32.Parse(pao.range); i++)
            {
                y += 50;

                int x = lblPerson.Location.X - 50;
                string number = i + ".";
                Input.createLabel(panel, number, x, y, 70, 40);
                

                x = lblPerson.Location.X + 20;
                TextBox tb = Input.createTb(panel, x, y, strPeople[i], 250, 90);
                this.people.Add(tb);

                x = lblAction.Location.X + 20;
                tb = Input.createTb(panel, x, y, strActions[i], 250, 90);
                this.actions.Add(tb);

                x = lblObject.Location.X + 20;
                tb = Input.createTb(panel, x, y, strObjects[i], 250, 90);
                this.objects.Add(tb);

                //edit Button
                x = lblEdit.Location.X ;
                Button btn = Input.createButton(panel, "Edit", x, y);
                btn.Click += new EventHandler(btn_Click);
                edit.Add(btn);



            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
          
            int paoId = pao.id;
            
            string peopleStr = Input.generateStr(people);
            string actionsStr = Input.generateStr(actions);
            string objectsStr = Input.generateStr(objects);
            Console.WriteLine(peopleStr);
            string[] keys = { "@people", "@actions", "@objects" , "@id"};
            object[] values = { peopleStr, actionsStr, objectsStr, paoId };

            string query = "UPDATE Pao SET people = @people, actions = @actions, objects=@objects WHERE id = @id";
            Database.executeQuery(query, Input.generateDictionary(keys, values));

            MenuForm.changeUserControl(new PAOSysUC());

        }
       
    }
}
