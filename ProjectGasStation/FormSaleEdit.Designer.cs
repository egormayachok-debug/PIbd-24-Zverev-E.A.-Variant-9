namespace ProjectGasStation
{
    partial class FormSaleEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxSellers = new ComboBox();
            comboBoxFuels = new ComboBox();
            textBoxLiters = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBoxSellers
            // 
            comboBoxSellers.FormattingEnabled = true;
            comboBoxSellers.Location = new Point(202, 12);
            comboBoxSellers.Name = "comboBoxSellers";
            comboBoxSellers.Size = new Size(182, 33);
            comboBoxSellers.TabIndex = 0;
            // 
            // comboBoxFuels
            // 
            comboBoxFuels.FormattingEnabled = true;
            comboBoxFuels.Location = new Point(12, 12);
            comboBoxFuels.Name = "comboBoxFuels";
            comboBoxFuels.Size = new Size(182, 33);
            comboBoxFuels.TabIndex = 1;
            // 
            // textBoxLiters
            // 
            textBoxLiters.Location = new Point(151, 78);
            textBoxLiters.Name = "textBoxLiters";
            textBoxLiters.Size = new Size(150, 31);
            textBoxLiters.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 221);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(277, 221);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 5;
            label1.Text = "Кол-во литров";
            // 
            // FormSaleEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 267);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxLiters);
            Controls.Add(comboBoxFuels);
            Controls.Add(comboBoxSellers);
            Name = "FormSaleEdit";
            Text = "FormSaleEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxSellers;
        private ComboBox comboBoxFuels;
        private TextBox textBoxLiters;
        private Button buttonSave;
        private Button buttonCancel;
        private Label label1;
    }
}