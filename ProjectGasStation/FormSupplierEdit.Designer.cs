namespace ProjectGasStation
{
    partial class FormSupplierEdit
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
            textBoxAddress = new TextBox();
            label3 = new Label();
            buttonCancel = new Button();
            buttonSave = new Button();
            textBoxName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(105, 52);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(150, 31);
            textBoxAddress.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 15);
            label3.Name = "label3";
            label3.Size = new Size(47, 25);
            label3.TabIndex = 26;
            label3.Text = "Имя";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(150, 272);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 25;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(9, 272);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 24;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(105, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(150, 31);
            textBoxName.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 52);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 21;
            label1.Text = "Адресс";
            // 
            // FormSupplierEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 318);
            Controls.Add(textBoxAddress);
            Controls.Add(label3);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Name = "FormSupplierEdit";
            Text = "FormSupplierEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAddress;
        private Label label3;
        private Button buttonCancel;
        private Button buttonSave;
        private TextBox textBoxName;
        private Label label1;
    }
}