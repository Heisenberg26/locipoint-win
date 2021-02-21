using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LociPoint
{
    class FullScreen
    {
        Form TargetForm;

        FormWindowState PreviousWindowState;

        public FullScreen(Form targetForm)
        {
            TargetForm = targetForm;
            TargetForm.KeyPreview = true;
            TargetForm.KeyDown += TargetForm_KeyDown;
        }

        private void TargetForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F11)
            {
                Toggle();
            }
        }

        public void Toggle()
        {
            MenuForm.fullscreen = !MenuForm.fullscreen;
            if (TargetForm.WindowState == FormWindowState.Maximized)
            {
                Leave();
            }
            else
            {
                Enter();
            }
        }

        public void Enter()
        {
            if (TargetForm.WindowState != FormWindowState.Maximized)
            {
                PreviousWindowState = TargetForm.WindowState;
                TargetForm.WindowState = FormWindowState.Normal;
                TargetForm.FormBorderStyle = FormBorderStyle.None;
                TargetForm.WindowState = FormWindowState.Maximized;
            }
        }

        public void Leave()
        {
            TargetForm.FormBorderStyle = FormBorderStyle.Sizable;
            TargetForm.WindowState = PreviousWindowState;
        }
    }
}
