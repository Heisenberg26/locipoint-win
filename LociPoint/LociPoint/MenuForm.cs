using Dapper;
using LociPoint.UC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace LociPoint
{

    public partial class MenuForm : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        public static PrivateFontCollection fonts = new PrivateFontCollection();

        public static Font comforta { get; set; }
        public static Font comfortaXL { get; set; }
        public static Font comfortaL { get; set; }
        public Button ActiveButton;

        public static Panel ActivePanel;
        public static UserControl ActiveUserControl;
        UserControl[] userControls = {new DashboardUC(), new SignInUC(), new SignUpUC(),
            new ScoresUC(), new CardsUC(), new NumbersUC(), new NamesUC(), new WordsUC(),
            new PAOUC(), new PalacesUC(), new CreateNewUC(), new LearnUC()
            };

        public static Panel MenuPanel;

        public static MenuForm instance;
        FullScreen fullScreen;
        internal static bool fullscreen = false;

        public MenuForm()
        {
            InitializeComponent();
            instance = this;
            //set font data
            byte[] comfortaData = Properties.Resources.Comfortaa_Regular;
            byte[] comfortaBoldData = Properties.Resources.Comfortaa_Bold;
            System.Single mediumSize = 20.0F;
            comforta = initializeFont(comfortaData, mediumSize);
            System.Single xlargeSize = 50.0F;
            comfortaXL = initializeFont(comfortaData, xlargeSize);
            System.Single largeSize = 30.0F;
            comfortaL = initializeFont(comfortaBoldData, largeSize);
        }
        public static IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {

            fullScreen = new FullScreen(this);
            fullScreen.Toggle();
            setFontType(this, comforta, typeof(Button));
            setFontType(this, comfortaXL, typeof(Label));
            //set panel layout
            MenuPanel = panelLayout;
            changeUserControl(new SignInUC());
            SignInUC.SignInClicked += new EventHandler(SignInUC_SignInClicked);
       
        }
       
        

        private void panelLayout_Paint(object sender, PaintEventArgs e)
        {

        }
        protected void SignInUC_SignInClicked(object sender, EventArgs e)
        {
            signIn();
        }

        private void signIn()
        {
            //handle SignIn event of SignInUC
            if (SignInUC.SignedIn)
            {
                btnDashboard.Show();
                btnMemSystems.Show();
                btnPalaces.Show();
                btnPAO.Show();

                btnScores.Show();
                btnSignOut.Show();
                btnCreate.Show();
                btnSignIn.Hide();
                btnSignUp.Hide();
                toggleSubMenuVisibility(panelHomeSub, btnHome);
                toggleButtonClicked(btnDashboard);
                changeUserControl(new DashboardUC());
            }
        }
        private void signOut()
        {
            SignInUC.SignedIn = false;
            SignUpUC.SignedUp = false;
            SignInUC.userId = -1;
            btnDashboard.Hide();
            btnScores.Hide();
            btnMemSystems.Hide();
            btnPalaces.Hide();
            btnPAO.Hide();
            btnCreate.Hide();
            btnSignOut.Hide();
            btnScores.Hide();

            btnSignIn.Show();
            btnSignUp.Show();
            toggleSubMenuVisibility(panelHomeSub, btnHome);
            toggleButtonClicked(btnSignIn);
            changeUserControl(new SignInUC());
        }
        public void changeMenu(UserControl userControl)
        {
            setSelected(userControl);
            toggleSubMenuVisibility(ActivePanel, ActiveButton);
            toggleButtonClicked(ActiveButton);
            changeUserControl(userControl);
            
        }

        private void setSelected(UserControl userControl)
        {
            ActiveUserControl = userControl;

            ActivePanel = setPanel(userControl);
            ActiveButton = setButton(userControl);
            Console.WriteLine(ActivePanel.Visible);
           
        }

        private Button setButton(UserControl userControl)
        {
            Button btn = btnCards;
            UserControl[] userControls = {new CardsUC(), new NumbersUC(),
                new WordsUC(), new NamesUC(),
                new ScoresUC(),new PAOUC(), new PalacesUC()};
            Button[] btns = { btnCards, btnNumbers, btnWords, btnNames, btnScores, btnPAO, btnPalaces};
            for(int i =0; i<userControls.Length; i++)
            {
                Type type = userControls[i].GetType();
                if(userControl.GetType() == type)
                {
                    btn = btns[i];
                }
            }
            return btn;
        }

        private Panel setPanel(UserControl userControl)
        {
            Panel panel = panelHome;
            UserControl[] userControls = {new CardsUC(), new NumbersUC(),
                new WordsUC(), new NamesUC(),
                new ScoresUC(),new PAOUC(), new PalacesUC()};
            Panel[] panels = { panelMemorizeSub, panelMemorizeSub, panelMemorizeSub, panelMemorizeSub, panelHomeSub,panelSystemsSub, panelSystemsSub };
            for (int i = 0; i < userControls.Length; i++)
            {
                Type type = userControls[i].GetType();
                if (userControl.GetType() == type)
                {
                    panel = panels[i];
                }
            }
            return panel;
        }

        //Submenu buttons
        private void btnSubClicked_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Button[] btns = { btnHome, btnMemorize, btnMemSystems };
            Panel[] panels = { panelHomeSub, panelMemorizeSub, panelSystemsSub };
            int index = 0;
            for (int i = 0; i < btns.Length; i++)
            {
                if (btn == btns[i])
                {
                    index = i;
                }

            }
            Panel selected = panels[index];

            toggleSubMenuVisibility(selected, btn);
        }
        private void btnClicked_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            UserControl[] userControls = {new DashboardUC(), new SignInUC(), new SignUpUC(),
            new ScoresUC(), new CardsUC(), new NumbersUC(), new NamesUC(), new WordsUC(),
            new PAOUC(), new PalacesUC(), new CreateNewUC(), new LearnUC()
            };
            Button[] submenuBtns = {btnDashboard, btnSignIn, btnSignUp, btnScores, btnCards, btnNumbers, btnNames,
            btnWords, btnPAO, btnPalaces, btnCreate, btnLearn};
            

            int index = 0;
            for (int i = 0; i < submenuBtns.Length; i++)
            {
                if (btn == submenuBtns[i])
                {
                    index = i;
                }

            }
            toggleButtonClicked(btn);
         
            changeUserControl(userControls[index]);


        }



        private void toggleSubMenuVisibility(Panel panel, Button btn)
        {
            Button[] btns = { btnHome, btnMemorize, btnMemSystems };
            Color newColor = Color.FromArgb(67, 202, 145);
            Color original = Color.Black;

            toggleColor(btns, btn,original,newColor);
            togglePanelVisibility(panel);

        }
        private void toggleColor(Button[] btns, Button btn,Color original, Color newColor)
        {
            for (int i = 0; i < btns.Length; i++)
            {
                btns[i].BackColor = original;

            }
            btn.BackColor = newColor;
        }
        private void toggleButtonClicked(Button btn)
        {
            Button[] btns = {btnDashboard, btnSignIn, btnSignUp, btnScores, btnCards, btnNumbers, btnNames,
            btnWords, btnPAO, btnPalaces, btnCreate, btnLearn};
            Color original = Color.FromArgb(21, 22, 30);
            Color newColor = Color.FromArgb(67, 202, 145);
            toggleColor(btns, btn,original,newColor);
            ActiveButton = btn;
           
        }
        public static void setFontType(Control control, Font font, Type type) {

            //set font for all elements
            var buttons = GetAll(control, type);
            foreach (var items in buttons)
            {

                items.Font = font;

            }

        }
       
        public static Font initializeFont(byte[] fontData,  System.Single size)
        {


            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, fontData.Length);
            AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            Font myFont = new Font(fonts.Families[0], size);

            return myFont;

        }

        private void togglePanelVisibility(Panel panel)
        {
            Panel[] panels = { panelHomeSub, panelMemorizeSub, panelSystemsSub};
            for(int i=0; i<panels.Length; i++)
            {
                panels[i].Hide();
            }

            if (panel.Visible)
            {
                panel.Hide();

            }
            else
            {
                panel.Show();
            }
            ActivePanel = panel;
        }
        public static void changeUserControl(UserControl userControl)
        {
            Panel panel = MenuPanel;
            if (!panel.Controls.Contains(userControl))
            {
                panel.Controls.Add(userControl);
                userControl.Dock = DockStyle.Fill;
                userControl.BringToFront();
            }
            else
            {
                userControl.BringToFront();
            }
            ActiveUserControl = userControl;

        }
        
  
       
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            signOut();
        }

       

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 5);
            Point point1 = new Point(0, 0);
            Point point2 = new Point(0, 100);
            e.Graphics.DrawLine(blackPen, point1, point2);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            QuitForm quitForm = new QuitForm("Are you sure you want to quit?","Quit");
            quitForm.ShowDialog();
        }
    }
}
