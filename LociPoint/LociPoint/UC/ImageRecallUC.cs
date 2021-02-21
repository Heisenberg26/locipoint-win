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
    public partial class ImageRecallUC : UserControl
    {
        public bool clicked = false;
        public static List<string> recallList;
        private int index;
        public Image[] ImageList { get; set; }
        public int Amount { get; set; }
       
     
        public ImageRecallUC(Image[] imgs, int amount)
        {
            ImageList = imgs;
            Amount = amount;
            recallList = new List<string>();
            setImage();
            InitializeComponent();
        }
        
        private void panelCard_Click(object sender, EventArgs e)
        {

        }
        private void setImage()
        {
            index = 0;

        }
        private void ImageRecallUC_Load(object sender, EventArgs e)
        {
            panelCard.BackgroundImage = ImageList[index];
            lblIndex.Text = "Card No: " + (index + 1).ToString() + "/" + Amount.ToString();
            lblList.Text = string.Join(",", recallList.ToArray());
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            index--;
            if (index == -1)
            {
                index = ImageList.Length - 1;
            }
            lblIndex.Text = "Card No: " + (index + 1).ToString() + "/" + Amount.ToString();
            panelCard.BackgroundImage = ImageList[index];

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            index++;
            if (index == ImageList.Length)
            {
                index = 0;
            }
            lblIndex.Text = "Card No: " + (index + 1).ToString() + "/" + Amount.ToString();
            panelCard.BackgroundImage = ImageList[index];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            recallList.Add(index.ToString());
            lblList.Text = string.Join(",", recallList.ToArray());
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            recallList.Remove(index.ToString());
            lblList.Text = string.Join(",", recallList.ToArray());

        }
    }
}
