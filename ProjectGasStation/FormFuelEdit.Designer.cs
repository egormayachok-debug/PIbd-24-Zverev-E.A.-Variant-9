namespace ProjectGasStation
{
    partial class FormFuelEdit
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
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            textBoxDescription = new TextBox();
            comboBoxFuelType = new ComboBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 52);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 0;
            label1.Text = "Цена";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(116, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(150, 31);
            textBoxName.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(116, 49);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(150, 31);
            textBoxPrice.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(116, 86);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(325, 31);
            textBoxDescription.TabIndex = 3;
            // 
            // comboBoxFuelType
            // 
            comboBoxFuelType.FormattingEnabled = true;
            comboBoxFuelType.Location = new Point(116, 123);
            comboBoxFuelType.Name = "comboBoxFuelType";
            comboBoxFuelType.Size = new Size(182, 33);
            comboBoxFuelType.TabIndex = 4;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(333, 277);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(20, 277);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 89);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 7;
            label2.Text = "Описание";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 15);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 8;
            label3.Text = "Название";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 126);
            label4.Name = "label4";
            label4.Size = new Size(41, 25);
            label4.TabIndex = 9;
            label4.Text = "Тип";
            // 
            // FormFuelEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 323);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxFuelType);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Name = "FormFuelEdit";
            Text = "FormFuelEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private TextBox textBoxDescription;
        private ComboBox comboBoxFuelType;
        private Button buttonSave;
        private Button buttonCancel;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}