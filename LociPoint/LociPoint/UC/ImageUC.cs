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
    public partial class ImageUC : UserControl { 
    public bool clicked;
    private int index;
    public Image[] ImageList { get; set; }
    public int Amount { get; set; }
    public ImageUC(Image[] images, int amount)
    {
        ImageList = images;
        Amount = amount;
        setImage();
        InitializeComponent();
    }
    private void setImage()
    {
        index = 0;

    }

    private void btnNext_Click(object sender, EventArgs e)
    {
            index++;
            if (index == ImageList.Length)
            {
                index = 0;
            }
            lblImage.Text = "Card No: " + (index + 1).ToString() + "/" + Amount.ToString();
            panelCard.BackgroundImage = ImageList[index];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            index--;
            if (index == -1)
            {
                index = ImageList.Length - 1;
            }
            lblImage.Text = "Card No: " + (index + 1).ToString() + "/" + Amount.ToString();
            panelCard.BackgroundImage = ImageList[index];
        }

        private void ImageUC_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < Amount; i++)
            {
                imageList.Images.Add(ImageList[i]);
            }
                Console.WriteLine(imageList);

            lblImage.Text = "Card No: " + (index + 1).ToString() + "/" + Amount.ToString();
            panelCard.BackgroundImage = ImageList[index];
        }
}
}
