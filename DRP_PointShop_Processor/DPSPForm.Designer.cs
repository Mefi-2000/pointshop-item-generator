namespace DRP_PointShop_Processor
{
    partial class dpspForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dpspForm));
            this.tbLua = new System.Windows.Forms.RichTextBox();
            this.bProcess = new System.Windows.Forms.Button();
            this.tbFocus = new System.Windows.Forms.TextBox();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.lDataTB = new System.Windows.Forms.Label();
            this.lStatus = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // tbLua
            // 
            this.tbLua.Location = new System.Drawing.Point(12, 146);
            this.tbLua.Name = "tbLua";
            this.tbLua.Size = new System.Drawing.Size(444, 147);
            this.tbLua.TabIndex = 5;
            this.tbLua.Text = "";
            // 
            // bProcess
            // 
            this.bProcess.BackColor = System.Drawing.SystemColors.Control;
            this.bProcess.Location = new System.Drawing.Point(12, 304);
            this.bProcess.Name = "bProcess";
            this.bProcess.Size = new System.Drawing.Size(76, 23);
            this.bProcess.TabIndex = 6;
            this.bProcess.Text = "Process";
            this.bProcess.UseVisualStyleBackColor = false;
            this.bProcess.Click += new System.EventHandler(this.bProcess_Clicked);
            // 
            // tbFocus
            // 
            this.tbFocus.Location = new System.Drawing.Point(12, 99);
            this.tbFocus.Name = "tbFocus";
            this.tbFocus.PlaceholderText = "Focus Part";
            this.tbFocus.Size = new System.Drawing.Size(204, 23);
            this.tbFocus.TabIndex = 4;
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(12, 12);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.PlaceholderText = "Item Name";
            this.tbItemName.Size = new System.Drawing.Size(204, 23);
            this.tbItemName.TabIndex = 1;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(12, 41);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PlaceholderText = "Item Description";
            this.tbDescription.Size = new System.Drawing.Size(259, 23);
            this.tbDescription.TabIndex = 2;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(12, 70);
            this.tbModel.Name = "tbModel";
            this.tbModel.PlaceholderText = "Item Model Path";
            this.tbModel.Size = new System.Drawing.Size(259, 23);
            this.tbModel.TabIndex = 3;
            // 
            // lDataTB
            // 
            this.lDataTB.AutoSize = true;
            this.lDataTB.Location = new System.Drawing.Point(12, 128);
            this.lDataTB.Name = "lDataTB";
            this.lDataTB.Size = new System.Drawing.Size(162, 15);
            this.lDataTB.TabIndex = 7;
            this.lDataTB.Text = "Item Data (from editor SWEP)";
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(94, 308);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(0, 15);
            this.lStatus.TabIndex = 8;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "lua";
            // 
            // dpspForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 339);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.lDataTB);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.tbFocus);
            this.Controls.Add(this.bProcess);
            this.Controls.Add(this.tbLua);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dpspForm";
            this.Text = "Point Shop Item Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox tbLua;
        private Button bProcess;
        private TextBox tbFocus;
        private TextBox tbItemName;
        private TextBox tbDescription;
        private TextBox tbModel;
        private Label lDataTB;
        private Label lStatus;
        private SaveFileDialog saveFileDialog;
    }
}