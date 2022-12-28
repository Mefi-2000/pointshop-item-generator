using System.Text.RegularExpressions;

namespace DRP_PointShop_Processor
{
    public partial class dpspForm : Form
    {
        public dpspForm()
        {
            InitializeComponent();
        }

        private void bProcess_Clicked(object sender, EventArgs e)
        {
            saveFileDialog.FileName = $"{Regex.Replace(tbItemName.Text, " ", "_").ToLower()}_ps.lua";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bool itemCreated = new PointShopItem(tbItemName.Text, tbDescription.Text, tbModel.Text, tbFocus.Text, tbLua.Text).createFile(saveFileDialog.FileName);

                if (itemCreated)
                {
                    lStatus.Text = "Success! Exported to items directory.";
                }
                else
                {
                    lStatus.Text = "Failed to output to file.";
                }
            }

        }
    }
}