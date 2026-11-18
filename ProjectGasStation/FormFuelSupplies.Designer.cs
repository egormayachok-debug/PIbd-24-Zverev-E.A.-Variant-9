namespace ProjectGasStation
{
    partial class FormFuelSupplies
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
            buttonDelete = new Button();
            buttonAdd = new Button();
            dataGridViewSupplies = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSupplies).BeginInit();
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(137, 8);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(112, 34);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(19, 8);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 34);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridViewSupplies
            // 
            dataGridViewSupplies.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewSupplies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSupplies.Location = new Point(6, 48);
            dataGridViewSupplies.Name = "dataGridViewSupplies";
            dataGridViewSupplies.RowHeadersWidth = 62;
            dataGridViewSupplies.Size = new Size(789, 395);
            dataGridViewSupplies.TabIndex = 4;
            // 
            // FormFuelSupplies
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewSupplies);
            Name = "FormFuelSupplies";
            Text = "FormFuelSupplies";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSupplies).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDelete;
        private Button buttonAdd;
        private DataGridView dataGridViewSupplies;
    }
}