namespace ProjectGasStation
{
    partial class FormGasStation
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
            menuStrip1 = new MenuStrip();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            топливоToolStripMenuItem = new ToolStripMenuItem();
            продавцыToolStripMenuItem = new ToolStripMenuItem();
            поставщикиToolStripMenuItem = new ToolStripMenuItem();
            операцииToolStripMenuItem = new ToolStripMenuItem();
            продажиТопливаToolStripMenuItem = new ToolStripMenuItem();
            поставкиТопливаToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { справочникиToolStripMenuItem, операцииToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { топливоToolStripMenuItem, продавцыToolStripMenuItem, поставщикиToolStripMenuItem });
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(139, 29);
            справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // топливоToolStripMenuItem
            // 
            топливоToolStripMenuItem.Name = "топливоToolStripMenuItem";
            топливоToolStripMenuItem.Size = new Size(270, 34);
            топливоToolStripMenuItem.Text = "Топливо";
            топливоToolStripMenuItem.Click += топливоToolStripMenuItem_Click;
            // 
            // продавцыToolStripMenuItem
            // 
            продавцыToolStripMenuItem.Name = "продавцыToolStripMenuItem";
            продавцыToolStripMenuItem.Size = new Size(270, 34);
            продавцыToolStripMenuItem.Text = "Продавцы";
            продавцыToolStripMenuItem.Click += продавцыToolStripMenuItem_Click;
            // 
            // поставщикиToolStripMenuItem
            // 
            поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            поставщикиToolStripMenuItem.Size = new Size(270, 34);
            поставщикиToolStripMenuItem.Text = "Поставщики";
            поставщикиToolStripMenuItem.Click += поставщикиToolStripMenuItem_Click;
            // 
            // операцииToolStripMenuItem
            // 
            операцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { продажиТопливаToolStripMenuItem, поставкиТопливаToolStripMenuItem });
            операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            операцииToolStripMenuItem.Size = new Size(112, 29);
            операцииToolStripMenuItem.Text = "Операции";
            // 
            // продажиТопливаToolStripMenuItem
            // 
            продажиТопливаToolStripMenuItem.Name = "продажиТопливаToolStripMenuItem";
            продажиТопливаToolStripMenuItem.Size = new Size(270, 34);
            продажиТопливаToolStripMenuItem.Text = "Продажи топлива";
            продажиТопливаToolStripMenuItem.Click += продажиТопливаToolStripMenuItem_Click;
            // 
            // поставкиТопливаToolStripMenuItem
            // 
            поставкиТопливаToolStripMenuItem.Name = "поставкиТопливаToolStripMenuItem";
            поставкиТопливаToolStripMenuItem.Size = new Size(270, 34);
            поставкиТопливаToolStripMenuItem.Text = "Поставки топлива";
            поставкиТопливаToolStripMenuItem.Click += поставкиТопливаToolStripMenuItem_Click;
            // 
            // FormGasStation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormGasStation";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem топливоToolStripMenuItem;
        private ToolStripMenuItem продавцыToolStripMenuItem;
        private ToolStripMenuItem поставщикиToolStripMenuItem;
        private ToolStripMenuItem операцииToolStripMenuItem;
        private ToolStripMenuItem продажиТопливаToolStripMenuItem;
        private ToolStripMenuItem поставкиТопливаToolStripMenuItem;
    }
}
