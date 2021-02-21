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
    public partial class CreateNewUC : UserControl
    {
     
        private static CreateNewUC _instance;
        public static CreateNewUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CreateNewUC();
                return _instance;
            }
        }
        public CreateNewUC()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //create a memory palace of x rooms
            int rooms = (int)nudRoomNum.Value;
            string name = tbName.Text;
            string range = cbNumRange.Text;
            int rangeInt = range.Contains("100") ? 100 : 10;
            if(Error.validateInputs(new string[] { name }))
            {
                if (cbType.SelectedIndex == 0)
                {
                    createPalace(rooms, name);
                }
                else
                {
                    createPAO(name, rangeInt);
                }
            }
            
            
        }
        private void createPAO(string paoName, int rangeInt)
        {
            //pao table -> id, userId, people, actions, objects

            string[] keys = { "@userId", "@people", "@actions", "@objects", "@peopleIds", "@actionsIds", "@objectsIds", "@paoName", "@range" };
            //generate array of ids
            Console.WriteLine(rangeInt);
            string peopleIds = Input.generateArrIds(rangeInt, false);
            string actionsIds = Input.generateArrIds(rangeInt, false);
            string objectsIds = Input.generateArrIds(rangeInt, false);
            Console.WriteLine(peopleIds);
            string people = Input.generateArrIds(rangeInt, true);
            string actions = Input.generateArrIds(rangeInt, true);
            string objects = Input.generateArrIds(rangeInt, true);
            string range = rangeInt.ToString();

            object[] values = { SignInUC.userId, people, actions, objects, peopleIds, actionsIds, objectsIds, paoName,range };
            string createPalace = "INSERT INTO Pao (userId, people, actions,objects,peopleIds,actionsIds,objectsIds,paoName,range) VALUES( @userId,@people,@actions,@objects,@peopleIds, @actionsIds,@objectsIds,@paoName,@range)";
            Database.executeQuery(createPalace, Input.generateDictionary(keys, values));

            MenuForm.changeUserControl(new PAOUC());

        }
        private void createPalace(int rooms, string name)
        {
            //insert memory palace
            string[] keys = { "@userId", "@palaceName" , "@rooms"};
            object[] values = { SignInUC.userId, name,rooms };
            string createPalace = "INSERT INTO Palaces (userId, palaceName, rooms) VALUES(@userId, @palaceName,@rooms)";
            Database.executeQuery(createPalace, Input.generateDictionary(keys, values));

            //get id of inserted palace
            string palaceId = getPalaceId(SignInUC.userId, name);

            //insert rooms
            string createRooms = "INSERT INTO Rooms (palaceId) VALUES(@palaceId)";
            keys = new string[] { "@palaceId" };
            values = new object[] { palaceId };
            for (int i = 0; i < rooms; i++)
            {
                Database.executeQuery(createRooms, Input.generateDictionary(keys, values));
            }
            MenuForm.changeUserControl(new PalacesUC());
           

        }
        private string getPalaceId(int userId,string palaceName)
        {
            string[] keys = {"@userId", "@palaceName"};
            object[] values = { userId, palaceName};

            string query = "SELECT id FROM Palaces WHERE userId = @userId AND palaceName =@palaceName";
            List<string> result = Database.selectionQuery<string>(query, Input.generateDictionary(keys, values));
            return(result[0]);
        }
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex == 0)
            {
                showPanel(panelPalace);
            }
            else
            {
                showPanel(panelPAO);
            }
            
            
           
        }
        private void showPanel(Panel panel)
        {
            Panel[] panels = { panelPalace, panelPAO };
            for(int i=0; i<panels.Length; i++)
            {
                panels[i].Hide();
            }
            panel.Show();
        }

        private void CreateNewUC_Load(object sender, EventArgs e)
        {
            cbType.SelectedIndex = 0;
            cbNumRange.SelectedIndex = 0;
        }
    }
}
