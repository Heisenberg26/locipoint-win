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
        public static Panel MenuPanel;
        FullScreen fullScreen;
        internal static bool fullscreen = false;

        public MenuForm()
        {
            InitializeComponent();

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
      
        private void btnHome_Click(object sender, EventArgs e)
        {
            toggleSubMenuVisibility(panelHomeSub, btnHome);
        }
        private void btnMemorize_Click(object sender, EventArgs e)
        {
            toggleSubMenuVisibility(panelMemorizeSub, btnMemorize);
        }

        private void btnMemSystems_Click(object sender, EventArgs e)
        {
            toggleSubMenuVisibility(panelSystemsSub, btnMemSystems);
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

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            toggleButtonClicked(btnDashboard);

            changeUserControl(new DashboardUC());
            SignInUC.comforta = comforta;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            toggleButtonClicked(btnSignIn);
            changeUserControl(new SignInUC());
            SignInUC.SignInClicked += new EventHandler(SignInUC_SignInClicked);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            toggleButtonClicked(btnSignUp);
            changeUserControl(SignUpUC.Instance);
            

        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            toggleButtonClicked(btnScores);
            changeUserControl(new ScoresUC());
        }

        private void btnCards_Click(object sender, EventArgs e)
        {
            toggleButtonClicked(btnCards);
            changeUserControl(CardsUC.Instance);
        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            toggleButtonClicked(btnNumbers);
            changeUserControl(NumbersUC.Instance);
        }

        private void btnWords_Click(object sender, EventArgs e)
        {
            toggleButtonClicked(btnWords);
            changeUserControl(WordsUC.Instance);
        }

        private void btnNames_Click(object sender, EventArgs e)
        {
            toggleButtonClicked(btnNames);
            changeUserControl(NamesUC.Instance);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            toggleButtonClicked(btnCreate);
            changeUserControl(CreateNewUC.Instance);
        }

        private void btnSystems_Click(object sender, EventArgs e)
        {
            toggleButtonClicked(btnPalaces);
            changeUserControl(new PalacesUC());
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            toggleButtonClicked(btnLearn);
            changeUserControl(LearnUC.Instance);
        }

        private void panelLayout_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnPAO_Click(object sender, EventArgs e)
        {
            toggleButtonClicked(btnPAO);
            changeUserControl(new PAOUC());
        }

       
        private void btnSignOut_Click(object sender, EventArgs e)
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

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 5);
            Point point1 = new Point(0, 0);
            Point point2 = new Point(0, 100);
            e.Graphics.DrawLine(blackPen, point1, point2);
        }

        private void MenuForm_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void MenuForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
