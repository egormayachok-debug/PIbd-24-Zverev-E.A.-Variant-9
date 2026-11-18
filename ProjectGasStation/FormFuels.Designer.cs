namespace ProjectGasStation
{
    partial class FormFuels
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
            dataGridViewFuels = new DataGridView();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuels).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFuels
            // 
            dataGridViewFuels.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewFuels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuels.Location = new Point(-1, 52);
            dataGridViewFuels.Name = "dataGridViewFuels";
            dataGridViewFuels.RowHeadersWidth = 62;
            dataGridViewFuels.Size = new Size(789, 395);
            dataGridViewFuels.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 34);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(130, 12);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(112, 34);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(248, 12);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(112, 34);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // FormFuels
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewFuels);
            Name = "FormFuels";
            Text = "FormFuels";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuels).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewFuels;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
    }
}