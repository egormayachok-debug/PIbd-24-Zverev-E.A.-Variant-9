namespace ProjectGasStation
{
    partial class FormFuelSupplyEdit
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
            label1 = new Label();
            buttonCancel = new Button();
            buttonSave = new Button();
            textBoxLiters = new TextBox();
            comboBoxSuppliers = new ComboBox();
            comboBoxFuels = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 11;
            label1.Text = "Кол-во литров";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(277, 221);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 221);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxLiters
            // 
            textBoxLiters.Location = new Point(151, 78);
            textBoxLiters.Name = "textBoxLiters";
            textBoxLiters.Size = new Size(150, 31);
            textBoxLiters.TabIndex = 8;
            // 
            // comboBoxSuppliers
            // 
            comboBoxSuppliers.FormattingEnabled = true;
            comboBoxSuppliers.Location = new Point(12, 12);
            comboBoxSuppliers.Name = "comboBoxSuppliers";
            comboBoxSuppliers.Size = new Size(182, 33);
            comboBoxSuppliers.TabIndex = 7;
            // 
            // comboBoxFuels
            // 
            comboBoxFuels.FormattingEnabled = true;
            comboBoxFuels.Location = new Point(202, 12);
            comboBoxFuels.Name = "comboBoxFuels";
            comboBoxFuels.Size = new Size(182, 33);
            comboBoxFuels.TabIndex = 6;
            // 
            // FormFuelSupplyEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 269);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxLiters);
            Controls.Add(comboBoxSuppliers);
            Controls.Add(comboBoxFuels);
            Name = "FormFuelSupplyEdit";
            Text = "FormFuelSupplyEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonCancel;
        private Button buttonSave;
        private TextBox textBoxLiters;
        private ComboBox comboBoxSuppliers;
        private ComboBox comboBoxFuels;
    }
}